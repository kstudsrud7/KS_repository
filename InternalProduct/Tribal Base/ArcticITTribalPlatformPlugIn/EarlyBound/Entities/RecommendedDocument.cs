// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RecommendedDocument
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("recommendeddocument")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RecommendedDocument : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "recommendeddocument";
    public const string EntitySchemaName = "RecommendedDocument";
    public const string PrimaryIdAttribute = "recommendeddocumentid";
    public const string PrimaryNameAttribute = "title";

    public RecommendedDocument()
      : base("recommendeddocument")
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

    [AttributeLogicalName("absoluteurl")]
    public string AbsoluteUrl => this.GetAttributeValue<string>("absoluteurl");

    [AttributeLogicalName("associatedrecordname")]
    public string AssociatedRecordName
    {
      get => this.GetAttributeValue<string>("associatedrecordname");
      set
      {
        this.OnPropertyChanging(nameof (AssociatedRecordName));
        this.SetAttributeValue("associatedrecordname", (object) value);
        this.OnPropertyChanged(nameof (AssociatedRecordName));
      }
    }

    [AttributeLogicalName("author")]
    public string Author
    {
      get => this.GetAttributeValue<string>("author");
      set
      {
        this.OnPropertyChanging(nameof (Author));
        this.SetAttributeValue("author", (object) value);
        this.OnPropertyChanged(nameof (Author));
      }
    }

    [AttributeLogicalName("contenttype")]
    public string ContentType => this.GetAttributeValue<string>("contenttype");

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

    [AttributeLogicalName("editurl")]
    public string EditUrl => this.GetAttributeValue<string>("editurl");

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("externaldocumentid")]
    public string ExternalDocumentId
    {
      get => this.GetAttributeValue<string>("externaldocumentid");
      set
      {
        this.OnPropertyChanging(nameof (ExternalDocumentId));
        this.SetAttributeValue("externaldocumentid", (object) value);
        this.OnPropertyChanged(nameof (ExternalDocumentId));
      }
    }

    [AttributeLogicalName("externalmodifiedby")]
    public string ExternalModifiedBy
    {
      get => this.GetAttributeValue<string>("externalmodifiedby");
      set
      {
        this.OnPropertyChanging(nameof (ExternalModifiedBy));
        this.SetAttributeValue("externalmodifiedby", (object) value);
        this.OnPropertyChanged(nameof (ExternalModifiedBy));
      }
    }

    [AttributeLogicalName("filesize")]
    public int? FileSize => this.GetAttributeValue<int?>("filesize");

    [AttributeLogicalName("filetype")]
    public string FileType => this.GetAttributeValue<string>("filetype");

    [AttributeLogicalName("fullname")]
    public string FullName => this.GetAttributeValue<string>("fullname");

    [AttributeLogicalName("iconclassname")]
    public string IconClassName => this.GetAttributeValue<string>("iconclassname");

    [AttributeLogicalName("location")]
    public string Location => this.GetAttributeValue<string>("location");

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

    [AttributeLogicalName("readurl")]
    public string ReadUrl => this.GetAttributeValue<string>("readurl");

    [AttributeLogicalName("recommendeddocumentid")]
    public Guid? RecommendedDocumentId
    {
      get => this.GetAttributeValue<Guid?>("recommendeddocumentid");
      set
      {
        this.OnPropertyChanging(nameof (RecommendedDocumentId));
        this.SetAttributeValue("recommendeddocumentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RecommendedDocumentId));
      }
    }

    [AttributeLogicalName("recommendeddocumentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RecommendedDocumentId = new Guid?(value);
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
    public string Source
    {
      get => this.GetAttributeValue<string>("source");
      set
      {
        this.OnPropertyChanging(nameof (Source));
        this.SetAttributeValue("source", (object) value);
        this.OnPropertyChanged(nameof (Source));
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

    [AttributeLogicalName("version")]
    public string Version => this.GetAttributeValue<string>("version");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_recommendeddocument_createdby")]
    public SystemUser lk_recommendeddocument_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recommendeddocument_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_recommendeddocument_createdonbehalfby")]
    public SystemUser lk_recommendeddocument_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recommendeddocument_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_recommendeddocument_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_recommendeddocument_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_recommendeddocument_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_recommendeddocument_modifiedby")]
    public SystemUser lk_recommendeddocument_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recommendeddocument_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_recommendeddocument_modifiedonbehalfby")]
    public SystemUser lk_recommendeddocument_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_recommendeddocument_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_recommendeddocument_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_recommendeddocument_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_recommendeddocument_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_recommendeddocument")]
    public Organization organization_recommendeddocument
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_recommendeddocument), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_recommendeddocument")]
    public TransactionCurrency TransactionCurrency_recommendeddocument
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_recommendeddocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_recommendeddocument));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_recommendeddocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_recommendeddocument));
      }
    }

    public RecommendedDocument(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["recommendeddocumentid"] = (object) base.Id;
            break;
          case "recommendeddocumentid":
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
