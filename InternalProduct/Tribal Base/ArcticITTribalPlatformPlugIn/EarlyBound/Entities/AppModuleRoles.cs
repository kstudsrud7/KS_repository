// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AppModuleRoles
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("appmoduleroles")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AppModuleRoles : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "appmoduleroles";
    public const string EntitySchemaName = "AppModuleRoles";
    public const string PrimaryIdAttribute = "appmoduleroleid";

    public AppModuleRoles()
      : base("appmoduleroles")
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

    [AttributeLogicalName("appmoduleid")]
    public EntityReference AppModuleId => this.GetAttributeValue<EntityReference>("appmoduleid");

    [AttributeLogicalName("appmoduleroleid")]
    public Guid? AppModuleRoleId
    {
      get => this.GetAttributeValue<Guid?>("appmoduleroleid");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleRoleId));
        this.SetAttributeValue("appmoduleroleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AppModuleRoleId));
      }
    }

    [AttributeLogicalName("appmoduleroleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AppModuleRoleId = new Guid?(value);
    }

    [AttributeLogicalName("appmoduleroleidunique")]
    public Guid? AppModuleRoleIdUnique
    {
      get => this.GetAttributeValue<Guid?>("appmoduleroleidunique");
      set
      {
        this.OnPropertyChanging(nameof (AppModuleRoleIdUnique));
        this.SetAttributeValue("appmoduleroleidunique", (object) value);
        this.OnPropertyChanged(nameof (AppModuleRoleIdUnique));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("roleid")]
    public EntityReference RoleId => this.GetAttributeValue<EntityReference>("roleid");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("appmoduleroles_association")]
    public IEnumerable<AppModule> appmoduleroles_association
    {
      get
      {
        return this.GetRelatedEntities<AppModule>(nameof (appmoduleroles_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmoduleroles_association));
        this.SetRelatedEntities<AppModule>(nameof (appmoduleroles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmoduleroles_association));
      }
    }

    public AppModuleRoles(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["appmoduleroleid"] = (object) base.Id;
            break;
          case "appmoduleroleid":
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
