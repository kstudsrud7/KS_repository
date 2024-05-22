// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ProcessSession
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("processsession")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ProcessSession : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "processsession";
    public const string EntitySchemaName = "ProcessSession";
    public const string PrimaryIdAttribute = "processsessionid";
    public const string PrimaryNameAttribute = "name";

    public ProcessSession()
      : base("processsession")
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

    [AttributeLogicalName("activityname")]
    public string ActivityName
    {
      get => this.GetAttributeValue<string>("activityname");
      set
      {
        this.OnPropertyChanging(nameof (ActivityName));
        this.SetAttributeValue("activityname", (object) value);
        this.OnPropertyChanged(nameof (ActivityName));
      }
    }

    [AttributeLogicalName("canceledby")]
    public EntityReference CanceledBy => this.GetAttributeValue<EntityReference>("canceledby");

    [AttributeLogicalName("canceledon")]
    public DateTime? CanceledOn
    {
      get => this.GetAttributeValue<DateTime?>("canceledon");
      set
      {
        this.OnPropertyChanging(nameof (CanceledOn));
        this.SetAttributeValue("canceledon", (object) value);
        this.OnPropertyChanged(nameof (CanceledOn));
      }
    }

    [AttributeLogicalName("comments")]
    public string Comments
    {
      get => this.GetAttributeValue<string>("comments");
      set
      {
        this.OnPropertyChanging(nameof (Comments));
        this.SetAttributeValue("comments", (object) value);
        this.OnPropertyChanged(nameof (Comments));
      }
    }

    [AttributeLogicalName("completedby")]
    public EntityReference CompletedBy => this.GetAttributeValue<EntityReference>("completedby");

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

    [AttributeLogicalName("errorcode")]
    public int? ErrorCode
    {
      get => this.GetAttributeValue<int?>("errorcode");
      set
      {
        this.OnPropertyChanging(nameof (ErrorCode));
        this.SetAttributeValue("errorcode", (object) value);
        this.OnPropertyChanged(nameof (ErrorCode));
      }
    }

    [AttributeLogicalName("executedby")]
    public EntityReference ExecutedBy
    {
      get => this.GetAttributeValue<EntityReference>("executedby");
      set
      {
        this.OnPropertyChanging(nameof (ExecutedBy));
        this.SetAttributeValue("executedby", (object) value);
        this.OnPropertyChanged(nameof (ExecutedBy));
      }
    }

    [AttributeLogicalName("executedon")]
    public DateTime? ExecutedOn => this.GetAttributeValue<DateTime?>("executedon");

    [AttributeLogicalName("inputarguments")]
    public string InputArguments
    {
      get => this.GetAttributeValue<string>("inputarguments");
      set
      {
        this.OnPropertyChanging(nameof (InputArguments));
        this.SetAttributeValue("inputarguments", (object) value);
        this.OnPropertyChanged(nameof (InputArguments));
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

    [AttributeLogicalName("nextlinkedsessionid")]
    public EntityReference NextLinkedSessionId
    {
      get => this.GetAttributeValue<EntityReference>("nextlinkedsessionid");
      set
      {
        this.OnPropertyChanging(nameof (NextLinkedSessionId));
        this.SetAttributeValue("nextlinkedsessionid", (object) value);
        this.OnPropertyChanged(nameof (NextLinkedSessionId));
      }
    }

    [AttributeLogicalName("originatingsessionid")]
    public EntityReference OriginatingSessionId
    {
      get => this.GetAttributeValue<EntityReference>("originatingsessionid");
      set
      {
        this.OnPropertyChanging(nameof (OriginatingSessionId));
        this.SetAttributeValue("originatingsessionid", (object) value);
        this.OnPropertyChanged(nameof (OriginatingSessionId));
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

    [AttributeLogicalName("previouslinkedsessionid")]
    public EntityReference PreviousLinkedSessionId
    {
      get => this.GetAttributeValue<EntityReference>("previouslinkedsessionid");
      set
      {
        this.OnPropertyChanging(nameof (PreviousLinkedSessionId));
        this.SetAttributeValue("previouslinkedsessionid", (object) value);
        this.OnPropertyChanged(nameof (PreviousLinkedSessionId));
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

    [AttributeLogicalName("processsessionid")]
    public Guid? ProcessSessionId
    {
      get => this.GetAttributeValue<Guid?>("processsessionid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessSessionId));
        this.SetAttributeValue("processsessionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ProcessSessionId));
      }
    }

    [AttributeLogicalName("processsessionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ProcessSessionId = new Guid?(value);
    }

    [AttributeLogicalName("processstagename")]
    public string ProcessStageName
    {
      get => this.GetAttributeValue<string>("processstagename");
      set
      {
        this.OnPropertyChanging(nameof (ProcessStageName));
        this.SetAttributeValue("processstagename", (object) value);
        this.OnPropertyChanged(nameof (ProcessStageName));
      }
    }

    [AttributeLogicalName("processstate")]
    public string ProcessState
    {
      get => this.GetAttributeValue<string>("processstate");
      set
      {
        this.OnPropertyChanging(nameof (ProcessState));
        this.SetAttributeValue("processstate", (object) value);
        this.OnPropertyChanged(nameof (ProcessState));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("startedby")]
    public EntityReference StartedBy => this.GetAttributeValue<EntityReference>("startedby");

    [AttributeLogicalName("startedon")]
    public DateTime? StartedOn
    {
      get => this.GetAttributeValue<DateTime?>("startedon");
      set
      {
        this.OnPropertyChanging(nameof (StartedOn));
        this.SetAttributeValue("startedon", (object) value);
        this.OnPropertyChanged(nameof (StartedOn));
      }
    }

    [AttributeLogicalName("statecode")]
    public ProcessSessionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ProcessSessionState?((ProcessSessionState) Enum.ToObject(typeof (ProcessSessionState), attributeValue.Value)) : new ProcessSessionState?();
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

    [AttributeLogicalName("stepname")]
    public string StepName
    {
      get => this.GetAttributeValue<string>("stepname");
      set
      {
        this.OnPropertyChanging(nameof (StepName));
        this.SetAttributeValue("stepname", (object) value);
        this.OnPropertyChanged(nameof (StepName));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<ProcessSession> Referencedlk_processsession_nextlinkedsessionid
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>("lk_processsession_nextlinkedsessionid", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedlk_processsession_nextlinkedsessionid));
        this.SetRelatedEntities<ProcessSession>("lk_processsession_nextlinkedsessionid", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedlk_processsession_nextlinkedsessionid));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<ProcessSession> Referencedlk_processsession_originatingsessionid
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>("lk_processsession_originatingsessionid", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedlk_processsession_originatingsessionid));
        this.SetRelatedEntities<ProcessSession>("lk_processsession_originatingsessionid", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedlk_processsession_originatingsessionid));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<ProcessSession> Referencedlk_processsession_previouslinkedsessionid
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>("lk_processsession_previouslinkedsessionid", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedlk_processsession_previouslinkedsessionid));
        this.SetRelatedEntities<ProcessSession>("lk_processsession_previouslinkedsessionid", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedlk_processsession_previouslinkedsessionid));
      }
    }

    [RelationshipSchemaName("lk_workflowlog_processsession")]
    public IEnumerable<WorkflowLog> lk_workflowlog_processsession
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_processsession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_processsession));
        this.SetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_processsession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_processsession));
      }
    }

    [RelationshipSchemaName("lk_workflowlog_processsession_childworkflow")]
    public IEnumerable<WorkflowLog> lk_workflowlog_processsession_childworkflow
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_processsession_childworkflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_processsession_childworkflow));
        this.SetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_processsession_childworkflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_processsession_childworkflow));
      }
    }

    [RelationshipSchemaName("processsession_connections1")]
    public IEnumerable<Connection> processsession_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (processsession_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processsession_connections1));
        this.SetRelatedEntities<Connection>(nameof (processsession_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processsession_connections1));
      }
    }

    [RelationshipSchemaName("processsession_connections2")]
    public IEnumerable<Connection> processsession_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (processsession_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processsession_connections2));
        this.SetRelatedEntities<Connection>(nameof (processsession_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processsession_connections2));
      }
    }

    [RelationshipSchemaName("processsession_PostFollows")]
    public IEnumerable<PostFollow> processsession_PostFollows
    {
      get
      {
        return this.GetRelatedEntities<PostFollow>(nameof (processsession_PostFollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processsession_PostFollows));
        this.SetRelatedEntities<PostFollow>(nameof (processsession_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processsession_PostFollows));
      }
    }

    [RelationshipSchemaName("ProcessSession_SyncErrors")]
    public IEnumerable<SyncError> ProcessSession_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ProcessSession_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ProcessSession_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ProcessSession_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ProcessSession_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_processsession")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_processsession
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_processsession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_processsession));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_processsession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_processsession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_ProcessSessions")]
    public Account Account_ProcessSessions
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_ProcessSessions));
        this.SetRelatedEntity<Account>(nameof (Account_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_accountingcode_ProcessSession")]
    public ait_accountingcode ait_accountingcode_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_ProcessSession));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_addresstype_ProcessSession")]
    public ait_addresstype ait_addresstype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_addresstype_ProcessSession));
        this.SetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_addresstype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_ProcessSession")]
    public ait_assessment ait_assessment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_ProcessSession));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_autonumber_ProcessSession")]
    public ait_autonumber ait_autonumber_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_ProcessSession));
        this.SetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_band_ProcessSession")]
    public ait_band ait_band_ProcessSession
    {
      get => this.GetRelatedEntity<ait_band>(nameof (ait_band_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_band_ProcessSession));
        this.SetRelatedEntity<ait_band>(nameof (ait_band_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_band_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccount_ProcessSession")]
    public ait_bankaccount ait_bankaccount_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_ProcessSession));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccounttype_ProcessSession")]
    public ait_bankaccounttype ait_bankaccounttype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccounttype_ProcessSession));
        this.SetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccounttype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_birthrecord_ProcessSession")]
    public ait_birthrecord ait_birthrecord_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_ProcessSession));
        this.SetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bloodquantum_ProcessSession")]
    public ait_bloodquantum ait_bloodquantum_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_ProcessSession));
        this.SetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformat_ProcessSession")]
    public ait_cardformat ait_cardformat_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_ProcessSession));
        this.SetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformatdetail_ProcessSession")]
    public ait_cardformatdetail ait_cardformatdetail_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_ProcessSession));
        this.SetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardhistory_ProcessSession")]
    public ait_cardhistory ait_cardhistory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_ProcessSession));
        this.SetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_ProcessSession")]
    public ait_case ait_case_ProcessSession
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_ProcessSession));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_ProcessSession")]
    public ait_casenote ait_casenote_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_ProcessSession));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_ProcessSession")]
    public ait_caseplan ait_caseplan_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ProcessSession));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_causeofdeath_ProcessSession")]
    public ait_causeofdeath ait_causeofdeath_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_causeofdeath_ProcessSession));
        this.SetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_causeofdeath_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cemetary_ProcessSession")]
    public ait_cemetary ait_cemetary_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_ProcessSession));
        this.SetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_certification_ProcessSession")]
    public ait_certification ait_certification_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_certification_ProcessSession));
        this.SetRelatedEntity<ait_certification>(nameof (ait_certification_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_certification_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_ProcessSession")]
    public ait_changerequest ait_changerequest_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_ProcessSession));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequesttype_ProcessSession")]
    public ait_changerequesttype ait_changerequesttype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_ProcessSession));
        this.SetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_charge_ProcessSession")]
    public ait_charge ait_charge_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_charge>(nameof (ait_charge_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_ProcessSession));
        this.SetRelatedEntity<ait_charge>(nameof (ait_charge_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_childvisitations_ProcessSession")]
    public ait_childvisitations ait_childvisitations_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_ProcessSession));
        this.SetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_city_ProcessSession")]
    public ait_city ait_city_ProcessSession
    {
      get => this.GetRelatedEntity<ait_city>(nameof (ait_city_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_city_ProcessSession));
        this.SetRelatedEntity<ait_city>(nameof (ait_city_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clan_ProcessSession")]
    public ait_clan ait_clan_ProcessSession
    {
      get => this.GetRelatedEntity<ait_clan>(nameof (ait_clan_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_clan_ProcessSession));
        this.SetRelatedEntity<ait_clan>(nameof (ait_clan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clan_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_ProcessSession")]
    public ait_clientprofile ait_clientprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ProcessSession));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committee_ProcessSession")]
    public ait_committee ait_committee_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_ProcessSession));
        this.SetRelatedEntity<ait_committee>(nameof (ait_committee_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemeeting_ProcessSession")]
    public ait_committeemeeting ait_committeemeeting_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemeeting_ProcessSession));
        this.SetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemeeting_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemember_ProcessSession")]
    public ait_committeemember ait_committeemember_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_ProcessSession));
        this.SetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeeposition_ProcessSession")]
    public ait_committeeposition ait_committeeposition_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeeposition_ProcessSession));
        this.SetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeeposition_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeepositiontype_ProcessSession")]
    public ait_committeepositiontype ait_committeepositiontype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeepositiontype_ProcessSession));
        this.SetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeepositiontype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_company_ProcessSession")]
    public ait_company ait_company_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ProcessSession));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactcertification_ProcessSession")]
    public ait_contactcertification ait_contactcertification_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_ProcessSession));
        this.SetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contacteducation_ProcessSession")]
    public ait_contacteducation ait_contacteducation_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_ProcessSession));
        this.SetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactemployment_ProcessSession")]
    public ait_contactemployment ait_contactemployment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_ProcessSession));
        this.SetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactimage_ProcessSession")]
    public ait_contactimage ait_contactimage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactimage_ProcessSession));
        this.SetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactimage_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincarceration_ProcessSession")]
    public ait_contactincarceration ait_contactincarceration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_ProcessSession));
        this.SetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_ProcessSession")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_ProcessSession));
        this.SetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactlanguage_ProcessSession")]
    public ait_contactlanguage ait_contactlanguage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_ProcessSession));
        this.SetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_ProcessSession")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_ProcessSession));
        this.SetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactname_ProcessSession")]
    public ait_contactname ait_contactname_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_ProcessSession));
        this.SetRelatedEntity<ait_contactname>(nameof (ait_contactname_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactskill_ProcessSession")]
    public ait_contactskill ait_contactskill_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactskill_ProcessSession));
        this.SetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactskill_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_countryregion_ProcessSession")]
    public ait_countryregion ait_countryregion_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_ProcessSession));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_county_ProcessSession")]
    public ait_county ait_county_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_county>(nameof (ait_county_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_county_ProcessSession));
        this.SetRelatedEntity<ait_county>(nameof (ait_county_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_county_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_ProcessSession")]
    public ait_courtcase ait_courtcase_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_ProcessSession));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtfinesandfees_ProcessSession")]
    public ait_courtfinesandfees ait_courtfinesandfees_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_ProcessSession));
        this.SetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtparty_ProcessSession")]
    public ait_courtparty ait_courtparty_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_ProcessSession));
        this.SetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtpayments_ProcessSession")]
    public ait_courtpayments ait_courtpayments_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_ProcessSession));
        this.SetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofile_ProcessSession")]
    public ait_courtprofile ait_courtprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_ProcessSession));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofileaddress_ProcessSession")]
    public ait_courtprofileaddress ait_courtprofileaddress_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_ProcessSession));
        this.SetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtroom_ProcessSession")]
    public ait_courtroom ait_courtroom_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtroom_ProcessSession));
        this.SetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtroom_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_datamigrationhistory_ProcessSession")]
    public ait_datamigrationhistory ait_datamigrationhistory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_ProcessSession));
        this.SetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_deathrecord_ProcessSession")]
    public ait_deathrecord ait_deathrecord_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_ProcessSession));
        this.SetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_degree_ProcessSession")]
    public ait_degree ait_degree_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_degree>(nameof (ait_degree_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_degree_ProcessSession));
        this.SetRelatedEntity<ait_degree>(nameof (ait_degree_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_degree_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_electronicaddress_ProcessSession")]
    public ait_electronicaddress ait_electronicaddress_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_ProcessSession));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_emergencycontact_ProcessSession")]
    public ait_emergencycontact ait_emergencycontact_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_ProcessSession));
        this.SetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_ProcessSession")]
    public ait_familygroup ait_familygroup_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ProcessSession));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_ProcessSession")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_ProcessSession));
        this.SetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_geographicalarea_ProcessSession")]
    public ait_geographicalarea ait_geographicalarea_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_ProcessSession));
        this.SetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_ProcessSession")]
    public ait_goal ait_goal_ProcessSession
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_ProcessSession));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivity_ProcessSession")]
    public ait_groupactivity ait_groupactivity_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_ProcessSession));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_ProcessSession")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_ProcessSession));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_household_ProcessSession")]
    public ait_household ait_household_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_ProcessSession));
        this.SetRelatedEntity<ait_household>(nameof (ait_household_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_householdmember_ProcessSession")]
    public ait_householdmember ait_householdmember_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_ProcessSession));
        this.SetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_ProcessSession")]
    public ait_icwaadoption ait_icwaadoption_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_ProcessSession));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_ProcessSession")]
    public ait_icwanotice ait_icwanotice_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_ProcessSession));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregion_ProcessSession")]
    public ait_icwaregion ait_icwaregion_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_ProcessSession));
        this.SetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregionnotification_ProcessSession")]
    public ait_icwaregionnotification ait_icwaregionnotification_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_ProcessSession));
        this.SetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_ProcessSession")]
    public ait_incident ait_incident_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ProcessSession));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incidenttype_ProcessSession")]
    public ait_incidenttype ait_incidenttype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype_ProcessSession));
        this.SetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidenttype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_ProcessSession")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_ProcessSession));
        this.SetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_ProcessSession")]
    public ait_investigation ait_investigation_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_ProcessSession));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_language_ProcessSession")]
    public ait_language ait_language_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_language_ProcessSession));
        this.SetRelatedEntity<ait_language>(nameof (ait_language_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_language_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_languageproficiencylevel_ProcessSession")]
    public ait_languageproficiencylevel ait_languageproficiencylevel_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_ProcessSession));
        this.SetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loan_ProcessSession")]
    public ait_loan ait_loan_ProcessSession
    {
      get => this.GetRelatedEntity<ait_loan>(nameof (ait_loan_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_ProcessSession));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loandetail_ProcessSession")]
    public ait_loandetail ait_loandetail_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_ProcessSession));
        this.SetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loantype_ProcessSession")]
    public ait_loantype ait_loantype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loantype_ProcessSession));
        this.SetRelatedEntity<ait_loantype>(nameof (ait_loantype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loantype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_medicalproviders_ProcessSession")]
    public ait_medicalproviders ait_medicalproviders_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_ProcessSession));
        this.SetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofile_ProcessSession")]
    public ait_memberprofile ait_memberprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_ProcessSession));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_ProcessSession")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofilemembershipcategory_ProcessSession));
        this.SetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofilemembershipcategory_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberroll_ProcessSession")]
    public ait_memberroll ait_memberroll_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_ProcessSession));
        this.SetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipcategory_ProcessSession")]
    public ait_membershipcategory ait_membershipcategory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_ProcessSession));
        this.SetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_ProcessSession")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatuschangerequest_ProcessSession));
        this.SetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipstatuschangerequest_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_nametype_ProcessSession")]
    public ait_nametype ait_nametype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_nametype_ProcessSession));
        this.SetRelatedEntity<ait_nametype>(nameof (ait_nametype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_nametype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_ProcessSession")]
    public ait_outcome ait_outcome_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_ProcessSession));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_payment_ProcessSession")]
    public ait_payment ait_payment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_ProcessSession));
        this.SetRelatedEntity<ait_payment>(nameof (ait_payment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_physicaladdress_ProcessSession")]
    public ait_physicaladdress ait_physicaladdress_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_ProcessSession));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placement_ProcessSession")]
    public ait_placement ait_placement_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_ProcessSession));
        this.SetRelatedEntity<ait_placement>(nameof (ait_placement_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placementlocation_ProcessSession")]
    public ait_placementlocation ait_placementlocation_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_ProcessSession));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_ProcessSession")]
    public ait_planactivity ait_planactivity_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_ProcessSession));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmteligibility_ProcessSession")]
    public ait_pmteligibility ait_pmteligibility_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_ProcessSession));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtevent_ProcessSession")]
    public ait_pmtevent ait_pmtevent_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_ProcessSession));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtpaymenttype_ProcessSession")]
    public ait_pmtpaymenttype ait_pmtpaymenttype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_ProcessSession));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransaction_ProcessSession")]
    public ait_pmttransaction ait_pmttransaction_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_ProcessSession));
        this.SetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransactiondeduction_ProcessSession")]
    public ait_pmttransactiondeduction ait_pmttransactiondeduction_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_ProcessSession));
        this.SetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholding_ProcessSession")]
    public ait_pmtwithholding ait_pmtwithholding_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_ProcessSession));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholdingoverride_ProcessSession")]
    public ait_pmtwithholdingoverride ait_pmtwithholdingoverride_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_ProcessSession));
        this.SetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_ProcessSession")]
    public ait_program ait_program_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ProcessSession));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_ProcessSession")]
    public ait_referral ait_referral_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_ProcessSession));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_relationship_ProcessSession")]
    public ait_relationship ait_relationship_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_ProcessSession));
        this.SetRelatedEntity<ait_relationship>(nameof (ait_relationship_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_reservation_ProcessSession")]
    public ait_reservation ait_reservation_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_reservation_ProcessSession));
        this.SetRelatedEntity<ait_reservation>(nameof (ait_reservation_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_reservation_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_resolution_ProcessSession")]
    public ait_resolution ait_resolution_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_resolution_ProcessSession));
        this.SetRelatedEntity<ait_resolution>(nameof (ait_resolution_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_resolution_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_roll_ProcessSession")]
    public ait_roll ait_roll_ProcessSession
    {
      get => this.GetRelatedEntity<ait_roll>(nameof (ait_roll_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_ProcessSession));
        this.SetRelatedEntity<ait_roll>(nameof (ait_roll_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_safetyplan_ProcessSession")]
    public ait_safetyplan ait_safetyplan_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_ProcessSession));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_school_ProcessSession")]
    public ait_school ait_school_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_school>(nameof (ait_school_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_ProcessSession));
        this.SetRelatedEntity<ait_school>(nameof (ait_school_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_schooltype_ProcessSession")]
    public ait_schooltype ait_schooltype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_schooltype_ProcessSession));
        this.SetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_schooltype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_ProcessSession")]
    public ait_servicerequest ait_servicerequest_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ProcessSession));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_skill_ProcessSession")]
    public ait_skill ait_skill_ProcessSession
    {
      get => this.GetRelatedEntity<ait_skill>(nameof (ait_skill_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_skill_ProcessSession));
        this.SetRelatedEntity<ait_skill>(nameof (ait_skill_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_skill_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_stateprovince_ProcessSession")]
    public ait_stateprovince ait_stateprovince_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_ProcessSession));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_statute_ProcessSession")]
    public ait_statute ait_statute_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_ProcessSession));
        this.SetRelatedEntity<ait_statute>(nameof (ait_statute_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_training_ProcessSession")]
    public ait_training ait_training_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_training_ProcessSession));
        this.SetRelatedEntity<ait_training>(nameof (ait_training_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_training_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_trainingtype_ProcessSession")]
    public ait_trainingtype ait_trainingtype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_trainingtype_ProcessSession));
        this.SetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_trainingtype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_ProcessSession")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_ProcessSession));
        this.SetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribe_ProcessSession")]
    public ait_tribe ait_tribe_ProcessSession
    {
      get => this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_ProcessSession));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_tribe_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_withholdingtype_ProcessSession")]
    public ait_withholdingtype ait_withholdingtype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_ProcessSession));
        this.SetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_zipcodecity_ProcessSession")]
    public ait_zipcodecity ait_zipcodecity_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_ProcessSession));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Annotation_ProcessSessions")]
    public Annotation Annotation_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<Annotation>(nameof (Annotation_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Annotation_ProcessSessions));
        this.SetRelatedEntity<Annotation>(nameof (Annotation_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Annotation_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("apisettings_ProcessSession")]
    public apisettings apisettings_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<apisettings>(nameof (apisettings_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_ProcessSession));
        this.SetRelatedEntity<apisettings>(nameof (apisettings_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appelement_ProcessSession")]
    public AppElement appelement_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<AppElement>(nameof (appelement_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_ProcessSession));
        this.SetRelatedEntity<AppElement>(nameof (appelement_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("applicationuser_ProcessSession")]
    public ApplicationUser applicationuser_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_ProcessSession));
        this.SetRelatedEntity<ApplicationUser>(nameof (applicationuser_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentedge_ProcessSession")]
    public AppModuleComponentEdge appmodulecomponentedge_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_ProcessSession));
        this.SetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentnode_ProcessSession")]
    public AppModuleComponentNode appmodulecomponentnode_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_ProcessSession));
        this.SetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Appointment_ProcessSessions")]
    public Appointment Appointment_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (Appointment_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Appointment_ProcessSessions));
        this.SetRelatedEntity<Appointment>(nameof (Appointment_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appsetting_ProcessSession")]
    public AppSetting appsetting_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<AppSetting>(nameof (appsetting_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_ProcessSession));
        this.SetRelatedEntity<AppSetting>(nameof (appsetting_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("bot_ProcessSession")]
    public bot bot_ProcessSession
    {
      get => this.GetRelatedEntity<bot>(nameof (bot_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_ProcessSession));
        this.SetRelatedEntity<bot>(nameof (bot_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("botcomponent_ProcessSession")]
    public botcomponent botcomponent_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<botcomponent>(nameof (botcomponent_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_ProcessSession));
        this.SetRelatedEntity<botcomponent>(nameof (botcomponent_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("BusinessUnit_ProcessSessions")]
    public BusinessUnit BusinessUnit_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_ProcessSessions));
        this.SetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("BusinessUnitNewsArticle_ProcessSessions")]
    public BusinessUnitNewsArticle BusinessUnitNewsArticle_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnitNewsArticle>(nameof (BusinessUnitNewsArticle_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitNewsArticle_ProcessSessions));
        this.SetRelatedEntity<BusinessUnitNewsArticle>(nameof (BusinessUnitNewsArticle_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnitNewsArticle_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("canvasappextendedmetadata_ProcessSession")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_ProcessSession));
        this.SetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalog_ProcessSession")]
    public Catalog catalog_ProcessSession
    {
      get => this.GetRelatedEntity<Catalog>(nameof (catalog_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (catalog_ProcessSession));
        this.SetRelatedEntity<Catalog>(nameof (catalog_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalogassignment_ProcessSession")]
    public CatalogAssignment catalogassignment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_ProcessSession));
        this.SetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("channelaccessprofile_ProcessSession")]
    public ChannelAccessProfile channelaccessprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_ProcessSession));
        this.SetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Connection_ProcessSessions")]
    public Connection Connection_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<Connection>(nameof (Connection_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Connection_ProcessSessions));
        this.SetRelatedEntity<Connection>(nameof (Connection_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Connection_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connectionreference_ProcessSession")]
    public connectionreference connectionreference_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<connectionreference>(nameof (connectionreference_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_ProcessSession));
        this.SetRelatedEntity<connectionreference>(nameof (connectionreference_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ConnectionRole_ProcessSessions")]
    public ConnectionRole ConnectionRole_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>(nameof (ConnectionRole_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConnectionRole_ProcessSessions));
        this.SetRelatedEntity<ConnectionRole>(nameof (ConnectionRole_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConnectionRole_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connector_ProcessSession")]
    public connector connector_ProcessSession
    {
      get => this.GetRelatedEntity<connector>(nameof (connector_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (connector_ProcessSession));
        this.SetRelatedEntity<connector>(nameof (connector_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_ProcessSessions")]
    public Contact Contact_ProcessSessions
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_ProcessSessions));
        this.SetRelatedEntity<Contact>(nameof (Contact_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("conversationtranscript_ProcessSession")]
    public conversationtranscript conversationtranscript_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_ProcessSession));
        this.SetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ConvertRule_ProcessSessions")]
    public ConvertRule ConvertRule_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<ConvertRule>(nameof (ConvertRule_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConvertRule_ProcessSessions));
        this.SetRelatedEntity<ConvertRule>(nameof (ConvertRule_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConvertRule_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("customapi_ProcessSession")]
    public CustomAPI customapi_ProcessSession
    {
      get => this.GetRelatedEntity<CustomAPI>(nameof (customapi_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (customapi_ProcessSession));
        this.SetRelatedEntity<CustomAPI>(nameof (customapi_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("CustomerAddress_ProcessSessions")]
    public CustomerAddress CustomerAddress_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<CustomerAddress>(nameof (CustomerAddress_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (CustomerAddress_ProcessSessions));
        this.SetRelatedEntity<CustomerAddress>(nameof (CustomerAddress_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (CustomerAddress_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("CustomerRelationship_ProcessSessions")]
    public CustomerRelationship CustomerRelationship_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<CustomerRelationship>(nameof (CustomerRelationship_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (CustomerRelationship_ProcessSessions));
        this.SetRelatedEntity<CustomerRelationship>(nameof (CustomerRelationship_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (CustomerRelationship_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolder_ProcessSession")]
    public datalakefolder datalakefolder_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_ProcessSession));
        this.SetRelatedEntity<datalakefolder>(nameof (datalakefolder_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolderpermission_ProcessSession")]
    public datalakefolderpermission datalakefolderpermission_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_ProcessSession));
        this.SetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspace_ProcessSession")]
    public datalakeworkspace datalakeworkspace_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_ProcessSession));
        this.SetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspacepermission_ProcessSession")]
    public datalakeworkspacepermission datalakeworkspacepermission_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_ProcessSession));
        this.SetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Email_ProcessSessions")]
    public Email Email_ProcessSessions
    {
      get => this.GetRelatedEntity<Email>(nameof (Email_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_ProcessSessions));
        this.SetRelatedEntity<Email>(nameof (Email_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariabledefinition_ProcessSession")]
    public EnvironmentVariableDefinition environmentvariabledefinition_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_ProcessSession));
        this.SetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariablevalue_ProcessSession")]
    public EnvironmentVariableValue environmentvariablevalue_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_ProcessSession));
        this.SetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ExpiredProcess_ProcessSessions")]
    public ExpiredProcess ExpiredProcess_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<ExpiredProcess>(nameof (ExpiredProcess_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ExpiredProcess_ProcessSessions));
        this.SetRelatedEntity<ExpiredProcess>(nameof (ExpiredProcess_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ExpiredProcess_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("exportsolutionupload_ProcessSession")]
    public ExportSolutionUpload exportsolutionupload_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_ProcessSession));
        this.SetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("externalparty_ProcessSession")]
    public ExternalParty externalparty_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ExternalParty>(nameof (externalparty_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_ProcessSession));
        this.SetRelatedEntity<ExternalParty>(nameof (externalparty_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("externalpartyitem_ProcessSession")]
    public ExternalPartyItem externalpartyitem_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ExternalPartyItem>(nameof (externalpartyitem_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalpartyitem_ProcessSession));
        this.SetRelatedEntity<ExternalPartyItem>(nameof (externalpartyitem_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalpartyitem_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Fax_ProcessSessions")]
    public Fax Fax_ProcessSessions
    {
      get => this.GetRelatedEntity<Fax>(nameof (Fax_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Fax_ProcessSessions));
        this.SetRelatedEntity<Fax>(nameof (Fax_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Goal_ProcessSessions")]
    public Goal Goal_ProcessSessions
    {
      get => this.GetRelatedEntity<Goal>(nameof (Goal_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Goal_ProcessSessions));
        this.SetRelatedEntity<Goal>(nameof (Goal_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Goal_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("goalrollupquery_ProcessSessions")]
    public GoalRollupQuery goalrollupquery_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<GoalRollupQuery>(nameof (goalrollupquery_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goalrollupquery_ProcessSessions));
        this.SetRelatedEntity<GoalRollupQuery>(nameof (goalrollupquery_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goalrollupquery_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("holidaywrapper_ProcessSession")]
    public holidaywrapper holidaywrapper_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_ProcessSession));
        this.SetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("internalcatalogassignment_ProcessSession")]
    public InternalCatalogAssignment internalcatalogassignment_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_ProcessSession));
        this.SetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticle_ProcessSessions")]
    public KbArticle KbArticle_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (KbArticle_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_ProcessSessions));
        this.SetRelatedEntity<KbArticle>(nameof (KbArticle_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticleComment_ProcessSessions")]
    public KbArticleComment KbArticleComment_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<KbArticleComment>(nameof (KbArticleComment_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleComment_ProcessSessions));
        this.SetRelatedEntity<KbArticleComment>(nameof (KbArticleComment_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleComment_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticleTemplate_ProcessSessions")]
    public KbArticleTemplate KbArticleTemplate_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<KbArticleTemplate>(nameof (KbArticleTemplate_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplate_ProcessSessions));
        this.SetRelatedEntity<KbArticleTemplate>(nameof (KbArticleTemplate_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleTemplate_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("knowledgearticle_ProcessSession")]
    public KnowledgeArticle knowledgearticle_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_ProcessSession));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_ProcessSession")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_ProcessSession));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Letter_ProcessSessions")]
    public Letter Letter_ProcessSessions
    {
      get => this.GetRelatedEntity<Letter>(nameof (Letter_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Letter_ProcessSessions));
        this.SetRelatedEntity<Letter>(nameof (Letter_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_ProcessSessions));
      }
    }

    [AttributeLogicalName("canceledby")]
    [RelationshipSchemaName("lk_processsession_canceledby")]
    public SystemUser lk_processsession_canceledby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processsession_canceledby), new EntityRole?());
      }
    }

    [AttributeLogicalName("completedby")]
    [RelationshipSchemaName("lk_processsession_completedby")]
    public SystemUser lk_processsession_completedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processsession_completedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_processsession_createdby")]
    public SystemUser lk_processsession_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processsession_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("executedby")]
    [RelationshipSchemaName("lk_processsession_executedby")]
    public SystemUser lk_processsession_executedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processsession_executedby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processsession_executedby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_processsession_executedby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processsession_executedby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_processsession_modifiedby")]
    public SystemUser lk_processsession_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processsession_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("nextlinkedsessionid")]
    [RelationshipSchemaName]
    public ProcessSession Referencinglk_processsession_nextlinkedsessionid
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>("lk_processsession_nextlinkedsessionid", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencinglk_processsession_nextlinkedsessionid));
        this.SetRelatedEntity<ProcessSession>("lk_processsession_nextlinkedsessionid", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencinglk_processsession_nextlinkedsessionid));
      }
    }

    [AttributeLogicalName("originatingsessionid")]
    [RelationshipSchemaName]
    public ProcessSession Referencinglk_processsession_originatingsessionid
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>("lk_processsession_originatingsessionid", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencinglk_processsession_originatingsessionid));
        this.SetRelatedEntity<ProcessSession>("lk_processsession_originatingsessionid", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencinglk_processsession_originatingsessionid));
      }
    }

    [AttributeLogicalName("previouslinkedsessionid")]
    [RelationshipSchemaName]
    public ProcessSession Referencinglk_processsession_previouslinkedsessionid
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>("lk_processsession_previouslinkedsessionid", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencinglk_processsession_previouslinkedsessionid));
        this.SetRelatedEntity<ProcessSession>("lk_processsession_previouslinkedsessionid", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencinglk_processsession_previouslinkedsessionid));
      }
    }

    [AttributeLogicalName("processid")]
    [RelationshipSchemaName("lk_processsession_processid")]
    public Workflow lk_processsession_processid
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (lk_processsession_processid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processsession_processid));
        this.SetRelatedEntity<Workflow>(nameof (lk_processsession_processid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processsession_processid));
      }
    }

    [AttributeLogicalName("startedby")]
    [RelationshipSchemaName("lk_processsession_startedby")]
    public SystemUser lk_processsession_startedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processsession_startedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_processsessionbase_createdonbehalfby")]
    public SystemUser lk_processsessionbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processsessionbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processsessionbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_processsessionbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processsessionbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_processsessionbase_modifiedonbehalfby")]
    public SystemUser lk_processsessionbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_processsessionbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processsessionbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_processsessionbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processsessionbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mailbox_processsessions")]
    public Mailbox mailbox_processsessions
    {
      get => this.GetRelatedEntity<Mailbox>(nameof (mailbox_processsessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (mailbox_processsessions));
        this.SetRelatedEntity<Mailbox>(nameof (mailbox_processsessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailbox_processsessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("MailMergeTemplate_ProcessSessions")]
    public MailMergeTemplate MailMergeTemplate_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<MailMergeTemplate>(nameof (MailMergeTemplate_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MailMergeTemplate_ProcessSessions));
        this.SetRelatedEntity<MailMergeTemplate>(nameof (MailMergeTemplate_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MailMergeTemplate_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mbs_pluginprofile_ProcessSession")]
    public mbs_pluginprofile mbs_pluginprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_ProcessSession));
        this.SetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("metric_ProcessSessions")]
    public Metric metric_ProcessSessions
    {
      get => this.GetRelatedEntity<Metric>(nameof (metric_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (metric_ProcessSessions));
        this.SetRelatedEntity<Metric>(nameof (metric_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (metric_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdataset_ProcessSession")]
    public msdyn_AIBDataset msdyn_aibdataset_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdataset_ProcessSession));
        this.SetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdataset_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_ProcessSession")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_ProcessSession));
        this.SetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_ProcessSession")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_ProcessSession));
        this.SetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_ProcessSession")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_ProcessSession));
        this.SetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfile_ProcessSession")]
    public msdyn_AIBFile msdyn_aibfile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_ProcessSession));
        this.SetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_ProcessSession")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfileattacheddata_ProcessSession));
        this.SetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfileattacheddata_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiconfiguration_ProcessSession")]
    public msdyn_AIConfiguration msdyn_aiconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_ProcessSession));
        this.SetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aifptrainingdocument_ProcessSession")]
    public msdyn_AIFpTrainingDocument msdyn_aifptrainingdocument_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_ProcessSession));
        this.SetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aimodel_ProcessSession")]
    public msdyn_AIModel msdyn_aimodel_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_ProcessSession));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodimage_ProcessSession")]
    public msdyn_AIOdImage msdyn_aiodimage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_ProcessSession));
        this.SetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodlabel_ProcessSession")]
    public msdyn_AIOdLabel msdyn_aiodlabel_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_ProcessSession));
        this.SetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_ProcessSession")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_ProcessSession));
        this.SetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_ProcessSession")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_ProcessSession));
        this.SetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aitemplate_ProcessSession")]
    public msdyn_AITemplate msdyn_aitemplate_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_ProcessSession));
        this.SetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_ProcessSession")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_ProcessSession));
        this.SetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisjob_ProcessSession")]
    public msdyn_analysisjob msdyn_analysisjob_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_ProcessSession));
        this.SetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresult_ProcessSession")]
    public msdyn_analysisresult msdyn_analysisresult_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_ProcessSession));
        this.SetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_ProcessSession")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_ProcessSession));
        this.SetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_dataflow_ProcessSession")]
    public msdyn_dataflow msdyn_dataflow_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_ProcessSession));
        this.SetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticle_ProcessSession")]
    public msdyn_federatedarticle msdyn_federatedarticle_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_ProcessSession));
        this.SetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_ProcessSession")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_ProcessSession));
        this.SetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_helppage_ProcessSession")]
    public msdyn_helppage msdyn_helppage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_helppage_ProcessSession));
        this.SetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_helppage_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_ProcessSession")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_ProcessSession));
        this.SetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_ProcessSession")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_ProcessSession));
        this.SetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_ProcessSession")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_ProcessSession));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_ProcessSession")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_ProcessSession));
        this.SetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_ProcessSession")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_ProcessSession));
        this.SetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_richtextfile_ProcessSession")]
    public msdyn_richtextfile msdyn_richtextfile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_ProcessSession));
        this.SetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_ProcessSession")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_ProcessSession));
        this.SetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_slakpi_ProcessSession")]
    public msdyn_slakpi msdyn_slakpi_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_ProcessSession));
        this.SetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_ProcessSession")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_ProcessSession));
        this.SetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_ProcessSession")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_ProcessSession));
        this.SetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_ProcessSession")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_ProcessSession));
        this.SetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdynce_botcontent_ProcessSession")]
    public msdynce_botcontent msdynce_botcontent_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_ProcessSession));
        this.SetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("NewProcess_ProcessSessions")]
    public NewProcess NewProcess_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<NewProcess>(nameof (NewProcess_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (NewProcess_ProcessSessions));
        this.SetRelatedEntity<NewProcess>(nameof (NewProcess_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (NewProcess_ProcessSessions));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("Owning_businessunit_processsessions")]
    public BusinessUnit Owning_businessunit_processsessions
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (Owning_businessunit_processsessions), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("package_ProcessSession")]
    public package package_ProcessSession
    {
      get => this.GetRelatedEntity<package>(nameof (package_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (package_ProcessSession));
        this.SetRelatedEntity<package>(nameof (package_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("pdfsetting_ProcessSession")]
    public PDFSetting pdfsetting_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<PDFSetting>(nameof (pdfsetting_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_ProcessSession));
        this.SetRelatedEntity<PDFSetting>(nameof (pdfsetting_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("PhoneCall_ProcessSessions")]
    public PhoneCall PhoneCall_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (PhoneCall_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_ProcessSessions));
        this.SetRelatedEntity<PhoneCall>(nameof (PhoneCall_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("position_ProcessSession")]
    public Position position_ProcessSession
    {
      get => this.GetRelatedEntity<Position>(nameof (position_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (position_ProcessSession));
        this.SetRelatedEntity<Position>(nameof (position_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("processstageparameter_ProcessSession")]
    public processstageparameter processstageparameter_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<processstageparameter>(nameof (processstageparameter_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_ProcessSession));
        this.SetRelatedEntity<processstageparameter>(nameof (processstageparameter_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("profilerule_ProcessSession")]
    public ChannelAccessProfileRule profilerule_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_ProcessSession));
        this.SetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("provisionlanguageforuser_ProcessSession")]
    public ProvisionLanguageForUser provisionlanguageforuser_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_ProcessSession));
        this.SetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Queue_ProcessSessions")]
    public Queue Queue_ProcessSessions
    {
      get => this.GetRelatedEntity<Queue>(nameof (Queue_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Queue_ProcessSessions));
        this.SetRelatedEntity<Queue>(nameof (Queue_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("QueueItem_ProcessSessions")]
    public QueueItem QueueItem_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<QueueItem>(nameof (QueueItem_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (QueueItem_ProcessSessions));
        this.SetRelatedEntity<QueueItem>(nameof (QueueItem_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QueueItem_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RecurringAppointmentMaster_ProcessSessions")]
    public RecurringAppointmentMaster RecurringAppointmentMaster_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_ProcessSessions));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RelationshipRole_ProcessSessions")]
    public RelationshipRole RelationshipRole_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>(nameof (RelationshipRole_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRole_ProcessSessions));
        this.SetRelatedEntity<RelationshipRole>(nameof (RelationshipRole_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RelationshipRole_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Report_ProcessSessions")]
    public Report Report_ProcessSessions
    {
      get => this.GetRelatedEntity<Report>(nameof (Report_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Report_ProcessSessions));
        this.SetRelatedEntity<Report>(nameof (Report_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Report_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_ProcessSession")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_ProcessSession));
        this.SetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("rollupfield_ProcessSessions")]
    public RollupField rollupfield_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<RollupField>(nameof (rollupfield_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (rollupfield_ProcessSessions));
        this.SetRelatedEntity<RollupField>(nameof (rollupfield_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (rollupfield_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("routingrule_ProcessSessions")]
    public RoutingRule routingrule_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<RoutingRule>(nameof (routingrule_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_ProcessSessions));
        this.SetRelatedEntity<RoutingRule>(nameof (routingrule_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("routingruleitem_ProcessSessions")]
    public RoutingRuleItem routingruleitem_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_ProcessSessions));
        this.SetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("serviceplan_ProcessSession")]
    public ServicePlan serviceplan_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_ProcessSession));
        this.SetRelatedEntity<ServicePlan>(nameof (serviceplan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("settingdefinition_ProcessSession")]
    public SettingDefinition settingdefinition_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<SettingDefinition>(nameof (settingdefinition_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_ProcessSession));
        this.SetRelatedEntity<SettingDefinition>(nameof (settingdefinition_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SharePointDocumentLocation_ProcessSessions")]
    public SharePointDocumentLocation SharePointDocumentLocation_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>(nameof (SharePointDocumentLocation_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocation_ProcessSessions));
        this.SetRelatedEntity<SharePointDocumentLocation>(nameof (SharePointDocumentLocation_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocumentLocation_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SharePointSite_ProcessSessions")]
    public SharePointSite SharePointSite_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>(nameof (SharePointSite_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointSite_ProcessSessions));
        this.SetRelatedEntity<SharePointSite>(nameof (SharePointSite_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointSite_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("slabase_ProcessSessions")]
    public SLA slabase_ProcessSessions
    {
      get => this.GetRelatedEntity<SLA>(nameof (slabase_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slabase_ProcessSessions));
        this.SetRelatedEntity<SLA>(nameof (slabase_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SocialActivity_ProcessSessions")]
    public SocialActivity SocialActivity_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (SocialActivity_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_ProcessSessions));
        this.SetRelatedEntity<SocialActivity>(nameof (SocialActivity_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SocialProfile_ProcessSessions")]
    public SocialProfile SocialProfile_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (SocialProfile_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialProfile_ProcessSessions));
        this.SetRelatedEntity<SocialProfile>(nameof (SocialProfile_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialProfile_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_ProcessSession")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_ProcessSession));
        this.SetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_ProcessSession")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_ProcessSession));
        this.SetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_ProcessSession")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_ProcessSession));
        this.SetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("stagesolutionupload_ProcessSession")]
    public StageSolutionUpload stagesolutionupload_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_ProcessSession));
        this.SetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Subject_ProcessSessions")]
    public Subject Subject_ProcessSessions
    {
      get => this.GetRelatedEntity<Subject>(nameof (Subject_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Subject_ProcessSessions));
        this.SetRelatedEntity<Subject>(nameof (Subject_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Subject_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SystemUser_ProcessSessions")]
    public SystemUser SystemUser_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (SystemUser_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SystemUser_ProcessSessions));
        this.SetRelatedEntity<SystemUser>(nameof (SystemUser_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SystemUser_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Task_ProcessSessions")]
    public Task Task_ProcessSessions
    {
      get => this.GetRelatedEntity<Task>(nameof (Task_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Task_ProcessSessions));
        this.SetRelatedEntity<Task>(nameof (Task_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_ProcessSessions));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_processsession")]
    public Team team_processsession
    {
      get => this.GetRelatedEntity<Team>(nameof (team_processsession), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Team_ProcessSessions")]
    public Team Team_ProcessSessions
    {
      get => this.GetRelatedEntity<Team>(nameof (Team_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Team_ProcessSessions));
        this.SetRelatedEntity<Team>(nameof (Team_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Template_ProcessSessions")]
    public Template Template_ProcessSessions
    {
      get => this.GetRelatedEntity<Template>(nameof (Template_ProcessSessions), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Template_ProcessSessions));
        this.SetRelatedEntity<Template>(nameof (Template_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Template_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Territory_ProcessSessions")]
    public Territory Territory_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<Territory>(nameof (Territory_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Territory_ProcessSessions));
        this.SetRelatedEntity<Territory>(nameof (Territory_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Territory_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("theme_ProcessSession")]
    public Theme theme_ProcessSession
    {
      get => this.GetRelatedEntity<Theme>(nameof (theme_ProcessSession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (theme_ProcessSession));
        this.SetRelatedEntity<Theme>(nameof (theme_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (theme_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("TransactionCurrency_ProcessSessions")]
    public TransactionCurrency TransactionCurrency_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ProcessSessions));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("TranslationProcess_ProcessSessions")]
    public TranslationProcess TranslationProcess_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntity<TranslationProcess>(nameof (TranslationProcess_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TranslationProcess_ProcessSessions));
        this.SetRelatedEntity<TranslationProcess>(nameof (TranslationProcess_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TranslationProcess_ProcessSessions));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("usermapping_ProcessSession")]
    public UserMapping usermapping_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<UserMapping>(nameof (usermapping_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (usermapping_ProcessSession));
        this.SetRelatedEntity<UserMapping>(nameof (usermapping_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (usermapping_ProcessSession));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("workflowbinary_ProcessSession")]
    public workflowbinary workflowbinary_ProcessSession
    {
      get
      {
        return this.GetRelatedEntity<workflowbinary>(nameof (workflowbinary_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_ProcessSession));
        this.SetRelatedEntity<workflowbinary>(nameof (workflowbinary_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_ProcessSession));
      }
    }

    public ProcessSession(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["processsessionid"] = (object) base.Id;
            break;
          case "processsessionid":
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
