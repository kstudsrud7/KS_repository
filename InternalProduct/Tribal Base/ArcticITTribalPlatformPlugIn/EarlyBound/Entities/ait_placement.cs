// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_placement
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_placement")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_placement : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_placement";
    public const string EntitySchemaName = "ait_placement";
    public const string PrimaryIdAttribute = "ait_placementid";
    public const string PrimaryNameAttribute = "ait_placementname";

    public ait_placement()
      : base(nameof (ait_placement))
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

    [AttributeLogicalName("ait_childsignatureifover12")]
    public string ait_ChildSignatureifover12
    {
      get => this.GetAttributeValue<string>("ait_childsignatureifover12");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChildSignatureifover12));
        this.SetAttributeValue("ait_childsignatureifover12", (object) value);
        this.OnPropertyChanged(nameof (ait_ChildSignatureifover12));
      }
    }

    [AttributeLogicalName("ait_departmentrepsignature")]
    public string ait_DepartmentRepSignature
    {
      get => this.GetAttributeValue<string>("ait_departmentrepsignature");
      set
      {
        this.OnPropertyChanging(nameof (ait_DepartmentRepSignature));
        this.SetAttributeValue("ait_departmentrepsignature", (object) value);
        this.OnPropertyChanged(nameof (ait_DepartmentRepSignature));
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

    [AttributeLogicalName("ait_incident")]
    public EntityReference ait_Incident
    {
      get => this.GetAttributeValue<EntityReference>("ait_incident");
      set
      {
        this.OnPropertyChanging(nameof (ait_Incident));
        this.SetAttributeValue("ait_incident", (object) value);
        this.OnPropertyChanged(nameof (ait_Incident));
      }
    }

    [AttributeLogicalName("ait_otherfunding")]
    public string ait_OtherFunding
    {
      get => this.GetAttributeValue<string>("ait_otherfunding");
      set
      {
        this.OnPropertyChanging(nameof (ait_OtherFunding));
        this.SetAttributeValue("ait_otherfunding", (object) value);
        this.OnPropertyChanged(nameof (ait_OtherFunding));
      }
    }

    [AttributeLogicalName("ait_parent1signature")]
    public string ait_Parent1Signature
    {
      get => this.GetAttributeValue<string>("ait_parent1signature");
      set
      {
        this.OnPropertyChanging(nameof (ait_Parent1Signature));
        this.SetAttributeValue("ait_parent1signature", (object) value);
        this.OnPropertyChanged(nameof (ait_Parent1Signature));
      }
    }

    [AttributeLogicalName("ait_parent2signature")]
    public string ait_Parent2Signature
    {
      get => this.GetAttributeValue<string>("ait_parent2signature");
      set
      {
        this.OnPropertyChanging(nameof (ait_Parent2Signature));
        this.SetAttributeValue("ait_parent2signature", (object) value);
        this.OnPropertyChanged(nameof (ait_Parent2Signature));
      }
    }

    [AttributeLogicalName("ait_payment")]
    public EntityReference ait_Payment
    {
      get => this.GetAttributeValue<EntityReference>("ait_payment");
      set
      {
        this.OnPropertyChanging(nameof (ait_Payment));
        this.SetAttributeValue("ait_payment", (object) value);
        this.OnPropertyChanged(nameof (ait_Payment));
      }
    }

    [AttributeLogicalName("ait_placedperson")]
    public EntityReference ait_PlacedPerson
    {
      get => this.GetAttributeValue<EntityReference>("ait_placedperson");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacedPerson));
        this.SetAttributeValue("ait_placedperson", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacedPerson));
      }
    }

    [AttributeLogicalName("ait_placement_autoid")]
    public string ait_Placement_AutoID
    {
      get => this.GetAttributeValue<string>("ait_placement_autoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_Placement_AutoID));
        this.SetAttributeValue("ait_placement_autoid", (object) value);
        this.OnPropertyChanged(nameof (ait_Placement_AutoID));
      }
    }

    [AttributeLogicalName("ait_placementenddate")]
    public DateTime? ait_placementenddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_placementenddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementenddate));
        this.SetAttributeValue(nameof (ait_placementenddate), (object) value);
        this.OnPropertyChanged(nameof (ait_placementenddate));
      }
    }

    [AttributeLogicalName("ait_placementfundingsource")]
    public OptionSetValue ait_PlacementFundingSource
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_placementfundingsource");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementFundingSource));
        this.SetAttributeValue("ait_placementfundingsource", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementFundingSource));
      }
    }

    [AttributeLogicalName("ait_placementid")]
    public Guid? ait_placementId
    {
      get => this.GetAttributeValue<Guid?>("ait_placementid");
      set
      {
        this.OnPropertyChanging(nameof (ait_placementId));
        this.SetAttributeValue("ait_placementid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_placementId));
      }
    }

    [AttributeLogicalName("ait_placementid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_placementId = new Guid?(value);
    }

    [AttributeLogicalName("ait_placementlocation")]
    public EntityReference ait_placementlocation
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_placementlocation));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation));
        this.SetAttributeValue(nameof (ait_placementlocation), (object) value);
        this.OnPropertyChanged(nameof (ait_placementlocation));
      }
    }

    [AttributeLogicalName("ait_placementmonthlyamount")]
    public Money ait_PlacementMonthlyAmount
    {
      get => this.GetAttributeValue<Money>("ait_placementmonthlyamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementMonthlyAmount));
        this.SetAttributeValue("ait_placementmonthlyamount", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementMonthlyAmount));
      }
    }

    [AttributeLogicalName("ait_placementmonthlyamount_base")]
    public Money ait_placementmonthlyamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_placementmonthlyamount_base");
    }

    [AttributeLogicalName("ait_placementname")]
    public string ait_PlacementName
    {
      get => this.GetAttributeValue<string>("ait_placementname");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementName));
        this.SetAttributeValue("ait_placementname", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementName));
      }
    }

    [AttributeLogicalName("ait_placementstartdate")]
    public DateTime? ait_placementstartdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_placementstartdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementstartdate));
        this.SetAttributeValue(nameof (ait_placementstartdate), (object) value);
        this.OnPropertyChanged(nameof (ait_placementstartdate));
      }
    }

    [AttributeLogicalName("ait_placementstatus")]
    public OptionSetValue ait_PlacementStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_placementstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementStatus));
        this.SetAttributeValue("ait_placementstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementStatus));
      }
    }

    [AttributeLogicalName("ait_program")]
    public EntityReference ait_Program
    {
      get => this.GetAttributeValue<EntityReference>("ait_program");
      set
      {
        this.OnPropertyChanging(nameof (ait_Program));
        this.SetAttributeValue("ait_program", (object) value);
        this.OnPropertyChanged(nameof (ait_Program));
      }
    }

    [AttributeLogicalName("ait_totalplaced")]
    public int? ait_TotalPlaced => this.GetAttributeValue<int?>("ait_totalplaced");

    [AttributeLogicalName("ait_totalplaced_date")]
    public DateTime? ait_TotalPlaced_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalplaced_date");
    }

    [AttributeLogicalName("ait_totalplaced_state")]
    public int? ait_TotalPlaced_State => this.GetAttributeValue<int?>("ait_totalplaced_state");

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
    public ait_placementState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_placementState?((ait_placementState) Enum.ToObject(typeof (ait_placementState), attributeValue.Value)) : new ait_placementState?();
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

    [RelationshipSchemaName("ait_ait_placement_ait_icwanotice_Placement")]
    public IEnumerable<ait_icwanotice> ait_ait_placement_ait_icwanotice_Placement
    {
      get
      {
        return this.GetRelatedEntities<ait_icwanotice>(nameof (ait_ait_placement_ait_icwanotice_Placement), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_placement_ait_icwanotice_Placement));
        this.SetRelatedEntities<ait_icwanotice>(nameof (ait_ait_placement_ait_icwanotice_Placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_placement_ait_icwanotice_Placement));
      }
    }

    [RelationshipSchemaName("ait_placement_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_placement_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_placement_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_placement_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_placement_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_placement_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_placement_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_placement_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_placement_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_placement_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_placement_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_placement_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_placement_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_placement_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_placement_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_placement_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_placement_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_placement_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_placement_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_placement_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_placement_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_placement_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_placement_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_placement_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_placement_ProcessSession")]
    public IEnumerable<ProcessSession> ait_placement_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_placement_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_placement_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_placement_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_placement_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_placement_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_placement_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_placement_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_placement_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_placement_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_placement_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_placement_SyncErrors")]
    public IEnumerable<SyncError> ait_placement_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_placement_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_placement_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_placement_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_placement_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_placement_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_placement_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_placement_Contact_Contact")]
    public IEnumerable<Contact> ait_placement_Contact_Contact
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_placement_Contact_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_Contact_Contact));
        this.SetRelatedEntities<Contact>(nameof (ait_placement_Contact_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_Contact_Contact));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_placement_Case")]
    public ait_case ait_ait_case_ait_placement_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_placement_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_placement_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_placement_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_placement_Case));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_placement_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_ait_placement_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_placement_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_placement_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_placement_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_placement_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_payment")]
    [RelationshipSchemaName("ait_ait_payment_ait_placement_Payment")]
    public ait_payment ait_ait_payment_ait_placement_Payment
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_ait_payment_ait_placement_Payment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_payment_ait_placement_Payment));
        this.SetRelatedEntity<ait_payment>(nameof (ait_ait_payment_ait_placement_Payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_payment_ait_placement_Payment));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_ait_program_ait_placement_Program")]
    public ait_program ait_ait_program_ait_placement_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_placement_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_placement_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_placement_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_placement_Program));
      }
    }

    [AttributeLogicalName("ait_placedperson")]
    [RelationshipSchemaName("ait_contact_ait_placement_PlacedPerson")]
    public Contact ait_contact_ait_placement_PlacedPerson
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_placement_PlacedPerson), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_placement_PlacedPerson));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_placement_PlacedPerson), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_placement_PlacedPerson));
      }
    }

    [AttributeLogicalName("ait_incident")]
    [RelationshipSchemaName("ait_incident_ait_placement_Incident")]
    public ait_incident ait_incident_ait_placement_Incident
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_ait_placement_Incident), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ait_placement_Incident));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_ait_placement_Incident), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ait_placement_Incident));
      }
    }

    [AttributeLogicalName("ait_placementlocation")]
    [RelationshipSchemaName("ait_placement_placementlocation_ait_place")]
    public ArcticIT.EarlyBound.Entities.ait_placementlocation ait_placement_placementlocation_ait_place
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_placementlocation>(nameof (ait_placement_placementlocation_ait_place), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_placementlocation_ait_place));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_placementlocation>(nameof (ait_placement_placementlocation_ait_place), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_placementlocation_ait_place));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_placement")]
    public BusinessUnit business_unit_ait_placement
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_placement), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_placement_createdby")]
    public SystemUser lk_ait_placement_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placement_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_placement_createdonbehalfby")]
    public SystemUser lk_ait_placement_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placement_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placement_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_placement_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placement_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_placement_modifiedby")]
    public SystemUser lk_ait_placement_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placement_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_placement_modifiedonbehalfby")]
    public SystemUser lk_ait_placement_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placement_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_placement_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_placement_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_placement_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_placement")]
    public Team team_ait_placement
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_placement), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_placement")]
    public TransactionCurrency TransactionCurrency_ait_placement
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_placement), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_placement));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_placement));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_placement")]
    public SystemUser user_ait_placement
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_placement), new EntityRole?());
    }

    public ait_placement(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_placementid"] = (object) base.Id;
            break;
          case "ait_placementid":
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
