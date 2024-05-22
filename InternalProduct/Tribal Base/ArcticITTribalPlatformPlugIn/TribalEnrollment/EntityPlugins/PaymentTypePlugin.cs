// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.PaymentTypePlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.TribalEnrollment.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_pmtpaymenttype", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_pmtpaymenttype")]
  public class PaymentTypePlugin : EntityBase
  {
    public PaymentTypePlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.CreatePaymentEligibilities();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.CreatePaymentEligibilities();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_pmtpaymenttype>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_pmtpaymenttype>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string formattedName = ((ait_pmtpaymenttype) entityInput).ait_name;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_pmtpaymenttype", "ait_name");
      return formattedName;
    }

    private void CreatePaymentEligibilities()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag1 = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag1 = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag1)
        return;
      this.CrmService.Trace("TP: Entering PaymentTypePlugin.CreatePaymentEligibilities");
      ait_pmtpaymenttype inputEntity = this.GetInputEntity<ait_pmtpaymenttype>(this.ActionType);
      bool? nullable;
      int num1;
      if (this.HasAttributeChanged("ait_autocreateeligibilities"))
      {
        nullable = inputEntity.ait_autocreateeligibilities;
        bool flag2 = true;
        num1 = nullable.GetValueOrDefault() == flag2 & nullable.HasValue ? 1 : 0;
      }
      else
        num1 = 0;
      if (num1 == 0)
        return;
      foreach (Contact entity1 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "contact", true).Entities)
      {
        if (ContactPlugin.IsEligibleForPaymentType((IOrganizationService) this.CrmService, entity1, inputEntity))
        {
          EntityCollection contactAndPaymentType = PaymentEligibilityPlugin.GetAllForContactAndPaymentType((IOrganizationService) this.CrmService, ((Entity) entity1).Id, ((Entity) inputEntity).Id);
          if (contactAndPaymentType == null || ((Collection<Entity>) contactAndPaymentType.Entities).Count <= 0)
          {
            PaymentEligibilityPlugin.Create((IOrganizationService) this.CrmService, entity1, inputEntity);
          }
          else
          {
            foreach (ait_withholdingtype_pmtpaymenttype entity2 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_withholdingtype_pmtpaymenttype", "ait_pmtpaymenttypeid", (object) ((Entity) inputEntity).Id, false).Entities)
            {
              ait_withholdingtype entity3 = (ait_withholdingtype) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, "ait_withholdingtype", entity2.ait_withholdingtypeid.Value);
              nullable = entity3.ait_autocreatewithholding;
              bool flag3 = false;
              int num2;
              if (!(nullable.GetValueOrDefault() == flag3 & nullable.HasValue))
              {
                ait_withholdingtypeState? statecode = entity3.statecode;
                ait_withholdingtypeState withholdingtypeState = ait_withholdingtypeState.Inactive;
                if (!(statecode.GetValueOrDefault() == withholdingtypeState & statecode.HasValue))
                {
                  num2 = !ContactPlugin.IsEligibleForWithholdingType((IOrganizationService) this.CrmService, entity1, entity3) ? 1 : 0;
                  goto label_18;
                }
              }
              num2 = 1;
label_18:
              if (num2 == 0)
              {
                foreach (ait_pmteligibility entity4 in (Collection<Entity>) contactAndPaymentType.Entities)
                {
                  EntityCollection paymentEligibility = WithholdingPlugin.GetAllForContactWithholdingTypeAndPaymentEligibility((IOrganizationService) this.CrmService, ((Entity) entity1).Id, ((Entity) entity3).Id, ((Entity) entity4).Id);
                  if (paymentEligibility == null || ((Collection<Entity>) paymentEligibility.Entities).Count <= 0)
                    WithholdingPlugin.Create((IOrganizationService) this.CrmService, entity1, entity3, entity4);
                }
              }
            }
          }
        }
      }
    }
  }
}
