// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ait_RelationshipReason
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
  public enum ait_RelationshipReason
  {
    [EnumMember] Minor = 750000000, // 0x2CB41780
    [EnumMember] Voluntary = 750000001, // 0x2CB41781
    [EnumMember] Incapacitated = 750000002, // 0x2CB41782
    [EnumMember] WardofCourt = 750000003, // 0x2CB41783
    [EnumMember] AdoptionDecree = 750000004, // 0x2CB41784
    [EnumMember] FullCustody = 914600000, // 0x3683B040
    [EnumMember] PartialCustody = 914600001, // 0x3683B041
    [EnumMember] NoCustody = 914600002, // 0x3683B042
    [EnumMember] Temporary = 914600003, // 0x3683B043
  }
}
