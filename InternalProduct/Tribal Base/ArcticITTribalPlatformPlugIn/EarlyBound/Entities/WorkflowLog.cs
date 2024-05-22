// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.WorkflowLog
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("workflowlog")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class WorkflowLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "workflowlog";
    public const string EntitySchemaName = "WorkflowLog";
    public const string PrimaryIdAttribute = "workflowlogid";

    public WorkflowLog()
      : base("workflowlog")
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

    [AttributeLogicalName("activityname")]
    public string ActivityName
    {
      get => this.GetAttributeValue<string>("activityname");
      set
      {
        this.OnPropertyChanging(nameof (ActivityName));
        this.SetAttributeValue("activityname", (object) value);
        this.OnPropertyChanged(nameof (ActivityName));
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    public EntityReference AsyncOperationId
    {
      get => this.GetAttributeValue<EntityReference>("asyncoperationid");
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperationId));
        this.SetAttributeValue("asyncoperationid", (object) value);
        this.OnPropertyChanged(nameof (AsyncOperationId));
      }
    }

    [AttributeLogicalName("childworkflowinstanceid")]
    public EntityReference ChildWorkflowInstanceId
    {
      get => this.GetAttributeValue<EntityReference>("childworkflowinstanceid");
      set
      {
        this.OnPropertyChanging(nameof (ChildWorkflowInstanceId));
        this.SetAttributeValue("childworkflowinstanceid", (object) value);
        this.OnPropertyChanged(nameof (ChildWorkflowInstanceId));
      }
    }

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn
    {
      get => this.GetAttributeValue<DateTime?>("completedon");
      set
      {
        this.OnPropertyChanging(nameof (CompletedOn));
        this.SetAttributeValue("completedon", (object) value);
        this.OnPropertyChanged(nameof (CompletedOn));
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

    [AttributeLogicalName("duration")]
    public int? Duration => this.GetAttributeValue<int?>("duration");

    [AttributeLogicalName("errorcode")]
    public int? ErrorCode
    {
      get => this.GetAttributeValue<int?>("errorcode");
      set
      {
        this.OnPropertyChanging(nameof (ErrorCode));
        this.SetAttributeValue("errorcode", (object) value);
        this.OnPropertyChanged(nameof (ErrorCode));
      }
    }

    [AttributeLogicalName("errortext")]
    public string ErrorText
    {
      get => this.GetAttributeValue<string>("errortext");
      set
      {
        this.OnPropertyChanging(nameof (ErrorText));
        this.SetAttributeValue("errortext", (object) value);
        this.OnPropertyChanged(nameof (ErrorText));
      }
    }

    [AttributeLogicalName("interactionactivityresult")]
    public string InteractionActivityResult
    {
      get => this.GetAttributeValue<string>("interactionactivityresult");
      set
      {
        this.OnPropertyChanging(nameof (InteractionActivityResult));
        this.SetAttributeValue("interactionactivityresult", (object) value);
        this.OnPropertyChanged(nameof (InteractionActivityResult));
      }
    }

    [AttributeLogicalName("iterationcount")]
    public int? IterationCount
    {
      get => this.GetAttributeValue<int?>("iterationcount");
      set
      {
        this.OnPropertyChanging(nameof (IterationCount));
        this.SetAttributeValue("iterationcount", (object) value);
        this.OnPropertyChanged(nameof (IterationCount));
      }
    }

    [AttributeLogicalName("message")]
    public string Message
    {
      get => this.GetAttributeValue<string>("message");
      set
      {
        this.OnPropertyChanging(nameof (Message));
        this.SetAttributeValue("message", (object) value);
        this.OnPropertyChanged(nameof (Message));
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

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

    [AttributeLogicalName("repetitioncount")]
    public int? RepetitionCount
    {
      get => this.GetAttributeValue<int?>("repetitioncount");
      set
      {
        this.OnPropertyChanging(nameof (RepetitionCount));
        this.SetAttributeValue("repetitioncount", (object) value);
        this.OnPropertyChanged(nameof (RepetitionCount));
      }
    }

    [AttributeLogicalName("repetitionid")]
    public string RepetitionId
    {
      get => this.GetAttributeValue<string>("repetitionid");
      set
      {
        this.OnPropertyChanging(nameof (RepetitionId));
        this.SetAttributeValue("repetitionid", (object) value);
        this.OnPropertyChanged(nameof (RepetitionId));
      }
    }

    [AttributeLogicalName("stagename")]
    public string StageName
    {
      get => this.GetAttributeValue<string>("stagename");
      set
      {
        this.OnPropertyChanging(nameof (StageName));
        this.SetAttributeValue("stagename", (object) value);
        this.OnPropertyChanged(nameof (StageName));
      }
    }

    [AttributeLogicalName("startedon")]
    public DateTime? StartedOn
    {
      get => this.GetAttributeValue<DateTime?>("startedon");
      set
      {
        this.OnPropertyChanging(nameof (StartedOn));
        this.SetAttributeValue("startedon", (object) value);
        this.OnPropertyChanged(nameof (StartedOn));
      }
    }

    [AttributeLogicalName("status")]
    public OptionSetValue Status
    {
      get => this.GetAttributeValue<OptionSetValue>("status");
      set
      {
        this.OnPropertyChanging(nameof (Status));
        this.SetAttributeValue("status", (object) value);
        this.OnPropertyChanged(nameof (Status));
      }
    }

    [AttributeLogicalName("stepname")]
    public string StepName
    {
      get => this.GetAttributeValue<string>("stepname");
      set
      {
        this.OnPropertyChanging(nameof (StepName));
        this.SetAttributeValue("stepname", (object) value);
        this.OnPropertyChanged(nameof (StepName));
      }
    }

    [AttributeLogicalName("workflowlogid")]
    public Guid? WorkflowLogId
    {
      get => this.GetAttributeValue<Guid?>("workflowlogid");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowLogId));
        this.SetAttributeValue("workflowlogid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (WorkflowLogId));
      }
    }

    [AttributeLogicalName("workflowlogid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.WorkflowLogId = new Guid?(value);
    }

    [RelationshipSchemaName("userentityinstancedata_workflowlog")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_workflowlog
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_workflowlog), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_workflowlog));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_workflowlog), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_workflowlog));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_workflowlogs")]
    public BusinessUnit business_unit_workflowlogs
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_workflowlogs), new EntityRole?());
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("lk_expiredprocess_workflowlogs")]
    public ExpiredProcess lk_expiredprocess_workflowlogs
    {
      get
      {
        return this.GetRelatedEntity<ExpiredProcess>(nameof (lk_expiredprocess_workflowlogs), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_workflowlogs));
        this.SetRelatedEntity<ExpiredProcess>(nameof (lk_expiredprocess_workflowlogs), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_workflowlogs));
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("lk_newprocess_workflowlogs")]
    public NewProcess lk_newprocess_workflowlogs
    {
      get
      {
        return this.GetRelatedEntity<NewProcess>(nameof (lk_newprocess_workflowlogs), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_newprocess_workflowlogs));
        this.SetRelatedEntity<NewProcess>(nameof (lk_newprocess_workflowlogs), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_newprocess_workflowlogs));
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("lk_translationprocess_workflowlogs")]
    public TranslationProcess lk_translationprocess_workflowlogs
    {
      get
      {
        return this.GetRelatedEntity<TranslationProcess>(nameof (lk_translationprocess_workflowlogs), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_translationprocess_workflowlogs));
        this.SetRelatedEntity<TranslationProcess>(nameof (lk_translationprocess_workflowlogs), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_translationprocess_workflowlogs));
      }
    }

    [AttributeLogicalName("childworkflowinstanceid")]
    [RelationshipSchemaName("lk_workflowlog_asyncoperation_childworkflow")]
    public AsyncOperation lk_workflowlog_asyncoperation_childworkflow
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>(nameof (lk_workflowlog_asyncoperation_childworkflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_asyncoperation_childworkflow));
        this.SetRelatedEntity<AsyncOperation>(nameof (lk_workflowlog_asyncoperation_childworkflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_asyncoperation_childworkflow));
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("lk_workflowlog_asyncoperations")]
    public AsyncOperation lk_workflowlog_asyncoperations
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>(nameof (lk_workflowlog_asyncoperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_asyncoperations));
        this.SetRelatedEntity<AsyncOperation>(nameof (lk_workflowlog_asyncoperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_asyncoperations));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_workflowlog_createdby")]
    public SystemUser lk_workflowlog_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_workflowlog_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_workflowlog_createdonbehalfby")]
    public SystemUser lk_workflowlog_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_workflowlog_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_workflowlog_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_createdonbehalfby));
      }
    }

    [AttributeLogicalName("childworkflowinstanceid")]
    [RelationshipSchemaName("lk_workflowlog_flowsession_childworkflow")]
    public flowsession lk_workflowlog_flowsession_childworkflow
    {
      get
      {
        return this.GetRelatedEntity<flowsession>(nameof (lk_workflowlog_flowsession_childworkflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_flowsession_childworkflow));
        this.SetRelatedEntity<flowsession>(nameof (lk_workflowlog_flowsession_childworkflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_flowsession_childworkflow));
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("lk_workflowlog_flowsessions")]
    public flowsession lk_workflowlog_flowsessions
    {
      get
      {
        return this.GetRelatedEntity<flowsession>(nameof (lk_workflowlog_flowsessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_flowsessions));
        this.SetRelatedEntity<flowsession>(nameof (lk_workflowlog_flowsessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_flowsessions));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_workflowlog_modifiedby")]
    public SystemUser lk_workflowlog_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_workflowlog_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_workflowlog_modifiedonbehalfby")]
    public SystemUser lk_workflowlog_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_workflowlog_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_workflowlog_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("lk_workflowlog_processsession")]
    public ProcessSession lk_workflowlog_processsession
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>(nameof (lk_workflowlog_processsession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_processsession));
        this.SetRelatedEntity<ProcessSession>(nameof (lk_workflowlog_processsession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_processsession));
      }
    }

    [AttributeLogicalName("childworkflowinstanceid")]
    [RelationshipSchemaName("lk_workflowlog_processsession_childworkflow")]
    public ProcessSession lk_workflowlog_processsession_childworkflow
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>(nameof (lk_workflowlog_processsession_childworkflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_processsession_childworkflow));
        this.SetRelatedEntity<ProcessSession>(nameof (lk_workflowlog_processsession_childworkflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_processsession_childworkflow));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_workflowlog")]
    public Team team_workflowlog
    {
      get => this.GetRelatedEntity<Team>(nameof (team_workflowlog), new EntityRole?());
    }

    public WorkflowLog(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["workflowlogid"] = (object) base.Id;
            break;
          case "workflowlogid":
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
