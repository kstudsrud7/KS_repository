// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TransformationParameterMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("transformationparametermapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TransformationParameterMapping : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "transformationparametermapping";
    public const string EntitySchemaName = "TransformationParameterMapping";
    public const string PrimaryIdAttribute = "transformationparametermappingid";
    public const string PrimaryNameAttribute = "data";

    public TransformationParameterMapping()
      : base("transformationparametermapping")
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

    [AttributeLogicalName("data")]
    public string Data
    {
      get => this.GetAttributeValue<string>("data");
      set
      {
        this.OnPropertyChanging(nameof (Data));
        this.SetAttributeValue("data", (object) value);
        this.OnPropertyChanged(nameof (Data));
      }
    }

    [AttributeLogicalName("datatypecode")]
    public OptionSetValue DataTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("datatypecode");
      set
      {
        this.OnPropertyChanging(nameof (DataTypeCode));
        this.SetAttributeValue("datatypecode", (object) value);
        this.OnPropertyChanged(nameof (DataTypeCode));
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

    [AttributeLogicalName("parameterarrayindex")]
    public int? ParameterArrayIndex
    {
      get => this.GetAttributeValue<int?>("parameterarrayindex");
      set
      {
        this.OnPropertyChanging(nameof (ParameterArrayIndex));
        this.SetAttributeValue("parameterarrayindex", (object) value);
        this.OnPropertyChanged(nameof (ParameterArrayIndex));
      }
    }

    [AttributeLogicalName("parametersequence")]
    public int? ParameterSequence
    {
      get => this.GetAttributeValue<int?>("parametersequence");
      set
      {
        this.OnPropertyChanging(nameof (ParameterSequence));
        this.SetAttributeValue("parametersequence", (object) value);
        this.OnPropertyChanged(nameof (ParameterSequence));
      }
    }

    [AttributeLogicalName("parametertypecode")]
    public OptionSetValue ParameterTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("parametertypecode");
      set
      {
        this.OnPropertyChanging(nameof (ParameterTypeCode));
        this.SetAttributeValue("parametertypecode", (object) value);
        this.OnPropertyChanged(nameof (ParameterTypeCode));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("transformationmappingid")]
    public EntityReference TransformationMappingId
    {
      get => this.GetAttributeValue<EntityReference>("transformationmappingid");
      set
      {
        this.OnPropertyChanging(nameof (TransformationMappingId));
        this.SetAttributeValue("transformationmappingid", (object) value);
        this.OnPropertyChanged(nameof (TransformationMappingId));
      }
    }

    [AttributeLogicalName("transformationparametermappingid")]
    public Guid? TransformationParameterMappingId
    {
      get => this.GetAttributeValue<Guid?>("transformationparametermappingid");
      set
      {
        this.OnPropertyChanging(nameof (TransformationParameterMappingId));
        this.SetAttributeValue("transformationparametermappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TransformationParameterMappingId));
      }
    }

    [AttributeLogicalName("transformationparametermappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TransformationParameterMappingId = new Guid?(value);
    }

    [AttributeLogicalName("transformationparametermappingidunique")]
    public Guid? TransformationParameterMappingIdUnique
    {
      get => this.GetAttributeValue<Guid?>("transformationparametermappingidunique");
    }

    [RelationshipSchemaName("LookUpMapping_TransformationParameterMapping")]
    public IEnumerable<LookUpMapping> LookUpMapping_TransformationParameterMapping
    {
      get
      {
        return this.GetRelatedEntities<LookUpMapping>(nameof (LookUpMapping_TransformationParameterMapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (LookUpMapping_TransformationParameterMapping));
        this.SetRelatedEntities<LookUpMapping>(nameof (LookUpMapping_TransformationParameterMapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (LookUpMapping_TransformationParameterMapping));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_transformationparametermapping")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_transformationparametermapping
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_transformationparametermapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_transformationparametermapping));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_transformationparametermapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_transformationparametermapping));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_transformationparametermapping_createdby")]
    public SystemUser lk_transformationparametermapping_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transformationparametermapping_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_transformationparametermapping_createdonbehalfby")]
    public SystemUser lk_transformationparametermapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transformationparametermapping_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_transformationparametermapping_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_transformationparametermapping_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_transformationparametermapping_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_transformationparametermapping_modifiedby")]
    public SystemUser lk_transformationparametermapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transformationparametermapping_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_transformationparametermapping_modifiedonbehalfby")]
    public SystemUser lk_transformationparametermapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_transformationparametermapping_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_transformationparametermapping_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_transformationparametermapping_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_transformationparametermapping_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("transformationmappingid")]
    [RelationshipSchemaName("TransformationParameterMapping_TransformationMapping")]
    public TransformationMapping TransformationParameterMapping_TransformationMapping
    {
      get
      {
        return this.GetRelatedEntity<TransformationMapping>(nameof (TransformationParameterMapping_TransformationMapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransformationParameterMapping_TransformationMapping));
        this.SetRelatedEntity<TransformationMapping>(nameof (TransformationParameterMapping_TransformationMapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransformationParameterMapping_TransformationMapping));
      }
    }

    public TransformationParameterMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["transformationparametermappingid"] = (object) base.Id;
            break;
          case "transformationparametermappingid":
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
