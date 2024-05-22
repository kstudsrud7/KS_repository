// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_tribalenrollmentconfiguration
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_tribalenrollmentconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_tribalenrollmentconfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_tribalenrollmentconfiguration";
    public const string EntitySchemaName = "ait_tribalenrollmentconfiguration";
    public const string PrimaryIdAttribute = "ait_tribalenrollmentconfigurationid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_tribalenrollmentconfiguration()
      : base(nameof (ait_tribalenrollmentconfiguration))
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

    [AttributeLogicalName("ait_adultage")]
    public int? ait_adultage
    {
      get => this.GetAttributeValue<int?>(nameof (ait_adultage));
      set
      {
        this.OnPropertyChanging(nameof (ait_adultage));
        this.SetAttributeValue(nameof (ait_adultage), (object) value);
        this.OnPropertyChanged(nameof (ait_adultage));
      }
    }

    [AttributeLogicalName("ait_bqcalculationmethod")]
    public OptionSetValue ait_bqcalculationmethod
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_bqcalculationmethod));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqcalculationmethod));
        this.SetAttributeValue(nameof (ait_bqcalculationmethod), (object) value);
        this.OnPropertyChanged(nameof (ait_bqcalculationmethod));
      }
    }

    [AttributeLogicalName("ait_bqmembershipthresholddecimal")]
    public Decimal? ait_bqmembershipthresholddecimal
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_bqmembershipthresholddecimal));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqmembershipthresholddecimal));
        this.SetAttributeValue(nameof (ait_bqmembershipthresholddecimal), (object) value);
        this.OnPropertyChanged(nameof (ait_bqmembershipthresholddecimal));
      }
    }

    [AttributeLogicalName("ait_bqmembershipthresholdfraction")]
    public string ait_bqmembershipthresholdfraction
    {
      get => this.GetAttributeValue<string>(nameof (ait_bqmembershipthresholdfraction));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqmembershipthresholdfraction));
        this.SetAttributeValue(nameof (ait_bqmembershipthresholdfraction), (object) value);
        this.OnPropertyChanged(nameof (ait_bqmembershipthresholdfraction));
      }
    }

    [AttributeLogicalName("ait_bqparentminimumdecimal")]
    public Decimal? ait_bqparentminimumdecimal
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_bqparentminimumdecimal));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqparentminimumdecimal));
        this.SetAttributeValue(nameof (ait_bqparentminimumdecimal), (object) value);
        this.OnPropertyChanged(nameof (ait_bqparentminimumdecimal));
      }
    }

    [AttributeLogicalName("ait_bqparentminimumfraction")]
    public string ait_bqparentminimumfraction
    {
      get => this.GetAttributeValue<string>(nameof (ait_bqparentminimumfraction));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqparentminimumfraction));
        this.SetAttributeValue(nameof (ait_bqparentminimumfraction), (object) value);
        this.OnPropertyChanged(nameof (ait_bqparentminimumfraction));
      }
    }

    [AttributeLogicalName("ait_contactnaming")]
    public OptionSetValue ait_contactnaming
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_contactnaming));
      set
      {
        this.OnPropertyChanging(nameof (ait_contactnaming));
        this.SetAttributeValue(nameof (ait_contactnaming), (object) value);
        this.OnPropertyChanged(nameof (ait_contactnaming));
      }
    }

    [AttributeLogicalName("ait_defaulttribe")]
    public EntityReference ait_defaulttribe
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_defaulttribe));
      set
      {
        this.OnPropertyChanging(nameof (ait_defaulttribe));
        this.SetAttributeValue(nameof (ait_defaulttribe), (object) value);
        this.OnPropertyChanged(nameof (ait_defaulttribe));
      }
    }

    [AttributeLogicalName("ait_disablecoredistributionpaymentslogic")]
    public bool? ait_DisableCoreDistributionPaymentsLogic
    {
      [DebuggerNonUserCode] get
      {
        return this.GetAttributeValue<bool?>("ait_disablecoredistributionpaymentslogic");
      }
      [DebuggerNonUserCode] set
      {
        this.OnPropertyChanging(nameof (ait_DisableCoreDistributionPaymentsLogic));
        this.SetAttributeValue("ait_disablecoredistributionpaymentslogic", (object) value);
        this.OnPropertyChanged(nameof (ait_DisableCoreDistributionPaymentsLogic));
      }
    }

    [AttributeLogicalName("ait_entityimagestring")]
    public string ait_entityimagestring
    {
      get => this.GetAttributeValue<string>(nameof (ait_entityimagestring));
      set
      {
        this.OnPropertyChanging(nameof (ait_entityimagestring));
        this.SetAttributeValue(nameof (ait_entityimagestring), (object) value);
        this.OnPropertyChanged(nameof (ait_entityimagestring));
      }
    }

    [AttributeLogicalName("ait_familytreereporturl")]
    public string ait_familytreereporturl
    {
      get => this.GetAttributeValue<string>(nameof (ait_familytreereporturl));
      set
      {
        this.OnPropertyChanging(nameof (ait_familytreereporturl));
        this.SetAttributeValue(nameof (ait_familytreereporturl), (object) value);
        this.OnPropertyChanged(nameof (ait_familytreereporturl));
      }
    }

    [AttributeLogicalName("ait_householdnaming")]
    public OptionSetValue ait_householdnaming
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_householdnaming));
      set
      {
        this.OnPropertyChanging(nameof (ait_householdnaming));
        this.SetAttributeValue(nameof (ait_householdnaming), (object) value);
        this.OnPropertyChanged(nameof (ait_householdnaming));
      }
    }

    [AttributeLogicalName("ait_membershipcardexpirationperiod")]
    public int? ait_membershipcardexpirationperiod
    {
      get => this.GetAttributeValue<int?>(nameof (ait_membershipcardexpirationperiod));
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcardexpirationperiod));
        this.SetAttributeValue(nameof (ait_membershipcardexpirationperiod), (object) value);
        this.OnPropertyChanged(nameof (ait_membershipcardexpirationperiod));
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

    [AttributeLogicalName("ait_reportfooterinformation")]
    public string ait_ReportFooterInformation
    {
      get => this.GetAttributeValue<string>("ait_reportfooterinformation");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReportFooterInformation));
        this.SetAttributeValue("ait_reportfooterinformation", (object) value);
        this.OnPropertyChanged(nameof (ait_ReportFooterInformation));
      }
    }

    [AttributeLogicalName("ait_seniorage")]
    public int? ait_seniorage
    {
      get => this.GetAttributeValue<int?>(nameof (ait_seniorage));
      set
      {
        this.OnPropertyChanging(nameof (ait_seniorage));
        this.SetAttributeValue(nameof (ait_seniorage), (object) value);
        this.OnPropertyChanged(nameof (ait_seniorage));
      }
    }

    [AttributeLogicalName("ait_supportedidprintversion")]
    public string ait_supportedidprintversion
    {
      get => this.GetAttributeValue<string>(nameof (ait_supportedidprintversion));
      set
      {
        this.OnPropertyChanging(nameof (ait_supportedidprintversion));
        this.SetAttributeValue(nameof (ait_supportedidprintversion), (object) value);
        this.OnPropertyChanged(nameof (ait_supportedidprintversion));
      }
    }

    [AttributeLogicalName("ait_synchronizehouseholdaddresses")]
    public bool? ait_synchronizehouseholdaddresses
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_synchronizehouseholdaddresses));
      set
      {
        this.OnPropertyChanging(nameof (ait_synchronizehouseholdaddresses));
        this.SetAttributeValue(nameof (ait_synchronizehouseholdaddresses), (object) value);
        this.OnPropertyChanged(nameof (ait_synchronizehouseholdaddresses));
      }
    }

    [AttributeLogicalName("ait_tribalenrollmentconfigurationid")]
    public Guid? ait_tribalenrollmentconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("ait_tribalenrollmentconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfigurationId));
        this.SetAttributeValue("ait_tribalenrollmentconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfigurationId));
      }
    }

    [AttributeLogicalName("ait_tribalenrollmentconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_tribalenrollmentconfigurationId = new Guid?(value);
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

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

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
    public ait_tribalenrollmentconfigurationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_tribalenrollmentconfigurationState?((ait_tribalenrollmentconfigurationState) Enum.ToObject(typeof (ait_tribalenrollmentconfigurationState), attributeValue.Value)) : new ait_tribalenrollmentconfigurationState?();
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

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_tribalenrollmentconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_tribalenrollmentconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_tribalenrollmentconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_tribalenrollmentconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_tribalenrollmentconfiguration_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_tribalenrollmentconfiguration_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_tribalenrollmentconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_tribalenrollmentconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_tribalenrollmentconfiguration_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_tribalenrollmentconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_tribalenrollmentconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_tribalenrollmentconfiguration_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_tribalenrollmentconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_tribalenrollmentconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_tribalenrollmentconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_ProcessSession")]
    public IEnumerable<ProcessSession> ait_tribalenrollmentconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_tribalenrollmentconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_tribalenrollmentconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_SyncErrors")]
    public IEnumerable<SyncError> ait_tribalenrollmentconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_tribalenrollmentconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_tribalenrollmentconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_tribalenrollmentconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_tribalenrollmentconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_tribalenrollmentconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_defaulttribe")]
    [RelationshipSchemaName("ait_ait_tribalenrollmentconfiguration_ait_tribe")]
    public ait_tribe ait_ait_tribalenrollmentconfiguration_ait_tribe
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_tribalenrollmentconfiguration")]
    public BusinessUnit business_unit_ait_tribalenrollmentconfiguration
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_tribalenrollmentconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_tribalenrollmentconfiguration_createdby")]
    public SystemUser lk_ait_tribalenrollmentconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_tribalenrollmentconfiguration_createdonbehalfby")]
    public SystemUser lk_ait_tribalenrollmentconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_tribalenrollmentconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_tribalenrollmentconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_tribalenrollmentconfiguration_modifiedby")]
    public SystemUser lk_ait_tribalenrollmentconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby")]
    public SystemUser lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_tribalenrollmentconfiguration")]
    public Team team_ait_tribalenrollmentconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_tribalenrollmentconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_tribalenrollmentconfiguration")]
    public SystemUser user_ait_tribalenrollmentconfiguration
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_tribalenrollmentconfiguration), new EntityRole?());
      }
    }

    public ait_tribalenrollmentconfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_tribalenrollmentconfigurationid"] = (object) base.Id;
            break;
          case "ait_tribalenrollmentconfigurationid":
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
