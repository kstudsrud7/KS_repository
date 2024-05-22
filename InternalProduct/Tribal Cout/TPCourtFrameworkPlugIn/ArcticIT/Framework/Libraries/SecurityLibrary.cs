// Decompiled with JetBrains decompiler
// Type: ArcticIT.Framework.Libraries.SecurityLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.Framework.Libraries
{
  internal class SecurityLibrary
  {
    public static bool IsUserInTeamByTeamID(FrameworkService CrmService, Guid userid, Guid teamid)
    {
      bool flag = false;
      foreach (Entity entity in (Collection<Entity>) SecurityLibrary.RetrieveUserTeams(CrmService, userid).Entities)
      {
        if (teamid == (Guid) entity[nameof (teamid)])
        {
          flag = true;
          break;
        }
      }
      return flag;
    }

    public static bool IsUserInTeamByTeamName(
      FrameworkService CrmService,
      Guid userid,
      string teamName)
    {
      bool flag = false;
      foreach (Entity entity in (Collection<Entity>) SecurityLibrary.RetrieveUserTeams(CrmService, userid).Entities)
      {
        if (string.Compare(teamName, entity["name"].ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
        {
          flag = true;
          break;
        }
      }
      return flag;
    }

    public static EntityCollection RetrieveUserTeams(FrameworkService CrmService, Guid userid)
    {
      QueryExpression queryExpression = new QueryExpression();
      queryExpression.EntityName = "team";
      queryExpression.ColumnSet = new ColumnSet(new string[2]
      {
        "teamid",
        "name"
      });
      DataCollection<LinkEntity> linkEntities1 = queryExpression.LinkEntities;
      LinkEntity linkEntity1 = new LinkEntity();
      linkEntity1.LinkFromEntityName = "team";
      linkEntity1.LinkFromAttributeName = "teamid";
      linkEntity1.LinkToEntityName = "teammembership";
      linkEntity1.LinkToAttributeName = "teamid";
      DataCollection<LinkEntity> linkEntities2 = linkEntity1.LinkEntities;
      LinkEntity linkEntity2 = new LinkEntity();
      linkEntity2.LinkFromEntityName = "teammembership";
      linkEntity2.LinkFromAttributeName = "systemuserid";
      linkEntity2.LinkToEntityName = "systemuser";
      linkEntity2.LinkToAttributeName = "systemuserid";
      ((Collection<ConditionExpression>) linkEntity2.LinkCriteria.Conditions).Add(new ConditionExpression("systemuserid", (ConditionOperator) 0, (object) userid));
      ((Collection<LinkEntity>) linkEntities2).Add(linkEntity2);
      ((Collection<LinkEntity>) linkEntities1).Add(linkEntity1);
      QueryExpression query = queryExpression;
      return CrmService.RetrieveMultiple((QueryBase) query);
    }

    public static EntityCollection RetrieveAllTeams(
      FrameworkService CrmService,
      string containsNameFilter)
    {
      QueryExpression queryExpression = new QueryExpression();
      queryExpression.EntityName = "team";
      queryExpression.ColumnSet = new ColumnSet(new string[2]
      {
        "teamid",
        "name"
      });
      ((Collection<LinkEntity>) queryExpression.LinkEntities).Add(new LinkEntity()
      {
        LinkFromEntityName = "team",
        LinkFromAttributeName = "teamid",
        LinkToEntityName = "teammembership",
        LinkToAttributeName = "teamid"
      });
      QueryExpression query = queryExpression;
      if (!string.IsNullOrEmpty(containsNameFilter))
      {
        FilterExpression filterExpression = new FilterExpression();
        ((Collection<ConditionExpression>) filterExpression.Conditions).Add(new ConditionExpression("name", (ConditionOperator) 49, (object) containsNameFilter));
        ((Collection<LinkEntity>) query.LinkEntities)[0].LinkCriteria = filterExpression;
      }
      return CrmService.RetrieveMultiple((QueryBase) query);
    }

    public static bool IsUserInRole(FrameworkService CrmService, Guid userid, string roleName)
    {
      bool flag = false;
      foreach (Entity entity in (Collection<Entity>) SecurityLibrary.RetrieveRoles(CrmService, userid).Entities)
      {
        if (string.Compare(roleName, entity["name"].ToString(), StringComparison.CurrentCultureIgnoreCase) == 0)
        {
          flag = true;
          break;
        }
      }
      return flag;
    }

    public static EntityCollection RetrieveRoles(FrameworkService CrmService, Guid userid)
    {
      QueryExpression queryExpression = new QueryExpression();
      queryExpression.EntityName = "role";
      queryExpression.ColumnSet = new ColumnSet(new string[2]
      {
        "roleid",
        "name"
      });
      DataCollection<LinkEntity> linkEntities1 = queryExpression.LinkEntities;
      LinkEntity linkEntity1 = new LinkEntity();
      linkEntity1.LinkFromEntityName = "role";
      linkEntity1.LinkFromAttributeName = "roleid";
      linkEntity1.LinkToEntityName = "systemuserroles";
      linkEntity1.LinkToAttributeName = "roleid";
      DataCollection<LinkEntity> linkEntities2 = linkEntity1.LinkEntities;
      LinkEntity linkEntity2 = new LinkEntity();
      linkEntity2.LinkFromEntityName = "systemuserroles";
      linkEntity2.LinkFromAttributeName = "systemuserid";
      linkEntity2.LinkToEntityName = "systemuser";
      linkEntity2.LinkToAttributeName = "systemuserid";
      ((Collection<ConditionExpression>) linkEntity2.LinkCriteria.Conditions).Add(new ConditionExpression("systemuserid", (ConditionOperator) 0, (object) userid));
      ((Collection<LinkEntity>) linkEntities2).Add(linkEntity2);
      ((Collection<LinkEntity>) linkEntities1).Add(linkEntity1);
      QueryExpression query = queryExpression;
      return CrmService.RetrieveMultiple((QueryBase) query);
    }
  }
}
