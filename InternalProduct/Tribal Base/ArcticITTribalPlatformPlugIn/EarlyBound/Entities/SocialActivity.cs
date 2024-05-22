// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SocialActivity
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("socialactivity")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SocialActivity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "socialactivity";
    public const string EntitySchemaName = "SocialActivity";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

    public SocialActivity()
      : base("socialactivity")
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

    [AttributeLogicalName("community")]
    public OptionSetValue Community
    {
      get => this.GetAttributeValue<OptionSetValue>("community");
      set
      {
        this.OnPropertyChanging(nameof (Community));
        this.SetAttributeValue("community", (object) value);
        this.OnPropertyChanged(nameof (Community));
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

    [AttributeLogicalName("inresponseto")]
    public string InResponseTo
    {
      get => this.GetAttributeValue<string>("inresponseto");
      set
      {
        this.OnPropertyChanging(nameof (InResponseTo));
        this.SetAttributeValue("inresponseto", (object) value);
        this.OnPropertyChanged(nameof (InResponseTo));
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

    [AttributeLogicalName("postauthor")]
    public EntityReference PostAuthor
    {
      get => this.GetAttributeValue<EntityReference>("postauthor");
      set
      {
        this.OnPropertyChanging(nameof (PostAuthor));
        this.SetAttributeValue("postauthor", (object) value);
        this.OnPropertyChanged(nameof (PostAuthor));
      }
    }

    [AttributeLogicalName("postauthoraccount")]
    public EntityReference PostAuthorAccount
    {
      get => this.GetAttributeValue<EntityReference>("postauthoraccount");
      set
      {
        this.OnPropertyChanging(nameof (PostAuthorAccount));
        this.SetAttributeValue("postauthoraccount", (object) value);
        this.OnPropertyChanged(nameof (PostAuthorAccount));
      }
    }

    [AttributeLogicalName("postedon")]
    public DateTime? PostedOn
    {
      get => this.GetAttributeValue<DateTime?>("postedon");
      set
      {
        this.OnPropertyChanging(nameof (PostedOn));
        this.SetAttributeValue("postedon", (object) value);
        this.OnPropertyChanged(nameof (PostedOn));
      }
    }

    [AttributeLogicalName("postfromprofileid")]
    public EntityReference PostFromProfileId
    {
      get => this.GetAttributeValue<EntityReference>("postfromprofileid");
      set
      {
        this.OnPropertyChanging(nameof (PostFromProfileId));
        this.SetAttributeValue("postfromprofileid", (object) value);
        this.OnPropertyChanged(nameof (PostFromProfileId));
      }
    }

    [AttributeLogicalName("postid")]
    public string PostId
    {
      get => this.GetAttributeValue<string>("postid");
      set
      {
        this.OnPropertyChanging(nameof (PostId));
        this.SetAttributeValue("postid", (object) value);
        this.OnPropertyChanged(nameof (PostId));
      }
    }

    [AttributeLogicalName("postmessagetype")]
    public OptionSetValue PostMessageType
    {
      get => this.GetAttributeValue<OptionSetValue>("postmessagetype");
      set
      {
        this.OnPropertyChanging(nameof (PostMessageType));
        this.SetAttributeValue("postmessagetype", (object) value);
        this.OnPropertyChanged(nameof (PostMessageType));
      }
    }

    [AttributeLogicalName("posttoprofileid")]
    public string PostToProfileId
    {
      get => this.GetAttributeValue<string>("posttoprofileid");
      set
      {
        this.OnPropertyChanging(nameof (PostToProfileId));
        this.SetAttributeValue("posttoprofileid", (object) value);
        this.OnPropertyChanged(nameof (PostToProfileId));
      }
    }

    [AttributeLogicalName("posturl")]
    public string PostURL
    {
      get => this.GetAttributeValue<string>("posturl");
      set
      {
        this.OnPropertyChanging(nameof (PostURL));
        this.SetAttributeValue("posturl", (object) value);
        this.OnPropertyChanged(nameof (PostURL));
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

    [AttributeLogicalName("resources")]
    public IEnumerable<ActivityParty> Resources
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("resources");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Resources));
        if (value == null)
          this.SetAttributeValue("resources", (object) value);
        else
          this.SetAttributeValue("resources", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (Resources));
      }
    }

    [AttributeLogicalName("scheduleddurationminutes")]
    public int? ScheduledDurationMinutes
    {
      get => this.GetAttributeValue<int?>("scheduleddurationminutes");
      set
      {
        this.OnPropertyChanging(nameof (ScheduledDurationMinutes));
        this.SetAttributeValue("scheduleddurationminutes", (object) value);
        this.OnPropertyChanged(nameof (ScheduledDurationMinutes));
      }
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

    [AttributeLogicalName("sentimentvalue")]
    public double? SentimentValue
    {
      get => this.GetAttributeValue<double?>("sentimentvalue");
      set
      {
        this.OnPropertyChanging(nameof (SentimentValue));
        this.SetAttributeValue("sentimentvalue", (object) value);
        this.OnPropertyChanged(nameof (SentimentValue));
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

    [AttributeLogicalName("socialadditionalparams")]
    public string SocialAdditionalParams
    {
      get => this.GetAttributeValue<string>("socialadditionalparams");
      set
      {
        this.OnPropertyChanging(nameof (SocialAdditionalParams));
        this.SetAttributeValue("socialadditionalparams", (object) value);
        this.OnPropertyChanged(nameof (SocialAdditionalParams));
      }
    }

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
    public SocialActivityState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SocialActivityState?((SocialActivityState) Enum.ToObject(typeof (SocialActivityState), attributeValue.Value)) : new SocialActivityState?();
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

    [AttributeLogicalName("threadid")]
    public string ThreadId
    {
      get => this.GetAttributeValue<string>("threadid");
      set
      {
        this.OnPropertyChanging(nameof (ThreadId));
        this.SetAttributeValue("threadid", (object) value);
        this.OnPropertyChanged(nameof (ThreadId));
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

    [RelationshipSchemaName("slakpiinstance_socialactivity")]
    public IEnumerable<SLAKPIInstance> slakpiinstance_socialactivity
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_socialactivity));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_socialactivity));
      }
    }

    [RelationshipSchemaName("socialactivity_activity_parties")]
    public IEnumerable<ActivityParty> socialactivity_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (socialactivity_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (socialactivity_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_activity_parties));
      }
    }

    [RelationshipSchemaName("SocialActivity_Annotation")]
    public IEnumerable<Annotation> SocialActivity_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (SocialActivity_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (SocialActivity_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_Annotation));
      }
    }

    [RelationshipSchemaName("SocialActivity_AsyncOperations")]
    public IEnumerable<AsyncOperation> SocialActivity_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (SocialActivity_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (SocialActivity_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_AsyncOperations));
      }
    }

    [RelationshipSchemaName("SocialActivity_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> SocialActivity_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (SocialActivity_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (SocialActivity_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("socialactivity_connections1")]
    public IEnumerable<Connection> socialactivity_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (socialactivity_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_connections1));
        this.SetRelatedEntities<Connection>(nameof (socialactivity_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_connections1));
      }
    }

    [RelationshipSchemaName("socialactivity_connections2")]
    public IEnumerable<Connection> socialactivity_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (socialactivity_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_connections2));
        this.SetRelatedEntities<Connection>(nameof (socialactivity_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_connections2));
      }
    }

    [RelationshipSchemaName("SocialActivity_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> SocialActivity_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (SocialActivity_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (SocialActivity_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("SocialActivity_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> SocialActivity_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (SocialActivity_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (SocialActivity_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("socialactivity_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> socialactivity_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (socialactivity_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (socialactivity_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("SocialActivity_ProcessSessions")]
    public IEnumerable<ProcessSession> SocialActivity_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (SocialActivity_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (SocialActivity_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_ProcessSessions));
      }
    }

    [RelationshipSchemaName("SocialActivity_QueueItem")]
    public IEnumerable<QueueItem> SocialActivity_QueueItem
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (SocialActivity_QueueItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (SocialActivity_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_QueueItem));
      }
    }

    [RelationshipSchemaName("SocialActivity_SyncErrors")]
    public IEnumerable<SyncError> SocialActivity_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (SocialActivity_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SocialActivity_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_socialactivity")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_socialactivity
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_socialactivity));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_socialactivity));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_SocialActivities")]
    public Account Account_SocialActivities
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_SocialActivities), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_SocialActivities));
        this.SetRelatedEntity<Account>(nameof (Account_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_SocialActivities));
      }
    }

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activity_pointer_socialactivity")]
    public ActivityPointer activity_pointer_socialactivity
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_socialactivity));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_socialactivity));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_SocialActivities")]
    public ait_assessment ait_assessment_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_SocialActivities));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_SocialActivities")]
    public ait_case ait_case_SocialActivities
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_SocialActivities), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_SocialActivities));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_SocialActivities")]
    public ait_casenote ait_casenote_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_SocialActivities));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_SocialActivities")]
    public ait_caseplan ait_caseplan_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_SocialActivities));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_SocialActivities")]
    public ait_changerequest ait_changerequest_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_SocialActivities));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_SocialActivities")]
    public ait_clientprofile ait_clientprofile_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_SocialActivities));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_SocialActivities")]
    public ait_courtcase ait_courtcase_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_SocialActivities));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_SocialActivities")]
    public ait_familygroup ait_familygroup_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_SocialActivities));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_SocialActivities")]
    public ait_goal ait_goal_SocialActivities
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_SocialActivities), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_SocialActivities));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_SocialActivities")]
    public ait_icwaadoption ait_icwaadoption_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_SocialActivities));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_SocialActivities")]
    public ait_icwanotice ait_icwanotice_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_SocialActivities));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_SocialActivities")]
    public ait_incident ait_incident_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_SocialActivities));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_SocialActivities")]
    public ait_investigation ait_investigation_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_SocialActivities));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_SocialActivities")]
    public ait_outcome ait_outcome_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_SocialActivities));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_SocialActivities")]
    public ait_planactivity ait_planactivity_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_SocialActivities));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_SocialActivities")]
    public ait_program ait_program_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_SocialActivities));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_SocialActivities")]
    public ait_referral ait_referral_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_SocialActivities));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_SocialActivities")]
    public ait_servicerequest ait_servicerequest_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_SocialActivities));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("AsyncOperation_SocialActivities")]
    public AsyncOperation AsyncOperation_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>(nameof (AsyncOperation_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperation_SocialActivities));
        this.SetRelatedEntity<AsyncOperation>(nameof (AsyncOperation_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AsyncOperation_SocialActivities));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_socialactivity")]
    public BusinessUnit business_unit_socialactivity
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_socialactivity), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_SocialActivities")]
    public Contact Contact_SocialActivities
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_SocialActivities), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_SocialActivities));
        this.SetRelatedEntity<Contact>(nameof (Contact_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_SocialActivities")]
    public KnowledgeArticle KnowledgeArticle_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_SocialActivities));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_SocialActivities));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_SocialActivities")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_SocialActivities));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_SocialActivities));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_socialactivity_createdby")]
    public SystemUser lk_socialactivity_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_socialactivity_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_socialactivity_modifiedby")]
    public SystemUser lk_socialactivity_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_socialactivity_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_socialactivitybase_createdonbehalfby")]
    public SystemUser lk_socialactivitybase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_socialactivitybase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_socialactivitybase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_socialactivitybase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_socialactivitybase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_socialactivitybase_modifiedonbehalfby")]
    public SystemUser lk_socialactivitybase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_socialactivitybase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_socialactivitybase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_socialactivitybase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_socialactivitybase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("manualsla_socialactivity")]
    public SLA manualsla_socialactivity
    {
      get => this.GetRelatedEntity<SLA>(nameof (manualsla_socialactivity), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_socialactivity));
        this.SetRelatedEntity<SLA>(nameof (manualsla_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_socialactivity));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    [RelationshipSchemaName("sla_socialactivity")]
    public SLA sla_socialactivity
    {
      get => this.GetRelatedEntity<SLA>(nameof (sla_socialactivity), new EntityRole?());
    }

    [AttributeLogicalName("postauthor")]
    [RelationshipSchemaName("SocialActivity_PostAuthor_accounts")]
    public Account SocialActivity_PostAuthor_accounts
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (SocialActivity_PostAuthor_accounts), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_PostAuthor_accounts));
        this.SetRelatedEntity<Account>(nameof (SocialActivity_PostAuthor_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_PostAuthor_accounts));
      }
    }

    [AttributeLogicalName("postauthor")]
    [RelationshipSchemaName("socialactivity_postauthor_contacts")]
    public Contact socialactivity_postauthor_contacts
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (socialactivity_postauthor_contacts), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_postauthor_contacts));
        this.SetRelatedEntity<Contact>(nameof (socialactivity_postauthor_contacts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_postauthor_contacts));
      }
    }

    [AttributeLogicalName("postauthoraccount")]
    [RelationshipSchemaName("SocialActivity_PostAuthorAccount_accounts")]
    public Account SocialActivity_PostAuthorAccount_accounts
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (SocialActivity_PostAuthorAccount_accounts), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_PostAuthorAccount_accounts));
        this.SetRelatedEntity<Account>(nameof (SocialActivity_PostAuthorAccount_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_PostAuthorAccount_accounts));
      }
    }

    [AttributeLogicalName("postauthoraccount")]
    [RelationshipSchemaName("socialactivity_postauthoraccount_contacts")]
    public Contact socialactivity_postauthoraccount_contacts
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (socialactivity_postauthoraccount_contacts), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_postauthoraccount_contacts));
        this.SetRelatedEntity<Contact>(nameof (socialactivity_postauthoraccount_contacts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_postauthoraccount_contacts));
      }
    }

    [AttributeLogicalName("postfromprofileid")]
    [RelationshipSchemaName("Socialprofile_SocialActivities")]
    public SocialProfile Socialprofile_SocialActivities
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (Socialprofile_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Socialprofile_SocialActivities));
        this.SetRelatedEntity<SocialProfile>(nameof (Socialprofile_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Socialprofile_SocialActivities));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_socialactivity")]
    public Team team_socialactivity
    {
      get => this.GetRelatedEntity<Team>(nameof (team_socialactivity), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_socialactivity")]
    public TransactionCurrency transactioncurrency_socialactivity
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_socialactivity));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_socialactivity));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_socialactivity")]
    public SystemUser user_socialactivity
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_socialactivity), new EntityRole?());
    }

    public SocialActivity(object anonymousType)
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
