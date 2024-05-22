// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Category
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("category")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Category : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "category";
    public const string EntitySchemaName = "Category";
    public const string PrimaryIdAttribute = "categoryid";
    public const string PrimaryNameAttribute = "title";

    public Category()
      : base("category")
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

    [AttributeLogicalName("categoryid")]
    public Guid? CategoryId
    {
      get => this.GetAttributeValue<Guid?>("categoryid");
      set
      {
        this.OnPropertyChanging(nameof (CategoryId));
        this.SetAttributeValue("categoryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CategoryId));
      }
    }

    [AttributeLogicalName("categoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CategoryId = new Guid?(value);
    }

    [AttributeLogicalName("categorynumber")]
    public string CategoryNumber
    {
      get => this.GetAttributeValue<string>("categorynumber");
      set
      {
        this.OnPropertyChanging(nameof (CategoryNumber));
        this.SetAttributeValue("categorynumber", (object) value);
        this.OnPropertyChanged(nameof (CategoryNumber));
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

    [AttributeLogicalName("parentcategoryid")]
    public EntityReference ParentCategoryId
    {
      get => this.GetAttributeValue<EntityReference>("parentcategoryid");
      set
      {
        this.OnPropertyChanging(nameof (ParentCategoryId));
        this.SetAttributeValue("parentcategoryid", (object) value);
        this.OnPropertyChanged(nameof (ParentCategoryId));
      }
    }

    [AttributeLogicalName("sequencenumber")]
    public int? SequenceNumber
    {
      get => this.GetAttributeValue<int?>("sequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (SequenceNumber));
        this.SetAttributeValue("sequencenumber", (object) value);
        this.OnPropertyChanged(nameof (SequenceNumber));
      }
    }

    [AttributeLogicalName("title")]
    public string Title
    {
      get => this.GetAttributeValue<string>("title");
      set
      {
        this.OnPropertyChanging(nameof (Title));
        this.SetAttributeValue("title", (object) value);
        this.OnPropertyChanged(nameof (Title));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName]
    public IEnumerable<Category> Referencedcategory_parent_category
    {
      get
      {
        return this.GetRelatedEntities<Category>("category_parent_category", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedcategory_parent_category));
        this.SetRelatedEntities<Category>("category_parent_category", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedcategory_parent_category));
      }
    }

    [RelationshipSchemaName("Category_SyncErrors")]
    public IEnumerable<SyncError> Category_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Category_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Category_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Category_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Category_SyncErrors));
      }
    }

    [RelationshipSchemaName("knowledgearticle_category")]
    public IEnumerable<KnowledgeArticle> knowledgearticle_category
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>(nameof (knowledgearticle_category), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_category));
        this.SetRelatedEntities<KnowledgeArticle>(nameof (knowledgearticle_category), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_category));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_category")]
    public BusinessUnit business_unit_category
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_category), new EntityRole?());
      }
    }

    [AttributeLogicalName("parentcategoryid")]
    [RelationshipSchemaName]
    public Category Referencingcategory_parent_category
    {
      get
      {
        return this.GetRelatedEntity<Category>("category_parent_category", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingcategory_parent_category));
        this.SetRelatedEntity<Category>("category_parent_category", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingcategory_parent_category));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_category_createdby")]
    public SystemUser lk_category_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_category_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_category_createdonbehalfby")]
    public SystemUser lk_category_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_category_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_category_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_category_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_category_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_category_modifiedby")]
    public SystemUser lk_category_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_category_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_category_modifiedonbehalfby")]
    public SystemUser lk_category_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_category_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_category_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_category_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_category_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_category")]
    public TransactionCurrency transactioncurrency_category
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_category), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_category));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_category), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_category));
      }
    }

    public Category(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["categoryid"] = (object) base.Id;
            break;
          case "categoryid":
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
