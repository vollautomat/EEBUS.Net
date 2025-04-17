<template>
	<h1>EEBUS EMS Adapter</h1>
	<div>
		<div class="header-frame">
			<div class="header" v-if="local">
				<div class="table2c">
					<p>Local Device</p>
					<p>{{ local.name }}</p>
					<p>Local SKI</p>
					<p>{{ local.ski }}</p>
					<p>Ship ID</p>
					<p class="qrcode-text">{{ local.shipId }}</p>
				</div>
				<div v-if="'' < local.shipId">
					<qrcode-vue  class="qrcode" :value="local.shipId" :size="130" level="H" render-as="svg" />
				</div>
			</div>
			<div v-else>
				<p>No local device found</p>
			</div>
		</div>

		<hr />

		<div v-for="remote in remotes">
			<br />
			<div class="table2c">
				<p>ID</p>
				<p>{{ remote.id }}</p>
				<p>Name</p>
				<p>{{ remote.name }}</p>
				<p>SKI</p>
				<p>{{ remote.ski }}</p>
				<p>Server state</p>
				<p>{{ remote.serverState ?? 'unknown' }}</p>
				<p>Client state</p>
				<p>{{ remote.clientState ?? 'unknown' }}</p>
			</div>
			<button @click="connect( remote )">Connect</button>
		</div>
	</div>
</template>

<script lang="ts">
	import { Component, Vue, Watch, toNative } from 'vue-facing-decorator'
	import QrcodeVue from 'qrcode.vue'

	interface Device {
		id:			 string;
		name:		 string;
		ski:		 string;
		serverState: string;
		clientState: string;
	}

	interface LocalDevice extends Device {
		url:	string;
		shipId:	string;
	}

	interface PushData {
		cmd:  string;
		data: any;
	}

	type pushFunction = (data: any) => void;

	@Component( {
		components: {
			QrcodeVue
		}
	} )
	export class EEBUS extends Vue {
		private connection: WebSocket | null = null;
		private timerId: any;

		public local:	LocalDevice | undefined	= undefined;
		public remotes:	Device[]				= [];

		@Watch('$route')
		routeWatcher( newVal: any, oldVal: any ) {
			this.fetchData();
		}

		async created() {
			// fetch the data when the view is created and the data is
			// already being observed
			await this.fetchData();
		}

		mounted() {
			this.connectPushService();

			document.addEventListener( "visibilitychange", () => {
				if ( document.hidden ) {
					this.disappear();
				} else {
					this.connectPushService();
				}
			} );
		}

		protected disappear() {
			clearInterval( this.timerId );
			if ( null != this.connection ) {
				this.connection.close();

				setTimeout( () => {
					this.connection = null;
				}, 1000 );
			}
		}

		private async fetchData() {
			var response = await fetch( 'https://localhost:7134/devices/getlocal' );
			if ( response.ok ) {
				this.local = await response.json();
			}

			response = await fetch('https://localhost:7134/devices/getremotes');
			if ( response.ok ) {
				this.remotes = await response.json();
			}
		}

		private connectPushService() {
			if ( null != this.connection )
				return;

			this.connection = new WebSocket( "wss://localhost:7134/ws/register" );

			let _this: EEBUS = this;

			this.timerId = setInterval( function() {
				if ( null == _this.connection ) {
					_this.connectPushService();
				}
			}, 1000 );

			if ( null == this.connection )
				return;

			this.connection.onmessage = function( event ) {

				let data = JSON.parse( event.data ) as PushData;

				var fct: pushFunction = (_this as any)[data.cmd] as pushFunction;
				if ( fct ) {
					fct( data.data );
				}
			}

			this.connection.onopen = function( event ) {
				console.log( "Successfully connected to the websocket server..." )
				console.log( event )
			}

			this.connection.onclose = function( event ) {
				console.log( "Connection to the websocket server closed..." )
				console.log( event );

				_this.connection = null;
			}

			this.connection.onerror = function( event ) {
				console.log( "Error with websocket server..." )
				console.log( event );

				_this.connection = null;
			}
		}

		public async connect( remote: Device ) {
			await fetch( 'https://localhost:7134/devices/connect?ski=' + remote.ski );
		}

		public remoteDeviceFound( data: any ) {
			this.remotes.push( {
				id:			 data.id,
				name:		 data.name,
				ski:		 data.ski,
				serverState: data.serverState,
				clientState: data.clientState,
			} as Device );
		}

		public serverStateChanged( data: any ) {
			var device = this.remotes.find( rd => rd.id == data.id );
			if ( device )
				device.serverState = data.state;
		}

		public clientStateChanged( data: any ) {
			var device = this.remotes.find( rd => rd.id == data.id );
			if ( device )
				device.clientState = data.state;
		}
	}

	export default toNative( EEBUS );
</script>

<style scoped>
	.header-frame {
	display: inline-table;
	margin-bottom: 10px;
	}

	.header {
	display: grid;
	grid-template-columns: 200fr 25fr;
	column-gap: 25px;
	}

	.qrcode-text {
	width: 370px;
	text-align: left;
	word-break: break-all;
	}

	.qrcode {
	width: 130px;
	height: 100%;
	}

	.table2c {
	display: grid;
	grid-template-columns: 100px 1fr;
	column-gap: 5px;
	}

</style>
