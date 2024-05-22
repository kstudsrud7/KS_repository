// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_charge
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_charge")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_charge : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_charge";
    public const string EntitySchemaName = "ait_charge";
    public const string PrimaryIdAttribute = "ait_chargeid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_charge()
      : base(nameof (ait_charge))
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

    [AttributeLogicalName("ait_chargecode")]
    public string ait_ChargeCode
    {
      get => this.GetAttributeValue<string>("ait_chargecode");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChargeCode));
        this.SetAttributeValue("ait_chargecode", (object) value);
        this.OnPropertyChanged(nameof (ait_ChargeCode));
      }
    }

    [AttributeLogicalName("ait_chargeid")]
    public Guid? ait_chargeId
    {
      get => this.GetAttributeValue<Guid?>("ait_chargeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_chargeId));
        this.SetAttributeValue("ait_chargeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_chargeId));
      }
    }

    [AttributeLogicalName("ait_chargeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_chargeId = new Guid?(value);
    }

    [AttributeLogicalName("ait_courtcase")]
    public EntityReference ait_CourtCase
    {
      get => this.GetAttributeValue<EntityReference>("ait_courtcase");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCase));
        this.SetAttributeValue("ait_courtcase", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCase));
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

    [AttributeLogicalName("ait_penalty")]
    public string ait_Penalty
    {
      get => this.GetAttributeValue<string>("ait_penalty");
      set
      {
        this.OnPropertyChanging(nameof (ait_Penalty));
        this.SetAttributeValue("ait_penalty", (object) value);
        this.OnPropertyChanged(nameof (ait_Penalty));
      }
    }

    [AttributeLogicalName("ait_statute")]
    public EntityReference ait_Statute
    {
      get => this.GetAttributeValue<EntityReference>("ait_statute");
      set
      {
        this.OnPropertyChanging(nameof (ait_Statute));
        this.SetAttributeValue("ait_statute", (object) value);
        this.OnPropertyChanged(nameof (ait_Statute));
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
    public ait_chargeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_chargeState?((ait_chargeState) Enum.ToObject(typeof (ait_chargeState), attributeValue.Value)) : new ait_chargeState?();
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

    [RelationshipSchemaName("ait_charge_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_charge_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_charge_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_charge_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_charge_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_charge_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_charge_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_charge_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_charge_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_charge_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_charge_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_charge_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_charge_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_charge_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_charge_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_charge_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_charge_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_charge_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_charge_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_charge_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_charge_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_charge_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_charge_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_charge_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_charge_ProcessSession")]
    public IEnumerable<ProcessSession> ait_charge_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_charge_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_charge_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_charge_SyncErrors")]
    public IEnumerable<SyncError> ait_charge_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_charge_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_charge_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_charge_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_charge_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_charge_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_charge_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_courtcase")]
    [RelationshipSchemaName("ait_ait_courtcase_ait_charge_CourtCase")]
    public ait_courtcase ait_ait_courtcase_ait_charge_CourtCase
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_ait_courtcase_ait_charge_CourtCase), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtcase_ait_charge_CourtCase));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_ait_courtcase_ait_charge_CourtCase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtcase_ait_charge_CourtCase));
      }
    }

    [AttributeLogicalName("ait_courtprofile")]
    [RelationshipSchemaName("ait_ait_courtprofile_ait_charge_CourtProfile")]
    public ait_courtprofile ait_ait_courtprofile_ait_charge_CourtProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_ait_courtprofile_ait_charge_CourtProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_courtprofile_ait_charge_CourtProfile));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_ait_courtprofile_ait_charge_CourtProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_courtprofile_ait_charge_CourtProfile));
      }
    }

    [AttributeLogicalName("ait_statute")]
    [RelationshipSchemaName("ait_statute_ait_charge_Statute")]
    public ait_statute ait_statute_ait_charge_Statute
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_ait_charge_Statute), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_ait_charge_Statute));
        this.SetRelatedEntity<ait_statute>(nameof (ait_statute_ait_charge_Statute), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_ait_charge_Statute));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_charge")]
    public BusinessUnit business_unit_ait_charge
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_charge), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_charge_createdby")]
    public SystemUser lk_ait_charge_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_charge_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_charge_createdonbehalfby")]
    public SystemUser lk_ait_charge_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_charge_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_charge_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_charge_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_charge_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_charge_modifiedby")]
    public SystemUser lk_ait_charge_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_charge_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_charge_modifiedonbehalfby")]
    public SystemUser lk_ait_charge_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_charge_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_charge_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_charge_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_charge_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_charge")]
    public Team team_ait_charge
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_charge), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_charge")]
    public SystemUser user_ait_charge
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_charge), new EntityRole?());
    }

    public ait_charge(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_chargeid"] = (object) base.Id;
            break;
          case "ait_chargeid":
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
