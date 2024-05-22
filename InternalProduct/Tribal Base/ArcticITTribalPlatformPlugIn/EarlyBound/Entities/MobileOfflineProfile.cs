// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.MobileOfflineProfile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mobileofflineprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class MobileOfflineProfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mobileofflineprofile";
    public const string EntitySchemaName = "MobileOfflineProfile";
    public const string PrimaryIdAttribute = "mobileofflineprofileid";
    public const string PrimaryNameAttribute = "name";

    public MobileOfflineProfile()
      : base("mobileofflineprofile")
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

    [AttributeLogicalName("isvalidated")]
    public bool? IsValidated => this.GetAttributeValue<bool?>("isvalidated");

    [AttributeLogicalName("mobileofflineprofileid")]
    public Guid? MobileOfflineProfileId
    {
      get => this.GetAttributeValue<Guid?>("mobileofflineprofileid");
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfileId));
        this.SetAttributeValue("mobileofflineprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (MobileOfflineProfileId));
      }
    }

    [AttributeLogicalName("mobileofflineprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.MobileOfflineProfileId = new Guid?(value);
    }

    [AttributeLogicalName("mobileofflineprofileidunique")]
    public Guid? MobileOfflineProfileIdUnique
    {
      get => this.GetAttributeValue<Guid?>("mobileofflineprofileidunique");
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("processid")]
    public Guid? ProcessId
    {
      get => this.GetAttributeValue<Guid?>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("publishedon")]
    public DateTime? PublishedOn => this.GetAttributeValue<DateTime?>("publishedon");

    [AttributeLogicalName("selectedentitymetadata")]
    public string SelectedEntityMetadata
    {
      get => this.GetAttributeValue<string>("selectedentitymetadata");
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("stageid")]
    public Guid? StageId
    {
      get => this.GetAttributeValue<Guid?>("stageid");
      set
      {
        this.OnPropertyChanging(nameof (StageId));
        this.SetAttributeValue("stageid", (object) value);
        this.OnPropertyChanged(nameof (StageId));
      }
    }

    [AttributeLogicalName("traversedpath")]
    public string TraversedPath
    {
      get => this.GetAttributeValue<string>("traversedpath");
      set
      {
        this.OnPropertyChanging(nameof (TraversedPath));
        this.SetAttributeValue("traversedpath", (object) value);
        this.OnPropertyChanged(nameof (TraversedPath));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("DefaultMobileOfflineProfile_Organization")]
    public IEnumerable<Organization> DefaultMobileOfflineProfile_Organization
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (DefaultMobileOfflineProfile_Organization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DefaultMobileOfflineProfile_Organization));
        this.SetRelatedEntities<Organization>(nameof (DefaultMobileOfflineProfile_Organization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DefaultMobileOfflineProfile_Organization));
      }
    }

    [RelationshipSchemaName("MobileOfflineProfile_MobileOfflineProfileItem")]
    public IEnumerable<MobileOfflineProfileItem> MobileOfflineProfile_MobileOfflineProfileItem
    {
      get
      {
        return this.GetRelatedEntities<MobileOfflineProfileItem>(nameof (MobileOfflineProfile_MobileOfflineProfileItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfile_MobileOfflineProfileItem));
        this.SetRelatedEntities<MobileOfflineProfileItem>(nameof (MobileOfflineProfile_MobileOfflineProfileItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MobileOfflineProfile_MobileOfflineProfileItem));
      }
    }

    [RelationshipSchemaName("MobileOfflineProfile_SystemUser")]
    public IEnumerable<SystemUser> MobileOfflineProfile_SystemUser
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (MobileOfflineProfile_SystemUser), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfile_SystemUser));
        this.SetRelatedEntities<SystemUser>(nameof (MobileOfflineProfile_SystemUser), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MobileOfflineProfile_SystemUser));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_MobileOfflineProfile_createdby")]
    public SystemUser lk_MobileOfflineProfile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_MobileOfflineProfile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_MobileOfflineProfile_createdonbehalfby")]
    public SystemUser lk_MobileOfflineProfile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_MobileOfflineProfile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_MobileOfflineProfile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_MobileOfflineProfile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_MobileOfflineProfile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_MobileOfflineProfile_modifiedby")]
    public SystemUser lk_MobileOfflineProfile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_MobileOfflineProfile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_MobileOfflineProfile_modifiedonbehalfby")]
    public SystemUser lk_MobileOfflineProfile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_MobileOfflineProfile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_MobileOfflineProfile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_MobileOfflineProfile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_MobileOfflineProfile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("MobileOfflineProfile_organization")]
    public Organization MobileOfflineProfile_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (MobileOfflineProfile_organization), new EntityRole?());
      }
    }

    public MobileOfflineProfile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mobileofflineprofileid"] = (object) base.Id;
            break;
          case "mobileofflineprofileid":
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
