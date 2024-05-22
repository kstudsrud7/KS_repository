// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.OrganizationLibrary
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using TPFamilyWellness.EarlyBound;

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
