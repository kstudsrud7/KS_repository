// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ExpiredProcess
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("expiredprocess")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ExpiredProcess : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "expiredprocess";
    public const string EntitySchemaName = "ExpiredProcess";
    public const string PrimaryIdAttribute = "businessprocessflowinstanceid";
    public const string PrimaryNameAttribute = "name";

    public ExpiredProcess()
      : base("expiredprocess")
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

    [AttributeLogicalName("activestageid")]
    public EntityReference ActiveStageId
    {
      get => this.GetAttributeValue<EntityReference>("activestageid");
      set
      {
        this.OnPropertyChanging(nameof (ActiveStageId));
        this.SetAttributeValue("activestageid", (object) value);
        this.OnPropertyChanged(nameof (ActiveStageId));
      }
    }

    [AttributeLogicalName("activestagestartedon")]
    public DateTime? ActiveStageStartedOn
    {
      get => this.GetAttributeValue<DateTime?>("activestagestartedon");
      set
      {
        this.OnPropertyChanging(nameof (ActiveStageStartedOn));
        this.SetAttributeValue("activestagestartedon", (object) value);
        this.OnPropertyChanged(nameof (ActiveStageStartedOn));
      }
    }

    [AttributeLogicalName("businessprocessflowinstanceid")]
    public Guid? BusinessProcessFlowInstanceId
    {
      get => this.GetAttributeValue<Guid?>("businessprocessflowinstanceid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessProcessFlowInstanceId));
        this.SetAttributeValue("businessprocessflowinstanceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (BusinessProcessFlowInstanceId));
      }
    }

    [AttributeLogicalName("businessprocessflowinstanceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.BusinessProcessFlowInstanceId = new Guid?(value);
    }

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn
    {
      get => this.GetAttributeValue<DateTime?>("completedon");
      set
      {
        this.OnPropertyChanging(nameof (CompletedOn));
        this.SetAttributeValue("completedon", (object) value);
        this.OnPropertyChanged(nameof (CompletedOn));
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

    [AttributeLogicalName("duration")]
    public int? Duration => this.GetAttributeValue<int?>("duration");

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("knowledgearticleid")]
    public EntityReference KnowledgeArticleId
    {
      get => this.GetAttributeValue<EntityReference>("knowledgearticleid");
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticleId));
        this.SetAttributeValue("knowledgearticleid", (object) value);
        this.OnPropertyChanged(nameof (KnowledgeArticleId));
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

    [AttributeLogicalName("statecode")]
    public ExpiredProcessState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ExpiredProcessState?((ExpiredProcessState) Enum.ToObject(typeof (ExpiredProcessState), attributeValue.Value)) : new ExpiredProcessState?();
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

    [AttributeLogicalName("traversedpath")]
    public string TraversedPath
    {
      get => this.GetAttributeValue<string>("traversedpath");
      set
      {
        this.OnPropertyChanging(nameof (TraversedPath));
        this.SetAttributeValue("traversedpath", (object) value);
        this.OnPropertyChanged(nameof (TraversedPath));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ExpiredProcess_ProcessSessions")]
    public IEnumerable<ProcessSession> ExpiredProcess_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ExpiredProcess_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ExpiredProcess_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (ExpiredProcess_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ExpiredProcess_ProcessSessions));
      }
    }

    [RelationshipSchemaName("ExpiredProcess_SyncErrors")]
    public IEnumerable<SyncError> ExpiredProcess_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ExpiredProcess_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ExpiredProcess_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ExpiredProcess_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ExpiredProcess_SyncErrors));
      }
    }

    [RelationshipSchemaName("lk_expiredprocess_workflowlogs")]
    public IEnumerable<WorkflowLog> lk_expiredprocess_workflowlogs
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>(nameof (lk_expiredprocess_workflowlogs), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_workflowlogs));
        this.SetRelatedEntities<WorkflowLog>(nameof (lk_expiredprocess_workflowlogs), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_workflowlogs));
      }
    }

    [AttributeLogicalName("activestageid")]
    [RelationshipSchemaName("lk_expiredprocess_activestageid")]
    public ProcessStage lk_expiredprocess_activestageid
    {
      get
      {
        return this.GetRelatedEntity<ProcessStage>(nameof (lk_expiredprocess_activestageid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_activestageid));
        this.SetRelatedEntity<ProcessStage>(nameof (lk_expiredprocess_activestageid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_activestageid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_expiredprocess_createdby")]
    public SystemUser lk_expiredprocess_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_expiredprocess_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_expiredprocess_createdonbehalfby")]
    public SystemUser lk_expiredprocess_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_expiredprocess_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_expiredprocess_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_createdonbehalfby));
      }
    }

    [AttributeLogicalName("knowledgearticleid")]
    [RelationshipSchemaName("lk_expiredprocess_knowledgearticleid")]
    public KnowledgeArticle lk_expiredprocess_knowledgearticleid
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (lk_expiredprocess_knowledgearticleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_knowledgearticleid));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (lk_expiredprocess_knowledgearticleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_knowledgearticleid));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_expiredprocess_modifiedby")]
    public SystemUser lk_expiredprocess_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_expiredprocess_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_expiredprocess_modifiedonbehalfby")]
    public SystemUser lk_expiredprocess_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_expiredprocess_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_expiredprocess_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("processid")]
    [RelationshipSchemaName("lk_expiredprocess_processid")]
    public Workflow lk_expiredprocess_processid
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (lk_expiredprocess_processid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_processid));
        this.SetRelatedEntity<Workflow>(nameof (lk_expiredprocess_processid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_processid));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_expiredprocess")]
    public Organization organization_expiredprocess
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_expiredprocess), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_expiredprocess")]
    public TransactionCurrency transactioncurrency_expiredprocess
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_expiredprocess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_expiredprocess));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_expiredprocess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_expiredprocess));
      }
    }

    public ExpiredProcess(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["businessprocessflowinstanceid"] = (object) base.Id;
            break;
          case "businessprocessflowinstanceid":
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
