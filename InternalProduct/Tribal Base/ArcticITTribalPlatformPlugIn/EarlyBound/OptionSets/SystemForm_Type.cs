// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.SystemForm_Type
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
  public enum SystemForm_Type
  {
    [EnumMember] Dashboard = 0,
    [EnumMember] AppointmentBook = 1,
    [EnumMember] Main = 2,
    [EnumMember] MiniCampaignBO = 3,
    [EnumMember] Preview = 4,
    [EnumMember] MobileExpress = 5,
    [EnumMember] QuickViewForm = 6,
    [EnumMember] QuickCreate = 7,
    [EnumMember] Dialog = 8,
    [EnumMember] TaskFlowForm = 9,
    [EnumMember] InteractionCentricDashboard = 10, // 0x0000000A
    [EnumMember] Card = 11, // 0x0000000B
    [EnumMember] MainInteractiveexperience = 12, // 0x0000000C
    [EnumMember] Other = 100, // 0x00000064
    [EnumMember] MainBackup = 101, // 0x00000065
    [EnumMember] AppointmentBookBackup = 102, // 0x00000066
    [EnumMember] PowerBIDashboard = 103, // 0x00000067
  }
}
