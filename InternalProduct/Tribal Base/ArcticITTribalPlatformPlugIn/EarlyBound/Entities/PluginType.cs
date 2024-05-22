// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PluginType
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("plugintype")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PluginType : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "plugintype";
    public const string EntitySchemaName = "PluginType";
    public const string PrimaryIdAttribute = "plugintypeid";
    public const string PrimaryNameAttribute = "name";

    public PluginType()
      : base("plugintype")
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

    [AttributeLogicalName("assemblyname")]
    public string AssemblyName => this.GetAttributeValue<string>("assemblyname");

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

    [AttributeLogicalName("culture")]
    public string Culture => this.GetAttributeValue<string>("culture");

    [AttributeLogicalName("customizationlevel")]
    public int? CustomizationLevel => this.GetAttributeValue<int?>("customizationlevel");

    [AttributeLogicalName("customworkflowactivityinfo")]
    public string CustomWorkflowActivityInfo
    {
      get => this.GetAttributeValue<string>("customworkflowactivityinfo");
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

    [AttributeLogicalName("friendlyname")]
    public string FriendlyName
    {
      get => this.GetAttributeValue<string>("friendlyname");
      set
      {
        this.OnPropertyChanging(nameof (FriendlyName));
        this.SetAttributeValue("friendlyname", (object) value);
        this.OnPropertyChanged(nameof (FriendlyName));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isworkflowactivity")]
    public bool? IsWorkflowActivity => this.GetAttributeValue<bool?>("isworkflowactivity");

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

    [AttributeLogicalName("pluginassemblyid")]
    public EntityReference PluginAssemblyId
    {
      get => this.GetAttributeValue<EntityReference>("pluginassemblyid");
      set
      {
        this.OnPropertyChanging(nameof (PluginAssemblyId));
        this.SetAttributeValue("pluginassemblyid", (object) value);
        this.OnPropertyChanged(nameof (PluginAssemblyId));
      }
    }

    [AttributeLogicalName("plugintypeid")]
    public Guid? PluginTypeId
    {
      get => this.GetAttributeValue<Guid?>("plugintypeid");
      set
      {
        this.OnPropertyChanging(nameof (PluginTypeId));
        this.SetAttributeValue("plugintypeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PluginTypeId));
      }
    }

    [AttributeLogicalName("plugintypeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PluginTypeId = new Guid?(value);
    }

    [AttributeLogicalName("plugintypeidunique")]
    public Guid? PluginTypeIdUnique => this.GetAttributeValue<Guid?>("plugintypeidunique");

    [AttributeLogicalName("publickeytoken")]
    public string PublicKeyToken => this.GetAttributeValue<string>("publickeytoken");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("typename")]
    public string TypeName
    {
      get => this.GetAttributeValue<string>("typename");
      set
      {
        this.OnPropertyChanging(nameof (TypeName));
        this.SetAttributeValue("typename", (object) value);
        this.OnPropertyChanged(nameof (TypeName));
      }
    }

    [AttributeLogicalName("version")]
    public string Version => this.GetAttributeValue<string>("version");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("workflowactivitygroupname")]
    public string WorkflowActivityGroupName
    {
      get => this.GetAttributeValue<string>("workflowactivitygroupname");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowActivityGroupName));
        this.SetAttributeValue("workflowactivitygroupname", (object) value);
        this.OnPropertyChanged(nameof (WorkflowActivityGroupName));
      }
    }

    [RelationshipSchemaName("plugintype_customapi")]
    public IEnumerable<CustomAPI> plugintype_customapi
    {
      get => this.GetRelatedEntities<CustomAPI>(nameof (plugintype_customapi), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (plugintype_customapi));
        this.SetRelatedEntities<CustomAPI>(nameof (plugintype_customapi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (plugintype_customapi));
      }
    }

    [RelationshipSchemaName("plugintype_plugintypestatistic")]
    public IEnumerable<PluginTypeStatistic> plugintype_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntities<PluginTypeStatistic>(nameof (plugintype_plugintypestatistic), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (plugintype_plugintypestatistic));
        this.SetRelatedEntities<PluginTypeStatistic>(nameof (plugintype_plugintypestatistic), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (plugintype_plugintypestatistic));
      }
    }

    [RelationshipSchemaName("plugintype_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> plugintype_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>(nameof (plugintype_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (plugintype_sdkmessageprocessingstep));
        this.SetRelatedEntities<SdkMessageProcessingStep>(nameof (plugintype_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (plugintype_sdkmessageprocessingstep));
      }
    }

    [RelationshipSchemaName("plugintypeid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> plugintypeid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>(nameof (plugintypeid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (plugintypeid_sdkmessageprocessingstep));
        this.SetRelatedEntities<SdkMessageProcessingStep>(nameof (plugintypeid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (plugintypeid_sdkmessageprocessingstep));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_plugintype")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_plugintype
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_plugintype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_plugintype));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_plugintype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_plugintype));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_plugintype")]
    public SystemUser createdby_plugintype
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (createdby_plugintype), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_plugintype_createdonbehalfby")]
    public SystemUser lk_plugintype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_plugintype_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_plugintype_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_plugintype_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_plugintype_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_plugintype_modifiedonbehalfby")]
    public SystemUser lk_plugintype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_plugintype_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_plugintype_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_plugintype_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_plugintype_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_plugintype")]
    public SystemUser modifiedby_plugintype
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (modifiedby_plugintype), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_plugintype")]
    public Organization organization_plugintype
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_plugintype), new EntityRole?());
      }
    }

    [AttributeLogicalName("pluginassemblyid")]
    [RelationshipSchemaName("pluginassembly_plugintype")]
    public PluginAssembly pluginassembly_plugintype
    {
      get
      {
        return this.GetRelatedEntity<PluginAssembly>(nameof (pluginassembly_plugintype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pluginassembly_plugintype));
        this.SetRelatedEntity<PluginAssembly>(nameof (pluginassembly_plugintype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pluginassembly_plugintype));
      }
    }

    public PluginType(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["plugintypeid"] = (object) base.Id;
            break;
          case "plugintypeid":
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
