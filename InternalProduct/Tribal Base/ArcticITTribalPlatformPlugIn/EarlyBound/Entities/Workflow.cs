// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Workflow
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("workflow")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Workflow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "workflow";
    public const string EntitySchemaName = "Workflow";
    public const string PrimaryIdAttribute = "workflowid";
    public const string PrimaryNameAttribute = "name";

    public Workflow()
      : base("workflow")
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

    [AttributeLogicalName("activeworkflowid")]
    public EntityReference ActiveWorkflowId
    {
      get => this.GetAttributeValue<EntityReference>("activeworkflowid");
    }

    [AttributeLogicalName("asyncautodelete")]
    public bool? AsyncAutoDelete
    {
      get => this.GetAttributeValue<bool?>("asyncautodelete");
      set
      {
        this.OnPropertyChanging(nameof (AsyncAutoDelete));
        this.SetAttributeValue("asyncautodelete", (object) value);
        this.OnPropertyChanged(nameof (AsyncAutoDelete));
      }
    }

    [AttributeLogicalName("businessprocesstype")]
    public OptionSetValue BusinessProcessType
    {
      get => this.GetAttributeValue<OptionSetValue>("businessprocesstype");
      set
      {
        this.OnPropertyChanging(nameof (BusinessProcessType));
        this.SetAttributeValue("businessprocesstype", (object) value);
        this.OnPropertyChanged(nameof (BusinessProcessType));
      }
    }

    [AttributeLogicalName("category")]
    public OptionSetValue Category
    {
      get => this.GetAttributeValue<OptionSetValue>("category");
      set
      {
        this.OnPropertyChanging(nameof (Category));
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged(nameof (Category));
      }
    }

    [AttributeLogicalName("clientdata")]
    public string ClientData
    {
      get => this.GetAttributeValue<string>("clientdata");
      set
      {
        this.OnPropertyChanging(nameof (ClientData));
        this.SetAttributeValue("clientdata", (object) value);
        this.OnPropertyChanged(nameof (ClientData));
      }
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

    [AttributeLogicalName("createstage")]
    public OptionSetValue CreateStage
    {
      get => this.GetAttributeValue<OptionSetValue>("createstage");
      set
      {
        this.OnPropertyChanging(nameof (CreateStage));
        this.SetAttributeValue("createstage", (object) value);
        this.OnPropertyChanged(nameof (CreateStage));
      }
    }

    [AttributeLogicalName("deletestage")]
    public OptionSetValue DeleteStage
    {
      get => this.GetAttributeValue<OptionSetValue>("deletestage");
      set
      {
        this.OnPropertyChanging(nameof (DeleteStage));
        this.SetAttributeValue("deletestage", (object) value);
        this.OnPropertyChanged(nameof (DeleteStage));
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

    [AttributeLogicalName("formid")]
    public Guid? FormId
    {
      get => this.GetAttributeValue<Guid?>("formid");
      set
      {
        this.OnPropertyChanging(nameof (FormId));
        this.SetAttributeValue("formid", (object) value);
        this.OnPropertyChanged(nameof (FormId));
      }
    }

    [AttributeLogicalName("inputparameters")]
    public string InputParameters
    {
      get => this.GetAttributeValue<string>("inputparameters");
      set
      {
        this.OnPropertyChanging(nameof (InputParameters));
        this.SetAttributeValue("inputparameters", (object) value);
        this.OnPropertyChanged(nameof (InputParameters));
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

    [AttributeLogicalName("iscrmuiworkflow")]
    public bool? IsCrmUIWorkflow => this.GetAttributeValue<bool?>("iscrmuiworkflow");

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

    [AttributeLogicalName("iscustomprocessingstepallowedforotherpublishers")]
    public BooleanManagedProperty IsCustomProcessingStepAllowedForOtherPublishers
    {
      get
      {
        return this.GetAttributeValue<BooleanManagedProperty>("iscustomprocessingstepallowedforotherpublishers");
      }
      set
      {
        this.OnPropertyChanging(nameof (IsCustomProcessingStepAllowedForOtherPublishers));
        this.SetAttributeValue("iscustomprocessingstepallowedforotherpublishers", (object) value);
        this.OnPropertyChanged(nameof (IsCustomProcessingStepAllowedForOtherPublishers));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("istransacted")]
    public bool? IsTransacted
    {
      get => this.GetAttributeValue<bool?>("istransacted");
      set
      {
        this.OnPropertyChanging(nameof (IsTransacted));
        this.SetAttributeValue("istransacted", (object) value);
        this.OnPropertyChanged(nameof (IsTransacted));
      }
    }

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get => this.GetAttributeValue<int?>("languagecode");
      set
      {
        this.OnPropertyChanging(nameof (LanguageCode));
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged(nameof (LanguageCode));
      }
    }

    [AttributeLogicalName("mode")]
    public OptionSetValue Mode
    {
      get => this.GetAttributeValue<OptionSetValue>("mode");
      set
      {
        this.OnPropertyChanging(nameof (Mode));
        this.SetAttributeValue("mode", (object) value);
        this.OnPropertyChanged(nameof (Mode));
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

    [AttributeLogicalName("ondemand")]
    public bool? OnDemand
    {
      get => this.GetAttributeValue<bool?>("ondemand");
      set
      {
        this.OnPropertyChanging(nameof (OnDemand));
        this.SetAttributeValue("ondemand", (object) value);
        this.OnPropertyChanged(nameof (OnDemand));
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

    [AttributeLogicalName("parentworkflowid")]
    public EntityReference ParentWorkflowId
    {
      get => this.GetAttributeValue<EntityReference>("parentworkflowid");
    }

    [AttributeLogicalName("plugintypeid")]
    public EntityReference PluginTypeId => this.GetAttributeValue<EntityReference>("plugintypeid");

    [AttributeLogicalName("primaryentity")]
    public string PrimaryEntity
    {
      get => this.GetAttributeValue<string>("primaryentity");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntity));
        this.SetAttributeValue("primaryentity", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntity));
      }
    }

    [AttributeLogicalName("processorder")]
    public int? ProcessOrder
    {
      get => this.GetAttributeValue<int?>("processorder");
      set
      {
        this.OnPropertyChanging(nameof (ProcessOrder));
        this.SetAttributeValue("processorder", (object) value);
        this.OnPropertyChanged(nameof (ProcessOrder));
      }
    }

    [AttributeLogicalName("processroleassignment")]
    public string ProcessRoleAssignment
    {
      get => this.GetAttributeValue<string>("processroleassignment");
      set
      {
        this.OnPropertyChanging(nameof (ProcessRoleAssignment));
        this.SetAttributeValue("processroleassignment", (object) value);
        this.OnPropertyChanged(nameof (ProcessRoleAssignment));
      }
    }

    [AttributeLogicalName("processtriggerformid")]
    public Guid? ProcessTriggerFormId
    {
      get => this.GetAttributeValue<Guid?>("processtriggerformid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessTriggerFormId));
        this.SetAttributeValue("processtriggerformid", (object) value);
        this.OnPropertyChanged(nameof (ProcessTriggerFormId));
      }
    }

    [AttributeLogicalName("processtriggerscope")]
    public OptionSetValue ProcessTriggerScope
    {
      get => this.GetAttributeValue<OptionSetValue>("processtriggerscope");
      set
      {
        this.OnPropertyChanging(nameof (ProcessTriggerScope));
        this.SetAttributeValue("processtriggerscope", (object) value);
        this.OnPropertyChanged(nameof (ProcessTriggerScope));
      }
    }

    [AttributeLogicalName("rank")]
    public int? Rank
    {
      get => this.GetAttributeValue<int?>("rank");
      set
      {
        this.OnPropertyChanging(nameof (Rank));
        this.SetAttributeValue("rank", (object) value);
        this.OnPropertyChanged(nameof (Rank));
      }
    }

    [AttributeLogicalName("rendererobjecttypecode")]
    public string RendererObjectTypeCode
    {
      get => this.GetAttributeValue<string>("rendererobjecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (RendererObjectTypeCode));
        this.SetAttributeValue("rendererobjecttypecode", (object) value);
        this.OnPropertyChanged(nameof (RendererObjectTypeCode));
      }
    }

    [AttributeLogicalName("runas")]
    public OptionSetValue RunAs
    {
      get => this.GetAttributeValue<OptionSetValue>("runas");
      set
      {
        this.OnPropertyChanging(nameof (RunAs));
        this.SetAttributeValue("runas", (object) value);
        this.OnPropertyChanged(nameof (RunAs));
      }
    }

    [AttributeLogicalName("scope")]
    public OptionSetValue Scope
    {
      get => this.GetAttributeValue<OptionSetValue>("scope");
      set
      {
        this.OnPropertyChanging(nameof (Scope));
        this.SetAttributeValue("scope", (object) value);
        this.OnPropertyChanged(nameof (Scope));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public EntityReference SdkMessageId => this.GetAttributeValue<EntityReference>("sdkmessageid");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public WorkflowState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new WorkflowState?((WorkflowState) Enum.ToObject(typeof (WorkflowState), attributeValue.Value)) : new WorkflowState?();
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

    [AttributeLogicalName("subprocess")]
    public bool? Subprocess
    {
      get => this.GetAttributeValue<bool?>("subprocess");
      set
      {
        this.OnPropertyChanging(nameof (Subprocess));
        this.SetAttributeValue("subprocess", (object) value);
        this.OnPropertyChanged(nameof (Subprocess));
      }
    }

    [AttributeLogicalName("syncworkflowlogonfailure")]
    public bool? SyncWorkflowLogOnFailure
    {
      get => this.GetAttributeValue<bool?>("syncworkflowlogonfailure");
      set
      {
        this.OnPropertyChanging(nameof (SyncWorkflowLogOnFailure));
        this.SetAttributeValue("syncworkflowlogonfailure", (object) value);
        this.OnPropertyChanged(nameof (SyncWorkflowLogOnFailure));
      }
    }

    [AttributeLogicalName("triggeroncreate")]
    public bool? TriggerOnCreate
    {
      get => this.GetAttributeValue<bool?>("triggeroncreate");
      set
      {
        this.OnPropertyChanging(nameof (TriggerOnCreate));
        this.SetAttributeValue("triggeroncreate", (object) value);
        this.OnPropertyChanged(nameof (TriggerOnCreate));
      }
    }

    [AttributeLogicalName("triggerondelete")]
    public bool? TriggerOnDelete
    {
      get => this.GetAttributeValue<bool?>("triggerondelete");
      set
      {
        this.OnPropertyChanging(nameof (TriggerOnDelete));
        this.SetAttributeValue("triggerondelete", (object) value);
        this.OnPropertyChanged(nameof (TriggerOnDelete));
      }
    }

    [AttributeLogicalName("triggeronupdateattributelist")]
    public string TriggerOnUpdateAttributeList
    {
      get => this.GetAttributeValue<string>("triggeronupdateattributelist");
      set
      {
        this.OnPropertyChanging(nameof (TriggerOnUpdateAttributeList));
        this.SetAttributeValue("triggeronupdateattributelist", (object) value);
        this.OnPropertyChanged(nameof (TriggerOnUpdateAttributeList));
      }
    }

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get => this.GetAttributeValue<OptionSetValue>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
      }
    }

    [AttributeLogicalName("uidata")]
    public string UIData => this.GetAttributeValue<string>("uidata");

    [AttributeLogicalName("uiflowtype")]
    public OptionSetValue UIFlowType
    {
      get => this.GetAttributeValue<OptionSetValue>("uiflowtype");
      set
      {
        this.OnPropertyChanging(nameof (UIFlowType));
        this.SetAttributeValue("uiflowtype", (object) value);
        this.OnPropertyChanged(nameof (UIFlowType));
      }
    }

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get => this.GetAttributeValue<string>("uniquename");
      set
      {
        this.OnPropertyChanging(nameof (UniqueName));
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged(nameof (UniqueName));
      }
    }

    [AttributeLogicalName("updatestage")]
    public OptionSetValue UpdateStage
    {
      get => this.GetAttributeValue<OptionSetValue>("updatestage");
      set
      {
        this.OnPropertyChanging(nameof (UpdateStage));
        this.SetAttributeValue("updatestage", (object) value);
        this.OnPropertyChanged(nameof (UpdateStage));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("workflowid")]
    public Guid? WorkflowId
    {
      get => this.GetAttributeValue<Guid?>("workflowid");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowId));
        this.SetAttributeValue("workflowid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (WorkflowId));
      }
    }

    [AttributeLogicalName("workflowid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.WorkflowId = new Guid?(value);
    }

    [AttributeLogicalName("workflowidunique")]
    public Guid? WorkflowIdUnique => this.GetAttributeValue<Guid?>("workflowidunique");

    [AttributeLogicalName("xaml")]
    public string Xaml
    {
      get => this.GetAttributeValue<string>("xaml");
      set
      {
        this.OnPropertyChanging(nameof (Xaml));
        this.SetAttributeValue("xaml", (object) value);
        this.OnPropertyChanged(nameof (Xaml));
      }
    }

    [RelationshipSchemaName("catalogassignment_workflow")]
    public IEnumerable<CatalogAssignment> catalogassignment_workflow
    {
      get
      {
        return this.GetRelatedEntities<CatalogAssignment>(nameof (catalogassignment_workflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_workflow));
        this.SetRelatedEntities<CatalogAssignment>(nameof (catalogassignment_workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_workflow));
      }
    }

    [RelationshipSchemaName("convertruleitembase_workflowid")]
    public IEnumerable<ConvertRuleItem> convertruleitembase_workflowid
    {
      get
      {
        return this.GetRelatedEntities<ConvertRuleItem>(nameof (convertruleitembase_workflowid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (convertruleitembase_workflowid));
        this.SetRelatedEntities<ConvertRuleItem>(nameof (convertruleitembase_workflowid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (convertruleitembase_workflowid));
      }
    }

    [RelationshipSchemaName("lk_asyncoperation_workflowactivationid")]
    public IEnumerable<AsyncOperation> lk_asyncoperation_workflowactivationid
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (lk_asyncoperation_workflowactivationid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_asyncoperation_workflowactivationid));
        this.SetRelatedEntities<AsyncOperation>(nameof (lk_asyncoperation_workflowactivationid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_asyncoperation_workflowactivationid));
      }
    }

    [RelationshipSchemaName("lk_expiredprocess_processid")]
    public IEnumerable<ExpiredProcess> lk_expiredprocess_processid
    {
      get
      {
        return this.GetRelatedEntities<ExpiredProcess>(nameof (lk_expiredprocess_processid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_processid));
        this.SetRelatedEntities<ExpiredProcess>(nameof (lk_expiredprocess_processid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_processid));
      }
    }

    [RelationshipSchemaName("lk_newprocess_processid")]
    public IEnumerable<NewProcess> lk_newprocess_processid
    {
      get
      {
        return this.GetRelatedEntities<NewProcess>(nameof (lk_newprocess_processid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_newprocess_processid));
        this.SetRelatedEntities<NewProcess>(nameof (lk_newprocess_processid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_newprocess_processid));
      }
    }

    [RelationshipSchemaName("lk_processsession_processid")]
    public IEnumerable<ProcessSession> lk_processsession_processid
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (lk_processsession_processid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_processsession_processid));
        this.SetRelatedEntities<ProcessSession>(nameof (lk_processsession_processid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_processsession_processid));
      }
    }

    [RelationshipSchemaName("lk_translationprocess_processid")]
    public IEnumerable<TranslationProcess> lk_translationprocess_processid
    {
      get
      {
        return this.GetRelatedEntities<TranslationProcess>(nameof (lk_translationprocess_processid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_translationprocess_processid));
        this.SetRelatedEntities<TranslationProcess>(nameof (lk_translationprocess_processid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_translationprocess_processid));
      }
    }

    [RelationshipSchemaName("msdyn_retrainworkflow_msdyn_toaimodel")]
    public IEnumerable<msdyn_AIModel> msdyn_retrainworkflow_msdyn_toaimodel
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIModel>(nameof (msdyn_retrainworkflow_msdyn_toaimodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_retrainworkflow_msdyn_toaimodel));
        this.SetRelatedEntities<msdyn_AIModel>(nameof (msdyn_retrainworkflow_msdyn_toaimodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_retrainworkflow_msdyn_toaimodel));
      }
    }

    [RelationshipSchemaName("msdyn_scheduleinferenceworkflow_msdyn_toaimodel")]
    public IEnumerable<msdyn_AIModel> msdyn_scheduleinferenceworkflow_msdyn_toaimodel
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIModel>(nameof (msdyn_scheduleinferenceworkflow_msdyn_toaimodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_scheduleinferenceworkflow_msdyn_toaimodel));
        this.SetRelatedEntities<msdyn_AIModel>(nameof (msdyn_scheduleinferenceworkflow_msdyn_toaimodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_scheduleinferenceworkflow_msdyn_toaimodel));
      }
    }

    [RelationshipSchemaName("msdyn_workflow_msdyn_solutionhealthrule_resolutionaction")]
    public IEnumerable<msdyn_solutionhealthrule> msdyn_workflow_msdyn_solutionhealthrule_resolutionaction
    {
      get
      {
        return this.GetRelatedEntities<msdyn_solutionhealthrule>(nameof (msdyn_workflow_msdyn_solutionhealthrule_resolutionaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_workflow_msdyn_solutionhealthrule_resolutionaction));
        this.SetRelatedEntities<msdyn_solutionhealthrule>(nameof (msdyn_workflow_msdyn_solutionhealthrule_resolutionaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_workflow_msdyn_solutionhealthrule_resolutionaction));
      }
    }

    [RelationshipSchemaName("msdyn_workflow_msdyn_solutionhealthrule_Workflow")]
    public IEnumerable<msdyn_solutionhealthrule> msdyn_workflow_msdyn_solutionhealthrule_Workflow
    {
      get
      {
        return this.GetRelatedEntities<msdyn_solutionhealthrule>(nameof (msdyn_workflow_msdyn_solutionhealthrule_Workflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_workflow_msdyn_solutionhealthrule_Workflow));
        this.SetRelatedEntities<msdyn_solutionhealthrule>(nameof (msdyn_workflow_msdyn_solutionhealthrule_Workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_workflow_msdyn_solutionhealthrule_Workflow));
      }
    }

    [RelationshipSchemaName("process_processstage")]
    public IEnumerable<ProcessStage> process_processstage
    {
      get
      {
        return this.GetRelatedEntities<ProcessStage>(nameof (process_processstage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (process_processstage));
        this.SetRelatedEntities<ProcessStage>(nameof (process_processstage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (process_processstage));
      }
    }

    [RelationshipSchemaName("process_processtrigger")]
    public IEnumerable<ProcessTrigger> process_processtrigger
    {
      get
      {
        return this.GetRelatedEntities<ProcessTrigger>(nameof (process_processtrigger), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (process_processtrigger));
        this.SetRelatedEntities<ProcessTrigger>(nameof (process_processtrigger), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (process_processtrigger));
      }
    }

    [RelationshipSchemaName("regardingobjectid_process")]
    public IEnumerable<flowsession> regardingobjectid_process
    {
      get
      {
        return this.GetRelatedEntities<flowsession>(nameof (regardingobjectid_process), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (regardingobjectid_process));
        this.SetRelatedEntities<flowsession>(nameof (regardingobjectid_process), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (regardingobjectid_process));
      }
    }

    [RelationshipSchemaName("slabase_workflowid")]
    public IEnumerable<SLA> slabase_workflowid
    {
      get => this.GetRelatedEntities<SLA>(nameof (slabase_workflowid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slabase_workflowid));
        this.SetRelatedEntities<SLA>(nameof (slabase_workflowid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_workflowid));
      }
    }

    [RelationshipSchemaName("slaitembase_workflowid")]
    public IEnumerable<SLAItem> slaitembase_workflowid
    {
      get => this.GetRelatedEntities<SLAItem>(nameof (slaitembase_workflowid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slaitembase_workflowid));
        this.SetRelatedEntities<SLAItem>(nameof (slaitembase_workflowid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slaitembase_workflowid));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_workflow")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_workflow
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_workflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_workflow));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_workflow));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Workflow> Referencedworkflow_active_workflow
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("workflow_active_workflow", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedworkflow_active_workflow));
        this.SetRelatedEntities<Workflow>("workflow_active_workflow", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedworkflow_active_workflow));
      }
    }

    [RelationshipSchemaName("Workflow_Annotation")]
    public IEnumerable<Annotation> Workflow_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (Workflow_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Workflow_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (Workflow_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Workflow_Annotation));
      }
    }

    [RelationshipSchemaName("workflow_dependencies")]
    public IEnumerable<WorkflowDependency> workflow_dependencies
    {
      get
      {
        return this.GetRelatedEntities<WorkflowDependency>(nameof (workflow_dependencies), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflow_dependencies));
        this.SetRelatedEntities<WorkflowDependency>(nameof (workflow_dependencies), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflow_dependencies));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Workflow> Referencedworkflow_parent_workflow
    {
      get
      {
        return this.GetRelatedEntities<Workflow>("workflow_parent_workflow", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedworkflow_parent_workflow));
        this.SetRelatedEntities<Workflow>("workflow_parent_workflow", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedworkflow_parent_workflow));
      }
    }

    [RelationshipSchemaName("Workflow_routingrule")]
    public IEnumerable<RoutingRule> Workflow_routingrule
    {
      get => this.GetRelatedEntities<RoutingRule>(nameof (Workflow_routingrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Workflow_routingrule));
        this.SetRelatedEntities<RoutingRule>(nameof (Workflow_routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Workflow_routingrule));
      }
    }

    [RelationshipSchemaName("Workflow_SyncErrors")]
    public IEnumerable<SyncError> Workflow_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Workflow_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Workflow_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Workflow_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Workflow_SyncErrors));
      }
    }

    [RelationshipSchemaName("workflow_workflowbinary_Process")]
    public IEnumerable<workflowbinary> workflow_workflowbinary_Process
    {
      get
      {
        return this.GetRelatedEntities<workflowbinary>(nameof (workflow_workflowbinary_Process), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflow_workflowbinary_Process));
        this.SetRelatedEntities<workflowbinary>(nameof (workflow_workflowbinary_Process), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflow_workflowbinary_Process));
      }
    }

    [RelationshipSchemaName("workflowid_convertrule")]
    public IEnumerable<ConvertRule> workflowid_convertrule
    {
      get
      {
        return this.GetRelatedEntities<ConvertRule>(nameof (workflowid_convertrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowid_convertrule));
        this.SetRelatedEntities<ConvertRule>(nameof (workflowid_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowid_convertrule));
      }
    }

    [RelationshipSchemaName("workflowid_profilerule")]
    public IEnumerable<ChannelAccessProfileRule> workflowid_profilerule
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfileRule>(nameof (workflowid_profilerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowid_profilerule));
        this.SetRelatedEntities<ChannelAccessProfileRule>(nameof (workflowid_profilerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowid_profilerule));
      }
    }

    [RelationshipSchemaName("botcomponent_workflow")]
    public IEnumerable<botcomponent> botcomponent_workflow
    {
      get
      {
        return this.GetRelatedEntities<botcomponent>(nameof (botcomponent_workflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_workflow));
        this.SetRelatedEntities<botcomponent>(nameof (botcomponent_workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_workflow));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_workflow")]
    public BusinessUnit business_unit_workflow
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_workflow), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("system_user_workflow")]
    public SystemUser system_user_workflow
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (system_user_workflow), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_workflow")]
    public Team team_workflow
    {
      get => this.GetRelatedEntity<Team>(nameof (team_workflow), new EntityRole?());
    }

    [AttributeLogicalName("activeworkflowid")]
    [RelationshipSchemaName]
    public Workflow Referencingworkflow_active_workflow
    {
      get
      {
        return this.GetRelatedEntity<Workflow>("workflow_active_workflow", new EntityRole?((EntityRole) 0));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("workflow_createdby")]
    public SystemUser workflow_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (workflow_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("workflow_createdonbehalfby")]
    public SystemUser workflow_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (workflow_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflow_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (workflow_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflow_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("workflow_modifiedby")]
    public SystemUser workflow_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (workflow_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("workflow_modifiedonbehalfby")]
    public SystemUser workflow_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (workflow_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflow_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (workflow_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflow_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("parentworkflowid")]
    [RelationshipSchemaName]
    public Workflow Referencingworkflow_parent_workflow
    {
      get
      {
        return this.GetRelatedEntity<Workflow>("workflow_parent_workflow", new EntityRole?((EntityRole) 0));
      }
    }

    public Workflow(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["workflowid"] = (object) base.Id;
            break;
          case "workflowid":
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
