// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.LanguageLocale
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("languagelocale")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class LanguageLocale : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "languagelocale";
    public const string EntitySchemaName = "LanguageLocale";
    public const string PrimaryIdAttribute = "languagelocaleid";
    public const string PrimaryNameAttribute = "name";

    public LanguageLocale()
      : base("languagelocale")
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

    [AttributeLogicalName("code")]
    public string Code => this.GetAttributeValue<string>("code");

    [AttributeLogicalName("language")]
    public string Language => this.GetAttributeValue<string>("language");

    [AttributeLogicalName("languagelocaleid")]
    public Guid? LanguageLocaleId
    {
      get => this.GetAttributeValue<Guid?>("languagelocaleid");
      set
      {
        this.OnPropertyChanging(nameof (LanguageLocaleId));
        this.SetAttributeValue("languagelocaleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (LanguageLocaleId));
      }
    }

    [AttributeLogicalName("languagelocaleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.LanguageLocaleId = new Guid?(value);
    }

    [AttributeLogicalName("localeid")]
    public int? LocaleId
    {
      get => this.GetAttributeValue<int?>("localeid");
      set
      {
        this.OnPropertyChanging(nameof (LocaleId));
        this.SetAttributeValue("localeid", (object) value);
        this.OnPropertyChanged(nameof (LocaleId));
      }
    }

    [AttributeLogicalName("name")]
    public string Name => this.GetAttributeValue<string>("name");

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("region")]
    public string Region => this.GetAttributeValue<string>("region");

    [AttributeLogicalName("statecode")]
    public LanguageLocaleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new LanguageLocaleState?((LanguageLocaleState) Enum.ToObject(typeof (LanguageLocaleState), attributeValue.Value)) : new LanguageLocaleState?();
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("knowledgearticle_languagelocaleid")]
    public IEnumerable<KnowledgeArticle> knowledgearticle_languagelocaleid
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>(nameof (knowledgearticle_languagelocaleid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_languagelocaleid));
        this.SetRelatedEntities<KnowledgeArticle>(nameof (knowledgearticle_languagelocaleid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_languagelocaleid));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("languagelocale_organization")]
    public Organization languagelocale_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (languagelocale_organization), new EntityRole?());
      }
    }

    public LanguageLocale(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["languagelocaleid"] = (object) base.Id;
            break;
          case "languagelocaleid":
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
