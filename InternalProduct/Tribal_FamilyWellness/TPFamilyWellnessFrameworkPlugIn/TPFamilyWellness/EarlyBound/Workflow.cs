// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Workflow
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("workflow")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class Workflow : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "workflow";
    public const int EntityTypeCode = 4703;

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
    public WorkflowState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new WorkflowState?((WorkflowState) Enum.ToObject(typeof (WorkflowState), attributeValue.Value)) : new WorkflowState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (StateCode));
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (StateCode));
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
  }
}
