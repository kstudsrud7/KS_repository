// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.UserQueryVisualization
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("userqueryvisualization")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class UserQueryVisualization : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "userqueryvisualization";
    public const string EntitySchemaName = "UserQueryVisualization";
    public const string PrimaryIdAttribute = "userqueryvisualizationid";
    public const string PrimaryNameAttribute = "name";

    public UserQueryVisualization()
      : base("userqueryvisualization")
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

    [AttributeLogicalName("charttype")]
    public OptionSetValue ChartType
    {
      get => this.GetAttributeValue<OptionSetValue>("charttype");
      set
      {
        this.OnPropertyChanging(nameof (ChartType));
        this.SetAttributeValue("charttype", (object) value);
        this.OnPropertyChanged(nameof (ChartType));
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

    [AttributeLogicalName("datadescription")]
    public string DataDescription
    {
      get => this.GetAttributeValue<string>("datadescription");
      set
      {
        this.OnPropertyChanging(nameof (DataDescription));
        this.SetAttributeValue("datadescription", (object) value);
        this.OnPropertyChanged(nameof (DataDescription));
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

    [AttributeLogicalName("presentationdescription")]
    public string PresentationDescription
    {
      get => this.GetAttributeValue<string>("presentationdescription");
      set
      {
        this.OnPropertyChanging(nameof (PresentationDescription));
        this.SetAttributeValue("presentationdescription", (object) value);
        this.OnPropertyChanged(nameof (PresentationDescription));
      }
    }

    [AttributeLogicalName("primaryentitytypecode")]
    public string PrimaryEntityTypeCode
    {
      get => this.GetAttributeValue<string>("primaryentitytypecode");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityTypeCode));
        this.SetAttributeValue("primaryentitytypecode", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityTypeCode));
      }
    }

    [AttributeLogicalName("userqueryvisualizationid")]
    public Guid? UserQueryVisualizationId
    {
      get => this.GetAttributeValue<Guid?>("userqueryvisualizationid");
      set
      {
        this.OnPropertyChanging(nameof (UserQueryVisualizationId));
        this.SetAttributeValue("userqueryvisualizationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (UserQueryVisualizationId));
      }
    }

    [AttributeLogicalName("userqueryvisualizationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.UserQueryVisualizationId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("webresourceid")]
    public EntityReference WebResourceId
    {
      get => this.GetAttributeValue<EntityReference>("webresourceid");
      set
      {
        this.OnPropertyChanging(nameof (WebResourceId));
        this.SetAttributeValue("webresourceid", (object) value);
        this.OnPropertyChanged(nameof (WebResourceId));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_userqueryvisualization")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_userqueryvisualization
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_userqueryvisualization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_userqueryvisualization));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_userqueryvisualization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_userqueryvisualization));
      }
    }

    [RelationshipSchemaName("UserQueryVisualization_SyncErrors")]
    public IEnumerable<SyncError> UserQueryVisualization_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (UserQueryVisualization_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (UserQueryVisualization_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (UserQueryVisualization_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserQueryVisualization_SyncErrors));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_userqueryvisualizations")]
    public BusinessUnit business_unit_userqueryvisualizations
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_userqueryvisualizations), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_userqueryvisualization_createdby")]
    public SystemUser lk_userqueryvisualization_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_userqueryvisualization_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_userqueryvisualization_modifiedby")]
    public SystemUser lk_userqueryvisualization_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_userqueryvisualization_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_userqueryvisualizationbase_createdonbehalfby")]
    public SystemUser lk_userqueryvisualizationbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_userqueryvisualizationbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_userqueryvisualizationbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_userqueryvisualizationbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_userqueryvisualizationbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_userqueryvisualizationbase_modifiedonbehalfby")]
    public SystemUser lk_userqueryvisualizationbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_userqueryvisualizationbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_userqueryvisualizationbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_userqueryvisualizationbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_userqueryvisualizationbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_userqueryvisualizations")]
    public Team team_userqueryvisualizations
    {
      get => this.GetRelatedEntity<Team>(nameof (team_userqueryvisualizations), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_userqueryvisualizations")]
    public SystemUser user_userqueryvisualizations
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_userqueryvisualizations), new EntityRole?());
      }
    }

    [AttributeLogicalName("webresourceid")]
    [RelationshipSchemaName("webresource_userqueryvisualizations")]
    public WebResource webresource_userqueryvisualizations
    {
      get
      {
        return this.GetRelatedEntity<WebResource>(nameof (webresource_userqueryvisualizations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (webresource_userqueryvisualizations));
        this.SetRelatedEntity<WebResource>(nameof (webresource_userqueryvisualizations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (webresource_userqueryvisualizations));
      }
    }

    public UserQueryVisualization(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["userqueryvisualizationid"] = (object) base.Id;
            break;
          case "userqueryvisualizationid":
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
