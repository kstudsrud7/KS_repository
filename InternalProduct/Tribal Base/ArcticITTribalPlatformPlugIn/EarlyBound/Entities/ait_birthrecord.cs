// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_birthrecord
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_birthrecord")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_birthrecord : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_birthrecord";
    public const string EntitySchemaName = "ait_birthrecord";
    public const string PrimaryIdAttribute = "ait_birthrecordid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_birthrecord()
      : base(nameof (ait_birthrecord))
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

    [AttributeLogicalName("ait_amendedbirthcertificateonfile")]
    public bool? ait_amendedbirthcertificateonfile
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_amendedbirthcertificateonfile));
      set
      {
        this.OnPropertyChanging(nameof (ait_amendedbirthcertificateonfile));
        this.SetAttributeValue(nameof (ait_amendedbirthcertificateonfile), (object) value);
        this.OnPropertyChanged(nameof (ait_amendedbirthcertificateonfile));
      }
    }

    [AttributeLogicalName("ait_amendedbirthcertificatereason")]
    public string ait_amendedbirthcertificatereason
    {
      get => this.GetAttributeValue<string>(nameof (ait_amendedbirthcertificatereason));
      set
      {
        this.OnPropertyChanging(nameof (ait_amendedbirthcertificatereason));
        this.SetAttributeValue(nameof (ait_amendedbirthcertificatereason), (object) value);
        this.OnPropertyChanged(nameof (ait_amendedbirthcertificatereason));
      }
    }

    [AttributeLogicalName("ait_amendedcity")]
    public EntityReference ait_amendedcity
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_amendedcity));
      set
      {
        this.OnPropertyChanging(nameof (ait_amendedcity));
        this.SetAttributeValue(nameof (ait_amendedcity), (object) value);
        this.OnPropertyChanged(nameof (ait_amendedcity));
      }
    }

    [AttributeLogicalName("ait_amendedcountryregion")]
    public EntityReference ait_amendedcountryregion
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_amendedcountryregion));
      set
      {
        this.OnPropertyChanging(nameof (ait_amendedcountryregion));
        this.SetAttributeValue(nameof (ait_amendedcountryregion), (object) value);
        this.OnPropertyChanged(nameof (ait_amendedcountryregion));
      }
    }

    [AttributeLogicalName("ait_amendedcounty")]
    public EntityReference ait_amendedcounty
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_amendedcounty));
      set
      {
        this.OnPropertyChanging(nameof (ait_amendedcounty));
        this.SetAttributeValue(nameof (ait_amendedcounty), (object) value);
        this.OnPropertyChanged(nameof (ait_amendedcounty));
      }
    }

    [AttributeLogicalName("ait_amendedstateprovince")]
    public EntityReference ait_amendedstateprovince
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_amendedstateprovince));
      set
      {
        this.OnPropertyChanging(nameof (ait_amendedstateprovince));
        this.SetAttributeValue(nameof (ait_amendedstateprovince), (object) value);
        this.OnPropertyChanged(nameof (ait_amendedstateprovince));
      }
    }

    [AttributeLogicalName("ait_birthcertificateonfile")]
    public OptionSetValue ait_birthcertificateonfile
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_birthcertificateonfile));
      set
      {
        this.OnPropertyChanging(nameof (ait_birthcertificateonfile));
        this.SetAttributeValue(nameof (ait_birthcertificateonfile), (object) value);
        this.OnPropertyChanged(nameof (ait_birthcertificateonfile));
      }
    }

    [AttributeLogicalName("ait_birthrecordid")]
    public Guid? ait_birthrecordId
    {
      get => this.GetAttributeValue<Guid?>("ait_birthrecordid");
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecordId));
        this.SetAttributeValue("ait_birthrecordid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_birthrecordId));
      }
    }

    [AttributeLogicalName("ait_birthrecordid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_birthrecordId = new Guid?(value);
    }

    [AttributeLogicalName("ait_city")]
    public EntityReference ait_city
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_city));
      set
      {
        this.OnPropertyChanging(nameof (ait_city));
        this.SetAttributeValue(nameof (ait_city), (object) value);
        this.OnPropertyChanged(nameof (ait_city));
      }
    }

    [AttributeLogicalName("ait_contact")]
    public EntityReference ait_Contact
    {
      get => this.GetAttributeValue<EntityReference>("ait_contact");
      set
      {
        this.OnPropertyChanging(nameof (ait_Contact));
        this.SetAttributeValue("ait_contact", (object) value);
        this.OnPropertyChanged(nameof (ait_Contact));
      }
    }

    [AttributeLogicalName("ait_country")]
    public EntityReference ait_country
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_country));
      set
      {
        this.OnPropertyChanging(nameof (ait_country));
        this.SetAttributeValue(nameof (ait_country), (object) value);
        this.OnPropertyChanged(nameof (ait_country));
      }
    }

    [AttributeLogicalName("ait_county")]
    public EntityReference ait_county
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_county));
      set
      {
        this.OnPropertyChanging(nameof (ait_county));
        this.SetAttributeValue(nameof (ait_county), (object) value);
        this.OnPropertyChanged(nameof (ait_county));
      }
    }

    [AttributeLogicalName("ait_dateofbirth")]
    public string ait_dateofbirth
    {
      get => this.GetAttributeValue<string>(nameof (ait_dateofbirth));
      set
      {
        this.OnPropertyChanging(nameof (ait_dateofbirth));
        this.SetAttributeValue(nameof (ait_dateofbirth), (object) value);
        this.OnPropertyChanged(nameof (ait_dateofbirth));
      }
    }

    [AttributeLogicalName("ait_dateofbirthinternal")]
    public DateTime? ait_dateofbirthinternal
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_dateofbirthinternal));
      set
      {
        this.OnPropertyChanging(nameof (ait_dateofbirthinternal));
        this.SetAttributeValue(nameof (ait_dateofbirthinternal), (object) value);
        this.OnPropertyChanged(nameof (ait_dateofbirthinternal));
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

    [AttributeLogicalName("ait_state")]
    public EntityReference ait_state
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_state));
      set
      {
        this.OnPropertyChanging(nameof (ait_state));
        this.SetAttributeValue(nameof (ait_state), (object) value);
        this.OnPropertyChanged(nameof (ait_state));
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
    public ait_birthrecordState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_birthrecordState?((ait_birthrecordState) Enum.ToObject(typeof (ait_birthrecordState), attributeValue.Value)) : new ait_birthrecordState?();
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

    [RelationshipSchemaName("ait_birthrecord_Annotations")]
    public IEnumerable<Annotation> ait_birthrecord_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_birthrecord_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_birthrecord_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_Annotations));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_birthrecord_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_birthrecord_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_birthrecord_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_birthrecord_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_birthrecord_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_birthrecord_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_birthrecord_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_birthrecord_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_birthrecord_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_birthrecord_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_birthrecord_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_birthrecord_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_birthrecord_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_birthrecord_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_birthrecord_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_birthrecord_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_birthrecord_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_birthrecord_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_ProcessSession")]
    public IEnumerable<ProcessSession> ait_birthrecord_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_birthrecord_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_birthrecord_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_SyncErrors")]
    public IEnumerable<SyncError> ait_birthrecord_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_birthrecord_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_birthrecord_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_birthrecord_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_birthrecord_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_birthrecord_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_birthrecord_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_contact_ait_birthrecord")]
    public IEnumerable<Contact> ait_contact_ait_birthrecord
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_contact_ait_birthrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_birthrecord));
        this.SetRelatedEntities<Contact>(nameof (ait_contact_ait_birthrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_birthrecord));
      }
    }

    [AttributeLogicalName("ait_city")]
    [RelationshipSchemaName("ait_ait_birthrecord_ait_city")]
    public ArcticIT.EarlyBound.Entities.ait_city ait_ait_birthrecord_ait_city
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_city>(nameof (ait_ait_birthrecord_ait_city), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_birthrecord_ait_city));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_city>(nameof (ait_ait_birthrecord_ait_city), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_birthrecord_ait_city));
      }
    }

    [AttributeLogicalName("ait_country")]
    [RelationshipSchemaName("ait_ait_birthrecord_ait_countryregion")]
    public ait_countryregion ait_ait_birthrecord_ait_countryregion
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_ait_birthrecord_ait_countryregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_birthrecord_ait_countryregion));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_ait_birthrecord_ait_countryregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_birthrecord_ait_countryregion));
      }
    }

    [AttributeLogicalName("ait_state")]
    [RelationshipSchemaName("ait_ait_birthrecord_ait_stateprovince")]
    public ait_stateprovince ait_ait_birthrecord_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_ait_birthrecord_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_birthrecord_ait_stateprovince));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_ait_birthrecord_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_birthrecord_ait_stateprovince));
      }
    }

    [AttributeLogicalName("ait_amendedcity")]
    [RelationshipSchemaName("ait_ait_city_ait_birthrecord_amendedcity")]
    public ArcticIT.EarlyBound.Entities.ait_city ait_ait_city_ait_birthrecord_amendedcity
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_city>(nameof (ait_ait_city_ait_birthrecord_amendedcity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_birthrecord_amendedcity));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_city>(nameof (ait_ait_city_ait_birthrecord_amendedcity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_birthrecord_amendedcity));
      }
    }

    [AttributeLogicalName("ait_amendedcountryregion")]
    [RelationshipSchemaName("ait_ait_countryregion_ait_birthrecord_amendedcountry")]
    public ait_countryregion ait_ait_countryregion_ait_birthrecord_amendedcountry
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_ait_countryregion_ait_birthrecord_amendedcountry), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_countryregion_ait_birthrecord_amendedcountry));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_ait_countryregion_ait_birthrecord_amendedcountry), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_countryregion_ait_birthrecord_amendedcountry));
      }
    }

    [AttributeLogicalName("ait_amendedcounty")]
    [RelationshipSchemaName("ait_ait_county_ait_birthrecord_amendedcounty")]
    public ArcticIT.EarlyBound.Entities.ait_county ait_ait_county_ait_birthrecord_amendedcounty
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_county>(nameof (ait_ait_county_ait_birthrecord_amendedcounty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_county_ait_birthrecord_amendedcounty));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_county>(nameof (ait_ait_county_ait_birthrecord_amendedcounty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_county_ait_birthrecord_amendedcounty));
      }
    }

    [AttributeLogicalName("ait_county")]
    [RelationshipSchemaName("ait_ait_county_ait_birthrecord_county")]
    public ArcticIT.EarlyBound.Entities.ait_county ait_ait_county_ait_birthrecord_county
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_county>(nameof (ait_ait_county_ait_birthrecord_county), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_county_ait_birthrecord_county));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_county>(nameof (ait_ait_county_ait_birthrecord_county), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_county_ait_birthrecord_county));
      }
    }

    [AttributeLogicalName("ait_amendedstateprovince")]
    [RelationshipSchemaName("ait_ait_stateprovince_ait_birthrecord_amendedstate")]
    public ait_stateprovince ait_ait_stateprovince_ait_birthrecord_amendedstate
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_birthrecord_amendedstate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_birthrecord_amendedstate));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_birthrecord_amendedstate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_birthrecord_amendedstate));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_contact_ait_birthrecord_Contact")]
    public Contact ait_contact_ait_birthrecord_Contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_birthrecord_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_birthrecord_Contact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_birthrecord_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_birthrecord_Contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_birthrecord")]
    public BusinessUnit business_unit_ait_birthrecord
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_birthrecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_birthrecord_createdby")]
    public SystemUser lk_ait_birthrecord_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_birthrecord_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_birthrecord_createdonbehalfby")]
    public SystemUser lk_ait_birthrecord_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_birthrecord_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_birthrecord_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_birthrecord_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_birthrecord_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_birthrecord_modifiedby")]
    public SystemUser lk_ait_birthrecord_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_birthrecord_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_birthrecord_modifiedonbehalfby")]
    public SystemUser lk_ait_birthrecord_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_birthrecord_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_birthrecord_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_birthrecord_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_birthrecord_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_birthrecord")]
    public Team team_ait_birthrecord
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_birthrecord), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_birthrecord")]
    public SystemUser user_ait_birthrecord
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_birthrecord), new EntityRole?());
    }

    public ait_birthrecord(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_birthrecordid"] = (object) base.Id;
            break;
          case "ait_birthrecordid":
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
