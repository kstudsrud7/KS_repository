// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.WithholdingOverridePlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_pmtwithholdingoverride", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_pmtwithholdingoverride")]
  public class WithholdingOverridePlugin : EntityBase
  {
    public WithholdingOverridePlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
    }

    public static ait_pmtwithholdingoverride GetForWithholdingByModifiedDateDesc(
      IOrganizationService crmService,
      Guid withholdingId,
      DateTime validDate)
    {
      if (withholdingId == Guid.Empty)
        return (ait_pmtwithholdingoverride) null;
      FilterExpression filterExpression1 = new FilterExpression();
      ((Collection<ConditionExpression>) filterExpression1.Conditions).Add(new ConditionExpression("ait_pmtwithholding", (ConditionOperator) 0, (object) withholdingId));
      FilterExpression filterExpression2 = filterExpression1;
      FilterExpression filterExpression3 = new FilterExpression();
      filterExpression3.FilterOperator = (LogicalOperator) 0;
      ((Collection<ConditionExpression>) filterExpression3.Conditions).Add(new ConditionExpression("ait_startdate", (ConditionOperator) 5, (object) validDate));
      DataCollection<FilterExpression> filters = filterExpression3.Filters;
      FilterExpression filterExpression4 = new FilterExpression();
      filterExpression4.FilterOperator = (LogicalOperator) 1;
      ((Collection<ConditionExpression>) filterExpression4.Conditions).Add(new ConditionExpression("ait_enddate", (ConditionOperator) 4, (object) validDate));
      ((Collection<ConditionExpression>) filterExpression4.Conditions).Add(new ConditionExpression("ait_enddate", (ConditionOperator) 12));
      ((Collection<FilterExpression>) filters).Add(filterExpression4);
      FilterExpression filterExpression5 = filterExpression3;
      EntityCollection allEntities = EntityLibrary.GetAllEntities(crmService, "ait_pmtwithholdingoverride", "modifiedon", (OrderType) 1, true, filterExpression2, filterExpression5);
      ait_pmtwithholdingoverride modifiedDateDesc = (ait_pmtwithholdingoverride) null;
      if (allEntities != null && ((Collection<Entity>) allEntities.Entities).Count > 0)
        modifiedDateDesc = (ait_pmtwithholdingoverride) ((Collection<Entity>) allEntities.Entities)[0];
      return modifiedDateDesc;
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_pmtwithholdingoverride>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_pmtwithholdingoverride>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string formattedName = ((ait_pmtwithholdingoverride) entityInput).ait_name;
      if (string.IsNullOrEmpty(formattedName))
        formattedName = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_pmtwithholdingoverride", "ait_name");
      return formattedName;
    }
  }
}
