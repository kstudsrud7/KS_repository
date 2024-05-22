// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Workflows.UpdateContactInformation
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.TribalEnrollment.EntityPlugins;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System.Activities;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.Workflows
{
  public class UpdateContactInformation : CodeActivity
  {
    [Input("Run for all records")]
    [Default("false")]
    public InArgument<bool> RunForAllRecords { get; set; }

    protected override void Execute(CodeActivityContext context)
    {
      FrameworkService crmService = WorkflowLibrary.GetCrmService(context);
      foreach (Contact entity in (Collection<Entity>) EntityLibrary.GetAllEntitiesUnlimited((IOrganizationService) crmService, "contact", new List<ConditionExpression>()
      {
        new ConditionExpression("ait_deathrecord", (ConditionOperator) 12),
        new ConditionExpression("ait_birthrecord", (ConditionOperator) 13)
      }, true).Entities)
        ContactPlugin.UpdateAgeInfo(crmService, entity, true);
    }
  }
}
