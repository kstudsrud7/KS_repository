// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.BloodQuantumPlugin
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

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_bloodquantum", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_bloodquantum")]
  public class BloodQuantumPlugin : EntityBase
  {
    public BloodQuantumPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostDeleting += new EntityBase.PluginOnPostDeleteHandler(this.Execute_OnPluginPostDeleting);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.UpdateBloodQuantumDecimal();
      this.UpdateFilterTribe();
      this.UpdateSystemGeneratedFlag();
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.UpdateBloodQuantumDecimal();
      this.UpdateFilterTribe();
      this.UpdateName();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.RecalculateBloodQuantumTotalsForMember();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.RecalculateBloodQuantumTotalsForMember();
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      this.RecalculateBloodQuantumTotalsForMember();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_bloodquantum>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_bloodquantum>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_bloodquantum aitBloodquantum1 = (ait_bloodquantum) entityInput;
      ait_bloodquantum aitBloodquantum2 = (ait_bloodquantum) preImage;
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitBloodquantum1.ait_memberprofile, aitBloodquantum2.ait_memberprofile), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitBloodquantum1.ait_Tribe, aitBloodquantum2.ait_Tribe), FormatLibrary.GetEntityValue(aitBloodquantum1.ait_bloodquantumfraction, aitBloodquantum2.ait_bloodquantumfraction));
    }

    private void RecalculateBloodQuantumTotalsForMember()
    {
      if (((IExecutionContext) this.CrmService.GetTopParentContext()).MessageName.ToLower().IndexOf("ait_") == 0 && this.ActionType == Global.ActionType.DELETE || ((IExecutionContext) this.CrmService.PluginContext).Depth > 1)
        return;
      ait_bloodquantum inputEntity1 = this.ActionType == Global.ActionType.DELETE ? (ait_bloodquantum) null : this.GetInputEntity<ait_bloodquantum>();
      ait_bloodquantum inputEntity2 = this.GetInputEntity<ait_bloodquantum>(this.ActionType);
      if (inputEntity2 == null || inputEntity2.ait_memberprofile == null)
        return;
      ait_memberprofile entity = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputEntity2.ait_memberprofile, false);
      if (entity != null && AttributeLibrary.Compare(entity.ait_bqcalculationlocked, 750000001) || this.ActionType != Global.ActionType.DELETE && this.IsBloodQuantumSystemGenerated(inputEntity1))
        return;
      new BloodQuantumLibrary(this.CrmService, inputEntity2.ait_memberprofile).UpdateBloodQuantumForIndividual();
    }

    private void UpdateBloodQuantumDecimal()
    {
      ait_bloodquantum inputEntity = this.GetInputEntity<ait_bloodquantum>();
      if (this.IsBloodQuantumSystemGenerated(inputEntity) || inputEntity.ait_bloodquantumfraction == null)
        return;
      inputEntity.ait_bloodquantumdecimal = new Decimal?((Decimal) Fraction.Parse(inputEntity.ait_bloodquantumfraction));
    }

    private void UpdateFilterTribe()
    {
      EntityReference entityReference = (EntityReference) null;
      ait_bloodquantum inputEntity = this.GetInputEntity<ait_bloodquantum>();
      if (inputEntity != null && inputEntity.ait_confederatedtribefilter != null)
        return;
      ait_bloodquantum entityFromPreImage = this.GetEntityFromPreImage<ait_bloodquantum>();
      if (entityFromPreImage != null && entityFromPreImage.ait_confederatedtribefilter != null)
        return;
      if (inputEntity != null)
        entityReference = inputEntity.ait_Tribe;
      if (entityReference == null && entityFromPreImage != null)
        entityReference = entityFromPreImage.ait_Tribe;
      if (entityReference == null)
        return;
      ait_tribe entity = (ait_tribe) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, entityReference);
      if (entity != null)
      {
        if (entity.ait_parenttribe != null && !AttributeLibrary.Compare(inputEntity.ait_confederatedtribefilter, entity.ait_parenttribe))
          inputEntity.ait_confederatedtribefilter = entity.ait_parenttribe;
        else if (entity.ait_parenttribe == null && !AttributeLibrary.Compare(inputEntity.ait_confederatedtribefilter, entity.ToEntityReference()))
          inputEntity.ait_confederatedtribefilter = entity.ToEntityReference();
      }
    }

    private void UpdateSystemGeneratedFlag()
    {
      ait_bloodquantum inputEntity = this.GetInputEntity<ait_bloodquantum>();
      if (!this.IsBloodQuantumSystemGenerated(this.GetEntityFromPreImage<ait_bloodquantum>()))
        return;
      inputEntity.ait_systemgenerated = new bool?(true);
    }

    private bool IsBloodQuantumSystemGenerated(ait_bloodquantum bloodquantum)
    {
      int num;
      if (bloodquantum != null && bloodquantum.ait_systemgenerated.HasValue)
      {
        bool? aitSystemgenerated = bloodquantum.ait_systemgenerated;
        bool flag = true;
        num = aitSystemgenerated.GetValueOrDefault() == flag & aitSystemgenerated.HasValue ? 1 : 0;
      }
      else
        num = 0;
      return num != 0;
    }
  }
}
