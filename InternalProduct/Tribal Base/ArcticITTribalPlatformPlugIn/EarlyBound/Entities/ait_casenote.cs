// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_casenote
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_casenote")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_casenote : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_casenote";
    public const string EntitySchemaName = "ait_casenote";
    public const string PrimaryIdAttribute = "ait_casenoteid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_casenote()
      : base(nameof (ait_casenote))
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

    [AttributeLogicalName("ait_case")]
    public EntityReference ait_Case
    {
      get => this.GetAttributeValue<EntityReference>("ait_case");
      set
      {
        this.OnPropertyChanging(nameof (ait_Case));
        this.SetAttributeValue("ait_case", (object) value);
        this.OnPropertyChanged(nameof (ait_Case));
      }
    }

    [AttributeLogicalName("ait_casenote")]
    public string ait_CaseNote
    {
      get => this.GetAttributeValue<string>(nameof (ait_casenote));
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNote));
        this.SetAttributeValue(nameof (ait_casenote), (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNote));
      }
    }

    [AttributeLogicalName("ait_casenoteautoid")]
    public string ait_CaseNoteAutoID
    {
      get => this.GetAttributeValue<string>("ait_casenoteautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNoteAutoID));
        this.SetAttributeValue("ait_casenoteautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNoteAutoID));
      }
    }

    [AttributeLogicalName("ait_casenoteid")]
    public Guid? ait_casenoteId
    {
      get => this.GetAttributeValue<Guid?>("ait_casenoteid");
      set
      {
        this.OnPropertyChanging(nameof (ait_casenoteId));
        this.SetAttributeValue("ait_casenoteid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_casenoteId));
      }
    }

    [AttributeLogicalName("ait_casenoteid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_casenoteId = new Guid?(value);
    }

    [AttributeLogicalName("ait_casenotestatus")]
    public OptionSetValue ait_CaseNoteStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_casenotestatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseNoteStatus));
        this.SetAttributeValue("ait_casenotestatus", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseNoteStatus));
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

    [AttributeLogicalName("ait_courtcase")]
    public EntityReference ait_CourtCase
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtcase");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCase));
        this.SetAttributeValue("ait_courtcase", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCase));
      }
    }

    [AttributeLogicalName("ait_courtprofile")]
    public EntityReference ait_CourtProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtProfile));
        this.SetAttributeValue("ait_courtprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtProfile));
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

    [AttributeLogicalName("ait_duedate")]
    public DateTime? ait_DueDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_duedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DueDate));
        this.SetAttributeValue("ait_duedate", (object) value);
        this.OnPropertyChanged(nameof (ait_DueDate));
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

    [AttributeLogicalName("ait_successstory")]
    public bool? ait_SuccessStory
    {
      get => this.GetAttributeValue<bool?>("ait_successstory");
      set
      {
        this.OnPropertyChanging(nameof (ait_SuccessStory));
        this.SetAttributeValue("ait_successstory", (object) value);
        this.OnPropertyChanged(nameof (ait_SuccessStory));
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

    [AttributeLogicalName("ait_travelmileage")]
    public int? ait_TravelMileage
    {
      get => this.GetAttributeValue<int?>("ait_travelmileage");
      set
      {
        this.OnPropertyChanging(nameof (ait_TravelMileage));
        this.SetAttributeValue("ait_travelmileage", (object) value);
        this.OnPropertyChanged(nameof (ait_TravelMileage));
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
    public ait_casenoteState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_casenoteState?((ait_casenoteState) Enum.ToObject(typeof (ait_casenoteState), attributeValue.Value)) : new ait_casenoteState?();
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

    [RelationshipSchemaName("ait_ait_casenote_ait_planactivity_CaseNote")]
    public IEnumerable<ait_planactivity> ait_ait_casenote_ait_planactivity_CaseNote
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_casenote_ait_planactivity_CaseNote), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_casenote_ait_planactivity_CaseNote));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_casenote_ait_planactivity_CaseNote), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_casenote_ait_planactivity_CaseNote));
      }
    }

    [RelationshipSchemaName("ait_casenote_ActivityParties")]
    public IEnumerable<ActivityParty> ait_casenote_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_casenote_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_casenote_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_casenote_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_casenote_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_casenote_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_casenote_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_casenote_Annotations")]
    public IEnumerable<Annotation> ait_casenote_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_casenote_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_casenote_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Annotations));
      }
    }

    [RelationshipSchemaName("ait_casenote_Appointments")]
    public IEnumerable<Appointment> ait_casenote_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_casenote_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_casenote_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Appointments));
      }
    }

    [RelationshipSchemaName("ait_casenote_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_casenote_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_casenote_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_casenote_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_casenote_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_casenote_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_casenote_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_casenote_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_casenote_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_casenote_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_casenote_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_casenote_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_casenote_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_casenote_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_casenote_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_casenote_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_casenote_Emails")]
    public IEnumerable<Email> ait_casenote_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_casenote_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_casenote_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Emails));
      }
    }

    [RelationshipSchemaName("ait_casenote_Faxes")]
    public IEnumerable<Fax> ait_casenote_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_casenote_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_casenote_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Faxes));
      }
    }

    [RelationshipSchemaName("ait_casenote_Letters")]
    public IEnumerable<Letter> ait_casenote_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_casenote_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_casenote_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Letters));
      }
    }

    [RelationshipSchemaName("ait_casenote_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_casenote_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_casenote_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_casenote_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_casenote_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_casenote_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_casenote_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_casenote_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_casenote_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_casenote_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_casenote_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_casenote_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_casenote_ProcessSession")]
    public IEnumerable<ProcessSession> ait_casenote_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_casenote_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_casenote_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_casenote_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_casenote_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_casenote_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_casenote_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_casenote_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_casenote_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_casenote_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_casenote_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_casenote_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_casenote_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_casenote_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_casenote_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_casenote_SocialActivities")]
    public IEnumerable<SocialActivity> ait_casenote_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_casenote_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_casenote_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_casenote_SyncErrors")]
    public IEnumerable<SyncError> ait_casenote_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_casenote_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_casenote_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_casenote_Tasks")]
    public IEnumerable<Task> ait_casenote_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_casenote_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_casenote_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Tasks));
      }
    }

    [RelationshipSchemaName("ait_casenote_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_casenote_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_casenote_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_casenote_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_casenote_Case")]
    public ait_case ait_ait_case_ait_casenote_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_casenote_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_casenote_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_casenote_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_casenote_Case));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_casenote_Plan")]
    public ait_caseplan ait_ait_caseplan_ait_casenote_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_casenote_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_casenote_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_casenote_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_casenote_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_casenote_Individual")]
    public ait_clientprofile ait_ait_clientprofile_ait_casenote_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_casenote_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_casenote_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_casenote_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_casenote_Individual));
      }
    }

    [AttributeLogicalName("ait_courtcase")]
    [RelationshipSchemaName("ait_ait_courtcase_ait_casenote_CourtCase")]
    public ait_courtcase ait_ait_courtcase_ait_casenote_CourtCase
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_ait_courtcase_ait_casenote_CourtCase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtcase_ait_casenote_CourtCase));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_ait_courtcase_ait_casenote_CourtCase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtcase_ait_casenote_CourtCase));
      }
    }

    [AttributeLogicalName("ait_courtprofile")]
    [RelationshipSchemaName("ait_ait_courtprofile_ait_casenote_CourtProfile")]
    public ait_courtprofile ait_ait_courtprofile_ait_casenote_CourtProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_ait_courtprofile_ait_casenote_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtprofile_ait_casenote_CourtProfile));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_ait_courtprofile_ait_casenote_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtprofile_ait_casenote_CourtProfile));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_casenote_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_ait_casenote_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_casenote_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_casenote_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_casenote_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_casenote_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_ait_casenote_Outcome")]
    public ait_outcome ait_ait_outcome_ait_casenote_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_casenote_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_casenote_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_casenote_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_casenote_Outcome));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_casenote")]
    public BusinessUnit business_unit_ait_casenote
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_casenote), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_casenote_createdby")]
    public SystemUser lk_ait_casenote_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_casenote_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_casenote_createdonbehalfby")]
    public SystemUser lk_ait_casenote_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_casenote_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_casenote_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_casenote_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_casenote_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_casenote_modifiedby")]
    public SystemUser lk_ait_casenote_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_casenote_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_casenote_modifiedonbehalfby")]
    public SystemUser lk_ait_casenote_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_casenote_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_casenote_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_casenote_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_casenote_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_casenote")]
    public Team team_ait_casenote
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_casenote), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_casenote")]
    public SystemUser user_ait_casenote
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_casenote), new EntityRole?());
    }

    public ait_casenote(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_casenoteid"] = (object) base.Id;
            break;
          case "ait_casenoteid":
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
