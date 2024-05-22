// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ChannelAccessProfile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("channelaccessprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ChannelAccessProfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "channelaccessprofile";
    public const string EntitySchemaName = "ChannelAccessProfile";
    public const string PrimaryIdAttribute = "channelaccessprofileid";
    public const string PrimaryNameAttribute = "name";

    public ChannelAccessProfile()
      : base("channelaccessprofile")
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

    [AttributeLogicalName("channelaccessprofileid")]
    public Guid? ChannelAccessProfileId
    {
      get => this.GetAttributeValue<Guid?>("channelaccessprofileid");
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileId));
        this.SetAttributeValue("channelaccessprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ChannelAccessProfileId));
      }
    }

    [AttributeLogicalName("channelaccessprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ChannelAccessProfileId = new Guid?(value);
    }

    [AttributeLogicalName("channelaccessprofileidunique")]
    public Guid? ChannelAccessProfileIdUnique
    {
      get => this.GetAttributeValue<Guid?>("channelaccessprofileidunique");
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

    [AttributeLogicalName("emailaccess")]
    public bool? EmailAccess
    {
      get => this.GetAttributeValue<bool?>("emailaccess");
      set
      {
        this.OnPropertyChanging(nameof (EmailAccess));
        this.SetAttributeValue("emailaccess", (object) value);
        this.OnPropertyChanged(nameof (EmailAccess));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("facebookaccess")]
    public bool? FacebookAccess
    {
      get => this.GetAttributeValue<bool?>("facebookaccess");
      set
      {
        this.OnPropertyChanging(nameof (FacebookAccess));
        this.SetAttributeValue("facebookaccess", (object) value);
        this.OnPropertyChanged(nameof (FacebookAccess));
      }
    }

    [AttributeLogicalName("haveprivilegeschanged")]
    public bool? HavePrivilegesChanged => this.GetAttributeValue<bool?>("haveprivilegeschanged");

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

    [AttributeLogicalName("isguestprofile")]
    public bool? IsGuestProfile
    {
      get => this.GetAttributeValue<bool?>("isguestprofile");
      set
      {
        this.OnPropertyChanging(nameof (IsGuestProfile));
        this.SetAttributeValue("isguestprofile", (object) value);
        this.OnPropertyChanged(nameof (IsGuestProfile));
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

    [AttributeLogicalName("phoneaccess")]
    public bool? PhoneAccess
    {
      get => this.GetAttributeValue<bool?>("phoneaccess");
      set
      {
        this.OnPropertyChanging(nameof (PhoneAccess));
        this.SetAttributeValue("phoneaccess", (object) value);
        this.OnPropertyChanged(nameof (PhoneAccess));
      }
    }

    [AttributeLogicalName("rateknowledgearticles")]
    public bool? RateKnowledgeArticles
    {
      get => this.GetAttributeValue<bool?>("rateknowledgearticles");
      set
      {
        this.OnPropertyChanging(nameof (RateKnowledgeArticles));
        this.SetAttributeValue("rateknowledgearticles", (object) value);
        this.OnPropertyChanged(nameof (RateKnowledgeArticles));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public ChannelAccessProfileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ChannelAccessProfileState?((ChannelAccessProfileState) Enum.ToObject(typeof (ChannelAccessProfileState), attributeValue.Value)) : new ChannelAccessProfileState?();
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

    [AttributeLogicalName("submitfeedback")]
    public bool? SubmitFeedback
    {
      get => this.GetAttributeValue<bool?>("submitfeedback");
      set
      {
        this.OnPropertyChanging(nameof (SubmitFeedback));
        this.SetAttributeValue("submitfeedback", (object) value);
        this.OnPropertyChanged(nameof (SubmitFeedback));
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
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("twitteraccess")]
    public bool? TwitterAccess
    {
      get => this.GetAttributeValue<bool?>("twitteraccess");
      set
      {
        this.OnPropertyChanging(nameof (TwitterAccess));
        this.SetAttributeValue("twitteraccess", (object) value);
        this.OnPropertyChanged(nameof (TwitterAccess));
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

    [AttributeLogicalName("viewarticlerating")]
    public bool? ViewArticleRating
    {
      get => this.GetAttributeValue<bool?>("viewarticlerating");
      set
      {
        this.OnPropertyChanging(nameof (ViewArticleRating));
        this.SetAttributeValue("viewarticlerating", (object) value);
        this.OnPropertyChanged(nameof (ViewArticleRating));
      }
    }

    [AttributeLogicalName("viewknowledgearticles")]
    public bool? ViewKnowledgeArticles
    {
      get => this.GetAttributeValue<bool?>("viewknowledgearticles");
      set
      {
        this.OnPropertyChanging(nameof (ViewKnowledgeArticles));
        this.SetAttributeValue("viewknowledgearticles", (object) value);
        this.OnPropertyChanged(nameof (ViewKnowledgeArticles));
      }
    }

    [AttributeLogicalName("webaccess")]
    public bool? WebAccess
    {
      get => this.GetAttributeValue<bool?>("webaccess");
      set
      {
        this.OnPropertyChanging(nameof (WebAccess));
        this.SetAttributeValue("webaccess", (object) value);
        this.OnPropertyChanged(nameof (WebAccess));
      }
    }

    [RelationshipSchemaName("channelaccessprofile_Annotations")]
    public IEnumerable<Annotation> channelaccessprofile_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (channelaccessprofile_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (channelaccessprofile_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_Annotations));
      }
    }

    [RelationshipSchemaName("channelaccessprofile_AsyncOperations")]
    public IEnumerable<AsyncOperation> channelaccessprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (channelaccessprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (channelaccessprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("channelaccessprofile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> channelaccessprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (channelaccessprofile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (channelaccessprofile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("channelaccessprofile_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> channelaccessprofile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (channelaccessprofile_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (channelaccessprofile_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("channelaccessprofile_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> channelaccessprofile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (channelaccessprofile_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (channelaccessprofile_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("channelaccessprofile_PrincipalObjectAttributeAccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> channelaccessprofile_PrincipalObjectAttributeAccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (channelaccessprofile_PrincipalObjectAttributeAccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_PrincipalObjectAttributeAccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (channelaccessprofile_PrincipalObjectAttributeAccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_PrincipalObjectAttributeAccess));
      }
    }

    [RelationshipSchemaName("channelaccessprofile_ProcessSession")]
    public IEnumerable<ProcessSession> channelaccessprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (channelaccessprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (channelaccessprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_ProcessSession));
      }
    }

    [RelationshipSchemaName("ChannelAccessProfile_SyncErrors")]
    public IEnumerable<SyncError> ChannelAccessProfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ChannelAccessProfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ChannelAccessProfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfile_SyncErrors));
      }
    }

    [RelationshipSchemaName("channelaccessprofile_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> channelaccessprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (channelaccessprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (channelaccessprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("lk_externalpartyitem_channelaccessprofileid")]
    public IEnumerable<ExternalPartyItem> lk_externalpartyitem_channelaccessprofileid
    {
      get
      {
        return this.GetRelatedEntities<ExternalPartyItem>(nameof (lk_externalpartyitem_channelaccessprofileid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_externalpartyitem_channelaccessprofileid));
        this.SetRelatedEntities<ExternalPartyItem>(nameof (lk_externalpartyitem_channelaccessprofileid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_externalpartyitem_channelaccessprofileid));
      }
    }

    [RelationshipSchemaName("profileruleitem_associated_channelaccessprofile")]
    public IEnumerable<ChannelAccessProfileRuleItem> profileruleitem_associated_channelaccessprofile
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfileRuleItem>(nameof (profileruleitem_associated_channelaccessprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profileruleitem_associated_channelaccessprofile));
        this.SetRelatedEntities<ChannelAccessProfileRuleItem>(nameof (profileruleitem_associated_channelaccessprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profileruleitem_associated_channelaccessprofile));
      }
    }

    [RelationshipSchemaName("ChannelAccessProfile_Privilege")]
    public IEnumerable<Privilege> ChannelAccessProfile_Privilege
    {
      get
      {
        return this.GetRelatedEntities<Privilege>(nameof (ChannelAccessProfile_Privilege), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfile_Privilege));
        this.SetRelatedEntities<Privilege>(nameof (ChannelAccessProfile_Privilege), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfile_Privilege));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_channelaccessprofile")]
    public BusinessUnit business_unit_channelaccessprofile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_channelaccessprofile), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_channelaccessprofile_createdby")]
    public SystemUser lk_channelaccessprofile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_channelaccessprofile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_channelaccessprofile_createdonbehalfby")]
    public SystemUser lk_channelaccessprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_channelaccessprofile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_channelaccessprofile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_channelaccessprofile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_channelaccessprofile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_channelaccessprofile_modifiedby")]
    public SystemUser lk_channelaccessprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_channelaccessprofile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_channelaccessprofile_modifiedonbehalfby")]
    public SystemUser lk_channelaccessprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_channelaccessprofile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_channelaccessprofile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_channelaccessprofile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_channelaccessprofile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_channelaccessprofile")]
    public Team team_channelaccessprofile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_channelaccessprofile), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ChannelAccessProfile")]
    public TransactionCurrency TransactionCurrency_ChannelAccessProfile
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ChannelAccessProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ChannelAccessProfile));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ChannelAccessProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ChannelAccessProfile));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_channelaccessprofile")]
    public SystemUser user_channelaccessprofile
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_channelaccessprofile), new EntityRole?());
      }
    }

    public ChannelAccessProfile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["channelaccessprofileid"] = (object) base.Id;
            break;
          case "channelaccessprofileid":
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
