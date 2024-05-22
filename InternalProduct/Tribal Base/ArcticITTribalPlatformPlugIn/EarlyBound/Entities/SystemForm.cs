// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SystemForm
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("systemform")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SystemForm : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "systemform";
    public const string EntitySchemaName = "SystemForm";
    public const string PrimaryIdAttribute = "formid";
    public const string PrimaryNameAttribute = "name";

    public SystemForm()
      : base("systemform")
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

    [AttributeLogicalName("ancestorformid")]
    public EntityReference AncestorFormId
    {
      get => this.GetAttributeValue<EntityReference>("ancestorformid");
      set
      {
        this.OnPropertyChanging(nameof (AncestorFormId));
        this.SetAttributeValue("ancestorformid", (object) value);
        this.OnPropertyChanged(nameof (AncestorFormId));
      }
    }

    [AttributeLogicalName("canbedeleted")]
    public BooleanManagedProperty CanBeDeleted
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("canbedeleted");
      set
      {
        this.OnPropertyChanging(nameof (CanBeDeleted));
        this.SetAttributeValue("canbedeleted", (object) value);
        this.OnPropertyChanged(nameof (CanBeDeleted));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("formactivationstate")]
    public OptionSetValue FormActivationState
    {
      get => this.GetAttributeValue<OptionSetValue>("formactivationstate");
      set
      {
        this.OnPropertyChanging(nameof (FormActivationState));
        this.SetAttributeValue("formactivationstate", (object) value);
        this.OnPropertyChanged(nameof (FormActivationState));
      }
    }

    [AttributeLogicalName("formid")]
    public Guid? FormId
    {
      get => this.GetAttributeValue<Guid?>("formid");
      set
      {
        this.OnPropertyChanging(nameof (FormId));
        this.SetAttributeValue("formid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (FormId));
      }
    }

    [AttributeLogicalName("formid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.FormId = new Guid?(value);
    }

    [AttributeLogicalName("formidunique")]
    public Guid? FormIdUnique => this.GetAttributeValue<Guid?>("formidunique");

    [AttributeLogicalName("formjson")]
    public string FormJson
    {
      get => this.GetAttributeValue<string>("formjson");
      set
      {
        this.OnPropertyChanging(nameof (FormJson));
        this.SetAttributeValue("formjson", (object) value);
        this.OnPropertyChanged(nameof (FormJson));
      }
    }

    [AttributeLogicalName("formpresentation")]
    public OptionSetValue FormPresentation
    {
      get => this.GetAttributeValue<OptionSetValue>("formpresentation");
      set
      {
        this.OnPropertyChanging(nameof (FormPresentation));
        this.SetAttributeValue("formpresentation", (object) value);
        this.OnPropertyChanged(nameof (FormPresentation));
      }
    }

    [AttributeLogicalName("formxml")]
    public string FormXml
    {
      get => this.GetAttributeValue<string>("formxml");
      set
      {
        this.OnPropertyChanging(nameof (FormXml));
        this.SetAttributeValue("formxml", (object) value);
        this.OnPropertyChanged(nameof (FormXml));
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

    [AttributeLogicalName("isairmerged")]
    public bool? IsAIRMerged
    {
      get => this.GetAttributeValue<bool?>("isairmerged");
      set
      {
        this.OnPropertyChanging(nameof (IsAIRMerged));
        this.SetAttributeValue("isairmerged", (object) value);
        this.OnPropertyChanged(nameof (IsAIRMerged));
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

    [AttributeLogicalName("isdefault")]
    public bool? IsDefault
    {
      get => this.GetAttributeValue<bool?>("isdefault");
      set
      {
        this.OnPropertyChanging(nameof (IsDefault));
        this.SetAttributeValue("isdefault", (object) value);
        this.OnPropertyChanged(nameof (IsDefault));
      }
    }

    [AttributeLogicalName("isdesktopenabled")]
    public bool? IsDesktopEnabled
    {
      get => this.GetAttributeValue<bool?>("isdesktopenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsDesktopEnabled));
        this.SetAttributeValue("isdesktopenabled", (object) value);
        this.OnPropertyChanged(nameof (IsDesktopEnabled));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("istabletenabled")]
    public bool? IsTabletEnabled
    {
      get => this.GetAttributeValue<bool?>("istabletenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsTabletEnabled));
        this.SetAttributeValue("istabletenabled", (object) value);
        this.OnPropertyChanged(nameof (IsTabletEnabled));
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

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("publishedon")]
    public DateTime? PublishedOn => this.GetAttributeValue<DateTime?>("publishedon");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get => this.GetAttributeValue<OptionSetValue>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
      }
    }

    [AttributeLogicalName("uniquename")]
    public string UniqueName
    {
      get => this.GetAttributeValue<string>("uniquename");
      set
      {
        this.OnPropertyChanging(nameof (UniqueName));
        this.SetAttributeValue("uniquename", (object) value);
        this.OnPropertyChanged(nameof (UniqueName));
      }
    }

    [AttributeLogicalName("version")]
    public int? Version
    {
      get => this.GetAttributeValue<int?>("version");
      set
      {
        this.OnPropertyChanging(nameof (Version));
        this.SetAttributeValue("version", (object) value);
        this.OnPropertyChanged(nameof (Version));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName]
    public IEnumerable<SystemForm> Referencedform_ancestor_form
    {
      get
      {
        return this.GetRelatedEntities<SystemForm>("form_ancestor_form", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedform_ancestor_form));
        this.SetRelatedEntities<SystemForm>("form_ancestor_form", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedform_ancestor_form));
      }
    }

    [RelationshipSchemaName("processtrigger_systemform")]
    public IEnumerable<ProcessTrigger> processtrigger_systemform
    {
      get
      {
        return this.GetRelatedEntities<ProcessTrigger>(nameof (processtrigger_systemform), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processtrigger_systemform));
        this.SetRelatedEntities<ProcessTrigger>(nameof (processtrigger_systemform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processtrigger_systemform));
      }
    }

    [RelationshipSchemaName("socialinsightsconfiguration_systemform")]
    public IEnumerable<SocialInsightsConfiguration> socialinsightsconfiguration_systemform
    {
      get
      {
        return this.GetRelatedEntities<SocialInsightsConfiguration>(nameof (socialinsightsconfiguration_systemform), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialinsightsconfiguration_systemform));
        this.SetRelatedEntities<SocialInsightsConfiguration>(nameof (socialinsightsconfiguration_systemform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialinsightsconfiguration_systemform));
      }
    }

    [RelationshipSchemaName("SystemForm_AsyncOperations")]
    public IEnumerable<AsyncOperation> SystemForm_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (SystemForm_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SystemForm_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (SystemForm_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SystemForm_AsyncOperations));
      }
    }

    [RelationshipSchemaName("SystemForm_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> SystemForm_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (SystemForm_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SystemForm_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (SystemForm_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SystemForm_BulkDeleteFailures));
      }
    }

    [AttributeLogicalName("ancestorformid")]
    [RelationshipSchemaName]
    public SystemForm Referencingform_ancestor_form
    {
      get
      {
        return this.GetRelatedEntity<SystemForm>("form_ancestor_form", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingform_ancestor_form));
        this.SetRelatedEntity<SystemForm>("form_ancestor_form", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingform_ancestor_form));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_systemforms")]
    public Organization organization_systemforms
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_systemforms), new EntityRole?());
      }
    }

    public SystemForm(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["formid"] = (object) base.Id;
            break;
          case "formid":
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
