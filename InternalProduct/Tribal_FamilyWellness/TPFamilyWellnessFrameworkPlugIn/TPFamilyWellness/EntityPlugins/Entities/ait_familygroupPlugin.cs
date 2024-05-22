// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.ait_familygroupPlugin
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using TPFamilyWellness.EarlyBound;

#nullable disable
namespace TPFamilyWellness.EntityPlugins.Entities
{
  [CRMMetadata(EntityName = "ait_familygroup", CrmEntityType = "TPFamilyWellness.ait_familygroup.ait_familygroup")]
  public class ait_familygroupPlugin : EntityBase
  {
    public ait_familygroupPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Ait_familygroupPlugin_OnPluginPostCreating);
    }

    private void Ait_familygroupPlugin_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.SyncFamilyGroupToContactLookup();
    }

    private void SyncFamilyGroupToContactLookup()
    {
      ait_familygroup inputEntity = this.GetInputEntity<ait_familygroup>();
      if (inputEntity.ait_PrimaryContact == null)
        return;
      Contact contact = new Contact();
      contact.Id = inputEntity.ait_PrimaryContact.Id;
      contact.ContactId = new Guid?(inputEntity.ait_PrimaryContact.Id);
      contact.ait_familygroup = new EntityReference("ait_familygroup", ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityId);
      this.CrmService.Update((Entity) contact);
    }
  }
}
