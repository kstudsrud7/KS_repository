// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_tribalenrollmentconfiguration
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_tribalenrollmentconfiguration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.71")]
  public class ait_tribalenrollmentconfiguration : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_tribalenrollmentconfiguration";
    public const string EntityLogicalCollectionName = "ait_tribalenrollmentconfigurations";
    public const string EntitySetName = "ait_tribalenrollmentconfigurations";
    public const int EntityTypeCode = 10400;

    public ait_tribalenrollmentconfiguration()
      : base(nameof (ait_tribalenrollmentconfiguration))
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

    [AttributeLogicalName("ait_adultage")]
    public int? ait_adultage
    {
      get => this.GetAttributeValue<int?>(nameof (ait_adultage));
      set
      {
        this.OnPropertyChanging(nameof (ait_adultage));
        this.SetAttributeValue(nameof (ait_adultage), (object) value);
        this.OnPropertyChanged(nameof (ait_adultage));
      }
    }

    [AttributeLogicalName("ait_bqcalculationmethod")]
    public Ait_bloodquantumcalculationmethod? ait_bqcalculationmethod
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (ait_bqcalculationmethod));
        return attributeValue != null ? new Ait_bloodquantumcalculationmethod?((Ait_bloodquantumcalculationmethod) Enum.ToObject(typeof (Ait_bloodquantumcalculationmethod), attributeValue.Value)) : new Ait_bloodquantumcalculationmethod?();
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bqcalculationmethod));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (ait_bqcalculationmethod), (object) null);
        else
          this.SetAttributeValue(nameof (ait_bqcalculationmethod), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (ait_bqcalculationmethod));
      }
    }

    [AttributeLogicalName("ait_bqmembershipthresholddecimal")]
    public Decimal? ait_bqmembershipthresholddecimal
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_bqmembershipthresholddecimal));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqmembershipthresholddecimal));
        this.SetAttributeValue(nameof (ait_bqmembershipthresholddecimal), (object) value);
        this.OnPropertyChanged(nameof (ait_bqmembershipthresholddecimal));
      }
    }

    [AttributeLogicalName("ait_bqmembershipthresholdfraction")]
    public string ait_bqmembershipthresholdfraction
    {
      get => this.GetAttributeValue<string>(nameof (ait_bqmembershipthresholdfraction));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqmembershipthresholdfraction));
        this.SetAttributeValue(nameof (ait_bqmembershipthresholdfraction), (object) value);
        this.OnPropertyChanged(nameof (ait_bqmembershipthresholdfraction));
      }
    }

    [AttributeLogicalName("ait_bqparentminimumdecimal")]
    public Decimal? ait_bqparentminimumdecimal
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_bqparentminimumdecimal));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqparentminimumdecimal));
        this.SetAttributeValue(nameof (ait_bqparentminimumdecimal), (object) value);
        this.OnPropertyChanged(nameof (ait_bqparentminimumdecimal));
      }
    }

    [AttributeLogicalName("ait_bqparentminimumfraction")]
    public string ait_bqparentminimumfraction
    {
      get => this.GetAttributeValue<string>(nameof (ait_bqparentminimumfraction));
      set
      {
        this.OnPropertyChanging(nameof (ait_bqparentminimumfraction));
        this.SetAttributeValue(nameof (ait_bqparentminimumfraction), (object) value);
        this.OnPropertyChanged(nameof (ait_bqparentminimumfraction));
      }
    }

    [AttributeLogicalName("ait_contactnaming")]
    public Ait_contactnaming? ait_contactnaming
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (ait_contactnaming));
        return attributeValue != null ? new Ait_contactnaming?((Ait_contactnaming) Enum.ToObject(typeof (Ait_contactnaming), attributeValue.Value)) : new Ait_contactnaming?();
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactnaming));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (ait_contactnaming), (object) null);
        else
          this.SetAttributeValue(nameof (ait_contactnaming), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (ait_contactnaming));
      }
    }

    [AttributeLogicalName("ait_courtdeployed")]
    public bool? ait_CourtDeployed
    {
      get => this.GetAttributeValue<bool?>("ait_courtdeployed");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtDeployed));
        this.SetAttributeValue("ait_courtdeployed", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtDeployed));
      }
    }

    [AttributeLogicalName("ait_defaulttribe")]
    public EntityReference ait_defaulttribe
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_defaulttribe));
      set
      {
        this.OnPropertyChanging(nameof (ait_defaulttribe));
        this.SetAttributeValue(nameof (ait_defaulttribe), (object) value);
        this.OnPropertyChanged(nameof (ait_defaulttribe));
      }
    }

    [AttributeLogicalName("ait_distributionpaymentsdeployed")]
    public bool? ait_DistributionPaymentsDeployed
    {
      get => this.GetAttributeValue<bool?>("ait_distributionpaymentsdeployed");
      set
      {
        this.OnPropertyChanging(nameof (ait_DistributionPaymentsDeployed));
        this.SetAttributeValue("ait_distributionpaymentsdeployed", (object) value);
        this.OnPropertyChanged(nameof (ait_DistributionPaymentsDeployed));
      }
    }

    [AttributeLogicalName("ait_educationdeployed")]
    public bool? ait_EducationDeployed
    {
      get => this.GetAttributeValue<bool?>("ait_educationdeployed");
      set
      {
        this.OnPropertyChanging(nameof (ait_EducationDeployed));
        this.SetAttributeValue("ait_educationdeployed", (object) value);
        this.OnPropertyChanged(nameof (ait_EducationDeployed));
      }
    }

    [AttributeLogicalName("ait_enrollmentdeployed")]
    public bool? ait_EnrollmentDeployed
    {
      get => this.GetAttributeValue<bool?>("ait_enrollmentdeployed");
      set
      {
        this.OnPropertyChanging(nameof (ait_EnrollmentDeployed));
        this.SetAttributeValue("ait_enrollmentdeployed", (object) value);
        this.OnPropertyChanged(nameof (ait_EnrollmentDeployed));
      }
    }

    [AttributeLogicalName("ait_entityimagestring")]
    public string ait_entityimagestring
    {
      get => this.GetAttributeValue<string>(nameof (ait_entityimagestring));
      set
      {
        this.OnPropertyChanging(nameof (ait_entityimagestring));
        this.SetAttributeValue(nameof (ait_entityimagestring), (object) value);
        this.OnPropertyChanged(nameof (ait_entityimagestring));
      }
    }

    [AttributeLogicalName("ait_familytreereporturl")]
    public string ait_familytreereporturl
    {
      get => this.GetAttributeValue<string>(nameof (ait_familytreereporturl));
      set
      {
        this.OnPropertyChanging(nameof (ait_familytreereporturl));
        this.SetAttributeValue(nameof (ait_familytreereporturl), (object) value);
        this.OnPropertyChanged(nameof (ait_familytreereporturl));
      }
    }

    [AttributeLogicalName("ait_familywellnessdeployed")]
    public bool? ait_FamilyWellnessDeployed
    {
      get => this.GetAttributeValue<bool?>("ait_familywellnessdeployed");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyWellnessDeployed));
        this.SetAttributeValue("ait_familywellnessdeployed", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyWellnessDeployed));
      }
    }

    [AttributeLogicalName("ait_householdnaming")]
    public Ait_householdnameoptions? ait_householdnaming
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (ait_householdnaming));
        return attributeValue != null ? new Ait_householdnameoptions?((Ait_householdnameoptions) Enum.ToObject(typeof (Ait_householdnameoptions), attributeValue.Value)) : new Ait_householdnameoptions?();
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdnaming));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (ait_householdnaming), (object) null);
        else
          this.SetAttributeValue(nameof (ait_householdnaming), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (ait_householdnaming));
      }
    }

    [AttributeLogicalName("ait_housingdeployed")]
    public bool? ait_HousingDeployed
    {
      get => this.GetAttributeValue<bool?>("ait_housingdeployed");
      set
      {
        this.OnPropertyChanging(nameof (ait_HousingDeployed));
        this.SetAttributeValue("ait_housingdeployed", (object) value);
        this.OnPropertyChanged(nameof (ait_HousingDeployed));
      }
    }

    [AttributeLogicalName("ait_membershipcardexpirationperiod")]
    public int? ait_membershipcardexpirationperiod
    {
      get => this.GetAttributeValue<int?>(nameof (ait_membershipcardexpirationperiod));
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcardexpirationperiod));
        this.SetAttributeValue(nameof (ait_membershipcardexpirationperiod), (object) value);
        this.OnPropertyChanged(nameof (ait_membershipcardexpirationperiod));
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

    [AttributeLogicalName("ait_portaldeployed")]
    public bool? ait_PortalDeployed
    {
      get => this.GetAttributeValue<bool?>("ait_portaldeployed");
      set
      {
        this.OnPropertyChanging(nameof (ait_PortalDeployed));
        this.SetAttributeValue("ait_portaldeployed", (object) value);
        this.OnPropertyChanged(nameof (ait_PortalDeployed));
      }
    }

    [AttributeLogicalName("ait_reportfooterinformation")]
    public string ait_ReportFooterInformation
    {
      get => this.GetAttributeValue<string>("ait_reportfooterinformation");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReportFooterInformation));
        this.SetAttributeValue("ait_reportfooterinformation", (object) value);
        this.OnPropertyChanged(nameof (ait_ReportFooterInformation));
      }
    }

    [AttributeLogicalName("ait_seniorage")]
    public int? ait_seniorage
    {
      get => this.GetAttributeValue<int?>(nameof (ait_seniorage));
      set
      {
        this.OnPropertyChanging(nameof (ait_seniorage));
        this.SetAttributeValue(nameof (ait_seniorage), (object) value);
        this.OnPropertyChanged(nameof (ait_seniorage));
      }
    }

    [AttributeLogicalName("ait_supportedidprintversion")]
    public string ait_supportedidprintversion
    {
      get => this.GetAttributeValue<string>(nameof (ait_supportedidprintversion));
      set
      {
        this.OnPropertyChanging(nameof (ait_supportedidprintversion));
        this.SetAttributeValue(nameof (ait_supportedidprintversion), (object) value);
        this.OnPropertyChanged(nameof (ait_supportedidprintversion));
      }
    }

    [AttributeLogicalName("ait_synchronizehouseholdaddresses")]
    public bool? ait_synchronizehouseholdaddresses
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_synchronizehouseholdaddresses));
      set
      {
        this.OnPropertyChanging(nameof (ait_synchronizehouseholdaddresses));
        this.SetAttributeValue(nameof (ait_synchronizehouseholdaddresses), (object) value);
        this.OnPropertyChanged(nameof (ait_synchronizehouseholdaddresses));
      }
    }

    [AttributeLogicalName("ait_tribalenrollmentconfigurationid")]
    public Guid? ait_tribalenrollmentconfigurationId
    {
      get => this.GetAttributeValue<Guid?>("ait_tribalenrollmentconfigurationid");
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfigurationId));
        this.SetAttributeValue("ait_tribalenrollmentconfigurationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfigurationId));
      }
    }

    [AttributeLogicalName("ait_tribalenrollmentconfigurationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_tribalenrollmentconfigurationId = new Guid?(value);
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

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

    [AttributeLogicalName("ait_defaulttribe")]
    [RelationshipSchemaName("ait_ait_tribalenrollmentconfiguration_ait_tribe")]
    public ait_tribe ait_ait_tribalenrollmentconfiguration_ait_tribe
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribalenrollmentconfiguration_ait_tribe));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_tribalenrollmentconfiguration")]
    public BusinessUnit business_unit_ait_tribalenrollmentconfiguration
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_tribalenrollmentconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_tribalenrollmentconfiguration_createdby")]
    public SystemUser lk_ait_tribalenrollmentconfiguration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_tribalenrollmentconfiguration_createdonbehalfby")]
    public SystemUser lk_ait_tribalenrollmentconfiguration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_tribalenrollmentconfiguration_modifiedby")]
    public SystemUser lk_ait_tribalenrollmentconfiguration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby")]
    public SystemUser lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_tribalenrollmentconfiguration_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_tribalenrollmentconfiguration")]
    public Team team_ait_tribalenrollmentconfiguration
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_ait_tribalenrollmentconfiguration), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_tribalenrollmentconfiguration")]
    public SystemUser user_ait_tribalenrollmentconfiguration
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_tribalenrollmentconfiguration), new EntityRole?());
      }
    }
  }
}
