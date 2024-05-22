// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ait_hearing
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;

#nullable disable
namespace TPCourt.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_hearing")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class ait_hearing : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_hearing";
    public const int EntityTypeCode = 10151;

    public ait_hearing()
      : base(nameof (ait_hearing))
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

    [AttributeLogicalName("ait_courtcaseid")]
    public EntityReference ait_CourtCaseId
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtcaseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCaseId));
        this.SetAttributeValue("ait_courtcaseid", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCaseId));
      }
    }

    [AttributeLogicalName("bcc")]
    public IEnumerable<Entity> BCC
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("bcc");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (BCC));
        if (value == null)
          this.SetAttributeValue("bcc", (object) value);
        else
          this.SetAttributeValue("bcc", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (BCC));
      }
    }

    [AttributeLogicalName("cc")]
    public IEnumerable<Entity> CC
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("cc");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (CC));
        if (value == null)
          this.SetAttributeValue("cc", (object) value);
        else
          this.SetAttributeValue("cc", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (CC));
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
    }

    [AttributeLogicalName("customers")]
    public IEnumerable<Entity> Customers
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("customers");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Customers));
        if (value == null)
          this.SetAttributeValue("customers", (object) value);
        else
          this.SetAttributeValue("customers", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (Customers));
      }
    }

    [AttributeLogicalName("deliverylastattemptedon")]
    public DateTime? DeliveryLastAttemptedOn
    {
      get => this.GetAttributeValue<DateTime?>("deliverylastattemptedon");
    }

    [AttributeLogicalName("deliveryprioritycode")]
    public OptionSetValue DeliveryPriorityCode
    {
      get => this.GetAttributeValue<OptionSetValue>("deliveryprioritycode");
      set
      {
        this.OnPropertyChanging(nameof (DeliveryPriorityCode));
        this.SetAttributeValue("deliveryprioritycode", (object) value);
        this.OnPropertyChanged(nameof (DeliveryPriorityCode));
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

    [AttributeLogicalName("exchangeitemid")]
    public string ExchangeItemId
    {
      get => this.GetAttributeValue<string>("exchangeitemid");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeItemId));
        this.SetAttributeValue("exchangeitemid", (object) value);
        this.OnPropertyChanged(nameof (ExchangeItemId));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("exchangeweblink")]
    public string ExchangeWebLink
    {
      get => this.GetAttributeValue<string>("exchangeweblink");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeWebLink));
        this.SetAttributeValue("exchangeweblink", (object) value);
        this.OnPropertyChanged(nameof (ExchangeWebLink));
      }
    }

    [AttributeLogicalName("from")]
    public IEnumerable<Entity> From
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("from");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging("@From");
        if (value == null)
          this.SetAttributeValue("from", (object) value);
        else
          this.SetAttributeValue("from", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged("@From");
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

    [AttributeLogicalName("instancetypecode")]
    public OptionSetValue InstanceTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("instancetypecode");
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

    [AttributeLogicalName("ismapiprivate")]
    public bool? IsMapiPrivate
    {
      get => this.GetAttributeValue<bool?>("ismapiprivate");
      set
      {
        this.OnPropertyChanging(nameof (IsMapiPrivate));
        this.SetAttributeValue("ismapiprivate", (object) value);
        this.OnPropertyChanged(nameof (IsMapiPrivate));
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
    }

    [AttributeLogicalName("onholdtime")]
    public int? OnHoldTime => this.GetAttributeValue<int?>("onholdtime");

    [AttributeLogicalName("optionalattendees")]
    public IEnumerable<Entity> OptionalAttendees
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("optionalattendees");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (OptionalAttendees));
        if (value == null)
          this.SetAttributeValue("optionalattendees", (object) value);
        else
          this.SetAttributeValue("optionalattendees", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (OptionalAttendees));
      }
    }

    [AttributeLogicalName("organizer")]
    public IEnumerable<Entity> Organizer
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("organizer");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Organizer));
        if (value == null)
          this.SetAttributeValue("organizer", (object) value);
        else
          this.SetAttributeValue("organizer", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (Organizer));
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

    [AttributeLogicalName("partners")]
    public IEnumerable<Entity> Partners
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("partners");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Partners));
        if (value == null)
          this.SetAttributeValue("partners", (object) value);
        else
          this.SetAttributeValue("partners", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (Partners));
      }
    }

    [AttributeLogicalName("postponeactivityprocessinguntil")]
    public DateTime? PostponeActivityProcessingUntil
    {
      get => this.GetAttributeValue<DateTime?>("postponeactivityprocessinguntil");
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

    [AttributeLogicalName("requiredattendees")]
    public IEnumerable<Entity> RequiredAttendees
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("requiredattendees");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (RequiredAttendees));
        if (value == null)
          this.SetAttributeValue("requiredattendees", (object) value);
        else
          this.SetAttributeValue("requiredattendees", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (RequiredAttendees));
      }
    }

    [AttributeLogicalName("resources")]
    public IEnumerable<Entity> Resources
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("resources");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Resources));
        if (value == null)
          this.SetAttributeValue("resources", (object) value);
        else
          this.SetAttributeValue("resources", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
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

    [AttributeLogicalName("sendermailboxid")]
    public EntityReference SenderMailboxId
    {
      get => this.GetAttributeValue<EntityReference>("sendermailboxid");
    }

    [AttributeLogicalName("senton")]
    public DateTime? SentOn => this.GetAttributeValue<DateTime?>("senton");

    [AttributeLogicalName("seriesid")]
    public Guid? SeriesId => this.GetAttributeValue<Guid?>("seriesid");

    [AttributeLogicalName("serviceid")]
    public EntityReference ServiceId
    {
      get => this.GetAttributeValue<EntityReference>("serviceid");
      set
      {
        this.OnPropertyChanging(nameof (ServiceId));
        this.SetAttributeValue("serviceid", (object) value);
        this.OnPropertyChanged(nameof (ServiceId));
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
    public Ait_hearingState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new Ait_hearingState?((Ait_hearingState) Enum.ToObject(typeof (Ait_hearingState), attributeValue.Value)) : new Ait_hearingState?();
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
    public IEnumerable<Entity> To
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("to");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (To));
        if (value == null)
          this.SetAttributeValue("to", (object) value);
        else
          this.SetAttributeValue("to", (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
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

    [RelationshipSchemaName("ait_hearing_connections1")]
    public IEnumerable<connection> ait_hearing_connections1
    {
      get
      {
        return this.GetRelatedEntities<connection>(nameof (ait_hearing_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_hearing_connections1));
        this.SetRelatedEntities<connection>(nameof (ait_hearing_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_hearing_connections1));
      }
    }

    [RelationshipSchemaName("ait_hearing_connections2")]
    public IEnumerable<connection> ait_hearing_connections2
    {
      get
      {
        return this.GetRelatedEntities<connection>(nameof (ait_hearing_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_hearing_connections2));
        this.SetRelatedEntities<connection>(nameof (ait_hearing_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_hearing_connections2));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("account_ait_hearings")]
    public account account_ait_hearings
    {
      get => this.GetRelatedEntity<account>(nameof (account_ait_hearings), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (account_ait_hearings));
        this.SetRelatedEntity<account>(nameof (account_ait_hearings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_ait_hearings));
      }
    }

    [AttributeLogicalName("ait_courtcaseid")]
    [RelationshipSchemaName("ait_ait_courtcase_ait_hearing")]
    public ait_courtcase ait_ait_courtcase_ait_hearing
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_ait_courtcase_ait_hearing), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtcase_ait_hearing));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_ait_courtcase_ait_hearing), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtcase_ait_hearing));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_ait_hearings")]
    public ait_courtcase ait_courtcase_ait_hearings
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_ait_hearings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_ait_hearings));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_ait_hearings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_ait_hearings));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("ait_hearing_businessunit_owningbusinessunit")]
    public businessunit ait_hearing_businessunit_owningbusinessunit
    {
      get
      {
        return this.GetRelatedEntity<businessunit>(nameof (ait_hearing_businessunit_owningbusinessunit), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("contact_ait_hearings")]
    public contact contact_ait_hearings
    {
      get => this.GetRelatedEntity<contact>(nameof (contact_ait_hearings), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (contact_ait_hearings));
        this.SetRelatedEntity<contact>(nameof (contact_ait_hearings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_ait_hearings));
      }
    }
  }
}
