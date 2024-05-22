// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.ConnectionsLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using TPCourt.EarlyBound;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class ConnectionsLibrary
  {
    private static ConcurrentDictionary<string, connectionrole> _connectionRoleDictionary = new ConcurrentDictionary<string, connectionrole>();

    public static connectionrole GetConnectionRole(FrameworkService crmService, string roleName)
    {
      if (ConnectionsLibrary._connectionRoleDictionary.ContainsKey(roleName))
        return ConnectionsLibrary._connectionRoleDictionary[roleName];
      connectionrole entityByAttribute = (connectionrole) EntityLibrary.GetEntityByAttribute((IOrganizationService) crmService, "connectionrole", "name", (object) roleName);
      if (entityByAttribute != null)
        ConnectionsLibrary._connectionRoleDictionary.TryAdd(roleName, entityByAttribute);
      return entityByAttribute;
    }

    public static connection CreateConnection(
      FrameworkService crmService,
      string roleName,
      EntityReference fromReference,
      EntityReference toReference)
    {
      return ConnectionsLibrary.CreateConnection(crmService, roleName, fromReference, toReference, false);
    }

    public static connection CreateConnection(
      FrameworkService crmService,
      string roleName,
      EntityReference fromReference,
      EntityReference toReference,
      bool skipIfExists)
    {
      if (fromReference == null || toReference == null)
        return (connection) null;
      TracingLibrary.TraceMethodStart(crmService);
      if (skipIfExists)
      {
        connection firstConnection = ConnectionsLibrary.GetFirstConnection(crmService, fromReference, toReference);
        if (firstConnection != null)
          return firstConnection;
      }
      connectionrole connectionRole = ConnectionsLibrary.GetConnectionRole(crmService, roleName);
      if (connectionRole == null)
      {
        crmService.Trace("ConnectionRole not found ({0}) no connection made.", (object) roleName);
        return (connection) null;
      }
      connection connection = new connection()
      {
        record1id = fromReference,
        record2roleid = connectionRole.ToEntityReference(),
        record2id = toReference
      };
      connection.Id = crmService.Create((Entity) connection);
      return connection;
    }

    public static connection GetFirstConnection(
      FrameworkService crmService,
      EntityReference fromReference,
      EntityReference toReference)
    {
      connection firstConnection = (connection) null;
      EntityCollection connections = ConnectionsLibrary.GetConnections(crmService, fromReference, toReference);
      if (connections != null && ((Collection<Entity>) connections.Entities).Count > 0)
        firstConnection = (connection) connections[0];
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
