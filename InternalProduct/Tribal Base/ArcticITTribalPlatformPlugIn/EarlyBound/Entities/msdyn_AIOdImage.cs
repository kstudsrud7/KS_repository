// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIOdImage
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aiodimage")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIOdImage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aiodimage";
    public const string EntitySchemaName = "msdyn_AIOdImage";
    public const string PrimaryIdAttribute = "msdyn_aiodimageid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIOdImage()
      : base("msdyn_aiodimage")
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

    [AttributeLogicalName("msdyn_aiodimageid")]
    public Guid? msdyn_AIOdImageId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aiodimageid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIOdImageId));
        this.SetAttributeValue("msdyn_aiodimageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIOdImageId));
      }
    }

    [AttributeLogicalName("msdyn_aiodimageid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIOdImageId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_checksum")]
    public string msdyn_Checksum
    {
      get => this.GetAttributeValue<string>("msdyn_checksum");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Checksum));
        this.SetAttributeValue("msdyn_checksum", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Checksum));
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

    [AttributeLogicalName("msdyn_metadata")]
    public string msdyn_Metadata
    {
      get => this.GetAttributeValue<string>("msdyn_metadata");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Metadata));
        this.SetAttributeValue("msdyn_metadata", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Metadata));
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
    public msdyn_AIOdImageState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIOdImageState?((msdyn_AIOdImageState) Enum.ToObject(typeof (msdyn_AIOdImageState), attributeValue.Value)) : new msdyn_AIOdImageState?();
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

    [RelationshipSchemaName("msdyn_aiodimage_Annotations")]
    public IEnumerable<Annotation> msdyn_aiodimage_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (msdyn_aiodimage_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (msdyn_aiodimage_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_Annotations));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aiodimage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aiodimage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aiodimage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aiodimage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiodimage_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiodimage_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aiodimage_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodimage_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodimage_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aiodimage_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodimage_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodimage_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aiodimage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiodimage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiodimage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_msdyn_aiodtrainingimage")]
    public IEnumerable<msdyn_AIOdTrainingImage> msdyn_aiodimage_msdyn_aiodtrainingimage
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodimage_msdyn_aiodtrainingimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_msdyn_aiodtrainingimage));
        this.SetRelatedEntities<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodimage_msdyn_aiodtrainingimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_msdyn_aiodtrainingimage));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aiodimage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiodimage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiodimage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aiodimage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aiodimage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aiodimage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aiodimage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aiodimage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aiodimage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aiodimage_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aiodimage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiodimage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiodimage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aiodimage")]
    public BusinessUnit business_unit_msdyn_aiodimage
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aiodimage), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aiodimage_createdby")]
    public SystemUser lk_msdyn_aiodimage_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodimage_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiodimage_createdonbehalfby")]
    public SystemUser lk_msdyn_aiodimage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodimage_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiodimage_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodimage_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiodimage_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aiodimage_modifiedby")]
    public SystemUser lk_msdyn_aiodimage_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodimage_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiodimage_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aiodimage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodimage_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiodimage_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodimage_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiodimage_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aiodimage")]
    public Team team_msdyn_aiodimage
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aiodimage), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aiodimage")]
    public SystemUser user_msdyn_aiodimage
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aiodimage), new EntityRole?());
    }

    public msdyn_AIOdImage(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aiodimageid"] = (object) base.Id;
            break;
          case "msdyn_aiodimageid":
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
