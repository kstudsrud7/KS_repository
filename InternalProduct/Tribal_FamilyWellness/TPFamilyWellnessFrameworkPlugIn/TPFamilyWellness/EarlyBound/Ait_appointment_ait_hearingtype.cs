// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Ait_appointment_ait_hearingtype
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public enum Ait_appointment_ait_hearingtype
  {
    [EnumMember] Hearing60dayreview = 750000000, // 0x2CB41780
    [EnumMember] Hearing90dayreview = 750000001, // 0x2CB41781
    [EnumMember] Hearing120dayreview = 750000002, // 0x2CB41782
    [EnumMember] HearingFactfinding = 750000003, // 0x2CB41783
    [EnumMember] InitialAppearance = 750000004, // 0x2CB41784
    [EnumMember] MotionHearing = 750000005, // 0x2CB41785
    [EnumMember] OralArgument = 750000006, // 0x2CB41786
    [EnumMember] OrdertoShowCause = 750000007, // 0x2CB41787
    [EnumMember] Other = 750000008, // 0x2CB41788
    [EnumMember] PreTrialConference = 750000009, // 0x2CB41789
    [EnumMember] StatusConference = 750000010, // 0x2CB4178A
    [EnumMember] Trial = 750000011, // 0x2CB4178B
    [EnumMember] TIMEBLOCKED = 750000012, // 0x2CB4178C
    [EnumMember] AnnualReview = 750000013, // 0x2CB4178D
    [EnumMember] Hearing30DayReview = 750000014, // 0x2CB4178E
    [EnumMember] Hearing45DayReview = 750000015, // 0x2CB4178F
  }
}
