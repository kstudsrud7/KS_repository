// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.OrganizationLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public sealed class OrganizationLibrary
  {
    private static volatile Dictionary<string, Organization> _orgaizationCache;
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
        OrganizationLibrary._orgaizationCache = new Dictionary<string, Organization>();
        OrganizationLibrary.cacheCreated = DateTime.Now;
      }
    }

    private static Organization GetOrganization(FrameworkService crmService)
    {
      lock (OrganizationLibrary.syncRoot)
      {
        if (DateTime.Now > OrganizationLibrary.cacheCreated.AddMinutes(30.0))
        {
          OrganizationLibrary._orgaizationCache = new Dictionary<string, Organization>();
          OrganizationLibrary.cacheCreated = DateTime.Now;
        }
        Organization entity;
        if (OrganizationLibrary._orgaizationCache.ContainsKey(crmService.ExecutionContext.OrganizationName))
        {
          entity = OrganizationLibrary._orgaizationCache[crmService.ExecutionContext.OrganizationName];
        }
        else
        {
          entity = (Organization) EntityLibrary.GetEntity((IOrganizationService) crmService, "organization", crmService.ExecutionContext.OrganizationId);
          if (entity != null)
            OrganizationLibrary._orgaizationCache.Add(crmService.ExecutionContext.OrganizationName, entity);
        }
        return entity;
      }
    }

    public static EntityReference GetDefaultCurrency(FrameworkService crmService)
    {
      EntityReference defaultCurrency = (EntityReference) null;
      Organization organization = OrganizationLibrary.GetOrganization(crmService);
      if (organization != null)
        defaultCurrency = organization.BaseCurrencyId;
      return defaultCurrency;
    }
  }
}
