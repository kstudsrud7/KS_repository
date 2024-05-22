// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.HouseholdPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.EarlyBound.OptionSets;
using ArcticIT.TribalEnrollment.Libraries;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_household", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_household")]
  public class HouseholdPlugin : EntityBase
  {
    private IPluginExecutionContext PluginContext { get; set; }

    public HouseholdPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.PluginContext = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.AutoNumberUpdate();
      this.SetDefaults();
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

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateRelatedRecords();
      this.UpdateRelatedNames();
    }

    public static bool IsContactInHousehold(
      IOrganizationService crmService,
      EntityReference contact)
    {
      EntityCollection referencedEntities = EntityLibrary.GetAllReferencedEntities(crmService, "ait_householdmember", "ait_contact", contact, true);
      return referencedEntities != null && ((Collection<Entity>) referencedEntities.Entities).Count > 0;
    }

    public static ait_householdmember GetHeadOfHousehold(
      IOrganizationService crmService,
      EntityReference householdReference)
    {
      ait_household entity = (ait_household) EntityLibrary.GetEntity(crmService, householdReference);
      return HouseholdPlugin.GetHeadOfHousehold(crmService, entity);
    }

    public static ait_householdmember GetHeadOfHousehold(
      IOrganizationService crmService,
      ait_household household)
    {
      ait_householdmember headOfHousehold = (ait_householdmember) null;
      if (household == null)
        return (ait_householdmember) null;
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "ait_householdmember", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_household", (ConditionOperator) 0, (object) ((Entity) household).Id),
        new ConditionExpression("ait_relationshiptype", (ConditionOperator) 0, (object) 750000012)
      }, true);
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
      {
        headOfHousehold = (ait_householdmember) ((Collection<Entity>) allEntities.Entities)[0];
        if (((Collection<Entity>) allEntities.Entities).Count == 2)
        {
          ait_householdmember entity = (ait_householdmember) ((Collection<Entity>) allEntities.Entities)[1];
          DateTime? nullable1 = entity.ModifiedOn;
          DateTime? nullable2 = headOfHousehold.ModifiedOn;
          if (nullable1.HasValue & nullable2.HasValue && nullable1.GetValueOrDefault() > nullable2.GetValueOrDefault())
          {
            headOfHousehold = entity;
          }
          else
          {
            nullable2 = entity.ModifiedOn;
            nullable1 = headOfHousehold.ModifiedOn;
            if (nullable2.HasValue == nullable1.HasValue && (!nullable2.HasValue || nullable2.GetValueOrDefault() == nullable1.GetValueOrDefault()))
            {
              nullable1 = entity.CreatedOn;
              nullable2 = headOfHousehold.CreatedOn;
              if (nullable1.HasValue & nullable2.HasValue && nullable1.GetValueOrDefault() > nullable2.GetValueOrDefault())
                headOfHousehold = entity;
            }
          }
        }
        else if (((Collection<Entity>) allEntities.Entities).Count > 2)
        {
          foreach (ait_householdmember entity in (Collection<Entity>) allEntities.Entities)
          {
            DateTime? modifiedOn1 = entity.ModifiedOn;
            DateTime? modifiedOn2 = headOfHousehold.ModifiedOn;
            if (modifiedOn1.HasValue & modifiedOn2.HasValue && modifiedOn1.GetValueOrDefault() > modifiedOn2.GetValueOrDefault())
              headOfHousehold = entity;
          }
        }
      }
      return headOfHousehold;
    }

    public static void UpdatePrimaryPhysicalAddressForContact(
      IOrganizationService crmService,
      EntityReference contactReference,
      ait_physicaladdress physicalAddress)
    {
      ait_physicaladdress currentForContact = PhysicalAddressPlugin.GetCurrentForContact(crmService, contactReference);
      if (currentForContact == null)
        CloneLibrary.CloneEntity(crmService, (Entity) physicalAddress, new Dictionary<string, object>()
        {
          {
            "ait_contact",
            (object) contactReference
          }
        });
      else if (CloneLibrary.CopyEntityAttributes((Entity) physicalAddress, (Entity) currentForContact, new Dictionary<string, object>()
      {
        {
          "ait_contact",
          (object) contactReference
        },
        {
          "ait_name",
          (object) currentForContact.ait_name
        }
      }))
        crmService.Update((Entity) currentForContact);
    }

    public static void UpdatePrimaryPhysicalAddressForMember(
      IOrganizationService crmService,
      ait_householdmember householdMember)
    {
      if (householdMember == null)
        return;
      ait_householdmember headOfHousehold = HouseholdPlugin.GetHeadOfHousehold(crmService, householdMember.ait_household);
      if (headOfHousehold == null)
        return;
      ait_physicaladdress currentForContact = PhysicalAddressPlugin.GetCurrentForContact(crmService, headOfHousehold.ait_contact);
      if (currentForContact == null)
        return;
      HouseholdPlugin.UpdatePrimaryPhysicalAddressForContact(crmService, householdMember.ait_contact, currentForContact);
    }

    public static void UpdatePrimaryPhysicalAddressForMembers(
      IOrganizationService crmService,
      EntityReference household)
    {
      if (household == null)
        return;
      ait_householdmember headOfHousehold = HouseholdPlugin.GetHeadOfHousehold(crmService, household);
      if (headOfHousehold == null)
        return;
      ait_physicaladdress currentForContact = PhysicalAddressPlugin.GetCurrentForContact(crmService, headOfHousehold.ait_contact);
      if (currentForContact == null)
        return;
      foreach (ait_householdmember entity in (Collection<Entity>) EntityLibrary.GetAllReferencedEntities(crmService, "ait_householdmember", "ait_household", household, true).Entities)
      {
        if (((Entity) entity).Id != household.Id && entity.ait_contact != null)
          HouseholdPlugin.UpdatePrimaryPhysicalAddressForContact(crmService, entity.ait_contact, currentForContact);
      }
    }

    public static ait_household UpdateIncomeExpenseInfo(
      IOrganizationService crmService,
      ait_householdmember householdMember)
    {
      ait_household aitHousehold = (ait_household) null;
      if (householdMember == null)
        throw new ArgumentNullException("Household Member cannot be empty.", nameof (householdMember));
      ait_household entity = (ait_household) EntityLibrary.GetEntity(crmService, householdMember.ait_household);
      int num;
      if (entity != null)
      {
        ait_householdState? statecode = entity.statecode;
        ait_householdState aitHouseholdState = ait_householdState.Active;
        num = statecode.GetValueOrDefault() == aitHouseholdState & statecode.HasValue ? 1 : 0;
      }
      else
        num = 0;
      if (num != 0)
        aitHousehold = HouseholdPlugin.RefreshHouseholdIncome(crmService, entity);
      return aitHousehold;
    }

    public static ait_household RefreshHouseholdIncome(
      IOrganizationService crmService,
      ait_household household)
    {
      // ISSUE: unable to decompile the method.
    }

    public static void RefreshHouseholdHead(
      IOrganizationService crmService,
      ait_household household)
    {
      ait_householdmember headOfHousehold = household != null ? HouseholdPlugin.GetHeadOfHousehold(crmService, household.ToEntityReference()) : throw new ArgumentNullException("Household cannot be empty.", nameof (household));
      ait_household aitHousehold = new ait_household();
      ((Entity) aitHousehold).Id = ((Entity) household).Id;
      bool flag = false;
      if (headOfHousehold == null && household.ait_headofhousehold != null)
      {
        flag = true;
        aitHousehold.ait_headofhousehold = (EntityReference) null;
      }
      if (headOfHousehold != null && !AttributeLibrary.Compare(household.ait_headofhousehold, headOfHousehold.ait_contact))
      {
        flag = true;
        aitHousehold.ait_headofhousehold = headOfHousehold.ait_contact;
      }
      if (!flag)
        return;
      HouseholdMemberPlugin.UpdateHouseholdMemberRelationships(crmService, household.ToEntityReference(), headOfHousehold);
      crmService.Update((Entity) aitHousehold);
    }

    protected override List<UpdateNameInformation> GetNameRelationships()
    {
      return new List<UpdateNameInformation>()
      {
        new UpdateNameInformation("ait_householdmember", "ait_household", true)
      };
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_household>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_household>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_household aitHousehold1 = (ait_household) entityInput;
      ait_household aitHousehold2 = (ait_household) preImage;
      string formattedName;
      if (TribalEnrollmentConfiguration.GetHouseholdNameOption(this.CrmService) == ait_householdnameoptions.NameandID)
      {
        string str = string.Empty;
        ait_householdmember headOfHousehold = HouseholdPlugin.GetHeadOfHousehold((IOrganizationService) this.CrmService, aitHousehold1.ToEntityReference());
        if (headOfHousehold != null && headOfHousehold.ait_contact != null)
        {
          str = headOfHousehold.ait_contact.Name + " Household";
        }
        else
        {
          string entityValue = FormatLibrary.GetEntityValue(aitHousehold1.ait_description, aitHousehold2.ait_description);
          if (!string.IsNullOrEmpty(entityValue))
          {
            int length = entityValue.Length < 75 ? entityValue.Length : 75;
            str = entityValue.Substring(0, length);
          }
        }
        string entityValue1 = FormatLibrary.GetEntityValue(aitHousehold1.ait_householdidnumber, aitHousehold2.ait_householdidnumber);
        formattedName = !string.IsNullOrEmpty(str) ? FormatLibrary.FormatName(str, entityValue1) : entityValue1;
      }
      else
        formattedName = base.GenerateFormattedName(entityInput, preImage);
      return formattedName;
    }

    private void SetDefaults()
    {
      ait_household inputEntity = this.GetInputEntity<ait_household>();
      if (inputEntity == null || inputEntity.TransactionCurrencyId != null)
        return;
      inputEntity.TransactionCurrencyId = OrganizationLibrary.GetDefaultCurrency(this.CrmService);
    }

    private void AutoNumberUpdate()
    {
      ait_householdnameoptions householdNameOption = TribalEnrollmentConfiguration.GetHouseholdNameOption(this.CrmService);
      if (householdNameOption != ait_householdnameoptions.NameandID && householdNameOption != ait_householdnameoptions.ID)
        return;
      ait_household inputEntity = this.GetInputEntity<ait_household>();
      if (string.IsNullOrEmpty(inputEntity.ait_householdidnumber))
        inputEntity.ait_householdidnumber = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_household", "ait_householdidnumber");
    }

    private void EntityInactivating(EntityReference deactiveEntityReference)
    {
      EntityLibrary.SetEntityChildrensState((IOrganizationService) this.CrmService, deactiveEntityReference, "ait_householdmember", "ait_household", 1, 2);
    }

    private void EntityActivating(EntityReference deactiveEntityReference)
    {
      EntityLibrary.SetEntityChildrensState((IOrganizationService) this.CrmService, deactiveEntityReference, "ait_householdmember", "ait_household", 0, 1);
    }

    private void UpdateRelatedRecords()
    {
      ait_household inputEntity = this.GetInputEntity<ait_household>(this.ActionType);
      if (!this.HasAttributeChanged("statecode"))
        return;
      if (inputEntity.statecode.Value == ait_householdState.Inactive)
        this.EntityInactivating(inputEntity.ToEntityReference());
      else if (inputEntity.statecode.Value == ait_householdState.Active)
        this.EntityActivating(inputEntity.ToEntityReference());
    }
  }
}
