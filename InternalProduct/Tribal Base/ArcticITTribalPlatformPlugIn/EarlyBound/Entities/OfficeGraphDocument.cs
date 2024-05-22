// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.OfficeGraphDocument
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("officegraphdocument")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class OfficeGraphDocument : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "officegraphdocument";
    public const string EntitySchemaName = "OfficeGraphDocument";
    public const string PrimaryIdAttribute = "officegraphdocumentid";
    public const string PrimaryNameAttribute = "title";

    public OfficeGraphDocument()
      : base("officegraphdocument")
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

    [AttributeLogicalName("authornames")]
    public string AuthorNames => this.GetAttributeValue<string>("authornames");

    [AttributeLogicalName("createdby")]
    public string CreatedBy => this.GetAttributeValue<string>("createdby");

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

    [AttributeLogicalName("createdtime")]
    public DateTime? CreatedTime => this.GetAttributeValue<DateTime?>("createdtime");

    [AttributeLogicalName("documentid")]
    public string DocumentId
    {
      get => this.GetAttributeValue<string>("documentid");
      set
      {
        this.OnPropertyChanging(nameof (DocumentId));
        this.SetAttributeValue("documentid", (object) value);
        this.OnPropertyChanged(nameof (DocumentId));
      }
    }

    [AttributeLogicalName("documentlastmodifiedby")]
    public string DocumentLastModifiedBy
    {
      get => this.GetAttributeValue<string>("documentlastmodifiedby");
    }

    [AttributeLogicalName("documentlastmodifiedon")]
    public DateTime? DocumentLastModifiedOn
    {
      get => this.GetAttributeValue<DateTime?>("documentlastmodifiedon");
    }

    [AttributeLogicalName("documentpreviewmetadata")]
    public string DocumentPreviewMetadata
    {
      get => this.GetAttributeValue<string>("documentpreviewmetadata");
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("fileextension")]
    public string FileExtension => this.GetAttributeValue<string>("fileextension");

    [AttributeLogicalName("filetype")]
    public string FileType => this.GetAttributeValue<string>("filetype");

    [AttributeLogicalName("modifiedby")]
    public string ModifiedBy => this.GetAttributeValue<string>("modifiedby");

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

    [AttributeLogicalName("modifiedtime")]
    public DateTime? ModifiedTime => this.GetAttributeValue<DateTime?>("modifiedtime");

    [AttributeLogicalName("officegraphdocumentid")]
    public Guid? OfficeGraphDocumentId
    {
      get => this.GetAttributeValue<Guid?>("officegraphdocumentid");
      set
      {
        this.OnPropertyChanging(nameof (OfficeGraphDocumentId));
        this.SetAttributeValue("officegraphdocumentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (OfficeGraphDocumentId));
      }
    }

    [AttributeLogicalName("officegraphdocumentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.OfficeGraphDocumentId = new Guid?(value);
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("previewimageurl")]
    public string PreviewImageUrl => this.GetAttributeValue<string>("previewimageurl");

    [AttributeLogicalName("querytype")]
    public int? QueryType => this.GetAttributeValue<int?>("querytype");

    [AttributeLogicalName("rank")]
    public int? Rank => this.GetAttributeValue<int?>("rank");

    [AttributeLogicalName("readurl")]
    public string ReadUrl => this.GetAttributeValue<string>("readurl");

    [AttributeLogicalName("secondaryfileextension")]
    public string SecondaryFileExtension
    {
      get => this.GetAttributeValue<string>("secondaryfileextension");
    }

    [AttributeLogicalName("sitetitle")]
    public string SiteTitle => this.GetAttributeValue<string>("sitetitle");

    [AttributeLogicalName("siteurl")]
    public string SiteUrl => this.GetAttributeValue<string>("siteurl");

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

    [AttributeLogicalName("viewcount")]
    public int? ViewCount => this.GetAttributeValue<int?>("viewcount");

    [AttributeLogicalName("weblocationurl")]
    public string WebLocationUrl => this.GetAttributeValue<string>("weblocationurl");

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_officegraphdocument_createdonbehalfby")]
    public SystemUser lk_officegraphdocument_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_officegraphdocument_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_officegraphdocument_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_officegraphdocument_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_officegraphdocument_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_officegraphdocument_modifiedonbehalfby")]
    public SystemUser lk_officegraphdocument_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_officegraphdocument_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_officegraphdocument_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_officegraphdocument_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_officegraphdocument_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_officegraphdocument")]
    public Organization organization_officegraphdocument
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_officegraphdocument), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_officegraphdocument")]
    public TransactionCurrency TransactionCurrency_officegraphdocument
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_officegraphdocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_officegraphdocument));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_officegraphdocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_officegraphdocument));
      }
    }

    public OfficeGraphDocument(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["officegraphdocumentid"] = (object) base.Id;
            break;
          case "officegraphdocumentid":
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
