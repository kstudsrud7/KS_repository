// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eAit_courtpartytype
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eAit_courtpartytype
  {
    [Description("Attorney for Appellant")] Attorney_for_Appellant = 750000000, // 0x2CB41780
    [Description("Attorney for Appellee")] Attorney_for_Appellee = 750000001, // 0x2CB41781
    [Description("Attorney for Defendant")] Attorney_for_Defendant = 750000002, // 0x2CB41782
    [Description("Attorney for Plaintiff")] Attorney_for_Plaintiff = 750000003, // 0x2CB41783
    [Description("Attorney for Petitioner")] Attorney_for_Petitioner = 750000004, // 0x2CB41784
    [Description("Attorney for Respondent")] Attorney_for_Respondent = 750000005, // 0x2CB41785
    [Description("Appellant")] Appellant = 750000006, // 0x2CB41786
    [Description("Appellee")] Appellee = 750000007, // 0x2CB41787
    [Description("Defendant")] Defendant = 750000008, // 0x2CB41788
    [Description("Garnishee")] Garnishee = 750000009, // 0x2CB41789
    [Description("Petitioner")] Petitioner = 750000010, // 0x2CB4178A
    [Description("Plaintiff")] Plaintiff = 750000011, // 0x2CB4178B
    [Description("Respondent")] Respondent = 750000012, // 0x2CB4178C
    [Description("Person In Need of Protection")] Person_In_Need_of_Protection = 750000013, // 0x2CB4178D
  }
}
