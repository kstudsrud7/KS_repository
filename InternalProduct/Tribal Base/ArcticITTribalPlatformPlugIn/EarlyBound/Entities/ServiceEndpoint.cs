// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ServiceEndpoint
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("serviceendpoint")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ServiceEndpoint : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "serviceendpoint";
    public const string EntitySchemaName = "ServiceEndpoint";
    public const string PrimaryIdAttribute = "serviceendpointid";
    public const string PrimaryNameAttribute = "name";

    public ServiceEndpoint()
      : base("serviceendpoint")
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

    [AttributeLogicalName("authvalue")]
    public string AuthValue
    {
      get => this.GetAttributeValue<string>("authvalue");
      set
      {
        this.OnPropertyChanging(nameof (AuthValue));
        this.SetAttributeValue("authvalue", (object) value);
        this.OnPropertyChanged(nameof (AuthValue));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("connectionmode")]
    public OptionSetValue ConnectionMode
    {
      get => this.GetAttributeValue<OptionSetValue>("connectionmode");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionMode));
        this.SetAttributeValue("connectionmode", (object) value);
        this.OnPropertyChanged(nameof (ConnectionMode));
      }
    }

    [AttributeLogicalName("contract")]
    public OptionSetValue Contract
    {
      get => this.GetAttributeValue<OptionSetValue>("contract");
      set
      {
        this.OnPropertyChanging(nameof (Contract));
        this.SetAttributeValue("contract", (object) value);
        this.OnPropertyChanged(nameof (Contract));
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

    [AttributeLogicalName("isauthvalueset")]
    public bool? IsAuthValueSet => this.GetAttributeValue<bool?>("isauthvalueset");

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

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("issaskeyset")]
    public bool? IsSASKeySet => this.GetAttributeValue<bool?>("issaskeyset");

    [AttributeLogicalName("issastokenset")]
    public bool? IsSASTokenSet => this.GetAttributeValue<bool?>("issastokenset");

    [AttributeLogicalName("messageformat")]
    public OptionSetValue MessageFormat
    {
      get => this.GetAttributeValue<OptionSetValue>("messageformat");
      set
      {
        this.OnPropertyChanging(nameof (MessageFormat));
        this.SetAttributeValue("messageformat", (object) value);
        this.OnPropertyChanged(nameof (MessageFormat));
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

    [AttributeLogicalName("namespaceaddress")]
    public string NamespaceAddress
    {
      get => this.GetAttributeValue<string>("namespaceaddress");
      set
      {
        this.OnPropertyChanging(nameof (NamespaceAddress));
        this.SetAttributeValue("namespaceaddress", (object) value);
        this.OnPropertyChanged(nameof (NamespaceAddress));
      }
    }

    [AttributeLogicalName("namespaceformat")]
    public OptionSetValue NamespaceFormat
    {
      get => this.GetAttributeValue<OptionSetValue>("namespaceformat");
      set
      {
        this.OnPropertyChanging(nameof (NamespaceFormat));
        this.SetAttributeValue("namespaceformat", (object) value);
        this.OnPropertyChanged(nameof (NamespaceFormat));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

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

    [AttributeLogicalName("saskey")]
    public string SASKey
    {
      get => this.GetAttributeValue<string>("saskey");
      set
      {
        this.OnPropertyChanging(nameof (SASKey));
        this.SetAttributeValue("saskey", (object) value);
        this.OnPropertyChanged(nameof (SASKey));
      }
    }

    [AttributeLogicalName("saskeyname")]
    public string SASKeyName
    {
      get => this.GetAttributeValue<string>("saskeyname");
      set
      {
        this.OnPropertyChanging(nameof (SASKeyName));
        this.SetAttributeValue("saskeyname", (object) value);
        this.OnPropertyChanged(nameof (SASKeyName));
      }
    }

    [AttributeLogicalName("sastoken")]
    public string SASToken
    {
      get => this.GetAttributeValue<string>("sastoken");
      set
      {
        this.OnPropertyChanging(nameof (SASToken));
        this.SetAttributeValue("sastoken", (object) value);
        this.OnPropertyChanged(nameof (SASToken));
      }
    }

    [AttributeLogicalName("serviceendpointid")]
    public Guid? ServiceEndpointId
    {
      get => this.GetAttributeValue<Guid?>("serviceendpointid");
      set
      {
        this.OnPropertyChanging(nameof (ServiceEndpointId));
        this.SetAttributeValue("serviceendpointid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ServiceEndpointId));
      }
    }

    [AttributeLogicalName("serviceendpointid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ServiceEndpointId = new Guid?(value);
    }

    [AttributeLogicalName("serviceendpointidunique")]
    public Guid? ServiceEndpointIdUnique
    {
      get => this.GetAttributeValue<Guid?>("serviceendpointidunique");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("solutionnamespace")]
    public string SolutionNamespace
    {
      get => this.GetAttributeValue<string>("solutionnamespace");
      set
      {
        this.OnPropertyChanging(nameof (SolutionNamespace));
        this.SetAttributeValue("solutionnamespace", (object) value);
        this.OnPropertyChanged(nameof (SolutionNamespace));
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

    [AttributeLogicalName("userclaim")]
    public OptionSetValue UserClaim
    {
      get => this.GetAttributeValue<OptionSetValue>("userclaim");
      set
      {
        this.OnPropertyChanging(nameof (UserClaim));
        this.SetAttributeValue("userclaim", (object) value);
        this.OnPropertyChanged(nameof (UserClaim));
      }
    }

    [RelationshipSchemaName("serviceendpoint_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> serviceendpoint_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>(nameof (serviceendpoint_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceendpoint_sdkmessageprocessingstep));
        this.SetRelatedEntities<SdkMessageProcessingStep>(nameof (serviceendpoint_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceendpoint_sdkmessageprocessingstep));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_serviceendpoint")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_serviceendpoint), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_serviceendpoint));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_serviceendpoint), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_serviceendpoint));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_serviceendpoint")]
    public SystemUser createdby_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_serviceendpoint), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_serviceendpointbase_createdonbehalfby")]
    public SystemUser lk_serviceendpointbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_serviceendpointbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_serviceendpointbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_serviceendpointbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_serviceendpointbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_serviceendpointbase_modifiedonbehalfby")]
    public SystemUser lk_serviceendpointbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_serviceendpointbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_serviceendpointbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_serviceendpointbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_serviceendpointbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_serviceendpoint")]
    public SystemUser modifiedby_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_serviceendpoint), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_serviceendpoint")]
    public Organization organization_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_serviceendpoint), new EntityRole?());
      }
    }

    public ServiceEndpoint(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["serviceendpointid"] = (object) base.Id;
            break;
          case "serviceendpointid":
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
