// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PluginTraceLog
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("plugintracelog")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PluginTraceLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "plugintracelog";
    public const string EntitySchemaName = "PluginTraceLog";
    public const string PrimaryIdAttribute = "plugintracelogid";
    public const string PrimaryNameAttribute = "typename";

    public PluginTraceLog()
      : base("plugintracelog")
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

    [AttributeLogicalName("configuration")]
    public string Configuration => this.GetAttributeValue<string>("configuration");

    [AttributeLogicalName("correlationid")]
    public Guid? CorrelationId => this.GetAttributeValue<Guid?>("correlationid");

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

    [AttributeLogicalName("depth")]
    public int? Depth => this.GetAttributeValue<int?>("depth");

    [AttributeLogicalName("exceptiondetails")]
    public string ExceptionDetails => this.GetAttributeValue<string>("exceptiondetails");

    [AttributeLogicalName("issystemcreated")]
    public bool? IsSystemCreated => this.GetAttributeValue<bool?>("issystemcreated");

    [AttributeLogicalName("messageblock")]
    public string MessageBlock => this.GetAttributeValue<string>("messageblock");

    [AttributeLogicalName("messagename")]
    public string MessageName => this.GetAttributeValue<string>("messagename");

    [AttributeLogicalName("mode")]
    public OptionSetValue Mode => this.GetAttributeValue<OptionSetValue>("mode");

    [AttributeLogicalName("operationtype")]
    public OptionSetValue OperationType => this.GetAttributeValue<OptionSetValue>("operationtype");

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("performanceconstructorduration")]
    public int? PerformanceConstructorDuration
    {
      get => this.GetAttributeValue<int?>("performanceconstructorduration");
    }

    [AttributeLogicalName("performanceconstructorstarttime")]
    public DateTime? PerformanceConstructorStartTime
    {
      get => this.GetAttributeValue<DateTime?>("performanceconstructorstarttime");
    }

    [AttributeLogicalName("performanceexecutionduration")]
    public int? PerformanceExecutionDuration
    {
      get => this.GetAttributeValue<int?>("performanceexecutionduration");
    }

    [AttributeLogicalName("performanceexecutionstarttime")]
    public DateTime? PerformanceExecutionStartTime
    {
      get => this.GetAttributeValue<DateTime?>("performanceexecutionstarttime");
    }

    [AttributeLogicalName("persistencekey")]
    public Guid? PersistenceKey => this.GetAttributeValue<Guid?>("persistencekey");

    [AttributeLogicalName("pluginstepid")]
    public Guid? PluginStepId => this.GetAttributeValue<Guid?>("pluginstepid");

    [AttributeLogicalName("plugintracelogid")]
    public Guid? PluginTraceLogId => this.GetAttributeValue<Guid?>("plugintracelogid");

    [AttributeLogicalName("plugintracelogid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("primaryentity")]
    public string PrimaryEntity => this.GetAttributeValue<string>("primaryentity");

    [AttributeLogicalName("profile")]
    public string Profile => this.GetAttributeValue<string>("profile");

    [AttributeLogicalName("requestid")]
    public Guid? RequestId => this.GetAttributeValue<Guid?>("requestid");

    [AttributeLogicalName("secureconfiguration")]
    public string SecureConfiguration => this.GetAttributeValue<string>("secureconfiguration");

    [AttributeLogicalName("typename")]
    public string TypeName => this.GetAttributeValue<string>("typename");

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_plugintracelog")]
    public SystemUser createdby_plugintracelog
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_plugintracelog), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_plugintracelogbase_createdonbehalfby")]
    public SystemUser lk_plugintracelogbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_plugintracelogbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_plugintracelogbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_plugintracelogbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_plugintracelogbase_createdonbehalfby));
      }
    }

    public PluginTraceLog(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["plugintracelogid"] = (object) base.Id;
            break;
          case "plugintracelogid":
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
