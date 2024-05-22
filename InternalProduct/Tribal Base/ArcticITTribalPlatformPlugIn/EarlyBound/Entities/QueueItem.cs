// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.QueueItem
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("queueitem")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class QueueItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "queueitem";
    public const string EntitySchemaName = "QueueItem";
    public const string PrimaryIdAttribute = "queueitemid";
    public const string PrimaryNameAttribute = "title";

    public QueueItem()
      : base("queueitem")
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

    [AttributeLogicalName("enteredon")]
    public DateTime? EnteredOn => this.GetAttributeValue<DateTime?>("enteredon");

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

    [AttributeLogicalName("objectid")]
    public EntityReference ObjectId
    {
      get => this.GetAttributeValue<EntityReference>("objectid");
      set
      {
        this.OnPropertyChanging(nameof (ObjectId));
        this.SetAttributeValue("objectid", (object) value);
        this.OnPropertyChanged(nameof (ObjectId));
      }
    }

    [AttributeLogicalName("objecttypecode")]
    public OptionSetValue ObjectTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("objecttypecode");
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("priority")]
    [Obsolete]
    public int? Priority
    {
      get => this.GetAttributeValue<int?>("priority");
      set
      {
        this.OnPropertyChanging(nameof (Priority));
        this.SetAttributeValue("priority", (object) value);
        this.OnPropertyChanged(nameof (Priority));
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

    [AttributeLogicalName("queueitemid")]
    public Guid? QueueItemId
    {
      get => this.GetAttributeValue<Guid?>("queueitemid");
      set
      {
        this.OnPropertyChanging(nameof (QueueItemId));
        this.SetAttributeValue("queueitemid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (QueueItemId));
      }
    }

    [AttributeLogicalName("queueitemid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.QueueItemId = new Guid?(value);
    }

    [AttributeLogicalName("sender")]
    [Obsolete]
    public string Sender
    {
      get => this.GetAttributeValue<string>("sender");
      set
      {
        this.OnPropertyChanging(nameof (Sender));
        this.SetAttributeValue("sender", (object) value);
        this.OnPropertyChanged(nameof (Sender));
      }
    }

    [AttributeLogicalName("state")]
    [Obsolete]
    public int? State
    {
      get => this.GetAttributeValue<int?>("state");
      set
      {
        this.OnPropertyChanging(nameof (State));
        this.SetAttributeValue("state", (object) value);
        this.OnPropertyChanged(nameof (State));
      }
    }

    [AttributeLogicalName("statecode")]
    public QueueItemState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new QueueItemState?((QueueItemState) Enum.ToObject(typeof (QueueItemState), attributeValue.Value)) : new QueueItemState?();
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

    [AttributeLogicalName("status")]
    [Obsolete]
    public int? Status
    {
      get => this.GetAttributeValue<int?>("status");
      set
      {
        this.OnPropertyChanging(nameof (Status));
        this.SetAttributeValue("status", (object) value);
        this.OnPropertyChanged(nameof (Status));
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

    [AttributeLogicalName("title")]
    public string Title => this.GetAttributeValue<string>("title");

    [AttributeLogicalName("torecipients")]
    [Obsolete]
    public string ToRecipients
    {
      get => this.GetAttributeValue<string>("torecipients");
      set
      {
        this.OnPropertyChanging(nameof (ToRecipients));
        this.SetAttributeValue("torecipients", (object) value);
        this.OnPropertyChanged(nameof (ToRecipients));
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

    [AttributeLogicalName("workerid")]
    public EntityReference WorkerId
    {
      get => this.GetAttributeValue<EntityReference>("workerid");
      set
      {
        this.OnPropertyChanging(nameof (WorkerId));
        this.SetAttributeValue("workerid", (object) value);
        this.OnPropertyChanged(nameof (WorkerId));
      }
    }

    [AttributeLogicalName("workeridmodifiedon")]
    public DateTime? WorkerIdModifiedOn => this.GetAttributeValue<DateTime?>("workeridmodifiedon");

    [RelationshipSchemaName("QueueItem_AsyncOperations")]
    public IEnumerable<AsyncOperation> QueueItem_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (QueueItem_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (QueueItem_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (QueueItem_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QueueItem_AsyncOperations));
      }
    }

    [RelationshipSchemaName("QueueItem_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> QueueItem_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (QueueItem_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (QueueItem_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (QueueItem_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QueueItem_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("queueitem_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> queueitem_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (queueitem_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queueitem_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (queueitem_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queueitem_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("QueueItem_ProcessSessions")]
    public IEnumerable<ProcessSession> QueueItem_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (QueueItem_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (QueueItem_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (QueueItem_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QueueItem_ProcessSessions));
      }
    }

    [RelationshipSchemaName("QueueItem_SyncErrors")]
    public IEnumerable<SyncError> QueueItem_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (QueueItem_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (QueueItem_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (QueueItem_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QueueItem_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_queueitem")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_queueitem
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_queueitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_queueitem));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_queueitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_queueitem));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ActivityPointer_QueueItem")]
    public ActivityPointer ActivityPointer_QueueItem
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (ActivityPointer_QueueItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityPointer_QueueItem));
        this.SetRelatedEntity<ActivityPointer>(nameof (ActivityPointer_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityPointer_QueueItem));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_incident_QueueItems")]
    public ait_incident ait_incident_QueueItems
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_QueueItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_QueueItems));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_QueueItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_QueueItems));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_servicerequest_QueueItems")]
    public ait_servicerequest ait_servicerequest_QueueItems
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_QueueItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_QueueItems));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_QueueItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_QueueItems));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Appointment_QueueItem")]
    public Appointment Appointment_QueueItem
    {
      get => this.GetRelatedEntity<Appointment>(nameof (Appointment_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Appointment_QueueItem));
        this.SetRelatedEntity<Appointment>(nameof (Appointment_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_QueueItem));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Email_QueueItem")]
    public Email Email_QueueItem
    {
      get => this.GetRelatedEntity<Email>(nameof (Email_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_QueueItem));
        this.SetRelatedEntity<Email>(nameof (Email_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_QueueItem));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Fax_QueueItem")]
    public Fax Fax_QueueItem
    {
      get => this.GetRelatedEntity<Fax>(nameof (Fax_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Fax_QueueItem));
        this.SetRelatedEntity<Fax>(nameof (Fax_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_QueueItem));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("knowledgearticle_QueueItems")]
    public KnowledgeArticle knowledgearticle_QueueItems
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_QueueItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_QueueItems));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_QueueItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_QueueItems));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Letter_QueueItem")]
    public Letter Letter_QueueItem
    {
      get => this.GetRelatedEntity<Letter>(nameof (Letter_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Letter_QueueItem));
        this.SetRelatedEntity<Letter>(nameof (Letter_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_QueueItem));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_queueitem_createdonbehalfby")]
    public SystemUser lk_queueitem_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_queueitem_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_queueitem_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_queueitem_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_queueitem_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_queueitem_modifiedonbehalfby")]
    public SystemUser lk_queueitem_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_queueitem_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_queueitem_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_queueitem_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_queueitem_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_queueitembase_createdby")]
    public SystemUser lk_queueitembase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_queueitembase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_queueitembase_modifiedby")]
    public SystemUser lk_queueitembase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_queueitembase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("workerid")]
    [RelationshipSchemaName("lk_queueitembase_workerid")]
    public SystemUser lk_queueitembase_workerid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_queueitembase_workerid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_queueitembase_workerid));
        this.SetRelatedEntity<SystemUser>(nameof (lk_queueitembase_workerid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_queueitembase_workerid));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_QueueItems")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_QueueItems
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_QueueItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_QueueItems));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_QueueItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_QueueItems));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_queueitems")]
    public Organization organization_queueitems
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_queueitems), new EntityRole?());
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("PhoneCall_QueueItem")]
    public PhoneCall PhoneCall_QueueItem
    {
      get => this.GetRelatedEntity<PhoneCall>(nameof (PhoneCall_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_QueueItem));
        this.SetRelatedEntity<PhoneCall>(nameof (PhoneCall_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_QueueItem));
      }
    }

    [AttributeLogicalName("queueid")]
    [RelationshipSchemaName("queue_entries")]
    public Queue queue_entries
    {
      get => this.GetRelatedEntity<Queue>(nameof (queue_entries), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_entries));
        this.SetRelatedEntity<Queue>(nameof (queue_entries), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_entries));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("RecurringAppointmentMaster_QueueItem")]
    public RecurringAppointmentMaster RecurringAppointmentMaster_QueueItem
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_QueueItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_QueueItem));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_QueueItem));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("SocialActivity_QueueItem")]
    public SocialActivity SocialActivity_QueueItem
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (SocialActivity_QueueItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_QueueItem));
        this.SetRelatedEntity<SocialActivity>(nameof (SocialActivity_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_QueueItem));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Task_QueueItem")]
    public Task Task_QueueItem
    {
      get => this.GetRelatedEntity<Task>(nameof (Task_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Task_QueueItem));
        this.SetRelatedEntity<Task>(nameof (Task_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_QueueItem));
      }
    }

    [AttributeLogicalName("workerid")]
    [RelationshipSchemaName("team_queueitembase_workerid")]
    public Team team_queueitembase_workerid
    {
      get => this.GetRelatedEntity<Team>(nameof (team_queueitembase_workerid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_queueitembase_workerid));
        this.SetRelatedEntity<Team>(nameof (team_queueitembase_workerid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_queueitembase_workerid));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_QueueItem")]
    public TransactionCurrency TransactionCurrency_QueueItem
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_QueueItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_QueueItem));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_QueueItem));
      }
    }

    public QueueItem(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["queueitemid"] = (object) base.Id;
            break;
          case "queueitemid":
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
