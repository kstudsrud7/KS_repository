// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RoutingRuleItem
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("routingruleitem")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RoutingRuleItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "routingruleitem";
    public const string EntitySchemaName = "RoutingRuleItem";
    public const string PrimaryIdAttribute = "routingruleitemid";
    public const string PrimaryNameAttribute = "name";

    public RoutingRuleItem()
      : base("routingruleitem")
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

    [AttributeLogicalName("assignobjectid")]
    public EntityReference AssignObjectId
    {
      get => this.GetAttributeValue<EntityReference>("assignobjectid");
      set
      {
        this.OnPropertyChanging(nameof (AssignObjectId));
        this.SetAttributeValue("assignobjectid", (object) value);
        this.OnPropertyChanged(nameof (AssignObjectId));
      }
    }

    [AttributeLogicalName("assignobjectidmodifiedon")]
    public DateTime? AssignObjectIdModifiedOn
    {
      get => this.GetAttributeValue<DateTime?>("assignobjectidmodifiedon");
      set
      {
        this.OnPropertyChanging(nameof (AssignObjectIdModifiedOn));
        this.SetAttributeValue("assignobjectidmodifiedon", (object) value);
        this.OnPropertyChanged(nameof (AssignObjectIdModifiedOn));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("routedqueueid")]
    public EntityReference RoutedQueueId
    {
      get => this.GetAttributeValue<EntityReference>("routedqueueid");
      set
      {
        this.OnPropertyChanging(nameof (RoutedQueueId));
        this.SetAttributeValue("routedqueueid", (object) value);
        this.OnPropertyChanged(nameof (RoutedQueueId));
      }
    }

    [AttributeLogicalName("routingruleid")]
    public EntityReference RoutingRuleId
    {
      get => this.GetAttributeValue<EntityReference>("routingruleid");
      set
      {
        this.OnPropertyChanging(nameof (RoutingRuleId));
        this.SetAttributeValue("routingruleid", (object) value);
        this.OnPropertyChanged(nameof (RoutingRuleId));
      }
    }

    [AttributeLogicalName("routingruleitemid")]
    public Guid? RoutingRuleItemId
    {
      get => this.GetAttributeValue<Guid?>("routingruleitemid");
      set
      {
        this.OnPropertyChanging(nameof (RoutingRuleItemId));
        this.SetAttributeValue("routingruleitemid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RoutingRuleItemId));
      }
    }

    [AttributeLogicalName("routingruleitemid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RoutingRuleItemId = new Guid?(value);
    }

    [AttributeLogicalName("routingruleitemidunique")]
    public Guid? RoutingRuleItemIdUnique
    {
      get => this.GetAttributeValue<Guid?>("routingruleitemidunique");
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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
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

    [RelationshipSchemaName("routingruleitem_Annotation")]
    public IEnumerable<Annotation> routingruleitem_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (routingruleitem_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (routingruleitem_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_Annotation));
      }
    }

    [RelationshipSchemaName("routingruleitem_AsyncOperations")]
    public IEnumerable<AsyncOperation> routingruleitem_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (routingruleitem_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (routingruleitem_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_AsyncOperations));
      }
    }

    [RelationshipSchemaName("routingruleitem_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> routingruleitem_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (routingruleitem_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (routingruleitem_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("routingruleitem_ProcessSessions")]
    public IEnumerable<ProcessSession> routingruleitem_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (routingruleitem_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (routingruleitem_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_ProcessSessions));
      }
    }

    [RelationshipSchemaName("routingruleitem_userentityinstancedatas")]
    public IEnumerable<UserEntityInstanceData> routingruleitem_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (routingruleitem_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_userentityinstancedatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (routingruleitem_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_RoutingRuleItem_createdby")]
    public SystemUser lk_RoutingRuleItem_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_RoutingRuleItem_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_routingruleitem_createdonbehalfby")]
    public SystemUser lk_routingruleitem_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_routingruleitem_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_routingruleitem_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_routingruleitem_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_routingruleitem_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_routingruleitem_modifiedby")]
    public SystemUser lk_routingruleitem_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_routingruleitem_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_routingruleitem_modifiedonbehalfby")]
    public SystemUser lk_routingruleitem_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_routingruleitem_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_routingruleitem_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_routingruleitem_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_routingruleitem_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_routingruleitems")]
    public Organization organization_routingruleitems
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_routingruleitems), new EntityRole?());
      }
    }

    [AttributeLogicalName("routedqueueid")]
    [RelationshipSchemaName("queue_routingruleitem")]
    public Queue queue_routingruleitem
    {
      get => this.GetRelatedEntity<Queue>(nameof (queue_routingruleitem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_routingruleitem));
        this.SetRelatedEntity<Queue>(nameof (queue_routingruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_routingruleitem));
      }
    }

    [AttributeLogicalName("routingruleid")]
    [RelationshipSchemaName("routingrule_entries")]
    public RoutingRule routingrule_entries
    {
      get => this.GetRelatedEntity<RoutingRule>(nameof (routingrule_entries), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (routingrule_entries));
        this.SetRelatedEntity<RoutingRule>(nameof (routingrule_entries), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_entries));
      }
    }

    [AttributeLogicalName("assignobjectid")]
    [RelationshipSchemaName("team_routingruleitem")]
    public Team team_routingruleitem
    {
      get => this.GetRelatedEntity<Team>(nameof (team_routingruleitem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_routingruleitem));
        this.SetRelatedEntity<Team>(nameof (team_routingruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_routingruleitem));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_routingruleitem")]
    public TransactionCurrency TransactionCurrency_routingruleitem
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_routingruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_routingruleitem));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_routingruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_routingruleitem));
      }
    }

    [AttributeLogicalName("assignobjectid")]
    [RelationshipSchemaName("user_routingruleitem")]
    public SystemUser user_routingruleitem
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_routingruleitem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_routingruleitem));
        this.SetRelatedEntity<SystemUser>(nameof (user_routingruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_routingruleitem));
      }
    }

    public RoutingRuleItem(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["routingruleitemid"] = (object) base.Id;
            break;
          case "routingruleitemid":
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
