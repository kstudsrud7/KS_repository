// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ImportEntityMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("importentitymapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ImportEntityMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "importentitymapping";
    public const string EntitySchemaName = "ImportEntityMapping";
    public const string PrimaryIdAttribute = "importentitymappingid";

    public ImportEntityMapping()
      : base("importentitymapping")
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

    [AttributeLogicalName("dedupe")]
    public OptionSetValue DeDupe
    {
      get => this.GetAttributeValue<OptionSetValue>("dedupe");
      set
      {
        this.OnPropertyChanging(nameof (DeDupe));
        this.SetAttributeValue("dedupe", (object) value);
        this.OnPropertyChanged(nameof (DeDupe));
      }
    }

    [AttributeLogicalName("importentitymappingid")]
    public Guid? ImportEntityMappingId
    {
      get => this.GetAttributeValue<Guid?>("importentitymappingid");
      set
      {
        this.OnPropertyChanging(nameof (ImportEntityMappingId));
        this.SetAttributeValue("importentitymappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ImportEntityMappingId));
      }
    }

    [AttributeLogicalName("importentitymappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ImportEntityMappingId = new Guid?(value);
    }

    [AttributeLogicalName("importentitymappingidunique")]
    public Guid? ImportEntityMappingIdUnique
    {
      get => this.GetAttributeValue<Guid?>("importentitymappingidunique");
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
    public ImportEntityMappingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ImportEntityMappingState?((ImportEntityMappingState) Enum.ToObject(typeof (ImportEntityMappingState), attributeValue.Value)) : new ImportEntityMappingState?();
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

    [RelationshipSchemaName("userentityinstancedata_importentitymapping")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_importentitymapping
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importentitymapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importentitymapping));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importentitymapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importentitymapping));
      }
    }

    [AttributeLogicalName("importmapid")]
    [RelationshipSchemaName("ImportEntityMapping_ImportMap")]
    public ImportMap ImportEntityMapping_ImportMap
    {
      get
      {
        return this.GetRelatedEntity<ImportMap>(nameof (ImportEntityMapping_ImportMap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportEntityMapping_ImportMap));
        this.SetRelatedEntity<ImportMap>(nameof (ImportEntityMapping_ImportMap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportEntityMapping_ImportMap));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_importentitymapping_createdby")]
    public SystemUser lk_importentitymapping_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importentitymapping_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_importentitymapping_createdonbehalfby")]
    public SystemUser lk_importentitymapping_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importentitymapping_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importentitymapping_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importentitymapping_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importentitymapping_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_importentitymapping_modifiedby")]
    public SystemUser lk_importentitymapping_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importentitymapping_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_importentitymapping_modifiedonbehalfby")]
    public SystemUser lk_importentitymapping_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importentitymapping_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importentitymapping_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importentitymapping_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importentitymapping_modifiedonbehalfby));
      }
    }

    public ImportEntityMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["importentitymappingid"] = (object) base.Id;
            break;
          case "importentitymappingid":
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
