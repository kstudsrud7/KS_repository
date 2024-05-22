// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CustomAPI
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("customapi")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CustomAPI : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "customapi";
    public const string EntitySchemaName = "CustomAPI";
    public const string PrimaryIdAttribute = "customapiid";
    public const string PrimaryNameAttribute = "name";

    public CustomAPI()
      : base("customapi")
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

    [AttributeLogicalName("allowedcustomprocessingsteptype")]
    public OptionSetValue AllowedCustomProcessingStepType
    {
      get => this.GetAttributeValue<OptionSetValue>("allowedcustomprocessingsteptype");
      set
      {
        this.OnPropertyChanging(nameof (AllowedCustomProcessingStepType));
        this.SetAttributeValue("allowedcustomprocessingsteptype", (object) value);
        this.OnPropertyChanged(nameof (AllowedCustomProcessingStepType));
      }
    }

    [AttributeLogicalName("bindingtype")]
    public OptionSetValue BindingType
    {
      get => this.GetAttributeValue<OptionSetValue>("bindingtype");
      set
      {
        this.OnPropertyChanging(nameof (BindingType));
        this.SetAttributeValue("bindingtype", (object) value);
        this.OnPropertyChanged(nameof (BindingType));
      }
    }

    [AttributeLogicalName("boundentitylogicalname")]
    public string BoundEntityLogicalName
    {
      get => this.GetAttributeValue<string>("boundentitylogicalname");
      set
      {
        this.OnPropertyChanging(nameof (BoundEntityLogicalName));
        this.SetAttributeValue("boundentitylogicalname", (object) value);
        this.OnPropertyChanged(nameof (BoundEntityLogicalName));
      }
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

    [AttributeLogicalName("customapiid")]
    public Guid? CustomAPIId
    {
      get => this.GetAttributeValue<Guid?>("customapiid");
      set
      {
        this.OnPropertyChanging(nameof (CustomAPIId));
        this.SetAttributeValue("customapiid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CustomAPIId));
      }
    }

    [AttributeLogicalName("customapiid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CustomAPIId = new Guid?(value);
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

    [AttributeLogicalName("displayname")]
    public string DisplayName
    {
      get => this.GetAttributeValue<string>("displayname");
      set
      {
        this.OnPropertyChanging(nameof (DisplayName));
        this.SetAttributeValue("displayname", (object) value);
        this.OnPropertyChanged(nameof (DisplayName));
      }
    }

    [AttributeLogicalName("executeprivilegename")]
    public string ExecutePrivilegeName
    {
      get => this.GetAttributeValue<string>("executeprivilegename");
      set
      {
        this.OnPropertyChanging(nameof (ExecutePrivilegeName));
        this.SetAttributeValue("executeprivilegename", (object) value);
        this.OnPropertyChanged(nameof (ExecutePrivilegeName));
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

    [AttributeLogicalName("isfunction")]
    public bool? IsFunction
    {
      get => this.GetAttributeValue<bool?>("isfunction");
      set
      {
        this.OnPropertyChanging(nameof (IsFunction));
        this.SetAttributeValue("isfunction", (object) value);
        this.OnPropertyChanged(nameof (IsFunction));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isprivate")]
    public bool? IsPrivate
    {
      get => this.GetAttributeValue<bool?>("isprivate");
      set
      {
        this.OnPropertyChanging(nameof (IsPrivate));
        this.SetAttributeValue("isprivate", (object) value);
        this.OnPropertyChanged(nameof (IsPrivate));
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

    [AttributeLogicalName("plugintypeid")]
    public EntityReference PluginTypeId
    {
      get => this.GetAttributeValue<EntityReference>("plugintypeid");
      set
      {
        this.OnPropertyChanging(nameof (PluginTypeId));
        this.SetAttributeValue("plugintypeid", (object) value);
        this.OnPropertyChanged(nameof (PluginTypeId));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public EntityReference SdkMessageId
    {
      get => this.GetAttributeValue<EntityReference>("sdkmessageid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageId));
        this.SetAttributeValue("sdkmessageid", (object) value);
        this.OnPropertyChanged(nameof (SdkMessageId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public CustomAPIState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new CustomAPIState?((CustomAPIState) Enum.ToObject(typeof (CustomAPIState), attributeValue.Value)) : new CustomAPIState?();
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

    [RelationshipSchemaName("catalogassignment_customapi")]
    public IEnumerable<CatalogAssignment> catalogassignment_customapi
    {
      get
      {
        return this.GetRelatedEntities<CatalogAssignment>(nameof (catalogassignment_customapi), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_customapi));
        this.SetRelatedEntities<CatalogAssignment>(nameof (catalogassignment_customapi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_customapi));
      }
    }

    [RelationshipSchemaName("customapi_AsyncOperations")]
    public IEnumerable<AsyncOperation> customapi_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (customapi_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (customapi_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_AsyncOperations));
      }
    }

    [RelationshipSchemaName("customapi_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> customapi_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (customapi_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (customapi_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("customapi_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> customapi_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (customapi_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (customapi_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("customapi_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> customapi_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (customapi_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (customapi_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("customapi_ProcessSession")]
    public IEnumerable<ProcessSession> customapi_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (customapi_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (customapi_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_ProcessSession));
      }
    }

    [RelationshipSchemaName("customapi_SyncErrors")]
    public IEnumerable<SyncError> customapi_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (customapi_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (customapi_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (customapi_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_SyncErrors));
      }
    }

    [RelationshipSchemaName("customapi_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> customapi_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (customapi_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (customapi_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_customapi")]
    public BusinessUnit business_unit_customapi
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_customapi), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_customapi_createdby")]
    public SystemUser lk_customapi_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_customapi_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_customapi_createdonbehalfby")]
    public SystemUser lk_customapi_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customapi_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_customapi_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_customapi_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_customapi_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_customapi_modifiedby")]
    public SystemUser lk_customapi_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_customapi_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_customapi_modifiedonbehalfby")]
    public SystemUser lk_customapi_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customapi_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_customapi_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_customapi_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_customapi_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("plugintypeid")]
    [RelationshipSchemaName("plugintype_customapi")]
    public PluginType plugintype_customapi
    {
      get => this.GetRelatedEntity<PluginType>(nameof (plugintype_customapi), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (plugintype_customapi));
        this.SetRelatedEntity<PluginType>(nameof (plugintype_customapi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (plugintype_customapi));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    [RelationshipSchemaName("sdkmessage_customapi")]
    public SdkMessage sdkmessage_customapi
    {
      get => this.GetRelatedEntity<SdkMessage>(nameof (sdkmessage_customapi), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sdkmessage_customapi));
        this.SetRelatedEntity<SdkMessage>(nameof (sdkmessage_customapi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessage_customapi));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_customapi")]
    public Team team_customapi
    {
      get => this.GetRelatedEntity<Team>(nameof (team_customapi), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_customapi")]
    public SystemUser user_customapi
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_customapi), new EntityRole?());
    }

    public CustomAPI(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["customapiid"] = (object) base.Id;
            break;
          case "customapiid":
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
