// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ConvertRuleItem
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("convertruleitem")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ConvertRuleItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "convertruleitem";
    public const string EntitySchemaName = "ConvertRuleItem";
    public const string PrimaryIdAttribute = "convertruleitemid";
    public const string PrimaryNameAttribute = "name";

    public ConvertRuleItem()
      : base("convertruleitem")
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

    [AttributeLogicalName("conditionid")]
    public EntityReference ConditionId
    {
      get => this.GetAttributeValue<EntityReference>("conditionid");
      set
      {
        this.OnPropertyChanging(nameof (ConditionId));
        this.SetAttributeValue("conditionid", (object) value);
        this.OnPropertyChanged(nameof (ConditionId));
      }
    }

    [AttributeLogicalName("conditionxml")]
    public string ConditionXml
    {
      get => this.GetAttributeValue<string>("conditionxml");
      set
      {
        this.OnPropertyChanging(nameof (ConditionXml));
        this.SetAttributeValue("conditionxml", (object) value);
        this.OnPropertyChanged(nameof (ConditionXml));
      }
    }

    [AttributeLogicalName("convertruleid")]
    public EntityReference ConvertRuleId
    {
      get => this.GetAttributeValue<EntityReference>("convertruleid");
      set
      {
        this.OnPropertyChanging(nameof (ConvertRuleId));
        this.SetAttributeValue("convertruleid", (object) value);
        this.OnPropertyChanged(nameof (ConvertRuleId));
      }
    }

    [AttributeLogicalName("convertruleitemid")]
    public Guid? ConvertRuleItemId
    {
      get => this.GetAttributeValue<Guid?>("convertruleitemid");
      set
      {
        this.OnPropertyChanging(nameof (ConvertRuleItemId));
        this.SetAttributeValue("convertruleitemid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ConvertRuleItemId));
      }
    }

    [AttributeLogicalName("convertruleitemid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ConvertRuleItemId = new Guid?(value);
    }

    [AttributeLogicalName("convertruleitemidunique")]
    public Guid? ConvertRuleItemIdUnique
    {
      get => this.GetAttributeValue<Guid?>("convertruleitemidunique");
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("propertiesxml")]
    public string PropertiesXml
    {
      get => this.GetAttributeValue<string>("propertiesxml");
      set
      {
        this.OnPropertyChanging(nameof (PropertiesXml));
        this.SetAttributeValue("propertiesxml", (object) value);
        this.OnPropertyChanged(nameof (PropertiesXml));
      }
    }

    [AttributeLogicalName("queueid")]
    public EntityReference QueueId
    {
      get => this.GetAttributeValue<EntityReference>("queueid");
      set
      {
        this.OnPropertyChanging(nameof (QueueId));
        this.SetAttributeValue("queueid", (object) value);
        this.OnPropertyChanged(nameof (QueueId));
      }
    }

    [AttributeLogicalName("sequencenumber")]
    public int? SequenceNumber
    {
      get => this.GetAttributeValue<int?>("sequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (SequenceNumber));
        this.SetAttributeValue("sequencenumber", (object) value);
        this.OnPropertyChanged(nameof (SequenceNumber));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("workflowid")]
    public EntityReference WorkflowId
    {
      get => this.GetAttributeValue<EntityReference>("workflowid");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowId));
        this.SetAttributeValue("workflowid", (object) value);
        this.OnPropertyChanged(nameof (WorkflowId));
      }
    }

    [AttributeLogicalName("convertruleid")]
    [RelationshipSchemaName("convertrule_convertruleitem")]
    public ConvertRule convertrule_convertruleitem
    {
      get
      {
        return this.GetRelatedEntity<ConvertRule>(nameof (convertrule_convertruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (convertrule_convertruleitem));
        this.SetRelatedEntity<ConvertRule>(nameof (convertrule_convertruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (convertrule_convertruleitem));
      }
    }

    [AttributeLogicalName("workflowid")]
    [RelationshipSchemaName("convertruleitembase_workflowid")]
    public Workflow convertruleitembase_workflowid
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (convertruleitembase_workflowid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (convertruleitembase_workflowid));
        this.SetRelatedEntity<Workflow>(nameof (convertruleitembase_workflowid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (convertruleitembase_workflowid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_convertruleitembase_createdby")]
    public SystemUser lk_convertruleitembase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_convertruleitembase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_convertruleitembase_createdonbehalfby")]
    public SystemUser lk_convertruleitembase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_convertruleitembase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_convertruleitembase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_convertruleitembase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_convertruleitembase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_convertruleitembase_modifiedby")]
    public SystemUser lk_convertruleitembase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_convertruleitembase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_convertruleitembase_modifiedonbehalfby")]
    public SystemUser lk_convertruleitembase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_convertruleitembase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_convertruleitembase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_convertruleitembase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_convertruleitembase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("queueid")]
    [RelationshipSchemaName("queue_convertruleitem")]
    public Queue queue_convertruleitem
    {
      get => this.GetRelatedEntity<Queue>(nameof (queue_convertruleitem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_convertruleitem));
        this.SetRelatedEntity<Queue>(nameof (queue_convertruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_convertruleitem));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_convertruleitem")]
    public TransactionCurrency transactioncurrency_convertruleitem
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_convertruleitem), new EntityRole?());
      }
    }

    public ConvertRuleItem(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["convertruleitemid"] = (object) base.Id;
            break;
          case "convertruleitemid":
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
