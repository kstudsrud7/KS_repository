// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIOdTrainingImage
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aiodtrainingimage")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIOdTrainingImage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aiodtrainingimage";
    public const string EntitySchemaName = "msdyn_AIOdTrainingImage";
    public const string PrimaryIdAttribute = "msdyn_aiodtrainingimageid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIOdTrainingImage()
      : base("msdyn_aiodtrainingimage")
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

    [AttributeLogicalName("msdyn_aiconfigurationid")]
    public EntityReference msdyn_AIConfigurationId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aiconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIConfigurationId));
        this.SetAttributeValue("msdyn_aiconfigurationid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIConfigurationId));
      }
    }

    [AttributeLogicalName("msdyn_aiodimageid")]
    public EntityReference msdyn_AIOdImageId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aiodimageid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIOdImageId));
        this.SetAttributeValue("msdyn_aiodimageid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIOdImageId));
      }
    }

    [AttributeLogicalName("msdyn_aiodtrainingimageid")]
    public Guid? msdyn_AIOdTrainingImageId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aiodtrainingimageid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIOdTrainingImageId));
        this.SetAttributeValue("msdyn_aiodtrainingimageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIOdTrainingImageId));
      }
    }

    [AttributeLogicalName("msdyn_aiodtrainingimageid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIOdTrainingImageId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_lastmodifieddate")]
    public DateTime? msdyn_LastModifiedDate
    {
      get => this.GetAttributeValue<DateTime?>("msdyn_lastmodifieddate");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_LastModifiedDate));
        this.SetAttributeValue("msdyn_lastmodifieddate", (object) value);
        this.OnPropertyChanged(nameof (msdyn_LastModifiedDate));
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

    [AttributeLogicalName("msdyn_sourcetype")]
    public string msdyn_SourceType
    {
      get => this.GetAttributeValue<string>("msdyn_sourcetype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SourceType));
        this.SetAttributeValue("msdyn_sourcetype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SourceType));
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

    [AttributeLogicalName("statecode")]
    public msdyn_AIOdTrainingImageState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIOdTrainingImageState?((msdyn_AIOdTrainingImageState) Enum.ToObject(typeof (msdyn_AIOdTrainingImageState), attributeValue.Value)) : new msdyn_AIOdTrainingImageState?();
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

    [RelationshipSchemaName("msdyn_aiodtrainingimage_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aiodtrainingimage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aiodtrainingimage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aiodtrainingimage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aiodtrainingimage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiodtrainingimage_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiodtrainingimage_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aiodtrainingimage_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodtrainingimage_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodtrainingimage_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aiodtrainingimage_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodtrainingimage_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodtrainingimage_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aiodtrainingimage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiodtrainingimage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiodtrainingimage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox")]
    public IEnumerable<msdyn_AIOdTrainingBoundingBox> msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox));
        this.SetRelatedEntities<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aiodtrainingimage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aiodtrainingimage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aiodtrainingimage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aiodtrainingimage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aiodtrainingimage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aiodtrainingimage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingimage_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aiodtrainingimage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiodtrainingimage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiodtrainingimage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aiodtrainingimage")]
    public BusinessUnit business_unit_msdyn_aiodtrainingimage
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aiodtrainingimage), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aiodtrainingimage_createdby")]
    public SystemUser lk_msdyn_aiodtrainingimage_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingimage_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiodtrainingimage_createdonbehalfby")]
    public SystemUser lk_msdyn_aiodtrainingimage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingimage_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiodtrainingimage_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingimage_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiodtrainingimage_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aiodtrainingimage_modifiedby")]
    public SystemUser lk_msdyn_aiodtrainingimage_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingimage_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiodtrainingimage_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aiodtrainingimage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingimage_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiodtrainingimage_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingimage_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiodtrainingimage_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_aiconfigurationid")]
    [RelationshipSchemaName("msdyn_aiconfiguration_msdyn_aiodtrainingimage")]
    public msdyn_AIConfiguration msdyn_aiconfiguration_msdyn_aiodtrainingimage
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_msdyn_aiodtrainingimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_msdyn_aiodtrainingimage));
        this.SetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_msdyn_aiodtrainingimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_msdyn_aiodtrainingimage));
      }
    }

    [AttributeLogicalName("msdyn_aiodimageid")]
    [RelationshipSchemaName("msdyn_aiodimage_msdyn_aiodtrainingimage")]
    public msdyn_AIOdImage msdyn_aiodimage_msdyn_aiodtrainingimage
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_msdyn_aiodtrainingimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_msdyn_aiodtrainingimage));
        this.SetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_msdyn_aiodtrainingimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_msdyn_aiodtrainingimage));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aiodtrainingimage")]
    public Team team_msdyn_aiodtrainingimage
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aiodtrainingimage), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aiodtrainingimage")]
    public SystemUser user_msdyn_aiodtrainingimage
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aiodtrainingimage), new EntityRole?());
      }
    }

    public msdyn_AIOdTrainingImage(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aiodtrainingimageid"] = (object) base.Id;
            break;
          case "msdyn_aiodtrainingimageid":
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
