// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SavedQuery
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("savedquery")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SavedQuery : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "savedquery";
    public const string EntitySchemaName = "SavedQuery";
    public const string PrimaryIdAttribute = "savedqueryid";
    public const string PrimaryNameAttribute = "name";

    public SavedQuery()
      : base("savedquery")
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

    [AttributeLogicalName("advancedgroupby")]
    public string AdvancedGroupBy
    {
      get => this.GetAttributeValue<string>("advancedgroupby");
      set
      {
        this.OnPropertyChanging(nameof (AdvancedGroupBy));
        this.SetAttributeValue("advancedgroupby", (object) value);
        this.OnPropertyChanged(nameof (AdvancedGroupBy));
      }
    }

    [AttributeLogicalName("canbedeleted")]
    public BooleanManagedProperty CanBeDeleted
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("canbedeleted");
      set
      {
        this.OnPropertyChanging(nameof (CanBeDeleted));
        this.SetAttributeValue("canbedeleted", (object) value);
        this.OnPropertyChanged(nameof (CanBeDeleted));
      }
    }

    [AttributeLogicalName("columnsetxml")]
    public string ColumnSetXml
    {
      get => this.GetAttributeValue<string>("columnsetxml");
      set
      {
        this.OnPropertyChanging(nameof (ColumnSetXml));
        this.SetAttributeValue("columnsetxml", (object) value);
        this.OnPropertyChanged(nameof (ColumnSetXml));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("conditionalformatting")]
    public string ConditionalFormatting
    {
      get => this.GetAttributeValue<string>("conditionalformatting");
      set
      {
        this.OnPropertyChanging(nameof (ConditionalFormatting));
        this.SetAttributeValue("conditionalformatting", (object) value);
        this.OnPropertyChanged(nameof (ConditionalFormatting));
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

    [AttributeLogicalName("fetchxml")]
    public string FetchXml
    {
      get => this.GetAttributeValue<string>("fetchxml");
      set
      {
        this.OnPropertyChanging(nameof (FetchXml));
        this.SetAttributeValue("fetchxml", (object) value);
        this.OnPropertyChanged(nameof (FetchXml));
      }
    }

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
      }
    }

    [AttributeLogicalName("iscustom")]
    public bool? IsCustom => this.GetAttributeValue<bool?>("iscustom");

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
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

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isprivate")]
    [Obsolete]
    public bool? IsPrivate => this.GetAttributeValue<bool?>("isprivate");

    [AttributeLogicalName("isquickfindquery")]
    public bool? IsQuickFindQuery
    {
      get => this.GetAttributeValue<bool?>("isquickfindquery");
      set
      {
        this.OnPropertyChanging(nameof (IsQuickFindQuery));
        this.SetAttributeValue("isquickfindquery", (object) value);
        this.OnPropertyChanged(nameof (IsQuickFindQuery));
      }
    }

    [AttributeLogicalName("isuserdefined")]
    public bool? IsUserDefined => this.GetAttributeValue<bool?>("isuserdefined");

    [AttributeLogicalName("layoutjson")]
    public string LayoutJson
    {
      get => this.GetAttributeValue<string>("layoutjson");
      set
      {
        this.OnPropertyChanging(nameof (LayoutJson));
        this.SetAttributeValue("layoutjson", (object) value);
        this.OnPropertyChanged(nameof (LayoutJson));
      }
    }

    [AttributeLogicalName("layoutxml")]
    public string LayoutXml
    {
      get => this.GetAttributeValue<string>("layoutxml");
      set
      {
        this.OnPropertyChanging(nameof (LayoutXml));
        this.SetAttributeValue("layoutxml", (object) value);
        this.OnPropertyChanged(nameof (LayoutXml));
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

    [AttributeLogicalName("offlinesqlquery")]
    public string OfflineSqlQuery
    {
      get => this.GetAttributeValue<string>("offlinesqlquery");
      set
      {
        this.OnPropertyChanging(nameof (OfflineSqlQuery));
        this.SetAttributeValue("offlinesqlquery", (object) value);
        this.OnPropertyChanged(nameof (OfflineSqlQuery));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("organizationtaborder")]
    public int? OrganizationTabOrder => this.GetAttributeValue<int?>("organizationtaborder");

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("queryapi")]
    public string QueryAPI => this.GetAttributeValue<string>("queryapi");

    [AttributeLogicalName("queryappusage")]
    public int? QueryAppUsage
    {
      get => this.GetAttributeValue<int?>("queryappusage");
      set
      {
        this.OnPropertyChanging(nameof (QueryAppUsage));
        this.SetAttributeValue("queryappusage", (object) value);
        this.OnPropertyChanged(nameof (QueryAppUsage));
      }
    }

    [AttributeLogicalName("querytype")]
    public int? QueryType
    {
      get => this.GetAttributeValue<int?>("querytype");
      set
      {
        this.OnPropertyChanging(nameof (QueryType));
        this.SetAttributeValue("querytype", (object) value);
        this.OnPropertyChanged(nameof (QueryType));
      }
    }

    [AttributeLogicalName("returnedtypecode")]
    public string ReturnedTypeCode
    {
      get => this.GetAttributeValue<string>("returnedtypecode");
      set
      {
        this.OnPropertyChanging(nameof (ReturnedTypeCode));
        this.SetAttributeValue("returnedtypecode", (object) value);
        this.OnPropertyChanged(nameof (ReturnedTypeCode));
      }
    }

    [AttributeLogicalName("savedqueryid")]
    public Guid? SavedQueryId
    {
      get => this.GetAttributeValue<Guid?>("savedqueryid");
      set
      {
        this.OnPropertyChanging(nameof (SavedQueryId));
        this.SetAttributeValue("savedqueryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SavedQueryId));
      }
    }

    [AttributeLogicalName("savedqueryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SavedQueryId = new Guid?(value);
    }

    [AttributeLogicalName("savedqueryidunique")]
    public Guid? SavedQueryIdUnique => this.GetAttributeValue<Guid?>("savedqueryidunique");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public SavedQueryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SavedQueryState?((SavedQueryState) Enum.ToObject(typeof (SavedQueryState), attributeValue.Value)) : new SavedQueryState?();
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("lk_mobileofflineprofileitem_savedquery")]
    public IEnumerable<MobileOfflineProfileItem> lk_mobileofflineprofileitem_savedquery
    {
      get
      {
        return this.GetRelatedEntities<MobileOfflineProfileItem>(nameof (lk_mobileofflineprofileitem_savedquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mobileofflineprofileitem_savedquery));
        this.SetRelatedEntities<MobileOfflineProfileItem>(nameof (lk_mobileofflineprofileitem_savedquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mobileofflineprofileitem_savedquery));
      }
    }

    [RelationshipSchemaName("SavedQuery_AsyncOperations")]
    public IEnumerable<AsyncOperation> SavedQuery_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (SavedQuery_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SavedQuery_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (SavedQuery_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SavedQuery_AsyncOperations));
      }
    }

    [RelationshipSchemaName("SavedQuery_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> SavedQuery_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (SavedQuery_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SavedQuery_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (SavedQuery_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SavedQuery_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("SavedQuery_SyncErrors")]
    public IEnumerable<SyncError> SavedQuery_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (SavedQuery_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (SavedQuery_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SavedQuery_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SavedQuery_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_savedquery")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_savedquery
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_savedquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_savedquery));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_savedquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_savedquery));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_savedquery_createdonbehalfby")]
    public SystemUser lk_savedquery_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedquery_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_savedquery_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_savedquery_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_savedquery_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_savedquery_modifiedonbehalfby")]
    public SystemUser lk_savedquery_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedquery_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_savedquery_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_savedquery_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_savedquery_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_savedquerybase_createdby")]
    public SystemUser lk_savedquerybase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedquerybase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_savedquerybase_modifiedby")]
    public SystemUser lk_savedquerybase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_savedquerybase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_saved_queries")]
    public Organization organization_saved_queries
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_saved_queries), new EntityRole?());
      }
    }

    public SavedQuery(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["savedqueryid"] = (object) base.Id;
            break;
          case "savedqueryid":
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
