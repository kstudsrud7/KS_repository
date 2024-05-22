// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.flowsession
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("flowsession")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class flowsession : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "flowsession";
    public const string EntitySchemaName = "flowsession";
    public const string PrimaryIdAttribute = "flowsessionid";
    public const string PrimaryNameAttribute = "name";

    public flowsession()
      : base(nameof (flowsession))
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

    [AttributeLogicalName("context")]
    public string Context
    {
      get => this.GetAttributeValue<string>("context");
      set
      {
        this.OnPropertyChanging(nameof (Context));
        this.SetAttributeValue("context", (object) value);
        this.OnPropertyChanged(nameof (Context));
      }
    }

    [AttributeLogicalName("correlationid")]
    public string CorrelationId
    {
      get => this.GetAttributeValue<string>("correlationid");
      set
      {
        this.OnPropertyChanging(nameof (CorrelationId));
        this.SetAttributeValue("correlationid", (object) value);
        this.OnPropertyChanged(nameof (CorrelationId));
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

    [AttributeLogicalName("errorcode")]
    public string ErrorCode
    {
      get => this.GetAttributeValue<string>("errorcode");
      set
      {
        this.OnPropertyChanging(nameof (ErrorCode));
        this.SetAttributeValue("errorcode", (object) value);
        this.OnPropertyChanged(nameof (ErrorCode));
      }
    }

    [AttributeLogicalName("errormessage")]
    public string ErrorMessage
    {
      get => this.GetAttributeValue<string>("errormessage");
      set
      {
        this.OnPropertyChanging(nameof (ErrorMessage));
        this.SetAttributeValue("errormessage", (object) value);
        this.OnPropertyChanged(nameof (ErrorMessage));
      }
    }

    [AttributeLogicalName("flowsessionid")]
    public Guid? flowsessionId
    {
      get => this.GetAttributeValue<Guid?>("flowsessionid");
      set
      {
        this.OnPropertyChanging(nameof (flowsessionId));
        this.SetAttributeValue("flowsessionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (flowsessionId));
      }
    }

    [AttributeLogicalName("flowsessionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.flowsessionId = new Guid?(value);
    }

    [AttributeLogicalName("gateway")]
    public string Gateway
    {
      get => this.GetAttributeValue<string>("gateway");
      set
      {
        this.OnPropertyChanging(nameof (Gateway));
        this.SetAttributeValue("gateway", (object) value);
        this.OnPropertyChanged(nameof (Gateway));
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

    [AttributeLogicalName("processversion")]
    public string ProcessVersion
    {
      get => this.GetAttributeValue<string>("processversion");
      set
      {
        this.OnPropertyChanging(nameof (ProcessVersion));
        this.SetAttributeValue("processversion", (object) value);
        this.OnPropertyChanged(nameof (ProcessVersion));
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

    [AttributeLogicalName("statecode")]
    public flowsessionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new flowsessionState?((flowsessionState) Enum.ToObject(typeof (flowsessionState), attributeValue.Value)) : new flowsessionState?();
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

    [RelationshipSchemaName("flowsession_AsyncOperations")]
    public IEnumerable<AsyncOperation> flowsession_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (flowsession_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (flowsession_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_AsyncOperations));
      }
    }

    [RelationshipSchemaName("flowsession_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> flowsession_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (flowsession_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (flowsession_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("flowsession_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> flowsession_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (flowsession_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (flowsession_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("flowsession_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> flowsession_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (flowsession_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (flowsession_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("flowsession_SyncErrors")]
    public IEnumerable<SyncError> flowsession_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (flowsession_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (flowsession_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (flowsession_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_SyncErrors));
      }
    }

    [RelationshipSchemaName("flowsession_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> flowsession_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (flowsession_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (flowsession_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("flowsession_workflowbinary_FlowSessionId")]
    public IEnumerable<workflowbinary> flowsession_workflowbinary_FlowSessionId
    {
      get
      {
        return this.GetRelatedEntities<workflowbinary>(nameof (flowsession_workflowbinary_FlowSessionId), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_workflowbinary_FlowSessionId));
        this.SetRelatedEntities<workflowbinary>(nameof (flowsession_workflowbinary_FlowSessionId), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_workflowbinary_FlowSessionId));
      }
    }

    [RelationshipSchemaName("lk_workflowlog_flowsession_childworkflow")]
    public IEnumerable<WorkflowLog> lk_workflowlog_flowsession_childworkflow
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_flowsession_childworkflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_flowsession_childworkflow));
        this.SetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_flowsession_childworkflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_flowsession_childworkflow));
      }
    }

    [RelationshipSchemaName("lk_workflowlog_flowsessions")]
    public IEnumerable<WorkflowLog> lk_workflowlog_flowsessions
    {
      get
      {
        return this.GetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_flowsessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowlog_flowsessions));
        this.SetRelatedEntities<WorkflowLog>(nameof (lk_workflowlog_flowsessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowlog_flowsessions));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_flowsession")]
    public BusinessUnit business_unit_flowsession
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_flowsession), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_flowsession_createdby")]
    public SystemUser lk_flowsession_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_flowsession_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_flowsession_createdonbehalfby")]
    public SystemUser lk_flowsession_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_flowsession_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_flowsession_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_flowsession_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_flowsession_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_flowsession_modifiedby")]
    public SystemUser lk_flowsession_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_flowsession_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_flowsession_modifiedonbehalfby")]
    public SystemUser lk_flowsession_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_flowsession_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_flowsession_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_flowsession_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_flowsession_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("regardingobjectid_process")]
    public Workflow regardingobjectid_process
    {
      get => this.GetRelatedEntity<Workflow>(nameof (regardingobjectid_process), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (regardingobjectid_process));
        this.SetRelatedEntity<Workflow>(nameof (regardingobjectid_process), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (regardingobjectid_process));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_flowsession")]
    public Team team_flowsession
    {
      get => this.GetRelatedEntity<Team>(nameof (team_flowsession), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_flowsession")]
    public SystemUser user_flowsession
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_flowsession), new EntityRole?());
    }

    public flowsession(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["flowsessionid"] = (object) base.Id;
            break;
          case "flowsessionid":
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
