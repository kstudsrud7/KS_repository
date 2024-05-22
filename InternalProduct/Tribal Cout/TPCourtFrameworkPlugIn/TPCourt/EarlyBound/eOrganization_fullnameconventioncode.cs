// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eOrganization_fullnameconventioncode
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eOrganization_fullnameconventioncode
  {
    [Description("Last Name, First Name")] Last_Name__First_Name,
    [Description("First Name")] First_Name,
    [Description("Last Name, First Name, Middle Initial")] Last_Name__First_Name__Middle_Initial,
    [Description("First Name, Middle Initial, Last Name")] First_Name__Middle_Initial__Last_Name,
    [Description("Last Name, First Name, Middle Name")] Last_Name__First_Name__Middle_Name,
    [Description("First Name, Middle Name, Last Name")] First_Name__Middle_Name__Last_Name,
    [Description("Last Name, space, First Name")] Last_Name__space__First_Name,
    [Description("Last Name, no space, First Name")] Last_Name__no_space__First_Name,
  }
}
