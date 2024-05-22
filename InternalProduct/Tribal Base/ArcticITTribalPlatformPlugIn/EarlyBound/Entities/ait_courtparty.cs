// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_courtparty
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_courtparty")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_courtparty : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_courtparty";
    public const string EntitySchemaName = "ait_courtparty";
    public const string PrimaryIdAttribute = "ait_courtpartyid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_courtparty()
      : base(nameof (ait_courtparty))
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

    [AttributeLogicalName("ait_courtcaseid")]
    public EntityReference ait_CourtCaseId
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtcaseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCaseId));
        this.SetAttributeValue("ait_courtcaseid", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCaseId));
      }
    }

    [AttributeLogicalName("ait_courtpartyid")]
    public Guid? ait_courtpartyId
    {
      get => this.GetAttributeValue<Guid?>("ait_courtpartyid");
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpartyId));
        this.SetAttributeValue("ait_courtpartyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_courtpartyId));
      }
    }

    [AttributeLogicalName("ait_courtpartyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_courtpartyId = new Guid?(value);
    }

    [AttributeLogicalName("ait_courtpartysubtype")]
    public OptionSetValue ait_CourtPartySubType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_courtpartysubtype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtPartySubType));
        this.SetAttributeValue("ait_courtpartysubtype", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtPartySubType));
      }
    }

    [AttributeLogicalName("ait_courtpartytype")]
    public OptionSetValue ait_CourtPartyType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_courtpartytype");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtPartyType));
        this.SetAttributeValue("ait_courtpartytype", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtPartyType));
      }
    }

    [AttributeLogicalName("ait_courtprofile")]
    public EntityReference ait_CourtProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtProfile));
        this.SetAttributeValue("ait_courtprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtProfile));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_Description
    {
      get => this.GetAttributeValue<string>("ait_description");
      set
      {
        this.OnPropertyChanging(nameof (ait_Description));
        this.SetAttributeValue("ait_description", (object) value);
        this.OnPropertyChanged(nameof (ait_Description));
      }
    }

    [AttributeLogicalName("ait_juvenile")]
    public bool? ait_Juvenile
    {
      get => this.GetAttributeValue<bool?>("ait_juvenile");
      set
      {
        this.OnPropertyChanging(nameof (ait_Juvenile));
        this.SetAttributeValue("ait_juvenile", (object) value);
        this.OnPropertyChanged(nameof (ait_Juvenile));
      }
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
    public ait_courtpartyState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_courtpartyState?((ait_courtpartyState) Enum.ToObject(typeof (ait_courtpartyState), attributeValue.Value)) : new ait_courtpartyState?();
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

    [RelationshipSchemaName("ait_courtparty_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_courtparty_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_courtparty_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_courtparty_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_courtparty_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_courtparty_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtparty_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_courtparty_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_courtparty_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_courtparty_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtparty_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtparty_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_courtparty_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_courtparty_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_courtparty_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_courtparty_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_courtparty_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_courtparty_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtparty_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_courtparty_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_courtparty_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_courtparty_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtparty_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_courtparty_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_courtparty_ProcessSession")]
    public IEnumerable<ProcessSession> ait_courtparty_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_courtparty_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_courtparty_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_courtparty_SyncErrors")]
    public IEnumerable<SyncError> ait_courtparty_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_courtparty_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_courtparty_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_courtparty_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_courtparty_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtparty_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_courtparty_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_courtcaseid")]
    [RelationshipSchemaName("ait_ait_courtcase_ait_courtparty")]
    public ait_courtcase ait_ait_courtcase_ait_courtparty
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_ait_courtcase_ait_courtparty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtcase_ait_courtparty));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_ait_courtcase_ait_courtparty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtcase_ait_courtparty));
      }
    }

    [AttributeLogicalName("ait_courtprofile")]
    [RelationshipSchemaName("ait_ait_courtprofile_ait_courtparty_CourtProfile")]
    public ait_courtprofile ait_ait_courtprofile_ait_courtparty_CourtProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_ait_courtprofile_ait_courtparty_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtprofile_ait_courtparty_CourtProfile));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_ait_courtprofile_ait_courtparty_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtprofile_ait_courtparty_CourtProfile));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_courtparty")]
    public BusinessUnit business_unit_ait_courtparty
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_courtparty), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_courtparty_createdby")]
    public SystemUser lk_ait_courtparty_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtparty_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtparty_createdonbehalfby")]
    public SystemUser lk_ait_courtparty_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtparty_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtparty_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtparty_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtparty_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_courtparty_modifiedby")]
    public SystemUser lk_ait_courtparty_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtparty_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_courtparty_modifiedonbehalfby")]
    public SystemUser lk_ait_courtparty_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_courtparty_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_courtparty_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_courtparty_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_courtparty_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_courtparty")]
    public Team team_ait_courtparty
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_courtparty), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_courtparty")]
    public SystemUser user_ait_courtparty
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_courtparty), new EntityRole?());
    }

    public ait_courtparty(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_courtpartyid"] = (object) base.Id;
            break;
          case "ait_courtpartyid":
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
