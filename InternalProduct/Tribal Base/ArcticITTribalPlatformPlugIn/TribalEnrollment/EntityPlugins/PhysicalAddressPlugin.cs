// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.PhysicalAddressPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.TribalEnrollment.Libraries;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_physicaladdress", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_physicaladdress")]
  public class PhysicalAddressPlugin : EntityBase
  {
    private IPluginExecutionContext PluginContext { get; set; }

    public PhysicalAddressPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.PluginContext = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
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
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateFormattedAddress();
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.ValidateUpdate();
      this.UpdateFormattedAddress();
      this.UpdateName();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.ValidateDelete();
      this.UpdateRelatedRecords();
    }

    public static ait_physicaladdress GetCurrentForContact(
      IOrganizationService crmService,
      EntityReference contactReference)
    {
      ait_physicaladdress currentForContact = (ait_physicaladdress) null;
      if (contactReference == null)
        return (ait_physicaladdress) null;
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "ait_physicaladdress", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_contact", (ConditionOperator) 0, (object) contactReference.Id),
        new ConditionExpression("ait_current", (ConditionOperator) 0, (object) true)
      }, true);
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
        currentForContact = (ait_physicaladdress) ((Collection<Entity>) allEntities.Entities)[0];
      return currentForContact;
    }

    public static bool UpdatePhysicalAddress(
      IOrganizationService crmService,
      ait_physicaladdress physicalAddress,
      Global.ActionType actionType)
    {
      bool flag1 = false;
      if (physicalAddress == null)
        throw new ArgumentNullException("Physical Address cannot be empty.", nameof (physicalAddress));
      string referenceField = string.Empty;
      Guid? referenceId = new Guid?();
      if (physicalAddress.ait_contact != null)
      {
        referenceId = new Guid?(physicalAddress.ait_contact.Id);
        referenceField = "ait_contact";
      }
      else if (physicalAddress.ait_company != null)
      {
        referenceId = new Guid?(physicalAddress.ait_company.Id);
        referenceField = "ait_company";
      }
      else if (physicalAddress.ait_school != null)
      {
        referenceId = new Guid?(physicalAddress.ait_school.Id);
        referenceField = "ait_school";
      }
      if (referenceId.HasValue && referenceId.HasValue && (AttributeLibrary.Compare(physicalAddress.ait_current, true) || AttributeLibrary.Compare(physicalAddress.ait_mailing, true)))
      {
        foreach (ait_physicaladdress entity in (Collection<Entity>) EntityLibrary.GetAllEntities(crmService, "ait_physicaladdress", referenceField, (object) referenceId, true).Entities)
        {
          bool flag2 = false;
          if (((Entity) entity).Id != ((Entity) physicalAddress).Id)
          {
            if (AttributeLibrary.Compare(entity.ait_current, true) && AttributeLibrary.Compare(physicalAddress.ait_current, true))
            {
              flag2 = true;
              entity.ait_current = new bool?(false);
            }
            bool? aitMailing = entity.ait_mailing;
            int num;
            if (aitMailing.HasValue)
            {
              aitMailing = entity.ait_mailing;
              if (aitMailing.Value)
              {
                aitMailing = physicalAddress.ait_mailing;
                if (aitMailing.HasValue)
                {
                  aitMailing = physicalAddress.ait_mailing;
                  num = aitMailing.Value ? 1 : 0;
                  goto label_19;
                }
              }
            }
            num = 0;
label_19:
            if (num != 0)
            {
              flag2 = true;
              entity.ait_mailing = new bool?(false);
            }
          }
          if (flag2)
          {
            flag1 = true;
            crmService.Update((Entity) entity);
          }
        }
      }
      return flag1;
    }

    public bool UpdatePrimaryEntity(
      IOrganizationService crmService,
      ait_physicaladdress physicalAddress,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (physicalAddress == null)
        throw new ArgumentNullException("Physical Address cannot be empty.", nameof (physicalAddress));
      if ((!this.HasAttributeChanged("ait_current") || actionType == Global.ActionType.CREATE || actionType == Global.ActionType.DELETE) && !physicalAddress.ait_current.Value)
        return false;
      if (physicalAddress.ait_contact != null)
      {
        Contact entity = (Contact) EntityLibrary.GetEntity(crmService, physicalAddress.ait_contact, false);
        if (entity != null)
        {
          ait_physicaladdress physicalAddress1 = (ait_physicaladdress) null;
          int num;
          if (physicalAddress.ait_current.Value)
          {
            ait_physicaladdressState? statecode = physicalAddress.statecode;
            ait_physicaladdressState physicaladdressState = ait_physicaladdressState.Active;
            if (statecode.GetValueOrDefault() == physicaladdressState & statecode.HasValue)
            {
              num = actionType != Global.ActionType.DELETE ? 1 : 0;
              goto label_10;
            }
          }
          num = 0;
label_10:
          if (num != 0)
            physicalAddress1 = physicalAddress;
          if (ContactPlugin.UpdatePhysicalAddressInfo(crmService, entity, physicalAddress1))
            flag = true;
        }
      }
      if (physicalAddress.ait_company != null)
      {
        ait_company entity = (ait_company) EntityLibrary.GetEntity(crmService, physicalAddress.ait_company, false);
        if (entity != null && entity.ait_primaryaddress != physicalAddress.ait_address)
        {
          entity.ait_primaryaddress = physicalAddress.ait_address;
          crmService.Update((Entity) entity);
          flag = true;
        }
      }
      if (physicalAddress.ait_school != null)
      {
        ait_school entity = (ait_school) EntityLibrary.GetEntity(crmService, physicalAddress.ait_school, false);
        if (entity != null && entity.ait_primaryaddress != physicalAddress.ait_address)
        {
          entity.ait_primaryaddress = physicalAddress.ait_address;
          crmService.Update((Entity) entity);
          flag = true;
        }
      }
      return flag;
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_physicaladdress>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_physicaladdress>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      return FormatLibrary.GetEntityValue(((ait_physicaladdress) entityInput).ait_address, ((ait_physicaladdress) preImage).ait_address);
    }

    private void UpdateFormattedAddress()
    {
      ait_physicaladdress baseImageForUpdate = (ait_physicaladdress) this.GetBaseImageForUpdate();
      ait_physicaladdress preImageForUpdate = (ait_physicaladdress) this.GetPreImageForUpdate();
      EntityReference entityValueToUse1 = (EntityReference) ObjectLibrary.GetEntityValueToUse(baseImageForUpdate.ait_city, preImageForUpdate.ait_city);
      EntityReference entityValueToUse2 = (EntityReference) ObjectLibrary.GetEntityValueToUse(baseImageForUpdate.ait_stateprovince, preImageForUpdate.ait_stateprovince);
      EntityReference entityValueToUse3 = (EntityReference) ObjectLibrary.GetEntityValueToUse(baseImageForUpdate.ait_zipcode, preImageForUpdate.ait_zipcode);
      EntityReference entityValueToUse4 = (EntityReference) ObjectLibrary.GetEntityValueToUse(baseImageForUpdate.ait_countryregion, preImageForUpdate.ait_countryregion);
      string entityValue1 = FormatLibrary.GetEntityValue(baseImageForUpdate.ait_street1, preImageForUpdate.ait_street1);
      string entityValue2 = FormatLibrary.GetEntityValue(baseImageForUpdate.ait_street2, preImageForUpdate.ait_street2);
      string entityValue3 = FormatLibrary.GetEntityValue(baseImageForUpdate.ait_street3, preImageForUpdate.ait_street3);
      string entityValueToUse5 = (string) ObjectLibrary.GetEntityValueToUse((object) baseImageForUpdate.ait_zipcodeextension, (object) preImageForUpdate.ait_zipcodeextension);
      string str = TribalEnrollmentFormatLibrary.FormatAddress((IOrganizationService) this.CrmService, entityValue1, entityValue2, entityValue3, entityValueToUse1, entityValueToUse2, entityValueToUse3, entityValueToUse5, entityValueToUse4);
      baseImageForUpdate.ait_address = str;
    }

    public static bool UpdateHousehold(
      FrameworkService crmService,
      ait_physicaladdress physicalAddress,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (physicalAddress == null)
        throw new ArgumentNullException("Physical Address cannot be empty.", nameof (physicalAddress));
      if (physicalAddress.ait_contact == null)
        return flag;
      ait_householdmember aitHouseholdmember = (ait_householdmember) null;
      EntityCollection allEntities = EntityLibrary.GetAllEntities((IOrganizationService) crmService, "ait_householdmember", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_contact", (ConditionOperator) 0, (object) physicalAddress.ait_contact.Id),
        new ConditionExpression("ait_relationshiptype", (ConditionOperator) 0, (object) 750000012)
      }, true);
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
        aitHouseholdmember = (ait_householdmember) ((Collection<Entity>) allEntities.Entities)[0];
      if (TribalEnrollmentConfiguration.GetSyncHouseholdAddress(crmService) && aitHouseholdmember != null)
      {
        flag = true;
        HouseholdPlugin.UpdatePrimaryPhysicalAddressForMembers((IOrganizationService) crmService, aitHouseholdmember.ait_household);
      }
      return flag;
    }

    private void UpdateRelatedRecords()
    {
      ait_physicaladdress inputEntity = this.GetInputEntity<ait_physicaladdress>(this.ActionType);
      PhysicalAddressPlugin.UpdatePhysicalAddress((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
      this.UpdatePrimaryEntity((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
      PhysicalAddressPlugin.UpdateHousehold(this.CrmService, inputEntity, this.ActionType);
    }

    private void ValidateUpdate()
    {
      ait_physicaladdress inputEntity = this.GetInputEntity<ait_physicaladdress>(this.ActionType);
      ait_physicaladdressState? statecode = inputEntity.statecode;
      ait_physicaladdressState physicaladdressState = ait_physicaladdressState.Inactive;
      if (!(statecode.GetValueOrDefault() == physicaladdressState & statecode.HasValue))
        return;
      ait_physicaladdress entity = (ait_physicaladdress) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputEntity.ToEntityReference(), false);
      if (entity != null && entity.ait_contact != null && entity.ait_current.HasValue && entity.ait_current.HasValue && entity.ait_current.Value && HouseholdPlugin.IsContactInHousehold((IOrganizationService) this.CrmService, entity.ait_contact))
        throw new InvalidPluginExecutionException("Cannot deactivate primary address when a member of a household.");
    }

    private void ValidateDelete()
    {
      ait_physicaladdress inputEntity = this.GetInputEntity<ait_physicaladdress>(this.ActionType);
      if (inputEntity.ait_contact != null && inputEntity.ait_current.HasValue && inputEntity.ait_current.HasValue && inputEntity.ait_current.Value && inputEntity.statuscode.Value == 1 && HouseholdPlugin.IsContactInHousehold((IOrganizationService) this.CrmService, inputEntity.ait_contact))
        throw new InvalidPluginExecutionException("Cannot delete primary address when a member of a household.");
    }
  }
}
