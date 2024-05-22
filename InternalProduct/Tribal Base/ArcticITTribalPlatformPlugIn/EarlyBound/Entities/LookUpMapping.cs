// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.LookUpMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("lookupmapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class LookUpMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "lookupmapping";
    public const string EntitySchemaName = "LookUpMapping";
    public const string PrimaryIdAttribute = "lookupmappingid";

    public LookUpMapping()
      : base("lookupmapping")
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

    [AttributeLogicalName("columnmappingid")]
    public EntityReference ColumnMappingId
    {
      get => this.GetAttributeValue<EntityReference>("columnmappingid");
      set
      {
        this.OnPropertyChanging(nameof (ColumnMappingId));
        this.SetAttributeValue("columnmappingid", (object) value);
        this.OnPropertyChanged(nameof (ColumnMappingId));
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

    [AttributeLogicalName("lookupattributename")]
    public string LookUpAttributeName
    {
      get => this.GetAttributeValue<string>("lookupattributename");
      set
      {
        this.OnPropertyChanging(nameof (LookUpAttributeName));
        this.SetAttributeValue("lookupattributename", (object) value);
        this.OnPropertyChanged(nameof (LookUpAttributeName));
      }
    }

    [AttributeLogicalName("lookupentityname")]
    public string LookUpEntityName
    {
      get => this.GetAttributeValue<string>("lookupentityname");
      set
      {
        this.OnPropertyChanging(nameof (LookUpEntityName));
        this.SetAttributeValue("lookupentityname", (object) value);
        this.OnPropertyChanged(nameof (LookUpEntityName));
      }
    }

    [AttributeLogicalName("lookupmappingid")]
    public Guid? LookUpMappingId
    {
      get => this.GetAttributeValue<Guid?>("lookupmappingid");
      set
      {
        this.OnPropertyChanging(nameof (LookUpMappingId));
        this.SetAttributeValue("lookupmappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (LookUpMappingId));
      }
    }

    [AttributeLogicalName("lookupmappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.LookUpMappingId = new Guid?(value);
    }

    [AttributeLogicalName("lookupmappingidunique")]
    public Guid? LookUpMappingIdUnique => this.GetAttributeValue<Guid?>("lookupmappingidunique");

    [AttributeLogicalName("lookupsourcecode")]
    public OptionSetValue LookUpSourceCode
    {
      get => this.GetAttributeValue<OptionSetValue>("lookupsourcecode");
      set
      {
        this.OnPropertyChanging(nameof (LookUpSourceCode));
        this.SetAttributeValue("lookupsourcecode", (object) value);
        this.OnPropertyChanged(nameof (LookUpSourceCode));
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

    [AttributeLogicalName("statecode")]
    public LookUpMappingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new LookUpMappingState?((LookUpMappingState) Enum.ToObject(typeof (LookUpMappingState), attributeValue.Value)) : new LookUpMappingState?();
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

    [AttributeLogicalName("transformationparametermappingid")]
    public EntityReference TransformationParameterMappingId
    {
      get => this.GetAttributeValue<EntityReference>("transformationparametermappingid");
      set
      {
        this.OnPropertyChanging(nameof (TransformationParameterMappingId));
        this.SetAttributeValue("transformationparametermappingid", (object) value);
        this.OnPropertyChanged(nameof (TransformationParameterMappingId));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_lookupmapping")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_lookupmapping
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_lookupmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_lookupmapping));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_lookupmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_lookupmapping));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_lookupmapping_createdby")]
    public SystemUser lk_lookupmapping_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_lookupmapping_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_lookupmapping_createdonbehalfby")]
    public SystemUser lk_lookupmapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_lookupmapping_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_lookupmapping_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_lookupmapping_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_lookupmapping_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_lookupmapping_modifiedby")]
    public SystemUser lk_lookupmapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_lookupmapping_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_lookupmapping_modifiedonbehalfby")]
    public SystemUser lk_lookupmapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_lookupmapping_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_lookupmapping_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_lookupmapping_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_lookupmapping_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("columnmappingid")]
    [RelationshipSchemaName("LookUpMapping_ColumnMapping")]
    public ColumnMapping LookUpMapping_ColumnMapping
    {
      get
      {
        return this.GetRelatedEntity<ColumnMapping>(nameof (LookUpMapping_ColumnMapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (LookUpMapping_ColumnMapping));
        this.SetRelatedEntity<ColumnMapping>(nameof (LookUpMapping_ColumnMapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (LookUpMapping_ColumnMapping));
      }
    }

    [AttributeLogicalName("transformationparametermappingid")]
    [RelationshipSchemaName("LookUpMapping_TransformationParameterMapping")]
    public TransformationParameterMapping LookUpMapping_TransformationParameterMapping
    {
      get
      {
        return this.GetRelatedEntity<TransformationParameterMapping>(nameof (LookUpMapping_TransformationParameterMapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (LookUpMapping_TransformationParameterMapping));
        this.SetRelatedEntity<TransformationParameterMapping>(nameof (LookUpMapping_TransformationParameterMapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (LookUpMapping_TransformationParameterMapping));
      }
    }

    public LookUpMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["lookupmappingid"] = (object) base.Id;
            break;
          case "lookupmappingid":
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
