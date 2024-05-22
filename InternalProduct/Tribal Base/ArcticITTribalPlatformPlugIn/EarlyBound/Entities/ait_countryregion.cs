// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_countryregion
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_countryregion")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_countryregion : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_countryregion";
    public const string EntitySchemaName = "ait_countryregion";
    public const string PrimaryIdAttribute = "ait_countryregionid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_countryregion()
      : base(nameof (ait_countryregion))
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

    [AttributeLogicalName("ait_countryregionid")]
    public Guid? ait_countryregionId
    {
      get => this.GetAttributeValue<Guid?>("ait_countryregionid");
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregionId));
        this.SetAttributeValue("ait_countryregionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_countryregionId));
      }
    }

    [AttributeLogicalName("ait_countryregionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_countryregionId = new Guid?(value);
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
    public ait_countryregionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_countryregionState?((ait_countryregionState) Enum.ToObject(typeof (ait_countryregionState), attributeValue.Value)) : new ait_countryregionState?();
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

    [RelationshipSchemaName("ait_ait_birthrecord_ait_countryregion")]
    public IEnumerable<ait_birthrecord> ait_ait_birthrecord_ait_countryregion
    {
      get
      {
        return this.GetRelatedEntities<ait_birthrecord>(nameof (ait_ait_birthrecord_ait_countryregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_birthrecord_ait_countryregion));
        this.SetRelatedEntities<ait_birthrecord>(nameof (ait_ait_birthrecord_ait_countryregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_birthrecord_ait_countryregion));
      }
    }

    [RelationshipSchemaName("ait_ait_countryregion_ait_birthrecord_amendedcountry")]
    public IEnumerable<ait_birthrecord> ait_ait_countryregion_ait_birthrecord_amendedcountry
    {
      get
      {
        return this.GetRelatedEntities<ait_birthrecord>(nameof (ait_ait_countryregion_ait_birthrecord_amendedcountry), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_countryregion_ait_birthrecord_amendedcountry));
        this.SetRelatedEntities<ait_birthrecord>(nameof (ait_ait_countryregion_ait_birthrecord_amendedcountry), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_countryregion_ait_birthrecord_amendedcountry));
      }
    }

    [RelationshipSchemaName("ait_ait_countryregion_ait_deathrecord_deathcountry")]
    public IEnumerable<ait_deathrecord> ait_ait_countryregion_ait_deathrecord_deathcountry
    {
      get
      {
        return this.GetRelatedEntities<ait_deathrecord>(nameof (ait_ait_countryregion_ait_deathrecord_deathcountry), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_countryregion_ait_deathrecord_deathcountry));
        this.SetRelatedEntities<ait_deathrecord>(nameof (ait_ait_countryregion_ait_deathrecord_deathcountry), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_countryregion_ait_deathrecord_deathcountry));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_countryregion")]
    public IEnumerable<ait_physicaladdress> ait_ait_physicaladdress_ait_countryregion
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_countryregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_countryregion));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_countryregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_countryregion));
      }
    }

    [RelationshipSchemaName("ait_ait_stateprovince_ait_countryregion")]
    public IEnumerable<ait_stateprovince> ait_ait_stateprovince_ait_countryregion
    {
      get
      {
        return this.GetRelatedEntities<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_countryregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_stateprovince_ait_countryregion));
        this.SetRelatedEntities<ait_stateprovince>(nameof (ait_ait_stateprovince_ait_countryregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_stateprovince_ait_countryregion));
      }
    }

    [RelationshipSchemaName("ait_countryregion_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_countryregion_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_countryregion_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_countryregion_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_countryregion_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_countryregion_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_countryregion_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_countryregion_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_countryregion_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_countryregion_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_countryregion_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_countryregion_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_countryregion_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_countryregion_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_countryregion_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_countryregion_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_countryregion_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_countryregion_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_countryregion_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_countryregion_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_countryregion_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_countryregion_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_countryregion_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_countryregion_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_countryregion_ProcessSession")]
    public IEnumerable<ProcessSession> ait_countryregion_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_countryregion_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_countryregion_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_countryregion_SyncErrors")]
    public IEnumerable<SyncError> ait_countryregion_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_countryregion_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_countryregion_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_countryregion_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_countryregion_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_countryregion_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_countryregion_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_countryregion_createdby")]
    public SystemUser lk_ait_countryregion_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_countryregion_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_countryregion_createdonbehalfby")]
    public SystemUser lk_ait_countryregion_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_countryregion_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_countryregion_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_countryregion_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_countryregion_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_countryregion_modifiedby")]
    public SystemUser lk_ait_countryregion_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_countryregion_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_countryregion_modifiedonbehalfby")]
    public SystemUser lk_ait_countryregion_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_countryregion_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_countryregion_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_countryregion_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_countryregion_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_countryregion")]
    public Organization organization_ait_countryregion
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_countryregion), new EntityRole?());
      }
    }

    public ait_countryregion(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_countryregionid"] = (object) base.Id;
            break;
          case "ait_countryregionid":
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
