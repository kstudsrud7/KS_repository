// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ReportCategory
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("reportcategory")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ReportCategory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "reportcategory";
    public const string EntitySchemaName = "ReportCategory";
    public const string PrimaryIdAttribute = "reportcategoryid";

    public ReportCategory()
      : base("reportcategory")
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

    [AttributeLogicalName("categorycode")]
    public OptionSetValue CategoryCode
    {
      get => this.GetAttributeValue<OptionSetValue>("categorycode");
      set
      {
        this.OnPropertyChanging(nameof (CategoryCode));
        this.SetAttributeValue("categorycode", (object) value);
        this.OnPropertyChanged(nameof (CategoryCode));
      }
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

    [AttributeLogicalName("reportcategoryid")]
    public Guid? ReportCategoryId
    {
      get => this.GetAttributeValue<Guid?>("reportcategoryid");
      set
      {
        this.OnPropertyChanging(nameof (ReportCategoryId));
        this.SetAttributeValue("reportcategoryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ReportCategoryId));
      }
    }

    [AttributeLogicalName("reportcategoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ReportCategoryId = new Guid?(value);
    }

    [AttributeLogicalName("reportcategoryidunique")]
    public Guid? ReportCategoryIdUnique => this.GetAttributeValue<Guid?>("reportcategoryidunique");

    [AttributeLogicalName("reportid")]
    public EntityReference ReportId
    {
      get => this.GetAttributeValue<EntityReference>("reportid");
      set
      {
        this.OnPropertyChanging(nameof (ReportId));
        this.SetAttributeValue("reportid", (object) value);
        this.OnPropertyChanged(nameof (ReportId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

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

    [RelationshipSchemaName("reportcategory_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> reportcategory_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (reportcategory_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (reportcategory_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (reportcategory_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (reportcategory_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("ReportCategory_SyncErrors")]
    public IEnumerable<SyncError> ReportCategory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ReportCategory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ReportCategory_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ReportCategory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ReportCategory_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_reportcategory")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_reportcategory
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_reportcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_reportcategory));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_reportcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_reportcategory));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_reportcategory_createdonbehalfby")]
    public SystemUser lk_reportcategory_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportcategory_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_reportcategory_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_reportcategory_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_reportcategory_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_reportcategory_modifiedonbehalfby")]
    public SystemUser lk_reportcategory_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportcategory_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_reportcategory_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_reportcategory_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_reportcategory_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_reportcategorybase_createdby")]
    public SystemUser lk_reportcategorybase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportcategorybase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_reportcategorybase_modifiedby")]
    public SystemUser lk_reportcategorybase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportcategorybase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("reportid")]
    [RelationshipSchemaName("report_reportcategories")]
    public Report report_reportcategories
    {
      get => this.GetRelatedEntity<Report>(nameof (report_reportcategories), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (report_reportcategories));
        this.SetRelatedEntity<Report>(nameof (report_reportcategories), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportcategories));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ReportCategory")]
    public TransactionCurrency TransactionCurrency_ReportCategory
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ReportCategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ReportCategory));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ReportCategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ReportCategory));
      }
    }

    public ReportCategory(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["reportcategoryid"] = (object) base.Id;
            break;
          case "reportcategoryid":
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
