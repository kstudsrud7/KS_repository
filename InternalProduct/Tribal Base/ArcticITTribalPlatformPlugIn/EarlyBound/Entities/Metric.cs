// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Metric
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("metric")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Metric : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "metric";
    public const string EntitySchemaName = "Metric";
    public const string PrimaryIdAttribute = "metricid";
    public const string PrimaryNameAttribute = "name";

    public Metric()
      : base("metric")
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

    [AttributeLogicalName("amountdatatype")]
    public OptionSetValue AmountDataType
    {
      get => this.GetAttributeValue<OptionSetValue>("amountdatatype");
      set
      {
        this.OnPropertyChanging(nameof (AmountDataType));
        this.SetAttributeValue("amountdatatype", (object) value);
        this.OnPropertyChanged(nameof (AmountDataType));
      }
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (CreatedOnBehalfBy));
        this.SetAttributeValue("createdonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (CreatedOnBehalfBy));
      }
    }

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("importsequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (ImportSequenceNumber));
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged(nameof (ImportSequenceNumber));
      }
    }

    [AttributeLogicalName("isamount")]
    public bool? IsAmount
    {
      get => this.GetAttributeValue<bool?>("isamount");
      set
      {
        this.OnPropertyChanging(nameof (IsAmount));
        this.SetAttributeValue("isamount", (object) value);
        this.OnPropertyChanged(nameof (IsAmount));
      }
    }

    [AttributeLogicalName("isstretchtracked")]
    public bool? IsStretchTracked
    {
      get => this.GetAttributeValue<bool?>("isstretchtracked");
      set
      {
        this.OnPropertyChanging(nameof (IsStretchTracked));
        this.SetAttributeValue("isstretchtracked", (object) value);
        this.OnPropertyChanged(nameof (IsStretchTracked));
      }
    }

    [AttributeLogicalName("metricid")]
    public Guid? MetricId
    {
      get => this.GetAttributeValue<Guid?>("metricid");
      set
      {
        this.OnPropertyChanging(nameof (MetricId));
        this.SetAttributeValue("metricid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (MetricId));
      }
    }

    [AttributeLogicalName("metricid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.MetricId = new Guid?(value);
    }

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (ModifiedOnBehalfBy));
        this.SetAttributeValue("modifiedonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (ModifiedOnBehalfBy));
      }
    }

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("overriddencreatedon");
      set
      {
        this.OnPropertyChanging(nameof (OverriddenCreatedOn));
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged(nameof (OverriddenCreatedOn));
      }
    }

    [AttributeLogicalName("statecode")]
    public MetricState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new MetricState?((MetricState) Enum.ToObject(typeof (MetricState), attributeValue.Value)) : new MetricState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (statecode));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (statecode), (object) null);
        else
          this.SetAttributeValue(nameof (statecode), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (statecode));
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("statuscode");
      set
      {
        this.OnPropertyChanging(nameof (StatusCode));
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged(nameof (StatusCode));
      }
    }

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get => this.GetAttributeValue<int?>("timezoneruleversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleVersionNumber));
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneRuleVersionNumber));
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("metric_AsyncOperations")]
    public IEnumerable<AsyncOperation> metric_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (metric_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (metric_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (metric_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (metric_AsyncOperations));
      }
    }

    [RelationshipSchemaName("metric_goal")]
    public IEnumerable<Goal> metric_goal
    {
      get => this.GetRelatedEntities<Goal>(nameof (metric_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (metric_goal));
        this.SetRelatedEntities<Goal>(nameof (metric_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (metric_goal));
      }
    }

    [RelationshipSchemaName("metric_ProcessSessions")]
    public IEnumerable<ProcessSession> metric_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (metric_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (metric_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (metric_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (metric_ProcessSessions));
      }
    }

    [RelationshipSchemaName("metric_rollupfield")]
    public IEnumerable<RollupField> metric_rollupfield
    {
      get => this.GetRelatedEntities<RollupField>(nameof (metric_rollupfield), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (metric_rollupfield));
        this.SetRelatedEntities<RollupField>(nameof (metric_rollupfield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (metric_rollupfield));
      }
    }

    [RelationshipSchemaName("Metric_SyncErrors")]
    public IEnumerable<SyncError> Metric_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Metric_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Metric_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Metric_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Metric_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_metric")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_metric
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_metric), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_metric));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_metric), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_metric));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_metric_createdby")]
    public SystemUser lk_metric_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_metric_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_metric_createdonbehalfby")]
    public SystemUser lk_metric_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_metric_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_metric_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_metric_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_metric_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_metric_modifiedby")]
    public SystemUser lk_metric_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_metric_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_metric_modifiedonbehalfby")]
    public SystemUser lk_metric_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_metric_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_metric_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_metric_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_metric_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_metric")]
    public Organization organization_metric
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_metric), new EntityRole?());
    }

    public Metric(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["metricid"] = (object) base.Id;
            break;
          case "metricid":
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
