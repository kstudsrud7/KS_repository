﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ait_CaseStatus
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
  public enum ait_CaseStatus
  {
    [EnumMember] New = 914600000, // 0x3683B040
    [EnumMember] Approved = 914600001, // 0x3683B041
    [EnumMember] Complete = 914600002, // 0x3683B042
    [EnumMember] Cancelled = 914600003, // 0x3683B043
    [EnumMember] Declined = 914600004, // 0x3683B044
  }
}
