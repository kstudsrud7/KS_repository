// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AzureServiceConnection
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("azureserviceconnection")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AzureServiceConnection : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "azureserviceconnection";
    public const string EntitySchemaName = "AzureServiceConnection";
    public const string PrimaryIdAttribute = "azureserviceconnectionid";
    public const string PrimaryNameAttribute = "name";

    public AzureServiceConnection()
      : base("azureserviceconnection")
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

    [AttributeLogicalName("accountkey")]
    public string AccountKey
    {
      get => this.GetAttributeValue<string>("accountkey");
      set
      {
        this.OnPropertyChanging(nameof (AccountKey));
        this.SetAttributeValue("accountkey", (object) value);
        this.OnPropertyChanged(nameof (AccountKey));
      }
    }

    [AttributeLogicalName("azureserviceconnectionid")]
    public Guid? AzureServiceConnectionId
    {
      get => this.GetAttributeValue<Guid?>("azureserviceconnectionid");
      set
      {
        this.OnPropertyChanging(nameof (AzureServiceConnectionId));
        this.SetAttributeValue("azureserviceconnectionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AzureServiceConnectionId));
      }
    }

    [AttributeLogicalName("azureserviceconnectionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AzureServiceConnectionId = new Guid?(value);
    }

    [AttributeLogicalName("connectiontype")]
    public OptionSetValue ConnectionType
    {
      get => this.GetAttributeValue<OptionSetValue>("connectiontype");
      set
      {
        this.OnPropertyChanging(nameof (ConnectionType));
        this.SetAttributeValue("connectiontype", (object) value);
        this.OnPropertyChanged(nameof (ConnectionType));
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

    [AttributeLogicalName("lastconnectionstatuscode")]
    public OptionSetValue LastConnectionStatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("lastconnectionstatuscode");
      set
      {
        this.OnPropertyChanging(nameof (LastConnectionStatusCode));
        this.SetAttributeValue("lastconnectionstatuscode", (object) value);
        this.OnPropertyChanged(nameof (LastConnectionStatusCode));
      }
    }

    [AttributeLogicalName("lastconnectiontime")]
    public DateTime? LastConnectionTime
    {
      get => this.GetAttributeValue<DateTime?>("lastconnectiontime");
      set
      {
        this.OnPropertyChanging(nameof (LastConnectionTime));
        this.SetAttributeValue("lastconnectiontime", (object) value);
        this.OnPropertyChanged(nameof (LastConnectionTime));
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
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("serviceuri")]
    public string ServiceUri
    {
      get => this.GetAttributeValue<string>("serviceuri");
      set
      {
        this.OnPropertyChanging(nameof (ServiceUri));
        this.SetAttributeValue("serviceuri", (object) value);
        this.OnPropertyChanged(nameof (ServiceUri));
      }
    }

    [AttributeLogicalName("statecode")]
    public AzureServiceConnectionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AzureServiceConnectionState?((AzureServiceConnectionState) Enum.ToObject(typeof (AzureServiceConnectionState), attributeValue.Value)) : new AzureServiceConnectionState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (statecode));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (statecode), (object) null);
        else
          this.SetAttributeValue(nameof (statecode), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (statecode));
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

    [RelationshipSchemaName("azureserviceconnection_advancedsimilarityrule")]
    public IEnumerable<AdvancedSimilarityRule> azureserviceconnection_advancedsimilarityrule
    {
      get
      {
        return this.GetRelatedEntities<AdvancedSimilarityRule>(nameof (azureserviceconnection_advancedsimilarityrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (azureserviceconnection_advancedsimilarityrule));
        this.SetRelatedEntities<AdvancedSimilarityRule>(nameof (azureserviceconnection_advancedsimilarityrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (azureserviceconnection_advancedsimilarityrule));
      }
    }

    [RelationshipSchemaName("azureserviceconnection_knowledgesearchmodel")]
    public IEnumerable<KnowledgeSearchModel> azureserviceconnection_knowledgesearchmodel
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeSearchModel>(nameof (azureserviceconnection_knowledgesearchmodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (azureserviceconnection_knowledgesearchmodel));
        this.SetRelatedEntities<KnowledgeSearchModel>(nameof (azureserviceconnection_knowledgesearchmodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (azureserviceconnection_knowledgesearchmodel));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_azureserviceconnection_createdby")]
    public SystemUser lk_azureserviceconnection_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_azureserviceconnection_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_azureserviceconnection_createdonbehalfby")]
    public SystemUser lk_azureserviceconnection_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_azureserviceconnection_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_azureserviceconnection_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_azureserviceconnection_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_azureserviceconnection_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_azureserviceconnection_modifiedby")]
    public SystemUser lk_azureserviceconnection_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_azureserviceconnection_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_azureserviceconnection_modifiedonbehalfby")]
    public SystemUser lk_azureserviceconnection_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_azureserviceconnection_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_azureserviceconnection_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_azureserviceconnection_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_azureserviceconnection_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_azureserviceconnection")]
    public Organization organization_azureserviceconnection
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_azureserviceconnection), new EntityRole?());
      }
    }

    public AzureServiceConnection(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["azureserviceconnectionid"] = (object) base.Id;
            break;
          case "azureserviceconnectionid":
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
