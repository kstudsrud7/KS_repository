// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.MobileOfflineProfileItem
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mobileofflineprofileitem")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class MobileOfflineProfileItem : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mobileofflineprofileitem";
    public const string EntitySchemaName = "MobileOfflineProfileItem";
    public const string PrimaryIdAttribute = "mobileofflineprofileitemid";
    public const string PrimaryNameAttribute = "name";

    public MobileOfflineProfileItem()
      : base("mobileofflineprofileitem")
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

    [AttributeLogicalName("canbefollowed")]
    [Obsolete]
    public bool? CanBeFollowed
    {
      get => this.GetAttributeValue<bool?>("canbefollowed");
      set
      {
        this.OnPropertyChanging(nameof (CanBeFollowed));
        this.SetAttributeValue("canbefollowed", (object) value);
        this.OnPropertyChanged(nameof (CanBeFollowed));
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

    [AttributeLogicalName("entityobjecttypecode")]
    public int? EntityObjectTypeCode => this.GetAttributeValue<int?>("entityobjecttypecode");

    [AttributeLogicalName("getrelatedentityrecords")]
    [Obsolete]
    public bool? GetRelatedEntityRecords
    {
      get => this.GetAttributeValue<bool?>("getrelatedentityrecords");
      set
      {
        this.OnPropertyChanging(nameof (GetRelatedEntityRecords));
        this.SetAttributeValue("getrelatedentityrecords", (object) value);
        this.OnPropertyChanged(nameof (GetRelatedEntityRecords));
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

    [AttributeLogicalName("isvisibleingrid")]
    public bool? IsVisibleInGrid
    {
      get => this.GetAttributeValue<bool?>("isvisibleingrid");
      set
      {
        this.OnPropertyChanging(nameof (IsVisibleInGrid));
        this.SetAttributeValue("isvisibleingrid", (object) value);
        this.OnPropertyChanged(nameof (IsVisibleInGrid));
      }
    }

    [AttributeLogicalName("mobileofflineprofileitemid")]
    public Guid? MobileOfflineProfileItemId
    {
      get => this.GetAttributeValue<Guid?>("mobileofflineprofileitemid");
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfileItemId));
        this.SetAttributeValue("mobileofflineprofileitemid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (MobileOfflineProfileItemId));
      }
    }

    [AttributeLogicalName("mobileofflineprofileitemid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.MobileOfflineProfileItemId = new Guid?(value);
    }

    [AttributeLogicalName("mobileofflineprofileitemidunique")]
    public Guid? MobileOfflineProfileItemIdUnique
    {
      get => this.GetAttributeValue<Guid?>("mobileofflineprofileitemidunique");
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

    [AttributeLogicalName("profileitementityfilter")]
    public string ProfileItemEntityFilter
    {
      get => this.GetAttributeValue<string>("profileitementityfilter");
      set
      {
        this.OnPropertyChanging(nameof (ProfileItemEntityFilter));
        this.SetAttributeValue("profileitementityfilter", (object) value);
        this.OnPropertyChanged(nameof (ProfileItemEntityFilter));
      }
    }

    [AttributeLogicalName("profileitemrule")]
    [Obsolete]
    public EntityReference ProfileItemRule
    {
      get => this.GetAttributeValue<EntityReference>("profileitemrule");
      set
      {
        this.OnPropertyChanging(nameof (ProfileItemRule));
        this.SetAttributeValue("profileitemrule", (object) value);
        this.OnPropertyChanged(nameof (ProfileItemRule));
      }
    }

    [AttributeLogicalName("publishedon")]
    public DateTime? PublishedOn => this.GetAttributeValue<DateTime?>("publishedon");

    [AttributeLogicalName("recorddistributioncriteria")]
    public OptionSetValue RecordDistributionCriteria
    {
      get => this.GetAttributeValue<OptionSetValue>("recorddistributioncriteria");
      set
      {
        this.OnPropertyChanging(nameof (RecordDistributionCriteria));
        this.SetAttributeValue("recorddistributioncriteria", (object) value);
        this.OnPropertyChanged(nameof (RecordDistributionCriteria));
      }
    }

    [AttributeLogicalName("recordsownedbyme")]
    public bool? RecordsOwnedByMe
    {
      get => this.GetAttributeValue<bool?>("recordsownedbyme");
      set
      {
        this.OnPropertyChanging(nameof (RecordsOwnedByMe));
        this.SetAttributeValue("recordsownedbyme", (object) value);
        this.OnPropertyChanged(nameof (RecordsOwnedByMe));
      }
    }

    [AttributeLogicalName("recordsownedbymybusinessunit")]
    public bool? RecordsOwnedByMyBusinessUnit
    {
      get => this.GetAttributeValue<bool?>("recordsownedbymybusinessunit");
      set
      {
        this.OnPropertyChanging(nameof (RecordsOwnedByMyBusinessUnit));
        this.SetAttributeValue("recordsownedbymybusinessunit", (object) value);
        this.OnPropertyChanged(nameof (RecordsOwnedByMyBusinessUnit));
      }
    }

    [AttributeLogicalName("recordsownedbymyteam")]
    public bool? RecordsOwnedByMyTeam
    {
      get => this.GetAttributeValue<bool?>("recordsownedbymyteam");
      set
      {
        this.OnPropertyChanging(nameof (RecordsOwnedByMyTeam));
        this.SetAttributeValue("recordsownedbymyteam", (object) value);
        this.OnPropertyChanged(nameof (RecordsOwnedByMyTeam));
      }
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

    [AttributeLogicalName("selectedentitymetadata")]
    public string SelectedEntityMetadata
    {
      get => this.GetAttributeValue<string>("selectedentitymetadata");
    }

    [AttributeLogicalName("selectedentitytypecode")]
    public string SelectedEntityTypeCode
    {
      get => this.GetAttributeValue<string>("selectedentitytypecode");
      set
      {
        this.OnPropertyChanging(nameof (SelectedEntityTypeCode));
        this.SetAttributeValue("selectedentitytypecode", (object) value);
        this.OnPropertyChanged(nameof (SelectedEntityTypeCode));
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

    [AttributeLogicalName("syncintervalinminutes")]
    public int? SyncIntervalInMinutes
    {
      get => this.GetAttributeValue<int?>("syncintervalinminutes");
      set
      {
        this.OnPropertyChanging(nameof (SyncIntervalInMinutes));
        this.SetAttributeValue("syncintervalinminutes", (object) value);
        this.OnPropertyChanged(nameof (SyncIntervalInMinutes));
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

    [AttributeLogicalName("viewquery")]
    [Obsolete]
    public string ViewQuery
    {
      get => this.GetAttributeValue<string>("viewquery");
      set
      {
        this.OnPropertyChanging(nameof (ViewQuery));
        this.SetAttributeValue("viewquery", (object) value);
        this.OnPropertyChanged(nameof (ViewQuery));
      }
    }

    [RelationshipSchemaName("MobileOfflineProfileItem_MobileOfflineProfileItemAssociation")]
    public IEnumerable<MobileOfflineProfileItemAssociation> MobileOfflineProfileItem_MobileOfflineProfileItemAssociation
    {
      get
      {
        return this.GetRelatedEntities<MobileOfflineProfileItemAssociation>(nameof (MobileOfflineProfileItem_MobileOfflineProfileItemAssociation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfileItem_MobileOfflineProfileItemAssociation));
        this.SetRelatedEntities<MobileOfflineProfileItemAssociation>(nameof (MobileOfflineProfileItem_MobileOfflineProfileItemAssociation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MobileOfflineProfileItem_MobileOfflineProfileItemAssociation));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_MobileOfflineProfileItem_createdby")]
    public SystemUser lk_MobileOfflineProfileItem_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_MobileOfflineProfileItem_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_mobileofflineprofileitem_createdonbehalfby")]
    public SystemUser lk_mobileofflineprofileitem_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitem_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mobileofflineprofileitem_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitem_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mobileofflineprofileitem_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_mobileofflineprofileitem_modifiedby")]
    public SystemUser lk_mobileofflineprofileitem_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitem_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_mobileofflineprofileitem_modifiedonbehalfby")]
    public SystemUser lk_mobileofflineprofileitem_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitem_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mobileofflineprofileitem_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mobileofflineprofileitem_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mobileofflineprofileitem_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("profileitemrule")]
    [RelationshipSchemaName("lk_mobileofflineprofileitem_savedquery")]
    public SavedQuery lk_mobileofflineprofileitem_savedquery
    {
      get
      {
        return this.GetRelatedEntity<SavedQuery>(nameof (lk_mobileofflineprofileitem_savedquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mobileofflineprofileitem_savedquery));
        this.SetRelatedEntity<SavedQuery>(nameof (lk_mobileofflineprofileitem_savedquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mobileofflineprofileitem_savedquery));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("MobileOfflineProfile_MobileOfflineProfileItem")]
    public MobileOfflineProfile MobileOfflineProfile_MobileOfflineProfileItem
    {
      get
      {
        return this.GetRelatedEntity<MobileOfflineProfile>(nameof (MobileOfflineProfile_MobileOfflineProfileItem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MobileOfflineProfile_MobileOfflineProfileItem));
        this.SetRelatedEntity<MobileOfflineProfile>(nameof (MobileOfflineProfile_MobileOfflineProfileItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MobileOfflineProfile_MobileOfflineProfileItem));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("MobileOfflineProfileItem_organization")]
    public Organization MobileOfflineProfileItem_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (MobileOfflineProfileItem_organization), new EntityRole?());
      }
    }

    public MobileOfflineProfileItem(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mobileofflineprofileitemid"] = (object) base.Id;
            break;
          case "mobileofflineprofileitemid":
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
