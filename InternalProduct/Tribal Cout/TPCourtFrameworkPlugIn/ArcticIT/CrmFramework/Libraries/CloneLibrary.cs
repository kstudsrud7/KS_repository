// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.CloneLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class CloneLibrary
  {
    public static Entity CloneEntityUnsaved(
      IOrganizationService crmService,
      Entity originalEntity,
      Dictionary<string, object> attributeUpdateList)
    {
      string[] attributesToSkipIn = new string[0];
      return CloneLibrary.CloneEntityUnsaved(crmService, originalEntity, attributeUpdateList, attributesToSkipIn);
    }

    public static Entity CloneEntityUnsaved(
      IOrganizationService crmService,
      Entity originalEntity,
      Dictionary<string, object> attributeUpdateList,
      string[] attributesToSkipIn)
    {
      if (originalEntity == null)
        throw new ArgumentNullException(nameof (originalEntity));
      Entity clonedEntity = new Entity();
      clonedEntity.LogicalName = originalEntity.LogicalName;
      CloneLibrary.CopyEntityAttributes(originalEntity, clonedEntity, attributeUpdateList, attributesToSkipIn);
      return clonedEntity;
    }

    public static Entity CloneEntity(
      IOrganizationService crmService,
      Entity originalEntity,
      Dictionary<string, object> attributeUpdateList)
    {
      Entity clonedEntity = originalEntity != null ? new Entity()
      {
        LogicalName = originalEntity.LogicalName
      } : throw new ArgumentNullException(nameof (originalEntity));
      clonedEntity.Id = crmService.Create(clonedEntity);
      CloneLibrary.CopyEntityAttributes(originalEntity, clonedEntity, attributeUpdateList);
      crmService.Update(clonedEntity);
      new SetStateRequest().EntityMoniker = clonedEntity.ToEntityReference();
      return clonedEntity;
    }

    public static void CloneRelatedRecords(
      FrameworkService crmService,
      string relatedEntityToClone,
      string referenceField,
      EntityReference originalEntityReference,
      EntityReference clonedEntityReference)
    {
      CloneLibrary.CloneRelatedRecords(crmService, relatedEntityToClone, referenceField, originalEntityReference, clonedEntityReference, (string) null, (EntityReference) null);
    }

    public static void CloneRelatedRecords(
      FrameworkService crmService,
      string relatedEntityToClone,
      string referenceField,
      EntityReference originalEntityReference,
      EntityReference clonedEntityReference,
      string skipField,
      EntityReference skipFieldReference)
    {
      if (originalEntityReference == null || clonedEntityReference == null)
        return;
      EntityCollection referencedEntities = EntityLibrary.GetAllReferencedEntities((IOrganizationService) crmService, relatedEntityToClone, referenceField, originalEntityReference, true);
      crmService.Trace("Cloning {0} related {1} records", (object) ((Collection<Entity>) referencedEntities.Entities).Count, (object) relatedEntityToClone);
      foreach (Entity entity in (Collection<Entity>) referencedEntities.Entities)
      {
        if (string.IsNullOrEmpty(skipField) || !string.IsNullOrEmpty(skipField) && !((DataCollection<string, object>) entity.Attributes).ContainsKey(skipField) || !string.IsNullOrEmpty(skipField) && ((DataCollection<string, object>) entity.Attributes).ContainsKey(skipField) && !AttributeLibrary.Compare((EntityReference) entity[skipField], skipFieldReference))
        {
          entity[referenceField] = (object) clonedEntityReference;
          CloneLibrary.CloneEntity((IOrganizationService) crmService, entity, (Dictionary<string, object>) null);
        }
      }
    }

    public static bool CopyEntityAttributes(
      Entity originalEntity,
      Entity clonedEntity,
      Dictionary<string, object> attributeUpdateList)
    {
      string[] attributesToSkipIn = new string[0];
      return CloneLibrary.CopyEntityAttributes(originalEntity, clonedEntity, attributeUpdateList, attributesToSkipIn);
    }

    public static bool CopyEntityAttributes(
      Entity originalEntity,
      Entity clonedEntity,
      Dictionary<string, object> attributeUpdateList,
      string[] attributesToSkipIn)
    {
      bool flag1 = false;
      string[] source = new string[8]
      {
        "state",
        "statecode",
        "status",
        "createdby",
        "createdon",
        "modifiedby",
        "modifiedon",
        "activityid"
      };
      string str1 = originalEntity.LogicalName + "id";
      foreach (string key in (IEnumerable<string>) ((DataCollection<string, object>) originalEntity.Attributes).Keys)
      {
        string lower = key.ToLower();
        bool flag2 = false;
        if (!(lower == "id") && !(lower == str1) && !((IEnumerable<string>) source).Contains<string>(lower) && (attributesToSkipIn == null || !((IEnumerable<string>) attributesToSkipIn).Contains<string>(lower)))
        {
          object compareTo = ((DataCollection<string, object>) originalEntity.Attributes)[key];
          if (attributeUpdateList != null && attributeUpdateList.ContainsKey(key))
            compareTo = attributeUpdateList[key];
          if (((DataCollection<string, object>) clonedEntity.Attributes).ContainsKey(key))
            flag2 = AttributeLibrary.Compare(clonedEntity[key], compareTo);
          if (!flag2)
          {
            flag1 = true;
            clonedEntity[key] = compareTo;
          }
        }
      }
      foreach (string str2 in ((DataCollection<string, object>) clonedEntity.Attributes).Keys.ToArray<string>())
      {
        if (!((DataCollection<string, object>) originalEntity.Attributes).ContainsKey(str2))
          clonedEntity[str2] = (object) null;
      }
      return flag1;
    }
  }
}
