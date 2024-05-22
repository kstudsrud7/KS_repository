// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessageFilter
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagefilter")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessageFilter : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessagefilter";
    public const string EntitySchemaName = "SdkMessageFilter";
    public const string PrimaryIdAttribute = "sdkmessagefilterid";
    public const string PrimaryNameAttribute = "name";

    public SdkMessageFilter()
      : base("sdkmessagefilter")
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

    [AttributeLogicalName("availability")]
    public int? Availability
    {
      get => this.GetAttributeValue<int?>("availability");
      set
      {
        this.OnPropertyChanging(nameof (Availability));
        this.SetAttributeValue("availability", (object) value);
        this.OnPropertyChanged(nameof (Availability));
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

    [AttributeLogicalName("customizationlevel")]
    public int? CustomizationLevel => this.GetAttributeValue<int?>("customizationlevel");

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

    [AttributeLogicalName("iscustomprocessingstepallowed")]
    public bool? IsCustomProcessingStepAllowed
    {
      get => this.GetAttributeValue<bool?>("iscustomprocessingstepallowed");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomProcessingStepAllowed));
        this.SetAttributeValue("iscustomprocessingstepallowed", (object) value);
        this.OnPropertyChanged(nameof (IsCustomProcessingStepAllowed));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isvisible")]
    public bool? IsVisible => this.GetAttributeValue<bool?>("isvisible");

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

    [AttributeLogicalName("primaryobjecttypecode")]
    public string PrimaryObjectTypeCode => this.GetAttributeValue<string>("primaryobjecttypecode");

    [AttributeLogicalName("restrictionlevel")]
    public int? RestrictionLevel
    {
      get => this.GetAttributeValue<int?>("restrictionlevel");
      set
      {
        this.OnPropertyChanging(nameof (RestrictionLevel));
        this.SetAttributeValue("restrictionlevel", (object) value);
        this.OnPropertyChanged(nameof (RestrictionLevel));
      }
    }

    [AttributeLogicalName("sdkmessagefilterid")]
    public Guid? SdkMessageFilterId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessagefilterid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageFilterId));
        this.SetAttributeValue("sdkmessagefilterid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessageFilterId));
      }
    }

    [AttributeLogicalName("sdkmessagefilterid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessageFilterId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessagefilteridunique")]
    public Guid? SdkMessageFilterIdUnique
    {
      get => this.GetAttributeValue<Guid?>("sdkmessagefilteridunique");
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

    [AttributeLogicalName("secondaryobjecttypecode")]
    public string SecondaryObjectTypeCode
    {
      get => this.GetAttributeValue<string>("secondaryobjecttypecode");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("workflowsdkstepenabled")]
    public bool? WorkflowSdkStepEnabled => this.GetAttributeValue<bool?>("workflowsdkstepenabled");

    [RelationshipSchemaName("sdkmessagefilter_internalcatalogassignment")]
    public IEnumerable<InternalCatalogAssignment> sdkmessagefilter_internalcatalogassignment
    {
      get
      {
        return this.GetRelatedEntities<InternalCatalogAssignment>(nameof (sdkmessagefilter_internalcatalogassignment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessagefilter_internalcatalogassignment));
        this.SetRelatedEntities<InternalCatalogAssignment>(nameof (sdkmessagefilter_internalcatalogassignment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessagefilter_internalcatalogassignment));
      }
    }

    [RelationshipSchemaName("sdkmessagefilterid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> sdkmessagefilterid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>(nameof (sdkmessagefilterid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessagefilterid_sdkmessageprocessingstep));
        this.SetRelatedEntities<SdkMessageProcessingStep>(nameof (sdkmessagefilterid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessagefilterid_sdkmessageprocessingstep));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sdkmessagefilter")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessagefilter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessagefilter));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessagefilter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessagefilter));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessagefilter")]
    public SystemUser createdby_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessagefilter), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagefilter_createdonbehalfby")]
    public SystemUser lk_sdkmessagefilter_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessagefilter_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessagefilter_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessagefilter_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessagefilter_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagefilter_modifiedonbehalfby")]
    public SystemUser lk_sdkmessagefilter_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessagefilter_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessagefilter_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessagefilter_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessagefilter_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessagefilter")]
    public SystemUser modifiedby_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessagefilter), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessagefilter")]
    public Organization organization_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessagefilter), new EntityRole?());
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    [RelationshipSchemaName("sdkmessageid_sdkmessagefilter")]
    public SdkMessage sdkmessageid_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntity<SdkMessage>(nameof (sdkmessageid_sdkmessagefilter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageid_sdkmessagefilter));
        this.SetRelatedEntity<SdkMessage>(nameof (sdkmessageid_sdkmessagefilter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageid_sdkmessagefilter));
      }
    }

    public SdkMessageFilter(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessagefilterid"] = (object) base.Id;
            break;
          case "sdkmessagefilterid":
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
