// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.WithholdingPlugin
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
  [CRMMetadata(EntityName = "ait_pmtwithholding", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_pmtwithholding")]
  public class WithholdingPlugin : EntityBase
  {
    public WithholdingPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
    }

    public static void Deactivate(
      IOrganizationService crmService,
      EntityReference withholdingReference)
    {
      ait_pmtwithholding aitPmtwithholding = new ait_pmtwithholding();
      ((Entity) aitPmtwithholding).Id = withholdingReference.Id;
      aitPmtwithholding.ait_EndDate = new DateTime?(DateTime.Today);
      aitPmtwithholding.statecode = new ait_pmtwithholdingState?(ait_pmtwithholdingState.Inactive);
      crmService.Update((Entity) aitPmtwithholding);
    }

    public static EntityCollection GetAllForContactAndWithholdingType(
      IOrganizationService crmService,
      Guid contactId,
      Guid withholdingTypeId)
    {
      if (contactId == Guid.Empty || withholdingTypeId == Guid.Empty)
        return (EntityCollection) null;
      return EntityLibrary.GetAllEntities(crmService, "ait_pmtwithholding", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_member", (ConditionOperator) 0, (object) contactId),
        new ConditionExpression("ait_withholdingtypeid", (ConditionOperator) 0, (object) withholdingTypeId)
      }, true);
    }

    public static EntityCollection GetAllForContactAndPaymentEligibility(
      IOrganizationService crmService,
      Guid contactId,
      Guid paymentEligibilityId)
    {
      if (contactId == Guid.Empty || paymentEligibilityId == Guid.Empty)
        return (EntityCollection) null;
      return EntityLibrary.GetAllEntities(crmService, "ait_pmtwithholding", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_member", (ConditionOperator) 0, (object) contactId),
        new ConditionExpression("ait_pmteligibility", (ConditionOperator) 0, (object) paymentEligibilityId)
      }, true);
    }

    public static EntityCollection GetAllForContactAndPaymentEligibilityByPriority(
      IOrganizationService crmService,
      Guid contactId,
      Guid paymentEligibilityId,
      DateTime validDate)
    {
      if (contactId == Guid.Empty || paymentEligibilityId == Guid.Empty)
        return (EntityCollection) null;
      FilterExpression filterExpression1 = new FilterExpression();
      ((Collection<ConditionExpression>) filterExpression1.Conditions).Add(new ConditionExpression("ait_member", (ConditionOperator) 0, (object) contactId));
      FilterExpression filterExpression2 = filterExpression1;
      FilterExpression filterExpression3 = new FilterExpression();
      ((Collection<ConditionExpression>) filterExpression3.Conditions).Add(new ConditionExpression("ait_pmteligibility", (ConditionOperator) 0, (object) paymentEligibilityId));
      FilterExpression filterExpression4 = filterExpression3;
      FilterExpression filterExpression5 = new FilterExpression();
      filterExpression5.FilterOperator = (LogicalOperator) 0;
      ((Collection<ConditionExpression>) filterExpression5.Conditions).Add(new ConditionExpression("ait_startdate", (ConditionOperator) 5, (object) validDate));
      DataCollection<FilterExpression> filters = filterExpression5.Filters;
      FilterExpression filterExpression6 = new FilterExpression();
      filterExpression6.FilterOperator = (LogicalOperator) 1;
      ((Collection<ConditionExpression>) filterExpression6.Conditions).Add(new ConditionExpression("ait_enddate", (ConditionOperator) 4, (object) validDate));
      ((Collection<ConditionExpression>) filterExpression6.Conditions).Add(new ConditionExpression("ait_enddate", (ConditionOperator) 12));
      ((Collection<FilterExpression>) filters).Add(filterExpression6);
      FilterExpression filterExpression7 = filterExpression5;
      return EntityLibrary.GetAllEntities(crmService, "ait_pmtwithholding", "ait_priority", true, filterExpression2, filterExpression4, filterExpression7);
    }

    public static EntityCollection GetAllForContactWithholdingTypeAndPaymentEligibility(
      IOrganizationService crmService,
      Guid contactId,
      Guid withholdingTypeId,
      Guid paymentEligibilityId)
    {
      if (contactId == Guid.Empty || paymentEligibilityId == Guid.Empty)
        return (EntityCollection) null;
      return EntityLibrary.GetAllEntities(crmService, "ait_pmtwithholding", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_member", (ConditionOperator) 0, (object) contactId),
        new ConditionExpression("ait_withholdingtypeid", (ConditionOperator) 0, (object) withholdingTypeId),
        new ConditionExpression("ait_pmteligibility", (ConditionOperator) 0, (object) paymentEligibilityId)
      }, true);
    }

    public static void Create(
      IOrganizationService crmService,
      Contact contact,
      ait_withholdingtype withholdingType,
      ait_pmteligibility paymentEligibility)
    {
      OrganizationRequest organizationRequest = new OrganizationRequest()
      {
        RequestName = "ait_GlobalCreatePaymentWithholdings"
      };
      organizationRequest["PaymentEligibilityID"] = (object) paymentEligibility.ToEntityReference();
      organizationRequest["WithholdingTypeID"] = (object) withholdingType.ToEntityReference();
      EntityReference result = (EntityReference) ((DataCollection<string, object>) crmService.Execute(organizationRequest).Results)["PaymentWithholdingID"];
      int availablePriority = WithholdingPlugin.GetNextAvailablePriority(crmService, contact, withholdingType, paymentEligibility);
      ait_pmtwithholding aitPmtwithholding = new ait_pmtwithholding();
      ((Entity) aitPmtwithholding).Id = result.Id;
      aitPmtwithholding.ait_Priority = new int?(availablePriority);
      crmService.Update((Entity) aitPmtwithholding);
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_pmtwithholding>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_pmtwithholding>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string formattedName = ((ait_pmtwithholding) entityInput).ait_name;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_pmtwithholding", "ait_name");
      return formattedName;
    }

    private static int GetNextAvailablePriority(
      IOrganizationService crmService,
      Contact contact,
      ait_withholdingtype withholdingType,
      ait_pmteligibility paymentEligibility)
    {
      int availablePriority = withholdingType.ait_withholdingrangeend.Value;
      int priority = withholdingType.ait_withholdingrangestart.Value;
      while (true)
      {
        int num = priority;
        int? withholdingrangeend = withholdingType.ait_withholdingrangeend;
        int valueOrDefault = withholdingrangeend.GetValueOrDefault();
        if (num < valueOrDefault & withholdingrangeend.HasValue)
        {
          if (WithholdingPlugin.ExistsForContactByPriority(crmService, contact.ToEntityReference(), paymentEligibility.ToEntityReference(), priority))
            ++priority;
          else
            break;
        }
        else
          goto label_5;
      }
      availablePriority = priority;
label_5:
      return availablePriority;
    }

    private static bool ExistsForContactByPriority(
      IOrganizationService crmService,
      EntityReference contact,
      EntityReference paymentEligibility,
      int priority)
    {
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "ait_pmtwithholding", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_member", (ConditionOperator) 0, (object) contact.Id),
        new ConditionExpression("ait_pmteligibility", (ConditionOperator) 0, (object) paymentEligibility.Id),
        new ConditionExpression("ait_priority", (ConditionOperator) 0, (object) priority)
      }, true);
      return allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0;
    }
  }
}
