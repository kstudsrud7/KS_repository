// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.ChangeRequestPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_changerequest", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_changerequest")]
  public class ChangeRequestPlugin : EntityBase
  {
    public ChangeRequestPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPostCustomActionFiring += new EntityBase.PluginPostCustomActionHandler(this.Execute_OnPluginPostCustomActionFiring);
    }

    private void Execute_OnPluginPostCustomActionFiring(
      object sender,
      EntityBase.PluginPostCustomActionHandlerEventArgs e)
    {
      string lower = ((IExecutionContext) this.CrmService.PluginContext).MessageName.ToLower();
      if (!(lower == "ait_changerequestupdate"))
        throw new InvalidPluginExecutionException("Invalid action on Change Request: " + lower);
      this.UpdateAddressInformation();
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.UpdateApprovedValues();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_changerequest>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_changerequest>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string formattedName = ((ait_changerequest) entityInput).ait_name;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_changerequest", "ait_name");
      return formattedName;
    }

    private void UpdateAddressInformation()
    {
      string str = string.Empty;
      ait_changerequest entity = (ait_changerequest) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, this.GetInputVariable<EntityReference>("Target", true));
      ait_electronicaddress electronicaddress1 = (ait_electronicaddress) null;
      ait_electronicaddress electronicaddress2 = (ait_electronicaddress) null;
      ait_physicaladdress aitPhysicaladdress = (ait_physicaladdress) null;
      if (!string.IsNullOrEmpty(entity.ait_Email_Approved))
      {
        electronicaddress1 = this.CreateEmailAddress(entity);
        str += "Email";
      }
      if (!string.IsNullOrEmpty(entity.ait_Phone_Approved))
      {
        electronicaddress2 = this.CreatePhoneNumber(entity);
        str = string.IsNullOrEmpty(str) ? "Phone" : str + ",Phone";
      }
      if (!string.IsNullOrEmpty(entity.ait_Street1_Approved) || entity.ait_City_Approved != null || entity.ait_StateProvince_Approved != null || entity.ait_ZipCode_Approved != null)
      {
        aitPhysicaladdress = this.CreatePhysicalAddress(entity);
        str = string.IsNullOrEmpty(str) ? "Address" : str + ",Address";
      }
      if (!string.IsNullOrEmpty(str))
      {
        string noteText = string.Format("Records ({0})", (object) str);
        this.AddNoteToRecord(entity.ToEntityReference(), noteText);
      }
      if (aitPhysicaladdress == null && electronicaddress1 == null && electronicaddress2 == null)
        return;
      ait_changerequest aitChangerequest = new ait_changerequest();
      ((Entity) aitChangerequest).Id = ((Entity) entity).Id;
      if (aitPhysicaladdress != null)
        aitChangerequest.ait_PhysicalAddress = aitPhysicaladdress.ToEntityReference();
      if (electronicaddress1 != null)
        aitChangerequest.ait_Email_ElectronicAddress = electronicaddress1.ToEntityReference();
      if (electronicaddress2 != null)
        aitChangerequest.ait_Phone_ElectronicAddress = electronicaddress2.ToEntityReference();
      this.CrmService.Update((Entity) aitChangerequest);
    }

    private ait_electronicaddress CreateEmailAddress(ait_changerequest changeRequest)
    {
      ait_electronicaddress emailAddress = new ait_electronicaddress();
      emailAddress.ait_contact = changeRequest.ait_Contact;
      emailAddress.ait_current = new bool?(true);
      emailAddress.ait_communicationtype = new OptionSetValue(750000001);
      emailAddress.ait_phonenumberoremail = changeRequest.ait_Email_Approved;
      emailAddress.ait_description = "Created from change request.";
      ((Entity) emailAddress).Id = this.CrmService.Create((Entity) emailAddress);
      this.AddNoteToRecord(changeRequest, emailAddress.ToEntityReference());
      return emailAddress;
    }

    private ait_electronicaddress CreatePhoneNumber(ait_changerequest changeRequest)
    {
      ait_electronicaddress phoneNumber = new ait_electronicaddress();
      phoneNumber.ait_contact = changeRequest.ait_Contact;
      phoneNumber.ait_current = new bool?(true);
      phoneNumber.ait_communicationtype = new OptionSetValue(750000000);
      phoneNumber.ait_phonenumberoremail = changeRequest.ait_Phone_Approved;
      phoneNumber.ait_description = string.Format("Created from change request {0}.", (object) changeRequest.ait_name);
      ((Entity) phoneNumber).Id = this.CrmService.Create((Entity) phoneNumber);
      this.AddNoteToRecord(changeRequest, phoneNumber.ToEntityReference());
      return phoneNumber;
    }

    private ait_physicaladdress CreatePhysicalAddress(ait_changerequest changeRequest)
    {
      ait_physicaladdress physicalAddress = new ait_physicaladdress();
      physicalAddress.ait_contact = changeRequest.ait_Contact;
      switch (changeRequest.ait_ChangeRequestAddressType.Value)
      {
        case 750000000:
          physicalAddress.ait_current = new bool?(true);
          physicalAddress.ait_mailing = new bool?(true);
          break;
        case 750000001:
          physicalAddress.ait_current = new bool?(true);
          physicalAddress.ait_mailing = new bool?(false);
          break;
        case 750000002:
          physicalAddress.ait_current = new bool?(false);
          physicalAddress.ait_mailing = new bool?(true);
          break;
        case 750000003:
          physicalAddress.ait_current = new bool?(false);
          physicalAddress.ait_mailing = new bool?(false);
          break;
        default:
          throw new NotImplementedException("enum value for ait_ChangeRequestAddressType not handled.");
      }
      ait_addresstype firstEntity = (ait_addresstype) EntityLibrary.GetFirstEntity((IOrganizationService) this.CrmService, "ait_addresstype", "ait_name", (object) "Home", true);
      if (firstEntity != null)
        physicalAddress.ait_addresstype = firstEntity.ToEntityReference();
      physicalAddress.ait_street1 = changeRequest.ait_Street1_Approved;
      physicalAddress.ait_street2 = changeRequest.ait_Street2_Approved;
      physicalAddress.ait_street3 = changeRequest.ait_Street3_Approved;
      physicalAddress.ait_city = changeRequest.ait_City_Approved;
      physicalAddress.ait_stateprovince = changeRequest.ait_StateProvince_Approved;
      physicalAddress.ait_zipcode = changeRequest.ait_ZipCode_Approved;
      if (changeRequest.ait_City_Approved != null)
      {
        ait_city entity = (ait_city) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, changeRequest.ait_City_Approved);
        if (entity != null)
          physicalAddress.ait_county = entity.ait_county;
      }
      if (changeRequest.ait_StateProvince_Approved != null)
      {
        ait_stateprovince entity = (ait_stateprovince) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, changeRequest.ait_StateProvince_Approved);
        if (entity != null)
          physicalAddress.ait_countryregion = entity.ait_countryregion;
      }
      ((Entity) physicalAddress).Id = this.CrmService.Create((Entity) physicalAddress);
      this.AddNoteToRecord(changeRequest, physicalAddress.ToEntityReference());
      return physicalAddress;
    }

    private void AddNoteToRecord(ait_changerequest changeRequest, EntityReference createOnReference)
    {
      string noteText = string.Format("Created from Change Request: {0}", (object) changeRequest.ait_name);
      this.AddNoteToRecord(createOnReference, noteText);
    }

    private void AddNoteToRecord(EntityReference createOnReference, string noteText)
    {
      this.CrmService.Create((Entity) new Annotation()
      {
        Subject = "Record Creation",
        NoteText = noteText,
        ObjectId = createOnReference,
        ObjectTypeCode = createOnReference.LogicalName,
        IsDocument = new bool?(false)
      });
    }

    private void UpdateApprovedValues()
    {
      ait_changerequest preImageForUpdate = (ait_changerequest) this.GetPreImageForUpdate();
      if (!string.IsNullOrEmpty(preImageForUpdate.ait_Street1_User))
        preImageForUpdate.ait_Street1_Approved = preImageForUpdate.ait_Street1_User;
      if (!string.IsNullOrEmpty(preImageForUpdate.ait_Street2_User))
        preImageForUpdate.ait_Street2_Approved = preImageForUpdate.ait_Street2_User;
      if (!string.IsNullOrEmpty(preImageForUpdate.ait_Street3_User))
        preImageForUpdate.ait_Street3_Approved = preImageForUpdate.ait_Street3_User;
      if (!string.IsNullOrEmpty(preImageForUpdate.ait_Email_User))
        preImageForUpdate.ait_Email_Approved = preImageForUpdate.ait_Email_User;
      if (!string.IsNullOrEmpty(preImageForUpdate.ait_Phone_User))
        preImageForUpdate.ait_Phone_Approved = AddressLibrary.FormatPhoneNumber(preImageForUpdate.ait_Phone_User);
      if (string.IsNullOrEmpty(preImageForUpdate.ait_ZipCode_User) || string.IsNullOrEmpty(preImageForUpdate.ait_City_User) || string.IsNullOrEmpty(preImageForUpdate.ait_StateProvince_User))
        return;
      ait_zipcodecity zipCodeForCity = ChangeRequestPlugin.GetZipCodeForCity(this.CrmService, preImageForUpdate.ait_ZipCode_User, preImageForUpdate.ait_City_User);
      if (zipCodeForCity != null)
      {
        preImageForUpdate.ait_ZipCode_Approved = zipCodeForCity.ToEntityReference();
        preImageForUpdate.ait_City_Approved = zipCodeForCity.ait_city;
        preImageForUpdate.ait_StateProvince_Approved = zipCodeForCity.ait_stateprovince;
      }
    }

    private static ait_zipcodecity GetZipCodeForCity(
      FrameworkService crmService,
      string zipCode,
      string city)
    {
      ait_zipcodecity zipCodeForCity = (ait_zipcodecity) null;
      EntityCollection citiesForZipCode = ChangeRequestPlugin.GetCitiesForZipCode(crmService, zipCode);
      if (citiesForZipCode != null && ((Collection<Entity>) citiesForZipCode.Entities).Count > 0)
      {
        foreach (ait_zipcodecity entity in (Collection<Entity>) citiesForZipCode.Entities)
        {
          if (entity.ait_city.Name.ToLower() == city.ToLower())
          {
            zipCodeForCity = entity;
            break;
          }
        }
      }
      return zipCodeForCity;
    }

    private static EntityCollection GetCitiesForZipCode(FrameworkService crmService, string zipCode)
    {
      return EntityLibrary.GetAllEntities((IOrganizationService) crmService, "ait_zipcodecity", "ait_name", (object) zipCode, true);
    }
  }
}
