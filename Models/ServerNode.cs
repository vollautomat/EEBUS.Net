﻿
using System;

namespace EEBUS.Models
{
    public class ServerNodes
    {
		public string LocalSKI { get; set; }

		public ServerNode[] Nodes { get; set; }
	}

    public class ServerNode
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string SKI { get; set; }

        public string Id { get; set; }

        public string Error { get; set; }

        public string LatestDataReceived { get; set; }

        public string LocalSKI { get; set; }

		public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ServerNode org = (ServerNode)obj;
                return Url.Equals(org.Url, StringComparison.Ordinal);
            }
        }

        public override int GetHashCode()
        {
            return Url.GetHashCode(StringComparison.Ordinal);
        }
    }
}
