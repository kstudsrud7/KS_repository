// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.KnowledgeArticle
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("knowledgearticle")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class KnowledgeArticle : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "knowledgearticle";
    public const string EntitySchemaName = "KnowledgeArticle";
    public const string PrimaryIdAttribute = "knowledgearticleid";
    public const string PrimaryNameAttribute = "title";

    public KnowledgeArticle()
      : base("knowledgearticle")
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

    [AttributeLogicalName("articlepublicnumber")]
    public string ArticlePublicNumber
    {
      get => this.GetAttributeValue<string>("articlepublicnumber");
      set
      {
        this.OnPropertyChanging(nameof (ArticlePublicNumber));
        this.SetAttributeValue("articlepublicnumber", (object) value);
        this.OnPropertyChanged(nameof (ArticlePublicNumber));
      }
    }

    [AttributeLogicalName("content")]
    public string Content
    {
      get => this.GetAttributeValue<string>("content");
      set
      {
        this.OnPropertyChanging(nameof (Content));
        this.SetAttributeValue("content", (object) value);
        this.OnPropertyChanged(nameof (Content));
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

    [AttributeLogicalName("expirationdate")]
    public DateTime? ExpirationDate
    {
      get => this.GetAttributeValue<DateTime?>("expirationdate");
      set
      {
        this.OnPropertyChanging(nameof (ExpirationDate));
        this.SetAttributeValue("expirationdate", (object) value);
        this.OnPropertyChanged(nameof (ExpirationDate));
      }
    }

    [AttributeLogicalName("expirationstateid")]
    public int? ExpirationStateId
    {
      get => this.GetAttributeValue<int?>("expirationstateid");
      set
      {
        this.OnPropertyChanging(nameof (ExpirationStateId));
        this.SetAttributeValue("expirationstateid", (object) value);
        this.OnPropertyChanged(nameof (ExpirationStateId));
      }
    }

    [AttributeLogicalName("expirationstatusid")]
    public int? ExpirationStatusId
    {
      get => this.GetAttributeValue<int?>("expirationstatusid");
      set
      {
        this.OnPropertyChanging(nameof (ExpirationStatusId));
        this.SetAttributeValue("expirationstatusid", (object) value);
        this.OnPropertyChanged(nameof (ExpirationStatusId));
      }
    }

    [AttributeLogicalName("expiredreviewoptions")]
    public OptionSetValue ExpiredReviewOptions
    {
      get => this.GetAttributeValue<OptionSetValue>("expiredreviewoptions");
      set
      {
        this.OnPropertyChanging(nameof (ExpiredReviewOptions));
        this.SetAttributeValue("expiredreviewoptions", (object) value);
        this.OnPropertyChanged(nameof (ExpiredReviewOptions));
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

    [AttributeLogicalName("isinternal")]
    public bool? IsInternal
    {
      get => this.GetAttributeValue<bool?>("isinternal");
      set
      {
        this.OnPropertyChanging(nameof (IsInternal));
        this.SetAttributeValue("isinternal", (object) value);
        this.OnPropertyChanged(nameof (IsInternal));
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

    [AttributeLogicalName("isprimary")]
    public bool? IsPrimary
    {
      get => this.GetAttributeValue<bool?>("isprimary");
      set
      {
        this.OnPropertyChanging(nameof (IsPrimary));
        this.SetAttributeValue("isprimary", (object) value);
        this.OnPropertyChanged(nameof (IsPrimary));
      }
    }

    [AttributeLogicalName("isrootarticle")]
    public bool? IsRootArticle
    {
      get => this.GetAttributeValue<bool?>("isrootarticle");
      set
      {
        this.OnPropertyChanging(nameof (IsRootArticle));
        this.SetAttributeValue("isrootarticle", (object) value);
        this.OnPropertyChanged(nameof (IsRootArticle));
      }
    }

    [AttributeLogicalName("keywords")]
    public string Keywords
    {
      get => this.GetAttributeValue<string>("keywords");
      set
      {
        this.OnPropertyChanging(nameof (Keywords));
        this.SetAttributeValue("keywords", (object) value);
        this.OnPropertyChanged(nameof (Keywords));
      }
    }

    [AttributeLogicalName("knowledgearticleid")]
    public Guid? knowledgearticleId
    {
      get => this.GetAttributeValue<Guid?>("knowledgearticleid");
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticleId));
        this.SetAttributeValue("knowledgearticleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (knowledgearticleId));
      }
    }

    [AttributeLogicalName("knowledgearticleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.knowledgearticleId = new Guid?(value);
    }

    [AttributeLogicalName("knowledgearticleviews")]
    public int? KnowledgeArticleViews => this.GetAttributeValue<int?>("knowledgearticleviews");

    [AttributeLogicalName("knowledgearticleviews_date")]
    public DateTime? KnowledgeArticleViews_Date
    {
      get => this.GetAttributeValue<DateTime?>("knowledgearticleviews_date");
    }

    [AttributeLogicalName("knowledgearticleviews_state")]
    public int? KnowledgeArticleViews_State
    {
      get => this.GetAttributeValue<int?>("knowledgearticleviews_state");
    }

    [AttributeLogicalName("languagelocaleid")]
    public EntityReference LanguageLocaleId
    {
      get => this.GetAttributeValue<EntityReference>("languagelocaleid");
      set
      {
        this.OnPropertyChanging(nameof (LanguageLocaleId));
        this.SetAttributeValue("languagelocaleid", (object) value);
        this.OnPropertyChanged(nameof (LanguageLocaleId));
      }
    }

    [AttributeLogicalName("majorversionnumber")]
    public int? MajorVersionNumber
    {
      get => this.GetAttributeValue<int?>("majorversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (MajorVersionNumber));
        this.SetAttributeValue("majorversionnumber", (object) value);
        this.OnPropertyChanged(nameof (MajorVersionNumber));
      }
    }

    [AttributeLogicalName("minorversionnumber")]
    public int? MinorVersionNumber
    {
      get => this.GetAttributeValue<int?>("minorversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (MinorVersionNumber));
        this.SetAttributeValue("minorversionnumber", (object) value);
        this.OnPropertyChanged(nameof (MinorVersionNumber));
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

    [AttributeLogicalName("parentarticlecontentid")]
    public EntityReference ParentArticleContentId
    {
      get => this.GetAttributeValue<EntityReference>("parentarticlecontentid");
      set
      {
        this.OnPropertyChanging(nameof (ParentArticleContentId));
        this.SetAttributeValue("parentarticlecontentid", (object) value);
        this.OnPropertyChanged(nameof (ParentArticleContentId));
      }
    }

    [AttributeLogicalName("previousarticlecontentid")]
    public EntityReference PreviousArticleContentId
    {
      get => this.GetAttributeValue<EntityReference>("previousarticlecontentid");
      set
      {
        this.OnPropertyChanging(nameof (PreviousArticleContentId));
        this.SetAttributeValue("previousarticlecontentid", (object) value);
        this.OnPropertyChanged(nameof (PreviousArticleContentId));
      }
    }

    [AttributeLogicalName("primaryauthorid")]
    public EntityReference primaryauthorid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (primaryauthorid));
      set
      {
        this.OnPropertyChanging(nameof (primaryauthorid));
        this.SetAttributeValue(nameof (primaryauthorid), (object) value);
        this.OnPropertyChanged(nameof (primaryauthorid));
      }
    }

    [AttributeLogicalName("processid")]
    public Guid? processid
    {
      get => this.GetAttributeValue<Guid?>(nameof (processid));
      set
      {
        this.OnPropertyChanging(nameof (processid));
        this.SetAttributeValue(nameof (processid), (object) value);
        this.OnPropertyChanged(nameof (processid));
      }
    }

    [AttributeLogicalName("publishon")]
    public DateTime? PublishOn
    {
      get => this.GetAttributeValue<DateTime?>("publishon");
      set
      {
        this.OnPropertyChanging(nameof (PublishOn));
        this.SetAttributeValue("publishon", (object) value);
        this.OnPropertyChanged(nameof (PublishOn));
      }
    }

    [AttributeLogicalName("publishstatusid")]
    public int? PublishStatusId
    {
      get => this.GetAttributeValue<int?>("publishstatusid");
      set
      {
        this.OnPropertyChanging(nameof (PublishStatusId));
        this.SetAttributeValue("publishstatusid", (object) value);
        this.OnPropertyChanged(nameof (PublishStatusId));
      }
    }

    [AttributeLogicalName("rating")]
    public Decimal? Rating => this.GetAttributeValue<Decimal?>("rating");

    [AttributeLogicalName("rating_count")]
    public int? Rating_Count => this.GetAttributeValue<int?>("rating_count");

    [AttributeLogicalName("rating_date")]
    public DateTime? Rating_Date => this.GetAttributeValue<DateTime?>("rating_date");

    [AttributeLogicalName("rating_state")]
    public int? Rating_State => this.GetAttributeValue<int?>("rating_state");

    [AttributeLogicalName("rating_sum")]
    public Decimal? Rating_Sum => this.GetAttributeValue<Decimal?>("rating_sum");

    [AttributeLogicalName("readyforreview")]
    public bool? ReadyForReview
    {
      get => this.GetAttributeValue<bool?>("readyforreview");
      set
      {
        this.OnPropertyChanging(nameof (ReadyForReview));
        this.SetAttributeValue("readyforreview", (object) value);
        this.OnPropertyChanged(nameof (ReadyForReview));
      }
    }

    [AttributeLogicalName("review")]
    public OptionSetValue Review
    {
      get => this.GetAttributeValue<OptionSetValue>("review");
      set
      {
        this.OnPropertyChanging(nameof (Review));
        this.SetAttributeValue("review", (object) value);
        this.OnPropertyChanged(nameof (Review));
      }
    }

    [AttributeLogicalName("rootarticleid")]
    public EntityReference RootArticleId
    {
      get => this.GetAttributeValue<EntityReference>("rootarticleid");
      set
      {
        this.OnPropertyChanging(nameof (RootArticleId));
        this.SetAttributeValue("rootarticleid", (object) value);
        this.OnPropertyChanged(nameof (RootArticleId));
      }
    }

    [AttributeLogicalName("scheduledstatusid")]
    public int? ScheduledStatusId
    {
      get => this.GetAttributeValue<int?>("scheduledstatusid");
      set
      {
        this.OnPropertyChanging(nameof (ScheduledStatusId));
        this.SetAttributeValue("scheduledstatusid", (object) value);
        this.OnPropertyChanged(nameof (ScheduledStatusId));
      }
    }

    [AttributeLogicalName("setcategoryassociations")]
    public bool? SetCategoryAssociations
    {
      get => this.GetAttributeValue<bool?>("setcategoryassociations");
      set
      {
        this.OnPropertyChanging(nameof (SetCategoryAssociations));
        this.SetAttributeValue("setcategoryassociations", (object) value);
        this.OnPropertyChanged(nameof (SetCategoryAssociations));
      }
    }

    [AttributeLogicalName("stageid")]
    public Guid? stageid
    {
      get => this.GetAttributeValue<Guid?>(nameof (stageid));
      set
      {
        this.OnPropertyChanging(nameof (stageid));
        this.SetAttributeValue(nameof (stageid), (object) value);
        this.OnPropertyChanged(nameof (stageid));
      }
    }

    [AttributeLogicalName("statecode")]
    public KnowledgeArticleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new KnowledgeArticleState?((KnowledgeArticleState) Enum.ToObject(typeof (KnowledgeArticleState), attributeValue.Value)) : new KnowledgeArticleState?();
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

    [AttributeLogicalName("traversedpath")]
    public string traversedpath
    {
      get => this.GetAttributeValue<string>(nameof (traversedpath));
      set
      {
        this.OnPropertyChanging(nameof (traversedpath));
        this.SetAttributeValue(nameof (traversedpath), (object) value);
        this.OnPropertyChanged(nameof (traversedpath));
      }
    }

    [AttributeLogicalName("updatecontent")]
    public bool? UpdateContent
    {
      get => this.GetAttributeValue<bool?>("updatecontent");
      set
      {
        this.OnPropertyChanging(nameof (UpdateContent));
        this.SetAttributeValue("updatecontent", (object) value);
        this.OnPropertyChanged(nameof (UpdateContent));
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

    [RelationshipSchemaName("knowledgearticle_activity_parties")]
    public IEnumerable<ActivityParty> knowledgearticle_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (knowledgearticle_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (knowledgearticle_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_activity_parties));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_ActivityPointers")]
    public IEnumerable<ActivityPointer> KnowledgeArticle_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (KnowledgeArticle_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (KnowledgeArticle_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_ActivityPointers));
      }
    }

    [RelationshipSchemaName("knowledgearticle_Annotations")]
    public IEnumerable<Annotation> knowledgearticle_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (knowledgearticle_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (knowledgearticle_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_Annotations));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_Appointments")]
    public IEnumerable<Appointment> KnowledgeArticle_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (KnowledgeArticle_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (KnowledgeArticle_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Appointments));
      }
    }

    [RelationshipSchemaName("knowledgearticle_AsyncOperations")]
    public IEnumerable<AsyncOperation> knowledgearticle_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (knowledgearticle_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (knowledgearticle_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_AsyncOperations));
      }
    }

    [RelationshipSchemaName("knowledgearticle_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> knowledgearticle_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (knowledgearticle_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (knowledgearticle_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("knowledgearticle_connections1")]
    public IEnumerable<Connection> knowledgearticle_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (knowledgearticle_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_connections1));
        this.SetRelatedEntities<Connection>(nameof (knowledgearticle_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_connections1));
      }
    }

    [RelationshipSchemaName("knowledgearticle_connections2")]
    public IEnumerable<Connection> knowledgearticle_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (knowledgearticle_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_connections2));
        this.SetRelatedEntities<Connection>(nameof (knowledgearticle_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_connections2));
      }
    }

    [RelationshipSchemaName("knowledgearticle_documentindex")]
    public IEnumerable<DocumentIndex> knowledgearticle_documentindex
    {
      get
      {
        return this.GetRelatedEntities<DocumentIndex>(nameof (knowledgearticle_documentindex), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_documentindex));
        this.SetRelatedEntities<DocumentIndex>(nameof (knowledgearticle_documentindex), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_documentindex));
      }
    }

    [RelationshipSchemaName("knowledgearticle_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> knowledgearticle_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (knowledgearticle_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (knowledgearticle_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("knowledgearticle_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> knowledgearticle_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (knowledgearticle_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (knowledgearticle_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_Emails")]
    public IEnumerable<Email> KnowledgeArticle_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (KnowledgeArticle_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Emails));
        this.SetRelatedEntities<Email>(nameof (KnowledgeArticle_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Emails));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_Faxes")]
    public IEnumerable<Fax> KnowledgeArticle_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (KnowledgeArticle_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Faxes));
        this.SetRelatedEntities<Fax>(nameof (KnowledgeArticle_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Faxes));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_Feedback")]
    public IEnumerable<Feedback> KnowledgeArticle_Feedback
    {
      get
      {
        return this.GetRelatedEntities<Feedback>(nameof (KnowledgeArticle_Feedback), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Feedback));
        this.SetRelatedEntities<Feedback>(nameof (KnowledgeArticle_Feedback), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Feedback));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_Letters")]
    public IEnumerable<Letter> KnowledgeArticle_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (KnowledgeArticle_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Letters));
        this.SetRelatedEntities<Letter>(nameof (KnowledgeArticle_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Letters));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<KnowledgeArticle> Referencedknowledgearticle_parentarticle_contentid
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>("knowledgearticle_parentarticle_contentid", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedknowledgearticle_parentarticle_contentid));
        this.SetRelatedEntities<KnowledgeArticle>("knowledgearticle_parentarticle_contentid", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedknowledgearticle_parentarticle_contentid));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_Phonecalls")]
    public IEnumerable<PhoneCall> KnowledgeArticle_Phonecalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (KnowledgeArticle_Phonecalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Phonecalls));
        this.SetRelatedEntities<PhoneCall>(nameof (KnowledgeArticle_Phonecalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Phonecalls));
      }
    }

    [RelationshipSchemaName("knowledgearticle_PostFollows")]
    public IEnumerable<PostFollow> knowledgearticle_PostFollows
    {
      get
      {
        return this.GetRelatedEntities<PostFollow>(nameof (knowledgearticle_PostFollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_PostFollows));
        this.SetRelatedEntities<PostFollow>(nameof (knowledgearticle_PostFollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_PostFollows));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<KnowledgeArticle> Referencedknowledgearticle_previousarticle_contentid
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>("knowledgearticle_previousarticle_contentid", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedknowledgearticle_previousarticle_contentid));
        this.SetRelatedEntities<KnowledgeArticle>("knowledgearticle_previousarticle_contentid", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedknowledgearticle_previousarticle_contentid));
      }
    }

    [RelationshipSchemaName("knowledgearticle_PrincipalObjectAttributeAccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> knowledgearticle_PrincipalObjectAttributeAccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (knowledgearticle_PrincipalObjectAttributeAccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_PrincipalObjectAttributeAccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (knowledgearticle_PrincipalObjectAttributeAccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_PrincipalObjectAttributeAccess));
      }
    }

    [RelationshipSchemaName("knowledgearticle_ProcessSession")]
    public IEnumerable<ProcessSession> knowledgearticle_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (knowledgearticle_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (knowledgearticle_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_ProcessSession));
      }
    }

    [RelationshipSchemaName("knowledgearticle_QueueItems")]
    public IEnumerable<QueueItem> knowledgearticle_QueueItems
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (knowledgearticle_QueueItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_QueueItems));
        this.SetRelatedEntities<QueueItem>(nameof (knowledgearticle_QueueItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_QueueItems));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> KnowledgeArticle_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (KnowledgeArticle_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (KnowledgeArticle_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<KnowledgeArticle> Referencedknowledgearticle_rootarticle_id
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>("knowledgearticle_rootarticle_id", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedknowledgearticle_rootarticle_id));
        this.SetRelatedEntities<KnowledgeArticle>("knowledgearticle_rootarticle_id", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedknowledgearticle_rootarticle_id));
      }
    }

    [RelationshipSchemaName("knowledgearticle_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> knowledgearticle_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (knowledgearticle_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (knowledgearticle_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("knowledgearticle_SharePointDocuments")]
    public IEnumerable<SharePointDocument> knowledgearticle_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (knowledgearticle_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (knowledgearticle_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_SocialActivities")]
    public IEnumerable<SocialActivity> KnowledgeArticle_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (KnowledgeArticle_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (KnowledgeArticle_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_SocialActivities));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_SyncErrors")]
    public IEnumerable<SyncError> KnowledgeArticle_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (KnowledgeArticle_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (KnowledgeArticle_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_SyncErrors));
      }
    }

    [RelationshipSchemaName("KnowledgeArticle_Tasks")]
    public IEnumerable<Task> KnowledgeArticle_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (KnowledgeArticle_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Tasks));
        this.SetRelatedEntities<Task>(nameof (KnowledgeArticle_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Tasks));
      }
    }

    [RelationshipSchemaName("knowledgearticle_Teams")]
    public IEnumerable<Team> knowledgearticle_Teams
    {
      get => this.GetRelatedEntities<Team>(nameof (knowledgearticle_Teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_Teams));
        this.SetRelatedEntities<Team>(nameof (knowledgearticle_Teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_Teams));
      }
    }

    [RelationshipSchemaName("knowledgearticle_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> knowledgearticle_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (knowledgearticle_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (knowledgearticle_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("knowledgearticle_views")]
    public IEnumerable<ArcticIT.EarlyBound.Entities.KnowledgeArticleViews> knowledgearticle_views
    {
      get
      {
        return this.GetRelatedEntities<ArcticIT.EarlyBound.Entities.KnowledgeArticleViews>(nameof (knowledgearticle_views), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_views));
        this.SetRelatedEntities<ArcticIT.EarlyBound.Entities.KnowledgeArticleViews>(nameof (knowledgearticle_views), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_views));
      }
    }

    [RelationshipSchemaName("lk_expiredprocess_knowledgearticleid")]
    public IEnumerable<ExpiredProcess> lk_expiredprocess_knowledgearticleid
    {
      get
      {
        return this.GetRelatedEntities<ExpiredProcess>(nameof (lk_expiredprocess_knowledgearticleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expiredprocess_knowledgearticleid));
        this.SetRelatedEntities<ExpiredProcess>(nameof (lk_expiredprocess_knowledgearticleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expiredprocess_knowledgearticleid));
      }
    }

    [RelationshipSchemaName("lk_newprocess_knowledgearticleid")]
    public IEnumerable<NewProcess> lk_newprocess_knowledgearticleid
    {
      get
      {
        return this.GetRelatedEntities<NewProcess>(nameof (lk_newprocess_knowledgearticleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_newprocess_knowledgearticleid));
        this.SetRelatedEntities<NewProcess>(nameof (lk_newprocess_knowledgearticleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_newprocess_knowledgearticleid));
      }
    }

    [RelationshipSchemaName("lk_translationprocess_knowledgearticleid")]
    public IEnumerable<TranslationProcess> lk_translationprocess_knowledgearticleid
    {
      get
      {
        return this.GetRelatedEntities<TranslationProcess>(nameof (lk_translationprocess_knowledgearticleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_translationprocess_knowledgearticleid));
        this.SetRelatedEntities<TranslationProcess>(nameof (lk_translationprocess_knowledgearticleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_translationprocess_knowledgearticleid));
      }
    }

    [RelationshipSchemaName("knowledgearticle_category")]
    public IEnumerable<Category> knowledgearticle_category
    {
      get
      {
        return this.GetRelatedEntities<Category>(nameof (knowledgearticle_category), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_category));
        this.SetRelatedEntities<Category>(nameof (knowledgearticle_category), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_category));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_knowledgearticle")]
    public BusinessUnit business_unit_knowledgearticle
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_knowledgearticle), new EntityRole?());
      }
    }

    [AttributeLogicalName("languagelocaleid")]
    [RelationshipSchemaName("knowledgearticle_languagelocaleid")]
    public LanguageLocale knowledgearticle_languagelocaleid
    {
      get
      {
        return this.GetRelatedEntity<LanguageLocale>(nameof (knowledgearticle_languagelocaleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_languagelocaleid));
        this.SetRelatedEntity<LanguageLocale>(nameof (knowledgearticle_languagelocaleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_languagelocaleid));
      }
    }

    [AttributeLogicalName("parentarticlecontentid")]
    [RelationshipSchemaName]
    public KnowledgeArticle Referencingknowledgearticle_parentarticle_contentid
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>("knowledgearticle_parentarticle_contentid", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingknowledgearticle_parentarticle_contentid));
        this.SetRelatedEntity<KnowledgeArticle>("knowledgearticle_parentarticle_contentid", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingknowledgearticle_parentarticle_contentid));
      }
    }

    [AttributeLogicalName("previousarticlecontentid")]
    [RelationshipSchemaName]
    public KnowledgeArticle Referencingknowledgearticle_previousarticle_contentid
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>("knowledgearticle_previousarticle_contentid", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingknowledgearticle_previousarticle_contentid));
        this.SetRelatedEntity<KnowledgeArticle>("knowledgearticle_previousarticle_contentid", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingknowledgearticle_previousarticle_contentid));
      }
    }

    [AttributeLogicalName("primaryauthorid")]
    [RelationshipSchemaName("knowledgearticle_primaryauthorid")]
    public SystemUser knowledgearticle_primaryauthorid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (knowledgearticle_primaryauthorid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_primaryauthorid));
        this.SetRelatedEntity<SystemUser>(nameof (knowledgearticle_primaryauthorid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_primaryauthorid));
      }
    }

    [AttributeLogicalName("rootarticleid")]
    [RelationshipSchemaName]
    public KnowledgeArticle Referencingknowledgearticle_rootarticle_id
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>("knowledgearticle_rootarticle_id", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingknowledgearticle_rootarticle_id));
        this.SetRelatedEntity<KnowledgeArticle>("knowledgearticle_rootarticle_id", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingknowledgearticle_rootarticle_id));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_knowledgearticle_createdby")]
    public SystemUser lk_knowledgearticle_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgearticle_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_knowledgearticle_createdonbehalfby")]
    public SystemUser lk_knowledgearticle_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgearticle_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_knowledgearticle_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_knowledgearticle_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_knowledgearticle_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_knowledgearticle_modifiedby")]
    public SystemUser lk_knowledgearticle_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgearticle_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_knowledgearticle_modifiedonbehalfby")]
    public SystemUser lk_knowledgearticle_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgearticle_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_knowledgearticle_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_knowledgearticle_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_knowledgearticle_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_knowledgearticle")]
    public ProcessStage processstage_knowledgearticle
    {
      get
      {
        return this.GetRelatedEntity<ProcessStage>(nameof (processstage_knowledgearticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstage_knowledgearticle));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_knowledgearticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_knowledgearticle));
      }
    }

    [AttributeLogicalName("subjectid")]
    [RelationshipSchemaName("subject_knowledgearticles")]
    public Subject subject_knowledgearticles
    {
      get => this.GetRelatedEntity<Subject>(nameof (subject_knowledgearticles), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (subject_knowledgearticles));
        this.SetRelatedEntity<Subject>(nameof (subject_knowledgearticles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (subject_knowledgearticles));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_knowledgearticle")]
    public Team team_knowledgearticle
    {
      get => this.GetRelatedEntity<Team>(nameof (team_knowledgearticle), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_knowledgearticle")]
    public TransactionCurrency TransactionCurrency_knowledgearticle
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_knowledgearticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_knowledgearticle));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_knowledgearticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_knowledgearticle));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_knowledgearticle")]
    public SystemUser user_knowledgearticle
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_knowledgearticle), new EntityRole?());
    }

    public KnowledgeArticle(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["knowledgearticleid"] = (object) base.Id;
            break;
          case "knowledgearticleid":
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
