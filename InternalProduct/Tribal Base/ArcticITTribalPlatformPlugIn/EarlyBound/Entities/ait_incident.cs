// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_incident
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_incident")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_incident : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_incident";
    public const string EntitySchemaName = "ait_incident";
    public const string PrimaryIdAttribute = "ait_incidentid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_incident()
      : base(nameof (ait_incident))
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

    [AttributeLogicalName("ait_case")]
    public EntityReference ait_Case
    {
      get => this.GetAttributeValue<EntityReference>("ait_case");
      set
      {
        this.OnPropertyChanging(nameof (ait_Case));
        this.SetAttributeValue("ait_case", (object) value);
        this.OnPropertyChanged(nameof (ait_Case));
      }
    }

    [AttributeLogicalName("ait_cibreport")]
    public OptionSetValue ait_cibreport
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_cibreport));
      set
      {
        this.OnPropertyChanging(nameof (ait_cibreport));
        this.SetAttributeValue(nameof (ait_cibreport), (object) value);
        this.OnPropertyChanged(nameof (ait_cibreport));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    public EntityReference ait_clientprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_clientprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile));
        this.SetAttributeValue(nameof (ait_clientprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_clientprofile));
      }
    }

    [AttributeLogicalName("ait_custodianname")]
    public EntityReference ait_CustodianName
    {
      get => this.GetAttributeValue<EntityReference>("ait_custodianname");
      set
      {
        this.OnPropertyChanging(nameof (ait_CustodianName));
        this.SetAttributeValue("ait_custodianname", (object) value);
        this.OnPropertyChanged(nameof (ait_CustodianName));
      }
    }

    [AttributeLogicalName("ait_datetimeofincident")]
    public DateTime? ait_datetimeofincident
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_datetimeofincident));
      set
      {
        this.OnPropertyChanging(nameof (ait_datetimeofincident));
        this.SetAttributeValue(nameof (ait_datetimeofincident), (object) value);
        this.OnPropertyChanged(nameof (ait_datetimeofincident));
      }
    }

    [AttributeLogicalName("ait_familyviolence")]
    public OptionSetValue ait_familyviolence
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_familyviolence));
      set
      {
        this.OnPropertyChanging(nameof (ait_familyviolence));
        this.SetAttributeValue(nameof (ait_familyviolence), (object) value);
        this.OnPropertyChanged(nameof (ait_familyviolence));
      }
    }

    [AttributeLogicalName("ait_familyviolencedescribeifyes")]
    public string ait_FamilyViolenceDescribeifYes
    {
      get => this.GetAttributeValue<string>("ait_familyviolencedescribeifyes");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyViolenceDescribeifYes));
        this.SetAttributeValue("ait_familyviolencedescribeifyes", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyViolenceDescribeifYes));
      }
    }

    [AttributeLogicalName("ait_fathersname")]
    public EntityReference ait_fathersname
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_fathersname));
      set
      {
        this.OnPropertyChanging(nameof (ait_fathersname));
        this.SetAttributeValue(nameof (ait_fathersname), (object) value);
        this.OnPropertyChanged(nameof (ait_fathersname));
      }
    }

    [AttributeLogicalName("ait_incident_id")]
    public string ait_Incident_ID
    {
      get => this.GetAttributeValue<string>("ait_incident_id");
      set
      {
        this.OnPropertyChanging(nameof (ait_Incident_ID));
        this.SetAttributeValue("ait_incident_id", (object) value);
        this.OnPropertyChanged(nameof (ait_Incident_ID));
      }
    }

    [AttributeLogicalName("ait_incidentcloseddate")]
    public DateTime? ait_IncidentClosedDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_incidentcloseddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_IncidentClosedDate));
        this.SetAttributeValue("ait_incidentcloseddate", (object) value);
        this.OnPropertyChanged(nameof (ait_IncidentClosedDate));
      }
    }

    [AttributeLogicalName("ait_incidentdescription")]
    public string ait_incidentdescription
    {
      get => this.GetAttributeValue<string>(nameof (ait_incidentdescription));
      set
      {
        this.OnPropertyChanging(nameof (ait_incidentdescription));
        this.SetAttributeValue(nameof (ait_incidentdescription), (object) value);
        this.OnPropertyChanged(nameof (ait_incidentdescription));
      }
    }

    [AttributeLogicalName("ait_incidentid")]
    public Guid? ait_incidentId
    {
      get => this.GetAttributeValue<Guid?>("ait_incidentid");
      set
      {
        this.OnPropertyChanging(nameof (ait_incidentId));
        this.SetAttributeValue("ait_incidentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_incidentId));
      }
    }

    [AttributeLogicalName("ait_incidentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_incidentId = new Guid?(value);
    }

    [AttributeLogicalName("ait_incidentreportdate")]
    public DateTime? ait_incidentreportdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_incidentreportdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_incidentreportdate));
        this.SetAttributeValue(nameof (ait_incidentreportdate), (object) value);
        this.OnPropertyChanged(nameof (ait_incidentreportdate));
      }
    }

    [AttributeLogicalName("ait_incidentstatus")]
    public OptionSetValue ait_IncidentStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_incidentstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_IncidentStatus));
        this.SetAttributeValue("ait_incidentstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_IncidentStatus));
      }
    }

    [AttributeLogicalName("ait_incidenttype")]
    public EntityReference ait_incidenttype
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_incidenttype));
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype));
        this.SetAttributeValue(nameof (ait_incidenttype), (object) value);
        this.OnPropertyChanged(nameof (ait_incidenttype));
      }
    }

    [AttributeLogicalName("ait_locationofincident")]
    public string ait_locationofincident
    {
      get => this.GetAttributeValue<string>(nameof (ait_locationofincident));
      set
      {
        this.OnPropertyChanging(nameof (ait_locationofincident));
        this.SetAttributeValue(nameof (ait_locationofincident), (object) value);
        this.OnPropertyChanged(nameof (ait_locationofincident));
      }
    }

    [AttributeLogicalName("ait_mothersname")]
    public EntityReference ait_mothersname
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_mothersname));
      set
      {
        this.OnPropertyChanging(nameof (ait_mothersname));
        this.SetAttributeValue(nameof (ait_mothersname), (object) value);
        this.OnPropertyChanged(nameof (ait_mothersname));
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

    [AttributeLogicalName("ait_nameofvictim")]
    public EntityReference ait_nameofvictim
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_nameofvictim));
      set
      {
        this.OnPropertyChanging(nameof (ait_nameofvictim));
        this.SetAttributeValue(nameof (ait_nameofvictim), (object) value);
        this.OnPropertyChanged(nameof (ait_nameofvictim));
      }
    }

    [AttributeLogicalName("ait_offenderaddress")]
    public string ait_OffenderAddress
    {
      get => this.GetAttributeValue<string>("ait_offenderaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_OffenderAddress));
        this.SetAttributeValue("ait_offenderaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_OffenderAddress));
      }
    }

    [AttributeLogicalName("ait_offendercontactname")]
    public EntityReference ait_OffenderContactName
    {
      get => this.GetAttributeValue<EntityReference>("ait_offendercontactname");
      set
      {
        this.OnPropertyChanging(nameof (ait_OffenderContactName));
        this.SetAttributeValue("ait_offendercontactname", (object) value);
        this.OnPropertyChanged(nameof (ait_OffenderContactName));
      }
    }

    [AttributeLogicalName("ait_offenderdob")]
    public DateTime? ait_OffenderDOB
    {
      get => this.GetAttributeValue<DateTime?>("ait_offenderdob");
      set
      {
        this.OnPropertyChanging(nameof (ait_OffenderDOB));
        this.SetAttributeValue("ait_offenderdob", (object) value);
        this.OnPropertyChanged(nameof (ait_OffenderDOB));
      }
    }

    [AttributeLogicalName("ait_offenderemail")]
    public string ait_OffenderEmail
    {
      get => this.GetAttributeValue<string>("ait_offenderemail");
      set
      {
        this.OnPropertyChanging(nameof (ait_OffenderEmail));
        this.SetAttributeValue("ait_offenderemail", (object) value);
        this.OnPropertyChanged(nameof (ait_OffenderEmail));
      }
    }

    [AttributeLogicalName("ait_offenderhascontactrecord")]
    public bool? ait_offenderhascontactrecord
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_offenderhascontactrecord));
      set
      {
        this.OnPropertyChanging(nameof (ait_offenderhascontactrecord));
        this.SetAttributeValue(nameof (ait_offenderhascontactrecord), (object) value);
        this.OnPropertyChanged(nameof (ait_offenderhascontactrecord));
      }
    }

    [AttributeLogicalName("ait_offendername")]
    public string ait_offendername
    {
      get => this.GetAttributeValue<string>(nameof (ait_offendername));
      set
      {
        this.OnPropertyChanging(nameof (ait_offendername));
        this.SetAttributeValue(nameof (ait_offendername), (object) value);
        this.OnPropertyChanged(nameof (ait_offendername));
      }
    }

    [AttributeLogicalName("ait_offendernameclientprofile")]
    public EntityReference ait_offendernameclientprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_offendernameclientprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_offendernameclientprofile));
        this.SetAttributeValue(nameof (ait_offendernameclientprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_offendernameclientprofile));
      }
    }

    [AttributeLogicalName("ait_offenderphone")]
    public string ait_OffenderPhone
    {
      get => this.GetAttributeValue<string>("ait_offenderphone");
      set
      {
        this.OnPropertyChanging(nameof (ait_OffenderPhone));
        this.SetAttributeValue("ait_offenderphone", (object) value);
        this.OnPropertyChanged(nameof (ait_OffenderPhone));
      }
    }

    [AttributeLogicalName("ait_offenderrelationship")]
    public string ait_OffenderRelationship
    {
      get => this.GetAttributeValue<string>("ait_offenderrelationship");
      set
      {
        this.OnPropertyChanging(nameof (ait_OffenderRelationship));
        this.SetAttributeValue("ait_offenderrelationship", (object) value);
        this.OnPropertyChanged(nameof (ait_OffenderRelationship));
      }
    }

    [AttributeLogicalName("ait_otheradultinhome")]
    public string ait_OtherAdultinHome
    {
      get => this.GetAttributeValue<string>("ait_otheradultinhome");
      set
      {
        this.OnPropertyChanging(nameof (ait_OtherAdultinHome));
        this.SetAttributeValue("ait_otheradultinhome", (object) value);
        this.OnPropertyChanged(nameof (ait_OtherAdultinHome));
      }
    }

    [AttributeLogicalName("ait_otheradultinhomeyn")]
    public bool? ait_OtherAdultInHomeYN
    {
      get => this.GetAttributeValue<bool?>("ait_otheradultinhomeyn");
      set
      {
        this.OnPropertyChanging(nameof (ait_OtherAdultInHomeYN));
        this.SetAttributeValue("ait_otheradultinhomeyn", (object) value);
        this.OnPropertyChanged(nameof (ait_OtherAdultInHomeYN));
      }
    }

    [AttributeLogicalName("ait_photographs")]
    public OptionSetValue ait_photographs
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_photographs));
      set
      {
        this.OnPropertyChanging(nameof (ait_photographs));
        this.SetAttributeValue(nameof (ait_photographs), (object) value);
        this.OnPropertyChanged(nameof (ait_photographs));
      }
    }

    [AttributeLogicalName("ait_policereport")]
    public OptionSetValue ait_policereport
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_policereport));
      set
      {
        this.OnPropertyChanging(nameof (ait_policereport));
        this.SetAttributeValue(nameof (ait_policereport), (object) value);
        this.OnPropertyChanged(nameof (ait_policereport));
      }
    }

    [AttributeLogicalName("ait_policereportno")]
    public string ait_PoliceReportNo
    {
      get => this.GetAttributeValue<string>("ait_policereportno");
      set
      {
        this.OnPropertyChanging(nameof (ait_PoliceReportNo));
        this.SetAttributeValue("ait_policereportno", (object) value);
        this.OnPropertyChanged(nameof (ait_PoliceReportNo));
      }
    }

    [AttributeLogicalName("ait_primaryinvestigator")]
    public EntityReference ait_primaryinvestigator
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_primaryinvestigator));
      set
      {
        this.OnPropertyChanging(nameof (ait_primaryinvestigator));
        this.SetAttributeValue(nameof (ait_primaryinvestigator), (object) value);
        this.OnPropertyChanged(nameof (ait_primaryinvestigator));
      }
    }

    [AttributeLogicalName("ait_relationshiptovictim")]
    public string ait_relationshiptovictim
    {
      get => this.GetAttributeValue<string>(nameof (ait_relationshiptovictim));
      set
      {
        this.OnPropertyChanging(nameof (ait_relationshiptovictim));
        this.SetAttributeValue(nameof (ait_relationshiptovictim), (object) value);
        this.OnPropertyChanged(nameof (ait_relationshiptovictim));
      }
    }

    [AttributeLogicalName("ait_reporter")]
    public EntityReference ait_reporter
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_reporter));
      set
      {
        this.OnPropertyChanging(nameof (ait_reporter));
        this.SetAttributeValue(nameof (ait_reporter), (object) value);
        this.OnPropertyChanged(nameof (ait_reporter));
      }
    }

    [AttributeLogicalName("ait_reportercontactinformation")]
    public string ait_ReporterContactInformation
    {
      get => this.GetAttributeValue<string>("ait_reportercontactinformation");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReporterContactInformation));
        this.SetAttributeValue("ait_reportercontactinformation", (object) value);
        this.OnPropertyChanged(nameof (ait_ReporterContactInformation));
      }
    }

    [AttributeLogicalName("ait_reportercontactrecord")]
    public bool? ait_ReporterContactRecord
    {
      get => this.GetAttributeValue<bool?>("ait_reportercontactrecord");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReporterContactRecord));
        this.SetAttributeValue("ait_reportercontactrecord", (object) value);
        this.OnPropertyChanged(nameof (ait_ReporterContactRecord));
      }
    }

    [AttributeLogicalName("ait_reportingorganization_company")]
    public EntityReference ait_ReportingOrganization_company
    {
      get => this.GetAttributeValue<EntityReference>("ait_reportingorganization_company");
      set
      {
        this.OnPropertyChanging(nameof (ait_ReportingOrganization_company));
        this.SetAttributeValue("ait_reportingorganization_company", (object) value);
        this.OnPropertyChanged(nameof (ait_ReportingOrganization_company));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    public EntityReference ait_ServiceRequest
    {
      get => this.GetAttributeValue<EntityReference>("ait_servicerequest");
      set
      {
        this.OnPropertyChanging(nameof (ait_ServiceRequest));
        this.SetAttributeValue("ait_servicerequest", (object) value);
        this.OnPropertyChanged(nameof (ait_ServiceRequest));
      }
    }

    [AttributeLogicalName("ait_substanceabuseifyes")]
    public OptionSetValue ait_substanceabuseifyes
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_substanceabuseifyes));
      set
      {
        this.OnPropertyChanging(nameof (ait_substanceabuseifyes));
        this.SetAttributeValue(nameof (ait_substanceabuseifyes), (object) value);
        this.OnPropertyChanged(nameof (ait_substanceabuseifyes));
      }
    }

    [AttributeLogicalName("ait_substanceabuseinvolvement")]
    public OptionSetValue ait_substanceabuseinvolvement
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_substanceabuseinvolvement));
      set
      {
        this.OnPropertyChanging(nameof (ait_substanceabuseinvolvement));
        this.SetAttributeValue(nameof (ait_substanceabuseinvolvement), (object) value);
        this.OnPropertyChanged(nameof (ait_substanceabuseinvolvement));
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

    [AttributeLogicalName("emailaddress")]
    public string EmailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EmailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EmailAddress));
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
    public ait_incidentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_incidentState?((ait_incidentState) Enum.ToObject(typeof (ait_incidentState), attributeValue.Value)) : new ait_incidentState?();
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

    [RelationshipSchemaName("ait_ait_incident_ait_icwanotice_RelatedIncident")]
    public IEnumerable<ait_icwanotice> ait_ait_incident_ait_icwanotice_RelatedIncident
    {
      get
      {
        return this.GetRelatedEntities<ait_icwanotice>(nameof (ait_ait_incident_ait_icwanotice_RelatedIncident), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incident_ait_icwanotice_RelatedIncident));
        this.SetRelatedEntities<ait_icwanotice>(nameof (ait_ait_incident_ait_icwanotice_RelatedIncident), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incident_ait_icwanotice_RelatedIncident));
      }
    }

    [RelationshipSchemaName("ait_incident_ActivityParties")]
    public IEnumerable<ActivityParty> ait_incident_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_incident_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_incident_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_incident_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_incident_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_incident_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_incident_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_incident_ait_investigation_incident")]
    public IEnumerable<ait_investigation> ait_incident_ait_investigation_incident
    {
      get
      {
        return this.GetRelatedEntities<ait_investigation>(nameof (ait_incident_ait_investigation_incident), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ait_investigation_incident));
        this.SetRelatedEntities<ait_investigation>(nameof (ait_incident_ait_investigation_incident), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ait_investigation_incident));
      }
    }

    [RelationshipSchemaName("ait_incident_ait_placement_Incident")]
    public IEnumerable<ait_placement> ait_incident_ait_placement_Incident
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_incident_ait_placement_Incident), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ait_placement_Incident));
        this.SetRelatedEntities<ait_placement>(nameof (ait_incident_ait_placement_Incident), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ait_placement_Incident));
      }
    }

    [RelationshipSchemaName("ait_incident_Annotations")]
    public IEnumerable<Annotation> ait_incident_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_incident_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_incident_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Annotations));
      }
    }

    [RelationshipSchemaName("ait_incident_Appointments")]
    public IEnumerable<Appointment> ait_incident_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_incident_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_incident_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Appointments));
      }
    }

    [RelationshipSchemaName("ait_incident_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_incident_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_incident_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_incident_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_incident_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_incident_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_incident_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_incident_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_incident_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_incident_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_incident_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_incident_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_incident_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_incident_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_incident_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_incident_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_incident_Emails")]
    public IEnumerable<Email> ait_incident_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_incident_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_incident_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Emails));
      }
    }

    [RelationshipSchemaName("ait_incident_Faxes")]
    public IEnumerable<Fax> ait_incident_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_incident_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_incident_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Faxes));
      }
    }

    [RelationshipSchemaName("ait_incident_Letters")]
    public IEnumerable<Letter> ait_incident_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_incident_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_incident_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Letters));
      }
    }

    [RelationshipSchemaName("ait_incident_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_incident_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_incident_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_incident_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_incident_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_incident_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_incident_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_incident_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_incident_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_incident_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_incident_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_incident_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_incident_ProcessSession")]
    public IEnumerable<ProcessSession> ait_incident_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_incident_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_incident_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_incident_QueueItems")]
    public IEnumerable<QueueItem> ait_incident_QueueItems
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (ait_incident_QueueItems), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_QueueItems));
        this.SetRelatedEntities<QueueItem>(nameof (ait_incident_QueueItems), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_QueueItems));
      }
    }

    [RelationshipSchemaName("ait_incident_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_incident_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_incident_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_incident_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_incident_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_incident_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_incident_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_incident_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_incident_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_incident_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_incident_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_incident_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_incident_SocialActivities")]
    public IEnumerable<SocialActivity> ait_incident_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_incident_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_incident_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_incident_SyncErrors")]
    public IEnumerable<SyncError> ait_incident_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_incident_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_incident_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_incident_Tasks")]
    public IEnumerable<Task> ait_incident_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_incident_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_incident_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Tasks));
      }
    }

    [RelationshipSchemaName("ait_incident_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_incident_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_incident_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_incident_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_incident_ait_clientprofile")]
    public IEnumerable<ArcticIT.EarlyBound.Entities.ait_clientprofile> ait_incident_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_incident_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ait_clientprofile));
        this.SetRelatedEntities<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_incident_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ait_clientprofile));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_incident_Case")]
    public ait_case ait_ait_case_ait_incident_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_incident_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_incident_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_incident_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_incident_Case));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_incident_clientprofile")]
    public ArcticIT.EarlyBound.Entities.ait_clientprofile ait_clientprofile_ait_incident_clientprofile
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_clientprofile_ait_incident_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incident_clientprofile));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_clientprofile_ait_incident_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incident_clientprofile));
      }
    }

    [AttributeLogicalName("ait_nameofvictim")]
    [RelationshipSchemaName("ait_clientprofile_ait_incident_nameofvictim")]
    public ArcticIT.EarlyBound.Entities.ait_clientprofile ait_clientprofile_ait_incident_nameofvictim
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_clientprofile_ait_incident_nameofvictim), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incident_nameofvictim));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_clientprofile_ait_incident_nameofvictim), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incident_nameofvictim));
      }
    }

    [AttributeLogicalName("ait_offendernameclientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_incident_offendernameclientprofile")]
    public ArcticIT.EarlyBound.Entities.ait_clientprofile ait_clientprofile_ait_incident_offendernameclientprofile
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_clientprofile_ait_incident_offendernameclientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incident_offendernameclientprofile));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_clientprofile>(nameof (ait_clientprofile_ait_incident_offendernameclientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incident_offendernameclientprofile));
      }
    }

    [AttributeLogicalName("ait_reportingorganization_company")]
    [RelationshipSchemaName("ait_company_ait_incident_ReportingOrganization_company")]
    public ait_company ait_company_ait_incident_ReportingOrganization_company
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_incident_ReportingOrganization_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_incident_ReportingOrganization_company));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_incident_ReportingOrganization_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_incident_ReportingOrganization_company));
      }
    }

    [AttributeLogicalName("ait_custodianname")]
    [RelationshipSchemaName("ait_contact_ait_incident_CustodianName")]
    public Contact ait_contact_ait_incident_CustodianName
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_CustodianName), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incident_CustodianName));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_CustodianName), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incident_CustodianName));
      }
    }

    [AttributeLogicalName("ait_fathersname")]
    [RelationshipSchemaName("ait_contact_ait_incident_fathersname")]
    public Contact ait_contact_ait_incident_fathersname
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_fathersname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incident_fathersname));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_fathersname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incident_fathersname));
      }
    }

    [AttributeLogicalName("ait_mothersname")]
    [RelationshipSchemaName("ait_contact_ait_incident_mothersname")]
    public Contact ait_contact_ait_incident_mothersname
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_mothersname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incident_mothersname));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_mothersname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incident_mothersname));
      }
    }

    [AttributeLogicalName("ait_offendercontactname")]
    [RelationshipSchemaName("ait_contact_ait_incident_OffenderContactName")]
    public Contact ait_contact_ait_incident_OffenderContactName
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_OffenderContactName), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incident_OffenderContactName));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_OffenderContactName), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incident_OffenderContactName));
      }
    }

    [AttributeLogicalName("ait_reporter")]
    [RelationshipSchemaName("ait_contact_ait_incident_reporter")]
    public Contact ait_contact_ait_incident_reporter
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_reporter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incident_reporter));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incident_reporter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incident_reporter));
      }
    }

    [AttributeLogicalName("ait_incidenttype")]
    [RelationshipSchemaName("ait_incidenttype_ait_incident_incidenttype")]
    public ArcticIT.EarlyBound.Entities.ait_incidenttype ait_incidenttype_ait_incident_incidenttype
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_incidenttype>(nameof (ait_incidenttype_ait_incident_incidenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype_ait_incident_incidenttype));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_incidenttype>(nameof (ait_incidenttype_ait_incident_incidenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidenttype_ait_incident_incidenttype));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    [RelationshipSchemaName("ait_servicerequest_ait_incident_ServiceRequest")]
    public ait_servicerequest ait_servicerequest_ait_incident_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_incident_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_incident_ServiceRequest));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_incident_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_incident_ServiceRequest));
      }
    }

    [AttributeLogicalName("ait_primaryinvestigator")]
    [RelationshipSchemaName("ait_systemuser_ait_incident_primaryinvestigator")]
    public SystemUser ait_systemuser_ait_incident_primaryinvestigator
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_incident_primaryinvestigator), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_incident_primaryinvestigator));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_incident_primaryinvestigator), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_incident_primaryinvestigator));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_incident_createdby")]
    public SystemUser lk_ait_incident_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incident_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_incident_createdonbehalfby")]
    public SystemUser lk_ait_incident_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incident_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incident_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_incident_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incident_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_incident_modifiedby")]
    public SystemUser lk_ait_incident_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incident_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_incident_modifiedonbehalfby")]
    public SystemUser lk_ait_incident_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incident_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incident_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_incident_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incident_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_incident")]
    public Organization organization_ait_incident
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_incident), new EntityRole?());
      }
    }

    public ait_incident(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_incidentid"] = (object) base.Id;
            break;
          case "ait_incidentid":
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
