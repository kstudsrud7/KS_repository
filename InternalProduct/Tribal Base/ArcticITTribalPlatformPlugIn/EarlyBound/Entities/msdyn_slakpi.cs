// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_slakpi
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_slakpi")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_slakpi : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_slakpi";
    public const string EntitySchemaName = "msdyn_slakpi";
    public const string PrimaryIdAttribute = "msdyn_slakpiid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_slakpi()
      : base(nameof (msdyn_slakpi))
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

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

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

    [AttributeLogicalName("msdyn_advancedpauseconfiguration")]
    public bool? msdyn_AdvancedPauseConfiguration
    {
      get => this.GetAttributeValue<bool?>("msdyn_advancedpauseconfiguration");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AdvancedPauseConfiguration));
        this.SetAttributeValue("msdyn_advancedpauseconfiguration", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AdvancedPauseConfiguration));
      }
    }

    [AttributeLogicalName("msdyn_applicablefromdisplayname")]
    public string msdyn_ApplicableFromDisplayName
    {
      get => this.GetAttributeValue<string>("msdyn_applicablefromdisplayname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ApplicableFromDisplayName));
        this.SetAttributeValue("msdyn_applicablefromdisplayname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ApplicableFromDisplayName));
      }
    }

    [AttributeLogicalName("msdyn_applicablefromfield")]
    public string msdyn_ApplicableFromField
    {
      get => this.GetAttributeValue<string>("msdyn_applicablefromfield");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ApplicableFromField));
        this.SetAttributeValue("msdyn_applicablefromfield", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ApplicableFromField));
      }
    }

    [AttributeLogicalName("msdyn_description")]
    public string msdyn_Description
    {
      get => this.GetAttributeValue<string>("msdyn_description");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Description));
        this.SetAttributeValue("msdyn_description", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Description));
      }
    }

    [AttributeLogicalName("msdyn_entitydisplayname")]
    public string msdyn_EntityDisplayName
    {
      get => this.GetAttributeValue<string>("msdyn_entitydisplayname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_EntityDisplayName));
        this.SetAttributeValue("msdyn_entitydisplayname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_EntityDisplayName));
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

    [AttributeLogicalName("msdyn_kpifield")]
    public string msdyn_KPIField
    {
      get => this.GetAttributeValue<string>("msdyn_kpifield");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_KPIField));
        this.SetAttributeValue("msdyn_kpifield", (object) value);
        this.OnPropertyChanged(nameof (msdyn_KPIField));
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

    [AttributeLogicalName("msdyn_pauseconfigurationxml")]
    public string msdyn_PauseConfigurationXml
    {
      get => this.GetAttributeValue<string>("msdyn_pauseconfigurationxml");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_PauseConfigurationXml));
        this.SetAttributeValue("msdyn_pauseconfigurationxml", (object) value);
        this.OnPropertyChanged(nameof (msdyn_PauseConfigurationXml));
      }
    }

    [AttributeLogicalName("msdyn_slakpiid")]
    public Guid? msdyn_slakpiId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_slakpiid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpiId));
        this.SetAttributeValue("msdyn_slakpiid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_slakpiId));
      }
    }

    [AttributeLogicalName("msdyn_slakpiid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_slakpiId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_workflowinfo")]
    public string msdyn_WorkflowInfo
    {
      get => this.GetAttributeValue<string>("msdyn_workflowinfo");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_WorkflowInfo));
        this.SetAttributeValue("msdyn_workflowinfo", (object) value);
        this.OnPropertyChanged(nameof (msdyn_WorkflowInfo));
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
    public msdyn_slakpiState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_slakpiState?((msdyn_slakpiState) Enum.ToObject(typeof (msdyn_slakpiState), attributeValue.Value)) : new msdyn_slakpiState?();
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

    [RelationshipSchemaName("msdyn_msdyn_slakpi_slaitem")]
    public IEnumerable<SLAItem> msdyn_msdyn_slakpi_slaitem
    {
      get
      {
        return this.GetRelatedEntities<SLAItem>(nameof (msdyn_msdyn_slakpi_slaitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_slakpi_slaitem));
        this.SetRelatedEntities<SLAItem>(nameof (msdyn_msdyn_slakpi_slaitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_slakpi_slaitem));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_slakpi_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_slakpi_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_slakpi_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_slakpi_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_slakpi_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_slakpi_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_slakpi_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_slakpi_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_slakpi_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_slakpi_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_slakpi_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_slakpi_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_slakpi_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_slakpi_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_slakpi_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_slakpi_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_slakpi_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_slakpi_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_slakpi_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_slakpi_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_slakpi_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_SyncErrors")]
    public IEnumerable<SyncError> msdyn_slakpi_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_slakpi_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_slakpi_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_slakpi_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_slakpi_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_slakpi_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_slakpi_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_slakpi")]
    public BusinessUnit business_unit_msdyn_slakpi
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_slakpi), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_slakpi_createdby")]
    public SystemUser lk_msdyn_slakpi_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_slakpi_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_slakpi_createdonbehalfby")]
    public SystemUser lk_msdyn_slakpi_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_slakpi_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_slakpi_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_slakpi_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_slakpi_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_slakpi_modifiedby")]
    public SystemUser lk_msdyn_slakpi_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_slakpi_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_slakpi_modifiedonbehalfby")]
    public SystemUser lk_msdyn_slakpi_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_slakpi_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_slakpi_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_slakpi_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_slakpi_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_slakpi")]
    public Team team_msdyn_slakpi
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_slakpi), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_slakpi")]
    public SystemUser user_msdyn_slakpi
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_slakpi), new EntityRole?());
    }

    public msdyn_slakpi(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_slakpiid"] = (object) base.Id;
            break;
          case "msdyn_slakpiid":
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
