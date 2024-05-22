// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ProcessTrigger
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("processtrigger")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ProcessTrigger : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "processtrigger";
    public const string EntitySchemaName = "ProcessTrigger";
    public const string PrimaryIdAttribute = "processtriggerid";

    public ProcessTrigger()
      : base("processtrigger")
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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("controlname")]
    public string ControlName
    {
      get => this.GetAttributeValue<string>("controlname");
      set
      {
        this.OnPropertyChanging(nameof (ControlName));
        this.SetAttributeValue("controlname", (object) value);
        this.OnPropertyChanged(nameof (ControlName));
      }
    }

    [AttributeLogicalName("controltype")]
    public OptionSetValue ControlType
    {
      get => this.GetAttributeValue<OptionSetValue>("controltype");
      set
      {
        this.OnPropertyChanging(nameof (ControlType));
        this.SetAttributeValue("controltype", (object) value);
        this.OnPropertyChanged(nameof (ControlType));
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

    [AttributeLogicalName("event")]
    public string Event
    {
      get => this.GetAttributeValue<string>("event");
      set
      {
        this.OnPropertyChanging(nameof (Event));
        this.SetAttributeValue("event", (object) value);
        this.OnPropertyChanged(nameof (Event));
      }
    }

    [AttributeLogicalName("formid")]
    public EntityReference FormId
    {
      get => this.GetAttributeValue<EntityReference>("formid");
      set
      {
        this.OnPropertyChanging(nameof (FormId));
        this.SetAttributeValue("formid", (object) value);
        this.OnPropertyChanged(nameof (FormId));
      }
    }

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("methodid")]
    public Guid? MethodId
    {
      get => this.GetAttributeValue<Guid?>("methodid");
      set
      {
        this.OnPropertyChanging(nameof (MethodId));
        this.SetAttributeValue("methodid", (object) value);
        this.OnPropertyChanged(nameof (MethodId));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

    [AttributeLogicalName("pipelinestage")]
    public OptionSetValue PipelineStage
    {
      get => this.GetAttributeValue<OptionSetValue>("pipelinestage");
      set
      {
        this.OnPropertyChanging(nameof (PipelineStage));
        this.SetAttributeValue("pipelinestage", (object) value);
        this.OnPropertyChanged(nameof (PipelineStage));
      }
    }

    [AttributeLogicalName("primaryentitytypecode")]
    public string PrimaryEntityTypeCode
    {
      get => this.GetAttributeValue<string>("primaryentitytypecode");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityTypeCode));
        this.SetAttributeValue("primaryentitytypecode", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityTypeCode));
      }
    }

    [AttributeLogicalName("processid")]
    public EntityReference ProcessId
    {
      get => this.GetAttributeValue<EntityReference>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("processtriggerid")]
    public Guid? ProcessTriggerId
    {
      get => this.GetAttributeValue<Guid?>("processtriggerid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessTriggerId));
        this.SetAttributeValue("processtriggerid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ProcessTriggerId));
      }
    }

    [AttributeLogicalName("processtriggerid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ProcessTriggerId = new Guid?(value);
    }

    [AttributeLogicalName("processtriggeridunique")]
    public Guid? ProcessTriggerIdUnique => this.GetAttributeValue<Guid?>("processtriggeridunique");

    [AttributeLogicalName("scope")]
    public OptionSetValue Scope
    {
      get => this.GetAttributeValue<OptionSetValue>("scope");
      set
      {
        this.OnPropertyChanging(nameof (Scope));
        this.SetAttributeValue("scope", (object) value);
        this.OnPropertyChanged(nameof (Scope));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ProcessTrigger_SyncErrors")]
    public IEnumerable<SyncError> ProcessTrigger_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ProcessTrigger_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ProcessTrigger_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ProcessTrigger_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ProcessTrigger_SyncErrors));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_processtriggerbase_createdby")]
    public SystemUser lk_processtriggerbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processtriggerbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_processtriggerbase_createdonbehalfby")]
    public SystemUser lk_processtriggerbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processtriggerbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processtriggerbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_processtriggerbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processtriggerbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_processtriggerbase_modifiedby")]
    public SystemUser lk_processtriggerbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processtriggerbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_processtriggerbase_modifiedonbehalfby")]
    public SystemUser lk_processtriggerbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processtriggerbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processtriggerbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_processtriggerbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processtriggerbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("processid")]
    [RelationshipSchemaName("process_processtrigger")]
    public Workflow process_processtrigger
    {
      get => this.GetRelatedEntity<Workflow>(nameof (process_processtrigger), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (process_processtrigger));
        this.SetRelatedEntity<Workflow>(nameof (process_processtrigger), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (process_processtrigger));
      }
    }

    [AttributeLogicalName("formid")]
    [RelationshipSchemaName("processtrigger_systemform")]
    public SystemForm processtrigger_systemform
    {
      get
      {
        return this.GetRelatedEntity<SystemForm>(nameof (processtrigger_systemform), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processtrigger_systemform));
        this.SetRelatedEntity<SystemForm>(nameof (processtrigger_systemform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processtrigger_systemform));
      }
    }

    public ProcessTrigger(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["processtriggerid"] = (object) base.Id;
            break;
          case "processtriggerid":
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
