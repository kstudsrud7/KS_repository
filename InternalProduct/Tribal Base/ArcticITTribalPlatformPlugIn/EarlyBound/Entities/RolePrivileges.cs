// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.RolePrivileges
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("roleprivileges")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class RolePrivileges : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "roleprivileges";
    public const string EntitySchemaName = "RolePrivileges";
    public const string PrimaryIdAttribute = "roleprivilegeid";

    public RolePrivileges()
      : base("roleprivileges")
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

    [AttributeLogicalName("canbedeleted")]
    public BooleanManagedProperty CanBeDeleted
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("canbedeleted");
      set
      {
        this.OnPropertyChanging(nameof (CanBeDeleted));
        this.SetAttributeValue("canbedeleted", (object) value);
        this.OnPropertyChanged(nameof (CanBeDeleted));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("privilegedepthmask")]
    public int? PrivilegeDepthMask
    {
      get => this.GetAttributeValue<int?>("privilegedepthmask");
      set
      {
        this.OnPropertyChanging(nameof (PrivilegeDepthMask));
        this.SetAttributeValue("privilegedepthmask", (object) value);
        this.OnPropertyChanged(nameof (PrivilegeDepthMask));
      }
    }

    [AttributeLogicalName("privilegeid")]
    public Guid? PrivilegeId => this.GetAttributeValue<Guid?>("privilegeid");

    [AttributeLogicalName("roleid")]
    public Guid? RoleId => this.GetAttributeValue<Guid?>("roleid");

    [AttributeLogicalName("roleprivilegeid")]
    public Guid? RolePrivilegeId
    {
      get => this.GetAttributeValue<Guid?>("roleprivilegeid");
      set
      {
        this.OnPropertyChanging(nameof (RolePrivilegeId));
        this.SetAttributeValue("roleprivilegeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (RolePrivilegeId));
      }
    }

    [AttributeLogicalName("roleprivilegeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.RolePrivilegeId = new Guid?(value);
    }

    [AttributeLogicalName("roleprivilegeidunique")]
    public Guid? RolePrivilegeIdUnique => this.GetAttributeValue<Guid?>("roleprivilegeidunique");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("roleprivileges_association")]
    public IEnumerable<Privilege> roleprivileges_association
    {
      get
      {
        return this.GetRelatedEntities<Privilege>(nameof (roleprivileges_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (roleprivileges_association));
        this.SetRelatedEntities<Privilege>(nameof (roleprivileges_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (roleprivileges_association));
      }
    }

    [AttributeLogicalName("solutionid")]
    [RelationshipSchemaName("solution_roleprivileges")]
    public Solution solution_roleprivileges
    {
      get => this.GetRelatedEntity<Solution>(nameof (solution_roleprivileges), new EntityRole?());
    }

    public RolePrivileges(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["roleprivilegeid"] = (object) base.Id;
            break;
          case "roleprivilegeid":
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
