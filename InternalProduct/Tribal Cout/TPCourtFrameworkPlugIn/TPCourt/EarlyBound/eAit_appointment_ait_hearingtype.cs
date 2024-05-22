// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eAit_appointment_ait_hearingtype
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eAit_appointment_ait_hearingtype
  {
    [Description("Hearing - 60 day review")] Hearing__60_day_review = 750000000, // 0x2CB41780
    [Description("Hearing - 90 day review")] Hearing__90_day_review = 750000001, // 0x2CB41781
    [Description("Hearing - 120 day review")] Hearing__120_day_review = 750000002, // 0x2CB41782
    [Description("Hearing - Fact-finding")] Hearing__Fact_finding = 750000003, // 0x2CB41783
    [Description("Initial Appearance")] Initial_Appearance = 750000004, // 0x2CB41784
    [Description("Motion Hearing")] Motion_Hearing = 750000005, // 0x2CB41785
    [Description("Oral Argument")] Oral_Argument = 750000006, // 0x2CB41786
    [Description("Order to Show Cause")] Order_to_Show_Cause = 750000007, // 0x2CB41787
    [Description("Other")] Other = 750000008, // 0x2CB41788
    [Description("Pre-Trial Conference")] Pre_Trial_Conference = 750000009, // 0x2CB41789
    [Description("Status Conference")] Status_Conference = 750000010, // 0x2CB4178A
    [Description("Trial")] Trial = 750000011, // 0x2CB4178B
  }
}
