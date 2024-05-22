// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eAit_maritalstatus
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eAit_maritalstatus
  {
    [Description("Single, Never Married")] Single__Never_Married = 750000000, // 0x2CB41780
    [Description("Married / Remarried")] Married___Remarried = 750000001, // 0x2CB41781
    [Description("Separated")] Separated = 750000002, // 0x2CB41782
    [Description("Divorced")] Divorced = 750000003, // 0x2CB41783
    [Description("Widowed")] Widowed = 750000004, // 0x2CB41784
    [Description("Civil Union")] Civil_Union = 750000005, // 0x2CB41785
    [Description("Common Law")] Common_Law = 750000006, // 0x2CB41786
    [Description("Domestic Partner")] Domestic_Partner = 750000007, // 0x2CB41787
    [Description("Traditional")] Traditional = 750000009, // 0x2CB41789
    [Description("Tribal Custom")] Tribal_Custom = 750000010, // 0x2CB4178A
    [Description("Unknown")] Unknown = 750000011, // 0x2CB4178B
  }
}
