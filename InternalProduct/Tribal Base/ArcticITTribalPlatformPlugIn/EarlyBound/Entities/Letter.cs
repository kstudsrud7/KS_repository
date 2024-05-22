// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Letter
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("letter")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Letter : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "letter";
    public const string EntitySchemaName = "Letter";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

    public Letter()
      : base("letter")
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

    [AttributeLogicalName("activityid")]
    public Guid? ActivityId
    {
      get => this.GetAttributeValue<Guid?>("activityid");
      set
      {
        this.OnPropertyChanging(nameof (ActivityId));
        this.SetAttributeValue("activityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("activityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ActivityId = new Guid?(value);
    }

    [AttributeLogicalName("activitytypecode")]
    public string ActivityTypeCode => this.GetAttributeValue<string>("activitytypecode");

    [AttributeLogicalName("actualdurationminutes")]
    public int? ActualDurationMinutes
    {
      get => this.GetAttributeValue<int?>("actualdurationminutes");
      set
      {
        this.OnPropertyChanging(nameof (ActualDurationMinutes));
        this.SetAttributeValue("actualdurationminutes", (object) value);
        this.OnPropertyChanged(nameof (ActualDurationMinutes));
      }
    }

    [AttributeLogicalName("actualend")]
    public DateTime? ActualEnd
    {
      get => this.GetAttributeValue<DateTime?>("actualend");
      set
      {
        this.OnPropertyChanging(nameof (ActualEnd));
        this.SetAttributeValue("actualend", (object) value);
        this.OnPropertyChanged(nameof (ActualEnd));
      }
    }

    [AttributeLogicalName("actualstart")]
    public DateTime? ActualStart
    {
      get => this.GetAttributeValue<DateTime?>("actualstart");
      set
      {
        this.OnPropertyChanging(nameof (ActualStart));
        this.SetAttributeValue("actualstart", (object) value);
        this.OnPropertyChanged(nameof (ActualStart));
      }
    }

    [AttributeLogicalName("address")]
    public string Address
    {
      get => this.GetAttributeValue<string>("address");
      set
      {
        this.OnPropertyChanging(nameof (Address));
        this.SetAttributeValue("address", (object) value);
        this.OnPropertyChanged(nameof (Address));
      }
    }

    [AttributeLogicalName("bcc")]
    public IEnumerable<ActivityParty> Bcc
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("bcc");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Bcc));
        if (value == null)
          this.SetAttributeValue("bcc", (object) value);
        else
          this.SetAttributeValue("bcc", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (Bcc));
      }
    }

    [AttributeLogicalName("category")]
    public string Category
    {
      get => this.GetAttributeValue<string>("category");
      set
      {
        this.OnPropertyChanging(nameof (Category));
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged(nameof (Category));
      }
    }

    [AttributeLogicalName("cc")]
    public IEnumerable<ActivityParty> Cc
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("cc");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Cc));
        if (value == null)
          this.SetAttributeValue("cc", (object) value);
        else
          this.SetAttributeValue("cc", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (Cc));
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

    [AttributeLogicalName("directioncode")]
    public bool? DirectionCode
    {
      get => this.GetAttributeValue<bool?>("directioncode");
      set
      {
        this.OnPropertyChanging(nameof (DirectionCode));
        this.SetAttributeValue("directioncode", (object) value);
        this.OnPropertyChanged(nameof (DirectionCode));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("from")]
    public IEnumerable<ActivityParty> From
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("from");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (From));
        if (value == null)
          this.SetAttributeValue("from", (object) value);
        else
          this.SetAttributeValue("from", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (From));
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

    [AttributeLogicalName("isbilled")]
    public bool? IsBilled
    {
      get => this.GetAttributeValue<bool?>("isbilled");
      set
      {
        this.OnPropertyChanging(nameof (IsBilled));
        this.SetAttributeValue("isbilled", (object) value);
        this.OnPropertyChanged(nameof (IsBilled));
      }
    }

    [AttributeLogicalName("isregularactivity")]
    public bool? IsRegularActivity => this.GetAttributeValue<bool?>("isregularactivity");

    [AttributeLogicalName("isworkflowcreated")]
    public bool? IsWorkflowCreated
    {
      get => this.GetAttributeValue<bool?>("isworkflowcreated");
      set
      {
        this.OnPropertyChanging(nameof (IsWorkflowCreated));
        this.SetAttributeValue("isworkflowcreated", (object) value);
        this.OnPropertyChanged(nameof (IsWorkflowCreated));
      }
    }

    [AttributeLogicalName("lastonholdtime")]
    public DateTime? LastOnHoldTime
    {
      get => this.GetAttributeValue<DateTime?>("lastonholdtime");
      set
      {
        this.OnPropertyChanging(nameof (LastOnHoldTime));
        this.SetAttributeValue("lastonholdtime", (object) value);
        this.OnPropertyChanged(nameof (LastOnHoldTime));
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

    [AttributeLogicalName("onholdtime")]
    public int? OnHoldTime => this.GetAttributeValue<int?>("onholdtime");

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

    [AttributeLogicalName("prioritycode")]
    public OptionSetValue PriorityCode
    {
      get => this.GetAttributeValue<OptionSetValue>("prioritycode");
      set
      {
        this.OnPropertyChanging(nameof (PriorityCode));
        this.SetAttributeValue("prioritycode", (object) value);
        this.OnPropertyChanged(nameof (PriorityCode));
      }
    }

    [AttributeLogicalName("processid")]
    public Guid? ProcessId
    {
      get => this.GetAttributeValue<Guid?>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
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

    [AttributeLogicalName("scheduleddurationminutes")]
    public int? ScheduledDurationMinutes
    {
      get => this.GetAttributeValue<int?>("scheduleddurationminutes");
    }

    [AttributeLogicalName("scheduledend")]
    public DateTime? ScheduledEnd
    {
      get => this.GetAttributeValue<DateTime?>("scheduledend");
      set
      {
        this.OnPropertyChanging(nameof (ScheduledEnd));
        this.SetAttributeValue("scheduledend", (object) value);
        this.OnPropertyChanged(nameof (ScheduledEnd));
      }
    }

    [AttributeLogicalName("scheduledstart")]
    public DateTime? ScheduledStart
    {
      get => this.GetAttributeValue<DateTime?>("scheduledstart");
      set
      {
        this.OnPropertyChanging(nameof (ScheduledStart));
        this.SetAttributeValue("scheduledstart", (object) value);
        this.OnPropertyChanged(nameof (ScheduledStart));
      }
    }

    [AttributeLogicalName("slaid")]
    public EntityReference SLAId
    {
      get => this.GetAttributeValue<EntityReference>("slaid");
      set
      {
        this.OnPropertyChanging(nameof (SLAId));
        this.SetAttributeValue("slaid", (object) value);
        this.OnPropertyChanged(nameof (SLAId));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    public EntityReference SLAInvokedId => this.GetAttributeValue<EntityReference>("slainvokedid");

    [AttributeLogicalName("sortdate")]
    public DateTime? SortDate
    {
      get => this.GetAttributeValue<DateTime?>("sortdate");
      set
      {
        this.OnPropertyChanging(nameof (SortDate));
        this.SetAttributeValue("sortdate", (object) value);
        this.OnPropertyChanged(nameof (SortDate));
      }
    }

    [AttributeLogicalName("stageid")]
    public Guid? StageId
    {
      get => this.GetAttributeValue<Guid?>("stageid");
      set
      {
        this.OnPropertyChanging(nameof (StageId));
        this.SetAttributeValue("stageid", (object) value);
        this.OnPropertyChanged(nameof (StageId));
      }
    }

    [AttributeLogicalName("statecode")]
    public LetterState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new LetterState?((LetterState) Enum.ToObject(typeof (LetterState), attributeValue.Value)) : new LetterState?();
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

    [AttributeLogicalName("subcategory")]
    public string Subcategory
    {
      get => this.GetAttributeValue<string>("subcategory");
      set
      {
        this.OnPropertyChanging(nameof (Subcategory));
        this.SetAttributeValue("subcategory", (object) value);
        this.OnPropertyChanged(nameof (Subcategory));
      }
    }

    [AttributeLogicalName("subject")]
    public string Subject
    {
      get => this.GetAttributeValue<string>("subject");
      set
      {
        this.OnPropertyChanging(nameof (Subject));
        this.SetAttributeValue("subject", (object) value);
        this.OnPropertyChanged(nameof (Subject));
      }
    }

    [AttributeLogicalName("subscriptionid")]
    public Guid? SubscriptionId
    {
      get => this.GetAttributeValue<Guid?>("subscriptionid");
      set
      {
        this.OnPropertyChanging(nameof (SubscriptionId));
        this.SetAttributeValue("subscriptionid", (object) value);
        this.OnPropertyChanged(nameof (SubscriptionId));
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

    [AttributeLogicalName("to")]
    public IEnumerable<ActivityParty> To
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("to");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (To));
        if (value == null)
          this.SetAttributeValue("to", (object) value);
        else
          this.SetAttributeValue("to", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (To));
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

    [RelationshipSchemaName("letter_actioncard")]
    public IEnumerable<ActionCard> letter_actioncard
    {
      get => this.GetRelatedEntities<ActionCard>(nameof (letter_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (letter_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (letter_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_actioncard));
      }
    }

    [RelationshipSchemaName("letter_activity_parties")]
    public IEnumerable<ActivityParty> letter_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (letter_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (letter_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (letter_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_activity_parties));
      }
    }

    [RelationshipSchemaName("Letter_Annotation")]
    public IEnumerable<Annotation> Letter_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (Letter_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Letter_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (Letter_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_Annotation));
      }
    }

    [RelationshipSchemaName("Letter_AsyncOperations")]
    public IEnumerable<AsyncOperation> Letter_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Letter_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Letter_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Letter_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Letter_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Letter_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Letter_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Letter_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Letter_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("letter_connections1")]
    public IEnumerable<Connection> letter_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (letter_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (letter_connections1));
        this.SetRelatedEntities<Connection>(nameof (letter_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_connections1));
      }
    }

    [RelationshipSchemaName("letter_connections2")]
    public IEnumerable<Connection> letter_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (letter_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (letter_connections2));
        this.SetRelatedEntities<Connection>(nameof (letter_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_connections2));
      }
    }

    [RelationshipSchemaName("Letter_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> Letter_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Letter_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Letter_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Letter_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("Letter_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> Letter_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Letter_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Letter_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Letter_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("letter_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> letter_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (letter_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (letter_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (letter_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Letter_ProcessSessions")]
    public IEnumerable<ProcessSession> Letter_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Letter_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Letter_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Letter_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Letter_QueueItem")]
    public IEnumerable<QueueItem> Letter_QueueItem
    {
      get => this.GetRelatedEntities<QueueItem>(nameof (Letter_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Letter_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (Letter_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_QueueItem));
      }
    }

    [RelationshipSchemaName("Letter_SyncErrors")]
    public IEnumerable<SyncError> Letter_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Letter_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Letter_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Letter_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_SyncErrors));
      }
    }

    [RelationshipSchemaName("slakpiinstance_letter")]
    public IEnumerable<SLAKPIInstance> slakpiinstance_letter
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_letter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_letter));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_letter));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_letter")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_letter
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_letter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_letter));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_letter));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_Letters")]
    public Account Account_Letters
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Letters));
        this.SetRelatedEntity<Account>(nameof (Account_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Letters));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activity_pointer_letter")]
    public ActivityPointer activity_pointer_letter
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_letter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_letter));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_letter));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_Letters")]
    public ait_assessment ait_assessment_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Letters));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_Letters")]
    public ait_case ait_case_Letters
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Letters));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_Letters")]
    public ait_casenote ait_casenote_Letters
    {
      get => this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Letters));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_Letters")]
    public ait_caseplan ait_caseplan_Letters
    {
      get => this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Letters));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_Letters")]
    public ait_changerequest ait_changerequest_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Letters));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_Letters")]
    public ait_clientprofile ait_clientprofile_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Letters));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_Letters")]
    public ait_courtcase ait_courtcase_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Letters));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_Letters")]
    public ait_familygroup ait_familygroup_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Letters));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_Letters")]
    public ait_goal ait_goal_Letters
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Letters));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_Letters")]
    public ait_icwaadoption ait_icwaadoption_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Letters));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_Letters")]
    public ait_icwanotice ait_icwanotice_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Letters));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_Letters")]
    public ait_incident ait_incident_Letters
    {
      get => this.GetRelatedEntity<ait_incident>(nameof (ait_incident_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Letters));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_Letters")]
    public ait_investigation ait_investigation_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Letters));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_Letters")]
    public ait_outcome ait_outcome_Letters
    {
      get => this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Letters));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_Letters")]
    public ait_planactivity ait_planactivity_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Letters));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_Letters")]
    public ait_program ait_program_Letters
    {
      get => this.GetRelatedEntity<ait_program>(nameof (ait_program_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Letters));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_Letters")]
    public ait_referral ait_referral_Letters
    {
      get => this.GetRelatedEntity<ait_referral>(nameof (ait_referral_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Letters));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_Letters")]
    public ait_servicerequest ait_servicerequest_Letters
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Letters));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Letters));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_letter_activities")]
    public BusinessUnit business_unit_letter_activities
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_letter_activities), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_Letters")]
    public Contact Contact_Letters
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Letters));
        this.SetRelatedEntity<Contact>(nameof (Contact_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_Letters")]
    public KnowledgeArticle KnowledgeArticle_Letters
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Letters));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Letters));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_Letters")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_Letters
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Letters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Letters));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Letters));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_letter_createdby")]
    public SystemUser lk_letter_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_letter_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_letter_createdonbehalfby")]
    public SystemUser lk_letter_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_letter_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_letter_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_letter_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_letter_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_letter_modifiedby")]
    public SystemUser lk_letter_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_letter_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_letter_modifiedonbehalfby")]
    public SystemUser lk_letter_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_letter_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_letter_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_letter_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_letter_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("manualsla_letter")]
    public SLA manualsla_letter
    {
      get => this.GetRelatedEntity<SLA>(nameof (manualsla_letter), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_letter));
        this.SetRelatedEntity<SLA>(nameof (manualsla_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_letter));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_letters")]
    public ProcessStage processstage_letters
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_letters));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_letters));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    [RelationshipSchemaName("sla_letter")]
    public SLA sla_letter => this.GetRelatedEntity<SLA>(nameof (sla_letter), new EntityRole?());

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_letter")]
    public Team team_letter => this.GetRelatedEntity<Team>(nameof (team_letter), new EntityRole?());

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Letter")]
    public TransactionCurrency TransactionCurrency_Letter
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Letter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Letter));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Letter));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_letter")]
    public SystemUser user_letter
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_letter), new EntityRole?());
    }

    public Letter(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["activityid"] = (object) base.Id;
            break;
          case "activityid":
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
