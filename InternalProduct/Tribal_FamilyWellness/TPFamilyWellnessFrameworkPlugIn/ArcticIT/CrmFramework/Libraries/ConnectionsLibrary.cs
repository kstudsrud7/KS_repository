// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.ConnectionsLibrary
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using TPFamilyWellness.EarlyBound;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class ConnectionsLibrary
  {
    private static ConcurrentDictionary<string, ConnectionRole> _connectionRoleDictionary = new ConcurrentDictionary<string, ConnectionRole>();

    public static ConnectionRole GetConnectionRole(FrameworkService crmService, string roleName)
    {
      if (ConnectionsLibrary._connectionRoleDictionary.ContainsKey(roleName))
        return ConnectionsLibrary._connectionRoleDictionary[roleName];
      ConnectionRole entityByAttribute = (ConnectionRole) EntityLibrary.GetEntityByAttribute((IOrganizationService) crmService, "connectionrole", "name", (object) roleName);
      if (entityByAttribute != null)
        ConnectionsLibrary._connectionRoleDictionary.TryAdd(roleName, entityByAttribute);
      return entityByAttribute;
    }

    public static Connection CreateConnection(
      FrameworkService crmService,
      string roleName,
      EntityReference fromReference,
      EntityReference toReference)
    {
      return ConnectionsLibrary.CreateConnection(crmService, roleName, fromReference, toReference, false);
    }

    public static Connection CreateConnection(
      FrameworkService crmService,
      string roleName,
      EntityReference fromReference,
      EntityReference toReference,
      bool skipIfExists)
    {
      if (fromReference == null || toReference == null)
        return (Connection) null;
      TracingLibrary.TraceMethodStart(crmService);
      if (skipIfExists)
      {
        Connection firstConnection = ConnectionsLibrary.GetFirstConnection(crmService, fromReference, toReference);
        if (firstConnection != null)
          return firstConnection;
      }
      ConnectionRole connectionRole = ConnectionsLibrary.GetConnectionRole(crmService, roleName);
      if (connectionRole == null)
      {
        crmService.Trace("ConnectionRole not found ({0}) no connection made.", (object) roleName);
        return (Connection) null;
      }
      Connection connection = new Connection()
      {
        Record1Id = fromReference,
        Record2RoleId = connectionRole.ToEntityReference(),
        Record2Id = toReference
      };
      ((Entity) connection).Id = crmService.Create((Entity) connection);
      return connection;
    }

    public static Connection GetFirstConnection(
      FrameworkService crmService,
      EntityReference fromReference,
      EntityReference toReference)
    {
      Connection firstConnection = (Connection) null;
      EntityCollection connections = ConnectionsLibrary.GetConnections(crmService, fromReference, toReference);
      if (connections != null && ((Collection<Entity>) connections.Entities).Count > 0)
        firstConnection = (Connection) connections[0];
      return firstConnection;
    }

    public static EntityCollection GetConnections(
      FrameworkService crmService,
      EntityReference fromReference,
      EntityReference toReference)
    {
      EntityCollection connections = new EntityCollection();
      if (fromReference == null || toReference == null)
        return connections;
      QueryExpression queryExpression1 = new QueryExpression("connection")
      {
        ColumnSet = new ColumnSet(true),
        Criteria = new FilterExpression()
      };
      QueryExpression queryExpression2 = new QueryExpression();
      queryExpression2.EntityName = "connection";
      queryExpression2.ColumnSet = new ColumnSet(true);
      FilterExpression filterExpression = new FilterExpression();
      filterExpression.FilterOperator = (LogicalOperator) 0;
      DataCollection<ConditionExpression> conditions1 = filterExpression.Conditions;
      ConditionExpression conditionExpression1 = new ConditionExpression();
      conditionExpression1.AttributeName = "record1id";
      conditionExpression1.Operator = (ConditionOperator) 0;
      ((Collection<object>) conditionExpression1.Values).Add((object) fromReference.Id);
      ((Collection<ConditionExpression>) conditions1).Add(conditionExpression1);
      DataCollection<ConditionExpression> conditions2 = filterExpression.Conditions;
      ConditionExpression conditionExpression2 = new ConditionExpression();
      conditionExpression2.AttributeName = "record2id";
      conditionExpression2.Operator = (ConditionOperator) 0;
      ((Collection<object>) conditionExpression2.Values).Add((object) toReference.Id);
      ((Collection<ConditionExpression>) conditions2).Add(conditionExpression2);
      queryExpression2.Criteria = filterExpression;
      QueryExpression queryExpression3 = queryExpression2;
      return EntityLibrary.GetAllEntitiesUnlimited((IOrganizationService) crmService, queryExpression3);
    }

    public static bool ConnectionExists(
      FrameworkService crmService,
      EntityReference fromReference,
      EntityReference toReference)
    {
      EntityCollection connections = ConnectionsLibrary.GetConnections(crmService, fromReference, toReference);
      return connections != null && ((Collection<Entity>) connections.Entities).Count > 0;
    }

    public static void DeleteConnections(
      FrameworkService crmService,
      EntityReference fromReference,
      EntityReference toReference)
    {
      if (TracingLibrary.TraceObjectNull((object) fromReference, nameof (fromReference), crmService) || TracingLibrary.TraceObjectNull((object) toReference, nameof (toReference), crmService))
        return;
      TracingLibrary.TraceMethodStart(crmService);
      EntityCollection connections = ConnectionsLibrary.GetConnections(crmService, fromReference, toReference);
      if (connections == null)
        return;
      if (((Collection<Entity>) connections.Entities).Count == 0)
        TracingLibrary.Trace(crmService, string.Format("No connections found to delete. From {0} To {1}", (object) DebugLibrary.GetFormattedString(fromReference), (object) DebugLibrary.GetFormattedString(toReference)));
      foreach (Entity entity in (Collection<Entity>) connections.Entities)
        crmService.Delete(entity);
    }
  }
}
