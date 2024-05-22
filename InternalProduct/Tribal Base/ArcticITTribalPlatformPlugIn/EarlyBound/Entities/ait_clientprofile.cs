// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_clientprofile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_clientprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_clientprofile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_clientprofile";
    public const string EntitySchemaName = "ait_clientprofile";
    public const string PrimaryIdAttribute = "ait_clientprofileid";
    public const string PrimaryNameAttribute = "ait_name";

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

    [AttributeLogicalName("ait_childsupportincome")]
    public Money ait_ChildSupportIncome
    {
      get => this.GetAttributeValue<Money>("ait_childsupportincome");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChildSupportIncome));
        this.SetAttributeValue("ait_childsupportincome", (object) value);
        this.OnPropertyChanged(nameof (ait_ChildSupportIncome));
      }
    }

    [AttributeLogicalName("ait_childsupportincome_base")]
    public Money ait_childsupportincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_childsupportincome_base");
    }

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
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_clientprofileId));
      }
    }

    [AttributeLogicalName("ait_clientprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_clientprofileId = new Guid?(value);
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

    [AttributeLogicalName("ait_socialsecurityincome")]
    public Money ait_SocialSecurityIncome
    {
      get => this.GetAttributeValue<Money>("ait_socialsecurityincome");
      set
      {
        this.OnPropertyChanging(nameof (ait_SocialSecurityIncome));
        this.SetAttributeValue("ait_socialsecurityincome", (object) value);
        this.OnPropertyChanged(nameof (ait_SocialSecurityIncome));
      }
    }

    [AttributeLogicalName("ait_socialsecurityincome_base")]
    public Money ait_socialsecurityincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_socialsecurityincome_base");
    }

    [AttributeLogicalName("ait_supplementalincome")]
    public Money ait_SupplementalIncome
    {
      get => this.GetAttributeValue<Money>("ait_supplementalincome");
      set
      {
        this.OnPropertyChanging(nameof (ait_SupplementalIncome));
        this.SetAttributeValue("ait_supplementalincome", (object) value);
        this.OnPropertyChanged(nameof (ait_SupplementalIncome));
      }
    }

    [AttributeLogicalName("ait_supplementalincome_base")]
    public Money ait_supplementalincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_supplementalincome_base");
    }

    [AttributeLogicalName("ait_totalavailablemonthlyincome")]
    public Money ait_TotalAvailableMonthlyIncome
    {
      get => this.GetAttributeValue<Money>("ait_totalavailablemonthlyincome");
    }

    [AttributeLogicalName("ait_totalavailablemonthlyincome_base")]
    public Money ait_totalavailablemonthlyincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalavailablemonthlyincome_base");
    }

    [AttributeLogicalName("ait_totalearnedincome")]
    public Money ait_TotalEarnedIncome
    {
      get => this.GetAttributeValue<Money>("ait_totalearnedincome");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalEarnedIncome));
        this.SetAttributeValue("ait_totalearnedincome", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalEarnedIncome));
      }
    }

    [AttributeLogicalName("ait_totalearnedincome_base")]
    public Money ait_totalearnedincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalearnedincome_base");
    }

    [AttributeLogicalName("ait_totalexpenses")]
    public Money ait_TotalExpenses
    {
      get => this.GetAttributeValue<Money>("ait_totalexpenses");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalExpenses));
        this.SetAttributeValue("ait_totalexpenses", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalExpenses));
      }
    }

    [AttributeLogicalName("ait_totalexpenses_base")]
    public Money ait_totalexpenses_Base => this.GetAttributeValue<Money>("ait_totalexpenses_base");

    [AttributeLogicalName("ait_totalincome")]
    public Money ait_TotalIncome
    {
      get => this.GetAttributeValue<Money>("ait_totalincome");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalIncome));
        this.SetAttributeValue("ait_totalincome", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalIncome));
      }
    }

    [AttributeLogicalName("ait_totalincome_base")]
    public Money ait_totalincome_Base => this.GetAttributeValue<Money>("ait_totalincome_base");

    [AttributeLogicalName("ait_totalunearnedincome")]
    public Money ait_TotalUnearnedIncome
    {
      get => this.GetAttributeValue<Money>("ait_totalunearnedincome");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalUnearnedIncome));
        this.SetAttributeValue("ait_totalunearnedincome", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalUnearnedIncome));
      }
    }

    [AttributeLogicalName("ait_totalunearnedincome_base")]
    public Money ait_totalunearnedincome_Base
    {
      get => this.GetAttributeValue<Money>("ait_totalunearnedincome_base");
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
    public ait_clientprofileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_clientprofileState?((ait_clientprofileState) Enum.ToObject(typeof (ait_clientprofileState), attributeValue.Value)) : new ait_clientprofileState?();
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

    [RelationshipSchemaName("ait_ait_clientprofile_ait_casenote_Individual")]
    public IEnumerable<ait_casenote> ait_ait_clientprofile_ait_casenote_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_casenote>(nameof (ait_ait_clientprofile_ait_casenote_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_casenote_Individual));
        this.SetRelatedEntities<ait_casenote>(nameof (ait_ait_clientprofile_ait_casenote_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_casenote_Individual));
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

    [RelationshipSchemaName("ait_ait_clientprofile_ait_outcome_Individual")]
    public IEnumerable<ait_outcome> ait_ait_clientprofile_ait_outcome_Individual
    {
      get
      {
        return this.GetRelatedEntities<ait_outcome>(nameof (ait_ait_clientprofile_ait_outcome_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_outcome_Individual));
        this.SetRelatedEntities<ait_outcome>(nameof (ait_ait_clientprofile_ait_outcome_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_outcome_Individual));
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

    [RelationshipSchemaName("ait_ait_clientprofile_ait_safetyplan")]
    public IEnumerable<ait_safetyplan> ait_ait_clientprofile_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntities<ait_safetyplan>(nameof (ait_ait_clientprofile_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_ait_safetyplan));
        this.SetRelatedEntities<ait_safetyplan>(nameof (ait_ait_clientprofile_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_ait_safetyplan));
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

    [RelationshipSchemaName("ait_clientprofile_ActivityParties")]
    public IEnumerable<ActivityParty> ait_clientprofile_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_clientprofile_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_clientprofile_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_clientprofile_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_clientprofile_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_clientprofile_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_childvisitations_ClientProfile")]
    public IEnumerable<ait_childvisitations> ait_clientprofile_ait_childvisitations_ClientProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_childvisitations>(nameof (ait_clientprofile_ait_childvisitations_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_childvisitations_ClientProfile));
        this.SetRelatedEntities<ait_childvisitations>(nameof (ait_clientprofile_ait_childvisitations_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_childvisitations_ClientProfile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_icwaadoption_ChildClientProfile")]
    public IEnumerable<ait_icwaadoption> ait_clientprofile_ait_icwaadoption_ChildClientProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaadoption>(nameof (ait_clientprofile_ait_icwaadoption_ChildClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_icwaadoption_ChildClientProfile));
        this.SetRelatedEntities<ait_icwaadoption>(nameof (ait_clientprofile_ait_icwaadoption_ChildClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_icwaadoption_ChildClientProfile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_icwanotice_ChildClientProfile")]
    public IEnumerable<ait_icwanotice> ait_clientprofile_ait_icwanotice_ChildClientProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_icwanotice>(nameof (ait_clientprofile_ait_icwanotice_ChildClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_icwanotice_ChildClientProfile));
        this.SetRelatedEntities<ait_icwanotice>(nameof (ait_clientprofile_ait_icwanotice_ChildClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_icwanotice_ChildClientProfile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_incident_clientprofile")]
    public IEnumerable<ait_incident> ait_clientprofile_ait_incident_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_incident>(nameof (ait_clientprofile_ait_incident_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incident_clientprofile));
        this.SetRelatedEntities<ait_incident>(nameof (ait_clientprofile_ait_incident_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incident_clientprofile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_incident_nameofvictim")]
    public IEnumerable<ait_incident> ait_clientprofile_ait_incident_nameofvictim
    {
      get
      {
        return this.GetRelatedEntities<ait_incident>(nameof (ait_clientprofile_ait_incident_nameofvictim), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incident_nameofvictim));
        this.SetRelatedEntities<ait_incident>(nameof (ait_clientprofile_ait_incident_nameofvictim), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incident_nameofvictim));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_incident_offendernameclientprofile")]
    public IEnumerable<ait_incident> ait_clientprofile_ait_incident_offendernameclientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_incident>(nameof (ait_clientprofile_ait_incident_offendernameclientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_incident_offendernameclientprofile));
        this.SetRelatedEntities<ait_incident>(nameof (ait_clientprofile_ait_incident_offendernameclientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_incident_offendernameclientprofile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ait_medicalproviders_ClientProfile")]
    public IEnumerable<ait_medicalproviders> ait_clientprofile_ait_medicalproviders_ClientProfile
    {
      get
      {
        return this.GetRelatedEntities<ait_medicalproviders>(nameof (ait_clientprofile_ait_medicalproviders_ClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_medicalproviders_ClientProfile));
        this.SetRelatedEntities<ait_medicalproviders>(nameof (ait_clientprofile_ait_medicalproviders_ClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_medicalproviders_ClientProfile));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_Annotations")]
    public IEnumerable<Annotation> ait_clientprofile_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_clientprofile_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_clientprofile_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Annotations));
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

    [RelationshipSchemaName("ait_clientprofile_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_clientprofile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_clientprofile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_clientprofile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_clientprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_clientprofile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_clientprofile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_clientprofile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_clientprofile_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_clientprofile_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_clientprofile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_clientprofile_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_clientprofile_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_DuplicateMatchingRecord));
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

    [RelationshipSchemaName("ait_clientprofile_Faxes")]
    public IEnumerable<Fax> ait_clientprofile_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_clientprofile_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_clientprofile_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Faxes));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_Letters")]
    public IEnumerable<Letter> ait_clientprofile_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_clientprofile_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_clientprofile_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Letters));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_clientprofile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_clientprofile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_clientprofile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_MailboxTrackingFolders));
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

    [RelationshipSchemaName("ait_clientprofile_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_clientprofile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_clientprofile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_clientprofile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_ProcessSession")]
    public IEnumerable<ProcessSession> ait_clientprofile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_clientprofile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_clientprofile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_clientprofile_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_clientprofile_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_clientprofile_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_clientprofile_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_clientprofile_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_clientprofile_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_clientprofile_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_clientprofile_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_clientprofile_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_SocialActivities")]
    public IEnumerable<SocialActivity> ait_clientprofile_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_clientprofile_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_clientprofile_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_clientprofile_SyncErrors")]
    public IEnumerable<SyncError> ait_clientprofile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_clientprofile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_clientprofile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_SyncErrors));
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

    [RelationshipSchemaName("ait_clientprofile_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_clientprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_clientprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_clientprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_UserEntityInstanceDatas));
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

    [RelationshipSchemaName("ait_incident_ait_clientprofile")]
    public IEnumerable<ait_incident> ait_incident_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_incident>(nameof (ait_incident_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_ait_clientprofile));
        this.SetRelatedEntities<ait_incident>(nameof (ait_incident_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_ait_clientprofile));
      }
    }

    [AttributeLogicalName("ait_dentalinsuranceprovider")]
    [RelationshipSchemaName("ait_company_ait_clientprofile_DentalInsuranceProvider")]
    public ait_company ait_company_ait_clientprofile_DentalInsuranceProvider
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_clientprofile_DentalInsuranceProvider), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_clientprofile_DentalInsuranceProvider));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_clientprofile_DentalInsuranceProvider), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_clientprofile_DentalInsuranceProvider));
      }
    }

    [AttributeLogicalName("ait_insuranceprovider_company")]
    [RelationshipSchemaName("ait_company_ait_clientprofile_InsuranceProvider_company")]
    public ait_company ait_company_ait_clientprofile_InsuranceProvider_company
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_clientprofile_InsuranceProvider_company), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_clientprofile_InsuranceProvider_company));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_clientprofile_InsuranceProvider_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_clientprofile_InsuranceProvider_company));
      }
    }

    [AttributeLogicalName("ait_pharmacy")]
    [RelationshipSchemaName("ait_company_ait_clientprofile_Pharmacy")]
    public ait_company ait_company_ait_clientprofile_Pharmacy
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_clientprofile_Pharmacy), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_clientprofile_Pharmacy));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_clientprofile_Pharmacy), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_clientprofile_Pharmacy));
      }
    }

    [AttributeLogicalName("ait_primarymedicalfacility")]
    [RelationshipSchemaName("ait_company_ait_clientprofile_PrimaryMedicalFacility")]
    public ait_company ait_company_ait_clientprofile_PrimaryMedicalFacility
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_ait_clientprofile_PrimaryMedicalFacility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_ait_clientprofile_PrimaryMedicalFacility));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_ait_clientprofile_PrimaryMedicalFacility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_ait_clientprofile_PrimaryMedicalFacility));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clientprofile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_clientprofile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clientprofile_createdonbehalfby));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_clientprofile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_clientprofile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_clientprofile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_clientprofile")]
    public Team team_ait_clientprofile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_clientprofile), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_clientprofile")]
    public TransactionCurrency TransactionCurrency_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_clientprofile));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_clientprofile));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_clientprofile")]
    public SystemUser user_ait_clientprofile
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_clientprofile), new EntityRole?());
    }

    public ait_clientprofile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_clientprofileid"] = (object) base.Id;
            break;
          case "ait_clientprofileid":
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
