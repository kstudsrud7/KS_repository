// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.ContactMilitaryServicePlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using System;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_contactmilitaryservice", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_contactmilitaryservice")]
  public class ContactMilitaryServicePlugin : EntityBase
  {
    public ContactMilitaryServicePlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
      this.OnPluginPostDeleting += new EntityBase.PluginOnPostDeleteHandler(this.Execute_OnPluginPostDeleting);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.Validate();
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.UpdateName();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    public static bool UpdateContact(
      IOrganizationService crmService,
      ait_contactmilitaryservice contactMilitaryService,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (contactMilitaryService == null)
        throw new ArgumentNullException("ContactMilitaryService cannot be empty.", nameof (contactMilitaryService));
      if (contactMilitaryService.ait_contact == null)
        return false;
      Contact entity = (Contact) EntityLibrary.GetEntity(crmService, contactMilitaryService.ait_contact, false);
      if (entity == null)
        return false;
      ContactPlugin.UpdateMilitaryService(crmService, entity, true);
      return flag;
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_contactmilitaryservice>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_contactmilitaryservice>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_contactmilitaryservice contactmilitaryservice1 = (ait_contactmilitaryservice) entityInput;
      ait_contactmilitaryservice contactmilitaryservice2 = (ait_contactmilitaryservice) preImage;
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, contactmilitaryservice1.ait_contact, contactmilitaryservice2.ait_contact), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, "ait_branchofservice", contactmilitaryservice1.ait_branchofservice, contactmilitaryservice2.ait_branchofservice), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, "ait_armedservicestatus", contactmilitaryservice1.ait_armedservicestatus, contactmilitaryservice2.ait_armedservicestatus));
    }

    public void UpdateRelatedRecords()
    {
      ContactMilitaryServicePlugin.UpdateContact((IOrganizationService) this.CrmService, this.GetInputEntity<ait_contactmilitaryservice>(this.ActionType), this.ActionType);
    }

    private void Validate()
    {
      if (this.GetInputEntity<ait_contactmilitaryservice>().ait_contact == null)
        throw new InvalidPluginExecutionException((OperationStatus) 0, "Contact must be specified.");
    }
  }
}
