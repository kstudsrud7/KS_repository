// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Libraries.TribalEnrollmentConfiguration
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.EarlyBound.OptionSets;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.Libraries
{
  public sealed class TribalEnrollmentConfiguration
  {
    private static volatile Dictionary<string, ait_tribalenrollmentconfiguration> _configurationCache;
    private static object syncRoot = new object();

    private TribalEnrollmentConfiguration()
    {
    }

    static TribalEnrollmentConfiguration()
    {
      lock (TribalEnrollmentConfiguration.syncRoot)
      {
        if (TribalEnrollmentConfiguration._configurationCache != null)
          return;
        TribalEnrollmentConfiguration._configurationCache = new Dictionary<string, ait_tribalenrollmentconfiguration>();
      }
    }

    public static ait_tribalenrollmentconfiguration GetConfiguration(FrameworkService crmService)
    {
      return TribalEnrollmentConfiguration.GetConfiguration(crmService, false);
    }

    public static ait_tribalenrollmentconfiguration GetConfiguration(
      FrameworkService crmService,
      bool forceRefresh)
    {
      lock (TribalEnrollmentConfiguration.syncRoot)
      {
        ait_tribalenrollmentconfiguration configuration;
        if (TribalEnrollmentConfiguration._configurationCache.ContainsKey(crmService.ExecutionContext.OrganizationName) && !forceRefresh)
        {
          configuration = TribalEnrollmentConfiguration._configurationCache[crmService.ExecutionContext.OrganizationName];
        }
        else
        {
          EntityCollection allEntities = EntityLibrary.GetAllEntities((IOrganizationService) crmService, "ait_tribalenrollmentconfiguration", true);
          if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
          {
            configuration = (ait_tribalenrollmentconfiguration) ((Collection<Entity>) allEntities.Entities)[0];
            if (TribalEnrollmentConfiguration._configurationCache.ContainsKey(crmService.ExecutionContext.OrganizationName))
              TribalEnrollmentConfiguration._configurationCache[crmService.ExecutionContext.OrganizationName] = configuration;
            else
              TribalEnrollmentConfiguration._configurationCache.Add(crmService.ExecutionContext.OrganizationName, configuration);
          }
          else
            configuration = new ait_tribalenrollmentconfiguration();
        }
        return configuration;
      }
    }

    public static void ClearConfiguration(FrameworkService crmService)
    {
      lock (TribalEnrollmentConfiguration.syncRoot)
      {
        if (!TribalEnrollmentConfiguration._configurationCache.ContainsKey(crmService.ExecutionContext.OrganizationName))
          return;
        TribalEnrollmentConfiguration._configurationCache.Remove(crmService.ExecutionContext.OrganizationName);
      }
    }

    public static string GetFamilyTreeUrl(FrameworkService crmService)
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      string familyTreeUrl = string.Empty;
      if (configuration != null && configuration.ait_familytreereporturl != null)
        familyTreeUrl = configuration.ait_familytreereporturl;
      return familyTreeUrl;
    }

    public static ait_bloodquantumcalculationmethod GetBloodQuantumCalculationMethod(
      FrameworkService crmService)
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      ait_bloodquantumcalculationmethod calculationMethod = ait_bloodquantumcalculationmethod.Tribal;
      if (configuration != null && configuration.ait_bqcalculationmethod != null)
        calculationMethod = (ait_bloodquantumcalculationmethod) configuration.ait_bqcalculationmethod.Value;
      return calculationMethod;
    }

    public static string GetBloodQuantumMembershipThreshholdFraction(FrameworkService crmService)
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      string threshholdFraction = "1/4";
      if (configuration != null && configuration.ait_bqmembershipthresholdfraction != null)
        threshholdFraction = configuration.ait_bqparentminimumfraction;
      return threshholdFraction;
    }

    public static Decimal GetBloodQuantumMembershipThreshholdDecimal(FrameworkService crmService)
    {
      return (Decimal) Fraction.Parse(TribalEnrollmentConfiguration.GetBloodQuantumMembershipThreshholdFraction(crmService));
    }

    public static string GetBloodQuantumParentThreshholdFraction(FrameworkService crmService)
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      string threshholdFraction = "1/4";
      if (configuration != null && configuration.ait_bqparentminimumfraction != null)
        threshholdFraction = configuration.ait_bqparentminimumfraction;
      return threshholdFraction;
    }

    public static Decimal GetBloodQuantumParentThreshholdDecimal(FrameworkService crmService)
    {
      return (Decimal) Fraction.Parse(TribalEnrollmentConfiguration.GetBloodQuantumParentThreshholdFraction(crmService));
    }

    public static EntityReference GetDefaultTribe(FrameworkService crmService)
    {
      return TribalEnrollmentConfiguration.GetConfiguration(crmService).ait_defaulttribe;
    }

    public static int GetAdultAge(FrameworkService crmService)
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      int adultAge = 18;
      if (configuration != null)
      {
        int? aitAdultage;
        int num;
        if (configuration.ait_adultage.HasValue)
        {
          aitAdultage = configuration.ait_adultage;
          num = aitAdultage.HasValue ? 1 : 0;
        }
        else
          num = 0;
        if (num != 0)
        {
          aitAdultage = configuration.ait_adultage;
          adultAge = aitAdultage.Value;
        }
      }
      return adultAge;
    }

    public static int GetSeniorAge(FrameworkService crmService)
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      int seniorAge = 55;
      if (configuration != null)
      {
        int? aitSeniorage;
        int num;
        if (configuration.ait_seniorage.HasValue)
        {
          aitSeniorage = configuration.ait_seniorage;
          num = aitSeniorage.HasValue ? 1 : 0;
        }
        else
          num = 0;
        if (num != 0)
        {
          aitSeniorage = configuration.ait_seniorage;
          seniorAge = aitSeniorage.Value;
        }
      }
      return seniorAge;
    }

    public static ait_householdnameoptions GetHouseholdNameOption(FrameworkService crmService)
    {
      ait_householdnameoptions householdNameOption = ait_householdnameoptions.Manual;
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      if (configuration != null && configuration.ait_householdnaming != null)
        householdNameOption = (ait_householdnameoptions) configuration.ait_householdnaming.Value;
      return householdNameOption;
    }

    public static ait_contactnaming GetContactNameOption(FrameworkService crmService)
    {
      ait_contactnaming contactNameOption = ait_contactnaming.Default;
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      if (configuration != null && configuration.ait_contactnaming != null)
        contactNameOption = (ait_contactnaming) configuration.ait_contactnaming.Value;
      return contactNameOption;
    }

    public static bool GetSyncHouseholdAddress(FrameworkService crmService)
    {
      bool householdAddress = true;
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(crmService);
      if (configuration != null && configuration.ait_synchronizehouseholdaddresses.HasValue)
        householdAddress = configuration.ait_synchronizehouseholdaddresses.Value;
      return householdAddress;
    }
  }
}
