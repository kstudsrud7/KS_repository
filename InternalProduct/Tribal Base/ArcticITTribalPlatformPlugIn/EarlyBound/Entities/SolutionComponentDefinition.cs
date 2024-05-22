// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SolutionComponentDefinition
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("solutioncomponentdefinition")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SolutionComponentDefinition : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "solutioncomponentdefinition";
    public const string EntitySchemaName = "SolutionComponentDefinition";
    public const string PrimaryIdAttribute = "solutioncomponentdefinitionid";
    public const string PrimaryNameAttribute = "name";

    public SolutionComponentDefinition()
      : base("solutioncomponentdefinition")
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

    [AttributeLogicalName("allowdeletebasesolutionrowandfakedelete")]
    public bool? AllowDeleteBaseSolutionRowAndFakeDelete
    {
      get => this.GetAttributeValue<bool?>("allowdeletebasesolutionrowandfakedelete");
      set
      {
        this.OnPropertyChanging(nameof (AllowDeleteBaseSolutionRowAndFakeDelete));
        this.SetAttributeValue("allowdeletebasesolutionrowandfakedelete", (object) value);
        this.OnPropertyChanged(nameof (AllowDeleteBaseSolutionRowAndFakeDelete));
      }
    }

    [AttributeLogicalName("allowoverwritecustomizations")]
    public bool? AllowOverwriteCustomizations
    {
      get => this.GetAttributeValue<bool?>("allowoverwritecustomizations");
      set
      {
        this.OnPropertyChanging(nameof (AllowOverwriteCustomizations));
        this.SetAttributeValue("allowoverwritecustomizations", (object) value);
        this.OnPropertyChanged(nameof (AllowOverwriteCustomizations));
      }
    }

    [AttributeLogicalName("allowrecreateforlogicallydeletedrow")]
    public bool? AllowRecreateForLogicallyDeletedRow
    {
      get => this.GetAttributeValue<bool?>("allowrecreateforlogicallydeletedrow");
      set
      {
        this.OnPropertyChanging(nameof (AllowRecreateForLogicallyDeletedRow));
        this.SetAttributeValue("allowrecreateforlogicallydeletedrow", (object) value);
        this.OnPropertyChanged(nameof (AllowRecreateForLogicallyDeletedRow));
      }
    }

    [AttributeLogicalName("alwaysremoveactivecustomizationsonuninstall")]
    public bool? AlwaysRemoveActiveCustomizationsOnUninstall
    {
      get => this.GetAttributeValue<bool?>("alwaysremoveactivecustomizationsonuninstall");
      set
      {
        this.OnPropertyChanging(nameof (AlwaysRemoveActiveCustomizationsOnUninstall));
        this.SetAttributeValue("alwaysremoveactivecustomizationsonuninstall", (object) value);
        this.OnPropertyChanged(nameof (AlwaysRemoveActiveCustomizationsOnUninstall));
      }
    }

    [AttributeLogicalName("canbeaddedtosolutioncomponents")]
    public bool? CanBeAddedToSolutionComponents
    {
      get => this.GetAttributeValue<bool?>("canbeaddedtosolutioncomponents");
      set
      {
        this.OnPropertyChanging(nameof (CanBeAddedToSolutionComponents));
        this.SetAttributeValue("canbeaddedtosolutioncomponents", (object) value);
        this.OnPropertyChanged(nameof (CanBeAddedToSolutionComponents));
      }
    }

    [AttributeLogicalName("canbehidden")]
    public bool? CanBeHidden
    {
      get => this.GetAttributeValue<bool?>("canbehidden");
      set
      {
        this.OnPropertyChanging(nameof (CanBeHidden));
        this.SetAttributeValue("canbehidden", (object) value);
        this.OnPropertyChanged(nameof (CanBeHidden));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("componentxpath")]
    public string ComponentXPath
    {
      get => this.GetAttributeValue<string>("componentxpath");
      set
      {
        this.OnPropertyChanging(nameof (ComponentXPath));
        this.SetAttributeValue("componentxpath", (object) value);
        this.OnPropertyChanged(nameof (ComponentXPath));
      }
    }

    [AttributeLogicalName("descendentisviewablecomponent")]
    public bool? DescendentIsViewableComponent
    {
      get => this.GetAttributeValue<bool?>("descendentisviewablecomponent");
      set
      {
        this.OnPropertyChanging(nameof (DescendentIsViewableComponent));
        this.SetAttributeValue("descendentisviewablecomponent", (object) value);
        this.OnPropertyChanged(nameof (DescendentIsViewableComponent));
      }
    }

    [AttributeLogicalName("groupparentcomponentattributename")]
    public string GroupParentComponentAttributeName
    {
      get => this.GetAttributeValue<string>("groupparentcomponentattributename");
      set
      {
        this.OnPropertyChanging(nameof (GroupParentComponentAttributeName));
        this.SetAttributeValue("groupparentcomponentattributename", (object) value);
        this.OnPropertyChanged(nameof (GroupParentComponentAttributeName));
      }
    }

    [AttributeLogicalName("groupparentcomponenttype")]
    public int? GroupParentComponentType
    {
      get => this.GetAttributeValue<int?>("groupparentcomponenttype");
      set
      {
        this.OnPropertyChanging(nameof (GroupParentComponentType));
        this.SetAttributeValue("groupparentcomponenttype", (object) value);
        this.OnPropertyChanged(nameof (GroupParentComponentType));
      }
    }

    [AttributeLogicalName("hasisrenameableattribute")]
    public bool? HasIsRenameableAttribute
    {
      get => this.GetAttributeValue<bool?>("hasisrenameableattribute");
      set
      {
        this.OnPropertyChanging(nameof (HasIsRenameableAttribute));
        this.SetAttributeValue("hasisrenameableattribute", (object) value);
        this.OnPropertyChanged(nameof (HasIsRenameableAttribute));
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

    [AttributeLogicalName("isdependencydisabled")]
    public bool? IsDependencyDisabled
    {
      get => this.GetAttributeValue<bool?>("isdependencydisabled");
      set
      {
        this.OnPropertyChanging(nameof (IsDependencyDisabled));
        this.SetAttributeValue("isdependencydisabled", (object) value);
        this.OnPropertyChanged(nameof (IsDependencyDisabled));
      }
    }

    [AttributeLogicalName("isdisplayable")]
    public bool? IsDisplayable
    {
      get => this.GetAttributeValue<bool?>("isdisplayable");
      set
      {
        this.OnPropertyChanging(nameof (IsDisplayable));
        this.SetAttributeValue("isdisplayable", (object) value);
        this.OnPropertyChanged(nameof (IsDisplayable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged
    {
      get => this.GetAttributeValue<bool?>("ismanaged");
      set
      {
        this.OnPropertyChanging(nameof (IsManaged));
        this.SetAttributeValue("ismanaged", (object) value);
        this.OnPropertyChanged(nameof (IsManaged));
      }
    }

    [AttributeLogicalName("ismergeable")]
    public bool? IsMergeable
    {
      get => this.GetAttributeValue<bool?>("ismergeable");
      set
      {
        this.OnPropertyChanging(nameof (IsMergeable));
        this.SetAttributeValue("ismergeable", (object) value);
        this.OnPropertyChanged(nameof (IsMergeable));
      }
    }

    [AttributeLogicalName("ismetadata")]
    public bool? IsMetadata
    {
      get => this.GetAttributeValue<bool?>("ismetadata");
      set
      {
        this.OnPropertyChanging(nameof (IsMetadata));
        this.SetAttributeValue("ismetadata", (object) value);
        this.OnPropertyChanged(nameof (IsMetadata));
      }
    }

    [AttributeLogicalName("isviewable")]
    public bool? IsViewable
    {
      get => this.GetAttributeValue<bool?>("isviewable");
      set
      {
        this.OnPropertyChanging(nameof (IsViewable));
        this.SetAttributeValue("isviewable", (object) value);
        this.OnPropertyChanged(nameof (IsViewable));
      }
    }

    [AttributeLogicalName("labeltypecode")]
    public int? LabelTypeCode
    {
      get => this.GetAttributeValue<int?>("labeltypecode");
      set
      {
        this.OnPropertyChanging(nameof (LabelTypeCode));
        this.SetAttributeValue("labeltypecode", (object) value);
        this.OnPropertyChanged(nameof (LabelTypeCode));
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
    public int? ObjectTypeCode
    {
      get => this.GetAttributeValue<int?>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
      }
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("parentattributename")]
    public string ParentAttributeName
    {
      get => this.GetAttributeValue<string>("parentattributename");
      set
      {
        this.OnPropertyChanging(nameof (ParentAttributeName));
        this.SetAttributeValue("parentattributename", (object) value);
        this.OnPropertyChanged(nameof (ParentAttributeName));
      }
    }

    [AttributeLogicalName("primaryentityname")]
    public string PrimaryEntityName
    {
      get => this.GetAttributeValue<string>("primaryentityname");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryEntityName));
        this.SetAttributeValue("primaryentityname", (object) value);
        this.OnPropertyChanged(nameof (PrimaryEntityName));
      }
    }

    [AttributeLogicalName("removeactivecustomizationsbehavior")]
    public OptionSetValue RemoveActiveCustomizationsBehavior
    {
      get => this.GetAttributeValue<OptionSetValue>("removeactivecustomizationsbehavior");
      set
      {
        this.OnPropertyChanging(nameof (RemoveActiveCustomizationsBehavior));
        this.SetAttributeValue("removeactivecustomizationsbehavior", (object) value);
        this.OnPropertyChanged(nameof (RemoveActiveCustomizationsBehavior));
      }
    }

    [AttributeLogicalName("rootattributename")]
    public string RootAttributeName
    {
      get => this.GetAttributeValue<string>("rootattributename");
      set
      {
        this.OnPropertyChanging(nameof (RootAttributeName));
        this.SetAttributeValue("rootattributename", (object) value);
        this.OnPropertyChanged(nameof (RootAttributeName));
      }
    }

    [AttributeLogicalName("rootcomponent")]
    public int? RootComponent
    {
      get => this.GetAttributeValue<int?>("rootcomponent");
      set
      {
        this.OnPropertyChanging(nameof (RootComponent));
        this.SetAttributeValue("rootcomponent", (object) value);
        this.OnPropertyChanged(nameof (RootComponent));
      }
    }

    [AttributeLogicalName("solutioncomponentdefinitionid")]
    public Guid? SolutionComponentDefinitionId
    {
      get => this.GetAttributeValue<Guid?>("solutioncomponentdefinitionid");
      set
      {
        this.OnPropertyChanging(nameof (SolutionComponentDefinitionId));
        this.SetAttributeValue("solutioncomponentdefinitionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SolutionComponentDefinitionId));
      }
    }

    [AttributeLogicalName("solutioncomponentdefinitionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SolutionComponentDefinitionId = new Guid?(value);
    }

    [AttributeLogicalName("solutioncomponentdefinitionidunique")]
    public Guid? SolutionComponentDefinitionIdUnique
    {
      get => this.GetAttributeValue<Guid?>("solutioncomponentdefinitionidunique");
    }

    [AttributeLogicalName("solutioncomponenttype")]
    public int? SolutionComponentType
    {
      get => this.GetAttributeValue<int?>("solutioncomponenttype");
      set
      {
        this.OnPropertyChanging(nameof (SolutionComponentType));
        this.SetAttributeValue("solutioncomponenttype", (object) value);
        this.OnPropertyChanged(nameof (SolutionComponentType));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("useforcedeleteforsolutionupdate")]
    public bool? UseForceDeleteForSolutionUpdate
    {
      get => this.GetAttributeValue<bool?>("useforcedeleteforsolutionupdate");
      set
      {
        this.OnPropertyChanging(nameof (UseForceDeleteForSolutionUpdate));
        this.SetAttributeValue("useforcedeleteforsolutionupdate", (object) value);
        this.OnPropertyChanged(nameof (UseForceDeleteForSolutionUpdate));
      }
    }

    [AttributeLogicalName("useforceupdatealways")]
    public bool? UseForceUpdateAlways
    {
      get => this.GetAttributeValue<bool?>("useforceupdatealways");
      set
      {
        this.OnPropertyChanging(nameof (UseForceUpdateAlways));
        this.SetAttributeValue("useforceupdatealways", (object) value);
        this.OnPropertyChanged(nameof (UseForceUpdateAlways));
      }
    }

    [AttributeLogicalName("usesentinelrowinbasesolution")]
    public bool? UseSentinelRowInBaseSolution
    {
      get => this.GetAttributeValue<bool?>("usesentinelrowinbasesolution");
      set
      {
        this.OnPropertyChanging(nameof (UseSentinelRowInBaseSolution));
        this.SetAttributeValue("usesentinelrowinbasesolution", (object) value);
        this.OnPropertyChanged(nameof (UseSentinelRowInBaseSolution));
      }
    }

    [AttributeLogicalName("viewabledescendentcomponenttype")]
    public int? ViewableDescendentComponentType
    {
      get => this.GetAttributeValue<int?>("viewabledescendentcomponenttype");
      set
      {
        this.OnPropertyChanging(nameof (ViewableDescendentComponentType));
        this.SetAttributeValue("viewabledescendentcomponenttype", (object) value);
        this.OnPropertyChanged(nameof (ViewableDescendentComponentType));
      }
    }

    public SolutionComponentDefinition(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["solutioncomponentdefinitionid"] = (object) base.Id;
            break;
          case "solutioncomponentdefinitionid":
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
