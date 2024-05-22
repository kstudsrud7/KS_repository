// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eOrganization_reportscripterrors
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eOrganization_reportscripterrors
  {
    [Description("No preference for sending an error report to Microsoft about Microsoft Dynamics 365")] No_preference_for_sending_an_error_report_to_Microsoft_about_Microsoft_Dynamics_365,
    [Description("Ask me for permission to send an error report to Microsoft")] Ask_me_for_permission_to_send_an_error_report_to_Microsoft,
    [Description("Automatically send an error report to Microsoft without asking me for permission")] Automatically_send_an_error_report_to_Microsoft_without_asking_me_for_permission,
    [Description("Never send an error report to Microsoft about Microsoft Dynamics 365")] Never_send_an_error_report_to_Microsoft_about_Microsoft_Dynamics_365,
  }
}
