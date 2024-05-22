// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.PaymentTransactionPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_pmttransaction", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_pmttransaction")]
  public class PaymentTransactionPlugin : EntityBase
  {
    public PaymentTransactionPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostDeleting += new EntityBase.PluginOnPostDeleteHandler(this.Execute_OnPluginPostDeleting);
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      this.UpdateRelatedTransaction();
    }

    public static EntityCollection GetAllForPaymentEvent(
      IOrganizationService crmService,
      Guid paymentEventId)
    {
      if (paymentEventId == Guid.Empty)
        return (EntityCollection) null;
      return EntityLibrary.GetAllEntities(crmService, "ait_pmttransaction", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_pmtevent", (ConditionOperator) 0, (object) paymentEventId)
      }, true);
    }

    public static EntityReference CreateFromEligibility(
      IOrganizationService crmService,
      EntityReference paymentEventId,
      EntityReference paymentTypeId,
      ait_pmteligibility paymentEligibility)
    {
      OrganizationRequest organizationRequest = new OrganizationRequest()
      {
        RequestName = "ait_GlobalCreatePaymentTransactions"
      };
      organizationRequest["PaymentEventID"] = (object) paymentEventId;
      organizationRequest["PaymentTypeID"] = (object) paymentTypeId;
      organizationRequest["PaymentEligibilityID"] = (object) paymentEligibility.ToEntityReference();
      organizationRequest["ContactID"] = paymentEligibility.ait_paymentco == null ? (object) paymentEligibility.ait_Member : (object) paymentEligibility.ait_paymentco;
      return (EntityReference) ((DataCollection<string, object>) crmService.Execute(organizationRequest).Results)["PaymentTransactionID"];
    }

    public static EntityReference CreateFromRequest(
      IOrganizationService crmService,
      EntityReference paymentEventId,
      ait_payment paymentRequest)
    {
      OrganizationRequest organizationRequest = new OrganizationRequest()
      {
        RequestName = "ait_GlobalCreateProgramPayment"
      };
      organizationRequest["PaymentEventId"] = (object) paymentEventId;
      organizationRequest["PaymentRequestId"] = (object) paymentRequest.ToEntityReference();
      if (paymentRequest.ait_payeeclientprofile != null)
      {
        ait_clientprofile entity = (ait_clientprofile) EntityLibrary.GetEntity(crmService, paymentRequest.ait_payeeclientprofile);
        organizationRequest["ContactId"] = (object) entity.ait_Contact;
      }
      else
        organizationRequest["CompanyId"] = (object) paymentRequest.ait_payeecompany;
      return (EntityReference) ((DataCollection<string, object>) crmService.Execute(organizationRequest).Results)["PaymentTransactionId"];
    }

    private void UpdateRelatedTransaction()
    {
      ait_pmttransaction inputEntity = this.GetInputEntity<ait_pmttransaction>(this.ActionType);
      if (inputEntity.ait_payment == null)
        return;
      OrganizationRequest request = new OrganizationRequest()
      {
        RequestName = "ait_PaymentRequestTransactionDeleted"
      };
      request["Target"] = (object) inputEntity.ait_payment;
      this.CrmService.ImpersonateAdmin().Execute(request);
    }
  }
}
