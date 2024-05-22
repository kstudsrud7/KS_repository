// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.UserQuery
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("userquery")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class UserQuery : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "userquery";
    public const string EntitySchemaName = "UserQuery";
    public const string PrimaryIdAttribute = "userqueryid";
    public const string PrimaryNameAttribute = "name";

    public UserQuery()
      : base("userquery")
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

    [AttributeLogicalName("parentqueryid")]
    public EntityReference ParentQueryId
    {
      get => this.GetAttributeValue<EntityReference>("parentqueryid");
      set
      {
        this.OnPropertyChanging(nameof (ParentQueryId));
        this.SetAttributeValue("parentqueryid", (object) value);
        this.OnPropertyChanged(nameof (ParentQueryId));
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

    [AttributeLogicalName("statecode")]
    public UserQueryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new UserQueryState?((UserQueryState) Enum.ToObject(typeof (UserQueryState), attributeValue.Value)) : new UserQueryState?();
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

    [AttributeLogicalName("userqueryid")]
    public Guid? UserQueryId
    {
      get => this.GetAttributeValue<Guid?>("userqueryid");
      set
      {
        this.OnPropertyChanging(nameof (UserQueryId));
        this.SetAttributeValue("userqueryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (UserQueryId));
      }
    }

    [AttributeLogicalName("userqueryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.UserQueryId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_userquery")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_userquery
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_userquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_userquery));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_userquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_userquery));
      }
    }

    [RelationshipSchemaName("UserQuery_AsyncOperations")]
    public IEnumerable<AsyncOperation> UserQuery_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (UserQuery_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (UserQuery_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (UserQuery_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserQuery_AsyncOperations));
      }
    }

    [RelationshipSchemaName("UserQuery_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> UserQuery_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (UserQuery_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (UserQuery_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (UserQuery_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserQuery_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("UserQuery_SyncErrors")]
    public IEnumerable<SyncError> UserQuery_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (UserQuery_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (UserQuery_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (UserQuery_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserQuery_SyncErrors));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_userquery")]
    public BusinessUnit business_unit_userquery
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_userquery), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_userquery_createdby")]
    public SystemUser lk_userquery_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_userquery_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_userquery_createdonbehalfby")]
    public SystemUser lk_userquery_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_userquery_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_userquery_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_userquery_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_userquery_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_userquery_modifiedby")]
    public SystemUser lk_userquery_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_userquery_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_userquery_modifiedonbehalfby")]
    public SystemUser lk_userquery_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_userquery_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_userquery_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_userquery_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_userquery_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_userquery")]
    public Team team_userquery
    {
      get => this.GetRelatedEntity<Team>(nameof (team_userquery), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_userquery")]
    public SystemUser user_userquery
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_userquery), new EntityRole?());
    }

    public UserQuery(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["userqueryid"] = (object) base.Id;
            break;
          case "userqueryid":
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
