// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TextAnalyticsEntityMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("textanalyticsentitymapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TextAnalyticsEntityMapping : Microsoft.Xrm.Sdk.Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "textanalyticsentitymapping";
    public const string EntitySchemaName = "TextAnalyticsEntityMapping";
    public const string PrimaryIdAttribute = "textanalyticsentitymappingid";

    public TextAnalyticsEntityMapping()
      : base("textanalyticsentitymapping")
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
    public EntityReference AdvancedSimilarityRuleId
    {
      get => this.GetAttributeValue<EntityReference>("advancedsimilarityruleid");
      set
      {
        this.OnPropertyChanging(nameof (AdvancedSimilarityRuleId));
        this.SetAttributeValue("advancedsimilarityruleid", (object) value);
        this.OnPropertyChanged(nameof (AdvancedSimilarityRuleId));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("entitydisplayname")]
    public string EntityDisplayName
    {
      get => this.GetAttributeValue<string>("entitydisplayname");
      set
      {
        this.OnPropertyChanging(nameof (EntityDisplayName));
        this.SetAttributeValue("entitydisplayname", (object) value);
        this.OnPropertyChanged(nameof (EntityDisplayName));
      }
    }

    [AttributeLogicalName("entitypicklist")]
    public OptionSetValue EntityPickList
    {
      get => this.GetAttributeValue<OptionSetValue>("entitypicklist");
      set
      {
        this.OnPropertyChanging(nameof (EntityPickList));
        this.SetAttributeValue("entitypicklist", (object) value);
        this.OnPropertyChanged(nameof (EntityPickList));
      }
    }

    [AttributeLogicalName("field")]
    public string Field
    {
      get => this.GetAttributeValue<string>("field");
      set
      {
        this.OnPropertyChanging(nameof (Field));
        this.SetAttributeValue("field", (object) value);
        this.OnPropertyChanged(nameof (Field));
      }
    }

    [AttributeLogicalName("fielddisplayname")]
    public string FieldDisplayName
    {
      get => this.GetAttributeValue<string>("fielddisplayname");
      set
      {
        this.OnPropertyChanging(nameof (FieldDisplayName));
        this.SetAttributeValue("fielddisplayname", (object) value);
        this.OnPropertyChanged(nameof (FieldDisplayName));
      }
    }

    [AttributeLogicalName("fieldpicklist")]
    public OptionSetValue FieldPickList
    {
      get => this.GetAttributeValue<OptionSetValue>("fieldpicklist");
      set
      {
        this.OnPropertyChanging(nameof (FieldPickList));
        this.SetAttributeValue("fieldpicklist", (object) value);
        this.OnPropertyChanged(nameof (FieldPickList));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("istextmatchmapping")]
    public bool? IsTextMatchMapping
    {
      get => this.GetAttributeValue<bool?>("istextmatchmapping");
      set
      {
        this.OnPropertyChanging(nameof (IsTextMatchMapping));
        this.SetAttributeValue("istextmatchmapping", (object) value);
        this.OnPropertyChanged(nameof (IsTextMatchMapping));
      }
    }

    [AttributeLogicalName("knowledgesearchmodelid")]
    public EntityReference KnowledgeSearchModelId
    {
      get => this.GetAttributeValue<EntityReference>("knowledgesearchmodelid");
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeSearchModelId));
        this.SetAttributeValue("knowledgesearchmodelid", (object) value);
        this.OnPropertyChanged(nameof (KnowledgeSearchModelId));
      }
    }

    [AttributeLogicalName("modeltype")]
    public int? ModelType
    {
      get => this.GetAttributeValue<int?>("modeltype");
      set
      {
        this.OnPropertyChanging(nameof (ModelType));
        this.SetAttributeValue("modeltype", (object) value);
        this.OnPropertyChanged(nameof (ModelType));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("relationshipname")]
    public string RelationshipName
    {
      get => this.GetAttributeValue<string>("relationshipname");
      set
      {
        this.OnPropertyChanging(nameof (RelationshipName));
        this.SetAttributeValue("relationshipname", (object) value);
        this.OnPropertyChanged(nameof (RelationshipName));
      }
    }

    [AttributeLogicalName("similarityruleid")]
    public EntityReference SimilarityRuleId
    {
      get => this.GetAttributeValue<EntityReference>("similarityruleid");
      set
      {
        this.OnPropertyChanging(nameof (SimilarityRuleId));
        this.SetAttributeValue("similarityruleid", (object) value);
        this.OnPropertyChanged(nameof (SimilarityRuleId));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("textanalyticsentitymappingid")]
    public Guid? TextAnalyticsEntityMappingId
    {
      get => this.GetAttributeValue<Guid?>("textanalyticsentitymappingid");
      set
      {
        this.OnPropertyChanging(nameof (TextAnalyticsEntityMappingId));
        this.SetAttributeValue("textanalyticsentitymappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TextAnalyticsEntityMappingId));
      }
    }

    [AttributeLogicalName("textanalyticsentitymappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TextAnalyticsEntityMappingId = new Guid?(value);
    }

    [AttributeLogicalName("textanalyticsentitymappingidunique")]
    public Guid? TextAnalyticsEntityMappingIdUnique
    {
      get => this.GetAttributeValue<Guid?>("textanalyticsentitymappingidunique");
    }

    [AttributeLogicalName("advancedsimilarityruleid")]
    [RelationshipSchemaName("advancedsimilarityrule_textanalyticsentitymapping")]
    public AdvancedSimilarityRule advancedsimilarityrule_textanalyticsentitymapping
    {
      get
      {
        return this.GetRelatedEntity<AdvancedSimilarityRule>(nameof (advancedsimilarityrule_textanalyticsentitymapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (advancedsimilarityrule_textanalyticsentitymapping));
        this.SetRelatedEntity<AdvancedSimilarityRule>(nameof (advancedsimilarityrule_textanalyticsentitymapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (advancedsimilarityrule_textanalyticsentitymapping));
      }
    }

    [AttributeLogicalName("knowledgesearchmodelid")]
    [RelationshipSchemaName("knowledgesearchmodel_textanalyticsentitymapping")]
    public KnowledgeSearchModel knowledgesearchmodel_textanalyticsentitymapping
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeSearchModel>(nameof (knowledgesearchmodel_textanalyticsentitymapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgesearchmodel_textanalyticsentitymapping));
        this.SetRelatedEntity<KnowledgeSearchModel>(nameof (knowledgesearchmodel_textanalyticsentitymapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgesearchmodel_textanalyticsentitymapping));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_textanalyticsentitymapping")]
    public Organization organization_textanalyticsentitymapping
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_textanalyticsentitymapping), new EntityRole?());
      }
    }

    public TextAnalyticsEntityMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["textanalyticsentitymappingid"] = (object) base.Id;
            break;
          case "textanalyticsentitymappingid":
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
