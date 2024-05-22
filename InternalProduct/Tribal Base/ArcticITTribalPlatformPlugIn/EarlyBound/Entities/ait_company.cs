// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_company
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_company")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_company : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_company";
    public const string EntitySchemaName = "ait_company";
    public const string PrimaryIdAttribute = "ait_companyid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_company()
      : base(nameof (ait_company))
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

    [AttributeLogicalName("ait_companyid")]
    public Guid? ait_companyId
    {
      get => this.GetAttributeValue<Guid?>("ait_companyid");
      set
      {
        this.OnPropertyChanging(nameof (ait_companyId));
        this.SetAttributeValue("ait_companyid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_companyId));
      }
    }

    [AttributeLogicalName("ait_companyid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_companyId = new Guid?(value);
    }

    [AttributeLogicalName("ait_companytype")]
    public OptionSetValue ait_companytype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_companytype));
      set
      {
        this.OnPropertyChanging(nameof (ait_companytype));
        this.SetAttributeValue(nameof (ait_companytype), (object) value);
        this.OnPropertyChanged(nameof (ait_companytype));
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

    [AttributeLogicalName("ait_primaryaddress")]
    public string ait_primaryaddress
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryaddress));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryaddress));
        this.SetAttributeValue(nameof (ait_primaryaddress), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryaddress));
      }
    }

    [AttributeLogicalName("ait_primaryemail")]
    public string ait_primaryemail
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryemail));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryemail));
        this.SetAttributeValue(nameof (ait_primaryemail), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryemail));
      }
    }

    [AttributeLogicalName("ait_primaryphone")]
    public string ait_primaryphone
    {
      get => this.GetAttributeValue<string>(nameof (ait_primaryphone));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryphone));
        this.SetAttributeValue(nameof (ait_primaryphone), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryphone));
      }
    }

    [AttributeLogicalName("ait_prmaryaddress")]
    public string ait_prmaryaddress
    {
      get => this.GetAttributeValue<string>(nameof (ait_prmaryaddress));
      set
      {
        this.OnPropertyChanging(nameof (ait_prmaryaddress));
        this.SetAttributeValue(nameof (ait_prmaryaddress), (object) value);
        this.OnPropertyChanged(nameof (ait_prmaryaddress));
      }
    }

    [AttributeLogicalName("ait_tribeowned")]
    public EntityReference ait_tribeowned
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_tribeowned));
      set
      {
        this.OnPropertyChanging(nameof (ait_tribeowned));
        this.SetAttributeValue(nameof (ait_tribeowned), (object) value);
        this.OnPropertyChanged(nameof (ait_tribeowned));
      }
    }

    [AttributeLogicalName("ait_vendornumber")]
    public string ait_vendornumber
    {
      get => this.GetAttributeValue<string>(nameof (ait_vendornumber));
      set
      {
        this.OnPropertyChanging(nameof (ait_vendornumber));
        this.SetAttributeValue(nameof (ait_vendornumber), (object) value);
        this.OnPropertyChanged(nameof (ait_vendornumber));
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
    public ait_companyState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_companyState?((ait_companyState) Enum.ToObject(typeof (ait_companyState), attributeValue.Value)) : new ait_companyState?();
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

    [RelationshipSchemaName("ait_ait_certification_ait_company")]
    public IEnumerable<ait_certification> ait_ait_certification_ait_company
    {
      get
      {
        return this.GetRelatedEntities<ait_certification>(nameof (ait_ait_certification_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_certification_ait_company));
        this.SetRelatedEntities<ait_certification>(nameof (ait_ait_certification_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_certification_ait_company));
      }
    }

    [RelationshipSchemaName("ait_ait_company_ait_courtprofile_Company")]
    public IEnumerable<ait_courtprofile> ait_ait_company_ait_courtprofile_Company
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofile>(nameof (ait_ait_company_ait_courtprofile_Company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_company_ait_courtprofile_Company));
        this.SetRelatedEntities<ait_courtprofile>(nameof (ait_ait_company_ait_courtprofile_Company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_company_ait_courtprofile_Company));
      }
    }

    [RelationshipSchemaName("ait_ait_contactemployment_ait_company")]
    public IEnumerable<ait_contactemployment> ait_ait_contactemployment_ait_company
    {
      get
      {
        return this.GetRelatedEntities<ait_contactemployment>(nameof (ait_ait_contactemployment_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactemployment_ait_company));
        this.SetRelatedEntities<ait_contactemployment>(nameof (ait_ait_contactemployment_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactemployment_ait_company));
      }
    }

    [RelationshipSchemaName("ait_ait_contactincarceration_ait_company")]
    public IEnumerable<ait_contactincarceration> ait_ait_contactincarceration_ait_company
    {
      get
      {
        return this.GetRelatedEntities<ait_contactincarceration>(nameof (ait_ait_contactincarceration_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_contactincarceration_ait_company));
        this.SetRelatedEntities<ait_contactincarceration>(nameof (ait_ait_contactincarceration_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_contactincarceration_ait_company));
      }
    }

    [RelationshipSchemaName("ait_ait_electronicaddress_ait_company")]
    public IEnumerable<ait_electronicaddress> ait_ait_electronicaddress_ait_company
    {
      get
      {
        return this.GetRelatedEntities<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_electronicaddress_ait_company));
        this.SetRelatedEntities<ait_electronicaddress>(nameof (ait_ait_electronicaddress_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_electronicaddress_ait_company));
      }
    }

    [RelationshipSchemaName("ait_ait_physicaladdress_ait_company")]
    public IEnumerable<ait_physicaladdress> ait_ait_physicaladdress_ait_company
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_physicaladdress_ait_company));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (ait_ait_physicaladdress_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_physicaladdress_ait_company));
      }
    }

    [RelationshipSchemaName("ait_company_ait_clientprofile_DentalInsuranceProvider")]
    public IEnumerable<ait_clientprofile> ait_company_ait_clientprofile_DentalInsuranceProvider
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_company_ait_clientprofile_DentalInsuranceProvider), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_clientprofile_DentalInsuranceProvider));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_company_ait_clientprofile_DentalInsuranceProvider), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_clientprofile_DentalInsuranceProvider));
      }
    }

    [RelationshipSchemaName("ait_company_ait_clientprofile_InsuranceProvider_company")]
    public IEnumerable<ait_clientprofile> ait_company_ait_clientprofile_InsuranceProvider_company
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_company_ait_clientprofile_InsuranceProvider_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_clientprofile_InsuranceProvider_company));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_company_ait_clientprofile_InsuranceProvider_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_clientprofile_InsuranceProvider_company));
      }
    }

    [RelationshipSchemaName("ait_company_ait_clientprofile_Pharmacy")]
    public IEnumerable<ait_clientprofile> ait_company_ait_clientprofile_Pharmacy
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_company_ait_clientprofile_Pharmacy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_clientprofile_Pharmacy));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_company_ait_clientprofile_Pharmacy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_clientprofile_Pharmacy));
      }
    }

    [RelationshipSchemaName("ait_company_ait_clientprofile_PrimaryMedicalFacility")]
    public IEnumerable<ait_clientprofile> ait_company_ait_clientprofile_PrimaryMedicalFacility
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (ait_company_ait_clientprofile_PrimaryMedicalFacility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_clientprofile_PrimaryMedicalFacility));
        this.SetRelatedEntities<ait_clientprofile>(nameof (ait_company_ait_clientprofile_PrimaryMedicalFacility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_clientprofile_PrimaryMedicalFacility));
      }
    }

    [RelationshipSchemaName("ait_company_ait_icwanotice_RequestorCompany")]
    public IEnumerable<ait_icwanotice> ait_company_ait_icwanotice_RequestorCompany
    {
      get
      {
        return this.GetRelatedEntities<ait_icwanotice>(nameof (ait_company_ait_icwanotice_RequestorCompany), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_icwanotice_RequestorCompany));
        this.SetRelatedEntities<ait_icwanotice>(nameof (ait_company_ait_icwanotice_RequestorCompany), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_icwanotice_RequestorCompany));
      }
    }

    [RelationshipSchemaName("ait_company_ait_incident_ReportingOrganization_company")]
    public IEnumerable<ait_incident> ait_company_ait_incident_ReportingOrganization_company
    {
      get
      {
        return this.GetRelatedEntities<ait_incident>(nameof (ait_company_ait_incident_ReportingOrganization_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_incident_ReportingOrganization_company));
        this.SetRelatedEntities<ait_incident>(nameof (ait_company_ait_incident_ReportingOrganization_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_incident_ReportingOrganization_company));
      }
    }

    [RelationshipSchemaName("ait_company_ait_medicalproviders_ProviderName_company")]
    public IEnumerable<ait_medicalproviders> ait_company_ait_medicalproviders_ProviderName_company
    {
      get
      {
        return this.GetRelatedEntities<ait_medicalproviders>(nameof (ait_company_ait_medicalproviders_ProviderName_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_medicalproviders_ProviderName_company));
        this.SetRelatedEntities<ait_medicalproviders>(nameof (ait_company_ait_medicalproviders_ProviderName_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_medicalproviders_ProviderName_company));
      }
    }

    [RelationshipSchemaName("ait_company_ait_payment_payeecompany")]
    public IEnumerable<ait_payment> ait_company_ait_payment_payeecompany
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_company_ait_payment_payeecompany), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_payment_payeecompany));
        this.SetRelatedEntities<ait_payment>(nameof (ait_company_ait_payment_payeecompany), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_payment_payeecompany));
      }
    }

    [RelationshipSchemaName("ait_company_ait_placementlocation_PlacementLocationCompany")]
    public IEnumerable<ait_placementlocation> ait_company_ait_placementlocation_PlacementLocationCompany
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (ait_company_ait_placementlocation_PlacementLocationCompany), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_placementlocation_PlacementLocationCompany));
        this.SetRelatedEntities<ait_placementlocation>(nameof (ait_company_ait_placementlocation_PlacementLocationCompany), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_placementlocation_PlacementLocationCompany));
      }
    }

    [RelationshipSchemaName("ait_company_ait_referral_referredtocompany")]
    public IEnumerable<ait_referral> ait_company_ait_referral_referredtocompany
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_company_ait_referral_referredtocompany), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_referral_referredtocompany));
        this.SetRelatedEntities<ait_referral>(nameof (ait_company_ait_referral_referredtocompany), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_referral_referredtocompany));
      }
    }

    [RelationshipSchemaName("ait_company_Annotations")]
    public IEnumerable<Annotation> ait_company_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_company_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_company_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_Annotations));
      }
    }

    [RelationshipSchemaName("ait_company_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_company_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_company_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_company_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_company_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_company_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_company_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_company_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_company_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_company_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_company_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_company_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_company_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_company_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_company_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_company_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_company_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_company_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_company_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_company_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_company_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_company_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_company_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_company_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_company_ProcessSession")]
    public IEnumerable<ProcessSession> ait_company_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_company_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_company_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_company_SyncErrors")]
    public IEnumerable<SyncError> ait_company_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_company_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_company_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_company_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_company_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_company_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_company_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_company_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_tribeowned")]
    [RelationshipSchemaName("ait_ait_tribe_ait_company_tribeowned")]
    public ait_tribe ait_ait_tribe_ait_company_tribeowned
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_ait_tribe_ait_company_tribeowned), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_company_tribeowned));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_ait_tribe_ait_company_tribeowned), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_company_tribeowned));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_company")]
    public BusinessUnit business_unit_ait_company
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_company), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_company_createdby")]
    public SystemUser lk_ait_company_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_company_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_company_createdonbehalfby")]
    public SystemUser lk_ait_company_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_company_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_company_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_company_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_company_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_company_modifiedby")]
    public SystemUser lk_ait_company_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_company_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_company_modifiedonbehalfby")]
    public SystemUser lk_ait_company_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_company_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_company_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_company_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_company_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_company")]
    public Team team_ait_company
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_company), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_company")]
    public SystemUser user_ait_company
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_company), new EntityRole?());
    }

    public ait_company(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_companyid"] = (object) base.Id;
            break;
          case "ait_companyid":
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
