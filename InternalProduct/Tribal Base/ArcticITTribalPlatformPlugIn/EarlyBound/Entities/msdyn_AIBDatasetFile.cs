// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIBDatasetFile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aibdatasetfile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIBDatasetFile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aibdatasetfile";
    public const string EntitySchemaName = "msdyn_AIBDatasetFile";
    public const string PrimaryIdAttribute = "msdyn_aibdatasetfileid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIBDatasetFile()
      : base("msdyn_aibdatasetfile")
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

    [AttributeLogicalName("msdyn_aibdatasetfileid")]
    public Guid? msdyn_AIBDatasetFileId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aibdatasetfileid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetFileId));
        this.SetAttributeValue("msdyn_aibdatasetfileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetFileId));
      }
    }

    [AttributeLogicalName("msdyn_aibdatasetfileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIBDatasetFileId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_aibdatasetid")]
    public EntityReference msdyn_AIBDatasetId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aibdatasetid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetId));
        this.SetAttributeValue("msdyn_aibdatasetid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetId));
      }
    }

    [AttributeLogicalName("msdyn_aibfileid")]
    public EntityReference msdyn_AIBFileId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aibfileid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBFileId));
        this.SetAttributeValue("msdyn_aibfileid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIBFileId));
      }
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
    public msdyn_AIBDatasetFileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIBDatasetFileState?((msdyn_AIBDatasetFileState) Enum.ToObject(typeof (msdyn_AIBDatasetFileState), attributeValue.Value)) : new msdyn_AIBDatasetFileState?();
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

    [RelationshipSchemaName("msdyn_aibdatasetfile_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aibdatasetfile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aibdatasetfile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aibdatasetfile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetfile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aibdatasetfile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aibdatasetfile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aibdatasetfile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetfile_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aibdatasetfile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetfile_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetfile_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetfile_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aibdatasetfile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetfile_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetfile_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetfile_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aibdatasetfile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aibdatasetfile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aibdatasetfile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetfile_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aibdatasetfile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aibdatasetfile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aibdatasetfile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetfile_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aibdatasetfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aibdatasetfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aibdatasetfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetfile_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aibdatasetfile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aibdatasetfile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aibdatasetfile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("msdyn_AIBFileAttachedData_msdyn_AIB")]
    public IEnumerable<msdyn_AIBFileAttachedData> msdyn_AIBFileAttachedData_msdyn_AIB
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBFileAttachedData>(nameof (msdyn_AIBFileAttachedData_msdyn_AIB), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBFileAttachedData_msdyn_AIB));
        this.SetRelatedEntities<msdyn_AIBFileAttachedData>(nameof (msdyn_AIBFileAttachedData_msdyn_AIB), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBFileAttachedData_msdyn_AIB));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aibdatasetfile")]
    public BusinessUnit business_unit_msdyn_aibdatasetfile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aibdatasetfile), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetfile_createdby")]
    public SystemUser lk_msdyn_aibdatasetfile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetfile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetfile_createdonbehalfby")]
    public SystemUser lk_msdyn_aibdatasetfile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetfile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aibdatasetfile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetfile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aibdatasetfile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetfile_modifiedby")]
    public SystemUser lk_msdyn_aibdatasetfile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetfile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetfile_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aibdatasetfile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetfile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aibdatasetfile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetfile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aibdatasetfile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_aibdatasetid")]
    [RelationshipSchemaName("msdyn_AIBDatasetFile_msdyn_AIBDatas")]
    public msdyn_AIBDataset msdyn_AIBDatasetFile_msdyn_AIBDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_AIBDatasetFile_msdyn_AIBDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetFile_msdyn_AIBDatas));
        this.SetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_AIBDatasetFile_msdyn_AIBDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetFile_msdyn_AIBDatas));
      }
    }

    [AttributeLogicalName("msdyn_aibfileid")]
    [RelationshipSchemaName("msdyn_AIBDatasetFile_msdyn_AIBuilde")]
    public msdyn_AIBFile msdyn_AIBDatasetFile_msdyn_AIBuilde
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_AIBDatasetFile_msdyn_AIBuilde), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetFile_msdyn_AIBuilde));
        this.SetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_AIBDatasetFile_msdyn_AIBuilde), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetFile_msdyn_AIBuilde));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aibdatasetfile")]
    public Team team_msdyn_aibdatasetfile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aibdatasetfile), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aibdatasetfile")]
    public SystemUser user_msdyn_aibdatasetfile
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aibdatasetfile), new EntityRole?());
      }
    }

    public msdyn_AIBDatasetFile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aibdatasetfileid"] = (object) base.Id;
            break;
          case "msdyn_aibdatasetfileid":
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
