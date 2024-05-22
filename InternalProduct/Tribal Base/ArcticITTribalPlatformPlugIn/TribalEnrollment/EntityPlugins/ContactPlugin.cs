// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.ContactPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.EarlyBound.OptionSets;
using ArcticIT.TribalEnrollment.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "contact", CrmEntityType = "ArcticIT.EarlyBound.Entities.Contact")]
  public class ContactPlugin : EntityBase
  {
    private IPluginExecutionContext PluginContext { get; set; }

    public ContactPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.PluginContext = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
      this.OnPluginPostDeleting += new EntityBase.PluginOnPostDeleteHandler(this.Execute_OnPluginPostDeleting);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.SynchronizeFields();
      this.SetDefaults();
      if (TribalEnrollmentConfiguration.GetContactNameOption(this.CrmService) == ait_contactnaming.Default)
        return;
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.SynchronizeFields();
      this.UpdateName();
      this.UpdateEntityImageString();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateRelatedRecords();
      this.UpdateRelatedNames();
      this.SynchronizeToRelatedAttributes();
      this.CreatePaymentEligibilities();
      this.CreatePaymentWithholdings();
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      if (((IExecutionContext) this.PluginContext).Depth > 3)
        return;
      this.UpdateRelatedRecords();
    }

    public static Contact UpdateElectronicAddressInfo(
      IOrganizationService crmService,
      Contact contact,
      ait_electronicaddress electronicAddress,
      bool performSave)
    {
      if (contact == null)
        throw new ArgumentNullException("Contact cannot be empty.", nameof (contact));
      if (electronicAddress == null)
        throw new ArgumentNullException("Electronic Address cannot be empty.", "physicalAddress");
      Contact contact1 = new Contact();
      ((Entity) contact1).Id = ((Entity) contact).Id;
      bool flag = false;
      switch (electronicAddress.ait_communicationtype.Value)
      {
        case 750000000:
          ait_electronicaddressState? statecode1 = electronicAddress.statecode;
          ait_electronicaddressState electronicaddressState1 = ait_electronicaddressState.Active;
          if (statecode1.GetValueOrDefault() == electronicaddressState1 & statecode1.HasValue && AttributeLibrary.Compare(electronicAddress.ait_current, true))
          {
            if (contact.ait_primaryphone != electronicAddress.ait_phonenumberoremail)
            {
              contact.ait_primaryphone = electronicAddress.ait_phonenumberoremail;
              contact1.ait_primaryphone = electronicAddress.ait_phonenumberoremail;
              flag = true;
              break;
            }
            break;
          }
          statecode1 = electronicAddress.statecode;
          ait_electronicaddressState electronicaddressState2 = ait_electronicaddressState.Active;
          if ((!(statecode1.GetValueOrDefault() == electronicaddressState2 & statecode1.HasValue) || AttributeLibrary.Compare(electronicAddress.ait_current, false)) && contact.ait_primaryphone == electronicAddress.ait_phonenumberoremail && !string.IsNullOrEmpty(contact.ait_primaryphone))
          {
            contact.ait_primaryphone = (string) null;
            contact1.ait_primaryphone = (string) null;
            flag = true;
            break;
          }
          break;
        case 750000001:
          ait_electronicaddressState? statecode2 = electronicAddress.statecode;
          ait_electronicaddressState electronicaddressState3 = ait_electronicaddressState.Active;
          if (statecode2.GetValueOrDefault() == electronicaddressState3 & statecode2.HasValue && AttributeLibrary.Compare(electronicAddress.ait_current, true))
          {
            if (contact.ait_primaryemail != electronicAddress.ait_phonenumberoremail)
            {
              contact.ait_primaryemail = electronicAddress.ait_phonenumberoremail;
              contact1.ait_primaryemail = electronicAddress.ait_phonenumberoremail;
              contact1.EMailAddress1 = electronicAddress.ait_phonenumberoremail;
              flag = true;
              break;
            }
            break;
          }
          statecode2 = electronicAddress.statecode;
          ait_electronicaddressState electronicaddressState4 = ait_electronicaddressState.Active;
          if ((!(statecode2.GetValueOrDefault() == electronicaddressState4 & statecode2.HasValue) || AttributeLibrary.Compare(electronicAddress.ait_current, false)) && contact.ait_primaryemail == electronicAddress.ait_phonenumberoremail && !string.IsNullOrEmpty(contact.ait_primaryemail))
          {
            contact.ait_primaryemail = (string) null;
            contact1.ait_primaryemail = (string) null;
            contact1.EMailAddress1 = (string) null;
            flag = true;
            break;
          }
          break;
      }
      if (flag & performSave)
        crmService.Update((Entity) contact1);
      return flag ? contact : (Contact) null;
    }

    public static bool UpdatePhysicalAddressInfo(
      IOrganizationService crmService,
      Contact contact,
      ait_physicaladdress physicalAddress)
    {
      bool flag = false;
      if (contact == null)
        throw new ArgumentNullException("Contact cannot be empty.", nameof (contact));
      string compareTo1 = string.Empty;
      string compareTo2 = string.Empty;
      string compareTo3 = string.Empty;
      string compareTo4 = string.Empty;
      string compareTo5 = string.Empty;
      string compareTo6 = string.Empty;
      string compareTo7 = string.Empty;
      string compareTo8 = string.Empty;
      string compareTo9 = string.Empty;
      ContactAddress1_AddressTypeCode compareTo10 = ContactAddress1_AddressTypeCode.Other;
      if (physicalAddress != null)
      {
        compareTo1 = physicalAddress.ait_street1;
        compareTo2 = physicalAddress.ait_street2;
        compareTo3 = physicalAddress.ait_street3;
        compareTo4 = (string) ObjectLibrary.GetPropertyValue((object) physicalAddress.ait_city, "Name", false);
        compareTo5 = (string) ObjectLibrary.GetPropertyValue((object) physicalAddress.ait_stateprovince, "Name", false);
        compareTo6 = (string) ObjectLibrary.GetPropertyValue((object) physicalAddress.ait_zipcode, "Name", false);
        compareTo7 = (string) ObjectLibrary.GetPropertyValue((object) physicalAddress.ait_countryregion, "Name", false);
        compareTo8 = (string) ObjectLibrary.GetPropertyValue((object) physicalAddress.ait_county, "Name", false);
        compareTo9 = physicalAddress.ait_address;
        compareTo10 = ContactAddress1_AddressTypeCode.Primary;
      }
      Contact contact1 = new Contact();
      ((Entity) contact1).Id = ((Entity) contact).Id;
      if (!AttributeLibrary.Compare((object) contact1.Address1_Line1, (object) compareTo1))
      {
        contact1.Address1_Line1 = compareTo1;
        flag = true;
      }
      if (!AttributeLibrary.Compare((object) contact1.Address1_Line2, (object) compareTo2))
      {
        contact1.Address1_Line2 = compareTo2;
        flag = true;
      }
      if (!AttributeLibrary.Compare((object) contact1.Address1_Line3, (object) compareTo3))
      {
        contact1.Address1_Line3 = compareTo3;
        flag = true;
      }
      if (!AttributeLibrary.Compare((object) contact1.Address1_City, (object) compareTo4))
      {
        contact1.Address1_City = compareTo4;
        flag = true;
      }
      if (!AttributeLibrary.Compare((object) contact1.Address1_StateOrProvince, (object) compareTo5))
      {
        contact1.Address1_StateOrProvince = compareTo5;
        flag = true;
      }
      if (!AttributeLibrary.Compare((object) contact1.Address1_PostalCode, (object) compareTo6))
      {
        contact1.Address1_PostalCode = compareTo6;
        flag = true;
      }
      if (!AttributeLibrary.Compare((object) contact1.Address1_Country, (object) compareTo7))
      {
        contact1.Address1_Country = compareTo7;
        flag = true;
      }
      if (!AttributeLibrary.Compare((object) contact1.Address1_County, (object) compareTo8))
      {
        contact1.Address1_County = compareTo8;
        flag = true;
      }
      if (!AttributeLibrary.Compare(contact1.Address1_AddressTypeCode, (int) compareTo10))
      {
        contact1.Address1_AddressTypeCode = new OptionSetValue((int) compareTo10);
        flag = true;
      }
      if (!AttributeLibrary.Compare((object) contact1.ait_primaryaddress, (object) compareTo9))
      {
        contact1.ait_primaryaddress = compareTo9;
        flag = true;
      }
      if (flag)
        crmService.Update((Entity) contact1);
      return flag;
    }

    public static Contact UpdateIncomeExpenseInfo(
      IOrganizationService crmService,
      Contact contact,
      bool performSave)
    {
      // ISSUE: unable to decompile the method.
    }

    public static Contact UpdateEmployment(
      IOrganizationService crmService,
      Contact contact,
      ait_contactemployment changingEmploymentRecord,
      bool performSave)
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      if (contact == null)
        throw new ArgumentNullException("Contact cannot be empty.", nameof (contact));
      foreach (ait_contactemployment entity1 in (Collection<Entity>) EntityLibrary.GetAllEntities(crmService, "ait_contactemployment", "ait_contact", (object) ((Entity) contact).Id, true).Entities)
      {
        if (AttributeLibrary.Compare(entity1.ait_currentlyemployed, 750000001))
        {
          flag2 = true;
          ait_company entity2 = (ait_company) EntityLibrary.GetEntity(crmService, entity1.ait_employer, false);
          if (entity2 != null && entity2.ait_tribeowned != null)
            flag3 = true;
        }
        if (flag2 & flag3)
          break;
      }
      Contact contact1 = new Contact();
      ((Entity) contact1).Id = ((Entity) contact).Id;
      if (changingEmploymentRecord != null && contact.ait_employeeidcard == null && AttributeLibrary.Compare(changingEmploymentRecord.ait_currentlyemployed, 750000001))
      {
        ait_company entity = (ait_company) EntityLibrary.GetEntity(crmService, changingEmploymentRecord.ait_employer, false);
        if (entity != null && entity.ait_tribeowned != null)
        {
          flag1 = true;
          contact.ait_employeeidcard = changingEmploymentRecord.ToEntityReference();
          contact1.ait_employeeidcard = changingEmploymentRecord.ToEntityReference();
        }
      }
      OptionSetValue compareTo1 = EnrollmentOptionSetLibrary.YesNoOptionSet(flag2);
      if (!AttributeLibrary.Compare(contact.ait_currentlyemployed, compareTo1))
      {
        flag1 = true;
        contact.ait_currentlyemployed = compareTo1;
        contact1.ait_currentlyemployed = compareTo1;
      }
      OptionSetValue compareTo2 = EnrollmentOptionSetLibrary.YesNoOptionSet(flag3);
      if (!AttributeLibrary.Compare(contact.ait_tribeemployed, compareTo2))
      {
        flag1 = true;
        contact.ait_tribeemployed = compareTo2;
        contact1.ait_tribeemployed = compareTo2;
      }
      if (flag1 & performSave)
        crmService.Update((Entity) contact1);
      return flag1 ? contact : (Contact) null;
    }

    public static Contact UpdateIncarcerated(IOrganizationService crmService, Contact contact)
    {
      bool flag = false;
      bool compareTo = false;
      if (contact == null)
        throw new ArgumentNullException("Contact cannot be empty.", nameof (contact));
      foreach (ait_contactincarceration entity in (Collection<Entity>) EntityLibrary.GetAllEntities(crmService, "ait_contactincarceration", "ait_contact", (object) ((Entity) contact).Id, true).Entities)
      {
        if (AttributeLibrary.Compare(entity.ait_currentlyincarcerated, true))
        {
          compareTo = true;
          break;
        }
      }
      Contact contact1 = new Contact();
      ((Entity) contact1).Id = ((Entity) contact).Id;
      bool? aitIncarcerated = contact.ait_incarcerated;
      int num;
      if (aitIncarcerated.HasValue)
      {
        aitIncarcerated = contact.ait_incarcerated;
        num = !aitIncarcerated.HasValue ? 1 : 0;
      }
      else
        num = 0;
      if (num != 0)
      {
        flag = true;
        contact.ait_incarcerated = new bool?(false);
        contact1.ait_incarcerated = new bool?(false);
      }
      if (!AttributeLibrary.Compare(contact.ait_incarcerated, compareTo))
      {
        contact.ait_incarcerated = new bool?(compareTo);
        contact1.ait_incarcerated = new bool?(compareTo);
        flag = true;
      }
      if (flag)
        crmService.Update((Entity) contact1);
      return flag ? contact : (Contact) null;
    }

    public static Contact UpdateMilitaryService(
      IOrganizationService crmService,
      Contact contact,
      bool performSave)
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      ait_militarystatus compareTo = ait_militarystatus.None;
      if (contact == null)
        throw new ArgumentNullException("Contact cannot be empty.", nameof (contact));
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "ait_contactmilitaryservice", "ait_contact", (object) ((Entity) contact).Id, true);
      if (((Collection<Entity>) allEntities.Entities).Count > 0)
      {
        flag2 = true;
        compareTo = ait_militarystatus.Veteran;
      }
      foreach (ait_contactmilitaryservice entity in (Collection<Entity>) allEntities.Entities)
      {
        if (entity.ait_armedservicestatus != null)
        {
          switch (entity.ait_armedservicestatus.Value)
          {
            case 750000000:
              compareTo = ait_militarystatus.CurrentlyServing;
              flag3 = true;
              break;
            case 750000008:
              compareTo = ait_militarystatus.CurrentlyServingandDeployed;
              flag3 = true;
              break;
          }
        }
      }
      Contact contact1 = new Contact();
      ((Entity) contact1).Id = ((Entity) contact).Id;
      if (!flag2 && contact.ait_militarystatus != null)
      {
        flag1 = true;
        contact.ait_militarystatus = (OptionSetValue) null;
        contact1.ait_militarystatus = (OptionSetValue) null;
      }
      if (flag2 && !AttributeLibrary.Compare(contact.ait_militarystatus, (int) compareTo))
      {
        flag1 = true;
        contact.ait_militarystatus = new OptionSetValue((int) compareTo);
        contact1.ait_militarystatus = new OptionSetValue((int) compareTo);
      }
      if (flag1 & performSave)
        crmService.Update((Entity) contact1);
      return flag1 ? contact : (Contact) null;
    }

    public static Contact UpdateAgeInfo(
      FrameworkService crmService,
      Contact contact,
      bool performSave)
    {
      string birthDate = (string) null;
      string deathDate = (string) null;
      if (contact == null)
        return (Contact) null;
      DateTime? nullable;
      if (contact.ait_birthrecord != null)
      {
        nullable = contact.BirthDate;
        birthDate = nullable.ToString();
      }
      if (contact.ait_deathrecord != null && !string.IsNullOrEmpty(birthDate))
      {
        nullable = contact.ait_deathdate;
        ref DateTime? local = ref nullable;
        deathDate = (local.HasValue ? local.GetValueOrDefault().ToString() : (string) null) ?? "1/1/0001";
      }
      return ContactPlugin.UpdateAgeInfo(crmService, contact, birthDate, deathDate, performSave);
    }

    public static Contact UpdateAgeInfo(
      FrameworkService crmService,
      Contact contact,
      string birthDate,
      string deathDate,
      bool performSave)
    {
      if (contact == null)
        throw new ArgumentNullException("Contact cannot be empty.", nameof (contact));
      bool flag = false;
      int? aitAge = contact.ait_age;
      Contact contact1 = new Contact();
      ((Entity) contact1).Id = ((Entity) contact).Id;
      int? nullable1;
      if (string.IsNullOrWhiteSpace(birthDate))
      {
        nullable1 = contact.ait_age;
        if (nullable1.HasValue)
        {
          flag = true;
          Contact contact2 = contact1;
          nullable1 = new int?();
          int? nullable2 = nullable1;
          contact2.ait_age = nullable2;
          Contact contact3 = contact;
          nullable1 = new int?();
          int? nullable3 = nullable1;
          contact3.ait_age = nullable3;
        }
        if (contact.ait_agegroup != null)
        {
          flag = true;
          contact1.ait_agegroup = (OptionSetValue) null;
          contact.ait_agegroup = (OptionSetValue) null;
        }
      }
      else
      {
        DateTime dateTime1 = Convert.ToDateTime(birthDate);
        DateTime dateTime2 = DateTime.Today;
        if (!string.IsNullOrWhiteSpace(deathDate))
          dateTime2 = Convert.ToDateTime(deathDate);
        int num1 = dateTime2.Year - dateTime1.Year;
        if (dateTime2.Month < dateTime1.Month || dateTime2.Month == dateTime1.Month && dateTime2.Day < dateTime1.Day)
          --num1;
        if (num1 < 0)
        {
          nullable1 = contact.ait_age;
          if (nullable1.HasValue)
          {
            flag = true;
            Contact contact4 = contact1;
            nullable1 = new int?();
            int? nullable4 = nullable1;
            contact4.ait_age = nullable4;
            Contact contact5 = contact;
            nullable1 = new int?();
            int? nullable5 = nullable1;
            contact5.ait_age = nullable5;
          }
          if (contact.ait_agegroup != null)
          {
            flag = true;
            contact1.ait_agegroup = (OptionSetValue) null;
            contact.ait_agegroup = (OptionSetValue) null;
          }
        }
        else
        {
          nullable1 = contact.ait_age;
          int num2;
          if (!nullable1.HasValue)
          {
            num2 = -1;
          }
          else
          {
            nullable1 = contact.ait_age;
            num2 = nullable1.Value;
          }
          if (num2 != num1)
          {
            flag = true;
            contact1.ait_age = new int?(num1);
            contact.ait_age = new int?(num1);
          }
        }
      }
      nullable1 = contact.ait_age;
      int? nullable6;
      int num;
      if (nullable1.HasValue)
      {
        nullable1 = contact.ait_age;
        nullable6 = aitAge;
        num = !(nullable1.GetValueOrDefault() == nullable6.GetValueOrDefault() & nullable1.HasValue == nullable6.HasValue) ? 1 : 0;
      }
      else
        num = 0;
      if (num != 0)
      {
        nullable6 = contact.ait_age;
        int adultAge = TribalEnrollmentConfiguration.GetAdultAge(crmService);
        OptionSetValue compareTo;
        if (nullable6.GetValueOrDefault() < adultAge & nullable6.HasValue)
        {
          compareTo = new OptionSetValue(750000000);
        }
        else
        {
          nullable6 = contact.ait_age;
          int seniorAge = TribalEnrollmentConfiguration.GetSeniorAge(crmService);
          compareTo = !(nullable6.GetValueOrDefault() < seniorAge & nullable6.HasValue) ? new OptionSetValue(750000002) : new OptionSetValue(750000001);
        }
        if (!AttributeLibrary.Compare(contact.ait_agegroup, compareTo))
        {
          flag = true;
          contact1.ait_agegroup = compareTo;
          contact.ait_agegroup = compareTo;
        }
      }
      if (flag & performSave)
      {
        crmService.Trace("crmService.Update in ContactPlugin.UpdateAgeInfo");
        crmService.Update((Entity) contact1);
      }
      return flag ? contact1 : (Contact) null;
    }

    public static bool IsEligibleForPaymentType(
      IOrganizationService crmService,
      Contact contact,
      ait_pmtpaymenttype paymentType)
    {
      return ContactPlugin.CheckPerCapEligibility(crmService, contact.ToEntityReference(), paymentType.ait_eligibilitycriteria, paymentType.ait_gender, paymentType.ait_ageminimum, paymentType.ait_agemaximum);
    }

    public static bool IsEligibleForWithholdingType(
      IOrganizationService crmService,
      Contact contact,
      ait_withholdingtype withholdingType)
    {
      return ContactPlugin.CheckPerCapEligibility(crmService, contact.ToEntityReference(), withholdingType.ait_eligibilitycriteria, withholdingType.ait_gender, withholdingType.ait_ageminimum, withholdingType.ait_agemaximum);
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<Contact>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<Contact>();
    }

    protected override List<UpdateRelatedAttributeInformation> GetSynchronizeToAttributeRelationships()
    {
      return new List<UpdateRelatedAttributeInformation>()
      {
        new UpdateRelatedAttributeInformation("ait_relationship", "ait_relationshipto", "birthdate", "ait_birthdate", true)
      };
    }

    protected override List<UpdateNameInformation> GetNameRelationships()
    {
      return new List<UpdateNameInformation>()
      {
        new UpdateNameInformation("ait_memberprofile", "ait_contact", true),
        new UpdateNameInformation("ait_contactcertification", "ait_contact", true),
        new UpdateNameInformation("ait_contacteducation", "ait_contact", true),
        new UpdateNameInformation("ait_contactemployment", "ait_contact", true),
        new UpdateNameInformation("ait_contactincarceration", "ait_contact", true),
        new UpdateNameInformation("ait_contactincomeandexpense", "ait_contact", true),
        new UpdateNameInformation("ait_contactlanguage", "ait_contact", true),
        new UpdateNameInformation("ait_contactmilitaryservice", "ait_contact", true),
        new UpdateNameInformation("ait_contactskill", "ait_contact", true),
        new UpdateNameInformation("ait_relationship", "ait_contact", true),
        new UpdateNameInformation("ait_emergencycontact", "ait_contact", true),
        new UpdateNameInformation("ait_householdmember", "ait_contact", true)
      };
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty1 = string.Empty;
      Contact contact1 = (Contact) entityInput;
      Contact contact2 = (Contact) preImage;
      string empty2 = string.Empty;
      string empty3 = string.Empty;
      string empty4 = string.Empty;
      string empty5 = string.Empty;
      string entityValue1 = FormatLibrary.GetEntityValue(contact1.FirstName, contact2.FirstName);
      string str1 = FormatLibrary.GetEntityValue(contact1.MiddleName, contact2.MiddleName);
      string entityValue2 = FormatLibrary.GetEntityValue(contact1.LastName, contact2.LastName);
      string entityValue3 = FormatLibrary.GetEntityValue(contact1.Suffix, contact2.Suffix);
      if (!string.IsNullOrEmpty(str1) && TribalEnrollmentConfiguration.GetContactNameOption(this.CrmService) == ait_contactnaming.FirstMiddleInitialLastSuffix)
      {
        if (str1.Trim().Substring(0, 1) == "\"")
        {
          string str2 = str1;
          int num = str1.LastIndexOf("\"");
          if (str1.Length >= num + 1)
            str1 = str1.Substring(num + 1);
          if (string.IsNullOrEmpty(str1.Trim()))
            str1 = str2;
        }
        str1 = str1.Trim().Substring(0, 1);
        if (str1 == "\"")
          str1 = string.Empty;
      }
      string empty6 = string.Empty;
      string str3 = empty1 + (string.IsNullOrEmpty(entityValue1) ? string.Empty : entityValue1);
      string str4 = string.IsNullOrEmpty(str3) ? "" : " ";
      string str5 = str3 + (string.IsNullOrEmpty(str1) ? string.Empty : str4 + str1);
      string str6 = string.IsNullOrEmpty(str5) ? "" : " ";
      string str7 = str5 + (string.IsNullOrEmpty(entityValue2) ? string.Empty : str6 + entityValue2);
      string str8 = string.IsNullOrEmpty(str7) ? "" : " ";
      return str7 + (string.IsNullOrEmpty(entityValue3) ? string.Empty : str8 + entityValue3);
    }

    private void UpdateMemberProfile(
      FrameworkService crmService,
      Contact contact,
      Global.ActionType actionType)
    {
      if (contact == null || contact.ait_MemberProfile == null)
        return;
      bool flag = false;
      FrameworkService crmService1 = crmService.ImpersonateAdmin();
      ait_memberprofile entity = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) crmService1, contact.ait_MemberProfile, false);
      if (entity == null)
        return;
      ait_memberprofile aitMemberprofile = new ait_memberprofile();
      ((Entity) aitMemberprofile).Id = ((Entity) entity).Id;
      if (!AttributeLibrary.Compare(contact.ait_tribe, entity.ait_tribe))
      {
        flag = true;
        aitMemberprofile.ait_tribe = contact.ait_tribe;
      }
      if (!AttributeLibrary.Compare(contact.ait_bandid, entity.ait_bandid))
      {
        flag = true;
        aitMemberprofile.ait_bandid = contact.ait_bandid;
      }
      if (!AttributeLibrary.Compare((object) contact.ait_tribalid, (object) entity.ait_tribalid))
      {
        flag = true;
        aitMemberprofile.ait_tribalid = contact.ait_tribalid;
      }
      if (!flag)
        return;
      crmService1.Update((Entity) aitMemberprofile);
    }

    private void EntityInactivating(EntityReference deactiveEntityReference)
    {
      Contact entity = (Contact) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, deactiveEntityReference, false);
      if (entity == null || entity.ait_householdmember == null)
        return;
      HouseholdMemberPlugin.Deactivate((IOrganizationService) this.CrmService, entity.ait_householdmember);
    }

    private void UpdateRelatedRecords()
    {
      Contact inputEntity = this.GetInputEntity<Contact>(this.ActionType);
      this.UpdateMemberProfile(this.CrmService, inputEntity, this.ActionType);
      if (!this.HasAttributeChanged("statuscode") || inputEntity.StatusCode.Value != 2)
        return;
      this.EntityInactivating(inputEntity.ToEntityReference());
    }

    private void SetDefaults()
    {
      Contact inputEntity = this.GetInputEntity<Contact>();
      if (inputEntity == null || inputEntity.TransactionCurrencyId != null)
        return;
      inputEntity.TransactionCurrencyId = OrganizationLibrary.GetDefaultCurrency(this.CrmService);
    }

    private void SynchronizeFields()
    {
      this.UpdateSSNLastFour();
      Contact inputEntity = this.GetInputEntity<Contact>();
      if (!this.HasAttributeChanged("ait_height"))
        return;
      Decimal num = inputEntity.ait_height.HasValue ? inputEntity.ait_height.Value : 0M;
      string str = Math.Truncate(num / new Decimal(12.0)).ToString() + "'";
      if (num % 12M > 0M)
        str = str + Convert.ToInt32(num % 12M).ToString() + "\"";
      ((DataCollection<string, object>) inputEntity.Attributes)["ait_heightstring"] = num != 0M ? (object) str : (object) (string) null;
    }

    private void UpdateSSNLastFour()
    {
      Contact inputEntity = this.GetInputEntity<Contact>();
      if (inputEntity == null)
        return;
      string str = "";
      if (!string.IsNullOrEmpty(inputEntity.ait_ssn) && inputEntity.ait_ssn.Length > 4)
        str = inputEntity.ait_ssn.Substring(inputEntity.ait_ssn.Length - 4, 4);
      if (!string.IsNullOrEmpty(inputEntity.ait_ssn) && inputEntity.ait_ssn.Length == 9)
        inputEntity.ait_ssn = string.Format("{0}-{1}-{2}", (object) inputEntity.ait_ssn.Substring(0, 3), (object) inputEntity.ait_ssn.Substring(3, 2), (object) inputEntity.ait_ssn.Substring(5));
      switch (this.ActionType)
      {
        case Global.ActionType.CREATE:
          inputEntity.ait_ssnlast4 = str;
          break;
        case Global.ActionType.UPDATE:
          Contact entityFromPreImage = this.GetEntityFromPreImage<Contact>();
          if (inputEntity.ait_ssn == null && str == "" || !(entityFromPreImage.ait_ssn != inputEntity.ait_ssn) || !(entityFromPreImage.ait_ssnlast4 != str))
            break;
          inputEntity.ait_ssnlast4 = str;
          break;
      }
    }

    private void UpdateEntityImageString()
    {
      string str = (string) null;
      float width1 = 768f;
      float height1 = 1024f;
      this.CrmService.Trace("Entered Plugin to update Entity Image");
      Contact inputEntity = this.GetInputEntity<Contact>();
      if (((DataCollection<string, object>) inputEntity.Attributes).ContainsKey("entityimage"))
      {
        this.CrmService.Trace("EntityImage updated, converting...");
        if (inputEntity.EntityImage.Length > 102400)
        {
          using (MemoryStream memoryStream1 = new MemoryStream(inputEntity.EntityImage))
          {
            this.CrmService.Trace("Original Image size = " + memoryStream1.Length.ToString());
            Bitmap bitmap1 = new Bitmap((Stream) memoryStream1);
            float num = Math.Min(width1 / (float) bitmap1.Width, height1 / (float) bitmap1.Height);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            using (MemoryStream memoryStream2 = new MemoryStream())
            {
              Bitmap bitmap2 = new Bitmap((int) width1, (int) height1);
              using (Graphics graphics = Graphics.FromImage((Image) bitmap2))
              {
                this.CrmService.Trace("Compressing Image");
                graphics.InterpolationMode = InterpolationMode.High;
                graphics.CompositingQuality = CompositingQuality.Default;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                int width2 = (int) ((double) bitmap1.Width * (double) num);
                int height2 = (int) ((double) bitmap1.Height * (double) num);
                graphics.FillRectangle((Brush) solidBrush, new RectangleF(0.0f, 0.0f, width1, height1));
                graphics.DrawImage((Image) bitmap1, ((int) width1 - width2) / 2, ((int) height1 - height2) / 2, width2, height2);
              }
              bitmap2.Save((Stream) memoryStream2, ImageFormat.Jpeg);
              this.CrmService.Trace("Save image to memory buffer, size =" + memoryStream2.Length.ToString());
              str = Convert.ToBase64String(memoryStream2.ToArray());
            }
          }
        }
        else
        {
          this.CrmService.Trace("Image size less than 100kB, saving directly.");
          str = Convert.ToBase64String(inputEntity.EntityImage);
        }
        inputEntity.ait_entityimagestring = str != null && str.Length <= 1024094 ? str : throw new InvalidPluginExecutionException("Image issue: uploaded is too large, please keep below 1,024,094 bytes.");
      }
      this.CrmService.Trace("Conversion complete, leaving plugin.");
    }

    private static bool CheckPerCapEligibility(
      IOrganizationService crmService,
      EntityReference contactEntityReference,
      OptionSetValue eligibilityCriteria,
      OptionSetValue gender,
      int? ageMinimum,
      int? ageMaximum)
    {
      OrganizationRequest organizationRequest = new OrganizationRequest()
      {
        RequestName = "ait_ContactCheckPerCapEligibility"
      };
      organizationRequest["Target"] = (object) contactEntityReference;
      organizationRequest["EligibilityType"] = (object) eligibilityCriteria.Value;
      organizationRequest["Gender"] = (object) gender;
      organizationRequest["AgeMinimum"] = (object) ageMinimum;
      organizationRequest["AgeMaximum"] = (object) ageMaximum;
      return (bool) ((DataCollection<string, object>) crmService.Execute(organizationRequest).Results)["IsEligible"];
    }

    private void CreatePaymentEligibilities()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag1 = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag1 = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag1)
        return;
      this.CrmService.Trace("TP: Entering ContactPlugin.CreatePaymentEligibilities");
      Contact inputEntity = this.GetInputEntity<Contact>(this.ActionType);
      if (!this.HasEligibilityAttributeChanged())
        return;
      FrameworkService crmService = this.CrmService.ImpersonateAdmin();
      foreach (ait_pmtpaymenttype entity1 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) crmService, "ait_pmtpaymenttype", "ait_autocreateeligibilities", (object) true, true).Entities)
      {
        bool flag2 = ContactPlugin.IsEligibleForPaymentType((IOrganizationService) crmService, inputEntity, entity1);
        EntityCollection contactAndPaymentType = PaymentEligibilityPlugin.GetAllForContactAndPaymentType((IOrganizationService) crmService, ((Entity) inputEntity).Id, ((Entity) entity1).Id);
        bool flag3 = contactAndPaymentType != null && ((Collection<Entity>) contactAndPaymentType.Entities).Count > 0;
        if (flag2 && !flag3)
          PaymentEligibilityPlugin.Create((IOrganizationService) crmService, inputEntity, entity1);
        else if (!flag2 & flag3)
        {
          foreach (ait_pmteligibility entity2 in (Collection<Entity>) contactAndPaymentType.Entities)
            PaymentEligibilityPlugin.Deactivate((IOrganizationService) crmService, entity2.ToEntityReference());
        }
      }
    }

    private void CreatePaymentWithholdings()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      bool flag = false;
      if (configuration.ait_DisableCoreDistributionPaymentsLogic.HasValue)
        flag = configuration.ait_DisableCoreDistributionPaymentsLogic.Value;
      if (flag)
        return;
      this.CrmService.Trace("TP: Entering ContactPlugin.CreatePaymentWithholdings");
      Contact inputEntity = this.GetInputEntity<Contact>(this.ActionType);
      if (!this.HasEligibilityAttributeChanged())
        return;
      FrameworkService crmService = this.CrmService.ImpersonateAdmin();
      foreach (ait_withholdingtype entity1 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) crmService, "ait_withholdingtype", "ait_autocreatewithholding", (object) true, true).Entities)
      {
        if (ContactPlugin.IsEligibleForWithholdingType((IOrganizationService) crmService, inputEntity, entity1))
        {
          foreach (ait_withholdingtype_pmtpaymenttype entity2 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) crmService, "ait_withholdingtype_pmtpaymenttype", "ait_withholdingtypeid", (object) ((Entity) entity1).Id, false).Entities)
          {
            foreach (ait_pmteligibility entity3 in (Collection<Entity>) PaymentEligibilityPlugin.GetAllForContactAndPaymentType((IOrganizationService) crmService, ((Entity) inputEntity).Id, entity2.ait_pmtpaymenttypeid.Value).Entities)
            {
              EntityCollection paymentEligibility = WithholdingPlugin.GetAllForContactAndPaymentEligibility((IOrganizationService) crmService, ((Entity) inputEntity).Id, ((Entity) entity3).Id);
              if (paymentEligibility == null || ((Collection<Entity>) paymentEligibility.Entities).Count <= 0)
                WithholdingPlugin.Create((IOrganizationService) crmService, inputEntity, entity1, entity3);
            }
          }
        }
        else
        {
          foreach (ait_pmtwithholding entity4 in (Collection<Entity>) WithholdingPlugin.GetAllForContactAndWithholdingType((IOrganizationService) crmService, ((Entity) inputEntity).Id, ((Entity) entity1).Id).Entities)
            WithholdingPlugin.Deactivate((IOrganizationService) crmService, entity4.ToEntityReference());
        }
      }
    }

    private bool HasEligibilityAttributeChanged()
    {
      return this.HasAttributeChanged("ait_age") || this.HasAttributeChanged("ait_gender") || this.HasAttributeChanged("ait_membershipstatus") || this.HasAttributeChanged("ait_deathdate") || this.HasAttributeChanged("ait_deathrecord");
    }
  }
}
