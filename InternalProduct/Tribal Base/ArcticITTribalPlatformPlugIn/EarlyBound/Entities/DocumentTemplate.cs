﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.DocumentTemplate
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("documenttemplate")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class DocumentTemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "documenttemplate";
    public const string EntitySchemaName = "DocumentTemplate";
    public const string PrimaryIdAttribute = "documenttemplateid";
    public const string PrimaryNameAttribute = "name";

    public DocumentTemplate()
      : base("documenttemplate")
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

    [AttributeLogicalName("associatedentitytypecode")]
    public string AssociatedEntityTypeCode
    {
      get => this.GetAttributeValue<string>("associatedentitytypecode");
      set
      {
        this.OnPropertyChanging(nameof (AssociatedEntityTypeCode));
        this.SetAttributeValue("associatedentitytypecode", (object) value);
        this.OnPropertyChanged(nameof (AssociatedEntityTypeCode));
      }
    }

    [AttributeLogicalName("clientdata")]
    public string ClientData
    {
      get => this.GetAttributeValue<string>("clientdata");
      set
      {
        this.OnPropertyChanging(nameof (ClientData));
        this.SetAttributeValue("clientdata", (object) value);
        this.OnPropertyChanged(nameof (ClientData));
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

    [AttributeLogicalName("documenttemplateid")]
    public Guid? DocumentTemplateId
    {
      get => this.GetAttributeValue<Guid?>("documenttemplateid");
      set
      {
        this.OnPropertyChanging(nameof (DocumentTemplateId));
        this.SetAttributeValue("documenttemplateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (DocumentTemplateId));
      }
    }

    [AttributeLogicalName("documenttemplateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.DocumentTemplateId = new Guid?(value);
    }

    [AttributeLogicalName("documenttype")]
    public OptionSetValue DocumentType
    {
      get => this.GetAttributeValue<OptionSetValue>("documenttype");
      set
      {
        this.OnPropertyChanging(nameof (DocumentType));
        this.SetAttributeValue("documenttype", (object) value);
        this.OnPropertyChanged(nameof (DocumentType));
      }
    }

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get => this.GetAttributeValue<int?>("languagecode");
      set
      {
        this.OnPropertyChanging(nameof (LanguageCode));
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged(nameof (LanguageCode));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("status")]
    public bool? Status
    {
      get => this.GetAttributeValue<bool?>("status");
      set
      {
        this.OnPropertyChanging(nameof (Status));
        this.SetAttributeValue("status", (object) value);
        this.OnPropertyChanged(nameof (Status));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_documenttemplatebase_createdby")]
    public SystemUser lk_documenttemplatebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_documenttemplatebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_documenttemplatebase_createdonbehalfby")]
    public SystemUser lk_documenttemplatebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_documenttemplatebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_documenttemplatebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_documenttemplatebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_documenttemplatebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_documenttemplatebase_modifiedby")]
    public SystemUser lk_documenttemplatebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_documenttemplatebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_documenttemplatebase_modifiedonbehalfby")]
    public SystemUser lk_documenttemplatebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_documenttemplatebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_documenttemplatebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_documenttemplatebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_documenttemplatebase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("lk_documenttemplatebase_organization")]
    public Organization lk_documenttemplatebase_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (lk_documenttemplatebase_organization), new EntityRole?());
      }
    }

    public DocumentTemplate(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["documenttemplateid"] = (object) base.Id;
            break;
          case "documenttemplateid":
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