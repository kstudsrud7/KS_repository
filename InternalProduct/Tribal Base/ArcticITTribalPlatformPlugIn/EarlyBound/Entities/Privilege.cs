// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Privilege
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("privilege")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Privilege : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "privilege";
    public const string EntitySchemaName = "Privilege";
    public const string PrimaryIdAttribute = "privilegeid";
    public const string PrimaryNameAttribute = "name";

    public Privilege()
      : base("privilege")
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

    [AttributeLogicalName("accessright")]
    public int? AccessRight
    {
      get => this.GetAttributeValue<int?>("accessright");
      set
      {
        this.OnPropertyChanging(nameof (AccessRight));
        this.SetAttributeValue("accessright", (object) value);
        this.OnPropertyChanged(nameof (AccessRight));
      }
    }

    [AttributeLogicalName("canbebasic")]
    public bool? CanBeBasic
    {
      get => this.GetAttributeValue<bool?>("canbebasic");
      set
      {
        this.OnPropertyChanging(nameof (CanBeBasic));
        this.SetAttributeValue("canbebasic", (object) value);
        this.OnPropertyChanged(nameof (CanBeBasic));
      }
    }

    [AttributeLogicalName("canbedeep")]
    public bool? CanBeDeep
    {
      get => this.GetAttributeValue<bool?>("canbedeep");
      set
      {
        this.OnPropertyChanging(nameof (CanBeDeep));
        this.SetAttributeValue("canbedeep", (object) value);
        this.OnPropertyChanged(nameof (CanBeDeep));
      }
    }

    [AttributeLogicalName("canbeentityreference")]
    public bool? CanBeEntityReference
    {
      get => this.GetAttributeValue<bool?>("canbeentityreference");
      set
      {
        this.OnPropertyChanging(nameof (CanBeEntityReference));
        this.SetAttributeValue("canbeentityreference", (object) value);
        this.OnPropertyChanged(nameof (CanBeEntityReference));
      }
    }

    [AttributeLogicalName("canbeglobal")]
    public bool? CanBeGlobal
    {
      get => this.GetAttributeValue<bool?>("canbeglobal");
      set
      {
        this.OnPropertyChanging(nameof (CanBeGlobal));
        this.SetAttributeValue("canbeglobal", (object) value);
        this.OnPropertyChanged(nameof (CanBeGlobal));
      }
    }

    [AttributeLogicalName("canbelocal")]
    public bool? CanBeLocal
    {
      get => this.GetAttributeValue<bool?>("canbelocal");
      set
      {
        this.OnPropertyChanging(nameof (CanBeLocal));
        this.SetAttributeValue("canbelocal", (object) value);
        this.OnPropertyChanged(nameof (CanBeLocal));
      }
    }

    [AttributeLogicalName("canbeparententityreference")]
    public bool? CanBeParentEntityReference
    {
      get => this.GetAttributeValue<bool?>("canbeparententityreference");
      set
      {
        this.OnPropertyChanging(nameof (CanBeParentEntityReference));
        this.SetAttributeValue("canbeparententityreference", (object) value);
        this.OnPropertyChanged(nameof (CanBeParentEntityReference));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("privilegeid")]
    public Guid? PrivilegeId
    {
      get => this.GetAttributeValue<Guid?>("privilegeid");
      set
      {
        this.OnPropertyChanging(nameof (PrivilegeId));
        this.SetAttributeValue("privilegeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PrivilegeId));
      }
    }

    [AttributeLogicalName("privilegeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PrivilegeId = new Guid?(value);
    }

    [AttributeLogicalName("privilegerowid")]
    public Guid? PrivilegeRowId
    {
      get => this.GetAttributeValue<Guid?>("privilegerowid");
      set
      {
        this.OnPropertyChanging(nameof (PrivilegeRowId));
        this.SetAttributeValue("privilegerowid", (object) value);
        this.OnPropertyChanged(nameof (PrivilegeRowId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("Privilege_AsyncOperations")]
    public IEnumerable<AsyncOperation> Privilege_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Privilege_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Privilege_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Privilege_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Privilege_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Privilege_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Privilege_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Privilege_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Privilege_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Privilege_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Privilege_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_privilege")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_privilege
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_privilege), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_privilege));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_privilege), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_privilege));
      }
    }

    [RelationshipSchemaName("ChannelAccessProfile_Privilege")]
    public IEnumerable<ChannelAccessProfile> ChannelAccessProfile_Privilege
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfile>(nameof (ChannelAccessProfile_Privilege), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfile_Privilege));
        this.SetRelatedEntities<ChannelAccessProfile>(nameof (ChannelAccessProfile_Privilege), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfile_Privilege));
      }
    }

    [RelationshipSchemaName("roleprivileges_association")]
    public IEnumerable<Role> roleprivileges_association
    {
      get => this.GetRelatedEntities<Role>(nameof (roleprivileges_association), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (roleprivileges_association));
        this.SetRelatedEntities<Role>(nameof (roleprivileges_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (roleprivileges_association));
      }
    }

    [AttributeLogicalName("solutionid")]
    [RelationshipSchemaName("solution_privilege")]
    public Solution solution_privilege
    {
      get => this.GetRelatedEntity<Solution>(nameof (solution_privilege), new EntityRole?());
    }

    public Privilege(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["privilegeid"] = (object) base.Id;
            break;
          case "privilegeid":
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
