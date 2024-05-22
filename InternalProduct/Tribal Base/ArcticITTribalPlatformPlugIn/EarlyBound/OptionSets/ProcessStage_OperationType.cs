// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ProcessStage_OperationType
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
  public enum ProcessStage_OperationType
  {
    [EnumMember] Http = 473330000, // 0x1C367150
    [EnumMember] ApiApp = 473330001, // 0x1C367151
    [EnumMember] Recurrence = 473330002, // 0x1C367152
    [EnumMember] Workflow = 473330003, // 0x1C367153
    [EnumMember] Flow = 473330004, // 0x1C367154
    [EnumMember] Wait = 473330005, // 0x1C367155
    [EnumMember] ApiConnection = 473330006, // 0x1C367156
    [EnumMember] OpenApiConnection = 473330007, // 0x1C367157
    [EnumMember] Manual = 473330008, // 0x1C367158
    [EnumMember] ApiConnectionWebhook = 473330009, // 0x1C367159
    [EnumMember] OpenApiConnectionWebhook = 473330010, // 0x1C36715A
    [EnumMember] Response = 473330011, // 0x1C36715B
    [EnumMember] HttpWebhook = 473330012, // 0x1C36715C
    [EnumMember] Compose = 473330013, // 0x1C36715D
    [EnumMember] Query = 473330014, // 0x1C36715E
    [EnumMember] Function = 473330015, // 0x1C36715F
    [EnumMember] ApiManagement = 473330016, // 0x1C367160
    [EnumMember] XmlValidation = 473330017, // 0x1C367161
    [EnumMember] FlatFileEncoding = 473330018, // 0x1C367162
    [EnumMember] Scope = 473330019, // 0x1C367163
    [EnumMember] Request = 473330020, // 0x1C367164
    [EnumMember] If = 473330021, // 0x1C367165
    [EnumMember] Foreach = 473330022, // 0x1C367166
    [EnumMember] Until = 473330023, // 0x1C367167
    [EnumMember] Xslt = 473330024, // 0x1C367168
    [EnumMember] FlatFileDecoding = 473330025, // 0x1C367169
    [EnumMember] Terminate = 473330026, // 0x1C36716A
    [EnumMember] IntegrationAccountArtifactLookup = 473330027, // 0x1C36716B
    [EnumMember] Switch = 473330028, // 0x1C36716C
    [EnumMember] ParseJson = 473330029, // 0x1C36716D
    [EnumMember] Table = 473330030, // 0x1C36716E
    [EnumMember] Join = 473330031, // 0x1C36716F
    [EnumMember] Select = 473330032, // 0x1C367170
    [EnumMember] InitializeVariable = 473330033, // 0x1C367171
    [EnumMember] IncrementVariable = 473330034, // 0x1C367172
    [EnumMember] DecrementVariable = 473330035, // 0x1C367173
    [EnumMember] SetVariable = 473330036, // 0x1C367174
    [EnumMember] AppendToArrayVariable = 473330037, // 0x1C367175
    [EnumMember] AppendToStringVariable = 473330038, // 0x1C367176
    [EnumMember] Batch = 473330039, // 0x1C367177
    [EnumMember] SendToBatch = 473330040, // 0x1C367178
    [EnumMember] SlidingWindow = 473330041, // 0x1C367179
    [EnumMember] Expression = 473330042, // 0x1C36717A
    [EnumMember] Liquid = 473330043, // 0x1C36717B
    [EnumMember] JavascriptCode = 473330044, // 0x1C36717C
    [EnumMember] As2Decode = 473330045, // 0x1C36717D
    [EnumMember] As2Encode = 473330046, // 0x1C36717E
    [EnumMember] RosettaNetEncode = 473330047, // 0x1C36717F
    [EnumMember] RosettaNetDecode = 473330048, // 0x1C367180
    [EnumMember] RosettaNetWaitForResponse = 473330049, // 0x1C367181
    [EnumMember] ApiConnectionNotification = 473330050, // 0x1C367182
    [EnumMember] Changeset = 473330051, // 0x1C367183
    [EnumMember] SwiftEncode = 473330052, // 0x1C367184
  }
}
