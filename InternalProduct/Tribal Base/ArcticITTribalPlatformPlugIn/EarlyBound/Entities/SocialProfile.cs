// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SocialProfile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("socialprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SocialProfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "socialprofile";
    public const string EntitySchemaName = "SocialProfile";
    public const string PrimaryIdAttribute = "socialprofileid";
    public const string PrimaryNameAttribute = "profilename";

    public SocialProfile()
      : base("socialprofile")
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

    [AttributeLogicalName("blocked")]
    public bool? Blocked
    {
      get => this.GetAttributeValue<bool?>("blocked");
      set
      {
        this.OnPropertyChanging(nameof (Blocked));
        this.SetAttributeValue("blocked", (object) value);
        this.OnPropertyChanged(nameof (Blocked));
      }
    }

    [AttributeLogicalName("community")]
    public OptionSetValue Community
    {
      get => this.GetAttributeValue<OptionSetValue>("community");
      set
      {
        this.OnPropertyChanging(nameof (Community));
        this.SetAttributeValue("community", (object) value);
        this.OnPropertyChanged(nameof (Community));
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

    [AttributeLogicalName("customerid")]
    public EntityReference CustomerId
    {
      get => this.GetAttributeValue<EntityReference>("customerid");
      set
      {
        this.OnPropertyChanging(nameof (CustomerId));
        this.SetAttributeValue("customerid", (object) value);
        this.OnPropertyChanged(nameof (CustomerId));
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

    [AttributeLogicalName("influencescore")]
    public double? InfluenceScore
    {
      get => this.GetAttributeValue<double?>("influencescore");
      set
      {
        this.OnPropertyChanging(nameof (InfluenceScore));
        this.SetAttributeValue("influencescore", (object) value);
        this.OnPropertyChanged(nameof (InfluenceScore));
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

    [AttributeLogicalName("profilefullname")]
    public string ProfileFullName
    {
      get => this.GetAttributeValue<string>("profilefullname");
      set
      {
        this.OnPropertyChanging(nameof (ProfileFullName));
        this.SetAttributeValue("profilefullname", (object) value);
        this.OnPropertyChanged(nameof (ProfileFullName));
      }
    }

    [AttributeLogicalName("profilelink")]
    public string ProfileLink
    {
      get => this.GetAttributeValue<string>("profilelink");
      set
      {
        this.OnPropertyChanging(nameof (ProfileLink));
        this.SetAttributeValue("profilelink", (object) value);
        this.OnPropertyChanged(nameof (ProfileLink));
      }
    }

    [AttributeLogicalName("profilename")]
    public string ProfileName
    {
      get => this.GetAttributeValue<string>("profilename");
      set
      {
        this.OnPropertyChanging(nameof (ProfileName));
        this.SetAttributeValue("profilename", (object) value);
        this.OnPropertyChanged(nameof (ProfileName));
      }
    }

    [AttributeLogicalName("socialprofileid")]
    public Guid? SocialProfileId
    {
      get => this.GetAttributeValue<Guid?>("socialprofileid");
      set
      {
        this.OnPropertyChanging(nameof (SocialProfileId));
        this.SetAttributeValue("socialprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SocialProfileId));
      }
    }

    [AttributeLogicalName("socialprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SocialProfileId = new Guid?(value);
    }

    [AttributeLogicalName("statecode")]
    public SocialProfileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SocialProfileState?((SocialProfileState) Enum.ToObject(typeof (SocialProfileState), attributeValue.Value)) : new SocialProfileState?();
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
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("uniqueprofileid")]
    public string UniqueProfileID
    {
      get => this.GetAttributeValue<string>("uniqueprofileid");
      set
      {
        this.OnPropertyChanging(nameof (UniqueProfileID));
        this.SetAttributeValue("uniqueprofileid", (object) value);
        this.OnPropertyChanged(nameof (UniqueProfileID));
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

    [RelationshipSchemaName("SocialProfile_AsyncOperations")]
    public IEnumerable<AsyncOperation> SocialProfile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (SocialProfile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialProfile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (SocialProfile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialProfile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("socialprofile_connections1")]
    public IEnumerable<Connection> socialprofile_connections1
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (socialprofile_connections1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialprofile_connections1));
        this.SetRelatedEntities<Connection>(nameof (socialprofile_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialprofile_connections1));
      }
    }

    [RelationshipSchemaName("socialprofile_connections2")]
    public IEnumerable<Connection> socialprofile_connections2
    {
      get
      {
        return this.GetRelatedEntities<Connection>(nameof (socialprofile_connections2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialprofile_connections2));
        this.SetRelatedEntities<Connection>(nameof (socialprofile_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialprofile_connections2));
      }
    }

    [RelationshipSchemaName("SocialProfile_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> SocialProfile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (SocialProfile_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialProfile_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (SocialProfile_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialProfile_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("SocialProfile_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> SocialProfile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (SocialProfile_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialProfile_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (SocialProfile_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialProfile_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("socialprofile_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> socialprofile_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (socialprofile_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialprofile_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (socialprofile_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialprofile_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("SocialProfile_ProcessSessions")]
    public IEnumerable<ProcessSession> SocialProfile_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (SocialProfile_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialProfile_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (SocialProfile_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialProfile_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Socialprofile_SocialActivities")]
    public IEnumerable<SocialActivity> Socialprofile_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (Socialprofile_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Socialprofile_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (Socialprofile_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Socialprofile_SocialActivities));
      }
    }

    [RelationshipSchemaName("SocialProfile_SyncErrors")]
    public IEnumerable<SyncError> SocialProfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (SocialProfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialProfile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (SocialProfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialProfile_SyncErrors));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_socialprofiles")]
    public BusinessUnit business_unit_socialprofiles
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_socialprofiles), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_SocialProfile_createdonbehalfby")]
    public SystemUser lk_SocialProfile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_SocialProfile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_SocialProfile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_SocialProfile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_SocialProfile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_SocialProfile_modifiedonbehalfby")]
    public SystemUser lk_SocialProfile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_SocialProfile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_SocialProfile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_SocialProfile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_SocialProfile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("customerid")]
    [RelationshipSchemaName("Socialprofile_customer_accounts")]
    public Account Socialprofile_customer_accounts
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (Socialprofile_customer_accounts), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Socialprofile_customer_accounts));
        this.SetRelatedEntity<Account>(nameof (Socialprofile_customer_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Socialprofile_customer_accounts));
      }
    }

    [AttributeLogicalName("customerid")]
    [RelationshipSchemaName("Socialprofile_customer_contacts")]
    public Contact Socialprofile_customer_contacts
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (Socialprofile_customer_contacts), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Socialprofile_customer_contacts));
        this.SetRelatedEntity<Contact>(nameof (Socialprofile_customer_contacts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Socialprofile_customer_contacts));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("socialProfile_owning_user")]
    public SystemUser socialProfile_owning_user
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (socialProfile_owning_user), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_SocialProfile")]
    public TransactionCurrency transactioncurrency_SocialProfile
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_SocialProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_SocialProfile));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_SocialProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_SocialProfile));
      }
    }

    public SocialProfile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["socialprofileid"] = (object) base.Id;
            break;
          case "socialprofileid":
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
