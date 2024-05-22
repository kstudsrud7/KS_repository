// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.OrganizationUI
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("organizationui")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class OrganizationUI : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "organizationui";
    public const string EntitySchemaName = "OrganizationUI";
    public const string PrimaryIdAttribute = "formid";

    public OrganizationUI()
      : base("organizationui")
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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("fieldxml")]
    public string FieldXml
    {
      get => this.GetAttributeValue<string>("fieldxml");
      set
      {
        this.OnPropertyChanging(nameof (FieldXml));
        this.SetAttributeValue("fieldxml", (object) value);
        this.OnPropertyChanged(nameof (FieldXml));
      }
    }

    [AttributeLogicalName("formid")]
    public Guid? FormId
    {
      get => this.GetAttributeValue<Guid?>("formid");
      set
      {
        this.OnPropertyChanging(nameof (FormId));
        this.SetAttributeValue("formid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (FormId));
      }
    }

    [AttributeLogicalName("formid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.FormId = new Guid?(value);
    }

    [AttributeLogicalName("formidunique")]
    public Guid? FormIdUnique => this.GetAttributeValue<Guid?>("formidunique");

    [AttributeLogicalName("formxml")]
    public string FormXml
    {
      get => this.GetAttributeValue<string>("formxml");
      set
      {
        this.OnPropertyChanging(nameof (FormXml));
        this.SetAttributeValue("formxml", (object) value);
        this.OnPropertyChanged(nameof (FormXml));
      }
    }

    [AttributeLogicalName("gridicon")]
    public string GridIcon
    {
      get => this.GetAttributeValue<string>("gridicon");
      set
      {
        this.OnPropertyChanging(nameof (GridIcon));
        this.SetAttributeValue("gridicon", (object) value);
        this.OnPropertyChanged(nameof (GridIcon));
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

    [AttributeLogicalName("largeentityicon")]
    public string LargeEntityIcon
    {
      get => this.GetAttributeValue<string>("largeentityicon");
      set
      {
        this.OnPropertyChanging(nameof (LargeEntityIcon));
        this.SetAttributeValue("largeentityicon", (object) value);
        this.OnPropertyChanged(nameof (LargeEntityIcon));
      }
    }

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("outlookshortcuticon")]
    public string OutlookShortcutIcon
    {
      get => this.GetAttributeValue<string>("outlookshortcuticon");
      set
      {
        this.OnPropertyChanging(nameof (OutlookShortcutIcon));
        this.SetAttributeValue("outlookshortcuticon", (object) value);
        this.OnPropertyChanged(nameof (OutlookShortcutIcon));
      }
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("previewcolumnsetxml")]
    public string PreviewColumnsetXml
    {
      get => this.GetAttributeValue<string>("previewcolumnsetxml");
      set
      {
        this.OnPropertyChanging(nameof (PreviewColumnsetXml));
        this.SetAttributeValue("previewcolumnsetxml", (object) value);
        this.OnPropertyChanged(nameof (PreviewColumnsetXml));
      }
    }

    [AttributeLogicalName("previewxml")]
    public string PreviewXml
    {
      get => this.GetAttributeValue<string>("previewxml");
      set
      {
        this.OnPropertyChanging(nameof (PreviewXml));
        this.SetAttributeValue("previewxml", (object) value);
        this.OnPropertyChanged(nameof (PreviewXml));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("version")]
    public int? Version
    {
      get => this.GetAttributeValue<int?>("version");
      set
      {
        this.OnPropertyChanging(nameof (Version));
        this.SetAttributeValue("version", (object) value);
        this.OnPropertyChanged(nameof (Version));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("lk_organizationui_organizationid")]
    public Organization lk_organizationui_organizationid
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (lk_organizationui_organizationid), new EntityRole?());
      }
    }

    public OrganizationUI(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["formid"] = (object) base.Id;
            break;
          case "formid":
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
