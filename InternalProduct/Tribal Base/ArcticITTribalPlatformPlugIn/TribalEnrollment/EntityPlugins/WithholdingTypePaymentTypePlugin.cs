// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.WithholdingTypePaymentTypePlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.TribalEnrollment.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_withholdingtype_pmtpaymenttype", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_withholdingtype_pmtpaymenttype")]
  public class WithholdingTypePaymentTypePlugin : EntityBase
  {
    public WithholdingTypePaymentTypePlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostAssociateChanging += new EntityBase.PluginPostAssociateHandler(this.Execute_OnPluginPostAssociateChanging);
    }

    private void Execute_OnPluginPostAssociateChanging(
      object sender,
      EntityBase.PluginPostAssociateHandlerEventArgs e)
    {
      if (!(((Relationship) ((DataCollection<string, object>) ((IExecutionContext) this.CrmService.PluginContext).InputParameters)["Relationship"]).SchemaName == "ait_withholdingtype_pmtpaymenttype"))
        return;
      this.CreatePaymentWithholdings();
    }

    private void CreatePaymentWithholdings()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag1 = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag1 = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag1)
        return;
      this.CrmService.Trace("TP: Entering WithholdingTypePaymentTypePlugin.CreatePaymentWithholdings");
      EntityReferenceCollection inputParameter = ((DataCollection<string, object>) ((IExecutionContext) this.CrmService.PluginContext).InputParameters)["RelatedEntities"] as EntityReferenceCollection;
      EntityReference targetEntityReference1;
      EntityReference targetEntityReference2;
      if (this.TargetEntityReference.LogicalName == "ait_withholdingtype")
      {
        targetEntityReference1 = this.TargetEntityReference;
        targetEntityReference2 = ((Collection<EntityReference>) inputParameter)[0];
      }
      else
      {
        targetEntityReference2 = this.TargetEntityReference;
        targetEntityReference1 = ((Collection<EntityReference>) inputParameter)[0];
      }
      ait_withholdingtype entity1 = (ait_withholdingtype) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, targetEntityReference1);
      bool? autocreatewithholding = entity1.ait_autocreatewithholding;
      bool flag2 = true;
      if (!(autocreatewithholding.GetValueOrDefault() == flag2 & autocreatewithholding.HasValue))
        return;
      foreach (Contact entity2 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "contact", true).Entities)
      {
        if (ContactPlugin.IsEligibleForWithholdingType((IOrganizationService) this.CrmService, entity2, entity1))
        {
          foreach (ait_pmteligibility entity3 in (Collection<Entity>) PaymentEligibilityPlugin.GetAllForContactAndPaymentType((IOrganizationService) this.CrmService, ((Entity) entity2).Id, targetEntityReference2.Id).Entities)
            WithholdingPlugin.Create((IOrganizationService) this.CrmService, entity2, entity1, entity3);
        }
      }
    }
  }
}
