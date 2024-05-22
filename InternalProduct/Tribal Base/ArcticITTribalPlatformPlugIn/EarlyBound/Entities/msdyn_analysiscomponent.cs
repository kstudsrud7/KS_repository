// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_analysiscomponent
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_analysiscomponent")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_analysiscomponent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_analysiscomponent";
    public const string EntitySchemaName = "msdyn_analysiscomponent";
    public const string PrimaryIdAttribute = "msdyn_analysiscomponentid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_analysiscomponent()
      : base(nameof (msdyn_analysiscomponent))
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
    public Guid? msdyn_analysiscomponentId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_analysiscomponentid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponentId));
        this.SetAttributeValue("msdyn_analysiscomponentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_analysiscomponentId));
      }
    }

    [AttributeLogicalName("msdyn_analysiscomponentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_analysiscomponentId = new Guid?(value);
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

    [AttributeLogicalName("msdyn_componentid")]
    public string msdyn_ComponentId
    {
      get => this.GetAttributeValue<string>("msdyn_componentid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ComponentId));
        this.SetAttributeValue("msdyn_componentid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ComponentId));
      }
    }

    [AttributeLogicalName("msdyn_componentname")]
    public string msdyn_ComponentName
    {
      get => this.GetAttributeValue<string>("msdyn_componentname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ComponentName));
        this.SetAttributeValue("msdyn_componentname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ComponentName));
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

    [AttributeLogicalName("msdyn_componentversion")]
    public string msdyn_ComponentVersion
    {
      get => this.GetAttributeValue<string>("msdyn_componentversion");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ComponentVersion));
        this.SetAttributeValue("msdyn_componentversion", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ComponentVersion));
      }
    }

    [AttributeLogicalName("msdyn_errorcount")]
    public int? msdyn_ErrorCount
    {
      get => this.GetAttributeValue<int?>("msdyn_errorcount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ErrorCount));
        this.SetAttributeValue("msdyn_errorcount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ErrorCount));
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

    [AttributeLogicalName("msdyn_retrycount")]
    public int? msdyn_RetryCount
    {
      get => this.GetAttributeValue<int?>("msdyn_retrycount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RetryCount));
        this.SetAttributeValue("msdyn_retrycount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RetryCount));
      }
    }

    [AttributeLogicalName("msdyn_rulefailcount")]
    public int? msdyn_RuleFailCount
    {
      get => this.GetAttributeValue<int?>("msdyn_rulefailcount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RuleFailCount));
        this.SetAttributeValue("msdyn_rulefailcount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RuleFailCount));
      }
    }

    [AttributeLogicalName("msdyn_rulepasscount")]
    public int? msdyn_RulePassCount
    {
      get => this.GetAttributeValue<int?>("msdyn_rulepasscount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RulePassCount));
        this.SetAttributeValue("msdyn_rulepasscount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RulePassCount));
      }
    }

    [AttributeLogicalName("msdyn_rulepassrate")]
    public int? msdyn_RulePassRate
    {
      get => this.GetAttributeValue<int?>("msdyn_rulepassrate");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RulePassRate));
        this.SetAttributeValue("msdyn_rulepassrate", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RulePassRate));
      }
    }

    [AttributeLogicalName("msdyn_sevcriticalcount")]
    public int? msdyn_sevcriticalcount
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_sevcriticalcount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sevcriticalcount));
        this.SetAttributeValue(nameof (msdyn_sevcriticalcount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sevcriticalcount));
      }
    }

    [AttributeLogicalName("msdyn_sevhighcount")]
    public int? msdyn_sevhighcount
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_sevhighcount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sevhighcount));
        this.SetAttributeValue(nameof (msdyn_sevhighcount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sevhighcount));
      }
    }

    [AttributeLogicalName("msdyn_sevlowcount")]
    public int? msdyn_sevlowcount
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_sevlowcount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sevlowcount));
        this.SetAttributeValue(nameof (msdyn_sevlowcount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sevlowcount));
      }
    }

    [AttributeLogicalName("msdyn_sevmediumcount")]
    public int? msdyn_sevmediumcount
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_sevmediumcount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sevmediumcount));
        this.SetAttributeValue(nameof (msdyn_sevmediumcount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sevmediumcount));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthrulesetid")]
    public EntityReference msdyn_SolutionHealthRuleSetId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_solutionhealthrulesetid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SolutionHealthRuleSetId));
        this.SetAttributeValue("msdyn_solutionhealthrulesetid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SolutionHealthRuleSetId));
      }
    }

    [AttributeLogicalName("msdyn_warningcount")]
    public int? msdyn_WarningCount
    {
      get => this.GetAttributeValue<int?>("msdyn_warningcount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_WarningCount));
        this.SetAttributeValue("msdyn_warningcount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_WarningCount));
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
    public msdyn_analysiscomponentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_analysiscomponentState?((msdyn_analysiscomponentState) Enum.ToObject(typeof (msdyn_analysiscomponentState), attributeValue.Value)) : new msdyn_analysiscomponentState?();
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

    [RelationshipSchemaName("msdyn_analysiscomponent_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_analysiscomponent_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_analysiscomponent_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_analysiscomponent_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_analysiscomponent_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_analysiscomponent_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_analysiscomponent_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_analysiscomponent_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysiscomponent_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysiscomponent_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_analysiscomponent_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysiscomponent_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysiscomponent_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_analysiscomponent_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_analysiscomponent_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_analysiscomponent_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_msdyn_analysisresult")]
    public IEnumerable<msdyn_analysisresult> msdyn_analysiscomponent_msdyn_analysisresult
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisresult>(nameof (msdyn_analysiscomponent_msdyn_analysisresult), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_msdyn_analysisresult));
        this.SetRelatedEntities<msdyn_analysisresult>(nameof (msdyn_analysiscomponent_msdyn_analysisresult), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_msdyn_analysisresult));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_analysiscomponent_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_analysiscomponent_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_analysiscomponent_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_analysiscomponent_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_analysiscomponent_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_analysiscomponent_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_SyncErrors")]
    public IEnumerable<SyncError> msdyn_analysiscomponent_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_analysiscomponent_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_analysiscomponent_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_analysiscomponent_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_analysiscomponent_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_analysiscomponent_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_analysiscomponent_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_analysiscomponent")]
    public BusinessUnit business_unit_msdyn_analysiscomponent
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_analysiscomponent), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_analysiscomponent_createdby")]
    public SystemUser lk_msdyn_analysiscomponent_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysiscomponent_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_analysiscomponent_createdonbehalfby")]
    public SystemUser lk_msdyn_analysiscomponent_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysiscomponent_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_analysiscomponent_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysiscomponent_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_analysiscomponent_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_analysiscomponent_modifiedby")]
    public SystemUser lk_msdyn_analysiscomponent_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysiscomponent_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_analysiscomponent_modifiedonbehalfby")]
    public SystemUser lk_msdyn_analysiscomponent_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysiscomponent_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_analysiscomponent_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysiscomponent_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_analysiscomponent_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_analysisjobid")]
    [RelationshipSchemaName("msdyn_analysisjob_msdyn_analysiscomponent")]
    public msdyn_analysisjob msdyn_analysisjob_msdyn_analysiscomponent
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_msdyn_analysiscomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_msdyn_analysiscomponent));
        this.SetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_msdyn_analysiscomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_msdyn_analysiscomponent));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthrulesetid")]
    [RelationshipSchemaName("msdyn_msdyn_solutionhealthruleset_msdyn_analysi")]
    public msdyn_solutionhealthruleset msdyn_msdyn_solutionhealthruleset_msdyn_analysi
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_analysi), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_analysi));
        this.SetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_analysi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_analysi));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_analysiscomponent")]
    public Team team_msdyn_analysiscomponent
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_analysiscomponent), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_analysiscomponent")]
    public SystemUser user_msdyn_analysiscomponent
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_analysiscomponent), new EntityRole?());
      }
    }

    public msdyn_analysiscomponent(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_analysiscomponentid"] = (object) base.Id;
            break;
          case "msdyn_analysiscomponentid":
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
