// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_safetyplan
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_safetyplan")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_safetyplan : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_safetyplan";
    public const string EntitySchemaName = "ait_safetyplan";
    public const string PrimaryIdAttribute = "ait_safetyplanid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_safetyplan()
      : base(nameof (ait_safetyplan))
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

    [AttributeLogicalName("ait_alternateplan")]
    public string ait_AlternatePlan
    {
      get => this.GetAttributeValue<string>("ait_alternateplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_AlternatePlan));
        this.SetAttributeValue("ait_alternateplan", (object) value);
        this.OnPropertyChanged(nameof (ait_AlternatePlan));
      }
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

    [AttributeLogicalName("ait_caseplan")]
    public EntityReference ait_CasePlan
    {
      get => this.GetAttributeValue<EntityReference>("ait_caseplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_CasePlan));
        this.SetAttributeValue("ait_caseplan", (object) value);
        this.OnPropertyChanged(nameof (ait_CasePlan));
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

    [AttributeLogicalName("ait_completeddate")]
    public DateTime? ait_CompletedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_completeddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_CompletedDate));
        this.SetAttributeValue("ait_completeddate", (object) value);
        this.OnPropertyChanged(nameof (ait_CompletedDate));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_Description
    {
      get => this.GetAttributeValue<string>("ait_description");
      set
      {
        this.OnPropertyChanging(nameof (ait_Description));
        this.SetAttributeValue("ait_description", (object) value);
        this.OnPropertyChanged(nameof (ait_Description));
      }
    }

    [AttributeLogicalName("ait_duedate")]
    public DateTime? ait_DueDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_duedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DueDate));
        this.SetAttributeValue("ait_duedate", (object) value);
        this.OnPropertyChanged(nameof (ait_DueDate));
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

    [AttributeLogicalName("ait_individual")]
    public EntityReference ait_Individual
    {
      get => this.GetAttributeValue<EntityReference>("ait_individual");
      set
      {
        this.OnPropertyChanging(nameof (ait_Individual));
        this.SetAttributeValue("ait_individual", (object) value);
        this.OnPropertyChanged(nameof (ait_Individual));
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

    [AttributeLogicalName("ait_newsafetyplan")]
    public string ait_NewSafetyPlan
    {
      get => this.GetAttributeValue<string>("ait_newsafetyplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_NewSafetyPlan));
        this.SetAttributeValue("ait_newsafetyplan", (object) value);
        this.OnPropertyChanged(nameof (ait_NewSafetyPlan));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    public EntityReference ait_Outcome
    {
      get => this.GetAttributeValue<EntityReference>("ait_outcome");
      set
      {
        this.OnPropertyChanging(nameof (ait_Outcome));
        this.SetAttributeValue("ait_outcome", (object) value);
        this.OnPropertyChanged(nameof (ait_Outcome));
      }
    }

    [AttributeLogicalName("ait_referrals")]
    public string ait_Referrals
    {
      get => this.GetAttributeValue<string>("ait_referrals");
      set
      {
        this.OnPropertyChanging(nameof (ait_Referrals));
        this.SetAttributeValue("ait_referrals", (object) value);
        this.OnPropertyChanged(nameof (ait_Referrals));
      }
    }

    [AttributeLogicalName("ait_safetyconcerns")]
    public string ait_SafetyConcerns
    {
      get => this.GetAttributeValue<string>("ait_safetyconcerns");
      set
      {
        this.OnPropertyChanging(nameof (ait_SafetyConcerns));
        this.SetAttributeValue("ait_safetyconcerns", (object) value);
        this.OnPropertyChanged(nameof (ait_SafetyConcerns));
      }
    }

    [AttributeLogicalName("ait_safetyplanautoid")]
    public string ait_SafetyPlanAutoID
    {
      get => this.GetAttributeValue<string>("ait_safetyplanautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_SafetyPlanAutoID));
        this.SetAttributeValue("ait_safetyplanautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_SafetyPlanAutoID));
      }
    }

    [AttributeLogicalName("ait_safetyplanid")]
    public Guid? ait_safetyplanId
    {
      get => this.GetAttributeValue<Guid?>("ait_safetyplanid");
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplanId));
        this.SetAttributeValue("ait_safetyplanid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_safetyplanId));
      }
    }

    [AttributeLogicalName("ait_safetyplanid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_safetyplanId = new Guid?(value);
    }

    [AttributeLogicalName("ait_safetyplanstatus")]
    public OptionSetValue ait_SafetyPlanStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_safetyplanstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_SafetyPlanStatus));
        this.SetAttributeValue("ait_safetyplanstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_SafetyPlanStatus));
      }
    }

    [AttributeLogicalName("ait_safetystrengths")]
    public string ait_SafetyStrengths
    {
      get => this.GetAttributeValue<string>("ait_safetystrengths");
      set
      {
        this.OnPropertyChanging(nameof (ait_SafetyStrengths));
        this.SetAttributeValue("ait_safetystrengths", (object) value);
        this.OnPropertyChanged(nameof (ait_SafetyStrengths));
      }
    }

    [AttributeLogicalName("ait_startdate")]
    public DateTime? ait_StartDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_startdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_StartDate));
        this.SetAttributeValue("ait_startdate", (object) value);
        this.OnPropertyChanged(nameof (ait_StartDate));
      }
    }

    [AttributeLogicalName("ait_warningsigns")]
    public string ait_WarningSigns
    {
      get => this.GetAttributeValue<string>("ait_warningsigns");
      set
      {
        this.OnPropertyChanging(nameof (ait_WarningSigns));
        this.SetAttributeValue("ait_warningsigns", (object) value);
        this.OnPropertyChanged(nameof (ait_WarningSigns));
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
    public ait_safetyplanState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_safetyplanState?((ait_safetyplanState) Enum.ToObject(typeof (ait_safetyplanState), attributeValue.Value)) : new ait_safetyplanState?();
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

    [RelationshipSchemaName("ait_ait_safetyplan_ait_planactivity_SafetyPlan")]
    public IEnumerable<ait_planactivity> ait_ait_safetyplan_ait_planactivity_SafetyPlan
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_safetyplan_ait_planactivity_SafetyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_safetyplan_ait_planactivity_SafetyPlan));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_safetyplan_ait_planactivity_SafetyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_safetyplan_ait_planactivity_SafetyPlan));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_safetyplan_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_safetyplan_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_safetyplan_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_safetyplan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_safetyplan_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_safetyplan_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_safetyplan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_safetyplan_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_safetyplan_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_safetyplan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_safetyplan_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_safetyplan_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_safetyplan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_safetyplan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_safetyplan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_safetyplan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_safetyplan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_safetyplan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_ProcessSession")]
    public IEnumerable<ProcessSession> ait_safetyplan_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_safetyplan_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_safetyplan_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_safetyplan_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_safetyplan_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_safetyplan_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_safetyplan_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_safetyplan_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_safetyplan_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_SyncErrors")]
    public IEnumerable<SyncError> ait_safetyplan_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_safetyplan_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_safetyplan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_safetyplan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_safetyplan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_safetyplan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_safetyplan_contact")]
    public IEnumerable<Contact> ait_safetyplan_contact
    {
      get => this.GetRelatedEntities<Contact>(nameof (ait_safetyplan_contact), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_contact));
        this.SetRelatedEntities<Contact>(nameof (ait_safetyplan_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_contact));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_safetyplan_Case")]
    public ait_case ait_ait_case_ait_safetyplan_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_safetyplan_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_safetyplan_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_safetyplan_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_safetyplan_Case));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_safetyplan")]
    public ait_caseplan ait_ait_caseplan_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_safetyplan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_safetyplan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_ait_safetyplan")]
    public ait_clientprofile ait_ait_clientprofile_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_safetyplan));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_safetyplan));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_safetyplan")]
    public ait_familygroup ait_ait_familygroup_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_safetyplan));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_safetyplan));
      }
    }

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_ait_safetyplan")]
    public ait_outcome ait_ait_outcome_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_ait_safetyplan));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_ait_safetyplan));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_systemuser_ait_safetyplan_Caseworker")]
    public SystemUser ait_systemuser_ait_safetyplan_Caseworker
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_safetyplan_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_safetyplan_Caseworker));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_safetyplan_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_safetyplan_Caseworker));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_safetyplan")]
    public BusinessUnit business_unit_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_safetyplan), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_safetyplan_createdby")]
    public SystemUser lk_ait_safetyplan_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_safetyplan_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_safetyplan_createdonbehalfby")]
    public SystemUser lk_ait_safetyplan_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_safetyplan_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_safetyplan_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_safetyplan_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_safetyplan_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_safetyplan_modifiedby")]
    public SystemUser lk_ait_safetyplan_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_safetyplan_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_safetyplan_modifiedonbehalfby")]
    public SystemUser lk_ait_safetyplan_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_safetyplan_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_safetyplan_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_safetyplan_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_safetyplan_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_safetyplan")]
    public Team team_ait_safetyplan
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_safetyplan), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_safetyplan")]
    public SystemUser user_ait_safetyplan
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_safetyplan), new EntityRole?());
    }

    public ait_safetyplan(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_safetyplanid"] = (object) base.Id;
            break;
          case "ait_safetyplanid":
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
