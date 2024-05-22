// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.RelatedEntityLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public class RelatedEntityLibrary
  {
    public static void SynchronizeFromRelatedEntityAttributes(
      FrameworkService crmService,
      EntityBase entityBase,
      List<UpdateRelatedAttributeInformation> relatedAttributeInformationList)
    {
      if (relatedAttributeInformationList == null || relatedAttributeInformationList.Count == 0 || entityBase == null)
        return;
      foreach (UpdateRelatedAttributeInformation attributeInformation in relatedAttributeInformationList)
        RelatedEntityLibrary.SynchronizeFromRelatedEntityAttributes(crmService, entityBase, attributeInformation);
    }

    public static void SynchronizeFromRelatedEntityAttributes(
      FrameworkService crmService,
      EntityBase entityBase,
      UpdateRelatedAttributeInformation relatedAttributeInformation)
    {
      if (entityBase.TargetEntityReference == null)
        return;
      EntityReference attributeValue = (EntityReference) entityBase.GetAttributeValue(relatedAttributeInformation.RelatedAttributeName);
      if (attributeValue == null)
        return;
      Entity inputEntity = entityBase.GetInputEntity<Entity>();
      if (inputEntity == null)
        return;
      Entity entity = EntityLibrary.GetEntity((IOrganizationService) crmService, attributeValue);
      if (entity == null)
        return;
      for (int index = 0; index < relatedAttributeInformation.BaseColumnList.Length; ++index)
      {
        string baseColumn = relatedAttributeInformation.BaseColumnList[index];
        string relatedColumn = relatedAttributeInformation.RelatedColumnList[index];
        if (((DataCollection<string, object>) entity.Attributes).Contains(relatedColumn))
          inputEntity[baseColumn] = ((DataCollection<string, object>) entity.Attributes)[relatedColumn];
      }
    }

    public static void SynchronizeToRelatedEntityAttributes(
      FrameworkService crmService,
      EntityBase entityBase,
      List<UpdateRelatedAttributeInformation> relatedAttributeInformationList)
    {
      if (relatedAttributeInformationList == null || relatedAttributeInformationList.Count == 0 || entityBase == null)
        return;
      foreach (UpdateRelatedAttributeInformation attributeInformation in relatedAttributeInformationList)
        RelatedEntityLibrary.SynchronizeToRelatedEntityAttributes(crmService, entityBase, attributeInformation);
    }

    public static void SynchronizeToRelatedEntityAttributes(
      FrameworkService crmService,
      EntityBase entityBase,
      UpdateRelatedAttributeInformation relatedAttributeInformation)
    {
      if (entityBase.TargetEntityReference == null)
        return;
      bool flag1 = false;
      foreach (string baseColumn in relatedAttributeInformation.BaseColumnList)
      {
        if (entityBase.HasAttributeChanged(baseColumn))
        {
          flag1 = true;
          break;
        }
      }
      if (!flag1)
        return;
      FrameworkService crmService1 = crmService;
      if (relatedAttributeInformation.ImpersonateOnUpdate)
        crmService1 = crmService.Impersonate();
      foreach (Entity entity1 in (Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) crmService1, relatedAttributeInformation.EntityLogicalName, relatedAttributeInformation.RelatedAttributeName, (object) entityBase.TargetEntityReference, true).Entities)
      {
        bool flag2 = false;
        Entity entity2 = new Entity();
        entity2.Id = entity1.Id;
        entity2.LogicalName = entity1.LogicalName;
        for (int index = 0; index < relatedAttributeInformation.BaseColumnList.Length; ++index)
        {
          string baseColumn = relatedAttributeInformation.BaseColumnList[index];
          string relatedColumn = relatedAttributeInformation.RelatedColumnList[index];
          if (entityBase.HasAttributeChanged(baseColumn))
          {
            entity2[relatedColumn] = entityBase.GetAttributeValue(baseColumn);
            flag2 = true;
          }
        }
        if (flag2)
          crmService.Update(entity2);
      }
    }

    public static void UpdateRelatedEntityNames(
      FrameworkService crmService,
      EntityReference relatedEntity,
      List<UpdateNameInformation> relatedNameEntities)
    {
      if (relatedNameEntities == null || relatedNameEntities.Count == 0 || relatedEntity == null)
        return;
      foreach (UpdateNameInformation relatedNameEntity in relatedNameEntities)
        RelatedEntityLibrary.UpdateRelatedEntityName(crmService, relatedEntity, relatedNameEntity.EntityLogicalName, relatedNameEntity.RelatedAttributeName, relatedNameEntity.ImpersonateOnUpdate);
    }

    public static void UpdateRelatedEntityName(
      FrameworkService crmService,
      EntityReference relatedEntity,
      string entityLogicalName,
      string relatedEntityAttribute,
      bool impersonateService)
    {
      FrameworkService crmService1 = crmService;
      if (impersonateService)
        crmService1 = crmService.ImpersonateAdmin();
      try
      {
        EntityCollection allEntities = EntityLibrary.GetAllEntities((IOrganizationService) crmService1, entityLogicalName, relatedEntityAttribute, (object) relatedEntity.Id, true);
        if (allEntities == null || ((Collection<Entity>) allEntities.Entities).Count <= 0)
          return;
        foreach (Entity entity in (Collection<Entity>) allEntities.Entities)
          crmService1.Update(new Entity()
          {
            Id = entity.Id,
            LogicalName = entity.LogicalName,
            ["ait_name"] = (object) null
          });
      }
      catch
      {
        crmService.Trace("Entered Catch in UpdateRelatedEntityName");
      }
    }

    public static void UpdateRelatedEntityStatuses(
      FrameworkService crmService,
      EntityReference relatedEntity,
      List<UpdateStatusInformation> relatedNameEntities)
    {
      if (relatedNameEntities == null || relatedNameEntities.Count == 0 || relatedEntity == null)
        return;
      foreach (UpdateStatusInformation relatedNameEntity in relatedNameEntities)
        RelatedEntityLibrary.UpdateRelatedEntityStatus(crmService, relatedEntity, relatedNameEntity.EntityLogicalName, relatedNameEntity.RelatedAttributeName, relatedNameEntity.StateCode, relatedNameEntity.StatusCode, relatedNameEntity.ImpersonateOnUpdate);
    }

    public static void UpdateRelatedEntityStatus(
      FrameworkService crmService,
      EntityReference relatedEntity,
      string entityLogicalName,
      string relatedEntityAttribute,
      int stateCode,
      int statusCode,
      bool impersonateService)
    {
      FrameworkService crmService1 = crmService;
      if (impersonateService)
        crmService1 = crmService.Impersonate();
      EntityCollection allEntities = EntityLibrary.GetAllEntities((IOrganizationService) crmService1, entityLogicalName, relatedEntityAttribute, (object) relatedEntity.Id, false);
      if (allEntities == null || ((Collection<Entity>) allEntities.Entities).Count <= 0)
        return;
      foreach (Entity entity in (Collection<Entity>) allEntities.Entities)
        EntityLibrary.SetEntityState((IOrganizationService) crmService1, entity.ToEntityReference(), stateCode, statusCode);
    }
  }
}
