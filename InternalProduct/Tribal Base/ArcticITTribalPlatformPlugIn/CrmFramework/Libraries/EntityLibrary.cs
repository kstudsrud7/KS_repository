// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.EntityLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.ServiceModel;
using System.Text;
using System.Xml;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  internal class EntityLibrary
  {
    public static Entity GetEntity(
      IOrganizationService crmService,
      string entityLogicalName,
      Guid id)
    {
      EntityReference entityReference = new EntityReference(entityLogicalName, id);
      return EntityLibrary.GetEntity(crmService, entityReference, false);
    }

    public static Entity GetEntity(IOrganizationService crmService, EntityReference entityReference)
    {
      return EntityLibrary.GetEntity(crmService, entityReference, false);
    }

    public static Entity GetEntity(
      IOrganizationService crmService,
      EntityReference entityReference,
      bool throwIfNotFound)
    {
      if (throwIfNotFound && entityReference == null)
        throw new ArgumentNullException("Entity reference can not be null.");
      if (entityReference == null)
        return (Entity) null;
      ColumnSet columnSet = new ColumnSet(true);
      Entity entity = (Entity) null;
      try
      {
        entity = crmService.Retrieve(entityReference.LogicalName, entityReference.Id, columnSet);
      }
      catch (FaultException ex)
      {
        if (!ex.Message.ToLower().Contains("does not exist"))
          throw;
      }
      return !throwIfNotFound || entity != null ? entity : throw new PluginException("Entity could not be found of type: " + entityReference.LogicalName);
    }

    public static Entity GetEntityImage(
      IOrganizationService crmService,
      EntityReference entityReference,
      bool throwIfNotFound)
    {
      if (throwIfNotFound && entityReference == null)
        throw new ArgumentNullException("Entity reference can not be null.");
      if (entityReference == null)
        return (Entity) null;
      ColumnSet columnSet = new ColumnSet(new string[1]
      {
        "entityimage"
      });
      Entity entity = (Entity) null;
      try
      {
        entity = crmService.Retrieve(entityReference.LogicalName, entityReference.Id, columnSet);
      }
      catch (FaultException ex)
      {
        if (!ex.Message.ToLower().Contains("does not exist"))
          throw;
      }
      return !throwIfNotFound || entity != null ? entity : throw new PluginException("Entity could not be found of type: " + entityReference.LogicalName);
    }

    public static Entity GetEntityByName(
      IOrganizationService crmService,
      string entityLogicalName,
      string name)
    {
      Entity entityByName = (Entity) null;
      QueryExpression queryExpression = new QueryExpression(entityLogicalName)
      {
        ColumnSet = new ColumnSet(true)
      };
      FilterExpression activeFilter = EntityLibrary.GetActiveFilter();
      activeFilter.AddCondition("ait_name", (ConditionOperator) 0, new object[1]
      {
        (object) name
      });
      queryExpression.Criteria = activeFilter;
      EntityCollection entityCollection = crmService.RetrieveMultiple((QueryBase) queryExpression);
      if (((Collection<Entity>) entityCollection.Entities).Count > 0)
        entityByName = ((Collection<Entity>) entityCollection.Entities)[0];
      return entityByName;
    }

    public static Entity GetFirstEntity(
      IOrganizationService crmService,
      string entityLogicalName,
      string referenceField,
      object referenceId,
      bool activeOnly)
    {
      Entity firstEntity = (Entity) null;
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, entityLogicalName, referenceField, referenceId, activeOnly);
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
        firstEntity = ((Collection<Entity>) allEntities.Entities)[0];
      return firstEntity;
    }

    public static EntityCollection GetAllReferencedEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      string referenceField,
      EntityReference referencedBy,
      bool activeOnly)
    {
      return referencedBy == null ? new EntityCollection() : EntityLibrary.GetAllEntities(crmService, entityLogicalName, referenceField, (object) referencedBy.Id, activeOnly);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      string referenceField,
      object referenceId,
      bool activeOnly)
    {
      if (string.IsNullOrEmpty(referenceField))
        throw new ArgumentNullException(nameof (referenceField));
      object obj = referenceId;
      if (referenceId is EntityReference)
        obj = (object) ((EntityReference) referenceId).Id;
      ConditionExpression condition = new ConditionExpression(referenceField, (ConditionOperator) 0, obj);
      return EntityLibrary.GetAllEntities(crmService, entityLogicalName, condition, activeOnly);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      ConditionExpression condition,
      bool activeOnly)
    {
      return EntityLibrary.GetAllEntities(crmService, entityLogicalName, new List<ConditionExpression>()
      {
        condition
      }, activeOnly);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      List<ConditionExpression> conditions,
      bool activeOnly)
    {
      return EntityLibrary.GetAllEntities(crmService, entityLogicalName, conditions, "", activeOnly);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      bool activeOnly,
      params FilterExpression[] filterExpressions)
    {
      return EntityLibrary.GetAllEntities(crmService, entityLogicalName, "", activeOnly, filterExpressions);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      string orderAttribute,
      bool activeOnly,
      params FilterExpression[] filterExpressions)
    {
      return EntityLibrary.GetAllEntities(crmService, entityLogicalName, orderAttribute, (OrderType) 0, activeOnly, filterExpressions);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      string orderAttribute,
      OrderType orderType,
      bool activeOnly,
      params FilterExpression[] filterExpressions)
    {
      FilterExpression filterExpression1 = new FilterExpression();
      QueryExpression queryExpression = new QueryExpression(entityLogicalName)
      {
        ColumnSet = new ColumnSet(true)
      };
      if (activeOnly)
      {
        FilterExpression activeFilter = EntityLibrary.GetActiveFilter();
        queryExpression.Criteria.AddFilter(activeFilter);
      }
      foreach (FilterExpression filterExpression2 in filterExpressions)
        queryExpression.Criteria.AddFilter(filterExpression2);
      if (!string.IsNullOrEmpty(orderAttribute))
        queryExpression.AddOrder(orderAttribute, orderType);
      return EntityLibrary.GetAllEntities(crmService, queryExpression);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      List<ConditionExpression> conditions,
      string orderAttribute,
      bool activeOnly)
    {
      return EntityLibrary.GetAllEntities(crmService, entityLogicalName, conditions, orderAttribute, (OrderType) 0, activeOnly);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      List<ConditionExpression> conditions,
      string orderAttribute,
      OrderType orderType,
      bool activeOnly)
    {
      QueryExpression queryExpression = new QueryExpression(entityLogicalName)
      {
        ColumnSet = new ColumnSet(true)
      };
      FilterExpression filterExpression = new FilterExpression();
      if (activeOnly)
        filterExpression = EntityLibrary.GetActiveFilter();
      foreach (ConditionExpression condition in conditions)
        filterExpression.AddCondition(condition);
      queryExpression.Criteria = filterExpression;
      if (!string.IsNullOrEmpty(orderAttribute))
        queryExpression.AddOrder(orderAttribute, orderType);
      return EntityLibrary.GetAllEntities(crmService, queryExpression);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      bool activeOnly)
    {
      QueryExpression queryExpression = new QueryExpression(entityLogicalName)
      {
        ColumnSet = new ColumnSet(true)
      };
      if (activeOnly)
        queryExpression.Criteria = EntityLibrary.GetActiveFilter();
      return EntityLibrary.GetAllEntities(crmService, queryExpression);
    }

    public static EntityCollection GetAllEntities(
      IOrganizationService crmService,
      QueryExpression queryExpression)
    {
      return crmService.RetrieveMultiple((QueryBase) queryExpression);
    }

    public static EntityCollection GetAllEntitiesUnlimited(
      IOrganizationService crmService,
      string entityLogicalName,
      List<ConditionExpression> conditions,
      bool activeOnly)
    {
      EntityCollection entitiesUnlimited = new EntityCollection();
      int num1 = 4800;
      int num2 = 1;
      int num3 = 0;
      QueryExpression queryExpression = new QueryExpression(entityLogicalName)
      {
        ColumnSet = new ColumnSet(true)
      };
      FilterExpression filterExpression = new FilterExpression();
      if (activeOnly)
        filterExpression = EntityLibrary.GetActiveFilter();
      foreach (ConditionExpression condition in conditions)
        filterExpression.AddCondition(condition);
      queryExpression.Criteria = filterExpression;
      queryExpression.PageInfo = new PagingInfo();
      queryExpression.PageInfo.Count = num1;
      queryExpression.PageInfo.PageNumber = num2;
      queryExpression.PageInfo.PagingCookie = (string) null;
      while (true)
      {
        EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, queryExpression);
        if (allEntities != null)
        {
          entitiesUnlimited.Entities.AddRange((IEnumerable<Entity>) allEntities.Entities);
          num3 += ((Collection<Entity>) allEntities.Entities).Count;
          if (allEntities.MoreRecords)
          {
            ++queryExpression.PageInfo.PageNumber;
            queryExpression.PageInfo.PagingCookie = allEntities.PagingCookie;
          }
          else
            break;
        }
        else
          break;
      }
      return entitiesUnlimited;
    }

    public static EntityCollection GetAllEntitiesUnlimited(
      IOrganizationService crmService,
      string entityLogicalName,
      List<ConditionExpression> conditions,
      bool activeOnly,
      ColumnSet columnSet,
      string orderAttribute,
      OrderType orderType)
    {
      EntityCollection entitiesUnlimited = new EntityCollection();
      int num1 = 4800;
      int num2 = 1;
      int num3 = 0;
      QueryExpression queryExpression = new QueryExpression(entityLogicalName)
      {
        ColumnSet = columnSet
      };
      FilterExpression filterExpression = new FilterExpression();
      if (activeOnly)
        filterExpression = EntityLibrary.GetActiveFilter();
      foreach (ConditionExpression condition in conditions)
        filterExpression.AddCondition(condition);
      queryExpression.Criteria = filterExpression;
      queryExpression.PageInfo = new PagingInfo();
      queryExpression.PageInfo.Count = num1;
      queryExpression.PageInfo.PageNumber = num2;
      queryExpression.PageInfo.PagingCookie = (string) null;
      queryExpression.AddOrder(orderAttribute, orderType);
      while (true)
      {
        EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, queryExpression);
        if (allEntities != null)
        {
          entitiesUnlimited.Entities.AddRange((IEnumerable<Entity>) allEntities.Entities);
          num3 += ((Collection<Entity>) allEntities.Entities).Count;
          if (allEntities.MoreRecords)
          {
            ++queryExpression.PageInfo.PageNumber;
            queryExpression.PageInfo.PagingCookie = allEntities.PagingCookie;
          }
          else
            break;
        }
        else
          break;
      }
      return entitiesUnlimited;
    }

    public static EntityCollection GetAssociatedEntities(
      IOrganizationService crmService,
      string fromEntityLogicalName,
      string fromAttributeName,
      string toAttributeName,
      string linkToEntityName,
      string orderAttribute,
      EntityReference relationshipReference)
    {
      Guid id = relationshipReference.Id;
      QueryExpression queryExpression1 = new QueryExpression();
      queryExpression1.EntityName = fromEntityLogicalName;
      queryExpression1.ColumnSet = new ColumnSet(true);
      DataCollection<LinkEntity> linkEntities = queryExpression1.LinkEntities;
      LinkEntity linkEntity = new LinkEntity();
      linkEntity.Columns = new ColumnSet(true);
      linkEntity.LinkFromEntityName = fromEntityLogicalName;
      linkEntity.LinkFromAttributeName = fromAttributeName;
      linkEntity.LinkToEntityName = linkToEntityName;
      linkEntity.LinkToAttributeName = fromAttributeName;
      FilterExpression filterExpression = new FilterExpression();
      filterExpression.FilterOperator = (LogicalOperator) 0;
      DataCollection<ConditionExpression> conditions = filterExpression.Conditions;
      ConditionExpression conditionExpression = new ConditionExpression();
      conditionExpression.AttributeName = toAttributeName;
      conditionExpression.Operator = (ConditionOperator) 0;
      ((Collection<object>) conditionExpression.Values).Add((object) id);
      ((Collection<ConditionExpression>) conditions).Add(conditionExpression);
      linkEntity.LinkCriteria = filterExpression;
      ((Collection<LinkEntity>) linkEntities).Add(linkEntity);
      QueryExpression queryExpression2 = queryExpression1;
      if (!string.IsNullOrEmpty(orderAttribute))
        queryExpression2.AddOrder(orderAttribute, (OrderType) 0);
      return EntityLibrary.GetAllEntities(crmService, queryExpression2);
    }

    public static void DeleteAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      EntityReference regarding)
    {
      QueryExpression queryExpression = new QueryExpression(entityLogicalName)
      {
        ColumnSet = new ColumnSet()
      };
      FilterExpression filterExpression = new FilterExpression();
      if (regarding != null)
        filterExpression.AddCondition("regardingobjectid", (ConditionOperator) 0, new object[1]
        {
          (object) regarding.Id
        });
      queryExpression.Criteria = filterExpression;
      EntityLibrary.DeleteAllEntities(crmService, queryExpression);
    }

    public static void DeleteAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      string referenceField,
      object referenceId)
    {
      if (string.IsNullOrEmpty(referenceField))
        throw new ArgumentNullException(nameof (referenceField));
      object obj = referenceId;
      if (referenceId is EntityReference)
        obj = (object) ((EntityReference) referenceId).Id;
      ConditionExpression condition = new ConditionExpression(referenceField, (ConditionOperator) 0, obj);
      EntityLibrary.DeleteAllEntities(crmService, entityLogicalName, condition);
    }

    public static void DeleteAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      ConditionExpression condition)
    {
      EntityLibrary.DeleteAllEntities(crmService, entityLogicalName, new List<ConditionExpression>()
      {
        condition
      });
    }

    public static void DeleteAllEntities(
      IOrganizationService crmService,
      string entityLogicalName,
      List<ConditionExpression> conditions)
    {
      QueryExpression queryExpression = new QueryExpression(entityLogicalName)
      {
        ColumnSet = new ColumnSet(true)
      };
      FilterExpression filterExpression = new FilterExpression();
      foreach (ConditionExpression condition in conditions)
        filterExpression.AddCondition(condition);
      queryExpression.Criteria = filterExpression;
      EntityLibrary.DeleteAllEntities(crmService, queryExpression);
    }

    public static void DeleteAllEntities(
      IOrganizationService crmService,
      QueryExpression queryExpression)
    {
      foreach (Entity entity in (Collection<Entity>) crmService.RetrieveMultiple((QueryBase) queryExpression).Entities)
        crmService.Delete(entity.LogicalName, entity.Id);
    }

    public static void CreateAssociation(
      IOrganizationService crmService,
      string entityLogicalName,
      EntityReference targetReference,
      EntityReference relatedReference)
    {
      AssociateRequest associateRequest1 = new AssociateRequest();
      associateRequest1.Target = targetReference;
      EntityReferenceCollection referenceCollection = new EntityReferenceCollection();
      ((Collection<EntityReference>) referenceCollection).Add(relatedReference);
      associateRequest1.RelatedEntities = referenceCollection;
      associateRequest1.Relationship = new Relationship(entityLogicalName);
      AssociateRequest associateRequest2 = associateRequest1;
      crmService.Execute((OrganizationRequest) associateRequest2);
    }

    public static string GetEntityName(
      IOrganizationService crmService,
      EntityReference entityReference)
    {
      return EntityLibrary.GetEntityName(crmService, entityReference, false);
    }

    public static string GetEntityName(
      IOrganizationService crmService,
      EntityReference entityReference,
      bool throwIfNotFound)
    {
      if (entityReference == null && !throwIfNotFound)
        return string.Empty;
      string entityName = entityReference.Name;
      if (string.IsNullOrEmpty(entityName))
        entityName = EntityLibrary.GetEntityName(EntityLibrary.GetEntity(crmService, entityReference, throwIfNotFound));
      return entityName;
    }

    public static string GetEntityName(Entity entity)
    {
      string entityName = "";
      if (entity != null)
      {
        object obj = (((ObjectLibrary.GetPropertyValue((object) entity, "Title", false) ?? ObjectLibrary.GetPropertyValue((object) entity, "ait_name", false)) ?? ObjectLibrary.GetPropertyValue((object) entity, "ait_name", false)) ?? ObjectLibrary.GetPropertyValue((object) entity, "FullName", false)) ?? ObjectLibrary.GetPropertyValue((object) entity, "Name", false);
        if (obj != null)
          entityName = (string) obj;
      }
      return entityName;
    }

    public static FilterExpression GetActiveFilter()
    {
      FilterExpression activeFilter = new FilterExpression();
      activeFilter.AddCondition("statecode", (ConditionOperator) 0, new object[1]
      {
        (object) 0
      });
      return activeFilter;
    }

    public static void SetEntityChildrensState(
      IOrganizationService crmService,
      EntityReference parentEntityReference,
      string childEntityLogicalName,
      string childEntityParentAttribute,
      int? stateCode,
      OptionSetValue statusCode)
    {
      if (!stateCode.HasValue || !stateCode.HasValue || statusCode == null)
        return;
      EntityLibrary.SetEntityChildrensState(crmService, parentEntityReference, childEntityLogicalName, childEntityParentAttribute, stateCode.Value, statusCode.Value);
    }

    public static void SetEntityChildrensState(
      IOrganizationService crmService,
      EntityReference parentEntityReference,
      string childEntityLogicalName,
      string childEntityParentAttribute,
      int stateCode,
      int statusCode)
    {
      EntityCollection referencedEntities = EntityLibrary.GetAllReferencedEntities(crmService, childEntityLogicalName, childEntityParentAttribute, parentEntityReference, false);
      if (referencedEntities == null || ((Collection<Entity>) referencedEntities.Entities).Count <= 0)
        return;
      foreach (Entity entity in (Collection<Entity>) referencedEntities.Entities)
      {
        OptionSetValue original1 = (OptionSetValue) entity["statecode"];
        OptionSetValue original2 = (OptionSetValue) entity["statuscode"];
        if (!AttributeLibrary.Compare(original1, stateCode) || !AttributeLibrary.Compare(original2, statusCode))
          EntityLibrary.SetEntityState(crmService, entity.ToEntityReference(), stateCode, statusCode);
      }
    }

    public static SetStateResponse SetEntityState(
      IOrganizationService crmService,
      EntityReference entityToChange,
      int stateCode,
      int statusCode)
    {
      if (statusCode < 0)
        throw new ArgumentException("statusCode cannot be less than zero.", nameof (statusCode));
      if (stateCode < 0)
        throw new ArgumentException("stateCode cannot be less than zero.", nameof (stateCode));
      SetStateRequest setStateRequest = new SetStateRequest();
      setStateRequest.EntityMoniker = entityToChange;
      setStateRequest.State = new OptionSetValue(stateCode);
      if (statusCode >= 0)
        setStateRequest.Status = new OptionSetValue(statusCode);
      return (SetStateResponse) crmService.Execute((OrganizationRequest) setStateRequest);
    }

    public static void RemoveAttributes(Entity entity, string[] attributeList)
    {
      if (entity == null || attributeList == null)
        return;
      foreach (string attribute in attributeList)
      {
        if (((DataCollection<string, object>) entity.Attributes).ContainsKey(attribute))
          ((DataCollection<string, object>) entity.Attributes).Remove(attribute);
      }
    }

    public static string TruncateToMaxLengthOfString(
      IOrganizationService crmService,
      string formattedName,
      string entityName,
      string attributeName)
    {
      if (string.IsNullOrEmpty(formattedName))
        return formattedName;
      int length = EntityLibrary.AttributeStringLength(crmService, entityName, attributeName);
      return formattedName.Length > length ? formattedName.Substring(0, length) : formattedName;
    }

    public static int AttributeStringLength(
      IOrganizationService crmService,
      string entityName,
      string attributeName)
    {
      RetrieveAttributeRequest attributeRequest = new RetrieveAttributeRequest()
      {
        EntityLogicalName = entityName,
        LogicalName = attributeName
      };
      return ((StringAttributeMetadata) ((RetrieveAttributeResponse) crmService.Execute((OrganizationRequest) attributeRequest)).AttributeMetadata).MaxLength.Value;
    }

    public static DataCollection<Entity> FetchAllRecords(
      string fetchxml,
      IOrganizationService CrmService,
      int pageLimit,
      int pageCount)
    {
      if (pageCount > 5000)
        pageCount = 5000;
      int page = 1;
      string cookie = string.Empty;
      bool flag = false;
      DataCollection<Entity> dataCollection = (DataCollection<Entity>) null;
      while (!flag && (pageLimit == 0 || page <= pageLimit))
      {
        EntityCollection entityCollection = EntityLibrary.FetchDataSet(EntityLibrary.CreateXml(fetchxml, cookie, page, pageCount), CrmService);
        cookie = entityCollection.PagingCookie;
        if (page == 1)
          dataCollection = entityCollection.Entities;
        else
          dataCollection.AddRange((IEnumerable<Entity>) entityCollection.Entities);
        if (!entityCollection.MoreRecords)
          flag = true;
        else
          ++page;
      }
      return dataCollection;
    }

    private static string CreateXml(string xml, string cookie, int page, int count)
    {
      XmlTextReader reader = new XmlTextReader((TextReader) new StringReader(xml));
      XmlDocument doc = new XmlDocument();
      doc.Load((XmlReader) reader);
      return EntityLibrary.CreateXml(doc, cookie, page, count);
    }

    private static string CreateXml(XmlDocument doc, string cookie, int page, int count)
    {
      XmlAttributeCollection attributes = doc.DocumentElement.Attributes;
      if (cookie != null)
      {
        XmlAttribute attribute = doc.CreateAttribute("paging-cookie");
        attribute.Value = cookie;
        attributes.Append(attribute);
      }
      XmlAttribute attribute1 = doc.CreateAttribute(nameof (page));
      attribute1.Value = Convert.ToString(page);
      attributes.Append(attribute1);
      XmlAttribute attribute2 = doc.CreateAttribute(nameof (count));
      attribute2.Value = Convert.ToString(count);
      attributes.Append(attribute2);
      StringBuilder sb = new StringBuilder(1024);
      XmlTextWriter w = new XmlTextWriter((TextWriter) new StringWriter(sb));
      doc.WriteTo((XmlWriter) w);
      w.Close();
      return sb.ToString();
    }

    private static EntityCollection FetchDataSet(string fetchXml, IOrganizationService CrmService)
    {
      FetchExpression fetchExpression = new FetchExpression(fetchXml);
      return CrmService.RetrieveMultiple((QueryBase) fetchExpression);
    }
  }
}
