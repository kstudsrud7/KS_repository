// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Feedback
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("feedback")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Feedback : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "feedback";
    public const string EntitySchemaName = "Feedback";
    public const string PrimaryIdAttribute = "feedbackid";
    public const string PrimaryNameAttribute = "title";

    public Feedback()
      : base("feedback")
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

    [AttributeLogicalName("adx_approved")]
    public bool? adx_approved
    {
      get => this.GetAttributeValue<bool?>(nameof (adx_approved));
      set
      {
        this.OnPropertyChanging(nameof (adx_approved));
        this.SetAttributeValue(nameof (adx_approved), (object) value);
        this.OnPropertyChanged(nameof (adx_approved));
      }
    }

    [AttributeLogicalName("adx_authorurl")]
    public string adx_authorurl
    {
      get => this.GetAttributeValue<string>(nameof (adx_authorurl));
      set
      {
        this.OnPropertyChanging(nameof (adx_authorurl));
        this.SetAttributeValue(nameof (adx_authorurl), (object) value);
        this.OnPropertyChanged(nameof (adx_authorurl));
      }
    }

    [AttributeLogicalName("adx_contactemail")]
    public string Adx_ContactEmail
    {
      get => this.GetAttributeValue<string>("adx_contactemail");
      set
      {
        this.OnPropertyChanging(nameof (Adx_ContactEmail));
        this.SetAttributeValue("adx_contactemail", (object) value);
        this.OnPropertyChanged(nameof (Adx_ContactEmail));
      }
    }

    [AttributeLogicalName("adx_contactusername")]
    public string Adx_ContactUsername
    {
      get => this.GetAttributeValue<string>("adx_contactusername");
      set
      {
        this.OnPropertyChanging(nameof (Adx_ContactUsername));
        this.SetAttributeValue("adx_contactusername", (object) value);
        this.OnPropertyChanged(nameof (Adx_ContactUsername));
      }
    }

    [AttributeLogicalName("adx_createdbycontact")]
    public string Adx_CreatedByContact
    {
      get => this.GetAttributeValue<string>("adx_createdbycontact");
      set
      {
        this.OnPropertyChanging(nameof (Adx_CreatedByContact));
        this.SetAttributeValue("adx_createdbycontact", (object) value);
        this.OnPropertyChanged(nameof (Adx_CreatedByContact));
      }
    }

    [AttributeLogicalName("closedby")]
    public EntityReference ClosedBy => this.GetAttributeValue<EntityReference>("closedby");

    [AttributeLogicalName("closedon")]
    public DateTime? ClosedOn => this.GetAttributeValue<DateTime?>("closedon");

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

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdbycontact")]
    public EntityReference CreatedByContact
    {
      get => this.GetAttributeValue<EntityReference>("createdbycontact");
      set
      {
        this.OnPropertyChanging(nameof (CreatedByContact));
        this.SetAttributeValue("createdbycontact", (object) value);
        this.OnPropertyChanged(nameof (CreatedByContact));
      }
    }

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

    [AttributeLogicalName("createdonbehalfbycontact")]
    public EntityReference CreatedOnBehalfByContact
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfbycontact");
      set
      {
        this.OnPropertyChanging(nameof (CreatedOnBehalfByContact));
        this.SetAttributeValue("createdonbehalfbycontact", (object) value);
        this.OnPropertyChanged(nameof (CreatedOnBehalfByContact));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("feedbackid")]
    public Guid? FeedbackId
    {
      get => this.GetAttributeValue<Guid?>("feedbackid");
      set
      {
        this.OnPropertyChanging(nameof (FeedbackId));
        this.SetAttributeValue("feedbackid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (FeedbackId));
      }
    }

    [AttributeLogicalName("feedbackid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.FeedbackId = new Guid?(value);
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

    [AttributeLogicalName("maxrating")]
    public int? MaxRating
    {
      get => this.GetAttributeValue<int?>("maxrating");
      set
      {
        this.OnPropertyChanging(nameof (MaxRating));
        this.SetAttributeValue("maxrating", (object) value);
        this.OnPropertyChanged(nameof (MaxRating));
      }
    }

    [AttributeLogicalName("minrating")]
    public int? MinRating
    {
      get => this.GetAttributeValue<int?>("minrating");
      set
      {
        this.OnPropertyChanging(nameof (MinRating));
        this.SetAttributeValue("minrating", (object) value);
        this.OnPropertyChanged(nameof (MinRating));
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

    [AttributeLogicalName("normalizedrating")]
    public Decimal? NormalizedRating => this.GetAttributeValue<Decimal?>("normalizedrating");

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

    [AttributeLogicalName("rating")]
    public int? Rating
    {
      get => this.GetAttributeValue<int?>("rating");
      set
      {
        this.OnPropertyChanging(nameof (Rating));
        this.SetAttributeValue("rating", (object) value);
        this.OnPropertyChanged(nameof (Rating));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("source")]
    public OptionSetValue Source
    {
      get => this.GetAttributeValue<OptionSetValue>("source");
      set
      {
        this.OnPropertyChanging(nameof (Source));
        this.SetAttributeValue("source", (object) value);
        this.OnPropertyChanged(nameof (Source));
      }
    }

    [AttributeLogicalName("statecode")]
    public FeedbackState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new FeedbackState?((FeedbackState) Enum.ToObject(typeof (FeedbackState), attributeValue.Value)) : new FeedbackState?();
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

    [RelationshipSchemaName("feedback_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> feedback_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (feedback_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (feedback_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (feedback_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (feedback_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("feedback_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> feedback_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (feedback_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (feedback_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (feedback_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (feedback_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Feedback> Referencedfeedback_feedback
    {
      get
      {
        return this.GetRelatedEntities<Feedback>("feedback_feedback", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedfeedback_feedback));
        this.SetRelatedEntities<Feedback>("feedback_feedback", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedfeedback_feedback));
      }
    }

    [RelationshipSchemaName("feedback_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> feedback_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (feedback_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (feedback_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (feedback_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (feedback_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Feedback_SyncErrors")]
    public IEnumerable<SyncError> Feedback_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Feedback_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Feedback_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Feedback_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Feedback_SyncErrors));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_feedback")]
    public BusinessUnit business_unit_feedback
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_feedback), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_Feedback")]
    public Contact Contact_Feedback
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Feedback), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Feedback));
        this.SetRelatedEntity<Contact>(nameof (Contact_Feedback), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Feedback));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName]
    public Feedback Referencingfeedback_feedback
    {
      get => this.GetRelatedEntity<Feedback>("feedback_feedback", new EntityRole?((EntityRole) 0));
      set
      {
        this.OnPropertyChanging(nameof (Referencingfeedback_feedback));
        this.SetRelatedEntity<Feedback>("feedback_feedback", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingfeedback_feedback));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_Feedback")]
    public KnowledgeArticle KnowledgeArticle_Feedback
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Feedback), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Feedback));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Feedback), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Feedback));
      }
    }

    [AttributeLogicalName("createdbycontact")]
    [RelationshipSchemaName("lk_contact_feedback_createdby")]
    public Contact lk_contact_feedback_createdby
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (lk_contact_feedback_createdby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_contact_feedback_createdby));
        this.SetRelatedEntity<Contact>(nameof (lk_contact_feedback_createdby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_contact_feedback_createdby));
      }
    }

    [AttributeLogicalName("createdonbehalfbycontact")]
    [RelationshipSchemaName("lk_contact_feedback_createdonbehalfby")]
    public Contact lk_contact_feedback_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (lk_contact_feedback_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_contact_feedback_createdonbehalfby));
        this.SetRelatedEntity<Contact>(nameof (lk_contact_feedback_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_contact_feedback_createdonbehalfby));
      }
    }

    [AttributeLogicalName("closedby")]
    [RelationshipSchemaName("lk_feedback_closedby")]
    public SystemUser lk_feedback_closedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_feedback_closedby), new EntityRole?());
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_feedback_createdby")]
    public SystemUser lk_feedback_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_feedback_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_feedback_createdonbehalfby")]
    public SystemUser lk_feedback_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_feedback_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_feedback_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_feedback_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_feedback_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_feedback_modifiedby")]
    public SystemUser lk_feedback_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_feedback_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_feedback_modifiedonbehalfby")]
    public SystemUser lk_feedback_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_feedback_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_feedback_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_feedback_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_feedback_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_feedback")]
    public TransactionCurrency transactioncurrency_feedback
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_feedback), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_feedback));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_feedback), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_feedback));
      }
    }

    public Feedback(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["feedbackid"] = (object) base.Id;
            break;
          case "feedbackid":
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
