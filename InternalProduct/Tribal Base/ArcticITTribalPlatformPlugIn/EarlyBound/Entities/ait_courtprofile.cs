// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_courtprofile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_courtprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_courtprofile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_courtprofile";
    public const string EntitySchemaName = "ait_courtprofile";
    public const string PrimaryIdAttribute = "ait_courtprofileid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_courtprofile()
      : base(nameof (ait_courtprofile))
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

    [AttributeLogicalName("ait_company")]
    public EntityReference ait_Company
    {
      get => this.GetAttributeValue<EntityReference>("ait_company");
      set
      {
        this.OnPropertyChanging(nameof (ait_Company));
        this.SetAttributeValue("ait_company", (object) value);
        this.OnPropertyChanged(nameof (ait_Company));
      }
    }

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_Contact
    {
      get => this.GetAttributeValue<EntityReference>("ait_contact");
      set
      {
        this.OnPropertyChanging(nameof (ait_Contact));
        this.SetAttributeValue("ait_contact", (object) value);
        this.OnPropertyChanged(nameof (ait_Contact));
      }
    }

    [AttributeLogicalName("ait_courtprofileid")]
    public Guid? ait_courtprofileId
    {
      get => this.GetAttributeValue<Guid?>("ait_courtprofileid");
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileId));
        this.SetAttributeValue("ait_courtprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_courtprofileId));
      }
    }

    [AttributeLogicalName("ait_courtprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_courtprofileId = new Guid?(value);
    }

    [AttributeLogicalName("ait_courtprofiletype")]
    public OptionSetValue ait_CourtProfileType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_courtprofiletype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtProfileType));
        this.SetAttributeValue("ait_courtprofiletype", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtProfileType));
      }
    }

    [AttributeLogicalName("ait_dlexpiration")]
    public DateTime? ait_DLExpiration
    {
      get => this.GetAttributeValue<DateTime?>("ait_dlexpiration");
      set
      {
        this.OnPropertyChanging(nameof (ait_DLExpiration));
        this.SetAttributeValue("ait_dlexpiration", (object) value);
        this.OnPropertyChanged(nameof (ait_DLExpiration));
      }
    }

    [AttributeLogicalName("ait_dob")]
    public DateTime? ait_DOB
    {
      get => this.GetAttributeValue<DateTime?>("ait_dob");
      set
      {
        this.OnPropertyChanging(nameof (ait_DOB));
        this.SetAttributeValue("ait_dob", (object) value);
        this.OnPropertyChanged(nameof (ait_DOB));
      }
    }

    [AttributeLogicalName("ait_dojnumber")]
    public string ait_DOJNumber
    {
      get => this.GetAttributeValue<string>("ait_dojnumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_DOJNumber));
        this.SetAttributeValue("ait_dojnumber", (object) value);
        this.OnPropertyChanged(nameof (ait_DOJNumber));
      }
    }

    [AttributeLogicalName("ait_driverslicenseno")]
    public string ait_DriversLicenseNo
    {
      get => this.GetAttributeValue<string>("ait_driverslicenseno");
      set
      {
        this.OnPropertyChanging(nameof (ait_DriversLicenseNo));
        this.SetAttributeValue("ait_driverslicenseno", (object) value);
        this.OnPropertyChanged(nameof (ait_DriversLicenseNo));
      }
    }

    [AttributeLogicalName("ait_email")]
    public string ait_Email
    {
      get => this.GetAttributeValue<string>("ait_email");
      set
      {
        this.OnPropertyChanging(nameof (ait_Email));
        this.SetAttributeValue("ait_email", (object) value);
        this.OnPropertyChanged(nameof (ait_Email));
      }
    }

    [AttributeLogicalName("ait_firstname")]
    public string ait_FirstName
    {
      get => this.GetAttributeValue<string>("ait_firstname");
      set
      {
        this.OnPropertyChanging(nameof (ait_FirstName));
        this.SetAttributeValue("ait_firstname", (object) value);
        this.OnPropertyChanged(nameof (ait_FirstName));
      }
    }

    [AttributeLogicalName("ait_issuestate")]
    public EntityReference ait_IssueState
    {
      get => this.GetAttributeValue<EntityReference>("ait_issuestate");
      set
      {
        this.OnPropertyChanging(nameof (ait_IssueState));
        this.SetAttributeValue("ait_issuestate", (object) value);
        this.OnPropertyChanged(nameof (ait_IssueState));
      }
    }

    [AttributeLogicalName("ait_lastname")]
    public string ait_LastName
    {
      get => this.GetAttributeValue<string>("ait_lastname");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastName));
        this.SetAttributeValue("ait_lastname", (object) value);
        this.OnPropertyChanged(nameof (ait_LastName));
      }
    }

    [AttributeLogicalName("ait_lastupdated")]
    public DateTime? ait_LastUpdated
    {
      get => this.GetAttributeValue<DateTime?>("ait_lastupdated");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastUpdated));
        this.SetAttributeValue("ait_lastupdated", (object) value);
        this.OnPropertyChanged(nameof (ait_LastUpdated));
      }
    }

    [AttributeLogicalName("ait_mailingaddress")]
    public EntityReference ait_MailingAddress
    {
      get => this.GetAttributeValue<EntityReference>("ait_mailingaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_MailingAddress));
        this.SetAttributeValue("ait_mailingaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_MailingAddress));
      }
    }

    [AttributeLogicalName("ait_middlename")]
    public string ait_MiddleName
    {
      get => this.GetAttributeValue<string>("ait_middlename");
      set
      {
        this.OnPropertyChanging(nameof (ait_MiddleName));
        this.SetAttributeValue("ait_middlename", (object) value);
        this.OnPropertyChanged(nameof (ait_MiddleName));
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

    [AttributeLogicalName("ait_notes")]
    public string ait_Notes
    {
      get => this.GetAttributeValue<string>("ait_notes");
      set
      {
        this.OnPropertyChanging(nameof (ait_Notes));
        this.SetAttributeValue("ait_notes", (object) value);
        this.OnPropertyChanged(nameof (ait_Notes));
      }
    }

    [AttributeLogicalName("ait_phonenumber")]
    public string ait_PhoneNumber
    {
      get => this.GetAttributeValue<string>("ait_phonenumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_PhoneNumber));
        this.SetAttributeValue("ait_phonenumber", (object) value);
        this.OnPropertyChanged(nameof (ait_PhoneNumber));
      }
    }

    [AttributeLogicalName("ait_physicaladdress")]
    public EntityReference ait_PhysicalAddress
    {
      get => this.GetAttributeValue<EntityReference>("ait_physicaladdress");
      set
      {
        this.OnPropertyChanging(nameof (ait_PhysicalAddress));
        this.SetAttributeValue("ait_physicaladdress", (object) value);
        this.OnPropertyChanged(nameof (ait_PhysicalAddress));
      }
    }

    [AttributeLogicalName("ait_updatedaddress")]
    public string ait_UpdatedAddress
    {
      get => this.GetAttributeValue<string>("ait_updatedaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_UpdatedAddress));
        this.SetAttributeValue("ait_updatedaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_UpdatedAddress));
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
    public ait_courtprofileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_courtprofileState?((ait_courtprofileState) Enum.ToObject(typeof (ait_courtprofileState), attributeValue.Value)) : new ait_courtprofileState?();
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

    [RelationshipSchemaName("ait_ait_courtprofile_ait_casenote_CourtProfile")]
    public IEnumerable<ait_casenote> ait_ait_courtprofile_ait_casenote_CourtProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_casenote>(nameof (ait_ait_courtprofile_ait_casenote_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtprofile_ait_casenote_CourtProfile));
        this.SetRelatedEntities<ait_casenote>(nameof (ait_ait_courtprofile_ait_casenote_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtprofile_ait_casenote_CourtProfile));
      }
    }

    [RelationshipSchemaName("ait_ait_courtprofile_ait_charge_CourtProfile")]
    public IEnumerable<ait_charge> ait_ait_courtprofile_ait_charge_CourtProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_charge>(nameof (ait_ait_courtprofile_ait_charge_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtprofile_ait_charge_CourtProfile));
        this.SetRelatedEntities<ait_charge>(nameof (ait_ait_courtprofile_ait_charge_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtprofile_ait_charge_CourtProfile));
      }
    }

    [RelationshipSchemaName("ait_ait_courtprofile_ait_courtparty_CourtProfile")]
    public IEnumerable<ait_courtparty> ait_ait_courtprofile_ait_courtparty_CourtProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_courtparty>(nameof (ait_ait_courtprofile_ait_courtparty_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtprofile_ait_courtparty_CourtProfile));
        this.SetRelatedEntities<ait_courtparty>(nameof (ait_ait_courtprofile_ait_courtparty_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtprofile_ait_courtparty_CourtProfile));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_ait_courtprofileaddress_CourtProfile")]
    public IEnumerable<ait_courtprofileaddress> ait_courtprofile_ait_courtprofileaddress_CourtProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (ait_courtprofile_ait_courtprofileaddress_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_ait_courtprofileaddress_CourtProfile));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (ait_courtprofile_ait_courtprofileaddress_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_ait_courtprofileaddress_CourtProfile));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_Annotations")]
    public IEnumerable<Annotation> ait_courtprofile_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_courtprofile_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_courtprofile_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_Annotations));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_courtprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_courtprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_courtprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_courtprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtprofile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtprofile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_contact_CourtProfile")]
    public IEnumerable<Contact> ait_courtprofile_contact_CourtProfile
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_courtprofile_contact_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_contact_CourtProfile));
        this.SetRelatedEntities<Contact>(nameof (ait_courtprofile_contact_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_contact_CourtProfile));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_courtprofile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtprofile_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtprofile_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_courtprofile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtprofile_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtprofile_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_courtprofile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtprofile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtprofile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_courtprofile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtprofile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtprofile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_ProcessSession")]
    public IEnumerable<ProcessSession> ait_courtprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_courtprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_courtprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_courtprofile_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_courtprofile_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_courtprofile_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_courtprofile_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_courtprofile_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_courtprofile_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_SyncErrors")]
    public IEnumerable<SyncError> ait_courtprofile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_courtprofile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_courtprofile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_courtprofile_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_courtprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_courtfinesandfees_ait_courtprofile")]
    public IEnumerable<ait_courtfinesandfees> ait_courtfinesandfees_ait_courtprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_ait_courtprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_ait_courtprofile));
        this.SetRelatedEntities<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_ait_courtprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_ait_courtprofile));
      }
    }

    [AttributeLogicalName("ait_company")]
    [RelationshipSchemaName("ait_ait_company_ait_courtprofile_Company")]
    public ait_company ait_ait_company_ait_courtprofile_Company
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_ait_company_ait_courtprofile_Company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_company_ait_courtprofile_Company));
        this.SetRelatedEntity<ait_company>(nameof (ait_ait_company_ait_courtprofile_Company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_company_ait_courtprofile_Company));
      }
    }

    [AttributeLogicalName("ait_physicaladdress")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress")]
    public ait_physicaladdress ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_courtprofile_PhysicalAddress));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_contact_ait_courtprofile_Contact")]
    public Contact ait_contact_ait_courtprofile_Contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_courtprofile_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_courtprofile_Contact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_courtprofile_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_courtprofile_Contact));
      }
    }

    [AttributeLogicalName("ait_mailingaddress")]
    [RelationshipSchemaName("ait_physicaladdress_ait_courtprofile_MailingAddress")]
    public ait_physicaladdress ait_physicaladdress_ait_courtprofile_MailingAddress
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_ait_courtprofile_MailingAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_ait_courtprofile_MailingAddress));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_ait_courtprofile_MailingAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_ait_courtprofile_MailingAddress));
      }
    }

    [AttributeLogicalName("ait_issuestate")]
    [RelationshipSchemaName("ait_stateprovince_ait_courtprofile_IssueState")]
    public ait_stateprovince ait_stateprovince_ait_courtprofile_IssueState
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_ait_courtprofile_IssueState), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_ait_courtprofile_IssueState));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_ait_courtprofile_IssueState), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_ait_courtprofile_IssueState));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_courtprofile")]
    public BusinessUnit business_unit_ait_courtprofile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_courtprofile), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_courtprofile_createdby")]
    public SystemUser lk_ait_courtprofile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtprofile_createdonbehalfby")]
    public SystemUser lk_ait_courtprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtprofile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtprofile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_courtprofile_modifiedby")]
    public SystemUser lk_ait_courtprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtprofile_modifiedonbehalfby")]
    public SystemUser lk_ait_courtprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtprofile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtprofile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_courtprofile")]
    public Team team_ait_courtprofile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_courtprofile), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_courtprofile")]
    public SystemUser user_ait_courtprofile
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_courtprofile), new EntityRole?());
    }

    public ait_courtprofile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_courtprofileid"] = (object) base.Id;
            break;
          case "ait_courtprofileid":
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
