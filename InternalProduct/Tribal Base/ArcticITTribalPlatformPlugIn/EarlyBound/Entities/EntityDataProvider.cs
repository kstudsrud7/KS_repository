// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.EntityDataProvider
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("entitydataprovider")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class EntityDataProvider : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "entitydataprovider";
    public const string EntitySchemaName = "EntityDataProvider";
    public const string PrimaryIdAttribute = "entitydataproviderid";
    public const string PrimaryNameAttribute = "name";

    public EntityDataProvider()
      : base("entitydataprovider")
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

    [AttributeLogicalName("createmultipleplugin")]
    public Guid? CreateMultiplePlugin
    {
      get => this.GetAttributeValue<Guid?>("createmultipleplugin");
      set
      {
        this.OnPropertyChanging(nameof (CreateMultiplePlugin));
        this.SetAttributeValue("createmultipleplugin", (object) value);
        this.OnPropertyChanged(nameof (CreateMultiplePlugin));
      }
    }

    [AttributeLogicalName("createplugin")]
    public Guid? CreatePlugin
    {
      get => this.GetAttributeValue<Guid?>("createplugin");
      set
      {
        this.OnPropertyChanging(nameof (CreatePlugin));
        this.SetAttributeValue("createplugin", (object) value);
        this.OnPropertyChanged(nameof (CreatePlugin));
      }
    }

    [AttributeLogicalName("datasourcelogicalname")]
    public string DataSourceLogicalName
    {
      get => this.GetAttributeValue<string>("datasourcelogicalname");
      set
      {
        this.OnPropertyChanging(nameof (DataSourceLogicalName));
        this.SetAttributeValue("datasourcelogicalname", (object) value);
        this.OnPropertyChanged(nameof (DataSourceLogicalName));
      }
    }

    [AttributeLogicalName("deleteplugin")]
    public Guid? DeletePlugin
    {
      get => this.GetAttributeValue<Guid?>("deleteplugin");
      set
      {
        this.OnPropertyChanging(nameof (DeletePlugin));
        this.SetAttributeValue("deleteplugin", (object) value);
        this.OnPropertyChanged(nameof (DeletePlugin));
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
    public Guid? EntityDataProviderId
    {
      get => this.GetAttributeValue<Guid?>("entitydataproviderid");
      set
      {
        this.OnPropertyChanging(nameof (EntityDataProviderId));
        this.SetAttributeValue("entitydataproviderid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (EntityDataProviderId));
      }
    }

    [AttributeLogicalName("entitydataproviderid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.EntityDataProviderId = new Guid?(value);
    }

    [AttributeLogicalName("entitydataprovideridunique")]
    public Guid? EntityDataProviderIdUnique
    {
      get => this.GetAttributeValue<Guid?>("entitydataprovideridunique");
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

    [AttributeLogicalName("retrieveentitychangesplugin")]
    public Guid? RetrieveEntityChangesPlugin
    {
      get => this.GetAttributeValue<Guid?>("retrieveentitychangesplugin");
      set
      {
        this.OnPropertyChanging(nameof (RetrieveEntityChangesPlugin));
        this.SetAttributeValue("retrieveentitychangesplugin", (object) value);
        this.OnPropertyChanged(nameof (RetrieveEntityChangesPlugin));
      }
    }

    [AttributeLogicalName("retrievemultipleplugin")]
    public Guid? RetrieveMultiplePlugin
    {
      get => this.GetAttributeValue<Guid?>("retrievemultipleplugin");
      set
      {
        this.OnPropertyChanging(nameof (RetrieveMultiplePlugin));
        this.SetAttributeValue("retrievemultipleplugin", (object) value);
        this.OnPropertyChanged(nameof (RetrieveMultiplePlugin));
      }
    }

    [AttributeLogicalName("retrieveplugin")]
    public Guid? RetrievePlugin
    {
      get => this.GetAttributeValue<Guid?>("retrieveplugin");
      set
      {
        this.OnPropertyChanging(nameof (RetrievePlugin));
        this.SetAttributeValue("retrieveplugin", (object) value);
        this.OnPropertyChanged(nameof (RetrievePlugin));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("updatemultipleplugin")]
    public Guid? UpdateMultiplePlugin
    {
      get => this.GetAttributeValue<Guid?>("updatemultipleplugin");
      set
      {
        this.OnPropertyChanging(nameof (UpdateMultiplePlugin));
        this.SetAttributeValue("updatemultipleplugin", (object) value);
        this.OnPropertyChanged(nameof (UpdateMultiplePlugin));
      }
    }

    [AttributeLogicalName("updateplugin")]
    public Guid? UpdatePlugin
    {
      get => this.GetAttributeValue<Guid?>("updateplugin");
      set
      {
        this.OnPropertyChanging(nameof (UpdatePlugin));
        this.SetAttributeValue("updateplugin", (object) value);
        this.OnPropertyChanged(nameof (UpdatePlugin));
      }
    }

    [AttributeLogicalName("upsertmultipleplugin")]
    public Guid? UpsertMultiplePlugin
    {
      get => this.GetAttributeValue<Guid?>("upsertmultipleplugin");
      set
      {
        this.OnPropertyChanging(nameof (UpsertMultiplePlugin));
        this.SetAttributeValue("upsertmultipleplugin", (object) value);
        this.OnPropertyChanged(nameof (UpsertMultiplePlugin));
      }
    }

    [AttributeLogicalName("upsertplugin")]
    public Guid? UpsertPlugin
    {
      get => this.GetAttributeValue<Guid?>("upsertplugin");
      set
      {
        this.OnPropertyChanging(nameof (UpsertPlugin));
        this.SetAttributeValue("upsertplugin", (object) value);
        this.OnPropertyChanged(nameof (UpsertPlugin));
      }
    }

    [RelationshipSchemaName("entitydataprovider_datasource")]
    public IEnumerable<EntityDataSource> entitydataprovider_datasource
    {
      get
      {
        return this.GetRelatedEntities<EntityDataSource>(nameof (entitydataprovider_datasource), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entitydataprovider_datasource));
        this.SetRelatedEntities<EntityDataSource>(nameof (entitydataprovider_datasource), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entitydataprovider_datasource));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_entitydataprovider")]
    public Organization organization_entitydataprovider
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_entitydataprovider), new EntityRole?());
      }
    }

    public EntityDataProvider(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["entitydataproviderid"] = (object) base.Id;
            break;
          case "entitydataproviderid":
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
