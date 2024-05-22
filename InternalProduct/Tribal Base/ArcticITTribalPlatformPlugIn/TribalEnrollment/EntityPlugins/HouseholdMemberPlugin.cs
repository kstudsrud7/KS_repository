// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.HouseholdMemberPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.TribalEnrollment.Libraries;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_householdmember", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_householdmember")]
  public class HouseholdMemberPlugin : EntityBase
  {
    private IPluginExecutionContext PluginContext { get; set; }

    public HouseholdMemberPlugin(
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
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
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
      Entity inputEntity = (Entity) this.GetInputEntity<ait_householdmember>();
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateRelatedRecords();
    }

    public static bool UpdateHouseholdMemberRelationships(
      IOrganizationService crmService,
      EntityReference householdReference,
      ait_householdmember headOfHousehold)
    {
      bool flag = false;
      if (householdReference == null)
        return false;
      foreach (ait_householdmember entity in (Collection<Entity>) EntityLibrary.GetAllReferencedEntities(crmService, "ait_householdmember", "ait_household", householdReference, true).Entities)
      {
        OptionSetValue compareTo = entity.ait_relationshiptype;
        if (headOfHousehold == null && entity.ait_relationshiptype != null)
          compareTo = (OptionSetValue) null;
        else if (headOfHousehold != null && !AttributeLibrary.Compare((Entity) headOfHousehold, (Entity) entity))
        {
          ait_relationship relationship = RelationshipPlugin.GetRelationship(crmService, entity.ait_contact, headOfHousehold.ait_contact);
          if (relationship != null && !AttributeLibrary.Compare(entity.ait_relationshiptype, relationship.ait_relationshiptype))
            compareTo = relationship.ait_relationshiptype;
          else if (relationship == null && entity.ait_relationshiptype != null)
            compareTo = (OptionSetValue) null;
        }
        if (!AttributeLibrary.Compare(entity.ait_relationshiptype, compareTo))
        {
          flag = true;
          ait_householdmember aitHouseholdmember = new ait_householdmember();
          ((Entity) aitHouseholdmember).Id = ((Entity) entity).Id;
          aitHouseholdmember.ait_relationshiptype = compareTo;
          crmService.Update((Entity) aitHouseholdmember);
        }
      }
      return flag;
    }

    public static void Deactivate(
      IOrganizationService crmService,
      EntityReference householdMemberId)
    {
      if (householdMemberId == null)
        return;
      ait_householdmember entity = (ait_householdmember) EntityLibrary.GetEntity(crmService, householdMemberId);
      if (entity == null)
        return;
      ait_householdmemberState? statecode = entity.statecode;
      ait_householdmemberState householdmemberState = ait_householdmemberState.Inactive;
      if (statecode.GetValueOrDefault() == householdmemberState & statecode.HasValue && entity.StatusCode.Value == 2)
        return;
      ait_householdmember aitHouseholdmember1 = new ait_householdmember();
      ((Entity) aitHouseholdmember1).Id = ((Entity) entity).Id;
      ait_householdmember aitHouseholdmember2 = aitHouseholdmember1;
      aitHouseholdmember2.statecode = new ait_householdmemberState?(ait_householdmemberState.Inactive);
      aitHouseholdmember2.StatusCode = new OptionSetValue(2);
      crmService.Update((Entity) aitHouseholdmember2);
    }

    public static void UpdateHouseholdMember(
      IOrganizationService crmService,
      EntityReference contact,
      EntityReference relatedTo,
      OptionSetValue relationshipType)
    {
      if (contact == null || relatedTo == null || relationshipType == null)
        return;
      ait_householdmember householdMember = HouseholdMemberPlugin.GetHouseholdMember(crmService, contact);
      if (householdMember == null || householdMember.ait_relationshiptype != null && AttributeLibrary.Compare(householdMember.ait_relationshiptype, relationshipType))
        return;
      ait_householdmember headOfHousehold = HouseholdPlugin.GetHeadOfHousehold(crmService, householdMember.ait_household);
      if (headOfHousehold == null || !AttributeLibrary.Compare(relatedTo, headOfHousehold.ait_contact))
        return;
      ait_householdmember aitHouseholdmember = new ait_householdmember();
      ((Entity) aitHouseholdmember).Id = ((Entity) householdMember).Id;
      aitHouseholdmember.ait_relationshiptype = relationshipType;
      crmService.Update((Entity) aitHouseholdmember);
    }

    public static ait_householdmember GetHouseholdMember(
      IOrganizationService crmService,
      EntityReference contact)
    {
      ait_householdmember householdMember = (ait_householdmember) null;
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "ait_householdmember", "ait_contact", (object) contact.Id, true);
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
        householdMember = (ait_householdmember) ((Collection<Entity>) allEntities.Entities)[0];
      return householdMember;
    }

    public static bool RemoveHouseholdMember(
      IOrganizationService crmService,
      ait_householdmember householdMember,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (householdMember == null)
        throw new ArgumentNullException("Household Member cannot be empty.", nameof (householdMember));
      if (householdMember.ait_household == null)
        return false;
      ait_household entity = (ait_household) EntityLibrary.GetEntity(crmService, householdMember.ait_household);
      if (householdMember.ait_household != null)
        HouseholdMemberPlugin.UpdateHousehold(crmService, entity, (ait_householdmember) null, true, true, actionType);
      return flag;
    }

    public static void UpdateHousehold(
      IOrganizationService crmService,
      ait_householdmember householdMember,
      bool incomeUpdated,
      bool headOfHouseholdUpdated,
      Global.ActionType actionType)
    {
      if (householdMember == null)
        throw new ArgumentNullException("Household Member cannot be empty.", nameof (householdMember));
      if (householdMember.ait_household == null)
        return;
      ait_household entity = (ait_household) EntityLibrary.GetEntity(crmService, householdMember.ait_household);
      if (householdMember.ait_household == null)
        return;
      HouseholdMemberPlugin.UpdateHousehold(crmService, entity, householdMember, incomeUpdated, headOfHouseholdUpdated, actionType);
    }

    public static void UpdateHousehold(
      IOrganizationService crmService,
      ait_household household,
      ait_householdmember householdMember,
      bool incomeUpdated,
      bool headOfHouseholdUpdated,
      Global.ActionType actionType)
    {
      ait_householdState? nullable = household != null ? household.statecode : throw new ArgumentNullException(nameof (household));
      ait_householdState aitHouseholdState = ait_householdState.Active;
      if (!(nullable.GetValueOrDefault() == aitHouseholdState & nullable.HasValue))
        return;
      if (incomeUpdated)
        HouseholdPlugin.RefreshHouseholdIncome(crmService, household);
      if (headOfHouseholdUpdated)
      {
        if (householdMember == null || !AttributeLibrary.Compare(householdMember.ait_relationshiptype, 750000012))
        {
          ait_householdmember headOfHousehold = HouseholdPlugin.GetHeadOfHousehold(crmService, household);
          if (householdMember == null || !AttributeLibrary.Compare((Entity) headOfHousehold, (Entity) householdMember))
            HouseholdPlugin.RefreshHouseholdHead(crmService, household);
          if (headOfHousehold == null && householdMember != null)
            HouseholdPlugin.RefreshHouseholdHead(crmService, household);
        }
        else
          HouseholdPlugin.RefreshHouseholdHead(crmService, household);
      }
    }

    public static void UpdateRelationship(
      IOrganizationService crmService,
      ait_householdmember householdMember,
      Global.ActionType actionType)
    {
      if (householdMember == null)
        return;
      int num;
      if (actionType != Global.ActionType.DELETE)
      {
        ait_householdmemberState? statecode = householdMember.statecode;
        ait_householdmemberState householdmemberState = ait_householdmemberState.Inactive;
        num = statecode.GetValueOrDefault() == householdmemberState & statecode.HasValue ? 1 : 0;
      }
      else
        num = 1;
      if (num != 0 || householdMember.ait_relationshiptype == null || AttributeLibrary.Compare(householdMember.ait_relationshiptype, 750000012))
        return;
      ait_householdmember headOfHousehold = HouseholdPlugin.GetHeadOfHousehold(crmService, householdMember.ait_household);
      if (headOfHousehold == null)
        return;
      RelationshipPlugin.AddRelationship(crmService, householdMember.ait_contact, headOfHousehold.ait_contact, householdMember.ait_relationshiptype);
    }

    public static bool UpdateContact(
      IOrganizationService crmService,
      ait_householdmember householdMember,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (householdMember == null)
        throw new ArgumentNullException("Household Member cannot be empty.", nameof (householdMember));
      if (householdMember.ait_contact == null)
        return false;
      Contact entity = (Contact) EntityLibrary.GetEntity(crmService, householdMember.ait_contact, false);
      Contact contact = new Contact();
      ((Entity) contact).Id = ((Entity) entity).Id;
      int num1;
      if (actionType != Global.ActionType.DELETE)
      {
        ait_householdmemberState? statecode = householdMember.statecode;
        ait_householdmemberState householdmemberState = ait_householdmemberState.Inactive;
        num1 = statecode.GetValueOrDefault() == householdmemberState & statecode.HasValue ? 1 : 0;
      }
      else
        num1 = 1;
      if (num1 != 0)
      {
        int num2;
        if (entity.ait_household != null || entity.ait_householdmember != null)
        {
          ContactState? stateCode = entity.StateCode;
          ContactState contactState = ContactState.Inactive;
          num2 = !(stateCode.GetValueOrDefault() == contactState & stateCode.HasValue) ? 1 : 0;
        }
        else
          num2 = 0;
        if (num2 != 0)
        {
          flag = true;
          entity.ait_householdmember = (EntityReference) null;
          entity.ait_household = (EntityReference) null;
          contact.ait_householdmember = (EntityReference) null;
          contact.ait_household = (EntityReference) null;
        }
      }
      else if (entity != null)
      {
        if (!AttributeLibrary.Compare(entity.ait_householdmember, (Entity) householdMember))
        {
          flag = true;
          entity.ait_householdmember = householdMember.ToEntityReference();
          contact.ait_householdmember = householdMember.ToEntityReference();
        }
        if (!AttributeLibrary.Compare(entity.ait_household, householdMember.ait_household))
        {
          flag = true;
          entity.ait_household = householdMember.ait_household;
          contact.ait_household = householdMember.ait_household;
        }
      }
      if (flag)
        crmService.Update((Entity) contact);
      return flag;
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_householdmember>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_householdmember>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_householdmember aitHouseholdmember1 = (ait_householdmember) entityInput;
      ait_householdmember aitHouseholdmember2 = (ait_householdmember) preImage;
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitHouseholdmember1.ait_contact, aitHouseholdmember2.ait_contact), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitHouseholdmember1.ait_household, aitHouseholdmember2.ait_household), FormatLibrary.GetEntityValueOptionSet((IOrganizationService) this.CrmService, (EntityBase) this, "ait_relationshiptype", "ait_relationshiptype"));
    }

    public bool HeadOfHouseholdChanged()
    {
      bool flag = false;
      ait_householdmember inputEntity = this.GetInputEntity<ait_householdmember>(this.ActionType);
      ait_householdmember entityFromPreImage = this.GetEntityFromPreImage<ait_householdmember>();
      if (this.HasAttributeChanged("ait_relationshiptype"))
      {
        if (inputEntity != null && AttributeLibrary.Compare(inputEntity.ait_relationshiptype, 750000012))
          flag = true;
        if (entityFromPreImage != null && AttributeLibrary.Compare(entityFromPreImage.ait_relationshiptype, 750000012))
          flag = true;
      }
      return flag;
    }

    public void UpdateRelatedRecords()
    {
      ait_householdmember inputEntity = this.GetInputEntity<ait_householdmember>(this.ActionType);
      ait_householdmember entityFromPreImage = this.GetEntityFromPreImage<ait_householdmember>();
      bool incomeUpdated = this.HasAttributeChanged("ait_includeincomeandexpensesinhousehold");
      bool headOfHouseholdUpdated = this.HeadOfHouseholdChanged();
      bool flag = this.HasAttributeChanged("statecode");
      if (incomeUpdated | headOfHouseholdUpdated | flag)
      {
        if (flag)
          incomeUpdated = true;
        HouseholdMemberPlugin.UpdateHousehold((IOrganizationService) this.CrmService, inputEntity, incomeUpdated, headOfHouseholdUpdated, this.ActionType);
      }
      if (entityFromPreImage != null && entityFromPreImage.ait_household != null && !AttributeLibrary.Compare(entityFromPreImage.ait_household, inputEntity.ait_household))
        HouseholdMemberPlugin.RemoveHouseholdMember((IOrganizationService) this.CrmService, entityFromPreImage, this.ActionType);
      if (TribalEnrollmentConfiguration.GetSyncHouseholdAddress(this.CrmService))
      {
        if (headOfHouseholdUpdated)
          HouseholdPlugin.UpdatePrimaryPhysicalAddressForMembers((IOrganizationService) this.CrmService, inputEntity.ait_household);
        else if (this.ActionType == Global.ActionType.CREATE || this.HasAttributeChanged("ait_household"))
          HouseholdPlugin.UpdatePrimaryPhysicalAddressForMember((IOrganizationService) this.CrmService, inputEntity);
      }
      HouseholdMemberPlugin.UpdateContact((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
      HouseholdMemberPlugin.UpdateRelationship((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
    }

    public void CloneEntity(IOrganizationService crmService, Entity originalEntity)
    {
      Entity clonedEntity = originalEntity != null ? new Entity()
      {
        LogicalName = originalEntity.LogicalName
      } : throw new ArgumentNullException(nameof (originalEntity));
      clonedEntity.Id = crmService.Create(clonedEntity);
      this.MyClone(originalEntity, clonedEntity);
      clonedEntity["ait_snapshotfrom"] = (object) originalEntity.ToEntityReference();
      crmService.Update(clonedEntity);
      SetStateResponse setStateResponse = (SetStateResponse) crmService.Execute((OrganizationRequest) new SetStateRequest()
      {
        EntityMoniker = clonedEntity.ToEntityReference(),
        State = new OptionSetValue(1),
        Status = new OptionSetValue(2)
      });
    }

    private Entity MyClone(Entity originalEntity, Entity clonedEntity)
    {
      string[] strArray = new string[2]{ "state", "status" };
      string str = originalEntity.LogicalName + "id";
      foreach (string key in (IEnumerable<string>) ((DataCollection<string, object>) originalEntity.Attributes).Keys)
      {
        if (!(key == "id") && !(key == str))
          clonedEntity[key] = ((DataCollection<string, object>) originalEntity.Attributes)[key];
      }
      return clonedEntity;
    }
  }
}
