// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eSystemuser_caltype
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eSystemuser_caltype
  {
    [Description("Professional")] Professional,
    [Description("Administrative")] Administrative,
    [Description("Basic")] Basic,
    [Description("Device Professional")] Device_Professional,
    [Description("Device Basic")] Device_Basic,
    [Description("Essential")] Essential,
    [Description("Device Essential")] Device_Essential,
    [Description("Enterprise")] Enterprise,
    [Description("Device Enterprise")] Device_Enterprise,
    [Description("Sales")] Sales,
    [Description("Service")] Service,
    [Description("Field Service")] Field_Service,
    [Description("Project Service")] Project_Service,
  }
}
