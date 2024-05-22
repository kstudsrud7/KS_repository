// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AITemplate
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aitemplate")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AITemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aitemplate";
    public const string EntitySchemaName = "msdyn_AITemplate";
    public const string PrimaryIdAttribute = "msdyn_aitemplateid";
    public const string PrimaryNameAttribute = "msdyn_uniquename";

    public msdyn_AITemplate()
      : base("msdyn_aitemplate")
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

    [AttributeLogicalName("msdyn_aitemplateid")]
    public Guid? msdyn_AITemplateId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aitemplateid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AITemplateId));
        this.SetAttributeValue("msdyn_aitemplateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AITemplateId));
      }
    }

    [AttributeLogicalName("msdyn_aitemplateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AITemplateId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_aitemplateidunique")]
    public Guid? msdyn_AITemplateIdUnique
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aitemplateidunique");
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

    [AttributeLogicalName("msdyn_defaultrunschedulingoptions")]
    public string msdyn_defaultrunschedulingoptions
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_defaultrunschedulingoptions));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_defaultrunschedulingoptions));
        this.SetAttributeValue(nameof (msdyn_defaultrunschedulingoptions), (object) value);
        this.OnPropertyChanged(nameof (msdyn_defaultrunschedulingoptions));
      }
    }

    [AttributeLogicalName("msdyn_istrainable")]
    public bool? msdyn_IsTrainable
    {
      get => this.GetAttributeValue<bool?>("msdyn_istrainable");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_IsTrainable));
        this.SetAttributeValue("msdyn_istrainable", (object) value);
        this.OnPropertyChanged(nameof (msdyn_IsTrainable));
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

    [AttributeLogicalName("msdyn_runconfigschema")]
    public string msdyn_RunConfigSchema
    {
      get => this.GetAttributeValue<string>("msdyn_runconfigschema");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RunConfigSchema));
        this.SetAttributeValue("msdyn_runconfigschema", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RunConfigSchema));
      }
    }

    [AttributeLogicalName("msdyn_rundataspecification")]
    public string msdyn_RunDataSpecification
    {
      get => this.GetAttributeValue<string>("msdyn_rundataspecification");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RunDataSpecification));
        this.SetAttributeValue("msdyn_rundataspecification", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RunDataSpecification));
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

    [AttributeLogicalName("msdyn_trainingconfigschema")]
    public string msdyn_TrainingConfigSchema
    {
      get => this.GetAttributeValue<string>("msdyn_trainingconfigschema");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_TrainingConfigSchema));
        this.SetAttributeValue("msdyn_trainingconfigschema", (object) value);
        this.OnPropertyChanged(nameof (msdyn_TrainingConfigSchema));
      }
    }

    [AttributeLogicalName("msdyn_trainingdataspecification")]
    public string msdyn_TrainingDataSpecification
    {
      get => this.GetAttributeValue<string>("msdyn_trainingdataspecification");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_TrainingDataSpecification));
        this.SetAttributeValue("msdyn_trainingdataspecification", (object) value);
        this.OnPropertyChanged(nameof (msdyn_TrainingDataSpecification));
      }
    }

    [AttributeLogicalName("msdyn_uniquename")]
    public string msdyn_UniqueName
    {
      get => this.GetAttributeValue<string>("msdyn_uniquename");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_UniqueName));
        this.SetAttributeValue("msdyn_uniquename", (object) value);
        this.OnPropertyChanged(nameof (msdyn_UniqueName));
      }
    }

    [AttributeLogicalName("msdyn_uxconfiguration")]
    public string msdyn_UXConfiguration
    {
      get => this.GetAttributeValue<string>("msdyn_uxconfiguration");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_UXConfiguration));
        this.SetAttributeValue("msdyn_uxconfiguration", (object) value);
        this.OnPropertyChanged(nameof (msdyn_UXConfiguration));
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
    public msdyn_AITemplateState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AITemplateState?((msdyn_AITemplateState) Enum.ToObject(typeof (msdyn_AITemplateState), attributeValue.Value)) : new msdyn_AITemplateState?();
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

    [RelationshipSchemaName("msdyn_aitemplate_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aitemplate_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aitemplate_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aitemplate_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aitemplate_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aitemplate_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aitemplate_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aitemplate_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aitemplate_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aitemplate_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aitemplate_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aitemplate_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aitemplate_msdyn_aimodel")]
    public IEnumerable<msdyn_AIModel> msdyn_aitemplate_msdyn_aimodel
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIModel>(nameof (msdyn_aitemplate_msdyn_aimodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_msdyn_aimodel));
        this.SetRelatedEntities<msdyn_AIModel>(nameof (msdyn_aitemplate_msdyn_aimodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_msdyn_aimodel));
      }
    }

    [RelationshipSchemaName("msdyn_aitemplate_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aitemplate_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aitemplate_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aitemplate_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aitemplate_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aitemplate_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aitemplate_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aitemplate_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aitemplate_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aitemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aitemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aitemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aitemplate_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aitemplate_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aitemplate_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aitemplate_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aitemplate")]
    public BusinessUnit business_unit_msdyn_aitemplate
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aitemplate), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aitemplate_createdby")]
    public SystemUser lk_msdyn_aitemplate_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aitemplate_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aitemplate_createdonbehalfby")]
    public SystemUser lk_msdyn_aitemplate_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aitemplate_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aitemplate_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aitemplate_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aitemplate_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aitemplate_modifiedby")]
    public SystemUser lk_msdyn_aitemplate_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aitemplate_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aitemplate_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aitemplate_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aitemplate_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aitemplate_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aitemplate_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aitemplate_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aitemplate")]
    public Team team_msdyn_aitemplate
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aitemplate), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aitemplate")]
    public SystemUser user_msdyn_aitemplate
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aitemplate), new EntityRole?());
    }

    public msdyn_AITemplate(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aitemplateid"] = (object) base.Id;
            break;
          case "msdyn_aitemplateid":
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
