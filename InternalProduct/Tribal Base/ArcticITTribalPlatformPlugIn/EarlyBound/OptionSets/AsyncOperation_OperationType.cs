// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.AsyncOperation_OperationType
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.OptionSets
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public enum AsyncOperation_OperationType
  {
    [EnumMember] SystemEvent = 1,
    [EnumMember] BulkEmail = 2,
    [EnumMember] ImportFileParse = 3,
    [EnumMember] TransformParseData = 4,
    [EnumMember] Import = 5,
    [EnumMember] ActivityPropagation = 6,
    [EnumMember] DuplicateDetectionRulePublish = 7,
    [EnumMember] BulkDuplicateDetection = 8,
    [EnumMember] SQMDataCollection = 9,
    [EnumMember] Workflow = 10, // 0x0000000A
    [EnumMember] QuickCampaign = 11, // 0x0000000B
    [EnumMember] MatchcodeUpdate = 12, // 0x0000000C
    [EnumMember] BulkDelete = 13, // 0x0000000D
    [EnumMember] DeletionService = 14, // 0x0000000E
    [EnumMember] IndexManagement = 15, // 0x0000000F
    [EnumMember] CollectOrganizationStatistics = 16, // 0x00000010
    [EnumMember] ImportSubprocess = 17, // 0x00000011
    [EnumMember] CalculateOrganizationStorageSize = 18, // 0x00000012
    [EnumMember] CollectOrganizationDatabaseStatistics = 19, // 0x00000013
    [EnumMember] CollectionOrganizationSizeStatistics = 20, // 0x00000014
    [EnumMember] DatabaseTuning = 21, // 0x00000015
    [EnumMember] CalculateOrganizationMaximumStorageSize = 22, // 0x00000016
    [EnumMember] BulkDeleteSubprocess = 23, // 0x00000017
    [EnumMember] UpdateStatisticIntervals = 24, // 0x00000018
    [EnumMember] OrganizationFullTextCatalogIndex = 25, // 0x00000019
    [EnumMember] Databaselogbackup = 26, // 0x0000001A
    [EnumMember] UpdateContractStates = 27, // 0x0000001B
    [EnumMember] DBCCSHRINKDATABASEmaintenancejob = 28, // 0x0000001C
    [EnumMember] DBCCSHRINKFILEmaintenancejob = 29, // 0x0000001D
    [EnumMember] Reindexallindicesmaintenancejob = 30, // 0x0000001E
    [EnumMember] StorageLimitNotification = 31, // 0x0000001F
    [EnumMember] Cleanupinactiveworkflowassemblies = 32, // 0x00000020
    [EnumMember] RecurringSeriesExpansion = 35, // 0x00000023
    [EnumMember] ImportSampleData = 38, // 0x00000026
    [EnumMember] GoalRollUp = 40, // 0x00000028
    [EnumMember] AuditPartitionCreation = 41, // 0x00000029
    [EnumMember] CheckForLanguagePackUpdates = 42, // 0x0000002A
    [EnumMember] ProvisionLanguagePack = 43, // 0x0000002B
    [EnumMember] UpdateOrganizationDatabase = 44, // 0x0000002C
    [EnumMember] UpdateSolution = 45, // 0x0000002D
    [EnumMember] RegenerateEntityRowCountSnapshotData = 46, // 0x0000002E
    [EnumMember] RegenerateReadShareSnapshotData = 47, // 0x0000002F
    [EnumMember] PosttoYammer = 49, // 0x00000031
    [EnumMember] OutgoingActivity = 50, // 0x00000032
    [EnumMember] IncomingEmailProcessing = 51, // 0x00000033
    [EnumMember] MailboxTestAccess = 52, // 0x00000034
    [EnumMember] EncryptionHealthCheck = 53, // 0x00000035
    [EnumMember] ExecuteAsyncRequest = 54, // 0x00000036
    [EnumMember] UpdateEntitlementStates = 56, // 0x00000038
    [EnumMember] CalculateRollupField = 57, // 0x00000039
    [EnumMember] MassCalculateRollupField = 58, // 0x0000003A
    [EnumMember] ImportTranslation = 59, // 0x0000003B
    [EnumMember] ConvertDateAndTimeBehavior = 62, // 0x0000003E
    [EnumMember] EntityKeyIndexCreation = 63, // 0x0000003F
    [EnumMember] UpdateKnowledgeArticleStates = 65, // 0x00000041
    [EnumMember] ResourceBookingSync = 68, // 0x00000044
    [EnumMember] RelationshipAssistantCards = 69, // 0x00000045
    [EnumMember] CleanupSolutionComponents = 71, // 0x00000047
    [EnumMember] AppModuleMetadataOperation = 72, // 0x00000048
    [EnumMember] ALMAnomalyDetectionOperation = 73, // 0x00000049
    [EnumMember] FlowNotification = 75, // 0x0000004B
    [EnumMember] RibbonClientMetadataOperation = 76, // 0x0000004C
    [EnumMember] CallbackRegistrationExpanderOperation = 79, // 0x0000004F
    [EnumMember] CascadeAssign = 90, // 0x0000005A
    [EnumMember] CascadeDelete = 91, // 0x0000005B
    [EnumMember] EventExpanderOperation = 92, // 0x0000005C
    [EnumMember] ImportSolutionMetadata = 93, // 0x0000005D
    [EnumMember] BulkDeleteFileAttachment = 94, // 0x0000005E
    [EnumMember] RefreshBusinessUnitforRecordsOwnedByPrincipal = 95, // 0x0000005F
    [EnumMember] RevokeInheritedAccess = 96, // 0x00000060
    [EnumMember] CreateOrRefreshVirtualEntity = 98, // 0x00000062
    [EnumMember] Provisionlanguageforuser = 201, // 0x000000C9
    [EnumMember] CascadeGrantorRevokeAccessVersionTrackingAsyncOperation = 12801, // 0x00003201
    [EnumMember] AIBuilderTrainingEvents = 190690091, // 0x0B5DB32B
    [EnumMember] AIBuilderPredictionEvents = 190690092, // 0x0B5DB32C
  }
}
