// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SdkMessageResponseField
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageresponsefield")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SdkMessageResponseField : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "sdkmessageresponsefield";
    public const string EntitySchemaName = "SdkMessageResponseField";
    public const string PrimaryIdAttribute = "sdkmessageresponsefieldid";

    public SdkMessageResponseField()
      : base("sdkmessageresponsefield")
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

    [AttributeLogicalName("clrformatter")]
    public string ClrFormatter
    {
      get => this.GetAttributeValue<string>("clrformatter");
      set
      {
        this.OnPropertyChanging(nameof (ClrFormatter));
        this.SetAttributeValue("clrformatter", (object) value);
        this.OnPropertyChanged(nameof (ClrFormatter));
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

    [AttributeLogicalName("formatter")]
    public string Formatter
    {
      get => this.GetAttributeValue<string>("formatter");
      set
      {
        this.OnPropertyChanging(nameof (Formatter));
        this.SetAttributeValue("formatter", (object) value);
        this.OnPropertyChanged(nameof (Formatter));
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

    [AttributeLogicalName("sdkmessageresponsefieldid")]
    public Guid? SdkMessageResponseFieldId
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageresponsefieldid");
      set
      {
        this.OnPropertyChanging(nameof (SdkMessageResponseFieldId));
        this.SetAttributeValue("sdkmessageresponsefieldid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SdkMessageResponseFieldId));
      }
    }

    [AttributeLogicalName("sdkmessageresponsefieldid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SdkMessageResponseFieldId = new Guid?(value);
    }

    [AttributeLogicalName("sdkmessageresponsefieldidunique")]
    public Guid? SdkMessageResponseFieldIdUnique
    {
      get => this.GetAttributeValue<Guid?>("sdkmessageresponsefieldidunique");
    }

    [AttributeLogicalName("sdkmessageresponseid")]
    public EntityReference SdkMessageResponseId
    {
      get => this.GetAttributeValue<EntityReference>("sdkmessageresponseid");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("value")]
    public string Value
    {
      get => this.GetAttributeValue<string>("value");
      set
      {
        this.OnPropertyChanging(nameof (Value));
        this.SetAttributeValue(nameof (value), (object) value);
        this.OnPropertyChanged(nameof (Value));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_sdkmessageresponsefield")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessageresponsefield), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageresponsefield));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_sdkmessageresponsefield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageresponsefield));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_sdkmessageresponsefield")]
    public SystemUser createdby_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_sdkmessageresponsefield), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageresponsefield_createdonbehalfby")]
    public SystemUser lk_sdkmessageresponsefield_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessageresponsefield_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessageresponsefield_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessageresponsefield_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessageresponsefield_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_sdkmessageresponsefield_modifiedonbehalfby")]
    public SystemUser lk_sdkmessageresponsefield_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_sdkmessageresponsefield_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_sdkmessageresponsefield_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_sdkmessageresponsefield_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_sdkmessageresponsefield_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("sdkmessageresponseid")]
    [RelationshipSchemaName("messageresponse_sdkmessageresponsefield")]
    public SdkMessageResponse messageresponse_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageResponse>(nameof (messageresponse_sdkmessageresponsefield), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_sdkmessageresponsefield")]
    public SystemUser modifiedby_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_sdkmessageresponsefield), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_sdkmessageresponsefield")]
    public Organization organization_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_sdkmessageresponsefield), new EntityRole?());
      }
    }

    public SdkMessageResponseField(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["sdkmessageresponsefieldid"] = (object) base.Id;
            break;
          case "sdkmessageresponsefieldid":
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
