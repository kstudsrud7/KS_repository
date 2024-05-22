// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.PaymentTransactionDeductionPlugin
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
  [CRMMetadata(EntityName = "ait_pmttransactiondeduction", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_pmttransactiondeduction")]
  public class PaymentTransactionDeductionPlugin : EntityBase
  {
    public PaymentTransactionDeductionPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
    }

    public static void Create(
      IOrganizationService crmService,
      EntityReference paymentTransactionId,
      EntityReference paymentWithholdingId,
      EntityReference withholdingTypeId,
      Money deductionAmount)
    {
      OrganizationRequest organizationRequest = new OrganizationRequest()
      {
        RequestName = "ait_PaymentTransactionCreatePaymentDeduction"
      };
      organizationRequest["Target"] = (object) paymentTransactionId;
      organizationRequest["PaymentWithholdingID"] = (object) paymentWithholdingId;
      organizationRequest["WithholdingTypeID"] = (object) withholdingTypeId;
      organizationRequest["DeductionAmount2"] = (object) deductionAmount.Value;
      crmService.Execute(organizationRequest);
    }

    public static Money GetDeductionAmount(
      int amountType,
      Money transactionAmount,
      Decimal? deductionPercentage,
      Money deductionAmount)
    {
      return new Money()
      {
        Value = amountType != 750000001 ? deductionAmount.Value : deductionPercentage.Value / 100M * transactionAmount.Value
      };
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_pmttransactiondeduction>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_pmttransactiondeduction>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string formattedName = ((ait_pmttransactiondeduction) entityInput).ait_name;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_pmttransactiondeduction", "ait_name");
      return formattedName;
    }
  }
}
