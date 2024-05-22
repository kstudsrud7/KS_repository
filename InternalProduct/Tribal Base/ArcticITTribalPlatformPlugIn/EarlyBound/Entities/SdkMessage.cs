// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessage
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessage")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessage";
    public const string EntitySchemaName = "SdkMessage";
    public const string PrimaryIdAttribute = "sdkmessageid";
    public const string PrimaryNameAttribute = "name";

    public SdkMessage()
      : base("sdkmessage")
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

    [AttributeLogicalName("autotransact")]
    public bool? AutoTransact
    {
      get => this.GetAttributeValue<bool?>("autotransact");
      set
      {
        this.OnPropertyChanging(nameof (AutoTransact));
        this.SetAttributeValue("autotransact", (object) value);
        this.OnPropertyChanged(nameof (AutoTransact));
      }
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

    [AttributeLogicalName("categoryname")]
    public string CategoryName
    {
      get => this.GetAttributeValue<string>("categoryname");
      set
      {
        this.OnPropertyChanging(nameof (CategoryName));
        this.SetAttributeValue("categoryname", (object) value);
        this.OnPropertyChanged(nameof (CategoryName));
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

    [AttributeLogicalName("executeprivilegename")]
    public string ExecutePrivilegeName
    {
      get => this.GetAttributeValue<string>("executeprivilegename");
      set
      {
        this.OnPropertyChanging(nameof (ExecutePrivilegeName));
        this.SetAttributeValue("executeprivilegename", (object) value);
        this.OnPropertyChanged(nameof (ExecutePrivilegeName));
      }
    }

    [AttributeLogicalName("expand")]
    public bool? Expand
    {
      get => this.GetAttributeValue<bool?>("expand");
      set
      {
        this.OnPropertyChanging(nameof (Expand));
        this.SetAttributeValue("expand", (object) value);
        this.OnPropertyChanged(nameof (Expand));
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

    [AttributeLogicalName("isactive")]
    public bool? IsActive
    {
      get => this.GetAttributeValue<bool?>("isactive");
      set
      {
        this.OnPropertyChanging(nameof (IsActive));
        this.SetAttributeValue("isactive", (object) value);
        this.OnPropertyChanged(nameof (IsActive));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("isprivate")]
    public bool? IsPrivate
    {
      get => this.GetAttributeValue<bool?>("isprivate");
      set
      {
        this.OnPropertyChanging(nameof (IsPrivate));
        this.SetAttributeValue("isprivate", (object) value);
        this.OnPropertyChanged(nameof (IsPrivate));
      }
    }

    [AttributeLogicalName("isreadonly")]
    public bool? IsReadOnly
    {
      get => this.GetAttributeValue<bool?>("isreadonly");
      set
      {
        this.OnPropertyChanging(nameof (IsReadOnly));
        this.SetAttributeValue("isreadonly", (object) value);
        this.OnPropertyChanged(nameof (IsReadOnly));
      }
    }

    [AttributeLogicalName("isvalidforexecuteasync")]
    public bool? IsValidForExecuteAsync => this.GetAttributeValue<bool?>("isvalidforexecuteasync");

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

    [AttributeLogicalName("sdkmessageid")]
    public Guid? SdkMessageId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageId));
        this.SetAttributeValue("sdkmessageid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessageId));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessageId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessageidunique")]
    public Guid? SdkMessageIdUnique => this.GetAttributeValue<Guid?>("sdkmessageidunique");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("template")]
    public bool? Template
    {
      get => this.GetAttributeValue<bool?>("template");
      set
      {
        this.OnPropertyChanging(nameof (Template));
        this.SetAttributeValue("template", (object) value);
        this.OnPropertyChanged(nameof (Template));
      }
    }

    [AttributeLogicalName("throttlesettings")]
    public string ThrottleSettings => this.GetAttributeValue<string>("throttlesettings");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("workflowsdkstepenabled")]
    public bool? WorkflowSdkStepEnabled => this.GetAttributeValue<bool?>("workflowsdkstepenabled");

    [RelationshipSchemaName("message_sdkmessagepair")]
    public IEnumerable<SdkMessagePair> message_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntities<SdkMessagePair>(nameof (message_sdkmessagepair), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (message_sdkmessagepair));
        this.SetRelatedEntities<SdkMessagePair>(nameof (message_sdkmessagepair), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (message_sdkmessagepair));
      }
    }

    [RelationshipSchemaName("sdkmessage_customapi")]
    public IEnumerable<CustomAPI> sdkmessage_customapi
    {
      get => this.GetRelatedEntities<CustomAPI>(nameof (sdkmessage_customapi), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (sdkmessage_customapi));
        this.SetRelatedEntities<CustomAPI>(nameof (sdkmessage_customapi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessage_customapi));
      }
    }

    [RelationshipSchemaName("sdkmessageid_sdkmessagefilter")]
    public IEnumerable<SdkMessageFilter> sdkmessageid_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageFilter>(nameof (sdkmessageid_sdkmessagefilter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageid_sdkmessagefilter));
        this.SetRelatedEntities<SdkMessageFilter>(nameof (sdkmessageid_sdkmessagefilter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageid_sdkmessagefilter));
      }
    }

    [RelationshipSchemaName("sdkmessageid_sdkmessageprocessingstep")]
    public IEnumerable<SdkMessageProcessingStep> sdkmessageid_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntities<SdkMessageProcessingStep>(nameof (sdkmessageid_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageid_sdkmessageprocessingstep));
        this.SetRelatedEntities<SdkMessageProcessingStep>(nameof (sdkmessageid_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageid_sdkmessageprocessingstep));
      }
    }

    [RelationshipSchemaName("sdkmessageid_workflow_dependency")]
    public IEnumerable<WorkflowDependency> sdkmessageid_workflow_dependency
    {
      get
      {
        return this.GetRelatedEntities<WorkflowDependency>(nameof (sdkmessageid_workflow_dependency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageid_workflow_dependency));
        this.SetRelatedEntities<WorkflowDependency>(nameof (sdkmessageid_workflow_dependency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageid_workflow_dependency));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_sdkmessage")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessage
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessage));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessage));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessage")]
    public SystemUser createdby_sdkmessage
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessage), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessage_createdonbehalfby")]
    public SystemUser lk_sdkmessage_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessage_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessage_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessage_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessage_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessage_modifiedonbehalfby")]
    public SystemUser lk_sdkmessage_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessage_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessage_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessage_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessage_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessage")]
    public SystemUser modifiedby_sdkmessage
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessage), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessage")]
    public Organization organization_sdkmessage
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessage), new EntityRole?());
      }
    }

    public SdkMessage(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessageid"] = (object) base.Id;
            break;
          case "sdkmessageid":
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
