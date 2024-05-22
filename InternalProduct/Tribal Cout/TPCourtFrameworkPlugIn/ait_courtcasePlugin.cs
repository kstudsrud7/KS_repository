// Decompiled with JetBrains decompiler
// Type: ait_courtcasePlugin
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using TPCourt.EarlyBound;

#nullable disable
[CRMMetadata(EntityName = "ait_courtcase", CrmEntityType = "TPCourt.EarlyBound.ait_courtcase")]
public class ait_courtcasePlugin : EntityBase
{
  public ait_courtcasePlugin(
    IServiceProvider serviceProvider,
    string unsecuredConfiguration,
    string securedConfiguration)
    : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
  {
    this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Ait_courtcasePlugin_OnPluginPreCreating);
    this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Ait_courtcasePlugin_OnPluginPreUpdating);
  }

  private void Ait_courtcasePlugin_OnPluginPreUpdating(
    object sender,
    EntityBase.PluginOnPreUpdateHandlerEventArgs e)
  {
    this.SetCourtNameUpdate();
  }

  private void Ait_courtcasePlugin_OnPluginPreCreating(
    object sender,
    EntityBase.PluginOnPreCreateHandlerEventArgs e)
  {
    this.SetCourtNameCreate();
  }

  private void SetCourtNameCreate()
  {
    ait_courtcase inputEntity = this.GetInputEntity<ait_courtcase>();
    if (inputEntity.ait_tempcaseid == null)
      return;
    string newValue = inputEntity.ait_casetype_Text((IOrganizationService) this.CrmService);
    if (newValue != string.Empty && newValue.Length >= 2)
    {
      int length = newValue.IndexOf(" ");
      if (length > 0)
        newValue = newValue.Substring(0, length);
    }
    if (inputEntity.ait_tempcaseid.IndexOf("XX") > -1)
      inputEntity.ait_caseid = inputEntity.ait_tempcaseid.Replace("XX", newValue);
  }

  private void SetCourtNameUpdate()
  {
    ait_courtcase inputEntity = this.GetInputEntity<ait_courtcase>();
    ait_courtcase entityFromPreImage = this.GetEntityFromPreImage<ait_courtcase>();
    if (entityFromPreImage.ait_tempcaseid == null || !inputEntity.ait_casetype.HasValue)
      return;
    string newValue = inputEntity.ait_casetype_Text((IOrganizationService) this.CrmService);
    if (newValue != string.Empty && newValue.Length >= 2)
    {
      int length = newValue.IndexOf(" ");
      if (length > 0)
        newValue = newValue.Substring(0, length);
    }
    if (entityFromPreImage.ait_tempcaseid.IndexOf("XX") > -1)
      inputEntity.ait_caseid = entityFromPreImage.ait_tempcaseid.Replace("XX", newValue);
  }
}
