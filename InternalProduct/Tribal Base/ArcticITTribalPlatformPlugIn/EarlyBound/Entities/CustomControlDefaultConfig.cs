// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CustomControlDefaultConfig
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("customcontroldefaultconfig")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CustomControlDefaultConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "customcontroldefaultconfig";
    public const string EntitySchemaName = "CustomControlDefaultConfig";
    public const string PrimaryIdAttribute = "customcontroldefaultconfigid";

    public CustomControlDefaultConfig()
      : base("customcontroldefaultconfig")
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

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("controldescriptionjson")]
    public string ControlDescriptionJson
    {
      get => this.GetAttributeValue<string>("controldescriptionjson");
      set
      {
        this.OnPropertyChanging(nameof (ControlDescriptionJson));
        this.SetAttributeValue("controldescriptionjson", (object) value);
        this.OnPropertyChanged(nameof (ControlDescriptionJson));
      }
    }

    [AttributeLogicalName("controldescriptionxml")]
    public string ControlDescriptionXML
    {
      get => this.GetAttributeValue<string>("controldescriptionxml");
      set
      {
        this.OnPropertyChanging(nameof (ControlDescriptionXML));
        this.SetAttributeValue("controldescriptionxml", (object) value);
        this.OnPropertyChanged(nameof (ControlDescriptionXML));
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

    [AttributeLogicalName("customcontroldefaultconfigid")]
    public Guid? CustomControlDefaultConfigId
    {
      get => this.GetAttributeValue<Guid?>("customcontroldefaultconfigid");
      set
      {
        this.OnPropertyChanging(nameof (CustomControlDefaultConfigId));
        this.SetAttributeValue("customcontroldefaultconfigid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CustomControlDefaultConfigId));
      }
    }

    [AttributeLogicalName("customcontroldefaultconfigid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CustomControlDefaultConfigId = new Guid?(value);
    }

    [AttributeLogicalName("customcontroldefaultconfigidunique")]
    public Guid? CustomControlDefaultConfigIdUnique
    {
      get => this.GetAttributeValue<Guid?>("customcontroldefaultconfigidunique");
    }

    [AttributeLogicalName("eventsxml")]
    public string EventsXml
    {
      get => this.GetAttributeValue<string>("eventsxml");
      set
      {
        this.OnPropertyChanging(nameof (EventsXml));
        this.SetAttributeValue("eventsxml", (object) value);
        this.OnPropertyChanged(nameof (EventsXml));
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

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("primaryentitytypecode")]
    public string PrimaryEntityTypeCode
    {
      get => this.GetAttributeValue<string>("primaryentitytypecode");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityTypeCode));
        this.SetAttributeValue("primaryentitytypecode", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityTypeCode));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("customcontroldefaultconfig_organization")]
    public Organization customcontroldefaultconfig_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (customcontroldefaultconfig_organization), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_customcontroldefaultconfig_createdby")]
    public SystemUser lk_customcontroldefaultconfig_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customcontroldefaultconfig_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_customcontroldefaultconfig_createdonbehalfby")]
    public SystemUser lk_customcontroldefaultconfig_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customcontroldefaultconfig_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_customcontroldefaultconfig_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_customcontroldefaultconfig_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_customcontroldefaultconfig_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_customcontroldefaultconfig_modifiedby")]
    public SystemUser lk_customcontroldefaultconfig_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customcontroldefaultconfig_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_customcontroldefaultconfig_modifiedonbehalfby")]
    public SystemUser lk_customcontroldefaultconfig_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_customcontroldefaultconfig_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_customcontroldefaultconfig_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_customcontroldefaultconfig_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_customcontroldefaultconfig_modifiedonbehalfby));
      }
    }

    public CustomControlDefaultConfig(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["customcontroldefaultconfigid"] = (object) base.Id;
            break;
          case "customcontroldefaultconfigid":
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
