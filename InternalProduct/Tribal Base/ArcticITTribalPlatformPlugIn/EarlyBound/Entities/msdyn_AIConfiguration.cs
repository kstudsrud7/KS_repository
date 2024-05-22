// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIConfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aiconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIConfiguration : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aiconfiguration";
    public const string EntitySchemaName = "msdyn_AIConfiguration";
    public const string PrimaryIdAttribute = "msdyn_aiconfigurationid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIConfiguration()
      : base("msdyn_aiconfiguration")
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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
      }
    }

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("msdyn_aiconfigurationid")]
    public Guid? msdyn_AIConfigurationId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aiconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIConfigurationId));
        this.SetAttributeValue("msdyn_aiconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIConfigurationId));
      }
    }

    [AttributeLogicalName("msdyn_aiconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIConfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_aiconfigurationidunique")]
    public Guid? msdyn_AIConfigurationIdUnique
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aiconfigurationidunique");
    }

    [AttributeLogicalName("msdyn_aimodelid")]
    public EntityReference msdyn_AIModelId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aimodelid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIModelId));
        this.SetAttributeValue("msdyn_aimodelid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIModelId));
      }
    }

    [AttributeLogicalName("msdyn_createdfromconfigurationid")]
    public EntityReference msdyn_CreatedFromConfigurationId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_createdfromconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_CreatedFromConfigurationId));
        this.SetAttributeValue("msdyn_createdfromconfigurationid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_CreatedFromConfigurationId));
      }
    }

    [AttributeLogicalName("msdyn_customconfiguration")]
    public string msdyn_CustomConfiguration
    {
      get => this.GetAttributeValue<string>("msdyn_customconfiguration");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_CustomConfiguration));
        this.SetAttributeValue("msdyn_customconfiguration", (object) value);
        this.OnPropertyChanged(nameof (msdyn_CustomConfiguration));
      }
    }

    [AttributeLogicalName("msdyn_databinding")]
    public string msdyn_DataBinding
    {
      get => this.GetAttributeValue<string>("msdyn_databinding");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_DataBinding));
        this.SetAttributeValue("msdyn_databinding", (object) value);
        this.OnPropertyChanged(nameof (msdyn_DataBinding));
      }
    }

    [AttributeLogicalName("msdyn_lasterrors")]
    public string msdyn_lasterrors
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_lasterrors));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_lasterrors));
        this.SetAttributeValue(nameof (msdyn_lasterrors), (object) value);
        this.OnPropertyChanged(nameof (msdyn_lasterrors));
      }
    }

    [AttributeLogicalName("msdyn_lasttrainorrundate")]
    public DateTime? msdyn_lasttrainorrundate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (msdyn_lasttrainorrundate));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_lasttrainorrundate));
        this.SetAttributeValue(nameof (msdyn_lasttrainorrundate), (object) value);
        this.OnPropertyChanged(nameof (msdyn_lasttrainorrundate));
      }
    }

    [AttributeLogicalName("msdyn_majoriterationnumber")]
    public int? msdyn_MajorIterationNumber
    {
      get => this.GetAttributeValue<int?>("msdyn_majoriterationnumber");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_MajorIterationNumber));
        this.SetAttributeValue("msdyn_majoriterationnumber", (object) value);
        this.OnPropertyChanged(nameof (msdyn_MajorIterationNumber));
      }
    }

    [AttributeLogicalName("msdyn_minoriterationnumber")]
    public int? msdyn_MinorIterationNumber
    {
      get => this.GetAttributeValue<int?>("msdyn_minoriterationnumber");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_MinorIterationNumber));
        this.SetAttributeValue("msdyn_minoriterationnumber", (object) value);
        this.OnPropertyChanged(nameof (msdyn_MinorIterationNumber));
      }
    }

    [AttributeLogicalName("msdyn_modeldata")]
    public string msdyn_ModelData
    {
      get => this.GetAttributeValue<string>("msdyn_modeldata");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ModelData));
        this.SetAttributeValue("msdyn_modeldata", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ModelData));
      }
    }

    [AttributeLogicalName("msdyn_modelglobalexplainability")]
    public string msdyn_modelglobalexplainability
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_modelglobalexplainability));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_modelglobalexplainability));
        this.SetAttributeValue(nameof (msdyn_modelglobalexplainability), (object) value);
        this.OnPropertyChanged(nameof (msdyn_modelglobalexplainability));
      }
    }

    [AttributeLogicalName("msdyn_modelperformance")]
    public string msdyn_ModelPerformance
    {
      get => this.GetAttributeValue<string>("msdyn_modelperformance");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ModelPerformance));
        this.SetAttributeValue("msdyn_modelperformance", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ModelPerformance));
      }
    }

    [AttributeLogicalName("msdyn_modelprovisioningmetadata")]
    public string msdyn_ModelProvisioningMetadata
    {
      get => this.GetAttributeValue<string>("msdyn_modelprovisioningmetadata");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ModelProvisioningMetadata));
        this.SetAttributeValue("msdyn_modelprovisioningmetadata", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ModelProvisioningMetadata));
      }
    }

    [AttributeLogicalName("msdyn_modelprovisioningstatus")]
    public string msdyn_ModelProvisioningStatus
    {
      get => this.GetAttributeValue<string>("msdyn_modelprovisioningstatus");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ModelProvisioningStatus));
        this.SetAttributeValue("msdyn_modelprovisioningstatus", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ModelProvisioningStatus));
      }
    }

    [AttributeLogicalName("msdyn_modelrundataspecification")]
    public string msdyn_ModelRunDataSpecification
    {
      get => this.GetAttributeValue<string>("msdyn_modelrundataspecification");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ModelRunDataSpecification));
        this.SetAttributeValue("msdyn_modelrundataspecification", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ModelRunDataSpecification));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_Name
    {
      get => this.GetAttributeValue<string>("msdyn_name");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Name));
        this.SetAttributeValue("msdyn_name", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Name));
      }
    }

    [AttributeLogicalName("msdyn_resourceinfo")]
    public string msdyn_ResourceInfo
    {
      get => this.GetAttributeValue<string>("msdyn_resourceinfo");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ResourceInfo));
        this.SetAttributeValue("msdyn_resourceinfo", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ResourceInfo));
      }
    }

    [AttributeLogicalName("msdyn_runconfiguration")]
    public string msdyn_RunConfiguration
    {
      get => this.GetAttributeValue<string>("msdyn_runconfiguration");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RunConfiguration));
        this.SetAttributeValue("msdyn_runconfiguration", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RunConfiguration));
      }
    }

    [AttributeLogicalName("msdyn_schedulingoptions")]
    public string msdyn_SchedulingOptions
    {
      get => this.GetAttributeValue<string>("msdyn_schedulingoptions");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SchedulingOptions));
        this.SetAttributeValue("msdyn_schedulingoptions", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SchedulingOptions));
      }
    }

    [AttributeLogicalName("msdyn_templateversion")]
    public int? msdyn_TemplateVersion
    {
      get => this.GetAttributeValue<int?>("msdyn_templateversion");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_TemplateVersion));
        this.SetAttributeValue("msdyn_templateversion", (object) value);
        this.OnPropertyChanged(nameof (msdyn_TemplateVersion));
      }
    }

    [AttributeLogicalName("msdyn_trainedmodelaiconfigurationpareid")]
    public EntityReference msdyn_TrainedModelAIConfigurationPareId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_trainedmodelaiconfigurationpareid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_TrainedModelAIConfigurationPareId));
        this.SetAttributeValue("msdyn_trainedmodelaiconfigurationpareid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_TrainedModelAIConfigurationPareId));
      }
    }

    [AttributeLogicalName("msdyn_type")]
    public OptionSetValue msdyn_Type
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_type");
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

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

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public msdyn_AIConfigurationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIConfigurationState?((msdyn_AIConfigurationState) Enum.ToObject(typeof (msdyn_AIConfigurationState), attributeValue.Value)) : new msdyn_AIConfigurationState?();
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

    [RelationshipSchemaName("msdyn_aiconfiguration_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aiconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aiconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aiconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aiconfiguration_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aiconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiconfiguration_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiconfiguration_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aiconfiguration_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aiconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<msdyn_AIConfiguration> Referencedmsdyn_aiconfiguration_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIConfiguration>("msdyn_aiconfiguration_msdyn_aiconfiguration", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedmsdyn_aiconfiguration_msdyn_aiconfiguration));
        this.SetRelatedEntities<msdyn_AIConfiguration>("msdyn_aiconfiguration_msdyn_aiconfiguration", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedmsdyn_aiconfiguration_msdyn_aiconfiguration));
      }
    }

    [RelationshipSchemaName("msdyn_aiconfiguration_msdyn_aiodtrainingimage")]
    public IEnumerable<msdyn_AIOdTrainingImage> msdyn_aiconfiguration_msdyn_aiodtrainingimage
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdTrainingImage>(nameof (msdyn_aiconfiguration_msdyn_aiodtrainingimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_msdyn_aiodtrainingimage));
        this.SetRelatedEntities<msdyn_AIOdTrainingImage>(nameof (msdyn_aiconfiguration_msdyn_aiodtrainingimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_msdyn_aiodtrainingimage));
      }
    }

    [RelationshipSchemaName("msdyn_aiconfiguration_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aiconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aiconfiguration_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aiconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aiconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aiconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aiconfiguration_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aiconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aiconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aiconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aiconfiguration_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aiconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<msdyn_AIConfiguration> Referencedmsdyn_createdfromconfiguration_msdyn_toconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIConfiguration>("msdyn_createdfromconfiguration_msdyn_toconfiguration", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedmsdyn_createdfromconfiguration_msdyn_toconfiguration));
        this.SetRelatedEntities<msdyn_AIConfiguration>("msdyn_createdfromconfiguration_msdyn_toconfiguration", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedmsdyn_createdfromconfiguration_msdyn_toconfiguration));
      }
    }

    [RelationshipSchemaName("msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId")]
    public IEnumerable<msdyn_AIFpTrainingDocument> msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIFpTrainingDocument>(nameof (msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId));
        this.SetRelatedEntities<msdyn_AIFpTrainingDocument>(nameof (msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_aiconfiguration_msdyn_aifptrainingdocument_AIConfigurationId));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_msdyn_aiconfiguration")]
    public IEnumerable<msdyn_AIOdLabel> msdyn_aiodlabel_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_msdyn_aiconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_msdyn_aiconfiguration));
        this.SetRelatedEntities<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_msdyn_aiconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_msdyn_aiconfiguration));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aiconfiguration")]
    public BusinessUnit business_unit_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aiconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aiconfiguration_createdby")]
    public SystemUser lk_msdyn_aiconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiconfiguration_createdonbehalfby")]
    public SystemUser lk_msdyn_aiconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aiconfiguration_modifiedby")]
    public SystemUser lk_msdyn_aiconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiconfiguration_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aiconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_trainedmodelaiconfigurationpareid")]
    [RelationshipSchemaName]
    public msdyn_AIConfiguration Referencingmsdyn_aiconfiguration_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>("msdyn_aiconfiguration_msdyn_aiconfiguration", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingmsdyn_aiconfiguration_msdyn_aiconfiguration));
        this.SetRelatedEntity<msdyn_AIConfiguration>("msdyn_aiconfiguration_msdyn_aiconfiguration", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingmsdyn_aiconfiguration_msdyn_aiconfiguration));
      }
    }

    [AttributeLogicalName("msdyn_aimodelid")]
    [RelationshipSchemaName("msdyn_aimodel_msdyn_aiconfiguration")]
    public msdyn_AIModel msdyn_aimodel_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_msdyn_aiconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_msdyn_aiconfiguration));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_msdyn_aiconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_msdyn_aiconfiguration));
      }
    }

    [AttributeLogicalName("msdyn_createdfromconfigurationid")]
    [RelationshipSchemaName]
    public msdyn_AIConfiguration Referencingmsdyn_createdfromconfiguration_msdyn_toconfiguration
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>("msdyn_createdfromconfiguration_msdyn_toconfiguration", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingmsdyn_createdfromconfiguration_msdyn_toconfiguration));
        this.SetRelatedEntity<msdyn_AIConfiguration>("msdyn_createdfromconfiguration_msdyn_toconfiguration", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingmsdyn_createdfromconfiguration_msdyn_toconfiguration));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aiconfiguration")]
    public Team team_msdyn_aiconfiguration
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aiconfiguration), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aiconfiguration")]
    public SystemUser user_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aiconfiguration), new EntityRole?());
      }
    }

    public msdyn_AIConfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aiconfigurationid"] = (object) base.Id;
            break;
          case "msdyn_aiconfigurationid":
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
