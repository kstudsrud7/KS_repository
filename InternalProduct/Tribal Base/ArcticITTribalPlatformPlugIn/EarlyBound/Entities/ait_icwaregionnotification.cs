// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_icwaregionnotification
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_icwaregionnotification")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_icwaregionnotification : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_icwaregionnotification";
    public const string EntitySchemaName = "ait_icwaregionnotification";
    public const string PrimaryIdAttribute = "ait_icwaregionnotificationid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_icwaregionnotification()
      : base(nameof (ait_icwaregionnotification))
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

    [AttributeLogicalName("ait_icwanotice")]
    public EntityReference ait_ICWANotice
    {
      get => this.GetAttributeValue<EntityReference>("ait_icwanotice");
      set
      {
        this.OnPropertyChanging(nameof (ait_ICWANotice));
        this.SetAttributeValue("ait_icwanotice", (object) value);
        this.OnPropertyChanged(nameof (ait_ICWANotice));
      }
    }

    [AttributeLogicalName("ait_icwaregionnotificationid")]
    public Guid? ait_icwaregionnotificationId
    {
      get => this.GetAttributeValue<Guid?>("ait_icwaregionnotificationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotificationId));
        this.SetAttributeValue("ait_icwaregionnotificationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_icwaregionnotificationId));
      }
    }

    [AttributeLogicalName("ait_icwaregionnotificationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_icwaregionnotificationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
      }
    }

    [AttributeLogicalName("ait_notes")]
    public string ait_Notes
    {
      get => this.GetAttributeValue<string>("ait_notes");
      set
      {
        this.OnPropertyChanging(nameof (ait_Notes));
        this.SetAttributeValue("ait_notes", (object) value);
        this.OnPropertyChanged(nameof (ait_Notes));
      }
    }

    [AttributeLogicalName("ait_notificationmethod")]
    public OptionSetValue ait_NotificationMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_notificationmethod");
      set
      {
        this.OnPropertyChanging(nameof (ait_NotificationMethod));
        this.SetAttributeValue("ait_notificationmethod", (object) value);
        this.OnPropertyChanged(nameof (ait_NotificationMethod));
      }
    }

    [AttributeLogicalName("ait_notificationstatus")]
    public OptionSetValue ait_NotificationStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_notificationstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_NotificationStatus));
        this.SetAttributeValue("ait_notificationstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_NotificationStatus));
      }
    }

    [AttributeLogicalName("ait_notifieddatetime")]
    public DateTime? ait_NotifiedDateTime
    {
      get => this.GetAttributeValue<DateTime?>("ait_notifieddatetime");
      set
      {
        this.OnPropertyChanging(nameof (ait_NotifiedDateTime));
        this.SetAttributeValue("ait_notifieddatetime", (object) value);
        this.OnPropertyChanged(nameof (ait_NotifiedDateTime));
      }
    }

    [AttributeLogicalName("ait_regionnotified")]
    public EntityReference ait_RegionNotified
    {
      get => this.GetAttributeValue<EntityReference>("ait_regionnotified");
      set
      {
        this.OnPropertyChanging(nameof (ait_RegionNotified));
        this.SetAttributeValue("ait_regionnotified", (object) value);
        this.OnPropertyChanged(nameof (ait_RegionNotified));
      }
    }

    [AttributeLogicalName("ait_responsereceived")]
    public OptionSetValue ait_ResponseReceived
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_responsereceived");
      set
      {
        this.OnPropertyChanging(nameof (ait_ResponseReceived));
        this.SetAttributeValue("ait_responsereceived", (object) value);
        this.OnPropertyChanged(nameof (ait_ResponseReceived));
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
    public ait_icwaregionnotificationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_icwaregionnotificationState?((ait_icwaregionnotificationState) Enum.ToObject(typeof (ait_icwaregionnotificationState), attributeValue.Value)) : new ait_icwaregionnotificationState?();
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

    [RelationshipSchemaName("ait_icwaregionnotification_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_icwaregionnotification_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_icwaregionnotification_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_icwaregionnotification_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_icwaregionnotification_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_icwaregionnotification_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_icwaregionnotification_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_icwaregionnotification_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_icwaregionnotification_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_icwaregionnotification_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_icwaregionnotification_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_icwaregionnotification_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_icwaregionnotification_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_icwaregionnotification_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_icwaregionnotification_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_icwaregionnotification_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_icwaregionnotification_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_icwaregionnotification_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_icwaregionnotification_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_ProcessSession")]
    public IEnumerable<ProcessSession> ait_icwaregionnotification_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_icwaregionnotification_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_icwaregionnotification_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_SyncErrors")]
    public IEnumerable<SyncError> ait_icwaregionnotification_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_icwaregionnotification_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_icwaregionnotification_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_icwaregionnotification_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_icwaregionnotification_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_icwaregionnotification_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_ait_icwaregion")]
    public IEnumerable<ait_icwaregion> ait_icwaregionnotification_ait_icwaregion
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregion>(nameof (ait_icwaregionnotification_ait_icwaregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_ait_icwaregion));
        this.SetRelatedEntities<ait_icwaregion>(nameof (ait_icwaregionnotification_ait_icwaregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_ait_icwaregion));
      }
    }

    [AttributeLogicalName("ait_regionnotified")]
    [RelationshipSchemaName("ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified")]
    public ait_icwaregion ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified));
        this.SetRelatedEntity<ait_icwaregion>(nameof (ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified));
      }
    }

    [AttributeLogicalName("ait_icwanotice")]
    [RelationshipSchemaName("ait_icwanotice_ait_icwaregionnotification_ICWANotice")]
    public ait_icwanotice ait_icwanotice_ait_icwaregionnotification_ICWANotice
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_ait_icwaregionnotification_ICWANotice), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_ait_icwaregionnotification_ICWANotice));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_ait_icwaregionnotification_ICWANotice), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_ait_icwaregionnotification_ICWANotice));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_icwaregionnotification")]
    public BusinessUnit business_unit_ait_icwaregionnotification
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_icwaregionnotification), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_icwaregionnotification_createdby")]
    public SystemUser lk_ait_icwaregionnotification_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregionnotification_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_icwaregionnotification_createdonbehalfby")]
    public SystemUser lk_ait_icwaregionnotification_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregionnotification_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_icwaregionnotification_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregionnotification_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_icwaregionnotification_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_icwaregionnotification_modifiedby")]
    public SystemUser lk_ait_icwaregionnotification_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregionnotification_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_icwaregionnotification_modifiedonbehalfby")]
    public SystemUser lk_ait_icwaregionnotification_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregionnotification_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_icwaregionnotification_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregionnotification_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_icwaregionnotification_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_icwaregionnotification")]
    public Team team_ait_icwaregionnotification
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_icwaregionnotification), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_icwaregionnotification")]
    public SystemUser user_ait_icwaregionnotification
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_icwaregionnotification), new EntityRole?());
      }
    }

    public ait_icwaregionnotification(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_icwaregionnotificationid"] = (object) base.Id;
            break;
          case "ait_icwaregionnotificationid":
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
