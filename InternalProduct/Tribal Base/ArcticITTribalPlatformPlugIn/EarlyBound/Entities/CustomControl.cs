// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CustomControl
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("customcontrol")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CustomControl : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "customcontrol";
    public const string EntitySchemaName = "CustomControl";
    public const string PrimaryIdAttribute = "customcontrolid";
    public const string PrimaryNameAttribute = "name";

    public CustomControl()
      : base("customcontrol")
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

    [AttributeLogicalName("authoringmanifest")]
    public string AuthoringManifest
    {
      get => this.GetAttributeValue<string>("authoringmanifest");
      set
      {
        this.OnPropertyChanging(nameof (AuthoringManifest));
        this.SetAttributeValue("authoringmanifest", (object) value);
        this.OnPropertyChanged(nameof (AuthoringManifest));
      }
    }

    [AttributeLogicalName("clientjson")]
    public string ClientJson
    {
      get => this.GetAttributeValue<string>("clientjson");
      set
      {
        this.OnPropertyChanging(nameof (ClientJson));
        this.SetAttributeValue("clientjson", (object) value);
        this.OnPropertyChanged(nameof (ClientJson));
      }
    }

    [AttributeLogicalName("compatibledatatypes")]
    public string CompatibleDataTypes
    {
      get => this.GetAttributeValue<string>("compatibledatatypes");
      set
      {
        this.OnPropertyChanging(nameof (CompatibleDataTypes));
        this.SetAttributeValue("compatibledatatypes", (object) value);
        this.OnPropertyChanged(nameof (CompatibleDataTypes));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("customcontrolid")]
    public Guid? CustomControlId
    {
      get => this.GetAttributeValue<Guid?>("customcontrolid");
      set
      {
        this.OnPropertyChanging(nameof (CustomControlId));
        this.SetAttributeValue("customcontrolid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CustomControlId));
      }
    }

    [AttributeLogicalName("customcontrolid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CustomControlId = new Guid?(value);
    }

    [AttributeLogicalName("customcontrolidunique")]
    public Guid? CustomControlIdUnique => this.GetAttributeValue<Guid?>("customcontrolidunique");

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

    [AttributeLogicalName("manifest")]
    public string Manifest
    {
      get => this.GetAttributeValue<string>("manifest");
      set
      {
        this.OnPropertyChanging(nameof (Manifest));
        this.SetAttributeValue("manifest", (object) value);
        this.OnPropertyChanged(nameof (Manifest));
      }
    }

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

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

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

    [RelationshipSchemaName("customcontrol_resource_id")]
    public IEnumerable<CustomControlResource> customcontrol_resource_id
    {
      get
      {
        return this.GetRelatedEntities<CustomControlResource>(nameof (customcontrol_resource_id), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customcontrol_resource_id));
        this.SetRelatedEntities<CustomControlResource>(nameof (customcontrol_resource_id), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customcontrol_resource_id));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("customcontrol_organization")]
    public Organization customcontrol_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (customcontrol_organization), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_customcontrol_createdby")]
    public SystemUser lk_customcontrol_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customcontrol_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_customcontrol_createdonbehalfby")]
    public SystemUser lk_customcontrol_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customcontrol_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_customcontrol_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_customcontrol_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_customcontrol_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_customcontrol_modifiedby")]
    public SystemUser lk_customcontrol_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customcontrol_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_customcontrol_modifiedonbehalfby")]
    public SystemUser lk_customcontrol_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customcontrol_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_customcontrol_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_customcontrol_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_customcontrol_modifiedonbehalfby));
      }
    }

    public CustomControl(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["customcontrolid"] = (object) base.Id;
            break;
          case "customcontrolid":
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
