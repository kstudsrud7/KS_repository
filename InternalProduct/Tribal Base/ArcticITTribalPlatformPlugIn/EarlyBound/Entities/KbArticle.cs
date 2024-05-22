// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.KbArticle
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("kbarticle")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class KbArticle : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "kbarticle";
    public const string EntitySchemaName = "KbArticle";
    public const string PrimaryIdAttribute = "kbarticleid";
    public const string PrimaryNameAttribute = "title";

    public KbArticle()
      : base("kbarticle")
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

    [AttributeLogicalName("adx_averagerating")]
    public double? adx_averagerating
    {
      get => this.GetAttributeValue<double?>(nameof (adx_averagerating));
      set
      {
        this.OnPropertyChanging(nameof (adx_averagerating));
        this.SetAttributeValue(nameof (adx_averagerating), (object) value);
        this.OnPropertyChanged(nameof (adx_averagerating));
      }
    }

    [AttributeLogicalName("adx_averagerating_int")]
    public int? adx_averagerating_int
    {
      get => this.GetAttributeValue<int?>(nameof (adx_averagerating_int));
      set
      {
        this.OnPropertyChanging(nameof (adx_averagerating_int));
        this.SetAttributeValue(nameof (adx_averagerating_int), (object) value);
        this.OnPropertyChanged(nameof (adx_averagerating_int));
      }
    }

    [AttributeLogicalName("adx_downvotes")]
    public int? adx_downvotes
    {
      get => this.GetAttributeValue<int?>(nameof (adx_downvotes));
      set
      {
        this.OnPropertyChanging(nameof (adx_downvotes));
        this.SetAttributeValue(nameof (adx_downvotes), (object) value);
        this.OnPropertyChanged(nameof (adx_downvotes));
      }
    }

    [AttributeLogicalName("adx_ratingcount")]
    public int? adx_ratingcount
    {
      get => this.GetAttributeValue<int?>(nameof (adx_ratingcount));
      set
      {
        this.OnPropertyChanging(nameof (adx_ratingcount));
        this.SetAttributeValue(nameof (adx_ratingcount), (object) value);
        this.OnPropertyChanged(nameof (adx_ratingcount));
      }
    }

    [AttributeLogicalName("adx_ratingsum")]
    public int? adx_ratingsum
    {
      get => this.GetAttributeValue<int?>(nameof (adx_ratingsum));
      set
      {
        this.OnPropertyChanging(nameof (adx_ratingsum));
        this.SetAttributeValue(nameof (adx_ratingsum), (object) value);
        this.OnPropertyChanged(nameof (adx_ratingsum));
      }
    }

    [AttributeLogicalName("adx_upvotes")]
    public int? adx_upvotes
    {
      get => this.GetAttributeValue<int?>(nameof (adx_upvotes));
      set
      {
        this.OnPropertyChanging(nameof (adx_upvotes));
        this.SetAttributeValue(nameof (adx_upvotes), (object) value);
        this.OnPropertyChanged(nameof (adx_upvotes));
      }
    }

    [AttributeLogicalName("articlexml")]
    public string ArticleXml
    {
      get => this.GetAttributeValue<string>("articlexml");
      set
      {
        this.OnPropertyChanging(nameof (ArticleXml));
        this.SetAttributeValue("articlexml", (object) value);
        this.OnPropertyChanged(nameof (ArticleXml));
      }
    }

    [AttributeLogicalName("comments")]
    public string Comments
    {
      get => this.GetAttributeValue<string>("comments");
      set
      {
        this.OnPropertyChanging(nameof (Comments));
        this.SetAttributeValue("comments", (object) value);
        this.OnPropertyChanged(nameof (Comments));
      }
    }

    [AttributeLogicalName("content")]
    public string Content => this.GetAttributeValue<string>("content");

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

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

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

    [AttributeLogicalName("kbarticleid")]
    public Guid? KbArticleId
    {
      get => this.GetAttributeValue<Guid?>("kbarticleid");
      set
      {
        this.OnPropertyChanging(nameof (KbArticleId));
        this.SetAttributeValue("kbarticleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (KbArticleId));
      }
    }

    [AttributeLogicalName("kbarticleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.KbArticleId = new Guid?(value);
    }

    [AttributeLogicalName("kbarticletemplateid")]
    public EntityReference KbArticleTemplateId
    {
      get => this.GetAttributeValue<EntityReference>("kbarticletemplateid");
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplateId));
        this.SetAttributeValue("kbarticletemplateid", (object) value);
        this.OnPropertyChanged(nameof (KbArticleTemplateId));
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

    [AttributeLogicalName("msa_publishtoweb")]
    public bool? msa_publishtoweb
    {
      get => this.GetAttributeValue<bool?>(nameof (msa_publishtoweb));
      set
      {
        this.OnPropertyChanging(nameof (msa_publishtoweb));
        this.SetAttributeValue(nameof (msa_publishtoweb), (object) value);
        this.OnPropertyChanged(nameof (msa_publishtoweb));
      }
    }

    [AttributeLogicalName("number")]
    public string Number => this.GetAttributeValue<string>("number");

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

    [AttributeLogicalName("statecode")]
    public KbArticleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new KbArticleState?((KbArticleState) Enum.ToObject(typeof (KbArticleState), attributeValue.Value)) : new KbArticleState?();
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

    [RelationshipSchemaName("KbArticle_Annotation")]
    public IEnumerable<Annotation> KbArticle_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (KbArticle_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (KbArticle_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_Annotation));
      }
    }

    [RelationshipSchemaName("KbArticle_AsyncOperations")]
    public IEnumerable<AsyncOperation> KbArticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (KbArticle_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (KbArticle_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_AsyncOperations));
      }
    }

    [RelationshipSchemaName("KbArticle_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> KbArticle_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (KbArticle_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (KbArticle_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("kbarticle_comments")]
    public IEnumerable<KbArticleComment> kbarticle_comments
    {
      get
      {
        return this.GetRelatedEntities<KbArticleComment>(nameof (kbarticle_comments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (kbarticle_comments));
        this.SetRelatedEntities<KbArticleComment>(nameof (kbarticle_comments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (kbarticle_comments));
      }
    }

    [RelationshipSchemaName("KbArticle_DocumentIndex")]
    public IEnumerable<DocumentIndex> KbArticle_DocumentIndex
    {
      get
      {
        return this.GetRelatedEntities<DocumentIndex>(nameof (KbArticle_DocumentIndex), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_DocumentIndex));
        this.SetRelatedEntities<DocumentIndex>(nameof (KbArticle_DocumentIndex), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_DocumentIndex));
      }
    }

    [RelationshipSchemaName("KbArticle_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> KbArticle_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (KbArticle_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (KbArticle_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("KbArticle_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> KbArticle_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (KbArticle_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (KbArticle_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("kbarticle_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> kbarticle_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (kbarticle_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (kbarticle_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (kbarticle_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (kbarticle_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("KbArticle_ProcessSessions")]
    public IEnumerable<ProcessSession> KbArticle_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (KbArticle_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (KbArticle_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_ProcessSessions));
      }
    }

    [RelationshipSchemaName("KbArticle_SharepointDocument")]
    public IEnumerable<SharePointDocument> KbArticle_SharepointDocument
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (KbArticle_SharepointDocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_SharepointDocument));
        this.SetRelatedEntities<SharePointDocument>(nameof (KbArticle_SharepointDocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_SharepointDocument));
      }
    }

    [RelationshipSchemaName("KbArticle_SharepointDocumentLocation")]
    public IEnumerable<SharePointDocumentLocation> KbArticle_SharepointDocumentLocation
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (KbArticle_SharepointDocumentLocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_SharepointDocumentLocation));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (KbArticle_SharepointDocumentLocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_SharepointDocumentLocation));
      }
    }

    [RelationshipSchemaName("KbArticle_SyncErrors")]
    public IEnumerable<SyncError> KbArticle_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (KbArticle_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (KbArticle_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_kbarticle")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticle
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_kbarticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_kbarticle));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_kbarticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_kbarticle));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<KbArticle> Referencingadx_kbarticle_kbarticle
    {
      get
      {
        return this.GetRelatedEntities<KbArticle>("adx_kbarticle_kbarticle", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingadx_kbarticle_kbarticle));
        this.SetRelatedEntities<KbArticle>("adx_kbarticle_kbarticle", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingadx_kbarticle_kbarticle));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<KbArticle> Referencedadx_kbarticle_kbarticle
    {
      get
      {
        return this.GetRelatedEntities<KbArticle>("adx_kbarticle_kbarticle", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedadx_kbarticle_kbarticle));
        this.SetRelatedEntities<KbArticle>("adx_kbarticle_kbarticle", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedadx_kbarticle_kbarticle));
      }
    }

    [AttributeLogicalName("kbarticletemplateid")]
    [RelationshipSchemaName("kb_article_template_kb_articles")]
    public KbArticleTemplate kb_article_template_kb_articles
    {
      get
      {
        return this.GetRelatedEntity<KbArticleTemplate>(nameof (kb_article_template_kb_articles), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (kb_article_template_kb_articles));
        this.SetRelatedEntity<KbArticleTemplate>(nameof (kb_article_template_kb_articles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (kb_article_template_kb_articles));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_kbarticle_createdonbehalfby")]
    public SystemUser lk_kbarticle_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticle_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_kbarticle_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_kbarticle_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_kbarticle_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_kbarticle_modifiedonbehalfby")]
    public SystemUser lk_kbarticle_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticle_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_kbarticle_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_kbarticle_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_kbarticle_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_kbarticlebase_createdby")]
    public SystemUser lk_kbarticlebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticlebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_kbarticlebase_modifiedby")]
    public SystemUser lk_kbarticlebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_kbarticlebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_kb_articles")]
    public Organization organization_kb_articles
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_kb_articles), new EntityRole?());
      }
    }

    [AttributeLogicalName("subjectid")]
    [RelationshipSchemaName("subject_kb_articles")]
    public Subject subject_kb_articles
    {
      get => this.GetRelatedEntity<Subject>(nameof (subject_kb_articles), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (subject_kb_articles));
        this.SetRelatedEntity<Subject>(nameof (subject_kb_articles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (subject_kb_articles));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_KbArticle")]
    public TransactionCurrency TransactionCurrency_KbArticle
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_KbArticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_KbArticle));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_KbArticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_KbArticle));
      }
    }

    public KbArticle(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["kbarticleid"] = (object) base.Id;
            break;
          case "kbarticleid":
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
