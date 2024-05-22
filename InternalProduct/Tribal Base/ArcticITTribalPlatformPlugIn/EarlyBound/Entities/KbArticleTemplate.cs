// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.KbArticleTemplate
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("kbarticletemplate")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class KbArticleTemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "kbarticletemplate";
    public const string EntitySchemaName = "KbArticleTemplate";
    public const string PrimaryIdAttribute = "kbarticletemplateid";
    public const string PrimaryNameAttribute = "title";

    public KbArticleTemplate()
      : base("kbarticletemplate")
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

    [AttributeLogicalName("formatxml")]
    public string FormatXml
    {
      get => this.GetAttributeValue<string>("formatxml");
      set
      {
        this.OnPropertyChanging(nameof (FormatXml));
        this.SetAttributeValue("formatxml", (object) value);
        this.OnPropertyChanged(nameof (FormatXml));
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

    [AttributeLogicalName("isactive")]
    public bool? IsActive
    {
      get => this.GetAttributeValue<bool?>("isactive");
      set
      {
        this.OnPropertyChanging(nameof (IsActive));
        this.SetAttributeValue("isactive", (object) value);
        this.OnPropertyChanged(nameof (IsActive));
      }
    }

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

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("kbarticletemplateid")]
    public Guid? KbArticleTemplateId
    {
      get => this.GetAttributeValue<Guid?>("kbarticletemplateid");
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplateId));
        this.SetAttributeValue("kbarticletemplateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (KbArticleTemplateId));
      }
    }

    [AttributeLogicalName("kbarticletemplateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.KbArticleTemplateId = new Guid?(value);
    }

    [AttributeLogicalName("kbarticletemplateidunique")]
    public Guid? KbArticleTemplateIdUnique
    {
      get => this.GetAttributeValue<Guid?>("kbarticletemplateidunique");
    }

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get => this.GetAttributeValue<int?>("languagecode");
      set
      {
        this.OnPropertyChanging(nameof (LanguageCode));
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged(nameof (LanguageCode));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("structurexml")]
    public string StructureXml
    {
      get => this.GetAttributeValue<string>("structurexml");
      set
      {
        this.OnPropertyChanging(nameof (StructureXml));
        this.SetAttributeValue("structurexml", (object) value);
        this.OnPropertyChanged(nameof (StructureXml));
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

    [RelationshipSchemaName("kb_article_template_kb_articles")]
    public IEnumerable<KbArticle> kb_article_template_kb_articles
    {
      get
      {
        return this.GetRelatedEntities<KbArticle>(nameof (kb_article_template_kb_articles), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (kb_article_template_kb_articles));
        this.SetRelatedEntities<KbArticle>(nameof (kb_article_template_kb_articles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (kb_article_template_kb_articles));
      }
    }

    [RelationshipSchemaName("KbArticleTemplate_AsyncOperations")]
    public IEnumerable<AsyncOperation> KbArticleTemplate_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (KbArticleTemplate_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplate_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (KbArticleTemplate_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleTemplate_AsyncOperations));
      }
    }

    [RelationshipSchemaName("KbArticleTemplate_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> KbArticleTemplate_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (KbArticleTemplate_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplate_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (KbArticleTemplate_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleTemplate_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("KbArticleTemplate_ProcessSessions")]
    public IEnumerable<ProcessSession> KbArticleTemplate_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (KbArticleTemplate_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplate_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (KbArticleTemplate_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleTemplate_ProcessSessions));
      }
    }

    [RelationshipSchemaName("KbArticleTemplate_SyncErrors")]
    public IEnumerable<SyncError> KbArticleTemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (KbArticleTemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplate_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (KbArticleTemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleTemplate_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_kbarticletemplate")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticletemplate
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_kbarticletemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_kbarticletemplate));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_kbarticletemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_kbarticletemplate));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_kbarticletemplate_createdonbehalfby")]
    public SystemUser lk_kbarticletemplate_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticletemplate_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_kbarticletemplate_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_kbarticletemplate_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_kbarticletemplate_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_kbarticletemplate_modifiedonbehalfby")]
    public SystemUser lk_kbarticletemplate_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticletemplate_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_kbarticletemplate_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_kbarticletemplate_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_kbarticletemplate_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_kbarticletemplatebase_createdby")]
    public SystemUser lk_kbarticletemplatebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticletemplatebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_kbarticletemplatebase_modifiedby")]
    public SystemUser lk_kbarticletemplatebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticletemplatebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_kb_article_templates")]
    public Organization organization_kb_article_templates
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_kb_article_templates), new EntityRole?());
      }
    }

    public KbArticleTemplate(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["kbarticletemplateid"] = (object) base.Id;
            break;
          case "kbarticletemplateid":
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
