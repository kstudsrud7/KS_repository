﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ait_CaseType
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
  public enum ait_CaseType
  {
    [EnumMember] Counseling = 914600000, // 0x3683B040
    [EnumMember] ChildSupport = 914600001, // 0x3683B041
    [EnumMember] Paternity = 914600002, // 0x3683B042
    [EnumMember] SubstanceAbuse = 914600003, // 0x3683B043
    [EnumMember] ICWCHIPS = 914600004, // 0x3683B044
    [EnumMember] Guardianship = 914600005, // 0x3683B045
    [EnumMember] DomesticViolence = 914600006, // 0x3683B046
    [EnumMember] ChildProtectiveServices = 914600007, // 0x3683B047
    [EnumMember] AdultProtectiveServices = 914600008, // 0x3683B048
    [EnumMember] Assistance = 914600009, // 0x3683B049
  }
}