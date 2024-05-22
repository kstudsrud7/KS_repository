// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.ElectronicAddressPlugin
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
  [CRMMetadata(EntityName = "ait_electronicaddress", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_electronicaddress")]
  public class ElectronicAddressPlugin : EntityBase
  {
    public ElectronicAddressPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
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
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.UpdateName();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    public static bool UpdateElectronicAddress(
      IOrganizationService crmService,
      ait_electronicaddress electronicAddress,
      Global.ActionType actionType)
    {
      bool flag = false;
      bool? nullable = electronicAddress != null ? electronicAddress.ait_current : throw new ArgumentNullException("Electronic Address cannot be empty.", nameof (electronicAddress));
      int num1;
      if (nullable.HasValue)
      {
        nullable = electronicAddress.ait_current;
        num1 = !nullable.Value ? 1 : 0;
      }
      else
        num1 = 0;
      if (num1 != 0)
        return flag;
      string referenceField = string.Empty;
      Guid? referenceId = new Guid?();
      if (electronicAddress.ait_contact != null)
      {
        referenceId = new Guid?(electronicAddress.ait_contact.Id);
        referenceField = "ait_contact";
      }
      else if (electronicAddress.ait_company != null)
      {
        referenceId = new Guid?(electronicAddress.ait_company.Id);
        referenceField = "ait_company";
      }
      else if (electronicAddress.ait_school != null)
      {
        referenceId = new Guid?(electronicAddress.ait_school.Id);
        referenceField = "ait_school";
      }
      if (referenceId.HasValue && referenceId.HasValue)
      {
        foreach (ait_electronicaddress entity in (Collection<Entity>) EntityLibrary.GetAllEntities(crmService, "ait_electronicaddress", referenceField, (object) referenceId, true).Entities)
        {
          nullable = entity.ait_current;
          int num2;
          if (nullable.HasValue && entity.ait_communicationtype != null)
          {
            nullable = entity.ait_current;
            if (nullable.Value && ((Entity) entity).Id != ((Entity) electronicAddress).Id)
            {
              num2 = entity.ait_communicationtype.Value == electronicAddress.ait_communicationtype.Value ? 1 : 0;
              goto label_20;
            }
          }
          num2 = 0;
label_20:
          if (num2 != 0)
          {
            flag = true;
            entity.ait_current = new bool?(false);
            crmService.Update((Entity) entity);
          }
        }
      }
      return flag;
    }

    public static bool UpdatePrimaryEntity(
      IOrganizationService crmService,
      ait_electronicaddress electronicAddress,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (electronicAddress == null)
        throw new ArgumentNullException("Electronic Address cannot be empty.", nameof (electronicAddress));
      if (electronicAddress.ait_communicationtype == null)
        return false;
      if (electronicAddress.ait_contact != null)
      {
        Contact entity = (Contact) EntityLibrary.GetEntity(crmService, electronicAddress.ait_contact, false);
        if (entity != null)
          ContactPlugin.UpdateElectronicAddressInfo(crmService, entity, electronicAddress, true);
      }
      ait_electronicaddressState? statecode;
      if (electronicAddress.ait_company != null)
      {
        ait_company entity = (ait_company) EntityLibrary.GetEntity(crmService, electronicAddress.ait_company, false);
        if (entity != null)
        {
          switch (electronicAddress.ait_communicationtype.Value)
          {
            case 750000000:
              statecode = electronicAddress.statecode;
              ait_electronicaddressState electronicaddressState1 = ait_electronicaddressState.Active;
              if (statecode.GetValueOrDefault() == electronicaddressState1 & statecode.HasValue && AttributeLibrary.Compare(electronicAddress.ait_current, true))
              {
                entity.ait_primaryphone = electronicAddress.ait_phonenumberoremail;
                break;
              }
              statecode = electronicAddress.statecode;
              ait_electronicaddressState electronicaddressState2 = ait_electronicaddressState.Active;
              if ((!(statecode.GetValueOrDefault() == electronicaddressState2 & statecode.HasValue) || AttributeLibrary.Compare(electronicAddress.ait_current, false)) && entity.ait_primaryphone == electronicAddress.ait_phonenumberoremail)
              {
                entity.ait_primaryphone = (string) null;
                break;
              }
              break;
            case 750000001:
              statecode = electronicAddress.statecode;
              ait_electronicaddressState electronicaddressState3 = ait_electronicaddressState.Active;
              if (statecode.GetValueOrDefault() == electronicaddressState3 & statecode.HasValue && AttributeLibrary.Compare(electronicAddress.ait_current, true))
              {
                entity.ait_primaryemail = electronicAddress.ait_phonenumberoremail;
                break;
              }
              statecode = electronicAddress.statecode;
              ait_electronicaddressState electronicaddressState4 = ait_electronicaddressState.Active;
              if ((!(statecode.GetValueOrDefault() == electronicaddressState4 & statecode.HasValue) || AttributeLibrary.Compare(electronicAddress.ait_current, false)) && entity.ait_primaryemail == electronicAddress.ait_phonenumberoremail)
              {
                entity.ait_primaryemail = (string) null;
                break;
              }
              break;
          }
          crmService.Update((Entity) entity);
        }
      }
      if (electronicAddress.ait_school != null)
      {
        ait_school entity = (ait_school) EntityLibrary.GetEntity(crmService, electronicAddress.ait_school, false);
        if (entity != null)
        {
          switch (electronicAddress.ait_communicationtype.Value)
          {
            case 750000000:
              statecode = electronicAddress.statecode;
              ait_electronicaddressState electronicaddressState5 = ait_electronicaddressState.Active;
              if (statecode.GetValueOrDefault() == electronicaddressState5 & statecode.HasValue && AttributeLibrary.Compare(electronicAddress.ait_current, true))
              {
                entity.ait_primaryphone = electronicAddress.ait_phonenumberoremail;
                break;
              }
              statecode = electronicAddress.statecode;
              ait_electronicaddressState electronicaddressState6 = ait_electronicaddressState.Active;
              if ((!(statecode.GetValueOrDefault() == electronicaddressState6 & statecode.HasValue) || AttributeLibrary.Compare(electronicAddress.ait_current, false)) && entity.ait_primaryphone == electronicAddress.ait_phonenumberoremail)
              {
                entity.ait_primaryphone = (string) null;
                break;
              }
              break;
            case 750000001:
              statecode = electronicAddress.statecode;
              ait_electronicaddressState electronicaddressState7 = ait_electronicaddressState.Active;
              if (statecode.GetValueOrDefault() == electronicaddressState7 & statecode.HasValue && AttributeLibrary.Compare(electronicAddress.ait_current, true))
              {
                entity.ait_primaryemail = electronicAddress.ait_phonenumberoremail;
                break;
              }
              statecode = electronicAddress.statecode;
              ait_electronicaddressState electronicaddressState8 = ait_electronicaddressState.Active;
              if ((!(statecode.GetValueOrDefault() == electronicaddressState8 & statecode.HasValue) || AttributeLibrary.Compare(electronicAddress.ait_current, false)) && entity.ait_primaryemail == electronicAddress.ait_phonenumberoremail)
              {
                entity.ait_primaryemail = (string) null;
                break;
              }
              break;
          }
          crmService.Update((Entity) entity);
        }
      }
      return flag;
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_electronicaddress>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_electronicaddress>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      string formattedName = FormatLibrary.GetEntityValue(((ait_electronicaddress) entityInput).ait_phonenumberoremail, ((ait_electronicaddress) preImage).ait_phonenumberoremail);
      if (string.IsNullOrEmpty(formattedName))
        formattedName = "Unknown";
      return formattedName;
    }

    private void UpdateRelatedRecords()
    {
      ait_electronicaddress inputEntity = this.GetInputEntity<ait_electronicaddress>(this.ActionType);
      ElectronicAddressPlugin.UpdateElectronicAddress((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
      ElectronicAddressPlugin.UpdatePrimaryEntity((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
    }
  }
}
