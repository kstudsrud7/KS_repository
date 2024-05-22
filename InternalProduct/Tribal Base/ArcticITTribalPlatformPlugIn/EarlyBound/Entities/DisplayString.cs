// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.DisplayString
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("displaystring")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class DisplayString : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "displaystring";
    public const string EntitySchemaName = "DisplayString";
    public const string PrimaryIdAttribute = "displaystringid";

    public DisplayString()
      : base("displaystring")
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

    [AttributeLogicalName("customcomment")]
    public string CustomComment
    {
      get => this.GetAttributeValue<string>("customcomment");
      set
      {
        this.OnPropertyChanging(nameof (CustomComment));
        this.SetAttributeValue("customcomment", (object) value);
        this.OnPropertyChanged(nameof (CustomComment));
      }
    }

    [AttributeLogicalName("customdisplaystring")]
    public string CustomDisplayString
    {
      get => this.GetAttributeValue<string>("customdisplaystring");
      set
      {
        this.OnPropertyChanging(nameof (CustomDisplayString));
        this.SetAttributeValue("customdisplaystring", (object) value);
        this.OnPropertyChanged(nameof (CustomDisplayString));
      }
    }

    [AttributeLogicalName("displaystringid")]
    public Guid? DisplayStringId
    {
      get => this.GetAttributeValue<Guid?>("displaystringid");
      set
      {
        this.OnPropertyChanging(nameof (DisplayStringId));
        this.SetAttributeValue("displaystringid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (DisplayStringId));
      }
    }

    [AttributeLogicalName("displaystringid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.DisplayStringId = new Guid?(value);
    }

    [AttributeLogicalName("displaystringidunique")]
    public Guid? DisplayStringIdUnique => this.GetAttributeValue<Guid?>("displaystringidunique");

    [AttributeLogicalName("displaystringkey")]
    public string DisplayStringKey => this.GetAttributeValue<string>("displaystringkey");

    [AttributeLogicalName("formatparameters")]
    public int? FormatParameters => this.GetAttributeValue<int?>("formatparameters");

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get => this.GetAttributeValue<int?>("languagecode");
      set
      {
        this.OnPropertyChanging(nameof (LanguageCode));
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged(nameof (LanguageCode));
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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("publisheddisplaystring")]
    public string PublishedDisplayString
    {
      get => this.GetAttributeValue<string>("publisheddisplaystring");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("DisplayString_AsyncOperations")]
    public IEnumerable<AsyncOperation> DisplayString_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (DisplayString_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DisplayString_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (DisplayString_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DisplayString_AsyncOperations));
      }
    }

    [RelationshipSchemaName("DisplayString_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> DisplayString_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (DisplayString_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DisplayString_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (DisplayString_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DisplayString_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_displaystring")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_displaystring
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_displaystring), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_displaystring));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_displaystring), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_displaystring));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_DisplayStringbase_createdby")]
    public SystemUser lk_DisplayStringbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_DisplayStringbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_DisplayStringbase_createdonbehalfby")]
    public SystemUser lk_DisplayStringbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_DisplayStringbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_DisplayStringbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_DisplayStringbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_DisplayStringbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_DisplayStringbase_modifiedby")]
    public SystemUser lk_DisplayStringbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_DisplayStringbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_DisplayStringbase_modifiedonbehalfby")]
    public SystemUser lk_DisplayStringbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_DisplayStringbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_DisplayStringbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_DisplayStringbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_DisplayStringbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_custom_displaystrings")]
    public Organization organization_custom_displaystrings
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_custom_displaystrings), new EntityRole?());
      }
    }

    public DisplayString(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["displaystringid"] = (object) base.Id;
            break;
          case "displaystringid":
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
