// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Queue
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("queue")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Queue : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "queue";
    public const string EntitySchemaName = "Queue";
    public const string PrimaryIdAttribute = "queueid";
    public const string PrimaryNameAttribute = "name";

    public Queue()
      : base("queue")
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

    [AttributeLogicalName("allowemailcredentials")]
    [Obsolete]
    public bool? AllowEmailCredentials => this.GetAttributeValue<bool?>("allowemailcredentials");

    [AttributeLogicalName("businessunitid")]
    [Obsolete]
    public EntityReference BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitId));
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged(nameof (BusinessUnitId));
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

    [AttributeLogicalName("defaultmailbox")]
    public EntityReference DefaultMailbox
    {
      get => this.GetAttributeValue<EntityReference>("defaultmailbox");
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

    [AttributeLogicalName("emailaddress")]
    public string EMailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EMailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EMailAddress));
      }
    }

    [AttributeLogicalName("emailpassword")]
    [Obsolete]
    public string EmailPassword => this.GetAttributeValue<string>("emailpassword");

    [AttributeLogicalName("emailrouteraccessapproval")]
    public OptionSetValue EmailRouterAccessApproval
    {
      get => this.GetAttributeValue<OptionSetValue>("emailrouteraccessapproval");
      set
      {
        this.OnPropertyChanging(nameof (EmailRouterAccessApproval));
        this.SetAttributeValue("emailrouteraccessapproval", (object) value);
        this.OnPropertyChanged(nameof (EmailRouterAccessApproval));
      }
    }

    [AttributeLogicalName("emailusername")]
    [Obsolete]
    public string EmailUsername => this.GetAttributeValue<string>("emailusername");

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("ignoreunsolicitedemail")]
    public bool? IgnoreUnsolicitedEmail
    {
      get => this.GetAttributeValue<bool?>("ignoreunsolicitedemail");
      set
      {
        this.OnPropertyChanging(nameof (IgnoreUnsolicitedEmail));
        this.SetAttributeValue("ignoreunsolicitedemail", (object) value);
        this.OnPropertyChanged(nameof (IgnoreUnsolicitedEmail));
      }
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

    [AttributeLogicalName("incomingemaildeliverymethod")]
    public OptionSetValue IncomingEmailDeliveryMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod");
      set
      {
        this.OnPropertyChanging(nameof (IncomingEmailDeliveryMethod));
        this.SetAttributeValue("incomingemaildeliverymethod", (object) value);
        this.OnPropertyChanged(nameof (IncomingEmailDeliveryMethod));
      }
    }

    [AttributeLogicalName("incomingemailfilteringmethod")]
    public OptionSetValue IncomingEmailFilteringMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("incomingemailfilteringmethod");
      set
      {
        this.OnPropertyChanging(nameof (IncomingEmailFilteringMethod));
        this.SetAttributeValue("incomingemailfilteringmethod", (object) value);
        this.OnPropertyChanged(nameof (IncomingEmailFilteringMethod));
      }
    }

    [AttributeLogicalName("isemailaddressapprovedbyo365admin")]
    public bool? IsEmailAddressApprovedByO365Admin
    {
      get => this.GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin");
    }

    [AttributeLogicalName("isfaxqueue")]
    [Obsolete]
    public bool? IsFaxQueue => this.GetAttributeValue<bool?>("isfaxqueue");

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

    [AttributeLogicalName("numberofitems")]
    public int? NumberOfItems => this.GetAttributeValue<int?>("numberofitems");

    [AttributeLogicalName("numberofmembers")]
    public int? NumberOfMembers => this.GetAttributeValue<int?>("numberofmembers");

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("outgoingemaildeliverymethod")]
    public OptionSetValue OutgoingEmailDeliveryMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingEmailDeliveryMethod));
        this.SetAttributeValue("outgoingemaildeliverymethod", (object) value);
        this.OnPropertyChanged(nameof (OutgoingEmailDeliveryMethod));
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

    [AttributeLogicalName("primaryuserid")]
    [Obsolete]
    public EntityReference PrimaryUserId
    {
      get => this.GetAttributeValue<EntityReference>("primaryuserid");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryUserId));
        this.SetAttributeValue("primaryuserid", (object) value);
        this.OnPropertyChanged(nameof (PrimaryUserId));
      }
    }

    [AttributeLogicalName("queueid")]
    public Guid? QueueId
    {
      get => this.GetAttributeValue<Guid?>("queueid");
      set
      {
        this.OnPropertyChanging(nameof (QueueId));
        this.SetAttributeValue("queueid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (QueueId));
      }
    }

    [AttributeLogicalName("queueid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.QueueId = new Guid?(value);
    }

    [AttributeLogicalName("queuetypecode")]
    public OptionSetValue QueueTypeCode => this.GetAttributeValue<OptionSetValue>("queuetypecode");

    [AttributeLogicalName("queueviewtype")]
    public OptionSetValue QueueViewType
    {
      get => this.GetAttributeValue<OptionSetValue>("queueviewtype");
      set
      {
        this.OnPropertyChanging(nameof (QueueViewType));
        this.SetAttributeValue("queueviewtype", (object) value);
        this.OnPropertyChanged(nameof (QueueViewType));
      }
    }

    [AttributeLogicalName("statecode")]
    public QueueState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new QueueState?((QueueState) Enum.ToObject(typeof (QueueState), attributeValue.Value)) : new QueueState?();
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

    [RelationshipSchemaName("convertrule_queue")]
    public IEnumerable<ConvertRule> convertrule_queue
    {
      get => this.GetRelatedEntities<ConvertRule>(nameof (convertrule_queue), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (convertrule_queue));
        this.SetRelatedEntities<ConvertRule>(nameof (convertrule_queue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (convertrule_queue));
      }
    }

    [RelationshipSchemaName("mailbox_regarding_queue")]
    public IEnumerable<Mailbox> mailbox_regarding_queue
    {
      get => this.GetRelatedEntities<Mailbox>(nameof (mailbox_regarding_queue), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (mailbox_regarding_queue));
        this.SetRelatedEntities<Mailbox>(nameof (mailbox_regarding_queue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailbox_regarding_queue));
      }
    }

    [RelationshipSchemaName("queue_activity_parties")]
    public IEnumerable<ActivityParty> queue_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (queue_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queue_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (queue_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_activity_parties));
      }
    }

    [RelationshipSchemaName("Queue_AsyncOperations")]
    public IEnumerable<AsyncOperation> Queue_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Queue_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Queue_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Queue_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Queue_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Queue_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Queue_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Queue_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Queue_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("queue_convertruleitem")]
    public IEnumerable<ConvertRuleItem> queue_convertruleitem
    {
      get
      {
        return this.GetRelatedEntities<ConvertRuleItem>(nameof (queue_convertruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queue_convertruleitem));
        this.SetRelatedEntities<ConvertRuleItem>(nameof (queue_convertruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_convertruleitem));
      }
    }

    [RelationshipSchemaName("Queue_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> Queue_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Queue_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Queue_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Queue_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("Queue_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> Queue_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Queue_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Queue_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Queue_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("Queue_Email_EmailSender")]
    public IEnumerable<Email> Queue_Email_EmailSender
    {
      get => this.GetRelatedEntities<Email>(nameof (Queue_Email_EmailSender), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Queue_Email_EmailSender));
        this.SetRelatedEntities<Email>(nameof (Queue_Email_EmailSender), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_Email_EmailSender));
      }
    }

    [RelationshipSchemaName("queue_entries")]
    public IEnumerable<QueueItem> queue_entries
    {
      get => this.GetRelatedEntities<QueueItem>(nameof (queue_entries), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_entries));
        this.SetRelatedEntities<QueueItem>(nameof (queue_entries), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_entries));
      }
    }

    [RelationshipSchemaName("queue_PostFollows")]
    public IEnumerable<PostFollow> queue_PostFollows
    {
      get => this.GetRelatedEntities<PostFollow>(nameof (queue_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_PostFollows));
        this.SetRelatedEntities<PostFollow>(nameof (queue_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_PostFollows));
      }
    }

    [RelationshipSchemaName("queue_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> queue_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (queue_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queue_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (queue_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Queue_ProcessSessions")]
    public IEnumerable<ProcessSession> Queue_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Queue_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Queue_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Queue_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_ProcessSessions));
      }
    }

    [RelationshipSchemaName("queue_routingruleitem")]
    public IEnumerable<RoutingRuleItem> queue_routingruleitem
    {
      get
      {
        return this.GetRelatedEntities<RoutingRuleItem>(nameof (queue_routingruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queue_routingruleitem));
        this.SetRelatedEntities<RoutingRuleItem>(nameof (queue_routingruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_routingruleitem));
      }
    }

    [RelationshipSchemaName("Queue_SyncErrors")]
    public IEnumerable<SyncError> Queue_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Queue_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Queue_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Queue_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_SyncErrors));
      }
    }

    [RelationshipSchemaName("queue_system_user")]
    public IEnumerable<SystemUser> queue_system_user
    {
      get => this.GetRelatedEntities<SystemUser>(nameof (queue_system_user), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_system_user));
        this.SetRelatedEntities<SystemUser>(nameof (queue_system_user), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_system_user));
      }
    }

    [RelationshipSchemaName("queue_team")]
    public IEnumerable<Team> queue_team
    {
      get => this.GetRelatedEntities<Team>(nameof (queue_team), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_team));
        this.SetRelatedEntities<Team>(nameof (queue_team), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_team));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_queue")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_queue
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_queue), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_queue));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_queue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_queue));
      }
    }

    [RelationshipSchemaName("queuemembership_association")]
    public IEnumerable<SystemUser> queuemembership_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (queuemembership_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queuemembership_association));
        this.SetRelatedEntities<SystemUser>(nameof (queuemembership_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queuemembership_association));
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_queues")]
    public BusinessUnit business_unit_queues
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_queues), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_queues));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_queues), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_queues));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_queues2")]
    public BusinessUnit business_unit_queues2
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_queues2), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_queue_createdonbehalfby")]
    public SystemUser lk_queue_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_queue_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_queue_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_queue_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_queue_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_queue_modifiedonbehalfby")]
    public SystemUser lk_queue_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_queue_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_queue_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_queue_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_queue_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_queuebase_createdby")]
    public SystemUser lk_queuebase_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_queuebase_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_queuebase_modifiedby")]
    public SystemUser lk_queuebase_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_queuebase_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_queues")]
    public Organization organization_queues
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_queues), new EntityRole?());
    }

    [AttributeLogicalName("defaultmailbox")]
    [RelationshipSchemaName("queue_defaultmailbox_mailbox")]
    public Mailbox queue_defaultmailbox_mailbox
    {
      get
      {
        return this.GetRelatedEntity<Mailbox>(nameof (queue_defaultmailbox_mailbox), new EntityRole?());
      }
    }

    [AttributeLogicalName("primaryuserid")]
    [RelationshipSchemaName("queue_primary_user")]
    public SystemUser queue_primary_user
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (queue_primary_user), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_primary_user));
        this.SetRelatedEntity<SystemUser>(nameof (queue_primary_user), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_primary_user));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Queue")]
    public TransactionCurrency TransactionCurrency_Queue
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Queue), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Queue));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Queue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Queue));
      }
    }

    public Queue(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["queueid"] = (object) base.Id;
            break;
          case "queueid":
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
