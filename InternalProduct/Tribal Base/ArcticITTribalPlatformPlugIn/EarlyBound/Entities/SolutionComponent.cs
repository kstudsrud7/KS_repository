// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SolutionComponent
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solutioncomponent")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SolutionComponent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solutioncomponent";
    public const string EntitySchemaName = "SolutionComponent";
    public const string PrimaryIdAttribute = "solutioncomponentid";

    public SolutionComponent()
      : base("solutioncomponent")
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

    [AttributeLogicalName("componenttype")]
    public OptionSetValue ComponentType => this.GetAttributeValue<OptionSetValue>("componenttype");

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

    [AttributeLogicalName("ismetadata")]
    public bool? IsMetadata => this.GetAttributeValue<bool?>("ismetadata");

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

    [AttributeLogicalName("objectid")]
    public Guid? ObjectId => this.GetAttributeValue<Guid?>("objectid");

    [AttributeLogicalName("rootcomponentbehavior")]
    public OptionSetValue RootComponentBehavior
    {
      get => this.GetAttributeValue<OptionSetValue>("rootcomponentbehavior");
    }

    [AttributeLogicalName("rootsolutioncomponentid")]
    public Guid? RootSolutionComponentId
    {
      get => this.GetAttributeValue<Guid?>("rootsolutioncomponentid");
    }

    [AttributeLogicalName("solutioncomponentid")]
    public Guid? SolutionComponentId => this.GetAttributeValue<Guid?>("solutioncomponentid");

    [AttributeLogicalName("solutioncomponentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("solutionid")]
    public EntityReference SolutionId => this.GetAttributeValue<EntityReference>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName]
    public IEnumerable<SolutionComponent> Referencedsolutioncomponent_parent_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntities<SolutionComponent>("solutioncomponent_parent_solutioncomponent", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedsolutioncomponent_parent_solutioncomponent));
        this.SetRelatedEntities<SolutionComponent>("solutioncomponent_parent_solutioncomponent", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedsolutioncomponent_parent_solutioncomponent));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_solutioncomponent")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_solutioncomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_solutioncomponent));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_solutioncomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_solutioncomponent));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentbase_createdonbehalfby")]
    public SystemUser lk_solutioncomponentbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutioncomponentbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutioncomponentbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_solutioncomponentbase_modifiedonbehalfby")]
    public SystemUser lk_solutioncomponentbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_solutioncomponentbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_solutioncomponentbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_solutioncomponentbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("solutionid")]
    [RelationshipSchemaName("solution_solutioncomponent")]
    public Solution solution_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntity<Solution>(nameof (solution_solutioncomponent), new EntityRole?());
      }
    }

    [AttributeLogicalName("rootsolutioncomponentid")]
    [RelationshipSchemaName]
    public SolutionComponent Referencingsolutioncomponent_parent_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntity<SolutionComponent>("solutioncomponent_parent_solutioncomponent", new EntityRole?((EntityRole) 0));
      }
    }

    public SolutionComponent(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["solutioncomponentid"] = (object) base.Id;
            break;
          case "solutioncomponentid":
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
