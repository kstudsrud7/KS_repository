// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.DeathRecordPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using System;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_deathrecord", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_deathrecord")]
  public class DeathRecordPlugin : EntityBase
  {
    public DeathRecordPlugin(
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
      this.Validate();
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.Validate();
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

    public static bool UpdateContact(
      FrameworkService crmService,
      ait_deathrecord deathRecord,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (deathRecord == null)
        throw new ArgumentNullException("DeathRecord cannot be empty.", "deathrecord");
      if (deathRecord.ait_Contact == null)
        return false;
      Contact entity = (Contact) EntityLibrary.GetEntity((IOrganizationService) crmService, deathRecord.ait_Contact, false);
      if (entity == null)
        return false;
      Contact contact = new Contact();
      ((Entity) contact).Id = ((Entity) entity).Id;
      ait_deathrecordState? statecode;
      int num1;
      if ((entity.ait_deathrecord == null || !AttributeLibrary.Compare(entity.ait_deathdate, deathRecord.ait_dateofdeathinternal)) && actionType != Global.ActionType.DELETE)
      {
        statecode = deathRecord.statecode;
        ait_deathrecordState deathrecordState = ait_deathrecordState.Inactive;
        num1 = !(statecode.GetValueOrDefault() == deathrecordState & statecode.HasValue) ? 1 : 0;
      }
      else
        num1 = 0;
      if (num1 != 0)
      {
        flag = true;
        entity.ait_deathrecord = deathRecord.ToEntityReference();
        contact.ait_deathrecord = deathRecord.ToEntityReference();
        entity.ait_deathdate = deathRecord.ait_dateofdeathinternal;
        contact.ait_deathdate = deathRecord.ait_dateofdeathinternal;
      }
      else
      {
        int num2;
        if (AttributeLibrary.Compare(entity.ait_deathrecord, deathRecord.ToEntityReference()))
        {
          statecode = deathRecord.statecode;
          ait_deathrecordState deathrecordState = ait_deathrecordState.Inactive;
          num2 = statecode.GetValueOrDefault() == deathrecordState & statecode.HasValue ? 1 : 0;
        }
        else
          num2 = 0;
        if (num2 != 0)
        {
          flag = true;
          entity.ait_deathrecord = (EntityReference) null;
          contact.ait_deathrecord = (EntityReference) null;
          entity.ait_deathdate = new DateTime?();
          contact.ait_deathdate = new DateTime?();
        }
        else if (entity.ait_deathrecord != null && actionType == Global.ActionType.DELETE)
        {
          flag = true;
          entity.ait_deathdate = new DateTime?();
          contact.ait_deathdate = new DateTime?();
        }
      }
      ContactPlugin.UpdateAgeInfo(crmService, entity, true);
      if (flag)
        crmService.Update((Entity) contact);
      return flag;
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_deathrecord>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_deathrecord>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_deathrecord aitDeathrecord1 = (ait_deathrecord) entityInput;
      ait_deathrecord aitDeathrecord2 = (ait_deathrecord) preImage;
      string entityValue1 = FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitDeathrecord1.ait_Contact, aitDeathrecord2.ait_Contact);
      string entityValue2 = FormatLibrary.GetEntityValue(aitDeathrecord1.ait_dateofdeath, aitDeathrecord2.ait_dateofdeath);
      if (string.IsNullOrEmpty(entityValue1))
        throw new ArgumentException("Contact cannot be empty.", "Contact");
      string formattedName = entityValue2;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = "Date Unknown";
      return formattedName;
    }

    public void Validate()
    {
      DateTime? nullable1 = new DateTime?();
      DateTime? nullable2 = new DateTime?();
      ait_deathrecord inputEntity = this.GetInputEntity<ait_deathrecord>(this.ActionType);
      if (!string.IsNullOrEmpty(inputEntity.ait_dateofdeath))
      {
        try
        {
          nullable2 = new DateTime?(Convert.ToDateTime(inputEntity.ait_dateofdeath));
        }
        catch (FormatException ex)
        {
          throw new InvalidPluginExecutionException(string.Format("Date of Death is not in a valid date format: {0}", (object) inputEntity.ait_dateofdeath));
        }
        string str = nullable2.Value.ToString("M/d/yyyy");
        if (inputEntity.ait_dateofdeath != str)
          inputEntity.ait_dateofdeath = str;
      }
      DateTime? nullable3;
      if (nullable2.HasValue)
      {
        nullable3 = inputEntity.ait_dateofdeathinternal;
        int num1;
        if (nullable3.HasValue)
        {
          nullable3 = inputEntity.ait_dateofdeathinternal;
          if (nullable3.HasValue)
          {
            num1 = 0;
            goto label_11;
          }
        }
        num1 = nullable2.Value > new DateTime(1753, 1, 1) ? 1 : 0;
label_11:
        if (num1 != 0)
          inputEntity.ait_dateofdeathinternal = nullable2;
        nullable3 = inputEntity.ait_dateofdeathinternal;
        int num2;
        if (nullable3.HasValue)
        {
          nullable3 = inputEntity.ait_dateofdeathinternal;
          if (nullable3.HasValue)
          {
            num2 = 0;
            goto label_17;
          }
        }
        num2 = nullable2.Value <= new DateTime(1753, 1, 1) ? 1 : 0;
label_17:
        if (num2 != 0)
        {
          ait_deathrecord aitDeathrecord = inputEntity;
          nullable3 = new DateTime?();
          DateTime? nullable4 = nullable3;
          aitDeathrecord.ait_dateofdeathinternal = nullable4;
        }
      }
      if (nullable2.HasValue && nullable2.HasValue && inputEntity.ait_Contact != null)
      {
        ait_birthrecord entity = (ait_birthrecord) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, ((Contact) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputEntity.ait_Contact)).ait_birthrecord);
        if (entity != null && !string.IsNullOrWhiteSpace(entity.ait_dateofbirth))
          nullable1 = new DateTime?(Convert.ToDateTime(entity.ait_dateofbirth));
      }
      if (!nullable1.HasValue || !nullable2.HasValue || !nullable1.HasValue || !nullable2.HasValue)
        return;
      nullable3 = nullable2;
      DateTime? nullable5 = nullable1;
      if (nullable3.HasValue & nullable5.HasValue && nullable3.GetValueOrDefault() < nullable5.GetValueOrDefault())
        throw new InvalidPluginExecutionException(string.Format("Date of death ({0}) cannot be before birth date ({1})", (object) nullable2.Value.ToString("M/d/yyyy"), (object) nullable1.Value.ToString("M/d/yyyy")));
    }

    public void UpdateRelatedRecords()
    {
      DeathRecordPlugin.UpdateContact(this.CrmService, this.GetInputEntity<ait_deathrecord>(this.ActionType), this.ActionType);
    }
  }
}
