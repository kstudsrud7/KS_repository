// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ChannelAccessProfileEntityAccessLevel
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("channelaccessprofileentityaccesslevel")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ChannelAccessProfileEntityAccessLevel : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "channelaccessprofileentityaccesslevel";
    public const string EntitySchemaName = "ChannelAccessProfileEntityAccessLevel";
    public const string PrimaryIdAttribute = "channelaccessprofileentityaccesslevelid";

    public ChannelAccessProfileEntityAccessLevel()
      : base("channelaccessprofileentityaccesslevel")
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

    [AttributeLogicalName("channelaccessprofileentityaccesslevelid")]
    public Guid? ChannelAccessProfileEntityAccessLevelId
    {
      get => this.GetAttributeValue<Guid?>("channelaccessprofileentityaccesslevelid");
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileEntityAccessLevelId));
        this.SetAttributeValue("channelaccessprofileentityaccesslevelid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ChannelAccessProfileEntityAccessLevelId));
      }
    }

    [AttributeLogicalName("channelaccessprofileentityaccesslevelid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ChannelAccessProfileEntityAccessLevelId = new Guid?(value);
    }

    [AttributeLogicalName("channelaccessprofileentityaccesslevelidunique")]
    public Guid? ChannelAccessProfileEntityAccessLevelIdUnique
    {
      get => this.GetAttributeValue<Guid?>("channelaccessprofileentityaccesslevelidunique");
    }

    [AttributeLogicalName("channelaccessprofileid")]
    public Guid? ChannelAccessProfileId => this.GetAttributeValue<Guid?>("channelaccessprofileid");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("entityaccessleveldepthmask")]
    public int? EntityAccessLevelDepthMask
    {
      get => this.GetAttributeValue<int?>("entityaccessleveldepthmask");
      set
      {
        this.OnPropertyChanging(nameof (EntityAccessLevelDepthMask));
        this.SetAttributeValue("entityaccessleveldepthmask", (object) value);
        this.OnPropertyChanged(nameof (EntityAccessLevelDepthMask));
      }
    }

    [AttributeLogicalName("entityaccesslevelid")]
    public Guid? EntityAccessLevelId => this.GetAttributeValue<Guid?>("entityaccesslevelid");

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ChannelAccessProfile_Privilege")]
    public IEnumerable<Privilege> ChannelAccessProfile_Privilege
    {
      get
      {
        return this.GetRelatedEntities<Privilege>(nameof (ChannelAccessProfile_Privilege), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfile_Privilege));
        this.SetRelatedEntities<Privilege>(nameof (ChannelAccessProfile_Privilege), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfile_Privilege));
      }
    }

    public ChannelAccessProfileEntityAccessLevel(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["channelaccessprofileentityaccesslevelid"] = (object) base.Id;
            break;
          case "channelaccessprofileentityaccesslevelid":
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
