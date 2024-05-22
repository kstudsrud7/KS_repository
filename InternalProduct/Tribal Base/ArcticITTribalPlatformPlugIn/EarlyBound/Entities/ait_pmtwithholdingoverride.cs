// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_pmtwithholdingoverride
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_pmtwithholdingoverride")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_pmtwithholdingoverride : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_pmtwithholdingoverride";
    public const string EntitySchemaName = "ait_pmtwithholdingoverride";
    public const string PrimaryIdAttribute = "ait_pmtwithholdingoverrideid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_pmtwithholdingoverride()
      : base(nameof (ait_pmtwithholdingoverride))
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

    [AttributeLogicalName("ait_amounttype")]
    public OptionSetValue ait_amounttype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_amounttype));
      set
      {
        this.OnPropertyChanging(nameof (ait_amounttype));
        this.SetAttributeValue(nameof (ait_amounttype), (object) value);
        this.OnPropertyChanged(nameof (ait_amounttype));
      }
    }

    [AttributeLogicalName("ait_enddate")]
    public DateTime? ait_EndDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_enddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_EndDate));
        this.SetAttributeValue("ait_enddate", (object) value);
        this.OnPropertyChanged(nameof (ait_EndDate));
      }
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
      }
    }

    [AttributeLogicalName("ait_pmtwithholding")]
    public EntityReference ait_PmtWithholding
    {
      get => this.GetAttributeValue<EntityReference>("ait_pmtwithholding");
      set
      {
        this.OnPropertyChanging(nameof (ait_PmtWithholding));
        this.SetAttributeValue("ait_pmtwithholding", (object) value);
        this.OnPropertyChanged(nameof (ait_PmtWithholding));
      }
    }

    [AttributeLogicalName("ait_pmtwithholdingoverrideid")]
    public Guid? ait_pmtwithholdingoverrideId
    {
      get => this.GetAttributeValue<Guid?>("ait_pmtwithholdingoverrideid");
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverrideId));
        this.SetAttributeValue("ait_pmtwithholdingoverrideid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverrideId));
      }
    }

    [AttributeLogicalName("ait_pmtwithholdingoverrideid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_pmtwithholdingoverrideId = new Guid?(value);
    }

    [AttributeLogicalName("ait_startdate")]
    public DateTime? ait_StartDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_startdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_StartDate));
        this.SetAttributeValue("ait_startdate", (object) value);
        this.OnPropertyChanged(nameof (ait_StartDate));
      }
    }

    [AttributeLogicalName("ait_withholdingoverrideamount")]
    public Money ait_WithholdingOverrideAmount
    {
      get => this.GetAttributeValue<Money>("ait_withholdingoverrideamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_WithholdingOverrideAmount));
        this.SetAttributeValue("ait_withholdingoverrideamount", (object) value);
        this.OnPropertyChanged(nameof (ait_WithholdingOverrideAmount));
      }
    }

    [AttributeLogicalName("ait_withholdingoverrideamount_base")]
    public Money ait_withholdingoverrideamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_withholdingoverrideamount_base");
    }

    [AttributeLogicalName("ait_withholdingpercentage")]
    public Decimal? ait_withholdingpercentage
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_withholdingpercentage));
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingpercentage));
        this.SetAttributeValue(nameof (ait_withholdingpercentage), (object) value);
        this.OnPropertyChanged(nameof (ait_withholdingpercentage));
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

    [AttributeLogicalName("statecode")]
    public ait_pmtwithholdingoverrideState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_pmtwithholdingoverrideState?((ait_pmtwithholdingoverrideState) Enum.ToObject(typeof (ait_pmtwithholdingoverrideState), attributeValue.Value)) : new ait_pmtwithholdingoverrideState?();
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

    [RelationshipSchemaName("ait_pmtwithholdingoverride_Annotations")]
    public IEnumerable<Annotation> ait_pmtwithholdingoverride_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_pmtwithholdingoverride_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_pmtwithholdingoverride_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_Annotations));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholdingoverride_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_pmtwithholdingoverride_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_pmtwithholdingoverride_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_pmtwithholdingoverride_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholdingoverride_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_pmtwithholdingoverride_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmtwithholdingoverride_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_pmtwithholdingoverride_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholdingoverride_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_pmtwithholdingoverride_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmtwithholdingoverride_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_pmtwithholdingoverride_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholdingoverride_ProcessSession")]
    public IEnumerable<ProcessSession> ait_pmtwithholdingoverride_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_pmtwithholdingoverride_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_pmtwithholdingoverride_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholdingoverride_SyncErrors")]
    public IEnumerable<SyncError> ait_pmtwithholdingoverride_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_pmtwithholdingoverride_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_pmtwithholdingoverride_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_pmtwithholdingoverride_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_pmtwithholdingoverride_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmtwithholdingoverride_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_pmtwithholdingoverride_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_pmtwithholding")]
    [RelationshipSchemaName("ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding")]
    public ait_pmtwithholding ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_pmtwithholding_ait_pmtwithholdingoverride_PmtWithholding));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_pmtwithholdingoverride")]
    public BusinessUnit business_unit_ait_pmtwithholdingoverride
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_pmtwithholdingoverride), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_pmtwithholdingoverride_createdby")]
    public SystemUser lk_ait_pmtwithholdingoverride_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholdingoverride_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmtwithholdingoverride_createdonbehalfby")]
    public SystemUser lk_ait_pmtwithholdingoverride_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholdingoverride_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmtwithholdingoverride_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholdingoverride_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmtwithholdingoverride_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_pmtwithholdingoverride_modifiedby")]
    public SystemUser lk_ait_pmtwithholdingoverride_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholdingoverride_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_pmtwithholdingoverride_modifiedonbehalfby")]
    public SystemUser lk_ait_pmtwithholdingoverride_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholdingoverride_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_pmtwithholdingoverride_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_pmtwithholdingoverride_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_pmtwithholdingoverride_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_pmtwithholdingoverride")]
    public Team team_ait_pmtwithholdingoverride
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_pmtwithholdingoverride), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_pmtwithholdingoverride")]
    public TransactionCurrency TransactionCurrency_ait_pmtwithholdingoverride
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmtwithholdingoverride), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_pmtwithholdingoverride));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_pmtwithholdingoverride), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_pmtwithholdingoverride));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_pmtwithholdingoverride")]
    public SystemUser user_ait_pmtwithholdingoverride
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_pmtwithholdingoverride), new EntityRole?());
      }
    }

    public ait_pmtwithholdingoverride(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_pmtwithholdingoverrideid"] = (object) base.Id;
            break;
          case "ait_pmtwithholdingoverrideid":
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
