// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SharePointSite
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sharepointsite")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SharePointSite : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sharepointsite";
    public const string EntitySchemaName = "SharePointSite";
    public const string PrimaryIdAttribute = "sharepointsiteid";
    public const string PrimaryNameAttribute = "name";

    public SharePointSite()
      : base("sharepointsite")
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

    [AttributeLogicalName("absoluteurl")]
    public string AbsoluteURL
    {
      get => this.GetAttributeValue<string>("absoluteurl");
      set
      {
        this.OnPropertyChanging(nameof (AbsoluteURL));
        this.SetAttributeValue("absoluteurl", (object) value);
        this.OnPropertyChanged(nameof (AbsoluteURL));
      }
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("folderstructureentity")]
    public string FolderStructureEntity
    {
      get => this.GetAttributeValue<string>("folderstructureentity");
      set
      {
        this.OnPropertyChanging(nameof (FolderStructureEntity));
        this.SetAttributeValue("folderstructureentity", (object) value);
        this.OnPropertyChanged(nameof (FolderStructureEntity));
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

    [AttributeLogicalName("isdefault")]
    public bool? IsDefault
    {
      get => this.GetAttributeValue<bool?>("isdefault");
      set
      {
        this.OnPropertyChanging(nameof (IsDefault));
        this.SetAttributeValue("isdefault", (object) value);
        this.OnPropertyChanged(nameof (IsDefault));
      }
    }

    [AttributeLogicalName("isgridpresent")]
    public bool? IsGridPresent
    {
      get => this.GetAttributeValue<bool?>("isgridpresent");
      set
      {
        this.OnPropertyChanging(nameof (IsGridPresent));
        this.SetAttributeValue("isgridpresent", (object) value);
        this.OnPropertyChanged(nameof (IsGridPresent));
      }
    }

    [AttributeLogicalName("ispowerbisite")]
    public bool? IsPowerBISite
    {
      get => this.GetAttributeValue<bool?>("ispowerbisite");
      set
      {
        this.OnPropertyChanging(nameof (IsPowerBISite));
        this.SetAttributeValue("ispowerbisite", (object) value);
        this.OnPropertyChanged(nameof (IsPowerBISite));
      }
    }

    [AttributeLogicalName("lastvalidated")]
    public DateTime? LastValidated
    {
      get => this.GetAttributeValue<DateTime?>("lastvalidated");
      set
      {
        this.OnPropertyChanging(nameof (LastValidated));
        this.SetAttributeValue("lastvalidated", (object) value);
        this.OnPropertyChanged(nameof (LastValidated));
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

    [AttributeLogicalName("parentsite")]
    public EntityReference ParentSite
    {
      get => this.GetAttributeValue<EntityReference>("parentsite");
      set
      {
        this.OnPropertyChanging(nameof (ParentSite));
        this.SetAttributeValue("parentsite", (object) value);
        this.OnPropertyChanged(nameof (ParentSite));
      }
    }

    [AttributeLogicalName("relativeurl")]
    public string RelativeUrl
    {
      get => this.GetAttributeValue<string>("relativeurl");
      set
      {
        this.OnPropertyChanging(nameof (RelativeUrl));
        this.SetAttributeValue("relativeurl", (object) value);
        this.OnPropertyChanged(nameof (RelativeUrl));
      }
    }

    [AttributeLogicalName("servicetype")]
    public OptionSetValue ServiceType
    {
      get => this.GetAttributeValue<OptionSetValue>("servicetype");
      set
      {
        this.OnPropertyChanging(nameof (ServiceType));
        this.SetAttributeValue("servicetype", (object) value);
        this.OnPropertyChanged(nameof (ServiceType));
      }
    }

    [AttributeLogicalName("sharepointsiteid")]
    public Guid? SharePointSiteId
    {
      get => this.GetAttributeValue<Guid?>("sharepointsiteid");
      set
      {
        this.OnPropertyChanging(nameof (SharePointSiteId));
        this.SetAttributeValue("sharepointsiteid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SharePointSiteId));
      }
    }

    [AttributeLogicalName("sharepointsiteid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SharePointSiteId = new Guid?(value);
    }

    [AttributeLogicalName("sitecollectionid")]
    public Guid? SiteCollectionId => this.GetAttributeValue<Guid?>("sitecollectionid");

    [AttributeLogicalName("statecode")]
    public SharePointSiteState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SharePointSiteState?((SharePointSiteState) Enum.ToObject(typeof (SharePointSiteState), attributeValue.Value)) : new SharePointSiteState?();
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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
    }

    [AttributeLogicalName("userid")]
    public Guid? UserId
    {
      get => this.GetAttributeValue<Guid?>("userid");
      set
      {
        this.OnPropertyChanging(nameof (UserId));
        this.SetAttributeValue("userid", (object) value);
        this.OnPropertyChanged(nameof (UserId));
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

    [AttributeLogicalName("validationstatus")]
    public OptionSetValue ValidationStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("validationstatus");
      set
      {
        this.OnPropertyChanging(nameof (ValidationStatus));
        this.SetAttributeValue("validationstatus", (object) value);
        this.OnPropertyChanged(nameof (ValidationStatus));
      }
    }

    [AttributeLogicalName("validationstatuserrorcode")]
    public OptionSetValue ValidationStatusErrorCode
    {
      get => this.GetAttributeValue<OptionSetValue>("validationstatuserrorcode");
      set
      {
        this.OnPropertyChanging(nameof (ValidationStatusErrorCode));
        this.SetAttributeValue("validationstatuserrorcode", (object) value);
        this.OnPropertyChanged(nameof (ValidationStatusErrorCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("sharepointdocumentlocation_parent_sharepointsite")]
    public IEnumerable<SharePointDocumentLocation> sharepointdocumentlocation_parent_sharepointsite
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (sharepointdocumentlocation_parent_sharepointsite), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sharepointdocumentlocation_parent_sharepointsite));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (sharepointdocumentlocation_parent_sharepointsite), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sharepointdocumentlocation_parent_sharepointsite));
      }
    }

    [RelationshipSchemaName("SharePointSite_AsyncOperations")]
    public IEnumerable<AsyncOperation> SharePointSite_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (SharePointSite_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointSite_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (SharePointSite_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointSite_AsyncOperations));
      }
    }

    [RelationshipSchemaName("SharePointSite_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> SharePointSite_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (SharePointSite_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointSite_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (SharePointSite_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointSite_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("SharePointSite_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> SharePointSite_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (SharePointSite_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointSite_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (SharePointSite_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointSite_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<SharePointSite> Referencedsharepointsite_parentsite_sharepointsite
    {
      get
      {
        return this.GetRelatedEntities<SharePointSite>("sharepointsite_parentsite_sharepointsite", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedsharepointsite_parentsite_sharepointsite));
        this.SetRelatedEntities<SharePointSite>("sharepointsite_parentsite_sharepointsite", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedsharepointsite_parentsite_sharepointsite));
      }
    }

    [RelationshipSchemaName("sharepointsite_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> sharepointsite_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (sharepointsite_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sharepointsite_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (sharepointsite_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sharepointsite_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("SharePointSite_ProcessSessions")]
    public IEnumerable<ProcessSession> SharePointSite_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (SharePointSite_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointSite_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (SharePointSite_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointSite_ProcessSessions));
      }
    }

    [RelationshipSchemaName("SharePointSite_SyncErrors")]
    public IEnumerable<SyncError> SharePointSite_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (SharePointSite_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointSite_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SharePointSite_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointSite_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sharepointsite")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sharepointsite
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sharepointsite), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sharepointsite));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sharepointsite), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sharepointsite));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_sharepointsites")]
    public BusinessUnit business_unit_sharepointsites
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_sharepointsites), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_sharepointsitebase_createdby")]
    public SystemUser lk_sharepointsitebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointsitebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sharepointsitebase_createdonbehalfby")]
    public SystemUser lk_sharepointsitebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointsitebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sharepointsitebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sharepointsitebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sharepointsitebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_sharepointsitebase_modifiedby")]
    public SystemUser lk_sharepointsitebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointsitebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sharepointsitebase_modifiedonbehalfby")]
    public SystemUser lk_sharepointsitebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sharepointsitebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sharepointsitebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sharepointsitebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sharepointsitebase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("parentsite")]
    [RelationshipSchemaName]
    public SharePointSite Referencingsharepointsite_parentsite_sharepointsite
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>("sharepointsite_parentsite_sharepointsite", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingsharepointsite_parentsite_sharepointsite));
        this.SetRelatedEntity<SharePointSite>("sharepointsite_parentsite_sharepointsite", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingsharepointsite_parentsite_sharepointsite));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_sharepointsite")]
    public Team team_sharepointsite
    {
      get => this.GetRelatedEntity<Team>(nameof (team_sharepointsite), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_SharePointSite")]
    public TransactionCurrency TransactionCurrency_SharePointSite
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_SharePointSite), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_sharepointsite")]
    public SystemUser user_sharepointsite
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_sharepointsite), new EntityRole?());
    }

    public SharePointSite(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sharepointsiteid"] = (object) base.Id;
            break;
          case "sharepointsiteid":
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
