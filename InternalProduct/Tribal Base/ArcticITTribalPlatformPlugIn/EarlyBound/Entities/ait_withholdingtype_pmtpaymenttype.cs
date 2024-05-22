// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_withholdingtype_pmtpaymenttype
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_withholdingtype_pmtpaymenttype")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_withholdingtype_pmtpaymenttype : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_withholdingtype_pmtpaymenttype";
    public const string EntitySchemaName = "ait_withholdingtype_pmtpaymenttype";
    public const string PrimaryIdAttribute = "ait_withholdingtype_pmtpaymenttypeid";

    public ait_withholdingtype_pmtpaymenttype()
      : base(nameof (ait_withholdingtype_pmtpaymenttype))
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

    [AttributeLogicalName("ait_pmtpaymenttypeid")]
    public Guid? ait_pmtpaymenttypeid
    {
      get => this.GetAttributeValue<Guid?>(nameof (ait_pmtpaymenttypeid));
    }

    [AttributeLogicalName("ait_withholdingtype_pmtpaymenttypeid")]
    public Guid? ait_withholdingtype_pmtpaymenttypeId
    {
      get => this.GetAttributeValue<Guid?>("ait_withholdingtype_pmtpaymenttypeid");
    }

    [AttributeLogicalName("ait_withholdingtype_pmtpaymenttypeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("ait_withholdingtypeid")]
    public Guid? ait_withholdingtypeid
    {
      get => this.GetAttributeValue<Guid?>(nameof (ait_withholdingtypeid));
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_withholdingtype_pmtpaymenttype")]
    public IEnumerable<ait_withholdingtype> ait_withholdingtype_pmtpaymenttype1
    {
      get
      {
        return this.GetRelatedEntities<ait_withholdingtype>(nameof (ait_withholdingtype_pmtpaymenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_pmtpaymenttype1));
        this.SetRelatedEntities<ait_withholdingtype>(nameof (ait_withholdingtype_pmtpaymenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_pmtpaymenttype1));
      }
    }

    public ait_withholdingtype_pmtpaymenttype(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_withholdingtype_pmtpaymenttypeid"] = (object) base.Id;
            break;
          case "ait_withholdingtype_pmtpaymenttypeid":
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
