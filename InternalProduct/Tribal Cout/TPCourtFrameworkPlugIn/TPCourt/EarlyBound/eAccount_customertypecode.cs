// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eAccount_customertypecode
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eAccount_customertypecode
  {
    [Description("Competitor")] Competitor = 1,
    [Description("Consultant")] Consultant = 2,
    [Description("Customer")] Customer = 3,
    [Description("Investor")] Investor = 4,
    [Description("Partner")] Partner = 5,
    [Description("Influencer")] Influencer = 6,
    [Description("Press")] Press = 7,
    [Description("Prospect")] Prospect = 8,
    [Description("Reseller")] Reseller = 9,
    [Description("Supplier")] Supplier = 10, // 0x0000000A
    [Description("Vendor")] Vendor = 11, // 0x0000000B
    [Description("Other")] Other = 12, // 0x0000000C
  }
}
