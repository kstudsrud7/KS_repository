// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_city
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_city")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_city : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_city";
    public const string EntitySchemaName = "ait_city";
    public const string PrimaryIdAttribute = "ait_cityid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_city()
      : base(nameof (ait_city))
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

    [AttributeLogicalName("ait_cityid")]
    public Guid? ait_cityId
    {
      get => this.GetAttributeValue<Guid?>("ait_cityid");
      set
      {
        this.OnPropertyChanging(nameof (ait_cityId));
        this.SetAttributeValue("ait_cityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_cityId));
      }
    }

    [AttributeLogicalName("ait_cityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_cityId = new Guid?(value);
    }

    [AttributeLogicalName("ait_citytype")]
    public OptionSetValue ait_citytype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_citytype));
      set
      {
        this.OnPropertyChanging(nameof (ait_citytype));
        this.SetAttributeValue(nameof (ait_citytype), (object) value);
        this.OnPropertyChanged(nameof (ait_citytype));
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

    [AttributeLogicalName("ait_households")]
    public int? ait_households
    {
      get => this.GetAttributeValue<int?>(nameof (ait_households));
      set
      {
        this.OnPropertyChanging(nameof (ait_households));
        this.SetAttributeValue(nameof (ait_households), (object) value);
        this.OnPropertyChanged(nameof (ait_households));
      }
    }

    [AttributeLogicalName("ait_latitude")]
    public double? ait_latitude
    {
      get => this.GetAttributeValue<double?>(nameof (ait_latitude));
      set
      {
        this.OnPropertyChanging(nameof (ait_latitude));
        this.SetAttributeValue(nameof (ait_latitude), (object) value);
        this.OnPropertyChanged(nameof (ait_latitude));
      }
    }

    [AttributeLogicalName("ait_longitude")]
    public double? ait_longitude
    {
      get => this.GetAttributeValue<double?>(nameof (ait_longitude));
      set
      {
        this.OnPropertyChanging(nameof (ait_longitude));
        this.SetAttributeValue(nameof (ait_longitude), (object) value);
        this.OnPropertyChanged(nameof (ait_longitude));
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

    [AttributeLogicalName("ait_population")]
    public int? ait_population
    {
      get => this.GetAttributeValue<int?>(nameof (ait_population));
      set
      {
        this.OnPropertyChanging(nameof (ait_population));
        this.SetAttributeValue(nameof (ait_population), (object) value);
        this.OnPropertyChanged(nameof (ait_population));
      }
    }

    [AttributeLogicalName("ait_stateprovince")]
    public EntityReference ait_stateprovince
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_stateprovince));
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince));
        this.SetAttributeValue(nameof (ait_stateprovince), (object) value);
        this.OnPropertyChanged(nameof (ait_stateprovince));
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
    public ait_cityState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_cityState?((ait_cityState) Enum.ToObject(typeof (ait_cityState), attributeValue.Value)) : new ait_cityState?();
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

    [RelationshipSchemaName("ait_ait_birthrecord_ait_city")]
    public IEnumerable<ait_birthrecord> ait_ait_birthrecord_ait_city
    {
      get
      {
        return this.GetRelatedEntities<ait_birthrecord>(nameof (ait_ait_birthrecord_ait_city), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_birthrecord_ait_city));
        this.SetRelatedEntities<ait_birthrecord>(nameof (ait_ait_birthrecord_ait_city), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_birthrecord_ait_city));
      }
    }

    [RelationshipSchemaName("ait_ait_city_ait_birthrecord_amendedcity")]
    public IEnumerable<ait_birthrecord> ait_ait_city_ait_birthrecord_amendedcity
    {
      get
      {
        return this.GetRelatedEntities<ait_birthrecord>(nameof (ait_ait_city_ait_birthrecord_amendedcity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_birthrecord_amendedcity));
        this.SetRelatedEntities<ait_birthrecord>(nameof (ait_ait_city_ait_birthrecord_amendedcity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_birthrecord_amendedcity));
      }
    }

    [RelationshipSchemaName("ait_ait_city_ait_changerequest_City_Approved")]
    public IEnumerable<ait_changerequest> ait_ait_city_ait_changerequest_City_Approved
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (ait_ait_city_ait_changerequest_City_Approved), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_changerequest_City_Approved));
        this.SetRelatedEntities<ait_changerequest>(nameof (ait_ait_city_ait_changerequest_City_Approved), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_changerequest_City_Approved));
      }
    }

    [RelationshipSchemaName("ait_ait_city_ait_deathrecord_deathcity")]
    public IEnumerable<ait_deathrecord> ait_ait_city_ait_deathrecord_deathcity
    {
      get
      {
        return this.GetRelatedEntities<ait_deathrecord>(nameof (ait_ait_city_ait_deathrecord_deathcity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_deathrecord_deathcity));
        this.SetRelatedEntities<ait_deathrecord>(nameof (ait_ait_city_ait_deathrecord_deathcity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_deathrecord_deathcity));
      }
    }

    [RelationshipSchemaName("ait_ait_city_ait_tribe")]
    public IEnumerable<ait_tribe> ait_ait_city_ait_tribe
    {
      get => this.GetRelatedEntities<ait_tribe>(nameof (ait_ait_city_ait_tribe), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_tribe));
        this.SetRelatedEntities<ait_tribe>(nameof (ait_ait_city_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_tribe));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_city")]
    public IEnumerable<ait_physicaladdress> ait_ait_physicaladdress_ait_city
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_city), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_city));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_city), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_city));
      }
    }

    [RelationshipSchemaName("ait_ait_zipcodecity_ait_city")]
    public IEnumerable<ait_zipcodecity> ait_ait_zipcodecity_ait_city
    {
      get
      {
        return this.GetRelatedEntities<ait_zipcodecity>(nameof (ait_ait_zipcodecity_ait_city), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_zipcodecity_ait_city));
        this.SetRelatedEntities<ait_zipcodecity>(nameof (ait_ait_zipcodecity_ait_city), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_zipcodecity_ait_city));
      }
    }

    [RelationshipSchemaName("ait_city_ait_courtprofileaddress_CityLookup")]
    public IEnumerable<ait_courtprofileaddress> ait_city_ait_courtprofileaddress_CityLookup
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (ait_city_ait_courtprofileaddress_CityLookup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_ait_courtprofileaddress_CityLookup));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (ait_city_ait_courtprofileaddress_CityLookup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_ait_courtprofileaddress_CityLookup));
      }
    }

    [RelationshipSchemaName("ait_city_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_city_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_city_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_city_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_city_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_city_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_city_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_city_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_city_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_city_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_city_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_city_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_city_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_city_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_city_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_city_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_city_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_city_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_city_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_city_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_city_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_city_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_city_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_city_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_city_ProcessSession")]
    public IEnumerable<ProcessSession> ait_city_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_city_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_city_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_city_SyncErrors")]
    public IEnumerable<SyncError> ait_city_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_city_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_city_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_city_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_city_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_city_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_city_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_city_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_county")]
    [RelationshipSchemaName("ait_ait_city_ait_county")]
    public ArcticIT.EarlyBound.Entities.ait_county ait_ait_city_ait_county
    {
      get => this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_county>(nameof (ait_ait_city_ait_county), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_county));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_county>(nameof (ait_ait_city_ait_county), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_county));
      }
    }

    [AttributeLogicalName("ait_stateprovince")]
    [RelationshipSchemaName("ait_ait_city_ait_stateprovince")]
    public ArcticIT.EarlyBound.Entities.ait_stateprovince ait_ait_city_ait_stateprovince
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_stateprovince>(nameof (ait_ait_city_ait_stateprovince), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_city_ait_stateprovince));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_stateprovince>(nameof (ait_ait_city_ait_stateprovince), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_city_ait_stateprovince));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_city_createdby")]
    public SystemUser lk_ait_city_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_city_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_city_createdonbehalfby")]
    public SystemUser lk_ait_city_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_city_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_city_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_city_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_city_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_city_modifiedby")]
    public SystemUser lk_ait_city_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_city_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_city_modifiedonbehalfby")]
    public SystemUser lk_ait_city_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_city_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_city_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_city_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_city_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_city")]
    public Organization organization_ait_city
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_ait_city), new EntityRole?());
    }

    public ait_city(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_cityid"] = (object) base.Id;
            break;
          case "ait_cityid":
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
