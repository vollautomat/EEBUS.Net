﻿/*
/// <remarks/>
[System.SerializableAttribute()]
public partial class ActuatorLevelDataType {
    
    /// <remarks/>
    public string function { get; set; }
    
    /// <remarks/>
    public ScaledNumberType value { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
public partial class ScaledNumberType {
    
    /// <remarks/>
    public long number { get; set; }
    
    /// <remarks/>
    public bool numberSpecified { get; set; }
    
    /// <remarks/>
    public short scale { get; set; }
    
    /// <remarks/>
    public bool scaleSpecified { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
public partial class CmdType {
    
    /// <remarks/>
    public string function { get; set; }
    
    /// <remarks/>
    public FilterType[] filter { get; set; }
    
    /// <remarks/>
    public ActuatorLevelDataType actuatorLevelData { get; set; }
    
    /// <remarks/>
    public ActuatorLevelDescriptionDataType actuatorLevelDescriptionData { get; set; }
    
    /// <remarks/>
    public ActuatorSwitchDataType actuatorSwitchData { get; set; }
    
    /// <remarks/>
    public ActuatorSwitchDescriptionDataType actuatorSwitchDescriptionData { get; set; }
    
    /// <remarks/>
    public AlarmDataType[] alarmListData { get; set; }
	
    /// <remarks/>
    public BillConstraintsDataType[] billConstraintsListData { get; set; }
	
    /// <remarks/>
    public BillDescriptionDataType[] billDescriptionListData { get; set; }
    
    /// <remarks/>
    public BillDataType[] billListData { get; set; }
    
    /// <remarks/>
    public BindingManagementDeleteCallType bindingManagementDeleteCall { get; set; }
    
    /// <remarks/>
    public BindingManagementEntryDataType[] bindingManagementEntryListData { get; set; }
    
    /// <remarks/>
    public BindingManagementRequestCallType bindingManagementRequestCall { get; set; }
    
    /// <remarks/>
    public CommodityDataType[] commodityListData { get; set; }
    
    /// <remarks/>
    public DataTunnelingCallType dataTunnelingCall { get; set; }
    
    /// <remarks/>
    public DeviceClassificationManufacturerDataType deviceClassificationManufacturerData { get; set; }
    
    /// <remarks/>
    public DeviceClassificationUserDataType deviceClassificationUserData { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueConstraintsDataType[] deviceConfigurationKeyValueConstraintsListData { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueDescriptionDataType[] deviceConfigurationKeyValueDescriptionListData { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueDataType[] deviceConfigurationKeyValueListData { get; set; }
    
    /// <remarks/>
    public DeviceDiagnosisHeartbeatDataType deviceDiagnosisHeartbeatData { get; set; }
    
    /// <remarks/>
    public DeviceDiagnosisServiceDataType deviceDiagnosisServiceData { get; set; }
	
    /// <remarks/>
    public DeviceDiagnosisStateDataType deviceDiagnosisStateData { get; set; }
    
    /// <remarks/>
    public DirectControlActivityDataType[] directControlActivityListData { get; set; }
    
    /// <remarks/>
    public DirectControlDescriptionDataType directControlDescriptionData { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionDescriptionDataType[] electricalConnectionDescriptionListData { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionParameterDescriptionDataType[] electricalConnectionParameterDescriptionListData { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionPermittedValueSetDataType[] electricalConnectionPermittedValueSetListData { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionStateDataType[] electricalConnectionStateListData { get; set; }
	
    /// <remarks/>
    public HvacOperationModeDescriptionDataType[] hvacOperationModeDescriptionListData { get; set; }
    
    /// <remarks/>
    public HvacOverrunDescriptionDataType[] hvacOverrunDescriptionListData { get; set; }
    
    /// <remarks/>
    public HvacOverrunDataType[] hvacOverrunListData { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionDescriptionDataType[] hvacSystemFunctionDescriptionListData { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionDataType[] hvacSystemFunctionListData { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionOperationModeRelationDataType[] hvacSystemFunctionOperationModeRelationListData { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionPowerSequenceRelationDataType[] hvacSystemFunctionPowerSequenceRelationListData { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionSetpointRelationDataType[] hvacSystemFunctionSetpointRelationListData { get; set; }
    
    /// <remarks/>
    public IdentificationDataType[] identificationListData { get; set; }
    
    /// <remarks/>
    public IncentiveDescriptionDataType[] incentiveDescriptionListData { get; set; }
    
    /// <remarks/>
    public IncentiveDataType[] incentiveListData { get; set; }
    
    /// <remarks/>
    public IncentiveTableConstraintsType[] incentiveTableConstraintsData { get; set; }
    
    /// <remarks/>
    public IncentiveTableType[] incentiveTableData { get; set; }
    
    /// <remarks/>
    public IncentiveTableDescriptionType[] incentiveTableDescriptionData { get; set; }
    
    /// <remarks/>
    public LoadControlEventDataType[] loadControlEventListData { get; set; }
    
    /// <remarks/>
    public LoadControlLimitConstraintsDataType[] loadControlLimitConstraintsListData { get; set; }
    
    /// <remarks/>
    public LoadControlLimitDescriptionDataType[] loadControlLimitDescriptionListData { get; set; }
    
    /// <remarks/>
    public LoadControlLimitDataType[] loadControlLimitListData { get; set; }
    
    /// <remarks/>
    public LoadControlNodeDataType loadControlNodeData { get; set; }
    
    /// <remarks/>
    public LoadControlStateDataType[] loadControlStateListData { get; set; }
    
    /// <remarks/>
    public MeasurementConstraintsDataType[] measurementConstraintsListData { get; set; }
	
    /// <remarks/>
    public MeasurementDescriptionDataType[] measurementDescriptionListData { get; set; }
    
    /// <remarks/>
    public MeasurementDataType[] measurementListData { get; set; }
    
    /// <remarks/>
    public MeasurementThresholdRelationDataType[] measurementThresholdRelationListData { get; set; }
    
    /// <remarks/>
    public MessagingDataType[] messagingListData { get; set; }
    
    /// <remarks/>
    public NetworkManagementAbortCallType networkManagementAbortCall { get; set; }
    
    /// <remarks/>
    public NetworkManagementAddNodeCallType networkManagementAddNodeCall { get; set; }
    
    /// <remarks/>
    public NetworkManagementDeviceDescriptionDataType[] networkManagementDeviceDescriptionListData { get; set; }
    
    /// <remarks/>
    public NetworkManagementDiscoverCallType networkManagementDiscoverCall { get; set; }
    
    /// <remarks/>
    public NetworkManagementEntityDescriptionDataType[] networkManagementEntityDescriptionListData { get; set; }
    
    /// <remarks/>
    public NetworkManagementFeatureDescriptionDataType[] networkManagementFeatureDescriptionListData { get; set; }
    
    /// <remarks/>
    public NetworkManagementJoiningModeDataType networkManagementJoiningModeData { get; set; }
    
    /// <remarks/>
    public NetworkManagementModifyNodeCallType networkManagementModifyNodeCall { get; set; }
    
    /// <remarks/>
    public NetworkManagementProcessStateDataType networkManagementProcessStateData { get; set; }
    
    /// <remarks/>
    public NetworkManagementRemoveNodeCallType networkManagementRemoveNodeCall { get; set; }
    
    /// <remarks/>
    public NetworkManagementReportCandidateDataType networkManagementReportCandidateData { get; set; }
    
    /// <remarks/>
    public NetworkManagementScanNetworkCallType networkManagementScanNetworkCall { get; set; }
    
    /// <remarks/>
    public NodeManagementBindingDataTypeBindingEntry[] nodeManagementBindingData { get; set; }
    
    /// <remarks/>
    public NodeManagementBindingDeleteCallType nodeManagementBindingDeleteCall { get; set; }
    
    /// <remarks/>
    public NodeManagementBindingRequestCallType nodeManagementBindingRequestCall { get; set; }
    
    /// <remarks/>
    public NodeManagementDestinationDataType[] nodeManagementDestinationListData { get; set; }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDataType nodeManagementDetailedDiscoveryData { get; set; }
    
    /// <remarks/>
    public NodeManagementSubscriptionDataTypeSubscriptionEntry[] nodeManagementSubscriptionData { get; set; }
	
    /// <remarks/>
    public NodeManagementSubscriptionDeleteCallType nodeManagementSubscriptionDeleteCall { get; set; }
    
    /// <remarks/>
    public NodeManagementSubscriptionRequestCallType nodeManagementSubscriptionRequestCall { get; set; }
    
    /// <remarks/>
    public NodeManagementUseCaseDataTypeUseCaseInformation[] nodeManagementUseCaseData { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsDurationDataType[] operatingConstraintsDurationListData { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsInterruptDataType[] operatingConstraintsInterruptListData { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerDescriptionDataType[] operatingConstraintsPowerDescriptionListData { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerLevelDataType[] operatingConstraintsPowerLevelListData { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerRangeDataType[] operatingConstraintsPowerRangeListData { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsResumeImplicationDataType[] operatingConstraintsResumeImplicationListData { get; set; }
    
    /// <remarks/>
    public PowerSequenceAlternativesRelationDataType[] powerSequenceAlternativesRelationListData { get; set; }
    
    /// <remarks/>
    public PowerSequenceDescriptionDataType[] powerSequenceDescriptionListData { get; set; }
    
    /// <remarks/>
    public PowerSequenceNodeScheduleInformationDataType powerSequenceNodeScheduleInformationData { get; set; }
    
    /// <remarks/>
    public PowerSequencePriceCalculationRequestCallType powerSequencePriceCalculationRequestCall { get; set; }
    
    /// <remarks/>
    public PowerSequencePriceDataType[] powerSequencePriceListData { get; set; }
    
    /// <remarks/>
    public PowerSequenceScheduleConfigurationRequestCallType powerSequenceScheduleConfigurationRequestCall { get; set; }
    
    /// <remarks/>
    public PowerSequenceScheduleConstraintsDataType[] powerSequenceScheduleConstraintsListData { get; set; }
    
    /// <remarks/>
    public PowerSequenceScheduleDataType[] powerSequenceScheduleListData { get; set; }
    
    /// <remarks/>
    public PowerSequenceSchedulePreferenceDataType[] powerSequenceSchedulePreferenceListData { get; set; }
    
    /// <remarks/>
    public PowerSequenceStateDataType[] powerSequenceStateListData { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotScheduleConstraintsDataType[] powerTimeSlotScheduleConstraintsListData { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotScheduleDataType[] powerTimeSlotScheduleListData { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotValueDataType[] powerTimeSlotValueListData { get; set; }
    
    /// <remarks/>
    public ResultDataType resultData { get; set; }
    
    /// <remarks/>
    public SensingDescriptionDataType sensingDescriptionData { get; set; }
    
    /// <remarks/>
    public SensingDataType[] sensingListData { get; set; }
    
    /// <remarks/>
    public SetpointConstraintsDataType[] setpointConstraintsListData { get; set; }
    
    /// <remarks/>
    public SetpointDescriptionDataType[] setpointDescriptionListData { get; set; }
    
    /// <remarks/>
    public SetpointDataType[] setpointListData { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsConfigurationRequestCallType smartEnergyManagementPsConfigurationRequestCall { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsDataType smartEnergyManagementPsData { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceCalculationRequestCallType smartEnergyManagementPsPriceCalculationRequestCall { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceDataTypePrice[] smartEnergyManagementPsPriceData { get; set; }
    
    /// <remarks/>
    public SpecificationVersionDataType[] specificationVersionListData { get; set; }
    
    /// <remarks/>
    public SubscriptionManagementDeleteCallType subscriptionManagementDeleteCall { get; set; }
    
    /// <remarks/>
    public SubscriptionManagementEntryDataType[] subscriptionManagementEntryListData { get; set; }
    
    /// <remarks/>
    public SubscriptionManagementRequestCallType subscriptionManagementRequestCall { get; set; }
    
    /// <remarks/>
    public SupplyConditionDescriptionDataType[] supplyConditionDescriptionListData { get; set; }
    
    /// <remarks/>
    public SupplyConditionDataType[] supplyConditionListData { get; set; }
    
    /// <remarks/>
    public SupplyConditionThresholdRelationDataType[] supplyConditionThresholdRelationListData { get; set; }
    
    /// <remarks/>
    public TariffBoundaryRelationDataType[] tariffBoundaryRelationListData { get; set; }
    
    /// <remarks/>
    public TariffDescriptionDataType[] tariffDescriptionListData { get; set; }
    
    /// <remarks/>
    public TariffDataType[] tariffListData { get; set; }
    
    /// <remarks/>
    public TariffOverallConstraintsDataType tariffOverallConstraintsData { get; set; }
    
    /// <remarks/>
    public TariffTierRelationDataType[] tariffTierRelationListData { get; set; }
    
    /// <remarks/>
    public TaskManagementJobDescriptionDataType[] taskManagementJobDescriptionListData { get; set; }
    
    /// <remarks/>
    public TaskManagementJobDataType[] taskManagementJobListData { get; set; }
    
    /// <remarks/>
    public TaskManagementJobRelationDataType[] taskManagementJobRelationListData { get; set; }
    
    /// <remarks/>
    public TaskManagementOverviewDataType taskManagementOverviewData { get; set; }
    
    /// <remarks/>
    public ThresholdConstraintsDataType[] thresholdConstraintsListData { get; set; }
    
    /// <remarks/>
    public ThresholdDescriptionDataType[] thresholdDescriptionListData { get; set; }
    
    /// <remarks/>
    public ThresholdDataType[] thresholdListData { get; set; }
    
    /// <remarks/>
    public TierBoundaryDescriptionDataType[] tierBoundaryDescriptionListData { get; set; }
    
    /// <remarks/>
    public TierBoundaryDataType[] tierBoundaryListData { get; set; }
    
    /// <remarks/>
    public TierDescriptionDataType[] tierDescriptionListData { get; set; }
    
    /// <remarks/>
    public TierIncentiveRelationDataType[] tierIncentiveRelationListData { get; set; }
    
    /// <remarks/>
    public TierDataType[] tierListData { get; set; }
    
    /// <remarks/>
    public TimeDistributorDataType timeDistributorData { get; set; }
    
    /// <remarks/>
    public TimeDistributorEnquiryCallType timeDistributorEnquiryCall { get; set; }
    
    /// <remarks/>
    public TimeInformationDataType timeInformationData { get; set; }
    
    /// <remarks/>
    public TimePrecisionDataType timePrecisionData { get; set; }
    
    /// <remarks/>
    public TimeSeriesConstraintsDataType[] timeSeriesConstraintsListData { get; set; }
    
    /// <remarks/>
    public TimeSeriesDescriptionDataType[] timeSeriesDescriptionListData { get; set; }
    
    /// <remarks/>
    public TimeSeriesDataType[] timeSeriesListData { get; set; }
    
    /// <remarks/>
    public TimeTableConstraintsDataType[] timeTableConstraintsListData { get; set; }
    
    /// <remarks/>
    public TimeTableDescriptionDataType[] timeTableDescriptionListData { get; set; }
    
    /// <remarks/>
    public TimeTableDataType[] timeTableListData { get; set; }
    
    /// <remarks/>
    public UseCaseInformationDataType[] useCaseInformationListData { get; set; }
    
    /// <remarks/>
    public byte[] manufacturerSpecificExtension { get; set; }
    
    /// <remarks/>
    public string lastUpdateAt { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
public partial class FilterType {
    
    //private uint filterIdField;
    
    //private bool filterIdFieldSpecified;
    
    //private CmdControlType cmdControlField;
    
    //private AlarmListDataSelectorsType[] alarmListDataSelectorsField;
    
    //private BillConstraintsListDataSelectorsType[] billConstraintsListDataSelectorsField;
    
    //private BillDescriptionListDataSelectorsType[] billDescriptionListDataSelectorsField;
    
    //private BillListDataSelectorsType[] billListDataSelectorsField;
    
    //private BindingManagementEntryListDataSelectorsType[] bindingManagementEntryListDataSelectorsField;
    
    //private CommodityListDataSelectorsType[] commodityListDataSelectorsField;
    
    //private DeviceConfigurationKeyValueConstraintsListDataSelectorsType[] deviceConfigurationKeyValueConstraintsListDataSelectorsField;
    
    //private DeviceConfigurationKeyValueDescriptionListDataSelectorsType[] deviceConfigurationKeyValueDescriptionListDataSelectorsField;
    
    //private DeviceConfigurationKeyValueListDataSelectorsType[] deviceConfigurationKeyValueListDataSelectorsField;
    
    //private DirectControlActivityListDataSelectorsType[] directControlActivityListDataSelectorsField;
    
    //private ElectricalConnectionDescriptionListDataSelectorsType[] electricalConnectionDescriptionListDataSelectorsField;
    
    //private ElectricalConnectionParameterDescriptionListDataSelectorsType[] electricalConnectionParameterDescriptionListDataSelectorsField;
    
    //private ElectricalConnectionPermittedValueSetListDataSelectorsType[] electricalConnectionPermittedValueSetListDataSelectorsField;
    
    //private ElectricalConnectionStateListDataSelectorsType[] electricalConnectionStateListDataSelectorsField;
    
    //private HvacOperationModeDescriptionListDataSelectorsType[] hvacOperationModeDescriptionListDataSelectorsField;
    
    //private HvacOverrunDescriptionListDataSelectorsType[] hvacOverrunDescriptionListDataSelectorsField;
    
    //private HvacOverrunListDataSelectorsType[] hvacOverrunListDataSelectorsField;
    
    //private HvacSystemFunctionDescriptionListDataSelectorsType[] hvacSystemFunctionDescriptionListDataSelectorsField;
    
    //private HvacSystemFunctionListDataSelectorsType[] hvacSystemFunctionListDataSelectorsField;
    
    //private HvacSystemFunctionOperationModeRelationListDataSelectorsType[] hvacSystemFunctionOperationModeRelationListDataSelectorsField;
    
    //private HvacSystemFunctionPowerSequenceRelationListDataSelectorsType[] hvacSystemFunctionPowerSequenceRelationListDataSelectorsField;
    
    //private HvacSystemFunctionSetpointRelationListDataSelectorsType[] hvacSystemFunctionSetpointRelationListDataSelectorsField;
    
    //private IdentificationListDataSelectorsType[] identificationListDataSelectorsField;
    
    //private IncentiveDescriptionListDataSelectorsType[] incentiveDescriptionListDataSelectorsField;
    
    //private IncentiveListDataSelectorsType[] incentiveListDataSelectorsField;
    
    //private IncentiveTableConstraintsDataSelectorsType[] incentiveTableConstraintsDataSelectorsField;
    
    //private IncentiveTableDataSelectorsType[] incentiveTableDataSelectorsField;
    
    //private IncentiveTableDescriptionDataSelectorsType[] incentiveTableDescriptionDataSelectorsField;
    
    //private LoadControlEventListDataSelectorsType[] loadControlEventListDataSelectorsField;
    
    //private LoadControlLimitConstraintsListDataSelectorsType[] loadControlLimitConstraintsListDataSelectorsField;
    
    //private LoadControlLimitDescriptionListDataSelectorsType[] loadControlLimitDescriptionListDataSelectorsField;
    
    //private LoadControlLimitListDataSelectorsType[] loadControlLimitListDataSelectorsField;
    
    //private LoadControlStateListDataSelectorsType[] loadControlStateListDataSelectorsField;
    
    //private MeasurementConstraintsListDataSelectorsType[] measurementConstraintsListDataSelectorsField;
    
    //private MeasurementDescriptionListDataSelectorsType[] measurementDescriptionListDataSelectorsField;
    
    //private MeasurementListDataSelectorsType[] measurementListDataSelectorsField;
    
    //private MeasurementThresholdRelationListDataSelectorsType[] measurementThresholdRelationListDataSelectorsField;
    
    //private MessagingListDataSelectorsType[] messagingListDataSelectorsField;
    
    //private NetworkManagementDeviceDescriptionListDataSelectorsType[] networkManagementDeviceDescriptionListDataSelectorsField;
    
    //private NetworkManagementEntityDescriptionListDataSelectorsType[] networkManagementEntityDescriptionListDataSelectorsField;
    
    //private NetworkManagementFeatureDescriptionListDataSelectorsType[] networkManagementFeatureDescriptionListDataSelectorsField;
    
    //private NodeManagementBindingDataSelectorsType[] nodeManagementBindingDataSelectorsField;
    
    //private NodeManagementDestinationListDataSelectorsType[] nodeManagementDestinationListDataSelectorsField;
    
    //private NodeManagementDetailedDiscoveryDataSelectorsType[] nodeManagementDetailedDiscoveryDataSelectorsField;
    
    //private NodeManagementSubscriptionDataSelectorsType[] nodeManagementSubscriptionDataSelectorsField;
    
    //private NodeManagementUseCaseDataSelectorsType[] nodeManagementUseCaseDataSelectorsField;
    
    //private OperatingConstraintsDurationListDataSelectorsType[] operatingConstraintsDurationListDataSelectorsField;
    
    //private OperatingConstraintsInterruptListDataSelectorsType[] operatingConstraintsInterruptListDataSelectorsField;
    
    //private OperatingConstraintsPowerDescriptionListDataSelectorsType[] operatingConstraintsPowerDescriptionListDataSelectorsField;
    
    //private OperatingConstraintsPowerLevelListDataSelectorsType[] operatingConstraintsPowerLevelListDataSelectorsField;
    
    //private OperatingConstraintsPowerRangeListDataSelectorsType[] operatingConstraintsPowerRangeListDataSelectorsField;
    
    //private OperatingConstraintsResumeImplicationListDataSelectorsType[] operatingConstraintsResumeImplicationListDataSelectorsField;
    
    //private PowerSequenceAlternativesRelationListDataSelectorsType[] powerSequenceAlternativesRelationListDataSelectorsField;
    
    //private PowerSequenceDescriptionListDataSelectorsType[] powerSequenceDescriptionListDataSelectorsField;
    
    //private PowerSequencePriceListDataSelectorsType[] powerSequencePriceListDataSelectorsField;
    
    //private PowerSequenceScheduleConstraintsListDataSelectorsType[] powerSequenceScheduleConstraintsListDataSelectorsField;
    
    //private PowerSequenceScheduleListDataSelectorsType[] powerSequenceScheduleListDataSelectorsField;
    
    //private PowerSequenceSchedulePreferenceListDataSelectorsType[] powerSequenceSchedulePreferenceListDataSelectorsField;
    
    //private PowerSequenceStateListDataSelectorsType[] powerSequenceStateListDataSelectorsField;
    
    //private PowerTimeSlotScheduleConstraintsListDataSelectorsType[] powerTimeSlotScheduleConstraintsListDataSelectorsField;
    
    //private PowerTimeSlotScheduleListDataSelectorsType[] powerTimeSlotScheduleListDataSelectorsField;
    
    //private PowerTimeSlotValueListDataSelectorsType[] powerTimeSlotValueListDataSelectorsField;
    
    //private SensingListDataSelectorsType[] sensingListDataSelectorsField;
    
    //private SetpointConstraintsListDataSelectorsType[] setpointConstraintsListDataSelectorsField;
    
    //private SetpointDescriptionListDataSelectorsType[] setpointDescriptionListDataSelectorsField;
    
    //private SetpointListDataSelectorsType[] setpointListDataSelectorsField;
    
    //private SmartEnergyManagementPsDataSelectorsType[] smartEnergyManagementPsDataSelectorsField;
    
    //private SmartEnergyManagementPsPriceDataSelectorsType[] smartEnergyManagementPsPriceDataSelectorsField;
    
    //private SpecificationVersionListDataSelectorsType[] specificationVersionListDataSelectorsField;
    
    //private SubscriptionManagementEntryListDataSelectorsType[] subscriptionManagementEntryListDataSelectorsField;
    
    //private SupplyConditionDescriptionListDataSelectorsType[] supplyConditionDescriptionListDataSelectorsField;
    
    //private SupplyConditionListDataSelectorsType[] supplyConditionListDataSelectorsField;
    
    //private SupplyConditionThresholdRelationListDataSelectorsType[] supplyConditionThresholdRelationListDataSelectorsField;
    
    //private TariffBoundaryRelationListDataSelectorsType[] tariffBoundaryRelationListDataSelectorsField;
    
    //private TariffDescriptionListDataSelectorsType[] tariffDescriptionListDataSelectorsField;
    
    //private TariffListDataSelectorsType[] tariffListDataSelectorsField;
    
    //private TariffTierRelationListDataSelectorsType[] tariffTierRelationListDataSelectorsField;
    
    //private TaskManagementJobDescriptionListDataSelectorsType[] taskManagementJobDescriptionListDataSelectorsField;
    
    //private TaskManagementJobListDataSelectorsType[] taskManagementJobListDataSelectorsField;
    
    //private TaskManagementJobRelationListDataSelectorsType[] taskManagementJobRelationListDataSelectorsField;
    
    //private ThresholdConstraintsListDataSelectorsType[] thresholdConstraintsListDataSelectorsField;
    
    //private ThresholdDescriptionListDataSelectorsType[] thresholdDescriptionListDataSelectorsField;
    
    //private ThresholdListDataSelectorsType[] thresholdListDataSelectorsField;
    
    //private TierBoundaryDescriptionListDataSelectorsType[] tierBoundaryDescriptionListDataSelectorsField;
    
    //private TierBoundaryListDataSelectorsType[] tierBoundaryListDataSelectorsField;
    
    //private TierDescriptionListDataSelectorsType[] tierDescriptionListDataSelectorsField;
    
    //private TierIncentiveRelationListDataSelectorsType[] tierIncentiveRelationListDataSelectorsField;
    
    //private TierListDataSelectorsType[] tierListDataSelectorsField;
    
    //private TimeSeriesConstraintsListDataSelectorsType[] timeSeriesConstraintsListDataSelectorsField;
    
    //private TimeSeriesDescriptionListDataSelectorsType[] timeSeriesDescriptionListDataSelectorsField;
    
    //private TimeSeriesListDataSelectorsType[] timeSeriesListDataSelectorsField;
    
    //private TimeTableConstraintsListDataSelectorsType[] timeTableConstraintsListDataSelectorsField;
    
    //private TimeTableDescriptionListDataSelectorsType[] timeTableDescriptionListDataSelectorsField;
    
    //private TimeTableListDataSelectorsType[] timeTableListDataSelectorsField;
    
    //private UseCaseInformationListDataSelectorsType[] useCaseInformationListDataSelectorsField;
    
    //private ActuatorLevelDataElementsType actuatorLevelDataElementsField;
    
    //private ActuatorLevelDescriptionDataElementsType actuatorLevelDescriptionDataElementsField;
    
    //private ActuatorSwitchDataElementsType actuatorSwitchDataElementsField;
    
    //private ActuatorSwitchDescriptionDataElementsType actuatorSwitchDescriptionDataElementsField;
    
    //private AlarmDataElementsType alarmDataElementsField;
    
    //private BillConstraintsDataElementsType billConstraintsDataElementsField;
    
    //private BillDataElementsType billDataElementsField;
    
    //private BillDescriptionDataElementsType billDescriptionDataElementsField;
    
    //private BindingManagementDeleteCallElementsType bindingManagementDeleteCallElementsField;
    
    //private BindingManagementEntryDataElementsType bindingManagementEntryDataElementsField;
    
    //private BindingManagementRequestCallElementsType bindingManagementRequestCallElementsField;
    
    //private CommodityDataElementsType commodityDataElementsField;
    
    //private DataTunnelingCallElementsType dataTunnelingCallElementsField;
    
    //private DeviceClassificationManufacturerDataElementsType deviceClassificationManufacturerDataElementsField;
    
    //private DeviceClassificationUserDataElementsType deviceClassificationUserDataElementsField;
    
    //private DeviceConfigurationKeyValueConstraintsDataElementsType deviceConfigurationKeyValueConstraintsDataElementsField;
    
    //private DeviceConfigurationKeyValueDataElementsType deviceConfigurationKeyValueDataElementsField;
    
    //private DeviceConfigurationKeyValueDescriptionDataElementsType deviceConfigurationKeyValueDescriptionDataElementsField;
    
    //private DeviceDiagnosisHeartbeatDataElementsType deviceDiagnosisHeartbeatDataElementsField;
    
    //private DeviceDiagnosisServiceDataElementsType deviceDiagnosisServiceDataElementsField;
    
    //private DeviceDiagnosisStateDataElementsType deviceDiagnosisStateDataElementsField;
    
    //private DirectControlActivityDataElementsType directControlActivityDataElementsField;
    
    //private DirectControlDescriptionDataElementsType directControlDescriptionDataElementsField;
    
    //private ElectricalConnectionDescriptionDataElementsType electricalConnectionDescriptionDataElementsField;
    
    //private ElectricalConnectionParameterDescriptionDataElementsType electricalConnectionParameterDescriptionDataElementsField;
    
    //private ElectricalConnectionPermittedValueSetDataElementsType electricalConnectionPermittedValueSetDataElementsField;
    
    //private ElectricalConnectionStateDataElementsType electricalConnectionStateDataElementsField;
    
    //private HvacOperationModeDescriptionDataElementsType hvacOperationModeDescriptionDataElementsField;
    
    //private HvacOverrunDataElementsType hvacOverrunDataElementsField;
    
    //private HvacOverrunDescriptionDataElementsType hvacOverrunDescriptionDataElementsField;
    
    //private HvacSystemFunctionDataElementsType hvacSystemFunctionDataElementsField;
    
    //private HvacSystemFunctionDescriptionDataElementsType hvacSystemFunctionDescriptionDataElementsField;
    
    //private HvacSystemFunctionOperationModeRelationDataElementsType hvacSystemFunctionOperationModeRelationDataElementsField;
    
    //private HvacSystemFunctionPowerSequenceRelationDataElementsType hvacSystemFunctionPowerSequenceRelationDataElementsField;
    
    //private HvacSystemFunctionSetpointRelationDataElementsType hvacSystemFunctionSetpointRelationDataElementsField;
    
    //private IdentificationDataElementsType identificationDataElementsField;
    
    //private IncentiveDataElementsType incentiveDataElementsField;
    
    //private IncentiveDescriptionDataElementsType incentiveDescriptionDataElementsField;
    
    //private IncentiveTableConstraintsDataElementsType incentiveTableConstraintsDataElementsField;
    
    //private IncentiveTableDataElementsType incentiveTableDataElementsField;
    
    //private IncentiveTableDescriptionDataElementsType incentiveTableDescriptionDataElementsField;
    
    //private LoadControlEventDataElementsType loadControlEventDataElementsField;
    
    //private LoadControlLimitConstraintsDataElementsType loadControlLimitConstraintsDataElementsField;
    
    //private LoadControlLimitDataElementsType loadControlLimitDataElementsField;
    
    //private LoadControlLimitDescriptionDataElementsType loadControlLimitDescriptionDataElementsField;
    
    //private LoadControlNodeDataElementsType loadControlNodeDataElementsField;
    
    //private LoadControlStateDataElementsType loadControlStateDataElementsField;
    
    //private MeasurementConstraintsDataElementsType measurementConstraintsDataElementsField;
    
    //private MeasurementDataElementsType measurementDataElementsField;
    
    //private MeasurementDescriptionDataElementsType measurementDescriptionDataElementsField;
    
    //private MeasurementThresholdRelationDataElementsType measurementThresholdRelationDataElementsField;
    
    //private MessagingDataElementsType messagingDataElementsField;
    
    //private NetworkManagementAbortCallElementsType networkManagementAbortCallElementsField;
    
    //private NetworkManagementAddNodeCallElementsType networkManagementAddNodeCallElementsField;
    
    //private NetworkManagementDeviceDescriptionDataElementsType networkManagementDeviceDescriptionDataElementsField;
    
    //private NetworkManagementDiscoverCallElementsType networkManagementDiscoverCallElementsField;
    
    //private NetworkManagementEntityDescriptionDataElementsType networkManagementEntityDescriptionDataElementsField;
    
    //private NetworkManagementFeatureDescriptionDataElementsType networkManagementFeatureDescriptionDataElementsField;
    
    //private NetworkManagementJoiningModeDataElementsType networkManagementJoiningModeDataElementsField;
    
    //private NetworkManagementModifyNodeCallElementsType networkManagementModifyNodeCallElementsField;
    
    //private NetworkManagementProcessStateDataElementsType networkManagementProcessStateDataElementsField;
    
    //private NetworkManagementRemoveNodeCallElementsType networkManagementRemoveNodeCallElementsField;
    
    //private NetworkManagementReportCandidateDataElementsType networkManagementReportCandidateDataElementsField;
    
    //private NetworkManagementScanNetworkCallElementsType networkManagementScanNetworkCallElementsField;
    
    //private NodeManagementBindingDataElementsType nodeManagementBindingDataElementsField;
    
    //private NodeManagementBindingDeleteCallElementsType nodeManagementBindingDeleteCallElementsField;
    
    //private NodeManagementBindingRequestCallElementsType nodeManagementBindingRequestCallElementsField;
    
    //private NodeManagementDestinationDataElementsType nodeManagementDestinationDataElementsField;
    
    //private NodeManagementDetailedDiscoveryDataElementsType nodeManagementDetailedDiscoveryDataElementsField;
    
    //private NodeManagementSubscriptionDataElementsType nodeManagementSubscriptionDataElementsField;
    
    //private NodeManagementSubscriptionDeleteCallElementsType nodeManagementSubscriptionDeleteCallElementsField;
    
    //private NodeManagementSubscriptionRequestCallElementsType nodeManagementSubscriptionRequestCallElementsField;
    
    //private NodeManagementUseCaseDataElementsType nodeManagementUseCaseDataElementsField;
    
    //private OperatingConstraintsDurationDataElementsType operatingConstraintsDurationDataElementsField;
    
    //private OperatingConstraintsInterruptDataElementsType operatingConstraintsInterruptDataElementsField;
    
    //private OperatingConstraintsPowerDescriptionDataElementsType operatingConstraintsPowerDescriptionDataElementsField;
    
    //private OperatingConstraintsPowerLevelDataElementsType operatingConstraintsPowerLevelDataElementsField;
    
    //private OperatingConstraintsPowerRangeDataElementsType operatingConstraintsPowerRangeDataElementsField;
    
    //private OperatingConstraintsResumeImplicationDataElementsType operatingConstraintsResumeImplicationDataElementsField;
    
    //private PowerSequenceAlternativesRelationDataElementsType powerSequenceAlternativesRelationDataElementsField;
    
    //private PowerSequenceDescriptionDataElementsType powerSequenceDescriptionDataElementsField;
    
    //private PowerSequenceNodeScheduleInformationDataElementsType powerSequenceNodeScheduleInformationDataElementsField;
    
    //private PowerSequencePriceCalculationRequestCallElementsType powerSequencePriceCalculationRequestCallElementsField;
    
    //private PowerSequencePriceDataElementsType powerSequencePriceDataElementsField;
    
    //private PowerSequenceScheduleConfigurationRequestCallElementsType powerSequenceScheduleConfigurationRequestCallElementsField;
    
    //private PowerSequenceScheduleConstraintsDataElementsType powerSequenceScheduleConstraintsDataElementsField;
    
    //private PowerSequenceScheduleDataElementsType powerSequenceScheduleDataElementsField;
    
    //private PowerSequenceSchedulePreferenceDataElementsType powerSequenceSchedulePreferenceDataElementsField;
    
    //private PowerSequenceStateDataElementsType powerSequenceStateDataElementsField;
    
    //private PowerTimeSlotScheduleConstraintsDataElementsType powerTimeSlotScheduleConstraintsDataElementsField;
    
    //private PowerTimeSlotScheduleDataElementsType powerTimeSlotScheduleDataElementsField;
    
    //private PowerTimeSlotValueDataElementsType powerTimeSlotValueDataElementsField;
    
    //private SensingDataElementsType sensingDataElementsField;
    
    //private SensingDescriptionDataElementsType sensingDescriptionDataElementsField;
    
    //private SetpointConstraintsDataElementsType setpointConstraintsDataElementsField;
    
    //private SetpointDataElementsType setpointDataElementsField;
    
    //private SetpointDescriptionDataElementsType setpointDescriptionDataElementsField;
    
    //private SmartEnergyManagementPsConfigurationRequestCallElementsType smartEnergyManagementPsConfigurationRequestCallElementsField;
    
    //private SmartEnergyManagementPsDataElementsType smartEnergyManagementPsDataElementsField;
    
    //private SmartEnergyManagementPsPriceCalculationRequestCallElementsType smartEnergyManagementPsPriceCalculationRequestCallElementsField;
    
    //private SmartEnergyManagementPsPriceDataElementsType smartEnergyManagementPsPriceDataElementsField;
    
    //private SpecificationVersionDataElementsType specificationVersionDataElementsField;
    
    //private SubscriptionManagementDeleteCallElementsType subscriptionManagementDeleteCallElementsField;
    
    //private SubscriptionManagementEntryDataElementsType subscriptionManagementEntryDataElementsField;
    
    //private SubscriptionManagementRequestCallElementsType subscriptionManagementRequestCallElementsField;
    
    //private SupplyConditionDataElementsType supplyConditionDataElementsField;
    
    //private SupplyConditionDescriptionDataElementsType supplyConditionDescriptionDataElementsField;
    
    //private SupplyConditionThresholdRelationDataElementsType supplyConditionThresholdRelationDataElementsField;
    
    //private TariffBoundaryRelationDataElementsType tariffBoundaryRelationDataElementsField;
    
    //private TariffDataElementsType tariffDataElementsField;
    
    //private TariffDescriptionDataElementsType tariffDescriptionDataElementsField;
    
    //private TariffOverallConstraintsDataElementsType tariffOverallConstraintsDataElementsField;
    
    //private TariffTierRelationDataElementsType tariffTierRelationDataElementsField;
    
    //private TaskManagementJobDataElementsType taskManagementJobDataElementsField;
    
    //private TaskManagementJobDescriptionDataElementsType taskManagementJobDescriptionDataElementsField;
    
    //private TaskManagementJobRelationDataElementsType taskManagementJobRelationDataElementsField;
    
    //private TaskManagementOverviewDataElementsType taskManagementOverviewDataElementsField;
    
    //private ThresholdConstraintsDataElementsType thresholdConstraintsDataElementsField;
    
    //private ThresholdDataElementsType thresholdDataElementsField;
    
    //private ThresholdDescriptionDataElementsType thresholdDescriptionDataElementsField;
    
    //private TierBoundaryDataElementsType tierBoundaryDataElementsField;
    
    //private TierBoundaryDescriptionDataElementsType tierBoundaryDescriptionDataElementsField;
    
    //private TierDataElementsType tierDataElementsField;
    
    //private TierDescriptionDataElementsType tierDescriptionDataElementsField;
    
    //private TierIncentiveRelationDataElementsType tierIncentiveRelationDataElementsField;
    
    //private TimeDistributorDataElementsType timeDistributorDataElementsField;
    
    //private TimeDistributorEnquiryCallElementsType timeDistributorEnquiryCallElementsField;
    
    //private TimeInformationDataElementsType timeInformationDataElementsField;
    
    //private TimePrecisionDataElementsType timePrecisionDataElementsField;
    
    //private TimeSeriesConstraintsDataElementsType timeSeriesConstraintsDataElementsField;
    
    //private TimeSeriesDataElementsType timeSeriesDataElementsField;
    
    //private TimeSeriesDescriptionDataElementsType timeSeriesDescriptionDataElementsField;
    
    //private TimeTableConstraintsDataElementsType timeTableConstraintsDataElementsField;
    
    //private TimeTableDataElementsType timeTableDataElementsField;
    
    //private TimeTableDescriptionDataElementsType timeTableDescriptionDataElementsField;
    
    //private UseCaseInformationDataElementsType useCaseInformationDataElementsField;
    
    /// <remarks/>
    public uint filterId { get; set; }
    
    /// <remarks/>
    public bool filterIdSpecified { get; set; }
    
    /// <remarks/>
    public CmdControlType cmdControl { get; set; }
    
    /// <remarks/>
    public AlarmListDataSelectorsType[] alarmListDataSelectors { get; set; }
    
    /// <remarks/>
    public BillConstraintsListDataSelectorsType[] billConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public BillDescriptionListDataSelectorsType[] billDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public BillListDataSelectorsType[] billListDataSelectors { get; set; }
    
    /// <remarks/>
    public BindingManagementEntryListDataSelectorsType[] bindingManagementEntryListDataSelectors { get; set; }
    
    /// <remarks/>
    public CommodityListDataSelectorsType[] commodityListDataSelectors { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueConstraintsListDataSelectorsType[] deviceConfigurationKeyValueConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueDescriptionListDataSelectorsType[] deviceConfigurationKeyValueDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueListDataSelectorsType[] deviceConfigurationKeyValueListDataSelectors { get; set; }
    
    /// <remarks/>
    public DirectControlActivityListDataSelectorsType[] directControlActivityListDataSelectors { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionDescriptionListDataSelectorsType[] electricalConnectionDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionParameterDescriptionListDataSelectorsType[] electricalConnectionParameterDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionPermittedValueSetListDataSelectorsType[] electricalConnectionPermittedValueSetListDataSelectors { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionStateListDataSelectorsType[] electricalConnectionStateListDataSelectors { get; set; }
    
    /// <remarks/>
    public HvacOperationModeDescriptionListDataSelectorsType[] hvacOperationModeDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public HvacOverrunDescriptionListDataSelectorsType[] hvacOverrunDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public HvacOverrunListDataSelectorsType[] hvacOverrunListDataSelectors { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionDescriptionListDataSelectorsType[] hvacSystemFunctionDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionListDataSelectorsType[] hvacSystemFunctionListDataSelectors { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionOperationModeRelationListDataSelectorsType[] hvacSystemFunctionOperationModeRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionPowerSequenceRelationListDataSelectorsType[] hvacSystemFunctionPowerSequenceRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionSetpointRelationListDataSelectorsType[] hvacSystemFunctionSetpointRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public IdentificationListDataSelectorsType[] identificationListDataSelectors { get; set; }
    
    /// <remarks/>
    public IncentiveDescriptionListDataSelectorsType[] incentiveDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public IncentiveListDataSelectorsType[] incentiveListDataSelectors { get; set; }
    
    /// <remarks/>
    public IncentiveTableConstraintsDataSelectorsType[] incentiveTableConstraintsDataSelectors { get; set; }
    
    /// <remarks/>
    public IncentiveTableDataSelectorsType[] incentiveTableDataSelectors { get; set; }
    
    /// <remarks/>
    public IncentiveTableDescriptionDataSelectorsType[] incentiveTableDescriptionDataSelectors { get; set; }
    
    /// <remarks/>
    public LoadControlEventListDataSelectorsType[] loadControlEventListDataSelectors { get; set; }
    
    /// <remarks/>
    public LoadControlLimitConstraintsListDataSelectorsType[] loadControlLimitConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public LoadControlLimitDescriptionListDataSelectorsType[] loadControlLimitDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public LoadControlLimitListDataSelectorsType[] loadControlLimitListDataSelectors { get; set; }
    
    /// <remarks/>
    public LoadControlStateListDataSelectorsType[] loadControlStateListDataSelectors { get; set; }
    
    /// <remarks/>
    public MeasurementConstraintsListDataSelectorsType[] measurementConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public MeasurementDescriptionListDataSelectorsType[] measurementDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public MeasurementListDataSelectorsType[] measurementListDataSelectors { get; set; }
    
    /// <remarks/>
    public MeasurementThresholdRelationListDataSelectorsType[] measurementThresholdRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public MessagingListDataSelectorsType[] messagingListDataSelectors { get; set; }
    
    /// <remarks/>
    public NetworkManagementDeviceDescriptionListDataSelectorsType[] networkManagementDeviceDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public NetworkManagementEntityDescriptionListDataSelectorsType[] networkManagementEntityDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public NetworkManagementFeatureDescriptionListDataSelectorsType[] networkManagementFeatureDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public NodeManagementBindingDataSelectorsType[] nodeManagementBindingDataSelectors { get; set; }
    
    /// <remarks/>
    public NodeManagementDestinationListDataSelectorsType[] nodeManagementDestinationListDataSelectors { get; set; }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDataSelectorsType[] nodeManagementDetailedDiscoveryDataSelectors { get; set; }
    
    /// <remarks/>
    public NodeManagementSubscriptionDataSelectorsType[] nodeManagementSubscriptionDataSelectors { get; set; }
    
    /// <remarks/>
    public NodeManagementUseCaseDataSelectorsType[] nodeManagementUseCaseDataSelectors { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsDurationListDataSelectorsType[] operatingConstraintsDurationListDataSelectors { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsInterruptListDataSelectorsType[] operatingConstraintsInterruptListDataSelectors { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerDescriptionListDataSelectorsType[] operatingConstraintsPowerDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerLevelListDataSelectorsType[] operatingConstraintsPowerLevelListDataSelectors { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerRangeListDataSelectorsType[] operatingConstraintsPowerRangeListDataSelectors { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsResumeImplicationListDataSelectorsType[] operatingConstraintsResumeImplicationListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerSequenceAlternativesRelationListDataSelectorsType[] powerSequenceAlternativesRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerSequenceDescriptionListDataSelectorsType[] powerSequenceDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerSequencePriceListDataSelectorsType[] powerSequencePriceListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerSequenceScheduleConstraintsListDataSelectorsType[] powerSequenceScheduleConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerSequenceScheduleListDataSelectorsType[] powerSequenceScheduleListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerSequenceSchedulePreferenceListDataSelectorsType[] powerSequenceSchedulePreferenceListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerSequenceStateListDataSelectorsType[] powerSequenceStateListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotScheduleConstraintsListDataSelectorsType[] powerTimeSlotScheduleConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotScheduleListDataSelectorsType[] powerTimeSlotScheduleListDataSelectors { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotValueListDataSelectorsType[] powerTimeSlotValueListDataSelectors { get; set; }
    
    /// <remarks/>
    public SensingListDataSelectorsType[] sensingListDataSelectors { get; set; }
    
    /// <remarks/>
    public SetpointConstraintsListDataSelectorsType[] setpointConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public SetpointDescriptionListDataSelectorsType[] setpointDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public SetpointListDataSelectorsType[] setpointListDataSelectors { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsDataSelectorsType[] smartEnergyManagementPsDataSelectors { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceDataSelectorsType[] smartEnergyManagementPsPriceDataSelectors { get; set; }
    
    /// <remarks/>
    public SpecificationVersionListDataSelectorsType[] specificationVersionListDataSelectors { get; set; }
    
    /// <remarks/>
    public SubscriptionManagementEntryListDataSelectorsType[] subscriptionManagementEntryListDataSelectors { get; set; }
    
    /// <remarks/>
    public SupplyConditionDescriptionListDataSelectorsType[] supplyConditionDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public SupplyConditionListDataSelectorsType[] supplyConditionListDataSelectors { get; set; }
    
    /// <remarks/>
    public SupplyConditionThresholdRelationListDataSelectorsType[] supplyConditionThresholdRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public TariffBoundaryRelationListDataSelectorsType[] tariffBoundaryRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public TariffDescriptionListDataSelectorsType[] tariffDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public TariffListDataSelectorsType[] tariffListDataSelectors { get; set; }
    
    /// <remarks/>
    public TariffTierRelationListDataSelectorsType[] tariffTierRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public TaskManagementJobDescriptionListDataSelectorsType[] taskManagementJobDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public TaskManagementJobListDataSelectorsType[] taskManagementJobListDataSelectors { get; set; }
    
    /// <remarks/>
    public TaskManagementJobRelationListDataSelectorsType[] taskManagementJobRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public ThresholdConstraintsListDataSelectorsType[] thresholdConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public ThresholdDescriptionListDataSelectorsType[] thresholdDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public ThresholdListDataSelectorsType[] thresholdListDataSelectors { get; set; }
    
    /// <remarks/>
    public TierBoundaryDescriptionListDataSelectorsType[] tierBoundaryDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public TierBoundaryListDataSelectorsType[] tierBoundaryListDataSelectors { get; set; }
    
    /// <remarks/>
    public TierDescriptionListDataSelectorsType[] tierDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public TierIncentiveRelationListDataSelectorsType[] tierIncentiveRelationListDataSelectors { get; set; }
    
    /// <remarks/>
    public TierListDataSelectorsType[] tierListDataSelectors { get; set; }
    
    /// <remarks/>
    public TimeSeriesConstraintsListDataSelectorsType[] timeSeriesConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public TimeSeriesDescriptionListDataSelectorsType[] timeSeriesDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public TimeSeriesListDataSelectorsType[] timeSeriesListDataSelectors { get; set; }
    
    /// <remarks/>
    public TimeTableConstraintsListDataSelectorsType[] timeTableConstraintsListDataSelectors { get; set; }
    
    /// <remarks/>
    public TimeTableDescriptionListDataSelectorsType[] timeTableDescriptionListDataSelectors { get; set; }
    
    /// <remarks/>
    public TimeTableListDataSelectorsType[] timeTableListDataSelectors { get; set; }
    
    /// <remarks/>
    public UseCaseInformationListDataSelectorsType[] useCaseInformationListDataSelectors { get; set; }
    
    /// <remarks/>
    public ActuatorLevelDataElementsType actuatorLevelDataElements { get; set; }
    
    /// <remarks/>
    public ActuatorLevelDescriptionDataElementsType actuatorLevelDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public ActuatorSwitchDataElementsType actuatorSwitchDataElements { get; set; }
    
    /// <remarks/>
    public ActuatorSwitchDescriptionDataElementsType actuatorSwitchDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public AlarmDataElementsType alarmDataElements { get; set; }
    
    /// <remarks/>
    public BillConstraintsDataElementsType billConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public BillDataElementsType billDataElements { get; set; }
    
    /// <remarks/>
    public BillDescriptionDataElementsType billDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public BindingManagementDeleteCallElementsType bindingManagementDeleteCallElements { get; set; }
    
    /// <remarks/>
    public BindingManagementEntryDataElementsType bindingManagementEntryDataElements { get; set; }
    
    /// <remarks/>
    public BindingManagementRequestCallElementsType bindingManagementRequestCallElements { get; set; }
    
    /// <remarks/>
    public CommodityDataElementsType commodityDataElements { get; set; }
    
    /// <remarks/>
    public DataTunnelingCallElementsType dataTunnelingCallElements { get; set; }
    
    /// <remarks/>
    public DeviceClassificationManufacturerDataElementsType deviceClassificationManufacturerDataElements { get; set; }
    
    /// <remarks/>
    public DeviceClassificationUserDataElementsType deviceClassificationUserDataElements { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueConstraintsDataElementsType deviceConfigurationKeyValueConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueDataElementsType deviceConfigurationKeyValueDataElements { get; set; }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueDescriptionDataElementsType deviceConfigurationKeyValueDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public DeviceDiagnosisHeartbeatDataElementsType deviceDiagnosisHeartbeatDataElements { get; set; }
    
    /// <remarks/>
    public DeviceDiagnosisServiceDataElementsType deviceDiagnosisServiceDataElements { get; set; }
    
    /// <remarks/>
    public DeviceDiagnosisStateDataElementsType deviceDiagnosisStateDataElements { get; set; }
    
    /// <remarks/>
    public DirectControlActivityDataElementsType directControlActivityDataElements { get; set; }
    
    /// <remarks/>
    public DirectControlDescriptionDataElementsType directControlDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionDescriptionDataElementsType electricalConnectionDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionParameterDescriptionDataElementsType electricalConnectionParameterDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionPermittedValueSetDataElementsType electricalConnectionPermittedValueSetDataElements { get; set; }
    
    /// <remarks/>
    public ElectricalConnectionStateDataElementsType electricalConnectionStateDataElements { get; set; }
    
    /// <remarks/>
    public HvacOperationModeDescriptionDataElementsType hvacOperationModeDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public HvacOverrunDataElementsType hvacOverrunDataElements { get; set; }
    
    /// <remarks/>
    public HvacOverrunDescriptionDataElementsType hvacOverrunDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionDataElementsType hvacSystemFunctionDataElements { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionDescriptionDataElementsType hvacSystemFunctionDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionOperationModeRelationDataElementsType hvacSystemFunctionOperationModeRelationDataElements { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionPowerSequenceRelationDataElementsType hvacSystemFunctionPowerSequenceRelationDataElements { get; set; }
    
    /// <remarks/>
    public HvacSystemFunctionSetpointRelationDataElementsType hvacSystemFunctionSetpointRelationDataElements { get; set; }
    
    /// <remarks/>
    public IdentificationDataElementsType identificationDataElements { get; set; }
    
    /// <remarks/>
    public IncentiveDataElementsType incentiveDataElements { get; set; }
    
    /// <remarks/>
    public IncentiveDescriptionDataElementsType incentiveDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public IncentiveTableConstraintsDataElementsType incentiveTableConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public IncentiveTableDataElementsType incentiveTableDataElements { get; set; }
    
    /// <remarks/>
    public IncentiveTableDescriptionDataElementsType incentiveTableDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public LoadControlEventDataElementsType loadControlEventDataElements { get; set; }
    
    /// <remarks/>
    public LoadControlLimitConstraintsDataElementsType loadControlLimitConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public LoadControlLimitDataElementsType loadControlLimitDataElements { get; set; }
    
    /// <remarks/>
    public LoadControlLimitDescriptionDataElementsType loadControlLimitDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public LoadControlNodeDataElementsType loadControlNodeDataElements { get; set; }
    
    /// <remarks/>
    public LoadControlStateDataElementsType loadControlStateDataElements { get; set; }
    
    /// <remarks/>
    public MeasurementConstraintsDataElementsType measurementConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public MeasurementDataElementsType measurementDataElements { get; set; }
    
    /// <remarks/>
    public MeasurementDescriptionDataElementsType measurementDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public MeasurementThresholdRelationDataElementsType measurementThresholdRelationDataElements { get; set; }
    
    /// <remarks/>
    public MessagingDataElementsType messagingDataElements { get; set; }

	/// <remarks/>
	public NetworkManagementAbortCallElementsType networkManagementAbortCallElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementAddNodeCallElementsType networkManagementAddNodeCallElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementDeviceDescriptionDataElementsType networkManagementDeviceDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementDiscoverCallElementsType networkManagementDiscoverCallElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementEntityDescriptionDataElementsType networkManagementEntityDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementFeatureDescriptionDataElementsType networkManagementFeatureDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementJoiningModeDataElementsType networkManagementJoiningModeDataElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementModifyNodeCallElementsType networkManagementModifyNodeCallElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementProcessStateDataElementsType networkManagementProcessStateDataElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementRemoveNodeCallElementsType networkManagementRemoveNodeCallElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementReportCandidateDataElementsType networkManagementReportCandidateDataElements { get; set; }
    
    /// <remarks/>
    public NetworkManagementScanNetworkCallElementsType networkManagementScanNetworkCallElements { get; set; }
    
    /// <remarks/>
    public NodeManagementBindingDataElementsType nodeManagementBindingDataElements { get; set; }
    
    /// <remarks/>
    public NodeManagementBindingDeleteCallElementsType nodeManagementBindingDeleteCallElements { get; set; }
    
    /// <remarks/>
    public NodeManagementBindingRequestCallElementsType nodeManagementBindingRequestCallElements { get; set; }
    
    /// <remarks/>
    public NodeManagementDestinationDataElementsType nodeManagementDestinationDataElements { get; set; }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDataElementsType nodeManagementDetailedDiscoveryDataElements { get; set; }
    
    /// <remarks/>
    public NodeManagementSubscriptionDataElementsType nodeManagementSubscriptionDataElements { get; set; }
    
    /// <remarks/>
    public NodeManagementSubscriptionDeleteCallElementsType nodeManagementSubscriptionDeleteCallElements { get; set; }
    
    /// <remarks/>
    public NodeManagementSubscriptionRequestCallElementsType nodeManagementSubscriptionRequestCallElements { get; set; }
    
    /// <remarks/>
    public NodeManagementUseCaseDataElementsType nodeManagementUseCaseDataElements { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsDurationDataElementsType operatingConstraintsDurationDataElements { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsInterruptDataElementsType operatingConstraintsInterruptDataElements { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerDescriptionDataElementsType operatingConstraintsPowerDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerLevelDataElementsType operatingConstraintsPowerLevelDataElements { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsPowerRangeDataElementsType operatingConstraintsPowerRangeDataElements { get; set; }
    
    /// <remarks/>
    public OperatingConstraintsResumeImplicationDataElementsType operatingConstraintsResumeImplicationDataElements { get; set; }
    
    /// <remarks/>
    public PowerSequenceAlternativesRelationDataElementsType powerSequenceAlternativesRelationDataElements { get; set; }
    
    /// <remarks/>
    public PowerSequenceDescriptionDataElementsType powerSequenceDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public PowerSequenceNodeScheduleInformationDataElementsType powerSequenceNodeScheduleInformationDataElements { get; set; }
    
    /// <remarks/>
    public PowerSequencePriceCalculationRequestCallElementsType powerSequencePriceCalculationRequestCallElements { get; set; }
    
    /// <remarks/>
    public PowerSequencePriceDataElementsType powerSequencePriceDataElements { get; set; }
    
    /// <remarks/>
    public PowerSequenceScheduleConfigurationRequestCallElementsType powerSequenceScheduleConfigurationRequestCallElements { get; set; }
    
    /// <remarks/>
    public PowerSequenceScheduleConstraintsDataElementsType powerSequenceScheduleConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public PowerSequenceScheduleDataElementsType powerSequenceScheduleDataElements { get; set; }
    
    /// <remarks/>
    public PowerSequenceSchedulePreferenceDataElementsType powerSequenceSchedulePreferenceDataElements { get; set; }
    
    /// <remarks/>
    public PowerSequenceStateDataElementsType powerSequenceStateDataElements { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotScheduleConstraintsDataElementsType powerTimeSlotScheduleConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotScheduleDataElementsType powerTimeSlotScheduleDataElements { get; set; }
    
    /// <remarks/>
    public PowerTimeSlotValueDataElementsType powerTimeSlotValueDataElements { get; set; }
    
    /// <remarks/>
    public SensingDataElementsType sensingDataElements { get; set; }
    
    /// <remarks/>
    public SensingDescriptionDataElementsType sensingDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public SetpointConstraintsDataElementsType setpointConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public SetpointDataElementsType setpointDataElements { get; set; }
    
    /// <remarks/>
    public SetpointDescriptionDataElementsType setpointDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsConfigurationRequestCallElementsType smartEnergyManagementPsConfigurationRequestCallElements { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsDataElementsType smartEnergyManagementPsDataElements { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceCalculationRequestCallElementsType smartEnergyManagementPsPriceCalculationRequestCallElements { get; set; }
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceDataElementsType smartEnergyManagementPsPriceDataElements { get; set; }
    
    /// <remarks/>
    public SpecificationVersionDataElementsType specificationVersionDataElements { get; set; }
    
    /// <remarks/>
    public SubscriptionManagementDeleteCallElementsType subscriptionManagementDeleteCallElements { get; set; }
    
    /// <remarks/>
    public SubscriptionManagementEntryDataElementsType subscriptionManagementEntryDataElements { get; set; }
    
    /// <remarks/>
    public SubscriptionManagementRequestCallElementsType subscriptionManagementRequestCallElements { get; set; }
    
    /// <remarks/>
    public SupplyConditionDataElementsType supplyConditionDataElements { get; set; }
    
    /// <remarks/>
    public SupplyConditionDescriptionDataElementsType supplyConditionDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public SupplyConditionThresholdRelationDataElementsType supplyConditionThresholdRelationDataElements { get; set; }
    
    /// <remarks/>
    public TariffBoundaryRelationDataElementsType tariffBoundaryRelationDataElements { get; set; }
    
    /// <remarks/>
    public TariffDataElementsType tariffDataElements { get; set; }
    
    /// <remarks/>
    public TariffDescriptionDataElementsType tariffDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public TariffOverallConstraintsDataElementsType tariffOverallConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public TariffTierRelationDataElementsType tariffTierRelationDataElements { get; set; }
    
    /// <remarks/>
    public TaskManagementJobDataElementsType taskManagementJobDataElements { get; set; }
    
    /// <remarks/>
    public TaskManagementJobDescriptionDataElementsType taskManagementJobDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public TaskManagementJobRelationDataElementsType taskManagementJobRelationDataElements { get; set; }
    
    /// <remarks/>
    public TaskManagementOverviewDataElementsType taskManagementOverviewDataElements { get; set; }
    
    /// <remarks/>
    public ThresholdConstraintsDataElementsType thresholdConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public ThresholdDataElementsType thresholdDataElements { get; set; }
    
    /// <remarks/>
    public ThresholdDescriptionDataElementsType thresholdDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public TierBoundaryDataElementsType tierBoundaryDataElements { get; set; }
    
    /// <remarks/>
    public TierBoundaryDescriptionDataElementsType tierBoundaryDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public TierDataElementsType tierDataElements { get; set; }
    
    /// <remarks/>
    public TierDescriptionDataElementsType tierDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public TierIncentiveRelationDataElementsType tierIncentiveRelationDataElements { get; set; }
    
    /// <remarks/>
    public TimeDistributorDataElementsType timeDistributorDataElements { get; set; }
    
    /// <remarks/>
    public TimeDistributorEnquiryCallElementsType timeDistributorEnquiryCallElements { get; set; }
    
    /// <remarks/>
    public TimeInformationDataElementsType timeInformationDataElements { get; set; }
    
    /// <remarks/>
    public TimePrecisionDataElementsType timePrecisionDataElements { get; set; }
    
    /// <remarks/>
    public TimeSeriesConstraintsDataElementsType timeSeriesConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public TimeSeriesDataElementsType timeSeriesDataElements { get; set; }
    
    /// <remarks/>
    public TimeSeriesDescriptionDataElementsType timeSeriesDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public TimeTableConstraintsDataElementsType timeTableConstraintsDataElements { get; set; }
    
    /// <remarks/>
    public TimeTableDataElementsType timeTableDataElements { get; set; }
    
    /// <remarks/>
    public TimeTableDescriptionDataElementsType timeTableDescriptionDataElements { get; set; }
    
    /// <remarks/>
    public UseCaseInformationDataElementsType useCaseInformationDataElements { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
public partial class CmdControlType {
    
    /// <remarks/>
    public ElementTagType delete { get; set; }
    
    /// <remarks/>
    public ElementTagType partial { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
public partial class ElementTagType {
}

/// <remarks/>
[System.SerializableAttribute()]
public partial class AlarmListDataSelectorsType {
        
    /// <remarks/>
    public uint alarmId { get; set; }
    
    /// <remarks/>
    public bool alarmIdSpecified { get; set; }
    
    /// <remarks/>
    public string scopeType { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillConstraintsListDataSelectorsType {
    
    private uint billIdField;
    
    private bool billIdFieldSpecified;
    
    /// <remarks/>
    public uint billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool billIdSpecified {
        get {
            return this.billIdFieldSpecified;
        }
        set {
            this.billIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillDescriptionListDataSelectorsType {
    
    private uint billIdField;
    
    private bool billIdFieldSpecified;
    
    /// <remarks/>
    public uint billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool billIdSpecified {
        get {
            return this.billIdFieldSpecified;
        }
        set {
            this.billIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillListDataSelectorsType {
    
    private uint billIdField;
    
    private bool billIdFieldSpecified;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool billIdSpecified {
        get {
            return this.billIdFieldSpecified;
        }
        set {
            this.billIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("bindingManagementEntryListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BindingManagementEntryListDataSelectorsType {
    
    private uint bindingIdField;
    
    private bool bindingIdFieldSpecified;
    
    private FeatureAddressType clientAddressField;
    
    private FeatureAddressType serverAddressField;
    
    /// <remarks/>
    public uint bindingId {
        get {
            return this.bindingIdField;
        }
        set {
            this.bindingIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool bindingIdSpecified {
        get {
            return this.bindingIdFieldSpecified;
        }
        set {
            this.bindingIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class FeatureAddressType : EntityAddressType {
    
    private uint featureField;
    
    private bool featureFieldSpecified;
    
    /// <remarks/>
    public uint feature {
        get {
            return this.featureField;
        }
        set {
            this.featureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool featureSpecified {
        get {
            return this.featureFieldSpecified;
        }
        set {
            this.featureFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureAddressType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class EntityAddressType : DeviceAddressType {
    
    private uint[] entityField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entity")]
    public uint[] entity {
        get {
            return this.entityField;
        }
        set {
            this.entityField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAddressType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureAddressType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class DeviceAddressType {
    
    private string deviceField;
    
    /// <remarks/>
    public string device {
        get {
            return this.deviceField;
        }
        set {
            this.deviceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("commodityListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class CommodityListDataSelectorsType {
    
    private uint commodityIdField;
    
    private bool commodityIdFieldSpecified;
    
    private string commodityTypeField;
    
    /// <remarks/>
    public uint commodityId {
        get {
            return this.commodityIdField;
        }
        set {
            this.commodityIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool commodityIdSpecified {
        get {
            return this.commodityIdFieldSpecified;
        }
        set {
            this.commodityIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string commodityType {
        get {
            return this.commodityTypeField;
        }
        set {
            this.commodityTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueConstraintsListDataSelectorsType {
    
    private uint keyIdField;
    
    private bool keyIdFieldSpecified;
    
    /// <remarks/>
    public uint keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool keyIdSpecified {
        get {
            return this.keyIdFieldSpecified;
        }
        set {
            this.keyIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueDescriptionListDataSelectorsType {
    
    private uint keyIdField;
    
    private bool keyIdFieldSpecified;
    
    private string keyNameField;
    
    /// <remarks/>
    public uint keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool keyIdSpecified {
        get {
            return this.keyIdFieldSpecified;
        }
        set {
            this.keyIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string keyName {
        get {
            return this.keyNameField;
        }
        set {
            this.keyNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueListDataSelectorsType {
    
    private uint keyIdField;
    
    private bool keyIdFieldSpecified;
    
    /// <remarks/>
    public uint keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool keyIdSpecified {
        get {
            return this.keyIdFieldSpecified;
        }
        set {
            this.keyIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("directControlActivityListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DirectControlActivityListDataSelectorsType {
    
    private TimestampIntervalType timestampIntervalField;
    
    /// <remarks/>
    public TimestampIntervalType timestampInterval {
        get {
            return this.timestampIntervalField;
        }
        set {
            this.timestampIntervalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TimestampIntervalType {
    
    private string startTimeField;
    
    private string endTimeField;
    
    /// <remarks/>
    public string startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    public string endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionDescriptionListDataSelectorsType {
    
    private uint electricalConnectionIdField;
    
    private bool electricalConnectionIdFieldSpecified;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool electricalConnectionIdSpecified {
        get {
            return this.electricalConnectionIdFieldSpecified;
        }
        set {
            this.electricalConnectionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionParameterDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionParameterDescriptionListDataSelectorsType {
    
    private uint electricalConnectionIdField;
    
    private bool electricalConnectionIdFieldSpecified;
    
    private uint parameterIdField;
    
    private bool parameterIdFieldSpecified;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool electricalConnectionIdSpecified {
        get {
            return this.electricalConnectionIdFieldSpecified;
        }
        set {
            this.electricalConnectionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint parameterId {
        get {
            return this.parameterIdField;
        }
        set {
            this.parameterIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool parameterIdSpecified {
        get {
            return this.parameterIdFieldSpecified;
        }
        set {
            this.parameterIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionPermittedValueSetListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionPermittedValueSetListDataSelectorsType {
    
    private uint electricalConnectionIdField;
    
    private bool electricalConnectionIdFieldSpecified;
    
    private uint parameterIdField;
    
    private bool parameterIdFieldSpecified;
    
    /// <remarks/>
    public uint electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool electricalConnectionIdSpecified {
        get {
            return this.electricalConnectionIdFieldSpecified;
        }
        set {
            this.electricalConnectionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint parameterId {
        get {
            return this.parameterIdField;
        }
        set {
            this.parameterIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool parameterIdSpecified {
        get {
            return this.parameterIdFieldSpecified;
        }
        set {
            this.parameterIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionStateListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionStateListDataSelectorsType {
    
    private uint electricalConnectionIdField;
    
    private bool electricalConnectionIdFieldSpecified;
    
    /// <remarks/>
    public uint electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool electricalConnectionIdSpecified {
        get {
            return this.electricalConnectionIdFieldSpecified;
        }
        set {
            this.electricalConnectionIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOperationModeDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOperationModeDescriptionListDataSelectorsType {
    
    private uint operationModeIdField;
    
    private bool operationModeIdFieldSpecified;
    
    /// <remarks/>
    public uint operationModeId {
        get {
            return this.operationModeIdField;
        }
        set {
            this.operationModeIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool operationModeIdSpecified {
        get {
            return this.operationModeIdFieldSpecified;
        }
        set {
            this.operationModeIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOverrunDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOverrunDescriptionListDataSelectorsType {
    
    private uint overrunIdField;
    
    private bool overrunIdFieldSpecified;
    
    /// <remarks/>
    public uint overrunId {
        get {
            return this.overrunIdField;
        }
        set {
            this.overrunIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool overrunIdSpecified {
        get {
            return this.overrunIdFieldSpecified;
        }
        set {
            this.overrunIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOverrunListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOverrunListDataSelectorsType {
    
    private uint overrunIdField;
    
    private bool overrunIdFieldSpecified;
    
    /// <remarks/>
    public uint overrunId {
        get {
            return this.overrunIdField;
        }
        set {
            this.overrunIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool overrunIdSpecified {
        get {
            return this.overrunIdFieldSpecified;
        }
        set {
            this.overrunIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionDescriptionListDataSelectorsType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionListDataSelectorsType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionOperationModeRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionOperationModeRelationListDataSelectorsType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionPowerSequenceRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionPowerSequenceRelationListDataSelectorsType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionSetpointRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionSetpointRelationListDataSelectorsType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    private uint operationModeIdField;
    
    private bool operationModeIdFieldSpecified;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint operationModeId {
        get {
            return this.operationModeIdField;
        }
        set {
            this.operationModeIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool operationModeIdSpecified {
        get {
            return this.operationModeIdFieldSpecified;
        }
        set {
            this.operationModeIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("identificationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IdentificationListDataSelectorsType {
    
    private uint identificationIdField;
    
    private bool identificationIdFieldSpecified;
    
    private string identificationTypeField;
    
    /// <remarks/>
    public uint identificationId {
        get {
            return this.identificationIdField;
        }
        set {
            this.identificationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool identificationIdSpecified {
        get {
            return this.identificationIdFieldSpecified;
        }
        set {
            this.identificationIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string identificationType {
        get {
            return this.identificationTypeField;
        }
        set {
            this.identificationTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveDescriptionListDataSelectorsType {
    
    private uint incentiveIdField;
    
    private bool incentiveIdFieldSpecified;
    
    private string incentiveTypeField;
    
    /// <remarks/>
    public uint incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool incentiveIdSpecified {
        get {
            return this.incentiveIdFieldSpecified;
        }
        set {
            this.incentiveIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string incentiveType {
        get {
            return this.incentiveTypeField;
        }
        set {
            this.incentiveTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveListDataSelectorsType {
    
    private uint incentiveIdField;
    
    private bool incentiveIdFieldSpecified;
    
    private string valueTypeField;
    
    private TimestampIntervalType timestampIntervalField;
    
    /// <remarks/>
    public uint incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool incentiveIdSpecified {
        get {
            return this.incentiveIdFieldSpecified;
        }
        set {
            this.incentiveIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public TimestampIntervalType timestampInterval {
        get {
            return this.timestampIntervalField;
        }
        set {
            this.timestampIntervalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableConstraintsDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableConstraintsDataSelectorsType {
    
    private IncentiveTableConstraintsDataSelectorsTypeTariff tariffField;
    
    /// <remarks/>
    public IncentiveTableConstraintsDataSelectorsTypeTariff tariff {
        get {
            return this.tariffField;
        }
        set {
            this.tariffField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsDataSelectorsTypeTariff : TariffListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffListDataSelectorsType {
    
    private uint tariffIdField;
    
    private bool tariffIdFieldSpecified;
    
    private uint activeTierIdField;
    
    private bool activeTierIdFieldSpecified;
    
    /// <remarks/>
    public uint tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffIdSpecified {
        get {
            return this.tariffIdFieldSpecified;
        }
        set {
            this.tariffIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint activeTierId {
        get {
            return this.activeTierIdField;
        }
        set {
            this.activeTierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool activeTierIdSpecified {
        get {
            return this.activeTierIdFieldSpecified;
        }
        set {
            this.activeTierIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableDataSelectorsType {
    
    private IncentiveTableDataSelectorsTypeTariff tariffField;
    
    /// <remarks/>
    public IncentiveTableDataSelectorsTypeTariff tariff {
        get {
            return this.tariffField;
        }
        set {
            this.tariffField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDataSelectorsTypeTariff : TariffListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableDescriptionDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableDescriptionDataSelectorsType {
    
    private IncentiveTableDescriptionDataSelectorsTypeTariffDescription tariffDescriptionField;
    
    /// <remarks/>
    public IncentiveTableDescriptionDataSelectorsTypeTariffDescription tariffDescription {
        get {
            return this.tariffDescriptionField;
        }
        set {
            this.tariffDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionDataSelectorsTypeTariffDescription : TariffDescriptionListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffDescriptionListDataSelectorsType {
    
    private uint tariffIdField;
    
    private bool tariffIdFieldSpecified;
    
    private uint commodityIdField;
    
    private bool commodityIdFieldSpecified;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffIdSpecified {
        get {
            return this.tariffIdFieldSpecified;
        }
        set {
            this.tariffIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint commodityId {
        get {
            return this.commodityIdField;
        }
        set {
            this.commodityIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool commodityIdSpecified {
        get {
            return this.commodityIdFieldSpecified;
        }
        set {
            this.commodityIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlEventListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlEventListDataSelectorsType {
    
    private TimestampIntervalType timestampIntervalField;
    
    private uint eventIdField;
    
    private bool eventIdFieldSpecified;
    
    /// <remarks/>
    public TimestampIntervalType timestampInterval {
        get {
            return this.timestampIntervalField;
        }
        set {
            this.timestampIntervalField = value;
        }
    }
    
    /// <remarks/>
    public uint eventId {
        get {
            return this.eventIdField;
        }
        set {
            this.eventIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool eventIdSpecified {
        get {
            return this.eventIdFieldSpecified;
        }
        set {
            this.eventIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitConstraintsListDataSelectorsType {
    
    private uint limitIdField;
    
    private bool limitIdFieldSpecified;
    
    /// <remarks/>
    public uint limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool limitIdSpecified {
        get {
            return this.limitIdFieldSpecified;
        }
        set {
            this.limitIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitDescriptionListDataSelectorsType {
    
    private uint limitIdField;
    
    private bool limitIdFieldSpecified;
    
    private string limitTypeField;
    
    private string limitDirectionField;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool limitIdSpecified {
        get {
            return this.limitIdFieldSpecified;
        }
        set {
            this.limitIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string limitType {
        get {
            return this.limitTypeField;
        }
        set {
            this.limitTypeField = value;
        }
    }
    
    /// <remarks/>
    public string limitDirection {
        get {
            return this.limitDirectionField;
        }
        set {
            this.limitDirectionField = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitListDataSelectorsType {
    
    private uint limitIdField;
    
    private bool limitIdFieldSpecified;
    
    /// <remarks/>
    public uint limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool limitIdSpecified {
        get {
            return this.limitIdFieldSpecified;
        }
        set {
            this.limitIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlStateListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlStateListDataSelectorsType {
    
    private TimestampIntervalType timestampIntervalField;
    
    private uint eventIdField;
    
    private bool eventIdFieldSpecified;
    
    /// <remarks/>
    public TimestampIntervalType timestampInterval {
        get {
            return this.timestampIntervalField;
        }
        set {
            this.timestampIntervalField = value;
        }
    }
    
    /// <remarks/>
    public uint eventId {
        get {
            return this.eventIdField;
        }
        set {
            this.eventIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool eventIdSpecified {
        get {
            return this.eventIdFieldSpecified;
        }
        set {
            this.eventIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementConstraintsListDataSelectorsType {
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementDescriptionListDataSelectorsType {
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string measurementTypeField;
    
    private string commodityTypeField;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string measurementType {
        get {
            return this.measurementTypeField;
        }
        set {
            this.measurementTypeField = value;
        }
    }
    
    /// <remarks/>
    public string commodityType {
        get {
            return this.commodityTypeField;
        }
        set {
            this.commodityTypeField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementListDataSelectorsType {
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string valueTypeField;
    
    private TimestampIntervalType timestampIntervalField;
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public TimestampIntervalType timestampInterval {
        get {
            return this.timestampIntervalField;
        }
        set {
            this.timestampIntervalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementThresholdRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementThresholdRelationListDataSelectorsType {
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("messagingListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MessagingListDataSelectorsType {
    
    private TimestampIntervalType timestampIntervalField;
    
    private uint messagingNumberField;
    
    private bool messagingNumberFieldSpecified;
    
    /// <remarks/>
    public TimestampIntervalType timestampInterval {
        get {
            return this.timestampIntervalField;
        }
        set {
            this.timestampIntervalField = value;
        }
    }
    
    /// <remarks/>
    public uint messagingNumber {
        get {
            return this.messagingNumberField;
        }
        set {
            this.messagingNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool messagingNumberSpecified {
        get {
            return this.messagingNumberFieldSpecified;
        }
        set {
            this.messagingNumberFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementDeviceDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementDeviceDescriptionListDataSelectorsType {
    
    private DeviceAddressType deviceAddressField;
    
    private string deviceTypeField;
    
    /// <remarks/>
    public DeviceAddressType deviceAddress {
        get {
            return this.deviceAddressField;
        }
        set {
            this.deviceAddressField = value;
        }
    }
    
    /// <remarks/>
    public string deviceType {
        get {
            return this.deviceTypeField;
        }
        set {
            this.deviceTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementEntityDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementEntityDescriptionListDataSelectorsType {
    
    private EntityAddressType entityAddressField;
    
    private string entityTypeField;
    
    /// <remarks/>
    public EntityAddressType entityAddress {
        get {
            return this.entityAddressField;
        }
        set {
            this.entityAddressField = value;
        }
    }
    
    /// <remarks/>
    public string entityType {
        get {
            return this.entityTypeField;
        }
        set {
            this.entityTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementFeatureDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementFeatureDescriptionListDataSelectorsType {
    
    private FeatureAddressType featureAddressField;
    
    private string featureTypeField;
    
    /// <remarks/>
    public FeatureAddressType featureAddress {
        get {
            return this.featureAddressField;
        }
        set {
            this.featureAddressField = value;
        }
    }
    
    /// <remarks/>
    public string featureType {
        get {
            return this.featureTypeField;
        }
        set {
            this.featureTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementBindingDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementBindingDataSelectorsType {
    
    private NodeManagementBindingDataSelectorsTypeBindingEntry bindingEntryField;
    
    /// <remarks/>
    public NodeManagementBindingDataSelectorsTypeBindingEntry bindingEntry {
        get {
            return this.bindingEntryField;
        }
        set {
            this.bindingEntryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementBindingDataSelectorsTypeBindingEntry : BindingManagementEntryListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementDestinationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementDestinationListDataSelectorsType {
    
    private NodeManagementDestinationListDataSelectorsTypeDeviceDescription deviceDescriptionField;
    
    /// <remarks/>
    public NodeManagementDestinationListDataSelectorsTypeDeviceDescription deviceDescription {
        get {
            return this.deviceDescriptionField;
        }
        set {
            this.deviceDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDestinationListDataSelectorsTypeDeviceDescription : NetworkManagementDeviceDescriptionListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementDetailedDiscoveryDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementDetailedDiscoveryDataSelectorsType {
    
    private NodeManagementDetailedDiscoveryDataSelectorsTypeDeviceInformation deviceInformationField;
    
    private NodeManagementDetailedDiscoveryDataSelectorsTypeEntityInformation entityInformationField;
    
    private NodeManagementDetailedDiscoveryDataSelectorsTypeFeatureInformation featureInformationField;
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDataSelectorsTypeDeviceInformation deviceInformation {
        get {
            return this.deviceInformationField;
        }
        set {
            this.deviceInformationField = value;
        }
    }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDataSelectorsTypeEntityInformation entityInformation {
        get {
            return this.entityInformationField;
        }
        set {
            this.entityInformationField = value;
        }
    }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDataSelectorsTypeFeatureInformation featureInformation {
        get {
            return this.featureInformationField;
        }
        set {
            this.featureInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryDataSelectorsTypeDeviceInformation : NetworkManagementDeviceDescriptionListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryDataSelectorsTypeEntityInformation : NetworkManagementEntityDescriptionListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryDataSelectorsTypeFeatureInformation : NetworkManagementFeatureDescriptionListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementSubscriptionDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementSubscriptionDataSelectorsType {
    
    private NodeManagementSubscriptionDataSelectorsTypeSubscriptionEntry subscriptionEntryField;
    
    /// <remarks/>
    public NodeManagementSubscriptionDataSelectorsTypeSubscriptionEntry subscriptionEntry {
        get {
            return this.subscriptionEntryField;
        }
        set {
            this.subscriptionEntryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSubscriptionDataSelectorsTypeSubscriptionEntry : SubscriptionManagementEntryListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("subscriptionManagementEntryListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SubscriptionManagementEntryListDataSelectorsType {
    
    private uint subscriptionIdField;
    
    private bool subscriptionIdFieldSpecified;
    
    private FeatureAddressType clientAddressField;
    
    private FeatureAddressType serverAddressField;
    
    /// <remarks/>
    public uint subscriptionId {
        get {
            return this.subscriptionIdField;
        }
        set {
            this.subscriptionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool subscriptionIdSpecified {
        get {
            return this.subscriptionIdFieldSpecified;
        }
        set {
            this.subscriptionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementUseCaseDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementUseCaseDataSelectorsType {
    
    private NodeManagementUseCaseDataSelectorsTypeUseCaseInformation useCaseInformationField;
    
    /// <remarks/>
    public NodeManagementUseCaseDataSelectorsTypeUseCaseInformation useCaseInformation {
        get {
            return this.useCaseInformationField;
        }
        set {
            this.useCaseInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementUseCaseDataSelectorsTypeUseCaseInformation : UseCaseInformationListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("useCaseInformationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class UseCaseInformationListDataSelectorsType {
    
    private FeatureAddressType addressField;
    
    private string actorField;
    
    private UseCaseSupportSelectorsType useCaseSupportField;
    
    /// <remarks/>
    public FeatureAddressType address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string actor {
        get {
            return this.actorField;
        }
        set {
            this.actorField = value;
        }
    }
    
    /// <remarks/>
    public UseCaseSupportSelectorsType useCaseSupport {
        get {
            return this.useCaseSupportField;
        }
        set {
            this.useCaseSupportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class UseCaseSupportSelectorsType {
    
    private string useCaseNameField;
    
    private string useCaseVersionField;
    
    private uint scenarioSupportField;
    
    private bool scenarioSupportFieldSpecified;
    
    /// <remarks/>
    public string useCaseName {
        get {
            return this.useCaseNameField;
        }
        set {
            this.useCaseNameField = value;
        }
    }
    
    /// <remarks/>
    public string useCaseVersion {
        get {
            return this.useCaseVersionField;
        }
        set {
            this.useCaseVersionField = value;
        }
    }
    
    /// <remarks/>
    public uint scenarioSupport {
        get {
            return this.scenarioSupportField;
        }
        set {
            this.scenarioSupportField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool scenarioSupportSpecified {
        get {
            return this.scenarioSupportFieldSpecified;
        }
        set {
            this.scenarioSupportFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsDurationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsDurationListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsInterruptListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsInterruptListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerDescriptionListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerLevelListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerLevelListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerRangeListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerRangeListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsResumeImplicationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsResumeImplicationListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceAlternativesRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceAlternativesRelationListDataSelectorsType {
    
    private uint alternativesIdField;
    
    private bool alternativesIdFieldSpecified;
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint alternativesId {
        get {
            return this.alternativesIdField;
        }
        set {
            this.alternativesIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool alternativesIdSpecified {
        get {
            return this.alternativesIdFieldSpecified;
        }
        set {
            this.alternativesIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceDescriptionListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequencePriceListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequencePriceListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private TimestampIntervalType potentialStartTimeIntervalField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimestampIntervalType potentialStartTimeInterval {
        get {
            return this.potentialStartTimeIntervalField;
        }
        set {
            this.potentialStartTimeIntervalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleConstraintsListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceSchedulePreferenceListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceSchedulePreferenceListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceStateListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceStateListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotScheduleConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotScheduleConstraintsListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private uint slotNumberField;
    
    private bool slotNumberFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotNumberSpecified {
        get {
            return this.slotNumberFieldSpecified;
        }
        set {
            this.slotNumberFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotScheduleListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotScheduleListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private uint slotNumberField;
    
    private bool slotNumberFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotNumberSpecified {
        get {
            return this.slotNumberFieldSpecified;
        }
        set {
            this.slotNumberFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotValueListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotValueListDataSelectorsType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private uint slotNumberField;
    
    private bool slotNumberFieldSpecified;
    
    private string valueTypeField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotNumberSpecified {
        get {
            return this.slotNumberFieldSpecified;
        }
        set {
            this.slotNumberFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("sensingListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SensingListDataSelectorsType {
    
    private TimestampIntervalType timestampIntervalField;
    
    /// <remarks/>
    public TimestampIntervalType timestampInterval {
        get {
            return this.timestampIntervalField;
        }
        set {
            this.timestampIntervalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointConstraintsListDataSelectorsType {
    
    private uint setpointIdField;
    
    private bool setpointIdFieldSpecified;
    
    /// <remarks/>
    public uint setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool setpointIdSpecified {
        get {
            return this.setpointIdFieldSpecified;
        }
        set {
            this.setpointIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointDescriptionListDataSelectorsType {
    
    private uint setpointIdField;
    
    private bool setpointIdFieldSpecified;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private string setpointTypeField;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool setpointIdSpecified {
        get {
            return this.setpointIdFieldSpecified;
        }
        set {
            this.setpointIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string setpointType {
        get {
            return this.setpointTypeField;
        }
        set {
            this.setpointTypeField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointListDataSelectorsType {
    
    private uint setpointIdField;
    
    private bool setpointIdFieldSpecified;
    
    /// <remarks/>
    public uint setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool setpointIdSpecified {
        get {
            return this.setpointIdFieldSpecified;
        }
        set {
            this.setpointIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsDataSelectorsType {
    
    private SmartEnergyManagementPsDataSelectorsTypeAlternativesRelation alternativesRelationField;
    
    private SmartEnergyManagementPsDataSelectorsTypePowerSequenceDescription powerSequenceDescriptionField;
    
    private SmartEnergyManagementPsDataSelectorsTypePowerTimeSlotSchedule powerTimeSlotScheduleField;
    
    private SmartEnergyManagementPsDataSelectorsTypePowerTimeSlotValue powerTimeSlotValueField;
    
    /// <remarks/>
    public SmartEnergyManagementPsDataSelectorsTypeAlternativesRelation alternativesRelation {
        get {
            return this.alternativesRelationField;
        }
        set {
            this.alternativesRelationField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsDataSelectorsTypePowerSequenceDescription powerSequenceDescription {
        get {
            return this.powerSequenceDescriptionField;
        }
        set {
            this.powerSequenceDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsDataSelectorsTypePowerTimeSlotSchedule powerTimeSlotSchedule {
        get {
            return this.powerTimeSlotScheduleField;
        }
        set {
            this.powerTimeSlotScheduleField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsDataSelectorsTypePowerTimeSlotValue powerTimeSlotValue {
        get {
            return this.powerTimeSlotValueField;
        }
        set {
            this.powerTimeSlotValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsDataSelectorsTypeAlternativesRelation : PowerSequenceAlternativesRelationListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsDataSelectorsTypePowerSequenceDescription : PowerSequenceDescriptionListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsDataSelectorsTypePowerTimeSlotSchedule : PowerTimeSlotScheduleListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsDataSelectorsTypePowerTimeSlotValue : PowerTimeSlotValueListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsPriceDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsPriceDataSelectorsType {
    
    private SmartEnergyManagementPsPriceDataSelectorsTypePrice priceField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceDataSelectorsTypePrice price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPriceDataSelectorsTypePrice : PowerSequencePriceListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("specificationVersionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SpecificationVersionListDataSelectorsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionDescriptionListDataSelectorsType {
    
    private uint conditionIdField;
    
    private bool conditionIdFieldSpecified;
    
    /// <remarks/>
    public uint conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conditionIdSpecified {
        get {
            return this.conditionIdFieldSpecified;
        }
        set {
            this.conditionIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionListDataSelectorsType {
    
    private uint conditionIdField;
    
    private bool conditionIdFieldSpecified;
    
    private TimestampIntervalType timestampIntervalField;
    
    private string eventTypeField;
    
    private string originatorField;
    
    /// <remarks/>
    public uint conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conditionIdSpecified {
        get {
            return this.conditionIdFieldSpecified;
        }
        set {
            this.conditionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimestampIntervalType timestampInterval {
        get {
            return this.timestampIntervalField;
        }
        set {
            this.timestampIntervalField = value;
        }
    }
    
    /// <remarks/>
    public string eventType {
        get {
            return this.eventTypeField;
        }
        set {
            this.eventTypeField = value;
        }
    }
    
    /// <remarks/>
    public string originator {
        get {
            return this.originatorField;
        }
        set {
            this.originatorField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionThresholdRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionThresholdRelationListDataSelectorsType {
    
    private uint conditionIdField;
    
    private bool conditionIdFieldSpecified;
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    /// <remarks/>
    public uint conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conditionIdSpecified {
        get {
            return this.conditionIdFieldSpecified;
        }
        set {
            this.conditionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffBoundaryRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffBoundaryRelationListDataSelectorsType {
    
    private uint tariffIdField;
    
    private bool tariffIdFieldSpecified;
    
    private uint boundaryIdField;
    
    private bool boundaryIdFieldSpecified;
    
    /// <remarks/>
    public uint tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffIdSpecified {
        get {
            return this.tariffIdFieldSpecified;
        }
        set {
            this.tariffIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool boundaryIdSpecified {
        get {
            return this.boundaryIdFieldSpecified;
        }
        set {
            this.boundaryIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffTierRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffTierRelationListDataSelectorsType {
    
    private uint tariffIdField;
    
    private bool tariffIdFieldSpecified;
    
    private uint tierIdField;
    
    private bool tierIdFieldSpecified;
    
    /// <remarks/>
    public uint tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffIdSpecified {
        get {
            return this.tariffIdFieldSpecified;
        }
        set {
            this.tariffIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tierIdSpecified {
        get {
            return this.tierIdFieldSpecified;
        }
        set {
            this.tierIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobDescriptionListDataSelectorsType {
    
    private uint jobIdField;
    
    private bool jobIdFieldSpecified;
    
    private string jobSourceField;
    
    /// <remarks/>
    public uint jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool jobIdSpecified {
        get {
            return this.jobIdFieldSpecified;
        }
        set {
            this.jobIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string jobSource {
        get {
            return this.jobSourceField;
        }
        set {
            this.jobSourceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobListDataSelectorsType {
    
    private uint jobIdField;
    
    private bool jobIdFieldSpecified;
    
    private string jobStateField;
    
    /// <remarks/>
    public uint jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool jobIdSpecified {
        get {
            return this.jobIdFieldSpecified;
        }
        set {
            this.jobIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string jobState {
        get {
            return this.jobStateField;
        }
        set {
            this.jobStateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobRelationListDataSelectorsType {
    
    private uint jobIdField;
    
    private bool jobIdFieldSpecified;
    
    /// <remarks/>
    public uint jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool jobIdSpecified {
        get {
            return this.jobIdFieldSpecified;
        }
        set {
            this.jobIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdConstraintsListDataSelectorsType {
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdDescriptionListDataSelectorsType {
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdListDataSelectorsType {
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierBoundaryDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierBoundaryDescriptionListDataSelectorsType {
    
    private uint boundaryIdField;
    
    private bool boundaryIdFieldSpecified;
    
    private string boundaryTypeField;
    
    /// <remarks/>
    public uint boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool boundaryIdSpecified {
        get {
            return this.boundaryIdFieldSpecified;
        }
        set {
            this.boundaryIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string boundaryType {
        get {
            return this.boundaryTypeField;
        }
        set {
            this.boundaryTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierBoundaryListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierBoundaryListDataSelectorsType {
    
    private uint boundaryIdField;
    
    private bool boundaryIdFieldSpecified;
    
    /// <remarks/>
    public uint boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool boundaryIdSpecified {
        get {
            return this.boundaryIdFieldSpecified;
        }
        set {
            this.boundaryIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierDescriptionListDataSelectorsType {
    
    private uint tierIdField;
    
    private bool tierIdFieldSpecified;
    
    private string tierTypeField;
    
    /// <remarks/>
    public uint tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tierIdSpecified {
        get {
            return this.tierIdFieldSpecified;
        }
        set {
            this.tierIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string tierType {
        get {
            return this.tierTypeField;
        }
        set {
            this.tierTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierIncentiveRelationListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierIncentiveRelationListDataSelectorsType {
    
    private uint tierIdField;
    
    private bool tierIdFieldSpecified;
    
    private uint incentiveIdField;
    
    private bool incentiveIdFieldSpecified;
    
    /// <remarks/>
    public uint tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tierIdSpecified {
        get {
            return this.tierIdFieldSpecified;
        }
        set {
            this.tierIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool incentiveIdSpecified {
        get {
            return this.incentiveIdFieldSpecified;
        }
        set {
            this.incentiveIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierListDataSelectorsType {
    
    private uint tierIdField;
    
    private bool tierIdFieldSpecified;
    
    private uint activeIncentiveIdField;
    
    private bool activeIncentiveIdFieldSpecified;
    
    /// <remarks/>
    public uint tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tierIdSpecified {
        get {
            return this.tierIdFieldSpecified;
        }
        set {
            this.tierIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint activeIncentiveId {
        get {
            return this.activeIncentiveIdField;
        }
        set {
            this.activeIncentiveIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool activeIncentiveIdSpecified {
        get {
            return this.activeIncentiveIdFieldSpecified;
        }
        set {
            this.activeIncentiveIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesConstraintsListDataSelectorsType {
    
    private uint timeSeriesIdField;
    
    private bool timeSeriesIdFieldSpecified;
    
    /// <remarks/>
    public uint timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesIdSpecified {
        get {
            return this.timeSeriesIdFieldSpecified;
        }
        set {
            this.timeSeriesIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesDescriptionListDataSelectorsType {
    
    private uint timeSeriesIdField;
    
    private bool timeSeriesIdFieldSpecified;
    
    private string timeSeriesTypeField;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesIdSpecified {
        get {
            return this.timeSeriesIdFieldSpecified;
        }
        set {
            this.timeSeriesIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string timeSeriesType {
        get {
            return this.timeSeriesTypeField;
        }
        set {
            this.timeSeriesTypeField = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesListDataSelectorsType {
    
    private uint timeSeriesIdField;
    
    private bool timeSeriesIdFieldSpecified;
    
    private uint timeSeriesSlotIdField;
    
    private bool timeSeriesSlotIdFieldSpecified;
    
    /// <remarks/>
    public uint timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesIdSpecified {
        get {
            return this.timeSeriesIdFieldSpecified;
        }
        set {
            this.timeSeriesIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint timeSeriesSlotId {
        get {
            return this.timeSeriesSlotIdField;
        }
        set {
            this.timeSeriesSlotIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesSlotIdSpecified {
        get {
            return this.timeSeriesSlotIdFieldSpecified;
        }
        set {
            this.timeSeriesSlotIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableConstraintsListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableConstraintsListDataSelectorsType {
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableDescriptionListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableDescriptionListDataSelectorsType {
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableListDataSelectors", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableListDataSelectorsType {
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private uint timeSlotIdField;
    
    private bool timeSlotIdFieldSpecified;
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint timeSlotId {
        get {
            return this.timeSlotIdField;
        }
        set {
            this.timeSlotIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSlotIdSpecified {
        get {
            return this.timeSlotIdFieldSpecified;
        }
        set {
            this.timeSlotIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("actuatorLevelDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ActuatorLevelDataElementsType {
    
    private ElementTagType functionField;
    
    private ScaledNumberElementsType valueField;
    
    /// <remarks/>
    public ElementTagType function {
        get {
            return this.functionField;
        }
        set {
            this.functionField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class ScaledNumberElementsType {
    
    private ElementTagType numberField;
    
    private ElementTagType scaleField;
    
    /// <remarks/>
    public ElementTagType number {
        get {
            return this.numberField;
        }
        set {
            this.numberField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scale {
        get {
            return this.scaleField;
        }
        set {
            this.scaleField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("actuatorLevelDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ActuatorLevelDescriptionDataElementsType {
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    private ElementTagType levelDefaultUnitField;
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType levelDefaultUnit {
        get {
            return this.levelDefaultUnitField;
        }
        set {
            this.levelDefaultUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("actuatorSwitchDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ActuatorSwitchDataElementsType {
    
    private ElementTagType functionField;
    
    /// <remarks/>
    public ElementTagType function {
        get {
            return this.functionField;
        }
        set {
            this.functionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("actuatorSwitchDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ActuatorSwitchDescriptionDataElementsType {
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("alarmDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class AlarmDataElementsType {
    
    private ElementTagType alarmIdField;
    
    private ElementTagType thresholdIdField;
    
    private ElementTagType timestampField;
    
    private ElementTagType alarmTypeField;
    
    private ScaledNumberElementsType measuredValueField;
    
    private TimePeriodElementsType evaluationPeriodField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType alarmId {
        get {
            return this.alarmIdField;
        }
        set {
            this.alarmIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType alarmType {
        get {
            return this.alarmTypeField;
        }
        set {
            this.alarmTypeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType measuredValue {
        get {
            return this.measuredValueField;
        }
        set {
            this.measuredValueField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType evaluationPeriod {
        get {
            return this.evaluationPeriodField;
        }
        set {
            this.evaluationPeriodField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TimePeriodElementsType {
    
    private ElementTagType startTimeField;
    
    private ElementTagType endTimeField;
    
    /// <remarks/>
    public ElementTagType startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillConstraintsDataElementsType {
    
    private ElementTagType billIdField;
    
    private ElementTagType positionCountMinField;
    
    private ElementTagType positionCountMaxField;
    
    /// <remarks/>
    public ElementTagType billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType positionCountMin {
        get {
            return this.positionCountMinField;
        }
        set {
            this.positionCountMinField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType positionCountMax {
        get {
            return this.positionCountMaxField;
        }
        set {
            this.positionCountMaxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillDataElementsType {
    
    private ElementTagType billIdField;
    
    private ElementTagType billTypeField;
    
    private ElementTagType scopeTypeField;
    
    private BillDataElementsTypeTotal totalField;
    
    private BillDataElementsTypePosition positionField;
    
    /// <remarks/>
    public ElementTagType billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType billType {
        get {
            return this.billTypeField;
        }
        set {
            this.billTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public BillDataElementsTypeTotal total {
        get {
            return this.totalField;
        }
        set {
            this.totalField = value;
        }
    }
    
    /// <remarks/>
    public BillDataElementsTypePosition position {
        get {
            return this.positionField;
        }
        set {
            this.positionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillDataElementsTypeTotal : BillPositionElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillPositionElementsType {
    
    private ElementTagType positionIdField;
    
    private ElementTagType positionTypeField;
    
    private TimePeriodElementsType timePeriodField;
    
    private BillValueElementsType valueField;
    
    private BillCostElementsType costField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType positionId {
        get {
            return this.positionIdField;
        }
        set {
            this.positionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType positionType {
        get {
            return this.positionTypeField;
        }
        set {
            this.positionTypeField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public BillValueElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public BillCostElementsType cost {
        get {
            return this.costField;
        }
        set {
            this.costField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillValueElementsType {
    
    private ElementTagType valueIdField;
    
    private ElementTagType unitField;
    
    private ScaledNumberElementsType valueField;
    
    private ScaledNumberElementsType valuePercentageField;
    
    /// <remarks/>
    public ElementTagType valueId {
        get {
            return this.valueIdField;
        }
        set {
            this.valueIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valuePercentage {
        get {
            return this.valuePercentageField;
        }
        set {
            this.valuePercentageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillCostElementsType {
    
    private ElementTagType costIdField;
    
    private ElementTagType costTypeField;
    
    private ElementTagType valueIdField;
    
    private ElementTagType unitField;
    
    private ElementTagType currencyField;
    
    private ScaledNumberElementsType costField;
    
    private ScaledNumberElementsType costPercentageField;
    
    /// <remarks/>
    public ElementTagType costId {
        get {
            return this.costIdField;
        }
        set {
            this.costIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType costType {
        get {
            return this.costTypeField;
        }
        set {
            this.costTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueId {
        get {
            return this.valueIdField;
        }
        set {
            this.valueIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType cost {
        get {
            return this.costField;
        }
        set {
            this.costField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType costPercentage {
        get {
            return this.costPercentageField;
        }
        set {
            this.costPercentageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillDataElementsTypePosition : BillPositionElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillDescriptionDataElementsType {
    
    private ElementTagType billIdField;
    
    private ElementTagType billWriteableField;
    
    private ElementTagType updateRequiredField;
    
    private ElementTagType supportedBillTypeField;
    
    /// <remarks/>
    public ElementTagType billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType billWriteable {
        get {
            return this.billWriteableField;
        }
        set {
            this.billWriteableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType updateRequired {
        get {
            return this.updateRequiredField;
        }
        set {
            this.updateRequiredField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType supportedBillType {
        get {
            return this.supportedBillTypeField;
        }
        set {
            this.supportedBillTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("bindingManagementDeleteCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BindingManagementDeleteCallElementsType {
    
    private ElementTagType bindingIdField;
    
    private FeatureAddressElementsType clientAddressField;
    
    private FeatureAddressElementsType serverAddressField;
    
    /// <remarks/>
    public ElementTagType bindingId {
        get {
            return this.bindingIdField;
        }
        set {
            this.bindingIdField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class FeatureAddressElementsType : EntityAddressElementsType {
    
    private ElementTagType featureField;
    
    /// <remarks/>
    public ElementTagType feature {
        get {
            return this.featureField;
        }
        set {
            this.featureField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureAddressElementsType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class EntityAddressElementsType : DeviceAddressElementsType {
    
    private ElementTagType entityField;
    
    /// <remarks/>
    public ElementTagType entity {
        get {
            return this.entityField;
        }
        set {
            this.entityField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityAddressElementsType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(FeatureAddressElementsType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class DeviceAddressElementsType {
    
    private ElementTagType deviceField;
    
    /// <remarks/>
    public ElementTagType device {
        get {
            return this.deviceField;
        }
        set {
            this.deviceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("bindingManagementEntryDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BindingManagementEntryDataElementsType {
    
    private ElementTagType bindingIdField;
    
    private FeatureAddressElementsType clientAddressField;
    
    private FeatureAddressElementsType serverAddressField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType bindingId {
        get {
            return this.bindingIdField;
        }
        set {
            this.bindingIdField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("bindingManagementRequestCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BindingManagementRequestCallElementsType {
    
    private FeatureAddressElementsType clientAddressField;
    
    private FeatureAddressElementsType serverAddressField;
    
    private ElementTagType serverFeatureTypeField;
    
    /// <remarks/>
    public FeatureAddressElementsType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType serverFeatureType {
        get {
            return this.serverFeatureTypeField;
        }
        set {
            this.serverFeatureTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("commodityDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class CommodityDataElementsType {
    
    private ElementTagType commodityIdField;
    
    private ElementTagType commodityTypeField;
    
    private ElementTagType positiveEnergyDirectionField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType commodityId {
        get {
            return this.commodityIdField;
        }
        set {
            this.commodityIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType commodityType {
        get {
            return this.commodityTypeField;
        }
        set {
            this.commodityTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("dataTunnelingCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DataTunnelingCallElementsType {
    
    private DataTunnelingHeaderElementsType headerField;
    
    private ElementTagType payloadField;
    
    /// <remarks/>
    public DataTunnelingHeaderElementsType header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType payload {
        get {
            return this.payloadField;
        }
        set {
            this.payloadField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class DataTunnelingHeaderElementsType {
    
    private ElementTagType purposeIdField;
    
    private ElementTagType channelIdField;
    
    private ElementTagType sequenceIdField;
    
    /// <remarks/>
    public ElementTagType purposeId {
        get {
            return this.purposeIdField;
        }
        set {
            this.purposeIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType channelId {
        get {
            return this.channelIdField;
        }
        set {
            this.channelIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceClassificationManufacturerDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceClassificationManufacturerDataElementsType {
    
    private ElementTagType deviceNameField;
    
    private ElementTagType deviceCodeField;
    
    private ElementTagType serialNumberField;
    
    private ElementTagType softwareRevisionField;
    
    private ElementTagType hardwareRevisionField;
    
    private ElementTagType vendorNameField;
    
    private ElementTagType vendorCodeField;
    
    private ElementTagType brandNameField;
    
    private ElementTagType powerSourceField;
    
    private ElementTagType manufacturerNodeIdentificationField;
    
    private ElementTagType manufacturerLabelField;
    
    private ElementTagType manufacturerDescriptionField;
    
    /// <remarks/>
    public ElementTagType deviceName {
        get {
            return this.deviceNameField;
        }
        set {
            this.deviceNameField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType deviceCode {
        get {
            return this.deviceCodeField;
        }
        set {
            this.deviceCodeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType serialNumber {
        get {
            return this.serialNumberField;
        }
        set {
            this.serialNumberField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType softwareRevision {
        get {
            return this.softwareRevisionField;
        }
        set {
            this.softwareRevisionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType hardwareRevision {
        get {
            return this.hardwareRevisionField;
        }
        set {
            this.hardwareRevisionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType vendorName {
        get {
            return this.vendorNameField;
        }
        set {
            this.vendorNameField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType vendorCode {
        get {
            return this.vendorCodeField;
        }
        set {
            this.vendorCodeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType brandName {
        get {
            return this.brandNameField;
        }
        set {
            this.brandNameField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType powerSource {
        get {
            return this.powerSourceField;
        }
        set {
            this.powerSourceField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType manufacturerNodeIdentification {
        get {
            return this.manufacturerNodeIdentificationField;
        }
        set {
            this.manufacturerNodeIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType manufacturerLabel {
        get {
            return this.manufacturerLabelField;
        }
        set {
            this.manufacturerLabelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType manufacturerDescription {
        get {
            return this.manufacturerDescriptionField;
        }
        set {
            this.manufacturerDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceClassificationUserDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceClassificationUserDataElementsType {
    
    private ElementTagType userNodeIdentificationField;
    
    private ElementTagType userLabelField;
    
    private ElementTagType userDescriptionField;
    
    /// <remarks/>
    public ElementTagType userNodeIdentification {
        get {
            return this.userNodeIdentificationField;
        }
        set {
            this.userNodeIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType userLabel {
        get {
            return this.userLabelField;
        }
        set {
            this.userLabelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType userDescription {
        get {
            return this.userDescriptionField;
        }
        set {
            this.userDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueConstraintsDataElementsType {
    
    private ElementTagType keyIdField;
    
    private DeviceConfigurationKeyValueValueElementsType valueRangeMinField;
    
    private DeviceConfigurationKeyValueValueElementsType valueRangeMaxField;
    
    private DeviceConfigurationKeyValueValueElementsType valueStepSizeField;
    
    /// <remarks/>
    public ElementTagType keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueValueElementsType valueRangeMin {
        get {
            return this.valueRangeMinField;
        }
        set {
            this.valueRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueValueElementsType valueRangeMax {
        get {
            return this.valueRangeMaxField;
        }
        set {
            this.valueRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueValueElementsType valueStepSize {
        get {
            return this.valueStepSizeField;
        }
        set {
            this.valueStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class DeviceConfigurationKeyValueValueElementsType {
    
    private ElementTagType booleanField;
    
    private ElementTagType dateField;
    
    private ElementTagType dateTimeField;
    
    private ElementTagType durationField;
    
    private ElementTagType stringField;
    
    private ElementTagType timeField;
    
    private ScaledNumberElementsType scaledNumberField;
    
    /// <remarks/>
    public ElementTagType boolean {
        get {
            return this.booleanField;
        }
        set {
            this.booleanField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType dateTime {
        get {
            return this.dateTimeField;
        }
        set {
            this.dateTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType duration {
        get {
            return this.durationField;
        }
        set {
            this.durationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType @string {
        get {
            return this.stringField;
        }
        set {
            this.stringField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType time {
        get {
            return this.timeField;
        }
        set {
            this.timeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType scaledNumber {
        get {
            return this.scaledNumberField;
        }
        set {
            this.scaledNumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueDataElementsType {
    
    private ElementTagType keyIdField;
    
    private DeviceConfigurationKeyValueValueElementsType valueField;
    
    private ElementTagType isValueChangeableField;
    
    /// <remarks/>
    public ElementTagType keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueValueElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isValueChangeable {
        get {
            return this.isValueChangeableField;
        }
        set {
            this.isValueChangeableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueDescriptionDataElementsType {
    
    private ElementTagType keyIdField;
    
    private ElementTagType keyNameField;
    
    private ElementTagType valueTypeField;
    
    private ElementTagType unitField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType keyName {
        get {
            return this.keyNameField;
        }
        set {
            this.keyNameField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceDiagnosisHeartbeatDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceDiagnosisHeartbeatDataElementsType {
    
    private ElementTagType timestampField;
    
    private ElementTagType heartbeatCounterField;
    
    private ElementTagType heartbeatTimeoutField;
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType heartbeatCounter {
        get {
            return this.heartbeatCounterField;
        }
        set {
            this.heartbeatCounterField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType heartbeatTimeout {
        get {
            return this.heartbeatTimeoutField;
        }
        set {
            this.heartbeatTimeoutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceDiagnosisServiceDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceDiagnosisServiceDataElementsType {
    
    private ElementTagType timestampField;
    
    private ElementTagType installationTimeField;
    
    private ElementTagType bootCounterField;
    
    private ElementTagType nextServiceField;
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType installationTime {
        get {
            return this.installationTimeField;
        }
        set {
            this.installationTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType bootCounter {
        get {
            return this.bootCounterField;
        }
        set {
            this.bootCounterField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType nextService {
        get {
            return this.nextServiceField;
        }
        set {
            this.nextServiceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceDiagnosisStateDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceDiagnosisStateDataElementsType {
    
    private ElementTagType timestampField;
    
    private ElementTagType operatingStateField;
    
    private ElementTagType vendorStateCodeField;
    
    private ElementTagType lastErrorCodeField;
    
    private ElementTagType upTimeField;
    
    private ElementTagType totalUpTimeField;
    
    private ElementTagType powerSupplyConditionField;
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType operatingState {
        get {
            return this.operatingStateField;
        }
        set {
            this.operatingStateField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType vendorStateCode {
        get {
            return this.vendorStateCodeField;
        }
        set {
            this.vendorStateCodeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType lastErrorCode {
        get {
            return this.lastErrorCodeField;
        }
        set {
            this.lastErrorCodeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType upTime {
        get {
            return this.upTimeField;
        }
        set {
            this.upTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType totalUpTime {
        get {
            return this.totalUpTimeField;
        }
        set {
            this.totalUpTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType powerSupplyCondition {
        get {
            return this.powerSupplyConditionField;
        }
        set {
            this.powerSupplyConditionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("directControlActivityDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DirectControlActivityDataElementsType {
    
    private ElementTagType timestampField;
    
    private ElementTagType activityStateField;
    
    private ElementTagType isActivityStateChangeableField;
    
    private ElementTagType energyModeField;
    
    private ElementTagType isEnergyModeChangeableField;
    
    private ScaledNumberElementsType powerField;
    
    private ElementTagType isPowerChangeableField;
    
    private ScaledNumberElementsType energyField;
    
    private ElementTagType isEnergyChangeableField;
    
    private ElementTagType sequenceIdField;
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activityState {
        get {
            return this.activityStateField;
        }
        set {
            this.activityStateField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isActivityStateChangeable {
        get {
            return this.isActivityStateChangeableField;
        }
        set {
            this.isActivityStateChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType energyMode {
        get {
            return this.energyModeField;
        }
        set {
            this.energyModeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isEnergyModeChangeable {
        get {
            return this.isEnergyModeChangeableField;
        }
        set {
            this.isEnergyModeChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType power {
        get {
            return this.powerField;
        }
        set {
            this.powerField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isPowerChangeable {
        get {
            return this.isPowerChangeableField;
        }
        set {
            this.isPowerChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType energy {
        get {
            return this.energyField;
        }
        set {
            this.energyField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isEnergyChangeable {
        get {
            return this.isEnergyChangeableField;
        }
        set {
            this.isEnergyChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("directControlDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DirectControlDescriptionDataElementsType {
    
    private ElementTagType positiveEnergyDirectionField;
    
    private ElementTagType powerUnitField;
    
    private ElementTagType energyUnitField;
    
    /// <remarks/>
    public ElementTagType positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType powerUnit {
        get {
            return this.powerUnitField;
        }
        set {
            this.powerUnitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType energyUnit {
        get {
            return this.energyUnitField;
        }
        set {
            this.energyUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionDescriptionDataElementsType {
    
    private ElementTagType electricalConnectionIdField;
    
    private ElementTagType powerSupplyTypeField;
    
    private ElementTagType acConnectedPhasesField;
    
    private ElementTagType acRmsPeriodDurationField;
    
    private ElementTagType positiveEnergyDirectionField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType powerSupplyType {
        get {
            return this.powerSupplyTypeField;
        }
        set {
            this.powerSupplyTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType acConnectedPhases {
        get {
            return this.acConnectedPhasesField;
        }
        set {
            this.acConnectedPhasesField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType acRmsPeriodDuration {
        get {
            return this.acRmsPeriodDurationField;
        }
        set {
            this.acRmsPeriodDurationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionParameterDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionParameterDescriptionDataElementsType {
    
    private ElementTagType electricalConnectionIdField;
    
    private ElementTagType parameterIdField;
    
    private ElementTagType measurementIdField;
    
    private ElementTagType voltageTypeField;
    
    private ElementTagType acMeasuredPhasesField;
    
    private ElementTagType acMeasuredInReferenceToField;
    
    private ElementTagType acMeasurementTypeField;
    
    private ElementTagType acMeasurementVariantField;
    
    private ElementTagType acMeasuredHarmonicField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType parameterId {
        get {
            return this.parameterIdField;
        }
        set {
            this.parameterIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType voltageType {
        get {
            return this.voltageTypeField;
        }
        set {
            this.voltageTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType acMeasuredPhases {
        get {
            return this.acMeasuredPhasesField;
        }
        set {
            this.acMeasuredPhasesField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType acMeasuredInReferenceTo {
        get {
            return this.acMeasuredInReferenceToField;
        }
        set {
            this.acMeasuredInReferenceToField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType acMeasurementType {
        get {
            return this.acMeasurementTypeField;
        }
        set {
            this.acMeasurementTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType acMeasurementVariant {
        get {
            return this.acMeasurementVariantField;
        }
        set {
            this.acMeasurementVariantField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType acMeasuredHarmonic {
        get {
            return this.acMeasuredHarmonicField;
        }
        set {
            this.acMeasuredHarmonicField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionPermittedValueSetDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionPermittedValueSetDataElementsType {
    
    private ElementTagType electricalConnectionIdField;
    
    private ElementTagType parameterIdField;
    
    private ScaledNumberSetElementsType permittedValueSetField;
    
    /// <remarks/>
    public ElementTagType electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType parameterId {
        get {
            return this.parameterIdField;
        }
        set {
            this.parameterIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberSetElementsType permittedValueSet {
        get {
            return this.permittedValueSetField;
        }
        set {
            this.permittedValueSetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class ScaledNumberSetElementsType {
    
    private ScaledNumberElementsType valueField;
    
    private ScaledNumberRangeElementsType rangeField;
    
    /// <remarks/>
    public ScaledNumberElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberRangeElementsType range {
        get {
            return this.rangeField;
        }
        set {
            this.rangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class ScaledNumberRangeElementsType {
    
    private ScaledNumberElementsType minField;
    
    private ScaledNumberElementsType maxField;
    
    /// <remarks/>
    public ScaledNumberElementsType min {
        get {
            return this.minField;
        }
        set {
            this.minField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionStateDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionStateDataElementsType {
    
    private ElementTagType electricalConnectionIdField;
    
    private ElementTagType timestampField;
    
    private ElementTagType currentEnergyModeField;
    
    private ElementTagType consumptionTimeField;
    
    private ElementTagType productionTimeField;
    
    private ElementTagType totalConsumptionTimeField;
    
    private ElementTagType totalProductionTimeField;
    
    /// <remarks/>
    public ElementTagType electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType currentEnergyMode {
        get {
            return this.currentEnergyModeField;
        }
        set {
            this.currentEnergyModeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType consumptionTime {
        get {
            return this.consumptionTimeField;
        }
        set {
            this.consumptionTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType productionTime {
        get {
            return this.productionTimeField;
        }
        set {
            this.productionTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType totalConsumptionTime {
        get {
            return this.totalConsumptionTimeField;
        }
        set {
            this.totalConsumptionTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType totalProductionTime {
        get {
            return this.totalProductionTimeField;
        }
        set {
            this.totalProductionTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOperationModeDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOperationModeDescriptionDataElementsType {
    
    private ElementTagType operationModeIdField;
    
    private ElementTagType operationModeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType operationModeId {
        get {
            return this.operationModeIdField;
        }
        set {
            this.operationModeIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType operationModeType {
        get {
            return this.operationModeTypeField;
        }
        set {
            this.operationModeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOverrunDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOverrunDataElementsType {
    
    private ElementTagType overrunIdField;
    
    private ElementTagType overrunStatusField;
    
    private ElementTagType timeTableIdField;
    
    private ElementTagType isOverrunStatusChangeableField;
    
    /// <remarks/>
    public ElementTagType overrunId {
        get {
            return this.overrunIdField;
        }
        set {
            this.overrunIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType overrunStatus {
        get {
            return this.overrunStatusField;
        }
        set {
            this.overrunStatusField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isOverrunStatusChangeable {
        get {
            return this.isOverrunStatusChangeableField;
        }
        set {
            this.isOverrunStatusChangeableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOverrunDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOverrunDescriptionDataElementsType {
    
    private ElementTagType overrunIdField;
    
    private ElementTagType overrunTypeField;
    
    private ElementTagType affectedSystemFunctionIdField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType overrunId {
        get {
            return this.overrunIdField;
        }
        set {
            this.overrunIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType overrunType {
        get {
            return this.overrunTypeField;
        }
        set {
            this.overrunTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType affectedSystemFunctionId {
        get {
            return this.affectedSystemFunctionIdField;
        }
        set {
            this.affectedSystemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionDataElementsType {
    
    private ElementTagType systemFunctionIdField;
    
    private ElementTagType currentOperationModeIdField;
    
    private ElementTagType isOperationModeIdChangeableField;
    
    private ElementTagType currentSetpointIdField;
    
    private ElementTagType isSetpointIdChangeableField;
    
    private ElementTagType isOverrunActiveField;
    
    /// <remarks/>
    public ElementTagType systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType currentOperationModeId {
        get {
            return this.currentOperationModeIdField;
        }
        set {
            this.currentOperationModeIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isOperationModeIdChangeable {
        get {
            return this.isOperationModeIdChangeableField;
        }
        set {
            this.isOperationModeIdChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType currentSetpointId {
        get {
            return this.currentSetpointIdField;
        }
        set {
            this.currentSetpointIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isSetpointIdChangeable {
        get {
            return this.isSetpointIdChangeableField;
        }
        set {
            this.isSetpointIdChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isOverrunActive {
        get {
            return this.isOverrunActiveField;
        }
        set {
            this.isOverrunActiveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionDescriptionDataElementsType {
    
    private ElementTagType systemFunctionIdField;
    
    private ElementTagType systemFunctionTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType systemFunctionType {
        get {
            return this.systemFunctionTypeField;
        }
        set {
            this.systemFunctionTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionOperationModeRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionOperationModeRelationDataElementsType {
    
    private ElementTagType systemFunctionIdField;
    
    private ElementTagType operationModeIdField;
    
    /// <remarks/>
    public ElementTagType systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType operationModeId {
        get {
            return this.operationModeIdField;
        }
        set {
            this.operationModeIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionPowerSequenceRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionPowerSequenceRelationDataElementsType {
    
    private ElementTagType systemFunctionIdField;
    
    private ElementTagType sequenceIdField;
    
    /// <remarks/>
    public ElementTagType systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionSetpointRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionSetpointRelationDataElementsType {
    
    private ElementTagType systemFunctionIdField;
    
    private ElementTagType operationModeIdField;
    
    private ElementTagType setpointIdField;
    
    /// <remarks/>
    public ElementTagType systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType operationModeId {
        get {
            return this.operationModeIdField;
        }
        set {
            this.operationModeIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("identificationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IdentificationDataElementsType {
    
    private ElementTagType identificationIdField;
    
    private ElementTagType identificationTypeField;
    
    private ElementTagType identificationValueField;
    
    private ElementTagType authorizedField;
    
    /// <remarks/>
    public ElementTagType identificationId {
        get {
            return this.identificationIdField;
        }
        set {
            this.identificationIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType identificationType {
        get {
            return this.identificationTypeField;
        }
        set {
            this.identificationTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType identificationValue {
        get {
            return this.identificationValueField;
        }
        set {
            this.identificationValueField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType authorized {
        get {
            return this.authorizedField;
        }
        set {
            this.authorizedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveDataElementsType {
    
    private ElementTagType incentiveIdField;
    
    private ElementTagType valueTypeField;
    
    private ElementTagType timestampField;
    
    private TimePeriodElementsType timePeriodField;
    
    private ElementTagType timeTableIdField;
    
    private ElementTagType valueField;
    
    /// <remarks/>
    public ElementTagType incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveDescriptionDataElementsType {
    
    private ElementTagType incentiveIdField;
    
    private ElementTagType incentiveTypeField;
    
    private ElementTagType incentivePriorityField;
    
    private ElementTagType currencyField;
    
    private ElementTagType unitField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType incentiveType {
        get {
            return this.incentiveTypeField;
        }
        set {
            this.incentiveTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType incentivePriority {
        get {
            return this.incentivePriorityField;
        }
        set {
            this.incentivePriorityField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableConstraintsDataElementsType {
    
    private IncentiveTableConstraintsElementsType incentiveTableConstraintsField;
    
    /// <remarks/>
    public IncentiveTableConstraintsElementsType incentiveTableConstraints {
        get {
            return this.incentiveTableConstraintsField;
        }
        set {
            this.incentiveTableConstraintsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsElementsType {
    
    private IncentiveTableConstraintsElementsTypeTariff tariffField;
    
    private IncentiveTableConstraintsElementsTypeTariffConstraints tariffConstraintsField;
    
    private IncentiveTableConstraintsElementsTypeIncentiveSlotConstraints incentiveSlotConstraintsField;
    
    /// <remarks/>
    public IncentiveTableConstraintsElementsTypeTariff tariff {
        get {
            return this.tariffField;
        }
        set {
            this.tariffField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableConstraintsElementsTypeTariffConstraints tariffConstraints {
        get {
            return this.tariffConstraintsField;
        }
        set {
            this.tariffConstraintsField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableConstraintsElementsTypeIncentiveSlotConstraints incentiveSlotConstraints {
        get {
            return this.incentiveSlotConstraintsField;
        }
        set {
            this.incentiveSlotConstraintsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsElementsTypeTariff : TariffDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffDataElementsType {
    
    private ElementTagType tariffIdField;
    
    private ElementTagType activeTierIdField;
    
    /// <remarks/>
    public ElementTagType tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activeTierId {
        get {
            return this.activeTierIdField;
        }
        set {
            this.activeTierIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsElementsTypeTariffConstraints : TariffOverallConstraintsDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffOverallConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffOverallConstraintsDataElementsType {
    
    private ElementTagType maxTariffCountField;
    
    private ElementTagType maxBoundaryCountField;
    
    private ElementTagType maxTierCountField;
    
    private ElementTagType maxIncentiveCountField;
    
    private ElementTagType maxBoundariesPerTariffField;
    
    private ElementTagType maxTiersPerTariffField;
    
    private ElementTagType maxBoundariesPerTierField;
    
    private ElementTagType maxIncentivesPerTierField;
    
    /// <remarks/>
    public ElementTagType maxTariffCount {
        get {
            return this.maxTariffCountField;
        }
        set {
            this.maxTariffCountField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxBoundaryCount {
        get {
            return this.maxBoundaryCountField;
        }
        set {
            this.maxBoundaryCountField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxTierCount {
        get {
            return this.maxTierCountField;
        }
        set {
            this.maxTierCountField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxIncentiveCount {
        get {
            return this.maxIncentiveCountField;
        }
        set {
            this.maxIncentiveCountField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxBoundariesPerTariff {
        get {
            return this.maxBoundariesPerTariffField;
        }
        set {
            this.maxBoundariesPerTariffField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxTiersPerTariff {
        get {
            return this.maxTiersPerTariffField;
        }
        set {
            this.maxTiersPerTariffField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxBoundariesPerTier {
        get {
            return this.maxBoundariesPerTierField;
        }
        set {
            this.maxBoundariesPerTierField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxIncentivesPerTier {
        get {
            return this.maxIncentivesPerTierField;
        }
        set {
            this.maxIncentivesPerTierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsElementsTypeIncentiveSlotConstraints : TimeTableConstraintsDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableConstraintsDataElementsType {
    
    private ElementTagType timeTableIdField;
    
    private ElementTagType slotCountMinField;
    
    private ElementTagType slotCountMaxField;
    
    private ElementTagType slotDurationMinField;
    
    private ElementTagType slotDurationMaxField;
    
    private ElementTagType slotDurationStepSizeField;
    
    private ElementTagType slotShiftStepSizeField;
    
    private ElementTagType firstSlotBeginsAtField;
    
    /// <remarks/>
    public ElementTagType timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotCountMin {
        get {
            return this.slotCountMinField;
        }
        set {
            this.slotCountMinField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotCountMax {
        get {
            return this.slotCountMaxField;
        }
        set {
            this.slotCountMaxField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotDurationMin {
        get {
            return this.slotDurationMinField;
        }
        set {
            this.slotDurationMinField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotDurationMax {
        get {
            return this.slotDurationMaxField;
        }
        set {
            this.slotDurationMaxField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotDurationStepSize {
        get {
            return this.slotDurationStepSizeField;
        }
        set {
            this.slotDurationStepSizeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotShiftStepSize {
        get {
            return this.slotShiftStepSizeField;
        }
        set {
            this.slotShiftStepSizeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType firstSlotBeginsAt {
        get {
            return this.firstSlotBeginsAtField;
        }
        set {
            this.firstSlotBeginsAtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableDataElementsType {
    
    private IncentiveTableElementsType incentiveTableField;
    
    /// <remarks/>
    public IncentiveTableElementsType incentiveTable {
        get {
            return this.incentiveTableField;
        }
        set {
            this.incentiveTableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableElementsType {
    
    private IncentiveTableElementsTypeTariff tariffField;
    
    private IncentiveTableIncentiveSlotElementsType incentiveSlotField;
    
    /// <remarks/>
    public IncentiveTableElementsTypeTariff tariff {
        get {
            return this.tariffField;
        }
        set {
            this.tariffField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableIncentiveSlotElementsType incentiveSlot {
        get {
            return this.incentiveSlotField;
        }
        set {
            this.incentiveSlotField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableElementsTypeTariff : TariffDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableIncentiveSlotElementsType {
    
    private IncentiveTableIncentiveSlotElementsTypeTimeInterval timeIntervalField;
    
    private IncentiveTableTierElementsType tierField;
    
    /// <remarks/>
    public IncentiveTableIncentiveSlotElementsTypeTimeInterval timeInterval {
        get {
            return this.timeIntervalField;
        }
        set {
            this.timeIntervalField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableTierElementsType tier {
        get {
            return this.tierField;
        }
        set {
            this.tierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableIncentiveSlotElementsTypeTimeInterval : TimeTableDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableDataElementsType {
    
    private ElementTagType timeTableIdField;
    
    private ElementTagType timeSlotIdField;
    
    private RecurrenceInformationElementsType recurrenceInformationField;
    
    private AbsoluteOrRecurringTimeElementsType startTimeField;
    
    private AbsoluteOrRecurringTimeElementsType endTimeField;
    
    /// <remarks/>
    public ElementTagType timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeSlotId {
        get {
            return this.timeSlotIdField;
        }
        set {
            this.timeSlotIdField = value;
        }
    }
    
    /// <remarks/>
    public RecurrenceInformationElementsType recurrenceInformation {
        get {
            return this.recurrenceInformationField;
        }
        set {
            this.recurrenceInformationField = value;
        }
    }
    
    /// <remarks/>
    public AbsoluteOrRecurringTimeElementsType startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    public AbsoluteOrRecurringTimeElementsType endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class RecurrenceInformationElementsType {
    
    private ElementTagType recurringIntervalField;
    
    private ElementTagType recurringIntervalStepField;
    
    private ElementTagType firstExecutionField;
    
    private ElementTagType executionCountField;
    
    private ElementTagType lastExecutionField;
    
    /// <remarks/>
    public ElementTagType recurringInterval {
        get {
            return this.recurringIntervalField;
        }
        set {
            this.recurringIntervalField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType recurringIntervalStep {
        get {
            return this.recurringIntervalStepField;
        }
        set {
            this.recurringIntervalStepField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType firstExecution {
        get {
            return this.firstExecutionField;
        }
        set {
            this.firstExecutionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType executionCount {
        get {
            return this.executionCountField;
        }
        set {
            this.executionCountField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType lastExecution {
        get {
            return this.lastExecutionField;
        }
        set {
            this.lastExecutionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class AbsoluteOrRecurringTimeElementsType {
    
    private ElementTagType dateTimeField;
    
    private ElementTagType monthField;
    
    private ElementTagType dayOfMonthField;
    
    private ElementTagType calendarWeekField;
    
    private ElementTagType dayOfWeekOccurrenceField;
    
    private ElementTagType daysOfWeekField;
    
    private ElementTagType timeField;
    
    private ElementTagType relativeField;
    
    /// <remarks/>
    public ElementTagType dateTime {
        get {
            return this.dateTimeField;
        }
        set {
            this.dateTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType month {
        get {
            return this.monthField;
        }
        set {
            this.monthField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType dayOfMonth {
        get {
            return this.dayOfMonthField;
        }
        set {
            this.dayOfMonthField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType calendarWeek {
        get {
            return this.calendarWeekField;
        }
        set {
            this.calendarWeekField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType dayOfWeekOccurrence {
        get {
            return this.dayOfWeekOccurrenceField;
        }
        set {
            this.dayOfWeekOccurrenceField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType daysOfWeek {
        get {
            return this.daysOfWeekField;
        }
        set {
            this.daysOfWeekField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType time {
        get {
            return this.timeField;
        }
        set {
            this.timeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType relative {
        get {
            return this.relativeField;
        }
        set {
            this.relativeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTierElementsType {
    
    private IncentiveTableTierElementsTypeTier tierField;
    
    private IncentiveTableTierElementsTypeBoundary boundaryField;
    
    private IncentiveTableTierElementsTypeIncentive incentiveField;
    
    /// <remarks/>
    public IncentiveTableTierElementsTypeTier tier {
        get {
            return this.tierField;
        }
        set {
            this.tierField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableTierElementsTypeBoundary boundary {
        get {
            return this.boundaryField;
        }
        set {
            this.boundaryField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableTierElementsTypeIncentive incentive {
        get {
            return this.incentiveField;
        }
        set {
            this.incentiveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTierElementsTypeTier : TierDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierDataElementsType {
    
    private ElementTagType tierIdField;
    
    private TimePeriodElementsType timePeriodField;
    
    private ElementTagType timeTableIdField;
    
    private ElementTagType activeIncentiveIdField;
    
    /// <remarks/>
    public ElementTagType tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activeIncentiveId {
        get {
            return this.activeIncentiveIdField;
        }
        set {
            this.activeIncentiveIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTierElementsTypeBoundary : TierBoundaryDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierBoundaryDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierBoundaryDataElementsType {
    
    private ElementTagType boundaryIdField;
    
    private TimePeriodElementsType timePeriodField;
    
    private ElementTagType timeTableIdField;
    
    private ScaledNumberElementsType lowerBoundaryValueField;
    
    private ScaledNumberElementsType upperBoundaryValueField;
    
    /// <remarks/>
    public ElementTagType boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType lowerBoundaryValue {
        get {
            return this.lowerBoundaryValueField;
        }
        set {
            this.lowerBoundaryValueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType upperBoundaryValue {
        get {
            return this.upperBoundaryValueField;
        }
        set {
            this.upperBoundaryValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTierElementsTypeIncentive : IncentiveDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableDescriptionDataElementsType {
    
    private IncentiveTableDescriptionElementsType incentiveTableDescriptionField;
    
    /// <remarks/>
    public IncentiveTableDescriptionElementsType incentiveTableDescription {
        get {
            return this.incentiveTableDescriptionField;
        }
        set {
            this.incentiveTableDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionElementsType {
    
    private IncentiveTableDescriptionElementsTypeTariffDescription tariffDescriptionField;
    
    private IncentiveTableDescriptionTierElementsType tierField;
    
    /// <remarks/>
    public IncentiveTableDescriptionElementsTypeTariffDescription tariffDescription {
        get {
            return this.tariffDescriptionField;
        }
        set {
            this.tariffDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableDescriptionTierElementsType tier {
        get {
            return this.tierField;
        }
        set {
            this.tierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionElementsTypeTariffDescription : TariffDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffDescriptionDataElementsType {
    
    private ElementTagType tariffIdField;
    
    private ElementTagType commodityIdField;
    
    private ElementTagType measurementIdField;
    
    private ElementTagType tariffWriteableField;
    
    private ElementTagType updateRequiredField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    private ElementTagType slotIdSupportField;
    
    /// <remarks/>
    public ElementTagType tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType commodityId {
        get {
            return this.commodityIdField;
        }
        set {
            this.commodityIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType tariffWriteable {
        get {
            return this.tariffWriteableField;
        }
        set {
            this.tariffWriteableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType updateRequired {
        get {
            return this.updateRequiredField;
        }
        set {
            this.updateRequiredField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotIdSupport {
        get {
            return this.slotIdSupportField;
        }
        set {
            this.slotIdSupportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTierElementsType {
    
    private IncentiveTableDescriptionTierElementsTypeTierDescription tierDescriptionField;
    
    private IncentiveTableDescriptionTierElementsTypeBoundaryDescription boundaryDescriptionField;
    
    private IncentiveTableDescriptionTierElementsTypeIncentiveDescription incentiveDescriptionField;
    
    /// <remarks/>
    public IncentiveTableDescriptionTierElementsTypeTierDescription tierDescription {
        get {
            return this.tierDescriptionField;
        }
        set {
            this.tierDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableDescriptionTierElementsTypeBoundaryDescription boundaryDescription {
        get {
            return this.boundaryDescriptionField;
        }
        set {
            this.boundaryDescriptionField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableDescriptionTierElementsTypeIncentiveDescription incentiveDescription {
        get {
            return this.incentiveDescriptionField;
        }
        set {
            this.incentiveDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTierElementsTypeTierDescription : TierDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierDescriptionDataElementsType {
    
    private ElementTagType tierIdField;
    
    private ElementTagType tierTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType tierType {
        get {
            return this.tierTypeField;
        }
        set {
            this.tierTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTierElementsTypeBoundaryDescription : TierBoundaryDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierBoundaryDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierBoundaryDescriptionDataElementsType {
    
    private ElementTagType boundaryIdField;
    
    private ElementTagType boundaryTypeField;
    
    private ElementTagType validForTierIdField;
    
    private ElementTagType switchToTierIdWhenLowerField;
    
    private ElementTagType switchToTierIdWhenHigherField;
    
    private ElementTagType boundaryUnitField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType boundaryType {
        get {
            return this.boundaryTypeField;
        }
        set {
            this.boundaryTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType validForTierId {
        get {
            return this.validForTierIdField;
        }
        set {
            this.validForTierIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType switchToTierIdWhenLower {
        get {
            return this.switchToTierIdWhenLowerField;
        }
        set {
            this.switchToTierIdWhenLowerField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType switchToTierIdWhenHigher {
        get {
            return this.switchToTierIdWhenHigherField;
        }
        set {
            this.switchToTierIdWhenHigherField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType boundaryUnit {
        get {
            return this.boundaryUnitField;
        }
        set {
            this.boundaryUnitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTierElementsTypeIncentiveDescription : IncentiveDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlEventDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlEventDataElementsType {
    
    private ElementTagType timestampField;
    
    private ElementTagType eventIdField;
    
    private ElementTagType eventActionConsumeField;
    
    private ElementTagType eventActionProduceField;
    
    private TimePeriodElementsType timePeriodField;
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType eventId {
        get {
            return this.eventIdField;
        }
        set {
            this.eventIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType eventActionConsume {
        get {
            return this.eventActionConsumeField;
        }
        set {
            this.eventActionConsumeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType eventActionProduce {
        get {
            return this.eventActionProduceField;
        }
        set {
            this.eventActionProduceField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitConstraintsDataElementsType {
    
    private ElementTagType limitIdField;
    
    private ScaledNumberElementsType valueRangeMinField;
    
    private ScaledNumberElementsType valueRangeMaxField;
    
    private ScaledNumberElementsType valueStepSizeField;
    
    /// <remarks/>
    public ElementTagType limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueRangeMin {
        get {
            return this.valueRangeMinField;
        }
        set {
            this.valueRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueRangeMax {
        get {
            return this.valueRangeMaxField;
        }
        set {
            this.valueRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueStepSize {
        get {
            return this.valueStepSizeField;
        }
        set {
            this.valueStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitDataElementsType {
    
    private ElementTagType limitIdField;
    
    private ElementTagType isLimitChangeableField;
    
    private ElementTagType isLimitActiveField;
    
    private TimePeriodElementsType timePeriodField;
    
    private ScaledNumberElementsType valueField;
    
    /// <remarks/>
    public ElementTagType limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isLimitChangeable {
        get {
            return this.isLimitChangeableField;
        }
        set {
            this.isLimitChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isLimitActive {
        get {
            return this.isLimitActiveField;
        }
        set {
            this.isLimitActiveField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitDescriptionDataElementsType {
    
    private ElementTagType limitIdField;
    
    private ElementTagType limitTypeField;
    
    private ElementTagType limitCategoryField;
    
    private ElementTagType limitDirectionField;
    
    private ElementTagType measurementIdField;
    
    private ElementTagType unitField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType limitType {
        get {
            return this.limitTypeField;
        }
        set {
            this.limitTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType limitCategory {
        get {
            return this.limitCategoryField;
        }
        set {
            this.limitCategoryField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType limitDirection {
        get {
            return this.limitDirectionField;
        }
        set {
            this.limitDirectionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlNodeDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlNodeDataElementsType {
    
    private ElementTagType isNodeRemoteControllableField;
    
    /// <remarks/>
    public ElementTagType isNodeRemoteControllable {
        get {
            return this.isNodeRemoteControllableField;
        }
        set {
            this.isNodeRemoteControllableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlStateDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlStateDataElementsType {
    
    private ElementTagType timestampField;
    
    private ElementTagType eventIdField;
    
    private ElementTagType eventStateConsumeField;
    
    private ElementTagType appliedEventActionConsumeField;
    
    private ElementTagType eventStateProduceField;
    
    private ElementTagType appliedEventActionProduceField;
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType eventId {
        get {
            return this.eventIdField;
        }
        set {
            this.eventIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType eventStateConsume {
        get {
            return this.eventStateConsumeField;
        }
        set {
            this.eventStateConsumeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType appliedEventActionConsume {
        get {
            return this.appliedEventActionConsumeField;
        }
        set {
            this.appliedEventActionConsumeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType eventStateProduce {
        get {
            return this.eventStateProduceField;
        }
        set {
            this.eventStateProduceField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType appliedEventActionProduce {
        get {
            return this.appliedEventActionProduceField;
        }
        set {
            this.appliedEventActionProduceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementConstraintsDataElementsType {
    
    private ElementTagType measurementIdField;
    
    private ScaledNumberElementsType valueRangeMinField;
    
    private ScaledNumberElementsType valueRangeMaxField;
    
    private ScaledNumberElementsType valueStepSizeField;
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueRangeMin {
        get {
            return this.valueRangeMinField;
        }
        set {
            this.valueRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueRangeMax {
        get {
            return this.valueRangeMaxField;
        }
        set {
            this.valueRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueStepSize {
        get {
            return this.valueStepSizeField;
        }
        set {
            this.valueStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementDataElementsType {
    
    private ElementTagType measurementIdField;
    
    private ElementTagType valueTypeField;
    
    private ElementTagType timestampField;
    
    private ScaledNumberElementsType valueField;
    
    private TimePeriodElementsType evaluationPeriodField;
    
    private ElementTagType valueSourceField;
    
    private ElementTagType valueTendencyField;
    
    private ElementTagType valueStateField;
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType evaluationPeriod {
        get {
            return this.evaluationPeriodField;
        }
        set {
            this.evaluationPeriodField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueSource {
        get {
            return this.valueSourceField;
        }
        set {
            this.valueSourceField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueTendency {
        get {
            return this.valueTendencyField;
        }
        set {
            this.valueTendencyField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueState {
        get {
            return this.valueStateField;
        }
        set {
            this.valueStateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementDescriptionDataElementsType {
    
    private ElementTagType measurementIdField;
    
    private ElementTagType measurementTypeField;
    
    private ElementTagType commodityTypeField;
    
    private ElementTagType unitField;
    
    private ScaledNumberElementsType calibrationValueField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType measurementType {
        get {
            return this.measurementTypeField;
        }
        set {
            this.measurementTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType commodityType {
        get {
            return this.commodityTypeField;
        }
        set {
            this.commodityTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType calibrationValue {
        get {
            return this.calibrationValueField;
        }
        set {
            this.calibrationValueField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementThresholdRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementThresholdRelationDataElementsType {
    
    private ElementTagType measurementIdField;
    
    private ElementTagType thresholdIdField;
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("messagingDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MessagingDataElementsType {
    
    private ElementTagType timestampField;
    
    private ElementTagType messagingNumberField;
    
    private ElementTagType typeField;
    
    private ElementTagType textField;
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType messagingNumber {
        get {
            return this.messagingNumberField;
        }
        set {
            this.messagingNumberField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementAbortCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementAbortCallElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementAddNodeCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementAddNodeCallElementsType {
    
    private FeatureAddressElementsType nodeAddressField;
    
    private ElementTagType nativeSetupField;
    
    private ElementTagType timeoutField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public FeatureAddressElementsType nodeAddress {
        get {
            return this.nodeAddressField;
        }
        set {
            this.nodeAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType nativeSetup {
        get {
            return this.nativeSetupField;
        }
        set {
            this.nativeSetupField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeout {
        get {
            return this.timeoutField;
        }
        set {
            this.timeoutField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementDeviceDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementDeviceDescriptionDataElementsType {
    
    private DeviceAddressElementsType deviceAddressField;
    
    private ElementTagType deviceTypeField;
    
    private ElementTagType networkManagementResponsibleAddressField;
    
    private ElementTagType nativeSetupField;
    
    private ElementTagType technologyAddressField;
    
    private ElementTagType communicationsTechnologyInformationField;
    
    private ElementTagType networkFeatureSetField;
    
    private ElementTagType lastStateChangeField;
    
    private ElementTagType minimumTrustLevelField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public DeviceAddressElementsType deviceAddress {
        get {
            return this.deviceAddressField;
        }
        set {
            this.deviceAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType deviceType {
        get {
            return this.deviceTypeField;
        }
        set {
            this.deviceTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType networkManagementResponsibleAddress {
        get {
            return this.networkManagementResponsibleAddressField;
        }
        set {
            this.networkManagementResponsibleAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType nativeSetup {
        get {
            return this.nativeSetupField;
        }
        set {
            this.nativeSetupField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType technologyAddress {
        get {
            return this.technologyAddressField;
        }
        set {
            this.technologyAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType communicationsTechnologyInformation {
        get {
            return this.communicationsTechnologyInformationField;
        }
        set {
            this.communicationsTechnologyInformationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType networkFeatureSet {
        get {
            return this.networkFeatureSetField;
        }
        set {
            this.networkFeatureSetField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType lastStateChange {
        get {
            return this.lastStateChangeField;
        }
        set {
            this.lastStateChangeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType minimumTrustLevel {
        get {
            return this.minimumTrustLevelField;
        }
        set {
            this.minimumTrustLevelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementDiscoverCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementDiscoverCallElementsType {
    
    private FeatureAddressElementsType discoverAddressField;
    
    /// <remarks/>
    public FeatureAddressElementsType discoverAddress {
        get {
            return this.discoverAddressField;
        }
        set {
            this.discoverAddressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementEntityDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementEntityDescriptionDataElementsType {
    
    private EntityAddressElementsType entityAddressField;
    
    private ElementTagType entityTypeField;
    
    private ElementTagType lastStateChangeField;
    
    private ElementTagType minimumTrustLevelField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public EntityAddressElementsType entityAddress {
        get {
            return this.entityAddressField;
        }
        set {
            this.entityAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType entityType {
        get {
            return this.entityTypeField;
        }
        set {
            this.entityTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType lastStateChange {
        get {
            return this.lastStateChangeField;
        }
        set {
            this.lastStateChangeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType minimumTrustLevel {
        get {
            return this.minimumTrustLevelField;
        }
        set {
            this.minimumTrustLevelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementFeatureDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementFeatureDescriptionDataElementsType {
    
    private FeatureAddressElementsType featureAddressField;
    
    private ElementTagType featureTypeField;
    
    private ElementTagType specificUsageField;
    
    private ElementTagType featureGroupField;
    
    private ElementTagType roleField;
    
    private FunctionPropertyElementsType supportedFunctionField;
    
    private ElementTagType lastStateChangeField;
    
    private ElementTagType minimumTrustLevelField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    private ElementTagType maxResponseDelayField;
    
    /// <remarks/>
    public FeatureAddressElementsType featureAddress {
        get {
            return this.featureAddressField;
        }
        set {
            this.featureAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType featureType {
        get {
            return this.featureTypeField;
        }
        set {
            this.featureTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType specificUsage {
        get {
            return this.specificUsageField;
        }
        set {
            this.specificUsageField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType featureGroup {
        get {
            return this.featureGroupField;
        }
        set {
            this.featureGroupField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType role {
        get {
            return this.roleField;
        }
        set {
            this.roleField = value;
        }
    }
    
    /// <remarks/>
    public FunctionPropertyElementsType supportedFunction {
        get {
            return this.supportedFunctionField;
        }
        set {
            this.supportedFunctionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType lastStateChange {
        get {
            return this.lastStateChangeField;
        }
        set {
            this.lastStateChangeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType minimumTrustLevel {
        get {
            return this.minimumTrustLevelField;
        }
        set {
            this.minimumTrustLevelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxResponseDelay {
        get {
            return this.maxResponseDelayField;
        }
        set {
            this.maxResponseDelayField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class FunctionPropertyElementsType {
    
    private ElementTagType functionField;
    
    private PossibleOperationsElementsType possibleOperationsField;
    
    /// <remarks/>
    public ElementTagType function {
        get {
            return this.functionField;
        }
        set {
            this.functionField = value;
        }
    }
    
    /// <remarks/>
    public PossibleOperationsElementsType possibleOperations {
        get {
            return this.possibleOperationsField;
        }
        set {
            this.possibleOperationsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class PossibleOperationsElementsType {
    
    private ElementTagType readField;
    
    private ElementTagType writeField;
    
    /// <remarks/>
    public ElementTagType read {
        get {
            return this.readField;
        }
        set {
            this.readField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType write {
        get {
            return this.writeField;
        }
        set {
            this.writeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementJoiningModeDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementJoiningModeDataElementsType {
    
    private ElementTagType setupField;
    
    /// <remarks/>
    public ElementTagType setup {
        get {
            return this.setupField;
        }
        set {
            this.setupField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementModifyNodeCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementModifyNodeCallElementsType {
    
    private FeatureAddressElementsType nodeAddressField;
    
    private ElementTagType nativeSetupField;
    
    private ElementTagType timeoutField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public FeatureAddressElementsType nodeAddress {
        get {
            return this.nodeAddressField;
        }
        set {
            this.nodeAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType nativeSetup {
        get {
            return this.nativeSetupField;
        }
        set {
            this.nativeSetupField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeout {
        get {
            return this.timeoutField;
        }
        set {
            this.timeoutField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementProcessStateDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementProcessStateDataElementsType {
    
    private ElementTagType stateField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementRemoveNodeCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementRemoveNodeCallElementsType {
    
    private FeatureAddressElementsType nodeAddressField;
    
    private ElementTagType timeoutField;
    
    /// <remarks/>
    public FeatureAddressElementsType nodeAddress {
        get {
            return this.nodeAddressField;
        }
        set {
            this.nodeAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeout {
        get {
            return this.timeoutField;
        }
        set {
            this.timeoutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementReportCandidateDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementReportCandidateDataElementsType {
    
    private ElementTagType candidateSetupField;
    
    private ElementTagType setupUsableForAddField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType candidateSetup {
        get {
            return this.candidateSetupField;
        }
        set {
            this.candidateSetupField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType setupUsableForAdd {
        get {
            return this.setupUsableForAddField;
        }
        set {
            this.setupUsableForAddField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementScanNetworkCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementScanNetworkCallElementsType {
    
    private ElementTagType scanSetupField;
    
    private ElementTagType timeoutField;
    
    /// <remarks/>
    public ElementTagType scanSetup {
        get {
            return this.scanSetupField;
        }
        set {
            this.scanSetupField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeout {
        get {
            return this.timeoutField;
        }
        set {
            this.timeoutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementBindingDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementBindingDataElementsType {
    
    private NodeManagementBindingDataElementsTypeBindingEntry bindingEntryField;
    
    /// <remarks/>
    public NodeManagementBindingDataElementsTypeBindingEntry bindingEntry {
        get {
            return this.bindingEntryField;
        }
        set {
            this.bindingEntryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementBindingDataElementsTypeBindingEntry : BindingManagementEntryDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementBindingDeleteCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementBindingDeleteCallElementsType {
    
    private NodeManagementBindingDeleteCallElementsTypeBindingDelete bindingDeleteField;
    
    /// <remarks/>
    public NodeManagementBindingDeleteCallElementsTypeBindingDelete bindingDelete {
        get {
            return this.bindingDeleteField;
        }
        set {
            this.bindingDeleteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementBindingDeleteCallElementsTypeBindingDelete : BindingManagementDeleteCallElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementBindingRequestCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementBindingRequestCallElementsType {
    
    private NodeManagementBindingRequestCallElementsTypeBindingRequest bindingRequestField;
    
    /// <remarks/>
    public NodeManagementBindingRequestCallElementsTypeBindingRequest bindingRequest {
        get {
            return this.bindingRequestField;
        }
        set {
            this.bindingRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementBindingRequestCallElementsTypeBindingRequest : BindingManagementRequestCallElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementDestinationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementDestinationDataElementsType {
    
    private NodeManagementDestinationDataElementsTypeDeviceDescription deviceDescriptionField;
    
    /// <remarks/>
    public NodeManagementDestinationDataElementsTypeDeviceDescription deviceDescription {
        get {
            return this.deviceDescriptionField;
        }
        set {
            this.deviceDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDestinationDataElementsTypeDeviceDescription : NetworkManagementDeviceDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementDetailedDiscoveryDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementDetailedDiscoveryDataElementsType {
    
    private NodeManagementSpecificationVersionListElementsType specificationVersionListField;
    
    private NodeManagementDetailedDiscoveryDeviceInformationElementsType deviceInformationField;
    
    private NodeManagementDetailedDiscoveryEntityInformationElementsType entityInformationField;
    
    private NodeManagementDetailedDiscoveryFeatureInformationElementsType featureInformationField;
    
    /// <remarks/>
    public NodeManagementSpecificationVersionListElementsType specificationVersionList {
        get {
            return this.specificationVersionListField;
        }
        set {
            this.specificationVersionListField = value;
        }
    }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDeviceInformationElementsType deviceInformation {
        get {
            return this.deviceInformationField;
        }
        set {
            this.deviceInformationField = value;
        }
    }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryEntityInformationElementsType entityInformation {
        get {
            return this.entityInformationField;
        }
        set {
            this.entityInformationField = value;
        }
    }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryFeatureInformationElementsType featureInformation {
        get {
            return this.featureInformationField;
        }
        set {
            this.featureInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSpecificationVersionListElementsType {
    
    private NodeManagementSpecificationVersionListElementsTypeSpecificationVersion specificationVersionField;
    
    /// <remarks/>
    public NodeManagementSpecificationVersionListElementsTypeSpecificationVersion specificationVersion {
        get {
            return this.specificationVersionField;
        }
        set {
            this.specificationVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSpecificationVersionListElementsTypeSpecificationVersion : SpecificationVersionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("specificationVersionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SpecificationVersionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryDeviceInformationElementsType {
    
    private NodeManagementDetailedDiscoveryDeviceInformationElementsTypeDescription descriptionField;
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDeviceInformationElementsTypeDescription description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryDeviceInformationElementsTypeDescription : NetworkManagementDeviceDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryEntityInformationElementsType {
    
    private NodeManagementDetailedDiscoveryEntityInformationElementsTypeDescription descriptionField;
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryEntityInformationElementsTypeDescription description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryEntityInformationElementsTypeDescription : NetworkManagementEntityDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryFeatureInformationElementsType {
    
    private NodeManagementDetailedDiscoveryFeatureInformationElementsTypeDescription descriptionField;
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryFeatureInformationElementsTypeDescription description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryFeatureInformationElementsTypeDescription : NetworkManagementFeatureDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementSubscriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementSubscriptionDataElementsType {
    
    private NodeManagementSubscriptionDataElementsTypeSubscriptionEntry subscriptionEntryField;
    
    /// <remarks/>
    public NodeManagementSubscriptionDataElementsTypeSubscriptionEntry subscriptionEntry {
        get {
            return this.subscriptionEntryField;
        }
        set {
            this.subscriptionEntryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSubscriptionDataElementsTypeSubscriptionEntry : SubscriptionManagementEntryDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("subscriptionManagementEntryDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SubscriptionManagementEntryDataElementsType {
    
    private ElementTagType subscriptionIdField;
    
    private FeatureAddressElementsType clientAddressField;
    
    private FeatureAddressElementsType serverAddressField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType subscriptionId {
        get {
            return this.subscriptionIdField;
        }
        set {
            this.subscriptionIdField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementSubscriptionDeleteCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementSubscriptionDeleteCallElementsType {
    
    private NodeManagementSubscriptionDeleteCallElementsTypeSubscriptionDelete subscriptionDeleteField;
    
    /// <remarks/>
    public NodeManagementSubscriptionDeleteCallElementsTypeSubscriptionDelete subscriptionDelete {
        get {
            return this.subscriptionDeleteField;
        }
        set {
            this.subscriptionDeleteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSubscriptionDeleteCallElementsTypeSubscriptionDelete : SubscriptionManagementDeleteCallElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("subscriptionManagementDeleteCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SubscriptionManagementDeleteCallElementsType {
    
    private ElementTagType subscriptionIdField;
    
    private FeatureAddressElementsType clientAddressField;
    
    private FeatureAddressElementsType serverAddressField;
    
    /// <remarks/>
    public ElementTagType subscriptionId {
        get {
            return this.subscriptionIdField;
        }
        set {
            this.subscriptionIdField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementSubscriptionRequestCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementSubscriptionRequestCallElementsType {
    
    private NodeManagementSubscriptionRequestCallElementsTypeSubscriptionRequest subscriptionRequestField;
    
    /// <remarks/>
    public NodeManagementSubscriptionRequestCallElementsTypeSubscriptionRequest subscriptionRequest {
        get {
            return this.subscriptionRequestField;
        }
        set {
            this.subscriptionRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSubscriptionRequestCallElementsTypeSubscriptionRequest : SubscriptionManagementRequestCallElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("subscriptionManagementRequestCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SubscriptionManagementRequestCallElementsType {
    
    private FeatureAddressElementsType clientAddressField;
    
    private FeatureAddressElementsType serverAddressField;
    
    private ElementTagType serverFeatureTypeField;
    
    /// <remarks/>
    public FeatureAddressElementsType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressElementsType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType serverFeatureType {
        get {
            return this.serverFeatureTypeField;
        }
        set {
            this.serverFeatureTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementUseCaseDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementUseCaseDataElementsType {
    
    private NodeManagementUseCaseDataElementsTypeUseCaseInformation useCaseInformationField;
    
    /// <remarks/>
    public NodeManagementUseCaseDataElementsTypeUseCaseInformation useCaseInformation {
        get {
            return this.useCaseInformationField;
        }
        set {
            this.useCaseInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementUseCaseDataElementsTypeUseCaseInformation : UseCaseInformationDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("useCaseInformationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class UseCaseInformationDataElementsType {
    
    private FeatureAddressElementsType addressField;
    
    private ElementTagType actorField;
    
    private UseCaseSupportElementsType useCaseSupportField;
    
    /// <remarks/>
    public FeatureAddressElementsType address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType actor {
        get {
            return this.actorField;
        }
        set {
            this.actorField = value;
        }
    }
    
    /// <remarks/>
    public UseCaseSupportElementsType useCaseSupport {
        get {
            return this.useCaseSupportField;
        }
        set {
            this.useCaseSupportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class UseCaseSupportElementsType {
    
    private ElementTagType useCaseNameField;
    
    private ElementTagType useCaseVersionField;
    
    private ElementTagType useCaseAvailableField;
    
    private ElementTagType scenarioSupportField;
    
    /// <remarks/>
    public ElementTagType useCaseName {
        get {
            return this.useCaseNameField;
        }
        set {
            this.useCaseNameField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType useCaseVersion {
        get {
            return this.useCaseVersionField;
        }
        set {
            this.useCaseVersionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType useCaseAvailable {
        get {
            return this.useCaseAvailableField;
        }
        set {
            this.useCaseAvailableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scenarioSupport {
        get {
            return this.scenarioSupportField;
        }
        set {
            this.scenarioSupportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsDurationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsDurationDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType activeDurationMinField;
    
    private ElementTagType activeDurationMaxField;
    
    private ElementTagType pauseDurationMinField;
    
    private ElementTagType pauseDurationMaxField;
    
    private ElementTagType activeDurationSumMinField;
    
    private ElementTagType activeDurationSumMaxField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activeDurationMin {
        get {
            return this.activeDurationMinField;
        }
        set {
            this.activeDurationMinField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activeDurationMax {
        get {
            return this.activeDurationMaxField;
        }
        set {
            this.activeDurationMaxField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType pauseDurationMin {
        get {
            return this.pauseDurationMinField;
        }
        set {
            this.pauseDurationMinField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType pauseDurationMax {
        get {
            return this.pauseDurationMaxField;
        }
        set {
            this.pauseDurationMaxField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activeDurationSumMin {
        get {
            return this.activeDurationSumMinField;
        }
        set {
            this.activeDurationSumMinField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activeDurationSumMax {
        get {
            return this.activeDurationSumMaxField;
        }
        set {
            this.activeDurationSumMaxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsInterruptDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsInterruptDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType isPausableField;
    
    private ElementTagType isStoppableField;
    
    private ElementTagType notInterruptibleAtHighPowerField;
    
    private ElementTagType maxCyclesPerDayField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isPausable {
        get {
            return this.isPausableField;
        }
        set {
            this.isPausableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType isStoppable {
        get {
            return this.isStoppableField;
        }
        set {
            this.isStoppableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType notInterruptibleAtHighPower {
        get {
            return this.notInterruptibleAtHighPowerField;
        }
        set {
            this.notInterruptibleAtHighPowerField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxCyclesPerDay {
        get {
            return this.maxCyclesPerDayField;
        }
        set {
            this.maxCyclesPerDayField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerDescriptionDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType positiveEnergyDirectionField;
    
    private ElementTagType powerUnitField;
    
    private ElementTagType energyUnitField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType powerUnit {
        get {
            return this.powerUnitField;
        }
        set {
            this.powerUnitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType energyUnit {
        get {
            return this.energyUnitField;
        }
        set {
            this.energyUnitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerLevelDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerLevelDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ScaledNumberElementsType powerField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType power {
        get {
            return this.powerField;
        }
        set {
            this.powerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerRangeDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerRangeDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ScaledNumberElementsType powerMinField;
    
    private ScaledNumberElementsType powerMaxField;
    
    private ScaledNumberElementsType energyMinField;
    
    private ScaledNumberElementsType energyMaxField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType powerMin {
        get {
            return this.powerMinField;
        }
        set {
            this.powerMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType powerMax {
        get {
            return this.powerMaxField;
        }
        set {
            this.powerMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType energyMin {
        get {
            return this.energyMinField;
        }
        set {
            this.energyMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType energyMax {
        get {
            return this.energyMaxField;
        }
        set {
            this.energyMaxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsResumeImplicationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsResumeImplicationDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ScaledNumberElementsType resumeEnergyEstimatedField;
    
    private ElementTagType energyUnitField;
    
    private ScaledNumberElementsType resumeCostEstimatedField;
    
    private ElementTagType currencyField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType resumeEnergyEstimated {
        get {
            return this.resumeEnergyEstimatedField;
        }
        set {
            this.resumeEnergyEstimatedField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType energyUnit {
        get {
            return this.energyUnitField;
        }
        set {
            this.energyUnitField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType resumeCostEstimated {
        get {
            return this.resumeCostEstimatedField;
        }
        set {
            this.resumeCostEstimatedField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SmartEnergyManagementPsAlternativesRelationElementsType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceAlternativesRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceAlternativesRelationDataElementsType {
    
    private ElementTagType alternativesIdField;
    
    private ElementTagType sequenceIdField;
    
    /// <remarks/>
    public ElementTagType alternativesId {
        get {
            return this.alternativesIdField;
        }
        set {
            this.alternativesIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsAlternativesRelationElementsType : PowerSequenceAlternativesRelationDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceDescriptionDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType descriptionField;
    
    private ElementTagType positiveEnergyDirectionField;
    
    private ElementTagType powerUnitField;
    
    private ElementTagType energyUnitField;
    
    private ElementTagType valueSourceField;
    
    private ElementTagType scopeField;
    
    private ElementTagType taskIdentifierField;
    
    private ElementTagType repetitionsTotalField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType powerUnit {
        get {
            return this.powerUnitField;
        }
        set {
            this.powerUnitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType energyUnit {
        get {
            return this.energyUnitField;
        }
        set {
            this.energyUnitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueSource {
        get {
            return this.valueSourceField;
        }
        set {
            this.valueSourceField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scope {
        get {
            return this.scopeField;
        }
        set {
            this.scopeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType taskIdentifier {
        get {
            return this.taskIdentifierField;
        }
        set {
            this.taskIdentifierField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType repetitionsTotal {
        get {
            return this.repetitionsTotalField;
        }
        set {
            this.repetitionsTotalField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceNodeScheduleInformationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceNodeScheduleInformationDataElementsType {
    
    private ElementTagType nodeRemoteControllableField;
    
    private ElementTagType supportsSingleSlotSchedulingOnlyField;
    
    private ElementTagType alternativesCountField;
    
    private ElementTagType totalSequencesCountMaxField;
    
    private ElementTagType supportsReselectionField;
    
    /// <remarks/>
    public ElementTagType nodeRemoteControllable {
        get {
            return this.nodeRemoteControllableField;
        }
        set {
            this.nodeRemoteControllableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType supportsSingleSlotSchedulingOnly {
        get {
            return this.supportsSingleSlotSchedulingOnlyField;
        }
        set {
            this.supportsSingleSlotSchedulingOnlyField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType alternativesCount {
        get {
            return this.alternativesCountField;
        }
        set {
            this.alternativesCountField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType totalSequencesCountMax {
        get {
            return this.totalSequencesCountMaxField;
        }
        set {
            this.totalSequencesCountMaxField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType supportsReselection {
        get {
            return this.supportsReselectionField;
        }
        set {
            this.supportsReselectionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequencePriceCalculationRequestCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequencePriceCalculationRequestCallElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType potentialStartTimeField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType potentialStartTime {
        get {
            return this.potentialStartTimeField;
        }
        set {
            this.potentialStartTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequencePriceDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequencePriceDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType potentialStartTimeField;
    
    private ScaledNumberElementsType priceField;
    
    private ElementTagType currencyField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType potentialStartTime {
        get {
            return this.potentialStartTimeField;
        }
        set {
            this.potentialStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleConfigurationRequestCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleConfigurationRequestCallElementsType {
    
    private ElementTagType sequenceIdField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleConstraintsDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType earliestStartTimeField;
    
    private ElementTagType latestStartTimeField;
    
    private ElementTagType earliestEndTimeField;
    
    private ElementTagType latestEndTimeField;
    
    private ElementTagType optionalSequenceField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType earliestStartTime {
        get {
            return this.earliestStartTimeField;
        }
        set {
            this.earliestStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType latestStartTime {
        get {
            return this.latestStartTimeField;
        }
        set {
            this.latestStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType earliestEndTime {
        get {
            return this.earliestEndTimeField;
        }
        set {
            this.earliestEndTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType latestEndTime {
        get {
            return this.latestEndTimeField;
        }
        set {
            this.latestEndTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType optionalSequence {
        get {
            return this.optionalSequenceField;
        }
        set {
            this.optionalSequenceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType startTimeField;
    
    private ElementTagType endTimeField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceSchedulePreferenceDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceSchedulePreferenceDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType greenestField;
    
    private ElementTagType cheapestField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType greenest {
        get {
            return this.greenestField;
        }
        set {
            this.greenestField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType cheapest {
        get {
            return this.cheapestField;
        }
        set {
            this.cheapestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceStateDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceStateDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType stateField;
    
    private ElementTagType activeSlotNumberField;
    
    private ElementTagType elapsedSlotTimeField;
    
    private ElementTagType remainingSlotTimeField;
    
    private ElementTagType sequenceRemoteControllableField;
    
    private ElementTagType activeRepetitionNumberField;
    
    private ElementTagType remainingPauseTimeField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activeSlotNumber {
        get {
            return this.activeSlotNumberField;
        }
        set {
            this.activeSlotNumberField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType elapsedSlotTime {
        get {
            return this.elapsedSlotTimeField;
        }
        set {
            this.elapsedSlotTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType remainingSlotTime {
        get {
            return this.remainingSlotTimeField;
        }
        set {
            this.remainingSlotTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType sequenceRemoteControllable {
        get {
            return this.sequenceRemoteControllableField;
        }
        set {
            this.sequenceRemoteControllableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType activeRepetitionNumber {
        get {
            return this.activeRepetitionNumberField;
        }
        set {
            this.activeRepetitionNumberField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType remainingPauseTime {
        get {
            return this.remainingPauseTimeField;
        }
        set {
            this.remainingPauseTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotScheduleConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotScheduleConstraintsDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType slotNumberField;
    
    private ElementTagType earliestStartTimeField;
    
    private ElementTagType latestEndTimeField;
    
    private ElementTagType minDurationField;
    
    private ElementTagType maxDurationField;
    
    private ElementTagType optionalSlotField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType earliestStartTime {
        get {
            return this.earliestStartTimeField;
        }
        set {
            this.earliestStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType latestEndTime {
        get {
            return this.latestEndTimeField;
        }
        set {
            this.latestEndTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType minDuration {
        get {
            return this.minDurationField;
        }
        set {
            this.minDurationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxDuration {
        get {
            return this.maxDurationField;
        }
        set {
            this.maxDurationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType optionalSlot {
        get {
            return this.optionalSlotField;
        }
        set {
            this.optionalSlotField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotScheduleDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotScheduleDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType slotNumberField;
    
    private TimePeriodElementsType timePeriodField;
    
    private ElementTagType defaultDurationField;
    
    private ElementTagType durationUncertaintyField;
    
    private ElementTagType slotActivatedField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType defaultDuration {
        get {
            return this.defaultDurationField;
        }
        set {
            this.defaultDurationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType durationUncertainty {
        get {
            return this.durationUncertaintyField;
        }
        set {
            this.durationUncertaintyField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotActivated {
        get {
            return this.slotActivatedField;
        }
        set {
            this.slotActivatedField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotValueDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotValueDataElementsType {
    
    private ElementTagType sequenceIdField;
    
    private ElementTagType slotNumberField;
    
    private ElementTagType valueTypeField;
    
    private ScaledNumberElementsType valueField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("sensingDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SensingDataElementsType {
    
    private ElementTagType timestampField;
    
    private ElementTagType stateField;
    
    private ScaledNumberElementsType valueField;
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("sensingDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SensingDescriptionDataElementsType {
    
    private ElementTagType sensingTypeField;
    
    private ElementTagType unitField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType sensingType {
        get {
            return this.sensingTypeField;
        }
        set {
            this.sensingTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointConstraintsDataElementsType {
    
    private ElementTagType setpointIdField;
    
    private ScaledNumberElementsType setpointRangeMinField;
    
    private ScaledNumberElementsType setpointRangeMaxField;
    
    private ScaledNumberElementsType setpointStepSizeField;
    
    /// <remarks/>
    public ElementTagType setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType setpointRangeMin {
        get {
            return this.setpointRangeMinField;
        }
        set {
            this.setpointRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType setpointRangeMax {
        get {
            return this.setpointRangeMaxField;
        }
        set {
            this.setpointRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType setpointStepSize {
        get {
            return this.setpointStepSizeField;
        }
        set {
            this.setpointStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointDataElementsType {
    
    private ElementTagType setpointIdField;
    
    private ScaledNumberElementsType valueField;
    
    private ScaledNumberElementsType valueMinField;
    
    private ScaledNumberElementsType valueMaxField;
    
    private ScaledNumberElementsType valueToleranceAbsoluteField;
    
    private ScaledNumberElementsType valueTolerancePercentageField;
    
    /// <remarks/>
    public ElementTagType setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueMin {
        get {
            return this.valueMinField;
        }
        set {
            this.valueMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueMax {
        get {
            return this.valueMaxField;
        }
        set {
            this.valueMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueToleranceAbsolute {
        get {
            return this.valueToleranceAbsoluteField;
        }
        set {
            this.valueToleranceAbsoluteField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType valueTolerancePercentage {
        get {
            return this.valueTolerancePercentageField;
        }
        set {
            this.valueTolerancePercentageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointDescriptionDataElementsType {
    
    private ElementTagType setpointIdField;
    
    private ElementTagType measurementIdField;
    
    private ElementTagType timeTableIdField;
    
    private ElementTagType setpointTypeField;
    
    private ElementTagType unitField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType setpointType {
        get {
            return this.setpointTypeField;
        }
        set {
            this.setpointTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsConfigurationRequestCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsConfigurationRequestCallElementsType {
    
    private SmartEnergyManagementPsConfigurationRequestCallElementsTypeScheduleConfigurationRequest scheduleConfigurationRequestField;
    
    /// <remarks/>
    public SmartEnergyManagementPsConfigurationRequestCallElementsTypeScheduleConfigurationRequest scheduleConfigurationRequest {
        get {
            return this.scheduleConfigurationRequestField;
        }
        set {
            this.scheduleConfigurationRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsConfigurationRequestCallElementsTypeScheduleConfigurationRequest : PowerSequenceScheduleConfigurationRequestCallElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsDataElementsType {
    
    private SmartEnergyManagementPsDataElementsTypeNodeScheduleInformation nodeScheduleInformationField;
    
    private SmartEnergyManagementPsAlternativesElementsType alternativesField;
    
    /// <remarks/>
    public SmartEnergyManagementPsDataElementsTypeNodeScheduleInformation nodeScheduleInformation {
        get {
            return this.nodeScheduleInformationField;
        }
        set {
            this.nodeScheduleInformationField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsAlternativesElementsType alternatives {
        get {
            return this.alternativesField;
        }
        set {
            this.alternativesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsDataElementsTypeNodeScheduleInformation : PowerSequenceNodeScheduleInformationDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsAlternativesElementsType {
    
    private SmartEnergyManagementPsAlternativesRelationElementsType relationField;
    
    private SmartEnergyManagementPsPowerSequenceElementsType powerSequenceField;
    
    /// <remarks/>
    public SmartEnergyManagementPsAlternativesRelationElementsType relation {
        get {
            return this.relationField;
        }
        set {
            this.relationField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsType powerSequence {
        get {
            return this.powerSequenceField;
        }
        set {
            this.powerSequenceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsType {
    
    private SmartEnergyManagementPsPowerSequenceElementsTypeDescription descriptionField;
    
    private SmartEnergyManagementPsPowerSequenceElementsTypeState stateField;
    
    private SmartEnergyManagementPsPowerSequenceElementsTypeSchedule scheduleField;
    
    private SmartEnergyManagementPsPowerSequenceElementsTypeScheduleConstraints scheduleConstraintsField;
    
    private SmartEnergyManagementPsPowerSequenceElementsTypeSchedulePreference schedulePreferenceField;
    
    private SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsInterrupt operatingConstraintsInterruptField;
    
    private SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsDuration operatingConstraintsDurationField;
    
    private SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsResumeImplication operatingConstraintsResumeImplicationField;
    
    private SmartEnergyManagementPsPowerTimeSlotElementsType powerTimeSlotField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsTypeDescription description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsTypeState state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsTypeSchedule schedule {
        get {
            return this.scheduleField;
        }
        set {
            this.scheduleField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsTypeScheduleConstraints scheduleConstraints {
        get {
            return this.scheduleConstraintsField;
        }
        set {
            this.scheduleConstraintsField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsTypeSchedulePreference schedulePreference {
        get {
            return this.schedulePreferenceField;
        }
        set {
            this.schedulePreferenceField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsInterrupt operatingConstraintsInterrupt {
        get {
            return this.operatingConstraintsInterruptField;
        }
        set {
            this.operatingConstraintsInterruptField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsDuration operatingConstraintsDuration {
        get {
            return this.operatingConstraintsDurationField;
        }
        set {
            this.operatingConstraintsDurationField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsResumeImplication operatingConstraintsResumeImplication {
        get {
            return this.operatingConstraintsResumeImplicationField;
        }
        set {
            this.operatingConstraintsResumeImplicationField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerTimeSlotElementsType powerTimeSlot {
        get {
            return this.powerTimeSlotField;
        }
        set {
            this.powerTimeSlotField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsTypeDescription : PowerSequenceDescriptionDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsTypeState : PowerSequenceStateDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsTypeSchedule : PowerSequenceScheduleDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsTypeScheduleConstraints : PowerSequenceScheduleConstraintsDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsTypeSchedulePreference : PowerSequenceSchedulePreferenceDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsInterrupt : OperatingConstraintsInterruptDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsDuration : OperatingConstraintsDurationDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceElementsTypeOperatingConstraintsResumeImplication : OperatingConstraintsResumeImplicationDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotElementsType {
    
    private SmartEnergyManagementPsPowerTimeSlotElementsTypeSchedule scheduleField;
    
    private SmartEnergyManagementPsPowerTimeSlotValueListElementsType valueListField;
    
    private SmartEnergyManagementPsPowerTimeSlotElementsTypeScheduleConstraints scheduleConstraintsField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerTimeSlotElementsTypeSchedule schedule {
        get {
            return this.scheduleField;
        }
        set {
            this.scheduleField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerTimeSlotValueListElementsType valueList {
        get {
            return this.valueListField;
        }
        set {
            this.valueListField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerTimeSlotElementsTypeScheduleConstraints scheduleConstraints {
        get {
            return this.scheduleConstraintsField;
        }
        set {
            this.scheduleConstraintsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotElementsTypeSchedule : PowerTimeSlotScheduleDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotValueListElementsType {
    
    private SmartEnergyManagementPsPowerTimeSlotValueListElementsTypeValue valueField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerTimeSlotValueListElementsTypeValue value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotValueListElementsTypeValue : PowerTimeSlotValueDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotElementsTypeScheduleConstraints : PowerTimeSlotScheduleConstraintsDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsPriceCalculationRequestCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsPriceCalculationRequestCallElementsType {
    
    private SmartEnergyManagementPsPriceCalculationRequestCallElementsTypePriceCalculationRequest priceCalculationRequestField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceCalculationRequestCallElementsTypePriceCalculationRequest priceCalculationRequest {
        get {
            return this.priceCalculationRequestField;
        }
        set {
            this.priceCalculationRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPriceCalculationRequestCallElementsTypePriceCalculationRequest : PowerSequencePriceCalculationRequestCallElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsPriceDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsPriceDataElementsType {
    
    private SmartEnergyManagementPsPriceDataElementsTypePrice priceField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceDataElementsTypePrice price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPriceDataElementsTypePrice : PowerSequencePriceDataElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionDataElementsType {
    
    private ElementTagType conditionIdField;
    
    private ElementTagType timestampField;
    
    private ElementTagType eventTypeField;
    
    private ElementTagType originatorField;
    
    private ElementTagType thresholdIdField;
    
    private ScaledNumberElementsType thresholdPercentageField;
    
    private TimePeriodElementsType relevantPeriodField;
    
    private ElementTagType descriptionField;
    
    private ElementTagType gridConditionField;
    
    /// <remarks/>
    public ElementTagType conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType eventType {
        get {
            return this.eventTypeField;
        }
        set {
            this.eventTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType originator {
        get {
            return this.originatorField;
        }
        set {
            this.originatorField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType thresholdPercentage {
        get {
            return this.thresholdPercentageField;
        }
        set {
            this.thresholdPercentageField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType relevantPeriod {
        get {
            return this.relevantPeriodField;
        }
        set {
            this.relevantPeriodField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType gridCondition {
        get {
            return this.gridConditionField;
        }
        set {
            this.gridConditionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionDescriptionDataElementsType {
    
    private ElementTagType conditionIdField;
    
    private ElementTagType commodityTypeField;
    
    private ElementTagType positiveEnergyDirectionField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType commodityType {
        get {
            return this.commodityTypeField;
        }
        set {
            this.commodityTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionThresholdRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionThresholdRelationDataElementsType {
    
    private ElementTagType conditionIdField;
    
    private ElementTagType thresholdIdField;
    
    /// <remarks/>
    public ElementTagType conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffBoundaryRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffBoundaryRelationDataElementsType {
    
    private ElementTagType tariffIdField;
    
    private ElementTagType boundaryIdField;
    
    /// <remarks/>
    public ElementTagType tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffTierRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffTierRelationDataElementsType {
    
    private ElementTagType tariffIdField;
    
    private ElementTagType tierIdField;
    
    /// <remarks/>
    public ElementTagType tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobDataElementsType {
    
    private ElementTagType jobIdField;
    
    private ElementTagType timestampField;
    
    private ElementTagType jobStateField;
    
    private ElementTagType elapsedTimeField;
    
    private ElementTagType remainingTimeField;
    
    /// <remarks/>
    public ElementTagType jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType jobState {
        get {
            return this.jobStateField;
        }
        set {
            this.jobStateField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType elapsedTime {
        get {
            return this.elapsedTimeField;
        }
        set {
            this.elapsedTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType remainingTime {
        get {
            return this.remainingTimeField;
        }
        set {
            this.remainingTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobDescriptionDataElementsType {
    
    private ElementTagType jobIdField;
    
    private ElementTagType jobSourceField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType jobSource {
        get {
            return this.jobSourceField;
        }
        set {
            this.jobSourceField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobRelationDataElementsType {
    
    private ElementTagType jobIdField;
    
    private TaskManagementDirectControlRelatedElementsType directControlRelatedField;
    
    private TaskManagementHvacRelatedElementsType hvacRelatedField;
    
    private TaskManagementLoadControlReleatedElementsType loadControlReleatedField;
    
    private TaskManagementPowerSequencesRelatedElementsType powerSequencesRelatedField;
    
    private TaskManagementSmartEnergyManagementPsRelatedElementsType smartEnergyManagementPsRelatedField;
    
    /// <remarks/>
    public ElementTagType jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementDirectControlRelatedElementsType directControlRelated {
        get {
            return this.directControlRelatedField;
        }
        set {
            this.directControlRelatedField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementHvacRelatedElementsType hvacRelated {
        get {
            return this.hvacRelatedField;
        }
        set {
            this.hvacRelatedField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementLoadControlReleatedElementsType loadControlReleated {
        get {
            return this.loadControlReleatedField;
        }
        set {
            this.loadControlReleatedField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementPowerSequencesRelatedElementsType powerSequencesRelated {
        get {
            return this.powerSequencesRelatedField;
        }
        set {
            this.powerSequencesRelatedField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementSmartEnergyManagementPsRelatedElementsType smartEnergyManagementPsRelated {
        get {
            return this.smartEnergyManagementPsRelatedField;
        }
        set {
            this.smartEnergyManagementPsRelatedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementDirectControlRelatedElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementHvacRelatedElementsType {
    
    private ElementTagType overrunIdField;
    
    /// <remarks/>
    public ElementTagType overrunId {
        get {
            return this.overrunIdField;
        }
        set {
            this.overrunIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementLoadControlReleatedElementsType {
    
    private ElementTagType eventIdField;
    
    /// <remarks/>
    public ElementTagType eventId {
        get {
            return this.eventIdField;
        }
        set {
            this.eventIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementPowerSequencesRelatedElementsType {
    
    private ElementTagType sequenceIdField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementSmartEnergyManagementPsRelatedElementsType {
    
    private ElementTagType sequenceIdField;
    
    /// <remarks/>
    public ElementTagType sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementOverviewDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementOverviewDataElementsType {
    
    private ElementTagType remoteControllableField;
    
    private ElementTagType jobsActiveField;
    
    /// <remarks/>
    public ElementTagType remoteControllable {
        get {
            return this.remoteControllableField;
        }
        set {
            this.remoteControllableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType jobsActive {
        get {
            return this.jobsActiveField;
        }
        set {
            this.jobsActiveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdConstraintsDataElementsType {
    
    private ElementTagType thresholdIdField;
    
    private ScaledNumberElementsType thresholdRangeMinField;
    
    private ScaledNumberElementsType thresholdRangeMaxField;
    
    private ScaledNumberElementsType thresholdStepSizeField;
    
    /// <remarks/>
    public ElementTagType thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType thresholdRangeMin {
        get {
            return this.thresholdRangeMinField;
        }
        set {
            this.thresholdRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType thresholdRangeMax {
        get {
            return this.thresholdRangeMaxField;
        }
        set {
            this.thresholdRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType thresholdStepSize {
        get {
            return this.thresholdStepSizeField;
        }
        set {
            this.thresholdStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdDataElementsType {
    
    private ElementTagType thresholdIdField;
    
    private ScaledNumberElementsType thresholdValueField;
    
    /// <remarks/>
    public ElementTagType thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType thresholdValue {
        get {
            return this.thresholdValueField;
        }
        set {
            this.thresholdValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdDescriptionDataElementsType {
    
    private ElementTagType thresholdIdField;
    
    private ElementTagType thresholdTypeField;
    
    private ElementTagType unitField;
    
    private ElementTagType scopeTypeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType thresholdType {
        get {
            return this.thresholdTypeField;
        }
        set {
            this.thresholdTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierIncentiveRelationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierIncentiveRelationDataElementsType {
    
    private ElementTagType tierIdField;
    
    private ElementTagType incentiveIdField;
    
    /// <remarks/>
    public ElementTagType tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeDistributorDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeDistributorDataElementsType {
    
    private ElementTagType isTimeDistributorField;
    
    private ElementTagType distributorPriorityField;
    
    /// <remarks/>
    public ElementTagType isTimeDistributor {
        get {
            return this.isTimeDistributorField;
        }
        set {
            this.isTimeDistributorField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType distributorPriority {
        get {
            return this.distributorPriorityField;
        }
        set {
            this.distributorPriorityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeDistributorEnquiryCallElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeDistributorEnquiryCallElementsType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeInformationDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeInformationDataElementsType {
    
    private ElementTagType utcField;
    
    private ElementTagType utcOffsetField;
    
    private ElementTagType dayOfWeekField;
    
    private ElementTagType calendarWeekField;
    
    /// <remarks/>
    public ElementTagType utc {
        get {
            return this.utcField;
        }
        set {
            this.utcField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType utcOffset {
        get {
            return this.utcOffsetField;
        }
        set {
            this.utcOffsetField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType dayOfWeek {
        get {
            return this.dayOfWeekField;
        }
        set {
            this.dayOfWeekField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType calendarWeek {
        get {
            return this.calendarWeekField;
        }
        set {
            this.calendarWeekField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timePrecisionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimePrecisionDataElementsType {
    
    private ElementTagType isSynchronisedField;
    
    private ElementTagType lastSyncAtField;
    
    private ElementTagType clockDriftField;
    
    /// <remarks/>
    public ElementTagType isSynchronised {
        get {
            return this.isSynchronisedField;
        }
        set {
            this.isSynchronisedField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType lastSyncAt {
        get {
            return this.lastSyncAtField;
        }
        set {
            this.lastSyncAtField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType clockDrift {
        get {
            return this.clockDriftField;
        }
        set {
            this.clockDriftField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesConstraintsDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesConstraintsDataElementsType {
    
    private ElementTagType timeSeriesIdField;
    
    private ElementTagType slotCountMinField;
    
    private ElementTagType slotCountMaxField;
    
    private ElementTagType slotDurationMinField;
    
    private ElementTagType slotDurationMaxField;
    
    private ElementTagType slotDurationStepSizeField;
    
    private ElementTagType earliestTimeSeriesStartTimeField;
    
    private ElementTagType latestTimeSeriesEndTimeField;
    
    private ScaledNumberElementsType slotValueMinField;
    
    private ScaledNumberElementsType slotValueMaxField;
    
    private ScaledNumberElementsType slotValueStepSizeField;
    
    /// <remarks/>
    public ElementTagType timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotCountMin {
        get {
            return this.slotCountMinField;
        }
        set {
            this.slotCountMinField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotCountMax {
        get {
            return this.slotCountMaxField;
        }
        set {
            this.slotCountMaxField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotDurationMin {
        get {
            return this.slotDurationMinField;
        }
        set {
            this.slotDurationMinField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotDurationMax {
        get {
            return this.slotDurationMaxField;
        }
        set {
            this.slotDurationMaxField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType slotDurationStepSize {
        get {
            return this.slotDurationStepSizeField;
        }
        set {
            this.slotDurationStepSizeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType earliestTimeSeriesStartTime {
        get {
            return this.earliestTimeSeriesStartTimeField;
        }
        set {
            this.earliestTimeSeriesStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType latestTimeSeriesEndTime {
        get {
            return this.latestTimeSeriesEndTimeField;
        }
        set {
            this.latestTimeSeriesEndTimeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType slotValueMin {
        get {
            return this.slotValueMinField;
        }
        set {
            this.slotValueMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType slotValueMax {
        get {
            return this.slotValueMaxField;
        }
        set {
            this.slotValueMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberElementsType slotValueStepSize {
        get {
            return this.slotValueStepSizeField;
        }
        set {
            this.slotValueStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesDataElementsType {
    
    private ElementTagType timeSeriesIdField;
    
    private TimePeriodElementsType timePeriodField;
    
    private TimeSeriesSlotElementsType timeSeriesSlotField;
    
    /// <remarks/>
    public ElementTagType timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public TimeSeriesSlotElementsType timeSeriesSlot {
        get {
            return this.timeSeriesSlotField;
        }
        set {
            this.timeSeriesSlotField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TimeSeriesSlotElementsType {
    
    private ElementTagType timeSeriesSlotIdField;
    
    private TimePeriodElementsType timePeriodField;
    
    private ElementTagType durationField;
    
    private AbsoluteOrRecurringTimeElementsType recurrenceInformationField;
    
    private ElementTagType valueField;
    
    private ElementTagType minValueField;
    
    private ElementTagType maxValueField;
    
    /// <remarks/>
    public ElementTagType timeSeriesSlotId {
        get {
            return this.timeSeriesSlotIdField;
        }
        set {
            this.timeSeriesSlotIdField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodElementsType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType duration {
        get {
            return this.durationField;
        }
        set {
            this.durationField = value;
        }
    }
    
    /// <remarks/>
    public AbsoluteOrRecurringTimeElementsType recurrenceInformation {
        get {
            return this.recurrenceInformationField;
        }
        set {
            this.recurrenceInformationField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType minValue {
        get {
            return this.minValueField;
        }
        set {
            this.minValueField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType maxValue {
        get {
            return this.maxValueField;
        }
        set {
            this.maxValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesDescriptionDataElementsType {
    
    private ElementTagType timeSeriesIdField;
    
    private ElementTagType timeSeriesTypeField;
    
    private ElementTagType timeSeriesWriteableField;
    
    private ElementTagType updateRequiredField;
    
    private ElementTagType measurementIdField;
    
    private ElementTagType currencyField;
    
    private ElementTagType unitField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    private ElementTagType scopeTypeField;
    
    /// <remarks/>
    public ElementTagType timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeSeriesType {
        get {
            return this.timeSeriesTypeField;
        }
        set {
            this.timeSeriesTypeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeSeriesWriteable {
        get {
            return this.timeSeriesWriteableField;
        }
        set {
            this.timeSeriesWriteableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType updateRequired {
        get {
            return this.updateRequiredField;
        }
        set {
            this.updateRequiredField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableDescriptionDataElements", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableDescriptionDataElementsType {
    
    private ElementTagType timeTableIdField;
    
    private ElementTagType timeSlotCountChangeableField;
    
    private ElementTagType timeSlotTimesChangeableField;
    
    private ElementTagType timeSlotTimeModeField;
    
    private ElementTagType labelField;
    
    private ElementTagType descriptionField;
    
    /// <remarks/>
    public ElementTagType timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeSlotCountChangeable {
        get {
            return this.timeSlotCountChangeableField;
        }
        set {
            this.timeSlotCountChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeSlotTimesChangeable {
        get {
            return this.timeSlotTimesChangeableField;
        }
        set {
            this.timeSlotTimesChangeableField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType timeSlotTimeMode {
        get {
            return this.timeSlotTimeModeField;
        }
        set {
            this.timeSlotTimeModeField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("actuatorLevelDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ActuatorLevelDescriptionDataType {
    
    private string labelField;
    
    private string descriptionField;
    
    private string levelDefaultUnitField;
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public string levelDefaultUnit {
        get {
            return this.levelDefaultUnitField;
        }
        set {
            this.levelDefaultUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("actuatorSwitchData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ActuatorSwitchDataType {
    
    private string functionField;
    
    /// <remarks/>
    public string function {
        get {
            return this.functionField;
        }
        set {
            this.functionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("actuatorSwitchDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ActuatorSwitchDescriptionDataType {
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("alarmData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class AlarmDataType {
    
    private uint alarmIdField;
    
    private bool alarmIdFieldSpecified;
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    private string timestampField;
    
    private string alarmTypeField;
    
    private ScaledNumberType measuredValueField;
    
    private TimePeriodType evaluationPeriodField;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint alarmId {
        get {
            return this.alarmIdField;
        }
        set {
            this.alarmIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool alarmIdSpecified {
        get {
            return this.alarmIdFieldSpecified;
        }
        set {
            this.alarmIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string alarmType {
        get {
            return this.alarmTypeField;
        }
        set {
            this.alarmTypeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType measuredValue {
        get {
            return this.measuredValueField;
        }
        set {
            this.measuredValueField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType evaluationPeriod {
        get {
            return this.evaluationPeriodField;
        }
        set {
            this.evaluationPeriodField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TimePeriodType {
    
    private string startTimeField;
    
    private string endTimeField;
    
    /// <remarks/>
    public string startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    public string endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillConstraintsDataType {
    
    private uint billIdField;
    
    private bool billIdFieldSpecified;
    
    private uint positionCountMinField;
    
    private bool positionCountMinFieldSpecified;
    
    private uint positionCountMaxField;
    
    private bool positionCountMaxFieldSpecified;
    
    /// <remarks/>
    public uint billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool billIdSpecified {
        get {
            return this.billIdFieldSpecified;
        }
        set {
            this.billIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint positionCountMin {
        get {
            return this.positionCountMinField;
        }
        set {
            this.positionCountMinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool positionCountMinSpecified {
        get {
            return this.positionCountMinFieldSpecified;
        }
        set {
            this.positionCountMinFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint positionCountMax {
        get {
            return this.positionCountMaxField;
        }
        set {
            this.positionCountMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool positionCountMaxSpecified {
        get {
            return this.positionCountMaxFieldSpecified;
        }
        set {
            this.positionCountMaxFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillDescriptionDataType {
    
    private uint billIdField;
    
    private bool billIdFieldSpecified;
    
    private bool billWriteableField;
    
    private bool billWriteableFieldSpecified;
    
    private bool updateRequiredField;
    
    private bool updateRequiredFieldSpecified;
    
    private string[] supportedBillTypeField;
    
    /// <remarks/>
    public uint billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool billIdSpecified {
        get {
            return this.billIdFieldSpecified;
        }
        set {
            this.billIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool billWriteable {
        get {
            return this.billWriteableField;
        }
        set {
            this.billWriteableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool billWriteableSpecified {
        get {
            return this.billWriteableFieldSpecified;
        }
        set {
            this.billWriteableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool updateRequired {
        get {
            return this.updateRequiredField;
        }
        set {
            this.updateRequiredField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool updateRequiredSpecified {
        get {
            return this.updateRequiredFieldSpecified;
        }
        set {
            this.updateRequiredFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("supportedBillType")]
    public string[] supportedBillType {
        get {
            return this.supportedBillTypeField;
        }
        set {
            this.supportedBillTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillDataType {
    
    private uint billIdField;
    
    private bool billIdFieldSpecified;
    
    private string billTypeField;
    
    private string scopeTypeField;
    
    private BillDataTypeTotal totalField;
    
    private BillDataTypePosition[] positionField;
    
    /// <remarks/>
    public uint billId {
        get {
            return this.billIdField;
        }
        set {
            this.billIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool billIdSpecified {
        get {
            return this.billIdFieldSpecified;
        }
        set {
            this.billIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string billType {
        get {
            return this.billTypeField;
        }
        set {
            this.billTypeField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public BillDataTypeTotal total {
        get {
            return this.totalField;
        }
        set {
            this.totalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("position")]
    public BillDataTypePosition[] position {
        get {
            return this.positionField;
        }
        set {
            this.positionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillDataTypeTotal : BillPositionType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillPositionType {
    
    private uint positionIdField;
    
    private bool positionIdFieldSpecified;
    
    private string positionTypeField;
    
    private TimePeriodType timePeriodField;
    
    private BillValueType[] valueField;
    
    private BillCostType[] costField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint positionId {
        get {
            return this.positionIdField;
        }
        set {
            this.positionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool positionIdSpecified {
        get {
            return this.positionIdFieldSpecified;
        }
        set {
            this.positionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string positionType {
        get {
            return this.positionTypeField;
        }
        set {
            this.positionTypeField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public BillValueType[] value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cost")]
    public BillCostType[] cost {
        get {
            return this.costField;
        }
        set {
            this.costField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillValueType {
    
    private uint valueIdField;
    
    private bool valueIdFieldSpecified;
    
    private string unitField;
    
    private ScaledNumberType valueField;
    
    private ScaledNumberType valuePercentageField;
    
    /// <remarks/>
    public uint valueId {
        get {
            return this.valueIdField;
        }
        set {
            this.valueIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueIdSpecified {
        get {
            return this.valueIdFieldSpecified;
        }
        set {
            this.valueIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valuePercentage {
        get {
            return this.valuePercentageField;
        }
        set {
            this.valuePercentageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillCostType {
    
    private uint costIdField;
    
    private bool costIdFieldSpecified;
    
    private string costTypeField;
    
    private uint valueIdField;
    
    private bool valueIdFieldSpecified;
    
    private string unitField;
    
    private string currencyField;
    
    private ScaledNumberType costField;
    
    private ScaledNumberType costPercentageField;
    
    /// <remarks/>
    public uint costId {
        get {
            return this.costIdField;
        }
        set {
            this.costIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool costIdSpecified {
        get {
            return this.costIdFieldSpecified;
        }
        set {
            this.costIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string costType {
        get {
            return this.costTypeField;
        }
        set {
            this.costTypeField = value;
        }
    }
    
    /// <remarks/>
    public uint valueId {
        get {
            return this.valueIdField;
        }
        set {
            this.valueIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueIdSpecified {
        get {
            return this.valueIdFieldSpecified;
        }
        set {
            this.valueIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType cost {
        get {
            return this.costField;
        }
        set {
            this.costField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType costPercentage {
        get {
            return this.costPercentageField;
        }
        set {
            this.costPercentageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class BillDataTypePosition : BillPositionType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("bindingManagementDeleteCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BindingManagementDeleteCallType {
    
    private uint bindingIdField;
    
    private bool bindingIdFieldSpecified;
    
    private FeatureAddressType clientAddressField;
    
    private FeatureAddressType serverAddressField;
    
    /// <remarks/>
    public uint bindingId {
        get {
            return this.bindingIdField;
        }
        set {
            this.bindingIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool bindingIdSpecified {
        get {
            return this.bindingIdFieldSpecified;
        }
        set {
            this.bindingIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("bindingManagementEntryData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BindingManagementEntryDataType {
    
    private uint bindingIdField;
    
    private bool bindingIdFieldSpecified;
    
    private FeatureAddressType clientAddressField;
    
    private FeatureAddressType serverAddressField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint bindingId {
        get {
            return this.bindingIdField;
        }
        set {
            this.bindingIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool bindingIdSpecified {
        get {
            return this.bindingIdFieldSpecified;
        }
        set {
            this.bindingIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("bindingManagementRequestCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BindingManagementRequestCallType {
    
    private FeatureAddressType clientAddressField;
    
    private FeatureAddressType serverAddressField;
    
    private string serverFeatureTypeField;
    
    /// <remarks/>
    public FeatureAddressType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
    
    /// <remarks/>
    public string serverFeatureType {
        get {
            return this.serverFeatureTypeField;
        }
        set {
            this.serverFeatureTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("commodityData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class CommodityDataType {
    
    private uint commodityIdField;
    
    private bool commodityIdFieldSpecified;
    
    private string commodityTypeField;
    
    private string positiveEnergyDirectionField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint commodityId {
        get {
            return this.commodityIdField;
        }
        set {
            this.commodityIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool commodityIdSpecified {
        get {
            return this.commodityIdFieldSpecified;
        }
        set {
            this.commodityIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string commodityType {
        get {
            return this.commodityTypeField;
        }
        set {
            this.commodityTypeField = value;
        }
    }
    
    /// <remarks/>
    public string positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("dataTunnelingCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DataTunnelingCallType {
    
    private DataTunnelingHeaderType headerField;
    
    private byte[] payloadField;
    
    /// <remarks/>
    public DataTunnelingHeaderType header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="hexBinary")]
    public byte[] payload {
        get {
            return this.payloadField;
        }
        set {
            this.payloadField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class DataTunnelingHeaderType {
    
    private string purposeIdField;
    
    private uint channelIdField;
    
    private bool channelIdFieldSpecified;
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public string purposeId {
        get {
            return this.purposeIdField;
        }
        set {
            this.purposeIdField = value;
        }
    }
    
    /// <remarks/>
    public uint channelId {
        get {
            return this.channelIdField;
        }
        set {
            this.channelIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool channelIdSpecified {
        get {
            return this.channelIdFieldSpecified;
        }
        set {
            this.channelIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceClassificationManufacturerData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceClassificationManufacturerDataType {
    
    private string deviceNameField;
    
    private string deviceCodeField;
    
    private string serialNumberField;
    
    private string softwareRevisionField;
    
    private string hardwareRevisionField;
    
    private string vendorNameField;
    
    private string vendorCodeField;
    
    private string brandNameField;
    
    private string powerSourceField;
    
    private string manufacturerNodeIdentificationField;
    
    private string manufacturerLabelField;
    
    private string manufacturerDescriptionField;
    
    /// <remarks/>
    public string deviceName {
        get {
            return this.deviceNameField;
        }
        set {
            this.deviceNameField = value;
        }
    }
    
    /// <remarks/>
    public string deviceCode {
        get {
            return this.deviceCodeField;
        }
        set {
            this.deviceCodeField = value;
        }
    }
    
    /// <remarks/>
    public string serialNumber {
        get {
            return this.serialNumberField;
        }
        set {
            this.serialNumberField = value;
        }
    }
    
    /// <remarks/>
    public string softwareRevision {
        get {
            return this.softwareRevisionField;
        }
        set {
            this.softwareRevisionField = value;
        }
    }
    
    /// <remarks/>
    public string hardwareRevision {
        get {
            return this.hardwareRevisionField;
        }
        set {
            this.hardwareRevisionField = value;
        }
    }
    
    /// <remarks/>
    public string vendorName {
        get {
            return this.vendorNameField;
        }
        set {
            this.vendorNameField = value;
        }
    }
    
    /// <remarks/>
    public string vendorCode {
        get {
            return this.vendorCodeField;
        }
        set {
            this.vendorCodeField = value;
        }
    }
    
    /// <remarks/>
    public string brandName {
        get {
            return this.brandNameField;
        }
        set {
            this.brandNameField = value;
        }
    }
    
    /// <remarks/>
    public string powerSource {
        get {
            return this.powerSourceField;
        }
        set {
            this.powerSourceField = value;
        }
    }
    
    /// <remarks/>
    public string manufacturerNodeIdentification {
        get {
            return this.manufacturerNodeIdentificationField;
        }
        set {
            this.manufacturerNodeIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public string manufacturerLabel {
        get {
            return this.manufacturerLabelField;
        }
        set {
            this.manufacturerLabelField = value;
        }
    }
    
    /// <remarks/>
    public string manufacturerDescription {
        get {
            return this.manufacturerDescriptionField;
        }
        set {
            this.manufacturerDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceClassificationUserData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceClassificationUserDataType {
    
    private string userNodeIdentificationField;
    
    private string userLabelField;
    
    private string userDescriptionField;
    
    /// <remarks/>
    public string userNodeIdentification {
        get {
            return this.userNodeIdentificationField;
        }
        set {
            this.userNodeIdentificationField = value;
        }
    }
    
    /// <remarks/>
    public string userLabel {
        get {
            return this.userLabelField;
        }
        set {
            this.userLabelField = value;
        }
    }
    
    /// <remarks/>
    public string userDescription {
        get {
            return this.userDescriptionField;
        }
        set {
            this.userDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueConstraintsDataType {
    
    private uint keyIdField;
    
    private bool keyIdFieldSpecified;
    
    private DeviceConfigurationKeyValueValueType valueRangeMinField;
    
    private DeviceConfigurationKeyValueValueType valueRangeMaxField;
    
    private DeviceConfigurationKeyValueValueType valueStepSizeField;
    
    /// <remarks/>
    public uint keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool keyIdSpecified {
        get {
            return this.keyIdFieldSpecified;
        }
        set {
            this.keyIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueValueType valueRangeMin {
        get {
            return this.valueRangeMinField;
        }
        set {
            this.valueRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueValueType valueRangeMax {
        get {
            return this.valueRangeMaxField;
        }
        set {
            this.valueRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueValueType valueStepSize {
        get {
            return this.valueStepSizeField;
        }
        set {
            this.valueStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class DeviceConfigurationKeyValueValueType {
    
    private bool booleanField;
    
    private bool booleanFieldSpecified;
    
    private System.DateTime dateField;
    
    private bool dateFieldSpecified;
    
    private System.DateTime dateTimeField;
    
    private bool dateTimeFieldSpecified;
    
    private string durationField;
    
    private string stringField;
    
    private System.DateTime timeField;
    
    private bool timeFieldSpecified;
    
    private ScaledNumberType scaledNumberField;
    
    /// <remarks/>
    public bool boolean {
        get {
            return this.booleanField;
        }
        set {
            this.booleanField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool booleanSpecified {
        get {
            return this.booleanFieldSpecified;
        }
        set {
            this.booleanFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dateSpecified {
        get {
            return this.dateFieldSpecified;
        }
        set {
            this.dateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime dateTime {
        get {
            return this.dateTimeField;
        }
        set {
            this.dateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dateTimeSpecified {
        get {
            return this.dateTimeFieldSpecified;
        }
        set {
            this.dateTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string duration {
        get {
            return this.durationField;
        }
        set {
            this.durationField = value;
        }
    }
    
    /// <remarks/>
    public string @string {
        get {
            return this.stringField;
        }
        set {
            this.stringField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
    public System.DateTime time {
        get {
            return this.timeField;
        }
        set {
            this.timeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSpecified {
        get {
            return this.timeFieldSpecified;
        }
        set {
            this.timeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType scaledNumber {
        get {
            return this.scaledNumberField;
        }
        set {
            this.scaledNumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueDescriptionDataType {
    
    private uint keyIdField;
    
    private bool keyIdFieldSpecified;
    
    private string keyNameField;
    
    private DeviceConfigurationKeyValueTypeType valueTypeField;
    
    private bool valueTypeFieldSpecified;
    
    private string unitField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool keyIdSpecified {
        get {
            return this.keyIdFieldSpecified;
        }
        set {
            this.keyIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string keyName {
        get {
            return this.keyNameField;
        }
        set {
            this.keyNameField = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueTypeType valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool valueTypeSpecified {
        get {
            return this.valueTypeFieldSpecified;
        }
        set {
            this.valueTypeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public enum DeviceConfigurationKeyValueTypeType {
    
    /// <remarks/>
    boolean,
    
    /// <remarks/>
    date,
    
    /// <remarks/>
    dateTime,
    
    /// <remarks/>
    duration,
    
    /// <remarks/>
    @string,
    
    /// <remarks/>
    time,
    
    /// <remarks/>
    scaledNumber,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueDataType {
    
    private uint keyIdField;
    
    private bool keyIdFieldSpecified;
    
    private DeviceConfigurationKeyValueValueType valueField;
    
    private bool isValueChangeableField;
    
    private bool isValueChangeableFieldSpecified;
    
    /// <remarks/>
    public uint keyId {
        get {
            return this.keyIdField;
        }
        set {
            this.keyIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool keyIdSpecified {
        get {
            return this.keyIdFieldSpecified;
        }
        set {
            this.keyIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DeviceConfigurationKeyValueValueType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public bool isValueChangeable {
        get {
            return this.isValueChangeableField;
        }
        set {
            this.isValueChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isValueChangeableSpecified {
        get {
            return this.isValueChangeableFieldSpecified;
        }
        set {
            this.isValueChangeableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceDiagnosisHeartbeatData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceDiagnosisHeartbeatDataType {
    
    private string timestampField;
    
    private ulong heartbeatCounterField;
    
    private bool heartbeatCounterFieldSpecified;
    
    private string heartbeatTimeoutField;
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ulong heartbeatCounter {
        get {
            return this.heartbeatCounterField;
        }
        set {
            this.heartbeatCounterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool heartbeatCounterSpecified {
        get {
            return this.heartbeatCounterFieldSpecified;
        }
        set {
            this.heartbeatCounterFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string heartbeatTimeout {
        get {
            return this.heartbeatTimeoutField;
        }
        set {
            this.heartbeatTimeoutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceDiagnosisServiceData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceDiagnosisServiceDataType {
    
    private string timestampField;
    
    private string installationTimeField;
    
    private ulong bootCounterField;
    
    private bool bootCounterFieldSpecified;
    
    private string nextServiceField;
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string installationTime {
        get {
            return this.installationTimeField;
        }
        set {
            this.installationTimeField = value;
        }
    }
    
    /// <remarks/>
    public ulong bootCounter {
        get {
            return this.bootCounterField;
        }
        set {
            this.bootCounterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool bootCounterSpecified {
        get {
            return this.bootCounterFieldSpecified;
        }
        set {
            this.bootCounterFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string nextService {
        get {
            return this.nextServiceField;
        }
        set {
            this.nextServiceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceDiagnosisStateData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceDiagnosisStateDataType {
    
    private string timestampField;
    
    private string operatingStateField;
    
    private string vendorStateCodeField;
    
    private string lastErrorCodeField;
    
    private string upTimeField;
    
    private string totalUpTimeField;
    
    private string powerSupplyConditionField;
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string operatingState {
        get {
            return this.operatingStateField;
        }
        set {
            this.operatingStateField = value;
        }
    }
    
    /// <remarks/>
    public string vendorStateCode {
        get {
            return this.vendorStateCodeField;
        }
        set {
            this.vendorStateCodeField = value;
        }
    }
    
    /// <remarks/>
    public string lastErrorCode {
        get {
            return this.lastErrorCodeField;
        }
        set {
            this.lastErrorCodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string upTime {
        get {
            return this.upTimeField;
        }
        set {
            this.upTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string totalUpTime {
        get {
            return this.totalUpTimeField;
        }
        set {
            this.totalUpTimeField = value;
        }
    }
    
    /// <remarks/>
    public string powerSupplyCondition {
        get {
            return this.powerSupplyConditionField;
        }
        set {
            this.powerSupplyConditionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("directControlActivityData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DirectControlActivityDataType {
    
    private string timestampField;
    
    private string activityStateField;
    
    private bool isActivityStateChangeableField;
    
    private bool isActivityStateChangeableFieldSpecified;
    
    private string energyModeField;
    
    private bool isEnergyModeChangeableField;
    
    private bool isEnergyModeChangeableFieldSpecified;
    
    private ScaledNumberType powerField;
    
    private bool isPowerChangeableField;
    
    private bool isPowerChangeableFieldSpecified;
    
    private ScaledNumberType energyField;
    
    private bool isEnergyChangeableField;
    
    private bool isEnergyChangeableFieldSpecified;
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string activityState {
        get {
            return this.activityStateField;
        }
        set {
            this.activityStateField = value;
        }
    }
    
    /// <remarks/>
    public bool isActivityStateChangeable {
        get {
            return this.isActivityStateChangeableField;
        }
        set {
            this.isActivityStateChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isActivityStateChangeableSpecified {
        get {
            return this.isActivityStateChangeableFieldSpecified;
        }
        set {
            this.isActivityStateChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string energyMode {
        get {
            return this.energyModeField;
        }
        set {
            this.energyModeField = value;
        }
    }
    
    /// <remarks/>
    public bool isEnergyModeChangeable {
        get {
            return this.isEnergyModeChangeableField;
        }
        set {
            this.isEnergyModeChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isEnergyModeChangeableSpecified {
        get {
            return this.isEnergyModeChangeableFieldSpecified;
        }
        set {
            this.isEnergyModeChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType power {
        get {
            return this.powerField;
        }
        set {
            this.powerField = value;
        }
    }
    
    /// <remarks/>
    public bool isPowerChangeable {
        get {
            return this.isPowerChangeableField;
        }
        set {
            this.isPowerChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isPowerChangeableSpecified {
        get {
            return this.isPowerChangeableFieldSpecified;
        }
        set {
            this.isPowerChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType energy {
        get {
            return this.energyField;
        }
        set {
            this.energyField = value;
        }
    }
    
    /// <remarks/>
    public bool isEnergyChangeable {
        get {
            return this.isEnergyChangeableField;
        }
        set {
            this.isEnergyChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isEnergyChangeableSpecified {
        get {
            return this.isEnergyChangeableFieldSpecified;
        }
        set {
            this.isEnergyChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("directControlDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DirectControlDescriptionDataType {
    
    private string positiveEnergyDirectionField;
    
    private string powerUnitField;
    
    private string energyUnitField;
    
    /// <remarks/>
    public string positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public string powerUnit {
        get {
            return this.powerUnitField;
        }
        set {
            this.powerUnitField = value;
        }
    }
    
    /// <remarks/>
    public string energyUnit {
        get {
            return this.energyUnitField;
        }
        set {
            this.energyUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionDescriptionDataType {
    
    private uint electricalConnectionIdField;
    
    private bool electricalConnectionIdFieldSpecified;
    
    private string powerSupplyTypeField;
    
    private uint acConnectedPhasesField;
    
    private bool acConnectedPhasesFieldSpecified;
    
    private string acRmsPeriodDurationField;
    
    private string positiveEnergyDirectionField;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool electricalConnectionIdSpecified {
        get {
            return this.electricalConnectionIdFieldSpecified;
        }
        set {
            this.electricalConnectionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string powerSupplyType {
        get {
            return this.powerSupplyTypeField;
        }
        set {
            this.powerSupplyTypeField = value;
        }
    }
    
    /// <remarks/>
    public uint acConnectedPhases {
        get {
            return this.acConnectedPhasesField;
        }
        set {
            this.acConnectedPhasesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool acConnectedPhasesSpecified {
        get {
            return this.acConnectedPhasesFieldSpecified;
        }
        set {
            this.acConnectedPhasesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string acRmsPeriodDuration {
        get {
            return this.acRmsPeriodDurationField;
        }
        set {
            this.acRmsPeriodDurationField = value;
        }
    }
    
    /// <remarks/>
    public string positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionParameterDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionParameterDescriptionDataType {
    
    private uint electricalConnectionIdField;
    
    private bool electricalConnectionIdFieldSpecified;
    
    private uint parameterIdField;
    
    private bool parameterIdFieldSpecified;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string voltageTypeField;
    
    private string acMeasuredPhasesField;
    
    private string acMeasuredInReferenceToField;
    
    private string acMeasurementTypeField;
    
    private string acMeasurementVariantField;
    
    private byte acMeasuredHarmonicField;
    
    private bool acMeasuredHarmonicFieldSpecified;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool electricalConnectionIdSpecified {
        get {
            return this.electricalConnectionIdFieldSpecified;
        }
        set {
            this.electricalConnectionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint parameterId {
        get {
            return this.parameterIdField;
        }
        set {
            this.parameterIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool parameterIdSpecified {
        get {
            return this.parameterIdFieldSpecified;
        }
        set {
            this.parameterIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string voltageType {
        get {
            return this.voltageTypeField;
        }
        set {
            this.voltageTypeField = value;
        }
    }
    
    /// <remarks/>
    public string acMeasuredPhases {
        get {
            return this.acMeasuredPhasesField;
        }
        set {
            this.acMeasuredPhasesField = value;
        }
    }
    
    /// <remarks/>
    public string acMeasuredInReferenceTo {
        get {
            return this.acMeasuredInReferenceToField;
        }
        set {
            this.acMeasuredInReferenceToField = value;
        }
    }
    
    /// <remarks/>
    public string acMeasurementType {
        get {
            return this.acMeasurementTypeField;
        }
        set {
            this.acMeasurementTypeField = value;
        }
    }
    
    /// <remarks/>
    public string acMeasurementVariant {
        get {
            return this.acMeasurementVariantField;
        }
        set {
            this.acMeasurementVariantField = value;
        }
    }
    
    /// <remarks/>
    public byte acMeasuredHarmonic {
        get {
            return this.acMeasuredHarmonicField;
        }
        set {
            this.acMeasuredHarmonicField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool acMeasuredHarmonicSpecified {
        get {
            return this.acMeasuredHarmonicFieldSpecified;
        }
        set {
            this.acMeasuredHarmonicFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionPermittedValueSetData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionPermittedValueSetDataType {
    
    private uint electricalConnectionIdField;
    
    private bool electricalConnectionIdFieldSpecified;
    
    private uint parameterIdField;
    
    private bool parameterIdFieldSpecified;
    
    private ScaledNumberSetType[] permittedValueSetField;
    
    /// <remarks/>
    public uint electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool electricalConnectionIdSpecified {
        get {
            return this.electricalConnectionIdFieldSpecified;
        }
        set {
            this.electricalConnectionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint parameterId {
        get {
            return this.parameterIdField;
        }
        set {
            this.parameterIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool parameterIdSpecified {
        get {
            return this.parameterIdFieldSpecified;
        }
        set {
            this.parameterIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("permittedValueSet")]
    public ScaledNumberSetType[] permittedValueSet {
        get {
            return this.permittedValueSetField;
        }
        set {
            this.permittedValueSetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class ScaledNumberSetType {
    
    private ScaledNumberType[] valueField;
    
    private ScaledNumberRangeType[] rangeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public ScaledNumberType[] value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("range")]
    public ScaledNumberRangeType[] range {
        get {
            return this.rangeField;
        }
        set {
            this.rangeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class ScaledNumberRangeType {
    
    private ScaledNumberType minField;
    
    private ScaledNumberType maxField;
    
    /// <remarks/>
    public ScaledNumberType min {
        get {
            return this.minField;
        }
        set {
            this.minField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionStateData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionStateDataType {
    
    private uint electricalConnectionIdField;
    
    private bool electricalConnectionIdFieldSpecified;
    
    private string timestampField;
    
    private string currentEnergyModeField;
    
    private string consumptionTimeField;
    
    private string productionTimeField;
    
    private string totalConsumptionTimeField;
    
    private string totalProductionTimeField;
    
    /// <remarks/>
    public uint electricalConnectionId {
        get {
            return this.electricalConnectionIdField;
        }
        set {
            this.electricalConnectionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool electricalConnectionIdSpecified {
        get {
            return this.electricalConnectionIdFieldSpecified;
        }
        set {
            this.electricalConnectionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string currentEnergyMode {
        get {
            return this.currentEnergyModeField;
        }
        set {
            this.currentEnergyModeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string consumptionTime {
        get {
            return this.consumptionTimeField;
        }
        set {
            this.consumptionTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string productionTime {
        get {
            return this.productionTimeField;
        }
        set {
            this.productionTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string totalConsumptionTime {
        get {
            return this.totalConsumptionTimeField;
        }
        set {
            this.totalConsumptionTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string totalProductionTime {
        get {
            return this.totalProductionTimeField;
        }
        set {
            this.totalProductionTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOperationModeDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOperationModeDescriptionDataType {
    
    private uint operationModeIdField;
    
    private bool operationModeIdFieldSpecified;
    
    private string operationModeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint operationModeId {
        get {
            return this.operationModeIdField;
        }
        set {
            this.operationModeIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool operationModeIdSpecified {
        get {
            return this.operationModeIdFieldSpecified;
        }
        set {
            this.operationModeIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string operationModeType {
        get {
            return this.operationModeTypeField;
        }
        set {
            this.operationModeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOverrunDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOverrunDescriptionDataType {
    
    private uint overrunIdField;
    
    private bool overrunIdFieldSpecified;
    
    private string overrunTypeField;
    
    private uint[] affectedSystemFunctionIdField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint overrunId {
        get {
            return this.overrunIdField;
        }
        set {
            this.overrunIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool overrunIdSpecified {
        get {
            return this.overrunIdFieldSpecified;
        }
        set {
            this.overrunIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string overrunType {
        get {
            return this.overrunTypeField;
        }
        set {
            this.overrunTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("affectedSystemFunctionId")]
    public uint[] affectedSystemFunctionId {
        get {
            return this.affectedSystemFunctionIdField;
        }
        set {
            this.affectedSystemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOverrunData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOverrunDataType {
    
    private uint overrunIdField;
    
    private bool overrunIdFieldSpecified;
    
    private string overrunStatusField;
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private bool isOverrunStatusChangeableField;
    
    private bool isOverrunStatusChangeableFieldSpecified;
    
    /// <remarks/>
    public uint overrunId {
        get {
            return this.overrunIdField;
        }
        set {
            this.overrunIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool overrunIdSpecified {
        get {
            return this.overrunIdFieldSpecified;
        }
        set {
            this.overrunIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string overrunStatus {
        get {
            return this.overrunStatusField;
        }
        set {
            this.overrunStatusField = value;
        }
    }
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool isOverrunStatusChangeable {
        get {
            return this.isOverrunStatusChangeableField;
        }
        set {
            this.isOverrunStatusChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isOverrunStatusChangeableSpecified {
        get {
            return this.isOverrunStatusChangeableFieldSpecified;
        }
        set {
            this.isOverrunStatusChangeableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionDescriptionDataType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    private string systemFunctionTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string systemFunctionType {
        get {
            return this.systemFunctionTypeField;
        }
        set {
            this.systemFunctionTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionDataType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    private uint currentOperationModeIdField;
    
    private bool currentOperationModeIdFieldSpecified;
    
    private bool isOperationModeIdChangeableField;
    
    private bool isOperationModeIdChangeableFieldSpecified;
    
    private uint currentSetpointIdField;
    
    private bool currentSetpointIdFieldSpecified;
    
    private bool isSetpointIdChangeableField;
    
    private bool isSetpointIdChangeableFieldSpecified;
    
    private bool isOverrunActiveField;
    
    private bool isOverrunActiveFieldSpecified;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint currentOperationModeId {
        get {
            return this.currentOperationModeIdField;
        }
        set {
            this.currentOperationModeIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool currentOperationModeIdSpecified {
        get {
            return this.currentOperationModeIdFieldSpecified;
        }
        set {
            this.currentOperationModeIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool isOperationModeIdChangeable {
        get {
            return this.isOperationModeIdChangeableField;
        }
        set {
            this.isOperationModeIdChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isOperationModeIdChangeableSpecified {
        get {
            return this.isOperationModeIdChangeableFieldSpecified;
        }
        set {
            this.isOperationModeIdChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint currentSetpointId {
        get {
            return this.currentSetpointIdField;
        }
        set {
            this.currentSetpointIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool currentSetpointIdSpecified {
        get {
            return this.currentSetpointIdFieldSpecified;
        }
        set {
            this.currentSetpointIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool isSetpointIdChangeable {
        get {
            return this.isSetpointIdChangeableField;
        }
        set {
            this.isSetpointIdChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isSetpointIdChangeableSpecified {
        get {
            return this.isSetpointIdChangeableFieldSpecified;
        }
        set {
            this.isSetpointIdChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool isOverrunActive {
        get {
            return this.isOverrunActiveField;
        }
        set {
            this.isOverrunActiveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isOverrunActiveSpecified {
        get {
            return this.isOverrunActiveFieldSpecified;
        }
        set {
            this.isOverrunActiveFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionOperationModeRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionOperationModeRelationDataType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    private uint[] operationModeIdField;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operationModeId")]
    public uint[] operationModeId {
        get {
            return this.operationModeIdField;
        }
        set {
            this.operationModeIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionPowerSequenceRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionPowerSequenceRelationDataType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    private uint[] sequenceIdField;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sequenceId")]
    public uint[] sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionSetpointRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionSetpointRelationDataType {
    
    private uint systemFunctionIdField;
    
    private bool systemFunctionIdFieldSpecified;
    
    private uint operationModeIdField;
    
    private bool operationModeIdFieldSpecified;
    
    private uint[] setpointIdField;
    
    /// <remarks/>
    public uint systemFunctionId {
        get {
            return this.systemFunctionIdField;
        }
        set {
            this.systemFunctionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool systemFunctionIdSpecified {
        get {
            return this.systemFunctionIdFieldSpecified;
        }
        set {
            this.systemFunctionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint operationModeId {
        get {
            return this.operationModeIdField;
        }
        set {
            this.operationModeIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool operationModeIdSpecified {
        get {
            return this.operationModeIdFieldSpecified;
        }
        set {
            this.operationModeIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("setpointId")]
    public uint[] setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("identificationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IdentificationDataType {
    
    private uint identificationIdField;
    
    private bool identificationIdFieldSpecified;
    
    private string identificationTypeField;
    
    private string identificationValueField;
    
    private bool authorizedField;
    
    private bool authorizedFieldSpecified;
    
    /// <remarks/>
    public uint identificationId {
        get {
            return this.identificationIdField;
        }
        set {
            this.identificationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool identificationIdSpecified {
        get {
            return this.identificationIdFieldSpecified;
        }
        set {
            this.identificationIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string identificationType {
        get {
            return this.identificationTypeField;
        }
        set {
            this.identificationTypeField = value;
        }
    }
    
    /// <remarks/>
    public string identificationValue {
        get {
            return this.identificationValueField;
        }
        set {
            this.identificationValueField = value;
        }
    }
    
    /// <remarks/>
    public bool authorized {
        get {
            return this.authorizedField;
        }
        set {
            this.authorizedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool authorizedSpecified {
        get {
            return this.authorizedFieldSpecified;
        }
        set {
            this.authorizedFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveDescriptionDataType {
    
    private uint incentiveIdField;
    
    private bool incentiveIdFieldSpecified;
    
    private string incentiveTypeField;
    
    private uint incentivePriorityField;
    
    private bool incentivePriorityFieldSpecified;
    
    private string currencyField;
    
    private string unitField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool incentiveIdSpecified {
        get {
            return this.incentiveIdFieldSpecified;
        }
        set {
            this.incentiveIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string incentiveType {
        get {
            return this.incentiveTypeField;
        }
        set {
            this.incentiveTypeField = value;
        }
    }
    
    /// <remarks/>
    public uint incentivePriority {
        get {
            return this.incentivePriorityField;
        }
        set {
            this.incentivePriorityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool incentivePrioritySpecified {
        get {
            return this.incentivePriorityFieldSpecified;
        }
        set {
            this.incentivePriorityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveDataType {
    
    private uint incentiveIdField;
    
    private bool incentiveIdFieldSpecified;
    
    private string valueTypeField;
    
    private string timestampField;
    
    private TimePeriodType timePeriodField;
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private ScaledNumberType valueField;
    
    /// <remarks/>
    public uint incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool incentiveIdSpecified {
        get {
            return this.incentiveIdFieldSpecified;
        }
        set {
            this.incentiveIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsType {
    
    private IncentiveTableConstraintsTypeTariff tariffField;
    
    private IncentiveTableConstraintsTypeTariffConstraints tariffConstraintsField;
    
    private IncentiveTableConstraintsTypeIncentiveSlotConstraints incentiveSlotConstraintsField;
    
    /// <remarks/>
    public IncentiveTableConstraintsTypeTariff tariff {
        get {
            return this.tariffField;
        }
        set {
            this.tariffField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableConstraintsTypeTariffConstraints tariffConstraints {
        get {
            return this.tariffConstraintsField;
        }
        set {
            this.tariffConstraintsField = value;
        }
    }
    
    /// <remarks/>
    public IncentiveTableConstraintsTypeIncentiveSlotConstraints incentiveSlotConstraints {
        get {
            return this.incentiveSlotConstraintsField;
        }
        set {
            this.incentiveSlotConstraintsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsTypeTariff : TariffDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffDataType {
    
    private uint tariffIdField;
    
    private bool tariffIdFieldSpecified;
    
    private uint[] activeTierIdField;
    
    /// <remarks/>
    public uint tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffIdSpecified {
        get {
            return this.tariffIdFieldSpecified;
        }
        set {
            this.tariffIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("activeTierId")]
    public uint[] activeTierId {
        get {
            return this.activeTierIdField;
        }
        set {
            this.activeTierIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsTypeTariffConstraints : TariffOverallConstraintsDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffOverallConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffOverallConstraintsDataType {
    
    private uint maxTariffCountField;
    
    private bool maxTariffCountFieldSpecified;
    
    private uint maxBoundaryCountField;
    
    private bool maxBoundaryCountFieldSpecified;
    
    private uint maxTierCountField;
    
    private bool maxTierCountFieldSpecified;
    
    private uint maxIncentiveCountField;
    
    private bool maxIncentiveCountFieldSpecified;
    
    private uint maxBoundariesPerTariffField;
    
    private bool maxBoundariesPerTariffFieldSpecified;
    
    private uint maxTiersPerTariffField;
    
    private bool maxTiersPerTariffFieldSpecified;
    
    private uint maxBoundariesPerTierField;
    
    private bool maxBoundariesPerTierFieldSpecified;
    
    private uint maxIncentivesPerTierField;
    
    private bool maxIncentivesPerTierFieldSpecified;
    
    /// <remarks/>
    public uint maxTariffCount {
        get {
            return this.maxTariffCountField;
        }
        set {
            this.maxTariffCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxTariffCountSpecified {
        get {
            return this.maxTariffCountFieldSpecified;
        }
        set {
            this.maxTariffCountFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint maxBoundaryCount {
        get {
            return this.maxBoundaryCountField;
        }
        set {
            this.maxBoundaryCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxBoundaryCountSpecified {
        get {
            return this.maxBoundaryCountFieldSpecified;
        }
        set {
            this.maxBoundaryCountFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint maxTierCount {
        get {
            return this.maxTierCountField;
        }
        set {
            this.maxTierCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxTierCountSpecified {
        get {
            return this.maxTierCountFieldSpecified;
        }
        set {
            this.maxTierCountFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint maxIncentiveCount {
        get {
            return this.maxIncentiveCountField;
        }
        set {
            this.maxIncentiveCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxIncentiveCountSpecified {
        get {
            return this.maxIncentiveCountFieldSpecified;
        }
        set {
            this.maxIncentiveCountFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint maxBoundariesPerTariff {
        get {
            return this.maxBoundariesPerTariffField;
        }
        set {
            this.maxBoundariesPerTariffField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxBoundariesPerTariffSpecified {
        get {
            return this.maxBoundariesPerTariffFieldSpecified;
        }
        set {
            this.maxBoundariesPerTariffFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint maxTiersPerTariff {
        get {
            return this.maxTiersPerTariffField;
        }
        set {
            this.maxTiersPerTariffField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxTiersPerTariffSpecified {
        get {
            return this.maxTiersPerTariffFieldSpecified;
        }
        set {
            this.maxTiersPerTariffFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint maxBoundariesPerTier {
        get {
            return this.maxBoundariesPerTierField;
        }
        set {
            this.maxBoundariesPerTierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxBoundariesPerTierSpecified {
        get {
            return this.maxBoundariesPerTierFieldSpecified;
        }
        set {
            this.maxBoundariesPerTierFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint maxIncentivesPerTier {
        get {
            return this.maxIncentivesPerTierField;
        }
        set {
            this.maxIncentivesPerTierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxIncentivesPerTierSpecified {
        get {
            return this.maxIncentivesPerTierFieldSpecified;
        }
        set {
            this.maxIncentivesPerTierFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableConstraintsTypeIncentiveSlotConstraints : TimeTableConstraintsDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableConstraintsDataType {
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private uint slotCountMinField;
    
    private bool slotCountMinFieldSpecified;
    
    private uint slotCountMaxField;
    
    private bool slotCountMaxFieldSpecified;
    
    private string slotDurationMinField;
    
    private string slotDurationMaxField;
    
    private string slotDurationStepSizeField;
    
    private string slotShiftStepSizeField;
    
    private System.DateTime firstSlotBeginsAtField;
    
    private bool firstSlotBeginsAtFieldSpecified;
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotCountMin {
        get {
            return this.slotCountMinField;
        }
        set {
            this.slotCountMinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotCountMinSpecified {
        get {
            return this.slotCountMinFieldSpecified;
        }
        set {
            this.slotCountMinFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotCountMax {
        get {
            return this.slotCountMaxField;
        }
        set {
            this.slotCountMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotCountMaxSpecified {
        get {
            return this.slotCountMaxFieldSpecified;
        }
        set {
            this.slotCountMaxFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string slotDurationMin {
        get {
            return this.slotDurationMinField;
        }
        set {
            this.slotDurationMinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string slotDurationMax {
        get {
            return this.slotDurationMaxField;
        }
        set {
            this.slotDurationMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string slotDurationStepSize {
        get {
            return this.slotDurationStepSizeField;
        }
        set {
            this.slotDurationStepSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string slotShiftStepSize {
        get {
            return this.slotShiftStepSizeField;
        }
        set {
            this.slotShiftStepSizeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
    public System.DateTime firstSlotBeginsAt {
        get {
            return this.firstSlotBeginsAtField;
        }
        set {
            this.firstSlotBeginsAtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool firstSlotBeginsAtSpecified {
        get {
            return this.firstSlotBeginsAtFieldSpecified;
        }
        set {
            this.firstSlotBeginsAtFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableType {
    
    private IncentiveTableTypeTariff tariffField;
    
    private IncentiveTableIncentiveSlotType[] incentiveSlotField;
    
    /// <remarks/>
    public IncentiveTableTypeTariff tariff {
        get {
            return this.tariffField;
        }
        set {
            this.tariffField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentiveSlot")]
    public IncentiveTableIncentiveSlotType[] incentiveSlot {
        get {
            return this.incentiveSlotField;
        }
        set {
            this.incentiveSlotField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTypeTariff : TariffDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableIncentiveSlotType {
    
    private IncentiveTableIncentiveSlotTypeTimeInterval timeIntervalField;
    
    private IncentiveTableTierType[] tierField;
    
    /// <remarks/>
    public IncentiveTableIncentiveSlotTypeTimeInterval timeInterval {
        get {
            return this.timeIntervalField;
        }
        set {
            this.timeIntervalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tier")]
    public IncentiveTableTierType[] tier {
        get {
            return this.tierField;
        }
        set {
            this.tierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableIncentiveSlotTypeTimeInterval : TimeTableDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableDataType {
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private uint timeSlotIdField;
    
    private bool timeSlotIdFieldSpecified;
    
    private RecurrenceInformationType recurrenceInformationField;
    
    private AbsoluteOrRecurringTimeType startTimeField;
    
    private AbsoluteOrRecurringTimeType endTimeField;
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint timeSlotId {
        get {
            return this.timeSlotIdField;
        }
        set {
            this.timeSlotIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSlotIdSpecified {
        get {
            return this.timeSlotIdFieldSpecified;
        }
        set {
            this.timeSlotIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public RecurrenceInformationType recurrenceInformation {
        get {
            return this.recurrenceInformationField;
        }
        set {
            this.recurrenceInformationField = value;
        }
    }
    
    /// <remarks/>
    public AbsoluteOrRecurringTimeType startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    public AbsoluteOrRecurringTimeType endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class RecurrenceInformationType {
    
    private string recurringIntervalField;
    
    private uint recurringIntervalStepField;
    
    private bool recurringIntervalStepFieldSpecified;
    
    private System.DateTime firstExecutionField;
    
    private bool firstExecutionFieldSpecified;
    
    private uint executionCountField;
    
    private bool executionCountFieldSpecified;
    
    private System.DateTime lastExecutionField;
    
    private bool lastExecutionFieldSpecified;
    
    /// <remarks/>
    public string recurringInterval {
        get {
            return this.recurringIntervalField;
        }
        set {
            this.recurringIntervalField = value;
        }
    }
    
    /// <remarks/>
    public uint recurringIntervalStep {
        get {
            return this.recurringIntervalStepField;
        }
        set {
            this.recurringIntervalStepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool recurringIntervalStepSpecified {
        get {
            return this.recurringIntervalStepFieldSpecified;
        }
        set {
            this.recurringIntervalStepFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime firstExecution {
        get {
            return this.firstExecutionField;
        }
        set {
            this.firstExecutionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool firstExecutionSpecified {
        get {
            return this.firstExecutionFieldSpecified;
        }
        set {
            this.firstExecutionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint executionCount {
        get {
            return this.executionCountField;
        }
        set {
            this.executionCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool executionCountSpecified {
        get {
            return this.executionCountFieldSpecified;
        }
        set {
            this.executionCountFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime lastExecution {
        get {
            return this.lastExecutionField;
        }
        set {
            this.lastExecutionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lastExecutionSpecified {
        get {
            return this.lastExecutionFieldSpecified;
        }
        set {
            this.lastExecutionFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class AbsoluteOrRecurringTimeType {
    
    private System.DateTime dateTimeField;
    
    private bool dateTimeFieldSpecified;
    
    private MonthType monthField;
    
    private bool monthFieldSpecified;
    
    private byte dayOfMonthField;
    
    private bool dayOfMonthFieldSpecified;
    
    private byte calendarWeekField;
    
    private bool calendarWeekFieldSpecified;
    
    private string dayOfWeekOccurrenceField;
    
    private DaysOfWeekType daysOfWeekField;
    
    private System.DateTime timeField;
    
    private bool timeFieldSpecified;
    
    private string relativeField;
    
    /// <remarks/>
    public System.DateTime dateTime {
        get {
            return this.dateTimeField;
        }
        set {
            this.dateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dateTimeSpecified {
        get {
            return this.dateTimeFieldSpecified;
        }
        set {
            this.dateTimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public MonthType month {
        get {
            return this.monthField;
        }
        set {
            this.monthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool monthSpecified {
        get {
            return this.monthFieldSpecified;
        }
        set {
            this.monthFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public byte dayOfMonth {
        get {
            return this.dayOfMonthField;
        }
        set {
            this.dayOfMonthField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dayOfMonthSpecified {
        get {
            return this.dayOfMonthFieldSpecified;
        }
        set {
            this.dayOfMonthFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public byte calendarWeek {
        get {
            return this.calendarWeekField;
        }
        set {
            this.calendarWeekField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool calendarWeekSpecified {
        get {
            return this.calendarWeekFieldSpecified;
        }
        set {
            this.calendarWeekFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string dayOfWeekOccurrence {
        get {
            return this.dayOfWeekOccurrenceField;
        }
        set {
            this.dayOfWeekOccurrenceField = value;
        }
    }
    
    /// <remarks/>
    public DaysOfWeekType daysOfWeek {
        get {
            return this.daysOfWeekField;
        }
        set {
            this.daysOfWeekField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
    public System.DateTime time {
        get {
            return this.timeField;
        }
        set {
            this.timeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSpecified {
        get {
            return this.timeFieldSpecified;
        }
        set {
            this.timeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string relative {
        get {
            return this.relativeField;
        }
        set {
            this.relativeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public enum MonthType {
    
    /// <remarks/>
    january,
    
    /// <remarks/>
    february,
    
    /// <remarks/>
    march,
    
    /// <remarks/>
    april,
    
    /// <remarks/>
    may,
    
    /// <remarks/>
    june,
    
    /// <remarks/>
    july,
    
    /// <remarks/>
    august,
    
    /// <remarks/>
    september,
    
    /// <remarks/>
    october,
    
    /// <remarks/>
    november,
    
    /// <remarks/>
    december,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class DaysOfWeekType {
    
    private ElementTagType mondayField;
    
    private ElementTagType tuesdayField;
    
    private ElementTagType wednesdayField;
    
    private ElementTagType thursdayField;
    
    private ElementTagType fridayField;
    
    private ElementTagType saturdayField;
    
    private ElementTagType sundayField;
    
    /// <remarks/>
    public ElementTagType monday {
        get {
            return this.mondayField;
        }
        set {
            this.mondayField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType tuesday {
        get {
            return this.tuesdayField;
        }
        set {
            this.tuesdayField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType wednesday {
        get {
            return this.wednesdayField;
        }
        set {
            this.wednesdayField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType thursday {
        get {
            return this.thursdayField;
        }
        set {
            this.thursdayField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType friday {
        get {
            return this.fridayField;
        }
        set {
            this.fridayField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType saturday {
        get {
            return this.saturdayField;
        }
        set {
            this.saturdayField = value;
        }
    }
    
    /// <remarks/>
    public ElementTagType sunday {
        get {
            return this.sundayField;
        }
        set {
            this.sundayField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTierType {
    
    private IncentiveTableTierTypeTier tierField;
    
    private IncentiveTableTierTypeBoundary[] boundaryField;
    
    private IncentiveTableTierTypeIncentive[] incentiveField;
    
    /// <remarks/>
    public IncentiveTableTierTypeTier tier {
        get {
            return this.tierField;
        }
        set {
            this.tierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boundary")]
    public IncentiveTableTierTypeBoundary[] boundary {
        get {
            return this.boundaryField;
        }
        set {
            this.boundaryField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentive")]
    public IncentiveTableTierTypeIncentive[] incentive {
        get {
            return this.incentiveField;
        }
        set {
            this.incentiveField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTierTypeTier : TierDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierDataType {
    
    private uint tierIdField;
    
    private bool tierIdFieldSpecified;
    
    private TimePeriodType timePeriodField;
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private uint[] activeIncentiveIdField;
    
    /// <remarks/>
    public uint tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tierIdSpecified {
        get {
            return this.tierIdFieldSpecified;
        }
        set {
            this.tierIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("activeIncentiveId")]
    public uint[] activeIncentiveId {
        get {
            return this.activeIncentiveIdField;
        }
        set {
            this.activeIncentiveIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTierTypeBoundary : TierBoundaryDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierBoundaryData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierBoundaryDataType {
    
    private uint boundaryIdField;
    
    private bool boundaryIdFieldSpecified;
    
    private TimePeriodType timePeriodField;
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private ScaledNumberType lowerBoundaryValueField;
    
    private ScaledNumberType upperBoundaryValueField;
    
    /// <remarks/>
    public uint boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool boundaryIdSpecified {
        get {
            return this.boundaryIdFieldSpecified;
        }
        set {
            this.boundaryIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType lowerBoundaryValue {
        get {
            return this.lowerBoundaryValueField;
        }
        set {
            this.lowerBoundaryValueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType upperBoundaryValue {
        get {
            return this.upperBoundaryValueField;
        }
        set {
            this.upperBoundaryValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableTierTypeIncentive : IncentiveDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionType {
    
    private IncentiveTableDescriptionTypeTariffDescription tariffDescriptionField;
    
    private IncentiveTableDescriptionTierType[] tierField;
    
    /// <remarks/>
    public IncentiveTableDescriptionTypeTariffDescription tariffDescription {
        get {
            return this.tariffDescriptionField;
        }
        set {
            this.tariffDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tier")]
    public IncentiveTableDescriptionTierType[] tier {
        get {
            return this.tierField;
        }
        set {
            this.tierField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTypeTariffDescription : TariffDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffDescriptionDataType {
    
    private uint tariffIdField;
    
    private bool tariffIdFieldSpecified;
    
    private uint commodityIdField;
    
    private bool commodityIdFieldSpecified;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private bool tariffWriteableField;
    
    private bool tariffWriteableFieldSpecified;
    
    private bool updateRequiredField;
    
    private bool updateRequiredFieldSpecified;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    private bool slotIdSupportField;
    
    private bool slotIdSupportFieldSpecified;
    
    /// <remarks/>
    public uint tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffIdSpecified {
        get {
            return this.tariffIdFieldSpecified;
        }
        set {
            this.tariffIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint commodityId {
        get {
            return this.commodityIdField;
        }
        set {
            this.commodityIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool commodityIdSpecified {
        get {
            return this.commodityIdFieldSpecified;
        }
        set {
            this.commodityIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool tariffWriteable {
        get {
            return this.tariffWriteableField;
        }
        set {
            this.tariffWriteableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffWriteableSpecified {
        get {
            return this.tariffWriteableFieldSpecified;
        }
        set {
            this.tariffWriteableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool updateRequired {
        get {
            return this.updateRequiredField;
        }
        set {
            this.updateRequiredField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool updateRequiredSpecified {
        get {
            return this.updateRequiredFieldSpecified;
        }
        set {
            this.updateRequiredFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public bool slotIdSupport {
        get {
            return this.slotIdSupportField;
        }
        set {
            this.slotIdSupportField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotIdSupportSpecified {
        get {
            return this.slotIdSupportFieldSpecified;
        }
        set {
            this.slotIdSupportFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTierType {
    
    private IncentiveTableDescriptionTierTypeTierDescription tierDescriptionField;
    
    private IncentiveTableDescriptionTierTypeBoundaryDescription[] boundaryDescriptionField;
    
    private IncentiveTableDescriptionTierTypeIncentiveDescription[] incentiveDescriptionField;
    
    /// <remarks/>
    public IncentiveTableDescriptionTierTypeTierDescription tierDescription {
        get {
            return this.tierDescriptionField;
        }
        set {
            this.tierDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boundaryDescription")]
    public IncentiveTableDescriptionTierTypeBoundaryDescription[] boundaryDescription {
        get {
            return this.boundaryDescriptionField;
        }
        set {
            this.boundaryDescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentiveDescription")]
    public IncentiveTableDescriptionTierTypeIncentiveDescription[] incentiveDescription {
        get {
            return this.incentiveDescriptionField;
        }
        set {
            this.incentiveDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTierTypeTierDescription : TierDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierDescriptionDataType {
    
    private uint tierIdField;
    
    private bool tierIdFieldSpecified;
    
    private string tierTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tierIdSpecified {
        get {
            return this.tierIdFieldSpecified;
        }
        set {
            this.tierIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string tierType {
        get {
            return this.tierTypeField;
        }
        set {
            this.tierTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTierTypeBoundaryDescription : TierBoundaryDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierBoundaryDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierBoundaryDescriptionDataType {
    
    private uint boundaryIdField;
    
    private bool boundaryIdFieldSpecified;
    
    private string boundaryTypeField;
    
    private uint validForTierIdField;
    
    private bool validForTierIdFieldSpecified;
    
    private uint switchToTierIdWhenLowerField;
    
    private bool switchToTierIdWhenLowerFieldSpecified;
    
    private uint switchToTierIdWhenHigherField;
    
    private bool switchToTierIdWhenHigherFieldSpecified;
    
    private string boundaryUnitField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool boundaryIdSpecified {
        get {
            return this.boundaryIdFieldSpecified;
        }
        set {
            this.boundaryIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string boundaryType {
        get {
            return this.boundaryTypeField;
        }
        set {
            this.boundaryTypeField = value;
        }
    }
    
    /// <remarks/>
    public uint validForTierId {
        get {
            return this.validForTierIdField;
        }
        set {
            this.validForTierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool validForTierIdSpecified {
        get {
            return this.validForTierIdFieldSpecified;
        }
        set {
            this.validForTierIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint switchToTierIdWhenLower {
        get {
            return this.switchToTierIdWhenLowerField;
        }
        set {
            this.switchToTierIdWhenLowerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool switchToTierIdWhenLowerSpecified {
        get {
            return this.switchToTierIdWhenLowerFieldSpecified;
        }
        set {
            this.switchToTierIdWhenLowerFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint switchToTierIdWhenHigher {
        get {
            return this.switchToTierIdWhenHigherField;
        }
        set {
            this.switchToTierIdWhenHigherField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool switchToTierIdWhenHigherSpecified {
        get {
            return this.switchToTierIdWhenHigherFieldSpecified;
        }
        set {
            this.switchToTierIdWhenHigherFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string boundaryUnit {
        get {
            return this.boundaryUnitField;
        }
        set {
            this.boundaryUnitField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class IncentiveTableDescriptionTierTypeIncentiveDescription : IncentiveDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlEventData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlEventDataType {
    
    private string timestampField;
    
    private uint eventIdField;
    
    private bool eventIdFieldSpecified;
    
    private string eventActionConsumeField;
    
    private string eventActionProduceField;
    
    private TimePeriodType timePeriodField;
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public uint eventId {
        get {
            return this.eventIdField;
        }
        set {
            this.eventIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool eventIdSpecified {
        get {
            return this.eventIdFieldSpecified;
        }
        set {
            this.eventIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string eventActionConsume {
        get {
            return this.eventActionConsumeField;
        }
        set {
            this.eventActionConsumeField = value;
        }
    }
    
    /// <remarks/>
    public string eventActionProduce {
        get {
            return this.eventActionProduceField;
        }
        set {
            this.eventActionProduceField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitConstraintsDataType {
    
    private uint limitIdField;
    
    private bool limitIdFieldSpecified;
    
    private ScaledNumberType valueRangeMinField;
    
    private ScaledNumberType valueRangeMaxField;
    
    private ScaledNumberType valueStepSizeField;
    
    /// <remarks/>
    public uint limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool limitIdSpecified {
        get {
            return this.limitIdFieldSpecified;
        }
        set {
            this.limitIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueRangeMin {
        get {
            return this.valueRangeMinField;
        }
        set {
            this.valueRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueRangeMax {
        get {
            return this.valueRangeMaxField;
        }
        set {
            this.valueRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueStepSize {
        get {
            return this.valueStepSizeField;
        }
        set {
            this.valueStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitDescriptionDataType {
    
    private uint limitIdField;
    
    private bool limitIdFieldSpecified;
    
    private string limitTypeField;
    
    private string limitCategoryField;
    
    private string limitDirectionField;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string unitField;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool limitIdSpecified {
        get {
            return this.limitIdFieldSpecified;
        }
        set {
            this.limitIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string limitType {
        get {
            return this.limitTypeField;
        }
        set {
            this.limitTypeField = value;
        }
    }
    
    /// <remarks/>
    public string limitCategory {
        get {
            return this.limitCategoryField;
        }
        set {
            this.limitCategoryField = value;
        }
    }
    
    /// <remarks/>
    public string limitDirection {
        get {
            return this.limitDirectionField;
        }
        set {
            this.limitDirectionField = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitDataType {
    
    private uint limitIdField;
    
    private bool limitIdFieldSpecified;
    
    private bool isLimitChangeableField;
    
    private bool isLimitChangeableFieldSpecified;
    
    private bool isLimitActiveField;
    
    private bool isLimitActiveFieldSpecified;
    
    private TimePeriodType timePeriodField;
    
    private ScaledNumberType valueField;
    
    /// <remarks/>
    public uint limitId {
        get {
            return this.limitIdField;
        }
        set {
            this.limitIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool limitIdSpecified {
        get {
            return this.limitIdFieldSpecified;
        }
        set {
            this.limitIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool isLimitChangeable {
        get {
            return this.isLimitChangeableField;
        }
        set {
            this.isLimitChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isLimitChangeableSpecified {
        get {
            return this.isLimitChangeableFieldSpecified;
        }
        set {
            this.isLimitChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool isLimitActive {
        get {
            return this.isLimitActiveField;
        }
        set {
            this.isLimitActiveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isLimitActiveSpecified {
        get {
            return this.isLimitActiveFieldSpecified;
        }
        set {
            this.isLimitActiveFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlNodeData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlNodeDataType {
    
    private bool isNodeRemoteControllableField;
    
    private bool isNodeRemoteControllableFieldSpecified;
    
    /// <remarks/>
    public bool isNodeRemoteControllable {
        get {
            return this.isNodeRemoteControllableField;
        }
        set {
            this.isNodeRemoteControllableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isNodeRemoteControllableSpecified {
        get {
            return this.isNodeRemoteControllableFieldSpecified;
        }
        set {
            this.isNodeRemoteControllableFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlStateData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlStateDataType {
    
    private string timestampField;
    
    private uint eventIdField;
    
    private bool eventIdFieldSpecified;
    
    private string eventStateConsumeField;
    
    private string appliedEventActionConsumeField;
    
    private string eventStateProduceField;
    
    private string appliedEventActionProduceField;
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public uint eventId {
        get {
            return this.eventIdField;
        }
        set {
            this.eventIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool eventIdSpecified {
        get {
            return this.eventIdFieldSpecified;
        }
        set {
            this.eventIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string eventStateConsume {
        get {
            return this.eventStateConsumeField;
        }
        set {
            this.eventStateConsumeField = value;
        }
    }
    
    /// <remarks/>
    public string appliedEventActionConsume {
        get {
            return this.appliedEventActionConsumeField;
        }
        set {
            this.appliedEventActionConsumeField = value;
        }
    }
    
    /// <remarks/>
    public string eventStateProduce {
        get {
            return this.eventStateProduceField;
        }
        set {
            this.eventStateProduceField = value;
        }
    }
    
    /// <remarks/>
    public string appliedEventActionProduce {
        get {
            return this.appliedEventActionProduceField;
        }
        set {
            this.appliedEventActionProduceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementConstraintsDataType {
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private ScaledNumberType valueRangeMinField;
    
    private ScaledNumberType valueRangeMaxField;
    
    private ScaledNumberType valueStepSizeField;
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueRangeMin {
        get {
            return this.valueRangeMinField;
        }
        set {
            this.valueRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueRangeMax {
        get {
            return this.valueRangeMaxField;
        }
        set {
            this.valueRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueStepSize {
        get {
            return this.valueStepSizeField;
        }
        set {
            this.valueStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementDescriptionDataType {
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string measurementTypeField;
    
    private string commodityTypeField;
    
    private string unitField;
    
    private ScaledNumberType calibrationValueField;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string measurementType {
        get {
            return this.measurementTypeField;
        }
        set {
            this.measurementTypeField = value;
        }
    }
    
    /// <remarks/>
    public string commodityType {
        get {
            return this.commodityTypeField;
        }
        set {
            this.commodityTypeField = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType calibrationValue {
        get {
            return this.calibrationValueField;
        }
        set {
            this.calibrationValueField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementDataType {
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string valueTypeField;
    
    private string timestampField;
    
    private ScaledNumberType valueField;
    
    private TimePeriodType evaluationPeriodField;
    
    private string valueSourceField;
    
    private string valueTendencyField;
    
    private string valueStateField;
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType evaluationPeriod {
        get {
            return this.evaluationPeriodField;
        }
        set {
            this.evaluationPeriodField = value;
        }
    }
    
    /// <remarks/>
    public string valueSource {
        get {
            return this.valueSourceField;
        }
        set {
            this.valueSourceField = value;
        }
    }
    
    /// <remarks/>
    public string valueTendency {
        get {
            return this.valueTendencyField;
        }
        set {
            this.valueTendencyField = value;
        }
    }
    
    /// <remarks/>
    public string valueState {
        get {
            return this.valueStateField;
        }
        set {
            this.valueStateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementThresholdRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementThresholdRelationDataType {
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private uint[] thresholdIdField;
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("thresholdId")]
    public uint[] thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("messagingData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MessagingDataType {
    
    private string timestampField;
    
    private uint messagingNumberField;
    
    private bool messagingNumberFieldSpecified;
    
    private string typeField;
    
    private string textField;
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public uint messagingNumber {
        get {
            return this.messagingNumberField;
        }
        set {
            this.messagingNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool messagingNumberSpecified {
        get {
            return this.messagingNumberFieldSpecified;
        }
        set {
            this.messagingNumberFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    public string text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementAbortCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementAbortCallType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementAddNodeCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementAddNodeCallType {
    
    private FeatureAddressType nodeAddressField;
    
    private string nativeSetupField;
    
    private string timeoutField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public FeatureAddressType nodeAddress {
        get {
            return this.nodeAddressField;
        }
        set {
            this.nodeAddressField = value;
        }
    }
    
    /// <remarks/>
    public string nativeSetup {
        get {
            return this.nativeSetupField;
        }
        set {
            this.nativeSetupField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string timeout {
        get {
            return this.timeoutField;
        }
        set {
            this.timeoutField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementDeviceDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementDeviceDescriptionDataType {
    
    private DeviceAddressType deviceAddressField;
    
    private string deviceTypeField;
    
    private FeatureAddressType networkManagementResponsibleAddressField;
    
    private string nativeSetupField;
    
    private string technologyAddressField;
    
    private string communicationsTechnologyInformationField;
    
    private NetworkManagementFeatureSetType networkFeatureSetField;
    
    private bool networkFeatureSetFieldSpecified;
    
    private NetworkManagementStateChangeType lastStateChangeField;
    
    private bool lastStateChangeFieldSpecified;
    
    private string minimumTrustLevelField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public DeviceAddressType deviceAddress {
        get {
            return this.deviceAddressField;
        }
        set {
            this.deviceAddressField = value;
        }
    }
    
    /// <remarks/>
    public string deviceType {
        get {
            return this.deviceTypeField;
        }
        set {
            this.deviceTypeField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType networkManagementResponsibleAddress {
        get {
            return this.networkManagementResponsibleAddressField;
        }
        set {
            this.networkManagementResponsibleAddressField = value;
        }
    }
    
    /// <remarks/>
    public string nativeSetup {
        get {
            return this.nativeSetupField;
        }
        set {
            this.nativeSetupField = value;
        }
    }
    
    /// <remarks/>
    public string technologyAddress {
        get {
            return this.technologyAddressField;
        }
        set {
            this.technologyAddressField = value;
        }
    }
    
    /// <remarks/>
    public string communicationsTechnologyInformation {
        get {
            return this.communicationsTechnologyInformationField;
        }
        set {
            this.communicationsTechnologyInformationField = value;
        }
    }
    
    /// <remarks/>
    public NetworkManagementFeatureSetType networkFeatureSet {
        get {
            return this.networkFeatureSetField;
        }
        set {
            this.networkFeatureSetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool networkFeatureSetSpecified {
        get {
            return this.networkFeatureSetFieldSpecified;
        }
        set {
            this.networkFeatureSetFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public NetworkManagementStateChangeType lastStateChange {
        get {
            return this.lastStateChangeField;
        }
        set {
            this.lastStateChangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lastStateChangeSpecified {
        get {
            return this.lastStateChangeFieldSpecified;
        }
        set {
            this.lastStateChangeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string minimumTrustLevel {
        get {
            return this.minimumTrustLevelField;
        }
        set {
            this.minimumTrustLevelField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public enum NetworkManagementFeatureSetType {
    
    /// <remarks/>
    gateway,
    
    /// <remarks/>
    router,
    
    /// <remarks/>
    smart,
    
    /// <remarks/>
    simple,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public enum NetworkManagementStateChangeType {
    
    /// <remarks/>
    added,
    
    /// <remarks/>
    removed,
    
    /// <remarks/>
    modified,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementDiscoverCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementDiscoverCallType {
    
    private FeatureAddressType discoverAddressField;
    
    /// <remarks/>
    public FeatureAddressType discoverAddress {
        get {
            return this.discoverAddressField;
        }
        set {
            this.discoverAddressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementEntityDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementEntityDescriptionDataType {
    
    private EntityAddressType entityAddressField;
    
    private string entityTypeField;
    
    private NetworkManagementStateChangeType lastStateChangeField;
    
    private bool lastStateChangeFieldSpecified;
    
    private string minimumTrustLevelField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public EntityAddressType entityAddress {
        get {
            return this.entityAddressField;
        }
        set {
            this.entityAddressField = value;
        }
    }
    
    /// <remarks/>
    public string entityType {
        get {
            return this.entityTypeField;
        }
        set {
            this.entityTypeField = value;
        }
    }
    
    /// <remarks/>
    public NetworkManagementStateChangeType lastStateChange {
        get {
            return this.lastStateChangeField;
        }
        set {
            this.lastStateChangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lastStateChangeSpecified {
        get {
            return this.lastStateChangeFieldSpecified;
        }
        set {
            this.lastStateChangeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string minimumTrustLevel {
        get {
            return this.minimumTrustLevelField;
        }
        set {
            this.minimumTrustLevelField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementFeatureDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementFeatureDescriptionDataType {
    
    private FeatureAddressType featureAddressField;
    
    private string featureTypeField;
    
    private string[] specificUsageField;
    
    private string featureGroupField;
    
    private RoleType roleField;
    
    private bool roleFieldSpecified;
    
    private FunctionPropertyType[] supportedFunctionField;
    
    private NetworkManagementStateChangeType lastStateChangeField;
    
    private bool lastStateChangeFieldSpecified;
    
    private string minimumTrustLevelField;
    
    private string labelField;
    
    private string descriptionField;
    
    private string maxResponseDelayField;
    
    /// <remarks/>
    public FeatureAddressType featureAddress {
        get {
            return this.featureAddressField;
        }
        set {
            this.featureAddressField = value;
        }
    }
    
    /// <remarks/>
    public string featureType {
        get {
            return this.featureTypeField;
        }
        set {
            this.featureTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("specificUsage")]
    public string[] specificUsage {
        get {
            return this.specificUsageField;
        }
        set {
            this.specificUsageField = value;
        }
    }
    
    /// <remarks/>
    public string featureGroup {
        get {
            return this.featureGroupField;
        }
        set {
            this.featureGroupField = value;
        }
    }
    
    /// <remarks/>
    public RoleType role {
        get {
            return this.roleField;
        }
        set {
            this.roleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool roleSpecified {
        get {
            return this.roleFieldSpecified;
        }
        set {
            this.roleFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("supportedFunction")]
    public FunctionPropertyType[] supportedFunction {
        get {
            return this.supportedFunctionField;
        }
        set {
            this.supportedFunctionField = value;
        }
    }
    
    /// <remarks/>
    public NetworkManagementStateChangeType lastStateChange {
        get {
            return this.lastStateChangeField;
        }
        set {
            this.lastStateChangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lastStateChangeSpecified {
        get {
            return this.lastStateChangeFieldSpecified;
        }
        set {
            this.lastStateChangeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string minimumTrustLevel {
        get {
            return this.minimumTrustLevelField;
        }
        set {
            this.minimumTrustLevelField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string maxResponseDelay {
        get {
            return this.maxResponseDelayField;
        }
        set {
            this.maxResponseDelayField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public enum RoleType {
    
    /// <remarks/>
    client,
    
    /// <remarks/>
    server,
    
    /// <remarks/>
    special,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class FunctionPropertyType {
    
    private string functionField;
    
    private PossibleOperationsType possibleOperationsField;
    
    /// <remarks/>
    public string function {
        get {
            return this.functionField;
        }
        set {
            this.functionField = value;
        }
    }
    
    /// <remarks/>
    public PossibleOperationsType possibleOperations {
        get {
            return this.possibleOperationsField;
        }
        set {
            this.possibleOperationsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class PossibleOperationsType {
    
    private PossibleOperationsReadType readField;
    
    private PossibleOperationsWriteType writeField;
    
    /// <remarks/>
    public PossibleOperationsReadType read {
        get {
            return this.readField;
        }
        set {
            this.readField = value;
        }
    }
    
    /// <remarks/>
    public PossibleOperationsWriteType write {
        get {
            return this.writeField;
        }
        set {
            this.writeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class PossibleOperationsReadType : PossibleOperationsClassifierType {
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PossibleOperationsWriteType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(PossibleOperationsReadType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class PossibleOperationsClassifierType {
    
    private ElementTagType partialField;
    
    /// <remarks/>
    public ElementTagType partial {
        get {
            return this.partialField;
        }
        set {
            this.partialField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class PossibleOperationsWriteType : PossibleOperationsClassifierType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementJoiningModeData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementJoiningModeDataType {
    
    private string setupField;
    
    /// <remarks/>
    public string setup {
        get {
            return this.setupField;
        }
        set {
            this.setupField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementModifyNodeCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementModifyNodeCallType {
    
    private FeatureAddressType nodeAddressField;
    
    private string nativeSetupField;
    
    private string timeoutField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public FeatureAddressType nodeAddress {
        get {
            return this.nodeAddressField;
        }
        set {
            this.nodeAddressField = value;
        }
    }
    
    /// <remarks/>
    public string nativeSetup {
        get {
            return this.nativeSetupField;
        }
        set {
            this.nativeSetupField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string timeout {
        get {
            return this.timeoutField;
        }
        set {
            this.timeoutField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementProcessStateData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementProcessStateDataType {
    
    private NetworkManagementProcessStateStateType stateField;
    
    private bool stateFieldSpecified;
    
    private string descriptionField;
    
    /// <remarks/>
    public NetworkManagementProcessStateStateType state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool stateSpecified {
        get {
            return this.stateFieldSpecified;
        }
        set {
            this.stateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public enum NetworkManagementProcessStateStateType {
    
    /// <remarks/>
    succeeded,
    
    /// <remarks/>
    failed,
    
    /// <remarks/>
    aborted,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementRemoveNodeCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementRemoveNodeCallType {
    
    private FeatureAddressType nodeAddressField;
    
    private string timeoutField;
    
    /// <remarks/>
    public FeatureAddressType nodeAddress {
        get {
            return this.nodeAddressField;
        }
        set {
            this.nodeAddressField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string timeout {
        get {
            return this.timeoutField;
        }
        set {
            this.timeoutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementReportCandidateData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementReportCandidateDataType {
    
    private string candidateSetupField;
    
    private bool setupUsableForAddField;
    
    private bool setupUsableForAddFieldSpecified;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public string candidateSetup {
        get {
            return this.candidateSetupField;
        }
        set {
            this.candidateSetupField = value;
        }
    }
    
    /// <remarks/>
    public bool setupUsableForAdd {
        get {
            return this.setupUsableForAddField;
        }
        set {
            this.setupUsableForAddField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool setupUsableForAddSpecified {
        get {
            return this.setupUsableForAddFieldSpecified;
        }
        set {
            this.setupUsableForAddFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementScanNetworkCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementScanNetworkCallType {
    
    private string scanSetupField;
    
    private string timeoutField;
    
    /// <remarks/>
    public string scanSetup {
        get {
            return this.scanSetupField;
        }
        set {
            this.scanSetupField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string timeout {
        get {
            return this.timeoutField;
        }
        set {
            this.timeoutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementBindingDataTypeBindingEntry : BindingManagementEntryDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementBindingDeleteCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementBindingDeleteCallType {
    
    private NodeManagementBindingDeleteCallTypeBindingDelete bindingDeleteField;
    
    /// <remarks/>
    public NodeManagementBindingDeleteCallTypeBindingDelete bindingDelete {
        get {
            return this.bindingDeleteField;
        }
        set {
            this.bindingDeleteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementBindingDeleteCallTypeBindingDelete : BindingManagementDeleteCallType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementBindingRequestCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementBindingRequestCallType {
    
    private NodeManagementBindingRequestCallTypeBindingRequest bindingRequestField;
    
    /// <remarks/>
    public NodeManagementBindingRequestCallTypeBindingRequest bindingRequest {
        get {
            return this.bindingRequestField;
        }
        set {
            this.bindingRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementBindingRequestCallTypeBindingRequest : BindingManagementRequestCallType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementDestinationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementDestinationDataType {
    
    private NodeManagementDestinationDataTypeDeviceDescription deviceDescriptionField;
    
    /// <remarks/>
    public NodeManagementDestinationDataTypeDeviceDescription deviceDescription {
        get {
            return this.deviceDescriptionField;
        }
        set {
            this.deviceDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDestinationDataTypeDeviceDescription : NetworkManagementDeviceDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementDetailedDiscoveryData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementDetailedDiscoveryDataType {
    
    private SpecificationVersionDataType[] specificationVersionListField;
    
    private NodeManagementDetailedDiscoveryDeviceInformationType deviceInformationField;
    
    private NodeManagementDetailedDiscoveryEntityInformationType[] entityInformationField;
    
    private NodeManagementDetailedDiscoveryFeatureInformationType[] featureInformationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("specificationVersion", IsNullable=false)]
    public SpecificationVersionDataType[] specificationVersionList {
        get {
            return this.specificationVersionListField;
        }
        set {
            this.specificationVersionListField = value;
        }
    }
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDeviceInformationType deviceInformation {
        get {
            return this.deviceInformationField;
        }
        set {
            this.deviceInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("entityInformation")]
    public NodeManagementDetailedDiscoveryEntityInformationType[] entityInformation {
        get {
            return this.entityInformationField;
        }
        set {
            this.entityInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("featureInformation")]
    public NodeManagementDetailedDiscoveryFeatureInformationType[] featureInformation {
        get {
            return this.featureInformationField;
        }
        set {
            this.featureInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("specificationVersionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SpecificationVersionDataType {
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryDeviceInformationType {
    
    private NodeManagementDetailedDiscoveryDeviceInformationTypeDescription descriptionField;
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryDeviceInformationTypeDescription description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryDeviceInformationTypeDescription : NetworkManagementDeviceDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryEntityInformationType {
    
    private NodeManagementDetailedDiscoveryEntityInformationTypeDescription descriptionField;
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryEntityInformationTypeDescription description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryEntityInformationTypeDescription : NetworkManagementEntityDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryFeatureInformationType {
    
    private NodeManagementDetailedDiscoveryFeatureInformationTypeDescription descriptionField;
    
    /// <remarks/>
    public NodeManagementDetailedDiscoveryFeatureInformationTypeDescription description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementDetailedDiscoveryFeatureInformationTypeDescription : NetworkManagementFeatureDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSubscriptionDataTypeSubscriptionEntry : SubscriptionManagementEntryDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("subscriptionManagementEntryData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SubscriptionManagementEntryDataType {
    
    private uint subscriptionIdField;
    
    private bool subscriptionIdFieldSpecified;
    
    private FeatureAddressType clientAddressField;
    
    private FeatureAddressType serverAddressField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint subscriptionId {
        get {
            return this.subscriptionIdField;
        }
        set {
            this.subscriptionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool subscriptionIdSpecified {
        get {
            return this.subscriptionIdFieldSpecified;
        }
        set {
            this.subscriptionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementSubscriptionDeleteCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementSubscriptionDeleteCallType {
    
    private NodeManagementSubscriptionDeleteCallTypeSubscriptionDelete subscriptionDeleteField;
    
    /// <remarks/>
    public NodeManagementSubscriptionDeleteCallTypeSubscriptionDelete subscriptionDelete {
        get {
            return this.subscriptionDeleteField;
        }
        set {
            this.subscriptionDeleteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSubscriptionDeleteCallTypeSubscriptionDelete : SubscriptionManagementDeleteCallType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("subscriptionManagementDeleteCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SubscriptionManagementDeleteCallType {
    
    private uint subscriptionIdField;
    
    private bool subscriptionIdFieldSpecified;
    
    private FeatureAddressType clientAddressField;
    
    private FeatureAddressType serverAddressField;
    
    /// <remarks/>
    public uint subscriptionId {
        get {
            return this.subscriptionIdField;
        }
        set {
            this.subscriptionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool subscriptionIdSpecified {
        get {
            return this.subscriptionIdFieldSpecified;
        }
        set {
            this.subscriptionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementSubscriptionRequestCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementSubscriptionRequestCallType {
    
    private NodeManagementSubscriptionRequestCallTypeSubscriptionRequest subscriptionRequestField;
    
    /// <remarks/>
    public NodeManagementSubscriptionRequestCallTypeSubscriptionRequest subscriptionRequest {
        get {
            return this.subscriptionRequestField;
        }
        set {
            this.subscriptionRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementSubscriptionRequestCallTypeSubscriptionRequest : SubscriptionManagementRequestCallType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("subscriptionManagementRequestCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SubscriptionManagementRequestCallType {
    
    private FeatureAddressType clientAddressField;
    
    private FeatureAddressType serverAddressField;
    
    private string serverFeatureTypeField;
    
    /// <remarks/>
    public FeatureAddressType clientAddress {
        get {
            return this.clientAddressField;
        }
        set {
            this.clientAddressField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType serverAddress {
        get {
            return this.serverAddressField;
        }
        set {
            this.serverAddressField = value;
        }
    }
    
    /// <remarks/>
    public string serverFeatureType {
        get {
            return this.serverFeatureTypeField;
        }
        set {
            this.serverFeatureTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class NodeManagementUseCaseDataTypeUseCaseInformation : UseCaseInformationDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("useCaseInformationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class UseCaseInformationDataType {
    
    private FeatureAddressType addressField;
    
    private string actorField;
    
    private UseCaseSupportType[] useCaseSupportField;
    
    /// <remarks/>
    public FeatureAddressType address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string actor {
        get {
            return this.actorField;
        }
        set {
            this.actorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("useCaseSupport")]
    public UseCaseSupportType[] useCaseSupport {
        get {
            return this.useCaseSupportField;
        }
        set {
            this.useCaseSupportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class UseCaseSupportType {
    
    private string useCaseNameField;
    
    private string useCaseVersionField;
    
    private bool useCaseAvailableField;
    
    private bool useCaseAvailableFieldSpecified;
    
    private uint[] scenarioSupportField;
    
    /// <remarks/>
    public string useCaseName {
        get {
            return this.useCaseNameField;
        }
        set {
            this.useCaseNameField = value;
        }
    }
    
    /// <remarks/>
    public string useCaseVersion {
        get {
            return this.useCaseVersionField;
        }
        set {
            this.useCaseVersionField = value;
        }
    }
    
    /// <remarks/>
    public bool useCaseAvailable {
        get {
            return this.useCaseAvailableField;
        }
        set {
            this.useCaseAvailableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool useCaseAvailableSpecified {
        get {
            return this.useCaseAvailableFieldSpecified;
        }
        set {
            this.useCaseAvailableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("scenarioSupport")]
    public uint[] scenarioSupport {
        get {
            return this.scenarioSupportField;
        }
        set {
            this.scenarioSupportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsDurationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsDurationDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private string activeDurationMinField;
    
    private string activeDurationMaxField;
    
    private string pauseDurationMinField;
    
    private string pauseDurationMaxField;
    
    private string activeDurationSumMinField;
    
    private string activeDurationSumMaxField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string activeDurationMin {
        get {
            return this.activeDurationMinField;
        }
        set {
            this.activeDurationMinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string activeDurationMax {
        get {
            return this.activeDurationMaxField;
        }
        set {
            this.activeDurationMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string pauseDurationMin {
        get {
            return this.pauseDurationMinField;
        }
        set {
            this.pauseDurationMinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string pauseDurationMax {
        get {
            return this.pauseDurationMaxField;
        }
        set {
            this.pauseDurationMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string activeDurationSumMin {
        get {
            return this.activeDurationSumMinField;
        }
        set {
            this.activeDurationSumMinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string activeDurationSumMax {
        get {
            return this.activeDurationSumMaxField;
        }
        set {
            this.activeDurationSumMaxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsInterruptData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsInterruptDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private bool isPausableField;
    
    private bool isPausableFieldSpecified;
    
    private bool isStoppableField;
    
    private bool isStoppableFieldSpecified;
    
    private bool notInterruptibleAtHighPowerField;
    
    private bool notInterruptibleAtHighPowerFieldSpecified;
    
    private uint maxCyclesPerDayField;
    
    private bool maxCyclesPerDayFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool isPausable {
        get {
            return this.isPausableField;
        }
        set {
            this.isPausableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isPausableSpecified {
        get {
            return this.isPausableFieldSpecified;
        }
        set {
            this.isPausableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool isStoppable {
        get {
            return this.isStoppableField;
        }
        set {
            this.isStoppableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isStoppableSpecified {
        get {
            return this.isStoppableFieldSpecified;
        }
        set {
            this.isStoppableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool notInterruptibleAtHighPower {
        get {
            return this.notInterruptibleAtHighPowerField;
        }
        set {
            this.notInterruptibleAtHighPowerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool notInterruptibleAtHighPowerSpecified {
        get {
            return this.notInterruptibleAtHighPowerFieldSpecified;
        }
        set {
            this.notInterruptibleAtHighPowerFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint maxCyclesPerDay {
        get {
            return this.maxCyclesPerDayField;
        }
        set {
            this.maxCyclesPerDayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool maxCyclesPerDaySpecified {
        get {
            return this.maxCyclesPerDayFieldSpecified;
        }
        set {
            this.maxCyclesPerDayFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerDescriptionDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private string positiveEnergyDirectionField;
    
    private string powerUnitField;
    
    private string energyUnitField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public string powerUnit {
        get {
            return this.powerUnitField;
        }
        set {
            this.powerUnitField = value;
        }
    }
    
    /// <remarks/>
    public string energyUnit {
        get {
            return this.energyUnitField;
        }
        set {
            this.energyUnitField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerLevelData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerLevelDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private ScaledNumberType[] powerField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("power")]
    public ScaledNumberType[] power {
        get {
            return this.powerField;
        }
        set {
            this.powerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerRangeData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerRangeDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private ScaledNumberType powerMinField;
    
    private ScaledNumberType powerMaxField;
    
    private ScaledNumberType energyMinField;
    
    private ScaledNumberType energyMaxField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType powerMin {
        get {
            return this.powerMinField;
        }
        set {
            this.powerMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType powerMax {
        get {
            return this.powerMaxField;
        }
        set {
            this.powerMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType energyMin {
        get {
            return this.energyMinField;
        }
        set {
            this.energyMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType energyMax {
        get {
            return this.energyMaxField;
        }
        set {
            this.energyMaxField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsResumeImplicationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsResumeImplicationDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private ScaledNumberType resumeEnergyEstimatedField;
    
    private string energyUnitField;
    
    private ScaledNumberType resumeCostEstimatedField;
    
    private string currencyField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType resumeEnergyEstimated {
        get {
            return this.resumeEnergyEstimatedField;
        }
        set {
            this.resumeEnergyEstimatedField = value;
        }
    }
    
    /// <remarks/>
    public string energyUnit {
        get {
            return this.energyUnitField;
        }
        set {
            this.energyUnitField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType resumeCostEstimated {
        get {
            return this.resumeCostEstimatedField;
        }
        set {
            this.resumeCostEstimatedField = value;
        }
    }
    
    /// <remarks/>
    public string currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SmartEnergyManagementPsAlternativesRelationType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceAlternativesRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceAlternativesRelationDataType {
    
    private uint alternativesIdField;
    
    private bool alternativesIdFieldSpecified;
    
    private uint[] sequenceIdField;
    
    /// <remarks/>
    public uint alternativesId {
        get {
            return this.alternativesIdField;
        }
        set {
            this.alternativesIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool alternativesIdSpecified {
        get {
            return this.alternativesIdFieldSpecified;
        }
        set {
            this.alternativesIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sequenceId")]
    public uint[] sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsAlternativesRelationType : PowerSequenceAlternativesRelationDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceDescriptionDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private string descriptionField;
    
    private string positiveEnergyDirectionField;
    
    private string powerUnitField;
    
    private string energyUnitField;
    
    private string valueSourceField;
    
    private string scopeField;
    
    private uint taskIdentifierField;
    
    private bool taskIdentifierFieldSpecified;
    
    private uint repetitionsTotalField;
    
    private bool repetitionsTotalFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public string positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public string powerUnit {
        get {
            return this.powerUnitField;
        }
        set {
            this.powerUnitField = value;
        }
    }
    
    /// <remarks/>
    public string energyUnit {
        get {
            return this.energyUnitField;
        }
        set {
            this.energyUnitField = value;
        }
    }
    
    /// <remarks/>
    public string valueSource {
        get {
            return this.valueSourceField;
        }
        set {
            this.valueSourceField = value;
        }
    }
    
    /// <remarks/>
    public string scope {
        get {
            return this.scopeField;
        }
        set {
            this.scopeField = value;
        }
    }
    
    /// <remarks/>
    public uint taskIdentifier {
        get {
            return this.taskIdentifierField;
        }
        set {
            this.taskIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool taskIdentifierSpecified {
        get {
            return this.taskIdentifierFieldSpecified;
        }
        set {
            this.taskIdentifierFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint repetitionsTotal {
        get {
            return this.repetitionsTotalField;
        }
        set {
            this.repetitionsTotalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool repetitionsTotalSpecified {
        get {
            return this.repetitionsTotalFieldSpecified;
        }
        set {
            this.repetitionsTotalFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceNodeScheduleInformationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceNodeScheduleInformationDataType {
    
    private bool nodeRemoteControllableField;
    
    private bool nodeRemoteControllableFieldSpecified;
    
    private bool supportsSingleSlotSchedulingOnlyField;
    
    private bool supportsSingleSlotSchedulingOnlyFieldSpecified;
    
    private uint alternativesCountField;
    
    private bool alternativesCountFieldSpecified;
    
    private uint totalSequencesCountMaxField;
    
    private bool totalSequencesCountMaxFieldSpecified;
    
    private bool supportsReselectionField;
    
    private bool supportsReselectionFieldSpecified;
    
    /// <remarks/>
    public bool nodeRemoteControllable {
        get {
            return this.nodeRemoteControllableField;
        }
        set {
            this.nodeRemoteControllableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool nodeRemoteControllableSpecified {
        get {
            return this.nodeRemoteControllableFieldSpecified;
        }
        set {
            this.nodeRemoteControllableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool supportsSingleSlotSchedulingOnly {
        get {
            return this.supportsSingleSlotSchedulingOnlyField;
        }
        set {
            this.supportsSingleSlotSchedulingOnlyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool supportsSingleSlotSchedulingOnlySpecified {
        get {
            return this.supportsSingleSlotSchedulingOnlyFieldSpecified;
        }
        set {
            this.supportsSingleSlotSchedulingOnlyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint alternativesCount {
        get {
            return this.alternativesCountField;
        }
        set {
            this.alternativesCountField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool alternativesCountSpecified {
        get {
            return this.alternativesCountFieldSpecified;
        }
        set {
            this.alternativesCountFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint totalSequencesCountMax {
        get {
            return this.totalSequencesCountMaxField;
        }
        set {
            this.totalSequencesCountMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool totalSequencesCountMaxSpecified {
        get {
            return this.totalSequencesCountMaxFieldSpecified;
        }
        set {
            this.totalSequencesCountMaxFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool supportsReselection {
        get {
            return this.supportsReselectionField;
        }
        set {
            this.supportsReselectionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool supportsReselectionSpecified {
        get {
            return this.supportsReselectionFieldSpecified;
        }
        set {
            this.supportsReselectionFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequencePriceCalculationRequestCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequencePriceCalculationRequestCallType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private string potentialStartTimeField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string potentialStartTime {
        get {
            return this.potentialStartTimeField;
        }
        set {
            this.potentialStartTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequencePriceData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequencePriceDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private string potentialStartTimeField;
    
    private ScaledNumberType priceField;
    
    private string currencyField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string potentialStartTime {
        get {
            return this.potentialStartTimeField;
        }
        set {
            this.potentialStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
    
    /// <remarks/>
    public string currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleConfigurationRequestCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleConfigurationRequestCallType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleConstraintsDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private string earliestStartTimeField;
    
    private string latestStartTimeField;
    
    private string earliestEndTimeField;
    
    private string latestEndTimeField;
    
    private bool optionalSequenceField;
    
    private bool optionalSequenceFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string earliestStartTime {
        get {
            return this.earliestStartTimeField;
        }
        set {
            this.earliestStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public string latestStartTime {
        get {
            return this.latestStartTimeField;
        }
        set {
            this.latestStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public string earliestEndTime {
        get {
            return this.earliestEndTimeField;
        }
        set {
            this.earliestEndTimeField = value;
        }
    }
    
    /// <remarks/>
    public string latestEndTime {
        get {
            return this.latestEndTimeField;
        }
        set {
            this.latestEndTimeField = value;
        }
    }
    
    /// <remarks/>
    public bool optionalSequence {
        get {
            return this.optionalSequenceField;
        }
        set {
            this.optionalSequenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool optionalSequenceSpecified {
        get {
            return this.optionalSequenceFieldSpecified;
        }
        set {
            this.optionalSequenceFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private string startTimeField;
    
    private string endTimeField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string startTime {
        get {
            return this.startTimeField;
        }
        set {
            this.startTimeField = value;
        }
    }
    
    /// <remarks/>
    public string endTime {
        get {
            return this.endTimeField;
        }
        set {
            this.endTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceSchedulePreferenceData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceSchedulePreferenceDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private bool greenestField;
    
    private bool greenestFieldSpecified;
    
    private bool cheapestField;
    
    private bool cheapestFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool greenest {
        get {
            return this.greenestField;
        }
        set {
            this.greenestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool greenestSpecified {
        get {
            return this.greenestFieldSpecified;
        }
        set {
            this.greenestFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool cheapest {
        get {
            return this.cheapestField;
        }
        set {
            this.cheapestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cheapestSpecified {
        get {
            return this.cheapestFieldSpecified;
        }
        set {
            this.cheapestFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceStateData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceStateDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private string stateField;
    
    private uint activeSlotNumberField;
    
    private bool activeSlotNumberFieldSpecified;
    
    private string elapsedSlotTimeField;
    
    private string remainingSlotTimeField;
    
    private bool sequenceRemoteControllableField;
    
    private bool sequenceRemoteControllableFieldSpecified;
    
    private uint activeRepetitionNumberField;
    
    private bool activeRepetitionNumberFieldSpecified;
    
    private string remainingPauseTimeField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public uint activeSlotNumber {
        get {
            return this.activeSlotNumberField;
        }
        set {
            this.activeSlotNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool activeSlotNumberSpecified {
        get {
            return this.activeSlotNumberFieldSpecified;
        }
        set {
            this.activeSlotNumberFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string elapsedSlotTime {
        get {
            return this.elapsedSlotTimeField;
        }
        set {
            this.elapsedSlotTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string remainingSlotTime {
        get {
            return this.remainingSlotTimeField;
        }
        set {
            this.remainingSlotTimeField = value;
        }
    }
    
    /// <remarks/>
    public bool sequenceRemoteControllable {
        get {
            return this.sequenceRemoteControllableField;
        }
        set {
            this.sequenceRemoteControllableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceRemoteControllableSpecified {
        get {
            return this.sequenceRemoteControllableFieldSpecified;
        }
        set {
            this.sequenceRemoteControllableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint activeRepetitionNumber {
        get {
            return this.activeRepetitionNumberField;
        }
        set {
            this.activeRepetitionNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool activeRepetitionNumberSpecified {
        get {
            return this.activeRepetitionNumberFieldSpecified;
        }
        set {
            this.activeRepetitionNumberFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string remainingPauseTime {
        get {
            return this.remainingPauseTimeField;
        }
        set {
            this.remainingPauseTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotScheduleConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotScheduleConstraintsDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private uint slotNumberField;
    
    private bool slotNumberFieldSpecified;
    
    private string earliestStartTimeField;
    
    private string latestEndTimeField;
    
    private string minDurationField;
    
    private string maxDurationField;
    
    private bool optionalSlotField;
    
    private bool optionalSlotFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotNumberSpecified {
        get {
            return this.slotNumberFieldSpecified;
        }
        set {
            this.slotNumberFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string earliestStartTime {
        get {
            return this.earliestStartTimeField;
        }
        set {
            this.earliestStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public string latestEndTime {
        get {
            return this.latestEndTimeField;
        }
        set {
            this.latestEndTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string minDuration {
        get {
            return this.minDurationField;
        }
        set {
            this.minDurationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string maxDuration {
        get {
            return this.maxDurationField;
        }
        set {
            this.maxDurationField = value;
        }
    }
    
    /// <remarks/>
    public bool optionalSlot {
        get {
            return this.optionalSlotField;
        }
        set {
            this.optionalSlotField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool optionalSlotSpecified {
        get {
            return this.optionalSlotFieldSpecified;
        }
        set {
            this.optionalSlotFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotScheduleData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotScheduleDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private uint slotNumberField;
    
    private bool slotNumberFieldSpecified;
    
    private TimePeriodType timePeriodField;
    
    private string defaultDurationField;
    
    private string durationUncertaintyField;
    
    private bool slotActivatedField;
    
    private bool slotActivatedFieldSpecified;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotNumberSpecified {
        get {
            return this.slotNumberFieldSpecified;
        }
        set {
            this.slotNumberFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string defaultDuration {
        get {
            return this.defaultDurationField;
        }
        set {
            this.defaultDurationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string durationUncertainty {
        get {
            return this.durationUncertaintyField;
        }
        set {
            this.durationUncertaintyField = value;
        }
    }
    
    /// <remarks/>
    public bool slotActivated {
        get {
            return this.slotActivatedField;
        }
        set {
            this.slotActivatedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotActivatedSpecified {
        get {
            return this.slotActivatedFieldSpecified;
        }
        set {
            this.slotActivatedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotValueData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotValueDataType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    private uint slotNumberField;
    
    private bool slotNumberFieldSpecified;
    
    private string valueTypeField;
    
    private ScaledNumberType valueField;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotNumber {
        get {
            return this.slotNumberField;
        }
        set {
            this.slotNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotNumberSpecified {
        get {
            return this.slotNumberFieldSpecified;
        }
        set {
            this.slotNumberFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string valueType {
        get {
            return this.valueTypeField;
        }
        set {
            this.valueTypeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("resultData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ResultDataType {
    
    private uint errorNumberField;
    
    private bool errorNumberFieldSpecified;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint errorNumber {
        get {
            return this.errorNumberField;
        }
        set {
            this.errorNumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool errorNumberSpecified {
        get {
            return this.errorNumberFieldSpecified;
        }
        set {
            this.errorNumberFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("sensingDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SensingDescriptionDataType {
    
    private string sensingTypeField;
    
    private string unitField;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public string sensingType {
        get {
            return this.sensingTypeField;
        }
        set {
            this.sensingTypeField = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("sensingData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SensingDataType {
    
    private string timestampField;
    
    private string stateField;
    
    private ScaledNumberType valueField;
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointConstraintsDataType {
    
    private uint setpointIdField;
    
    private bool setpointIdFieldSpecified;
    
    private ScaledNumberType setpointRangeMinField;
    
    private ScaledNumberType setpointRangeMaxField;
    
    private ScaledNumberType setpointStepSizeField;
    
    /// <remarks/>
    public uint setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool setpointIdSpecified {
        get {
            return this.setpointIdFieldSpecified;
        }
        set {
            this.setpointIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType setpointRangeMin {
        get {
            return this.setpointRangeMinField;
        }
        set {
            this.setpointRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType setpointRangeMax {
        get {
            return this.setpointRangeMaxField;
        }
        set {
            this.setpointRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType setpointStepSize {
        get {
            return this.setpointStepSizeField;
        }
        set {
            this.setpointStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointDescriptionDataType {
    
    private uint setpointIdField;
    
    private bool setpointIdFieldSpecified;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private string setpointTypeField;
    
    private string unitField;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool setpointIdSpecified {
        get {
            return this.setpointIdFieldSpecified;
        }
        set {
            this.setpointIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string setpointType {
        get {
            return this.setpointTypeField;
        }
        set {
            this.setpointTypeField = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointDataType {
    
    private uint setpointIdField;
    
    private bool setpointIdFieldSpecified;
    
    private ScaledNumberType valueField;
    
    private ScaledNumberType valueMinField;
    
    private ScaledNumberType valueMaxField;
    
    private ScaledNumberType valueToleranceAbsoluteField;
    
    private ScaledNumberType valueTolerancePercentageField;
    
    /// <remarks/>
    public uint setpointId {
        get {
            return this.setpointIdField;
        }
        set {
            this.setpointIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool setpointIdSpecified {
        get {
            return this.setpointIdFieldSpecified;
        }
        set {
            this.setpointIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueMin {
        get {
            return this.valueMinField;
        }
        set {
            this.valueMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueMax {
        get {
            return this.valueMaxField;
        }
        set {
            this.valueMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueToleranceAbsolute {
        get {
            return this.valueToleranceAbsoluteField;
        }
        set {
            this.valueToleranceAbsoluteField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType valueTolerancePercentage {
        get {
            return this.valueTolerancePercentageField;
        }
        set {
            this.valueTolerancePercentageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsConfigurationRequestCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsConfigurationRequestCallType {
    
    private SmartEnergyManagementPsConfigurationRequestCallTypeScheduleConfigurationRequest scheduleConfigurationRequestField;
    
    /// <remarks/>
    public SmartEnergyManagementPsConfigurationRequestCallTypeScheduleConfigurationRequest scheduleConfigurationRequest {
        get {
            return this.scheduleConfigurationRequestField;
        }
        set {
            this.scheduleConfigurationRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsConfigurationRequestCallTypeScheduleConfigurationRequest : PowerSequenceScheduleConfigurationRequestCallType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsDataType {
    
    private SmartEnergyManagementPsDataTypeNodeScheduleInformation nodeScheduleInformationField;
    
    private SmartEnergyManagementPsAlternativesType[] alternativesField;
    
    /// <remarks/>
    public SmartEnergyManagementPsDataTypeNodeScheduleInformation nodeScheduleInformation {
        get {
            return this.nodeScheduleInformationField;
        }
        set {
            this.nodeScheduleInformationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("alternatives")]
    public SmartEnergyManagementPsAlternativesType[] alternatives {
        get {
            return this.alternativesField;
        }
        set {
            this.alternativesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsDataTypeNodeScheduleInformation : PowerSequenceNodeScheduleInformationDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsAlternativesType {
    
    private SmartEnergyManagementPsAlternativesRelationType relationField;
    
    private SmartEnergyManagementPsPowerSequenceType[] powerSequenceField;
    
    /// <remarks/>
    public SmartEnergyManagementPsAlternativesRelationType relation {
        get {
            return this.relationField;
        }
        set {
            this.relationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerSequence")]
    public SmartEnergyManagementPsPowerSequenceType[] powerSequence {
        get {
            return this.powerSequenceField;
        }
        set {
            this.powerSequenceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceType {
    
    private SmartEnergyManagementPsPowerSequenceTypeDescription descriptionField;
    
    private SmartEnergyManagementPsPowerSequenceTypeState stateField;
    
    private SmartEnergyManagementPsPowerSequenceTypeSchedule scheduleField;
    
    private SmartEnergyManagementPsPowerSequenceTypeScheduleConstraints scheduleConstraintsField;
    
    private SmartEnergyManagementPsPowerSequenceTypeSchedulePreference schedulePreferenceField;
    
    private SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsInterrupt operatingConstraintsInterruptField;
    
    private SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsDuration operatingConstraintsDurationField;
    
    private SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsResumeImplication operatingConstraintsResumeImplicationField;
    
    private SmartEnergyManagementPsPowerTimeSlotType[] powerTimeSlotField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceTypeDescription description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceTypeState state {
        get {
            return this.stateField;
        }
        set {
            this.stateField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceTypeSchedule schedule {
        get {
            return this.scheduleField;
        }
        set {
            this.scheduleField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceTypeScheduleConstraints scheduleConstraints {
        get {
            return this.scheduleConstraintsField;
        }
        set {
            this.scheduleConstraintsField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceTypeSchedulePreference schedulePreference {
        get {
            return this.schedulePreferenceField;
        }
        set {
            this.schedulePreferenceField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsInterrupt operatingConstraintsInterrupt {
        get {
            return this.operatingConstraintsInterruptField;
        }
        set {
            this.operatingConstraintsInterruptField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsDuration operatingConstraintsDuration {
        get {
            return this.operatingConstraintsDurationField;
        }
        set {
            this.operatingConstraintsDurationField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsResumeImplication operatingConstraintsResumeImplication {
        get {
            return this.operatingConstraintsResumeImplicationField;
        }
        set {
            this.operatingConstraintsResumeImplicationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerTimeSlot")]
    public SmartEnergyManagementPsPowerTimeSlotType[] powerTimeSlot {
        get {
            return this.powerTimeSlotField;
        }
        set {
            this.powerTimeSlotField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceTypeDescription : PowerSequenceDescriptionDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceTypeState : PowerSequenceStateDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceTypeSchedule : PowerSequenceScheduleDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceTypeScheduleConstraints : PowerSequenceScheduleConstraintsDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceTypeSchedulePreference : PowerSequenceSchedulePreferenceDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsInterrupt : OperatingConstraintsInterruptDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsDuration : OperatingConstraintsDurationDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerSequenceTypeOperatingConstraintsResumeImplication : OperatingConstraintsResumeImplicationDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotType {
    
    private SmartEnergyManagementPsPowerTimeSlotTypeSchedule scheduleField;
    
    private SmartEnergyManagementPsPowerTimeSlotValueListTypeValue[] valueListField;
    
    private SmartEnergyManagementPsPowerTimeSlotTypeScheduleConstraints scheduleConstraintsField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerTimeSlotTypeSchedule schedule {
        get {
            return this.scheduleField;
        }
        set {
            this.scheduleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("value", IsNullable=false)]
    public SmartEnergyManagementPsPowerTimeSlotValueListTypeValue[] valueList {
        get {
            return this.valueListField;
        }
        set {
            this.valueListField = value;
        }
    }
    
    /// <remarks/>
    public SmartEnergyManagementPsPowerTimeSlotTypeScheduleConstraints scheduleConstraints {
        get {
            return this.scheduleConstraintsField;
        }
        set {
            this.scheduleConstraintsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotTypeSchedule : PowerTimeSlotScheduleDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotValueListTypeValue : PowerTimeSlotValueDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPowerTimeSlotTypeScheduleConstraints : PowerTimeSlotScheduleConstraintsDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsPriceCalculationRequestCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsPriceCalculationRequestCallType {
    
    private SmartEnergyManagementPsPriceCalculationRequestCallTypePriceCalculationRequest priceCalculationRequestField;
    
    /// <remarks/>
    public SmartEnergyManagementPsPriceCalculationRequestCallTypePriceCalculationRequest priceCalculationRequest {
        get {
            return this.priceCalculationRequestField;
        }
        set {
            this.priceCalculationRequestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPriceCalculationRequestCallTypePriceCalculationRequest : PowerSequencePriceCalculationRequestCallType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class SmartEnergyManagementPsPriceDataTypePrice : PowerSequencePriceDataType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionDescriptionDataType {
    
    private uint conditionIdField;
    
    private bool conditionIdFieldSpecified;
    
    private string commodityTypeField;
    
    private string positiveEnergyDirectionField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conditionIdSpecified {
        get {
            return this.conditionIdFieldSpecified;
        }
        set {
            this.conditionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string commodityType {
        get {
            return this.commodityTypeField;
        }
        set {
            this.commodityTypeField = value;
        }
    }
    
    /// <remarks/>
    public string positiveEnergyDirection {
        get {
            return this.positiveEnergyDirectionField;
        }
        set {
            this.positiveEnergyDirectionField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionDataType {
    
    private uint conditionIdField;
    
    private bool conditionIdFieldSpecified;
    
    private string timestampField;
    
    private string eventTypeField;
    
    private string originatorField;
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    private ScaledNumberType thresholdPercentageField;
    
    private TimePeriodType relevantPeriodField;
    
    private string descriptionField;
    
    private string gridConditionField;
    
    /// <remarks/>
    public uint conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conditionIdSpecified {
        get {
            return this.conditionIdFieldSpecified;
        }
        set {
            this.conditionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string eventType {
        get {
            return this.eventTypeField;
        }
        set {
            this.eventTypeField = value;
        }
    }
    
    /// <remarks/>
    public string originator {
        get {
            return this.originatorField;
        }
        set {
            this.originatorField = value;
        }
    }
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType thresholdPercentage {
        get {
            return this.thresholdPercentageField;
        }
        set {
            this.thresholdPercentageField = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType relevantPeriod {
        get {
            return this.relevantPeriodField;
        }
        set {
            this.relevantPeriodField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public string gridCondition {
        get {
            return this.gridConditionField;
        }
        set {
            this.gridConditionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionThresholdRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionThresholdRelationDataType {
    
    private uint conditionIdField;
    
    private bool conditionIdFieldSpecified;
    
    private uint[] thresholdIdField;
    
    /// <remarks/>
    public uint conditionId {
        get {
            return this.conditionIdField;
        }
        set {
            this.conditionIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool conditionIdSpecified {
        get {
            return this.conditionIdFieldSpecified;
        }
        set {
            this.conditionIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("thresholdId")]
    public uint[] thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffBoundaryRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffBoundaryRelationDataType {
    
    private uint tariffIdField;
    
    private bool tariffIdFieldSpecified;
    
    private uint[] boundaryIdField;
    
    /// <remarks/>
    public uint tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffIdSpecified {
        get {
            return this.tariffIdFieldSpecified;
        }
        set {
            this.tariffIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("boundaryId")]
    public uint[] boundaryId {
        get {
            return this.boundaryIdField;
        }
        set {
            this.boundaryIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffTierRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffTierRelationDataType {
    
    private uint tariffIdField;
    
    private bool tariffIdFieldSpecified;
    
    private uint[] tierIdField;
    
    /// <remarks/>
    public uint tariffId {
        get {
            return this.tariffIdField;
        }
        set {
            this.tariffIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tariffIdSpecified {
        get {
            return this.tariffIdFieldSpecified;
        }
        set {
            this.tariffIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tierId")]
    public uint[] tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobDescriptionDataType {
    
    private uint jobIdField;
    
    private bool jobIdFieldSpecified;
    
    private string jobSourceField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool jobIdSpecified {
        get {
            return this.jobIdFieldSpecified;
        }
        set {
            this.jobIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string jobSource {
        get {
            return this.jobSourceField;
        }
        set {
            this.jobSourceField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobDataType {
    
    private uint jobIdField;
    
    private bool jobIdFieldSpecified;
    
    private string timestampField;
    
    private string jobStateField;
    
    private string elapsedTimeField;
    
    private string remainingTimeField;
    
    /// <remarks/>
    public uint jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool jobIdSpecified {
        get {
            return this.jobIdFieldSpecified;
        }
        set {
            this.jobIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
    
    /// <remarks/>
    public string jobState {
        get {
            return this.jobStateField;
        }
        set {
            this.jobStateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string elapsedTime {
        get {
            return this.elapsedTimeField;
        }
        set {
            this.elapsedTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string remainingTime {
        get {
            return this.remainingTimeField;
        }
        set {
            this.remainingTimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobRelationDataType {
    
    private uint jobIdField;
    
    private bool jobIdFieldSpecified;
    
    private TaskManagementDirectControlRelatedType directControlRelatedField;
    
    private TaskManagementHvacRelatedType hvacRelatedField;
    
    private TaskManagementLoadControlReleatedType loadControlReleatedField;
    
    private TaskManagementPowerSequencesRelatedType powerSequencesRelatedField;
    
    private TaskManagementSmartEnergyManagementPsRelatedType smartEnergyManagementPsRelatedField;
    
    /// <remarks/>
    public uint jobId {
        get {
            return this.jobIdField;
        }
        set {
            this.jobIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool jobIdSpecified {
        get {
            return this.jobIdFieldSpecified;
        }
        set {
            this.jobIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementDirectControlRelatedType directControlRelated {
        get {
            return this.directControlRelatedField;
        }
        set {
            this.directControlRelatedField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementHvacRelatedType hvacRelated {
        get {
            return this.hvacRelatedField;
        }
        set {
            this.hvacRelatedField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementLoadControlReleatedType loadControlReleated {
        get {
            return this.loadControlReleatedField;
        }
        set {
            this.loadControlReleatedField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementPowerSequencesRelatedType powerSequencesRelated {
        get {
            return this.powerSequencesRelatedField;
        }
        set {
            this.powerSequencesRelatedField = value;
        }
    }
    
    /// <remarks/>
    public TaskManagementSmartEnergyManagementPsRelatedType smartEnergyManagementPsRelated {
        get {
            return this.smartEnergyManagementPsRelatedField;
        }
        set {
            this.smartEnergyManagementPsRelatedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementDirectControlRelatedType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementHvacRelatedType {
    
    private uint overrunIdField;
    
    private bool overrunIdFieldSpecified;
    
    /// <remarks/>
    public uint overrunId {
        get {
            return this.overrunIdField;
        }
        set {
            this.overrunIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool overrunIdSpecified {
        get {
            return this.overrunIdFieldSpecified;
        }
        set {
            this.overrunIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementLoadControlReleatedType {
    
    private uint eventIdField;
    
    private bool eventIdFieldSpecified;
    
    /// <remarks/>
    public uint eventId {
        get {
            return this.eventIdField;
        }
        set {
            this.eventIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool eventIdSpecified {
        get {
            return this.eventIdFieldSpecified;
        }
        set {
            this.eventIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementPowerSequencesRelatedType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TaskManagementSmartEnergyManagementPsRelatedType {
    
    private uint sequenceIdField;
    
    private bool sequenceIdFieldSpecified;
    
    /// <remarks/>
    public uint sequenceId {
        get {
            return this.sequenceIdField;
        }
        set {
            this.sequenceIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sequenceIdSpecified {
        get {
            return this.sequenceIdFieldSpecified;
        }
        set {
            this.sequenceIdFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementOverviewData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementOverviewDataType {
    
    private bool remoteControllableField;
    
    private bool remoteControllableFieldSpecified;
    
    private bool jobsActiveField;
    
    private bool jobsActiveFieldSpecified;
    
    /// <remarks/>
    public bool remoteControllable {
        get {
            return this.remoteControllableField;
        }
        set {
            this.remoteControllableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool remoteControllableSpecified {
        get {
            return this.remoteControllableFieldSpecified;
        }
        set {
            this.remoteControllableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool jobsActive {
        get {
            return this.jobsActiveField;
        }
        set {
            this.jobsActiveField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool jobsActiveSpecified {
        get {
            return this.jobsActiveFieldSpecified;
        }
        set {
            this.jobsActiveFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdConstraintsDataType {
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    private ScaledNumberType thresholdRangeMinField;
    
    private ScaledNumberType thresholdRangeMaxField;
    
    private ScaledNumberType thresholdStepSizeField;
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType thresholdRangeMin {
        get {
            return this.thresholdRangeMinField;
        }
        set {
            this.thresholdRangeMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType thresholdRangeMax {
        get {
            return this.thresholdRangeMaxField;
        }
        set {
            this.thresholdRangeMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType thresholdStepSize {
        get {
            return this.thresholdStepSizeField;
        }
        set {
            this.thresholdStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdDescriptionDataType {
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    private string thresholdTypeField;
    
    private string unitField;
    
    private string scopeTypeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string thresholdType {
        get {
            return this.thresholdTypeField;
        }
        set {
            this.thresholdTypeField = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdDataType {
    
    private uint thresholdIdField;
    
    private bool thresholdIdFieldSpecified;
    
    private ScaledNumberType thresholdValueField;
    
    /// <remarks/>
    public uint thresholdId {
        get {
            return this.thresholdIdField;
        }
        set {
            this.thresholdIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool thresholdIdSpecified {
        get {
            return this.thresholdIdFieldSpecified;
        }
        set {
            this.thresholdIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType thresholdValue {
        get {
            return this.thresholdValueField;
        }
        set {
            this.thresholdValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierIncentiveRelationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierIncentiveRelationDataType {
    
    private uint tierIdField;
    
    private bool tierIdFieldSpecified;
    
    private uint[] incentiveIdField;
    
    /// <remarks/>
    public uint tierId {
        get {
            return this.tierIdField;
        }
        set {
            this.tierIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool tierIdSpecified {
        get {
            return this.tierIdFieldSpecified;
        }
        set {
            this.tierIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentiveId")]
    public uint[] incentiveId {
        get {
            return this.incentiveIdField;
        }
        set {
            this.incentiveIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeDistributorData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeDistributorDataType {
    
    private bool isTimeDistributorField;
    
    private bool isTimeDistributorFieldSpecified;
    
    private uint distributorPriorityField;
    
    private bool distributorPriorityFieldSpecified;
    
    /// <remarks/>
    public bool isTimeDistributor {
        get {
            return this.isTimeDistributorField;
        }
        set {
            this.isTimeDistributorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isTimeDistributorSpecified {
        get {
            return this.isTimeDistributorFieldSpecified;
        }
        set {
            this.isTimeDistributorFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint distributorPriority {
        get {
            return this.distributorPriorityField;
        }
        set {
            this.distributorPriorityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool distributorPrioritySpecified {
        get {
            return this.distributorPriorityFieldSpecified;
        }
        set {
            this.distributorPriorityFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeDistributorEnquiryCall", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeDistributorEnquiryCallType {
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeInformationData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeInformationDataType {
    
    private System.DateTime utcField;
    
    private bool utcFieldSpecified;
    
    private string utcOffsetField;
    
    private DayOfWeekType dayOfWeekField;
    
    private bool dayOfWeekFieldSpecified;
    
    private byte calendarWeekField;
    
    private bool calendarWeekFieldSpecified;
    
    /// <remarks/>
    public System.DateTime utc {
        get {
            return this.utcField;
        }
        set {
            this.utcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool utcSpecified {
        get {
            return this.utcFieldSpecified;
        }
        set {
            this.utcFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string utcOffset {
        get {
            return this.utcOffsetField;
        }
        set {
            this.utcOffsetField = value;
        }
    }
    
    /// <remarks/>
    public DayOfWeekType dayOfWeek {
        get {
            return this.dayOfWeekField;
        }
        set {
            this.dayOfWeekField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dayOfWeekSpecified {
        get {
            return this.dayOfWeekFieldSpecified;
        }
        set {
            this.dayOfWeekFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public byte calendarWeek {
        get {
            return this.calendarWeekField;
        }
        set {
            this.calendarWeekField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool calendarWeekSpecified {
        get {
            return this.calendarWeekFieldSpecified;
        }
        set {
            this.calendarWeekFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public enum DayOfWeekType {
    
    /// <remarks/>
    monday,
    
    /// <remarks/>
    tuesday,
    
    /// <remarks/>
    wednesday,
    
    /// <remarks/>
    thursday,
    
    /// <remarks/>
    friday,
    
    /// <remarks/>
    saturday,
    
    /// <remarks/>
    sunday,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timePrecisionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimePrecisionDataType {
    
    private bool isSynchronisedField;
    
    private bool isSynchronisedFieldSpecified;
    
    private System.DateTime lastSyncAtField;
    
    private bool lastSyncAtFieldSpecified;
    
    private string clockDriftField;
    
    /// <remarks/>
    public bool isSynchronised {
        get {
            return this.isSynchronisedField;
        }
        set {
            this.isSynchronisedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool isSynchronisedSpecified {
        get {
            return this.isSynchronisedFieldSpecified;
        }
        set {
            this.isSynchronisedFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime lastSyncAt {
        get {
            return this.lastSyncAtField;
        }
        set {
            this.lastSyncAtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lastSyncAtSpecified {
        get {
            return this.lastSyncAtFieldSpecified;
        }
        set {
            this.lastSyncAtFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string clockDrift {
        get {
            return this.clockDriftField;
        }
        set {
            this.clockDriftField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesConstraintsDataType {
    
    private uint timeSeriesIdField;
    
    private bool timeSeriesIdFieldSpecified;
    
    private uint slotCountMinField;
    
    private bool slotCountMinFieldSpecified;
    
    private uint slotCountMaxField;
    
    private bool slotCountMaxFieldSpecified;
    
    private string slotDurationMinField;
    
    private string slotDurationMaxField;
    
    private string slotDurationStepSizeField;
    
    private string earliestTimeSeriesStartTimeField;
    
    private string latestTimeSeriesEndTimeField;
    
    private ScaledNumberType slotValueMinField;
    
    private ScaledNumberType slotValueMaxField;
    
    private ScaledNumberType slotValueStepSizeField;
    
    /// <remarks/>
    public uint timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesIdSpecified {
        get {
            return this.timeSeriesIdFieldSpecified;
        }
        set {
            this.timeSeriesIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotCountMin {
        get {
            return this.slotCountMinField;
        }
        set {
            this.slotCountMinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotCountMinSpecified {
        get {
            return this.slotCountMinFieldSpecified;
        }
        set {
            this.slotCountMinFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint slotCountMax {
        get {
            return this.slotCountMaxField;
        }
        set {
            this.slotCountMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool slotCountMaxSpecified {
        get {
            return this.slotCountMaxFieldSpecified;
        }
        set {
            this.slotCountMaxFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string slotDurationMin {
        get {
            return this.slotDurationMinField;
        }
        set {
            this.slotDurationMinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string slotDurationMax {
        get {
            return this.slotDurationMaxField;
        }
        set {
            this.slotDurationMaxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string slotDurationStepSize {
        get {
            return this.slotDurationStepSizeField;
        }
        set {
            this.slotDurationStepSizeField = value;
        }
    }
    
    /// <remarks/>
    public string earliestTimeSeriesStartTime {
        get {
            return this.earliestTimeSeriesStartTimeField;
        }
        set {
            this.earliestTimeSeriesStartTimeField = value;
        }
    }
    
    /// <remarks/>
    public string latestTimeSeriesEndTime {
        get {
            return this.latestTimeSeriesEndTimeField;
        }
        set {
            this.latestTimeSeriesEndTimeField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType slotValueMin {
        get {
            return this.slotValueMinField;
        }
        set {
            this.slotValueMinField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType slotValueMax {
        get {
            return this.slotValueMaxField;
        }
        set {
            this.slotValueMaxField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType slotValueStepSize {
        get {
            return this.slotValueStepSizeField;
        }
        set {
            this.slotValueStepSizeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesDescriptionDataType {
    
    private uint timeSeriesIdField;
    
    private bool timeSeriesIdFieldSpecified;
    
    private string timeSeriesTypeField;
    
    private bool timeSeriesWriteableField;
    
    private bool timeSeriesWriteableFieldSpecified;
    
    private bool updateRequiredField;
    
    private bool updateRequiredFieldSpecified;
    
    private uint measurementIdField;
    
    private bool measurementIdFieldSpecified;
    
    private string currencyField;
    
    private string unitField;
    
    private string labelField;
    
    private string descriptionField;
    
    private string scopeTypeField;
    
    /// <remarks/>
    public uint timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesIdSpecified {
        get {
            return this.timeSeriesIdFieldSpecified;
        }
        set {
            this.timeSeriesIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string timeSeriesType {
        get {
            return this.timeSeriesTypeField;
        }
        set {
            this.timeSeriesTypeField = value;
        }
    }
    
    /// <remarks/>
    public bool timeSeriesWriteable {
        get {
            return this.timeSeriesWriteableField;
        }
        set {
            this.timeSeriesWriteableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesWriteableSpecified {
        get {
            return this.timeSeriesWriteableFieldSpecified;
        }
        set {
            this.timeSeriesWriteableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool updateRequired {
        get {
            return this.updateRequiredField;
        }
        set {
            this.updateRequiredField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool updateRequiredSpecified {
        get {
            return this.updateRequiredFieldSpecified;
        }
        set {
            this.updateRequiredFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public uint measurementId {
        get {
            return this.measurementIdField;
        }
        set {
            this.measurementIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool measurementIdSpecified {
        get {
            return this.measurementIdFieldSpecified;
        }
        set {
            this.measurementIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public string scopeType {
        get {
            return this.scopeTypeField;
        }
        set {
            this.scopeTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesDataType {
    
    private uint timeSeriesIdField;
    
    private bool timeSeriesIdFieldSpecified;
    
    private TimePeriodType timePeriodField;
    
    private TimeSeriesSlotType[] timeSeriesSlotField;
    
    /// <remarks/>
    public uint timeSeriesId {
        get {
            return this.timeSeriesIdField;
        }
        set {
            this.timeSeriesIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesIdSpecified {
        get {
            return this.timeSeriesIdFieldSpecified;
        }
        set {
            this.timeSeriesIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeSeriesSlot")]
    public TimeSeriesSlotType[] timeSeriesSlot {
        get {
            return this.timeSeriesSlotField;
        }
        set {
            this.timeSeriesSlotField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
public partial class TimeSeriesSlotType {
    
    private uint timeSeriesSlotIdField;
    
    private bool timeSeriesSlotIdFieldSpecified;
    
    private TimePeriodType timePeriodField;
    
    private string durationField;
    
    private AbsoluteOrRecurringTimeType recurrenceInformationField;
    
    private ScaledNumberType valueField;
    
    private ScaledNumberType minValueField;
    
    private ScaledNumberType maxValueField;
    
    /// <remarks/>
    public uint timeSeriesSlotId {
        get {
            return this.timeSeriesSlotIdField;
        }
        set {
            this.timeSeriesSlotIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSeriesSlotIdSpecified {
        get {
            return this.timeSeriesSlotIdFieldSpecified;
        }
        set {
            this.timeSeriesSlotIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TimePeriodType timePeriod {
        get {
            return this.timePeriodField;
        }
        set {
            this.timePeriodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
    public string duration {
        get {
            return this.durationField;
        }
        set {
            this.durationField = value;
        }
    }
    
    /// <remarks/>
    public AbsoluteOrRecurringTimeType recurrenceInformation {
        get {
            return this.recurrenceInformationField;
        }
        set {
            this.recurrenceInformationField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType minValue {
        get {
            return this.minValueField;
        }
        set {
            this.minValueField = value;
        }
    }
    
    /// <remarks/>
    public ScaledNumberType maxValue {
        get {
            return this.maxValueField;
        }
        set {
            this.maxValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableDescriptionDataType {
    
    private uint timeTableIdField;
    
    private bool timeTableIdFieldSpecified;
    
    private bool timeSlotCountChangeableField;
    
    private bool timeSlotCountChangeableFieldSpecified;
    
    private bool timeSlotTimesChangeableField;
    
    private bool timeSlotTimesChangeableFieldSpecified;
    
    private string timeSlotTimeModeField;
    
    private string labelField;
    
    private string descriptionField;
    
    /// <remarks/>
    public uint timeTableId {
        get {
            return this.timeTableIdField;
        }
        set {
            this.timeTableIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeTableIdSpecified {
        get {
            return this.timeTableIdFieldSpecified;
        }
        set {
            this.timeTableIdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool timeSlotCountChangeable {
        get {
            return this.timeSlotCountChangeableField;
        }
        set {
            this.timeSlotCountChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSlotCountChangeableSpecified {
        get {
            return this.timeSlotCountChangeableFieldSpecified;
        }
        set {
            this.timeSlotCountChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool timeSlotTimesChangeable {
        get {
            return this.timeSlotTimesChangeableField;
        }
        set {
            this.timeSlotTimesChangeableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool timeSlotTimesChangeableSpecified {
        get {
            return this.timeSlotTimesChangeableFieldSpecified;
        }
        set {
            this.timeSlotTimesChangeableFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string timeSlotTimeMode {
        get {
            return this.timeSlotTimeModeField;
        }
        set {
            this.timeSlotTimeModeField = value;
        }
    }
    
    /// <remarks/>
    public string label {
        get {
            return this.labelField;
        }
        set {
            this.labelField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdListDataType {
    
    private ThresholdDataType[] thresholdDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("thresholdData")]
    public ThresholdDataType[] thresholdData {
        get {
            return this.thresholdDataField;
        }
        set {
            this.thresholdDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdConstraintsListDataType {
    
    private ThresholdConstraintsDataType[] thresholdConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("thresholdConstraintsData")]
    public ThresholdConstraintsDataType[] thresholdConstraintsData {
        get {
            return this.thresholdConstraintsDataField;
        }
        set {
            this.thresholdConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("thresholdDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ThresholdDescriptionListDataType {
    
    private ThresholdDescriptionDataType[] thresholdDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("thresholdDescriptionData")]
    public ThresholdDescriptionDataType[] thresholdDescriptionData {
        get {
            return this.thresholdDescriptionDataField;
        }
        set {
            this.thresholdDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("alarmListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class AlarmListDataType {
    
    private AlarmDataType[] alarmDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("alarmData")]
    public AlarmDataType[] alarmData {
        get {
            return this.alarmDataField;
        }
        set {
            this.alarmDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillListDataType {
    
    private BillDataType[] billDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("billData")]
    public BillDataType[] billData {
        get {
            return this.billDataField;
        }
        set {
            this.billDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillConstraintsListDataType {
    
    private BillConstraintsDataType[] billConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("billConstraintsData")]
    public BillConstraintsDataType[] billConstraintsData {
        get {
            return this.billConstraintsDataField;
        }
        set {
            this.billConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("billDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BillDescriptionListDataType {
    
    private BillDescriptionDataType[] billDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("billDescriptionData")]
    public BillDescriptionDataType[] billDescriptionData {
        get {
            return this.billDescriptionDataField;
        }
        set {
            this.billDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("bindingManagementEntryListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class BindingManagementEntryListDataType {
    
    private BindingManagementEntryDataType[] bindingManagementEntryDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bindingManagementEntryData")]
    public BindingManagementEntryDataType[] bindingManagementEntryData {
        get {
            return this.bindingManagementEntryDataField;
        }
        set {
            this.bindingManagementEntryDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueListDataType {
    
    private DeviceConfigurationKeyValueDataType[] deviceConfigurationKeyValueDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("deviceConfigurationKeyValueData")]
    public DeviceConfigurationKeyValueDataType[] deviceConfigurationKeyValueData {
        get {
            return this.deviceConfigurationKeyValueDataField;
        }
        set {
            this.deviceConfigurationKeyValueDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueDescriptionListDataType {
    
    private DeviceConfigurationKeyValueDescriptionDataType[] deviceConfigurationKeyValueDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("deviceConfigurationKeyValueDescriptionData")]
    public DeviceConfigurationKeyValueDescriptionDataType[] deviceConfigurationKeyValueDescriptionData {
        get {
            return this.deviceConfigurationKeyValueDescriptionDataField;
        }
        set {
            this.deviceConfigurationKeyValueDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("deviceConfigurationKeyValueConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DeviceConfigurationKeyValueConstraintsListDataType {
    
    private DeviceConfigurationKeyValueConstraintsDataType[] deviceConfigurationKeyValueConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("deviceConfigurationKeyValueConstraintsData")]
    public DeviceConfigurationKeyValueConstraintsDataType[] deviceConfigurationKeyValueConstraintsData {
        get {
            return this.deviceConfigurationKeyValueConstraintsDataField;
        }
        set {
            this.deviceConfigurationKeyValueConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementListDataType {
    
    private MeasurementDataType[] measurementDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("measurementData")]
    public MeasurementDataType[] measurementData {
        get {
            return this.measurementDataField;
        }
        set {
            this.measurementDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementConstraintsListDataType {
    
    private MeasurementConstraintsDataType[] measurementConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("measurementConstraintsData")]
    public MeasurementConstraintsDataType[] measurementConstraintsData {
        get {
            return this.measurementConstraintsDataField;
        }
        set {
            this.measurementConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementDescriptionListDataType {
    
    private MeasurementDescriptionDataType[] measurementDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("measurementDescriptionData")]
    public MeasurementDescriptionDataType[] measurementDescriptionData {
        get {
            return this.measurementDescriptionDataField;
        }
        set {
            this.measurementDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("measurementThresholdRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MeasurementThresholdRelationListDataType {
    
    private MeasurementThresholdRelationDataType[] measurementThresholdRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("measurementThresholdRelationData")]
    public MeasurementThresholdRelationDataType[] measurementThresholdRelationData {
        get {
            return this.measurementThresholdRelationDataField;
        }
        set {
            this.measurementThresholdRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotScheduleListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotScheduleListDataType {
    
    private PowerTimeSlotScheduleDataType[] powerTimeSlotScheduleDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerTimeSlotScheduleData")]
    public PowerTimeSlotScheduleDataType[] powerTimeSlotScheduleData {
        get {
            return this.powerTimeSlotScheduleDataField;
        }
        set {
            this.powerTimeSlotScheduleDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotValueListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotValueListDataType {
    
    private PowerTimeSlotValueDataType[] powerTimeSlotValueDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerTimeSlotValueData")]
    public PowerTimeSlotValueDataType[] powerTimeSlotValueData {
        get {
            return this.powerTimeSlotValueDataField;
        }
        set {
            this.powerTimeSlotValueDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerTimeSlotScheduleConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerTimeSlotScheduleConstraintsListDataType {
    
    private PowerTimeSlotScheduleConstraintsDataType[] powerTimeSlotScheduleConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerTimeSlotScheduleConstraintsData")]
    public PowerTimeSlotScheduleConstraintsDataType[] powerTimeSlotScheduleConstraintsData {
        get {
            return this.powerTimeSlotScheduleConstraintsDataField;
        }
        set {
            this.powerTimeSlotScheduleConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceAlternativesRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceAlternativesRelationListDataType {
    
    private PowerSequenceAlternativesRelationDataType[] powerSequenceAlternativesRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerSequenceAlternativesRelationData")]
    public PowerSequenceAlternativesRelationDataType[] powerSequenceAlternativesRelationData {
        get {
            return this.powerSequenceAlternativesRelationDataField;
        }
        set {
            this.powerSequenceAlternativesRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceDescriptionListDataType {
    
    private PowerSequenceDescriptionDataType[] powerSequenceDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerSequenceDescriptionData")]
    public PowerSequenceDescriptionDataType[] powerSequenceDescriptionData {
        get {
            return this.powerSequenceDescriptionDataField;
        }
        set {
            this.powerSequenceDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceStateListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceStateListDataType {
    
    private PowerSequenceStateDataType[] powerSequenceStateDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerSequenceStateData")]
    public PowerSequenceStateDataType[] powerSequenceStateData {
        get {
            return this.powerSequenceStateDataField;
        }
        set {
            this.powerSequenceStateDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleListDataType {
    
    private PowerSequenceScheduleDataType[] powerSequenceScheduleDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerSequenceScheduleData")]
    public PowerSequenceScheduleDataType[] powerSequenceScheduleData {
        get {
            return this.powerSequenceScheduleDataField;
        }
        set {
            this.powerSequenceScheduleDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceScheduleConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceScheduleConstraintsListDataType {
    
    private PowerSequenceScheduleConstraintsDataType[] powerSequenceScheduleConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerSequenceScheduleConstraintsData")]
    public PowerSequenceScheduleConstraintsDataType[] powerSequenceScheduleConstraintsData {
        get {
            return this.powerSequenceScheduleConstraintsDataField;
        }
        set {
            this.powerSequenceScheduleConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequencePriceListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequencePriceListDataType {
    
    private PowerSequencePriceDataType[] powerSequencePriceDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerSequencePriceData")]
    public PowerSequencePriceDataType[] powerSequencePriceData {
        get {
            return this.powerSequencePriceDataField;
        }
        set {
            this.powerSequencePriceDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("powerSequenceSchedulePreferenceListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PowerSequenceSchedulePreferenceListDataType {
    
    private PowerSequenceSchedulePreferenceDataType[] powerSequenceSchedulePreferenceDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("powerSequenceSchedulePreferenceData")]
    public PowerSequenceSchedulePreferenceDataType[] powerSequenceSchedulePreferenceData {
        get {
            return this.powerSequenceSchedulePreferenceDataField;
        }
        set {
            this.powerSequenceSchedulePreferenceDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("directControlActivityListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DirectControlActivityListDataType {
    
    private DirectControlActivityDataType[] directControlActivityDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("directControlActivityData")]
    public DirectControlActivityDataType[] directControlActivityData {
        get {
            return this.directControlActivityDataField;
        }
        set {
            this.directControlActivityDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionParameterDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionParameterDescriptionListDataType {
    
    private ElectricalConnectionParameterDescriptionDataType[] electricalConnectionParameterDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("electricalConnectionParameterDescriptionData")]
    public ElectricalConnectionParameterDescriptionDataType[] electricalConnectionParameterDescriptionData {
        get {
            return this.electricalConnectionParameterDescriptionDataField;
        }
        set {
            this.electricalConnectionParameterDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionPermittedValueSetListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionPermittedValueSetListDataType {
    
    private ElectricalConnectionPermittedValueSetDataType[] electricalConnectionPermittedValueSetDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("electricalConnectionPermittedValueSetData")]
    public ElectricalConnectionPermittedValueSetDataType[] electricalConnectionPermittedValueSetData {
        get {
            return this.electricalConnectionPermittedValueSetDataField;
        }
        set {
            this.electricalConnectionPermittedValueSetDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionStateListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionStateListDataType {
    
    private ElectricalConnectionStateDataType[] electricalConnectionStateDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("electricalConnectionStateData")]
    public ElectricalConnectionStateDataType[] electricalConnectionStateData {
        get {
            return this.electricalConnectionStateDataField;
        }
        set {
            this.electricalConnectionStateDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("electricalConnectionDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class ElectricalConnectionDescriptionListDataType {
    
    private ElectricalConnectionDescriptionDataType[] electricalConnectionDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("electricalConnectionDescriptionData")]
    public ElectricalConnectionDescriptionDataType[] electricalConnectionDescriptionData {
        get {
            return this.electricalConnectionDescriptionDataField;
        }
        set {
            this.electricalConnectionDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableListDataType {
    
    private TimeTableDataType[] timeTableDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeTableData")]
    public TimeTableDataType[] timeTableData {
        get {
            return this.timeTableDataField;
        }
        set {
            this.timeTableDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableConstraintsListDataType {
    
    private TimeTableConstraintsDataType[] timeTableConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeTableConstraintsData")]
    public TimeTableConstraintsDataType[] timeTableConstraintsData {
        get {
            return this.timeTableConstraintsDataField;
        }
        set {
            this.timeTableConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeTableDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeTableDescriptionListDataType {
    
    private TimeTableDescriptionDataType[] timeTableDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeTableDescriptionData")]
    public TimeTableDescriptionDataType[] timeTableDescriptionData {
        get {
            return this.timeTableDescriptionDataField;
        }
        set {
            this.timeTableDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointListDataType {
    
    private SetpointDataType[] setpointDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("setpointData")]
    public SetpointDataType[] setpointData {
        get {
            return this.setpointDataField;
        }
        set {
            this.setpointDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointConstraintsListDataType {
    
    private SetpointConstraintsDataType[] setpointConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("setpointConstraintsData")]
    public SetpointConstraintsDataType[] setpointConstraintsData {
        get {
            return this.setpointConstraintsDataField;
        }
        set {
            this.setpointConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("setpointDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SetpointDescriptionListDataType {
    
    private SetpointDescriptionDataType[] setpointDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("setpointDescriptionData")]
    public SetpointDescriptionDataType[] setpointDescriptionData {
        get {
            return this.setpointDescriptionDataField;
        }
        set {
            this.setpointDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionListDataType {
    
    private HvacSystemFunctionDataType[] hvacSystemFunctionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hvacSystemFunctionData")]
    public HvacSystemFunctionDataType[] hvacSystemFunctionData {
        get {
            return this.hvacSystemFunctionDataField;
        }
        set {
            this.hvacSystemFunctionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionOperationModeRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionOperationModeRelationListDataType {
    
    private HvacSystemFunctionOperationModeRelationDataType[] hvacSystemFunctionOperationModeRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hvacSystemFunctionOperationModeRelationData")]
    public HvacSystemFunctionOperationModeRelationDataType[] hvacSystemFunctionOperationModeRelationData {
        get {
            return this.hvacSystemFunctionOperationModeRelationDataField;
        }
        set {
            this.hvacSystemFunctionOperationModeRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionSetpointRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionSetpointRelationListDataType {
    
    private HvacSystemFunctionSetpointRelationDataType[] hvacSystemFunctionSetpointRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hvacSystemFunctionSetpointRelationData")]
    public HvacSystemFunctionSetpointRelationDataType[] hvacSystemFunctionSetpointRelationData {
        get {
            return this.hvacSystemFunctionSetpointRelationDataField;
        }
        set {
            this.hvacSystemFunctionSetpointRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionPowerSequenceRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionPowerSequenceRelationListDataType {
    
    private HvacSystemFunctionPowerSequenceRelationDataType[] hvacSystemFunctionPowerSequenceRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hvacSystemFunctionPowerSequenceRelationData")]
    public HvacSystemFunctionPowerSequenceRelationDataType[] hvacSystemFunctionPowerSequenceRelationData {
        get {
            return this.hvacSystemFunctionPowerSequenceRelationDataField;
        }
        set {
            this.hvacSystemFunctionPowerSequenceRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacSystemFunctionDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacSystemFunctionDescriptionListDataType {
    
    private HvacSystemFunctionDescriptionDataType[] hvacSystemFunctionDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hvacSystemFunctionDescriptionData")]
    public HvacSystemFunctionDescriptionDataType[] hvacSystemFunctionDescriptionData {
        get {
            return this.hvacSystemFunctionDescriptionDataField;
        }
        set {
            this.hvacSystemFunctionDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOperationModeDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOperationModeDescriptionListDataType {
    
    private HvacOperationModeDescriptionDataType[] hvacOperationModeDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hvacOperationModeDescriptionData")]
    public HvacOperationModeDescriptionDataType[] hvacOperationModeDescriptionData {
        get {
            return this.hvacOperationModeDescriptionDataField;
        }
        set {
            this.hvacOperationModeDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOverrunListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOverrunListDataType {
    
    private HvacOverrunDataType[] hvacOverrunDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hvacOverrunData")]
    public HvacOverrunDataType[] hvacOverrunData {
        get {
            return this.hvacOverrunDataField;
        }
        set {
            this.hvacOverrunDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("hvacOverrunDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class HvacOverrunDescriptionListDataType {
    
    private HvacOverrunDescriptionDataType[] hvacOverrunDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("hvacOverrunDescriptionData")]
    public HvacOverrunDescriptionDataType[] hvacOverrunDescriptionData {
        get {
            return this.hvacOverrunDescriptionDataField;
        }
        set {
            this.hvacOverrunDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("identificationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IdentificationListDataType {
    
    private IdentificationDataType[] identificationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("identificationData")]
    public IdentificationDataType[] identificationData {
        get {
            return this.identificationDataField;
        }
        set {
            this.identificationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffListDataType {
    
    private TariffDataType[] tariffDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tariffData")]
    public TariffDataType[] tariffData {
        get {
            return this.tariffDataField;
        }
        set {
            this.tariffDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffTierRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffTierRelationListDataType {
    
    private TariffTierRelationDataType[] tariffTierRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tariffTierRelationData")]
    public TariffTierRelationDataType[] tariffTierRelationData {
        get {
            return this.tariffTierRelationDataField;
        }
        set {
            this.tariffTierRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffBoundaryRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffBoundaryRelationListDataType {
    
    private TariffBoundaryRelationDataType[] tariffBoundaryRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tariffBoundaryRelationData")]
    public TariffBoundaryRelationDataType[] tariffBoundaryRelationData {
        get {
            return this.tariffBoundaryRelationDataField;
        }
        set {
            this.tariffBoundaryRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tariffDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TariffDescriptionListDataType {
    
    private TariffDescriptionDataType[] tariffDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tariffDescriptionData")]
    public TariffDescriptionDataType[] tariffDescriptionData {
        get {
            return this.tariffDescriptionDataField;
        }
        set {
            this.tariffDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierBoundaryListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierBoundaryListDataType {
    
    private TierBoundaryDataType[] tierBoundaryDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tierBoundaryData")]
    public TierBoundaryDataType[] tierBoundaryData {
        get {
            return this.tierBoundaryDataField;
        }
        set {
            this.tierBoundaryDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierBoundaryDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierBoundaryDescriptionListDataType {
    
    private TierBoundaryDescriptionDataType[] tierBoundaryDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tierBoundaryDescriptionData")]
    public TierBoundaryDescriptionDataType[] tierBoundaryDescriptionData {
        get {
            return this.tierBoundaryDescriptionDataField;
        }
        set {
            this.tierBoundaryDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("commodityListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class CommodityListDataType {
    
    private CommodityDataType[] commodityDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("commodityData")]
    public CommodityDataType[] commodityData {
        get {
            return this.commodityDataField;
        }
        set {
            this.commodityDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierListDataType {
    
    private TierDataType[] tierDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tierData")]
    public TierDataType[] tierData {
        get {
            return this.tierDataField;
        }
        set {
            this.tierDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierIncentiveRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierIncentiveRelationListDataType {
    
    private TierIncentiveRelationDataType[] tierIncentiveRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tierIncentiveRelationData")]
    public TierIncentiveRelationDataType[] tierIncentiveRelationData {
        get {
            return this.tierIncentiveRelationDataField;
        }
        set {
            this.tierIncentiveRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("tierDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TierDescriptionListDataType {
    
    private TierDescriptionDataType[] tierDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tierDescriptionData")]
    public TierDescriptionDataType[] tierDescriptionData {
        get {
            return this.tierDescriptionDataField;
        }
        set {
            this.tierDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveListDataType {
    
    private IncentiveDataType[] incentiveDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentiveData")]
    public IncentiveDataType[] incentiveData {
        get {
            return this.incentiveDataField;
        }
        set {
            this.incentiveDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveDescriptionListDataType {
    
    private IncentiveDescriptionDataType[] incentiveDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentiveDescriptionData")]
    public IncentiveDescriptionDataType[] incentiveDescriptionData {
        get {
            return this.incentiveDescriptionDataField;
        }
        set {
            this.incentiveDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableDataType {
    
    private IncentiveTableType[] incentiveTableField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentiveTable")]
    public IncentiveTableType[] incentiveTable {
        get {
            return this.incentiveTableField;
        }
        set {
            this.incentiveTableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableDescriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableDescriptionDataType {
    
    private IncentiveTableDescriptionType[] incentiveTableDescriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentiveTableDescription")]
    public IncentiveTableDescriptionType[] incentiveTableDescription {
        get {
            return this.incentiveTableDescriptionField;
        }
        set {
            this.incentiveTableDescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("incentiveTableConstraintsData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class IncentiveTableConstraintsDataType {
    
    private IncentiveTableConstraintsType[] incentiveTableConstraintsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("incentiveTableConstraints")]
    public IncentiveTableConstraintsType[] incentiveTableConstraints {
        get {
            return this.incentiveTableConstraintsField;
        }
        set {
            this.incentiveTableConstraintsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlEventListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlEventListDataType {
    
    private LoadControlEventDataType[] loadControlEventDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("loadControlEventData")]
    public LoadControlEventDataType[] loadControlEventData {
        get {
            return this.loadControlEventDataField;
        }
        set {
            this.loadControlEventDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlStateListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlStateListDataType {
    
    private LoadControlStateDataType[] loadControlStateDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("loadControlStateData")]
    public LoadControlStateDataType[] loadControlStateData {
        get {
            return this.loadControlStateDataField;
        }
        set {
            this.loadControlStateDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitListDataType {
    
    private LoadControlLimitDataType[] loadControlLimitDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("loadControlLimitData")]
    public LoadControlLimitDataType[] loadControlLimitData {
        get {
            return this.loadControlLimitDataField;
        }
        set {
            this.loadControlLimitDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitConstraintsListDataType {
    
    private LoadControlLimitConstraintsDataType[] loadControlLimitConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("loadControlLimitConstraintsData")]
    public LoadControlLimitConstraintsDataType[] loadControlLimitConstraintsData {
        get {
            return this.loadControlLimitConstraintsDataField;
        }
        set {
            this.loadControlLimitConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("loadControlLimitDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class LoadControlLimitDescriptionListDataType {
    
    private LoadControlLimitDescriptionDataType[] loadControlLimitDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("loadControlLimitDescriptionData")]
    public LoadControlLimitDescriptionDataType[] loadControlLimitDescriptionData {
        get {
            return this.loadControlLimitDescriptionDataField;
        }
        set {
            this.loadControlLimitDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("messagingListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class MessagingListDataType {
    
    private MessagingDataType[] messagingDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("messagingData")]
    public MessagingDataType[] messagingData {
        get {
            return this.messagingDataField;
        }
        set {
            this.messagingDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementDeviceDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementDeviceDescriptionListDataType {
    
    private NetworkManagementDeviceDescriptionDataType[] networkManagementDeviceDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("networkManagementDeviceDescriptionData")]
    public NetworkManagementDeviceDescriptionDataType[] networkManagementDeviceDescriptionData {
        get {
            return this.networkManagementDeviceDescriptionDataField;
        }
        set {
            this.networkManagementDeviceDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementEntityDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementEntityDescriptionListDataType {
    
    private NetworkManagementEntityDescriptionDataType[] networkManagementEntityDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("networkManagementEntityDescriptionData")]
    public NetworkManagementEntityDescriptionDataType[] networkManagementEntityDescriptionData {
        get {
            return this.networkManagementEntityDescriptionDataField;
        }
        set {
            this.networkManagementEntityDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("networkManagementFeatureDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NetworkManagementFeatureDescriptionListDataType {
    
    private NetworkManagementFeatureDescriptionDataType[] networkManagementFeatureDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("networkManagementFeatureDescriptionData")]
    public NetworkManagementFeatureDescriptionDataType[] networkManagementFeatureDescriptionData {
        get {
            return this.networkManagementFeatureDescriptionDataField;
        }
        set {
            this.networkManagementFeatureDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("subscriptionManagementEntryListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SubscriptionManagementEntryListDataType {
    
    private SubscriptionManagementEntryDataType[] subscriptionManagementEntryDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("subscriptionManagementEntryData")]
    public SubscriptionManagementEntryDataType[] subscriptionManagementEntryData {
        get {
            return this.subscriptionManagementEntryDataField;
        }
        set {
            this.subscriptionManagementEntryDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("specificationVersionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SpecificationVersionListDataType {
    
    private SpecificationVersionDataType[] specificationVersionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("specificationVersionData")]
    public SpecificationVersionDataType[] specificationVersionData {
        get {
            return this.specificationVersionDataField;
        }
        set {
            this.specificationVersionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("useCaseInformationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class UseCaseInformationListDataType {
    
    private UseCaseInformationDataType[] useCaseInformationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("useCaseInformationData")]
    public UseCaseInformationDataType[] useCaseInformationData {
        get {
            return this.useCaseInformationDataField;
        }
        set {
            this.useCaseInformationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementBindingData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementBindingDataType {
    
    private NodeManagementBindingDataTypeBindingEntry[] bindingEntryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("bindingEntry")]
    public NodeManagementBindingDataTypeBindingEntry[] bindingEntry {
        get {
            return this.bindingEntryField;
        }
        set {
            this.bindingEntryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementSubscriptionData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementSubscriptionDataType {
    
    private NodeManagementSubscriptionDataTypeSubscriptionEntry[] subscriptionEntryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("subscriptionEntry")]
    public NodeManagementSubscriptionDataTypeSubscriptionEntry[] subscriptionEntry {
        get {
            return this.subscriptionEntryField;
        }
        set {
            this.subscriptionEntryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementDestinationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementDestinationListDataType {
    
    private NodeManagementDestinationDataType[] nodeManagementDestinationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("nodeManagementDestinationData")]
    public NodeManagementDestinationDataType[] nodeManagementDestinationData {
        get {
            return this.nodeManagementDestinationDataField;
        }
        set {
            this.nodeManagementDestinationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("nodeManagementUseCaseData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class NodeManagementUseCaseDataType {
    
    private NodeManagementUseCaseDataTypeUseCaseInformation[] useCaseInformationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("useCaseInformation")]
    public NodeManagementUseCaseDataTypeUseCaseInformation[] useCaseInformation {
        get {
            return this.useCaseInformationField;
        }
        set {
            this.useCaseInformationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsInterruptListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsInterruptListDataType {
    
    private OperatingConstraintsInterruptDataType[] operatingConstraintsInterruptDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operatingConstraintsInterruptData")]
    public OperatingConstraintsInterruptDataType[] operatingConstraintsInterruptData {
        get {
            return this.operatingConstraintsInterruptDataField;
        }
        set {
            this.operatingConstraintsInterruptDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsDurationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsDurationListDataType {
    
    private OperatingConstraintsDurationDataType[] operatingConstraintsDurationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operatingConstraintsDurationData")]
    public OperatingConstraintsDurationDataType[] operatingConstraintsDurationData {
        get {
            return this.operatingConstraintsDurationDataField;
        }
        set {
            this.operatingConstraintsDurationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerDescriptionListDataType {
    
    private OperatingConstraintsPowerDescriptionDataType[] operatingConstraintsPowerDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operatingConstraintsPowerDescriptionData")]
    public OperatingConstraintsPowerDescriptionDataType[] operatingConstraintsPowerDescriptionData {
        get {
            return this.operatingConstraintsPowerDescriptionDataField;
        }
        set {
            this.operatingConstraintsPowerDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerRangeListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerRangeListDataType {
    
    private OperatingConstraintsPowerRangeDataType[] operatingConstraintsPowerRangeDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operatingConstraintsPowerRangeData")]
    public OperatingConstraintsPowerRangeDataType[] operatingConstraintsPowerRangeData {
        get {
            return this.operatingConstraintsPowerRangeDataField;
        }
        set {
            this.operatingConstraintsPowerRangeDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsPowerLevelListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsPowerLevelListDataType {
    
    private OperatingConstraintsPowerLevelDataType[] operatingConstraintsPowerLevelDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operatingConstraintsPowerLevelData")]
    public OperatingConstraintsPowerLevelDataType[] operatingConstraintsPowerLevelData {
        get {
            return this.operatingConstraintsPowerLevelDataField;
        }
        set {
            this.operatingConstraintsPowerLevelDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("operatingConstraintsResumeImplicationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class OperatingConstraintsResumeImplicationListDataType {
    
    private OperatingConstraintsResumeImplicationDataType[] operatingConstraintsResumeImplicationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operatingConstraintsResumeImplicationData")]
    public OperatingConstraintsResumeImplicationDataType[] operatingConstraintsResumeImplicationData {
        get {
            return this.operatingConstraintsResumeImplicationDataField;
        }
        set {
            this.operatingConstraintsResumeImplicationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("sensingListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SensingListDataType {
    
    private SensingDataType[] sensingDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sensingData")]
    public SensingDataType[] sensingData {
        get {
            return this.sensingDataField;
        }
        set {
            this.sensingDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("smartEnergyManagementPsPriceData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SmartEnergyManagementPsPriceDataType {
    
    private SmartEnergyManagementPsPriceDataTypePrice[] priceField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("price")]
    public SmartEnergyManagementPsPriceDataTypePrice[] price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionListDataType {
    
    private SupplyConditionDataType[] supplyConditionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("supplyConditionData")]
    public SupplyConditionDataType[] supplyConditionData {
        get {
            return this.supplyConditionDataField;
        }
        set {
            this.supplyConditionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionDescriptionListDataType {
    
    private SupplyConditionDescriptionDataType[] supplyConditionDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("supplyConditionDescriptionData")]
    public SupplyConditionDescriptionDataType[] supplyConditionDescriptionData {
        get {
            return this.supplyConditionDescriptionDataField;
        }
        set {
            this.supplyConditionDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("supplyConditionThresholdRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SupplyConditionThresholdRelationListDataType {
    
    private SupplyConditionThresholdRelationDataType[] supplyConditionThresholdRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("supplyConditionThresholdRelationData")]
    public SupplyConditionThresholdRelationDataType[] supplyConditionThresholdRelationData {
        get {
            return this.supplyConditionThresholdRelationDataField;
        }
        set {
            this.supplyConditionThresholdRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobListDataType {
    
    private TaskManagementJobDataType[] taskManagementJobDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("taskManagementJobData")]
    public TaskManagementJobDataType[] taskManagementJobData {
        get {
            return this.taskManagementJobDataField;
        }
        set {
            this.taskManagementJobDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobRelationListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobRelationListDataType {
    
    private TaskManagementJobRelationDataType[] taskManagementJobRelationDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("taskManagementJobRelationData")]
    public TaskManagementJobRelationDataType[] taskManagementJobRelationData {
        get {
            return this.taskManagementJobRelationDataField;
        }
        set {
            this.taskManagementJobRelationDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("taskManagementJobDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TaskManagementJobDescriptionListDataType {
    
    private TaskManagementJobDescriptionDataType[] taskManagementJobDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("taskManagementJobDescriptionData")]
    public TaskManagementJobDescriptionDataType[] taskManagementJobDescriptionData {
        get {
            return this.taskManagementJobDescriptionDataField;
        }
        set {
            this.taskManagementJobDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesListDataType {
    
    private TimeSeriesDataType[] timeSeriesDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeSeriesData")]
    public TimeSeriesDataType[] timeSeriesData {
        get {
            return this.timeSeriesDataField;
        }
        set {
            this.timeSeriesDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesDescriptionListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesDescriptionListDataType {
    
    private TimeSeriesDescriptionDataType[] timeSeriesDescriptionDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeSeriesDescriptionData")]
    public TimeSeriesDescriptionDataType[] timeSeriesDescriptionData {
        get {
            return this.timeSeriesDescriptionDataField;
        }
        set {
            this.timeSeriesDescriptionDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("timeSeriesConstraintsListData", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class TimeSeriesConstraintsListDataType {
    
    private TimeSeriesConstraintsDataType[] timeSeriesConstraintsDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("timeSeriesConstraintsData")]
    public TimeSeriesConstraintsDataType[] timeSeriesConstraintsData {
        get {
            return this.timeSeriesConstraintsDataField;
        }
        set {
            this.timeSeriesConstraintsDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("cmdClassifier", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public enum CmdClassifierType {
    
    /// <remarks/>
    read,
    
    /// <remarks/>
    reply,
    
    /// <remarks/>
    notify,
    
    /// <remarks/>
    write,
    
    /// <remarks/>
    call,
    
    /// <remarks/>
    result,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("header", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class SpineHeaderType {
    
    private string specificationVersionField;
    
    private FeatureAddressType addressSourceField;
    
    private FeatureAddressType addressDestinationField;
    
    private FeatureAddressType addressOriginatorField;
    
    private ulong msgCounterField;
    
    private bool msgCounterFieldSpecified;
    
    private ulong msgCounterReferenceField;
    
    private bool msgCounterReferenceFieldSpecified;
    
    private CmdClassifierType cmdClassifierField;
    
    private bool cmdClassifierFieldSpecified;
    
    private bool ackRequestField;
    
    private bool ackRequestFieldSpecified;
    
    private string timestampField;
    
    /// <remarks/>
    public string specificationVersion {
        get {
            return this.specificationVersionField;
        }
        set {
            this.specificationVersionField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType addressSource {
        get {
            return this.addressSourceField;
        }
        set {
            this.addressSourceField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType addressDestination {
        get {
            return this.addressDestinationField;
        }
        set {
            this.addressDestinationField = value;
        }
    }
    
    /// <remarks/>
    public FeatureAddressType addressOriginator {
        get {
            return this.addressOriginatorField;
        }
        set {
            this.addressOriginatorField = value;
        }
    }
    
    /// <remarks/>
    public ulong msgCounter {
        get {
            return this.msgCounterField;
        }
        set {
            this.msgCounterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool msgCounterSpecified {
        get {
            return this.msgCounterFieldSpecified;
        }
        set {
            this.msgCounterFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ulong msgCounterReference {
        get {
            return this.msgCounterReferenceField;
        }
        set {
            this.msgCounterReferenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool msgCounterReferenceSpecified {
        get {
            return this.msgCounterReferenceFieldSpecified;
        }
        set {
            this.msgCounterReferenceFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public CmdClassifierType cmdClassifier {
        get {
            return this.cmdClassifierField;
        }
        set {
            this.cmdClassifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cmdClassifierSpecified {
        get {
            return this.cmdClassifierFieldSpecified;
        }
        set {
            this.cmdClassifierFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public bool ackRequest {
        get {
            return this.ackRequestField;
        }
        set {
            this.ackRequestField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ackRequestSpecified {
        get {
            return this.ackRequestFieldSpecified;
        }
        set {
            this.ackRequestFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string timestamp {
        get {
            return this.timestampField;
        }
        set {
            this.timestampField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("payload", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class PayloadType {
    
    private CmdType[] cmdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cmd")]
    public CmdType[] cmd {
        get {
            return this.cmdField;
        }
        set {
            this.cmdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://docs.eebus.org/spine/xsd/v1")]
[System.Xml.Serialization.XmlRootAttribute("datagram", Namespace="http://docs.eebus.org/spine/xsd/v1", IsNullable=false)]
public partial class DatagramType {
    
    private SpineHeaderType headerField;
    
    private CmdType[] payloadField;
    
    /// <remarks/>
    public SpineHeaderType header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("cmd", IsNullable=false)]
    public CmdType[] payload {
        get {
            return this.payloadField;
        }
        set {
            this.payloadField = value;
        }
    }
}
*/