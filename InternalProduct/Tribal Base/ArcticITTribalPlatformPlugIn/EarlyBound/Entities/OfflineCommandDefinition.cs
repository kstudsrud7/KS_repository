// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.OfflineCommandDefinition
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("offlinecommanddefinition")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class OfflineCommandDefinition : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "offlinecommanddefinition";
    public const string EntitySchemaName = "OfflineCommandDefinition";
    public const string PrimaryIdAttribute = "commanddefinitionid";
    public const string PrimaryNameAttribute = "commandname";

    public OfflineCommandDefinition()
      : base("offlinecommanddefinition")
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

    [AttributeLogicalName("commanddefinition")]
    public string CommandDefinition
    {
      get => this.GetAttributeValue<string>("commanddefinition");
      set
      {
        this.OnPropertyChanging(nameof (CommandDefinition));
        this.SetAttributeValue("commanddefinition", (object) value);
        this.OnPropertyChanged(nameof (CommandDefinition));
      }
    }

    [AttributeLogicalName("commanddefinitionid")]
    public Guid? CommandDefinitionId
    {
      get => this.GetAttributeValue<Guid?>("commanddefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (CommandDefinitionId));
        this.SetAttributeValue("commanddefinitionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CommandDefinitionId));
      }
    }

    [AttributeLogicalName("commanddefinitionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CommandDefinitionId = new Guid?(value);
    }

    [AttributeLogicalName("commandname")]
    public string CommandName
    {
      get => this.GetAttributeValue<string>("commandname");
      set
      {
        this.OnPropertyChanging(nameof (CommandName));
        this.SetAttributeValue("commandname", (object) value);
        this.OnPropertyChanged(nameof (CommandName));
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

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("importsequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (ImportSequenceNumber));
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged(nameof (ImportSequenceNumber));
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

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("overriddencreatedon");
      set
      {
        this.OnPropertyChanging(nameof (OverriddenCreatedOn));
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged(nameof (OverriddenCreatedOn));
      }
    }

    [AttributeLogicalName("primaryentitylogicalname")]
    public string PrimaryEntityLogicalName
    {
      get => this.GetAttributeValue<string>("primaryentitylogicalname");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityLogicalName));
        this.SetAttributeValue("primaryentitylogicalname", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityLogicalName));
      }
    }

    [AttributeLogicalName("solutionname")]
    public string SolutionName
    {
      get => this.GetAttributeValue<string>("solutionname");
      set
      {
        this.OnPropertyChanging(nameof (SolutionName));
        this.SetAttributeValue("solutionname", (object) value);
        this.OnPropertyChanged(nameof (SolutionName));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("OfflineCommandDefinition_SyncErrors")]
    public IEnumerable<SyncError> OfflineCommandDefinition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (OfflineCommandDefinition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (OfflineCommandDefinition_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (OfflineCommandDefinition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (OfflineCommandDefinition_SyncErrors));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_offlinecommanddefinition_createdby")]
    public SystemUser lk_offlinecommanddefinition_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_offlinecommanddefinition_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_offlinecommanddefinition_createdonbehalfby")]
    public SystemUser lk_offlinecommanddefinition_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_offlinecommanddefinition_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_offlinecommanddefinition_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_offlinecommanddefinition_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_offlinecommanddefinition_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_offlinecommanddefinition_modifiedby")]
    public SystemUser lk_offlinecommanddefinition_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_offlinecommanddefinition_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_offlinecommanddefinition_modifiedonbehalfby")]
    public SystemUser lk_offlinecommanddefinition_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_offlinecommanddefinition_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_offlinecommanddefinition_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_offlinecommanddefinition_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_offlinecommanddefinition_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("offlinecommanddefinition_organization")]
    public Organization offlinecommanddefinition_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (offlinecommanddefinition_organization), new EntityRole?());
      }
    }

    public OfflineCommandDefinition(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["commanddefinitionid"] = (object) base.Id;
            break;
          case "commanddefinitionid":
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
