// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_childvisitations
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_childvisitations")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_childvisitations : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_childvisitations";
    public const string EntitySchemaName = "ait_childvisitations";
    public const string PrimaryIdAttribute = "ait_childvisitationsid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_childvisitations()
      : base(nameof (ait_childvisitations))
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

    [AttributeLogicalName("ait_activities")]
    public string ait_Activities
    {
      get => this.GetAttributeValue<string>("ait_activities");
      set
      {
        this.OnPropertyChanging(nameof (ait_Activities));
        this.SetAttributeValue("ait_activities", (object) value);
        this.OnPropertyChanged(nameof (ait_Activities));
      }
    }

    [AttributeLogicalName("ait_behaviorobservations")]
    public string ait_BehaviorObservations
    {
      get => this.GetAttributeValue<string>("ait_behaviorobservations");
      set
      {
        this.OnPropertyChanging(nameof (ait_BehaviorObservations));
        this.SetAttributeValue("ait_behaviorobservations", (object) value);
        this.OnPropertyChanged(nameof (ait_BehaviorObservations));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    public EntityReference ait_Caseworker
    {
      get => this.GetAttributeValue<EntityReference>("ait_caseworker");
      set
      {
        this.OnPropertyChanging(nameof (ait_Caseworker));
        this.SetAttributeValue("ait_caseworker", (object) value);
        this.OnPropertyChanged(nameof (ait_Caseworker));
      }
    }

    [AttributeLogicalName("ait_childvisitationsid")]
    public Guid? ait_childvisitationsId
    {
      get => this.GetAttributeValue<Guid?>("ait_childvisitationsid");
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitationsId));
        this.SetAttributeValue("ait_childvisitationsid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_childvisitationsId));
      }
    }

    [AttributeLogicalName("ait_childvisitationsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_childvisitationsId = new Guid?(value);
    }

    [AttributeLogicalName("ait_clientprofile")]
    public EntityReference ait_ClientProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_clientprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_ClientProfile));
        this.SetAttributeValue("ait_clientprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_ClientProfile));
      }
    }

    [AttributeLogicalName("ait_durationofvisit")]
    public int? ait_DurationofVisit
    {
      get => this.GetAttributeValue<int?>("ait_durationofvisit");
      set
      {
        this.OnPropertyChanging(nameof (ait_DurationofVisit));
        this.SetAttributeValue("ait_durationofvisit", (object) value);
        this.OnPropertyChanged(nameof (ait_DurationofVisit));
      }
    }

    [AttributeLogicalName("ait_generalnotes")]
    public string ait_GeneralNotes
    {
      get => this.GetAttributeValue<string>("ait_generalnotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_GeneralNotes));
        this.SetAttributeValue("ait_generalnotes", (object) value);
        this.OnPropertyChanged(nameof (ait_GeneralNotes));
      }
    }

    [AttributeLogicalName("ait_giftsfoodbrought")]
    public string ait_GiftsFoodBrought
    {
      get => this.GetAttributeValue<string>("ait_giftsfoodbrought");
      set
      {
        this.OnPropertyChanging(nameof (ait_GiftsFoodBrought));
        this.SetAttributeValue("ait_giftsfoodbrought", (object) value);
        this.OnPropertyChanged(nameof (ait_GiftsFoodBrought));
      }
    }

    [AttributeLogicalName("ait_locationofvisit")]
    public string ait_LocationOfVisit
    {
      get => this.GetAttributeValue<string>("ait_locationofvisit");
      set
      {
        this.OnPropertyChanging(nameof (ait_LocationOfVisit));
        this.SetAttributeValue("ait_locationofvisit", (object) value);
        this.OnPropertyChanged(nameof (ait_LocationOfVisit));
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

    [AttributeLogicalName("ait_ontime")]
    public OptionSetValue ait_OnTime
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_ontime");
      set
      {
        this.OnPropertyChanging(nameof (ait_OnTime));
        this.SetAttributeValue("ait_ontime", (object) value);
        this.OnPropertyChanged(nameof (ait_OnTime));
      }
    }

    [AttributeLogicalName("ait_ontimedetails")]
    public string ait_OnTimeDetails
    {
      get => this.GetAttributeValue<string>("ait_ontimedetails");
      set
      {
        this.OnPropertyChanging(nameof (ait_OnTimeDetails));
        this.SetAttributeValue("ait_ontimedetails", (object) value);
        this.OnPropertyChanged(nameof (ait_OnTimeDetails));
      }
    }

    [AttributeLogicalName("ait_promisestatements")]
    public string ait_PromiseStatements
    {
      get => this.GetAttributeValue<string>("ait_promisestatements");
      set
      {
        this.OnPropertyChanging(nameof (ait_PromiseStatements));
        this.SetAttributeValue("ait_promisestatements", (object) value);
        this.OnPropertyChanged(nameof (ait_PromiseStatements));
      }
    }

    [AttributeLogicalName("ait_relationship1")]
    public string ait_Relationship1
    {
      get => this.GetAttributeValue<string>("ait_relationship1");
      set
      {
        this.OnPropertyChanging(nameof (ait_Relationship1));
        this.SetAttributeValue("ait_relationship1", (object) value);
        this.OnPropertyChanged(nameof (ait_Relationship1));
      }
    }

    [AttributeLogicalName("ait_relationship2")]
    public string ait_Relationship2
    {
      get => this.GetAttributeValue<string>("ait_relationship2");
      set
      {
        this.OnPropertyChanging(nameof (ait_Relationship2));
        this.SetAttributeValue("ait_relationship2", (object) value);
        this.OnPropertyChanged(nameof (ait_Relationship2));
      }
    }

    [AttributeLogicalName("ait_relationship3")]
    public string ait_Relationship3
    {
      get => this.GetAttributeValue<string>("ait_relationship3");
      set
      {
        this.OnPropertyChanging(nameof (ait_Relationship3));
        this.SetAttributeValue("ait_relationship3", (object) value);
        this.OnPropertyChanged(nameof (ait_Relationship3));
      }
    }

    [AttributeLogicalName("ait_relationship4")]
    public string ait_Relationship4
    {
      get => this.GetAttributeValue<string>("ait_relationship4");
      set
      {
        this.OnPropertyChanging(nameof (ait_Relationship4));
        this.SetAttributeValue("ait_relationship4", (object) value);
        this.OnPropertyChanged(nameof (ait_Relationship4));
      }
    }

    [AttributeLogicalName("ait_relationship5")]
    public string ait_Relationship5
    {
      get => this.GetAttributeValue<string>("ait_relationship5");
      set
      {
        this.OnPropertyChanging(nameof (ait_Relationship5));
        this.SetAttributeValue("ait_relationship5", (object) value);
        this.OnPropertyChanged(nameof (ait_Relationship5));
      }
    }

    [AttributeLogicalName("ait_visitationid")]
    public string ait_VisitationID
    {
      get => this.GetAttributeValue<string>("ait_visitationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_VisitationID));
        this.SetAttributeValue("ait_visitationid", (object) value);
        this.OnPropertyChanged(nameof (ait_VisitationID));
      }
    }

    [AttributeLogicalName("ait_visitationresult")]
    public OptionSetValue ait_VisitationResult
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_visitationresult");
      set
      {
        this.OnPropertyChanging(nameof (ait_VisitationResult));
        this.SetAttributeValue("ait_visitationresult", (object) value);
        this.OnPropertyChanged(nameof (ait_VisitationResult));
      }
    }

    [AttributeLogicalName("ait_visitdate")]
    public DateTime? ait_VisitDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_visitdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_VisitDate));
        this.SetAttributeValue("ait_visitdate", (object) value);
        this.OnPropertyChanged(nameof (ait_VisitDate));
      }
    }

    [AttributeLogicalName("ait_visitdatetimeend")]
    public DateTime? ait_VisitDateTimeEnd
    {
      get => this.GetAttributeValue<DateTime?>("ait_visitdatetimeend");
      set
      {
        this.OnPropertyChanging(nameof (ait_VisitDateTimeEnd));
        this.SetAttributeValue("ait_visitdatetimeend", (object) value);
        this.OnPropertyChanged(nameof (ait_VisitDateTimeEnd));
      }
    }

    [AttributeLogicalName("ait_visitor1")]
    public string ait_Visitor1
    {
      get => this.GetAttributeValue<string>("ait_visitor1");
      set
      {
        this.OnPropertyChanging(nameof (ait_Visitor1));
        this.SetAttributeValue("ait_visitor1", (object) value);
        this.OnPropertyChanged(nameof (ait_Visitor1));
      }
    }

    [AttributeLogicalName("ait_visitor2")]
    public string ait_Visitor2
    {
      get => this.GetAttributeValue<string>("ait_visitor2");
      set
      {
        this.OnPropertyChanging(nameof (ait_Visitor2));
        this.SetAttributeValue("ait_visitor2", (object) value);
        this.OnPropertyChanged(nameof (ait_Visitor2));
      }
    }

    [AttributeLogicalName("ait_visitor3")]
    public string ait_Visitor3
    {
      get => this.GetAttributeValue<string>("ait_visitor3");
      set
      {
        this.OnPropertyChanging(nameof (ait_Visitor3));
        this.SetAttributeValue("ait_visitor3", (object) value);
        this.OnPropertyChanged(nameof (ait_Visitor3));
      }
    }

    [AttributeLogicalName("ait_visitor4")]
    public string ait_Visitor4
    {
      get => this.GetAttributeValue<string>("ait_visitor4");
      set
      {
        this.OnPropertyChanging(nameof (ait_Visitor4));
        this.SetAttributeValue("ait_visitor4", (object) value);
        this.OnPropertyChanged(nameof (ait_Visitor4));
      }
    }

    [AttributeLogicalName("ait_visitor5")]
    public string ait_Visitor5
    {
      get => this.GetAttributeValue<string>("ait_visitor5");
      set
      {
        this.OnPropertyChanging(nameof (ait_Visitor5));
        this.SetAttributeValue("ait_visitor5", (object) value);
        this.OnPropertyChanged(nameof (ait_Visitor5));
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
    public ait_childvisitationsState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_childvisitationsState?((ait_childvisitationsState) Enum.ToObject(typeof (ait_childvisitationsState), attributeValue.Value)) : new ait_childvisitationsState?();
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

    [RelationshipSchemaName("ait_childvisitations_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_childvisitations_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_childvisitations_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_childvisitations_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_childvisitations_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_childvisitations_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_childvisitations_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_childvisitations_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_childvisitations_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_childvisitations_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_childvisitations_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_childvisitations_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_childvisitations_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_childvisitations_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_childvisitations_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_childvisitations_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_childvisitations_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_childvisitations_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_childvisitations_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_childvisitations_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_childvisitations_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_childvisitations_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_childvisitations_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_childvisitations_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_childvisitations_ProcessSession")]
    public IEnumerable<ProcessSession> ait_childvisitations_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_childvisitations_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_childvisitations_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_childvisitations_SyncErrors")]
    public IEnumerable<SyncError> ait_childvisitations_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_childvisitations_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_childvisitations_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_childvisitations_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_childvisitations_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_childvisitations_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_childvisitations_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_ait_childvisitations_ait_Caseworker_s")]
    public SystemUser ait_ait_childvisitations_ait_Caseworker_s
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_ait_childvisitations_ait_Caseworker_s), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_childvisitations_ait_Caseworker_s));
        this.SetRelatedEntity<SystemUser>(nameof (ait_ait_childvisitations_ait_Caseworker_s), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_childvisitations_ait_Caseworker_s));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_childvisitations_ClientProfile")]
    public ait_clientprofile ait_clientprofile_ait_childvisitations_ClientProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_childvisitations_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_childvisitations_ClientProfile));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_childvisitations_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_childvisitations_ClientProfile));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_childvisitations")]
    public BusinessUnit business_unit_ait_childvisitations
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_childvisitations), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_childvisitations_createdby")]
    public SystemUser lk_ait_childvisitations_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_childvisitations_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_childvisitations_createdonbehalfby")]
    public SystemUser lk_ait_childvisitations_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_childvisitations_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_childvisitations_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_childvisitations_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_childvisitations_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_childvisitations_modifiedby")]
    public SystemUser lk_ait_childvisitations_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_childvisitations_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_childvisitations_modifiedonbehalfby")]
    public SystemUser lk_ait_childvisitations_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_childvisitations_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_childvisitations_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_childvisitations_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_childvisitations_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_childvisitations")]
    public Team team_ait_childvisitations
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_childvisitations), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_childvisitations")]
    public SystemUser user_ait_childvisitations
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_childvisitations), new EntityRole?());
      }
    }

    public ait_childvisitations(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_childvisitationsid"] = (object) base.Id;
            break;
          case "ait_childvisitationsid":
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
