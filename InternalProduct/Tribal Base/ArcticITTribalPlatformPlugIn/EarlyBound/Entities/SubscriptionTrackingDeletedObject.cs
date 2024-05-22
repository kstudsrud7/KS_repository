// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SubscriptionTrackingDeletedObject
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("subscriptiontrackingdeletedobject")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SubscriptionTrackingDeletedObject : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "subscriptiontrackingdeletedobject";
    public const string EntitySchemaName = "SubscriptionTrackingDeletedObject";
    public const string PrimaryIdAttribute = "timestamp";

    public SubscriptionTrackingDeletedObject()
      : base("subscriptiontrackingdeletedobject")
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

    [AttributeLogicalName("crmcreatedon")]
    public DateTime? CrmCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("crmcreatedon");
      set
      {
        this.OnPropertyChanging(nameof (CrmCreatedOn));
        this.SetAttributeValue("crmcreatedon", (object) value);
        this.OnPropertyChanged(nameof (CrmCreatedOn));
      }
    }

    [AttributeLogicalName("deletetime")]
    public DateTime? DeleteTime
    {
      get => this.GetAttributeValue<DateTime?>("deletetime");
      set
      {
        this.OnPropertyChanging(nameof (DeleteTime));
        this.SetAttributeValue("deletetime", (object) value);
        this.OnPropertyChanged(nameof (DeleteTime));
      }
    }

    [AttributeLogicalName("islogicaldelete")]
    public bool? IsLogicalDelete
    {
      get => this.GetAttributeValue<bool?>("islogicaldelete");
      set
      {
        this.OnPropertyChanging(nameof (IsLogicalDelete));
        this.SetAttributeValue("islogicaldelete", (object) value);
        this.OnPropertyChanged(nameof (IsLogicalDelete));
      }
    }

    [AttributeLogicalName("objectid")]
    public Guid? ObjectId => this.GetAttributeValue<Guid?>("objectid");

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode => this.GetAttributeValue<string>("objecttypecode");

    [AttributeLogicalName("timestamp")]
    public long? TimeStamp => this.GetAttributeValue<long?>("timestamp");

    public SubscriptionTrackingDeletedObject(object anonymousType)
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
            this.Id = (Guid) obj;
            ((DataCollection<string, object>) this.Attributes)["timestamp"] = (object) this.Id;
            break;
          case "timestamp":
            Guid? nullable = (Guid?) obj;
            if (nullable.HasValue)
            {
              this.Id = nullable.Value;
              ((DataCollection<string, object>) this.Attributes)[str] = (object) this.Id;
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
