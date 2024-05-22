// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.OrgInsightsNotification
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("orginsightsnotification")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class OrgInsightsNotification : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "orginsightsnotification";
    public const string EntitySchemaName = "OrgInsightsNotification";
    public const string PrimaryIdAttribute = "orginsightsnotificationid";

    public OrgInsightsNotification()
      : base("orginsightsnotification")
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

    [AttributeLogicalName("internalname")]
    public string InternalName
    {
      get => this.GetAttributeValue<string>("internalname");
      set
      {
        this.OnPropertyChanging(nameof (InternalName));
        this.SetAttributeValue("internalname", (object) value);
        this.OnPropertyChanged(nameof (InternalName));
      }
    }

    [AttributeLogicalName("jsondata")]
    public string JsonData => this.GetAttributeValue<string>("jsondata");

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

    [AttributeLogicalName("orginsightsnotificationid")]
    public Guid? OrgInsightsNotificationId
    {
      get => this.GetAttributeValue<Guid?>("orginsightsnotificationid");
      set
      {
        this.OnPropertyChanging(nameof (OrgInsightsNotificationId));
        this.SetAttributeValue("orginsightsnotificationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (OrgInsightsNotificationId));
      }
    }

    [AttributeLogicalName("orginsightsnotificationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.OrgInsightsNotificationId = new Guid?(value);
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_orginsightsnotification")]
    public Organization organization_orginsightsnotification
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_orginsightsnotification), new EntityRole?());
      }
    }

    public OrgInsightsNotification(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["orginsightsnotificationid"] = (object) base.Id;
            break;
          case "orginsightsnotificationid":
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
