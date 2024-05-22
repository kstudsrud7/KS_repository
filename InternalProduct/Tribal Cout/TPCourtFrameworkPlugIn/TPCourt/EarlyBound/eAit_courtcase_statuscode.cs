// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eAit_courtcase_statuscode
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eAit_courtcase_statuscode
  {
    [Description("Open")] Open = 1,
    [Description("Closed")] Closed2 = 2,
    [Description("Preperation")] Preperation = 750000000, // 0x2CB41780
    [Description("Filed")] Filed = 750000001, // 0x2CB41781
    [Description("On Docket")] On_Docket = 750000002, // 0x2CB41782
    [Description("Judgement")] Judgement = 750000003, // 0x2CB41783
    [Description("Appeal")] Appeal = 750000004, // 0x2CB41784
    [Description("Settled")] Settled = 750000005, // 0x2CB41785
    [Description("Dismiss Without Prejudice")] Dismiss_Without_Prejudice = 750000006, // 0x2CB41786
    [Description("Closed")] Closed = 750000007, // 0x2CB41787
    [Description("Dismissed")] Dismissed = 750000008, // 0x2CB41788
  }
}
