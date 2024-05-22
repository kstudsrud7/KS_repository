// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eConnectionrole_category
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eConnectionrole_category
  {
    [Description("Business")] Business = 1,
    [Description("Family")] Family = 2,
    [Description("Social")] Social = 3,
    [Description("Sales")] Sales = 4,
    [Description("Other")] Other = 5,
    [Description("Stakeholder")] Stakeholder = 1000, // 0x000003E8
    [Description("Sales Team")] Sales_Team = 1001, // 0x000003E9
    [Description("Service")] Service = 1002, // 0x000003EA
  }
}
