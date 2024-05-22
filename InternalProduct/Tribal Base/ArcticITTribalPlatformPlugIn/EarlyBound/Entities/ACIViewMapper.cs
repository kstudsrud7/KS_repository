// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ACIViewMapper
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("aciviewmapper")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ACIViewMapper : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "aciviewmapper";
    public const string EntitySchemaName = "ACIViewMapper";
    public const string PrimaryIdAttribute = "aciviewmapperid";

    public ACIViewMapper()
      : base("aciviewmapper")
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

    [AttributeLogicalName("aciviewmapperid")]
    public Guid? ACIViewMapperId
    {
      get => this.GetAttributeValue<Guid?>("aciviewmapperid");
      set
      {
        this.OnPropertyChanging(nameof (ACIViewMapperId));
        this.SetAttributeValue("aciviewmapperid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ACIViewMapperId));
      }
    }

    [AttributeLogicalName("aciviewmapperid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ACIViewMapperId = new Guid?(value);
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("statecode")]
    public ACIViewMapperState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ACIViewMapperState?((ACIViewMapperState) Enum.ToObject(typeof (ACIViewMapperState), attributeValue.Value)) : new ACIViewMapperState?();
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

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("viewname")]
    public string ViewName
    {
      get => this.GetAttributeValue<string>("viewname");
      set
      {
        this.OnPropertyChanging(nameof (ViewName));
        this.SetAttributeValue("viewname", (object) value);
        this.OnPropertyChanged(nameof (ViewName));
      }
    }

    [AttributeLogicalName("webapplicationendpoint")]
    public string WebApplicationEndPoint
    {
      get => this.GetAttributeValue<string>("webapplicationendpoint");
      set
      {
        this.OnPropertyChanging(nameof (WebApplicationEndPoint));
        this.SetAttributeValue("webapplicationendpoint", (object) value);
        this.OnPropertyChanged(nameof (WebApplicationEndPoint));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ACIViewMapper_createdby")]
    public SystemUser lk_ACIViewMapper_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ACIViewMapper_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ACIViewMapper_createdonbehalfby")]
    public SystemUser lk_ACIViewMapper_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ACIViewMapper_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ACIViewMapper_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ACIViewMapper_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ACIViewMapper_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ACIViewMapper_modifiedby")]
    public SystemUser lk_ACIViewMapper_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ACIViewMapper_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ACIViewMapper_modifiedonbehalfby")]
    public SystemUser lk_ACIViewMapper_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ACIViewMapper_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ACIViewMapper_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ACIViewMapper_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ACIViewMapper_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_aciviewmapper")]
    public Organization organization_aciviewmapper
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_aciviewmapper), new EntityRole?());
      }
    }

    public ACIViewMapper(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["aciviewmapperid"] = (object) base.Id;
            break;
          case "aciviewmapperid":
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
