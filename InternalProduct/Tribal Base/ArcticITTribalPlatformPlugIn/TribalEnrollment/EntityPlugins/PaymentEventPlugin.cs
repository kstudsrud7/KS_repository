// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.PaymentEventPlugin
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
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_pmtevent", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_pmtevent")]
  public class PaymentEventPlugin : EntityBase
  {
    private FrameworkService adminService;

    public PaymentEventPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.adminService = this.CrmService.ImpersonateAdmin();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.UpdateRelatedTransactions();
      this.UpdateRelatedDeductions();
      this.CreatePayments();
      this.CompleteIntegration();
      this.CompleteExport();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_pmtevent>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_pmtevent>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string formattedName = ((ait_pmtevent) entityInput).ait_name;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_pmtevent", "ait_name");
      return formattedName;
    }

    private void UpdateRelatedTransactions()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag)
        return;
      this.CrmService.Trace("TP: Entering PaymentEventPlugin.UpdateRelatedTransactions");
      ait_pmtevent inputEntity = this.GetInputEntity<ait_pmtevent>(this.ActionType);
      if (inputEntity == null)
        return;
      int num;
      if (this.HasAttributeChanged("statecode"))
      {
        ait_pmteventState? statecode = inputEntity.statecode;
        ait_pmteventState aitPmteventState = ait_pmteventState.Inactive;
        num = statecode.GetValueOrDefault() == aitPmteventState & statecode.HasValue ? 1 : 0;
      }
      else
        num = 0;
      if (num != 0)
      {
        foreach (ait_pmttransaction entity in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_pmttransaction", "ait_pmtevent", (object) inputEntity.ToEntityReference(), true).Entities)
        {
          ait_pmttransaction aitPmttransaction = new ait_pmttransaction();
          ((Entity) aitPmttransaction).Id = ((Entity) entity).Id;
          aitPmttransaction.statecode = new ait_pmttransactionState?(ait_pmttransactionState.Inactive);
          aitPmttransaction.StatusCode = AttributeLibrary.Compare((object) inputEntity.ait_ProcessStage, (object) ait_pmtprocessstages.IntegrationSucceeded) ? new OptionSetValue(750000000) : new OptionSetValue(2);
          this.adminService.Update((Entity) aitPmttransaction);
        }
      }
    }

    private void UpdateRelatedDeductions()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag)
        return;
      this.CrmService.Trace("TP: Entering PaymentEventPlugin.UpdateRelatedDeductions");
      ait_pmtevent inputEntity = this.GetInputEntity<ait_pmtevent>(this.ActionType);
      if (inputEntity == null)
        return;
      int num;
      if (this.HasAttributeChanged("statecode"))
      {
        ait_pmteventState? statecode = inputEntity.statecode;
        ait_pmteventState aitPmteventState = ait_pmteventState.Inactive;
        num = statecode.GetValueOrDefault() == aitPmteventState & statecode.HasValue ? 1 : 0;
      }
      else
        num = 0;
      if (num != 0)
      {
        foreach (ait_pmttransactiondeduction entity in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_pmttransactiondeduction", "ait_pmtevent", (object) inputEntity.ToEntityReference(), true).Entities)
        {
          ait_pmttransactiondeduction pmttransactiondeduction = new ait_pmttransactiondeduction();
          ((Entity) pmttransactiondeduction).Id = ((Entity) entity).Id;
          pmttransactiondeduction.statecode = new ait_pmttransactiondeductionState?(ait_pmttransactiondeductionState.Inactive);
          pmttransactiondeduction.StatusCode = AttributeLibrary.Compare((object) inputEntity.ait_ProcessStage, (object) ait_pmtprocessstages.IntegrationSucceeded) ? new OptionSetValue(750000000) : new OptionSetValue(2);
          this.adminService.Update((Entity) pmttransactiondeduction);
        }
      }
    }

    private void CreatePayments()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag1 = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag1 = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag1)
        return;
      this.CrmService.Trace("TP: Entering PaymentEventPlugin.CreatePayments");
      ait_pmtevent inputEntity = this.GetInputEntity<ait_pmtevent>(this.ActionType);
      if (inputEntity == null || !this.HasAttributeChanged("ait_ProcessStage") || inputEntity.ait_ProcessStage.Value != 914600000)
        return;
      bool flag2 = false;
      ait_pmtpaymenttype entity = (ait_pmtpaymenttype) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputEntity.ait_PmtPaymentType);
      try
      {
        ait_pmtevent aitPmtevent1 = new ait_pmtevent();
        ((Entity) aitPmtevent1).Id = ((Entity) inputEntity).Id;
        ait_pmtevent aitPmtevent2 = aitPmtevent1;
        aitPmtevent2.ait_Iteration = new int?(inputEntity.ait_Iteration.GetValueOrDefault() + 1);
        this.CrmService.Update((Entity) aitPmtevent2);
        EntityLibrary.DeleteAllEntities((IOrganizationService) this.adminService, "ait_pmttransactiondeduction", "ait_pmtevent", (object) ((Entity) inputEntity).Id);
        EntityLibrary.DeleteAllEntities((IOrganizationService) this.adminService, "ait_pmttransaction", "ait_pmtevent", (object) ((Entity) inputEntity).Id);
        bool fromEligibilities = this.CreatePaymentsFromEligibilities(inputEntity);
        if (this.CreatePaymentsFromRequests(inputEntity) | fromEligibilities)
        {
          bool? allowWithholdings = entity.ait_AllowWithholdings;
          bool flag3 = true;
          if (allowWithholdings.GetValueOrDefault() == flag3 & allowWithholdings.HasValue)
            this.CreateDeductions(inputEntity);
          aitPmtevent2.ait_ProcessStage = new OptionSetValue(914600002);
        }
        else
        {
          aitPmtevent2.ait_ProcessStage = new OptionSetValue(914600007);
          aitPmtevent2.ait_processingerror = "Payments were not created.  Please verify that there is at least one associated payment eligibility or payment request.";
        }
        this.CrmService.Update((Entity) aitPmtevent2);
        flag2 = true;
      }
      finally
      {
        if (!flag2)
        {
          ait_pmtevent aitPmtevent3 = new ait_pmtevent();
          ((Entity) aitPmtevent3).Id = ((Entity) inputEntity).Id;
          ait_pmtevent aitPmtevent4 = aitPmtevent3;
          aitPmtevent4.ait_ProcessStage = new OptionSetValue(914600007);
          aitPmtevent4.ait_processingerror = "Payments were not created.  If you received an error message during processing, please provide that message to your administrator.  Otherwise, please try again later.";
          this.CrmService.Update((Entity) aitPmtevent4);
        }
      }
    }

    private bool CreatePaymentsFromEligibilities(ait_pmtevent paymentEvent)
    {
      bool fromEligibilities = false;
      foreach (ait_pmteligibility entity in (Collection<Entity>) PaymentEligibilityPlugin.GetAllForPaymentType((IOrganizationService) this.CrmService, paymentEvent.ait_PmtPaymentType.Id, paymentEvent.ait_TransactionDate.Value).Entities)
      {
        EntityReference fromEligibility = PaymentTransactionPlugin.CreateFromEligibility((IOrganizationService) this.adminService, paymentEvent.ToEntityReference(), paymentEvent.ait_PmtPaymentType, entity);
        fromEligibilities = fromEligibilities || fromEligibility != null;
      }
      return fromEligibilities;
    }

    private bool CreatePaymentsFromRequests(ait_pmtevent paymentEvent)
    {
      bool paymentsFromRequests = false;
      foreach (ait_payment entity in (Collection<Entity>) PaymentRequestPlugin.GetAllReadyForProcessing((IOrganizationService) this.CrmService, paymentEvent.ait_PmtPaymentType.Id, ((Entity) paymentEvent).Id).Entities)
      {
        EntityReference fromRequest = PaymentTransactionPlugin.CreateFromRequest((IOrganizationService) this.adminService, paymentEvent.ToEntityReference(), entity);
        paymentsFromRequests = paymentsFromRequests || fromRequest != null;
      }
      return paymentsFromRequests;
    }

    private void CreateDeductions(ait_pmtevent paymentEvent)
    {
      foreach (ait_pmttransaction entity1 in (Collection<Entity>) PaymentTransactionPlugin.GetAllForPaymentEvent((IOrganizationService) this.CrmService, ((Entity) paymentEvent).Id).Entities)
      {
        FrameworkService crmService1 = this.CrmService;
        Guid id1 = entity1.ait_Member.Id;
        Guid id2 = entity1.ait_PmtEligibility.Id;
        DateTime? aitTransactionDate = paymentEvent.ait_TransactionDate;
        DateTime validDate1 = aitTransactionDate.Value;
        foreach (ait_pmtwithholding entity2 in (Collection<Entity>) WithholdingPlugin.GetAllForContactAndPaymentEligibilityByPriority((IOrganizationService) crmService1, id1, id2, validDate1).Entities)
        {
          FrameworkService crmService2 = this.CrmService;
          Guid id3 = ((Entity) entity2).Id;
          aitTransactionDate = paymentEvent.ait_TransactionDate;
          DateTime validDate2 = aitTransactionDate.Value;
          ait_pmtwithholdingoverride modifiedDateDesc = WithholdingOverridePlugin.GetForWithholdingByModifiedDateDesc((IOrganizationService) crmService2, id3, validDate2);
          Money deductionAmount = modifiedDateDesc == null ? PaymentTransactionDeductionPlugin.GetDeductionAmount(entity2.ait_amounttype.Value, entity1.ait_TransactionAmount, entity2.ait_withholdingpercentage, entity2.ait_WithholdingAmount) : PaymentTransactionDeductionPlugin.GetDeductionAmount(modifiedDateDesc.ait_amounttype.Value, entity1.ait_TransactionAmount, modifiedDateDesc.ait_withholdingpercentage, modifiedDateDesc.ait_WithholdingOverrideAmount);
          PaymentTransactionDeductionPlugin.Create((IOrganizationService) this.adminService, entity1.ToEntityReference(), entity2.ToEntityReference(), entity2.ait_withholdingtypeid, deductionAmount);
        }
      }
    }

    private void CompleteIntegration()
    {
      ait_pmtevent inputEntity = this.GetInputEntity<ait_pmtevent>(this.ActionType);
      if (inputEntity == null || ((ait_pmtpaymenttype) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputEntity.ait_PmtPaymentType)).ait_financedestination.Value != 750000000 || !this.HasAttributeChanged("ait_ProcessStage") || inputEntity.ait_ProcessStage.Value != 914600006)
        return;
      ait_pmtevent aitPmtevent1 = new ait_pmtevent();
      ((Entity) aitPmtevent1).Id = ((Entity) inputEntity).Id;
      ait_pmtevent aitPmtevent2 = aitPmtevent1;
      aitPmtevent2.ait_ProcessStage = new OptionSetValue(914600004);
      this.CrmService.Update((Entity) aitPmtevent2);
    }

    private void CompleteExport()
    {
      ait_pmtevent inputEntity = this.GetInputEntity<ait_pmtevent>(this.ActionType);
      if (inputEntity == null || !this.HasAttributeChanged("ait_ProcessStage") || inputEntity.ait_ProcessStage.Value != 750000002)
        return;
      foreach (ait_payment entity in (Collection<Entity>) PaymentRequestPlugin.GetAllForPaymentEvent((IOrganizationService) this.CrmService, ((Entity) inputEntity).Id).Entities)
      {
        ait_payment aitPayment1 = new ait_payment();
        ((Entity) aitPayment1).Id = ((Entity) entity).Id;
        ait_payment aitPayment2 = aitPayment1;
        aitPayment2.ait_paymentstatus = new OptionSetValue(914600003);
        this.CrmService.Update((Entity) aitPayment2);
      }
    }
  }
}
