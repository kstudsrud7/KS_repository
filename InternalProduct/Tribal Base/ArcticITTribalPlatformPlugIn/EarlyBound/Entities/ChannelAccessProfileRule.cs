// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ChannelAccessProfileRule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("channelaccessprofilerule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ChannelAccessProfileRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "channelaccessprofilerule";
    public const string EntitySchemaName = "ChannelAccessProfileRule";
    public const string PrimaryIdAttribute = "channelaccessprofileruleid";
    public const string PrimaryNameAttribute = "name";

    public ChannelAccessProfileRule()
      : base("channelaccessprofilerule")
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

    [AttributeLogicalName("channelaccessprofileruleid")]
    public Guid? ChannelAccessProfileRuleId
    {
      get => this.GetAttributeValue<Guid?>("channelaccessprofileruleid");
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileRuleId));
        this.SetAttributeValue("channelaccessprofileruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ChannelAccessProfileRuleId));
      }
    }

    [AttributeLogicalName("channelaccessprofileruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ChannelAccessProfileRuleId = new Guid?(value);
    }

    [AttributeLogicalName("channelaccessprofileruleidunique")]
    public Guid? ChannelAccessProfileRuleIdUnique
    {
      get => this.GetAttributeValue<Guid?>("channelaccessprofileruleidunique");
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

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
      }
    }

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

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public ChannelAccessProfileRuleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ChannelAccessProfileRuleState?((ChannelAccessProfileRuleState) Enum.ToObject(typeof (ChannelAccessProfileRuleState), attributeValue.Value)) : new ChannelAccessProfileRuleState?();
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

    [RelationshipSchemaName("ChannelAccessProfileRule_SyncErrors")]
    public IEnumerable<SyncError> ChannelAccessProfileRule_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ChannelAccessProfileRule_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileRule_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ChannelAccessProfileRule_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfileRule_SyncErrors));
      }
    }

    [RelationshipSchemaName("profilerule_Annotations")]
    public IEnumerable<Annotation> profilerule_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (profilerule_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (profilerule_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_Annotations));
      }
    }

    [RelationshipSchemaName("profilerule_AsyncOperations")]
    public IEnumerable<AsyncOperation> profilerule_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (profilerule_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (profilerule_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_AsyncOperations));
      }
    }

    [RelationshipSchemaName("profilerule_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> profilerule_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (profilerule_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (profilerule_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("profilerule_connections1")]
    public IEnumerable<Connection> profilerule_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (profilerule_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_connections1));
        this.SetRelatedEntities<Connection>(nameof (profilerule_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_connections1));
      }
    }

    [RelationshipSchemaName("profilerule_connections2")]
    public IEnumerable<Connection> profilerule_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (profilerule_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_connections2));
        this.SetRelatedEntities<Connection>(nameof (profilerule_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_connections2));
      }
    }

    [RelationshipSchemaName("profilerule_entries")]
    public IEnumerable<ChannelAccessProfileRuleItem> profilerule_entries
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfileRuleItem>(nameof (profilerule_entries), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_entries));
        this.SetRelatedEntities<ChannelAccessProfileRuleItem>(nameof (profilerule_entries), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_entries));
      }
    }

    [RelationshipSchemaName("profilerule_ProcessSession")]
    public IEnumerable<ProcessSession> profilerule_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (profilerule_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (profilerule_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_ProcessSession));
      }
    }

    [RelationshipSchemaName("profilerule_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> profilerule_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (profilerule_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (profilerule_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_profilerule")]
    public BusinessUnit business_unit_profilerule
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_profilerule), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_profilerule_createdby")]
    public SystemUser lk_profilerule_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_profilerule_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_profilerule_createdonbehalfby")]
    public SystemUser lk_profilerule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_profilerule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_profilerule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_profilerule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_profilerule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_profilerule_modifiedby")]
    public SystemUser lk_profilerule_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_profilerule_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_profilerule_modifiedonbehalfby")]
    public SystemUser lk_profilerule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_profilerule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_profilerule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_profilerule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_profilerule_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_profilerule")]
    public Team team_profilerule
    {
      get => this.GetRelatedEntity<Team>(nameof (team_profilerule), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_profilerule")]
    public TransactionCurrency TransactionCurrency_profilerule
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_profilerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_profilerule));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_profilerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_profilerule));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_profilerule")]
    public SystemUser user_profilerule
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_profilerule), new EntityRole?());
    }

    [AttributeLogicalName("workflowid")]
    [RelationshipSchemaName("workflowid_profilerule")]
    public Workflow workflowid_profilerule
    {
      get => this.GetRelatedEntity<Workflow>(nameof (workflowid_profilerule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (workflowid_profilerule));
        this.SetRelatedEntity<Workflow>(nameof (workflowid_profilerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowid_profilerule));
      }
    }

    public ChannelAccessProfileRule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["channelaccessprofileruleid"] = (object) base.Id;
            break;
          case "channelaccessprofileruleid":
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
