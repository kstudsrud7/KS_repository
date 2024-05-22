// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RollupField
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("rollupfield")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RollupField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "rollupfield";
    public const string EntitySchemaName = "RollupField";
    public const string PrimaryIdAttribute = "rollupfieldid";

    public RollupField()
      : base("rollupfield")
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

    [AttributeLogicalName("dateattribute")]
    public string DateAttribute
    {
      get => this.GetAttributeValue<string>("dateattribute");
      set
      {
        this.OnPropertyChanging(nameof (DateAttribute));
        this.SetAttributeValue("dateattribute", (object) value);
        this.OnPropertyChanged(nameof (DateAttribute));
      }
    }

    [AttributeLogicalName("entityfordateattribute")]
    public string EntityForDateAttribute
    {
      get => this.GetAttributeValue<string>("entityfordateattribute");
      set
      {
        this.OnPropertyChanging(nameof (EntityForDateAttribute));
        this.SetAttributeValue("entityfordateattribute", (object) value);
        this.OnPropertyChanged(nameof (EntityForDateAttribute));
      }
    }

    [AttributeLogicalName("goalattribute")]
    public string GoalAttribute
    {
      get => this.GetAttributeValue<string>("goalattribute");
      set
      {
        this.OnPropertyChanging(nameof (GoalAttribute));
        this.SetAttributeValue("goalattribute", (object) value);
        this.OnPropertyChanged(nameof (GoalAttribute));
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

    [AttributeLogicalName("isstateparententityattribute")]
    public bool? IsStateParentEntityAttribute
    {
      get => this.GetAttributeValue<bool?>("isstateparententityattribute");
      set
      {
        this.OnPropertyChanging(nameof (IsStateParentEntityAttribute));
        this.SetAttributeValue("isstateparententityattribute", (object) value);
        this.OnPropertyChanged(nameof (IsStateParentEntityAttribute));
      }
    }

    [AttributeLogicalName("metricid")]
    public EntityReference MetricId
    {
      get => this.GetAttributeValue<EntityReference>("metricid");
      set
      {
        this.OnPropertyChanging(nameof (MetricId));
        this.SetAttributeValue("metricid", (object) value);
        this.OnPropertyChanged(nameof (MetricId));
      }
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("rollupfieldid")]
    public Guid? RollupFieldId
    {
      get => this.GetAttributeValue<Guid?>("rollupfieldid");
      set
      {
        this.OnPropertyChanging(nameof (RollupFieldId));
        this.SetAttributeValue("rollupfieldid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RollupFieldId));
      }
    }

    [AttributeLogicalName("rollupfieldid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RollupFieldId = new Guid?(value);
    }

    [AttributeLogicalName("sourceattribute")]
    public string SourceAttribute
    {
      get => this.GetAttributeValue<string>("sourceattribute");
      set
      {
        this.OnPropertyChanging(nameof (SourceAttribute));
        this.SetAttributeValue("sourceattribute", (object) value);
        this.OnPropertyChanged(nameof (SourceAttribute));
      }
    }

    [AttributeLogicalName("sourceentity")]
    public string SourceEntity
    {
      get => this.GetAttributeValue<string>("sourceentity");
      set
      {
        this.OnPropertyChanging(nameof (SourceEntity));
        this.SetAttributeValue("sourceentity", (object) value);
        this.OnPropertyChanged(nameof (SourceEntity));
      }
    }

    [AttributeLogicalName("sourcestate")]
    public int? SourceState
    {
      get => this.GetAttributeValue<int?>("sourcestate");
      set
      {
        this.OnPropertyChanging(nameof (SourceState));
        this.SetAttributeValue("sourcestate", (object) value);
        this.OnPropertyChanged(nameof (SourceState));
      }
    }

    [AttributeLogicalName("sourcestatus")]
    public int? SourceStatus
    {
      get => this.GetAttributeValue<int?>("sourcestatus");
      set
      {
        this.OnPropertyChanging(nameof (SourceStatus));
        this.SetAttributeValue("sourcestatus", (object) value);
        this.OnPropertyChanged(nameof (SourceStatus));
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

    [RelationshipSchemaName("rollupfield_AsyncOperations")]
    public IEnumerable<AsyncOperation> rollupfield_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (rollupfield_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (rollupfield_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (rollupfield_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (rollupfield_AsyncOperations));
      }
    }

    [RelationshipSchemaName("rollupfield_ProcessSessions")]
    public IEnumerable<ProcessSession> rollupfield_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (rollupfield_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (rollupfield_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (rollupfield_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (rollupfield_ProcessSessions));
      }
    }

    [RelationshipSchemaName("RollupField_SyncErrors")]
    public IEnumerable<SyncError> RollupField_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (RollupField_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (RollupField_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (RollupField_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RollupField_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_rollupfield")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_rollupfield
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_rollupfield), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_rollupfield));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_rollupfield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_rollupfield));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_rollupfield_createdby")]
    public SystemUser lk_rollupfield_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_rollupfield_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_rollupfield_createdonbehalfby")]
    public SystemUser lk_rollupfield_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_rollupfield_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_rollupfield_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_rollupfield_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_rollupfield_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_rollupfield_modifiedby")]
    public SystemUser lk_rollupfield_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_rollupfield_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_rollupfield_modifiedonbehalfby")]
    public SystemUser lk_rollupfield_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_rollupfield_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_rollupfield_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_rollupfield_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_rollupfield_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("metricid")]
    [RelationshipSchemaName("metric_rollupfield")]
    public Metric metric_rollupfield
    {
      get => this.GetRelatedEntity<Metric>(nameof (metric_rollupfield), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (metric_rollupfield));
        this.SetRelatedEntity<Metric>(nameof (metric_rollupfield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (metric_rollupfield));
      }
    }

    public RollupField(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["rollupfieldid"] = (object) base.Id;
            break;
          case "rollupfieldid":
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
