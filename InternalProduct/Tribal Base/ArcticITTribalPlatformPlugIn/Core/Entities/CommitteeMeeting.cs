// Decompiled with JetBrains decompiler
// Type: ArcticIT.Core.Entities.CommitteeMeeting
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
namespace ArcticIT.Core.Entities
{
  [CRMMetadata(EntityName = "ait_committeemeeting", CrmEntityType = "ArcticIT.CrmFramework.Plugins.EarlyBound.ait_committeemeeting")]
  public class CommitteeMeeting : EntityBase
  {
    public CommitteeMeeting(
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
      return (Entity) this.GetInputEntity<ait_committeemeeting>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_committeemeeting>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_committeemeeting committeemeeting1 = (ait_committeemeeting) entityInput;
      ait_committeemeeting committeemeeting2 = (ait_committeemeeting) preImage;
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, committeemeeting1.ait_committee, committeemeeting2.ait_committee), FormatLibrary.GetFormatValue(committeemeeting2.ait_meetingdate));
    }
  }
}
