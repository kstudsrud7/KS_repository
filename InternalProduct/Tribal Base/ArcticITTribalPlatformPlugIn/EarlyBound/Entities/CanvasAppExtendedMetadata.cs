// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CanvasAppExtendedMetadata
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("canvasappextendedmetadata")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CanvasAppExtendedMetadata : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "canvasappextendedmetadata";
    public const string EntitySchemaName = "CanvasAppExtendedMetadata";
    public const string PrimaryIdAttribute = "canvasappextendedmetadataid";
    public const string PrimaryNameAttribute = "name";

    public CanvasAppExtendedMetadata()
      : base(nameof (canvasappextendedmetadata))
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

    [AttributeLogicalName("canvasappextendedmetadataid")]
    public Guid? CanvasAppExtendedMetadataId
    {
      get => this.GetAttributeValue<Guid?>("canvasappextendedmetadataid");
      set
      {
        this.OnPropertyChanging(nameof (CanvasAppExtendedMetadataId));
        this.SetAttributeValue("canvasappextendedmetadataid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CanvasAppExtendedMetadataId));
      }
    }

    [AttributeLogicalName("canvasappextendedmetadataid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CanvasAppExtendedMetadataId = new Guid?(value);
    }

    [AttributeLogicalName("canvasappid")]
    public EntityReference CanvasAppId
    {
      get => this.GetAttributeValue<EntityReference>("canvasappid");
      set
      {
        this.OnPropertyChanging(nameof (CanvasAppId));
        this.SetAttributeValue("canvasappid", (object) value);
        this.OnPropertyChanged(nameof (CanvasAppId));
      }
    }

    [AttributeLogicalName("canvasappuniqueid")]
    public string CanvasAppUniqueId
    {
      get => this.GetAttributeValue<string>("canvasappuniqueid");
      set
      {
        this.OnPropertyChanging(nameof (CanvasAppUniqueId));
        this.SetAttributeValue("canvasappuniqueid", (object) value);
        this.OnPropertyChanged(nameof (CanvasAppUniqueId));
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
    public CanvasAppExtendedMetadataState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new CanvasAppExtendedMetadataState?((CanvasAppExtendedMetadataState) Enum.ToObject(typeof (CanvasAppExtendedMetadataState), attributeValue.Value)) : new CanvasAppExtendedMetadataState?();
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

    [RelationshipSchemaName("canvasappextendedmetadata_AsyncOperations")]
    public IEnumerable<AsyncOperation> canvasappextendedmetadata_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (canvasappextendedmetadata_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (canvasappextendedmetadata_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_AsyncOperations));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> canvasappextendedmetadata_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (canvasappextendedmetadata_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (canvasappextendedmetadata_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> canvasappextendedmetadata_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (canvasappextendedmetadata_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (canvasappextendedmetadata_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> canvasappextendedmetadata_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (canvasappextendedmetadata_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (canvasappextendedmetadata_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> canvasappextendedmetadata_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (canvasappextendedmetadata_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (canvasappextendedmetadata_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> canvasappextendedmetadata_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (canvasappextendedmetadata_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (canvasappextendedmetadata_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata_ProcessSession")]
    public IEnumerable<ProcessSession> canvasappextendedmetadata_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (canvasappextendedmetadata_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (canvasappextendedmetadata_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_ProcessSession));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata_SyncErrors")]
    public IEnumerable<SyncError> canvasappextendedmetadata_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (canvasappextendedmetadata_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (canvasappextendedmetadata_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_SyncErrors));
      }
    }

    [RelationshipSchemaName("canvasappextendedmetadata_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> canvasappextendedmetadata_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (canvasappextendedmetadata_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (canvasappextendedmetadata_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_canvasappextendedmetadata")]
    public BusinessUnit business_unit_canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_canvasappextendedmetadata), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("businessunit_canvasappextendedmetadata")]
    public BusinessUnit businessunit_canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (businessunit_canvasappextendedmetadata), new EntityRole?());
      }
    }

    [AttributeLogicalName("canvasappid")]
    [RelationshipSchemaName("canvasappextendedmetadata")]
    public CanvasApp canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntity<CanvasApp>(nameof (canvasappextendedmetadata), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata));
        this.SetRelatedEntity<CanvasApp>(nameof (canvasappextendedmetadata), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_canvasappextendedmetadata_createdby")]
    public SystemUser lk_canvasappextendedmetadata_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_canvasappextendedmetadata_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_canvasappextendedmetadata_createdonbehalfby")]
    public SystemUser lk_canvasappextendedmetadata_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_canvasappextendedmetadata_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_canvasappextendedmetadata_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_canvasappextendedmetadata_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_canvasappextendedmetadata_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_canvasappextendedmetadata_modifiedby")]
    public SystemUser lk_canvasappextendedmetadata_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_canvasappextendedmetadata_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_canvasappextendedmetadata_modifiedonbehalfby")]
    public SystemUser lk_canvasappextendedmetadata_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_canvasappextendedmetadata_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_canvasappextendedmetadata_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_canvasappextendedmetadata_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_canvasappextendedmetadata_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_canvasappextendedmetadata")]
    public Team team_canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_canvasappextendedmetadata), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_canvasappextendedmetadata")]
    public SystemUser user_canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_canvasappextendedmetadata), new EntityRole?());
      }
    }

    public CanvasAppExtendedMetadata(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["canvasappextendedmetadataid"] = (object) base.Id;
            break;
          case "canvasappextendedmetadataid":
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
