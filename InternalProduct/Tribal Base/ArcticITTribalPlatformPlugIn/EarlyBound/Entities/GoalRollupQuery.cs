// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.GoalRollupQuery
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("goalrollupquery")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class GoalRollupQuery : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "goalrollupquery";
    public const string EntitySchemaName = "GoalRollupQuery";
    public const string PrimaryIdAttribute = "goalrollupqueryid";
    public const string PrimaryNameAttribute = "name";

    public GoalRollupQuery()
      : base("goalrollupquery")
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

    [AttributeLogicalName("fetchxml")]
    public string FetchXml
    {
      get => this.GetAttributeValue<string>("fetchxml");
      set
      {
        this.OnPropertyChanging(nameof (FetchXml));
        this.SetAttributeValue("fetchxml", (object) value);
        this.OnPropertyChanged(nameof (FetchXml));
      }
    }

    [AttributeLogicalName("goalrollupqueryid")]
    public Guid? GoalRollupQueryId
    {
      get => this.GetAttributeValue<Guid?>("goalrollupqueryid");
      set
      {
        this.OnPropertyChanging(nameof (GoalRollupQueryId));
        this.SetAttributeValue("goalrollupqueryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (GoalRollupQueryId));
      }
    }

    [AttributeLogicalName("goalrollupqueryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.GoalRollupQueryId = new Guid?(value);
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

    [AttributeLogicalName("queryentitytype")]
    public string QueryEntityType
    {
      get => this.GetAttributeValue<string>("queryentitytype");
      set
      {
        this.OnPropertyChanging(nameof (QueryEntityType));
        this.SetAttributeValue("queryentitytype", (object) value);
        this.OnPropertyChanged(nameof (QueryEntityType));
      }
    }

    [AttributeLogicalName("statecode")]
    public GoalRollupQueryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new GoalRollupQueryState?((GoalRollupQueryState) Enum.ToObject(typeof (GoalRollupQueryState), attributeValue.Value)) : new GoalRollupQueryState?();
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

    [RelationshipSchemaName("goal_rollupquery_actualdecimal")]
    public IEnumerable<Goal> goal_rollupquery_actualdecimal
    {
      get
      {
        return this.GetRelatedEntities<Goal>(nameof (goal_rollupquery_actualdecimal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goal_rollupquery_actualdecimal));
        this.SetRelatedEntities<Goal>(nameof (goal_rollupquery_actualdecimal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_rollupquery_actualdecimal));
      }
    }

    [RelationshipSchemaName("goal_rollupquery_actualmoney")]
    public IEnumerable<Goal> goal_rollupquery_actualmoney
    {
      get
      {
        return this.GetRelatedEntities<Goal>(nameof (goal_rollupquery_actualmoney), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goal_rollupquery_actualmoney));
        this.SetRelatedEntities<Goal>(nameof (goal_rollupquery_actualmoney), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_rollupquery_actualmoney));
      }
    }

    [RelationshipSchemaName("goal_rollupquery_customdecimal")]
    public IEnumerable<Goal> goal_rollupquery_customdecimal
    {
      get
      {
        return this.GetRelatedEntities<Goal>(nameof (goal_rollupquery_customdecimal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goal_rollupquery_customdecimal));
        this.SetRelatedEntities<Goal>(nameof (goal_rollupquery_customdecimal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_rollupquery_customdecimal));
      }
    }

    [RelationshipSchemaName("goal_rollupquery_customint")]
    public IEnumerable<Goal> goal_rollupquery_customint
    {
      get => this.GetRelatedEntities<Goal>(nameof (goal_rollupquery_customint), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (goal_rollupquery_customint));
        this.SetRelatedEntities<Goal>(nameof (goal_rollupquery_customint), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_rollupquery_customint));
      }
    }

    [RelationshipSchemaName("goal_rollupquery_custommoney")]
    public IEnumerable<Goal> goal_rollupquery_custommoney
    {
      get
      {
        return this.GetRelatedEntities<Goal>(nameof (goal_rollupquery_custommoney), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goal_rollupquery_custommoney));
        this.SetRelatedEntities<Goal>(nameof (goal_rollupquery_custommoney), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_rollupquery_custommoney));
      }
    }

    [RelationshipSchemaName("goal_rollupquery_inprogressdecimal")]
    public IEnumerable<Goal> goal_rollupquery_inprogressdecimal
    {
      get
      {
        return this.GetRelatedEntities<Goal>(nameof (goal_rollupquery_inprogressdecimal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goal_rollupquery_inprogressdecimal));
        this.SetRelatedEntities<Goal>(nameof (goal_rollupquery_inprogressdecimal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_rollupquery_inprogressdecimal));
      }
    }

    [RelationshipSchemaName("goal_rollupquery_inprogressint")]
    public IEnumerable<Goal> goal_rollupquery_inprogressint
    {
      get
      {
        return this.GetRelatedEntities<Goal>(nameof (goal_rollupquery_inprogressint), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goal_rollupquery_inprogressint));
        this.SetRelatedEntities<Goal>(nameof (goal_rollupquery_inprogressint), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_rollupquery_inprogressint));
      }
    }

    [RelationshipSchemaName("goal_rollupquery_inprogressmoney")]
    public IEnumerable<Goal> goal_rollupquery_inprogressmoney
    {
      get
      {
        return this.GetRelatedEntities<Goal>(nameof (goal_rollupquery_inprogressmoney), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goal_rollupquery_inprogressmoney));
        this.SetRelatedEntities<Goal>(nameof (goal_rollupquery_inprogressmoney), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_rollupquery_inprogressmoney));
      }
    }

    [RelationshipSchemaName("goalrollupquery_actualint")]
    public IEnumerable<Goal> goalrollupquery_actualint
    {
      get => this.GetRelatedEntities<Goal>(nameof (goalrollupquery_actualint), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (goalrollupquery_actualint));
        this.SetRelatedEntities<Goal>(nameof (goalrollupquery_actualint), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goalrollupquery_actualint));
      }
    }

    [RelationshipSchemaName("goalrollupquery_AsyncOperations")]
    public IEnumerable<AsyncOperation> goalrollupquery_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (goalrollupquery_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goalrollupquery_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (goalrollupquery_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goalrollupquery_AsyncOperations));
      }
    }

    [RelationshipSchemaName("GoalRollupQuery_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> GoalRollupQuery_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (GoalRollupQuery_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (GoalRollupQuery_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (GoalRollupQuery_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (GoalRollupQuery_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("GoalRollupQuery_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> GoalRollupQuery_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (GoalRollupQuery_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (GoalRollupQuery_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (GoalRollupQuery_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (GoalRollupQuery_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("goalrollupquery_ProcessSessions")]
    public IEnumerable<ProcessSession> goalrollupquery_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (goalrollupquery_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goalrollupquery_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (goalrollupquery_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goalrollupquery_ProcessSessions));
      }
    }

    [RelationshipSchemaName("GoalRollupQuery_SyncErrors")]
    public IEnumerable<SyncError> GoalRollupQuery_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (GoalRollupQuery_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (GoalRollupQuery_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (GoalRollupQuery_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (GoalRollupQuery_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_goalrollupquery")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_goalrollupquery
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_goalrollupquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_goalrollupquery));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_goalrollupquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_goalrollupquery));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_goalrollupquery")]
    public BusinessUnit business_unit_goalrollupquery
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_goalrollupquery), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_goalrollupquery_createdby")]
    public SystemUser lk_goalrollupquery_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_goalrollupquery_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_goalrollupquery_createdonbehalfby")]
    public SystemUser lk_goalrollupquery_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_goalrollupquery_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_goalrollupquery_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_goalrollupquery_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_goalrollupquery_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_goalrollupquery_modifiedby")]
    public SystemUser lk_goalrollupquery_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_goalrollupquery_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_goalrollupquery_modifiedonbehalfby")]
    public SystemUser lk_goalrollupquery_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_goalrollupquery_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_goalrollupquery_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_goalrollupquery_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_goalrollupquery_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_goalrollupquery")]
    public Team team_goalrollupquery
    {
      get => this.GetRelatedEntity<Team>(nameof (team_goalrollupquery), new EntityRole?());
    }

    public GoalRollupQuery(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["goalrollupqueryid"] = (object) base.Id;
            break;
          case "goalrollupqueryid":
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
