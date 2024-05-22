// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_knowledgearticletemplate
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_knowledgearticletemplate")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_knowledgearticletemplate : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_knowledgearticletemplate";
    public const string EntitySchemaName = "msdyn_knowledgearticletemplate";
    public const string PrimaryIdAttribute = "msdyn_knowledgearticletemplateid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_knowledgearticletemplate()
      : base(nameof (msdyn_knowledgearticletemplate))
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

    [AttributeLogicalName("msdyn_content")]
    public string msdyn_Content
    {
      get => this.GetAttributeValue<string>("msdyn_content");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Content));
        this.SetAttributeValue("msdyn_content", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Content));
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

    [AttributeLogicalName("msdyn_isinternal")]
    public bool? msdyn_isinternal
    {
      get => this.GetAttributeValue<bool?>(nameof (msdyn_isinternal));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isinternal));
        this.SetAttributeValue(nameof (msdyn_isinternal), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isinternal));
      }
    }

    [AttributeLogicalName("msdyn_keywords")]
    public string msdyn_keywords
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_keywords));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_keywords));
        this.SetAttributeValue(nameof (msdyn_keywords), (object) value);
        this.OnPropertyChanged(nameof (msdyn_keywords));
      }
    }

    [AttributeLogicalName("msdyn_knowledgearticletemplateid")]
    public Guid? msdyn_knowledgearticletemplateId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_knowledgearticletemplateid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplateId));
        this.SetAttributeValue("msdyn_knowledgearticletemplateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplateId));
      }
    }

    [AttributeLogicalName("msdyn_knowledgearticletemplateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_knowledgearticletemplateId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_languagelocaleid")]
    public string msdyn_languagelocaleid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_languagelocaleid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_languagelocaleid));
        this.SetAttributeValue(nameof (msdyn_languagelocaleid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_languagelocaleid));
      }
    }

    [AttributeLogicalName("msdyn_LanguageLocaleIdName")]
    public string msdyn_LanguageLocaleIdName
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_LanguageLocaleIdName));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_LanguageLocaleIdName));
        this.SetAttributeValue(nameof (msdyn_LanguageLocaleIdName), (object) value);
        this.OnPropertyChanged(nameof (msdyn_LanguageLocaleIdName));
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

    [AttributeLogicalName("msdyn_subjectid")]
    public EntityReference msdyn_subjectid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (msdyn_subjectid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_subjectid));
        this.SetAttributeValue(nameof (msdyn_subjectid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_subjectid));
      }
    }

    [AttributeLogicalName("msdyn_title")]
    public string msdyn_title
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_title));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_title));
        this.SetAttributeValue(nameof (msdyn_title), (object) value);
        this.OnPropertyChanged(nameof (msdyn_title));
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
    public msdyn_knowledgearticletemplateState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_knowledgearticletemplateState?((msdyn_knowledgearticletemplateState) Enum.ToObject(typeof (msdyn_knowledgearticletemplateState), attributeValue.Value)) : new msdyn_knowledgearticletemplateState?();
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

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_knowledgearticletemplate_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_knowledgearticletemplate_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_knowledgearticletemplate_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_knowledgearticletemplate_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_knowledgearticletemplate_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_knowledgearticletemplate_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_knowledgearticletemplate_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgearticletemplate_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgearticletemplate_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_knowledgearticletemplate_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgearticletemplate_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_knowledgearticletemplate_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_knowledgearticletemplate_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_knowledgearticletemplate_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_knowledgearticletemplate_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_knowledgearticletemplate_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_knowledgearticletemplate_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_knowledgearticletemplate_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_QueueItems")]
    public IEnumerable<QueueItem> msdyn_knowledgearticletemplate_QueueItems
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (msdyn_knowledgearticletemplate_QueueItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_QueueItems));
        this.SetRelatedEntities<QueueItem>(nameof (msdyn_knowledgearticletemplate_QueueItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_QueueItems));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> msdyn_knowledgearticletemplate_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (msdyn_knowledgearticletemplate_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (msdyn_knowledgearticletemplate_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_SharePointDocuments")]
    public IEnumerable<SharePointDocument> msdyn_knowledgearticletemplate_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (msdyn_knowledgearticletemplate_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (msdyn_knowledgearticletemplate_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_SyncErrors")]
    public IEnumerable<SyncError> msdyn_knowledgearticletemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_knowledgearticletemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_knowledgearticletemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_knowledgearticletemplate_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_knowledgearticletemplate_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_knowledgearticletemplate_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_knowledgearticletemplate_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_knowledgearticletemplate")]
    public BusinessUnit business_unit_msdyn_knowledgearticletemplate
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_knowledgearticletemplate), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_knowledgearticletemplate_createdby")]
    public SystemUser lk_msdyn_knowledgearticletemplate_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticletemplate_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_knowledgearticletemplate_createdonbehalfby")]
    public SystemUser lk_msdyn_knowledgearticletemplate_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticletemplate_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_knowledgearticletemplate_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticletemplate_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_knowledgearticletemplate_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_knowledgearticletemplate_modifiedby")]
    public SystemUser lk_msdyn_knowledgearticletemplate_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticletemplate_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_knowledgearticletemplate_modifiedonbehalfby")]
    public SystemUser lk_msdyn_knowledgearticletemplate_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticletemplate_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_knowledgearticletemplate_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_knowledgearticletemplate_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_knowledgearticletemplate_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_subjectid")]
    [RelationshipSchemaName("msdyn_subject_knowledgearticletemplate_subjectid")]
    public Subject msdyn_subject_knowledgearticletemplate_subjectid
    {
      get
      {
        return this.GetRelatedEntity<Subject>(nameof (msdyn_subject_knowledgearticletemplate_subjectid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_subject_knowledgearticletemplate_subjectid));
        this.SetRelatedEntity<Subject>(nameof (msdyn_subject_knowledgearticletemplate_subjectid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_subject_knowledgearticletemplate_subjectid));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_knowledgearticletemplate")]
    public Team team_msdyn_knowledgearticletemplate
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_knowledgearticletemplate), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_knowledgearticletemplate")]
    public SystemUser user_msdyn_knowledgearticletemplate
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_knowledgearticletemplate), new EntityRole?());
      }
    }

    public msdyn_knowledgearticletemplate(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_knowledgearticletemplateid"] = (object) base.Id;
            break;
          case "msdyn_knowledgearticletemplateid":
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
