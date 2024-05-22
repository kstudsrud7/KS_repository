// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.BirthRecordPlugin
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
  [CRMMetadata(EntityName = "ait_birthrecord", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_birthrecord")]
  public class BirthRecordPlugin : EntityBase
  {
    public BirthRecordPlugin(
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

    public static bool UpdateContact(FrameworkService crmService, ait_birthrecord birthRecord)
    {
      return BirthRecordPlugin.UpdateContact(crmService, birthRecord, Global.ActionType.UNKNOWN);
    }

    public static bool UpdateContact(
      FrameworkService crmService,
      ait_birthrecord birthRecord,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (birthRecord == null)
        throw new ArgumentNullException("BirthRecord cannot be empty.", nameof (birthRecord));
      if (birthRecord.ait_Contact == null)
        return false;
      Contact entity = (Contact) EntityLibrary.GetEntity((IOrganizationService) crmService, birthRecord.ait_Contact, false);
      if (entity == null)
        return false;
      Contact contact = new Contact();
      ((Entity) contact).Id = ((Entity) entity).Id;
      ait_birthrecordState? statecode;
      int num1;
      if ((entity.ait_birthrecord == null || entity.ait_birthrecord.Id != ((Entity) birthRecord).Id || !AttributeLibrary.Compare(entity.BirthDate, birthRecord.ait_dateofbirthinternal)) && actionType != Global.ActionType.DELETE)
      {
        statecode = birthRecord.statecode;
        ait_birthrecordState birthrecordState = ait_birthrecordState.Inactive;
        num1 = !(statecode.GetValueOrDefault() == birthrecordState & statecode.HasValue) ? 1 : 0;
      }
      else
        num1 = 0;
      if (num1 != 0)
      {
        flag = true;
        entity.ait_birthrecord = birthRecord.ToEntityReference();
        entity.BirthDate = birthRecord.ait_dateofbirthinternal;
        contact.ait_birthrecord = birthRecord.ToEntityReference();
        contact.BirthDate = birthRecord.ait_dateofbirthinternal;
      }
      else
      {
        int num2;
        if (AttributeLibrary.Compare(entity.ait_birthrecord, birthRecord.ToEntityReference()))
        {
          statecode = birthRecord.statecode;
          ait_birthrecordState birthrecordState = ait_birthrecordState.Inactive;
          num2 = statecode.GetValueOrDefault() == birthrecordState & statecode.HasValue ? 1 : 0;
        }
        else
          num2 = 0;
        if (num2 != 0)
        {
          flag = true;
          entity.ait_birthrecord = (EntityReference) null;
          entity.BirthDate = new DateTime?();
          contact.ait_birthrecord = (EntityReference) null;
          contact.BirthDate = new DateTime?();
        }
        else if (entity.ait_birthrecord != null && actionType == Global.ActionType.DELETE)
        {
          flag = true;
          entity.BirthDate = new DateTime?();
          contact.BirthDate = new DateTime?();
        }
      }
      ContactPlugin.UpdateAgeInfo(crmService, entity, true);
      if (flag)
        crmService.Update((Entity) contact);
      return flag;
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_birthrecord>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_birthrecord>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_birthrecord aitBirthrecord1 = (ait_birthrecord) entityInput;
      ait_birthrecord aitBirthrecord2 = (ait_birthrecord) preImage;
      string entityValue1 = FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitBirthrecord1.ait_Contact, aitBirthrecord2.ait_Contact);
      string entityValue2 = FormatLibrary.GetEntityValue(aitBirthrecord1.ait_dateofbirth, aitBirthrecord2.ait_dateofbirth);
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
      ait_birthrecord inputEntity = this.GetInputEntity<ait_birthrecord>(this.ActionType);
      if (!string.IsNullOrEmpty(inputEntity.ait_dateofbirth))
      {
        try
        {
          nullable1 = new DateTime?(Convert.ToDateTime(inputEntity.ait_dateofbirth));
        }
        catch (FormatException ex)
        {
          throw new InvalidPluginExecutionException(string.Format("Date of Brith is not in a valid date format: {0}", (object) inputEntity.ait_dateofbirth));
        }
        string str = nullable1.Value.ToString("M/d/yyyy");
        if (inputEntity.ait_dateofbirth != str)
          inputEntity.ait_dateofbirth = str;
      }
      DateTime? nullable3;
      if (nullable1.HasValue)
      {
        nullable3 = inputEntity.ait_dateofbirthinternal;
        int num1;
        if (nullable3.HasValue)
        {
          nullable3 = inputEntity.ait_dateofbirthinternal;
          if (nullable3.HasValue)
          {
            num1 = 0;
            goto label_11;
          }
        }
        num1 = nullable1.Value > new DateTime(1753, 1, 1) ? 1 : 0;
label_11:
        if (num1 != 0)
          inputEntity.ait_dateofbirthinternal = nullable1;
        nullable3 = inputEntity.ait_dateofbirthinternal;
        int num2;
        if (nullable3.HasValue)
        {
          nullable3 = inputEntity.ait_dateofbirthinternal;
          if (nullable3.HasValue)
          {
            num2 = 0;
            goto label_17;
          }
        }
        num2 = nullable1.Value <= new DateTime(1753, 1, 1) ? 1 : 0;
label_17:
        if (num2 != 0)
        {
          ait_birthrecord aitBirthrecord = inputEntity;
          nullable3 = new DateTime?();
          DateTime? nullable4 = nullable3;
          aitBirthrecord.ait_dateofbirthinternal = nullable4;
        }
      }
      if (nullable1.HasValue && nullable1.HasValue && inputEntity.ait_Contact != null)
      {
        ait_deathrecord entity = (ait_deathrecord) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, ((Contact) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputEntity.ait_Contact, false)).ait_deathrecord, false);
        if (entity != null && !string.IsNullOrWhiteSpace(entity.ait_dateofdeath))
          nullable2 = new DateTime?(Convert.ToDateTime(entity.ait_dateofdeath));
      }
      if (!nullable1.HasValue || !nullable2.HasValue || !nullable1.HasValue || !nullable2.HasValue)
        return;
      nullable3 = nullable2;
      DateTime? nullable5 = nullable1;
      if (nullable3.HasValue & nullable5.HasValue && nullable3.GetValueOrDefault() < nullable5.GetValueOrDefault())
        throw new InvalidPluginExecutionException(string.Format("Brith date ({0}) cannot be before death date ({1})", (object) nullable1.Value.ToString("M/d/yyyy"), (object) nullable2.Value.ToString("M/d/yyyy")));
    }

    public void UpdateRelatedRecords()
    {
      BirthRecordPlugin.UpdateContact(this.CrmService, this.GetInputEntity<ait_birthrecord>(this.ActionType), this.ActionType);
    }
  }
}
