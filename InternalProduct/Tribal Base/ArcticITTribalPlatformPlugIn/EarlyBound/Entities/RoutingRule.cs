// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RoutingRule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("routingrule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RoutingRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "routingrule";
    public const string EntitySchemaName = "RoutingRule";
    public const string PrimaryIdAttribute = "routingruleid";
    public const string PrimaryNameAttribute = "name";

    public RoutingRule()
      : base("routingrule")
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
      set
      {
        this.OnPropertyChanging(nameof (OwningBusinessUnit));
        this.SetAttributeValue("owningbusinessunit", (object) value);
        this.OnPropertyChanged(nameof (OwningBusinessUnit));
      }
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam
    {
      get => this.GetAttributeValue<EntityReference>("owningteam");
      set
      {
        this.OnPropertyChanging(nameof (OwningTeam));
        this.SetAttributeValue("owningteam", (object) value);
        this.OnPropertyChanged(nameof (OwningTeam));
      }
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser
    {
      get => this.GetAttributeValue<EntityReference>("owninguser");
      set
      {
        this.OnPropertyChanging(nameof (OwningUser));
        this.SetAttributeValue("owninguser", (object) value);
        this.OnPropertyChanged(nameof (OwningUser));
      }
    }

    [AttributeLogicalName("routingruleid")]
    public Guid? RoutingRuleId
    {
      get => this.GetAttributeValue<Guid?>("routingruleid");
      set
      {
        this.OnPropertyChanging(nameof (RoutingRuleId));
        this.SetAttributeValue("routingruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RoutingRuleId));
      }
    }

    [AttributeLogicalName("routingruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RoutingRuleId = new Guid?(value);
    }

    [AttributeLogicalName("routingruleidunique")]
    public Guid? RoutingRuleIdUnique => this.GetAttributeValue<Guid?>("routingruleidunique");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public RoutingRuleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new RoutingRuleState?((RoutingRuleState) Enum.ToObject(typeof (RoutingRuleState), attributeValue.Value)) : new RoutingRuleState?();
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

    [RelationshipSchemaName("routingrule_Annotation")]
    public IEnumerable<Annotation> routingrule_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (routingrule_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (routingrule_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_Annotation));
      }
    }

    [RelationshipSchemaName("routingrule_AsyncOperations")]
    public IEnumerable<AsyncOperation> routingrule_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (routingrule_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (routingrule_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_AsyncOperations));
      }
    }

    [RelationshipSchemaName("routingrule_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> routingrule_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (routingrule_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (routingrule_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("routingrule_entries")]
    public IEnumerable<RoutingRuleItem> routingrule_entries
    {
      get
      {
        return this.GetRelatedEntities<RoutingRuleItem>(nameof (routingrule_entries), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_entries));
        this.SetRelatedEntities<RoutingRuleItem>(nameof (routingrule_entries), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_entries));
      }
    }

    [RelationshipSchemaName("routingrule_ProcessSessions")]
    public IEnumerable<ProcessSession> routingrule_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (routingrule_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (routingrule_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_ProcessSessions));
      }
    }

    [RelationshipSchemaName("routingrule_userentityinstancedatas")]
    public IEnumerable<UserEntityInstanceData> routingrule_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (routingrule_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_userentityinstancedatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (routingrule_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_routingrule")]
    public BusinessUnit business_unit_routingrule
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_routingrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_routingrule));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_routingrule));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_routingrule_createdby")]
    public SystemUser lk_routingrule_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_routingrule_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_routingrule_createdonbehalfby")]
    public SystemUser lk_routingrule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_routingrule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_routingrule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_routingrule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_routingrule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_routingrule_modifiedby")]
    public SystemUser lk_routingrule_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_routingrule_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_routingrule_modifiedonbehalfby")]
    public SystemUser lk_routingrule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_routingrule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_routingrule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_routingrule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_routingrule_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_RoutingRules")]
    public Organization organization_RoutingRules
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_RoutingRules), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_routingrule")]
    public Team team_routingrule
    {
      get => this.GetRelatedEntity<Team>(nameof (team_routingrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_routingrule));
        this.SetRelatedEntity<Team>(nameof (team_routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_routingrule));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Routingrule")]
    public TransactionCurrency TransactionCurrency_Routingrule
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Routingrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Routingrule));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Routingrule));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_routingrule")]
    public SystemUser user_routingrule
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_routingrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_routingrule));
        this.SetRelatedEntity<SystemUser>(nameof (user_routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_routingrule));
      }
    }

    [AttributeLogicalName("workflowid")]
    [RelationshipSchemaName("Workflow_routingrule")]
    public Workflow Workflow_routingrule
    {
      get => this.GetRelatedEntity<Workflow>(nameof (Workflow_routingrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Workflow_routingrule));
        this.SetRelatedEntity<Workflow>(nameof (Workflow_routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Workflow_routingrule));
      }
    }

    public RoutingRule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["routingruleid"] = (object) base.Id;
            break;
          case "routingruleid":
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
