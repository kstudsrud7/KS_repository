// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.MemberProfileMembershipCategory
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
  [CRMMetadata(EntityName = "ait_memberprofilemembershipcategory", CrmEntityType = "ArcticIT.CrmFramework.Plugins.EarlyBound.ait_memberprofilemembershipcategory")]
  public class MemberProfileMembershipCategory : EntityBase
  {
    public MemberProfileMembershipCategory(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.UpdateName();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_memberprofilemembershipcategory>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_memberprofilemembershipcategory>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_memberprofilemembershipcategory memberprofilemembershipcategory1 = (ait_memberprofilemembershipcategory) entityInput;
      ait_memberprofilemembershipcategory memberprofilemembershipcategory2 = (ait_memberprofilemembershipcategory) preImage;
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, memberprofilemembershipcategory1.ait_memberprofile, memberprofilemembershipcategory2.ait_memberprofile), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, memberprofilemembershipcategory1.ait_membershipcategory, memberprofilemembershipcategory2.ait_membershipcategory));
    }
  }
}
