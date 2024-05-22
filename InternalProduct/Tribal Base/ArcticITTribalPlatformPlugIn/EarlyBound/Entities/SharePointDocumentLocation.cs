// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SharePointDocumentLocation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sharepointdocumentlocation")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SharePointDocumentLocation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sharepointdocumentlocation";
    public const string EntitySchemaName = "SharePointDocumentLocation";
    public const string PrimaryIdAttribute = "sharepointdocumentlocationid";
    public const string PrimaryNameAttribute = "name";

    public SharePointDocumentLocation()
      : base("sharepointdocumentlocation")
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

    [AttributeLogicalName("absoluteurl")]
    public string AbsoluteURL
    {
      get => this.GetAttributeValue<string>("absoluteurl");
      set
      {
        this.OnPropertyChanging(nameof (AbsoluteURL));
        this.SetAttributeValue("absoluteurl", (object) value);
        this.OnPropertyChanged(nameof (AbsoluteURL));
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

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
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

    [AttributeLogicalName("locationtype")]
    public OptionSetValue LocationType
    {
      get => this.GetAttributeValue<OptionSetValue>("locationtype");
      set
      {
        this.OnPropertyChanging(nameof (LocationType));
        this.SetAttributeValue("locationtype", (object) value);
        this.OnPropertyChanged(nameof (LocationType));
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

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
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

    [AttributeLogicalName("parentsiteorlocation")]
    public EntityReference ParentSiteOrLocation
    {
      get => this.GetAttributeValue<EntityReference>("parentsiteorlocation");
      set
      {
        this.OnPropertyChanging(nameof (ParentSiteOrLocation));
        this.SetAttributeValue("parentsiteorlocation", (object) value);
        this.OnPropertyChanged(nameof (ParentSiteOrLocation));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("relativeurl")]
    public string RelativeUrl
    {
      get => this.GetAttributeValue<string>("relativeurl");
      set
      {
        this.OnPropertyChanging(nameof (RelativeUrl));
        this.SetAttributeValue("relativeurl", (object) value);
        this.OnPropertyChanged(nameof (RelativeUrl));
      }
    }

    [AttributeLogicalName("servicetype")]
    public OptionSetValue ServiceType
    {
      get => this.GetAttributeValue<OptionSetValue>("servicetype");
      set
      {
        this.OnPropertyChanging(nameof (ServiceType));
        this.SetAttributeValue("servicetype", (object) value);
        this.OnPropertyChanged(nameof (ServiceType));
      }
    }

    [AttributeLogicalName("sharepointdocumentlocationid")]
    public Guid? SharePointDocumentLocationId
    {
      get => this.GetAttributeValue<Guid?>("sharepointdocumentlocationid");
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocationId));
        this.SetAttributeValue("sharepointdocumentlocationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SharePointDocumentLocationId));
      }
    }

    [AttributeLogicalName("sharepointdocumentlocationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SharePointDocumentLocationId = new Guid?(value);
    }

    [AttributeLogicalName("sitecollectionid")]
    public Guid? SiteCollectionId => this.GetAttributeValue<Guid?>("sitecollectionid");

    [AttributeLogicalName("statecode")]
    public SharePointDocumentLocationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SharePointDocumentLocationState?((SharePointDocumentLocationState) Enum.ToObject(typeof (SharePointDocumentLocationState), attributeValue.Value)) : new SharePointDocumentLocationState?();
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
    }

    [AttributeLogicalName("userid")]
    public Guid? UserId
    {
      get => this.GetAttributeValue<Guid?>("userid");
      set
      {
        this.OnPropertyChanging(nameof (UserId));
        this.SetAttributeValue("userid", (object) value);
        this.OnPropertyChanged(nameof (UserId));
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

    [RelationshipSchemaName("sharepointdata_sharepointdocumentlocation")]
    public IEnumerable<SharePointData> sharepointdata_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntities<SharePointData>(nameof (sharepointdata_sharepointdocumentlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sharepointdata_sharepointdocumentlocation));
        this.SetRelatedEntities<SharePointData>(nameof (sharepointdata_sharepointdocumentlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sharepointdata_sharepointdocumentlocation));
      }
    }

    [RelationshipSchemaName("SharePointDocumentLocation_AsyncOperations")]
    public IEnumerable<AsyncOperation> SharePointDocumentLocation_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (SharePointDocumentLocation_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocation_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (SharePointDocumentLocation_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocumentLocation_AsyncOperations));
      }
    }

    [RelationshipSchemaName("SharePointDocumentLocation_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> SharePointDocumentLocation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (SharePointDocumentLocation_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocation_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (SharePointDocumentLocation_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocumentLocation_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("SharePointDocumentLocation_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> SharePointDocumentLocation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (SharePointDocumentLocation_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocation_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (SharePointDocumentLocation_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocumentLocation_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<SharePointDocumentLocation> Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation));
        this.SetRelatedEntities<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation));
      }
    }

    [RelationshipSchemaName("sharepointdocumentlocation_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> sharepointdocumentlocation_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (sharepointdocumentlocation_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sharepointdocumentlocation_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (sharepointdocumentlocation_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sharepointdocumentlocation_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("SharePointDocumentLocation_ProcessSessions")]
    public IEnumerable<ProcessSession> SharePointDocumentLocation_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (SharePointDocumentLocation_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocation_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (SharePointDocumentLocation_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocumentLocation_ProcessSessions));
      }
    }

    [RelationshipSchemaName("SharePointDocumentLocation_SyncErrors")]
    public IEnumerable<SyncError> SharePointDocumentLocation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (SharePointDocumentLocation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocation_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SharePointDocumentLocation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocumentLocation_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sharepointdocumentlocation")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sharepointdocumentlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sharepointdocumentlocation));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sharepointdocumentlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sharepointdocumentlocation));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_SharepointDocumentLocation")]
    public Account Account_SharepointDocumentLocation
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (Account_SharepointDocumentLocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Account_SharepointDocumentLocation));
        this.SetRelatedEntity<Account>(nameof (Account_SharepointDocumentLocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_SharepointDocumentLocation));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_SharePointDocumentLocations")]
    public ait_case ait_case_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_SharePointDocumentLocations")]
    public ait_casenote ait_casenote_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_SharePointDocumentLocations")]
    public ait_caseplan ait_caseplan_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_SharePointDocumentLocations")]
    public ait_clientprofile ait_clientprofile_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_SharePointDocumentLocations")]
    public ait_courtcase ait_courtcase_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofile_SharePointDocumentLocations")]
    public ait_courtprofile ait_courtprofile_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_SharePointDocumentLocations")]
    public ait_icwanotice ait_icwanotice_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_SharePointDocumentLocations")]
    public ait_incident ait_incident_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_medicalproviders_SharePointDocumentLocations")]
    public ait_medicalproviders ait_medicalproviders_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofile_SharePointDocumentLocations")]
    public ait_memberprofile ait_memberprofile_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placement_SharePointDocumentLocations")]
    public ait_placement ait_placement_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_placement>(nameof (ait_placement_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placementlocation_SharePointDocumentLocations")]
    public ait_placementlocation ait_placementlocation_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_SharePointDocumentLocations")]
    public ait_program ait_program_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_SharePointDocumentLocations")]
    public ait_referral ait_referral_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_safetyplan_SharePointDocumentLocations")]
    public ait_safetyplan ait_safetyplan_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_SharePointDocumentLocations")]
    public ait_servicerequest ait_servicerequest_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_SharePointDocumentLocations));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_sharepointdocumentlocation")]
    public BusinessUnit business_unit_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_sharepointdocumentlocation), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("contact_SharePointDocumentLocations")]
    public Contact contact_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (contact_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (contact_SharePointDocumentLocations));
        this.SetRelatedEntity<Contact>(nameof (contact_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticle_SharepointDocumentLocation")]
    public KbArticle KbArticle_SharepointDocumentLocation
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (KbArticle_SharepointDocumentLocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_SharepointDocumentLocation));
        this.SetRelatedEntity<KbArticle>(nameof (KbArticle_SharepointDocumentLocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_SharepointDocumentLocation));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("knowledgearticle_SharePointDocumentLocations")]
    public KnowledgeArticle knowledgearticle_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_SharePointDocumentLocations));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_sharepointdocumentlocationbase_createdby")]
    public SystemUser lk_sharepointdocumentlocationbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentlocationbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sharepointdocumentlocationbase_createdonbehalfby")]
    public SystemUser lk_sharepointdocumentlocationbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentlocationbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sharepointdocumentlocationbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentlocationbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sharepointdocumentlocationbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_sharepointdocumentlocationbase_modifiedby")]
    public SystemUser lk_sharepointdocumentlocationbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentlocationbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sharepointdocumentlocationbase_modifiedonbehalfby")]
    public SystemUser lk_sharepointdocumentlocationbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentlocationbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sharepointdocumentlocationbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sharepointdocumentlocationbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sharepointdocumentlocationbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_SharePointDocumentLocations")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_SharePointDocumentLocations));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_SharePointDocumentLocations));
      }
    }

    [AttributeLogicalName("parentsiteorlocation")]
    [RelationshipSchemaName]
    public SharePointDocumentLocation Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation));
        this.SetRelatedEntity<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation));
      }
    }

    [AttributeLogicalName("parentsiteorlocation")]
    [RelationshipSchemaName("sharepointdocumentlocation_parent_sharepointsite")]
    public SharePointSite sharepointdocumentlocation_parent_sharepointsite
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>(nameof (sharepointdocumentlocation_parent_sharepointsite), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sharepointdocumentlocation_parent_sharepointsite));
        this.SetRelatedEntity<SharePointSite>(nameof (sharepointdocumentlocation_parent_sharepointsite), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sharepointdocumentlocation_parent_sharepointsite));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_sharepointdocumentlocation")]
    public Team team_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_sharepointdocumentlocation), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_SharePointDocumentLocation")]
    public TransactionCurrency TransactionCurrency_SharePointDocumentLocation
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_SharePointDocumentLocation), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_sharepointdocumentlocation")]
    public SystemUser user_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_sharepointdocumentlocation), new EntityRole?());
      }
    }

    public SharePointDocumentLocation(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sharepointdocumentlocationid"] = (object) base.Id;
            break;
          case "sharepointdocumentlocationid":
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
