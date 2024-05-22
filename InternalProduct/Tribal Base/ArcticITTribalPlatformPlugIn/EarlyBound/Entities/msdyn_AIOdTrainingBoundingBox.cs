// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_AIOdTrainingBoundingBox
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_aiodtrainingboundingbox")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_AIOdTrainingBoundingBox : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_aiodtrainingboundingbox";
    public const string EntitySchemaName = "msdyn_AIOdTrainingBoundingBox";
    public const string PrimaryIdAttribute = "msdyn_aiodtrainingboundingboxid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_AIOdTrainingBoundingBox()
      : base("msdyn_aiodtrainingboundingbox")
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

    [AttributeLogicalName("msdyn_aiodlabelid")]
    public EntityReference msdyn_AIOdLabelId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aiodlabelid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIOdLabelId));
        this.SetAttributeValue("msdyn_aiodlabelid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIOdLabelId));
      }
    }

    [AttributeLogicalName("msdyn_aiodtrainingboundingboxid")]
    public Guid? msdyn_AIOdTrainingBoundingBoxId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_aiodtrainingboundingboxid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIOdTrainingBoundingBoxId));
        this.SetAttributeValue("msdyn_aiodtrainingboundingboxid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_AIOdTrainingBoundingBoxId));
      }
    }

    [AttributeLogicalName("msdyn_aiodtrainingboundingboxid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_AIOdTrainingBoundingBoxId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_aiodtrainingimageid")]
    public EntityReference msdyn_AIOdTrainingImageId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_aiodtrainingimageid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_AIOdTrainingImageId));
        this.SetAttributeValue("msdyn_aiodtrainingimageid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_AIOdTrainingImageId));
      }
    }

    [AttributeLogicalName("msdyn_height")]
    public double? msdyn_Height
    {
      get => this.GetAttributeValue<double?>("msdyn_height");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Height));
        this.SetAttributeValue("msdyn_height", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Height));
      }
    }

    [AttributeLogicalName("msdyn_left")]
    public double? msdyn_Left
    {
      get => this.GetAttributeValue<double?>("msdyn_left");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Left));
        this.SetAttributeValue("msdyn_left", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Left));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_name));
        this.SetAttributeValue(nameof (msdyn_name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_name));
      }
    }

    [AttributeLogicalName("msdyn_top")]
    public double? msdyn_Top
    {
      get => this.GetAttributeValue<double?>("msdyn_top");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Top));
        this.SetAttributeValue("msdyn_top", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Top));
      }
    }

    [AttributeLogicalName("msdyn_width")]
    public double? msdyn_Width
    {
      get => this.GetAttributeValue<double?>("msdyn_width");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Width));
        this.SetAttributeValue("msdyn_width", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Width));
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

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("statecode")]
    public msdyn_AIOdTrainingBoundingBoxState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_AIOdTrainingBoundingBoxState?((msdyn_AIOdTrainingBoundingBoxState) Enum.ToObject(typeof (msdyn_AIOdTrainingBoundingBoxState), attributeValue.Value)) : new msdyn_AIOdTrainingBoundingBoxState?();
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

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get => this.GetAttributeValue<int?>("timezoneruleversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleVersionNumber));
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneRuleVersionNumber));
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_aiodtrainingboundingbox_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_aiodtrainingboundingbox_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_aiodtrainingboundingbox_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_aiodtrainingboundingbox_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiodtrainingboundingbox_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_aiodtrainingboundingbox_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aiodtrainingboundingbox_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodtrainingboundingbox_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodtrainingboundingbox_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_aiodtrainingboundingbox_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiodtrainingboundingbox_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_aiodtrainingboundingbox_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_aiodtrainingboundingbox_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_aiodtrainingboundingbox_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_aiodtrainingboundingbox_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_SyncErrors")]
    public IEnumerable<SyncError> msdyn_aiodtrainingboundingbox_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_aiodtrainingboundingbox_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_aiodtrainingboundingbox_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_aiodtrainingboundingbox")]
    public BusinessUnit business_unit_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_aiodtrainingboundingbox_createdby")]
    public SystemUser lk_msdyn_aiodtrainingboundingbox_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingboundingbox_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiodtrainingboundingbox_createdonbehalfby")]
    public SystemUser lk_msdyn_aiodtrainingboundingbox_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingboundingbox_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiodtrainingboundingbox_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingboundingbox_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiodtrainingboundingbox_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_aiodtrainingboundingbox_modifiedby")]
    public SystemUser lk_msdyn_aiodtrainingboundingbox_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingboundingbox_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby")]
    public SystemUser lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_aiodlabelid")]
    [RelationshipSchemaName("msdyn_aiodlabel_msdyn_aiodtrainingboundingbox")]
    public msdyn_AIOdLabel msdyn_aiodlabel_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_msdyn_aiodtrainingboundingbox));
        this.SetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_msdyn_aiodtrainingboundingbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_msdyn_aiodtrainingboundingbox));
      }
    }

    [AttributeLogicalName("msdyn_aiodtrainingimageid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox));
        this.SetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_msdyn_aiodtrainingboundingbox));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_aiodtrainingboundingbox")]
    public Team team_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_aiodtrainingboundingbox")]
    public SystemUser user_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
    }

    public msdyn_AIOdTrainingBoundingBox(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_aiodtrainingboundingboxid"] = (object) base.Id;
            break;
          case "msdyn_aiodtrainingboundingboxid":
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
