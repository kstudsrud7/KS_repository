// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CrmServiceContext
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System.CodeDom.Compiler;
using System.Linq;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CrmServiceContext : OrganizationServiceContext
  {
    public CrmServiceContext(IOrganizationService service)
      : base(service)
    {
    }

    public IQueryable<Account> AccountSet => this.CreateQuery<Account>();

    public IQueryable<ACIViewMapper> ACIViewMapperSet => this.CreateQuery<ACIViewMapper>();

    public IQueryable<ActionCard> ActionCardSet => this.CreateQuery<ActionCard>();

    public IQueryable<ActionCardUserSettings> ActionCardUserSettingsSet
    {
      get => this.CreateQuery<ActionCardUserSettings>();
    }

    public IQueryable<ActionCardUserState> ActionCardUserStateSet
    {
      get => this.CreateQuery<ActionCardUserState>();
    }

    public IQueryable<ActivityMimeAttachment> ActivityMimeAttachmentSet
    {
      get => this.CreateQuery<ActivityMimeAttachment>();
    }

    public IQueryable<ActivityParty> ActivityPartySet => this.CreateQuery<ActivityParty>();

    public IQueryable<ActivityPointer> ActivityPointerSet => this.CreateQuery<ActivityPointer>();

    public IQueryable<AdvancedSimilarityRule> AdvancedSimilarityRuleSet
    {
      get => this.CreateQuery<AdvancedSimilarityRule>();
    }

    public IQueryable<ait_accountingcode> ait_accountingcodeSet
    {
      get => this.CreateQuery<ait_accountingcode>();
    }

    public IQueryable<ait_addresstype> ait_addresstypeSet => this.CreateQuery<ait_addresstype>();

    public IQueryable<ait_ait_committeemeeting_ait_committeemembe> ait_ait_committeemeeting_ait_committeemembeSet
    {
      get => this.CreateQuery<ait_ait_committeemeeting_ait_committeemembe>();
    }

    public IQueryable<ait_ait_groupactivity_contact> ait_ait_groupactivity_contactSet
    {
      get => this.CreateQuery<ait_ait_groupactivity_contact>();
    }

    public IQueryable<ait_ait_groupactivitymeeting_contact> ait_ait_groupactivitymeeting_contactSet
    {
      get => this.CreateQuery<ait_ait_groupactivitymeeting_contact>();
    }

    public IQueryable<ait_ait_memberprofile_ait_membershipcategor> ait_ait_memberprofile_ait_membershipcategorSet
    {
      get => this.CreateQuery<ait_ait_memberprofile_ait_membershipcategor>();
    }

    public IQueryable<ait_ait_resolution_ait_memberprofile> ait_ait_resolution_ait_memberprofileSet
    {
      get => this.CreateQuery<ait_ait_resolution_ait_memberprofile>();
    }

    public IQueryable<ait_assessment> ait_assessmentSet => this.CreateQuery<ait_assessment>();

    public IQueryable<ait_autonumber> ait_autonumberSet => this.CreateQuery<ait_autonumber>();

    public IQueryable<ait_band> ait_bandSet => this.CreateQuery<ait_band>();

    public IQueryable<ait_bankaccount> ait_bankaccountSet => this.CreateQuery<ait_bankaccount>();

    public IQueryable<ait_bankaccounttype> ait_bankaccounttypeSet
    {
      get => this.CreateQuery<ait_bankaccounttype>();
    }

    public IQueryable<ait_birthrecord> ait_birthrecordSet => this.CreateQuery<ait_birthrecord>();

    public IQueryable<ait_bloodquantum> ait_bloodquantumSet => this.CreateQuery<ait_bloodquantum>();

    public IQueryable<ait_cardformat> ait_cardformatSet => this.CreateQuery<ait_cardformat>();

    public IQueryable<ait_cardformatdetail> ait_cardformatdetailSet
    {
      get => this.CreateQuery<ait_cardformatdetail>();
    }

    public IQueryable<ait_cardhistory> ait_cardhistorySet => this.CreateQuery<ait_cardhistory>();

    public IQueryable<ait_case> ait_caseSet => this.CreateQuery<ait_case>();

    public IQueryable<ait_casenote> ait_casenoteSet => this.CreateQuery<ait_casenote>();

    public IQueryable<ait_caseplan> ait_caseplanSet => this.CreateQuery<ait_caseplan>();

    public IQueryable<ait_causeofdeath> ait_causeofdeathSet => this.CreateQuery<ait_causeofdeath>();

    public IQueryable<ait_cemetary> ait_cemetarySet => this.CreateQuery<ait_cemetary>();

    public IQueryable<ait_certification> ait_certificationSet
    {
      get => this.CreateQuery<ait_certification>();
    }

    public IQueryable<ait_changerequest> ait_changerequestSet
    {
      get => this.CreateQuery<ait_changerequest>();
    }

    public IQueryable<ait_changerequesttype> ait_changerequesttypeSet
    {
      get => this.CreateQuery<ait_changerequesttype>();
    }

    public IQueryable<ait_charge> ait_chargeSet => this.CreateQuery<ait_charge>();

    public IQueryable<ait_childvisitations> ait_childvisitationsSet
    {
      get => this.CreateQuery<ait_childvisitations>();
    }

    public IQueryable<ait_city> ait_citySet => this.CreateQuery<ait_city>();

    public IQueryable<ait_clan> ait_clanSet => this.CreateQuery<ait_clan>();

    public IQueryable<ait_clientprofile> ait_clientprofileSet
    {
      get => this.CreateQuery<ait_clientprofile>();
    }

    public IQueryable<ait_committee> ait_committeeSet => this.CreateQuery<ait_committee>();

    public IQueryable<ait_committeemeeting> ait_committeemeetingSet
    {
      get => this.CreateQuery<ait_committeemeeting>();
    }

    public IQueryable<ait_committeemember> ait_committeememberSet
    {
      get => this.CreateQuery<ait_committeemember>();
    }

    public IQueryable<ait_committeeposition> ait_committeepositionSet
    {
      get => this.CreateQuery<ait_committeeposition>();
    }

    public IQueryable<ait_committeepositiontype> ait_committeepositiontypeSet
    {
      get => this.CreateQuery<ait_committeepositiontype>();
    }

    public IQueryable<ait_company> ait_companySet => this.CreateQuery<ait_company>();

    public IQueryable<ait_contactcertification> ait_contactcertificationSet
    {
      get => this.CreateQuery<ait_contactcertification>();
    }

    public IQueryable<ait_contacteducation> ait_contacteducationSet
    {
      get => this.CreateQuery<ait_contacteducation>();
    }

    public IQueryable<ait_contactemployment> ait_contactemploymentSet
    {
      get => this.CreateQuery<ait_contactemployment>();
    }

    public IQueryable<ait_contactimage> ait_contactimageSet => this.CreateQuery<ait_contactimage>();

    public IQueryable<ait_contactincarceration> ait_contactincarcerationSet
    {
      get => this.CreateQuery<ait_contactincarceration>();
    }

    public IQueryable<ait_contactincomeandexpense> ait_contactincomeandexpenseSet
    {
      get => this.CreateQuery<ait_contactincomeandexpense>();
    }

    public IQueryable<ait_contactlanguage> ait_contactlanguageSet
    {
      get => this.CreateQuery<ait_contactlanguage>();
    }

    public IQueryable<ait_contactmilitaryservice> ait_contactmilitaryserviceSet
    {
      get => this.CreateQuery<ait_contactmilitaryservice>();
    }

    public IQueryable<ait_contactname> ait_contactnameSet => this.CreateQuery<ait_contactname>();

    public IQueryable<ait_contactskill> ait_contactskillSet => this.CreateQuery<ait_contactskill>();

    public IQueryable<ait_countryregion> ait_countryregionSet
    {
      get => this.CreateQuery<ait_countryregion>();
    }

    public IQueryable<ait_county> ait_countySet => this.CreateQuery<ait_county>();

    public IQueryable<ait_courtcase> ait_courtcaseSet => this.CreateQuery<ait_courtcase>();

    public IQueryable<ait_courtfinesandfees> ait_courtfinesandfeesSet
    {
      get => this.CreateQuery<ait_courtfinesandfees>();
    }

    public IQueryable<ait_courtfinesandfees_ait_courtprofile> ait_courtfinesandfees_ait_courtprofileSet
    {
      get => this.CreateQuery<ait_courtfinesandfees_ait_courtprofile>();
    }

    public IQueryable<ait_courtparty> ait_courtpartySet => this.CreateQuery<ait_courtparty>();

    public IQueryable<ait_courtpayments> ait_courtpaymentsSet
    {
      get => this.CreateQuery<ait_courtpayments>();
    }

    public IQueryable<ait_courtprofile> ait_courtprofileSet => this.CreateQuery<ait_courtprofile>();

    public IQueryable<ait_courtprofileaddress> ait_courtprofileaddressSet
    {
      get => this.CreateQuery<ait_courtprofileaddress>();
    }

    public IQueryable<ait_courtroom> ait_courtroomSet => this.CreateQuery<ait_courtroom>();

    public IQueryable<ait_datamigrationhistory> ait_datamigrationhistorySet
    {
      get => this.CreateQuery<ait_datamigrationhistory>();
    }

    public IQueryable<ait_deathrecord> ait_deathrecordSet => this.CreateQuery<ait_deathrecord>();

    public IQueryable<ait_degree> ait_degreeSet => this.CreateQuery<ait_degree>();

    public IQueryable<ait_electronicaddress> ait_electronicaddressSet
    {
      get => this.CreateQuery<ait_electronicaddress>();
    }

    public IQueryable<ait_emergencycontact> ait_emergencycontactSet
    {
      get => this.CreateQuery<ait_emergencycontact>();
    }

    public IQueryable<ait_familygroup> ait_familygroupSet => this.CreateQuery<ait_familygroup>();

    public IQueryable<ait_familywellnessconfiguration> ait_familywellnessconfigurationSet
    {
      get => this.CreateQuery<ait_familywellnessconfiguration>();
    }

    public IQueryable<ait_geographicalarea> ait_geographicalareaSet
    {
      get => this.CreateQuery<ait_geographicalarea>();
    }

    public IQueryable<ait_goal> ait_goalSet => this.CreateQuery<ait_goal>();

    public IQueryable<ait_groupactivity> ait_groupactivitySet
    {
      get => this.CreateQuery<ait_groupactivity>();
    }

    public IQueryable<ait_groupactivitymeeting> ait_groupactivitymeetingSet
    {
      get => this.CreateQuery<ait_groupactivitymeeting>();
    }

    public IQueryable<ait_household> ait_householdSet => this.CreateQuery<ait_household>();

    public IQueryable<ait_householdmember> ait_householdmemberSet
    {
      get => this.CreateQuery<ait_householdmember>();
    }

    public IQueryable<ait_icwaadoption> ait_icwaadoptionSet => this.CreateQuery<ait_icwaadoption>();

    public IQueryable<ait_icwanotice> ait_icwanoticeSet => this.CreateQuery<ait_icwanotice>();

    public IQueryable<ait_icwaregion> ait_icwaregionSet => this.CreateQuery<ait_icwaregion>();

    public IQueryable<ait_icwaregionnotification> ait_icwaregionnotificationSet
    {
      get => this.CreateQuery<ait_icwaregionnotification>();
    }

    public IQueryable<ait_icwaregionnotification_ait_icwaregi> ait_icwaregionnotification_ait_icwaregiSet
    {
      get => this.CreateQuery<ait_icwaregionnotification_ait_icwaregi>();
    }

    public IQueryable<ait_incident> ait_incidentSet => this.CreateQuery<ait_incident>();

    public IQueryable<ait_incident_ait_clientprofile> ait_incident_ait_clientprofileSet
    {
      get => this.CreateQuery<ait_incident_ait_clientprofile>();
    }

    public IQueryable<ait_incidenttype> ait_incidenttypeSet => this.CreateQuery<ait_incidenttype>();

    public IQueryable<ait_incomeorexpensecategory> ait_incomeorexpensecategorySet
    {
      get => this.CreateQuery<ait_incomeorexpensecategory>();
    }

    public IQueryable<ait_investigation> ait_investigationSet
    {
      get => this.CreateQuery<ait_investigation>();
    }

    public IQueryable<ait_language> ait_languageSet => this.CreateQuery<ait_language>();

    public IQueryable<ait_languageproficiencylevel> ait_languageproficiencylevelSet
    {
      get => this.CreateQuery<ait_languageproficiencylevel>();
    }

    public IQueryable<ait_loan> ait_loanSet => this.CreateQuery<ait_loan>();

    public IQueryable<ait_loandetail> ait_loandetailSet => this.CreateQuery<ait_loandetail>();

    public IQueryable<ait_loantype> ait_loantypeSet => this.CreateQuery<ait_loantype>();

    public IQueryable<ait_medicalproviders> ait_medicalprovidersSet
    {
      get => this.CreateQuery<ait_medicalproviders>();
    }

    public IQueryable<ait_memberprofile> ait_memberprofileSet
    {
      get => this.CreateQuery<ait_memberprofile>();
    }

    public IQueryable<ait_memberprofilemembershipcategory> ait_memberprofilemembershipcategorySet
    {
      get => this.CreateQuery<ait_memberprofilemembershipcategory>();
    }

    public IQueryable<ait_memberroll> ait_memberrollSet => this.CreateQuery<ait_memberroll>();

    public IQueryable<ait_membershipcategory> ait_membershipcategorySet
    {
      get => this.CreateQuery<ait_membershipcategory>();
    }

    public IQueryable<ait_membershipstatuschangerequest> ait_membershipstatuschangerequestSet
    {
      get => this.CreateQuery<ait_membershipstatuschangerequest>();
    }

    public IQueryable<ait_nametype> ait_nametypeSet => this.CreateQuery<ait_nametype>();

    public IQueryable<ait_outcome> ait_outcomeSet => this.CreateQuery<ait_outcome>();

    public IQueryable<ait_payment> ait_paymentSet => this.CreateQuery<ait_payment>();

    public IQueryable<ait_physicaladdress> ait_physicaladdressSet
    {
      get => this.CreateQuery<ait_physicaladdress>();
    }

    public IQueryable<ait_placement> ait_placementSet => this.CreateQuery<ait_placement>();

    public IQueryable<ait_placement_Contact> ait_placement_ContactSet
    {
      get => this.CreateQuery<ait_placement_Contact>();
    }

    public IQueryable<ait_placementlocation> ait_placementlocationSet
    {
      get => this.CreateQuery<ait_placementlocation>();
    }

    public IQueryable<ait_planactivity> ait_planactivitySet => this.CreateQuery<ait_planactivity>();

    public IQueryable<ait_pmteligibility> ait_pmteligibilitySet
    {
      get => this.CreateQuery<ait_pmteligibility>();
    }

    public IQueryable<ait_pmtevent> ait_pmteventSet => this.CreateQuery<ait_pmtevent>();

    public IQueryable<ait_pmtpaymenttype> ait_pmtpaymenttypeSet
    {
      get => this.CreateQuery<ait_pmtpaymenttype>();
    }

    public IQueryable<ait_pmttransaction> ait_pmttransactionSet
    {
      get => this.CreateQuery<ait_pmttransaction>();
    }

    public IQueryable<ait_pmttransactiondeduction> ait_pmttransactiondeductionSet
    {
      get => this.CreateQuery<ait_pmttransactiondeduction>();
    }

    public IQueryable<ait_pmtwithholding> ait_pmtwithholdingSet
    {
      get => this.CreateQuery<ait_pmtwithholding>();
    }

    public IQueryable<ait_pmtwithholdingoverride> ait_pmtwithholdingoverrideSet
    {
      get => this.CreateQuery<ait_pmtwithholdingoverride>();
    }

    public IQueryable<ait_program> ait_programSet => this.CreateQuery<ait_program>();

    public IQueryable<ait_referral> ait_referralSet => this.CreateQuery<ait_referral>();

    public IQueryable<ait_relationship> ait_relationshipSet => this.CreateQuery<ait_relationship>();

    public IQueryable<ait_reservation> ait_reservationSet => this.CreateQuery<ait_reservation>();

    public IQueryable<ait_resolution> ait_resolutionSet => this.CreateQuery<ait_resolution>();

    public IQueryable<ait_roll> ait_rollSet => this.CreateQuery<ait_roll>();

    public IQueryable<ait_safetyplan> ait_safetyplanSet => this.CreateQuery<ait_safetyplan>();

    public IQueryable<ait_safetyplan_contact> ait_safetyplan_contactSet
    {
      get => this.CreateQuery<ait_safetyplan_contact>();
    }

    public IQueryable<ait_school> ait_schoolSet => this.CreateQuery<ait_school>();

    public IQueryable<ait_schooltype> ait_schooltypeSet => this.CreateQuery<ait_schooltype>();

    public IQueryable<ait_servicerequest> ait_servicerequestSet
    {
      get => this.CreateQuery<ait_servicerequest>();
    }

    public IQueryable<ait_skill> ait_skillSet => this.CreateQuery<ait_skill>();

    public IQueryable<ait_stateprovince> ait_stateprovinceSet
    {
      get => this.CreateQuery<ait_stateprovince>();
    }

    public IQueryable<ait_statute> ait_statuteSet => this.CreateQuery<ait_statute>();

    public IQueryable<ait_training> ait_trainingSet => this.CreateQuery<ait_training>();

    public IQueryable<ait_trainingtype> ait_trainingtypeSet => this.CreateQuery<ait_trainingtype>();

    public IQueryable<ait_tribalenrollmentconfiguration> ait_tribalenrollmentconfigurationSet
    {
      get => this.CreateQuery<ait_tribalenrollmentconfiguration>();
    }

    public IQueryable<ait_tribe> ait_tribeSet => this.CreateQuery<ait_tribe>();

    public IQueryable<ait_withholdingtype> ait_withholdingtypeSet
    {
      get => this.CreateQuery<ait_withholdingtype>();
    }

    public IQueryable<ait_withholdingtype_pmtpaymenttype> ait_withholdingtype_pmtpaymenttypeSet
    {
      get => this.CreateQuery<ait_withholdingtype_pmtpaymenttype>();
    }

    public IQueryable<ait_zipcodecity> ait_zipcodecitySet => this.CreateQuery<ait_zipcodecity>();

    public IQueryable<Annotation> AnnotationSet => this.CreateQuery<Annotation>();

    public IQueryable<AnnualFiscalCalendar> AnnualFiscalCalendarSet
    {
      get => this.CreateQuery<AnnualFiscalCalendar>();
    }

    public IQueryable<apisettings> apisettingsSet => this.CreateQuery<apisettings>();

    public IQueryable<AppConfig> AppConfigSet => this.CreateQuery<AppConfig>();

    public IQueryable<AppConfigInstance> AppConfigInstanceSet
    {
      get => this.CreateQuery<AppConfigInstance>();
    }

    public IQueryable<AppConfigMaster> AppConfigMasterSet => this.CreateQuery<AppConfigMaster>();

    public IQueryable<AppElement> AppElementSet => this.CreateQuery<AppElement>();

    public IQueryable<ApplicationUser> ApplicationUserSet => this.CreateQuery<ApplicationUser>();

    public IQueryable<applicationuserprofile> applicationuserprofileSet
    {
      get => this.CreateQuery<applicationuserprofile>();
    }

    public IQueryable<applicationuserrole> applicationuserroleSet
    {
      get => this.CreateQuery<applicationuserrole>();
    }

    public IQueryable<AppModule> AppModuleSet => this.CreateQuery<AppModule>();

    public IQueryable<AppModuleComponent> AppModuleComponentSet
    {
      get => this.CreateQuery<AppModuleComponent>();
    }

    public IQueryable<AppModuleComponentEdge> AppModuleComponentEdgeSet
    {
      get => this.CreateQuery<AppModuleComponentEdge>();
    }

    public IQueryable<AppModuleComponentNode> AppModuleComponentNodeSet
    {
      get => this.CreateQuery<AppModuleComponentNode>();
    }

    public IQueryable<AppModuleRoles> AppModuleRolesSet => this.CreateQuery<AppModuleRoles>();

    public IQueryable<Appointment> AppointmentSet => this.CreateQuery<Appointment>();

    public IQueryable<AppSetting> AppSettingSet => this.CreateQuery<AppSetting>();

    public IQueryable<AsyncOperation> AsyncOperationSet => this.CreateQuery<AsyncOperation>();

    public IQueryable<AttributeImageConfig> AttributeImageConfigSet
    {
      get => this.CreateQuery<AttributeImageConfig>();
    }

    public IQueryable<AttributeMap> AttributeMapSet => this.CreateQuery<AttributeMap>();

    public IQueryable<Audit> AuditSet => this.CreateQuery<Audit>();

    public IQueryable<AzureServiceConnection> AzureServiceConnectionSet
    {
      get => this.CreateQuery<AzureServiceConnection>();
    }

    public IQueryable<bot> botSet => this.CreateQuery<bot>();

    public IQueryable<bot_botcomponent> bot_botcomponentSet => this.CreateQuery<bot_botcomponent>();

    public IQueryable<botcomponent> botcomponentSet => this.CreateQuery<botcomponent>();

    public IQueryable<botcomponent_botcomponent> botcomponent_botcomponentSet
    {
      get => this.CreateQuery<botcomponent_botcomponent>();
    }

    public IQueryable<botcomponent_workflow> botcomponent_workflowSet
    {
      get => this.CreateQuery<botcomponent_workflow>();
    }

    public IQueryable<BulkDeleteFailure> BulkDeleteFailureSet
    {
      get => this.CreateQuery<BulkDeleteFailure>();
    }

    public IQueryable<BulkDeleteOperation> BulkDeleteOperationSet
    {
      get => this.CreateQuery<BulkDeleteOperation>();
    }

    public IQueryable<BusinessProcessFlowInstance> BusinessProcessFlowInstanceSet
    {
      get => this.CreateQuery<BusinessProcessFlowInstance>();
    }

    public IQueryable<BusinessUnit> BusinessUnitSet => this.CreateQuery<BusinessUnit>();

    public IQueryable<BusinessUnitNewsArticle> BusinessUnitNewsArticleSet
    {
      get => this.CreateQuery<BusinessUnitNewsArticle>();
    }

    public IQueryable<Calendar> CalendarSet => this.CreateQuery<Calendar>();

    public IQueryable<CallbackRegistration> CallbackRegistrationSet
    {
      get => this.CreateQuery<CallbackRegistration>();
    }

    public IQueryable<CanvasApp> CanvasAppSet => this.CreateQuery<CanvasApp>();

    public IQueryable<CanvasAppExtendedMetadata> CanvasAppExtendedMetadataSet
    {
      get => this.CreateQuery<CanvasAppExtendedMetadata>();
    }

    public IQueryable<CardType> CardTypeSet => this.CreateQuery<CardType>();

    public IQueryable<Catalog> CatalogSet => this.CreateQuery<Catalog>();

    public IQueryable<CatalogAssignment> CatalogAssignmentSet
    {
      get => this.CreateQuery<CatalogAssignment>();
    }

    public IQueryable<Category> CategorySet => this.CreateQuery<Category>();

    public IQueryable<ChannelAccessProfile> ChannelAccessProfileSet
    {
      get => this.CreateQuery<ChannelAccessProfile>();
    }

    public IQueryable<ChannelAccessProfileEntityAccessLevel> ChannelAccessProfileEntityAccessLevelSet
    {
      get => this.CreateQuery<ChannelAccessProfileEntityAccessLevel>();
    }

    public IQueryable<ChannelAccessProfileRule> ChannelAccessProfileRuleSet
    {
      get => this.CreateQuery<ChannelAccessProfileRule>();
    }

    public IQueryable<ChannelAccessProfileRuleItem> ChannelAccessProfileRuleItemSet
    {
      get => this.CreateQuery<ChannelAccessProfileRuleItem>();
    }

    public IQueryable<ChannelProperty> ChannelPropertySet => this.CreateQuery<ChannelProperty>();

    public IQueryable<ChannelPropertyGroup> ChannelPropertyGroupSet
    {
      get => this.CreateQuery<ChannelPropertyGroup>();
    }

    public IQueryable<ColumnMapping> ColumnMappingSet => this.CreateQuery<ColumnMapping>();

    public IQueryable<Connection> ConnectionSet => this.CreateQuery<Connection>();

    public IQueryable<connectionreference> connectionreferenceSet
    {
      get => this.CreateQuery<connectionreference>();
    }

    public IQueryable<ConnectionRole> ConnectionRoleSet => this.CreateQuery<ConnectionRole>();

    public IQueryable<ConnectionRoleAssociation> ConnectionRoleAssociationSet
    {
      get => this.CreateQuery<ConnectionRoleAssociation>();
    }

    public IQueryable<ConnectionRoleObjectTypeCode> ConnectionRoleObjectTypeCodeSet
    {
      get => this.CreateQuery<ConnectionRoleObjectTypeCode>();
    }

    public IQueryable<connector> connectorSet => this.CreateQuery<connector>();

    public IQueryable<Contact> ContactSet => this.CreateQuery<Contact>();

    public IQueryable<conversationtranscript> conversationtranscriptSet
    {
      get => this.CreateQuery<conversationtranscript>();
    }

    public IQueryable<ConvertRule> ConvertRuleSet => this.CreateQuery<ConvertRule>();

    public IQueryable<ConvertRuleItem> ConvertRuleItemSet => this.CreateQuery<ConvertRuleItem>();

    public IQueryable<CustomAPI> CustomAPISet => this.CreateQuery<CustomAPI>();

    public IQueryable<CustomControl> CustomControlSet => this.CreateQuery<CustomControl>();

    public IQueryable<CustomControlDefaultConfig> CustomControlDefaultConfigSet
    {
      get => this.CreateQuery<CustomControlDefaultConfig>();
    }

    public IQueryable<CustomControlResource> CustomControlResourceSet
    {
      get => this.CreateQuery<CustomControlResource>();
    }

    public IQueryable<CustomerAddress> CustomerAddressSet => this.CreateQuery<CustomerAddress>();

    public IQueryable<CustomerRelationship> CustomerRelationshipSet
    {
      get => this.CreateQuery<CustomerRelationship>();
    }

    public IQueryable<datalakefolder> datalakefolderSet => this.CreateQuery<datalakefolder>();

    public IQueryable<datalakefolderpermission> datalakefolderpermissionSet
    {
      get => this.CreateQuery<datalakefolderpermission>();
    }

    public IQueryable<datalakeworkspace> datalakeworkspaceSet
    {
      get => this.CreateQuery<datalakeworkspace>();
    }

    public IQueryable<datalakeworkspacepermission> datalakeworkspacepermissionSet
    {
      get => this.CreateQuery<datalakeworkspacepermission>();
    }

    public IQueryable<DataPerformance> DataPerformanceSet => this.CreateQuery<DataPerformance>();

    public IQueryable<DelveActionHub> DelveActionHubSet => this.CreateQuery<DelveActionHub>();

    public IQueryable<Dependency> DependencySet => this.CreateQuery<Dependency>();

    public IQueryable<DisplayString> DisplayStringSet => this.CreateQuery<DisplayString>();

    public IQueryable<DocumentIndex> DocumentIndexSet => this.CreateQuery<DocumentIndex>();

    public IQueryable<DocumentTemplate> DocumentTemplateSet => this.CreateQuery<DocumentTemplate>();

    public IQueryable<DuplicateRecord> DuplicateRecordSet => this.CreateQuery<DuplicateRecord>();

    public IQueryable<DuplicateRule> DuplicateRuleSet => this.CreateQuery<DuplicateRule>();

    public IQueryable<DuplicateRuleCondition> DuplicateRuleConditionSet
    {
      get => this.CreateQuery<DuplicateRuleCondition>();
    }

    public IQueryable<Email> EmailSet => this.CreateQuery<Email>();

    public IQueryable<EmailServerProfile> EmailServerProfileSet
    {
      get => this.CreateQuery<EmailServerProfile>();
    }

    public IQueryable<EmailSignature> EmailSignatureSet => this.CreateQuery<EmailSignature>();

    public IQueryable<EntityAnalyticsConfig> EntityAnalyticsConfigSet
    {
      get => this.CreateQuery<EntityAnalyticsConfig>();
    }

    public IQueryable<EntityDataProvider> EntityDataProviderSet
    {
      get => this.CreateQuery<EntityDataProvider>();
    }

    public IQueryable<EntityDataSource> EntityDataSourceSet => this.CreateQuery<EntityDataSource>();

    public IQueryable<EntityImageConfig> EntityImageConfigSet
    {
      get => this.CreateQuery<EntityImageConfig>();
    }

    public IQueryable<EntityMap> EntityMapSet => this.CreateQuery<EntityMap>();

    public IQueryable<EnvironmentVariableDefinition> EnvironmentVariableDefinitionSet
    {
      get => this.CreateQuery<EnvironmentVariableDefinition>();
    }

    public IQueryable<EnvironmentVariableValue> EnvironmentVariableValueSet
    {
      get => this.CreateQuery<EnvironmentVariableValue>();
    }

    public IQueryable<ExchangeSyncIdMapping> ExchangeSyncIdMappingSet
    {
      get => this.CreateQuery<ExchangeSyncIdMapping>();
    }

    public IQueryable<ExpanderEvent> ExpanderEventSet => this.CreateQuery<ExpanderEvent>();

    public IQueryable<ExpiredProcess> ExpiredProcessSet => this.CreateQuery<ExpiredProcess>();

    public IQueryable<ExportSolutionUpload> ExportSolutionUploadSet
    {
      get => this.CreateQuery<ExportSolutionUpload>();
    }

    public IQueryable<ExternalParty> ExternalPartySet => this.CreateQuery<ExternalParty>();

    public IQueryable<ExternalPartyItem> ExternalPartyItemSet
    {
      get => this.CreateQuery<ExternalPartyItem>();
    }

    public IQueryable<Fax> FaxSet => this.CreateQuery<Fax>();

    public IQueryable<Feedback> FeedbackSet => this.CreateQuery<Feedback>();

    public IQueryable<FieldPermission> FieldPermissionSet => this.CreateQuery<FieldPermission>();

    public IQueryable<FieldSecurityProfile> FieldSecurityProfileSet
    {
      get => this.CreateQuery<FieldSecurityProfile>();
    }

    public IQueryable<FixedMonthlyFiscalCalendar> FixedMonthlyFiscalCalendarSet
    {
      get => this.CreateQuery<FixedMonthlyFiscalCalendar>();
    }

    public IQueryable<flowsession> flowsessionSet => this.CreateQuery<flowsession>();

    public IQueryable<Goal> GoalSet => this.CreateQuery<Goal>();

    public IQueryable<GoalRollupQuery> GoalRollupQuerySet => this.CreateQuery<GoalRollupQuery>();

    public IQueryable<HierarchyRule> HierarchyRuleSet => this.CreateQuery<HierarchyRule>();

    public IQueryable<HierarchySecurityConfiguration> HierarchySecurityConfigurationSet
    {
      get => this.CreateQuery<HierarchySecurityConfiguration>();
    }

    public IQueryable<holidaywrapper> holidaywrapperSet => this.CreateQuery<holidaywrapper>();

    public IQueryable<Import> ImportSet => this.CreateQuery<Import>();

    public IQueryable<ImportEntityMapping> ImportEntityMappingSet
    {
      get => this.CreateQuery<ImportEntityMapping>();
    }

    public IQueryable<ImportFile> ImportFileSet => this.CreateQuery<ImportFile>();

    public IQueryable<ImportJob> ImportJobSet => this.CreateQuery<ImportJob>();

    public IQueryable<ImportLog> ImportLogSet => this.CreateQuery<ImportLog>();

    public IQueryable<ImportMap> ImportMapSet => this.CreateQuery<ImportMap>();

    public IQueryable<InteractionForEmail> InteractionForEmailSet
    {
      get => this.CreateQuery<InteractionForEmail>();
    }

    public IQueryable<InternalCatalogAssignment> InternalCatalogAssignmentSet
    {
      get => this.CreateQuery<InternalCatalogAssignment>();
    }

    public IQueryable<InvalidDependency> InvalidDependencySet
    {
      get => this.CreateQuery<InvalidDependency>();
    }

    public IQueryable<IsvConfig> IsvConfigSet => this.CreateQuery<IsvConfig>();

    public IQueryable<KbArticle> KbArticleSet => this.CreateQuery<KbArticle>();

    public IQueryable<KbArticleComment> KbArticleCommentSet => this.CreateQuery<KbArticleComment>();

    public IQueryable<KbArticleTemplate> KbArticleTemplateSet
    {
      get => this.CreateQuery<KbArticleTemplate>();
    }

    public IQueryable<KnowledgeArticle> KnowledgeArticleSet => this.CreateQuery<KnowledgeArticle>();

    public IQueryable<KnowledgeArticlesCategories> KnowledgeArticlesCategoriesSet
    {
      get => this.CreateQuery<KnowledgeArticlesCategories>();
    }

    public IQueryable<KnowledgeArticleViews> KnowledgeArticleViewsSet
    {
      get => this.CreateQuery<KnowledgeArticleViews>();
    }

    public IQueryable<KnowledgeBaseRecord> KnowledgeBaseRecordSet
    {
      get => this.CreateQuery<KnowledgeBaseRecord>();
    }

    public IQueryable<KnowledgeSearchModel> KnowledgeSearchModelSet
    {
      get => this.CreateQuery<KnowledgeSearchModel>();
    }

    public IQueryable<LanguageLocale> LanguageLocaleSet => this.CreateQuery<LanguageLocale>();

    public IQueryable<Letter> LetterSet => this.CreateQuery<Letter>();

    public IQueryable<License> LicenseSet => this.CreateQuery<License>();

    public IQueryable<LookUpMapping> LookUpMappingSet => this.CreateQuery<LookUpMapping>();

    public IQueryable<Mailbox> MailboxSet => this.CreateQuery<Mailbox>();

    public IQueryable<MailboxStatistics> MailboxStatisticsSet
    {
      get => this.CreateQuery<MailboxStatistics>();
    }

    public IQueryable<MailboxTrackingCategory> MailboxTrackingCategorySet
    {
      get => this.CreateQuery<MailboxTrackingCategory>();
    }

    public IQueryable<MailboxTrackingFolder> MailboxTrackingFolderSet
    {
      get => this.CreateQuery<MailboxTrackingFolder>();
    }

    public IQueryable<MailMergeTemplate> MailMergeTemplateSet
    {
      get => this.CreateQuery<MailMergeTemplate>();
    }

    public IQueryable<mbs_pluginprofile> mbs_pluginprofileSet
    {
      get => this.CreateQuery<mbs_pluginprofile>();
    }

    public IQueryable<Metric> MetricSet => this.CreateQuery<Metric>();

    public IQueryable<MobileOfflineProfile> MobileOfflineProfileSet
    {
      get => this.CreateQuery<MobileOfflineProfile>();
    }

    public IQueryable<MobileOfflineProfileItem> MobileOfflineProfileItemSet
    {
      get => this.CreateQuery<MobileOfflineProfileItem>();
    }

    public IQueryable<MobileOfflineProfileItemAssociation> MobileOfflineProfileItemAssociationSet
    {
      get => this.CreateQuery<MobileOfflineProfileItemAssociation>();
    }

    public IQueryable<MonthlyFiscalCalendar> MonthlyFiscalCalendarSet
    {
      get => this.CreateQuery<MonthlyFiscalCalendar>();
    }

    public IQueryable<msdyn_AIBDataset> msdyn_AIBDatasetSet => this.CreateQuery<msdyn_AIBDataset>();

    public IQueryable<msdyn_AIBDatasetFile> msdyn_AIBDatasetFileSet
    {
      get => this.CreateQuery<msdyn_AIBDatasetFile>();
    }

    public IQueryable<msdyn_AIBDatasetRecord> msdyn_AIBDatasetRecordSet
    {
      get => this.CreateQuery<msdyn_AIBDatasetRecord>();
    }

    public IQueryable<msdyn_AIBDatasetsContainer> msdyn_AIBDatasetsContainerSet
    {
      get => this.CreateQuery<msdyn_AIBDatasetsContainer>();
    }

    public IQueryable<msdyn_AIBFile> msdyn_AIBFileSet => this.CreateQuery<msdyn_AIBFile>();

    public IQueryable<msdyn_AIBFileAttachedData> msdyn_AIBFileAttachedDataSet
    {
      get => this.CreateQuery<msdyn_AIBFileAttachedData>();
    }

    public IQueryable<msdyn_AIConfiguration> msdyn_AIConfigurationSet
    {
      get => this.CreateQuery<msdyn_AIConfiguration>();
    }

    public IQueryable<msdyn_AIFpTrainingDocument> msdyn_AIFpTrainingDocumentSet
    {
      get => this.CreateQuery<msdyn_AIFpTrainingDocument>();
    }

    public IQueryable<msdyn_AIModel> msdyn_AIModelSet => this.CreateQuery<msdyn_AIModel>();

    public IQueryable<msdyn_AIOdImage> msdyn_AIOdImageSet => this.CreateQuery<msdyn_AIOdImage>();

    public IQueryable<msdyn_AIOdLabel> msdyn_AIOdLabelSet => this.CreateQuery<msdyn_AIOdLabel>();

    public IQueryable<msdyn_aiodlabel_msdyn_aiconfiguration> msdyn_aiodlabel_msdyn_aiconfigurationSet
    {
      get => this.CreateQuery<msdyn_aiodlabel_msdyn_aiconfiguration>();
    }

    public IQueryable<msdyn_AIOdTrainingBoundingBox> msdyn_AIOdTrainingBoundingBoxSet
    {
      get => this.CreateQuery<msdyn_AIOdTrainingBoundingBox>();
    }

    public IQueryable<msdyn_AIOdTrainingImage> msdyn_AIOdTrainingImageSet
    {
      get => this.CreateQuery<msdyn_AIOdTrainingImage>();
    }

    public IQueryable<msdyn_AITemplate> msdyn_AITemplateSet => this.CreateQuery<msdyn_AITemplate>();

    public IQueryable<msdyn_analysiscomponent> msdyn_analysiscomponentSet
    {
      get => this.CreateQuery<msdyn_analysiscomponent>();
    }

    public IQueryable<msdyn_analysisjob> msdyn_analysisjobSet
    {
      get => this.CreateQuery<msdyn_analysisjob>();
    }

    public IQueryable<msdyn_analysisresult> msdyn_analysisresultSet
    {
      get => this.CreateQuery<msdyn_analysisresult>();
    }

    public IQueryable<msdyn_analysisresultdetail> msdyn_analysisresultdetailSet
    {
      get => this.CreateQuery<msdyn_analysisresultdetail>();
    }

    public IQueryable<msdyn_componentlayer> msdyn_componentlayerSet
    {
      get => this.CreateQuery<msdyn_componentlayer>();
    }

    public IQueryable<msdyn_componentlayerdatasource> msdyn_componentlayerdatasourceSet
    {
      get => this.CreateQuery<msdyn_componentlayerdatasource>();
    }

    public IQueryable<msdyn_dataflow> msdyn_dataflowSet => this.CreateQuery<msdyn_dataflow>();

    public IQueryable<msdyn_federatedarticle> msdyn_federatedarticleSet
    {
      get => this.CreateQuery<msdyn_federatedarticle>();
    }

    public IQueryable<msdyn_federatedarticleincident> msdyn_federatedarticleincidentSet
    {
      get => this.CreateQuery<msdyn_federatedarticleincident>();
    }

    public IQueryable<msdyn_helppage> msdyn_helppageSet => this.CreateQuery<msdyn_helppage>();

    public IQueryable<msdyn_kmfederatedsearchconfig> msdyn_kmfederatedsearchconfigSet
    {
      get => this.CreateQuery<msdyn_kmfederatedsearchconfig>();
    }

    public IQueryable<msdyn_knowledgearticleimage> msdyn_knowledgearticleimageSet
    {
      get => this.CreateQuery<msdyn_knowledgearticleimage>();
    }

    public IQueryable<msdyn_knowledgearticletemplate> msdyn_knowledgearticletemplateSet
    {
      get => this.CreateQuery<msdyn_knowledgearticletemplate>();
    }

    public IQueryable<msdyn_knowledgeinteractioninsight> msdyn_knowledgeinteractioninsightSet
    {
      get => this.CreateQuery<msdyn_knowledgeinteractioninsight>();
    }

    public IQueryable<msdyn_knowledgesearchinsight> msdyn_knowledgesearchinsightSet
    {
      get => this.CreateQuery<msdyn_knowledgesearchinsight>();
    }

    public IQueryable<msdyn_nonrelationalds> msdyn_nonrelationaldsSet
    {
      get => this.CreateQuery<msdyn_nonrelationalds>();
    }

    public IQueryable<msdyn_odatav4ds> msdyn_odatav4dsSet => this.CreateQuery<msdyn_odatav4ds>();

    public IQueryable<msdyn_richtextfile> msdyn_richtextfileSet
    {
      get => this.CreateQuery<msdyn_richtextfile>();
    }

    public IQueryable<msdyn_serviceconfiguration> msdyn_serviceconfigurationSet
    {
      get => this.CreateQuery<msdyn_serviceconfiguration>();
    }

    public IQueryable<msdyn_slakpi> msdyn_slakpiSet => this.CreateQuery<msdyn_slakpi>();

    public IQueryable<msdyn_solutioncomponentdatasource> msdyn_solutioncomponentdatasourceSet
    {
      get => this.CreateQuery<msdyn_solutioncomponentdatasource>();
    }

    public IQueryable<msdyn_solutioncomponentsummary> msdyn_solutioncomponentsummarySet
    {
      get => this.CreateQuery<msdyn_solutioncomponentsummary>();
    }

    public IQueryable<msdyn_solutionhealthrule> msdyn_solutionhealthruleSet
    {
      get => this.CreateQuery<msdyn_solutionhealthrule>();
    }

    public IQueryable<msdyn_solutionhealthruleargument> msdyn_solutionhealthruleargumentSet
    {
      get => this.CreateQuery<msdyn_solutionhealthruleargument>();
    }

    public IQueryable<msdyn_solutionhealthruleset> msdyn_solutionhealthrulesetSet
    {
      get => this.CreateQuery<msdyn_solutionhealthruleset>();
    }

    public IQueryable<msdyn_solutionhistory> msdyn_solutionhistorySet
    {
      get => this.CreateQuery<msdyn_solutionhistory>();
    }

    public IQueryable<msdyn_solutionhistorydatasource> msdyn_solutionhistorydatasourceSet
    {
      get => this.CreateQuery<msdyn_solutionhistorydatasource>();
    }

    public IQueryable<msdynce_botcontent> msdynce_botcontentSet
    {
      get => this.CreateQuery<msdynce_botcontent>();
    }

    public IQueryable<NavigationSetting> NavigationSettingSet
    {
      get => this.CreateQuery<NavigationSetting>();
    }

    public IQueryable<NewProcess> NewProcessSet => this.CreateQuery<NewProcess>();

    public IQueryable<OfficeGraphDocument> OfficeGraphDocumentSet
    {
      get => this.CreateQuery<OfficeGraphDocument>();
    }

    public IQueryable<OfflineCommandDefinition> OfflineCommandDefinitionSet
    {
      get => this.CreateQuery<OfflineCommandDefinition>();
    }

    public IQueryable<Organization> OrganizationSet => this.CreateQuery<Organization>();

    public IQueryable<OrganizationUI> OrganizationUISet => this.CreateQuery<OrganizationUI>();

    public IQueryable<OrgInsightsMetric> OrgInsightsMetricSet
    {
      get => this.CreateQuery<OrgInsightsMetric>();
    }

    public IQueryable<OrgInsightsNotification> OrgInsightsNotificationSet
    {
      get => this.CreateQuery<OrgInsightsNotification>();
    }

    public IQueryable<OwnerMapping> OwnerMappingSet => this.CreateQuery<OwnerMapping>();

    public IQueryable<package> packageSet => this.CreateQuery<package>();

    public IQueryable<package_solution> package_solutionSet => this.CreateQuery<package_solution>();

    public IQueryable<PDFSetting> PDFSettingSet => this.CreateQuery<PDFSetting>();

    public IQueryable<PersonalDocumentTemplate> PersonalDocumentTemplateSet
    {
      get => this.CreateQuery<PersonalDocumentTemplate>();
    }

    public IQueryable<PhoneCall> PhoneCallSet => this.CreateQuery<PhoneCall>();

    public IQueryable<PickListMapping> PickListMappingSet => this.CreateQuery<PickListMapping>();

    public IQueryable<PluginAssembly> PluginAssemblySet => this.CreateQuery<PluginAssembly>();

    public IQueryable<PluginTraceLog> PluginTraceLogSet => this.CreateQuery<PluginTraceLog>();

    public IQueryable<PluginType> PluginTypeSet => this.CreateQuery<PluginType>();

    public IQueryable<PluginTypeStatistic> PluginTypeStatisticSet
    {
      get => this.CreateQuery<PluginTypeStatistic>();
    }

    public IQueryable<Position> PositionSet => this.CreateQuery<Position>();

    public IQueryable<Post> PostSet => this.CreateQuery<Post>();

    public IQueryable<PostComment> PostCommentSet => this.CreateQuery<PostComment>();

    public IQueryable<PostFollow> PostFollowSet => this.CreateQuery<PostFollow>();

    public IQueryable<PostLike> PostLikeSet => this.CreateQuery<PostLike>();

    public IQueryable<PrincipalEntityMap> PrincipalEntityMapSet
    {
      get => this.CreateQuery<PrincipalEntityMap>();
    }

    public IQueryable<PrincipalObjectAttributeAccess> PrincipalObjectAttributeAccessSet
    {
      get => this.CreateQuery<PrincipalObjectAttributeAccess>();
    }

    public IQueryable<Privilege> PrivilegeSet => this.CreateQuery<Privilege>();

    public IQueryable<ProcessSession> ProcessSessionSet => this.CreateQuery<ProcessSession>();

    public IQueryable<ProcessStage> ProcessStageSet => this.CreateQuery<ProcessStage>();

    public IQueryable<processstageparameter> processstageparameterSet
    {
      get => this.CreateQuery<processstageparameter>();
    }

    public IQueryable<ProcessTrigger> ProcessTriggerSet => this.CreateQuery<ProcessTrigger>();

    public IQueryable<ProvisionLanguageForUser> ProvisionLanguageForUserSet
    {
      get => this.CreateQuery<ProvisionLanguageForUser>();
    }

    public IQueryable<Publisher> PublisherSet => this.CreateQuery<Publisher>();

    public IQueryable<PublisherAddress> PublisherAddressSet => this.CreateQuery<PublisherAddress>();

    public IQueryable<QuarterlyFiscalCalendar> QuarterlyFiscalCalendarSet
    {
      get => this.CreateQuery<QuarterlyFiscalCalendar>();
    }

    public IQueryable<Queue> QueueSet => this.CreateQuery<Queue>();

    public IQueryable<QueueItem> QueueItemSet => this.CreateQuery<QueueItem>();

    public IQueryable<QueueMembership> QueueMembershipSet => this.CreateQuery<QueueMembership>();

    public IQueryable<RecommendedDocument> RecommendedDocumentSet
    {
      get => this.CreateQuery<RecommendedDocument>();
    }

    public IQueryable<RecurrenceRule> RecurrenceRuleSet => this.CreateQuery<RecurrenceRule>();

    public IQueryable<RecurringAppointmentMaster> RecurringAppointmentMasterSet
    {
      get => this.CreateQuery<RecurringAppointmentMaster>();
    }

    public IQueryable<RelationshipRole> RelationshipRoleSet => this.CreateQuery<RelationshipRole>();

    public IQueryable<RelationshipRoleMap> RelationshipRoleMapSet
    {
      get => this.CreateQuery<RelationshipRoleMap>();
    }

    public IQueryable<Report> ReportSet => this.CreateQuery<Report>();

    public IQueryable<ReportCategory> ReportCategorySet => this.CreateQuery<ReportCategory>();

    public IQueryable<ReportEntity> ReportEntitySet => this.CreateQuery<ReportEntity>();

    public IQueryable<ReportLink> ReportLinkSet => this.CreateQuery<ReportLink>();

    public IQueryable<ReportVisibility> ReportVisibilitySet => this.CreateQuery<ReportVisibility>();

    public IQueryable<revokeinheritedaccessrecordstracker> revokeinheritedaccessrecordstrackerSet
    {
      get => this.CreateQuery<revokeinheritedaccessrecordstracker>();
    }

    public IQueryable<RibbonCustomization> RibbonCustomizationSet
    {
      get => this.CreateQuery<RibbonCustomization>();
    }

    public IQueryable<RibbonMetadataToProcess> RibbonMetadataToProcessSet
    {
      get => this.CreateQuery<RibbonMetadataToProcess>();
    }

    public IQueryable<Role> RoleSet => this.CreateQuery<Role>();

    public IQueryable<RolePrivileges> RolePrivilegesSet => this.CreateQuery<RolePrivileges>();

    public IQueryable<RoleTemplatePrivileges> RoleTemplatePrivilegesSet
    {
      get => this.CreateQuery<RoleTemplatePrivileges>();
    }

    public IQueryable<RollupField> RollupFieldSet => this.CreateQuery<RollupField>();

    public IQueryable<RoutingRule> RoutingRuleSet => this.CreateQuery<RoutingRule>();

    public IQueryable<RoutingRuleItem> RoutingRuleItemSet => this.CreateQuery<RoutingRuleItem>();

    public IQueryable<SavedOrgInsightsConfiguration> SavedOrgInsightsConfigurationSet
    {
      get => this.CreateQuery<SavedOrgInsightsConfiguration>();
    }

    public IQueryable<SavedQuery> SavedQuerySet => this.CreateQuery<SavedQuery>();

    public IQueryable<SavedQueryVisualization> SavedQueryVisualizationSet
    {
      get => this.CreateQuery<SavedQueryVisualization>();
    }

    public IQueryable<SdkMessage> SdkMessageSet => this.CreateQuery<SdkMessage>();

    public IQueryable<SdkMessageFilter> SdkMessageFilterSet => this.CreateQuery<SdkMessageFilter>();

    public IQueryable<SdkMessagePair> SdkMessagePairSet => this.CreateQuery<SdkMessagePair>();

    public IQueryable<SdkMessageProcessingStep> SdkMessageProcessingStepSet
    {
      get => this.CreateQuery<SdkMessageProcessingStep>();
    }

    public IQueryable<SdkMessageProcessingStepImage> SdkMessageProcessingStepImageSet
    {
      get => this.CreateQuery<SdkMessageProcessingStepImage>();
    }

    public IQueryable<SdkMessageProcessingStepSecureConfig> SdkMessageProcessingStepSecureConfigSet
    {
      get => this.CreateQuery<SdkMessageProcessingStepSecureConfig>();
    }

    public IQueryable<SdkMessageRequest> SdkMessageRequestSet
    {
      get => this.CreateQuery<SdkMessageRequest>();
    }

    public IQueryable<SdkMessageRequestField> SdkMessageRequestFieldSet
    {
      get => this.CreateQuery<SdkMessageRequestField>();
    }

    public IQueryable<SdkMessageResponse> SdkMessageResponseSet
    {
      get => this.CreateQuery<SdkMessageResponse>();
    }

    public IQueryable<SdkMessageResponseField> SdkMessageResponseFieldSet
    {
      get => this.CreateQuery<SdkMessageResponseField>();
    }

    public IQueryable<searchtelemetry> searchtelemetrySet => this.CreateQuery<searchtelemetry>();

    public IQueryable<SemiAnnualFiscalCalendar> SemiAnnualFiscalCalendarSet
    {
      get => this.CreateQuery<SemiAnnualFiscalCalendar>();
    }

    public IQueryable<ServiceEndpoint> ServiceEndpointSet => this.CreateQuery<ServiceEndpoint>();

    public IQueryable<ServicePlan> ServicePlanSet => this.CreateQuery<ServicePlan>();

    public IQueryable<ServicePlanAppModules> ServicePlanAppModulesSet
    {
      get => this.CreateQuery<ServicePlanAppModules>();
    }

    public IQueryable<SettingDefinition> SettingDefinitionSet
    {
      get => this.CreateQuery<SettingDefinition>();
    }

    public IQueryable<SharePointData> SharePointDataSet => this.CreateQuery<SharePointData>();

    public IQueryable<SharePointDocument> SharePointDocumentSet
    {
      get => this.CreateQuery<SharePointDocument>();
    }

    public IQueryable<SharePointDocumentLocation> SharePointDocumentLocationSet
    {
      get => this.CreateQuery<SharePointDocumentLocation>();
    }

    public IQueryable<SharePointSite> SharePointSiteSet => this.CreateQuery<SharePointSite>();

    public IQueryable<SiteMap> SiteMapSet => this.CreateQuery<SiteMap>();

    public IQueryable<SLA> SLASet => this.CreateQuery<SLA>();

    public IQueryable<SLAItem> SLAItemSet => this.CreateQuery<SLAItem>();

    public IQueryable<SLAKPIInstance> SLAKPIInstanceSet => this.CreateQuery<SLAKPIInstance>();

    public IQueryable<SocialActivity> SocialActivitySet => this.CreateQuery<SocialActivity>();

    public IQueryable<SocialInsightsConfiguration> SocialInsightsConfigurationSet
    {
      get => this.CreateQuery<SocialInsightsConfiguration>();
    }

    public IQueryable<SocialProfile> SocialProfileSet => this.CreateQuery<SocialProfile>();

    public IQueryable<Solution> SolutionSet => this.CreateQuery<Solution>();

    public IQueryable<SolutionComponent> SolutionComponentSet
    {
      get => this.CreateQuery<SolutionComponent>();
    }

    public IQueryable<solutioncomponentattributeconfiguration> solutioncomponentattributeconfigurationSet
    {
      get => this.CreateQuery<solutioncomponentattributeconfiguration>();
    }

    public IQueryable<solutioncomponentconfiguration> solutioncomponentconfigurationSet
    {
      get => this.CreateQuery<solutioncomponentconfiguration>();
    }

    public IQueryable<SolutionComponentDefinition> SolutionComponentDefinitionSet
    {
      get => this.CreateQuery<SolutionComponentDefinition>();
    }

    public IQueryable<solutioncomponentrelationshipconfiguration> solutioncomponentrelationshipconfigurationSet
    {
      get => this.CreateQuery<solutioncomponentrelationshipconfiguration>();
    }

    public IQueryable<SolutionHistoryData> SolutionHistoryDataSet
    {
      get => this.CreateQuery<SolutionHistoryData>();
    }

    public IQueryable<StageSolutionUpload> StageSolutionUploadSet
    {
      get => this.CreateQuery<StageSolutionUpload>();
    }

    public IQueryable<Subject> SubjectSet => this.CreateQuery<Subject>();

    public IQueryable<SubscriptionManuallyTrackedObject> SubscriptionManuallyTrackedObjectSet
    {
      get => this.CreateQuery<SubscriptionManuallyTrackedObject>();
    }

    public IQueryable<SubscriptionTrackingDeletedObject> SubscriptionTrackingDeletedObjectSet
    {
      get => this.CreateQuery<SubscriptionTrackingDeletedObject>();
    }

    public IQueryable<SuggestionCardTemplate> SuggestionCardTemplateSet
    {
      get => this.CreateQuery<SuggestionCardTemplate>();
    }

    public IQueryable<SyncError> SyncErrorSet => this.CreateQuery<SyncError>();

    public IQueryable<SystemForm> SystemFormSet => this.CreateQuery<SystemForm>();

    public IQueryable<SystemUser> SystemUserSet => this.CreateQuery<SystemUser>();

    public IQueryable<SystemUserLicenses> SystemUserLicensesSet
    {
      get => this.CreateQuery<SystemUserLicenses>();
    }

    public IQueryable<SystemUserProfiles> SystemUserProfilesSet
    {
      get => this.CreateQuery<SystemUserProfiles>();
    }

    public IQueryable<SystemUserRoles> SystemUserRolesSet => this.CreateQuery<SystemUserRoles>();

    public IQueryable<SystemUserSyncMappingProfiles> SystemUserSyncMappingProfilesSet
    {
      get => this.CreateQuery<SystemUserSyncMappingProfiles>();
    }

    public IQueryable<Task> TaskSet => this.CreateQuery<Task>();

    public IQueryable<Team> TeamSet => this.CreateQuery<Team>();

    public IQueryable<TeamMembership> TeamMembershipSet => this.CreateQuery<TeamMembership>();

    public IQueryable<TeamProfiles> TeamProfilesSet => this.CreateQuery<TeamProfiles>();

    public IQueryable<TeamRoles> TeamRolesSet => this.CreateQuery<TeamRoles>();

    public IQueryable<TeamSyncAttributeMappingProfiles> TeamSyncAttributeMappingProfilesSet
    {
      get => this.CreateQuery<TeamSyncAttributeMappingProfiles>();
    }

    public IQueryable<TeamTemplate> TeamTemplateSet => this.CreateQuery<TeamTemplate>();

    public IQueryable<Template> TemplateSet => this.CreateQuery<Template>();

    public IQueryable<Territory> TerritorySet => this.CreateQuery<Territory>();

    public IQueryable<TextAnalyticsEntityMapping> TextAnalyticsEntityMappingSet
    {
      get => this.CreateQuery<TextAnalyticsEntityMapping>();
    }

    public IQueryable<Theme> ThemeSet => this.CreateQuery<Theme>();

    public IQueryable<TimeZoneDefinition> TimeZoneDefinitionSet
    {
      get => this.CreateQuery<TimeZoneDefinition>();
    }

    public IQueryable<TimeZoneLocalizedName> TimeZoneLocalizedNameSet
    {
      get => this.CreateQuery<TimeZoneLocalizedName>();
    }

    public IQueryable<TimeZoneRule> TimeZoneRuleSet => this.CreateQuery<TimeZoneRule>();

    public IQueryable<TraceLog> TraceLogSet => this.CreateQuery<TraceLog>();

    public IQueryable<TransactionCurrency> TransactionCurrencySet
    {
      get => this.CreateQuery<TransactionCurrency>();
    }

    public IQueryable<TransformationMapping> TransformationMappingSet
    {
      get => this.CreateQuery<TransformationMapping>();
    }

    public IQueryable<TransformationParameterMapping> TransformationParameterMappingSet
    {
      get => this.CreateQuery<TransformationParameterMapping>();
    }

    public IQueryable<TranslationProcess> TranslationProcessSet
    {
      get => this.CreateQuery<TranslationProcess>();
    }

    public IQueryable<UserEntityInstanceData> UserEntityInstanceDataSet
    {
      get => this.CreateQuery<UserEntityInstanceData>();
    }

    public IQueryable<UserEntityUISettings> UserEntityUISettingsSet
    {
      get => this.CreateQuery<UserEntityUISettings>();
    }

    public IQueryable<UserForm> UserFormSet => this.CreateQuery<UserForm>();

    public IQueryable<UserMapping> UserMappingSet => this.CreateQuery<UserMapping>();

    public IQueryable<UserQuery> UserQuerySet => this.CreateQuery<UserQuery>();

    public IQueryable<UserQueryVisualization> UserQueryVisualizationSet
    {
      get => this.CreateQuery<UserQueryVisualization>();
    }

    public IQueryable<UserSettings> UserSettingsSet => this.CreateQuery<UserSettings>();

    public IQueryable<WebResource> WebResourceSet => this.CreateQuery<WebResource>();

    public IQueryable<Workflow> WorkflowSet => this.CreateQuery<Workflow>();

    public IQueryable<workflowbinary> workflowbinarySet => this.CreateQuery<workflowbinary>();

    public IQueryable<WorkflowDependency> WorkflowDependencySet
    {
      get => this.CreateQuery<WorkflowDependency>();
    }

    public IQueryable<WorkflowLog> WorkflowLogSet => this.CreateQuery<WorkflowLog>();
  }
}
