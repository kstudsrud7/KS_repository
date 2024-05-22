// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_courtcase
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_courtcase")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_courtcase : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_courtcase";
    public const string EntitySchemaName = "ait_courtcase";
    public const string PrimaryIdAttribute = "ait_courtcaseid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_courtcase()
      : base(nameof (ait_courtcase))
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

    [AttributeLogicalName("ait_caseid")]
    public string ait_CaseID
    {
      get => this.GetAttributeValue<string>("ait_caseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseID));
        this.SetAttributeValue("ait_caseid", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseID));
      }
    }

    [AttributeLogicalName("ait_casetype")]
    public OptionSetValue ait_CaseType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_casetype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CaseType));
        this.SetAttributeValue("ait_casetype", (object) value);
        this.OnPropertyChanged(nameof (ait_CaseType));
      }
    }

    [AttributeLogicalName("ait_closedate")]
    public DateTime? ait_CloseDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_closedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_CloseDate));
        this.SetAttributeValue("ait_closedate", (object) value);
        this.OnPropertyChanged(nameof (ait_CloseDate));
      }
    }

    [AttributeLogicalName("ait_courtcaseid")]
    public Guid? ait_courtcaseId
    {
      get => this.GetAttributeValue<Guid?>("ait_courtcaseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcaseId));
        this.SetAttributeValue("ait_courtcaseid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_courtcaseId));
      }
    }

    [AttributeLogicalName("ait_courtcaseid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_courtcaseId = new Guid?(value);
    }

    [AttributeLogicalName("ait_courtclerk")]
    public EntityReference ait_CourtClerk
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtclerk");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtClerk));
        this.SetAttributeValue("ait_courtclerk", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtClerk));
      }
    }

    [AttributeLogicalName("ait_initiationdate")]
    public DateTime? ait_InitiationDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_initiationdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_InitiationDate));
        this.SetAttributeValue("ait_initiationdate", (object) value);
        this.OnPropertyChanged(nameof (ait_InitiationDate));
      }
    }

    [AttributeLogicalName("ait_judge_user")]
    public EntityReference ait_Judge_user
    {
      get => this.GetAttributeValue<EntityReference>("ait_judge_user");
      set
      {
        this.OnPropertyChanging(nameof (ait_Judge_user));
        this.SetAttributeValue("ait_judge_user", (object) value);
        this.OnPropertyChanged(nameof (ait_Judge_user));
      }
    }

    [AttributeLogicalName("ait_jurytrial")]
    public bool? ait_JuryTrial
    {
      get => this.GetAttributeValue<bool?>("ait_jurytrial");
      set
      {
        this.OnPropertyChanging(nameof (ait_JuryTrial));
        this.SetAttributeValue("ait_jurytrial", (object) value);
        this.OnPropertyChanged(nameof (ait_JuryTrial));
      }
    }

    [AttributeLogicalName("ait_juvenile")]
    public bool? ait_Juvenile
    {
      get => this.GetAttributeValue<bool?>("ait_juvenile");
      set
      {
        this.OnPropertyChanging(nameof (ait_Juvenile));
        this.SetAttributeValue("ait_juvenile", (object) value);
        this.OnPropertyChanged(nameof (ait_Juvenile));
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

    [AttributeLogicalName("ait_sealed")]
    public bool? ait_Sealed
    {
      get => this.GetAttributeValue<bool?>("ait_sealed");
      set
      {
        this.OnPropertyChanging(nameof (ait_Sealed));
        this.SetAttributeValue("ait_sealed", (object) value);
        this.OnPropertyChanged(nameof (ait_Sealed));
      }
    }

    [AttributeLogicalName("ait_tempcaseid")]
    public string ait_TempCaseID
    {
      get => this.GetAttributeValue<string>("ait_tempcaseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_TempCaseID));
        this.SetAttributeValue("ait_tempcaseid", (object) value);
        this.OnPropertyChanged(nameof (ait_TempCaseID));
      }
    }

    [AttributeLogicalName("ait_tempdate")]
    public DateTime? ait_tempdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_tempdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_tempdate));
        this.SetAttributeValue(nameof (ait_tempdate), (object) value);
        this.OnPropertyChanged(nameof (ait_tempdate));
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
    public ait_courtcaseState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_courtcaseState?((ait_courtcaseState) Enum.ToObject(typeof (ait_courtcaseState), attributeValue.Value)) : new ait_courtcaseState?();
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

    [RelationshipSchemaName("ait_ait_courtcase_ait_casenote_CourtCase")]
    public IEnumerable<ait_casenote> ait_ait_courtcase_ait_casenote_CourtCase
    {
      get
      {
        return this.GetRelatedEntities<ait_casenote>(nameof (ait_ait_courtcase_ait_casenote_CourtCase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtcase_ait_casenote_CourtCase));
        this.SetRelatedEntities<ait_casenote>(nameof (ait_ait_courtcase_ait_casenote_CourtCase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtcase_ait_casenote_CourtCase));
      }
    }

    [RelationshipSchemaName("ait_ait_courtcase_ait_charge_CourtCase")]
    public IEnumerable<ait_charge> ait_ait_courtcase_ait_charge_CourtCase
    {
      get
      {
        return this.GetRelatedEntities<ait_charge>(nameof (ait_ait_courtcase_ait_charge_CourtCase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtcase_ait_charge_CourtCase));
        this.SetRelatedEntities<ait_charge>(nameof (ait_ait_courtcase_ait_charge_CourtCase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtcase_ait_charge_CourtCase));
      }
    }

    [RelationshipSchemaName("ait_ait_courtcase_ait_courtparty")]
    public IEnumerable<ait_courtparty> ait_ait_courtcase_ait_courtparty
    {
      get
      {
        return this.GetRelatedEntities<ait_courtparty>(nameof (ait_ait_courtcase_ait_courtparty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtcase_ait_courtparty));
        this.SetRelatedEntities<ait_courtparty>(nameof (ait_ait_courtcase_ait_courtparty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtcase_ait_courtparty));
      }
    }

    [RelationshipSchemaName("ait_courtcase_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_courtcase_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_courtcase_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_courtcase_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_courtcase_ait_courtfinesandfees_CourtCase")]
    public IEnumerable<ait_courtfinesandfees> ait_courtcase_ait_courtfinesandfees_CourtCase
    {
      get
      {
        return this.GetRelatedEntities<ait_courtfinesandfees>(nameof (ait_courtcase_ait_courtfinesandfees_CourtCase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_ait_courtfinesandfees_CourtCase));
        this.SetRelatedEntities<ait_courtfinesandfees>(nameof (ait_courtcase_ait_courtfinesandfees_CourtCase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_ait_courtfinesandfees_CourtCase));
      }
    }

    [RelationshipSchemaName("ait_courtcase_Annotations")]
    public IEnumerable<Annotation> ait_courtcase_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_courtcase_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_courtcase_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Annotations));
      }
    }

    [RelationshipSchemaName("ait_courtcase_appointment_CourtCase")]
    public IEnumerable<Appointment> ait_courtcase_appointment_CourtCase
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_courtcase_appointment_CourtCase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_appointment_CourtCase));
        this.SetRelatedEntities<Appointment>(nameof (ait_courtcase_appointment_CourtCase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_appointment_CourtCase));
      }
    }

    [RelationshipSchemaName("ait_courtcase_Appointments")]
    public IEnumerable<Appointment> ait_courtcase_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_courtcase_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_courtcase_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Appointments));
      }
    }

    [RelationshipSchemaName("ait_courtcase_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_courtcase_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_courtcase_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_courtcase_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_courtcase_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_courtcase_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtcase_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtcase_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_courtcase_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_courtcase_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtcase_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtcase_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_courtcase_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_courtcase_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtcase_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtcase_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_courtcase_Emails")]
    public IEnumerable<Email> ait_courtcase_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_courtcase_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_courtcase_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Emails));
      }
    }

    [RelationshipSchemaName("ait_courtcase_Faxes")]
    public IEnumerable<Fax> ait_courtcase_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_courtcase_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_courtcase_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Faxes));
      }
    }

    [RelationshipSchemaName("ait_courtcase_Letters")]
    public IEnumerable<Letter> ait_courtcase_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_courtcase_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_courtcase_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Letters));
      }
    }

    [RelationshipSchemaName("ait_courtcase_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_courtcase_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtcase_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtcase_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_courtcase_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_courtcase_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_courtcase_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_courtcase_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_courtcase_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_courtcase_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtcase_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtcase_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_courtcase_ProcessSession")]
    public IEnumerable<ProcessSession> ait_courtcase_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_courtcase_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_courtcase_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_courtcase_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_courtcase_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_courtcase_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_courtcase_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_courtcase_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_courtcase_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_courtcase_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_courtcase_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_courtcase_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_courtcase_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_courtcase_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_courtcase_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_courtcase_SocialActivities")]
    public IEnumerable<SocialActivity> ait_courtcase_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_courtcase_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_courtcase_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_courtcase_SyncErrors")]
    public IEnumerable<SyncError> ait_courtcase_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_courtcase_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_courtcase_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_courtcase_Tasks")]
    public IEnumerable<Task> ait_courtcase_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_courtcase_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_courtcase_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Tasks));
      }
    }

    [RelationshipSchemaName("ait_courtcase_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_courtcase_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtcase_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtcase_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_courtclerk")]
    [RelationshipSchemaName("ait_systemuser_ait_courtcase_CourtClerk")]
    public SystemUser ait_systemuser_ait_courtcase_CourtClerk
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_courtcase_CourtClerk), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_courtcase_CourtClerk));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_courtcase_CourtClerk), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_courtcase_CourtClerk));
      }
    }

    [AttributeLogicalName("ait_judge_user")]
    [RelationshipSchemaName("ait_systemuser_ait_courtcase_Judge_user")]
    public SystemUser ait_systemuser_ait_courtcase_Judge_user
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_courtcase_Judge_user), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_courtcase_Judge_user));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_courtcase_Judge_user), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_courtcase_Judge_user));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_courtcase")]
    public BusinessUnit business_unit_ait_courtcase
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_courtcase), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_courtcase_createdby")]
    public SystemUser lk_ait_courtcase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtcase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtcase_createdonbehalfby")]
    public SystemUser lk_ait_courtcase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtcase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtcase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtcase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtcase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_courtcase_modifiedby")]
    public SystemUser lk_ait_courtcase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtcase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtcase_modifiedonbehalfby")]
    public SystemUser lk_ait_courtcase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtcase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtcase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtcase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtcase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_courtcase")]
    public Team team_ait_courtcase
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_courtcase), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_courtcase")]
    public SystemUser user_ait_courtcase
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_courtcase), new EntityRole?());
    }

    public ait_courtcase(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_courtcaseid"] = (object) base.Id;
            break;
          case "ait_courtcaseid":
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
