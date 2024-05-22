// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_courtprofileaddress
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_courtprofileaddress")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_courtprofileaddress : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_courtprofileaddress";
    public const string EntitySchemaName = "ait_courtprofileaddress";
    public const string PrimaryIdAttribute = "ait_courtprofileaddressid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_courtprofileaddress()
      : base(nameof (ait_courtprofileaddress))
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

    [AttributeLogicalName("ait_citylookup")]
    public EntityReference ait_CityLookup
    {
      get => this.GetAttributeValue<EntityReference>("ait_citylookup");
      set
      {
        this.OnPropertyChanging(nameof (ait_CityLookup));
        this.SetAttributeValue("ait_citylookup", (object) value);
        this.OnPropertyChanged(nameof (ait_CityLookup));
      }
    }

    [AttributeLogicalName("ait_citymigrated")]
    public string ait_CityMigrated
    {
      get => this.GetAttributeValue<string>("ait_citymigrated");
      set
      {
        this.OnPropertyChanging(nameof (ait_CityMigrated));
        this.SetAttributeValue("ait_citymigrated", (object) value);
        this.OnPropertyChanged(nameof (ait_CityMigrated));
      }
    }

    [AttributeLogicalName("ait_contactaddress")]
    public EntityReference ait_ContactAddress
    {
      get => this.GetAttributeValue<EntityReference>("ait_contactaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_ContactAddress));
        this.SetAttributeValue("ait_contactaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_ContactAddress));
      }
    }

    [AttributeLogicalName("ait_contactemail")]
    public EntityReference ait_ContactEmail
    {
      get => this.GetAttributeValue<EntityReference>("ait_contactemail");
      set
      {
        this.OnPropertyChanging(nameof (ait_ContactEmail));
        this.SetAttributeValue("ait_contactemail", (object) value);
        this.OnPropertyChanged(nameof (ait_ContactEmail));
      }
    }

    [AttributeLogicalName("ait_contactphone1")]
    public EntityReference ait_ContactPhone1
    {
      get => this.GetAttributeValue<EntityReference>("ait_contactphone1");
      set
      {
        this.OnPropertyChanging(nameof (ait_ContactPhone1));
        this.SetAttributeValue("ait_contactphone1", (object) value);
        this.OnPropertyChanged(nameof (ait_ContactPhone1));
      }
    }

    [AttributeLogicalName("ait_contactphone2")]
    public EntityReference ait_ContactPhone2
    {
      get => this.GetAttributeValue<EntityReference>("ait_contactphone2");
      set
      {
        this.OnPropertyChanging(nameof (ait_ContactPhone2));
        this.SetAttributeValue("ait_contactphone2", (object) value);
        this.OnPropertyChanged(nameof (ait_ContactPhone2));
      }
    }

    [AttributeLogicalName("ait_courtaddresstype")]
    public EntityReference ait_CourtAddressType
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtaddresstype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtAddressType));
        this.SetAttributeValue("ait_courtaddresstype", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtAddressType));
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

    [AttributeLogicalName("ait_courtprofileaddressid")]
    public Guid? ait_courtprofileaddressId
    {
      get => this.GetAttributeValue<Guid?>("ait_courtprofileaddressid");
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddressId));
        this.SetAttributeValue("ait_courtprofileaddressid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_courtprofileaddressId));
      }
    }

    [AttributeLogicalName("ait_courtprofileaddressid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_courtprofileaddressId = new Guid?(value);
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

    [AttributeLogicalName("ait_emailmigrated")]
    public string ait_EmailMigrated
    {
      get => this.GetAttributeValue<string>("ait_emailmigrated");
      set
      {
        this.OnPropertyChanging(nameof (ait_EmailMigrated));
        this.SetAttributeValue("ait_emailmigrated", (object) value);
        this.OnPropertyChanged(nameof (ait_EmailMigrated));
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

    [AttributeLogicalName("ait_phone1")]
    public string ait_Phone1
    {
      get => this.GetAttributeValue<string>("ait_phone1");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone1));
        this.SetAttributeValue("ait_phone1", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone1));
      }
    }

    [AttributeLogicalName("ait_phone1migrated")]
    public string ait_Phone1Migrated
    {
      get => this.GetAttributeValue<string>("ait_phone1migrated");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone1Migrated));
        this.SetAttributeValue("ait_phone1migrated", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone1Migrated));
      }
    }

    [AttributeLogicalName("ait_phone2")]
    public string ait_Phone2
    {
      get => this.GetAttributeValue<string>("ait_phone2");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone2));
        this.SetAttributeValue("ait_phone2", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone2));
      }
    }

    [AttributeLogicalName("ait_phone2migrated")]
    public string ait_Phone2Migrated
    {
      get => this.GetAttributeValue<string>("ait_phone2migrated");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone2Migrated));
        this.SetAttributeValue("ait_phone2migrated", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone2Migrated));
      }
    }

    [AttributeLogicalName("ait_statelookup")]
    public EntityReference ait_StateLookup
    {
      get => this.GetAttributeValue<EntityReference>("ait_statelookup");
      set
      {
        this.OnPropertyChanging(nameof (ait_StateLookup));
        this.SetAttributeValue("ait_statelookup", (object) value);
        this.OnPropertyChanged(nameof (ait_StateLookup));
      }
    }

    [AttributeLogicalName("ait_statemigrated")]
    public string ait_StateMigrated
    {
      get => this.GetAttributeValue<string>("ait_statemigrated");
      set
      {
        this.OnPropertyChanging(nameof (ait_StateMigrated));
        this.SetAttributeValue("ait_statemigrated", (object) value);
        this.OnPropertyChanged(nameof (ait_StateMigrated));
      }
    }

    [AttributeLogicalName("ait_street")]
    public string ait_Street
    {
      get => this.GetAttributeValue<string>("ait_street");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street));
        this.SetAttributeValue("ait_street", (object) value);
        this.OnPropertyChanged(nameof (ait_Street));
      }
    }

    [AttributeLogicalName("ait_street2")]
    public string ait_Street2
    {
      get => this.GetAttributeValue<string>("ait_street2");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street2));
        this.SetAttributeValue("ait_street2", (object) value);
        this.OnPropertyChanged(nameof (ait_Street2));
      }
    }

    [AttributeLogicalName("ait_street2migrated")]
    public string ait_Street2Migrated
    {
      get => this.GetAttributeValue<string>("ait_street2migrated");
      set
      {
        this.OnPropertyChanging(nameof (ait_Street2Migrated));
        this.SetAttributeValue("ait_street2migrated", (object) value);
        this.OnPropertyChanged(nameof (ait_Street2Migrated));
      }
    }

    [AttributeLogicalName("ait_streetmigrated")]
    public string ait_StreetMigrated
    {
      get => this.GetAttributeValue<string>("ait_streetmigrated");
      set
      {
        this.OnPropertyChanging(nameof (ait_StreetMigrated));
        this.SetAttributeValue("ait_streetmigrated", (object) value);
        this.OnPropertyChanged(nameof (ait_StreetMigrated));
      }
    }

    [AttributeLogicalName("ait_zipcodemigrated")]
    public string ait_ZipCodeMigrated
    {
      get => this.GetAttributeValue<string>("ait_zipcodemigrated");
      set
      {
        this.OnPropertyChanging(nameof (ait_ZipCodeMigrated));
        this.SetAttributeValue("ait_zipcodemigrated", (object) value);
        this.OnPropertyChanged(nameof (ait_ZipCodeMigrated));
      }
    }

    [AttributeLogicalName("ait_ziplookup")]
    public EntityReference ait_ZipLookup
    {
      get => this.GetAttributeValue<EntityReference>("ait_ziplookup");
      set
      {
        this.OnPropertyChanging(nameof (ait_ZipLookup));
        this.SetAttributeValue("ait_ziplookup", (object) value);
        this.OnPropertyChanged(nameof (ait_ZipLookup));
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
    public ait_courtprofileaddressState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_courtprofileaddressState?((ait_courtprofileaddressState) Enum.ToObject(typeof (ait_courtprofileaddressState), attributeValue.Value)) : new ait_courtprofileaddressState?();
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

    [RelationshipSchemaName("ait_courtprofileaddress_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_courtprofileaddress_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_courtprofileaddress_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_courtprofileaddress_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_courtprofileaddress_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_courtprofileaddress_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtprofileaddress_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtprofileaddress_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_courtprofileaddress_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_courtprofileaddress_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtprofileaddress_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtprofileaddress_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_courtprofileaddress_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_courtprofileaddress_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtprofileaddress_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtprofileaddress_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_courtprofileaddress_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_courtprofileaddress_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtprofileaddress_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtprofileaddress_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_courtprofileaddress_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_courtprofileaddress_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtprofileaddress_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtprofileaddress_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_courtprofileaddress_ProcessSession")]
    public IEnumerable<ProcessSession> ait_courtprofileaddress_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_courtprofileaddress_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_courtprofileaddress_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_courtprofileaddress_SyncErrors")]
    public IEnumerable<SyncError> ait_courtprofileaddress_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_courtprofileaddress_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_courtprofileaddress_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_courtprofileaddress_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_courtprofileaddress_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtprofileaddress_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtprofileaddress_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_courtaddresstype")]
    [RelationshipSchemaName("ait_ait_addresstype_ait_courtprofileaddress_CourtAddressType")]
    public ait_addresstype ait_ait_addresstype_ait_courtprofileaddress_CourtAddressType
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_ait_addresstype_ait_courtprofileaddress_CourtAddressType), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_addresstype_ait_courtprofileaddress_CourtAddressType));
        this.SetRelatedEntity<ait_addresstype>(nameof (ait_ait_addresstype_ait_courtprofileaddress_CourtAddressType), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_addresstype_ait_courtprofileaddress_CourtAddressType));
      }
    }

    [AttributeLogicalName("ait_contactemail")]
    [RelationshipSchemaName("ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail")]
    public ait_electronicaddress ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactEmail));
      }
    }

    [AttributeLogicalName("ait_contactphone1")]
    [RelationshipSchemaName("ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1")]
    public ait_electronicaddress ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone1));
      }
    }

    [AttributeLogicalName("ait_contactphone2")]
    [RelationshipSchemaName("ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2")]
    public ait_electronicaddress ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_courtprofileaddress_ContactPhone2));
      }
    }

    [AttributeLogicalName("ait_contactaddress")]
    [RelationshipSchemaName("ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress")]
    public ait_physicaladdress ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_courtprofileaddress_ContactAddress));
      }
    }

    [AttributeLogicalName("ait_citylookup")]
    [RelationshipSchemaName("ait_city_ait_courtprofileaddress_CityLookup")]
    public ait_city ait_city_ait_courtprofileaddress_CityLookup
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_city_ait_courtprofileaddress_CityLookup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_ait_courtprofileaddress_CityLookup));
        this.SetRelatedEntity<ait_city>(nameof (ait_city_ait_courtprofileaddress_CityLookup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_ait_courtprofileaddress_CityLookup));
      }
    }

    [AttributeLogicalName("ait_courtprofile")]
    [RelationshipSchemaName("ait_courtprofile_ait_courtprofileaddress_CourtProfile")]
    public ait_courtprofile ait_courtprofile_ait_courtprofileaddress_CourtProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_ait_courtprofileaddress_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_ait_courtprofileaddress_CourtProfile));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_ait_courtprofileaddress_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_ait_courtprofileaddress_CourtProfile));
      }
    }

    [AttributeLogicalName("ait_statelookup")]
    [RelationshipSchemaName("ait_stateprovince_ait_courtprofileaddress_StateLookup")]
    public ait_stateprovince ait_stateprovince_ait_courtprofileaddress_StateLookup
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_ait_courtprofileaddress_StateLookup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_ait_courtprofileaddress_StateLookup));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_ait_courtprofileaddress_StateLookup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_ait_courtprofileaddress_StateLookup));
      }
    }

    [AttributeLogicalName("ait_ziplookup")]
    [RelationshipSchemaName("ait_zipcodecity_ait_courtprofileaddress_ZipLookup")]
    public ait_zipcodecity ait_zipcodecity_ait_courtprofileaddress_ZipLookup
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_ait_courtprofileaddress_ZipLookup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_ait_courtprofileaddress_ZipLookup));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_ait_courtprofileaddress_ZipLookup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_ait_courtprofileaddress_ZipLookup));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_courtprofileaddress")]
    public BusinessUnit business_unit_ait_courtprofileaddress
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_courtprofileaddress), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_courtprofileaddress_createdby")]
    public SystemUser lk_ait_courtprofileaddress_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofileaddress_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtprofileaddress_createdonbehalfby")]
    public SystemUser lk_ait_courtprofileaddress_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofileaddress_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtprofileaddress_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofileaddress_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtprofileaddress_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_courtprofileaddress_modifiedby")]
    public SystemUser lk_ait_courtprofileaddress_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofileaddress_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtprofileaddress_modifiedonbehalfby")]
    public SystemUser lk_ait_courtprofileaddress_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofileaddress_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtprofileaddress_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtprofileaddress_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtprofileaddress_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_courtprofileaddress")]
    public Team team_ait_courtprofileaddress
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_courtprofileaddress), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_courtprofileaddress")]
    public SystemUser user_ait_courtprofileaddress
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_courtprofileaddress), new EntityRole?());
      }
    }

    public ait_courtprofileaddress(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_courtprofileaddressid"] = (object) base.Id;
            break;
          case "ait_courtprofileaddressid":
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
