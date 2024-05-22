// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_knowledgearticleimage
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_knowledgearticleimage")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_knowledgearticleimage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_knowledgearticleimage";
    public const string EntitySchemaName = "msdyn_knowledgearticleimage";
    public const string PrimaryIdAttribute = "msdyn_knowledgearticleimageid";
    public const string PrimaryNameAttribute = "msdyn_filename";

    public msdyn_knowledgearticleimage()
      : base(nameof (msdyn_knowledgearticleimage))
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

    [AttributeLogicalName("msdyn_filename")]
    public string msdyn_FileName
    {
      get => this.GetAttributeValue<string>("msdyn_filename");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_FileName));
        this.SetAttributeValue("msdyn_filename", (object) value);
        this.OnPropertyChanged(nameof (msdyn_FileName));
      }
    }

    [AttributeLogicalName("msdyn_knowledgearticleimageid")]
    public Guid? msdyn_knowledgearticleimageId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_knowledgearticleimageid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimageId));
        this.SetAttributeValue("msdyn_knowledgearticleimageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimageId));
      }
    }

    [AttributeLogicalName("msdyn_knowledgearticleimageid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_knowledgearticleimageId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_parentknowledgearticleid")]
    public EntityReference msdyn_ParentKnowledgeArticleID
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_parentknowledgearticleid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ParentKnowledgeArticleID));
        this.SetAttributeValue("msdyn_parentknowledgearticleid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ParentKnowledgeArticleID));
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
    public msdyn_knowledgearticleimageState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_knowledgearticleimageState?((msdyn_knowledgearticleimageState) Enum.ToObject(typeof (msdyn_knowledgearticleimageState), attributeValue.Value)) : new msdyn_knowledgearticleimageState?();
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

    [RelationshipSchemaName("msdyn_knowledgearticleimage_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_knowledgearticleimage_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_knowledgearticleimage_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_knowledgearticleimage_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticleimage_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_knowledgearticleimage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_knowledgearticleimage_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_knowledgearticleimage_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticleimage_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_knowledgearticleimage_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgearticleimage_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgearticleimage_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticleimage_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_knowledgearticleimage_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgearticleimage_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgearticleimage_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticleimage_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_knowledgearticleimage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_knowledgearticleimage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_knowledgearticleimage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticleimage_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_knowledgearticleimage_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_knowledgearticleimage_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_knowledgearticleimage_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticleimage_SyncErrors")]
    public IEnumerable<SyncError> msdyn_knowledgearticleimage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_knowledgearticleimage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_knowledgearticleimage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticleimage_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_knowledgearticleimage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_knowledgearticleimage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_knowledgearticleimage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_knowledgearticleimage")]
    public BusinessUnit business_unit_msdyn_knowledgearticleimage
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_knowledgearticleimage), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_knowledgearticleimage_createdby")]
    public SystemUser lk_msdyn_knowledgearticleimage_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticleimage_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_knowledgearticleimage_createdonbehalfby")]
    public SystemUser lk_msdyn_knowledgearticleimage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticleimage_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_knowledgearticleimage_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticleimage_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_knowledgearticleimage_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_knowledgearticleimage_modifiedby")]
    public SystemUser lk_msdyn_knowledgearticleimage_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticleimage_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_knowledgearticleimage_modifiedonbehalfby")]
    public SystemUser lk_msdyn_knowledgearticleimage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticleimage_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_knowledgearticleimage_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticleimage_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_knowledgearticleimage_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_knowledgearticleimage")]
    public Team team_msdyn_knowledgearticleimage
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_knowledgearticleimage), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_knowledgearticleimage")]
    public SystemUser user_msdyn_knowledgearticleimage
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_knowledgearticleimage), new EntityRole?());
      }
    }

    public msdyn_knowledgearticleimage(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_knowledgearticleimageid"] = (object) base.Id;
            break;
          case "msdyn_knowledgearticleimageid":
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
