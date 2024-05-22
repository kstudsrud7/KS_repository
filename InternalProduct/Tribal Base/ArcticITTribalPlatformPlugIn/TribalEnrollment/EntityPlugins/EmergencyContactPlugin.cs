// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.EmergencyContactPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_emergencycontact", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_emergencycontact")]
  public class EmergencyContactPlugin : EntityBase
  {
    public EmergencyContactPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.ValidateEmergencyContact();
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

    public static void UpdateRelationship(
      IOrganizationService crmService,
      ait_emergencycontact emergencyContact,
      Global.ActionType actionType)
    {
      if (emergencyContact == null)
        return;
      int num;
      if (actionType != Global.ActionType.DELETE)
      {
        ait_emergencycontactState? statecode = emergencyContact.statecode;
        ait_emergencycontactState emergencycontactState = ait_emergencycontactState.Inactive;
        num = statecode.GetValueOrDefault() == emergencycontactState & statecode.HasValue ? 1 : 0;
      }
      else
        num = 1;
      if (num != 0)
        return;
      RelationshipPlugin.AddRelationship(crmService, emergencyContact.ait_contact, emergencyContact.ait_EmergencyContact, emergencyContact.ait_relationshiptype);
    }

    public static void UpdateEmergencyContact(
      IOrganizationService crmService,
      EntityReference contactReference,
      EntityReference emergencyContactReference,
      OptionSetValue relationshipType)
    {
      foreach (ait_emergencycontact entity in (Collection<Entity>) EmergencyContactPlugin.GetEmergencyContacts(crmService, contactReference, emergencyContactReference).Entities)
      {
        if (!AttributeLibrary.Compare(entity.ait_relationshiptype, relationshipType))
        {
          ait_emergencycontact emergencycontact = new ait_emergencycontact();
          ((Entity) emergencycontact).Id = ((Entity) entity).Id;
          emergencycontact.ait_relationshiptype = relationshipType;
          crmService.Update((Entity) emergencycontact);
        }
      }
    }

    public static EntityCollection GetEmergencyContacts(
      IOrganizationService crmService,
      EntityReference contactReference,
      EntityReference emergencyContactReference)
    {
      if (contactReference == null || emergencyContactReference == null)
        return (EntityCollection) null;
      return EntityLibrary.GetAllEntities(crmService, "ait_emergencycontact", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_contact", (ConditionOperator) 0, (object) contactReference.Id),
        new ConditionExpression("ait_emergencycontact", (ConditionOperator) 0, (object) emergencyContactReference.Id)
      }, true);
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_emergencycontact>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_emergencycontact>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_emergencycontact emergencycontact1 = (ait_emergencycontact) entityInput;
      ait_emergencycontact emergencycontact2 = (ait_emergencycontact) preImage;
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, emergencycontact1.ait_contact, emergencycontact2.ait_contact), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, "ait_relationshiptype", emergencycontact1.ait_relationshiptype, emergencycontact2.ait_relationshiptype), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, emergencycontact1.ait_EmergencyContact, emergencycontact2.ait_EmergencyContact));
    }

    private void ValidateEmergencyContact()
    {
      this.GetInputEntity<ait_emergencycontact>();
      if ((EntityReference) ObjectLibrary.GetEntityValueToUse((EntityBase) this, "ait_contact") == null)
        throw new InvalidPluginExecutionException((OperationStatus) 0, "Contact must be specified.");
    }

    public void UpdateRelatedRecords()
    {
      ait_emergencycontact inputEntity = this.GetInputEntity<ait_emergencycontact>(this.ActionType);
      this.GetEntityFromPreImage<ait_emergencycontact>();
      EmergencyContactPlugin.UpdateRelationship((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
    }
  }
}
