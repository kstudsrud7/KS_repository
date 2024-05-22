// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.PhoneCall
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("phonecall")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class PhoneCall : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "phonecall";
    public const int EntityTypeCode = 4210;

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
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("activitytypecode")]
    public string ActivityTypeCode => this.GetAttributeValue<string>("activitytypecode");

    [AttributeLogicalName("activitytypecodename")]
    public object ActivityTypeCodeName => this.GetAttributeValue<object>("activitytypecodename");

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

    [AttributeLogicalName("ait_caseplanname")]
    public string ait_CasePlanName => this.GetAttributeValue<string>("ait_caseplanname");

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

    [AttributeLogicalName("ait_familygroupname")]
    public string ait_FamilyGroupName => this.GetAttributeValue<string>("ait_familygroupname");

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

    [AttributeLogicalName("ait_individualname")]
    public string ait_IndividualName => this.GetAttributeValue<string>("ait_individualname");

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

    [AttributeLogicalName("ait_outcomename")]
    public string ait_OutcomeName => this.GetAttributeValue<string>("ait_outcomename");

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

    [AttributeLogicalName("createdbyname")]
    public string CreatedByName => this.GetAttributeValue<string>("createdbyname");

    [AttributeLogicalName("createdbyyominame")]
    public string CreatedByYomiName => this.GetAttributeValue<string>("createdbyyominame");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("createdonbehalfbyname")]
    public string CreatedOnBehalfByName => this.GetAttributeValue<string>("createdonbehalfbyname");

    [AttributeLogicalName("createdonbehalfbyyominame")]
    public string CreatedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("createdonbehalfbyyominame");
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

    [AttributeLogicalName("directioncodename")]
    public object DirectionCodeName => this.GetAttributeValue<object>("directioncodename");

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("from")]
    public IEnumerable<Entity> from
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>(nameof (from));
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging("@from");
        if (value == null)
          this.SetAttributeValue(nameof (from), (object) value);
        else
          this.SetAttributeValue(nameof (from), (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged("@from");
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

    [AttributeLogicalName("isbilledname")]
    public object IsBilledName => this.GetAttributeValue<object>("isbilledname");

    [AttributeLogicalName("isregularactivity")]
    public bool? IsRegularActivity => this.GetAttributeValue<bool?>("isregularactivity");

    [AttributeLogicalName("isregularactivityname")]
    public object IsRegularActivityName => this.GetAttributeValue<object>("isregularactivityname");

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

    [AttributeLogicalName("isworkflowcreatedname")]
    public object IsWorkflowCreatedName => this.GetAttributeValue<object>("isworkflowcreatedname");

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

    [AttributeLogicalName("leftvoicemailname")]
    public object LeftVoiceMailName => this.GetAttributeValue<object>("leftvoicemailname");

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

    [AttributeLogicalName("modifiedbyname")]
    public string ModifiedByName => this.GetAttributeValue<string>("modifiedbyname");

    [AttributeLogicalName("modifiedbyyominame")]
    public string ModifiedByYomiName => this.GetAttributeValue<string>("modifiedbyyominame");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
    }

    [AttributeLogicalName("modifiedonbehalfbyname")]
    public string ModifiedOnBehalfByName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyname");
    }

    [AttributeLogicalName("modifiedonbehalfbyyominame")]
    public string ModifiedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyyominame");
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

    [AttributeLogicalName("owneridname")]
    public string OwnerIdName => this.GetAttributeValue<string>("owneridname");

    [AttributeLogicalName("owneridtype")]
    public string OwnerIdType
    {
      get => this.GetAttributeValue<string>("owneridtype");
      set
      {
        this.OnPropertyChanging(nameof (OwnerIdType));
        this.SetAttributeValue("owneridtype", (object) value);
        this.OnPropertyChanged(nameof (OwnerIdType));
      }
    }

    [AttributeLogicalName("owneridyominame")]
    public string OwnerIdYomiName => this.GetAttributeValue<string>("owneridyominame");

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

    [AttributeLogicalName("prioritycodename")]
    public object PriorityCodeName => this.GetAttributeValue<object>("prioritycodename");

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

    [AttributeLogicalName("regardingobjectidname")]
    public string RegardingObjectIdName => this.GetAttributeValue<string>("regardingobjectidname");

    [AttributeLogicalName("regardingobjectidyominame")]
    public string RegardingObjectIdYomiName
    {
      get => this.GetAttributeValue<string>("regardingobjectidyominame");
    }

    [AttributeLogicalName("regardingobjecttypecode")]
    public string RegardingObjectTypeCode
    {
      get => this.GetAttributeValue<string>("regardingobjecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectTypeCode));
        this.SetAttributeValue("regardingobjecttypecode", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectTypeCode));
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

    [AttributeLogicalName("slainvokedidname")]
    public string SLAInvokedIdName => this.GetAttributeValue<string>("slainvokedidname");

    [AttributeLogicalName("slaname")]
    public string SLAName => this.GetAttributeValue<string>("slaname");

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
    public PhoneCallState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new PhoneCallState?((PhoneCallState) Enum.ToObject(typeof (PhoneCallState), attributeValue.Value)) : new PhoneCallState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (StateCode));
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (StateCode));
      }
    }

    [AttributeLogicalName("statecodename")]
    public object StateCodeName => this.GetAttributeValue<object>("statecodename");

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

    [AttributeLogicalName("statuscodename")]
    public object StatusCodeName => this.GetAttributeValue<object>("statuscodename");

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
    public IEnumerable<Entity> to
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>(nameof (to));
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (to));
        if (value == null)
          this.SetAttributeValue(nameof (to), (object) value);
        else
          this.SetAttributeValue(nameof (to), (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (to));
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

    [AttributeLogicalName("transactioncurrencyidname")]
    public string TransactionCurrencyIdName
    {
      get => this.GetAttributeValue<string>("transactioncurrencyidname");
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
    [RelationshipSchemaName("ait_casenotefamilywellness_PhoneCalls")]
    public ait_casenotefamilywellness ait_casenotefamilywellness_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_casenotefamilywellness>(nameof (ait_casenotefamilywellness_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_PhoneCalls));
        this.SetRelatedEntity<ait_casenotefamilywellness>(nameof (ait_casenotefamilywellness_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_PhoneCalls));
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
    [RelationshipSchemaName("ait_groupactivityregistration_PhoneCalls")]
    public ait_groupactivityregistration ait_groupactivityregistration_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivityregistration>(nameof (ait_groupactivityregistration_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_PhoneCalls));
        this.SetRelatedEntity<ait_groupactivityregistration>(nameof (ait_groupactivityregistration_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_PhoneCalls));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incidents_PhoneCalls")]
    public ait_incidents ait_incidents_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_incidents>(nameof (ait_incidents_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidents_PhoneCalls));
        this.SetRelatedEntity<ait_incidents>(nameof (ait_incidents_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidents_PhoneCalls));
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
    [RelationshipSchemaName("ait_meetingattendee_PhoneCalls")]
    public ait_meetingattendee ait_meetingattendee_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_PhoneCalls));
        this.SetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_PhoneCalls));
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

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_phonecall")]
    public Team team_phonecall
    {
      get => this.GetRelatedEntity<Team>(nameof (team_phonecall), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_phonecall")]
    public SystemUser user_phonecall
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_phonecall), new EntityRole?());
    }
  }
}
