// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_medicalproviders
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_medicalproviders")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_medicalproviders : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_medicalproviders";
    public const string EntitySchemaName = "ait_medicalproviders";
    public const string PrimaryIdAttribute = "ait_medicalprovidersid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_medicalproviders()
      : base(nameof (ait_medicalproviders))
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

    [AttributeLogicalName("ait_clientprofile")]
    public EntityReference ait_ClientProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_clientprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_ClientProfile));
        this.SetAttributeValue("ait_clientprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_ClientProfile));
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

    [AttributeLogicalName("ait_insurancegroupnumber")]
    public string ait_InsuranceGroupNumber
    {
      get => this.GetAttributeValue<string>("ait_insurancegroupnumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_InsuranceGroupNumber));
        this.SetAttributeValue("ait_insurancegroupnumber", (object) value);
        this.OnPropertyChanged(nameof (ait_InsuranceGroupNumber));
      }
    }

    [AttributeLogicalName("ait_insurancenumber")]
    public string ait_InsuranceNumber
    {
      get => this.GetAttributeValue<string>("ait_insurancenumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_InsuranceNumber));
        this.SetAttributeValue("ait_insurancenumber", (object) value);
        this.OnPropertyChanged(nameof (ait_InsuranceNumber));
      }
    }

    [AttributeLogicalName("ait_lastupdated")]
    public string ait_LastUpdated
    {
      get => this.GetAttributeValue<string>("ait_lastupdated");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastUpdated));
        this.SetAttributeValue("ait_lastupdated", (object) value);
        this.OnPropertyChanged(nameof (ait_LastUpdated));
      }
    }

    [AttributeLogicalName("ait_medicalprovidersid")]
    public Guid? ait_medicalprovidersId
    {
      get => this.GetAttributeValue<Guid?>("ait_medicalprovidersid");
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalprovidersId));
        this.SetAttributeValue("ait_medicalprovidersid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_medicalprovidersId));
      }
    }

    [AttributeLogicalName("ait_medicalprovidersid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_medicalprovidersId = new Guid?(value);
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

    [AttributeLogicalName("ait_providername_company")]
    public EntityReference ait_ProviderName_company
    {
      get => this.GetAttributeValue<EntityReference>("ait_providername_company");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProviderName_company));
        this.SetAttributeValue("ait_providername_company", (object) value);
        this.OnPropertyChanged(nameof (ait_ProviderName_company));
      }
    }

    [AttributeLogicalName("ait_providerstatus")]
    public OptionSetValue ait_ProviderStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_providerstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProviderStatus));
        this.SetAttributeValue("ait_providerstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_ProviderStatus));
      }
    }

    [AttributeLogicalName("ait_providertype")]
    public OptionSetValue ait_ProviderType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_providertype");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProviderType));
        this.SetAttributeValue("ait_providertype", (object) value);
        this.OnPropertyChanged(nameof (ait_ProviderType));
      }
    }

    [AttributeLogicalName("ait_roireceiveddate")]
    public DateTime? ait_ROIReceivedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_roireceiveddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ROIReceivedDate));
        this.SetAttributeValue("ait_roireceiveddate", (object) value);
        this.OnPropertyChanged(nameof (ait_ROIReceivedDate));
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
    public ait_medicalprovidersState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_medicalprovidersState?((ait_medicalprovidersState) Enum.ToObject(typeof (ait_medicalprovidersState), attributeValue.Value)) : new ait_medicalprovidersState?();
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

    [RelationshipSchemaName("ait_medicalproviders_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_medicalproviders_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_medicalproviders_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_medicalproviders_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_medicalproviders_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_medicalproviders_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_medicalproviders_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_medicalproviders_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_medicalproviders_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_medicalproviders_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_medicalproviders_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_medicalproviders_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_medicalproviders_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_medicalproviders_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_medicalproviders_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_medicalproviders_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_medicalproviders_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_medicalproviders_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_medicalproviders_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_ProcessSession")]
    public IEnumerable<ProcessSession> ait_medicalproviders_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_medicalproviders_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_medicalproviders_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_medicalproviders_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_medicalproviders_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_medicalproviders_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_medicalproviders_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_medicalproviders_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_medicalproviders_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_SyncErrors")]
    public IEnumerable<SyncError> ait_medicalproviders_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_medicalproviders_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_medicalproviders_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_medicalproviders_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_medicalproviders_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_medicalproviders_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_medicalproviders_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_medicalproviders_ClientProfile")]
    public ait_clientprofile ait_clientprofile_ait_medicalproviders_ClientProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_medicalproviders_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_medicalproviders_ClientProfile));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_medicalproviders_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_medicalproviders_ClientProfile));
      }
    }

    [AttributeLogicalName("ait_providername_company")]
    [RelationshipSchemaName("ait_company_ait_medicalproviders_ProviderName_company")]
    public ait_company ait_company_ait_medicalproviders_ProviderName_company
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_medicalproviders_ProviderName_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_medicalproviders_ProviderName_company));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_medicalproviders_ProviderName_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_medicalproviders_ProviderName_company));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_medicalproviders_createdby")]
    public SystemUser lk_ait_medicalproviders_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_medicalproviders_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_medicalproviders_createdonbehalfby")]
    public SystemUser lk_ait_medicalproviders_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_medicalproviders_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_medicalproviders_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_medicalproviders_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_medicalproviders_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_medicalproviders_modifiedby")]
    public SystemUser lk_ait_medicalproviders_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_medicalproviders_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_medicalproviders_modifiedonbehalfby")]
    public SystemUser lk_ait_medicalproviders_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_medicalproviders_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_medicalproviders_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_medicalproviders_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_medicalproviders_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_medicalproviders")]
    public Organization organization_ait_medicalproviders
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_medicalproviders), new EntityRole?());
      }
    }

    public ait_medicalproviders(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_medicalprovidersid"] = (object) base.Id;
            break;
          case "ait_medicalprovidersid":
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
