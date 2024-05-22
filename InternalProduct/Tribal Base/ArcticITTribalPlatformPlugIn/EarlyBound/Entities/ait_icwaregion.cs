// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_icwaregion
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_icwaregion")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_icwaregion : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_icwaregion";
    public const string EntitySchemaName = "ait_icwaregion";
    public const string PrimaryIdAttribute = "ait_icwaregionid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_icwaregion()
      : base(nameof (ait_icwaregion))
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

    [AttributeLogicalName("ait_address")]
    public string ait_Address
    {
      get => this.GetAttributeValue<string>("ait_address");
      set
      {
        this.OnPropertyChanging(nameof (ait_Address));
        this.SetAttributeValue("ait_address", (object) value);
        this.OnPropertyChanged(nameof (ait_Address));
      }
    }

    [AttributeLogicalName("ait_icwaregionid")]
    public Guid? ait_icwaregionId
    {
      get => this.GetAttributeValue<Guid?>("ait_icwaregionid");
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionId));
        this.SetAttributeValue("ait_icwaregionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_icwaregionId));
      }
    }

    [AttributeLogicalName("ait_icwaregionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_icwaregionId = new Guid?(value);
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
    public ait_icwaregionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_icwaregionState?((ait_icwaregionState) Enum.ToObject(typeof (ait_icwaregionState), attributeValue.Value)) : new ait_icwaregionState?();
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

    [RelationshipSchemaName("ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified")]
    public IEnumerable<ait_icwaregionnotification> ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregionnotification>(nameof (ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified));
        this.SetRelatedEntities<ait_icwaregionnotification>(nameof (ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_icwaregion_ait_icwaregionnotification_RegionNotified));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_icwaregion_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_icwaregion_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_icwaregion_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_icwaregion_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_icwaregion_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_icwaregion_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_icwaregion_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_icwaregion_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_icwaregion_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_icwaregion_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_icwaregion_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_icwaregion_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_icwaregion_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_icwaregion_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_icwaregion_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_icwaregion_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_icwaregion_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_icwaregion_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_ProcessSession")]
    public IEnumerable<ProcessSession> ait_icwaregion_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_icwaregion_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_icwaregion_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_SyncErrors")]
    public IEnumerable<SyncError> ait_icwaregion_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_icwaregion_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_icwaregion_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_icwaregion_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_icwaregion_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_icwaregion_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_icwaregion_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_icwaregionnotification_ait_icwaregion")]
    public IEnumerable<ait_icwaregionnotification> ait_icwaregionnotification_ait_icwaregion
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_ait_icwaregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_ait_icwaregion));
        this.SetRelatedEntities<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_ait_icwaregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_ait_icwaregion));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_icwaregion")]
    public BusinessUnit business_unit_ait_icwaregion
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_icwaregion), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_icwaregion_createdby")]
    public SystemUser lk_ait_icwaregion_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregion_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_icwaregion_createdonbehalfby")]
    public SystemUser lk_ait_icwaregion_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregion_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_icwaregion_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregion_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_icwaregion_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_icwaregion_modifiedby")]
    public SystemUser lk_ait_icwaregion_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregion_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_icwaregion_modifiedonbehalfby")]
    public SystemUser lk_ait_icwaregion_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregion_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_icwaregion_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_icwaregion_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_icwaregion_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_icwaregion")]
    public Team team_ait_icwaregion
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_icwaregion), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_icwaregion")]
    public SystemUser user_ait_icwaregion
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_icwaregion), new EntityRole?());
    }

    public ait_icwaregion(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_icwaregionid"] = (object) base.Id;
            break;
          case "ait_icwaregionid":
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
