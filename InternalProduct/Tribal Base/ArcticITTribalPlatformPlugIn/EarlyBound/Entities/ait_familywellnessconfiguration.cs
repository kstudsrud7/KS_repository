// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_familywellnessconfiguration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_familywellnessconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_familywellnessconfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_familywellnessconfiguration";
    public const string EntitySchemaName = "ait_familywellnessconfiguration";
    public const string PrimaryIdAttribute = "ait_familywellnessconfigurationid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_familywellnessconfiguration()
      : base(nameof (ait_familywellnessconfiguration))
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

    [AttributeLogicalName("ait_agreementdetails")]
    public string ait_Agreementdetails
    {
      get => this.GetAttributeValue<string>("ait_agreementdetails");
      set
      {
        this.OnPropertyChanging(nameof (ait_Agreementdetails));
        this.SetAttributeValue("ait_agreementdetails", (object) value);
        this.OnPropertyChanged(nameof (ait_Agreementdetails));
      }
    }

    [AttributeLogicalName("ait_biareportingyear")]
    public DateTime? ait_BIAReportingYear
    {
      get => this.GetAttributeValue<DateTime?>("ait_biareportingyear");
      set
      {
        this.OnPropertyChanging(nameof (ait_BIAReportingYear));
        this.SetAttributeValue("ait_biareportingyear", (object) value);
        this.OnPropertyChanged(nameof (ait_BIAReportingYear));
      }
    }

    [AttributeLogicalName("ait_contractexpiration")]
    public DateTime? ait_ContractExpiration
    {
      get => this.GetAttributeValue<DateTime?>("ait_contractexpiration");
      set
      {
        this.OnPropertyChanging(nameof (ait_ContractExpiration));
        this.SetAttributeValue("ait_contractexpiration", (object) value);
        this.OnPropertyChanged(nameof (ait_ContractExpiration));
      }
    }

    [AttributeLogicalName("ait_entityimage")]
    public byte[] ait_EntityImage
    {
      get => this.GetAttributeValue<byte[]>("ait_entityimage");
      set
      {
        this.OnPropertyChanging(nameof (ait_EntityImage));
        this.SetAttributeValue("ait_entityimage", (object) value);
        this.OnPropertyChanged(nameof (ait_EntityImage));
      }
    }

    [AttributeLogicalName("ait_entityimage_timestamp")]
    public long? ait_EntityImage_Timestamp
    {
      get => this.GetAttributeValue<long?>("ait_entityimage_timestamp");
    }

    [AttributeLogicalName("ait_entityimage_url")]
    public string ait_EntityImage_URL => this.GetAttributeValue<string>("ait_entityimage_url");

    [AttributeLogicalName("ait_entityimageid")]
    public Guid? ait_EntityImageId => this.GetAttributeValue<Guid?>("ait_entityimageid");

    [AttributeLogicalName("ait_entityimagestring")]
    public string ait_EntityImageString
    {
      get => this.GetAttributeValue<string>("ait_entityimagestring");
      set
      {
        this.OnPropertyChanging(nameof (ait_EntityImageString));
        this.SetAttributeValue("ait_entityimagestring", (object) value);
        this.OnPropertyChanged(nameof (ait_EntityImageString));
      }
    }

    [AttributeLogicalName("ait_familywellnessconfigurationid")]
    public Guid? ait_familywellnessconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("ait_familywellnessconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfigurationId));
        this.SetAttributeValue("ait_familywellnessconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_familywellnessconfigurationId));
      }
    }

    [AttributeLogicalName("ait_familywellnessconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_familywellnessconfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("ait_fwmode")]
    public OptionSetValue ait_FWMode
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_fwmode");
      set
      {
        this.OnPropertyChanging(nameof (ait_FWMode));
        this.SetAttributeValue("ait_fwmode", (object) value);
        this.OnPropertyChanged(nameof (ait_FWMode));
      }
    }

    [AttributeLogicalName("ait_icwacontractgrantnumber")]
    public string ait_ICWAContractGrantNumber
    {
      get => this.GetAttributeValue<string>("ait_icwacontractgrantnumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_ICWAContractGrantNumber));
        this.SetAttributeValue("ait_icwacontractgrantnumber", (object) value);
        this.OnPropertyChanged(nameof (ait_ICWAContractGrantNumber));
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

    [AttributeLogicalName("ait_nextbiareportdate")]
    public DateTime? ait_NextBIAReportDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_nextbiareportdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_NextBIAReportDate));
        this.SetAttributeValue("ait_nextbiareportdate", (object) value);
        this.OnPropertyChanged(nameof (ait_NextBIAReportDate));
      }
    }

    [AttributeLogicalName("ait_productkey")]
    public string ait_ProductKey
    {
      get => this.GetAttributeValue<string>("ait_productkey");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProductKey));
        this.SetAttributeValue("ait_productkey", (object) value);
        this.OnPropertyChanged(nameof (ait_ProductKey));
      }
    }

    [AttributeLogicalName("ait_reportsheader")]
    public string ait_ReportsHeader
    {
      get => this.GetAttributeValue<string>("ait_reportsheader");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReportsHeader));
        this.SetAttributeValue("ait_reportsheader", (object) value);
        this.OnPropertyChanged(nameof (ait_ReportsHeader));
      }
    }

    [AttributeLogicalName("ait_reportsheader2")]
    public string ait_ReportsHeader2
    {
      get => this.GetAttributeValue<string>("ait_reportsheader2");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReportsHeader2));
        this.SetAttributeValue("ait_reportsheader2", (object) value);
        this.OnPropertyChanged(nameof (ait_ReportsHeader2));
      }
    }

    [AttributeLogicalName("ait_tribalstateagreements")]
    public bool? ait_TribalStateAgreements
    {
      get => this.GetAttributeValue<bool?>("ait_tribalstateagreements");
      set
      {
        this.OnPropertyChanging(nameof (ait_TribalStateAgreements));
        this.SetAttributeValue("ait_tribalstateagreements", (object) value);
        this.OnPropertyChanged(nameof (ait_TribalStateAgreements));
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
    public ait_familywellnessconfigurationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_familywellnessconfigurationState?((ait_familywellnessconfigurationState) Enum.ToObject(typeof (ait_familywellnessconfigurationState), attributeValue.Value)) : new ait_familywellnessconfigurationState?();
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

    [RelationshipSchemaName("ait_familywellnessconfiguration_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_familywellnessconfiguration_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_familywellnessconfiguration_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_familywellnessconfiguration_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_familywellnessconfiguration_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_familywellnessconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_familywellnessconfiguration_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_familywellnessconfiguration_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_familywellnessconfiguration_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_familywellnessconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_familywellnessconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_familywellnessconfiguration_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_familywellnessconfiguration_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_familywellnessconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_familywellnessconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_familywellnessconfiguration_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_familywellnessconfiguration_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_familywellnessconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_familywellnessconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_familywellnessconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_familywellnessconfiguration_ProcessSession")]
    public IEnumerable<ProcessSession> ait_familywellnessconfiguration_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_familywellnessconfiguration_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_familywellnessconfiguration_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_familywellnessconfiguration_SyncErrors")]
    public IEnumerable<SyncError> ait_familywellnessconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_familywellnessconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_familywellnessconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_familywellnessconfiguration_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_familywellnessconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_familywellnessconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_familywellnessconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_createdby")]
    public SystemUser lk_ait_familywellnessconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_createdonbehalfby")]
    public SystemUser lk_ait_familywellnessconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familywellnessconfiguration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_modifiedby")]
    public SystemUser lk_ait_familywellnessconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_familywellnessconfiguration_modifiedonbehalfby")]
    public SystemUser lk_ait_familywellnessconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_familywellnessconfiguration_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_familywellnessconfiguration")]
    public Organization organization_ait_familywellnessconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_familywellnessconfiguration), new EntityRole?());
      }
    }

    public ait_familywellnessconfiguration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_familywellnessconfigurationid"] = (object) base.Id;
            break;
          case "ait_familywellnessconfigurationid":
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
