// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RoleTemplatePrivileges
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("roletemplateprivileges")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RoleTemplatePrivileges : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "roletemplateprivileges";
    public const string EntitySchemaName = "RoleTemplatePrivileges";
    public const string PrimaryIdAttribute = "roletemplateprivilegeid";

    public RoleTemplatePrivileges()
      : base("roletemplateprivileges")
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

    [AttributeLogicalName("isbasic")]
    public bool? IsBasic
    {
      get => this.GetAttributeValue<bool?>("isbasic");
      set
      {
        this.OnPropertyChanging(nameof (IsBasic));
        this.SetAttributeValue("isbasic", (object) value);
        this.OnPropertyChanged(nameof (IsBasic));
      }
    }

    [AttributeLogicalName("isdeep")]
    public bool? IsDeep
    {
      get => this.GetAttributeValue<bool?>("isdeep");
      set
      {
        this.OnPropertyChanging(nameof (IsDeep));
        this.SetAttributeValue("isdeep", (object) value);
        this.OnPropertyChanged(nameof (IsDeep));
      }
    }

    [AttributeLogicalName("isglobal")]
    public bool? IsGlobal
    {
      get => this.GetAttributeValue<bool?>("isglobal");
      set
      {
        this.OnPropertyChanging(nameof (IsGlobal));
        this.SetAttributeValue("isglobal", (object) value);
        this.OnPropertyChanged(nameof (IsGlobal));
      }
    }

    [AttributeLogicalName("islocal")]
    public bool? IsLocal
    {
      get => this.GetAttributeValue<bool?>("islocal");
      set
      {
        this.OnPropertyChanging(nameof (IsLocal));
        this.SetAttributeValue("islocal", (object) value);
        this.OnPropertyChanged(nameof (IsLocal));
      }
    }

    [AttributeLogicalName("privilegeid")]
    public Guid? PrivilegeId => this.GetAttributeValue<Guid?>("privilegeid");

    [AttributeLogicalName("roletemplateid")]
    public Guid? RoleTemplateId => this.GetAttributeValue<Guid?>("roletemplateid");

    [AttributeLogicalName("roletemplateprivilegeid")]
    public Guid? RoleTemplatePrivilegeId
    {
      get => this.GetAttributeValue<Guid?>("roletemplateprivilegeid");
      set
      {
        this.OnPropertyChanging(nameof (RoleTemplatePrivilegeId));
        this.SetAttributeValue("roletemplateprivilegeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RoleTemplatePrivilegeId));
      }
    }

    [AttributeLogicalName("roletemplateprivilegeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RoleTemplatePrivilegeId = new Guid?(value);
    }

    public RoleTemplatePrivileges(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["roletemplateprivilegeid"] = (object) base.Id;
            break;
          case "roletemplateprivilegeid":
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
