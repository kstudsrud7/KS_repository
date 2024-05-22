// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessageRequestField
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagerequestfield")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessageRequestField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessagerequestfield";
    public const string EntitySchemaName = "SdkMessageRequestField";
    public const string PrimaryIdAttribute = "sdkmessagerequestfieldid";

    public SdkMessageRequestField()
      : base("sdkmessagerequestfield")
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

    [AttributeLogicalName("clrparser")]
    public string ClrParser
    {
      get => this.GetAttributeValue<string>("clrparser");
      set
      {
        this.OnPropertyChanging(nameof (ClrParser));
        this.SetAttributeValue("clrparser", (object) value);
        this.OnPropertyChanged(nameof (ClrParser));
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

    [AttributeLogicalName("customizationlevel")]
    public int? CustomizationLevel => this.GetAttributeValue<int?>("customizationlevel");

    [AttributeLogicalName("fieldmask")]
    public int? FieldMask => this.GetAttributeValue<int?>("fieldmask");

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

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("optional")]
    public bool? Optional
    {
      get => this.GetAttributeValue<bool?>("optional");
      set
      {
        this.OnPropertyChanging(nameof (Optional));
        this.SetAttributeValue("optional", (object) value);
        this.OnPropertyChanged(nameof (Optional));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("parameterbindinginformation")]
    public string ParameterBindingInformation
    {
      get => this.GetAttributeValue<string>("parameterbindinginformation");
      set
      {
        this.OnPropertyChanging(nameof (ParameterBindingInformation));
        this.SetAttributeValue("parameterbindinginformation", (object) value);
        this.OnPropertyChanged(nameof (ParameterBindingInformation));
      }
    }

    [AttributeLogicalName("parser")]
    public string Parser
    {
      get => this.GetAttributeValue<string>("parser");
      set
      {
        this.OnPropertyChanging(nameof (Parser));
        this.SetAttributeValue("parser", (object) value);
        this.OnPropertyChanged(nameof (Parser));
      }
    }

    [AttributeLogicalName("position")]
    public int? Position => this.GetAttributeValue<int?>("position");

    [AttributeLogicalName("publicname")]
    public string PublicName
    {
      get => this.GetAttributeValue<string>("publicname");
      set
      {
        this.OnPropertyChanging(nameof (PublicName));
        this.SetAttributeValue("publicname", (object) value);
        this.OnPropertyChanged(nameof (PublicName));
      }
    }

    [AttributeLogicalName("sdkmessagerequestfieldid")]
    public Guid? SdkMessageRequestFieldId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessagerequestfieldid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageRequestFieldId));
        this.SetAttributeValue("sdkmessagerequestfieldid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessageRequestFieldId));
      }
    }

    [AttributeLogicalName("sdkmessagerequestfieldid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessageRequestFieldId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessagerequestfieldidunique")]
    public Guid? SdkMessageRequestFieldIdUnique
    {
      get => this.GetAttributeValue<Guid?>("sdkmessagerequestfieldidunique");
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    public EntityReference SdkMessageRequestId
    {
      get => this.GetAttributeValue<EntityReference>("sdkmessagerequestid");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_sdkmessagerequestfield")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessagerequestfield), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessagerequestfield));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessagerequestfield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessagerequestfield));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessagerequestfield")]
    public SystemUser createdby_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessagerequestfield), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagerequestfield_createdonbehalfby")]
    public SystemUser lk_sdkmessagerequestfield_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessagerequestfield_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessagerequestfield_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessagerequestfield_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessagerequestfield_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessagerequestfield_modifiedonbehalfby")]
    public SystemUser lk_sdkmessagerequestfield_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessagerequestfield_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessagerequestfield_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessagerequestfield_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessagerequestfield_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("sdkmessagerequestid")]
    [RelationshipSchemaName("messagerequest_sdkmessagerequestfield")]
    public SdkMessageRequest messagerequest_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageRequest>(nameof (messagerequest_sdkmessagerequestfield), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessagerequestfield")]
    public SystemUser modifiedby_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessagerequestfield), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessagerequestfield")]
    public Organization organization_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessagerequestfield), new EntityRole?());
      }
    }

    public SdkMessageRequestField(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessagerequestfieldid"] = (object) base.Id;
            break;
          case "sdkmessagerequestfieldid":
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
