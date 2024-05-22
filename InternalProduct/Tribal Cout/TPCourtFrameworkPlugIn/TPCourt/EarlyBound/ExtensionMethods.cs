// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.ExtensionMethods
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

#nullable disable
namespace TPCourt.EarlyBound
{
  public static class ExtensionMethods
  {
    public static bool RetrieveAllPages = true;
    private static Dictionary<string, Dictionary<Guid, Entity>> _cachedEntities = new Dictionary<string, Dictionary<Guid, Entity>>();

    public static Guid Create(this IOrganizationService service, BaseProxyClass proxy)
    {
      proxy.Id = service.Create((Entity) proxy);
      return proxy.Id;
    }

    public static void Update(this IOrganizationService service, BaseProxyClass proxy)
    {
      proxy.Update(service);
    }

    public static void Delete(this IOrganizationService service, BaseProxyClass proxy)
    {
      service.Delete(proxy.LogicalName, proxy.Id);
    }

    public static void SetState(
      this IOrganizationService service,
      BaseProxyClass proxy,
      int state,
      int status)
    {
      service.SetState(proxy, new OptionSetValue(state), new OptionSetValue(status));
    }

    public static void SetState(
      this IOrganizationService service,
      BaseProxyClass proxy,
      OptionSetValue state,
      OptionSetValue status)
    {
      SetStateRequest setStateRequest = new SetStateRequest()
      {
        EntityMoniker = (EntityReference) proxy,
        State = state,
        Status = status
      };
      service.Execute((OrganizationRequest) setStateRequest);
    }

    public static async Task<Guid> CreateAsync(this IOrganizationService service, Entity entity)
    {
      Guid async = await Task.Run<Guid>((Func<Guid>) (() =>
      {
        entity.Id = service.Create(entity);
        return entity.Id;
      }));
      return async;
    }

    public static async Task UpdateAsync(this IOrganizationService service, Entity entity)
    {
      await Task.Run((Action) (() => service.Update(entity)));
    }

    public static async Task DeleteAsync(this IOrganizationService service, Entity entity)
    {
      await service.DeleteAsync(entity.LogicalName, entity.Id);
    }

    public static async Task<OrganizationResponse> ExecuteAsync(
      this IOrganizationService service,
      OrganizationRequest request)
    {
      OrganizationResponse organizationResponse = await Task.Run<OrganizationResponse>((Func<OrganizationResponse>) (() => service.Execute(request)));
      return organizationResponse;
    }

    public static async Task SetStateAsync(
      this IOrganizationService service,
      BaseProxyClass proxy,
      int state,
      int status)
    {
      await service.SetStateAsync(proxy, new OptionSetValue(state), new OptionSetValue(status));
    }

    public static async Task SetStateAsync(
      this IOrganizationService service,
      BaseProxyClass proxy,
      OptionSetValue state,
      OptionSetValue status)
    {
      SetStateRequest request = new SetStateRequest()
      {
        EntityMoniker = (EntityReference) proxy,
        State = state,
        Status = status
      };
      OrganizationResponse organizationResponse = await service.ExecuteAsync((OrganizationRequest) request);
      request = (SetStateRequest) null;
    }

    public static T ToProxy<T>(this EntityReference reference) where T : BaseProxyClass
    {
      return reference == null ? default (T) : reference.ToEntity().ToProxy<T>();
    }

    public static Entity ToEntity(this EntityReference reference)
    {
      if (reference == null)
        return (Entity) null;
      return new Entity()
      {
        LogicalName = reference.LogicalName,
        Id = reference.Id
      };
    }

    public static T ToProxy<T>(this Entity entity) where T : BaseProxyClass
    {
      if (entity == null)
        return default (T);
      ConstructorInfo constructor = typeof (T).GetConstructor(new Type[1]
      {
        typeof (Entity)
      });
      return entity.ToProxy<T>(constructor);
    }

    private static T ToProxy<T>(this Entity entity, ConstructorInfo construcor) where T : BaseProxyClass
    {
      return construcor.Invoke(new object[1]
      {
        (object) entity
      }) as T;
    }

    public static AttributeMetadata GetAttributeMetadata(
      this IOrganizationService service,
      string entityLogicalName,
      string attributeLogicalName)
    {
      RetrieveAttributeRequest attributeRequest = new RetrieveAttributeRequest()
      {
        EntityLogicalName = entityLogicalName,
        LogicalName = attributeLogicalName
      };
      return (service.Execute((OrganizationRequest) attributeRequest) as RetrieveAttributeResponse).AttributeMetadata;
    }

    public static OptionMetadata GetOptionMetadata(
      this OptionSetValue value,
      IOrganizationService service,
      BaseProxyClass entity,
      string attributeLogicalName)
    {
      AttributeMetadata attributeMetadata = service.GetAttributeMetadata(entity.LogicalName, attributeLogicalName);
      if (attributeMetadata is EnumAttributeMetadata)
        return ((EnumAttributeMetadata) attributeMetadata).GetOptionMetadata(value.Value);
      throw new Exception("The attribute is not an Enum type attribute");
    }

    public static OptionMetadata GetOptionMetadata(this EnumAttributeMetadata enumMeta, int value)
    {
      return ((IEnumerable<OptionMetadata>) enumMeta.OptionSet.Options).Where<OptionMetadata>((Func<OptionMetadata, bool>) (meta =>
      {
        int? nullable = meta.Value;
        int num = value;
        return nullable.GetValueOrDefault() == num & nullable.HasValue;
      })).FirstOrDefault<OptionMetadata>();
    }

    public static string GetOptionSetText(this EnumAttributeMetadata enumMeta, int value)
    {
      return enumMeta.GetOptionMetadata(value).GetOptionSetText();
    }

    public static string GetOptionSetText(
      this OptionSetValue value,
      IOrganizationService service,
      BaseProxyClass entity,
      string attributeLogicalName)
    {
      return value.GetOptionMetadata(service, entity, attributeLogicalName).GetOptionSetText();
    }

    public static string GetOptionSetText(this OptionMetadata optionMeta)
    {
      return optionMeta != null && optionMeta.Label != null && optionMeta.Label.UserLocalizedLabel != null ? optionMeta.Label.UserLocalizedLabel.Label : string.Empty;
    }

    public static List<T> RetrieveProxies<T>(
      this IOrganizationService service,
      ConditionExpression expression,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      FilterExpression expression1 = new FilterExpression();
      expression1.AddCondition(expression);
      return service.RetrieveProxies<T>(expression1, columns);
    }

    public static List<T> RetrieveProxies<T>(
      this IOrganizationService service,
      FilterExpression expression,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      QueryExpression query = new QueryExpression(BaseProxyClass.GetLogicalName<T>())
      {
        ColumnSet = columns,
        Criteria = expression
      };
      return service.RetrieveProxies<T>(query);
    }

    public static List<T> RetrieveProxies<T>(
      this IOrganizationService service,
      params string[] columns)
      where T : BaseProxyClass
    {
      return service.RetrieveProxies<T>(ExtensionMethods.GetColumnSet(columns));
    }

    public static List<T> RetrieveProxies<T>(this IOrganizationService service, ColumnSet columns) where T : BaseProxyClass
    {
      QueryExpression query = new QueryExpression(BaseProxyClass.GetLogicalName<T>())
      {
        ColumnSet = columns
      };
      return service.RetrieveProxies<T>(query);
    }

    public static List<T> RetrieveProxies<T>(
      this IOrganizationService service,
      QueryExpression query)
      where T : BaseProxyClass
    {
      List<T> proxies = service.RetrieveMultipleAllPages(query).ToProxies<T>();
      ColumnSet columnSet = query.ColumnSet;
      if (columnSet != null && columnSet.AllColumns)
      {
        foreach (T obj in proxies)
          obj.AllColumnsRetrievedFromCrm = true;
      }
      return proxies;
    }

    public static List<T> ToProxies<T>(this EntityCollection entities) where T : BaseProxyClass
    {
      return ((IEnumerable<Entity>) entities.Entities).ToProxies<T>();
    }

    public static List<T> ToProxies<T>(this IEnumerable<Entity> entities) where T : BaseProxyClass
    {
      ConstructorInfo constructor = typeof (T).GetConstructor(new Type[1]
      {
        typeof (Entity)
      });
      return entities.Select<Entity, T>((Func<Entity, T>) (entity => entity.ToProxy<T>(constructor))).ToList<T>();
    }

    public static T RetrieveProxy<T>(
      this EntityReference entity,
      IOrganizationService service,
      params string[] columns)
      where T : BaseProxyClass
    {
      return service.RetrieveProxy<T>(entity.Id, columns);
    }

    public static T RetrieveProxy<T>(
      this EntityReference entity,
      IOrganizationService service,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      return service.RetrieveProxy<T>(entity.Id, columns);
    }

    public static T RetrieveProxy<T>(
      this IOrganizationService service,
      Guid Id,
      params string[] columns)
      where T : BaseProxyClass
    {
      return service.RetrieveProxy<T>(Id, ExtensionMethods.GetColumnSet(columns));
    }

    public static T RetrieveProxy<T>(this IOrganizationService service, Guid Id, ColumnSet columns) where T : BaseProxyClass
    {
      string logicalName = BaseProxyClass.GetLogicalName<T>();
      if (columns == null)
        columns = new ColumnSet(true);
      T proxy = service.Retrieve(logicalName, Id, columns).ToProxy<T>();
      if (columns.AllColumns)
        proxy.AllColumnsRetrievedFromCrm = true;
      return proxy;
    }

    public static T FindProxy<T>(
      this IOrganizationService service,
      string propertyName,
      object value,
      params string[] columns)
      where T : BaseProxyClass
    {
      return service.FindProxy<T>(propertyName, value, ExtensionMethods.GetColumnSet(columns));
    }

    public static T FindProxy<T>(
      this IOrganizationService service,
      string propertyName,
      object value,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      return service.FindProxies<T>(propertyName, value, columns).FirstOrDefault<T>();
    }

    public static T FindProxy<T>(
      this IOrganizationService service,
      string propertyName,
      ConditionOperator Operator,
      object value,
      params string[] columns)
      where T : BaseProxyClass
    {
      return service.FindProxy<T>(propertyName, Operator, value, ExtensionMethods.GetColumnSet(columns));
    }

    public static T FindProxy<T>(
      this IOrganizationService service,
      string propertyName,
      ConditionOperator Operator,
      object value,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      return service.FindProxies<T>(propertyName, Operator, value, columns).FirstOrDefault<T>();
    }

    public static List<T> FindProxies<T>(
      this IOrganizationService service,
      string propertyName,
      object value,
      params string[] columns)
      where T : BaseProxyClass
    {
      return service.FindProxies<T>(propertyName, value, ExtensionMethods.GetColumnSet(columns));
    }

    public static List<T> FindProxies<T>(
      this IOrganizationService service,
      string propertyName,
      object value,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      return service.FindProxies<T>(propertyName, (ConditionOperator) 0, value, columns);
    }

    public static List<T> FindProxies<T>(
      this IOrganizationService service,
      string propertyName,
      ConditionOperator @operator,
      object value,
      params string[] columns)
      where T : BaseProxyClass
    {
      return service.FindProxies<T>(propertyName, @operator, value, ExtensionMethods.GetColumnSet(columns));
    }

    public static List<T> FindProxies<T>(
      this IOrganizationService service,
      string propertyName,
      ConditionOperator @operator,
      object value,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      ConditionExpression expression = value != null ? new ConditionExpression(propertyName, @operator, value) : new ConditionExpression(propertyName, @operator);
      return service.RetrieveProxies<T>(expression, columns);
    }

    internal static ColumnSet GetColumnSet(params string[] columns)
    {
      ColumnSet columnSet = new ColumnSet(columns);
      if (!((IEnumerable<string>) columnSet.Columns).Any<string>())
        columnSet = new ColumnSet(true);
      return columnSet;
    }

    public static Entity RetrieveEntity(
      this EntityReference entity,
      IOrganizationService service,
      params string[] columns)
    {
      return entity.RetrieveEntity(service, ExtensionMethods.GetColumnSet(columns));
    }

    public static Entity RetrieveEntity(
      this EntityReference entity,
      IOrganizationService service,
      ColumnSet columns)
    {
      if (columns == null)
        columns = new ColumnSet(true);
      return service.Retrieve(entity.LogicalName, entity.Id, columns);
    }

    public static EntityCollection RetrieveMultiple(
      this IOrganizationService service,
      string logicalName,
      ConditionExpression condition,
      params string[] columns)
    {
      return service.RetrieveMultiple(logicalName, condition, ExtensionMethods.GetColumnSet(columns));
    }

    public static EntityCollection RetrieveMultiple(
      this IOrganizationService service,
      string logicalName,
      ConditionExpression condition,
      ColumnSet columns)
    {
      QueryExpression query = new QueryExpression(logicalName)
      {
        ColumnSet = columns
      };
      query.Criteria.AddCondition(condition);
      return service.RetrieveMultipleAllPages(query);
    }

    public static EntityCollection RetrieveMultipleAllPages(
      this IOrganizationService service,
      QueryExpression query)
    {
      if (query.PageInfo.PageNumber == 0)
        query.PageInfo.PageNumber = 1;
      EntityCollection entityCollection = service.RetrieveMultiple((QueryBase) query);
      while (entityCollection.MoreRecords && ExtensionMethods.RetrieveAllPages)
      {
        DataCollection<Entity> entities = entityCollection.Entities;
        query.PageInfo.PagingCookie = entityCollection.PagingCookie;
        ++query.PageInfo.PageNumber;
        entityCollection = service.RetrieveMultiple((QueryBase) query);
        entityCollection.Entities.AddRange((IEnumerable<Entity>) entities);
      }
      return entityCollection;
    }

    public static void RelateEntities(
      this IOrganizationService service,
      EntityReference target,
      string intermediateEntityName,
      IList<Entity> entities)
    {
      service.RelateEntities(target, intermediateEntityName, entities.ToArray<Entity>());
    }

    public static void RelateEntities(
      this IOrganizationService service,
      EntityReference target,
      string intermediateEntityName,
      params Entity[] entities)
    {
      List<EntityReference> list = ((IEnumerable<Entity>) entities).Select<Entity, EntityReference>((Func<Entity, EntityReference>) (EntityTemp => EntityTemp.ToEntityReference())).ToList<EntityReference>();
      service.RelateEntities(target, intermediateEntityName, (IList<EntityReference>) list);
    }

    public static void RelateEntities(
      this IOrganizationService service,
      EntityReference target,
      string intermediateEntityName,
      IList<EntityReference> entities)
    {
      service.RelateEntities(target, intermediateEntityName, entities.ToArray<EntityReference>());
    }

    public static void RelateEntities(
      this IOrganizationService service,
      EntityReference target,
      string intermediateEntityName,
      params EntityReference[] entities)
    {
      AssociateRequest associateRequest = new AssociateRequest()
      {
        Relationship = new Relationship(intermediateEntityName),
        Target = target
      };
      associateRequest.RelatedEntities = new EntityReferenceCollection((IList<EntityReference>) entities);
      service.Execute((OrganizationRequest) associateRequest);
    }

    public static void UnRelateEntities(
      this IOrganizationService service,
      EntityReference target,
      string intermediateEntityName,
      IList<Entity> entities)
    {
      service.UnRelateEntities(target, intermediateEntityName, entities.ToArray<Entity>());
    }

    public static void UnRelateEntities(
      this IOrganizationService service,
      EntityReference target,
      string intermediateEntityName,
      params Entity[] entities)
    {
      List<EntityReference> list = ((IEnumerable<Entity>) entities).Select<Entity, EntityReference>((Func<Entity, EntityReference>) (EntityTemp => EntityTemp.ToEntityReference())).ToList<EntityReference>();
      service.UnRelateEntities(target, intermediateEntityName, (IList<EntityReference>) list);
    }

    public static void UnRelateEntities(
      this IOrganizationService service,
      EntityReference target,
      string intermediateEntityName,
      IList<EntityReference> entities)
    {
      service.UnRelateEntities(target, intermediateEntityName, entities.ToArray<EntityReference>());
    }

    public static void UnRelateEntities(
      this IOrganizationService service,
      EntityReference target,
      string intermediateEntityName,
      params EntityReference[] entities)
    {
      DisassociateRequest disassociateRequest = new DisassociateRequest()
      {
        Target = target,
        Relationship = new Relationship(intermediateEntityName)
      };
      disassociateRequest.RelatedEntities = new EntityReferenceCollection((IList<EntityReference>) entities);
      service.Execute((OrganizationRequest) disassociateRequest);
    }

    public static void Add(this List<OrganizationRequest> requests, BaseProxyClass proxy)
    {
      OrganizationRequest organizationRequest = ExtensionMethods.GetOrganizationRequest(proxy);
      if (organizationRequest == null)
        return;
      requests.Add(organizationRequest);
    }

    public static void Add(this OrganizationRequestCollection collection, BaseProxyClass proxy)
    {
      OrganizationRequest organizationRequest = ExtensionMethods.GetOrganizationRequest(proxy);
      if (organizationRequest == null)
        return;
      ((Collection<OrganizationRequest>) collection).Add(organizationRequest);
    }

    public static OrganizationRequest GetOrganizationRequest(BaseProxyClass proxy)
    {
      if (proxy.Id != Guid.Empty && proxy.IsDirty)
        return (OrganizationRequest) new UpdateRequest()
        {
          Target = proxy.GetChangedEntity()
        };
      if (!(proxy.Id == Guid.Empty))
        return (OrganizationRequest) null;
      return (OrganizationRequest) new CreateRequest()
      {
        Target = (Entity) proxy
      };
    }

    public static void GrantAccess(
      this IAccessControlledEntity entity,
      IOrganizationService service,
      EntityReference principal,
      AccessRights accessMask)
    {
      GrantAccessRequest grantAccessRequest = new GrantAccessRequest()
      {
        PrincipalAccess = new PrincipalAccess()
        {
          Principal = principal,
          AccessMask = accessMask
        },
        Target = (EntityReference) entity
      };
      service.Execute((OrganizationRequest) grantAccessRequest);
    }

    public static void ModifyAccess(
      this IAccessControlledEntity entity,
      IOrganizationService service,
      EntityReference Principal,
      AccessRights AccessMask)
    {
      ModifyAccessRequest modifyAccessRequest = new ModifyAccessRequest()
      {
        PrincipalAccess = new PrincipalAccess()
        {
          Principal = Principal,
          AccessMask = AccessMask
        },
        Target = (EntityReference) entity
      };
      service.Execute((OrganizationRequest) modifyAccessRequest);
    }

    public static void RevokeAccess(
      this IAccessControlledEntity entity,
      IOrganizationService service,
      EntityReference revokee)
    {
      RevokeAccessRequest revokeAccessRequest = new RevokeAccessRequest()
      {
        Revokee = revokee,
        Target = (EntityReference) entity
      };
      service.Execute((OrganizationRequest) revokeAccessRequest);
    }

    public static void ClearCache(string entityLogicalName = null)
    {
      lock (ExtensionMethods._cachedEntities)
      {
        if (string.IsNullOrEmpty(entityLogicalName))
          return;
        if (ExtensionMethods._cachedEntities.ContainsKey(entityLogicalName))
          ExtensionMethods._cachedEntities[entityLogicalName] = new Dictionary<Guid, Entity>();
        else
          ExtensionMethods._cachedEntities.Clear();
      }
    }

    public static Entity RetrieveCachedEntityById(
      this IOrganizationService service,
      string entityLogicalName,
      Guid Id,
      ColumnSet columns)
    {
      lock (ExtensionMethods._cachedEntities)
      {
        Entity entity = ExtensionMethods.GetEntityFromCache(entityLogicalName, Id);
        if (entity == null)
        {
          entity = service.Retrieve(entityLogicalName, Id, columns);
          ExtensionMethods.AddEntityToCache(entity);
        }
        return entity;
      }
    }

    public static Entity GetEntityFromCache(
      this IOrganizationService service,
      string entityLogicalName,
      Guid id)
    {
      return ExtensionMethods.GetEntityFromCache(entityLogicalName, id);
    }

    public static Entity GetEntityFromCache(string entityLogicalName, Guid id)
    {
      lock (ExtensionMethods._cachedEntities)
      {
        Entity entityFromCache = (Entity) null;
        ExtensionMethods.GetEntitiesFromCache(entityLogicalName).TryGetValue(id, out entityFromCache);
        return entityFromCache;
      }
    }

    public static Dictionary<Guid, Entity> GetEntitiesFromCache(
      this IOrganizationService service,
      string entityLogicalName)
    {
      return ExtensionMethods.GetEntitiesFromCache(entityLogicalName);
    }

    public static Dictionary<Guid, Entity> GetEntitiesFromCache(string entityLogicalName)
    {
      lock (ExtensionMethods._cachedEntities)
      {
        Dictionary<Guid, Entity> dictionary = new Dictionary<Guid, Entity>();
        ExtensionMethods._cachedEntities.TryGetValue(entityLogicalName, out dictionary);
        return dictionary ?? new Dictionary<Guid, Entity>();
      }
    }

    public static void AddEntitiesToCache<T>(
      this IOrganizationService service,
      ICollection<T> entities)
      where T : BaseProxyClass
    {
      foreach (T entity in (IEnumerable<T>) entities)
        ExtensionMethods.AddEntityToCache((Entity) entity);
    }

    public static void AddEntitiesToCache(
      this IOrganizationService service,
      ICollection<Entity> entities)
    {
      ExtensionMethods.AddEntitiesToCache(entities);
    }

    public static void AddEntitiesToCache(ICollection<Entity> entities)
    {
      lock (ExtensionMethods._cachedEntities)
      {
        foreach (Entity entity in (IEnumerable<Entity>) entities)
          ExtensionMethods.AddEntityToCache(entity);
      }
    }

    public static void AddEntityToCache(this IOrganizationService service, Entity entity)
    {
      ExtensionMethods.AddEntityToCache(entity);
    }

    public static void AddEntityToCache(Entity entity)
    {
      lock (ExtensionMethods._cachedEntities)
      {
        if (!ExtensionMethods._cachedEntities.ContainsKey(entity.LogicalName))
          ExtensionMethods._cachedEntities.Add(entity.LogicalName, new Dictionary<Guid, Entity>());
        if (ExtensionMethods._cachedEntities[entity.LogicalName].ContainsKey(entity.Id))
          return;
        ExtensionMethods._cachedEntities[entity.LogicalName].Add(entity.Id, entity);
      }
    }

    public static T RetrieveCachedProxy<T>(
      this IOrganizationService service,
      EntityReference entity)
      where T : BaseProxyClass
    {
      return service.RetrieveCachedProxy<T>(entity, new ColumnSet(true));
    }

    public static T RetrieveCachedProxy<T>(
      this IOrganizationService service,
      EntityReference entity,
      params string[] columns)
      where T : BaseProxyClass
    {
      return service.RetrieveCachedProxy<T>(entity, ExtensionMethods.GetColumnSet(columns));
    }

    public static T RetrieveCachedProxy<T>(
      this IOrganizationService service,
      EntityReference entity,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      return service.RetrieveCachedEntityById(entity.LogicalName, entity.Id, columns).ToProxy<T>();
    }

    public static T RetrieveCachedProxy<T>(
      this EntityReference entity,
      IOrganizationService service)
      where T : BaseProxyClass
    {
      return entity.RetrieveCachedProxy<T>(service, new ColumnSet(true));
    }

    public static T RetrieveCachedProxy<T>(
      this EntityReference entity,
      IOrganizationService service,
      params string[] columns)
      where T : BaseProxyClass
    {
      return entity.RetrieveCachedProxy<T>(service, ExtensionMethods.GetColumnSet(columns));
    }

    public static T RetrieveCachedProxy<T>(
      this EntityReference entity,
      IOrganizationService service,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      return service.RetrieveCachedProxy<T>(entity, columns);
    }

    public static async Task<EntityMetadata> GetEntityMetadataAsync(
      this IOrganizationService service,
      string logicalName,
      EntityFilters filters)
    {
      EntityMetadata entityMetadataAsync = await Task.Run<EntityMetadata>((Func<EntityMetadata>) (() => service.GetEntityMetadata(logicalName, filters)));
      return entityMetadataAsync;
    }

    public static EntityMetadata GetEntityMetadata(
      this IOrganizationService service,
      string logicalName,
      EntityFilters filters)
    {
      RetrieveEntityRequest retrieveEntityRequest = new RetrieveEntityRequest()
      {
        LogicalName = logicalName,
        EntityFilters = filters
      };
      return ((RetrieveEntityResponse) service.Execute((OrganizationRequest) retrieveEntityRequest)).EntityMetadata;
    }

    public static async Task<Entity> RetrieveAsync(
      this IOrganizationService service,
      string entityName,
      Guid id,
      params string[] columns)
    {
      Entity entity = await service.RetrieveAsync(entityName, id, ExtensionMethods.GetColumnSet(columns));
      return entity;
    }

    public static async Task<Entity> RetrieveAsync(
      this IOrganizationService service,
      EntityReference entity,
      params string[] columns)
    {
      Entity entity1 = await service.RetrieveAsync(entity.LogicalName, entity.Id, ExtensionMethods.GetColumnSet(columns));
      return entity1;
    }

    public static async Task<Entity> RetrieveAsync(
      this IOrganizationService service,
      EntityReference entity,
      ColumnSet columns)
    {
      Entity entity1 = await service.RetrieveAsync(entity.LogicalName, entity.Id, columns);
      return entity1;
    }

    public static async Task<Entity> RetrieveAsync(
      this IOrganizationService service,
      string entityName,
      Guid id,
      ColumnSet columns)
    {
      Entity entity = await Task.Run<Entity>((Func<Entity>) (() => service.Retrieve(entityName, id, columns)));
      return entity;
    }

    public static void CopyTo(this Entity entity, Entity toEntity, bool overwriteMissingValuesOnly = true)
    {
      if (entity.Id != Guid.Empty && (toEntity.Id == Guid.Empty || !overwriteMissingValuesOnly))
        toEntity.Id = entity.Id;
      foreach (KeyValuePair<string, object> attribute in (DataCollection<string, object>) entity.Attributes)
      {
        if (!toEntity.Contains(attribute.Key) || !overwriteMissingValuesOnly)
          toEntity[attribute.Key] = attribute.Value;
      }
    }

    public static async Task<EntityCollection> RetrieveMultipleAsync(
      this IOrganizationService service,
      QueryExpression query)
    {
      EntityCollection entityCollection = await Task.Run<EntityCollection>((Func<EntityCollection>) (() => service.RetrieveMultiple((QueryBase) query)));
      return entityCollection;
    }

    public static async Task<EntityCollection> RetrieveMultipleAsync(
      this IOrganizationService service,
      string entityName,
      ConditionExpression condition,
      ColumnSet columns)
    {
      EntityCollection entityCollection = await Task.Run<EntityCollection>((Func<EntityCollection>) (() => service.RetrieveMultiple(entityName, condition, columns)));
      return entityCollection;
    }

    public static async Task<EntityCollection> RetrieveMultipleAsync(
      this IOrganizationService service,
      string entityName,
      ConditionExpression condition,
      params string[] columns)
    {
      EntityCollection entityCollection = await Task.Run<EntityCollection>((Func<EntityCollection>) (() => service.RetrieveMultiple(entityName, condition, columns)));
      return entityCollection;
    }

    public static async Task DeleteAsync(this IOrganizationService service, EntityReference entity)
    {
      await service.DeleteAsync(entity.LogicalName, entity.Id);
    }

    public static async Task DeleteAsync(
      this IOrganizationService service,
      string logicalName,
      Guid id)
    {
      await Task.Run((Action) (() => service.Delete(logicalName, id)));
    }
  }
}
