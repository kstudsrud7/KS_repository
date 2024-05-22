// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessageProcessingStepSecureConfig
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageprocessingstepsecureconfig")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessageProcessingStepSecureConfig : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageprocessingstepsecureconfig";
    public const string EntitySchemaName = "SdkMessageProcessingStepSecureConfig";
    public const string PrimaryIdAttribute = "sdkmessageprocessingstepsecureconfigid";

    public SdkMessageProcessingStepSecureConfig()
      : base("sdkmessageprocessingstepsecureconfig")
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

    [AttributeLogicalName("customizationlevel")]
    public int? CustomizationLevel => this.GetAttributeValue<int?>("customizationlevel");

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

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
    public Guid? SdkMessageProcessingStepSecureConfigId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageprocessingstepsecureconfigid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageProcessingStepSecureConfigId));
        this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessageProcessingStepSecureConfigId));
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessageProcessingStepSecureConfigId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigidunique")]
    public Guid? SdkMessageProcessingStepSecureConfigIdUnique
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageprocessingstepsecureconfigidunique");
    }

    [AttributeLogicalName("secureconfig")]
    public string SecureConfig
    {
      get => this.GetAttributeValue<string>("secureconfig");
      set
      {
        this.OnPropertyChanging(nameof (SecureConfig));
        this.SetAttributeValue("secureconfig", (object) value);
        this.OnPropertyChanged(nameof (SecureConfig));
      }
    }

    [RelationshipSchemaName("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>(nameof (sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep));
        this.SetRelatedEntities<SdkMessageProcessingStep>(nameof (sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstepsecureconfig")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessageprocessingstepsecureconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageprocessingstepsecureconfig));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessageprocessingstepsecureconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageprocessingstepsecureconfig));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessageprocessingstepsecureconfig")]
    public SystemUser createdby_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessageprocessingstepsecureconfig), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessageprocessingstepsecureconfig")]
    public SystemUser modifiedby_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessageprocessingstepsecureconfig), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessageprocessingstepsecureconfig")]
    public Organization organization_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessageprocessingstepsecureconfig), new EntityRole?());
      }
    }

    public SdkMessageProcessingStepSecureConfig(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessageprocessingstepsecureconfigid"] = (object) base.Id;
            break;
          case "sdkmessageprocessingstepsecureconfigid":
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
