// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIOdLabel
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aiodlabel")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIOdLabel : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aiodlabel";
    public const string EntitySchemaName = "msdyn_AIOdLabel";
    public const string PrimaryIdAttribute = "msdyn_aiodlabelid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIOdLabel()
      : base("msdyn_aiodlabel")
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

    [AttributeLogicalName("msdyn_aiodlabelid")]
    public Guid? msdyn_AIOdLabelId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aiodlabelid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIOdLabelId));
        this.SetAttributeValue("msdyn_aiodlabelid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIOdLabelId));
      }
    }

    [AttributeLogicalName("msdyn_aiodlabelid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIOdLabelId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_labelstring")]
    public string msdyn_LabelString
    {
      get => this.GetAttributeValue<string>("msdyn_labelstring");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_LabelString));
        this.SetAttributeValue("msdyn_labelstring", (object) value);
        this.OnPropertyChanged(nameof (msdyn_LabelString));
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

    [AttributeLogicalName("msdyn_sourceattributelogicalname")]
    public string msdyn_SourceAttributeLogicalName
    {
      get => this.GetAttributeValue<string>("msdyn_sourceattributelogicalname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SourceAttributeLogicalName));
        this.SetAttributeValue("msdyn_sourceattributelogicalname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SourceAttributeLogicalName));
      }
    }

    [AttributeLogicalName("msdyn_sourceentitysetname")]
    public string msdyn_SourceEntitySetName
    {
      get => this.GetAttributeValue<string>("msdyn_sourceentitysetname");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SourceEntitySetName));
        this.SetAttributeValue("msdyn_sourceentitysetname", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SourceEntitySetName));
      }
    }

    [AttributeLogicalName("msdyn_sourcerecordid")]
    public string msdyn_SourceRecordId
    {
      get => this.GetAttributeValue<string>("msdyn_sourcerecordid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SourceRecordId));
        this.SetAttributeValue("msdyn_sourcerecordid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SourceRecordId));
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
    public msdyn_AIOdLabelState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIOdLabelState?((msdyn_AIOdLabelState) Enum.ToObject(typeof (msdyn_AIOdLabelState), attributeValue.Value)) : new msdyn_AIOdLabelState?();
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

    [RelationshipSchemaName("msdyn_aiodlabel_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aiodlabel_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aiodlabel_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aiodlabel_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aiodlabel_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiodlabel_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiodlabel_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aiodlabel_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodlabel_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodlabel_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aiodlabel_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodlabel_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodlabel_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aiodlabel_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiodlabel_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiodlabel_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_msdyn_aiodtrainingboundingbox")]
    public IEnumerable<msdyn_AIOdTrainingBoundingBox> msdyn_aiodlabel_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodlabel_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_msdyn_aiodtrainingboundingbox));
        this.SetRelatedEntities<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodlabel_msdyn_aiodtrainingboundingbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_msdyn_aiodtrainingboundingbox));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aiodlabel_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiodlabel_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiodlabel_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aiodlabel_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aiodlabel_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aiodlabel_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aiodlabel_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aiodlabel_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aiodlabel_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aiodlabel_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiodlabel_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiodlabel_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("msdyn_aiodlabel_msdyn_aiconfiguration")]
    public IEnumerable<msdyn_AIConfiguration> msdyn_aiodlabel_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIConfiguration>(nameof (msdyn_aiodlabel_msdyn_aiconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_msdyn_aiconfiguration));
        this.SetRelatedEntities<msdyn_AIConfiguration>(nameof (msdyn_aiodlabel_msdyn_aiconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_msdyn_aiconfiguration));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aiodlabel")]
    public BusinessUnit business_unit_msdyn_aiodlabel
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aiodlabel), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aiodlabel_createdby")]
    public SystemUser lk_msdyn_aiodlabel_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodlabel_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiodlabel_createdonbehalfby")]
    public SystemUser lk_msdyn_aiodlabel_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodlabel_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiodlabel_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodlabel_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiodlabel_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aiodlabel_modifiedby")]
    public SystemUser lk_msdyn_aiodlabel_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodlabel_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiodlabel_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aiodlabel_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodlabel_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiodlabel_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodlabel_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiodlabel_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aiodlabel")]
    public Team team_msdyn_aiodlabel
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_aiodlabel), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aiodlabel")]
    public SystemUser user_msdyn_aiodlabel
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aiodlabel), new EntityRole?());
    }

    public msdyn_AIOdLabel(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aiodlabelid"] = (object) base.Id;
            break;
          case "msdyn_aiodlabelid":
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
