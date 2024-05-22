// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_serviceconfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_serviceconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_serviceconfiguration : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_serviceconfiguration";
    public const string EntitySchemaName = "msdyn_serviceconfiguration";
    public const string PrimaryIdAttribute = "msdyn_serviceconfigurationid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_serviceconfiguration()
      : base(nameof (msdyn_serviceconfiguration))
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

    [AttributeLogicalName("msdyn_entitylogicalname")]
    public string msdyn_EntityLogicalName
    {
      get => this.GetAttributeValue<string>("msdyn_entitylogicalname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_EntityLogicalName));
        this.SetAttributeValue("msdyn_entitylogicalname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_EntityLogicalName));
      }
    }

    [AttributeLogicalName("msdyn_lookupattributeforsla")]
    public string msdyn_LookupAttributeforSLA
    {
      get => this.GetAttributeValue<string>("msdyn_lookupattributeforsla");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_LookupAttributeforSLA));
        this.SetAttributeValue("msdyn_lookupattributeforsla", (object) value);
        this.OnPropertyChanged(nameof (msdyn_LookupAttributeforSLA));
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

    [AttributeLogicalName("msdyn_organizationid")]
    public string msdyn_OrganizationID
    {
      get => this.GetAttributeValue<string>("msdyn_organizationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_OrganizationID));
        this.SetAttributeValue("msdyn_organizationid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_OrganizationID));
      }
    }

    [AttributeLogicalName("msdyn_pausestate")]
    public string msdyn_PauseState
    {
      get => this.GetAttributeValue<string>("msdyn_pausestate");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_PauseState));
        this.SetAttributeValue("msdyn_pausestate", (object) value);
        this.OnPropertyChanged(nameof (msdyn_PauseState));
      }
    }

    [AttributeLogicalName("msdyn_serviceconfigurationid")]
    public Guid? msdyn_serviceconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_serviceconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfigurationId));
        this.SetAttributeValue("msdyn_serviceconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_serviceconfigurationId));
      }
    }

    [AttributeLogicalName("msdyn_serviceconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_serviceconfigurationId = new Guid?(value);
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

    [AttributeLogicalName("statecode")]
    public msdyn_serviceconfigurationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_serviceconfigurationState?((msdyn_serviceconfigurationState) Enum.ToObject(typeof (msdyn_serviceconfigurationState), attributeValue.Value)) : new msdyn_serviceconfigurationState?();
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

    [RelationshipSchemaName("msdyn_serviceconfiguration_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_serviceconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_serviceconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_serviceconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_serviceconfiguration_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_serviceconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_serviceconfiguration_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_serviceconfiguration_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_serviceconfiguration_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_serviceconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_serviceconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_serviceconfiguration_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_serviceconfiguration_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_serviceconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_serviceconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_serviceconfiguration_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_serviceconfiguration_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_serviceconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_serviceconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_serviceconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_serviceconfiguration_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_serviceconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_serviceconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_serviceconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_serviceconfiguration_SyncErrors")]
    public IEnumerable<SyncError> msdyn_serviceconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_serviceconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_serviceconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_serviceconfiguration_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_serviceconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_serviceconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_serviceconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_serviceconfiguration")]
    public BusinessUnit business_unit_msdyn_serviceconfiguration
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_serviceconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_serviceconfiguration_createdby")]
    public SystemUser lk_msdyn_serviceconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_serviceconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_serviceconfiguration_createdonbehalfby")]
    public SystemUser lk_msdyn_serviceconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_serviceconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_serviceconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_serviceconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_serviceconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_serviceconfiguration_modifiedby")]
    public SystemUser lk_msdyn_serviceconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_serviceconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_serviceconfiguration_modifiedonbehalfby")]
    public SystemUser lk_msdyn_serviceconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_serviceconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_serviceconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_serviceconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_serviceconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_serviceconfiguration")]
    public Team team_msdyn_serviceconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_serviceconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_serviceconfiguration")]
    public SystemUser user_msdyn_serviceconfiguration
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_serviceconfiguration), new EntityRole?());
      }
    }

    public msdyn_serviceconfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_serviceconfigurationid"] = (object) base.Id;
            break;
          case "msdyn_serviceconfigurationid":
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
