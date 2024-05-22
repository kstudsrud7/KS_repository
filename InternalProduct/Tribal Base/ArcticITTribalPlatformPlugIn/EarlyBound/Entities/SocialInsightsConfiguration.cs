// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SocialInsightsConfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("socialinsightsconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SocialInsightsConfiguration : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "socialinsightsconfiguration";
    public const string EntitySchemaName = "SocialInsightsConfiguration";
    public const string PrimaryIdAttribute = "socialinsightsconfigurationid";

    public SocialInsightsConfiguration()
      : base("socialinsightsconfiguration")
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

    [AttributeLogicalName("controlid")]
    public string ControlId
    {
      get => this.GetAttributeValue<string>("controlid");
      set
      {
        this.OnPropertyChanging(nameof (ControlId));
        this.SetAttributeValue("controlid", (object) value);
        this.OnPropertyChanged(nameof (ControlId));
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

    [AttributeLogicalName("formid")]
    public EntityReference FormId
    {
      get => this.GetAttributeValue<EntityReference>("formid");
      set
      {
        this.OnPropertyChanging(nameof (FormId));
        this.SetAttributeValue("formid", (object) value);
        this.OnPropertyChanged(nameof (FormId));
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

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("socialdataitemid")]
    public string SocialDataItemId
    {
      get => this.GetAttributeValue<string>("socialdataitemid");
      set
      {
        this.OnPropertyChanging(nameof (SocialDataItemId));
        this.SetAttributeValue("socialdataitemid", (object) value);
        this.OnPropertyChanged(nameof (SocialDataItemId));
      }
    }

    [AttributeLogicalName("socialdataitemtype")]
    public OptionSetValue SocialDataItemType
    {
      get => this.GetAttributeValue<OptionSetValue>("socialdataitemtype");
      set
      {
        this.OnPropertyChanging(nameof (SocialDataItemType));
        this.SetAttributeValue("socialdataitemtype", (object) value);
        this.OnPropertyChanged(nameof (SocialDataItemType));
      }
    }

    [AttributeLogicalName("socialdataparameters")]
    public string SocialDataParameters
    {
      get => this.GetAttributeValue<string>("socialdataparameters");
      set
      {
        this.OnPropertyChanging(nameof (SocialDataParameters));
        this.SetAttributeValue("socialdataparameters", (object) value);
        this.OnPropertyChanged(nameof (SocialDataParameters));
      }
    }

    [AttributeLogicalName("socialinsightsconfigurationid")]
    public Guid? SocialInsightsConfigurationId
    {
      get => this.GetAttributeValue<Guid?>("socialinsightsconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (SocialInsightsConfigurationId));
        this.SetAttributeValue("socialinsightsconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SocialInsightsConfigurationId));
      }
    }

    [AttributeLogicalName("socialinsightsconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SocialInsightsConfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_socialinsightsconfiguration_createdby")]
    public SystemUser lk_socialinsightsconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_socialinsightsconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_socialinsightsconfiguration_createdonbehalfby")]
    public SystemUser lk_socialinsightsconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_socialinsightsconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_socialinsightsconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_socialinsightsconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_socialinsightsconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_socialinsightsconfiguration_modifiedby")]
    public SystemUser lk_socialinsightsconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_socialinsightsconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_socialinsightsconfiguration_modifiedonbehalfby")]
    public SystemUser lk_socialinsightsconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_socialinsightsconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_socialinsightsconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_socialinsightsconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_socialinsightsconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_socialinsightsconfiguration")]
    public Organization organization_socialinsightsconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_socialinsightsconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("formid")]
    [RelationshipSchemaName("socialinsightsconfiguration_systemform")]
    public SystemForm socialinsightsconfiguration_systemform
    {
      get
      {
        return this.GetRelatedEntity<SystemForm>(nameof (socialinsightsconfiguration_systemform), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialinsightsconfiguration_systemform));
        this.SetRelatedEntity<SystemForm>(nameof (socialinsightsconfiguration_systemform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialinsightsconfiguration_systemform));
      }
    }

    [AttributeLogicalName("formid")]
    [RelationshipSchemaName("socialinsightsconfiguration_userform")]
    public UserForm socialinsightsconfiguration_userform
    {
      get
      {
        return this.GetRelatedEntity<UserForm>(nameof (socialinsightsconfiguration_userform), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialinsightsconfiguration_userform));
        this.SetRelatedEntity<UserForm>(nameof (socialinsightsconfiguration_userform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialinsightsconfiguration_userform));
      }
    }

    public SocialInsightsConfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["socialinsightsconfigurationid"] = (object) base.Id;
            break;
          case "socialinsightsconfigurationid":
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
