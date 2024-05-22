// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.package_solution
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("package_solution")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class package_solution : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "package_solution";
    public const string EntitySchemaName = "package_solution";
    public const string PrimaryIdAttribute = "package_solutionid";

    public package_solution()
      : base(nameof (package_solution))
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

    [AttributeLogicalName("package_solutionid")]
    public Guid? package_solutionId => this.GetAttributeValue<Guid?>("package_solutionid");

    [AttributeLogicalName("package_solutionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("packageid")]
    public Guid? packageid => this.GetAttributeValue<Guid?>(nameof (packageid));

    [AttributeLogicalName("solutionid")]
    public Guid? solutionid => this.GetAttributeValue<Guid?>(nameof (solutionid));

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("package_solution")]
    public IEnumerable<package> package_solution1
    {
      get => this.GetRelatedEntities<package>(nameof (package_solution), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (package_solution1));
        this.SetRelatedEntities<package>(nameof (package_solution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_solution1));
      }
    }

    public package_solution(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["package_solutionid"] = (object) base.Id;
            break;
          case "package_solutionid":
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
