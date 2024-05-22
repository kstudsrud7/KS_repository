// Decompiled with JetBrains decompiler
// Type: ArcticIT.Framework.Libraries.RelatedEntityNNLibrary
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.Framework.Libraries
{
  public class RelatedEntityNNLibrary
  {
    public static EntityReference GetReference(
      FrameworkService crmService,
      string entityLogicalName)
    {
      EntityReference reference = (EntityReference) null;
      if (((DataCollection<string, object>) ((IExecutionContext) crmService.PluginContext).InputParameters).Keys.Contains("Target"))
      {
        object inputParameter = ((DataCollection<string, object>) ((IExecutionContext) crmService.PluginContext).InputParameters)["Target"];
        EntityReference entityReference = (EntityReference) null;
        if (inputParameter != null)
        {
          if (inputParameter is EntityReference)
            entityReference = (EntityReference) inputParameter;
          if (inputParameter is Entity)
            entityReference = ((Entity) inputParameter).ToEntityReference();
        }
        if (entityReference != null && entityReference.LogicalName == entityLogicalName)
          reference = entityReference;
      }
      if (reference == null && ((DataCollection<string, object>) ((IExecutionContext) crmService.PluginContext).InputParameters).Keys.Contains("RelatedEntities"))
      {
        foreach (EntityReference entityReference in (Collection<EntityReference>) ((DataCollection<string, object>) ((IExecutionContext) crmService.PluginContext).InputParameters)["RelatedEntities"])
        {
          if (entityReference.LogicalName == entityLogicalName)
          {
            reference = entityReference;
            break;
          }
        }
      }
      return reference;
    }

    public static Entity GetEntity(FrameworkService crmService, string entityLogicalName)
    {
      EntityReference reference = RelatedEntityNNLibrary.GetReference(crmService, entityLogicalName);
      return EntityLibrary.GetEntity((IOrganizationService) crmService, reference);
    }

    public static int UpdateAssociationListAttribute(
      FrameworkService crmService,
      string updateEntityLogicalName,
      string updateEntityAttribute,
      string fromEntityLogicalName,
      string fromAttributeName,
      string toAttributeName,
      string linkToEntityName,
      string orderAttribute)
    {
      return RelatedEntityNNLibrary.UpdateAssociationListAttribute(crmService, updateEntityLogicalName, updateEntityAttribute, (string) null, fromEntityLogicalName, fromAttributeName, toAttributeName, linkToEntityName, orderAttribute, (Func<Entity, string>) null);
    }

    public static int UpdateAssociationListAttribute(
      FrameworkService crmService,
      string updateEntityLogicalName,
      string updateEntityAttribute,
      string updateEntityCountAttribute,
      string fromEntityLogicalName,
      string fromAttributeName,
      string toAttributeName,
      string linkToEntityName,
      string orderAttribute,
      Func<Entity, string> methodEntityName)
    {
      int listCount = -1;
      Entity entity1 = RelatedEntityNNLibrary.GetEntity(crmService, updateEntityLogicalName);
      string empty = string.Empty;
      if (entity1 == null)
        return listCount;
      string associationList = RelatedEntityNNLibrary.GetAssociationList(crmService, fromEntityLogicalName, fromAttributeName, toAttributeName, linkToEntityName, orderAttribute, entity1.ToEntityReference(), out listCount, methodEntityName);
      Entity entity2 = new Entity();
      entity2.LogicalName = updateEntityLogicalName;
      entity2.Id = entity1.Id;
      bool flag = false;
      if (!((DataCollection<string, object>) entity1.Attributes).ContainsKey(updateEntityAttribute) || (string) entity1[updateEntityAttribute] != associationList)
      {
        entity2[updateEntityAttribute] = (object) associationList;
        flag = true;
      }
      if (!string.IsNullOrEmpty(updateEntityCountAttribute) && listCount >= 0 && (!((DataCollection<string, object>) entity1.Attributes).ContainsKey(updateEntityCountAttribute) || (int) entity1[updateEntityCountAttribute] != listCount))
      {
        entity2[updateEntityCountAttribute] = (object) listCount;
        flag = true;
      }
      if (flag)
        crmService.Update(entity2);
      return listCount;
    }

    public static string GetAssociationList(
      FrameworkService crmService,
      string fromEntityLogicalName,
      string fromAttributeName,
      string toAttributeName,
      string linkToEntityName,
      string orderAttribute,
      EntityReference associationEntityReference,
      out int listCount)
    {
      return RelatedEntityNNLibrary.GetAssociationList(crmService, fromEntityLogicalName, fromAttributeName, toAttributeName, linkToEntityName, orderAttribute, associationEntityReference, out listCount, (Func<Entity, string>) null);
    }

    public static string GetAssociationList(
      FrameworkService crmService,
      string fromEntityLogicalName,
      string fromAttributeName,
      string toAttributeName,
      string linkToEntityName,
      string orderAttribute,
      EntityReference associationEntityReference,
      out int listCount,
      Func<Entity, string> methodEntityName)
    {
      string empty = string.Empty;
      listCount = -1;
      if (associationEntityReference == null)
        return empty;
      EntityCollection associatedEntities = EntityLibrary.GetAssociatedEntities((IOrganizationService) crmService, fromEntityLogicalName, fromAttributeName, toAttributeName, linkToEntityName, orderAttribute, associationEntityReference);
      if (associatedEntities != null && associatedEntities.Entities != null)
      {
        listCount = ((Collection<Entity>) associatedEntities.Entities).Count;
        foreach (Entity entity in (Collection<Entity>) associatedEntities.Entities)
        {
          if (!string.IsNullOrEmpty(empty))
            empty += "; ";
          string str = (string) entity[orderAttribute];
          if (methodEntityName != null)
            str = methodEntityName(entity);
          empty += str;
        }
      }
      return empty;
    }
  }
}
