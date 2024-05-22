// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_icwaregionnotification_ait_icwaregi
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_icwaregionnotification_ait_icwaregi")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_icwaregionnotification_ait_icwaregi : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_icwaregionnotification_ait_icwaregi";
    public const string EntitySchemaName = "ait_icwaregionnotification_ait_icwaregi";
    public const string PrimaryIdAttribute = "ait_icwaregionnotification_ait_icwaregiid";

    public ait_icwaregionnotification_ait_icwaregi()
      : base(nameof (ait_icwaregionnotification_ait_icwaregi))
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

    [AttributeLogicalName("ait_icwaregionid")]
    public Guid? ait_icwaregionid => this.GetAttributeValue<Guid?>(nameof (ait_icwaregionid));

    [AttributeLogicalName("ait_icwaregionnotification_ait_icwaregiid")]
    public Guid? ait_icwaregionnotification_ait_icwaregiId
    {
      get => this.GetAttributeValue<Guid?>("ait_icwaregionnotification_ait_icwaregiid");
    }

    [AttributeLogicalName("ait_icwaregionnotification_ait_icwaregiid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("ait_icwaregionnotificationid")]
    public Guid? ait_icwaregionnotificationid
    {
      get => this.GetAttributeValue<Guid?>(nameof (ait_icwaregionnotificationid));
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_icwaregionnotification_ait_icwaregion")]
    public IEnumerable<ait_icwaregionnotification> ait_icwaregionnotification_ait_icwaregion
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_ait_icwaregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_ait_icwaregion));
        this.SetRelatedEntities<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_ait_icwaregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_ait_icwaregion));
      }
    }

    public ait_icwaregionnotification_ait_icwaregi(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_icwaregionnotification_ait_icwaregiid"] = (object) base.Id;
            break;
          case "ait_icwaregionnotification_ait_icwaregiid":
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
