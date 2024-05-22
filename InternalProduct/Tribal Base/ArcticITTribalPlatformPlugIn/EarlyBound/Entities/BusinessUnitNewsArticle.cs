// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.BusinessUnitNewsArticle
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("businessunitnewsarticle")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class BusinessUnitNewsArticle : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "businessunitnewsarticle";
    public const string EntitySchemaName = "BusinessUnitNewsArticle";
    public const string PrimaryIdAttribute = "businessunitnewsarticleid";
    public const string PrimaryNameAttribute = "articletitle";

    public BusinessUnitNewsArticle()
      : base("businessunitnewsarticle")
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

    [AttributeLogicalName("activeon")]
    public DateTime? ActiveOn
    {
      get => this.GetAttributeValue<DateTime?>("activeon");
      set
      {
        this.OnPropertyChanging(nameof (ActiveOn));
        this.SetAttributeValue("activeon", (object) value);
        this.OnPropertyChanged(nameof (ActiveOn));
      }
    }

    [AttributeLogicalName("activeuntil")]
    public DateTime? ActiveUntil
    {
      get => this.GetAttributeValue<DateTime?>("activeuntil");
      set
      {
        this.OnPropertyChanging(nameof (ActiveUntil));
        this.SetAttributeValue("activeuntil", (object) value);
        this.OnPropertyChanged(nameof (ActiveUntil));
      }
    }

    [AttributeLogicalName("articletitle")]
    public string ArticleTitle
    {
      get => this.GetAttributeValue<string>("articletitle");
      set
      {
        this.OnPropertyChanging(nameof (ArticleTitle));
        this.SetAttributeValue("articletitle", (object) value);
        this.OnPropertyChanged(nameof (ArticleTitle));
      }
    }

    [AttributeLogicalName("articletypecode")]
    public OptionSetValue ArticleTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("articletypecode");
      set
      {
        this.OnPropertyChanging(nameof (ArticleTypeCode));
        this.SetAttributeValue("articletypecode", (object) value);
        this.OnPropertyChanged(nameof (ArticleTypeCode));
      }
    }

    [AttributeLogicalName("articleurl")]
    public string ArticleUrl
    {
      get => this.GetAttributeValue<string>("articleurl");
      set
      {
        this.OnPropertyChanging(nameof (ArticleUrl));
        this.SetAttributeValue("articleurl", (object) value);
        this.OnPropertyChanged(nameof (ArticleUrl));
      }
    }

    [AttributeLogicalName("businessunitnewsarticleid")]
    public Guid? BusinessUnitNewsArticleId
    {
      get => this.GetAttributeValue<Guid?>("businessunitnewsarticleid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitNewsArticleId));
        this.SetAttributeValue("businessunitnewsarticleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (BusinessUnitNewsArticleId));
      }
    }

    [AttributeLogicalName("businessunitnewsarticleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.BusinessUnitNewsArticleId = new Guid?(value);
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

    [AttributeLogicalName("newsarticle")]
    public string NewsArticle
    {
      get => this.GetAttributeValue<string>("newsarticle");
      set
      {
        this.OnPropertyChanging(nameof (NewsArticle));
        this.SetAttributeValue("newsarticle", (object) value);
        this.OnPropertyChanged(nameof (NewsArticle));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("showonhomepage")]
    public bool? ShowOnHomepage
    {
      get => this.GetAttributeValue<bool?>("showonhomepage");
      set
      {
        this.OnPropertyChanging(nameof (ShowOnHomepage));
        this.SetAttributeValue("showonhomepage", (object) value);
        this.OnPropertyChanged(nameof (ShowOnHomepage));
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

    [RelationshipSchemaName("BusinessUnitNewsArticle_AsyncOperations")]
    public IEnumerable<AsyncOperation> BusinessUnitNewsArticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (BusinessUnitNewsArticle_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitNewsArticle_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (BusinessUnitNewsArticle_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnitNewsArticle_AsyncOperations));
      }
    }

    [RelationshipSchemaName("BusinessUnitNewsArticle_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> BusinessUnitNewsArticle_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (BusinessUnitNewsArticle_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitNewsArticle_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (BusinessUnitNewsArticle_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnitNewsArticle_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("BusinessUnitNewsArticle_ProcessSessions")]
    public IEnumerable<ProcessSession> BusinessUnitNewsArticle_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (BusinessUnitNewsArticle_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitNewsArticle_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (BusinessUnitNewsArticle_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnitNewsArticle_ProcessSessions));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_businessunitnewsarticle")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_businessunitnewsarticle
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_businessunitnewsarticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_businessunitnewsarticle));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_businessunitnewsarticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_businessunitnewsarticle));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_businessunitnewsarticle_createdonbehalfby")]
    public SystemUser lk_businessunitnewsarticle_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessunitnewsarticle_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_businessunitnewsarticle_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_businessunitnewsarticle_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessunitnewsarticle_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_businessunitnewsarticle_modifiedonbehalfby")]
    public SystemUser lk_businessunitnewsarticle_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessunitnewsarticle_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_businessunitnewsarticle_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_businessunitnewsarticle_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessunitnewsarticle_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_businessunitnewsarticlebase_createdby")]
    public SystemUser lk_businessunitnewsarticlebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessunitnewsarticlebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_businessunitnewsarticlebase_modifiedby")]
    public SystemUser lk_businessunitnewsarticlebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessunitnewsarticlebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_business_unit_news_articles")]
    public Organization organization_business_unit_news_articles
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_business_unit_news_articles), new EntityRole?());
      }
    }

    public BusinessUnitNewsArticle(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["businessunitnewsarticleid"] = (object) base.Id;
            break;
          case "businessunitnewsarticleid":
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
