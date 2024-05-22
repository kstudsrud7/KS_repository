// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.PaymentEligibilityPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.EntityLibraries;
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
  [CRMMetadata(EntityName = "ait_pmteligibility", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_pmteligibility")]
  public class PaymentEligibilityPlugin : EntityBase
  {
    public PaymentEligibilityPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.UpdateRelatedWithholdings();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.CreateWithholdings();
    }

    public static void Deactivate(
      IOrganizationService crmService,
      EntityReference pmtEligilityReference)
    {
      ait_pmteligibility aitPmteligibility = new ait_pmteligibility();
      ((Entity) aitPmteligibility).Id = pmtEligilityReference.Id;
      aitPmteligibility.ait_EndDate = new DateTime?(DateTime.Today);
      aitPmteligibility.statecode = new ait_pmteligibilityState?(ait_pmteligibilityState.Inactive);
      crmService.Update((Entity) aitPmteligibility);
    }

    public static EntityCollection GetAllForContactAndPaymentType(
      IOrganizationService crmService,
      Guid contactId,
      Guid paymentTypeId)
    {
      if (contactId == Guid.Empty || paymentTypeId == Guid.Empty)
        return (EntityCollection) null;
      return EntityLibrary.GetAllEntities(crmService, "ait_pmteligibility", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_member", (ConditionOperator) 0, (object) contactId),
        new ConditionExpression("ait_pmtpaymenttype", (ConditionOperator) 0, (object) paymentTypeId)
      }, true);
    }

    public static EntityCollection GetAllForPaymentType(
      IOrganizationService crmService,
      Guid paymentTypeId,
      DateTime validDate)
    {
      if (paymentTypeId == Guid.Empty)
        return (EntityCollection) null;
      FilterExpression filterExpression1 = new FilterExpression();
      ((Collection<ConditionExpression>) filterExpression1.Conditions).Add(new ConditionExpression("ait_pmtpaymenttype", (ConditionOperator) 0, (object) paymentTypeId));
      FilterExpression filterExpression2 = filterExpression1;
      FilterExpression filterExpression3 = new FilterExpression();
      filterExpression3.FilterOperator = (LogicalOperator) 0;
      ((Collection<ConditionExpression>) filterExpression3.Conditions).Add(new ConditionExpression("ait_startdate", (ConditionOperator) 5, (object) validDate));
      DataCollection<FilterExpression> filters = filterExpression3.Filters;
      FilterExpression filterExpression4 = new FilterExpression();
      filterExpression4.FilterOperator = (LogicalOperator) 1;
      ((Collection<ConditionExpression>) filterExpression4.Conditions).Add(new ConditionExpression("ait_enddate", (ConditionOperator) 4, (object) validDate));
      ((Collection<ConditionExpression>) filterExpression4.Conditions).Add(new ConditionExpression("ait_enddate", (ConditionOperator) 12));
      ((Collection<FilterExpression>) filters).Add(filterExpression4);
      FilterExpression filterExpression5 = filterExpression3;
      return EntityLibrary.GetAllEntities(crmService, "ait_pmteligibility", true, filterExpression2, filterExpression5);
    }

    public static void Create(
      IOrganizationService crmService,
      Contact contact,
      ait_pmtpaymenttype paymentType)
    {
      DateTime dateTime1 = new DateTime();
      DateTime dateTime2 = new DateTime();
      DateTime dateTime3;
      DateTime dateTime4;
      if (paymentType.ait_eligibilitycriteria.Value == 750000000 || paymentType.ait_eligibilitycriteria.Value == 750000002)
      {
        int? nullable1 = paymentType.ait_ageminimum;
        int num1;
        if (nullable1.HasValue)
        {
          nullable1 = paymentType.ait_agemaximum;
          num1 = !nullable1.HasValue ? 1 : 0;
        }
        else
          num1 = 1;
        if (num1 != 0)
          throw new InvalidPluginExecutionException(string.Format("Minimum and Maximum Age must be set on Payment Type {0}.", (object) paymentType.ait_name));
        if (!contact.BirthDate.HasValue)
          return;
        DateTime dateTime5 = contact.BirthDate.Value;
        ref DateTime local1 = ref dateTime5;
        nullable1 = paymentType.ait_ageminimum;
        int num2 = nullable1.Value;
        dateTime3 = local1.AddYears(num2);
        DateTime? nullable2 = contact.BirthDate;
        DateTime dateTime6 = nullable2.Value;
        ref DateTime local2 = ref dateTime6;
        nullable1 = paymentType.ait_agemaximum;
        int num3 = nullable1.Value + 1;
        dateTime4 = local2.AddYears(num3).Subtract(TimeSpan.FromDays(1.0));
        nullable2 = UserLibrary.LocalTime(crmService);
        if (nullable2.Value > dateTime4)
          return;
      }
      else
      {
        dateTime3 = UserLibrary.LocalTime(crmService).Value;
        dateTime4 = dateTime3.AddYears(100);
      }
      OrganizationRequest organizationRequest = new OrganizationRequest()
      {
        RequestName = "ait_GlobalCreatePaymentEligibilities"
      };
      organizationRequest["PaymentTypeID"] = (object) paymentType.ToEntityReference();
      organizationRequest["ContactID"] = (object) contact.ToEntityReference();
      organizationRequest["StartDate"] = (object) dateTime3;
      organizationRequest["EndDate"] = (object) dateTime4;
      crmService.Execute(organizationRequest);
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_pmteligibility>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_pmteligibility>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string formattedName = ((ait_pmteligibility) entityInput).ait_name;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_pmteligibility", "ait_name");
      return formattedName;
    }

    private void UpdateRelatedWithholdings()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag)
        return;
      this.CrmService.Trace("TP: Entering PaymentEligibilityPlugin.UpdateRelatedWithholdings");
      ait_pmteligibility inputEntity = this.GetInputEntity<ait_pmteligibility>(this.ActionType);
      int num;
      if (this.HasAttributeChanged("statecode"))
      {
        ait_pmteligibilityState? statecode = inputEntity.statecode;
        ait_pmteligibilityState pmteligibilityState = ait_pmteligibilityState.Inactive;
        num = statecode.GetValueOrDefault() == pmteligibilityState & statecode.HasValue ? 1 : 0;
      }
      else
        num = 0;
      if (num == 0)
        return;
      foreach (Entity entity in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_pmtwithholding", "ait_pmteligibility", (object) inputEntity.ToEntityReference(), true).Entities)
        WithholdingPlugin.Deactivate((IOrganizationService) this.CrmService, entity.ToEntityReference());
    }

    private void CreateWithholdings()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag1 = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag1 = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag1)
        return;
      this.CrmService.Trace("TP: Entering PaymentEligibilityPlugin.CreateWithholdings");
      ait_pmteligibility inputEntity = this.GetInputEntity<ait_pmteligibility>(this.ActionType);
      foreach (ait_withholdingtype_pmtpaymenttype entity1 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_withholdingtype_pmtpaymenttype", "ait_pmtpaymenttypeid", (object) inputEntity.ait_PmtPaymentType.Id, false).Entities)
      {
        ait_withholdingtype entity2 = (ait_withholdingtype) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, "ait_withholdingtype", entity1.ait_withholdingtypeid.Value);
        Contact entity3 = (Contact) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, "contact", inputEntity.ait_Member.Id);
        bool? autocreatewithholding = entity2.ait_autocreatewithholding;
        bool flag2 = false;
        int num;
        if (!(autocreatewithholding.GetValueOrDefault() == flag2 & autocreatewithholding.HasValue))
        {
          ait_withholdingtypeState? statecode = entity2.statecode;
          ait_withholdingtypeState withholdingtypeState = ait_withholdingtypeState.Inactive;
          if (!(statecode.GetValueOrDefault() == withholdingtypeState & statecode.HasValue))
          {
            num = !ContactPlugin.IsEligibleForWithholdingType((IOrganizationService) this.CrmService, entity3, entity2) ? 1 : 0;
            goto label_9;
          }
        }
        num = 1;
label_9:
        if (num == 0)
        {
          EntityCollection paymentEligibility = WithholdingPlugin.GetAllForContactWithholdingTypeAndPaymentEligibility((IOrganizationService) this.CrmService, ((Entity) entity3).Id, ((Entity) entity2).Id, ((Entity) inputEntity).Id);
          if (paymentEligibility == null || ((Collection<Entity>) paymentEligibility.Entities).Count <= 0)
            WithholdingPlugin.Create((IOrganizationService) this.CrmService, entity3, entity2, inputEntity);
        }
      }
    }
  }
}
