// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ConvertRule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("convertrule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ConvertRule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "convertrule";
    public const string EntitySchemaName = "ConvertRule";
    public const string PrimaryIdAttribute = "convertruleid";
    public const string PrimaryNameAttribute = "name";

    public ConvertRule()
      : base("convertrule")
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

    [AttributeLogicalName("allowunknownsender")]
    public bool? AllowUnknownSender
    {
      get => this.GetAttributeValue<bool?>("allowunknownsender");
      set
      {
        this.OnPropertyChanging(nameof (AllowUnknownSender));
        this.SetAttributeValue("allowunknownsender", (object) value);
        this.OnPropertyChanged(nameof (AllowUnknownSender));
      }
    }

    [AttributeLogicalName("channelpropertygroupid")]
    public EntityReference ChannelPropertyGroupId
    {
      get => this.GetAttributeValue<EntityReference>("channelpropertygroupid");
      set
      {
        this.OnPropertyChanging(nameof (ChannelPropertyGroupId));
        this.SetAttributeValue("channelpropertygroupid", (object) value);
        this.OnPropertyChanged(nameof (ChannelPropertyGroupId));
      }
    }

    [AttributeLogicalName("checkactiveentitlement")]
    public bool? CheckActiveEntitlement
    {
      get => this.GetAttributeValue<bool?>("checkactiveentitlement");
      set
      {
        this.OnPropertyChanging(nameof (CheckActiveEntitlement));
        this.SetAttributeValue("checkactiveentitlement", (object) value);
        this.OnPropertyChanged(nameof (CheckActiveEntitlement));
      }
    }

    [AttributeLogicalName("checkblockedsocialprofile")]
    public bool? CheckBlockedSocialProfile
    {
      get => this.GetAttributeValue<bool?>("checkblockedsocialprofile");
      set
      {
        this.OnPropertyChanging(nameof (CheckBlockedSocialProfile));
        this.SetAttributeValue("checkblockedsocialprofile", (object) value);
        this.OnPropertyChanged(nameof (CheckBlockedSocialProfile));
      }
    }

    [AttributeLogicalName("checkdirectmessages")]
    public bool? CheckDirectMessages
    {
      get => this.GetAttributeValue<bool?>("checkdirectmessages");
      set
      {
        this.OnPropertyChanging(nameof (CheckDirectMessages));
        this.SetAttributeValue("checkdirectmessages", (object) value);
        this.OnPropertyChanged(nameof (CheckDirectMessages));
      }
    }

    [AttributeLogicalName("checkifresolved")]
    public bool? CheckIfResolved
    {
      get => this.GetAttributeValue<bool?>("checkifresolved");
      set
      {
        this.OnPropertyChanging(nameof (CheckIfResolved));
        this.SetAttributeValue("checkifresolved", (object) value);
        this.OnPropertyChanged(nameof (CheckIfResolved));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("convertruleid")]
    public Guid? ConvertRuleId
    {
      get => this.GetAttributeValue<Guid?>("convertruleid");
      set
      {
        this.OnPropertyChanging(nameof (ConvertRuleId));
        this.SetAttributeValue("convertruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ConvertRuleId));
      }
    }

    [AttributeLogicalName("convertruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ConvertRuleId = new Guid?(value);
    }

    [AttributeLogicalName("convertruleidunique")]
    public Guid? ConvertRuleIdUnique => this.GetAttributeValue<Guid?>("convertruleidunique");

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

    [AttributeLogicalName("recordversion")]
    public string RecordVersion => this.GetAttributeValue<string>("recordversion");

    [AttributeLogicalName("resolvedsince")]
    public int? ResolvedSince
    {
      get => this.GetAttributeValue<int?>("resolvedsince");
      set
      {
        this.OnPropertyChanging(nameof (ResolvedSince));
        this.SetAttributeValue("resolvedsince", (object) value);
        this.OnPropertyChanged(nameof (ResolvedSince));
      }
    }

    [AttributeLogicalName("responsetemplateid")]
    public EntityReference ResponseTemplateId
    {
      get => this.GetAttributeValue<EntityReference>("responsetemplateid");
      set
      {
        this.OnPropertyChanging(nameof (ResponseTemplateId));
        this.SetAttributeValue("responsetemplateid", (object) value);
        this.OnPropertyChanged(nameof (ResponseTemplateId));
      }
    }

    [AttributeLogicalName("sendautomaticresponse")]
    public bool? SendAutomaticResponse
    {
      get => this.GetAttributeValue<bool?>("sendautomaticresponse");
      set
      {
        this.OnPropertyChanging(nameof (SendAutomaticResponse));
        this.SetAttributeValue("sendautomaticresponse", (object) value);
        this.OnPropertyChanged(nameof (SendAutomaticResponse));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("sourcechanneltypecode")]
    public string SourceChannelTypeCode
    {
      get => this.GetAttributeValue<string>("sourcechanneltypecode");
      set
      {
        this.OnPropertyChanging(nameof (SourceChannelTypeCode));
        this.SetAttributeValue("sourcechanneltypecode", (object) value);
        this.OnPropertyChanged(nameof (SourceChannelTypeCode));
      }
    }

    [AttributeLogicalName("sourcetypecode")]
    public OptionSetValue SourceTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("sourcetypecode");
      set
      {
        this.OnPropertyChanging(nameof (SourceTypeCode));
        this.SetAttributeValue("sourcetypecode", (object) value);
        this.OnPropertyChanged(nameof (SourceTypeCode));
      }
    }

    [AttributeLogicalName("statecode")]
    public ConvertRuleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ConvertRuleState?((ConvertRuleState) Enum.ToObject(typeof (ConvertRuleState), attributeValue.Value)) : new ConvertRuleState?();
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

    [RelationshipSchemaName("ConvertRule_Annotation")]
    public IEnumerable<Annotation> ConvertRule_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ConvertRule_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConvertRule_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (ConvertRule_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConvertRule_Annotation));
      }
    }

    [RelationshipSchemaName("Convertrule_AsyncOperations")]
    public IEnumerable<AsyncOperation> Convertrule_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Convertrule_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Convertrule_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Convertrule_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Convertrule_AsyncOperations));
      }
    }

    [RelationshipSchemaName("convertrule_convertruleitem")]
    public IEnumerable<ConvertRuleItem> convertrule_convertruleitem
    {
      get
      {
        return this.GetRelatedEntities<ConvertRuleItem>(nameof (convertrule_convertruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (convertrule_convertruleitem));
        this.SetRelatedEntities<ConvertRuleItem>(nameof (convertrule_convertruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (convertrule_convertruleitem));
      }
    }

    [RelationshipSchemaName("ConvertRule_ProcessSessions")]
    public IEnumerable<ProcessSession> ConvertRule_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ConvertRule_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConvertRule_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (ConvertRule_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConvertRule_ProcessSessions));
      }
    }

    [RelationshipSchemaName("ConvertRule_userentityinstancedatas")]
    public IEnumerable<UserEntityInstanceData> ConvertRule_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ConvertRule_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConvertRule_userentityinstancedatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ConvertRule_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConvertRule_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_convertrule")]
    public BusinessUnit business_unit_convertrule
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_convertrule), new EntityRole?());
      }
    }

    [AttributeLogicalName("channelpropertygroupid")]
    [RelationshipSchemaName("channelpropertygroup_convertrule")]
    public ChannelPropertyGroup channelpropertygroup_convertrule
    {
      get
      {
        return this.GetRelatedEntity<ChannelPropertyGroup>(nameof (channelpropertygroup_convertrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelpropertygroup_convertrule));
        this.SetRelatedEntity<ChannelPropertyGroup>(nameof (channelpropertygroup_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelpropertygroup_convertrule));
      }
    }

    [AttributeLogicalName("queueid")]
    [RelationshipSchemaName("convertrule_queue")]
    public Queue convertrule_queue
    {
      get => this.GetRelatedEntity<Queue>(nameof (convertrule_queue), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (convertrule_queue));
        this.SetRelatedEntity<Queue>(nameof (convertrule_queue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (convertrule_queue));
      }
    }

    [AttributeLogicalName("responsetemplateid")]
    [RelationshipSchemaName("emailtemplate_convertrule")]
    public Template emailtemplate_convertrule
    {
      get => this.GetRelatedEntity<Template>(nameof (emailtemplate_convertrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (emailtemplate_convertrule));
        this.SetRelatedEntity<Template>(nameof (emailtemplate_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailtemplate_convertrule));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_convertrule_createdby")]
    public SystemUser lk_convertrule_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_convertrule_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ConvertRule_createdonbehalfby")]
    public SystemUser lk_ConvertRule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ConvertRule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ConvertRule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ConvertRule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ConvertRule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ConvertRule_modifiedby")]
    public SystemUser lk_ConvertRule_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ConvertRule_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ConvertRule_modifiedonbehalfby")]
    public SystemUser lk_ConvertRule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ConvertRule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ConvertRule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ConvertRule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ConvertRule_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_convertrule")]
    public Team team_convertrule
    {
      get => this.GetRelatedEntity<Team>(nameof (team_convertrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_convertrule));
        this.SetRelatedEntity<Team>(nameof (team_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_convertrule));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ConvertRule")]
    public TransactionCurrency TransactionCurrency_ConvertRule
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ConvertRule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ConvertRule));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ConvertRule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ConvertRule));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_convertrule")]
    public SystemUser user_convertrule
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_convertrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_convertrule));
        this.SetRelatedEntity<SystemUser>(nameof (user_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_convertrule));
      }
    }

    [AttributeLogicalName("workflowid")]
    [RelationshipSchemaName("workflowid_convertrule")]
    public Workflow workflowid_convertrule
    {
      get => this.GetRelatedEntity<Workflow>(nameof (workflowid_convertrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (workflowid_convertrule));
        this.SetRelatedEntity<Workflow>(nameof (workflowid_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowid_convertrule));
      }
    }

    public ConvertRule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["convertruleid"] = (object) base.Id;
            break;
          case "convertruleid":
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
