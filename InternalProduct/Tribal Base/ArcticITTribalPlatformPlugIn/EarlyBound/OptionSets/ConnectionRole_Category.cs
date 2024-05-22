// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ConnectionRole_Category
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
  public enum ConnectionRole_Category
  {
    [EnumMember] Business = 1,
    [EnumMember] Family = 2,
    [EnumMember] Social = 3,
    [EnumMember] Sales = 4,
    [EnumMember] Other = 5,
    [EnumMember] Stakeholder = 1000, // 0x000003E8
    [EnumMember] SalesTeam = 1001, // 0x000003E9
    [EnumMember] Service = 1002, // 0x000003EA
  }
}
