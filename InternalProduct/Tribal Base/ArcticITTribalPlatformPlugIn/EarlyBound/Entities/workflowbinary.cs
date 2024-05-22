// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.workflowbinary
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("workflowbinary")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class workflowbinary : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "workflowbinary";
    public const string EntitySchemaName = "workflowbinary";
    public const string PrimaryIdAttribute = "workflowbinaryid";
    public const string PrimaryNameAttribute = "name";

    public workflowbinary()
      : base(nameof (workflowbinary))
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

    [AttributeLogicalName("flowsessionid")]
    public EntityReference FlowSessionId
    {
      get => this.GetAttributeValue<EntityReference>("flowsessionid");
      set
      {
        this.OnPropertyChanging(nameof (FlowSessionId));
        this.SetAttributeValue("flowsessionid", (object) value);
        this.OnPropertyChanged(nameof (FlowSessionId));
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

    [AttributeLogicalName("metadata")]
    public string Metadata
    {
      get => this.GetAttributeValue<string>("metadata");
      set
      {
        this.OnPropertyChanging(nameof (Metadata));
        this.SetAttributeValue("metadata", (object) value);
        this.OnPropertyChanged(nameof (Metadata));
      }
    }

    [AttributeLogicalName("mimetype")]
    public string MimeType
    {
      get => this.GetAttributeValue<string>("mimetype");
      set
      {
        this.OnPropertyChanging(nameof (MimeType));
        this.SetAttributeValue("mimetype", (object) value);
        this.OnPropertyChanged(nameof (MimeType));
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
    public string name
    {
      get => this.GetAttributeValue<string>(nameof (name));
      set
      {
        this.OnPropertyChanging(nameof (name));
        this.SetAttributeValue(nameof (name), (object) value);
        this.OnPropertyChanged(nameof (name));
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

    [AttributeLogicalName("process")]
    public EntityReference Process
    {
      get => this.GetAttributeValue<EntityReference>("process");
      set
      {
        this.OnPropertyChanging(nameof (Process));
        this.SetAttributeValue("process", (object) value);
        this.OnPropertyChanged(nameof (Process));
      }
    }

    [AttributeLogicalName("referencename")]
    public string ReferenceName
    {
      get => this.GetAttributeValue<string>("referencename");
      set
      {
        this.OnPropertyChanging(nameof (ReferenceName));
        this.SetAttributeValue("referencename", (object) value);
        this.OnPropertyChanged(nameof (ReferenceName));
      }
    }

    [AttributeLogicalName("statecode")]
    public workflowbinaryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new workflowbinaryState?((workflowbinaryState) Enum.ToObject(typeof (workflowbinaryState), attributeValue.Value)) : new workflowbinaryState?();
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

    [AttributeLogicalName("type")]
    public string Type
    {
      get => this.GetAttributeValue<string>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
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

    [AttributeLogicalName("workflowbinaryid")]
    public Guid? workflowbinaryId
    {
      get => this.GetAttributeValue<Guid?>("workflowbinaryid");
      set
      {
        this.OnPropertyChanging(nameof (workflowbinaryId));
        this.SetAttributeValue("workflowbinaryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (workflowbinaryId));
      }
    }

    [AttributeLogicalName("workflowbinaryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.workflowbinaryId = new Guid?(value);
    }

    [RelationshipSchemaName("workflowbinary_AsyncOperations")]
    public IEnumerable<AsyncOperation> workflowbinary_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (workflowbinary_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (workflowbinary_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_AsyncOperations));
      }
    }

    [RelationshipSchemaName("workflowbinary_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> workflowbinary_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (workflowbinary_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (workflowbinary_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("workflowbinary_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> workflowbinary_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (workflowbinary_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (workflowbinary_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("workflowbinary_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> workflowbinary_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (workflowbinary_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (workflowbinary_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("workflowbinary_ProcessSession")]
    public IEnumerable<ProcessSession> workflowbinary_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (workflowbinary_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (workflowbinary_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_ProcessSession));
      }
    }

    [RelationshipSchemaName("workflowbinary_SyncErrors")]
    public IEnumerable<SyncError> workflowbinary_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (workflowbinary_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (workflowbinary_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_SyncErrors));
      }
    }

    [RelationshipSchemaName("workflowbinary_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> workflowbinary_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (workflowbinary_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (workflowbinary_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_workflowbinary")]
    public BusinessUnit business_unit_workflowbinary
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_workflowbinary), new EntityRole?());
      }
    }

    [AttributeLogicalName("flowsessionid")]
    [RelationshipSchemaName("flowsession_workflowbinary_FlowSessionId")]
    public flowsession flowsession_workflowbinary_FlowSessionId
    {
      get
      {
        return this.GetRelatedEntity<flowsession>(nameof (flowsession_workflowbinary_FlowSessionId), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_workflowbinary_FlowSessionId));
        this.SetRelatedEntity<flowsession>(nameof (flowsession_workflowbinary_FlowSessionId), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_workflowbinary_FlowSessionId));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_workflowbinary_createdby")]
    public SystemUser lk_workflowbinary_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_workflowbinary_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_workflowbinary_createdonbehalfby")]
    public SystemUser lk_workflowbinary_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_workflowbinary_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowbinary_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_workflowbinary_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowbinary_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_workflowbinary_modifiedby")]
    public SystemUser lk_workflowbinary_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_workflowbinary_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_workflowbinary_modifiedonbehalfby")]
    public SystemUser lk_workflowbinary_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_workflowbinary_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_workflowbinary_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_workflowbinary_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_workflowbinary_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_workflowbinary")]
    public Team team_workflowbinary
    {
      get => this.GetRelatedEntity<Team>(nameof (team_workflowbinary), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_workflowbinary")]
    public SystemUser user_workflowbinary
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_workflowbinary), new EntityRole?());
    }

    [AttributeLogicalName("process")]
    [RelationshipSchemaName("workflow_workflowbinary_Process")]
    public Workflow workflow_workflowbinary_Process
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (workflow_workflowbinary_Process), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflow_workflowbinary_Process));
        this.SetRelatedEntity<Workflow>(nameof (workflow_workflowbinary_Process), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflow_workflowbinary_Process));
      }
    }

    public workflowbinary(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["workflowbinaryid"] = (object) base.Id;
            break;
          case "workflowbinaryid":
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
