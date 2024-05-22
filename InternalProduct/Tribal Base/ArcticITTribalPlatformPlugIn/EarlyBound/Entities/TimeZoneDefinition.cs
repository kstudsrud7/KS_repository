// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TimeZoneDefinition
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("timezonedefinition")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TimeZoneDefinition : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "timezonedefinition";
    public const string EntitySchemaName = "TimeZoneDefinition";
    public const string PrimaryIdAttribute = "timezonedefinitionid";
    public const string PrimaryNameAttribute = "userinterfacename";

    public TimeZoneDefinition()
      : base("timezonedefinition")
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

    [AttributeLogicalName("bias")]
    public int? Bias
    {
      get => this.GetAttributeValue<int?>("bias");
      set
      {
        this.OnPropertyChanging(nameof (Bias));
        this.SetAttributeValue("bias", (object) value);
        this.OnPropertyChanged(nameof (Bias));
      }
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

    [AttributeLogicalName("daylightname")]
    public string DaylightName
    {
      get => this.GetAttributeValue<string>("daylightname");
      set
      {
        this.OnPropertyChanging(nameof (DaylightName));
        this.SetAttributeValue("daylightname", (object) value);
        this.OnPropertyChanged(nameof (DaylightName));
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

    [AttributeLogicalName("retiredorder")]
    public int? RetiredOrder
    {
      get => this.GetAttributeValue<int?>("retiredorder");
      set
      {
        this.OnPropertyChanging(nameof (RetiredOrder));
        this.SetAttributeValue("retiredorder", (object) value);
        this.OnPropertyChanged(nameof (RetiredOrder));
      }
    }

    [AttributeLogicalName("standardname")]
    public string StandardName
    {
      get => this.GetAttributeValue<string>("standardname");
      set
      {
        this.OnPropertyChanging(nameof (StandardName));
        this.SetAttributeValue("standardname", (object) value);
        this.OnPropertyChanged(nameof (StandardName));
      }
    }

    [AttributeLogicalName("timezonecode")]
    public int? TimeZoneCode
    {
      get => this.GetAttributeValue<int?>("timezonecode");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneCode));
        this.SetAttributeValue("timezonecode", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneCode));
      }
    }

    [AttributeLogicalName("timezonedefinitionid")]
    public Guid? TimeZoneDefinitionId
    {
      get => this.GetAttributeValue<Guid?>("timezonedefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDefinitionId));
        this.SetAttributeValue("timezonedefinitionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TimeZoneDefinitionId));
      }
    }

    [AttributeLogicalName("timezonedefinitionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TimeZoneDefinitionId = new Guid?(value);
    }

    [AttributeLogicalName("userinterfacename")]
    public string UserInterfaceName
    {
      get => this.GetAttributeValue<string>("userinterfacename");
      set
      {
        this.OnPropertyChanging(nameof (UserInterfaceName));
        this.SetAttributeValue("userinterfacename", (object) value);
        this.OnPropertyChanged(nameof (UserInterfaceName));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("lk_timezonelocalizedname_timezonedefinitionid")]
    public IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_timezonedefinitionid
    {
      get
      {
        return this.GetRelatedEntities<TimeZoneLocalizedName>(nameof (lk_timezonelocalizedname_timezonedefinitionid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonelocalizedname_timezonedefinitionid));
        this.SetRelatedEntities<TimeZoneLocalizedName>(nameof (lk_timezonelocalizedname_timezonedefinitionid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonelocalizedname_timezonedefinitionid));
      }
    }

    [RelationshipSchemaName("lk_timezonerule_timezonedefinitionid")]
    public IEnumerable<TimeZoneRule> lk_timezonerule_timezonedefinitionid
    {
      get
      {
        return this.GetRelatedEntities<TimeZoneRule>(nameof (lk_timezonerule_timezonedefinitionid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonerule_timezonedefinitionid));
        this.SetRelatedEntities<TimeZoneRule>(nameof (lk_timezonerule_timezonedefinitionid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonerule_timezonedefinitionid));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_timezonedefinition")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonedefinition
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_timezonedefinition), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_timezonedefinition));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_timezonedefinition), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_timezonedefinition));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_timezonedefinition_createdby")]
    public SystemUser lk_timezonedefinition_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonedefinition_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_timezonedefinition_createdonbehalfby")]
    public SystemUser lk_timezonedefinition_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonedefinition_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonedefinition_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_timezonedefinition_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonedefinition_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_timezonedefinition_modifiedby")]
    public SystemUser lk_timezonedefinition_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonedefinition_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_timezonedefinition_modifiedonbehalfby")]
    public SystemUser lk_timezonedefinition_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonedefinition_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonedefinition_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_timezonedefinition_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonedefinition_modifiedonbehalfby));
      }
    }

    public TimeZoneDefinition(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["timezonedefinitionid"] = (object) base.Id;
            break;
          case "timezonedefinitionid":
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
