// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.KnowledgeArticleViews
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("knowledgearticleviews")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class KnowledgeArticleViews : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "knowledgearticleviews";
    public const string EntitySchemaName = "KnowledgeArticleViews";
    public const string PrimaryIdAttribute = "knowledgearticleviewsid";
    public const string PrimaryNameAttribute = "knowledgearticleidname";

    public KnowledgeArticleViews()
      : base("knowledgearticleviews")
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("knowledgearticleid")]
    public EntityReference KnowledgeArticleId
    {
      get => this.GetAttributeValue<EntityReference>("knowledgearticleid");
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticleId));
        this.SetAttributeValue("knowledgearticleid", (object) value);
        this.OnPropertyChanged(nameof (KnowledgeArticleId));
      }
    }

    [AttributeLogicalName("knowledgearticleview")]
    public int? KnowledgeArticleView
    {
      get => this.GetAttributeValue<int?>("knowledgearticleview");
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticleView));
        this.SetAttributeValue("knowledgearticleview", (object) value);
        this.OnPropertyChanged(nameof (KnowledgeArticleView));
      }
    }

    [AttributeLogicalName("knowledgearticleviewsid")]
    public Guid? KnowledgeArticleViewsId
    {
      get => this.GetAttributeValue<Guid?>("knowledgearticleviewsid");
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticleViewsId));
        this.SetAttributeValue("knowledgearticleviewsid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (KnowledgeArticleViewsId));
      }
    }

    [AttributeLogicalName("knowledgearticleviewsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.KnowledgeArticleViewsId = new Guid?(value);
    }

    [AttributeLogicalName("location")]
    public OptionSetValue Location
    {
      get => this.GetAttributeValue<OptionSetValue>("location");
      set
      {
        this.OnPropertyChanging(nameof (Location));
        this.SetAttributeValue("location", (object) value);
        this.OnPropertyChanged(nameof (Location));
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
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

    [AttributeLogicalName("statecode")]
    public KnowledgeArticleViewsState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new KnowledgeArticleViewsState?((KnowledgeArticleViewsState) Enum.ToObject(typeof (KnowledgeArticleViewsState), attributeValue.Value)) : new KnowledgeArticleViewsState?();
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

    [AttributeLogicalName("viewdate")]
    public DateTime? ViewDate
    {
      get => this.GetAttributeValue<DateTime?>("viewdate");
      set
      {
        this.OnPropertyChanging(nameof (ViewDate));
        this.SetAttributeValue("viewdate", (object) value);
        this.OnPropertyChanged(nameof (ViewDate));
      }
    }

    [RelationshipSchemaName("knowledgearticleview_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> knowledgearticleview_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (knowledgearticleview_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticleview_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (knowledgearticleview_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticleview_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("KnowledgeArticleViews_SyncErrors")]
    public IEnumerable<SyncError> KnowledgeArticleViews_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (KnowledgeArticleViews_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticleViews_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (KnowledgeArticleViews_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticleViews_SyncErrors));
      }
    }

    [AttributeLogicalName("knowledgearticleid")]
    [RelationshipSchemaName("knowledgearticle_views")]
    public KnowledgeArticle knowledgearticle_views
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_views), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_views));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_views), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_views));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_knowledgearticleviews_createdby")]
    public SystemUser lk_knowledgearticleviews_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgearticleviews_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_knowledgearticleviews_createdonbehalfby")]
    public SystemUser lk_knowledgearticleviews_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgearticleviews_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_knowledgearticleviews_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_knowledgearticleviews_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_knowledgearticleviews_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_knowledgearticleviews_modifiedby")]
    public SystemUser lk_knowledgearticleviews_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgearticleviews_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_knowledgearticleviews_modifiedonbehalfby")]
    public SystemUser lk_knowledgearticleviews_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgearticleviews_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_knowledgearticleviews_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_knowledgearticleviews_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_knowledgearticleviews_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_knowledgearticleviews")]
    public TransactionCurrency transactioncurrency_knowledgearticleviews
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_knowledgearticleviews), new EntityRole?());
      }
    }

    public KnowledgeArticleViews(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["knowledgearticleviewsid"] = (object) base.Id;
            break;
          case "knowledgearticleviewsid":
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
