// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.ValidateDeleteAggregationPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;

#nullable disable
namespace ArcticIT.CrmFramework.Plugins
{
  [CRMMetadata(EntityName = "", CrmEntityType = "")]
  internal class ValidateDeleteAggregationPlugin : EntityBase
  {
    public List<string> _entityVerificationList;

    public ValidateDeleteAggregationPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.OnPluginPreDeleting += new EntityBase.PluginOnPreDeleteHandler(this.Execute_OnPluginPreDeleting);
      this.ParseConfiguration();
    }

    private void Execute_OnPluginPreDeleting(
      object sender,
      EntityBase.PluginOnPreDeleteHandlerEventArgs e)
    {
      this.ValidateDelete();
    }

    public List<string> EntityVerificationList => this._entityVerificationList;

    private void ParseConfiguration()
    {
      this._entityVerificationList = new List<string>();
      if (string.IsNullOrWhiteSpace(this.UnsecuredConfiguration) || !this.UnsecuredConfiguration.Contains(";"))
        return;
      string str1 = this.UnsecuredConfiguration.Split(';')[1];
      if (!string.IsNullOrWhiteSpace(str1))
      {
        string str2 = str1;
        char[] chArray = new char[1]{ ',' };
        foreach (string str3 in str2.Split(chArray))
          this.EntityVerificationList.Add(str3.Trim());
      }
    }

    private void ValidateDelete()
    {
      throw new InvalidPluginExecutionException(string.Format("Cannot delete a {0} when a {1} references it.", (object) MetadataLibrary.GetEntityDisplayName((IOrganizationService) this.CrmService, this.EntityLogicalName), (object) MetadataLibrary.GetEntityDisplayName((IOrganizationService) this.CrmService, this.EntityVerificationList[0])));
    }
  }
}
