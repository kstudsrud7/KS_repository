// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TimeZoneLocalizedName
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("timezonelocalizedname")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TimeZoneLocalizedName : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "timezonelocalizedname";
    public const string EntitySchemaName = "TimeZoneLocalizedName";
    public const string PrimaryIdAttribute = "timezonelocalizednameid";
    public const string PrimaryNameAttribute = "userinterfacename";

    public TimeZoneLocalizedName()
      : base("timezonelocalizedname")
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

    [AttributeLogicalName("cultureid")]
    public int? CultureId
    {
      get => this.GetAttributeValue<int?>("cultureid");
      set
      {
        this.OnPropertyChanging(nameof (CultureId));
        this.SetAttributeValue("cultureid", (object) value);
        this.OnPropertyChanged(nameof (CultureId));
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

    [AttributeLogicalName("timezonedefinitionid")]
    public EntityReference TimeZoneDefinitionId
    {
      get => this.GetAttributeValue<EntityReference>("timezonedefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneDefinitionId));
        this.SetAttributeValue("timezonedefinitionid", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneDefinitionId));
      }
    }

    [AttributeLogicalName("timezonelocalizednameid")]
    public Guid? TimeZoneLocalizedNameId
    {
      get => this.GetAttributeValue<Guid?>("timezonelocalizednameid");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneLocalizedNameId));
        this.SetAttributeValue("timezonelocalizednameid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TimeZoneLocalizedNameId));
      }
    }

    [AttributeLogicalName("timezonelocalizednameid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TimeZoneLocalizedNameId = new Guid?(value);
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

    [RelationshipSchemaName("userentityinstancedata_timezonelocalizedname")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonelocalizedname
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_timezonelocalizedname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_timezonelocalizedname));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_timezonelocalizedname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_timezonelocalizedname));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_timezonelocalizedname_createdby")]
    public SystemUser lk_timezonelocalizedname_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonelocalizedname_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_timezonelocalizedname_createdonbehalfby")]
    public SystemUser lk_timezonelocalizedname_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonelocalizedname_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonelocalizedname_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_timezonelocalizedname_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonelocalizedname_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_timezonelocalizedname_modifiedby")]
    public SystemUser lk_timezonelocalizedname_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonelocalizedname_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_timezonelocalizedname_modifiedonbehalfby")]
    public SystemUser lk_timezonelocalizedname_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_timezonelocalizedname_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonelocalizedname_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_timezonelocalizedname_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonelocalizedname_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("timezonedefinitionid")]
    [RelationshipSchemaName("lk_timezonelocalizedname_timezonedefinitionid")]
    public TimeZoneDefinition lk_timezonelocalizedname_timezonedefinitionid
    {
      get
      {
        return this.GetRelatedEntity<TimeZoneDefinition>(nameof (lk_timezonelocalizedname_timezonedefinitionid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_timezonelocalizedname_timezonedefinitionid));
        this.SetRelatedEntity<TimeZoneDefinition>(nameof (lk_timezonelocalizedname_timezonedefinitionid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_timezonelocalizedname_timezonedefinitionid));
      }
    }

    public TimeZoneLocalizedName(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["timezonelocalizednameid"] = (object) base.Id;
            break;
          case "timezonelocalizednameid":
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
