// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.mbs_pluginprofile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mbs_pluginprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class mbs_pluginprofile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mbs_pluginprofile";
    public const string EntitySchemaName = "mbs_pluginprofile";
    public const string PrimaryIdAttribute = "mbs_pluginprofileid";
    public const string PrimaryNameAttribute = "mbs_label";

    public mbs_pluginprofile()
      : base(nameof (mbs_pluginprofile))
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

    [AttributeLogicalName("mbs_businessunitid")]
    public EntityReference mbs_BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("mbs_businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (mbs_BusinessUnitId));
        this.SetAttributeValue("mbs_businessunitid", (object) value);
        this.OnPropertyChanged(nameof (mbs_BusinessUnitId));
      }
    }

    [AttributeLogicalName("mbs_configuration")]
    public string mbs_Configuration
    {
      get => this.GetAttributeValue<string>("mbs_configuration");
      set
      {
        this.OnPropertyChanging(nameof (mbs_Configuration));
        this.SetAttributeValue("mbs_configuration", (object) value);
        this.OnPropertyChanged(nameof (mbs_Configuration));
      }
    }

    [AttributeLogicalName("mbs_correlationid")]
    public string mbs_CorrelationId
    {
      get => this.GetAttributeValue<string>("mbs_correlationid");
      set
      {
        this.OnPropertyChanging(nameof (mbs_CorrelationId));
        this.SetAttributeValue("mbs_correlationid", (object) value);
        this.OnPropertyChanged(nameof (mbs_CorrelationId));
      }
    }

    [AttributeLogicalName("mbs_depth")]
    public int? mbs_Depth
    {
      get => this.GetAttributeValue<int?>("mbs_depth");
      set
      {
        this.OnPropertyChanging(nameof (mbs_Depth));
        this.SetAttributeValue("mbs_depth", (object) value);
        this.OnPropertyChanged(nameof (mbs_Depth));
      }
    }

    [AttributeLogicalName("mbs_initiatinguserid")]
    public EntityReference mbs_InitiatingUserId
    {
      get => this.GetAttributeValue<EntityReference>("mbs_initiatinguserid");
      set
      {
        this.OnPropertyChanging(nameof (mbs_InitiatingUserId));
        this.SetAttributeValue("mbs_initiatinguserid", (object) value);
        this.OnPropertyChanged(nameof (mbs_InitiatingUserId));
      }
    }

    [AttributeLogicalName("mbs_label")]
    public string mbs_label
    {
      get => this.GetAttributeValue<string>(nameof (mbs_label));
      set
      {
        this.OnPropertyChanging(nameof (mbs_label));
        this.SetAttributeValue(nameof (mbs_label), (object) value);
        this.OnPropertyChanged(nameof (mbs_label));
      }
    }

    [AttributeLogicalName("mbs_messagename")]
    public string mbs_MessageName
    {
      get => this.GetAttributeValue<string>("mbs_messagename");
      set
      {
        this.OnPropertyChanging(nameof (mbs_MessageName));
        this.SetAttributeValue("mbs_messagename", (object) value);
        this.OnPropertyChanged(nameof (mbs_MessageName));
      }
    }

    [AttributeLogicalName("mbs_mode")]
    public OptionSetValue mbs_mode
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (mbs_mode));
      set
      {
        this.OnPropertyChanging(nameof (mbs_mode));
        this.SetAttributeValue(nameof (mbs_mode), (object) value);
        this.OnPropertyChanged(nameof (mbs_mode));
      }
    }

    [AttributeLogicalName("mbs_operationtype")]
    public OptionSetValue mbs_OperationType
    {
      get => this.GetAttributeValue<OptionSetValue>("mbs_operationtype");
      set
      {
        this.OnPropertyChanging(nameof (mbs_OperationType));
        this.SetAttributeValue("mbs_operationtype", (object) value);
        this.OnPropertyChanged(nameof (mbs_OperationType));
      }
    }

    [AttributeLogicalName("mbs_performanceconstructorduration")]
    public int? mbs_PerformanceConstructorDuration
    {
      get => this.GetAttributeValue<int?>("mbs_performanceconstructorduration");
      set
      {
        this.OnPropertyChanging(nameof (mbs_PerformanceConstructorDuration));
        this.SetAttributeValue("mbs_performanceconstructorduration", (object) value);
        this.OnPropertyChanged(nameof (mbs_PerformanceConstructorDuration));
      }
    }

    [AttributeLogicalName("mbs_performanceconstructorstarttime")]
    public DateTime? mbs_PerformanceConstructorStartTime
    {
      get => this.GetAttributeValue<DateTime?>("mbs_performanceconstructorstarttime");
      set
      {
        this.OnPropertyChanging(nameof (mbs_PerformanceConstructorStartTime));
        this.SetAttributeValue("mbs_performanceconstructorstarttime", (object) value);
        this.OnPropertyChanged(nameof (mbs_PerformanceConstructorStartTime));
      }
    }

    [AttributeLogicalName("mbs_performanceexecutionduration")]
    public int? mbs_PerformanceExecutionDuration
    {
      get => this.GetAttributeValue<int?>("mbs_performanceexecutionduration");
      set
      {
        this.OnPropertyChanging(nameof (mbs_PerformanceExecutionDuration));
        this.SetAttributeValue("mbs_performanceexecutionduration", (object) value);
        this.OnPropertyChanged(nameof (mbs_PerformanceExecutionDuration));
      }
    }

    [AttributeLogicalName("mbs_performanceexecutionstarttime")]
    public DateTime? mbs_PerformanceExecutionStartTime
    {
      get => this.GetAttributeValue<DateTime?>("mbs_performanceexecutionstarttime");
      set
      {
        this.OnPropertyChanging(nameof (mbs_PerformanceExecutionStartTime));
        this.SetAttributeValue("mbs_performanceexecutionstarttime", (object) value);
        this.OnPropertyChanged(nameof (mbs_PerformanceExecutionStartTime));
      }
    }

    [AttributeLogicalName("mbs_persistencekey")]
    public string mbs_PersistenceKey
    {
      get => this.GetAttributeValue<string>("mbs_persistencekey");
      set
      {
        this.OnPropertyChanging(nameof (mbs_PersistenceKey));
        this.SetAttributeValue("mbs_persistencekey", (object) value);
        this.OnPropertyChanged(nameof (mbs_PersistenceKey));
      }
    }

    [AttributeLogicalName("mbs_pluginprofileid")]
    public Guid? mbs_pluginprofileId
    {
      get => this.GetAttributeValue<Guid?>("mbs_pluginprofileid");
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofileId));
        this.SetAttributeValue("mbs_pluginprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (mbs_pluginprofileId));
      }
    }

    [AttributeLogicalName("mbs_pluginprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.mbs_pluginprofileId = new Guid?(value);
    }

    [AttributeLogicalName("mbs_primaryentity")]
    public string mbs_PrimaryEntity
    {
      get => this.GetAttributeValue<string>("mbs_primaryentity");
      set
      {
        this.OnPropertyChanging(nameof (mbs_PrimaryEntity));
        this.SetAttributeValue("mbs_primaryentity", (object) value);
        this.OnPropertyChanged(nameof (mbs_PrimaryEntity));
      }
    }

    [AttributeLogicalName("mbs_profile")]
    public string mbs_Profile
    {
      get => this.GetAttributeValue<string>("mbs_profile");
      set
      {
        this.OnPropertyChanging(nameof (mbs_Profile));
        this.SetAttributeValue("mbs_profile", (object) value);
        this.OnPropertyChanged(nameof (mbs_Profile));
      }
    }

    [AttributeLogicalName("mbs_requestid")]
    public string mbs_RequestId
    {
      get => this.GetAttributeValue<string>("mbs_requestid");
      set
      {
        this.OnPropertyChanging(nameof (mbs_RequestId));
        this.SetAttributeValue("mbs_requestid", (object) value);
        this.OnPropertyChanged(nameof (mbs_RequestId));
      }
    }

    [AttributeLogicalName("mbs_secureconfiguration")]
    public string mbs_SecureConfiguration
    {
      get => this.GetAttributeValue<string>("mbs_secureconfiguration");
      set
      {
        this.OnPropertyChanging(nameof (mbs_SecureConfiguration));
        this.SetAttributeValue("mbs_secureconfiguration", (object) value);
        this.OnPropertyChanged(nameof (mbs_SecureConfiguration));
      }
    }

    [AttributeLogicalName("mbs_typename")]
    public string mbs_typename
    {
      get => this.GetAttributeValue<string>(nameof (mbs_typename));
      set
      {
        this.OnPropertyChanging(nameof (mbs_typename));
        this.SetAttributeValue(nameof (mbs_typename), (object) value);
        this.OnPropertyChanged(nameof (mbs_typename));
      }
    }

    [AttributeLogicalName("mbs_workflowstepid")]
    public string mbs_WorkflowStepId
    {
      get => this.GetAttributeValue<string>("mbs_workflowstepid");
      set
      {
        this.OnPropertyChanging(nameof (mbs_WorkflowStepId));
        this.SetAttributeValue("mbs_workflowstepid", (object) value);
        this.OnPropertyChanged(nameof (mbs_WorkflowStepId));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("statecode")]
    public mbs_pluginprofileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new mbs_pluginprofileState?((mbs_pluginprofileState) Enum.ToObject(typeof (mbs_pluginprofileState), attributeValue.Value)) : new mbs_pluginprofileState?();
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

    [RelationshipSchemaName("mbs_pluginprofile_AsyncOperations")]
    public IEnumerable<AsyncOperation> mbs_pluginprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (mbs_pluginprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (mbs_pluginprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("mbs_pluginprofile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> mbs_pluginprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (mbs_pluginprofile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (mbs_pluginprofile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("mbs_pluginprofile_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> mbs_pluginprofile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (mbs_pluginprofile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (mbs_pluginprofile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("mbs_pluginprofile_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> mbs_pluginprofile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (mbs_pluginprofile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (mbs_pluginprofile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("mbs_pluginprofile_ProcessSession")]
    public IEnumerable<ProcessSession> mbs_pluginprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (mbs_pluginprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (mbs_pluginprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_ProcessSession));
      }
    }

    [RelationshipSchemaName("mbs_pluginprofile_SyncErrors")]
    public IEnumerable<SyncError> mbs_pluginprofile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (mbs_pluginprofile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (mbs_pluginprofile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_SyncErrors));
      }
    }

    [RelationshipSchemaName("mbs_pluginprofile_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> mbs_pluginprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (mbs_pluginprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (mbs_pluginprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_mbs_pluginprofile_createdby")]
    public SystemUser lk_mbs_pluginprofile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mbs_pluginprofile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_mbs_pluginprofile_createdonbehalfby")]
    public SystemUser lk_mbs_pluginprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mbs_pluginprofile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mbs_pluginprofile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mbs_pluginprofile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mbs_pluginprofile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_mbs_pluginprofile_modifiedby")]
    public SystemUser lk_mbs_pluginprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mbs_pluginprofile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_mbs_pluginprofile_modifiedonbehalfby")]
    public SystemUser lk_mbs_pluginprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mbs_pluginprofile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mbs_pluginprofile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mbs_pluginprofile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mbs_pluginprofile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("mbs_businessunitid")]
    [RelationshipSchemaName("mbs_businessunit_mbs_pluginprofile")]
    public BusinessUnit mbs_businessunit_mbs_pluginprofile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (mbs_businessunit_mbs_pluginprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_businessunit_mbs_pluginprofile));
        this.SetRelatedEntity<BusinessUnit>(nameof (mbs_businessunit_mbs_pluginprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_businessunit_mbs_pluginprofile));
      }
    }

    [AttributeLogicalName("mbs_initiatinguserid")]
    [RelationshipSchemaName("mbs_systemuser_mbs_pluginprofile")]
    public SystemUser mbs_systemuser_mbs_pluginprofile
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (mbs_systemuser_mbs_pluginprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_systemuser_mbs_pluginprofile));
        this.SetRelatedEntity<SystemUser>(nameof (mbs_systemuser_mbs_pluginprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_systemuser_mbs_pluginprofile));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_mbs_pluginprofile")]
    public Organization organization_mbs_pluginprofile
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_mbs_pluginprofile), new EntityRole?());
      }
    }

    public mbs_pluginprofile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mbs_pluginprofileid"] = (object) base.Id;
            break;
          case "mbs_pluginprofileid":
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
