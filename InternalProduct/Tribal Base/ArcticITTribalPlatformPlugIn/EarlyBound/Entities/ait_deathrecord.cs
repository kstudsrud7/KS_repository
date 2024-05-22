// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_deathrecord
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_deathrecord")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_deathrecord : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_deathrecord";
    public const string EntitySchemaName = "ait_deathrecord";
    public const string PrimaryIdAttribute = "ait_deathrecordid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_deathrecord()
      : base(nameof (ait_deathrecord))
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

    [AttributeLogicalName("ait_causeofdeath")]
    public EntityReference ait_causeofdeath
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_causeofdeath));
      set
      {
        this.OnPropertyChanging(nameof (ait_causeofdeath));
        this.SetAttributeValue(nameof (ait_causeofdeath), (object) value);
        this.OnPropertyChanged(nameof (ait_causeofdeath));
      }
    }

    [AttributeLogicalName("ait_cemetary")]
    public EntityReference ait_cemetary
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_cemetary));
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary));
        this.SetAttributeValue(nameof (ait_cemetary), (object) value);
        this.OnPropertyChanged(nameof (ait_cemetary));
      }
    }

    [AttributeLogicalName("ait_cemetaryplot")]
    public string ait_cemetaryplot
    {
      get => this.GetAttributeValue<string>(nameof (ait_cemetaryplot));
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetaryplot));
        this.SetAttributeValue(nameof (ait_cemetaryplot), (object) value);
        this.OnPropertyChanged(nameof (ait_cemetaryplot));
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

    [AttributeLogicalName("ait_dateofdeath")]
    public string ait_dateofdeath
    {
      get => this.GetAttributeValue<string>(nameof (ait_dateofdeath));
      set
      {
        this.OnPropertyChanging(nameof (ait_dateofdeath));
        this.SetAttributeValue(nameof (ait_dateofdeath), (object) value);
        this.OnPropertyChanged(nameof (ait_dateofdeath));
      }
    }

    [AttributeLogicalName("ait_dateofdeathinternal")]
    public DateTime? ait_dateofdeathinternal
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_dateofdeathinternal));
      set
      {
        this.OnPropertyChanging(nameof (ait_dateofdeathinternal));
        this.SetAttributeValue(nameof (ait_dateofdeathinternal), (object) value);
        this.OnPropertyChanged(nameof (ait_dateofdeathinternal));
      }
    }

    [AttributeLogicalName("ait_deathcertificateonfile")]
    public OptionSetValue ait_deathcertificateonfile
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_deathcertificateonfile));
      set
      {
        this.OnPropertyChanging(nameof (ait_deathcertificateonfile));
        this.SetAttributeValue(nameof (ait_deathcertificateonfile), (object) value);
        this.OnPropertyChanged(nameof (ait_deathcertificateonfile));
      }
    }

    [AttributeLogicalName("ait_deathcity")]
    public EntityReference ait_deathcity
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_deathcity));
      set
      {
        this.OnPropertyChanging(nameof (ait_deathcity));
        this.SetAttributeValue(nameof (ait_deathcity), (object) value);
        this.OnPropertyChanged(nameof (ait_deathcity));
      }
    }

    [AttributeLogicalName("ait_deathcountry")]
    public EntityReference ait_deathcountry
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_deathcountry));
      set
      {
        this.OnPropertyChanging(nameof (ait_deathcountry));
        this.SetAttributeValue(nameof (ait_deathcountry), (object) value);
        this.OnPropertyChanged(nameof (ait_deathcountry));
      }
    }

    [AttributeLogicalName("ait_deathrecordid")]
    public Guid? ait_deathrecordId
    {
      get => this.GetAttributeValue<Guid?>("ait_deathrecordid");
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecordId));
        this.SetAttributeValue("ait_deathrecordid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_deathrecordId));
      }
    }

    [AttributeLogicalName("ait_deathrecordid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_deathrecordId = new Guid?(value);
    }

    [AttributeLogicalName("ait_deathstate")]
    public EntityReference ait_deathstate
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_deathstate));
      set
      {
        this.OnPropertyChanging(nameof (ait_deathstate));
        this.SetAttributeValue(nameof (ait_deathstate), (object) value);
        this.OnPropertyChanged(nameof (ait_deathstate));
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

    [AttributeLogicalName("ait_placeofdeath")]
    public string ait_placeofdeath
    {
      get => this.GetAttributeValue<string>(nameof (ait_placeofdeath));
      set
      {
        this.OnPropertyChanging(nameof (ait_placeofdeath));
        this.SetAttributeValue(nameof (ait_placeofdeath), (object) value);
        this.OnPropertyChanged(nameof (ait_placeofdeath));
      }
    }

    [AttributeLogicalName("ait_privatenotes")]
    public string ait_privatenotes
    {
      get => this.GetAttributeValue<string>(nameof (ait_privatenotes));
      set
      {
        this.OnPropertyChanging(nameof (ait_privatenotes));
        this.SetAttributeValue(nameof (ait_privatenotes), (object) value);
        this.OnPropertyChanged(nameof (ait_privatenotes));
      }
    }

    [AttributeLogicalName("ait_websitelink")]
    public string ait_websitelink
    {
      get => this.GetAttributeValue<string>(nameof (ait_websitelink));
      set
      {
        this.OnPropertyChanging(nameof (ait_websitelink));
        this.SetAttributeValue(nameof (ait_websitelink), (object) value);
        this.OnPropertyChanged(nameof (ait_websitelink));
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
    public ait_deathrecordState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_deathrecordState?((ait_deathrecordState) Enum.ToObject(typeof (ait_deathrecordState), attributeValue.Value)) : new ait_deathrecordState?();
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

    [RelationshipSchemaName("ait_contact_ait_deathrecord")]
    public IEnumerable<Contact> ait_contact_ait_deathrecord
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_contact_ait_deathrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_deathrecord));
        this.SetRelatedEntities<Contact>(nameof (ait_contact_ait_deathrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_deathrecord));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_Annotations")]
    public IEnumerable<Annotation> ait_deathrecord_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_deathrecord_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_deathrecord_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_Annotations));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_deathrecord_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_deathrecord_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_deathrecord_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_deathrecord_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_deathrecord_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_deathrecord_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_deathrecord_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_deathrecord_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_deathrecord_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_deathrecord_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_deathrecord_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_deathrecord_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_deathrecord_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_deathrecord_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_deathrecord_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_deathrecord_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_deathrecord_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_deathrecord_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_ProcessSession")]
    public IEnumerable<ProcessSession> ait_deathrecord_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_deathrecord_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_deathrecord_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_SyncErrors")]
    public IEnumerable<SyncError> ait_deathrecord_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_deathrecord_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_deathrecord_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_deathrecord_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_deathrecord_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_deathrecord_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_deathrecord_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_deathcity")]
    [RelationshipSchemaName("ait_ait_city_ait_deathrecord_deathcity")]
    public ait_city ait_ait_city_ait_deathrecord_deathcity
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_ait_city_ait_deathrecord_deathcity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_deathrecord_deathcity));
        this.SetRelatedEntity<ait_city>(nameof (ait_ait_city_ait_deathrecord_deathcity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_deathrecord_deathcity));
      }
    }

    [AttributeLogicalName("ait_deathcountry")]
    [RelationshipSchemaName("ait_ait_countryregion_ait_deathrecord_deathcountry")]
    public ait_countryregion ait_ait_countryregion_ait_deathrecord_deathcountry
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_ait_countryregion_ait_deathrecord_deathcountry), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_countryregion_ait_deathrecord_deathcountry));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_ait_countryregion_ait_deathrecord_deathcountry), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_countryregion_ait_deathrecord_deathcountry));
      }
    }

    [AttributeLogicalName("ait_causeofdeath")]
    [RelationshipSchemaName("ait_ait_deathrecord_ait_causeofdeath")]
    public ArcticIT.EarlyBound.Entities.ait_causeofdeath ait_ait_deathrecord_ait_causeofdeath
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_causeofdeath>(nameof (ait_ait_deathrecord_ait_causeofdeath), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_deathrecord_ait_causeofdeath));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_causeofdeath>(nameof (ait_ait_deathrecord_ait_causeofdeath), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_deathrecord_ait_causeofdeath));
      }
    }

    [AttributeLogicalName("ait_cemetary")]
    [RelationshipSchemaName("ait_ait_deathrecord_ait_cemetary")]
    public ArcticIT.EarlyBound.Entities.ait_cemetary ait_ait_deathrecord_ait_cemetary
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_cemetary>(nameof (ait_ait_deathrecord_ait_cemetary), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_deathrecord_ait_cemetary));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_cemetary>(nameof (ait_ait_deathrecord_ait_cemetary), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_deathrecord_ait_cemetary));
      }
    }

    [AttributeLogicalName("ait_deathstate")]
    [RelationshipSchemaName("ait_ait_stateprovince_ait_deathrecord_deathstate")]
    public ait_stateprovince ait_ait_stateprovince_ait_deathrecord_deathstate
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_deathrecord_deathstate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_deathrecord_deathstate));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_deathrecord_deathstate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_deathrecord_deathstate));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_contact_ait_deathrecord_Contact")]
    public Contact ait_contact_ait_deathrecord_Contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_deathrecord_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_deathrecord_Contact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_deathrecord_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_deathrecord_Contact));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_deathrecord")]
    public BusinessUnit business_unit_ait_deathrecord
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_deathrecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_deathrecord_createdby")]
    public SystemUser lk_ait_deathrecord_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_deathrecord_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_deathrecord_createdonbehalfby")]
    public SystemUser lk_ait_deathrecord_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_deathrecord_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_deathrecord_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_deathrecord_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_deathrecord_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_deathrecord_modifiedby")]
    public SystemUser lk_ait_deathrecord_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_deathrecord_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_deathrecord_modifiedonbehalfby")]
    public SystemUser lk_ait_deathrecord_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_deathrecord_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_deathrecord_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_deathrecord_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_deathrecord_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_deathrecord")]
    public Team team_ait_deathrecord
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_deathrecord), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_deathrecord")]
    public SystemUser user_ait_deathrecord
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_deathrecord), new EntityRole?());
    }

    public ait_deathrecord(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_deathrecordid"] = (object) base.Id;
            break;
          case "ait_deathrecordid":
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
