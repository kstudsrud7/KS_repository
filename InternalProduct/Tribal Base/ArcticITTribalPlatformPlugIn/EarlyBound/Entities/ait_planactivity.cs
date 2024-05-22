// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_planactivity
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_planactivity")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_planactivity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_planactivity";
    public const string EntitySchemaName = "ait_planactivity";
    public const string PrimaryIdAttribute = "ait_planactivityid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_planactivity()
      : base(nameof (ait_planactivity))
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

    [AttributeLogicalName("ait_activityautoid")]
    public string ait_ActivityAutoID
    {
      get => this.GetAttributeValue<string>("ait_activityautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityAutoID));
        this.SetAttributeValue("ait_activityautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityAutoID));
      }
    }

    [AttributeLogicalName("ait_activitystatus")]
    public OptionSetValue ait_ActivityStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_activitystatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityStatus));
        this.SetAttributeValue("ait_activitystatus", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityStatus));
      }
    }

    [AttributeLogicalName("ait_activitytype")]
    public OptionSetValue ait_ActivityType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_activitytype");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityType));
        this.SetAttributeValue("ait_activitytype", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityType));
      }
    }

    [AttributeLogicalName("ait_appointment")]
    public EntityReference ait_Appointment
    {
      get => this.GetAttributeValue<EntityReference>("ait_appointment");
      set
      {
        this.OnPropertyChanging(nameof (ait_Appointment));
        this.SetAttributeValue("ait_appointment", (object) value);
        this.OnPropertyChanged(nameof (ait_Appointment));
      }
    }

    [AttributeLogicalName("ait_assessment")]
    public EntityReference ait_Assessment
    {
      get => this.GetAttributeValue<EntityReference>("ait_assessment");
      set
      {
        this.OnPropertyChanging(nameof (ait_Assessment));
        this.SetAttributeValue("ait_assessment", (object) value);
        this.OnPropertyChanged(nameof (ait_Assessment));
      }
    }

    [AttributeLogicalName("ait_casenote")]
    public EntityReference ait_CaseNote
    {
      get => this.GetAttributeValue<EntityReference>("ait_casenote");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNote));
        this.SetAttributeValue("ait_casenote", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNote));
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

    [AttributeLogicalName("ait_completeddate")]
    public DateTime? ait_CompletedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_completeddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_CompletedDate));
        this.SetAttributeValue("ait_completeddate", (object) value);
        this.OnPropertyChanged(nameof (ait_CompletedDate));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_Description
    {
      get => this.GetAttributeValue<string>("ait_description");
      set
      {
        this.OnPropertyChanging(nameof (ait_Description));
        this.SetAttributeValue("ait_description", (object) value);
        this.OnPropertyChanged(nameof (ait_Description));
      }
    }

    [AttributeLogicalName("ait_email")]
    public EntityReference ait_Email
    {
      get => this.GetAttributeValue<EntityReference>("ait_email");
      set
      {
        this.OnPropertyChanging(nameof (ait_Email));
        this.SetAttributeValue("ait_email", (object) value);
        this.OnPropertyChanged(nameof (ait_Email));
      }
    }

    [AttributeLogicalName("ait_enddate")]
    public DateTime? ait_EndDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_enddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_EndDate));
        this.SetAttributeValue("ait_enddate", (object) value);
        this.OnPropertyChanged(nameof (ait_EndDate));
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

    [AttributeLogicalName("ait_goal")]
    public EntityReference ait_Goal
    {
      get => this.GetAttributeValue<EntityReference>("ait_goal");
      set
      {
        this.OnPropertyChanging(nameof (ait_Goal));
        this.SetAttributeValue("ait_goal", (object) value);
        this.OnPropertyChanged(nameof (ait_Goal));
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

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
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

    [AttributeLogicalName("ait_phonecall")]
    public EntityReference ait_PhoneCall
    {
      get => this.GetAttributeValue<EntityReference>("ait_phonecall");
      set
      {
        this.OnPropertyChanging(nameof (ait_PhoneCall));
        this.SetAttributeValue("ait_phonecall", (object) value);
        this.OnPropertyChanged(nameof (ait_PhoneCall));
      }
    }

    [AttributeLogicalName("ait_planactivityid")]
    public Guid? ait_planactivityId
    {
      get => this.GetAttributeValue<Guid?>("ait_planactivityid");
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivityId));
        this.SetAttributeValue("ait_planactivityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_planactivityId));
      }
    }

    [AttributeLogicalName("ait_planactivityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_planactivityId = new Guid?(value);
    }

    [AttributeLogicalName("ait_referral")]
    public EntityReference ait_Referral
    {
      get => this.GetAttributeValue<EntityReference>("ait_referral");
      set
      {
        this.OnPropertyChanging(nameof (ait_Referral));
        this.SetAttributeValue("ait_referral", (object) value);
        this.OnPropertyChanged(nameof (ait_Referral));
      }
    }

    [AttributeLogicalName("ait_safetyplan")]
    public EntityReference ait_SafetyPlan
    {
      get => this.GetAttributeValue<EntityReference>("ait_safetyplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_SafetyPlan));
        this.SetAttributeValue("ait_safetyplan", (object) value);
        this.OnPropertyChanged(nameof (ait_SafetyPlan));
      }
    }

    [AttributeLogicalName("ait_startdate")]
    public DateTime? ait_StartDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_startdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_StartDate));
        this.SetAttributeValue("ait_startdate", (object) value);
        this.OnPropertyChanged(nameof (ait_StartDate));
      }
    }

    [AttributeLogicalName("ait_statuslabel")]
    public string ait_StatusLabel
    {
      get => this.GetAttributeValue<string>("ait_statuslabel");
      set
      {
        this.OnPropertyChanging(nameof (ait_StatusLabel));
        this.SetAttributeValue("ait_statuslabel", (object) value);
        this.OnPropertyChanged(nameof (ait_StatusLabel));
      }
    }

    [AttributeLogicalName("ait_task")]
    public EntityReference ait_Task
    {
      get => this.GetAttributeValue<EntityReference>("ait_task");
      set
      {
        this.OnPropertyChanging(nameof (ait_Task));
        this.SetAttributeValue("ait_task", (object) value);
        this.OnPropertyChanged(nameof (ait_Task));
      }
    }

    [AttributeLogicalName("ait_timetaken")]
    public int? ait_TimeTaken
    {
      get => this.GetAttributeValue<int?>("ait_timetaken");
      set
      {
        this.OnPropertyChanging(nameof (ait_TimeTaken));
        this.SetAttributeValue("ait_timetaken", (object) value);
        this.OnPropertyChanged(nameof (ait_TimeTaken));
      }
    }

    [AttributeLogicalName("ait_traveltime")]
    public int? ait_TravelTime
    {
      get => this.GetAttributeValue<int?>("ait_traveltime");
      set
      {
        this.OnPropertyChanging(nameof (ait_TravelTime));
        this.SetAttributeValue("ait_traveltime", (object) value);
        this.OnPropertyChanged(nameof (ait_TravelTime));
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

    [AttributeLogicalName("emailaddress")]
    public string EmailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EmailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EmailAddress));
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

    [AttributeLogicalName("statecode")]
    public ait_planactivityState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_planactivityState?((ait_planactivityState) Enum.ToObject(typeof (ait_planactivityState), attributeValue.Value)) : new ait_planactivityState?();
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_planactivity_ActivityParties")]
    public IEnumerable<ActivityParty> ait_planactivity_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_planactivity_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_planactivity_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_planactivity_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_planactivity_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_planactivity_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_planactivity_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_planactivity_Annotations")]
    public IEnumerable<Annotation> ait_planactivity_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_planactivity_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_planactivity_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Annotations));
      }
    }

    [RelationshipSchemaName("ait_planactivity_Appointments")]
    public IEnumerable<Appointment> ait_planactivity_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_planactivity_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_planactivity_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Appointments));
      }
    }

    [RelationshipSchemaName("ait_planactivity_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_planactivity_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_planactivity_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_planactivity_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_planactivity_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_planactivity_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_planactivity_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_planactivity_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_planactivity_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_planactivity_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_planactivity_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_planactivity_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_planactivity_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_planactivity_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_planactivity_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_planactivity_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_planactivity_Emails")]
    public IEnumerable<Email> ait_planactivity_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_planactivity_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_planactivity_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Emails));
      }
    }

    [RelationshipSchemaName("ait_planactivity_Faxes")]
    public IEnumerable<Fax> ait_planactivity_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_planactivity_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_planactivity_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Faxes));
      }
    }

    [RelationshipSchemaName("ait_planactivity_Letters")]
    public IEnumerable<Letter> ait_planactivity_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_planactivity_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_planactivity_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Letters));
      }
    }

    [RelationshipSchemaName("ait_planactivity_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_planactivity_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_planactivity_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_planactivity_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_planactivity_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_planactivity_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_planactivity_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_planactivity_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_planactivity_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_planactivity_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_planactivity_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_planactivity_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_planactivity_ProcessSession")]
    public IEnumerable<ProcessSession> ait_planactivity_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_planactivity_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_planactivity_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_planactivity_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_planactivity_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_planactivity_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_planactivity_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_planactivity_SocialActivities")]
    public IEnumerable<SocialActivity> ait_planactivity_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_planactivity_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_planactivity_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_planactivity_SyncErrors")]
    public IEnumerable<SyncError> ait_planactivity_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_planactivity_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_planactivity_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_planactivity_Tasks")]
    public IEnumerable<Task> ait_planactivity_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_planactivity_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_planactivity_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Tasks));
      }
    }

    [RelationshipSchemaName("ait_planactivity_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_planactivity_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_planactivity_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_planactivity_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_assessment")]
    [RelationshipSchemaName("ait_ait_assessment_ait_planactivity_Assessment")]
    public ait_assessment ait_ait_assessment_ait_planactivity_Assessment
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_ait_assessment_ait_planactivity_Assessment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_assessment_ait_planactivity_Assessment));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_ait_assessment_ait_planactivity_Assessment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_assessment_ait_planactivity_Assessment));
      }
    }

    [AttributeLogicalName("ait_casenote")]
    [RelationshipSchemaName("ait_ait_casenote_ait_planactivity_CaseNote")]
    public ait_casenote ait_ait_casenote_ait_planactivity_CaseNote
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_ait_casenote_ait_planactivity_CaseNote), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_casenote_ait_planactivity_CaseNote));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_ait_casenote_ait_planactivity_CaseNote), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_casenote_ait_planactivity_CaseNote));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_planactivity_Plan")]
    public ait_caseplan ait_ait_caseplan_ait_planactivity_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_planactivity_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_planactivity_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_planactivity_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_planactivity_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_planactivity_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_planactivity_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_planactivity_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_planactivity_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_planactivity_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_planactivity_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_planactivity_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_ait_planactivity_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_planactivity_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_goal")]
    [RelationshipSchemaName("ait_ait_goal_ait_planactivity_Goal")]
    public ait_goal ait_ait_goal_ait_planactivity_Goal
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_ait_goal_ait_planactivity_Goal), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_goal_ait_planactivity_Goal));
        this.SetRelatedEntity<ait_goal>(nameof (ait_ait_goal_ait_planactivity_Goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_goal_ait_planactivity_Goal));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_ait_planactivity_Outcome")]
    public ait_outcome ait_ait_outcome_ait_planactivity_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_planactivity_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_planactivity_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_planactivity_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_planactivity_Outcome));
      }
    }

    [AttributeLogicalName("ait_referral")]
    [RelationshipSchemaName("ait_ait_referral_ait_planactivity_Referral")]
    public ait_referral ait_ait_referral_ait_planactivity_Referral
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_ait_referral_ait_planactivity_Referral), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_referral_ait_planactivity_Referral));
        this.SetRelatedEntity<ait_referral>(nameof (ait_ait_referral_ait_planactivity_Referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_referral_ait_planactivity_Referral));
      }
    }

    [AttributeLogicalName("ait_safetyplan")]
    [RelationshipSchemaName("ait_ait_safetyplan_ait_planactivity_SafetyPlan")]
    public ait_safetyplan ait_ait_safetyplan_ait_planactivity_SafetyPlan
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_ait_safetyplan_ait_planactivity_SafetyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_safetyplan_ait_planactivity_SafetyPlan));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_ait_safetyplan_ait_planactivity_SafetyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_safetyplan_ait_planactivity_SafetyPlan));
      }
    }

    [AttributeLogicalName("ait_appointment")]
    [RelationshipSchemaName("ait_appointment_ait_planactivity_Appointment")]
    public Appointment ait_appointment_ait_planactivity_Appointment
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (ait_appointment_ait_planactivity_Appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_appointment_ait_planactivity_Appointment));
        this.SetRelatedEntity<Appointment>(nameof (ait_appointment_ait_planactivity_Appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_appointment_ait_planactivity_Appointment));
      }
    }

    [AttributeLogicalName("ait_email")]
    [RelationshipSchemaName("ait_email_ait_planactivity_Email")]
    public Email ait_email_ait_planactivity_Email
    {
      get
      {
        return this.GetRelatedEntity<Email>(nameof (ait_email_ait_planactivity_Email), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_email_ait_planactivity_Email));
        this.SetRelatedEntity<Email>(nameof (ait_email_ait_planactivity_Email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_email_ait_planactivity_Email));
      }
    }

    [AttributeLogicalName("ait_phonecall")]
    [RelationshipSchemaName("ait_phonecall_ait_planactivity_PhoneCall")]
    public PhoneCall ait_phonecall_ait_planactivity_PhoneCall
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (ait_phonecall_ait_planactivity_PhoneCall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_phonecall_ait_planactivity_PhoneCall));
        this.SetRelatedEntity<PhoneCall>(nameof (ait_phonecall_ait_planactivity_PhoneCall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_phonecall_ait_planactivity_PhoneCall));
      }
    }

    [AttributeLogicalName("ait_task")]
    [RelationshipSchemaName("ait_task_ait_planactivity_Task")]
    public Task ait_task_ait_planactivity_Task
    {
      get
      {
        return this.GetRelatedEntity<Task>(nameof (ait_task_ait_planactivity_Task), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_task_ait_planactivity_Task));
        this.SetRelatedEntity<Task>(nameof (ait_task_ait_planactivity_Task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_task_ait_planactivity_Task));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_planactivity")]
    public BusinessUnit business_unit_ait_planactivity
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_planactivity), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_planactivity_createdby")]
    public SystemUser lk_ait_planactivity_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_planactivity_createdonbehalfby")]
    public SystemUser lk_ait_planactivity_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_planactivity_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_planactivity_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_planactivity_modifiedby")]
    public SystemUser lk_ait_planactivity_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_planactivity_modifiedonbehalfby")]
    public SystemUser lk_ait_planactivity_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_planactivity_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_planactivity_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_planactivity_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_planactivity")]
    public Team team_ait_planactivity
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_planactivity), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_planactivity")]
    public SystemUser user_ait_planactivity
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_planactivity), new EntityRole?());
    }

    public ait_planactivity(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_planactivityid"] = (object) base.Id;
            break;
          case "ait_planactivityid":
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
