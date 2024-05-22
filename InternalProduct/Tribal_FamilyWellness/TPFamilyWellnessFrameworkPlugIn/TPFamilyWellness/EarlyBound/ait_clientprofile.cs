// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_clientprofile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_clientprofile")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_clientprofile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_clientprofile";
    public const int EntityTypeCode = 10646;

    public ait_clientprofile()
      : base(nameof (ait_clientprofile))
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

    [AttributeLogicalName("ait_biologicalfather")]
    public string ait_BiologicalFather
    {
      get => this.GetAttributeValue<string>("ait_biologicalfather");
      set
      {
        this.OnPropertyChanging(nameof (ait_BiologicalFather));
        this.SetAttributeValue("ait_biologicalfather", (object) value);
        this.OnPropertyChanged(nameof (ait_BiologicalFather));
      }
    }

    [AttributeLogicalName("ait_biologicalmother")]
    public string ait_BiologicalMother
    {
      get => this.GetAttributeValue<string>("ait_biologicalmother");
      set
      {
        this.OnPropertyChanging(nameof (ait_BiologicalMother));
        this.SetAttributeValue("ait_biologicalmother", (object) value);
        this.OnPropertyChanged(nameof (ait_BiologicalMother));
      }
    }

    [AttributeLogicalName("ait_birthdate")]
    public EntityReference ait_BirthDate
    {
      get => this.GetAttributeValue<EntityReference>("ait_birthdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_BirthDate));
        this.SetAttributeValue("ait_birthdate", (object) value);
        this.OnPropertyChanged(nameof (ait_BirthDate));
      }
    }

    [AttributeLogicalName("ait_birthdatename")]
    public string ait_BirthDateName => this.GetAttributeValue<string>("ait_birthdatename");

    [AttributeLogicalName("ait_clientid")]
    public string ait_ClientID
    {
      get => this.GetAttributeValue<string>("ait_clientid");
      set
      {
        this.OnPropertyChanging(nameof (ait_ClientID));
        this.SetAttributeValue("ait_clientid", (object) value);
        this.OnPropertyChanged(nameof (ait_ClientID));
      }
    }

    [AttributeLogicalName("ait_clientprofileid")]
    public Guid? ait_clientprofileId
    {
      get => this.GetAttributeValue<Guid?>("ait_clientprofileid");
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofileId));
        this.SetAttributeValue("ait_clientprofileid", (object) value);
        this.OnPropertyChanged(nameof (ait_clientprofileId));
      }
    }

    [AttributeLogicalName("ait_clienttype")]
    public OptionSetValue ait_ClientType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_clienttype");
      set
      {
        this.OnPropertyChanging(nameof (ait_ClientType));
        this.SetAttributeValue("ait_clienttype", (object) value);
        this.OnPropertyChanged(nameof (ait_ClientType));
      }
    }

    [AttributeLogicalName("ait_clienttypename")]
    public object ait_clienttypeName => this.GetAttributeValue<object>("ait_clienttypename");

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

    [AttributeLogicalName("ait_contactage")]
    public int? ait_ContactAge
    {
      get => this.GetAttributeValue<int?>("ait_contactage");
      set
      {
        this.OnPropertyChanging(nameof (ait_ContactAge));
        this.SetAttributeValue("ait_contactage", (object) value);
        this.OnPropertyChanged(nameof (ait_ContactAge));
      }
    }

    [AttributeLogicalName("ait_contactagegroup")]
    public OptionSetValue ait_ContactAgeGroup
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_contactagegroup");
      set
      {
        this.OnPropertyChanging(nameof (ait_ContactAgeGroup));
        this.SetAttributeValue("ait_contactagegroup", (object) value);
        this.OnPropertyChanged(nameof (ait_ContactAgeGroup));
      }
    }

    [AttributeLogicalName("ait_contactagegroupname")]
    public object ait_contactagegroupName
    {
      get => this.GetAttributeValue<object>("ait_contactagegroupname");
    }

    [AttributeLogicalName("ait_contactfullname")]
    public string ait_ContactFullName
    {
      get => this.GetAttributeValue<string>("ait_contactfullname");
      set
      {
        this.OnPropertyChanging(nameof (ait_ContactFullName));
        this.SetAttributeValue("ait_contactfullname", (object) value);
        this.OnPropertyChanged(nameof (ait_ContactFullName));
      }
    }

    [AttributeLogicalName("ait_contactname")]
    public string ait_ContactName => this.GetAttributeValue<string>("ait_contactname");

    [AttributeLogicalName("ait_contactyominame")]
    public string ait_ContactYomiName => this.GetAttributeValue<string>("ait_contactyominame");

    [AttributeLogicalName("ait_courtcaseid")]
    public string ait_CourtCaseID
    {
      get => this.GetAttributeValue<string>("ait_courtcaseid");
      set
      {
        this.OnPropertyChanging(nameof (ait_CourtCaseID));
        this.SetAttributeValue("ait_courtcaseid", (object) value);
        this.OnPropertyChanged(nameof (ait_CourtCaseID));
      }
    }

    [AttributeLogicalName("ait_dentalinsurancegroupnumber")]
    public string ait_DentalInsuranceGroupNumber
    {
      get => this.GetAttributeValue<string>("ait_dentalinsurancegroupnumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_DentalInsuranceGroupNumber));
        this.SetAttributeValue("ait_dentalinsurancegroupnumber", (object) value);
        this.OnPropertyChanged(nameof (ait_DentalInsuranceGroupNumber));
      }
    }

    [AttributeLogicalName("ait_dentalinsurancenumber")]
    public string ait_DentalInsuranceNumber
    {
      get => this.GetAttributeValue<string>("ait_dentalinsurancenumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_DentalInsuranceNumber));
        this.SetAttributeValue("ait_dentalinsurancenumber", (object) value);
        this.OnPropertyChanged(nameof (ait_DentalInsuranceNumber));
      }
    }

    [AttributeLogicalName("ait_dentalinsuranceprovider")]
    public EntityReference ait_DentalInsuranceProvider
    {
      get => this.GetAttributeValue<EntityReference>("ait_dentalinsuranceprovider");
      set
      {
        this.OnPropertyChanging(nameof (ait_DentalInsuranceProvider));
        this.SetAttributeValue("ait_dentalinsuranceprovider", (object) value);
        this.OnPropertyChanged(nameof (ait_DentalInsuranceProvider));
      }
    }

    [AttributeLogicalName("ait_dentalinsuranceprovidername")]
    public string ait_DentalInsuranceProviderName
    {
      get => this.GetAttributeValue<string>("ait_dentalinsuranceprovidername");
    }

    [AttributeLogicalName("ait_disabled")]
    public bool? ait_Disabled
    {
      get => this.GetAttributeValue<bool?>("ait_disabled");
      set
      {
        this.OnPropertyChanging(nameof (ait_Disabled));
        this.SetAttributeValue("ait_disabled", (object) value);
        this.OnPropertyChanged(nameof (ait_Disabled));
      }
    }

    [AttributeLogicalName("ait_disabledname")]
    public object ait_disabledName => this.GetAttributeValue<object>("ait_disabledname");

    [AttributeLogicalName("ait_driverslicenseexpirationdate")]
    public DateTime? ait_DriversLicenseExpirationDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_driverslicenseexpirationdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DriversLicenseExpirationDate));
        this.SetAttributeValue("ait_driverslicenseexpirationdate", (object) value);
        this.OnPropertyChanged(nameof (ait_DriversLicenseExpirationDate));
      }
    }

    [AttributeLogicalName("ait_driverslicenseissuedate")]
    public DateTime? ait_DriversLicenseIssueDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_driverslicenseissuedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DriversLicenseIssueDate));
        this.SetAttributeValue("ait_driverslicenseissuedate", (object) value);
        this.OnPropertyChanged(nameof (ait_DriversLicenseIssueDate));
      }
    }

    [AttributeLogicalName("ait_driverslicensenotes")]
    public string ait_DriversLicenseNotes
    {
      get => this.GetAttributeValue<string>("ait_driverslicensenotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_DriversLicenseNotes));
        this.SetAttributeValue("ait_driverslicensenotes", (object) value);
        this.OnPropertyChanged(nameof (ait_DriversLicenseNotes));
      }
    }

    [AttributeLogicalName("ait_driverslicensenumber")]
    public string ait_DriversLicenseNumber
    {
      get => this.GetAttributeValue<string>("ait_driverslicensenumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_DriversLicenseNumber));
        this.SetAttributeValue("ait_driverslicensenumber", (object) value);
        this.OnPropertyChanged(nameof (ait_DriversLicenseNumber));
      }
    }

    [AttributeLogicalName("ait_driverslicensestate")]
    public string ait_DriversLicenseState
    {
      get => this.GetAttributeValue<string>("ait_driverslicensestate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DriversLicenseState));
        this.SetAttributeValue("ait_driverslicensestate", (object) value);
        this.OnPropertyChanged(nameof (ait_DriversLicenseState));
      }
    }

    [AttributeLogicalName("ait_duedate")]
    public DateTime? ait_DueDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_duedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_DueDate));
        this.SetAttributeValue("ait_duedate", (object) value);
        this.OnPropertyChanged(nameof (ait_DueDate));
      }
    }

    [AttributeLogicalName("ait_fostercarepaymentcategory")]
    public OptionSetValue ait_FosterCarePaymentCategory
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_fostercarepaymentcategory");
      set
      {
        this.OnPropertyChanging(nameof (ait_FosterCarePaymentCategory));
        this.SetAttributeValue("ait_fostercarepaymentcategory", (object) value);
        this.OnPropertyChanged(nameof (ait_FosterCarePaymentCategory));
      }
    }

    [AttributeLogicalName("ait_fostercarepaymentcategoryname")]
    public object ait_fostercarepaymentcategoryName
    {
      get => this.GetAttributeValue<object>("ait_fostercarepaymentcategoryname");
    }

    [AttributeLogicalName("ait_gender")]
    public OptionSetValue ait_gender
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_gender));
      set
      {
        this.OnPropertyChanging(nameof (ait_gender));
        this.SetAttributeValue(nameof (ait_gender), (object) value);
        this.OnPropertyChanged(nameof (ait_gender));
      }
    }

    [AttributeLogicalName("ait_gendername")]
    public object ait_genderName => this.GetAttributeValue<object>("ait_gendername");

    [AttributeLogicalName("ait_groupactivitiesclientprofileid")]
    public EntityReference ait_GroupActivitiesClientProfileId
    {
      get => this.GetAttributeValue<EntityReference>("ait_groupactivitiesclientprofileid");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivitiesClientProfileId));
        this.SetAttributeValue("ait_groupactivitiesclientprofileid", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivitiesClientProfileId));
      }
    }

    [AttributeLogicalName("ait_groupactivitiesclientprofileidname")]
    public string ait_GroupActivitiesClientProfileIdName
    {
      get => this.GetAttributeValue<string>("ait_groupactivitiesclientprofileidname");
    }

    [AttributeLogicalName("ait_groupactivitymeetingid")]
    public EntityReference ait_GroupActivityMeetingId
    {
      get => this.GetAttributeValue<EntityReference>("ait_groupactivitymeetingid");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivityMeetingId));
        this.SetAttributeValue("ait_groupactivitymeetingid", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivityMeetingId));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeetingidname")]
    public string ait_GroupActivityMeetingIdName
    {
      get => this.GetAttributeValue<string>("ait_groupactivitymeetingidname");
    }

    [AttributeLogicalName("ait_guardian1")]
    public EntityReference ait_Guardian1
    {
      get => this.GetAttributeValue<EntityReference>("ait_guardian1");
      set
      {
        this.OnPropertyChanging(nameof (ait_Guardian1));
        this.SetAttributeValue("ait_guardian1", (object) value);
        this.OnPropertyChanged(nameof (ait_Guardian1));
      }
    }

    [AttributeLogicalName("ait_guardian1name")]
    public string ait_Guardian1Name => this.GetAttributeValue<string>("ait_guardian1name");

    [AttributeLogicalName("ait_guardian1yominame")]
    public string ait_Guardian1YomiName => this.GetAttributeValue<string>("ait_guardian1yominame");

    [AttributeLogicalName("ait_guardian2")]
    public EntityReference ait_Guardian2
    {
      get => this.GetAttributeValue<EntityReference>("ait_guardian2");
      set
      {
        this.OnPropertyChanging(nameof (ait_Guardian2));
        this.SetAttributeValue("ait_guardian2", (object) value);
        this.OnPropertyChanged(nameof (ait_Guardian2));
      }
    }

    [AttributeLogicalName("ait_guardian2name")]
    public string ait_Guardian2Name => this.GetAttributeValue<string>("ait_guardian2name");

    [AttributeLogicalName("ait_guardian2yominame")]
    public string ait_Guardian2YomiName => this.GetAttributeValue<string>("ait_guardian2yominame");

    [AttributeLogicalName("ait_hearingimpaired")]
    public bool? ait_HearingImpaired
    {
      get => this.GetAttributeValue<bool?>("ait_hearingimpaired");
      set
      {
        this.OnPropertyChanging(nameof (ait_HearingImpaired));
        this.SetAttributeValue("ait_hearingimpaired", (object) value);
        this.OnPropertyChanged(nameof (ait_HearingImpaired));
      }
    }

    [AttributeLogicalName("ait_hearingimpairedname")]
    public object ait_hearingimpairedName
    {
      get => this.GetAttributeValue<object>("ait_hearingimpairedname");
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

    [AttributeLogicalName("ait_insurancelastupdate")]
    public DateTime? ait_InsuranceLastUpdate
    {
      get => this.GetAttributeValue<DateTime?>("ait_insurancelastupdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_InsuranceLastUpdate));
        this.SetAttributeValue("ait_insurancelastupdate", (object) value);
        this.OnPropertyChanged(nameof (ait_InsuranceLastUpdate));
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

    [AttributeLogicalName("ait_insuranceprovider_company")]
    public EntityReference ait_InsuranceProvider_company
    {
      get => this.GetAttributeValue<EntityReference>("ait_insuranceprovider_company");
      set
      {
        this.OnPropertyChanging(nameof (ait_InsuranceProvider_company));
        this.SetAttributeValue("ait_insuranceprovider_company", (object) value);
        this.OnPropertyChanged(nameof (ait_InsuranceProvider_company));
      }
    }

    [AttributeLogicalName("ait_insuranceprovider_companyname")]
    public string ait_InsuranceProvider_companyName
    {
      get => this.GetAttributeValue<string>("ait_insuranceprovider_companyname");
    }

    [AttributeLogicalName("ait_lastupdate")]
    public DateTime? ait_LastUpdate
    {
      get => this.GetAttributeValue<DateTime?>("ait_lastupdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastUpdate));
        this.SetAttributeValue("ait_lastupdate", (object) value);
        this.OnPropertyChanged(nameof (ait_LastUpdate));
      }
    }

    [AttributeLogicalName("ait_lastupdatedental")]
    public DateTime? ait_LastUpdateDental
    {
      get => this.GetAttributeValue<DateTime?>("ait_lastupdatedental");
      set
      {
        this.OnPropertyChanging(nameof (ait_LastUpdateDental));
        this.SetAttributeValue("ait_lastupdatedental", (object) value);
        this.OnPropertyChanged(nameof (ait_LastUpdateDental));
      }
    }

    [AttributeLogicalName("ait_maritalstatus")]
    public OptionSetValue ait_maritalstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_maritalstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_maritalstatus));
        this.SetAttributeValue(nameof (ait_maritalstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_maritalstatus));
      }
    }

    [AttributeLogicalName("ait_maritalstatusname")]
    public object ait_maritalstatusName => this.GetAttributeValue<object>("ait_maritalstatusname");

    [AttributeLogicalName("ait_medicalbackground")]
    public string ait_MedicalBackground
    {
      get => this.GetAttributeValue<string>("ait_medicalbackground");
      set
      {
        this.OnPropertyChanging(nameof (ait_MedicalBackground));
        this.SetAttributeValue("ait_medicalbackground", (object) value);
        this.OnPropertyChanged(nameof (ait_MedicalBackground));
      }
    }

    [AttributeLogicalName("ait_meetingattendeeid")]
    public EntityReference ait_MeetingAttendeeId
    {
      get => this.GetAttributeValue<EntityReference>("ait_meetingattendeeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingAttendeeId));
        this.SetAttributeValue("ait_meetingattendeeid", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingAttendeeId));
      }
    }

    [AttributeLogicalName("ait_meetingattendeeidname")]
    public string ait_MeetingAttendeeIdName
    {
      get => this.GetAttributeValue<string>("ait_meetingattendeeidname");
    }

    [AttributeLogicalName("ait_memberstatusenr")]
    public OptionSetValue ait_MemberStatusENR
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_memberstatusenr");
      set
      {
        this.OnPropertyChanging(nameof (ait_MemberStatusENR));
        this.SetAttributeValue("ait_memberstatusenr", (object) value);
        this.OnPropertyChanged(nameof (ait_MemberStatusENR));
      }
    }

    [AttributeLogicalName("ait_memberstatusenrname")]
    public object ait_memberstatusenrName
    {
      get => this.GetAttributeValue<object>("ait_memberstatusenrname");
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

    [AttributeLogicalName("ait_nextofkin")]
    public EntityReference ait_NextofKin
    {
      get => this.GetAttributeValue<EntityReference>("ait_nextofkin");
      set
      {
        this.OnPropertyChanging(nameof (ait_NextofKin));
        this.SetAttributeValue("ait_nextofkin", (object) value);
        this.OnPropertyChanged(nameof (ait_NextofKin));
      }
    }

    [AttributeLogicalName("ait_nextofkinname")]
    public string ait_NextofKinName => this.GetAttributeValue<string>("ait_nextofkinname");

    [AttributeLogicalName("ait_nextofkinrelationship")]
    public OptionSetValue ait_NextofKinRelationship
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_nextofkinrelationship");
      set
      {
        this.OnPropertyChanging(nameof (ait_NextofKinRelationship));
        this.SetAttributeValue("ait_nextofkinrelationship", (object) value);
        this.OnPropertyChanged(nameof (ait_NextofKinRelationship));
      }
    }

    [AttributeLogicalName("ait_nextofkinrelationshipname")]
    public object ait_nextofkinrelationshipName
    {
      get => this.GetAttributeValue<object>("ait_nextofkinrelationshipname");
    }

    [AttributeLogicalName("ait_nextofkinyominame")]
    public string ait_NextofKinYomiName => this.GetAttributeValue<string>("ait_nextofkinyominame");

    [AttributeLogicalName("ait_noofmeetingsattended")]
    public int? ait_NoofMeetingsAttended
    {
      get => this.GetAttributeValue<int?>("ait_noofmeetingsattended");
      set
      {
        this.OnPropertyChanging(nameof (ait_NoofMeetingsAttended));
        this.SetAttributeValue("ait_noofmeetingsattended", (object) value);
        this.OnPropertyChanged(nameof (ait_NoofMeetingsAttended));
      }
    }

    [AttributeLogicalName("ait_noofmeetingsattended_date")]
    public DateTime? ait_NoofMeetingsAttended_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_noofmeetingsattended_date");
    }

    [AttributeLogicalName("ait_noofmeetingsattended_state")]
    public int? ait_NoofMeetingsAttended_State
    {
      get => this.GetAttributeValue<int?>("ait_noofmeetingsattended_state");
    }

    [AttributeLogicalName("ait_otherincome")]
    public Money ait_OtherIncome
    {
      get => this.GetAttributeValue<Money>("ait_otherincome");
      set
      {
        this.OnPropertyChanging(nameof (ait_OtherIncome));
        this.SetAttributeValue("ait_otherincome", (object) value);
        this.OnPropertyChanged(nameof (ait_OtherIncome));
      }
    }

    [AttributeLogicalName("ait_otherincome_base")]
    public Money ait_otherincome_Base => this.GetAttributeValue<Money>("ait_otherincome_base");

    [AttributeLogicalName("ait_paymentcounttoclient")]
    public int? ait_paymentcounttoclient
    {
      get => this.GetAttributeValue<int?>(nameof (ait_paymentcounttoclient));
    }

    [AttributeLogicalName("ait_paymentcounttoclient_date")]
    public DateTime? ait_paymentcounttoclient_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentcounttoclient_date");
    }

    [AttributeLogicalName("ait_paymentcounttoclient_state")]
    public int? ait_paymentcounttoclient_State
    {
      get => this.GetAttributeValue<int?>("ait_paymentcounttoclient_state");
    }

    [AttributeLogicalName("ait_paymentcounttoother")]
    public int? ait_paymentcounttoother
    {
      get => this.GetAttributeValue<int?>(nameof (ait_paymentcounttoother));
    }

    [AttributeLogicalName("ait_paymentcounttoother_date")]
    public DateTime? ait_paymentcounttoother_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentcounttoother_date");
    }

    [AttributeLogicalName("ait_paymentcounttoother_state")]
    public int? ait_paymentcounttoother_State
    {
      get => this.GetAttributeValue<int?>("ait_paymentcounttoother_state");
    }

    [AttributeLogicalName("ait_paymentstoclient")]
    public Money ait_paymentstoclient
    {
      get => this.GetAttributeValue<Money>(nameof (ait_paymentstoclient));
    }

    [AttributeLogicalName("ait_paymentstoclient_base")]
    public Money ait_paymentstoclient_Base
    {
      get => this.GetAttributeValue<Money>("ait_paymentstoclient_base");
    }

    [AttributeLogicalName("ait_paymentstoclient_date")]
    public DateTime? ait_paymentstoclient_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentstoclient_date");
    }

    [AttributeLogicalName("ait_paymentstoclient_state")]
    public int? ait_paymentstoclient_State
    {
      get => this.GetAttributeValue<int?>("ait_paymentstoclient_state");
    }

    [AttributeLogicalName("ait_paymentstoother")]
    public Money ait_paymentstoother => this.GetAttributeValue<Money>(nameof (ait_paymentstoother));

    [AttributeLogicalName("ait_paymentstoother_base")]
    public Money ait_paymentstoother_Base
    {
      get => this.GetAttributeValue<Money>("ait_paymentstoother_base");
    }

    [AttributeLogicalName("ait_paymentstoother_date")]
    public DateTime? ait_paymentstoother_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_paymentstoother_date");
    }

    [AttributeLogicalName("ait_paymentstoother_state")]
    public int? ait_paymentstoother_State
    {
      get => this.GetAttributeValue<int?>("ait_paymentstoother_state");
    }

    [AttributeLogicalName("ait_pharmacy")]
    public EntityReference ait_Pharmacy
    {
      get => this.GetAttributeValue<EntityReference>("ait_pharmacy");
      set
      {
        this.OnPropertyChanging(nameof (ait_Pharmacy));
        this.SetAttributeValue("ait_pharmacy", (object) value);
        this.OnPropertyChanged(nameof (ait_Pharmacy));
      }
    }

    [AttributeLogicalName("ait_pharmacyname")]
    public string ait_PharmacyName => this.GetAttributeValue<string>("ait_pharmacyname");

    [AttributeLogicalName("ait_primarymedicalfacility")]
    public EntityReference ait_PrimaryMedicalFacility
    {
      get => this.GetAttributeValue<EntityReference>("ait_primarymedicalfacility");
      set
      {
        this.OnPropertyChanging(nameof (ait_PrimaryMedicalFacility));
        this.SetAttributeValue("ait_primarymedicalfacility", (object) value);
        this.OnPropertyChanged(nameof (ait_PrimaryMedicalFacility));
      }
    }

    [AttributeLogicalName("ait_primarymedicalfacilityname")]
    public string ait_PrimaryMedicalFacilityName
    {
      get => this.GetAttributeValue<string>("ait_primarymedicalfacilityname");
    }

    [AttributeLogicalName("ait_primarymedicalprovidername")]
    public string ait_PrimaryMedicalProviderName
    {
      get => this.GetAttributeValue<string>("ait_primarymedicalprovidername");
      set
      {
        this.OnPropertyChanging(nameof (ait_PrimaryMedicalProviderName));
        this.SetAttributeValue("ait_primarymedicalprovidername", (object) value);
        this.OnPropertyChanged(nameof (ait_PrimaryMedicalProviderName));
      }
    }

    [AttributeLogicalName("ait_primaryprovider")]
    public EntityReference ait_PrimaryProvider
    {
      get => this.GetAttributeValue<EntityReference>("ait_primaryprovider");
      set
      {
        this.OnPropertyChanging(nameof (ait_PrimaryProvider));
        this.SetAttributeValue("ait_primaryprovider", (object) value);
        this.OnPropertyChanged(nameof (ait_PrimaryProvider));
      }
    }

    [AttributeLogicalName("ait_primaryprovidername")]
    public string ait_PrimaryProviderName
    {
      get => this.GetAttributeValue<string>("ait_primaryprovidername");
    }

    [AttributeLogicalName("ait_primaryprovideryominame")]
    public string ait_PrimaryProviderYomiName
    {
      get => this.GetAttributeValue<string>("ait_primaryprovideryominame");
    }

    [AttributeLogicalName("ait_tribalid")]
    public string ait_TribalID
    {
      get => this.GetAttributeValue<string>("ait_tribalid");
      set
      {
        this.OnPropertyChanging(nameof (ait_TribalID));
        this.SetAttributeValue("ait_tribalid", (object) value);
        this.OnPropertyChanged(nameof (ait_TribalID));
      }
    }

    [AttributeLogicalName("ait_unbornchild")]
    public OptionSetValue ait_UnbornChild
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_unbornchild");
      set
      {
        this.OnPropertyChanging(nameof (ait_UnbornChild));
        this.SetAttributeValue("ait_unbornchild", (object) value);
        this.OnPropertyChanged(nameof (ait_UnbornChild));
      }
    }

    [AttributeLogicalName("ait_unbornchildname")]
    public object ait_unbornchildName => this.GetAttributeValue<object>("ait_unbornchildname");

    [AttributeLogicalName("ait_visualimpaired")]
    public bool? ait_VisualImpaired
    {
      get => this.GetAttributeValue<bool?>("ait_visualimpaired");
      set
      {
        this.OnPropertyChanging(nameof (ait_VisualImpaired));
        this.SetAttributeValue("ait_visualimpaired", (object) value);
        this.OnPropertyChanged(nameof (ait_VisualImpaired));
      }
    }

    [AttributeLogicalName("ait_visualimpairedname")]
    public object ait_visualimpairedName
    {
      get => this.GetAttributeValue<object>("ait_visualimpairedname");
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdbyname")]
    public string CreatedByName => this.GetAttributeValue<string>("createdbyname");

    [AttributeLogicalName("createdbyyominame")]
    public string CreatedByYomiName => this.GetAttributeValue<string>("createdbyyominame");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("createdonbehalfbyname")]
    public string CreatedOnBehalfByName => this.GetAttributeValue<string>("createdonbehalfbyname");

    [AttributeLogicalName("createdonbehalfbyyominame")]
    public string CreatedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("createdonbehalfbyyominame");
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("modifiedbyname")]
    public string ModifiedByName => this.GetAttributeValue<string>("modifiedbyname");

    [AttributeLogicalName("modifiedbyyominame")]
    public string ModifiedByYomiName => this.GetAttributeValue<string>("modifiedbyyominame");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
    }

    [AttributeLogicalName("modifiedonbehalfbyname")]
    public string ModifiedOnBehalfByName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyname");
    }

    [AttributeLogicalName("modifiedonbehalfbyyominame")]
    public string ModifiedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyyominame");
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

    [AttributeLogicalName("owneridname")]
    public string OwnerIdName => this.GetAttributeValue<string>("owneridname");

    [AttributeLogicalName("owneridtype")]
    public string OwnerIdType
    {
      get => this.GetAttributeValue<string>("owneridtype");
      set
      {
        this.OnPropertyChanging(nameof (OwnerIdType));
        this.SetAttributeValue("owneridtype", (object) value);
        this.OnPropertyChanged(nameof (OwnerIdType));
      }
    }

    [AttributeLogicalName("owneridyominame")]
    public string OwnerIdYomiName => this.GetAttributeValue<string>("owneridyominame");

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
    public Ait_clientprofileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_clientprofileState?((Ait_clientprofileState) Enum.ToObject(typeof (Ait_clientprofileState), attributeValue.Value)) : new Ait_clientprofileState?();
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

    [AttributeLogicalName("statecodename")]
    public object statecodeName => this.GetAttributeValue<object>("statecodename");

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

    [AttributeLogicalName("statuscodename")]
    public object statuscodeName => this.GetAttributeValue<object>("statuscodename");

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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("transactioncurrencyidname")]
    public string TransactionCurrencyIdName
    {
      get => this.GetAttributeValue<string>("transactioncurrencyidname");
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

    [RelationshipSchemaName("ait_ait_clientprofile_ait_assessment_Individual")]
    public IEnumerable<ait_assessment> ait_ait_clientprofile_ait_assessment_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (ait_ait_clientprofile_ait_assessment_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_assessment_Individual));
        this.SetRelatedEntities<ait_assessment>(nameof (ait_ait_clientprofile_ait_assessment_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_assessment_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_ait_case_Client")]
    public IEnumerable<ait_case> ait_ait_clientprofile_ait_case_Client
    {
      get
      {
        return this.GetRelatedEntities<ait_case>(nameof (ait_ait_clientprofile_ait_case_Client), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_case_Client));
        this.SetRelatedEntities<ait_case>(nameof (ait_ait_clientprofile_ait_case_Client), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_case_Client));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_ait_caseplan_Individual")]
    public IEnumerable<ait_caseplan> ait_ait_clientprofile_ait_caseplan_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (ait_ait_clientprofile_ait_caseplan_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_caseplan_Individual));
        this.SetRelatedEntities<ait_caseplan>(nameof (ait_ait_clientprofile_ait_caseplan_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_caseplan_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_ait_goal_Individual")]
    public IEnumerable<ait_goal> ait_ait_clientprofile_ait_goal_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (ait_ait_clientprofile_ait_goal_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_goal_Individual));
        this.SetRelatedEntities<ait_goal>(nameof (ait_ait_clientprofile_ait_goal_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_goal_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_ait_payment_Individual")]
    public IEnumerable<ait_payment> ait_ait_clientprofile_ait_payment_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_ait_clientprofile_ait_payment_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_payment_Individual));
        this.SetRelatedEntities<ait_payment>(nameof (ait_ait_clientprofile_ait_payment_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_payment_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_ait_planactivity_Individual")]
    public IEnumerable<ait_planactivity> ait_ait_clientprofile_ait_planactivity_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_clientprofile_ait_planactivity_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_planactivity_Individual));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_clientprofile_ait_planactivity_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_planactivity_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_ait_referral_Individual")]
    public IEnumerable<ait_referral> ait_ait_clientprofile_ait_referral_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_ait_clientprofile_ait_referral_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_referral_Individual));
        this.SetRelatedEntities<ait_referral>(nameof (ait_ait_clientprofile_ait_referral_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_referral_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_appointment_Individual")]
    public IEnumerable<Appointment> ait_ait_clientprofile_appointment_Individual
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_ait_clientprofile_appointment_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_appointment_Individual));
        this.SetRelatedEntities<Appointment>(nameof (ait_ait_clientprofile_appointment_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_appointment_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_contact_ClientProfile")]
    public IEnumerable<Contact> ait_ait_clientprofile_contact_ClientProfile
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_ait_clientprofile_contact_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_contact_ClientProfile));
        this.SetRelatedEntities<Contact>(nameof (ait_ait_clientprofile_contact_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_contact_ClientProfile));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_email_Individual")]
    public IEnumerable<Email> ait_ait_clientprofile_email_Individual
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (ait_ait_clientprofile_email_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_email_Individual));
        this.SetRelatedEntities<Email>(nameof (ait_ait_clientprofile_email_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_email_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_phonecall_Individual")]
    public IEnumerable<PhoneCall> ait_ait_clientprofile_phonecall_Individual
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_ait_clientprofile_phonecall_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_phonecall_Individual));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_ait_clientprofile_phonecall_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_phonecall_Individual));
      }
    }

    [RelationshipSchemaName("ait_ait_clientprofile_task_Individual")]
    public IEnumerable<Task> ait_ait_clientprofile_task_Individual
    {
      get
      {
        return this.GetRelatedEntities<Task>(nameof (ait_ait_clientprofile_task_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_task_Individual));
        this.SetRelatedEntities<Task>(nameof (ait_ait_clientprofile_task_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_task_Individual));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_casenotefamilywellness_Individual")]
    public IEnumerable<ait_casenotefamilywellness> ait_clientprofile_ait_casenotefamilywellness_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_clientprofile_ait_casenotefamilywellness_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_casenotefamilywellness_Individual));
        this.SetRelatedEntities<ait_casenotefamilywellness>(nameof (ait_clientprofile_ait_casenotefamilywellness_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_casenotefamilywellness_Individual));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_groupactivityregistration_ClientProfile")]
    public IEnumerable<ait_groupactivityregistration> ait_clientprofile_ait_groupactivityregistration_ClientProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivityregistration>(nameof (ait_clientprofile_ait_groupactivityregistration_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_groupactivityregistration_ClientProfile));
        this.SetRelatedEntities<ait_groupactivityregistration>(nameof (ait_clientprofile_ait_groupactivityregistration_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_groupactivityregistration_ClientProfile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_incidents_clientprofile")]
    public IEnumerable<ait_incidents> ait_clientprofile_ait_incidents_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_clientprofile_ait_incidents_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incidents_clientprofile));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_clientprofile_ait_incidents_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incidents_clientprofile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_incidents_offendernameclientprofile")]
    public IEnumerable<ait_incidents> ait_clientprofile_ait_incidents_offendernameclientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_clientprofile_ait_incidents_offendernameclientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incidents_offendernameclientprofile));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_clientprofile_ait_incidents_offendernameclientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incidents_offendernameclientprofile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_meetingattendee_ClientProfile")]
    public IEnumerable<ait_meetingattendee> ait_clientprofile_ait_meetingattendee_ClientProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_meetingattendee>(nameof (ait_clientprofile_ait_meetingattendee_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_meetingattendee_ClientProfile));
        this.SetRelatedEntities<ait_meetingattendee>(nameof (ait_clientprofile_ait_meetingattendee_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_meetingattendee_ClientProfile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_payment_PayeeClientProfile")]
    public IEnumerable<ait_payment> ait_clientprofile_ait_payment_PayeeClientProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_clientprofile_ait_payment_PayeeClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_payment_PayeeClientProfile));
        this.SetRelatedEntities<ait_payment>(nameof (ait_clientprofile_ait_payment_PayeeClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_payment_PayeeClientProfile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_placement_PlacedPerson")]
    public IEnumerable<ait_placement> ait_clientprofile_ait_placement_PlacedPerson
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_clientprofile_ait_placement_PlacedPerson), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_placement_PlacedPerson));
        this.SetRelatedEntities<ait_placement>(nameof (ait_clientprofile_ait_placement_PlacedPerson), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_placement_PlacedPerson));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_Appointments")]
    public IEnumerable<Appointment> ait_clientprofile_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_clientprofile_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_clientprofile_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Appointments));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_Emails")]
    public IEnumerable<Email> ait_clientprofile_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_clientprofile_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_clientprofile_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Emails));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_clientprofile_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_clientprofile_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_clientprofile_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_Tasks")]
    public IEnumerable<Task> ait_clientprofile_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_clientprofile_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_clientprofile_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Tasks));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_clientprofile_ait_clie")]
    public IEnumerable<ait_servicerequest> ait_servicerequest_clientprofile_ait_clie
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (ait_servicerequest_clientprofile_ait_clie), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_clientprofile_ait_clie));
        this.SetRelatedEntities<ait_servicerequest>(nameof (ait_servicerequest_clientprofile_ait_clie), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_clientprofile_ait_clie));
      }
    }

    [RelationshipSchemaName("ait_ait_incidents_ait_clientprofile")]
    public IEnumerable<ait_incidents> ait_ait_incidents_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_incidents>(nameof (ait_ait_incidents_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incidents_ait_clientprofile));
        this.SetRelatedEntities<ait_incidents>(nameof (ait_ait_incidents_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incidents_ait_clientprofile));
      }
    }

    [AttributeLogicalName("ait_groupactivitiesclientprofileid")]
    [RelationshipSchemaName("ait_ait_groupactivity_ait_clientprofile")]
    public ait_groupactivity ait_ait_groupactivity_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_ait_groupactivity_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivity_ait_clientprofile));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_ait_groupactivity_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivity_ait_clientprofile));
      }
    }

    [AttributeLogicalName("ait_contact")]
    [RelationshipSchemaName("ait_contact_ait_clientprofile_Contact")]
    public Contact ait_contact_ait_clientprofile_Contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_Contact));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_Contact));
      }
    }

    [AttributeLogicalName("ait_guardian1")]
    [RelationshipSchemaName("ait_contact_ait_clientprofile_Guardian1")]
    public Contact ait_contact_ait_clientprofile_Guardian1
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_Guardian1), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_Guardian1));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_Guardian1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_Guardian1));
      }
    }

    [AttributeLogicalName("ait_guardian2")]
    [RelationshipSchemaName("ait_contact_ait_clientprofile_Guardian2")]
    public Contact ait_contact_ait_clientprofile_Guardian2
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_Guardian2), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_Guardian2));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_Guardian2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_Guardian2));
      }
    }

    [AttributeLogicalName("ait_nextofkin")]
    [RelationshipSchemaName("ait_contact_ait_clientprofile_NextofKin")]
    public Contact ait_contact_ait_clientprofile_NextofKin
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_NextofKin), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_NextofKin));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_NextofKin), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_NextofKin));
      }
    }

    [AttributeLogicalName("ait_primaryprovider")]
    [RelationshipSchemaName("ait_contact_ait_clientprofile_PrimaryProvider")]
    public Contact ait_contact_ait_clientprofile_PrimaryProvider
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_PrimaryProvider), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contact_ait_clientprofile_PrimaryProvider));
        this.SetRelatedEntity<Contact>(nameof (ait_contact_ait_clientprofile_PrimaryProvider), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contact_ait_clientprofile_PrimaryProvider));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeetingid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_ait_clientprofil")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_ait_clientprofil
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ait_clientprofil), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_ait_clientprofil));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_ait_clientprofil), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_ait_clientprofil));
      }
    }

    [AttributeLogicalName("ait_meetingattendeeid")]
    [RelationshipSchemaName("ait_meetingattendee_ait_clientprofile")]
    public ait_meetingattendee ait_meetingattendee_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_ait_clientprofile));
        this.SetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_ait_clientprofile));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_clientprofile")]
    public BusinessUnit business_unit_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_clientprofile), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_clientprofile_createdby")]
    public SystemUser lk_ait_clientprofile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_clientprofile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_clientprofile_createdonbehalfby")]
    public SystemUser lk_ait_clientprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_clientprofile_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_clientprofile_modifiedby")]
    public SystemUser lk_ait_clientprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_clientprofile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_clientprofile_modifiedonbehalfby")]
    public SystemUser lk_ait_clientprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_clientprofile_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_clientprofile")]
    public Team team_ait_clientprofile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_clientprofile), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_clientprofile")]
    public SystemUser user_ait_clientprofile
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_clientprofile), new EntityRole?());
    }
  }
}
