// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessageProcessingStep
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageprocessingstep")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessageProcessingStep : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageprocessingstep";
    public const string EntitySchemaName = "SdkMessageProcessingStep";
    public const string PrimaryIdAttribute = "sdkmessageprocessingstepid";
    public const string PrimaryNameAttribute = "name";

    public SdkMessageProcessingStep()
      : base("sdkmessageprocessingstep")
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

    [AttributeLogicalName("asyncautodelete")]
    public bool? AsyncAutoDelete
    {
      get => this.GetAttributeValue<bool?>("asyncautodelete");
      set
      {
        this.OnPropertyChanging(nameof (AsyncAutoDelete));
        this.SetAttributeValue("asyncautodelete", (object) value);
        this.OnPropertyChanged(nameof (AsyncAutoDelete));
      }
    }

    [AttributeLogicalName("canusereadonlyconnection")]
    public bool? CanUseReadOnlyConnection
    {
      get => this.GetAttributeValue<bool?>("canusereadonlyconnection");
      set
      {
        this.OnPropertyChanging(nameof (CanUseReadOnlyConnection));
        this.SetAttributeValue("canusereadonlyconnection", (object) value);
        this.OnPropertyChanged(nameof (CanUseReadOnlyConnection));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("configuration")]
    public string Configuration
    {
      get => this.GetAttributeValue<string>("configuration");
      set
      {
        this.OnPropertyChanging(nameof (Configuration));
        this.SetAttributeValue("configuration", (object) value);
        this.OnPropertyChanged(nameof (Configuration));
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

    [AttributeLogicalName("eventexpander")]
    public string EventExpander
    {
      get => this.GetAttributeValue<string>("eventexpander");
      set
      {
        this.OnPropertyChanging(nameof (EventExpander));
        this.SetAttributeValue("eventexpander", (object) value);
        this.OnPropertyChanged(nameof (EventExpander));
      }
    }

    [AttributeLogicalName("eventhandler")]
    public EntityReference EventHandler
    {
      get => this.GetAttributeValue<EntityReference>("eventhandler");
      set
      {
        this.OnPropertyChanging(nameof (EventHandler));
        this.SetAttributeValue("eventhandler", (object) value);
        this.OnPropertyChanged(nameof (EventHandler));
      }
    }

    [AttributeLogicalName("filteringattributes")]
    public string FilteringAttributes
    {
      get => this.GetAttributeValue<string>("filteringattributes");
      set
      {
        this.OnPropertyChanging(nameof (FilteringAttributes));
        this.SetAttributeValue("filteringattributes", (object) value);
        this.OnPropertyChanged(nameof (FilteringAttributes));
      }
    }

    [AttributeLogicalName("impersonatinguserid")]
    public EntityReference ImpersonatingUserId
    {
      get => this.GetAttributeValue<EntityReference>("impersonatinguserid");
      set
      {
        this.OnPropertyChanging(nameof (ImpersonatingUserId));
        this.SetAttributeValue("impersonatinguserid", (object) value);
        this.OnPropertyChanged(nameof (ImpersonatingUserId));
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

    [AttributeLogicalName("invocationsource")]
    [Obsolete]
    public OptionSetValue InvocationSource
    {
      get => this.GetAttributeValue<OptionSetValue>("invocationsource");
      set
      {
        this.OnPropertyChanging(nameof (InvocationSource));
        this.SetAttributeValue("invocationsource", (object) value);
        this.OnPropertyChanged(nameof (InvocationSource));
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

    [AttributeLogicalName("mode")]
    public OptionSetValue Mode
    {
      get => this.GetAttributeValue<OptionSetValue>("mode");
      set
      {
        this.OnPropertyChanging(nameof (Mode));
        this.SetAttributeValue("mode", (object) value);
        this.OnPropertyChanged(nameof (Mode));
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

    [AttributeLogicalName("plugintypeid")]
    [Obsolete]
    public EntityReference PluginTypeId
    {
      get => this.GetAttributeValue<EntityReference>("plugintypeid");
      set
      {
        this.OnPropertyChanging(nameof (PluginTypeId));
        this.SetAttributeValue("plugintypeid", (object) value);
        this.OnPropertyChanged(nameof (PluginTypeId));
      }
    }

    [AttributeLogicalName("rank")]
    public int? Rank
    {
      get => this.GetAttributeValue<int?>("rank");
      set
      {
        this.OnPropertyChanging(nameof (Rank));
        this.SetAttributeValue("rank", (object) value);
        this.OnPropertyChanged(nameof (Rank));
      }
    }

    [AttributeLogicalName("sdkmessagefilterid")]
    public EntityReference SdkMessageFilterId
    {
      get => this.GetAttributeValue<EntityReference>("sdkmessagefilterid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageFilterId));
        this.SetAttributeValue("sdkmessagefilterid", (object) value);
        this.OnPropertyChanged(nameof (SdkMessageFilterId));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public EntityReference SdkMessageId
    {
      get => this.GetAttributeValue<EntityReference>("sdkmessageid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageId));
        this.SetAttributeValue("sdkmessageid", (object) value);
        this.OnPropertyChanged(nameof (SdkMessageId));
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepid")]
    public Guid? SdkMessageProcessingStepId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageprocessingstepid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageProcessingStepId));
        this.SetAttributeValue("sdkmessageprocessingstepid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessageProcessingStepId));
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessageProcessingStepId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessageprocessingstepidunique")]
    public Guid? SdkMessageProcessingStepIdUnique
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageprocessingstepidunique");
    }

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
    public EntityReference SdkMessageProcessingStepSecureConfigId
    {
      get => this.GetAttributeValue<EntityReference>("sdkmessageprocessingstepsecureconfigid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageProcessingStepSecureConfigId));
        this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", (object) value);
        this.OnPropertyChanged(nameof (SdkMessageProcessingStepSecureConfigId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("stage")]
    public OptionSetValue Stage
    {
      get => this.GetAttributeValue<OptionSetValue>("stage");
      set
      {
        this.OnPropertyChanging(nameof (Stage));
        this.SetAttributeValue("stage", (object) value);
        this.OnPropertyChanged(nameof (Stage));
      }
    }

    [AttributeLogicalName("statecode")]
    public SdkMessageProcessingStepState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SdkMessageProcessingStepState?((SdkMessageProcessingStepState) Enum.ToObject(typeof (SdkMessageProcessingStepState), attributeValue.Value)) : new SdkMessageProcessingStepState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (statecode));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (statecode), (object) null);
        else
          this.SetAttributeValue(nameof (statecode), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (statecode));
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("statuscode");
      set
      {
        this.OnPropertyChanging(nameof (StatusCode));
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged(nameof (StatusCode));
      }
    }

    [AttributeLogicalName("supporteddeployment")]
    public OptionSetValue SupportedDeployment
    {
      get => this.GetAttributeValue<OptionSetValue>("supporteddeployment");
      set
      {
        this.OnPropertyChanging(nameof (SupportedDeployment));
        this.SetAttributeValue("supporteddeployment", (object) value);
        this.OnPropertyChanged(nameof (SupportedDeployment));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("SdkMessageProcessingStep_AsyncOperations")]
    public IEnumerable<AsyncOperation> SdkMessageProcessingStep_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (SdkMessageProcessingStep_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageProcessingStep_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (SdkMessageProcessingStep_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SdkMessageProcessingStep_AsyncOperations));
      }
    }

    [RelationshipSchemaName("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
    public IEnumerable<SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStepImage>(nameof (sdkmessageprocessingstepid_sdkmessageprocessingstepimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageprocessingstepid_sdkmessageprocessingstepimage));
        this.SetRelatedEntities<SdkMessageProcessingStepImage>(nameof (sdkmessageprocessingstepid_sdkmessageprocessingstepimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageprocessingstepid_sdkmessageprocessingstepimage));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstep")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageprocessingstep));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageprocessingstep));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessageprocessingstep")]
    public SystemUser createdby_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessageprocessingstep), new EntityRole?());
      }
    }

    [AttributeLogicalName("impersonatinguserid")]
    [RelationshipSchemaName("impersonatinguserid_sdkmessageprocessingstep")]
    public SystemUser impersonatinguserid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (impersonatinguserid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (impersonatinguserid_sdkmessageprocessingstep));
        this.SetRelatedEntity<SystemUser>(nameof (impersonatinguserid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (impersonatinguserid_sdkmessageprocessingstep));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageprocessingstep_createdonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstep_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessageprocessingstep_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessageprocessingstep_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessageprocessingstep_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessageprocessingstep_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
    public SystemUser lk_sdkmessageprocessingstep_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessageprocessingstep_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessageprocessingstep_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessageprocessingstep_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessageprocessingstep_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessageprocessingstep")]
    public SystemUser modifiedby_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessageprocessingstep), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessageprocessingstep")]
    public Organization organization_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessageprocessingstep), new EntityRole?());
      }
    }

    [AttributeLogicalName("eventhandler")]
    [RelationshipSchemaName("plugintype_sdkmessageprocessingstep")]
    public PluginType plugintype_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<PluginType>(nameof (plugintype_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (plugintype_sdkmessageprocessingstep));
        this.SetRelatedEntity<PluginType>(nameof (plugintype_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (plugintype_sdkmessageprocessingstep));
      }
    }

    [AttributeLogicalName("plugintypeid")]
    [RelationshipSchemaName("plugintypeid_sdkmessageprocessingstep")]
    public PluginType plugintypeid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<PluginType>(nameof (plugintypeid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (plugintypeid_sdkmessageprocessingstep));
        this.SetRelatedEntity<PluginType>(nameof (plugintypeid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (plugintypeid_sdkmessageprocessingstep));
      }
    }

    [AttributeLogicalName("sdkmessagefilterid")]
    [RelationshipSchemaName("sdkmessagefilterid_sdkmessageprocessingstep")]
    public SdkMessageFilter sdkmessagefilterid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageFilter>(nameof (sdkmessagefilterid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessagefilterid_sdkmessageprocessingstep));
        this.SetRelatedEntity<SdkMessageFilter>(nameof (sdkmessagefilterid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessagefilterid_sdkmessageprocessingstep));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    [RelationshipSchemaName("sdkmessageid_sdkmessageprocessingstep")]
    public SdkMessage sdkmessageid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SdkMessage>(nameof (sdkmessageid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageid_sdkmessageprocessingstep));
        this.SetRelatedEntity<SdkMessage>(nameof (sdkmessageid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageid_sdkmessageprocessingstep));
      }
    }

    [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
    [RelationshipSchemaName("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
    public SdkMessageProcessingStepSecureConfig sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageProcessingStepSecureConfig>(nameof (sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep));
        this.SetRelatedEntity<SdkMessageProcessingStepSecureConfig>(nameof (sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep));
      }
    }

    [AttributeLogicalName("eventhandler")]
    [RelationshipSchemaName("serviceendpoint_sdkmessageprocessingstep")]
    public ServiceEndpoint serviceendpoint_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<ServiceEndpoint>(nameof (serviceendpoint_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceendpoint_sdkmessageprocessingstep));
        this.SetRelatedEntity<ServiceEndpoint>(nameof (serviceendpoint_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceendpoint_sdkmessageprocessingstep));
      }
    }

    public SdkMessageProcessingStep(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessageprocessingstepid"] = (object) base.Id;
            break;
          case "sdkmessageprocessingstepid":
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
