// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ProcessStage_OperationKind
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
  public enum ProcessStage_OperationKind
  {
    [EnumMember] Http = 473330000, // 0x1C367150
    [EnumMember] PowerApp = 473330001, // 0x1C367151
    [EnumMember] PowerAppV2 = 473330002, // 0x1C367152
    [EnumMember] Button = 473330003, // 0x1C367153
    [EnumMember] ApiConnection = 473330004, // 0x1C367154
    [EnumMember] Alert = 473330005, // 0x1C367155
    [EnumMember] EventGrid = 473330006, // 0x1C367156
    [EnumMember] CurrentTime = 473330007, // 0x1C367157
    [EnumMember] ConvertTimeZone = 473330008, // 0x1C367158
    [EnumMember] GetFutureTime = 473330009, // 0x1C367159
    [EnumMember] GetPastTime = 473330010, // 0x1C36715A
    [EnumMember] AddToTime = 473330011, // 0x1C36715B
    [EnumMember] SubtractFromTime = 473330012, // 0x1C36715C
    [EnumMember] AzureMonitorAlert = 473330013, // 0x1C36715D
    [EnumMember] SecurityCenterAlert = 473330014, // 0x1C36715E
    [EnumMember] JsonToJson = 473330015, // 0x1C36715F
    [EnumMember] JsonToText = 473330016, // 0x1C367160
    [EnumMember] XmlToJson = 473330017, // 0x1C367161
    [EnumMember] XmlToText = 473330018, // 0x1C367162
    [EnumMember] Geofence = 473330019, // 0x1C367163
    [EnumMember] ODataOpenApiConnection = 473330020, // 0x1C367164
    [EnumMember] IndexOf = 473330021, // 0x1C367165
    [EnumMember] Substring = 473330022, // 0x1C367166
    [EnumMember] VirtualAgent = 473330023, // 0x1C367167
    [EnumMember] FormatNumber = 473330024, // 0x1C367168
  }
}
