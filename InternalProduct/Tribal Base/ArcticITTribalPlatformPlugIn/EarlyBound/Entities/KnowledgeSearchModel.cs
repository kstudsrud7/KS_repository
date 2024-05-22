// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.KnowledgeSearchModel
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("knowledgesearchmodel")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class KnowledgeSearchModel : Microsoft.Xrm.Sdk.Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "knowledgesearchmodel";
    public const string EntitySchemaName = "KnowledgeSearchModel";
    public const string PrimaryIdAttribute = "knowledgesearchmodelid";
    public const string PrimaryNameAttribute = "name";

    public KnowledgeSearchModel()
      : base("knowledgesearchmodel")
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

    [AttributeLogicalName("azureserviceconnectionid")]
    public EntityReference AzureServiceConnectionId
    {
      get => this.GetAttributeValue<EntityReference>("azureserviceconnectionid");
      set
      {
        this.OnPropertyChanging(nameof (AzureServiceConnectionId));
        this.SetAttributeValue("azureserviceconnectionid", (object) value);
        this.OnPropertyChanged(nameof (AzureServiceConnectionId));
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

    [AttributeLogicalName("entity")]
    public string Entity
    {
      get => this.GetAttributeValue<string>("entity");
      set
      {
        this.OnPropertyChanging(nameof (Entity));
        this.SetAttributeValue("entity", (object) value);
        this.OnPropertyChanged(nameof (Entity));
      }
    }

    [AttributeLogicalName("fetchxmllist")]
    public string FetchXmlList
    {
      get => this.GetAttributeValue<string>("fetchxmllist");
      set
      {
        this.OnPropertyChanging(nameof (FetchXmlList));
        this.SetAttributeValue("fetchxmllist", (object) value);
        this.OnPropertyChanged(nameof (FetchXmlList));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("knowledgesearchmodelid")]
    public Guid? KnowledgeSearchModelId
    {
      get => this.GetAttributeValue<Guid?>("knowledgesearchmodelid");
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeSearchModelId));
        this.SetAttributeValue("knowledgesearchmodelid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (KnowledgeSearchModelId));
      }
    }

    [AttributeLogicalName("knowledgesearchmodelid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.KnowledgeSearchModelId = new Guid?(value);
    }

    [AttributeLogicalName("knowledgesearchmodelidunique")]
    public Guid? KnowledgeSearchModelIdUnique
    {
      get => this.GetAttributeValue<Guid?>("knowledgesearchmodelidunique");
    }

    [AttributeLogicalName("maxkeywords")]
    public int? MaxKeyWords
    {
      get => this.GetAttributeValue<int?>("maxkeywords");
      set
      {
        this.OnPropertyChanging(nameof (MaxKeyWords));
        this.SetAttributeValue("maxkeywords", (object) value);
        this.OnPropertyChanged(nameof (MaxKeyWords));
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

    [AttributeLogicalName("ngramsize")]
    public int? NgramSize
    {
      get => this.GetAttributeValue<int?>("ngramsize");
      set
      {
        this.OnPropertyChanging(nameof (NgramSize));
        this.SetAttributeValue("ngramsize", (object) value);
        this.OnPropertyChanged(nameof (NgramSize));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("sourceentity")]
    public string SourceEntity
    {
      get => this.GetAttributeValue<string>("sourceentity");
      set
      {
        this.OnPropertyChanging(nameof (SourceEntity));
        this.SetAttributeValue("sourceentity", (object) value);
        this.OnPropertyChanged(nameof (SourceEntity));
      }
    }

    [AttributeLogicalName("statecode")]
    public KnowledgeSearchModelState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new KnowledgeSearchModelState?((KnowledgeSearchModelState) Enum.ToObject(typeof (KnowledgeSearchModelState), attributeValue.Value)) : new KnowledgeSearchModelState?();
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

    [RelationshipSchemaName("knowledgesearchmodel_textanalyticsentitymapping")]
    public IEnumerable<TextAnalyticsEntityMapping> knowledgesearchmodel_textanalyticsentitymapping
    {
      get
      {
        return this.GetRelatedEntities<TextAnalyticsEntityMapping>(nameof (knowledgesearchmodel_textanalyticsentitymapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgesearchmodel_textanalyticsentitymapping));
        this.SetRelatedEntities<TextAnalyticsEntityMapping>(nameof (knowledgesearchmodel_textanalyticsentitymapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgesearchmodel_textanalyticsentitymapping));
      }
    }

    [AttributeLogicalName("azureserviceconnectionid")]
    [RelationshipSchemaName("azureserviceconnection_knowledgesearchmodel")]
    public AzureServiceConnection azureserviceconnection_knowledgesearchmodel
    {
      get
      {
        return this.GetRelatedEntity<AzureServiceConnection>(nameof (azureserviceconnection_knowledgesearchmodel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (azureserviceconnection_knowledgesearchmodel));
        this.SetRelatedEntity<AzureServiceConnection>(nameof (azureserviceconnection_knowledgesearchmodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (azureserviceconnection_knowledgesearchmodel));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_knowledgesearchmodel_createdby")]
    public SystemUser lk_knowledgesearchmodel_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgesearchmodel_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_knowledgesearchmodel_createdonbehalfby")]
    public SystemUser lk_knowledgesearchmodel_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgesearchmodel_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_knowledgesearchmodel_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_knowledgesearchmodel_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_knowledgesearchmodel_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_knowledgesearchmodel_modifiedby")]
    public SystemUser lk_knowledgesearchmodel_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgesearchmodel_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_knowledgesearchmodel_modifiedonbehalfby")]
    public SystemUser lk_knowledgesearchmodel_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_knowledgesearchmodel_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_knowledgesearchmodel_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_knowledgesearchmodel_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_knowledgesearchmodel_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_knowledgesearchmodel")]
    public Organization organization_knowledgesearchmodel
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_knowledgesearchmodel), new EntityRole?());
      }
    }

    public KnowledgeSearchModel(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["knowledgesearchmodelid"] = (object) base.Id;
            break;
          case "knowledgesearchmodelid":
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
