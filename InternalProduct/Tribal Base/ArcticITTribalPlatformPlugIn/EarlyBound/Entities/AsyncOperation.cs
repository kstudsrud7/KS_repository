// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AsyncOperation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("asyncoperation")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AsyncOperation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "asyncoperation";
    public const string EntitySchemaName = "AsyncOperation";
    public const string PrimaryIdAttribute = "asyncoperationid";
    public const string PrimaryNameAttribute = "name";

    public AsyncOperation()
      : base("asyncoperation")
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

    [AttributeLogicalName("asyncoperationid")]
    public Guid? AsyncOperationId
    {
      get => this.GetAttributeValue<Guid?>("asyncoperationid");
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperationId));
        this.SetAttributeValue("asyncoperationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AsyncOperationId));
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AsyncOperationId = new Guid?(value);
    }

    [AttributeLogicalName("breadcrumbid")]
    public Guid? BreadcrumbId
    {
      get => this.GetAttributeValue<Guid?>("breadcrumbid");
      set
      {
        this.OnPropertyChanging(nameof (BreadcrumbId));
        this.SetAttributeValue("breadcrumbid", (object) value);
        this.OnPropertyChanged(nameof (BreadcrumbId));
      }
    }

    [AttributeLogicalName("callerorigin")]
    public string CallerOrigin
    {
      get => this.GetAttributeValue<string>("callerorigin");
      set
      {
        this.OnPropertyChanging(nameof (CallerOrigin));
        this.SetAttributeValue("callerorigin", (object) value);
        this.OnPropertyChanged(nameof (CallerOrigin));
      }
    }

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn => this.GetAttributeValue<DateTime?>("completedon");

    [AttributeLogicalName("correlationid")]
    public Guid? CorrelationId
    {
      get => this.GetAttributeValue<Guid?>("correlationid");
      set
      {
        this.OnPropertyChanging(nameof (CorrelationId));
        this.SetAttributeValue("correlationid", (object) value);
        this.OnPropertyChanged(nameof (CorrelationId));
      }
    }

    [AttributeLogicalName("correlationupdatedtime")]
    public DateTime? CorrelationUpdatedTime
    {
      get => this.GetAttributeValue<DateTime?>("correlationupdatedtime");
      set
      {
        this.OnPropertyChanging(nameof (CorrelationUpdatedTime));
        this.SetAttributeValue("correlationupdatedtime", (object) value);
        this.OnPropertyChanged(nameof (CorrelationUpdatedTime));
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

    [AttributeLogicalName("data")]
    public string Data
    {
      get => this.GetAttributeValue<string>("data");
      set
      {
        this.OnPropertyChanging(nameof (Data));
        this.SetAttributeValue("data", (object) value);
        this.OnPropertyChanged(nameof (Data));
      }
    }

    [AttributeLogicalName("dependencytoken")]
    public string DependencyToken
    {
      get => this.GetAttributeValue<string>("dependencytoken");
      set
      {
        this.OnPropertyChanging(nameof (DependencyToken));
        this.SetAttributeValue("dependencytoken", (object) value);
        this.OnPropertyChanged(nameof (DependencyToken));
      }
    }

    [AttributeLogicalName("depth")]
    public int? Depth
    {
      get => this.GetAttributeValue<int?>("depth");
      set
      {
        this.OnPropertyChanging(nameof (Depth));
        this.SetAttributeValue("depth", (object) value);
        this.OnPropertyChanged(nameof (Depth));
      }
    }

    [AttributeLogicalName("errorcode")]
    public int? ErrorCode => this.GetAttributeValue<int?>("errorcode");

    [AttributeLogicalName("executiontimespan")]
    public double? ExecutionTimeSpan => this.GetAttributeValue<double?>("executiontimespan");

    [AttributeLogicalName("expanderstarttime")]
    public DateTime? ExpanderStartTime
    {
      get => this.GetAttributeValue<DateTime?>("expanderstarttime");
      set
      {
        this.OnPropertyChanging(nameof (ExpanderStartTime));
        this.SetAttributeValue("expanderstarttime", (object) value);
        this.OnPropertyChanged(nameof (ExpanderStartTime));
      }
    }

    [AttributeLogicalName("friendlymessage")]
    public string FriendlyMessage
    {
      get => this.GetAttributeValue<string>("friendlymessage");
      set
      {
        this.OnPropertyChanging(nameof (FriendlyMessage));
        this.SetAttributeValue("friendlymessage", (object) value);
        this.OnPropertyChanged(nameof (FriendlyMessage));
      }
    }

    [AttributeLogicalName("hostid")]
    public string HostId
    {
      get => this.GetAttributeValue<string>("hostid");
      set
      {
        this.OnPropertyChanging(nameof (HostId));
        this.SetAttributeValue("hostid", (object) value);
        this.OnPropertyChanged(nameof (HostId));
      }
    }

    [AttributeLogicalName("iswaitingforevent")]
    public bool? IsWaitingForEvent => this.GetAttributeValue<bool?>("iswaitingforevent");

    [AttributeLogicalName("message")]
    public string Message => this.GetAttributeValue<string>("message");

    [AttributeLogicalName("messagename")]
    public string MessageName
    {
      get => this.GetAttributeValue<string>("messagename");
      set
      {
        this.OnPropertyChanging(nameof (MessageName));
        this.SetAttributeValue("messagename", (object) value);
        this.OnPropertyChanged(nameof (MessageName));
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

    [AttributeLogicalName("operationtype")]
    public OptionSetValue OperationType
    {
      get => this.GetAttributeValue<OptionSetValue>("operationtype");
      set
      {
        this.OnPropertyChanging(nameof (OperationType));
        this.SetAttributeValue("operationtype", (object) value);
        this.OnPropertyChanged(nameof (OperationType));
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

    [AttributeLogicalName("owningextensionid")]
    public EntityReference OwningExtensionId
    {
      get => this.GetAttributeValue<EntityReference>("owningextensionid");
      set
      {
        this.OnPropertyChanging(nameof (OwningExtensionId));
        this.SetAttributeValue("owningextensionid", (object) value);
        this.OnPropertyChanged(nameof (OwningExtensionId));
      }
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("parentpluginexecutionid")]
    public Guid? ParentPluginExecutionId
    {
      get => this.GetAttributeValue<Guid?>("parentpluginexecutionid");
      set
      {
        this.OnPropertyChanging(nameof (ParentPluginExecutionId));
        this.SetAttributeValue("parentpluginexecutionid", (object) value);
        this.OnPropertyChanged(nameof (ParentPluginExecutionId));
      }
    }

    [AttributeLogicalName("postponeuntil")]
    public DateTime? PostponeUntil
    {
      get => this.GetAttributeValue<DateTime?>("postponeuntil");
      set
      {
        this.OnPropertyChanging(nameof (PostponeUntil));
        this.SetAttributeValue("postponeuntil", (object) value);
        this.OnPropertyChanged(nameof (PostponeUntil));
      }
    }

    [AttributeLogicalName("primaryentitytype")]
    public string PrimaryEntityType
    {
      get => this.GetAttributeValue<string>("primaryentitytype");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityType));
        this.SetAttributeValue("primaryentitytype", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityType));
      }
    }

    [AttributeLogicalName("recurrencepattern")]
    public string RecurrencePattern
    {
      get => this.GetAttributeValue<string>("recurrencepattern");
      set
      {
        this.OnPropertyChanging(nameof (RecurrencePattern));
        this.SetAttributeValue("recurrencepattern", (object) value);
        this.OnPropertyChanged(nameof (RecurrencePattern));
      }
    }

    [AttributeLogicalName("recurrencestarttime")]
    public DateTime? RecurrenceStartTime
    {
      get => this.GetAttributeValue<DateTime?>("recurrencestarttime");
      set
      {
        this.OnPropertyChanging(nameof (RecurrenceStartTime));
        this.SetAttributeValue("recurrencestarttime", (object) value);
        this.OnPropertyChanged(nameof (RecurrenceStartTime));
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

    [AttributeLogicalName("requestid")]
    public Guid? RequestId
    {
      get => this.GetAttributeValue<Guid?>("requestid");
      set
      {
        this.OnPropertyChanging(nameof (RequestId));
        this.SetAttributeValue("requestid", (object) value);
        this.OnPropertyChanged(nameof (RequestId));
      }
    }

    [AttributeLogicalName("retainjobhistory")]
    public bool? RetainJobHistory
    {
      get => this.GetAttributeValue<bool?>("retainjobhistory");
      set
      {
        this.OnPropertyChanging(nameof (RetainJobHistory));
        this.SetAttributeValue("retainjobhistory", (object) value);
        this.OnPropertyChanged(nameof (RetainJobHistory));
      }
    }

    [AttributeLogicalName("retrycount")]
    public int? RetryCount => this.GetAttributeValue<int?>("retrycount");

    [AttributeLogicalName("rootexecutioncontext")]
    public string RootExecutionContext
    {
      get => this.GetAttributeValue<string>("rootexecutioncontext");
      set
      {
        this.OnPropertyChanging(nameof (RootExecutionContext));
        this.SetAttributeValue("rootexecutioncontext", (object) value);
        this.OnPropertyChanged(nameof (RootExecutionContext));
      }
    }

    [AttributeLogicalName("sequence")]
    public long? Sequence => this.GetAttributeValue<long?>("sequence");

    [AttributeLogicalName("startedon")]
    public DateTime? StartedOn => this.GetAttributeValue<DateTime?>("startedon");

    [AttributeLogicalName("statecode")]
    public AsyncOperationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AsyncOperationState?((AsyncOperationState) Enum.ToObject(typeof (AsyncOperationState), attributeValue.Value)) : new AsyncOperationState?();
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

    [AttributeLogicalName("subtype")]
    public int? Subtype => this.GetAttributeValue<int?>("subtype");

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

    [AttributeLogicalName("workflowactivationid")]
    public EntityReference WorkflowActivationId
    {
      get => this.GetAttributeValue<EntityReference>("workflowactivationid");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowActivationId));
        this.SetAttributeValue("workflowactivationid", (object) value);
        this.OnPropertyChanged(nameof (WorkflowActivationId));
      }
    }

    [AttributeLogicalName("workflowstagename")]
    public string WorkflowStageName => this.GetAttributeValue<string>("workflowstagename");

    [AttributeLogicalName("workload")]
    public string Workload
    {
      get => this.GetAttributeValue<string>("workload");
      set
      {
        this.OnPropertyChanging(nameof (Workload));
        this.SetAttributeValue("workload", (object) value);
        this.OnPropertyChanged(nameof (Workload));
      }
    }

    [RelationshipSchemaName("AsyncOperation_BulkDeleteOperation")]
    public IEnumerable<BulkDeleteOperation> AsyncOperation_BulkDeleteOperation
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteOperation>(nameof (AsyncOperation_BulkDeleteOperation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperation_BulkDeleteOperation));
        this.SetRelatedEntities<BulkDeleteOperation>(nameof (AsyncOperation_BulkDeleteOperation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AsyncOperation_BulkDeleteOperation));
      }
    }

    [RelationshipSchemaName("AsyncOperation_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> AsyncOperation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (AsyncOperation_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperation_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (AsyncOperation_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AsyncOperation_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("AsyncOperation_Emails")]
    public IEnumerable<Email> AsyncOperation_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (AsyncOperation_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperation_Emails));
        this.SetRelatedEntities<Email>(nameof (AsyncOperation_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AsyncOperation_Emails));
      }
    }

    [RelationshipSchemaName("AsyncOperation_MailboxTrackingFolder")]
    public IEnumerable<MailboxTrackingFolder> AsyncOperation_MailboxTrackingFolder
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (AsyncOperation_MailboxTrackingFolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperation_MailboxTrackingFolder));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (AsyncOperation_MailboxTrackingFolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AsyncOperation_MailboxTrackingFolder));
      }
    }

    [RelationshipSchemaName("AsyncOperation_SocialActivities")]
    public IEnumerable<SocialActivity> AsyncOperation_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (AsyncOperation_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperation_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (AsyncOperation_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AsyncOperation_SocialActivities));
      }
    }

    [RelationshipSchemaName("lk_workflowlog_asyncoperation_childworkflow")]
    public IEnumerable<WorkflowLog> lk_workflowlog_asyncoperation_childworkflow
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_asyncoperation_childworkflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_asyncoperation_childworkflow));
        this.SetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_asyncoperation_childworkflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_asyncoperation_childworkflow));
      }
    }

    [RelationshipSchemaName("lk_workflowlog_asyncoperations")]
    public IEnumerable<WorkflowLog> lk_workflowlog_asyncoperations
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_asyncoperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_asyncoperations));
        this.SetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_asyncoperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_asyncoperations));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_asyncoperation")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_asyncoperation
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_asyncoperation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_asyncoperation));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_asyncoperation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_asyncoperation));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_AsyncOperations")]
    public Account Account_AsyncOperations
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_AsyncOperations));
        this.SetRelatedEntity<Account>(nameof (Account_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ActivityMimeAttachment_AsyncOperations")]
    public ActivityMimeAttachment ActivityMimeAttachment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ActivityMimeAttachment>(nameof (ActivityMimeAttachment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityMimeAttachment_AsyncOperations));
        this.SetRelatedEntity<ActivityMimeAttachment>(nameof (ActivityMimeAttachment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityMimeAttachment_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ActivityPointer_AsyncOperations")]
    public ActivityPointer ActivityPointer_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (ActivityPointer_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityPointer_AsyncOperations));
        this.SetRelatedEntity<ActivityPointer>(nameof (ActivityPointer_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityPointer_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_accountingcode_AsyncOperations")]
    public ait_accountingcode ait_accountingcode_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_AsyncOperations));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_addresstype_AsyncOperations")]
    public ait_addresstype ait_addresstype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_addresstype_AsyncOperations));
        this.SetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_addresstype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_AsyncOperations")]
    public ait_assessment ait_assessment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_AsyncOperations));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_autonumber_AsyncOperations")]
    public ait_autonumber ait_autonumber_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_AsyncOperations));
        this.SetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_band_AsyncOperations")]
    public ait_band ait_band_AsyncOperations
    {
      get => this.GetRelatedEntity<ait_band>(nameof (ait_band_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_band_AsyncOperations));
        this.SetRelatedEntity<ait_band>(nameof (ait_band_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_band_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccount_AsyncOperations")]
    public ait_bankaccount ait_bankaccount_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_AsyncOperations));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccounttype_AsyncOperations")]
    public ait_bankaccounttype ait_bankaccounttype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccounttype_AsyncOperations));
        this.SetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccounttype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_birthrecord_AsyncOperations")]
    public ait_birthrecord ait_birthrecord_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_AsyncOperations));
        this.SetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bloodquantum_AsyncOperations")]
    public ait_bloodquantum ait_bloodquantum_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_AsyncOperations));
        this.SetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformat_AsyncOperations")]
    public ait_cardformat ait_cardformat_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_AsyncOperations));
        this.SetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformatdetail_AsyncOperations")]
    public ait_cardformatdetail ait_cardformatdetail_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_AsyncOperations));
        this.SetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardhistory_AsyncOperations")]
    public ait_cardhistory ait_cardhistory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_AsyncOperations));
        this.SetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_AsyncOperations")]
    public ait_case ait_case_AsyncOperations
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_AsyncOperations));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_AsyncOperations")]
    public ait_casenote ait_casenote_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_AsyncOperations));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_AsyncOperations")]
    public ait_caseplan ait_caseplan_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_AsyncOperations));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_causeofdeath_AsyncOperations")]
    public ait_causeofdeath ait_causeofdeath_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_causeofdeath_AsyncOperations));
        this.SetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_causeofdeath_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cemetary_AsyncOperations")]
    public ait_cemetary ait_cemetary_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_AsyncOperations));
        this.SetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_certification_AsyncOperations")]
    public ait_certification ait_certification_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_certification_AsyncOperations));
        this.SetRelatedEntity<ait_certification>(nameof (ait_certification_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_certification_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_AsyncOperations")]
    public ait_changerequest ait_changerequest_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_AsyncOperations));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequesttype_AsyncOperations")]
    public ait_changerequesttype ait_changerequesttype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_AsyncOperations));
        this.SetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_charge_AsyncOperations")]
    public ait_charge ait_charge_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_charge>(nameof (ait_charge_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_AsyncOperations));
        this.SetRelatedEntity<ait_charge>(nameof (ait_charge_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_childvisitations_AsyncOperations")]
    public ait_childvisitations ait_childvisitations_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_AsyncOperations));
        this.SetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_city_AsyncOperations")]
    public ait_city ait_city_AsyncOperations
    {
      get => this.GetRelatedEntity<ait_city>(nameof (ait_city_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_city_AsyncOperations));
        this.SetRelatedEntity<ait_city>(nameof (ait_city_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clan_AsyncOperations")]
    public ait_clan ait_clan_AsyncOperations
    {
      get => this.GetRelatedEntity<ait_clan>(nameof (ait_clan_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_clan_AsyncOperations));
        this.SetRelatedEntity<ait_clan>(nameof (ait_clan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clan_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_AsyncOperations")]
    public ait_clientprofile ait_clientprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_AsyncOperations));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committee_AsyncOperations")]
    public ait_committee ait_committee_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_AsyncOperations));
        this.SetRelatedEntity<ait_committee>(nameof (ait_committee_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemeeting_AsyncOperations")]
    public ait_committeemeeting ait_committeemeeting_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemeeting_AsyncOperations));
        this.SetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemeeting_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemember_AsyncOperations")]
    public ait_committeemember ait_committeemember_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_AsyncOperations));
        this.SetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeeposition_AsyncOperations")]
    public ait_committeeposition ait_committeeposition_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeeposition_AsyncOperations));
        this.SetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeeposition_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeepositiontype_AsyncOperations")]
    public ait_committeepositiontype ait_committeepositiontype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeepositiontype_AsyncOperations));
        this.SetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeepositiontype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_company_AsyncOperations")]
    public ait_company ait_company_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_AsyncOperations));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactcertification_AsyncOperations")]
    public ait_contactcertification ait_contactcertification_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_AsyncOperations));
        this.SetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contacteducation_AsyncOperations")]
    public ait_contacteducation ait_contacteducation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_AsyncOperations));
        this.SetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactemployment_AsyncOperations")]
    public ait_contactemployment ait_contactemployment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_AsyncOperations));
        this.SetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactimage_AsyncOperations")]
    public ait_contactimage ait_contactimage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactimage_AsyncOperations));
        this.SetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactimage_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincarceration_AsyncOperations")]
    public ait_contactincarceration ait_contactincarceration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_AsyncOperations));
        this.SetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_AsyncOperations")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_AsyncOperations));
        this.SetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactlanguage_AsyncOperations")]
    public ait_contactlanguage ait_contactlanguage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_AsyncOperations));
        this.SetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_AsyncOperations")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_AsyncOperations));
        this.SetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactname_AsyncOperations")]
    public ait_contactname ait_contactname_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_AsyncOperations));
        this.SetRelatedEntity<ait_contactname>(nameof (ait_contactname_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactskill_AsyncOperations")]
    public ait_contactskill ait_contactskill_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactskill_AsyncOperations));
        this.SetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactskill_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_countryregion_AsyncOperations")]
    public ait_countryregion ait_countryregion_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_AsyncOperations));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_county_AsyncOperations")]
    public ait_county ait_county_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_county>(nameof (ait_county_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_county_AsyncOperations));
        this.SetRelatedEntity<ait_county>(nameof (ait_county_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_county_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_AsyncOperations")]
    public ait_courtcase ait_courtcase_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_AsyncOperations));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtfinesandfees_AsyncOperations")]
    public ait_courtfinesandfees ait_courtfinesandfees_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_AsyncOperations));
        this.SetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtparty_AsyncOperations")]
    public ait_courtparty ait_courtparty_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_AsyncOperations));
        this.SetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtpayments_AsyncOperations")]
    public ait_courtpayments ait_courtpayments_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_AsyncOperations));
        this.SetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofile_AsyncOperations")]
    public ait_courtprofile ait_courtprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_AsyncOperations));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofileaddress_AsyncOperations")]
    public ait_courtprofileaddress ait_courtprofileaddress_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_AsyncOperations));
        this.SetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtroom_AsyncOperations")]
    public ait_courtroom ait_courtroom_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtroom_AsyncOperations));
        this.SetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtroom_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_datamigrationhistory_AsyncOperations")]
    public ait_datamigrationhistory ait_datamigrationhistory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_AsyncOperations));
        this.SetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_deathrecord_AsyncOperations")]
    public ait_deathrecord ait_deathrecord_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_AsyncOperations));
        this.SetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_degree_AsyncOperations")]
    public ait_degree ait_degree_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_degree>(nameof (ait_degree_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_degree_AsyncOperations));
        this.SetRelatedEntity<ait_degree>(nameof (ait_degree_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_degree_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_electronicaddress_AsyncOperations")]
    public ait_electronicaddress ait_electronicaddress_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_AsyncOperations));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_emergencycontact_AsyncOperations")]
    public ait_emergencycontact ait_emergencycontact_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_AsyncOperations));
        this.SetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_AsyncOperations")]
    public ait_familygroup ait_familygroup_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_AsyncOperations));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_AsyncOperations")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_AsyncOperations));
        this.SetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_geographicalarea_AsyncOperations")]
    public ait_geographicalarea ait_geographicalarea_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_AsyncOperations));
        this.SetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_AsyncOperations")]
    public ait_goal ait_goal_AsyncOperations
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_AsyncOperations));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivity_AsyncOperations")]
    public ait_groupactivity ait_groupactivity_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_AsyncOperations));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_AsyncOperations")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_AsyncOperations));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_household_AsyncOperations")]
    public ait_household ait_household_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_AsyncOperations));
        this.SetRelatedEntity<ait_household>(nameof (ait_household_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_householdmember_AsyncOperations")]
    public ait_householdmember ait_householdmember_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_AsyncOperations));
        this.SetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_AsyncOperations")]
    public ait_icwaadoption ait_icwaadoption_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_AsyncOperations));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_AsyncOperations")]
    public ait_icwanotice ait_icwanotice_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_AsyncOperations));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregion_AsyncOperations")]
    public ait_icwaregion ait_icwaregion_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_AsyncOperations));
        this.SetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregionnotification_AsyncOperations")]
    public ait_icwaregionnotification ait_icwaregionnotification_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_AsyncOperations));
        this.SetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_AsyncOperations")]
    public ait_incident ait_incident_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_AsyncOperations));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incidenttype_AsyncOperations")]
    public ait_incidenttype ait_incidenttype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype_AsyncOperations));
        this.SetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidenttype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_AsyncOperations")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_AsyncOperations));
        this.SetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_AsyncOperations")]
    public ait_investigation ait_investigation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_AsyncOperations));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_language_AsyncOperations")]
    public ait_language ait_language_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_language_AsyncOperations));
        this.SetRelatedEntity<ait_language>(nameof (ait_language_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_language_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_languageproficiencylevel_AsyncOperations")]
    public ait_languageproficiencylevel ait_languageproficiencylevel_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_AsyncOperations));
        this.SetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loan_AsyncOperations")]
    public ait_loan ait_loan_AsyncOperations
    {
      get => this.GetRelatedEntity<ait_loan>(nameof (ait_loan_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_AsyncOperations));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loandetail_AsyncOperations")]
    public ait_loandetail ait_loandetail_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_AsyncOperations));
        this.SetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loantype_AsyncOperations")]
    public ait_loantype ait_loantype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loantype_AsyncOperations));
        this.SetRelatedEntity<ait_loantype>(nameof (ait_loantype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loantype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_medicalproviders_AsyncOperations")]
    public ait_medicalproviders ait_medicalproviders_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_AsyncOperations));
        this.SetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofile_AsyncOperations")]
    public ait_memberprofile ait_memberprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_AsyncOperations));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_AsyncOperations")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofilemembershipcategory_AsyncOperations));
        this.SetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofilemembershipcategory_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberroll_AsyncOperations")]
    public ait_memberroll ait_memberroll_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_AsyncOperations));
        this.SetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipcategory_AsyncOperations")]
    public ait_membershipcategory ait_membershipcategory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_AsyncOperations));
        this.SetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_AsyncOperations")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatuschangerequest_AsyncOperations));
        this.SetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipstatuschangerequest_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_nametype_AsyncOperations")]
    public ait_nametype ait_nametype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_nametype_AsyncOperations));
        this.SetRelatedEntity<ait_nametype>(nameof (ait_nametype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_nametype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_AsyncOperations")]
    public ait_outcome ait_outcome_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_AsyncOperations));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_payment_AsyncOperations")]
    public ait_payment ait_payment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_AsyncOperations));
        this.SetRelatedEntity<ait_payment>(nameof (ait_payment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_physicaladdress_AsyncOperations")]
    public ait_physicaladdress ait_physicaladdress_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_AsyncOperations));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placement_AsyncOperations")]
    public ait_placement ait_placement_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_AsyncOperations));
        this.SetRelatedEntity<ait_placement>(nameof (ait_placement_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placementlocation_AsyncOperations")]
    public ait_placementlocation ait_placementlocation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_AsyncOperations));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_AsyncOperations")]
    public ait_planactivity ait_planactivity_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_AsyncOperations));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmteligibility_AsyncOperations")]
    public ait_pmteligibility ait_pmteligibility_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_AsyncOperations));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtevent_AsyncOperations")]
    public ait_pmtevent ait_pmtevent_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_AsyncOperations));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtpaymenttype_AsyncOperations")]
    public ait_pmtpaymenttype ait_pmtpaymenttype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_AsyncOperations));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransaction_AsyncOperations")]
    public ait_pmttransaction ait_pmttransaction_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_AsyncOperations));
        this.SetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransactiondeduction_AsyncOperations")]
    public ait_pmttransactiondeduction ait_pmttransactiondeduction_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_AsyncOperations));
        this.SetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholding_AsyncOperations")]
    public ait_pmtwithholding ait_pmtwithholding_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_AsyncOperations));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholdingoverride_AsyncOperations")]
    public ait_pmtwithholdingoverride ait_pmtwithholdingoverride_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_AsyncOperations));
        this.SetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_AsyncOperations")]
    public ait_program ait_program_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_AsyncOperations));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_AsyncOperations")]
    public ait_referral ait_referral_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_AsyncOperations));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_relationship_AsyncOperations")]
    public ait_relationship ait_relationship_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_AsyncOperations));
        this.SetRelatedEntity<ait_relationship>(nameof (ait_relationship_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_reservation_AsyncOperations")]
    public ait_reservation ait_reservation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_reservation_AsyncOperations));
        this.SetRelatedEntity<ait_reservation>(nameof (ait_reservation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_reservation_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_resolution_AsyncOperations")]
    public ait_resolution ait_resolution_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_resolution_AsyncOperations));
        this.SetRelatedEntity<ait_resolution>(nameof (ait_resolution_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_resolution_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_roll_AsyncOperations")]
    public ait_roll ait_roll_AsyncOperations
    {
      get => this.GetRelatedEntity<ait_roll>(nameof (ait_roll_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_AsyncOperations));
        this.SetRelatedEntity<ait_roll>(nameof (ait_roll_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_safetyplan_AsyncOperations")]
    public ait_safetyplan ait_safetyplan_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_AsyncOperations));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_school_AsyncOperations")]
    public ait_school ait_school_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_school>(nameof (ait_school_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_AsyncOperations));
        this.SetRelatedEntity<ait_school>(nameof (ait_school_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_schooltype_AsyncOperations")]
    public ait_schooltype ait_schooltype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_schooltype_AsyncOperations));
        this.SetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_schooltype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_AsyncOperations")]
    public ait_servicerequest ait_servicerequest_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_AsyncOperations));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_skill_AsyncOperations")]
    public ait_skill ait_skill_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_skill>(nameof (ait_skill_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_skill_AsyncOperations));
        this.SetRelatedEntity<ait_skill>(nameof (ait_skill_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_skill_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_stateprovince_AsyncOperations")]
    public ait_stateprovince ait_stateprovince_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_AsyncOperations));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_statute_AsyncOperations")]
    public ait_statute ait_statute_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_AsyncOperations));
        this.SetRelatedEntity<ait_statute>(nameof (ait_statute_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_training_AsyncOperations")]
    public ait_training ait_training_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_training_AsyncOperations));
        this.SetRelatedEntity<ait_training>(nameof (ait_training_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_training_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_trainingtype_AsyncOperations")]
    public ait_trainingtype ait_trainingtype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_trainingtype_AsyncOperations));
        this.SetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_trainingtype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_AsyncOperations")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_AsyncOperations));
        this.SetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribe_AsyncOperations")]
    public ait_tribe ait_tribe_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_AsyncOperations));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_tribe_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_withholdingtype_AsyncOperations")]
    public ait_withholdingtype ait_withholdingtype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_AsyncOperations));
        this.SetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_zipcodecity_AsyncOperations")]
    public ait_zipcodecity ait_zipcodecity_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_AsyncOperations));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Annotation_AsyncOperations")]
    public Annotation Annotation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<Annotation>(nameof (Annotation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Annotation_AsyncOperations));
        this.SetRelatedEntity<Annotation>(nameof (Annotation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Annotation_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("AnnualFiscalCalendar_AsyncOperations")]
    public AnnualFiscalCalendar AnnualFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<AnnualFiscalCalendar>(nameof (AnnualFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AnnualFiscalCalendar_AsyncOperations));
        this.SetRelatedEntity<AnnualFiscalCalendar>(nameof (AnnualFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AnnualFiscalCalendar_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("apisettings_AsyncOperations")]
    public apisettings apisettings_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<apisettings>(nameof (apisettings_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_AsyncOperations));
        this.SetRelatedEntity<apisettings>(nameof (apisettings_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appelement_AsyncOperations")]
    public AppElement appelement_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<AppElement>(nameof (appelement_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_AsyncOperations));
        this.SetRelatedEntity<AppElement>(nameof (appelement_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("applicationuser_AsyncOperations")]
    public ApplicationUser applicationuser_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_AsyncOperations));
        this.SetRelatedEntity<ApplicationUser>(nameof (applicationuser_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentedge_AsyncOperations")]
    public AppModuleComponentEdge appmodulecomponentedge_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_AsyncOperations));
        this.SetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentnode_AsyncOperations")]
    public AppModuleComponentNode appmodulecomponentnode_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_AsyncOperations));
        this.SetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Appointment_AsyncOperations")]
    public Appointment Appointment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (Appointment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Appointment_AsyncOperations));
        this.SetRelatedEntity<Appointment>(nameof (Appointment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appsetting_AsyncOperations")]
    public AppSetting appsetting_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<AppSetting>(nameof (appsetting_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_AsyncOperations));
        this.SetRelatedEntity<AppSetting>(nameof (appsetting_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("attributeimageconfig_AsyncOperations")]
    public AttributeImageConfig attributeimageconfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_AsyncOperations));
        this.SetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("AttributeMap_AsyncOperations")]
    public AttributeMap AttributeMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<AttributeMap>(nameof (AttributeMap_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AttributeMap_AsyncOperations));
        this.SetRelatedEntity<AttributeMap>(nameof (AttributeMap_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AttributeMap_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("bot_AsyncOperations")]
    public bot bot_AsyncOperations
    {
      get => this.GetRelatedEntity<bot>(nameof (bot_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_AsyncOperations));
        this.SetRelatedEntity<bot>(nameof (bot_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("botcomponent_AsyncOperations")]
    public botcomponent botcomponent_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<botcomponent>(nameof (botcomponent_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_AsyncOperations));
        this.SetRelatedEntity<botcomponent>(nameof (botcomponent_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_AsyncOperations));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_asyncoperation")]
    public BusinessUnit business_unit_asyncoperation
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_asyncoperation), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("BusinessUnit_AsyncOperations")]
    public BusinessUnit BusinessUnit_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_AsyncOperations));
        this.SetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("BusinessUnitNewsArticle_AsyncOperations")]
    public BusinessUnitNewsArticle BusinessUnitNewsArticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnitNewsArticle>(nameof (BusinessUnitNewsArticle_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitNewsArticle_AsyncOperations));
        this.SetRelatedEntity<BusinessUnitNewsArticle>(nameof (BusinessUnitNewsArticle_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnitNewsArticle_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Calendar_AsyncOperations")]
    public Calendar Calendar_AsyncOperations
    {
      get => this.GetRelatedEntity<Calendar>(nameof (Calendar_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Calendar_AsyncOperations));
        this.SetRelatedEntity<Calendar>(nameof (Calendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Calendar_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("canvasappextendedmetadata_AsyncOperations")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_AsyncOperations));
        this.SetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalog_AsyncOperations")]
    public Catalog catalog_AsyncOperations
    {
      get => this.GetRelatedEntity<Catalog>(nameof (catalog_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (catalog_AsyncOperations));
        this.SetRelatedEntity<Catalog>(nameof (catalog_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalogassignment_AsyncOperations")]
    public CatalogAssignment catalogassignment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_AsyncOperations));
        this.SetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("channelaccessprofile_AsyncOperations")]
    public ChannelAccessProfile channelaccessprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_AsyncOperations));
        this.SetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Connection_AsyncOperations")]
    public Connection Connection_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<Connection>(nameof (Connection_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Connection_AsyncOperations));
        this.SetRelatedEntity<Connection>(nameof (Connection_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Connection_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Connection_Role_AsyncOperations")]
    public ConnectionRole Connection_Role_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>(nameof (Connection_Role_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Connection_Role_AsyncOperations));
        this.SetRelatedEntity<ConnectionRole>(nameof (Connection_Role_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Connection_Role_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connectionreference_AsyncOperations")]
    public connectionreference connectionreference_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<connectionreference>(nameof (connectionreference_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_AsyncOperations));
        this.SetRelatedEntity<connectionreference>(nameof (connectionreference_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connector_AsyncOperations")]
    public connector connector_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<connector>(nameof (connector_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_AsyncOperations));
        this.SetRelatedEntity<connector>(nameof (connector_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_AsyncOperations")]
    public Contact Contact_AsyncOperations
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_AsyncOperations));
        this.SetRelatedEntity<Contact>(nameof (Contact_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("conversationtranscript_AsyncOperations")]
    public conversationtranscript conversationtranscript_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_AsyncOperations));
        this.SetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Convertrule_AsyncOperations")]
    public ConvertRule Convertrule_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ConvertRule>(nameof (Convertrule_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Convertrule_AsyncOperations));
        this.SetRelatedEntity<ConvertRule>(nameof (Convertrule_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Convertrule_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("customapi_AsyncOperations")]
    public CustomAPI customapi_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<CustomAPI>(nameof (customapi_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_AsyncOperations));
        this.SetRelatedEntity<CustomAPI>(nameof (customapi_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("CustomerAddress_AsyncOperations")]
    public CustomerAddress CustomerAddress_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<CustomerAddress>(nameof (CustomerAddress_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (CustomerAddress_AsyncOperations));
        this.SetRelatedEntity<CustomerAddress>(nameof (CustomerAddress_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (CustomerAddress_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("CustomerRelationship_AsyncOperations")]
    public CustomerRelationship CustomerRelationship_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<CustomerRelationship>(nameof (CustomerRelationship_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (CustomerRelationship_AsyncOperations));
        this.SetRelatedEntity<CustomerRelationship>(nameof (CustomerRelationship_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (CustomerRelationship_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolder_AsyncOperations")]
    public datalakefolder datalakefolder_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_AsyncOperations));
        this.SetRelatedEntity<datalakefolder>(nameof (datalakefolder_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolderpermission_AsyncOperations")]
    public datalakefolderpermission datalakefolderpermission_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_AsyncOperations));
        this.SetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspace_AsyncOperations")]
    public datalakeworkspace datalakeworkspace_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_AsyncOperations));
        this.SetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspacepermission_AsyncOperations")]
    public datalakeworkspacepermission datalakeworkspacepermission_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_AsyncOperations));
        this.SetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("DisplayString_AsyncOperations")]
    public DisplayString DisplayString_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<DisplayString>(nameof (DisplayString_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DisplayString_AsyncOperations));
        this.SetRelatedEntity<DisplayString>(nameof (DisplayString_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DisplayString_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Email_AsyncOperations")]
    public Email Email_AsyncOperations
    {
      get => this.GetRelatedEntity<Email>(nameof (Email_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_AsyncOperations));
        this.SetRelatedEntity<Email>(nameof (Email_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("emailserverprofile_asyncoperations")]
    public EmailServerProfile emailserverprofile_asyncoperations
    {
      get
      {
        return this.GetRelatedEntity<EmailServerProfile>(nameof (emailserverprofile_asyncoperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (emailserverprofile_asyncoperations));
        this.SetRelatedEntity<EmailServerProfile>(nameof (emailserverprofile_asyncoperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailserverprofile_asyncoperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("entityanalyticsconfig_AsyncOperations")]
    public EntityAnalyticsConfig entityanalyticsconfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_AsyncOperations));
        this.SetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("entityimageconfig_AsyncOperations")]
    public EntityImageConfig entityimageconfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_AsyncOperations));
        this.SetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("EntityMap_AsyncOperations")]
    public EntityMap EntityMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<EntityMap>(nameof (EntityMap_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (EntityMap_AsyncOperations));
        this.SetRelatedEntity<EntityMap>(nameof (EntityMap_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (EntityMap_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariabledefinition_AsyncOperations")]
    public EnvironmentVariableDefinition environmentvariabledefinition_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_AsyncOperations));
        this.SetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariablevalue_AsyncOperations")]
    public EnvironmentVariableValue environmentvariablevalue_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_AsyncOperations));
        this.SetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("exportsolutionupload_AsyncOperations")]
    public ExportSolutionUpload exportsolutionupload_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_AsyncOperations));
        this.SetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("externalparty_AsyncOperations")]
    public ExternalParty externalparty_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ExternalParty>(nameof (externalparty_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_AsyncOperations));
        this.SetRelatedEntity<ExternalParty>(nameof (externalparty_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("externalpartyitem_AsyncOperations")]
    public ExternalPartyItem externalpartyitem_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ExternalPartyItem>(nameof (externalpartyitem_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalpartyitem_AsyncOperations));
        this.SetRelatedEntity<ExternalPartyItem>(nameof (externalpartyitem_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalpartyitem_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Fax_AsyncOperations")]
    public Fax Fax_AsyncOperations
    {
      get => this.GetRelatedEntity<Fax>(nameof (Fax_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Fax_AsyncOperations));
        this.SetRelatedEntity<Fax>(nameof (Fax_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("FixedMonthlyFiscalCalendar_AsyncOperations")]
    public FixedMonthlyFiscalCalendar FixedMonthlyFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<FixedMonthlyFiscalCalendar>(nameof (FixedMonthlyFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (FixedMonthlyFiscalCalendar_AsyncOperations));
        this.SetRelatedEntity<FixedMonthlyFiscalCalendar>(nameof (FixedMonthlyFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (FixedMonthlyFiscalCalendar_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("flowsession_AsyncOperations")]
    public flowsession flowsession_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<flowsession>(nameof (flowsession_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_AsyncOperations));
        this.SetRelatedEntity<flowsession>(nameof (flowsession_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Goal_AsyncOperations")]
    public Goal Goal_AsyncOperations
    {
      get => this.GetRelatedEntity<Goal>(nameof (Goal_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Goal_AsyncOperations));
        this.SetRelatedEntity<Goal>(nameof (Goal_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Goal_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("goalrollupquery_AsyncOperations")]
    public GoalRollupQuery goalrollupquery_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<GoalRollupQuery>(nameof (goalrollupquery_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goalrollupquery_AsyncOperations));
        this.SetRelatedEntity<GoalRollupQuery>(nameof (goalrollupquery_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goalrollupquery_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("holidaywrapper_AsyncOperations")]
    public holidaywrapper holidaywrapper_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_AsyncOperations));
        this.SetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Import_AsyncOperations")]
    public Import Import_AsyncOperations
    {
      get => this.GetRelatedEntity<Import>(nameof (Import_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Import_AsyncOperations));
        this.SetRelatedEntity<Import>(nameof (Import_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Import_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ImportFile_AsyncOperations")]
    public ImportFile ImportFile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ImportFile>(nameof (ImportFile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportFile_AsyncOperations));
        this.SetRelatedEntity<ImportFile>(nameof (ImportFile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportFile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ImportLog_AsyncOperations")]
    public ImportLog ImportLog_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ImportLog>(nameof (ImportLog_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportLog_AsyncOperations));
        this.SetRelatedEntity<ImportLog>(nameof (ImportLog_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportLog_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ImportMap_AsyncOperations")]
    public ImportMap ImportMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ImportMap>(nameof (ImportMap_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportMap_AsyncOperations));
        this.SetRelatedEntity<ImportMap>(nameof (ImportMap_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportMap_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("interactionforemail_AsyncOperations")]
    public InteractionForEmail interactionforemail_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<InteractionForEmail>(nameof (interactionforemail_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (interactionforemail_AsyncOperations));
        this.SetRelatedEntity<InteractionForEmail>(nameof (interactionforemail_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (interactionforemail_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("internalcatalogassignment_AsyncOperations")]
    public InternalCatalogAssignment internalcatalogassignment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_AsyncOperations));
        this.SetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("IsvConfig_AsyncOperations")]
    public IsvConfig IsvConfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<IsvConfig>(nameof (IsvConfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (IsvConfig_AsyncOperations));
        this.SetRelatedEntity<IsvConfig>(nameof (IsvConfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (IsvConfig_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticle_AsyncOperations")]
    public KbArticle KbArticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (KbArticle_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_AsyncOperations));
        this.SetRelatedEntity<KbArticle>(nameof (KbArticle_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticleComment_AsyncOperations")]
    public KbArticleComment KbArticleComment_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<KbArticleComment>(nameof (KbArticleComment_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleComment_AsyncOperations));
        this.SetRelatedEntity<KbArticleComment>(nameof (KbArticleComment_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleComment_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticleTemplate_AsyncOperations")]
    public KbArticleTemplate KbArticleTemplate_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<KbArticleTemplate>(nameof (KbArticleTemplate_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplate_AsyncOperations));
        this.SetRelatedEntity<KbArticleTemplate>(nameof (KbArticleTemplate_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleTemplate_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("knowledgearticle_AsyncOperations")]
    public KnowledgeArticle knowledgearticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_AsyncOperations));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_AsyncOperations")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_AsyncOperations));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Letter_AsyncOperations")]
    public Letter Letter_AsyncOperations
    {
      get => this.GetRelatedEntity<Letter>(nameof (Letter_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Letter_AsyncOperations));
        this.SetRelatedEntity<Letter>(nameof (Letter_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_AsyncOperations));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_asyncoperation_createdby")]
    public SystemUser lk_asyncoperation_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_asyncoperation_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_asyncoperation_createdonbehalfby")]
    public SystemUser lk_asyncoperation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_asyncoperation_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_asyncoperation_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_asyncoperation_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_asyncoperation_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_asyncoperation_modifiedby")]
    public SystemUser lk_asyncoperation_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_asyncoperation_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_asyncoperation_modifiedonbehalfby")]
    public SystemUser lk_asyncoperation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_asyncoperation_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_asyncoperation_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_asyncoperation_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_asyncoperation_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("workflowactivationid")]
    [RelationshipSchemaName("lk_asyncoperation_workflowactivationid")]
    public Workflow lk_asyncoperation_workflowactivationid
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (lk_asyncoperation_workflowactivationid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_asyncoperation_workflowactivationid));
        this.SetRelatedEntity<Workflow>(nameof (lk_asyncoperation_workflowactivationid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_asyncoperation_workflowactivationid));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mailbox_asyncoperations")]
    public Mailbox mailbox_asyncoperations
    {
      get => this.GetRelatedEntity<Mailbox>(nameof (mailbox_asyncoperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (mailbox_asyncoperations));
        this.SetRelatedEntity<Mailbox>(nameof (mailbox_asyncoperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailbox_asyncoperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("MailMergeTemplate_AsyncOperations")]
    public MailMergeTemplate MailMergeTemplate_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<MailMergeTemplate>(nameof (MailMergeTemplate_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MailMergeTemplate_AsyncOperations));
        this.SetRelatedEntity<MailMergeTemplate>(nameof (MailMergeTemplate_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MailMergeTemplate_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mbs_pluginprofile_AsyncOperations")]
    public mbs_pluginprofile mbs_pluginprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_AsyncOperations));
        this.SetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("metric_AsyncOperations")]
    public Metric metric_AsyncOperations
    {
      get => this.GetRelatedEntity<Metric>(nameof (metric_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (metric_AsyncOperations));
        this.SetRelatedEntity<Metric>(nameof (metric_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (metric_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("MonthlyFiscalCalendar_AsyncOperations")]
    public MonthlyFiscalCalendar MonthlyFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<MonthlyFiscalCalendar>(nameof (MonthlyFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MonthlyFiscalCalendar_AsyncOperations));
        this.SetRelatedEntity<MonthlyFiscalCalendar>(nameof (MonthlyFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MonthlyFiscalCalendar_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdataset_AsyncOperations")]
    public msdyn_AIBDataset msdyn_aibdataset_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdataset_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdataset_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_AsyncOperations")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_AsyncOperations")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_AsyncOperations")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfile_AsyncOperations")]
    public msdyn_AIBFile msdyn_aibfile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_AsyncOperations")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfileattacheddata_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfileattacheddata_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiconfiguration_AsyncOperations")]
    public msdyn_AIConfiguration msdyn_aiconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aifptrainingdocument_AsyncOperations")]
    public msdyn_AIFpTrainingDocument msdyn_aifptrainingdocument_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aimodel_AsyncOperations")]
    public msdyn_AIModel msdyn_aimodel_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodimage_AsyncOperations")]
    public msdyn_AIOdImage msdyn_aiodimage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodlabel_AsyncOperations")]
    public msdyn_AIOdLabel msdyn_aiodlabel_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_AsyncOperations")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_AsyncOperations")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_AsyncOperations));
        this.SetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aitemplate_AsyncOperations")]
    public msdyn_AITemplate msdyn_aitemplate_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_AsyncOperations));
        this.SetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_AsyncOperations")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_AsyncOperations));
        this.SetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisjob_AsyncOperations")]
    public msdyn_analysisjob msdyn_analysisjob_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_AsyncOperations));
        this.SetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresult_AsyncOperations")]
    public msdyn_analysisresult msdyn_analysisresult_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_AsyncOperations));
        this.SetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_AsyncOperations")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_AsyncOperations));
        this.SetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_dataflow_AsyncOperations")]
    public msdyn_dataflow msdyn_dataflow_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_AsyncOperations));
        this.SetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticle_AsyncOperations")]
    public msdyn_federatedarticle msdyn_federatedarticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_AsyncOperations));
        this.SetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_AsyncOperations")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_AsyncOperations));
        this.SetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_helppage_AsyncOperations")]
    public msdyn_helppage msdyn_helppage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_helppage_AsyncOperations));
        this.SetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_helppage_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_AsyncOperations")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_AsyncOperations));
        this.SetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_AsyncOperations")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_AsyncOperations));
        this.SetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_AsyncOperations")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_AsyncOperations));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_AsyncOperations")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_AsyncOperations));
        this.SetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_AsyncOperations")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_AsyncOperations));
        this.SetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_richtextfile_AsyncOperations")]
    public msdyn_richtextfile msdyn_richtextfile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_AsyncOperations));
        this.SetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_AsyncOperations")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_AsyncOperations));
        this.SetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_slakpi_AsyncOperations")]
    public msdyn_slakpi msdyn_slakpi_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_AsyncOperations));
        this.SetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_AsyncOperations")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_AsyncOperations));
        this.SetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_AsyncOperations")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_AsyncOperations));
        this.SetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_AsyncOperations")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_AsyncOperations));
        this.SetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdynce_botcontent_AsyncOperations")]
    public msdynce_botcontent msdynce_botcontent_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_AsyncOperations));
        this.SetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Organization_AsyncOperations")]
    public Organization Organization_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (Organization_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Organization_AsyncOperations));
        this.SetRelatedEntity<Organization>(nameof (Organization_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Organization_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("package_AsyncOperations")]
    public package package_AsyncOperations
    {
      get => this.GetRelatedEntity<package>(nameof (package_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (package_AsyncOperations));
        this.SetRelatedEntity<package>(nameof (package_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("pdfsetting_AsyncOperations")]
    public PDFSetting pdfsetting_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<PDFSetting>(nameof (pdfsetting_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_AsyncOperations));
        this.SetRelatedEntity<PDFSetting>(nameof (pdfsetting_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("PhoneCall_AsyncOperations")]
    public PhoneCall PhoneCall_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (PhoneCall_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_AsyncOperations));
        this.SetRelatedEntity<PhoneCall>(nameof (PhoneCall_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("position_AsyncOperations")]
    public Position position_AsyncOperations
    {
      get => this.GetRelatedEntity<Position>(nameof (position_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (position_AsyncOperations));
        this.SetRelatedEntity<Position>(nameof (position_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("post_AsyncOperations")]
    public Post post_AsyncOperations
    {
      get => this.GetRelatedEntity<Post>(nameof (post_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (post_AsyncOperations));
        this.SetRelatedEntity<Post>(nameof (post_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (post_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("PostFollow_AsyncOperations")]
    public PostFollow PostFollow_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<PostFollow>(nameof (PostFollow_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PostFollow_AsyncOperations));
        this.SetRelatedEntity<PostFollow>(nameof (PostFollow_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PostFollow_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Privilege_AsyncOperations")]
    public Privilege Privilege_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<Privilege>(nameof (Privilege_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Privilege_AsyncOperations));
        this.SetRelatedEntity<Privilege>(nameof (Privilege_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Privilege_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("processstageparameter_AsyncOperations")]
    public processstageparameter processstageparameter_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<processstageparameter>(nameof (processstageparameter_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_AsyncOperations));
        this.SetRelatedEntity<processstageparameter>(nameof (processstageparameter_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("profilerule_AsyncOperations")]
    public ChannelAccessProfileRule profilerule_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_AsyncOperations));
        this.SetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("provisionlanguageforuser_AsyncOperations")]
    public ProvisionLanguageForUser provisionlanguageforuser_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_AsyncOperations));
        this.SetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("QuarterlyFiscalCalendar_AsyncOperations")]
    public QuarterlyFiscalCalendar QuarterlyFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<QuarterlyFiscalCalendar>(nameof (QuarterlyFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (QuarterlyFiscalCalendar_AsyncOperations));
        this.SetRelatedEntity<QuarterlyFiscalCalendar>(nameof (QuarterlyFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QuarterlyFiscalCalendar_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Queue_AsyncOperations")]
    public Queue Queue_AsyncOperations
    {
      get => this.GetRelatedEntity<Queue>(nameof (Queue_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Queue_AsyncOperations));
        this.SetRelatedEntity<Queue>(nameof (Queue_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("QueueItem_AsyncOperations")]
    public QueueItem QueueItem_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<QueueItem>(nameof (QueueItem_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (QueueItem_AsyncOperations));
        this.SetRelatedEntity<QueueItem>(nameof (QueueItem_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QueueItem_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RecurringAppointmentMaster_AsyncOperations")]
    public RecurringAppointmentMaster RecurringAppointmentMaster_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_AsyncOperations));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RelationshipRole_AsyncOperations")]
    public RelationshipRole RelationshipRole_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>(nameof (RelationshipRole_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRole_AsyncOperations));
        this.SetRelatedEntity<RelationshipRole>(nameof (RelationshipRole_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RelationshipRole_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RelationshipRoleMap_AsyncOperations")]
    public RelationshipRoleMap RelationshipRoleMap_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRoleMap>(nameof (RelationshipRoleMap_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RelationshipRoleMap_AsyncOperations));
        this.SetRelatedEntity<RelationshipRoleMap>(nameof (RelationshipRoleMap_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RelationshipRoleMap_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Report_AsyncOperations")]
    public Report Report_AsyncOperations
    {
      get => this.GetRelatedEntity<Report>(nameof (Report_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Report_AsyncOperations));
        this.SetRelatedEntity<Report>(nameof (Report_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Report_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_AsyncOperations")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_AsyncOperations));
        this.SetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Role_AsyncOperations")]
    public Role Role_AsyncOperations
    {
      get => this.GetRelatedEntity<Role>(nameof (Role_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Role_AsyncOperations));
        this.SetRelatedEntity<Role>(nameof (Role_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Role_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("rollupfield_AsyncOperations")]
    public RollupField rollupfield_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<RollupField>(nameof (rollupfield_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (rollupfield_AsyncOperations));
        this.SetRelatedEntity<RollupField>(nameof (rollupfield_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (rollupfield_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("routingrule_AsyncOperations")]
    public RoutingRule routingrule_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<RoutingRule>(nameof (routingrule_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_AsyncOperations));
        this.SetRelatedEntity<RoutingRule>(nameof (routingrule_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("routingruleitem_AsyncOperations")]
    public RoutingRuleItem routingruleitem_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_AsyncOperations));
        this.SetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SavedQuery_AsyncOperations")]
    public SavedQuery SavedQuery_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SavedQuery>(nameof (SavedQuery_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SavedQuery_AsyncOperations));
        this.SetRelatedEntity<SavedQuery>(nameof (SavedQuery_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SavedQuery_AsyncOperations));
      }
    }

    [AttributeLogicalName("owningextensionid")]
    [RelationshipSchemaName("SdkMessageProcessingStep_AsyncOperations")]
    public SdkMessageProcessingStep SdkMessageProcessingStep_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageProcessingStep>(nameof (SdkMessageProcessingStep_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageProcessingStep_AsyncOperations));
        this.SetRelatedEntity<SdkMessageProcessingStep>(nameof (SdkMessageProcessingStep_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SdkMessageProcessingStep_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SemiAnnualFiscalCalendar_AsyncOperations")]
    public SemiAnnualFiscalCalendar SemiAnnualFiscalCalendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SemiAnnualFiscalCalendar>(nameof (SemiAnnualFiscalCalendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SemiAnnualFiscalCalendar_AsyncOperations));
        this.SetRelatedEntity<SemiAnnualFiscalCalendar>(nameof (SemiAnnualFiscalCalendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SemiAnnualFiscalCalendar_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("serviceplan_AsyncOperations")]
    public ServicePlan serviceplan_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_AsyncOperations));
        this.SetRelatedEntity<ServicePlan>(nameof (serviceplan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("settingdefinition_AsyncOperations")]
    public SettingDefinition settingdefinition_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SettingDefinition>(nameof (settingdefinition_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_AsyncOperations));
        this.SetRelatedEntity<SettingDefinition>(nameof (settingdefinition_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SharePointDocumentLocation_AsyncOperations")]
    public SharePointDocumentLocation SharePointDocumentLocation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>(nameof (SharePointDocumentLocation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocation_AsyncOperations));
        this.SetRelatedEntity<SharePointDocumentLocation>(nameof (SharePointDocumentLocation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocumentLocation_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SharePointSite_AsyncOperations")]
    public SharePointSite SharePointSite_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>(nameof (SharePointSite_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointSite_AsyncOperations));
        this.SetRelatedEntity<SharePointSite>(nameof (SharePointSite_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointSite_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("slabase_AsyncOperations")]
    public SLA slabase_AsyncOperations
    {
      get => this.GetRelatedEntity<SLA>(nameof (slabase_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slabase_AsyncOperations));
        this.SetRelatedEntity<SLA>(nameof (slabase_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SocialActivity_AsyncOperations")]
    public SocialActivity SocialActivity_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (SocialActivity_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_AsyncOperations));
        this.SetRelatedEntity<SocialActivity>(nameof (SocialActivity_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SocialProfile_AsyncOperations")]
    public SocialProfile SocialProfile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (SocialProfile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialProfile_AsyncOperations));
        this.SetRelatedEntity<SocialProfile>(nameof (SocialProfile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialProfile_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_AsyncOperations")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_AsyncOperations));
        this.SetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_AsyncOperations")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_AsyncOperations));
        this.SetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_AsyncOperations")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_AsyncOperations));
        this.SetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("stagesolutionupload_AsyncOperations")]
    public StageSolutionUpload stagesolutionupload_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_AsyncOperations));
        this.SetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Subject_AsyncOperations")]
    public Subject Subject_AsyncOperations
    {
      get => this.GetRelatedEntity<Subject>(nameof (Subject_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Subject_AsyncOperations));
        this.SetRelatedEntity<Subject>(nameof (Subject_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Subject_AsyncOperations));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("system_user_asyncoperation")]
    public SystemUser system_user_asyncoperation
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (system_user_asyncoperation), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SystemForm_AsyncOperations")]
    public SystemForm SystemForm_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SystemForm>(nameof (SystemForm_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SystemForm_AsyncOperations));
        this.SetRelatedEntity<SystemForm>(nameof (SystemForm_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SystemForm_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SystemUser_AsyncOperations")]
    public SystemUser SystemUser_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (SystemUser_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SystemUser_AsyncOperations));
        this.SetRelatedEntity<SystemUser>(nameof (SystemUser_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SystemUser_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Task_AsyncOperations")]
    public Task Task_AsyncOperations
    {
      get => this.GetRelatedEntity<Task>(nameof (Task_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Task_AsyncOperations));
        this.SetRelatedEntity<Task>(nameof (Task_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_AsyncOperations));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_asyncoperation")]
    public Team team_asyncoperation
    {
      get => this.GetRelatedEntity<Team>(nameof (team_asyncoperation), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Team_AsyncOperations")]
    public Team Team_AsyncOperations
    {
      get => this.GetRelatedEntity<Team>(nameof (Team_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Team_AsyncOperations));
        this.SetRelatedEntity<Team>(nameof (Team_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Template_AsyncOperations")]
    public Template Template_AsyncOperations
    {
      get => this.GetRelatedEntity<Template>(nameof (Template_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Template_AsyncOperations));
        this.SetRelatedEntity<Template>(nameof (Template_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Template_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Territory_AsyncOperations")]
    public Territory Territory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<Territory>(nameof (Territory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Territory_AsyncOperations));
        this.SetRelatedEntity<Territory>(nameof (Territory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Territory_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("theme_AsyncOperations")]
    public Theme theme_AsyncOperations
    {
      get => this.GetRelatedEntity<Theme>(nameof (theme_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (theme_AsyncOperations));
        this.SetRelatedEntity<Theme>(nameof (theme_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (theme_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("TransactionCurrency_AsyncOperations")]
    public TransactionCurrency TransactionCurrency_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_AsyncOperations));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("UserForm_AsyncOperations")]
    public UserForm UserForm_AsyncOperations
    {
      get => this.GetRelatedEntity<UserForm>(nameof (UserForm_AsyncOperations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (UserForm_AsyncOperations));
        this.SetRelatedEntity<UserForm>(nameof (UserForm_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserForm_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("usermapping_AsyncOperations")]
    public UserMapping usermapping_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<UserMapping>(nameof (usermapping_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (usermapping_AsyncOperations));
        this.SetRelatedEntity<UserMapping>(nameof (usermapping_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (usermapping_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("UserQuery_AsyncOperations")]
    public UserQuery UserQuery_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<UserQuery>(nameof (UserQuery_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (UserQuery_AsyncOperations));
        this.SetRelatedEntity<UserQuery>(nameof (UserQuery_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserQuery_AsyncOperations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("workflowbinary_AsyncOperations")]
    public workflowbinary workflowbinary_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntity<workflowbinary>(nameof (workflowbinary_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_AsyncOperations));
        this.SetRelatedEntity<workflowbinary>(nameof (workflowbinary_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_AsyncOperations));
      }
    }

    public AsyncOperation(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["asyncoperationid"] = (object) base.Id;
            break;
          case "asyncoperationid":
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
