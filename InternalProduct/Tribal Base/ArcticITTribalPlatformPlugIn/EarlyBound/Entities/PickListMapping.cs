// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PickListMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("picklistmapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PickListMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "picklistmapping";
    public const string EntitySchemaName = "PickListMapping";
    public const string PrimaryIdAttribute = "picklistmappingid";

    public PickListMapping()
      : base("picklistmapping")
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

    [AttributeLogicalName("picklistmappingid")]
    public Guid? PickListMappingId
    {
      get => this.GetAttributeValue<Guid?>("picklistmappingid");
      set
      {
        this.OnPropertyChanging(nameof (PickListMappingId));
        this.SetAttributeValue("picklistmappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PickListMappingId));
      }
    }

    [AttributeLogicalName("picklistmappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PickListMappingId = new Guid?(value);
    }

    [AttributeLogicalName("picklistmappingidunique")]
    public Guid? PickListMappingIdUnique
    {
      get => this.GetAttributeValue<Guid?>("picklistmappingidunique");
    }

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

    [AttributeLogicalName("sourcevalue")]
    public string SourceValue
    {
      get => this.GetAttributeValue<string>("sourcevalue");
      set
      {
        this.OnPropertyChanging(nameof (SourceValue));
        this.SetAttributeValue("sourcevalue", (object) value);
        this.OnPropertyChanged(nameof (SourceValue));
      }
    }

    [AttributeLogicalName("statecode")]
    public PickListMappingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new PickListMappingState?((PickListMappingState) Enum.ToObject(typeof (PickListMappingState), attributeValue.Value)) : new PickListMappingState?();
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

    [AttributeLogicalName("targetvalue")]
    public int? TargetValue
    {
      get => this.GetAttributeValue<int?>("targetvalue");
      set
      {
        this.OnPropertyChanging(nameof (TargetValue));
        this.SetAttributeValue("targetvalue", (object) value);
        this.OnPropertyChanged(nameof (TargetValue));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_picklistmapping")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_picklistmapping
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_picklistmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_picklistmapping));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_picklistmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_picklistmapping));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_picklistmapping_createdby")]
    public SystemUser lk_picklistmapping_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_picklistmapping_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_picklistmapping_createdonbehalfby")]
    public SystemUser lk_picklistmapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_picklistmapping_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_picklistmapping_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_picklistmapping_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_picklistmapping_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_picklistmapping_modifiedby")]
    public SystemUser lk_picklistmapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_picklistmapping_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_picklistmapping_modifiedonbehalfby")]
    public SystemUser lk_picklistmapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_picklistmapping_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_picklistmapping_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_picklistmapping_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_picklistmapping_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("columnmappingid")]
    [RelationshipSchemaName("PickListMapping_ColumnMapping")]
    public ColumnMapping PickListMapping_ColumnMapping
    {
      get
      {
        return this.GetRelatedEntity<ColumnMapping>(nameof (PickListMapping_ColumnMapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (PickListMapping_ColumnMapping));
        this.SetRelatedEntity<ColumnMapping>(nameof (PickListMapping_ColumnMapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PickListMapping_ColumnMapping));
      }
    }

    public PickListMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["picklistmappingid"] = (object) base.Id;
            break;
          case "picklistmappingid":
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
