// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eOrganization_syncoptinselectionstatus
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eOrganization_syncoptinselectionstatus
  {
    [Description("Processing")] Processing = 1,
    [Description("Passed")] Passed = 2,
    [Description("Failed")] Failed = 3,
  }
}
