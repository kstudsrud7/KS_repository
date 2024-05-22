// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.WorkflowDependency
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("workflowdependency")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class WorkflowDependency : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "workflowdependency";
    public const string EntitySchemaName = "WorkflowDependency";
    public const string PrimaryIdAttribute = "workflowdependencyid";

    public WorkflowDependency()
      : base("workflowdependency")
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

    [AttributeLogicalName("customentityname")]
    public string CustomEntityName
    {
      get => this.GetAttributeValue<string>("customentityname");
      set
      {
        this.OnPropertyChanging(nameof (CustomEntityName));
        this.SetAttributeValue("customentityname", (object) value);
        this.OnPropertyChanged(nameof (CustomEntityName));
      }
    }

    [AttributeLogicalName("dependentattributename")]
    public string DependentAttributeName
    {
      get => this.GetAttributeValue<string>("dependentattributename");
      set
      {
        this.OnPropertyChanging(nameof (DependentAttributeName));
        this.SetAttributeValue("dependentattributename", (object) value);
        this.OnPropertyChanged(nameof (DependentAttributeName));
      }
    }

    [AttributeLogicalName("dependententityname")]
    public string DependentEntityName
    {
      get => this.GetAttributeValue<string>("dependententityname");
      set
      {
        this.OnPropertyChanging(nameof (DependentEntityName));
        this.SetAttributeValue("dependententityname", (object) value);
        this.OnPropertyChanged(nameof (DependentEntityName));
      }
    }

    [AttributeLogicalName("entityattributes")]
    public string EntityAttributes
    {
      get => this.GetAttributeValue<string>("entityattributes");
      set
      {
        this.OnPropertyChanging(nameof (EntityAttributes));
        this.SetAttributeValue("entityattributes", (object) value);
        this.OnPropertyChanged(nameof (EntityAttributes));
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

    [AttributeLogicalName("parametername")]
    public string ParameterName
    {
      get => this.GetAttributeValue<string>("parametername");
      set
      {
        this.OnPropertyChanging(nameof (ParameterName));
        this.SetAttributeValue("parametername", (object) value);
        this.OnPropertyChanged(nameof (ParameterName));
      }
    }

    [AttributeLogicalName("parametertype")]
    public string ParameterType
    {
      get => this.GetAttributeValue<string>("parametertype");
      set
      {
        this.OnPropertyChanging(nameof (ParameterType));
        this.SetAttributeValue("parametertype", (object) value);
        this.OnPropertyChanged(nameof (ParameterType));
      }
    }

    [AttributeLogicalName("relatedattributename")]
    public string RelatedAttributeName
    {
      get => this.GetAttributeValue<string>("relatedattributename");
      set
      {
        this.OnPropertyChanging(nameof (RelatedAttributeName));
        this.SetAttributeValue("relatedattributename", (object) value);
        this.OnPropertyChanged(nameof (RelatedAttributeName));
      }
    }

    [AttributeLogicalName("relatedentityname")]
    public string RelatedEntityName
    {
      get => this.GetAttributeValue<string>("relatedentityname");
      set
      {
        this.OnPropertyChanging(nameof (RelatedEntityName));
        this.SetAttributeValue("relatedentityname", (object) value);
        this.OnPropertyChanged(nameof (RelatedEntityName));
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

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get => this.GetAttributeValue<OptionSetValue>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("workflowdependencyid")]
    public Guid? WorkflowDependencyId
    {
      get => this.GetAttributeValue<Guid?>("workflowdependencyid");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowDependencyId));
        this.SetAttributeValue("workflowdependencyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (WorkflowDependencyId));
      }
    }

    [AttributeLogicalName("workflowdependencyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.WorkflowDependencyId = new Guid?(value);
    }

    [AttributeLogicalName("workflowid")]
    public EntityReference WorkflowId
    {
      get => this.GetAttributeValue<EntityReference>("workflowid");
      set
      {
        this.OnPropertyChanging(nameof (WorkflowId));
        this.SetAttributeValue("workflowid", (object) value);
        this.OnPropertyChanged(nameof (WorkflowId));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_workflowdependency")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_workflowdependency
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_workflowdependency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_workflowdependency));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_workflowdependency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_workflowdependency));
      }
    }

    [AttributeLogicalName("sdkmessageid")]
    [RelationshipSchemaName("sdkmessageid_workflow_dependency")]
    public SdkMessage sdkmessageid_workflow_dependency
    {
      get
      {
        return this.GetRelatedEntity<SdkMessage>(nameof (sdkmessageid_workflow_dependency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sdkmessageid_workflow_dependency));
        this.SetRelatedEntity<SdkMessage>(nameof (sdkmessageid_workflow_dependency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sdkmessageid_workflow_dependency));
      }
    }

    [AttributeLogicalName("workflowid")]
    [RelationshipSchemaName("workflow_dependencies")]
    public Workflow workflow_dependencies
    {
      get => this.GetRelatedEntity<Workflow>(nameof (workflow_dependencies), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (workflow_dependencies));
        this.SetRelatedEntity<Workflow>(nameof (workflow_dependencies), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflow_dependencies));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("workflow_dependency_createdby")]
    public SystemUser workflow_dependency_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (workflow_dependency_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("workflow_dependency_createdonbehalfby")]
    public SystemUser workflow_dependency_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (workflow_dependency_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflow_dependency_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (workflow_dependency_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflow_dependency_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("workflow_dependency_modifiedby")]
    public SystemUser workflow_dependency_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (workflow_dependency_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("workflow_dependency_modifiedonbehalfby")]
    public SystemUser workflow_dependency_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (workflow_dependency_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflow_dependency_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (workflow_dependency_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflow_dependency_modifiedonbehalfby));
      }
    }

    public WorkflowDependency(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["workflowdependencyid"] = (object) base.Id;
            break;
          case "workflowdependencyid":
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
