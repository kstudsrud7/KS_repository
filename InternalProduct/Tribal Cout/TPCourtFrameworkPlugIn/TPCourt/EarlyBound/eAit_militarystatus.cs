// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eAit_militarystatus
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eAit_militarystatus
  {
    [Description("Currently Serving")] Currently_Serving = 750000000, // 0x2CB41780
    [Description("Veteran")] Veteran = 750000001, // 0x2CB41781
    [Description("None")] None = 750000002, // 0x2CB41782
    [Description("Currently Serving and Deployed")] Currently_Serving_and_Deployed = 750000003, // 0x2CB41783
  }
}
