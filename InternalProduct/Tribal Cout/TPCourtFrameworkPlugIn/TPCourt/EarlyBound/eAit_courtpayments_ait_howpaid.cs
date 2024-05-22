// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eAit_courtpayments_ait_howpaid
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eAit_courtpayments_ait_howpaid
  {
    [Description("Cash")] Cash = 750000000, // 0x2CB41780
    [Description("Check")] Check = 750000001, // 0x2CB41781
    [Description("Charge")] Charge = 750000002, // 0x2CB41782
    [Description("Money Order")] Money_Order = 750000003, // 0x2CB41783
    [Description("Other")] Other = 750000004, // 0x2CB41784
  }
}
