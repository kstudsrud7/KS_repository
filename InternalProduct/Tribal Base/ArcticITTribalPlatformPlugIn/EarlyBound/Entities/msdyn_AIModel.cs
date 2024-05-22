// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIModel
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aimodel")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIModel : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aimodel";
    public const string EntitySchemaName = "msdyn_AIModel";
    public const string PrimaryIdAttribute = "msdyn_aimodelid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIModel()
      : base("msdyn_aimodel")
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

    [AttributeLogicalName("msdyn_activerunconfigurationid")]
    public EntityReference msdyn_ActiveRunConfigurationId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_activerunconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ActiveRunConfigurationId));
        this.SetAttributeValue("msdyn_activerunconfigurationid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ActiveRunConfigurationId));
      }
    }

    [AttributeLogicalName("msdyn_aimodelid")]
    public Guid? msdyn_AIModelId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aimodelid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIModelId));
        this.SetAttributeValue("msdyn_aimodelid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIModelId));
      }
    }

    [AttributeLogicalName("msdyn_aimodelid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIModelId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_aimodelidunique")]
    public Guid? msdyn_AIModelIdUnique => this.GetAttributeValue<Guid?>("msdyn_aimodelidunique");

    [AttributeLogicalName("msdyn_modelcreationcontext")]
    public string msdyn_ModelCreationContext
    {
      get => this.GetAttributeValue<string>("msdyn_modelcreationcontext");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ModelCreationContext));
        this.SetAttributeValue("msdyn_modelcreationcontext", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ModelCreationContext));
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

    [AttributeLogicalName("msdyn_retrainworkflowid")]
    public EntityReference msdyn_RetrainWorkflowId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_retrainworkflowid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RetrainWorkflowId));
        this.SetAttributeValue("msdyn_retrainworkflowid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RetrainWorkflowId));
      }
    }

    [AttributeLogicalName("msdyn_scheduleinferenceworkflowid")]
    public EntityReference msdyn_ScheduleInferenceWorkflowId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_scheduleinferenceworkflowid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ScheduleInferenceWorkflowId));
        this.SetAttributeValue("msdyn_scheduleinferenceworkflowid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ScheduleInferenceWorkflowId));
      }
    }

    [AttributeLogicalName("msdyn_sharewithorganizationoncreate")]
    public bool? msdyn_ShareWithOrganizationOnCreate
    {
      get => this.GetAttributeValue<bool?>("msdyn_sharewithorganizationoncreate");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ShareWithOrganizationOnCreate));
        this.SetAttributeValue("msdyn_sharewithorganizationoncreate", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ShareWithOrganizationOnCreate));
      }
    }

    [AttributeLogicalName("msdyn_templateid")]
    public EntityReference msdyn_TemplateId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_templateid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_TemplateId));
        this.SetAttributeValue("msdyn_templateid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_TemplateId));
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
    public msdyn_AIModelState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIModelState?((msdyn_AIModelState) Enum.ToObject(typeof (msdyn_AIModelState), attributeValue.Value)) : new msdyn_AIModelState?();
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

    [RelationshipSchemaName("msdyn_AIBDatasetsContainer_msdyn_AIModelI")]
    public IEnumerable<msdyn_AIBDatasetsContainer> msdyn_AIBDatasetsContainer_msdyn_AIModelI
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDatasetsContainer>(nameof (msdyn_AIBDatasetsContainer_msdyn_AIModelI), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetsContainer_msdyn_AIModelI));
        this.SetRelatedEntities<msdyn_AIBDatasetsContainer>(nameof (msdyn_AIBDatasetsContainer_msdyn_AIModelI), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetsContainer_msdyn_AIModelI));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_Annotations")]
    public IEnumerable<Annotation> msdyn_aimodel_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (msdyn_aimodel_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (msdyn_aimodel_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_Annotations));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aimodel_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aimodel_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aimodel_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aimodel_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aimodel_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aimodel_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aimodel_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aimodel_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aimodel_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_msdyn_aiconfiguration")]
    public IEnumerable<msdyn_AIConfiguration> msdyn_aimodel_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIConfiguration>(nameof (msdyn_aimodel_msdyn_aiconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_msdyn_aiconfiguration));
        this.SetRelatedEntities<msdyn_AIConfiguration>(nameof (msdyn_aimodel_msdyn_aiconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_msdyn_aiconfiguration));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aimodel_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aimodel_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aimodel_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aimodel_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aimodel_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aimodel_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aimodel_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aimodel_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aimodel_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aimodel_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aimodel_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aimodel_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aimodel_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aimodel")]
    public BusinessUnit business_unit_msdyn_aimodel
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aimodel), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aimodel_createdby")]
    public SystemUser lk_msdyn_aimodel_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aimodel_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aimodel_createdonbehalfby")]
    public SystemUser lk_msdyn_aimodel_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aimodel_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aimodel_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aimodel_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aimodel_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aimodel_modifiedby")]
    public SystemUser lk_msdyn_aimodel_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aimodel_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aimodel_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aimodel_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aimodel_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aimodel_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aimodel_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aimodel_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_templateid")]
    [RelationshipSchemaName("msdyn_aitemplate_msdyn_aimodel")]
    public msdyn_AITemplate msdyn_aitemplate_msdyn_aimodel
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_msdyn_aimodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_msdyn_aimodel));
        this.SetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_msdyn_aimodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_msdyn_aimodel));
      }
    }

    [AttributeLogicalName("msdyn_retrainworkflowid")]
    [RelationshipSchemaName("msdyn_retrainworkflow_msdyn_toaimodel")]
    public Workflow msdyn_retrainworkflow_msdyn_toaimodel
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (msdyn_retrainworkflow_msdyn_toaimodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_retrainworkflow_msdyn_toaimodel));
        this.SetRelatedEntity<Workflow>(nameof (msdyn_retrainworkflow_msdyn_toaimodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_retrainworkflow_msdyn_toaimodel));
      }
    }

    [AttributeLogicalName("msdyn_scheduleinferenceworkflowid")]
    [RelationshipSchemaName("msdyn_scheduleinferenceworkflow_msdyn_toaimodel")]
    public Workflow msdyn_scheduleinferenceworkflow_msdyn_toaimodel
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (msdyn_scheduleinferenceworkflow_msdyn_toaimodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_scheduleinferenceworkflow_msdyn_toaimodel));
        this.SetRelatedEntity<Workflow>(nameof (msdyn_scheduleinferenceworkflow_msdyn_toaimodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_scheduleinferenceworkflow_msdyn_toaimodel));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aimodel")]
    public Team team_msdyn_aimodel
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aimodel), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aimodel")]
    public SystemUser user_msdyn_aimodel
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aimodel), new EntityRole?());
    }

    public msdyn_AIModel(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aimodelid"] = (object) base.Id;
            break;
          case "msdyn_aimodelid":
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
