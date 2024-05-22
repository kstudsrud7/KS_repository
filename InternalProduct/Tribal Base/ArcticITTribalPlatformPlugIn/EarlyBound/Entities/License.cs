// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.License
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("license")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class License : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "license";
    public const string EntitySchemaName = "License";
    public const string PrimaryIdAttribute = "licenseid";

    public License()
      : base("license")
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

    [AttributeLogicalName("installedon")]
    public DateTime? InstalledOn
    {
      get => this.GetAttributeValue<DateTime?>("installedon");
      set
      {
        this.OnPropertyChanging(nameof (InstalledOn));
        this.SetAttributeValue("installedon", (object) value);
        this.OnPropertyChanged(nameof (InstalledOn));
      }
    }

    [AttributeLogicalName("licenseid")]
    public Guid? LicenseId
    {
      get => this.GetAttributeValue<Guid?>("licenseid");
      set
      {
        this.OnPropertyChanging(nameof (LicenseId));
        this.SetAttributeValue("licenseid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (LicenseId));
      }
    }

    [AttributeLogicalName("licenseid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.LicenseId = new Guid?(value);
    }

    [AttributeLogicalName("licensekey")]
    public string LicenseKey
    {
      get => this.GetAttributeValue<string>("licensekey");
      set
      {
        this.OnPropertyChanging(nameof (LicenseKey));
        this.SetAttributeValue("licensekey", (object) value);
        this.OnPropertyChanged(nameof (LicenseKey));
      }
    }

    [AttributeLogicalName("licensetype")]
    public Guid? LicenseType
    {
      get => this.GetAttributeValue<Guid?>("licensetype");
      set
      {
        this.OnPropertyChanging(nameof (LicenseType));
        this.SetAttributeValue("licensetype", (object) value);
        this.OnPropertyChanged(nameof (LicenseType));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [RelationshipSchemaName("userentityinstancedata_license")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_license
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_license), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_license));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_license), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_license));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_licenses")]
    public Organization organization_licenses
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_licenses), new EntityRole?());
    }

    public License(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["licenseid"] = (object) base.Id;
            break;
          case "licenseid":
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
