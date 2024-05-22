// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.OrganizationLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using TPCourt.EarlyBound;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public sealed class OrganizationLibrary
  {
    private static volatile Dictionary<string, organization> _orgaizationCache;
    private static object syncRoot = new object();
    private static DateTime cacheCreated;

    private OrganizationLibrary()
    {
    }

    static OrganizationLibrary()
    {
      lock (OrganizationLibrary.syncRoot)
      {
        if (OrganizationLibrary._orgaizationCache != null)
          return;
        OrganizationLibrary._orgaizationCache = new Dictionary<string, organization>();
        OrganizationLibrary.cacheCreated = DateTime.Now;
      }
    }

    private static organization GetOrganization(FrameworkService crmService)
    {
      lock (OrganizationLibrary.syncRoot)
      {
        if (DateTime.Now > OrganizationLibrary.cacheCreated.AddMinutes(30.0))
        {
          OrganizationLibrary._orgaizationCache = new Dictionary<string, organization>();
          OrganizationLibrary.cacheCreated = DateTime.Now;
        }
        organization entity;
        if (OrganizationLibrary._orgaizationCache.ContainsKey(crmService.ExecutionContext.OrganizationName))
        {
          entity = OrganizationLibrary._orgaizationCache[crmService.ExecutionContext.OrganizationName];
        }
        else
        {
          entity = (organization) EntityLibrary.GetEntity((IOrganizationService) crmService, "organization", crmService.ExecutionContext.OrganizationId);
          if (entity != null)
            OrganizationLibrary._orgaizationCache.Add(crmService.ExecutionContext.OrganizationName, entity);
        }
        return entity;
      }
    }

    public static EntityReference GetDefaultCurrency(FrameworkService crmService)
    {
      EntityReference defaultCurrency = (EntityReference) null;
      organization organization = OrganizationLibrary.GetOrganization(crmService);
      if (organization != null)
        defaultCurrency = organization.basecurrencyid;
      return defaultCurrency;
    }
  }
}
