// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_investigation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_investigation")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_investigation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_investigation";
    public const string EntitySchemaName = "ait_investigation";
    public const string PrimaryIdAttribute = "ait_investigationid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_investigation()
      : base(nameof (ait_investigation))
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

    [AttributeLogicalName("ait_enddate")]
    public DateTime? ait_enddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_enddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_enddate));
        this.SetAttributeValue(nameof (ait_enddate), (object) value);
        this.OnPropertyChanged(nameof (ait_enddate));
      }
    }

    [AttributeLogicalName("ait_incident")]
    public EntityReference ait_incident
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_incident));
      set
      {
        this.OnPropertyChanging(nameof (ait_incident));
        this.SetAttributeValue(nameof (ait_incident), (object) value);
        this.OnPropertyChanged(nameof (ait_incident));
      }
    }

    [AttributeLogicalName("ait_investigationid")]
    public Guid? ait_investigationId
    {
      get => this.GetAttributeValue<Guid?>("ait_investigationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_investigationId));
        this.SetAttributeValue("ait_investigationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_investigationId));
      }
    }

    [AttributeLogicalName("ait_investigationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_investigationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_investigationnotes")]
    public string ait_InvestigationNotes
    {
      get => this.GetAttributeValue<string>("ait_investigationnotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_InvestigationNotes));
        this.SetAttributeValue("ait_investigationnotes", (object) value);
        this.OnPropertyChanged(nameof (ait_InvestigationNotes));
      }
    }

    [AttributeLogicalName("ait_investigationreportid")]
    public string ait_InvestigationReportID
    {
      get => this.GetAttributeValue<string>("ait_investigationreportid");
      set
      {
        this.OnPropertyChanging(nameof (ait_InvestigationReportID));
        this.SetAttributeValue("ait_investigationreportid", (object) value);
        this.OnPropertyChanged(nameof (ait_InvestigationReportID));
      }
    }

    [AttributeLogicalName("ait_investigationstatus")]
    public OptionSetValue ait_investigationstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_investigationstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_investigationstatus));
        this.SetAttributeValue(nameof (ait_investigationstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_investigationstatus));
      }
    }

    [AttributeLogicalName("ait_investigator")]
    public EntityReference ait_investigator
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_investigator));
      set
      {
        this.OnPropertyChanging(nameof (ait_investigator));
        this.SetAttributeValue(nameof (ait_investigator), (object) value);
        this.OnPropertyChanged(nameof (ait_investigator));
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

    [AttributeLogicalName("ait_reporttype")]
    public OptionSetValue ait_reporttype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_reporttype));
      set
      {
        this.OnPropertyChanging(nameof (ait_reporttype));
        this.SetAttributeValue(nameof (ait_reporttype), (object) value);
        this.OnPropertyChanged(nameof (ait_reporttype));
      }
    }

    [AttributeLogicalName("ait_startdate")]
    public DateTime? ait_startdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_startdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_startdate));
        this.SetAttributeValue(nameof (ait_startdate), (object) value);
        this.OnPropertyChanged(nameof (ait_startdate));
      }
    }

    [AttributeLogicalName("ait_substantiated")]
    public OptionSetValue ait_Substantiated
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_substantiated");
      set
      {
        this.OnPropertyChanging(nameof (ait_Substantiated));
        this.SetAttributeValue("ait_substantiated", (object) value);
        this.OnPropertyChanged(nameof (ait_Substantiated));
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

    [AttributeLogicalName("statecode")]
    public ait_investigationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_investigationState?((ait_investigationState) Enum.ToObject(typeof (ait_investigationState), attributeValue.Value)) : new ait_investigationState?();
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

    [RelationshipSchemaName("ait_investigation_ActivityParties")]
    public IEnumerable<ActivityParty> ait_investigation_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_investigation_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_investigation_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_investigation_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_investigation_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_investigation_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_investigation_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_investigation_Annotations")]
    public IEnumerable<Annotation> ait_investigation_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_investigation_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_investigation_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Annotations));
      }
    }

    [RelationshipSchemaName("ait_investigation_Appointments")]
    public IEnumerable<Appointment> ait_investigation_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_investigation_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_investigation_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Appointments));
      }
    }

    [RelationshipSchemaName("ait_investigation_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_investigation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_investigation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_investigation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_investigation_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_investigation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_investigation_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_investigation_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_investigation_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_investigation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_investigation_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_investigation_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_investigation_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_investigation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_investigation_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_investigation_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_investigation_Emails")]
    public IEnumerable<Email> ait_investigation_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_investigation_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_investigation_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Emails));
      }
    }

    [RelationshipSchemaName("ait_investigation_Faxes")]
    public IEnumerable<Fax> ait_investigation_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_investigation_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_investigation_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Faxes));
      }
    }

    [RelationshipSchemaName("ait_investigation_Letters")]
    public IEnumerable<Letter> ait_investigation_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_investigation_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_investigation_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Letters));
      }
    }

    [RelationshipSchemaName("ait_investigation_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_investigation_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_investigation_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_investigation_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_investigation_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_investigation_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_investigation_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_investigation_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_investigation_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_investigation_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_investigation_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_investigation_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_investigation_ProcessSession")]
    public IEnumerable<ProcessSession> ait_investigation_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_investigation_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_investigation_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_investigation_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_investigation_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_investigation_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_investigation_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_investigation_SocialActivities")]
    public IEnumerable<SocialActivity> ait_investigation_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_investigation_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_investigation_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_investigation_SyncErrors")]
    public IEnumerable<SyncError> ait_investigation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_investigation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_investigation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_investigation_Tasks")]
    public IEnumerable<Task> ait_investigation_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_investigation_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_investigation_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Tasks));
      }
    }

    [RelationshipSchemaName("ait_investigation_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_investigation_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_investigation_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_investigation_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_incident")]
    [RelationshipSchemaName("ait_incident_ait_investigation_incident")]
    public ArcticIT.EarlyBound.Entities.ait_incident ait_incident_ait_investigation_incident
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_incident>(nameof (ait_incident_ait_investigation_incident), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ait_investigation_incident));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_incident>(nameof (ait_incident_ait_investigation_incident), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ait_investigation_incident));
      }
    }

    [AttributeLogicalName("ait_investigator")]
    [RelationshipSchemaName("ait_systemuser_ait_investigation_investigator")]
    public SystemUser ait_systemuser_ait_investigation_investigator
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_investigation_investigator), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_investigation_investigator));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_investigation_investigator), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_investigation_investigator));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_investigation_createdby")]
    public SystemUser lk_ait_investigation_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_investigation_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_investigation_createdonbehalfby")]
    public SystemUser lk_ait_investigation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_investigation_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_investigation_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_investigation_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_investigation_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_investigation_modifiedby")]
    public SystemUser lk_ait_investigation_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_investigation_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_investigation_modifiedonbehalfby")]
    public SystemUser lk_ait_investigation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_investigation_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_investigation_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_investigation_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_investigation_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_investigation")]
    public Organization organization_ait_investigation
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_investigation), new EntityRole?());
      }
    }

    public ait_investigation(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_investigationid"] = (object) base.Id;
            break;
          case "ait_investigationid":
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
