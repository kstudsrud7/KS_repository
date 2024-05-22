// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_electronicaddress
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_electronicaddress")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_electronicaddress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_electronicaddress";
    public const string EntitySchemaName = "ait_electronicaddress";
    public const string PrimaryIdAttribute = "ait_electronicaddressid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_electronicaddress()
      : base(nameof (ait_electronicaddress))
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

    [AttributeLogicalName("ait_addresstype")]
    public EntityReference ait_addresstype
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_addresstype));
      set
      {
        this.OnPropertyChanging(nameof (ait_addresstype));
        this.SetAttributeValue(nameof (ait_addresstype), (object) value);
        this.OnPropertyChanged(nameof (ait_addresstype));
      }
    }

    [AttributeLogicalName("ait_communicationtype")]
    public OptionSetValue ait_communicationtype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_communicationtype));
      set
      {
        this.OnPropertyChanging(nameof (ait_communicationtype));
        this.SetAttributeValue(nameof (ait_communicationtype), (object) value);
        this.OnPropertyChanged(nameof (ait_communicationtype));
      }
    }

    [AttributeLogicalName("ait_company")]
    public EntityReference ait_company
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_company));
      set
      {
        this.OnPropertyChanging(nameof (ait_company));
        this.SetAttributeValue(nameof (ait_company), (object) value);
        this.OnPropertyChanged(nameof (ait_company));
      }
    }

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_contact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_contact));
      set
      {
        this.OnPropertyChanging(nameof (ait_contact));
        this.SetAttributeValue(nameof (ait_contact), (object) value);
        this.OnPropertyChanged(nameof (ait_contact));
      }
    }

    [AttributeLogicalName("ait_current")]
    public bool? ait_current
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_current));
      set
      {
        this.OnPropertyChanging(nameof (ait_current));
        this.SetAttributeValue(nameof (ait_current), (object) value);
        this.OnPropertyChanged(nameof (ait_current));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
      }
    }

    [AttributeLogicalName("ait_electronicaddressid")]
    public Guid? ait_electronicaddressId
    {
      get => this.GetAttributeValue<Guid?>("ait_electronicaddressid");
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddressId));
        this.SetAttributeValue("ait_electronicaddressid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_electronicaddressId));
      }
    }

    [AttributeLogicalName("ait_electronicaddressid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_electronicaddressId = new Guid?(value);
    }

    [AttributeLogicalName("ait_isconfidential")]
    public bool? ait_IsConfidential
    {
      get => this.GetAttributeValue<bool?>("ait_isconfidential");
      set
      {
        this.OnPropertyChanging(nameof (ait_IsConfidential));
        this.SetAttributeValue("ait_isconfidential", (object) value);
        this.OnPropertyChanged(nameof (ait_IsConfidential));
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

    [AttributeLogicalName("ait_phonenumberoremail")]
    public string ait_phonenumberoremail
    {
      get => this.GetAttributeValue<string>(nameof (ait_phonenumberoremail));
      set
      {
        this.OnPropertyChanging(nameof (ait_phonenumberoremail));
        this.SetAttributeValue(nameof (ait_phonenumberoremail), (object) value);
        this.OnPropertyChanged(nameof (ait_phonenumberoremail));
      }
    }

    [AttributeLogicalName("ait_school")]
    public EntityReference ait_school
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_school));
      set
      {
        this.OnPropertyChanging(nameof (ait_school));
        this.SetAttributeValue(nameof (ait_school), (object) value);
        this.OnPropertyChanged(nameof (ait_school));
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
    public ait_electronicaddressState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_electronicaddressState?((ait_electronicaddressState) Enum.ToObject(typeof (ait_electronicaddressState), attributeValue.Value)) : new ait_electronicaddressState?();
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

    [RelationshipSchemaName("ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail")]
    public IEnumerable<ait_courtprofileaddress> ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail));
      }
    }

    [RelationshipSchemaName("ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1")]
    public IEnumerable<ait_courtprofileaddress> ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1));
      }
    }

    [RelationshipSchemaName("ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2")]
    public IEnumerable<ait_courtprofileaddress> ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2));
      }
    }

    [RelationshipSchemaName("ait_ait_emergencycontact_ait_electronicaddress")]
    public IEnumerable<ait_emergencycontact> ait_ait_emergencycontact_ait_electronicaddress
    {
      get
      {
        return this.GetRelatedEntities<ait_emergencycontact>(nameof (ait_ait_emergencycontact_ait_electronicaddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_emergencycontact_ait_electronicaddress));
        this.SetRelatedEntities<ait_emergencycontact>(nameof (ait_ait_emergencycontact_ait_electronicaddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_emergencycontact_ait_electronicaddress));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_Annotations")]
    public IEnumerable<Annotation> ait_electronicaddress_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_electronicaddress_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_electronicaddress_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_Annotations));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_electronicaddress_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_electronicaddress_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_electronicaddress_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_electronicaddress_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_electronicaddress_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_electronicaddress_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_electronicaddress_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_electronicaddress_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_electronicaddress_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_electronicaddress_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_electronicaddress_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_electronicaddress_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_electronicaddress_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_electronicaddress_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_electronicaddress_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_electronicaddress_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_electronicaddress_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_electronicaddress_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_ProcessSession")]
    public IEnumerable<ProcessSession> ait_electronicaddress_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_electronicaddress_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_electronicaddress_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_SyncErrors")]
    public IEnumerable<SyncError> ait_electronicaddress_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_electronicaddress_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_electronicaddress_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_electronicaddress_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_electronicaddress_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_electronicaddress_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_electronicaddress_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress")]
    public IEnumerable<ait_changerequest> ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress));
        this.SetRelatedEntities<ait_changerequest>(nameof (ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_email_electronicaddress_ait_changerequest_Email_ElectronicAddress));
      }
    }

    [RelationshipSchemaName("ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress")]
    public IEnumerable<ait_changerequest> ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress));
        this.SetRelatedEntities<ait_changerequest>(nameof (ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_phone_electronicaddress_ait_changerequest_Phone_ElectronicAddress));
      }
    }

    [AttributeLogicalName("ait_addresstype")]
    [RelationshipSchemaName("ait_ait_electronicaddress_ait_addresstype")]
    public ArcticIT.EarlyBound.Entities.ait_addresstype ait_ait_electronicaddress_ait_addresstype
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_addresstype>(nameof (ait_ait_electronicaddress_ait_addresstype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_addresstype));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_addresstype>(nameof (ait_ait_electronicaddress_ait_addresstype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_addresstype));
      }
    }

    [AttributeLogicalName("ait_company")]
    [RelationshipSchemaName("ait_ait_electronicaddress_ait_company")]
    public ArcticIT.EarlyBound.Entities.ait_company ait_ait_electronicaddress_ait_company
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_company>(nameof (ait_ait_electronicaddress_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_company));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_company>(nameof (ait_ait_electronicaddress_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_company));
      }
    }

    [AttributeLogicalName("ait_school")]
    [RelationshipSchemaName("ait_ait_electronicaddress_ait_school")]
    public ArcticIT.EarlyBound.Entities.ait_school ait_ait_electronicaddress_ait_school
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_school>(nameof (ait_ait_electronicaddress_ait_school), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_school));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_school>(nameof (ait_ait_electronicaddress_ait_school), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_school));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_ait_electronicaddress_contact")]
    public Contact ait_ait_electronicaddress_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_ait_electronicaddress_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_contact));
        this.SetRelatedEntity<Contact>(nameof (ait_ait_electronicaddress_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_electronicaddress")]
    public BusinessUnit business_unit_ait_electronicaddress
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_electronicaddress), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_electronicaddress_createdby")]
    public SystemUser lk_ait_electronicaddress_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_electronicaddress_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_electronicaddress_createdonbehalfby")]
    public SystemUser lk_ait_electronicaddress_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_electronicaddress_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_electronicaddress_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_electronicaddress_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_electronicaddress_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_electronicaddress_modifiedby")]
    public SystemUser lk_ait_electronicaddress_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_electronicaddress_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_electronicaddress_modifiedonbehalfby")]
    public SystemUser lk_ait_electronicaddress_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_electronicaddress_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_electronicaddress_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_electronicaddress_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_electronicaddress_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_electronicaddress")]
    public Team team_ait_electronicaddress
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_electronicaddress), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_electronicaddress")]
    public SystemUser user_ait_electronicaddress
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_electronicaddress), new EntityRole?());
      }
    }

    public ait_electronicaddress(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_electronicaddressid"] = (object) base.Id;
            break;
          case "ait_electronicaddressid":
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
