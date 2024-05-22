// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_analysisresult
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_analysisresult")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_analysisresult : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_analysisresult";
    public const string EntitySchemaName = "msdyn_analysisresult";
    public const string PrimaryIdAttribute = "msdyn_analysisresultid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_analysisresult()
      : base(nameof (msdyn_analysisresult))
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

    [AttributeLogicalName("msdyn_analysiscomponentid")]
    public EntityReference msdyn_AnalysisComponentId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_analysiscomponentid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AnalysisComponentId));
        this.SetAttributeValue("msdyn_analysiscomponentid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AnalysisComponentId));
      }
    }

    [AttributeLogicalName("msdyn_analysiscomponenttype")]
    public OptionSetValue msdyn_AnalysisComponentType
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_analysiscomponenttype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AnalysisComponentType));
        this.SetAttributeValue("msdyn_analysiscomponenttype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AnalysisComponentType));
      }
    }

    [AttributeLogicalName("msdyn_analysisjobid")]
    public EntityReference msdyn_AnalysisJobId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_analysisjobid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AnalysisJobId));
        this.SetAttributeValue("msdyn_analysisjobid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AnalysisJobId));
      }
    }

    [AttributeLogicalName("msdyn_analysisresultid")]
    public Guid? msdyn_analysisresultId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_analysisresultid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultId));
        this.SetAttributeValue("msdyn_analysisresultid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_analysisresultId));
      }
    }

    [AttributeLogicalName("msdyn_analysisresultid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_analysisresultId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_category")]
    public OptionSetValue msdyn_Category
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_category");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Category));
        this.SetAttributeValue("msdyn_category", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Category));
      }
    }

    [AttributeLogicalName("msdyn_componenttype")]
    public OptionSetValue msdyn_ComponentType
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_componenttype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ComponentType));
        this.SetAttributeValue("msdyn_componenttype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ComponentType));
      }
    }

    [AttributeLogicalName("msdyn_entityname")]
    public string msdyn_EntityName
    {
      get => this.GetAttributeValue<string>("msdyn_entityname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_EntityName));
        this.SetAttributeValue("msdyn_entityname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_EntityName));
      }
    }

    [AttributeLogicalName("msdyn_fileuri")]
    public string msdyn_FileUri
    {
      get => this.GetAttributeValue<string>("msdyn_fileuri");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_FileUri));
        this.SetAttributeValue("msdyn_fileuri", (object) value);
        this.OnPropertyChanged(nameof (msdyn_FileUri));
      }
    }

    [AttributeLogicalName("msdyn_hasresolution")]
    public bool? msdyn_HasResolution
    {
      get => this.GetAttributeValue<bool?>("msdyn_hasresolution");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_HasResolution));
        this.SetAttributeValue("msdyn_hasresolution", (object) value);
        this.OnPropertyChanged(nameof (msdyn_HasResolution));
      }
    }

    [AttributeLogicalName("msdyn_helplink")]
    public string msdyn_helplink
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_helplink));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_helplink));
        this.SetAttributeValue(nameof (msdyn_helplink), (object) value);
        this.OnPropertyChanged(nameof (msdyn_helplink));
      }
    }

    [AttributeLogicalName("msdyn_level")]
    public OptionSetValue msdyn_Level
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_level");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Level));
        this.SetAttributeValue("msdyn_level", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Level));
      }
    }

    [AttributeLogicalName("msdyn_line")]
    public int? msdyn_Line
    {
      get => this.GetAttributeValue<int?>("msdyn_line");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Line));
        this.SetAttributeValue("msdyn_line", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Line));
      }
    }

    [AttributeLogicalName("msdyn_member")]
    public string msdyn_Member
    {
      get => this.GetAttributeValue<string>("msdyn_member");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Member));
        this.SetAttributeValue("msdyn_member", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Member));
      }
    }

    [AttributeLogicalName("msdyn_message")]
    public string msdyn_Message
    {
      get => this.GetAttributeValue<string>("msdyn_message");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Message));
        this.SetAttributeValue("msdyn_message", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Message));
      }
    }

    [AttributeLogicalName("msdyn_messagearguments")]
    public string msdyn_MessageArguments
    {
      get => this.GetAttributeValue<string>("msdyn_messagearguments");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_MessageArguments));
        this.SetAttributeValue("msdyn_messagearguments", (object) value);
        this.OnPropertyChanged(nameof (msdyn_MessageArguments));
      }
    }

    [AttributeLogicalName("msdyn_messageid")]
    public string msdyn_MessageId
    {
      get => this.GetAttributeValue<string>("msdyn_messageid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_MessageId));
        this.SetAttributeValue("msdyn_messageid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_MessageId));
      }
    }

    [AttributeLogicalName("msdyn_module")]
    public string msdyn_Module
    {
      get => this.GetAttributeValue<string>("msdyn_module");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Module));
        this.SetAttributeValue("msdyn_module", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Module));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_name));
        this.SetAttributeValue(nameof (msdyn_name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_name));
      }
    }

    [AttributeLogicalName("msdyn_returnstatus")]
    public OptionSetValue msdyn_ReturnStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_returnstatus");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ReturnStatus));
        this.SetAttributeValue("msdyn_returnstatus", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ReturnStatus));
      }
    }

    [AttributeLogicalName("msdyn_ruleid")]
    public string msdyn_RuleId
    {
      get => this.GetAttributeValue<string>("msdyn_ruleid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RuleId));
        this.SetAttributeValue("msdyn_ruleid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RuleId));
      }
    }

    [AttributeLogicalName("msdyn_rulereferenceuri")]
    public string msdyn_RuleReferenceUri
    {
      get => this.GetAttributeValue<string>("msdyn_rulereferenceuri");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RuleReferenceUri));
        this.SetAttributeValue("msdyn_rulereferenceuri", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RuleReferenceUri));
      }
    }

    [AttributeLogicalName("msdyn_severity")]
    public OptionSetValue msdyn_Severity
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_severity");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Severity));
        this.SetAttributeValue("msdyn_severity", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Severity));
      }
    }

    [AttributeLogicalName("msdyn_snippet")]
    public string msdyn_Snippet
    {
      get => this.GetAttributeValue<string>("msdyn_snippet");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Snippet));
        this.SetAttributeValue("msdyn_snippet", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Snippet));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthmessage")]
    public string msdyn_SolutionHealthMessage
    {
      get => this.GetAttributeValue<string>("msdyn_solutionhealthmessage");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SolutionHealthMessage));
        this.SetAttributeValue("msdyn_solutionhealthmessage", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SolutionHealthMessage));
      }
    }

    [AttributeLogicalName("msdyn_type")]
    public string msdyn_Type
    {
      get => this.GetAttributeValue<string>("msdyn_type");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Type));
        this.SetAttributeValue("msdyn_type", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Type));
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
    public msdyn_analysisresultState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_analysisresultState?((msdyn_analysisresultState) Enum.ToObject(typeof (msdyn_analysisresultState), attributeValue.Value)) : new msdyn_analysisresultState?();
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

    [RelationshipSchemaName("msdyn_analysisresult_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_analysisresult_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_analysisresult_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_analysisresult_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresult_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_analysisresult_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_analysisresult_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_analysisresult_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresult_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_analysisresult_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisresult_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisresult_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresult_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_analysisresult_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisresult_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisresult_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresult_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_analysisresult_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_analysisresult_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_analysisresult_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresult_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_analysisresult_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_analysisresult_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_analysisresult_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresult_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_analysisresult_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_analysisresult_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_analysisresult_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresult_SyncErrors")]
    public IEnumerable<SyncError> msdyn_analysisresult_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_analysisresult_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_analysisresult_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_analysisresult_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_analysisresult_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_analysisresult_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_analysisresult_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult")]
    public IEnumerable<msdyn_analysisresultdetail> msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisresultdetail>(nameof (msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult));
        this.SetRelatedEntities<msdyn_analysisresultdetail>(nameof (msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_analysisresult_msdyn_analysisresultdetail_AnalysisResult));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_analysisresult")]
    public BusinessUnit business_unit_msdyn_analysisresult
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_analysisresult), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_analysisresult_createdby")]
    public SystemUser lk_msdyn_analysisresult_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresult_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_analysisresult_createdonbehalfby")]
    public SystemUser lk_msdyn_analysisresult_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresult_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_analysisresult_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresult_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_analysisresult_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_analysisresult_modifiedby")]
    public SystemUser lk_msdyn_analysisresult_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresult_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_analysisresult_modifiedonbehalfby")]
    public SystemUser lk_msdyn_analysisresult_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresult_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_analysisresult_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisresult_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_analysisresult_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_analysiscomponentid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_msdyn_analysisresult")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_msdyn_analysisresult
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_msdyn_analysisresult), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_msdyn_analysisresult));
        this.SetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_msdyn_analysisresult), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_msdyn_analysisresult));
      }
    }

    [AttributeLogicalName("msdyn_analysisjobid")]
    [RelationshipSchemaName("msdyn_analysisjob_msdyn_analysisresult")]
    public msdyn_analysisjob msdyn_analysisjob_msdyn_analysisresult
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_msdyn_analysisresult), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_msdyn_analysisresult));
        this.SetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_msdyn_analysisresult), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_msdyn_analysisresult));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_analysisresult")]
    public Team team_msdyn_analysisresult
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_analysisresult), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_analysisresult")]
    public SystemUser user_msdyn_analysisresult
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_analysisresult), new EntityRole?());
      }
    }

    public msdyn_analysisresult(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_analysisresultid"] = (object) base.Id;
            break;
          case "msdyn_analysisresultid":
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
