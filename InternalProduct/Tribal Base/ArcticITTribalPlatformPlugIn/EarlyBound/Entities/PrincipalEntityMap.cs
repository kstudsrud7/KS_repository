// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PrincipalEntityMap
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("principalentitymap")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PrincipalEntityMap : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "principalentitymap";
    public const string EntitySchemaName = "PrincipalEntityMap";
    public const string PrimaryIdAttribute = "principalentitymapid";

    public PrincipalEntityMap()
      : base("principalentitymap")
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

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode => this.GetAttributeValue<string>("objecttypecode");

    [AttributeLogicalName("principalentitymapid")]
    public Guid? PrincipalEntityMapId
    {
      get => this.GetAttributeValue<Guid?>("principalentitymapid");
      set
      {
        this.OnPropertyChanging(nameof (PrincipalEntityMapId));
        this.SetAttributeValue("principalentitymapid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PrincipalEntityMapId));
      }
    }

    [AttributeLogicalName("principalentitymapid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PrincipalEntityMapId = new Guid?(value);
    }

    [AttributeLogicalName("principalid")]
    public Guid? PrincipalId => this.GetAttributeValue<Guid?>("principalid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_principalentitymap")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_principalentitymap
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_principalentitymap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_principalentitymap));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_principalentitymap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_principalentitymap));
      }
    }

    public PrincipalEntityMap(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["principalentitymapid"] = (object) base.Id;
            break;
          case "principalentitymapid":
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
