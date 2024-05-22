// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.MobileOfflineProfileItemAssociation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mobileofflineprofileitemassociation")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class MobileOfflineProfileItemAssociation : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mobileofflineprofileitemassociation";
    public const string EntitySchemaName = "MobileOfflineProfileItemAssociation";
    public const string PrimaryIdAttribute = "mobileofflineprofileitemassociationid";
    public const string PrimaryNameAttribute = "name";

    public MobileOfflineProfileItemAssociation()
      : base("mobileofflineprofileitemassociation")
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

    [AttributeLogicalName("mobileofflineprofileitemassociationid")]
    public Guid? MobileOfflineProfileItemAssociationId
    {
      get => this.GetAttributeValue<Guid?>("mobileofflineprofileitemassociationid");
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfileItemAssociationId));
        this.SetAttributeValue("mobileofflineprofileitemassociationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (MobileOfflineProfileItemAssociationId));
      }
    }

    [AttributeLogicalName("mobileofflineprofileitemassociationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.MobileOfflineProfileItemAssociationId = new Guid?(value);
    }

    [AttributeLogicalName("mobileofflineprofileitemassociationidunique")]
    public Guid? MobileOfflineProfileItemAssociationIdUnique
    {
      get => this.GetAttributeValue<Guid?>("mobileofflineprofileitemassociationidunique");
    }

    [AttributeLogicalName("mobileofflineprofileitemid")]
    public EntityReference MobileOfflineProfileItemId
    {
      get => this.GetAttributeValue<EntityReference>("mobileofflineprofileitemid");
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfileItemId));
        this.SetAttributeValue("mobileofflineprofileitemid", (object) value);
        this.OnPropertyChanged(nameof (MobileOfflineProfileItemId));
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

    [AttributeLogicalName("profileitemassociationentityfilter")]
    public string ProfileItemAssociationEntityFilter
    {
      get => this.GetAttributeValue<string>("profileitemassociationentityfilter");
      set
      {
        this.OnPropertyChanging(nameof (ProfileItemAssociationEntityFilter));
        this.SetAttributeValue("profileitemassociationentityfilter", (object) value);
        this.OnPropertyChanged(nameof (ProfileItemAssociationEntityFilter));
      }
    }

    [AttributeLogicalName("publishedon")]
    public DateTime? PublishedOn => this.GetAttributeValue<DateTime?>("publishedon");

    [AttributeLogicalName("relationshipdata")]
    public string RelationshipData
    {
      get => this.GetAttributeValue<string>("relationshipdata");
      set
      {
        this.OnPropertyChanging(nameof (RelationshipData));
        this.SetAttributeValue("relationshipdata", (object) value);
        this.OnPropertyChanged(nameof (RelationshipData));
      }
    }

    [AttributeLogicalName("relationshipdisplayname")]
    public string RelationshipDisplayName
    {
      get => this.GetAttributeValue<string>("relationshipdisplayname");
      set
      {
        this.OnPropertyChanging(nameof (RelationshipDisplayName));
        this.SetAttributeValue("relationshipdisplayname", (object) value);
        this.OnPropertyChanged(nameof (RelationshipDisplayName));
      }
    }

    [AttributeLogicalName("relationshipid")]
    public Guid? RelationshipId
    {
      get => this.GetAttributeValue<Guid?>("relationshipid");
      set
      {
        this.OnPropertyChanging(nameof (RelationshipId));
        this.SetAttributeValue("relationshipid", (object) value);
        this.OnPropertyChanged(nameof (RelationshipId));
      }
    }

    [AttributeLogicalName("relationshipname")]
    public string RelationshipName => this.GetAttributeValue<string>("relationshipname");

    [AttributeLogicalName("selectedrelationshipsschema")]
    public OptionSetValue SelectedRelationShipsSchema
    {
      get => this.GetAttributeValue<OptionSetValue>("selectedrelationshipsschema");
      set
      {
        this.OnPropertyChanging(nameof (SelectedRelationShipsSchema));
        this.SetAttributeValue("selectedrelationshipsschema", (object) value);
        this.OnPropertyChanged(nameof (SelectedRelationShipsSchema));
      }
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

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_MobileOfflineProfileItemAssociation_createdby")]
    public SystemUser lk_MobileOfflineProfileItemAssociation_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_MobileOfflineProfileItemAssociation_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_mobileofflineprofileitemassociation_createdonbehalfby")]
    public SystemUser lk_mobileofflineprofileitemassociation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitemassociation_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mobileofflineprofileitemassociation_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitemassociation_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mobileofflineprofileitemassociation_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_mobileofflineprofileitemassociation_modifiedby")]
    public SystemUser lk_mobileofflineprofileitemassociation_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitemassociation_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_mobileofflineprofileitemassociation_modifiedonbehalfby")]
    public SystemUser lk_mobileofflineprofileitemassociation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitemassociation_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mobileofflineprofileitemassociation_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitemassociation_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mobileofflineprofileitemassociation_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("mobileofflineprofileitemid")]
    [RelationshipSchemaName("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation")]
    public MobileOfflineProfileItem MobileOfflineProfileItem_MobileOfflineProfileItemAssociation
    {
      get
      {
        return this.GetRelatedEntity<MobileOfflineProfileItem>(nameof (MobileOfflineProfileItem_MobileOfflineProfileItemAssociation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfileItem_MobileOfflineProfileItemAssociation));
        this.SetRelatedEntity<MobileOfflineProfileItem>(nameof (MobileOfflineProfileItem_MobileOfflineProfileItemAssociation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MobileOfflineProfileItem_MobileOfflineProfileItemAssociation));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("MobileOfflineProfileItemAssociation_organization")]
    public Organization MobileOfflineProfileItemAssociation_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (MobileOfflineProfileItemAssociation_organization), new EntityRole?());
      }
    }

    public MobileOfflineProfileItemAssociation(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mobileofflineprofileitemassociationid"] = (object) base.Id;
            break;
          case "mobileofflineprofileitemassociationid":
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
