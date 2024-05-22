// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_placementlocation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_placementlocation")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_placementlocation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_placementlocation";
    public const string EntitySchemaName = "ait_placementlocation";
    public const string PrimaryIdAttribute = "ait_placementlocationid";
    public const string PrimaryNameAttribute = "ait_placementlocationname";

    public ait_placementlocation()
      : base(nameof (ait_placementlocation))
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

    [AttributeLogicalName("ait_address")]
    public string ait_Address
    {
      get => this.GetAttributeValue<string>("ait_address");
      set
      {
        this.OnPropertyChanging(nameof (ait_Address));
        this.SetAttributeValue("ait_address", (object) value);
        this.OnPropertyChanged(nameof (ait_Address));
      }
    }

    [AttributeLogicalName("ait_backgroundcheckdate")]
    public DateTime? ait_BackgroundCheckDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_backgroundcheckdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_BackgroundCheckDate));
        this.SetAttributeValue("ait_backgroundcheckdate", (object) value);
        this.OnPropertyChanged(nameof (ait_BackgroundCheckDate));
      }
    }

    [AttributeLogicalName("ait_backgroundcheckyn")]
    public bool? ait_BackgroundCheckYN
    {
      get => this.GetAttributeValue<bool?>("ait_backgroundcheckyn");
      set
      {
        this.OnPropertyChanging(nameof (ait_BackgroundCheckYN));
        this.SetAttributeValue("ait_backgroundcheckyn", (object) value);
        this.OnPropertyChanged(nameof (ait_BackgroundCheckYN));
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

    [AttributeLogicalName("ait_ineligibledate")]
    public DateTime? ait_IneligibleDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_ineligibledate");
      set
      {
        this.OnPropertyChanging(nameof (ait_IneligibleDate));
        this.SetAttributeValue("ait_ineligibledate", (object) value);
        this.OnPropertyChanged(nameof (ait_IneligibleDate));
      }
    }

    [AttributeLogicalName("ait_ineligiblereason")]
    public string ait_IneligibleReason
    {
      get => this.GetAttributeValue<string>("ait_ineligiblereason");
      set
      {
        this.OnPropertyChanging(nameof (ait_IneligibleReason));
        this.SetAttributeValue("ait_ineligiblereason", (object) value);
        this.OnPropertyChanged(nameof (ait_IneligibleReason));
      }
    }

    [AttributeLogicalName("ait_inpsectedby")]
    public EntityReference ait_InpsectedBy
    {
      get => this.GetAttributeValue<EntityReference>("ait_inpsectedby");
      set
      {
        this.OnPropertyChanging(nameof (ait_InpsectedBy));
        this.SetAttributeValue("ait_inpsectedby", (object) value);
        this.OnPropertyChanged(nameof (ait_InpsectedBy));
      }
    }

    [AttributeLogicalName("ait_lastinspectiondate")]
    public DateTime? ait_LastInspectionDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_lastinspectiondate");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastInspectionDate));
        this.SetAttributeValue("ait_lastinspectiondate", (object) value);
        this.OnPropertyChanged(nameof (ait_LastInspectionDate));
      }
    }

    [AttributeLogicalName("ait_noofchildrenallowed")]
    public int? ait_noofchildrenallowed
    {
      get => this.GetAttributeValue<int?>(nameof (ait_noofchildrenallowed));
      set
      {
        this.OnPropertyChanging(nameof (ait_noofchildrenallowed));
        this.SetAttributeValue(nameof (ait_noofchildrenallowed), (object) value);
        this.OnPropertyChanged(nameof (ait_noofchildrenallowed));
      }
    }

    [AttributeLogicalName("ait_paymentmailingaddress")]
    public string ait_PaymentMailingAddress
    {
      get => this.GetAttributeValue<string>("ait_paymentmailingaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_PaymentMailingAddress));
        this.SetAttributeValue("ait_paymentmailingaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_PaymentMailingAddress));
      }
    }

    [AttributeLogicalName("ait_paymentsmadeto")]
    public string ait_Paymentsmadeto
    {
      get => this.GetAttributeValue<string>("ait_paymentsmadeto");
      set
      {
        this.OnPropertyChanging(nameof (ait_Paymentsmadeto));
        this.SetAttributeValue("ait_paymentsmadeto", (object) value);
        this.OnPropertyChanged(nameof (ait_Paymentsmadeto));
      }
    }

    [AttributeLogicalName("ait_personcost")]
    public Money ait_PersonCost
    {
      get => this.GetAttributeValue<Money>("ait_personcost");
      set
      {
        this.OnPropertyChanging(nameof (ait_PersonCost));
        this.SetAttributeValue("ait_personcost", (object) value);
        this.OnPropertyChanged(nameof (ait_PersonCost));
      }
    }

    [AttributeLogicalName("ait_personcost_base")]
    public Money ait_personcost_Base => this.GetAttributeValue<Money>("ait_personcost_base");

    [AttributeLogicalName("ait_phone")]
    public string ait_Phone
    {
      get => this.GetAttributeValue<string>("ait_phone");
      set
      {
        this.OnPropertyChanging(nameof (ait_Phone));
        this.SetAttributeValue("ait_phone", (object) value);
        this.OnPropertyChanged(nameof (ait_Phone));
      }
    }

    [AttributeLogicalName("ait_placementcount")]
    public int? ait_PlacementCount => this.GetAttributeValue<int?>("ait_placementcount");

    [AttributeLogicalName("ait_placementcount_date")]
    public DateTime? ait_PlacementCount_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_placementcount_date");
    }

    [AttributeLogicalName("ait_placementcount_state")]
    public int? ait_PlacementCount_State
    {
      get => this.GetAttributeValue<int?>("ait_placementcount_state");
    }

    [AttributeLogicalName("ait_placementlocationcompany")]
    public EntityReference ait_PlacementLocationCompany
    {
      get => this.GetAttributeValue<EntityReference>("ait_placementlocationcompany");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementLocationCompany));
        this.SetAttributeValue("ait_placementlocationcompany", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementLocationCompany));
      }
    }

    [AttributeLogicalName("ait_placementlocationid")]
    public Guid? ait_placementlocationId
    {
      get => this.GetAttributeValue<Guid?>("ait_placementlocationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocationId));
        this.SetAttributeValue("ait_placementlocationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_placementlocationId));
      }
    }

    [AttributeLogicalName("ait_placementlocationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_placementlocationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_placementlocationname")]
    public string ait_placementlocationname
    {
      get => this.GetAttributeValue<string>(nameof (ait_placementlocationname));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocationname));
        this.SetAttributeValue(nameof (ait_placementlocationname), (object) value);
        this.OnPropertyChanged(nameof (ait_placementlocationname));
      }
    }

    [AttributeLogicalName("ait_placementstatus")]
    public OptionSetValue ait_placementstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_placementstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementstatus));
        this.SetAttributeValue(nameof (ait_placementstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_placementstatus));
      }
    }

    [AttributeLogicalName("ait_placementtype")]
    public OptionSetValue ait_PlacementType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_placementtype");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementType));
        this.SetAttributeValue("ait_placementtype", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementType));
      }
    }

    [AttributeLogicalName("ait_primarycontact")]
    public EntityReference ait_primarycontact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_primarycontact));
      set
      {
        this.OnPropertyChanging(nameof (ait_primarycontact));
        this.SetAttributeValue(nameof (ait_primarycontact), (object) value);
        this.OnPropertyChanged(nameof (ait_primarycontact));
      }
    }

    [AttributeLogicalName("ait_remainingplacements")]
    public int? ait_RemainingPlacements => this.GetAttributeValue<int?>("ait_remainingplacements");

    [AttributeLogicalName("ait_secondarycontact")]
    public EntityReference ait_secondarycontact
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_secondarycontact));
      set
      {
        this.OnPropertyChanging(nameof (ait_secondarycontact));
        this.SetAttributeValue(nameof (ait_secondarycontact), (object) value);
        this.OnPropertyChanged(nameof (ait_secondarycontact));
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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
    public ait_placementlocationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_placementlocationState?((ait_placementlocationState) Enum.ToObject(typeof (ait_placementlocationState), attributeValue.Value)) : new ait_placementlocationState?();
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

    [RelationshipSchemaName("ait_placement_placementlocation_ait_place")]
    public IEnumerable<ait_placement> ait_placement_placementlocation_ait_place
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_placement_placementlocation_ait_place), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_placementlocation_ait_place));
        this.SetRelatedEntities<ait_placement>(nameof (ait_placement_placementlocation_ait_place), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_placementlocation_ait_place));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_ActivityParties")]
    public IEnumerable<ActivityParty> ait_placementlocation_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_placementlocation_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_placementlocation_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_placementlocation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_placementlocation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_placementlocation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_placementlocation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_placementlocation_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_placementlocation_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_placementlocation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_placementlocation_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_placementlocation_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_placementlocation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_placementlocation_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_placementlocation_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_placementlocation_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_placementlocation_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_placementlocation_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_placementlocation_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_placementlocation_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_placementlocation_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_ProcessSession")]
    public IEnumerable<ProcessSession> ait_placementlocation_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_placementlocation_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_placementlocation_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_placementlocation_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_placementlocation_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_placementlocation_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_placementlocation_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_placementlocation_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_placementlocation_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_SyncErrors")]
    public IEnumerable<SyncError> ait_placementlocation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_placementlocation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_placementlocation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_placementlocation_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_placementlocation_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_placementlocation_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_placementlocation_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_placementlocationcompany")]
    [RelationshipSchemaName("ait_company_ait_placementlocation_PlacementLocationCompany")]
    public ait_company ait_company_ait_placementlocation_PlacementLocationCompany
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_placementlocation_PlacementLocationCompany), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_placementlocation_PlacementLocationCompany));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_placementlocation_PlacementLocationCompany), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_placementlocation_PlacementLocationCompany));
      }
    }

    [AttributeLogicalName("ait_primarycontact")]
    [RelationshipSchemaName("ait_placementlocation_primarycontact_Cont")]
    public Contact ait_placementlocation_primarycontact_Cont
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_placementlocation_primarycontact_Cont), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_primarycontact_Cont));
        this.SetRelatedEntity<Contact>(nameof (ait_placementlocation_primarycontact_Cont), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_primarycontact_Cont));
      }
    }

    [AttributeLogicalName("ait_secondarycontact")]
    [RelationshipSchemaName("ait_placementlocation_secondarycontact_Co")]
    public Contact ait_placementlocation_secondarycontact_Co
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_placementlocation_secondarycontact_Co), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_secondarycontact_Co));
        this.SetRelatedEntity<Contact>(nameof (ait_placementlocation_secondarycontact_Co), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_secondarycontact_Co));
      }
    }

    [AttributeLogicalName("ait_inpsectedby")]
    [RelationshipSchemaName("ait_systemuser_ait_placementlocation_InpsectedBy")]
    public SystemUser ait_systemuser_ait_placementlocation_InpsectedBy
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_placementlocation_InpsectedBy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_placementlocation_InpsectedBy));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_placementlocation_InpsectedBy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_placementlocation_InpsectedBy));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_placementlocation")]
    public BusinessUnit business_unit_ait_placementlocation
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_placementlocation), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_placementlocation_createdby")]
    public SystemUser lk_ait_placementlocation_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placementlocation_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_placementlocation_createdonbehalfby")]
    public SystemUser lk_ait_placementlocation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placementlocation_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placementlocation_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_placementlocation_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placementlocation_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_placementlocation_modifiedby")]
    public SystemUser lk_ait_placementlocation_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placementlocation_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_placementlocation_modifiedonbehalfby")]
    public SystemUser lk_ait_placementlocation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placementlocation_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placementlocation_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_placementlocation_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placementlocation_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_placementlocation")]
    public Team team_ait_placementlocation
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_placementlocation), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_placementlocation")]
    public TransactionCurrency TransactionCurrency_ait_placementlocation
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_placementlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_placementlocation));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_placementlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_placementlocation));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_placementlocation")]
    public SystemUser user_ait_placementlocation
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_placementlocation), new EntityRole?());
      }
    }

    public ait_placementlocation(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_placementlocationid"] = (object) base.Id;
            break;
          case "ait_placementlocationid":
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
