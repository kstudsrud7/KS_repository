// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TransformationMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("transformationmapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TransformationMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "transformationmapping";
    public const string EntitySchemaName = "TransformationMapping";
    public const string PrimaryIdAttribute = "transformationmappingid";

    public TransformationMapping()
      : base("transformationmapping")
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

    [AttributeLogicalName("importmapid")]
    public EntityReference ImportMapId
    {
      get => this.GetAttributeValue<EntityReference>("importmapid");
      set
      {
        this.OnPropertyChanging(nameof (ImportMapId));
        this.SetAttributeValue("importmapid", (object) value);
        this.OnPropertyChanged(nameof (ImportMapId));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("processcode")]
    public OptionSetValue ProcessCode
    {
      get => this.GetAttributeValue<OptionSetValue>("processcode");
      set
      {
        this.OnPropertyChanging(nameof (ProcessCode));
        this.SetAttributeValue("processcode", (object) value);
        this.OnPropertyChanged(nameof (ProcessCode));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("sourceentityname")]
    public string SourceEntityName
    {
      get => this.GetAttributeValue<string>("sourceentityname");
      set
      {
        this.OnPropertyChanging(nameof (SourceEntityName));
        this.SetAttributeValue("sourceentityname", (object) value);
        this.OnPropertyChanged(nameof (SourceEntityName));
      }
    }

    [AttributeLogicalName("statecode")]
    public TransformationMappingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new TransformationMappingState?((TransformationMappingState) Enum.ToObject(typeof (TransformationMappingState), attributeValue.Value)) : new TransformationMappingState?();
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

    [AttributeLogicalName("targetentityname")]
    public string TargetEntityName
    {
      get => this.GetAttributeValue<string>("targetentityname");
      set
      {
        this.OnPropertyChanging(nameof (TargetEntityName));
        this.SetAttributeValue("targetentityname", (object) value);
        this.OnPropertyChanged(nameof (TargetEntityName));
      }
    }

    [AttributeLogicalName("transformationmappingid")]
    public Guid? TransformationMappingId
    {
      get => this.GetAttributeValue<Guid?>("transformationmappingid");
      set
      {
        this.OnPropertyChanging(nameof (TransformationMappingId));
        this.SetAttributeValue("transformationmappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TransformationMappingId));
      }
    }

    [AttributeLogicalName("transformationmappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TransformationMappingId = new Guid?(value);
    }

    [AttributeLogicalName("transformationmappingidunique")]
    public Guid? TransformationMappingIdUnique
    {
      get => this.GetAttributeValue<Guid?>("transformationmappingidunique");
    }

    [AttributeLogicalName("transformationtypename")]
    public string TransformationTypeName
    {
      get => this.GetAttributeValue<string>("transformationtypename");
      set
      {
        this.OnPropertyChanging(nameof (TransformationTypeName));
        this.SetAttributeValue("transformationtypename", (object) value);
        this.OnPropertyChanged(nameof (TransformationTypeName));
      }
    }

    [RelationshipSchemaName("TransformationParameterMapping_TransformationMapping")]
    public IEnumerable<TransformationParameterMapping> TransformationParameterMapping_TransformationMapping
    {
      get
      {
        return this.GetRelatedEntities<TransformationParameterMapping>(nameof (TransformationParameterMapping_TransformationMapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransformationParameterMapping_TransformationMapping));
        this.SetRelatedEntities<TransformationParameterMapping>(nameof (TransformationParameterMapping_TransformationMapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransformationParameterMapping_TransformationMapping));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_transformationmapping")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_transformationmapping
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_transformationmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_transformationmapping));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_transformationmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_transformationmapping));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_transformationmapping_createdby")]
    public SystemUser lk_transformationmapping_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transformationmapping_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_transformationmapping_createdonbehalfby")]
    public SystemUser lk_transformationmapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transformationmapping_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_transformationmapping_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_transformationmapping_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_transformationmapping_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_transformationmapping_modifiedby")]
    public SystemUser lk_transformationmapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transformationmapping_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_transformationmapping_modifiedonbehalfby")]
    public SystemUser lk_transformationmapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transformationmapping_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_transformationmapping_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_transformationmapping_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_transformationmapping_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("importmapid")]
    [RelationshipSchemaName("TransformationMapping_ImportMap")]
    public ImportMap TransformationMapping_ImportMap
    {
      get
      {
        return this.GetRelatedEntity<ImportMap>(nameof (TransformationMapping_ImportMap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransformationMapping_ImportMap));
        this.SetRelatedEntity<ImportMap>(nameof (TransformationMapping_ImportMap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransformationMapping_ImportMap));
      }
    }

    public TransformationMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["transformationmappingid"] = (object) base.Id;
            break;
          case "transformationmappingid":
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
