// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.DocumentIndex
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("documentindex")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class DocumentIndex : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "documentindex";
    public const string EntitySchemaName = "DocumentIndex";
    public const string PrimaryIdAttribute = "documentindexid";
    public const string PrimaryNameAttribute = "title";

    public DocumentIndex()
      : base("documentindex")
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

    [AttributeLogicalName("documentid")]
    public EntityReference DocumentId
    {
      get => this.GetAttributeValue<EntityReference>("documentid");
      set
      {
        this.OnPropertyChanging(nameof (DocumentId));
        this.SetAttributeValue("documentid", (object) value);
        this.OnPropertyChanged(nameof (DocumentId));
      }
    }

    [AttributeLogicalName("documentindexid")]
    public Guid? DocumentIndexId
    {
      get => this.GetAttributeValue<Guid?>("documentindexid");
      set
      {
        this.OnPropertyChanging(nameof (DocumentIndexId));
        this.SetAttributeValue("documentindexid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (DocumentIndexId));
      }
    }

    [AttributeLogicalName("documentindexid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.DocumentIndexId = new Guid?(value);
    }

    [AttributeLogicalName("documenttypecode")]
    public OptionSetValue DocumentTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("documenttypecode");
      set
      {
        this.OnPropertyChanging(nameof (DocumentTypeCode));
        this.SetAttributeValue("documenttypecode", (object) value);
        this.OnPropertyChanged(nameof (DocumentTypeCode));
      }
    }

    [AttributeLogicalName("islatestversion")]
    public bool? IsLatestVersion
    {
      get => this.GetAttributeValue<bool?>("islatestversion");
      set
      {
        this.OnPropertyChanging(nameof (IsLatestVersion));
        this.SetAttributeValue("islatestversion", (object) value);
        this.OnPropertyChanged(nameof (IsLatestVersion));
      }
    }

    [AttributeLogicalName("ispublished")]
    public bool? IsPublished
    {
      get => this.GetAttributeValue<bool?>("ispublished");
      set
      {
        this.OnPropertyChanging(nameof (IsPublished));
        this.SetAttributeValue("ispublished", (object) value);
        this.OnPropertyChanged(nameof (IsPublished));
      }
    }

    [AttributeLogicalName("keywords")]
    public string KeyWords
    {
      get => this.GetAttributeValue<string>("keywords");
      set
      {
        this.OnPropertyChanging(nameof (KeyWords));
        this.SetAttributeValue("keywords", (object) value);
        this.OnPropertyChanged(nameof (KeyWords));
      }
    }

    [AttributeLogicalName("location")]
    public string Location
    {
      get => this.GetAttributeValue<string>("location");
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

    [AttributeLogicalName("number")]
    public string Number
    {
      get => this.GetAttributeValue<string>("number");
      set
      {
        this.OnPropertyChanging(nameof (Number));
        this.SetAttributeValue("number", (object) value);
        this.OnPropertyChanged(nameof (Number));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("searchtext")]
    public string SearchText
    {
      get => this.GetAttributeValue<string>("searchtext");
      set
      {
        this.OnPropertyChanging(nameof (SearchText));
        this.SetAttributeValue("searchtext", (object) value);
        this.OnPropertyChanged(nameof (SearchText));
      }
    }

    [AttributeLogicalName("subjectid")]
    public EntityReference SubjectId
    {
      get => this.GetAttributeValue<EntityReference>("subjectid");
      set
      {
        this.OnPropertyChanging(nameof (SubjectId));
        this.SetAttributeValue("subjectid", (object) value);
        this.OnPropertyChanged(nameof (SubjectId));
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_documentindex")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_documentindex
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_documentindex), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_documentindex));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_documentindex), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_documentindex));
      }
    }

    [AttributeLogicalName("subjectid")]
    [RelationshipSchemaName("is_primary_subject_for")]
    public Subject is_primary_subject_for
    {
      get => this.GetRelatedEntity<Subject>(nameof (is_primary_subject_for), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (is_primary_subject_for));
        this.SetRelatedEntity<Subject>(nameof (is_primary_subject_for), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (is_primary_subject_for));
      }
    }

    [AttributeLogicalName("documentid")]
    [RelationshipSchemaName("KbArticle_DocumentIndex")]
    public KbArticle KbArticle_DocumentIndex
    {
      get => this.GetRelatedEntity<KbArticle>(nameof (KbArticle_DocumentIndex), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_DocumentIndex));
        this.SetRelatedEntity<KbArticle>(nameof (KbArticle_DocumentIndex), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_DocumentIndex));
      }
    }

    [AttributeLogicalName("documentid")]
    [RelationshipSchemaName("knowledgearticle_documentindex")]
    public KnowledgeArticle knowledgearticle_documentindex
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_documentindex), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_documentindex));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_documentindex), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_documentindex));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_documentindex_createdby")]
    public SystemUser lk_documentindex_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_documentindex_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_documentindex_createdonbehalfby")]
    public SystemUser lk_documentindex_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_documentindex_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_documentindex_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_documentindex_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_documentindex_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_documentindex_modifiedby")]
    public SystemUser lk_documentindex_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_documentindex_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_documentindex_modifiedonbehalfby")]
    public SystemUser lk_documentindex_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_documentindex_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_documentindex_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_documentindex_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_documentindex_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_indexed_documents")]
    public Organization organization_indexed_documents
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_indexed_documents), new EntityRole?());
      }
    }

    public DocumentIndex(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["documentindexid"] = (object) base.Id;
            break;
          case "documentindexid":
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
