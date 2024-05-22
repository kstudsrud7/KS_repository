// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_incidents
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_incidents")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_incidents : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_incidents";
    public const int EntityTypeCode = 10710;

    public ait_incidents()
      : base(nameof (ait_incidents))
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

    [AttributeLogicalName("ait_caseplan")]
    public EntityReference ait_caseplan
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_caseplan));
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan));
        this.SetAttributeValue(nameof (ait_caseplan), (object) value);
        this.OnPropertyChanged(nameof (ait_caseplan));
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

    [AttributeLogicalName("ait_incidentsid")]
    public Guid? ait_incidentsId
    {
      get => this.GetAttributeValue<Guid?>("ait_incidentsid");
      set
      {
        this.OnPropertyChanging(nameof (ait_incidentsId));
        this.SetAttributeValue("ait_incidentsid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_incidentsId));
      }
    }

    [AttributeLogicalName("ait_incidentsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_incidentsId = new Guid?(value);
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
    public Ait_incidentsState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_incidentsState?((Ait_incidentsState) Enum.ToObject(typeof (Ait_incidentsState), attributeValue.Value)) : new Ait_incidentsState?();
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
    public OptionSetValue statuscode
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (statuscode));
      set
      {
        this.OnPropertyChanging(nameof (statuscode));
        this.SetAttributeValue(nameof (statuscode), (object) value);
        this.OnPropertyChanged(nameof (statuscode));
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

    [RelationshipSchemaName("ait_ait_incidents_ait_investigation")]
    public IEnumerable<ait_investigation> ait_ait_incidents_ait_investigation
    {
      get
      {
        return this.GetRelatedEntities<ait_investigation>(nameof (ait_ait_incidents_ait_investigation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incidents_ait_investigation));
        this.SetRelatedEntities<ait_investigation>(nameof (ait_ait_incidents_ait_investigation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incidents_ait_investigation));
      }
    }

    [RelationshipSchemaName("ait_ait_incidents_ait_placement")]
    public IEnumerable<ait_placement> ait_ait_incidents_ait_placement
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_ait_incidents_ait_placement), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incidents_ait_placement));
        this.SetRelatedEntities<ait_placement>(nameof (ait_ait_incidents_ait_placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incidents_ait_placement));
      }
    }

    [RelationshipSchemaName("ait_ait_incidents_ait_planactivity")]
    public IEnumerable<ait_planactivity> ait_ait_incidents_ait_planactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_incidents_ait_planactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incidents_ait_planactivity));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_incidents_ait_planactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incidents_ait_planactivity));
      }
    }

    [RelationshipSchemaName("ait_incidents_Appointments")]
    public IEnumerable<Appointment> ait_incidents_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_incidents_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidents_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_incidents_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidents_Appointments));
      }
    }

    [RelationshipSchemaName("ait_incidents_Emails")]
    public IEnumerable<Email> ait_incidents_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_incidents_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incidents_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_incidents_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidents_Emails));
      }
    }

    [RelationshipSchemaName("ait_incidents_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_incidents_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_incidents_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidents_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_incidents_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidents_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_incidents_Tasks")]
    public IEnumerable<Task> ait_incidents_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_incidents_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incidents_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_incidents_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidents_Tasks));
      }
    }

    [RelationshipSchemaName("ait_ait_incidents_ait_clientprofile")]
    public IEnumerable<TPFamilyWellness.EarlyBound.ait_clientprofile> ait_ait_incidents_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<TPFamilyWellness.EarlyBound.ait_clientprofile>(nameof (ait_ait_incidents_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incidents_ait_clientprofile));
        this.SetRelatedEntities<TPFamilyWellness.EarlyBound.ait_clientprofile>(nameof (ait_ait_incidents_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incidents_ait_clientprofile));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_incidents_Case")]
    public ait_case ait_ait_case_ait_incidents_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_incidents_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_incidents_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_incidents_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_incidents_Case));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_incidents_FamilyPlan")]
    public TPFamilyWellness.EarlyBound.ait_caseplan ait_ait_caseplan_ait_incidents_FamilyPlan
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_caseplan>(nameof (ait_ait_caseplan_ait_incidents_FamilyPlan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_incidents_FamilyPlan));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_caseplan>(nameof (ait_ait_caseplan_ait_incidents_FamilyPlan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_incidents_FamilyPlan));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_incidents_clientprofile")]
    public TPFamilyWellness.EarlyBound.ait_clientprofile ait_clientprofile_ait_incidents_clientprofile
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_clientprofile>(nameof (ait_clientprofile_ait_incidents_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incidents_clientprofile));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_clientprofile>(nameof (ait_clientprofile_ait_incidents_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incidents_clientprofile));
      }
    }

    [AttributeLogicalName("ait_offendernameclientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_incidents_offendernameclientprofile")]
    public TPFamilyWellness.EarlyBound.ait_clientprofile ait_clientprofile_ait_incidents_offendernameclientprofile
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_clientprofile>(nameof (ait_clientprofile_ait_incidents_offendernameclientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incidents_offendernameclientprofile));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_clientprofile>(nameof (ait_clientprofile_ait_incidents_offendernameclientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incidents_offendernameclientprofile));
      }
    }

    [AttributeLogicalName("ait_custodianname")]
    [RelationshipSchemaName("ait_contact_ait_incidents_CustodianName")]
    public Contact ait_contact_ait_incidents_CustodianName
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_CustodianName), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_CustodianName));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_CustodianName), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_CustodianName));
      }
    }

    [AttributeLogicalName("ait_fathersname")]
    [RelationshipSchemaName("ait_contact_ait_incidents_fathersname")]
    public Contact ait_contact_ait_incidents_fathersname
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_fathersname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_fathersname));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_fathersname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_fathersname));
      }
    }

    [AttributeLogicalName("ait_mothersname")]
    [RelationshipSchemaName("ait_contact_ait_incidents_mothersname")]
    public Contact ait_contact_ait_incidents_mothersname
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_mothersname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_mothersname));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_mothersname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_mothersname));
      }
    }

    [AttributeLogicalName("ait_offendercontactname")]
    [RelationshipSchemaName("ait_contact_ait_incidents_OffenderContactName")]
    public Contact ait_contact_ait_incidents_OffenderContactName
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_OffenderContactName), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_OffenderContactName));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_OffenderContactName), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_OffenderContactName));
      }
    }

    [AttributeLogicalName("ait_reporter")]
    [RelationshipSchemaName("ait_contact_ait_incidents_reporter")]
    public Contact ait_contact_ait_incidents_reporter
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_reporter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_incidents_reporter));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_incidents_reporter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_incidents_reporter));
      }
    }

    [AttributeLogicalName("ait_incidenttype")]
    [RelationshipSchemaName("ait_incidenttype_ait_incidents_incidenttype")]
    public TPFamilyWellness.EarlyBound.ait_incidenttype ait_incidenttype_ait_incidents_incidenttype
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_incidenttype>(nameof (ait_incidenttype_ait_incidents_incidenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype_ait_incidents_incidenttype));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_incidenttype>(nameof (ait_incidenttype_ait_incidents_incidenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidenttype_ait_incidents_incidenttype));
      }
    }

    [AttributeLogicalName("ait_servicerequest")]
    [RelationshipSchemaName("ait_servicerequest_ait_incidents_ServiceRequest")]
    public ait_servicerequest ait_servicerequest_ait_incidents_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_incidents_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_incidents_ServiceRequest));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_ait_incidents_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_incidents_ServiceRequest));
      }
    }

    [AttributeLogicalName("ait_primaryinvestigator")]
    [RelationshipSchemaName("ait_systemuser_ait_incidents_primaryinvestigator")]
    public SystemUser ait_systemuser_ait_incidents_primaryinvestigator
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_incidents_primaryinvestigator), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_incidents_primaryinvestigator));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_incidents_primaryinvestigator), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_incidents_primaryinvestigator));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_incidents")]
    public BusinessUnit business_unit_ait_incidents
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_incidents), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_incidents_createdby")]
    public SystemUser lk_ait_incidents_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incidents_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_incidents_createdonbehalfby")]
    public SystemUser lk_ait_incidents_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incidents_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_incidents_modifiedby")]
    public SystemUser lk_ait_incidents_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incidents_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_incidents_modifiedonbehalfby")]
    public SystemUser lk_ait_incidents_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incidents_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_incidents")]
    public Team team_ait_incidents
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_incidents), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_incidents")]
    public SystemUser user_ait_incidents
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_incidents), new EntityRole?());
    }
  }
}
