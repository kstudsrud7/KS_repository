// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ComponentType
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
  public enum ComponentType
  {
    [EnumMember] Entity = 1,
    [EnumMember] Attribute = 2,
    [EnumMember] Relationship = 3,
    [EnumMember] AttributePicklistValue = 4,
    [EnumMember] AttributeLookupValue = 5,
    [EnumMember] ViewAttribute = 6,
    [EnumMember] LocalizedLabel = 7,
    [EnumMember] RelationshipExtraCondition = 8,
    [EnumMember] OptionSet = 9,
    [EnumMember] EntityRelationship = 10, // 0x0000000A
    [EnumMember] EntityRelationshipRole = 11, // 0x0000000B
    [EnumMember] EntityRelationshipRelationships = 12, // 0x0000000C
    [EnumMember] ManagedProperty = 13, // 0x0000000D
    [EnumMember] EntityKey = 14, // 0x0000000E
    [EnumMember] Privilege = 16, // 0x00000010
    [EnumMember] PrivilegeObjectTypeCode = 17, // 0x00000011
    [EnumMember] Index = 18, // 0x00000012
    [EnumMember] Role = 20, // 0x00000014
    [EnumMember] RolePrivilege = 21, // 0x00000015
    [EnumMember] DisplayString = 22, // 0x00000016
    [EnumMember] DisplayStringMap = 23, // 0x00000017
    [EnumMember] Form = 24, // 0x00000018
    [EnumMember] Organization = 25, // 0x00000019
    [EnumMember] SavedQuery = 26, // 0x0000001A
    [EnumMember] Workflow = 29, // 0x0000001D
    [EnumMember] Report = 31, // 0x0000001F
    [EnumMember] ReportEntity = 32, // 0x00000020
    [EnumMember] ReportCategory = 33, // 0x00000021
    [EnumMember] ReportVisibility = 34, // 0x00000022
    [EnumMember] Attachment = 35, // 0x00000023
    [EnumMember] EmailTemplate = 36, // 0x00000024
    [EnumMember] ContractTemplate = 37, // 0x00000025
    [EnumMember] KBArticleTemplate = 38, // 0x00000026
    [EnumMember] MailMergeTemplate = 39, // 0x00000027
    [EnumMember] DuplicateRule = 44, // 0x0000002C
    [EnumMember] DuplicateRuleCondition = 45, // 0x0000002D
    [EnumMember] EntityMap = 46, // 0x0000002E
    [EnumMember] AttributeMap = 47, // 0x0000002F
    [EnumMember] RibbonCommand = 48, // 0x00000030
    [EnumMember] RibbonContextGroup = 49, // 0x00000031
    [EnumMember] RibbonCustomization = 50, // 0x00000032
    [EnumMember] RibbonRule = 52, // 0x00000034
    [EnumMember] RibbonTabToCommandMap = 53, // 0x00000035
    [EnumMember] RibbonDiff = 55, // 0x00000037
    [EnumMember] SavedQueryVisualization = 59, // 0x0000003B
    [EnumMember] SystemForm = 60, // 0x0000003C
    [EnumMember] WebResource = 61, // 0x0000003D
    [EnumMember] SiteMap = 62, // 0x0000003E
    [EnumMember] ConnectionRole = 63, // 0x0000003F
    [EnumMember] ComplexControl = 64, // 0x00000040
    [EnumMember] HierarchyRule = 65, // 0x00000041
    [EnumMember] CustomControl = 66, // 0x00000042
    [EnumMember] CustomControlDefaultConfig = 68, // 0x00000044
    [EnumMember] FieldSecurityProfile = 70, // 0x00000046
    [EnumMember] FieldPermission = 71, // 0x00000047
    [EnumMember] PluginType = 90, // 0x0000005A
    [EnumMember] PluginAssembly = 91, // 0x0000005B
    [EnumMember] SDKMessageProcessingStep = 92, // 0x0000005C
    [EnumMember] SDKMessageProcessingStepImage = 93, // 0x0000005D
    [EnumMember] ServiceEndpoint = 95, // 0x0000005F
    [EnumMember] RoutingRule = 150, // 0x00000096
    [EnumMember] RoutingRuleItem = 151, // 0x00000097
    [EnumMember] SLA = 152, // 0x00000098
    [EnumMember] SLAItem = 153, // 0x00000099
    [EnumMember] ConvertRule = 154, // 0x0000009A
    [EnumMember] ConvertRuleItem = 155, // 0x0000009B
    [EnumMember] MobileOfflineProfile = 161, // 0x000000A1
    [EnumMember] MobileOfflineProfileItem = 162, // 0x000000A2
    [EnumMember] SimilarityRule = 165, // 0x000000A5
    [EnumMember] DataSourceMapping = 166, // 0x000000A6
    [EnumMember] SDKMessage = 201, // 0x000000C9
    [EnumMember] SDKMessageFilter = 202, // 0x000000CA
    [EnumMember] SdkMessagePair = 203, // 0x000000CB
    [EnumMember] SdkMessageRequest = 204, // 0x000000CC
    [EnumMember] SdkMessageRequestField = 205, // 0x000000CD
    [EnumMember] SdkMessageResponse = 206, // 0x000000CE
    [EnumMember] SdkMessageResponseField = 207, // 0x000000CF
    [EnumMember] ImportMap = 208, // 0x000000D0
    [EnumMember] WebWizard = 210, // 0x000000D2
    [EnumMember] CanvasApp = 300, // 0x0000012C
    [EnumMember] Connector_371 = 371, // 0x00000173
    [EnumMember] Connector_372 = 372, // 0x00000174
    [EnumMember] EnvironmentVariableDefinition = 380, // 0x0000017C
    [EnumMember] EnvironmentVariableValue = 381, // 0x0000017D
    [EnumMember] AIProjectType = 400, // 0x00000190
    [EnumMember] AIProject = 401, // 0x00000191
    [EnumMember] AIConfiguration = 402, // 0x00000192
    [EnumMember] EntityAnalyticsConfiguration = 430, // 0x000001AE
    [EnumMember] AttributeImageConfiguration = 431, // 0x000001AF
    [EnumMember] EntityImageConfiguration = 432, // 0x000001B0
  }
}
