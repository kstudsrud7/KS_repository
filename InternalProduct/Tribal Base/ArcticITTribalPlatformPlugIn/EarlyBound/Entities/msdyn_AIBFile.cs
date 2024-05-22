// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIBFile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aibfile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIBFile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aibfile";
    public const string EntitySchemaName = "msdyn_AIBFile";
    public const string PrimaryIdAttribute = "msdyn_aibfileid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIBFile()
      : base("msdyn_aibfile")
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

    [AttributeLogicalName("msdyn_aibdatasetscontainerid")]
    public EntityReference msdyn_AIBDatasetsContainerId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aibdatasetscontainerid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetsContainerId));
        this.SetAttributeValue("msdyn_aibdatasetscontainerid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetsContainerId));
      }
    }

    [AttributeLogicalName("msdyn_aibfileid")]
    public Guid? msdyn_AIBFileId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aibfileid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBFileId));
        this.SetAttributeValue("msdyn_aibfileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIBFileId));
      }
    }

    [AttributeLogicalName("msdyn_aibfileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIBFileId = new Guid?(value);
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

    [AttributeLogicalName("msdyn_image")]
    public byte[] msdyn_Image
    {
      get => this.GetAttributeValue<byte[]>("msdyn_image");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Image));
        this.SetAttributeValue("msdyn_image", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Image));
      }
    }

    [AttributeLogicalName("msdyn_image_timestamp")]
    public long? msdyn_Image_Timestamp => this.GetAttributeValue<long?>("msdyn_image_timestamp");

    [AttributeLogicalName("msdyn_image_url")]
    public string msdyn_Image_URL => this.GetAttributeValue<string>("msdyn_image_url");

    [AttributeLogicalName("msdyn_imageid")]
    public Guid? msdyn_ImageId => this.GetAttributeValue<Guid?>("msdyn_imageid");

    [AttributeLogicalName("msdyn_importmetadata")]
    public string msdyn_ImportMetadata
    {
      get => this.GetAttributeValue<string>("msdyn_importmetadata");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ImportMetadata));
        this.SetAttributeValue("msdyn_importmetadata", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ImportMetadata));
      }
    }

    [AttributeLogicalName("msdyn_mimetype")]
    public string msdyn_MimeType
    {
      get => this.GetAttributeValue<string>("msdyn_mimetype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_MimeType));
        this.SetAttributeValue("msdyn_mimetype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_MimeType));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_Name
    {
      get => this.GetAttributeValue<string>("msdyn_name");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Name));
        this.SetAttributeValue("msdyn_name", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Name));
      }
    }

    [AttributeLogicalName("msdyn_size")]
    public int? msdyn_Size
    {
      get => this.GetAttributeValue<int?>("msdyn_size");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Size));
        this.SetAttributeValue("msdyn_size", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Size));
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
    public msdyn_AIBFileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIBFileState?((msdyn_AIBFileState) Enum.ToObject(typeof (msdyn_AIBFileState), attributeValue.Value)) : new msdyn_AIBFileState?();
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

    [RelationshipSchemaName("msdyn_AIBDatasetFile_msdyn_AIBuilde")]
    public IEnumerable<msdyn_AIBDatasetFile> msdyn_AIBDatasetFile_msdyn_AIBuilde
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDatasetFile>(nameof (msdyn_AIBDatasetFile_msdyn_AIBuilde), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetFile_msdyn_AIBuilde));
        this.SetRelatedEntities<msdyn_AIBDatasetFile>(nameof (msdyn_AIBDatasetFile_msdyn_AIBuilde), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetFile_msdyn_AIBuilde));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aibfile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aibfile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aibfile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aibfile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aibfile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aibfile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aibfile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibfile_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibfile_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aibfile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibfile_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibfile_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aibfile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aibfile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aibfile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aibfile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aibfile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aibfile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aibfile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aibfile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aibfile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aibfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aibfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aibfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aibfile_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aibfile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aibfile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aibfile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aibfile")]
    public BusinessUnit business_unit_msdyn_aibfile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aibfile), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aibfile_createdby")]
    public SystemUser lk_msdyn_aibfile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibfile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aibfile_createdonbehalfby")]
    public SystemUser lk_msdyn_aibfile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibfile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aibfile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibfile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aibfile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aibfile_modifiedby")]
    public SystemUser lk_msdyn_aibfile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibfile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aibfile_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aibfile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibfile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aibfile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibfile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aibfile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_aibdatasetscontainerid")]
    [RelationshipSchemaName("msdyn_AIBFile_msdyn_AIBDatasetsCont")]
    public msdyn_AIBDatasetsContainer msdyn_AIBFile_msdyn_AIBDatasetsCont
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_AIBFile_msdyn_AIBDatasetsCont), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBFile_msdyn_AIBDatasetsCont));
        this.SetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_AIBFile_msdyn_AIBDatasetsCont), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBFile_msdyn_AIBDatasetsCont));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aibfile")]
    public Team team_msdyn_aibfile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aibfile), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aibfile")]
    public SystemUser user_msdyn_aibfile
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aibfile), new EntityRole?());
    }

    public msdyn_AIBFile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aibfileid"] = (object) base.Id;
            break;
          case "msdyn_aibfileid":
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
