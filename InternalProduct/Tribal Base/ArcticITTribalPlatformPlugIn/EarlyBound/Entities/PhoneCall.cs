// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PhoneCall
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("phonecall")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PhoneCall : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "phonecall";
    public const string EntitySchemaName = "PhoneCall";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

    public PhoneCall()
      : base("phonecall")
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

    [AttributeLogicalName("activityadditionalparams")]
    public string ActivityAdditionalParams
    {
      get => this.GetAttributeValue<string>("activityadditionalparams");
      set
      {
        this.OnPropertyChanging(nameof (ActivityAdditionalParams));
        this.SetAttributeValue("activityadditionalparams", (object) value);
        this.OnPropertyChanged(nameof (ActivityAdditionalParams));
      }
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

    [AttributeLogicalName("ait_caseplan")]
    public EntityReference ait_CasePlan
    {
      get => this.GetAttributeValue<EntityReference>("ait_caseplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_CasePlan));
        this.SetAttributeValue("ait_caseplan", (object) value);
        this.OnPropertyChanged(nameof (ait_CasePlan));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    public EntityReference ait_FamilyGroup
    {
      get => this.GetAttributeValue<EntityReference>("ait_familygroup");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyGroup));
        this.SetAttributeValue("ait_familygroup", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_individual")]
    public EntityReference ait_Individual
    {
      get => this.GetAttributeValue<EntityReference>("ait_individual");
      set
      {
        this.OnPropertyChanging(nameof (ait_Individual));
        this.SetAttributeValue("ait_individual", (object) value);
        this.OnPropertyChanged(nameof (ait_Individual));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    public EntityReference ait_Outcome
    {
      get => this.GetAttributeValue<EntityReference>("ait_outcome");
      set
      {
        this.OnPropertyChanging(nameof (ait_Outcome));
        this.SetAttributeValue("ait_outcome", (object) value);
        this.OnPropertyChanged(nameof (ait_Outcome));
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

    [AttributeLogicalName("leftvoicemail")]
    public bool? LeftVoiceMail
    {
      get => this.GetAttributeValue<bool?>("leftvoicemail");
      set
      {
        this.OnPropertyChanging(nameof (LeftVoiceMail));
        this.SetAttributeValue("leftvoicemail", (object) value);
        this.OnPropertyChanged(nameof (LeftVoiceMail));
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

    [AttributeLogicalName("phonenumber")]
    public string PhoneNumber
    {
      get => this.GetAttributeValue<string>("phonenumber");
      set
      {
        this.OnPropertyChanging(nameof (PhoneNumber));
        this.SetAttributeValue("phonenumber", (object) value);
        this.OnPropertyChanged(nameof (PhoneNumber));
      }
    }

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
    public PhoneCallState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new PhoneCallState?((PhoneCallState) Enum.ToObject(typeof (PhoneCallState), attributeValue.Value)) : new PhoneCallState?();
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

    [RelationshipSchemaName("ait_phonecall_ait_planactivity_PhoneCall")]
    public IEnumerable<ait_planactivity> ait_phonecall_ait_planactivity_PhoneCall
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_phonecall_ait_planactivity_PhoneCall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_phonecall_ait_planactivity_PhoneCall));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_phonecall_ait_planactivity_PhoneCall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_phonecall_ait_planactivity_PhoneCall));
      }
    }

    [RelationshipSchemaName("phonecall_actioncard")]
    public IEnumerable<ActionCard> phonecall_actioncard
    {
      get => this.GetRelatedEntities<ActionCard>(nameof (phonecall_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (phonecall_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (phonecall_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_actioncard));
      }
    }

    [RelationshipSchemaName("phonecall_activity_parties")]
    public IEnumerable<ActivityParty> phonecall_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (phonecall_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (phonecall_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (phonecall_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_activity_parties));
      }
    }

    [RelationshipSchemaName("PhoneCall_Annotation")]
    public IEnumerable<Annotation> PhoneCall_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (PhoneCall_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (PhoneCall_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_Annotation));
      }
    }

    [RelationshipSchemaName("PhoneCall_AsyncOperations")]
    public IEnumerable<AsyncOperation> PhoneCall_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (PhoneCall_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (PhoneCall_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_AsyncOperations));
      }
    }

    [RelationshipSchemaName("PhoneCall_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> PhoneCall_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (PhoneCall_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (PhoneCall_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("phonecall_connections1")]
    public IEnumerable<Connection> phonecall_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (phonecall_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (phonecall_connections1));
        this.SetRelatedEntities<Connection>(nameof (phonecall_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_connections1));
      }
    }

    [RelationshipSchemaName("phonecall_connections2")]
    public IEnumerable<Connection> phonecall_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (phonecall_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (phonecall_connections2));
        this.SetRelatedEntities<Connection>(nameof (phonecall_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_connections2));
      }
    }

    [RelationshipSchemaName("PhoneCall_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> PhoneCall_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (PhoneCall_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (PhoneCall_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("PhoneCall_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> PhoneCall_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (PhoneCall_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (PhoneCall_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("phonecall_PostFollows")]
    public IEnumerable<PostFollow> phonecall_PostFollows
    {
      get => this.GetRelatedEntities<PostFollow>(nameof (phonecall_PostFollows), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (phonecall_PostFollows));
        this.SetRelatedEntities<PostFollow>(nameof (phonecall_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_PostFollows));
      }
    }

    [RelationshipSchemaName("phonecall_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> phonecall_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (phonecall_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (phonecall_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (phonecall_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("PhoneCall_ProcessSessions")]
    public IEnumerable<ProcessSession> PhoneCall_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (PhoneCall_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (PhoneCall_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_ProcessSessions));
      }
    }

    [RelationshipSchemaName("PhoneCall_QueueItem")]
    public IEnumerable<QueueItem> PhoneCall_QueueItem
    {
      get => this.GetRelatedEntities<QueueItem>(nameof (PhoneCall_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (PhoneCall_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_QueueItem));
      }
    }

    [RelationshipSchemaName("PhoneCall_SyncErrors")]
    public IEnumerable<SyncError> PhoneCall_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (PhoneCall_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (PhoneCall_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_SyncErrors));
      }
    }

    [RelationshipSchemaName("slakpiinstance_phonecall")]
    public IEnumerable<SLAKPIInstance> slakpiinstance_phonecall
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_phonecall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_phonecall));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_phonecall));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_phonecall")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_phonecall
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_phonecall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_phonecall));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_phonecall));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_Phonecalls")]
    public Account Account_Phonecalls
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_Phonecalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Phonecalls));
        this.SetRelatedEntity<Account>(nameof (Account_Phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Phonecalls));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activity_pointer_phonecall")]
    public ActivityPointer activity_pointer_phonecall
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_phonecall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_phonecall));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_phonecall));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_phonecall_Plan")]
    public ait_caseplan ait_ait_caseplan_phonecall_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_phonecall_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_phonecall_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_phonecall_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_phonecall_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_phonecall_Individual")]
    public ait_clientprofile ait_ait_clientprofile_phonecall_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_phonecall_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_phonecall_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_phonecall_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_phonecall_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_phonecall_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_phonecall_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_phonecall_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_phonecall_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_phonecall_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_phonecall_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_phonecall_Outcome")]
    public ait_outcome ait_ait_outcome_phonecall_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_phonecall_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_phonecall_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_phonecall_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_phonecall_Outcome));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_PhoneCalls")]
    public ait_assessment ait_assessment_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_PhoneCalls));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_PhoneCalls")]
    public ait_case ait_case_PhoneCalls
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_PhoneCalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_PhoneCalls));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_PhoneCalls")]
    public ait_casenote ait_casenote_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_PhoneCalls));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_PhoneCalls")]
    public ait_caseplan ait_caseplan_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_PhoneCalls));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_PhoneCalls")]
    public ait_changerequest ait_changerequest_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_PhoneCalls));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_PhoneCalls")]
    public ait_clientprofile ait_clientprofile_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_PhoneCalls));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_PhoneCalls")]
    public ait_courtcase ait_courtcase_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_PhoneCalls));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_PhoneCalls")]
    public ait_familygroup ait_familygroup_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_PhoneCalls));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_PhoneCalls")]
    public ait_goal ait_goal_PhoneCalls
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_PhoneCalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_PhoneCalls));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_PhoneCalls")]
    public ait_icwaadoption ait_icwaadoption_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_PhoneCalls));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_PhoneCalls")]
    public ait_icwanotice ait_icwanotice_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_PhoneCalls));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_PhoneCalls")]
    public ait_incident ait_incident_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_PhoneCalls));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_PhoneCalls")]
    public ait_investigation ait_investigation_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_PhoneCalls));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_PhoneCalls")]
    public ait_outcome ait_outcome_PhoneCalls
    {
      get => this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_PhoneCalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_PhoneCalls));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_PhoneCalls")]
    public ait_planactivity ait_planactivity_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_PhoneCalls));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_PhoneCalls")]
    public ait_program ait_program_PhoneCalls
    {
      get => this.GetRelatedEntity<ait_program>(nameof (ait_program_PhoneCalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_PhoneCalls));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_PhoneCalls")]
    public ait_referral ait_referral_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_PhoneCalls));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_PhoneCalls")]
    public ait_servicerequest ait_servicerequest_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_PhoneCalls));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_PhoneCalls));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_phone_call_activities")]
    public BusinessUnit business_unit_phone_call_activities
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_phone_call_activities), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_Phonecalls")]
    public Contact Contact_Phonecalls
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Phonecalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Phonecalls));
        this.SetRelatedEntity<Contact>(nameof (Contact_Phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Phonecalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_Phonecalls")]
    public KnowledgeArticle KnowledgeArticle_Phonecalls
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Phonecalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Phonecalls));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Phonecalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_PhoneCalls")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_PhoneCalls));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_PhoneCalls));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_phonecall_createdby")]
    public SystemUser lk_phonecall_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_phonecall_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_phonecall_createdonbehalfby")]
    public SystemUser lk_phonecall_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_phonecall_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_phonecall_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_phonecall_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_phonecall_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_phonecall_modifiedby")]
    public SystemUser lk_phonecall_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_phonecall_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_phonecall_modifiedonbehalfby")]
    public SystemUser lk_phonecall_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_phonecall_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_phonecall_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_phonecall_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_phonecall_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("manualsla_phonecall")]
    public SLA manualsla_phonecall
    {
      get => this.GetRelatedEntity<SLA>(nameof (manualsla_phonecall), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_phonecall));
        this.SetRelatedEntity<SLA>(nameof (manualsla_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_phonecall));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_phonecalls")]
    public ProcessStage processstage_phonecalls
    {
      get
      {
        return this.GetRelatedEntity<ProcessStage>(nameof (processstage_phonecalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_phonecalls));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_phonecalls));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    [RelationshipSchemaName("sla_phonecall")]
    public SLA sla_phonecall
    {
      get => this.GetRelatedEntity<SLA>(nameof (sla_phonecall), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_phonecall")]
    public Team team_phonecall
    {
      get => this.GetRelatedEntity<Team>(nameof (team_phonecall), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_PhoneCall")]
    public TransactionCurrency TransactionCurrency_PhoneCall
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_PhoneCall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_PhoneCall));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_PhoneCall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_PhoneCall));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_phonecall")]
    public SystemUser user_phonecall
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_phonecall), new EntityRole?());
    }

    public PhoneCall(object anonymousType)
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
