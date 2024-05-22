// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SiteMap
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sitemap")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SiteMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sitemap";
    public const string EntitySchemaName = "SiteMap";
    public const string PrimaryIdAttribute = "sitemapid";

    public SiteMap()
      : base("sitemap")
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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("isappaware")]
    public bool? IsAppAware
    {
      get => this.GetAttributeValue<bool?>("isappaware");
      set
      {
        this.OnPropertyChanging(nameof (IsAppAware));
        this.SetAttributeValue("isappaware", (object) value);
        this.OnPropertyChanged(nameof (IsAppAware));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("sitemapid")]
    public Guid? SiteMapId => this.GetAttributeValue<Guid?>("sitemapid");

    [AttributeLogicalName("sitemapid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("sitemapidunique")]
    public Guid? SiteMapIdUnique => this.GetAttributeValue<Guid?>("sitemapidunique");

    [AttributeLogicalName("sitemapname")]
    public string SiteMapName
    {
      get => this.GetAttributeValue<string>("sitemapname");
      set
      {
        this.OnPropertyChanging(nameof (SiteMapName));
        this.SetAttributeValue("sitemapname", (object) value);
        this.OnPropertyChanged(nameof (SiteMapName));
      }
    }

    [AttributeLogicalName("sitemapnameunique")]
    public string SiteMapNameUnique
    {
      get => this.GetAttributeValue<string>("sitemapnameunique");
      set
      {
        this.OnPropertyChanging(nameof (SiteMapNameUnique));
        this.SetAttributeValue("sitemapnameunique", (object) value);
        this.OnPropertyChanged(nameof (SiteMapNameUnique));
      }
    }

    [AttributeLogicalName("sitemapxml")]
    public string SiteMapXml
    {
      get => this.GetAttributeValue<string>("sitemapxml");
      set
      {
        this.OnPropertyChanging(nameof (SiteMapXml));
        this.SetAttributeValue("sitemapxml", (object) value);
        this.OnPropertyChanged(nameof (SiteMapXml));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_sitemap")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sitemap
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sitemap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sitemap));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sitemap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sitemap));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_SiteMap_createdby")]
    public SystemUser lk_SiteMap_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_SiteMap_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_SiteMap_createdonbehalfby")]
    public SystemUser lk_SiteMap_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_SiteMap_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_SiteMap_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_SiteMap_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_SiteMap_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_SiteMap_modifiedby")]
    public SystemUser lk_SiteMap_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_SiteMap_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_SiteMap_modifiedonbehalfby")]
    public SystemUser lk_SiteMap_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_SiteMap_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_SiteMap_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_SiteMap_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_SiteMap_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sitemap")]
    public Organization organization_sitemap
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_sitemap), new EntityRole?());
    }

    public SiteMap(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sitemapid"] = (object) base.Id;
            break;
          case "sitemapid":
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
