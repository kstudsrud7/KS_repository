// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.ait_CourtPartyType
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
  public enum ait_CourtPartyType
  {
    [EnumMember] AttorneyforAppellant = 750000000, // 0x2CB41780
    [EnumMember] AttorneyforAppellee = 750000001, // 0x2CB41781
    [EnumMember] AttorneyforDefendant = 750000002, // 0x2CB41782
    [EnumMember] AttorneyforPlaintiff = 750000003, // 0x2CB41783
    [EnumMember] AttorneyforPetitioner = 750000004, // 0x2CB41784
    [EnumMember] AttorneyforRespondent = 750000005, // 0x2CB41785
    [EnumMember] Appellant = 750000006, // 0x2CB41786
    [EnumMember] Appellee = 750000007, // 0x2CB41787
    [EnumMember] Defendant = 750000008, // 0x2CB41788
    [EnumMember] Garnishee = 750000009, // 0x2CB41789
    [EnumMember] Petitioner = 750000010, // 0x2CB4178A
    [EnumMember] Plaintiff = 750000011, // 0x2CB4178B
    [EnumMember] Respondent = 750000012, // 0x2CB4178C
    [EnumMember] PersonInNeedofProtection = 750000013, // 0x2CB4178D
    [EnumMember] GAL = 750000014, // 0x2CB4178E
  }
}
