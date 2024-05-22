// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SubscriptionManuallyTrackedObject
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("subscriptionmanuallytrackedobject")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SubscriptionManuallyTrackedObject : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "subscriptionmanuallytrackedobject";
    public const string EntitySchemaName = "SubscriptionManuallyTrackedObject";
    public const string PrimaryIdAttribute = "subscriptionmanuallytrackedobjectid";

    public SubscriptionManuallyTrackedObject()
      : base("subscriptionmanuallytrackedobject")
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

    [AttributeLogicalName("objectid")]
    public Guid? ObjectId
    {
      get => this.GetAttributeValue<Guid?>("objectid");
      set
      {
        this.OnPropertyChanging(nameof (ObjectId));
        this.SetAttributeValue("objectid", (object) value);
        this.OnPropertyChanged(nameof (ObjectId));
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

    [AttributeLogicalName("subscriptionid")]
    public Guid? SubscriptionId
    {
      get => this.GetAttributeValue<Guid?>("subscriptionid");
      set
      {
        this.OnPropertyChanging(nameof (SubscriptionId));
        this.SetAttributeValue("subscriptionid", (object) value);
        this.OnPropertyChanged(nameof (SubscriptionId));
      }
    }

    [AttributeLogicalName("subscriptionmanuallytrackedobjectid")]
    public Guid? SubscriptionManuallyTrackedObjectId
    {
      get => this.GetAttributeValue<Guid?>("subscriptionmanuallytrackedobjectid");
      set
      {
        this.OnPropertyChanging(nameof (SubscriptionManuallyTrackedObjectId));
        this.SetAttributeValue("subscriptionmanuallytrackedobjectid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SubscriptionManuallyTrackedObjectId));
      }
    }

    [AttributeLogicalName("subscriptionmanuallytrackedobjectid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SubscriptionManuallyTrackedObjectId = new Guid?(value);
    }

    [AttributeLogicalName("track")]
    public bool? Track
    {
      get => this.GetAttributeValue<bool?>("track");
      set
      {
        this.OnPropertyChanging(nameof (Track));
        this.SetAttributeValue("track", (object) value);
        this.OnPropertyChanged(nameof (Track));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_subscriptionmanuallytrackedobject")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_subscriptionmanuallytrackedobject
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_subscriptionmanuallytrackedobject), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_subscriptionmanuallytrackedobject));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_subscriptionmanuallytrackedobject), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_subscriptionmanuallytrackedobject));
      }
    }

    public SubscriptionManuallyTrackedObject(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["subscriptionmanuallytrackedobjectid"] = (object) base.Id;
            break;
          case "subscriptionmanuallytrackedobjectid":
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
