// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIBDatasetRecord
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aibdatasetrecord")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIBDatasetRecord : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aibdatasetrecord";
    public const string EntitySchemaName = "msdyn_AIBDatasetRecord";
    public const string PrimaryIdAttribute = "msdyn_aibdatasetrecordid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIBDatasetRecord()
      : base("msdyn_aibdatasetrecord")
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

    [AttributeLogicalName("msdyn_aibdatasetrecordid")]
    public Guid? msdyn_AIBDatasetRecordId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aibdatasetrecordid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetRecordId));
        this.SetAttributeValue("msdyn_aibdatasetrecordid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetRecordId));
      }
    }

    [AttributeLogicalName("msdyn_aibdatasetrecordid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIBDatasetRecordId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_aibdatasetsid")]
    public EntityReference msdyn_AIBDatasetsId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aibdatasetsid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetsId));
        this.SetAttributeValue("msdyn_aibdatasetsid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetsId));
      }
    }

    [AttributeLogicalName("msdyn_data")]
    public string msdyn_Data
    {
      get => this.GetAttributeValue<string>("msdyn_data");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Data));
        this.SetAttributeValue("msdyn_data", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Data));
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

    [AttributeLogicalName("msdyn_recordtype")]
    public OptionSetValue msdyn_RecordType
    {
      get => this.GetAttributeValue<OptionSetValue>("msdyn_recordtype");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RecordType));
        this.SetAttributeValue("msdyn_recordtype", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RecordType));
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
    public msdyn_AIBDatasetRecordState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIBDatasetRecordState?((msdyn_AIBDatasetRecordState) Enum.ToObject(typeof (msdyn_AIBDatasetRecordState), attributeValue.Value)) : new msdyn_AIBDatasetRecordState?();
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

    [RelationshipSchemaName("msdyn_aibdatasetrecord_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aibdatasetrecord_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aibdatasetrecord_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aibdatasetrecord_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetrecord_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aibdatasetrecord_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aibdatasetrecord_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aibdatasetrecord_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetrecord_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aibdatasetrecord_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetrecord_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetrecord_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetrecord_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aibdatasetrecord_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetrecord_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aibdatasetrecord_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetrecord_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aibdatasetrecord_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aibdatasetrecord_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aibdatasetrecord_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetrecord_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aibdatasetrecord_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aibdatasetrecord_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aibdatasetrecord_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetrecord_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aibdatasetrecord_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aibdatasetrecord_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aibdatasetrecord_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aibdatasetrecord_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aibdatasetrecord_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aibdatasetrecord_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aibdatasetrecord_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aibdatasetrecord")]
    public BusinessUnit business_unit_msdyn_aibdatasetrecord
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aibdatasetrecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetrecord_createdby")]
    public SystemUser lk_msdyn_aibdatasetrecord_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetrecord_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetrecord_createdonbehalfby")]
    public SystemUser lk_msdyn_aibdatasetrecord_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetrecord_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aibdatasetrecord_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetrecord_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aibdatasetrecord_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetrecord_modifiedby")]
    public SystemUser lk_msdyn_aibdatasetrecord_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetrecord_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aibdatasetrecord_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aibdatasetrecord_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetrecord_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aibdatasetrecord_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aibdatasetrecord_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aibdatasetrecord_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_aibdatasetsid")]
    [RelationshipSchemaName("msdyn_AIBDatasetRecord_msdyn_AIBDataset")]
    public msdyn_AIBDataset msdyn_AIBDatasetRecord_msdyn_AIBDataset
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_AIBDatasetRecord_msdyn_AIBDataset), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIBDatasetRecord_msdyn_AIBDataset));
        this.SetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_AIBDatasetRecord_msdyn_AIBDataset), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_AIBDatasetRecord_msdyn_AIBDataset));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aibdatasetrecord")]
    public Team team_msdyn_aibdatasetrecord
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aibdatasetrecord), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aibdatasetrecord")]
    public SystemUser user_msdyn_aibdatasetrecord
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aibdatasetrecord), new EntityRole?());
      }
    }

    public msdyn_AIBDatasetRecord(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aibdatasetrecordid"] = (object) base.Id;
            break;
          case "msdyn_aibdatasetrecordid":
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
