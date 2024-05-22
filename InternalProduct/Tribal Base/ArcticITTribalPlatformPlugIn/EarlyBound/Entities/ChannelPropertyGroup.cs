// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ChannelPropertyGroup
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("channelpropertygroup")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ChannelPropertyGroup : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "channelpropertygroup";
    public const string EntitySchemaName = "ChannelPropertyGroup";
    public const string PrimaryIdAttribute = "channelpropertygroupid";
    public const string PrimaryNameAttribute = "name";

    public ChannelPropertyGroup()
      : base("channelpropertygroup")
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

    [AttributeLogicalName("channelpropertygroupid")]
    public Guid? ChannelPropertyGroupId
    {
      get => this.GetAttributeValue<Guid?>("channelpropertygroupid");
      set
      {
        this.OnPropertyChanging(nameof (ChannelPropertyGroupId));
        this.SetAttributeValue("channelpropertygroupid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ChannelPropertyGroupId));
      }
    }

    [AttributeLogicalName("channelpropertygroupid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ChannelPropertyGroupId = new Guid?(value);
    }

    [AttributeLogicalName("channelpropertygroupidunique")]
    public Guid? ChannelPropertyGroupIdUnique
    {
      get => this.GetAttributeValue<Guid?>("channelpropertygroupidunique");
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

    [AttributeLogicalName("regardingtypecode")]
    public OptionSetValue RegardingTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("regardingtypecode");
      set
      {
        this.OnPropertyChanging(nameof (RegardingTypeCode));
        this.SetAttributeValue("regardingtypecode", (object) value);
        this.OnPropertyChanged(nameof (RegardingTypeCode));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public ChannelPropertyGroupState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ChannelPropertyGroupState?((ChannelPropertyGroupState) Enum.ToObject(typeof (ChannelPropertyGroupState), attributeValue.Value)) : new ChannelPropertyGroupState?();
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ChannelPropertyGroup_ChannelProperty")]
    public IEnumerable<ChannelProperty> ChannelPropertyGroup_ChannelProperty
    {
      get
      {
        return this.GetRelatedEntities<ChannelProperty>(nameof (ChannelPropertyGroup_ChannelProperty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelPropertyGroup_ChannelProperty));
        this.SetRelatedEntities<ChannelProperty>(nameof (ChannelPropertyGroup_ChannelProperty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelPropertyGroup_ChannelProperty));
      }
    }

    [RelationshipSchemaName("channelpropertygroup_convertrule")]
    public IEnumerable<ConvertRule> channelpropertygroup_convertrule
    {
      get
      {
        return this.GetRelatedEntities<ConvertRule>(nameof (channelpropertygroup_convertrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelpropertygroup_convertrule));
        this.SetRelatedEntities<ConvertRule>(nameof (channelpropertygroup_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelpropertygroup_convertrule));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("channelpropertygroup_organization")]
    public Organization channelpropertygroup_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (channelpropertygroup_organization), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ChannelPropertyGroup_createdby")]
    public SystemUser lk_ChannelPropertyGroup_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ChannelPropertyGroup_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ChannelPropertyGroup_createdonbehalfby")]
    public SystemUser lk_ChannelPropertyGroup_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ChannelPropertyGroup_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ChannelPropertyGroup_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ChannelPropertyGroup_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ChannelPropertyGroup_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ChannelPropertyGroup_modifiedby")]
    public SystemUser lk_ChannelPropertyGroup_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ChannelPropertyGroup_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ChannelPropertyGroup_modifiedonbehalfby")]
    public SystemUser lk_ChannelPropertyGroup_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ChannelPropertyGroup_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ChannelPropertyGroup_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ChannelPropertyGroup_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ChannelPropertyGroup_modifiedonbehalfby));
      }
    }

    public ChannelPropertyGroup(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["channelpropertygroupid"] = (object) base.Id;
            break;
          case "channelpropertygroupid":
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
