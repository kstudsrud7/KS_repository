// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.WithholdingTypePlugin
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
  [CRMMetadata(EntityName = "ait_withholdingtype", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_withholdingtype")]
  public class WithholdingTypePlugin : EntityBase
  {
    public WithholdingTypePlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.CreatePaymentWithholdings();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_withholdingtype>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_withholdingtype>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string formattedName = ((ait_withholdingtype) entityInput).ait_name;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_withholdingtype", "ait_name");
      return formattedName;
    }

    private void CreatePaymentWithholdings()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag1 = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag1 = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag1)
        return;
      this.CrmService.Trace("TP: Entering WithholdingTypePlugin.CreatePaymentWithholdings");
      ait_withholdingtype inputEntity = this.GetInputEntity<ait_withholdingtype>(this.ActionType);
      int num;
      if (this.HasAttributeChanged("ait_autocreatewithholding"))
      {
        bool? autocreatewithholding = inputEntity.ait_autocreatewithholding;
        bool flag2 = true;
        num = autocreatewithholding.GetValueOrDefault() == flag2 & autocreatewithholding.HasValue ? 1 : 0;
      }
      else
        num = 0;
      if (num == 0)
        return;
      foreach (Contact entity1 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "contact", true).Entities)
      {
        if (ContactPlugin.IsEligibleForWithholdingType((IOrganizationService) this.CrmService, entity1, inputEntity))
        {
          foreach (ait_withholdingtype_pmtpaymenttype entity2 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_withholdingtype_pmtpaymenttype", "ait_withholdingtypeid", (object) ((Entity) inputEntity).Id, false).Entities)
          {
            foreach (ait_pmteligibility entity3 in (Collection<Entity>) PaymentEligibilityPlugin.GetAllForContactAndPaymentType((IOrganizationService) this.CrmService, ((Entity) entity1).Id, entity2.ait_pmtpaymenttypeid.Value).Entities)
            {
              EntityCollection paymentEligibility = WithholdingPlugin.GetAllForContactWithholdingTypeAndPaymentEligibility((IOrganizationService) this.CrmService, ((Entity) entity1).Id, ((Entity) inputEntity).Id, ((Entity) entity3).Id);
              if (paymentEligibility == null || ((Collection<Entity>) paymentEligibility.Entities).Count <= 0)
                WithholdingPlugin.Create((IOrganizationService) this.CrmService, entity1, inputEntity, entity3);
            }
          }
        }
      }
    }
  }
}
