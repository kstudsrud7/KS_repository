// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.EntityDataSource
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("entitydatasource")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class EntityDataSource : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "entitydatasource";
    public const string EntitySchemaName = "EntityDataSource";
    public const string PrimaryIdAttribute = "entitydatasourceid";
    public const string PrimaryNameAttribute = "name";

    public EntityDataSource()
      : base("entitydatasource")
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

    [AttributeLogicalName("connectiondefinition")]
    public string ConnectionDefinition
    {
      get => this.GetAttributeValue<string>("connectiondefinition");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionDefinition));
        this.SetAttributeValue("connectiondefinition", (object) value);
        this.OnPropertyChanged(nameof (ConnectionDefinition));
      }
    }

    [AttributeLogicalName("connectiondefinitionsecrets")]
    public string ConnectionDefinitionSecrets
    {
      get => this.GetAttributeValue<string>("connectiondefinitionsecrets");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionDefinitionSecrets));
        this.SetAttributeValue("connectiondefinitionsecrets", (object) value);
        this.OnPropertyChanged(nameof (ConnectionDefinitionSecrets));
      }
    }

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("entitydataproviderid")]
    public EntityReference EntityDataProviderId
    {
      get => this.GetAttributeValue<EntityReference>("entitydataproviderid");
      set
      {
        this.OnPropertyChanging(nameof (EntityDataProviderId));
        this.SetAttributeValue("entitydataproviderid", (object) value);
        this.OnPropertyChanged(nameof (EntityDataProviderId));
      }
    }

    [AttributeLogicalName("entitydatasourceid")]
    public Guid? EntityDataSourceId
    {
      get => this.GetAttributeValue<Guid?>("entitydatasourceid");
      set
      {
        this.OnPropertyChanging(nameof (EntityDataSourceId));
        this.SetAttributeValue("entitydatasourceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (EntityDataSourceId));
      }
    }

    [AttributeLogicalName("entitydatasourceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.EntityDataSourceId = new Guid?(value);
    }

    [AttributeLogicalName("entitydatasourceidunique")]
    public Guid? EntityDataSourceIdUnique
    {
      get => this.GetAttributeValue<Guid?>("entitydatasourceidunique");
    }

    [AttributeLogicalName("entityname")]
    public string EntityName
    {
      get => this.GetAttributeValue<string>("entityname");
      set
      {
        this.OnPropertyChanging(nameof (EntityName));
        this.SetAttributeValue("entityname", (object) value);
        this.OnPropertyChanged(nameof (EntityName));
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

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("entitydataproviderid")]
    [RelationshipSchemaName("entitydataprovider_datasource")]
    public EntityDataProvider entitydataprovider_datasource
    {
      get
      {
        return this.GetRelatedEntity<EntityDataProvider>(nameof (entitydataprovider_datasource), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entitydataprovider_datasource));
        this.SetRelatedEntity<EntityDataProvider>(nameof (entitydataprovider_datasource), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entitydataprovider_datasource));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_entitydatasource")]
    public Organization organization_entitydatasource
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_entitydatasource), new EntityRole?());
      }
    }

    public EntityDataSource(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["entitydatasourceid"] = (object) base.Id;
            break;
          case "entitydatasourceid":
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
