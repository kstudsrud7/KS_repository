// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_stateprovince
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_stateprovince")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_stateprovince : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_stateprovince";
    public const string EntitySchemaName = "ait_stateprovince";
    public const string PrimaryIdAttribute = "ait_stateprovinceid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_stateprovince()
      : base(nameof (ait_stateprovince))
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

    [AttributeLogicalName("ait_abbreviation")]
    public string ait_abbreviation
    {
      get => this.GetAttributeValue<string>(nameof (ait_abbreviation));
      set
      {
        this.OnPropertyChanging(nameof (ait_abbreviation));
        this.SetAttributeValue(nameof (ait_abbreviation), (object) value);
        this.OnPropertyChanged(nameof (ait_abbreviation));
      }
    }

    [AttributeLogicalName("ait_countryregion")]
    public EntityReference ait_countryregion
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_countryregion));
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion));
        this.SetAttributeValue(nameof (ait_countryregion), (object) value);
        this.OnPropertyChanged(nameof (ait_countryregion));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
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

    [AttributeLogicalName("ait_stateprovinceid")]
    public Guid? ait_stateprovinceId
    {
      get => this.GetAttributeValue<Guid?>("ait_stateprovinceid");
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovinceId));
        this.SetAttributeValue("ait_stateprovinceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_stateprovinceId));
      }
    }

    [AttributeLogicalName("ait_stateprovinceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_stateprovinceId = new Guid?(value);
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

    [AttributeLogicalName("statecode")]
    public ait_stateprovinceState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_stateprovinceState?((ait_stateprovinceState) Enum.ToObject(typeof (ait_stateprovinceState), attributeValue.Value)) : new ait_stateprovinceState?();
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

    [RelationshipSchemaName("ait_ait_birthrecord_ait_stateprovince")]
    public IEnumerable<ait_birthrecord> ait_ait_birthrecord_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntities<ait_birthrecord>(nameof (ait_ait_birthrecord_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_birthrecord_ait_stateprovince));
        this.SetRelatedEntities<ait_birthrecord>(nameof (ait_ait_birthrecord_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_birthrecord_ait_stateprovince));
      }
    }

    [RelationshipSchemaName("ait_ait_city_ait_stateprovince")]
    public IEnumerable<ait_city> ait_ait_city_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntities<ait_city>(nameof (ait_ait_city_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_stateprovince));
        this.SetRelatedEntities<ait_city>(nameof (ait_ait_city_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_stateprovince));
      }
    }

    [RelationshipSchemaName("ait_ait_county_ait_stateprovince")]
    public IEnumerable<ait_county> ait_ait_county_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntities<ait_county>(nameof (ait_ait_county_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_county_ait_stateprovince));
        this.SetRelatedEntities<ait_county>(nameof (ait_ait_county_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_county_ait_stateprovince));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_stateprovince")]
    public IEnumerable<ait_physicaladdress> ait_ait_physicaladdress_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_stateprovince));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_stateprovince));
      }
    }

    [RelationshipSchemaName("ait_ait_stateprovince_ait_birthrecord_amendedstate")]
    public IEnumerable<ait_birthrecord> ait_ait_stateprovince_ait_birthrecord_amendedstate
    {
      get
      {
        return this.GetRelatedEntities<ait_birthrecord>(nameof (ait_ait_stateprovince_ait_birthrecord_amendedstate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_birthrecord_amendedstate));
        this.SetRelatedEntities<ait_birthrecord>(nameof (ait_ait_stateprovince_ait_birthrecord_amendedstate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_birthrecord_amendedstate));
      }
    }

    [RelationshipSchemaName("ait_ait_stateprovince_ait_changerequest_StateProvince_Approved")]
    public IEnumerable<ait_changerequest> ait_ait_stateprovince_ait_changerequest_StateProvince_Approved
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (ait_ait_stateprovince_ait_changerequest_StateProvince_Approved), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_changerequest_StateProvince_Approved));
        this.SetRelatedEntities<ait_changerequest>(nameof (ait_ait_stateprovince_ait_changerequest_StateProvince_Approved), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_changerequest_StateProvince_Approved));
      }
    }

    [RelationshipSchemaName("ait_ait_stateprovince_ait_deathrecord_deathstate")]
    public IEnumerable<ait_deathrecord> ait_ait_stateprovince_ait_deathrecord_deathstate
    {
      get
      {
        return this.GetRelatedEntities<ait_deathrecord>(nameof (ait_ait_stateprovince_ait_deathrecord_deathstate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_deathrecord_deathstate));
        this.SetRelatedEntities<ait_deathrecord>(nameof (ait_ait_stateprovince_ait_deathrecord_deathstate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_deathrecord_deathstate));
      }
    }

    [RelationshipSchemaName("ait_ait_stateprovince_ait_tribe")]
    public IEnumerable<ait_tribe> ait_ait_stateprovince_ait_tribe
    {
      get
      {
        return this.GetRelatedEntities<ait_tribe>(nameof (ait_ait_stateprovince_ait_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_tribe));
        this.SetRelatedEntities<ait_tribe>(nameof (ait_ait_stateprovince_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_tribe));
      }
    }

    [RelationshipSchemaName("ait_ait_zipcodecity_ait_stateprovince")]
    public IEnumerable<ait_zipcodecity> ait_ait_zipcodecity_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntities<ait_zipcodecity>(nameof (ait_ait_zipcodecity_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_zipcodecity_ait_stateprovince));
        this.SetRelatedEntities<ait_zipcodecity>(nameof (ait_ait_zipcodecity_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_zipcodecity_ait_stateprovince));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_ait_courtprofile_IssueState")]
    public IEnumerable<ait_courtprofile> ait_stateprovince_ait_courtprofile_IssueState
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofile>(nameof (ait_stateprovince_ait_courtprofile_IssueState), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_ait_courtprofile_IssueState));
        this.SetRelatedEntities<ait_courtprofile>(nameof (ait_stateprovince_ait_courtprofile_IssueState), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_ait_courtprofile_IssueState));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_ait_courtprofileaddress_StateLookup")]
    public IEnumerable<ait_courtprofileaddress> ait_stateprovince_ait_courtprofileaddress_StateLookup
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (ait_stateprovince_ait_courtprofileaddress_StateLookup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_ait_courtprofileaddress_StateLookup));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (ait_stateprovince_ait_courtprofileaddress_StateLookup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_ait_courtprofileaddress_StateLookup));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_stateprovince_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_stateprovince_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_stateprovince_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_stateprovince_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_stateprovince_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_stateprovince_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_stateprovince_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_stateprovince_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_stateprovince_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_stateprovince_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_stateprovince_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_stateprovince_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_stateprovince_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_stateprovince_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_stateprovince_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_stateprovince_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_stateprovince_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_stateprovince_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_ProcessSession")]
    public IEnumerable<ProcessSession> ait_stateprovince_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_stateprovince_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_stateprovince_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_SyncErrors")]
    public IEnumerable<SyncError> ait_stateprovince_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_stateprovince_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_stateprovince_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_stateprovince_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_stateprovince_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_stateprovince_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_stateprovince_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_countryregion")]
    [RelationshipSchemaName("ait_ait_stateprovince_ait_countryregion")]
    public ArcticIT.EarlyBound.Entities.ait_countryregion ait_ait_stateprovince_ait_countryregion
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_countryregion>(nameof (ait_ait_stateprovince_ait_countryregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_countryregion));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_countryregion>(nameof (ait_ait_stateprovince_ait_countryregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_countryregion));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_stateprovince_createdby")]
    public SystemUser lk_ait_stateprovince_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_stateprovince_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_stateprovince_createdonbehalfby")]
    public SystemUser lk_ait_stateprovince_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_stateprovince_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_stateprovince_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_stateprovince_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_stateprovince_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_stateprovince_modifiedby")]
    public SystemUser lk_ait_stateprovince_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_stateprovince_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_stateprovince_modifiedonbehalfby")]
    public SystemUser lk_ait_stateprovince_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_stateprovince_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_stateprovince_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_stateprovince_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_stateprovince_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_stateprovince")]
    public Organization organization_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_stateprovince), new EntityRole?());
      }
    }

    public ait_stateprovince(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_stateprovinceid"] = (object) base.Id;
            break;
          case "ait_stateprovinceid":
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
