// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.PlanActivityPlugin
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using TPFamilyWellness.EarlyBound;

#nullable disable
namespace TPFamilyWellness.EntityPlugins.Entities
{
  [CRMMetadata(EntityName = "ait_planactivity", CrmEntityType = "TPFamilyWellness.EarlyBound.ait_planactivity")]
  public class PlanActivityPlugin : EntityBase
  {
    public PlanActivityPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.PlanActivityPlugin_OnPluginPostUpdating);
    }

    private void PlanActivityPlugin_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.DeleteOrphanedPlanActivity();
    }

    private void DeleteOrphanedPlanActivity()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PlanActivityPlugin.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20 = new PlanActivityPlugin.\u003C\u003Ec__DisplayClass2_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.planActivityPost = this.GetEntityFromPostImage<ait_planactivity>();
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression;
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: method reference
        ait_planactivity aitPlanactivity = crmServiceContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso(pa.ait_planactivityId != new Guid?(), (Expression) Expression.Equal(pa.ait_planactivityId, (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (PlanActivityPlugin.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (PlanActivityPlugin.\u003C\u003Ec__DisplayClass2_0.planActivityPost))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id))), typeof (Guid?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression)).FirstOrDefault<ait_planactivity>();
        if (aitPlanactivity == null || aitPlanactivity.ait_Appointment != null || aitPlanactivity.ait_Assessment != null || aitPlanactivity.ait_CaseNotes != null || aitPlanactivity.ait_Email != null || aitPlanactivity.ait_Goal != null || aitPlanactivity.ait_PhoneCall != null || aitPlanactivity.ait_Referral != null || aitPlanactivity.ait_Task != null || aitPlanactivity.ait_SafetyPlan != null || aitPlanactivity.ait_case != null || aitPlanactivity.ait_placement != null || aitPlanactivity.ait_IncidentsId != null)
          return;
        this.CrmService.ImpersonateAdmin().Delete((Entity) aitPlanactivity);
      }
    }
  }
}
