// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.Tribe
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_tribe", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_tribe")]
  public class Tribe : EntityBase
  {
    public Tribe(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.UpdateBQIncludedAsChild();
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.UpdateBQIncludedAsChild();
      this.UpdateName();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.UpdateBQIncludedAsParent();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.UpdateBQIncludedAsParent();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_tribe>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_tribe>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_tribe aitTribe1 = (ait_tribe) entityInput;
      ait_tribe aitTribe2 = (ait_tribe) preImage;
      string entityValue = FormatLibrary.GetEntityValue(aitTribe1.ait_shortname, aitTribe2.ait_shortname);
      if (string.IsNullOrEmpty(entityValue))
        entityValue = FormatLibrary.GetEntityValue(aitTribe1.ait_officialname, aitTribe2.ait_officialname);
      return entityValue;
    }

    private void UpdateBQIncludedAsParent()
    {
      ait_tribe inputEntity = this.GetInputEntity<ait_tribe>(this.ActionType, Global.Stage.PRE);
      if (inputEntity.ait_parenttribe != null)
        return;
      this.UpdateChildTribes(inputEntity, inputEntity.ait_includeintribalbq);
    }

    private void UpdateChildTribes(ait_tribe tribe, bool? includeInParentBQ)
    {
      EntityCollection referencedEntities = EntityLibrary.GetAllReferencedEntities((IOrganizationService) this.CrmService, "ait_tribe", "ait_parenttribe", tribe.ToEntityReference(), true);
      if (referencedEntities == null)
        return;
      foreach (ait_tribe entity in (Collection<Entity>) referencedEntities.Entities)
      {
        bool? includeintribalbq = entity.ait_includeintribalbq;
        bool? nullable = includeInParentBQ;
        if (!(includeintribalbq.GetValueOrDefault() == nullable.GetValueOrDefault() & includeintribalbq.HasValue == nullable.HasValue))
        {
          entity.ait_includeintribalbq = includeInParentBQ;
          this.CrmService.Update((Entity) entity);
        }
        this.UpdateChildTribes(entity, includeInParentBQ);
      }
    }

    private void UpdateBQIncludedAsChild()
    {
      ait_tribe inputEntity = this.GetInputEntity<ait_tribe>(this.ActionType, Global.Stage.PRE);
      if (inputEntity.ait_parenttribe == null)
        return;
      ait_tribe topTribe = this.GetTopTribe(inputEntity);
      bool? includeintribalbq1 = inputEntity.ait_includeintribalbq;
      bool? includeintribalbq2 = topTribe.ait_includeintribalbq;
      if (!(includeintribalbq1.GetValueOrDefault() == includeintribalbq2.GetValueOrDefault() & includeintribalbq1.HasValue == includeintribalbq2.HasValue))
        inputEntity.ait_includeintribalbq = topTribe.ait_includeintribalbq;
    }

    private ait_tribe GetTopTribe(ait_tribe tribe)
    {
      ait_tribe topTribe = tribe;
      if (tribe.ait_parenttribe != null)
        topTribe = this.GetTopTribe((ait_tribe) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, tribe.ait_parenttribe));
      return topTribe;
    }
  }
}
