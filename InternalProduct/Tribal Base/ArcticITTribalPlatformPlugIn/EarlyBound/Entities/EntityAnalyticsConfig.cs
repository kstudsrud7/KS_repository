// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.EntityAnalyticsConfig
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("entityanalyticsconfig")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class EntityAnalyticsConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "entityanalyticsconfig";
    public const string EntitySchemaName = "EntityAnalyticsConfig";
    public const string PrimaryIdAttribute = "entityanalyticsconfigid";
    public const string PrimaryNameAttribute = "parententitylogicalname";

    public EntityAnalyticsConfig()
      : base("entityanalyticsconfig")
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    private void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnPropertyChanging(string propertyName)
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, new PropertyChangingEventArgs(propertyName));
    }

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("entityanalyticsconfigid")]
    public Guid? EntityAnalyticsConfigId
    {
      get => this.GetAttributeValue<Guid?>("entityanalyticsconfigid");
      set
      {
        this.OnPropertyChanging(nameof (EntityAnalyticsConfigId));
        this.SetAttributeValue("entityanalyticsconfigid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (EntityAnalyticsConfigId));
      }
    }

    [AttributeLogicalName("entityanalyticsconfigid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.EntityAnalyticsConfigId = new Guid?(value);
    }

    [AttributeLogicalName("isenabledforadls")]
    public bool? IsEnabledForADLS
    {
      get => this.GetAttributeValue<bool?>("isenabledforadls");
      set
      {
        this.OnPropertyChanging(nameof (IsEnabledForADLS));
        this.SetAttributeValue("isenabledforadls", (object) value);
        this.OnPropertyChanged(nameof (IsEnabledForADLS));
      }
    }

    [AttributeLogicalName("isenabledfortimeseries")]
    public bool? IsEnabledForTimeSeries
    {
      get => this.GetAttributeValue<bool?>("isenabledfortimeseries");
      set
      {
        this.OnPropertyChanging(nameof (IsEnabledForTimeSeries));
        this.SetAttributeValue("isenabledfortimeseries", (object) value);
        this.OnPropertyChanged(nameof (IsEnabledForTimeSeries));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("parententityid")]
    public EntityReference ParentEntityId
    {
      get => this.GetAttributeValue<EntityReference>("parententityid");
      set
      {
        this.OnPropertyChanging(nameof (ParentEntityId));
        this.SetAttributeValue("parententityid", (object) value);
        this.OnPropertyChanged(nameof (ParentEntityId));
      }
    }

    [AttributeLogicalName("parententitylogicalname")]
    public string ParentEntityLogicalName
    {
      get => this.GetAttributeValue<string>("parententitylogicalname");
      set
      {
        this.OnPropertyChanging(nameof (ParentEntityLogicalName));
        this.SetAttributeValue("parententitylogicalname", (object) value);
        this.OnPropertyChanged(nameof (ParentEntityLogicalName));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("entityanalyticsconfig_AsyncOperations")]
    public IEnumerable<AsyncOperation> entityanalyticsconfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (entityanalyticsconfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (entityanalyticsconfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_AsyncOperations));
      }
    }

    [RelationshipSchemaName("entityanalyticsconfig_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> entityanalyticsconfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (entityanalyticsconfig_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (entityanalyticsconfig_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("entityanalyticsconfig_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> entityanalyticsconfig_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (entityanalyticsconfig_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (entityanalyticsconfig_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("entityanalyticsconfig_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> entityanalyticsconfig_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (entityanalyticsconfig_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (entityanalyticsconfig_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("entityanalyticsconfig_SyncErrors")]
    public IEnumerable<SyncError> entityanalyticsconfig_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (entityanalyticsconfig_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (entityanalyticsconfig_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_SyncErrors));
      }
    }

    [RelationshipSchemaName("entityanalyticsconfig_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> entityanalyticsconfig_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (entityanalyticsconfig_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (entityanalyticsconfig_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_entityanalyticsconfig")]
    public Organization organization_entityanalyticsconfig
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_entityanalyticsconfig), new EntityRole?());
      }
    }

    public EntityAnalyticsConfig(object anonymousType)
      : this()
    {
      foreach (PropertyInfo property in anonymousType.GetType().GetProperties())
      {
        object obj = property.GetValue(anonymousType, (object[]) null);
        string str = property.Name.ToLower();
        if (str.EndsWith("enum") && obj.GetType().BaseType == typeof (Enum))
        {
          obj = (object) new OptionSetValue((int) obj);
          str = str.Remove(str.Length - "enum".Length);
        }
        switch (str)
        {
          case "id":
            base.Id = (Guid) obj;
            ((DataCollection<string, object>) this.Attributes)["entityanalyticsconfigid"] = (object) base.Id;
            break;
          case "entityanalyticsconfigid":
            Guid? nullable = (Guid?) obj;
            if (nullable.HasValue)
            {
              base.Id = nullable.Value;
              ((DataCollection<string, object>) this.Attributes)[str] = (object) base.Id;
              break;
            }
            continue;
          case "formattedvalues":
            ((DataCollection<string, string>) this.FormattedValues).AddRange((IEnumerable<KeyValuePair<string, string>>) obj);
            break;
          default:
            ((DataCollection<string, object>) this.Attributes)[str] = obj;
            break;
        }
      }
    }
  }
}
