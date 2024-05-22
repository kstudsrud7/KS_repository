// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.UserMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("usermapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class UserMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "usermapping";
    public const string EntitySchemaName = "UserMapping";
    public const string PrimaryIdAttribute = "usermappingid";

    public UserMapping()
      : base("usermapping")
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

    [AttributeLogicalName("claimtype")]
    public string ClaimType
    {
      get => this.GetAttributeValue<string>("claimtype");
      set
      {
        this.OnPropertyChanging(nameof (ClaimType));
        this.SetAttributeValue("claimtype", (object) value);
        this.OnPropertyChanged(nameof (ClaimType));
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("partnerapplicationtype")]
    public OptionSetValue PartnerApplicationType
    {
      get => this.GetAttributeValue<OptionSetValue>("partnerapplicationtype");
      set
      {
        this.OnPropertyChanging(nameof (PartnerApplicationType));
        this.SetAttributeValue("partnerapplicationtype", (object) value);
        this.OnPropertyChanged(nameof (PartnerApplicationType));
      }
    }

    [AttributeLogicalName("systemuserattributename")]
    public string SystemUserAttributeName
    {
      get => this.GetAttributeValue<string>("systemuserattributename");
      set
      {
        this.OnPropertyChanging(nameof (SystemUserAttributeName));
        this.SetAttributeValue("systemuserattributename", (object) value);
        this.OnPropertyChanged(nameof (SystemUserAttributeName));
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

    [AttributeLogicalName("usermappingid")]
    public Guid? UserMappingId
    {
      get => this.GetAttributeValue<Guid?>("usermappingid");
      set
      {
        this.OnPropertyChanging(nameof (UserMappingId));
        this.SetAttributeValue("usermappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (UserMappingId));
      }
    }

    [AttributeLogicalName("usermappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.UserMappingId = new Guid?(value);
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

    [RelationshipSchemaName("usermapping_AsyncOperations")]
    public IEnumerable<AsyncOperation> usermapping_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (usermapping_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (usermapping_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (usermapping_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (usermapping_AsyncOperations));
      }
    }

    [RelationshipSchemaName("usermapping_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> usermapping_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (usermapping_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (usermapping_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (usermapping_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (usermapping_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("usermapping_ProcessSession")]
    public IEnumerable<ProcessSession> usermapping_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (usermapping_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (usermapping_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (usermapping_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (usermapping_ProcessSession));
      }
    }

    [RelationshipSchemaName("usermapping_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> usermapping_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (usermapping_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (usermapping_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (usermapping_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (usermapping_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_usermapping_createdby")]
    public SystemUser lk_usermapping_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_usermapping_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_usermapping_createdonbehalfby")]
    public SystemUser lk_usermapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_usermapping_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_usermapping_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_usermapping_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_usermapping_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_usermapping_modifiedby")]
    public SystemUser lk_usermapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_usermapping_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_usermapping_modifiedonbehalfby")]
    public SystemUser lk_usermapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_usermapping_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_usermapping_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_usermapping_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_usermapping_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_UserMapping")]
    public Organization organization_UserMapping
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_UserMapping), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_UserMapping")]
    public TransactionCurrency TransactionCurrency_UserMapping
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_UserMapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_UserMapping));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_UserMapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_UserMapping));
      }
    }

    public UserMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["usermappingid"] = (object) base.Id;
            break;
          case "usermappingid":
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
