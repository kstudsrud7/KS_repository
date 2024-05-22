// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AdvancedSimilarityRule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("advancedsimilarityrule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AdvancedSimilarityRule : Microsoft.Xrm.Sdk.Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "advancedsimilarityrule";
    public const string EntitySchemaName = "AdvancedSimilarityRule";
    public const string PrimaryIdAttribute = "advancedsimilarityruleid";
    public const string PrimaryNameAttribute = "name";

    public AdvancedSimilarityRule()
      : base("advancedsimilarityrule")
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

    [AttributeLogicalName("advancedsimilarityruleid")]
    public Guid? AdvancedSimilarityRuleId
    {
      get => this.GetAttributeValue<Guid?>("advancedsimilarityruleid");
      set
      {
        this.OnPropertyChanging(nameof (AdvancedSimilarityRuleId));
        this.SetAttributeValue("advancedsimilarityruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AdvancedSimilarityRuleId));
      }
    }

    [AttributeLogicalName("advancedsimilarityruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AdvancedSimilarityRuleId = new Guid?(value);
    }

    [AttributeLogicalName("advancedsimilarityruleidunique")]
    public Guid? AdvancedSimilarityRuleIdUnique
    {
      get => this.GetAttributeValue<Guid?>("advancedsimilarityruleidunique");
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

    [AttributeLogicalName("exactmatchlist")]
    public string ExactMatchList
    {
      get => this.GetAttributeValue<string>("exactmatchlist");
      set
      {
        this.OnPropertyChanging(nameof (ExactMatchList));
        this.SetAttributeValue("exactmatchlist", (object) value);
        this.OnPropertyChanged(nameof (ExactMatchList));
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

    [AttributeLogicalName("filterresultbystatus")]
    public OptionSetValue FilterResultByStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("filterresultbystatus");
      set
      {
        this.OnPropertyChanging(nameof (FilterResultByStatus));
        this.SetAttributeValue("filterresultbystatus", (object) value);
        this.OnPropertyChanged(nameof (FilterResultByStatus));
      }
    }

    [AttributeLogicalName("filterresultbystatusdisplayname")]
    public string FilterResultByStatusDisplayName
    {
      get => this.GetAttributeValue<string>("filterresultbystatusdisplayname");
      set
      {
        this.OnPropertyChanging(nameof (FilterResultByStatusDisplayName));
        this.SetAttributeValue("filterresultbystatusdisplayname", (object) value);
        this.OnPropertyChanged(nameof (FilterResultByStatusDisplayName));
      }
    }

    [AttributeLogicalName("isazuremlrequired")]
    public bool? IsAzureMLRequired
    {
      get => this.GetAttributeValue<bool?>("isazuremlrequired");
      set
      {
        this.OnPropertyChanging(nameof (IsAzureMLRequired));
        this.SetAttributeValue("isazuremlrequired", (object) value);
        this.OnPropertyChanged(nameof (IsAzureMLRequired));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("maxnumberkeyphrases")]
    public int? MaxNumberKeyphrases
    {
      get => this.GetAttributeValue<int?>("maxnumberkeyphrases");
      set
      {
        this.OnPropertyChanging(nameof (MaxNumberKeyphrases));
        this.SetAttributeValue("maxnumberkeyphrases", (object) value);
        this.OnPropertyChanged(nameof (MaxNumberKeyphrases));
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
    public string name
    {
      get => this.GetAttributeValue<string>(nameof (name));
      set
      {
        this.OnPropertyChanging(nameof (name));
        this.SetAttributeValue(nameof (name), (object) value);
        this.OnPropertyChanged(nameof (name));
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
    public AdvancedSimilarityRuleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new AdvancedSimilarityRuleState?((AdvancedSimilarityRuleState) Enum.ToObject(typeof (AdvancedSimilarityRuleState), attributeValue.Value)) : new AdvancedSimilarityRuleState?();
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

    [RelationshipSchemaName("advancedsimilarityrule_textanalyticsentitymapping")]
    public IEnumerable<TextAnalyticsEntityMapping> advancedsimilarityrule_textanalyticsentitymapping
    {
      get
      {
        return this.GetRelatedEntities<TextAnalyticsEntityMapping>(nameof (advancedsimilarityrule_textanalyticsentitymapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (advancedsimilarityrule_textanalyticsentitymapping));
        this.SetRelatedEntities<TextAnalyticsEntityMapping>(nameof (advancedsimilarityrule_textanalyticsentitymapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (advancedsimilarityrule_textanalyticsentitymapping));
      }
    }

    [AttributeLogicalName("azureserviceconnectionid")]
    [RelationshipSchemaName("azureserviceconnection_advancedsimilarityrule")]
    public AzureServiceConnection azureserviceconnection_advancedsimilarityrule
    {
      get
      {
        return this.GetRelatedEntity<AzureServiceConnection>(nameof (azureserviceconnection_advancedsimilarityrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (azureserviceconnection_advancedsimilarityrule));
        this.SetRelatedEntity<AzureServiceConnection>(nameof (azureserviceconnection_advancedsimilarityrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (azureserviceconnection_advancedsimilarityrule));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_advancedsimilarityrule_createdby")]
    public SystemUser lk_advancedsimilarityrule_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_advancedsimilarityrule_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_advancedsimilarityrule_createdonbehalfby")]
    public SystemUser lk_advancedsimilarityrule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_advancedsimilarityrule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_advancedsimilarityrule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_advancedsimilarityrule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_advancedsimilarityrule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_advancedsimilarityrule_modifiedby")]
    public SystemUser lk_advancedsimilarityrule_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_advancedsimilarityrule_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_advancedsimilarityrule_modifiedonbehalfby")]
    public SystemUser lk_advancedsimilarityrule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_advancedsimilarityrule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_advancedsimilarityrule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_advancedsimilarityrule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_advancedsimilarityrule_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_advancedsimilarityrule")]
    public Organization organization_advancedsimilarityrule
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_advancedsimilarityrule), new EntityRole?());
      }
    }

    public AdvancedSimilarityRule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["advancedsimilarityruleid"] = (object) base.Id;
            break;
          case "advancedsimilarityruleid":
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
