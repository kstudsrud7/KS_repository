// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PluginAssembly
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("pluginassembly")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PluginAssembly : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "pluginassembly";
    public const string EntitySchemaName = "PluginAssembly";
    public const string PrimaryIdAttribute = "pluginassemblyid";
    public const string PrimaryNameAttribute = "name";

    public PluginAssembly()
      : base("pluginassembly")
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

    [AttributeLogicalName("authtype")]
    public OptionSetValue AuthType
    {
      get => this.GetAttributeValue<OptionSetValue>("authtype");
      set
      {
        this.OnPropertyChanging(nameof (AuthType));
        this.SetAttributeValue("authtype", (object) value);
        this.OnPropertyChanged(nameof (AuthType));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("content")]
    public string Content
    {
      get => this.GetAttributeValue<string>("content");
      set
      {
        this.OnPropertyChanging(nameof (Content));
        this.SetAttributeValue("content", (object) value);
        this.OnPropertyChanged(nameof (Content));
      }
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (CreatedOnBehalfBy));
        this.SetAttributeValue("createdonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (CreatedOnBehalfBy));
      }
    }

    [AttributeLogicalName("culture")]
    public string Culture
    {
      get => this.GetAttributeValue<string>("culture");
      set
      {
        this.OnPropertyChanging(nameof (Culture));
        this.SetAttributeValue("culture", (object) value);
        this.OnPropertyChanged(nameof (Culture));
      }
    }

    [AttributeLogicalName("customizationlevel")]
    public int? CustomizationLevel => this.GetAttributeValue<int?>("customizationlevel");

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
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

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ishidden")]
    public BooleanManagedProperty IsHidden
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("ishidden");
      set
      {
        this.OnPropertyChanging(nameof (IsHidden));
        this.SetAttributeValue("ishidden", (object) value);
        this.OnPropertyChanged(nameof (IsHidden));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isolationmode")]
    public OptionSetValue IsolationMode
    {
      get => this.GetAttributeValue<OptionSetValue>("isolationmode");
      set
      {
        this.OnPropertyChanging(nameof (IsolationMode));
        this.SetAttributeValue("isolationmode", (object) value);
        this.OnPropertyChanged(nameof (IsolationMode));
      }
    }

    [AttributeLogicalName("ispasswordset")]
    public bool? IsPasswordSet => this.GetAttributeValue<bool?>("ispasswordset");

    [AttributeLogicalName("major")]
    public int? Major => this.GetAttributeValue<int?>("major");

    [AttributeLogicalName("minor")]
    public int? Minor => this.GetAttributeValue<int?>("minor");

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (ModifiedOnBehalfBy));
        this.SetAttributeValue("modifiedonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (ModifiedOnBehalfBy));
      }
    }

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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("password")]
    public string Password
    {
      get => this.GetAttributeValue<string>("password");
      set
      {
        this.OnPropertyChanging(nameof (Password));
        this.SetAttributeValue("password", (object) value);
        this.OnPropertyChanged(nameof (Password));
      }
    }

    [AttributeLogicalName("path")]
    public string Path
    {
      get => this.GetAttributeValue<string>("path");
      set
      {
        this.OnPropertyChanging(nameof (Path));
        this.SetAttributeValue("path", (object) value);
        this.OnPropertyChanged(nameof (Path));
      }
    }

    [AttributeLogicalName("pluginassemblyid")]
    public Guid? PluginAssemblyId
    {
      get => this.GetAttributeValue<Guid?>("pluginassemblyid");
      set
      {
        this.OnPropertyChanging(nameof (PluginAssemblyId));
        this.SetAttributeValue("pluginassemblyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PluginAssemblyId));
      }
    }

    [AttributeLogicalName("pluginassemblyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PluginAssemblyId = new Guid?(value);
    }

    [AttributeLogicalName("pluginassemblyidunique")]
    public Guid? PluginAssemblyIdUnique => this.GetAttributeValue<Guid?>("pluginassemblyidunique");

    [AttributeLogicalName("publickeytoken")]
    public string PublicKeyToken
    {
      get => this.GetAttributeValue<string>("publickeytoken");
      set
      {
        this.OnPropertyChanging(nameof (PublicKeyToken));
        this.SetAttributeValue("publickeytoken", (object) value);
        this.OnPropertyChanged(nameof (PublicKeyToken));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("sourcehash")]
    public string SourceHash
    {
      get => this.GetAttributeValue<string>("sourcehash");
      set
      {
        this.OnPropertyChanging(nameof (SourceHash));
        this.SetAttributeValue("sourcehash", (object) value);
        this.OnPropertyChanged(nameof (SourceHash));
      }
    }

    [AttributeLogicalName("sourcetype")]
    public OptionSetValue SourceType
    {
      get => this.GetAttributeValue<OptionSetValue>("sourcetype");
      set
      {
        this.OnPropertyChanging(nameof (SourceType));
        this.SetAttributeValue("sourcetype", (object) value);
        this.OnPropertyChanged(nameof (SourceType));
      }
    }

    [AttributeLogicalName("url")]
    public string Url
    {
      get => this.GetAttributeValue<string>("url");
      set
      {
        this.OnPropertyChanging(nameof (Url));
        this.SetAttributeValue("url", (object) value);
        this.OnPropertyChanged(nameof (Url));
      }
    }

    [AttributeLogicalName("username")]
    public string UserName
    {
      get => this.GetAttributeValue<string>("username");
      set
      {
        this.OnPropertyChanging(nameof (UserName));
        this.SetAttributeValue("username", (object) value);
        this.OnPropertyChanged(nameof (UserName));
      }
    }

    [AttributeLogicalName("version")]
    public string Version
    {
      get => this.GetAttributeValue<string>("version");
      set
      {
        this.OnPropertyChanging(nameof (Version));
        this.SetAttributeValue("version", (object) value);
        this.OnPropertyChanged(nameof (Version));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("pluginassembly_plugintype")]
    public IEnumerable<PluginType> pluginassembly_plugintype
    {
      get
      {
        return this.GetRelatedEntities<PluginType>(nameof (pluginassembly_plugintype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pluginassembly_plugintype));
        this.SetRelatedEntities<PluginType>(nameof (pluginassembly_plugintype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pluginassembly_plugintype));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_pluginassembly")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_pluginassembly
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_pluginassembly), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_pluginassembly));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_pluginassembly), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_pluginassembly));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_pluginassembly")]
    public SystemUser createdby_pluginassembly
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_pluginassembly), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_pluginassembly_createdonbehalfby")]
    public SystemUser lk_pluginassembly_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_pluginassembly_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_pluginassembly_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_pluginassembly_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_pluginassembly_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_pluginassembly_modifiedonbehalfby")]
    public SystemUser lk_pluginassembly_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_pluginassembly_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_pluginassembly_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_pluginassembly_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_pluginassembly_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_pluginassembly")]
    public SystemUser modifiedby_pluginassembly
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_pluginassembly), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_pluginassembly")]
    public Organization organization_pluginassembly
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_pluginassembly), new EntityRole?());
      }
    }

    public PluginAssembly(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["pluginassemblyid"] = (object) base.Id;
            break;
          case "pluginassemblyid":
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
