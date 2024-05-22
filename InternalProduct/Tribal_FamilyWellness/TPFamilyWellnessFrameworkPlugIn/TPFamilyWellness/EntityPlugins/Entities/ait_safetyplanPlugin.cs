// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.ait_safetyplanPlugin
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
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
  [CRMMetadata(EntityName = "ait_safetyplan", CrmEntityType = "TPFamilyWellness.EarlyBound.ait_safetyplan")]
  public class ait_safetyplanPlugin : EntityBase
  {
    public ait_safetyplanPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.ait_safetyplanPlugin_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.ait_safetyplanPlugin_OnPluginPostCreating);
      this.OnPluginPreDeleting += new EntityBase.PluginOnPreDeleteHandler(this.Ait_safetyplanPlugin_OnPluginPreDeleting);
    }

    private void Ait_safetyplanPlugin_OnPluginPreDeleting(
      object sender,
      EntityBase.PluginOnPreDeleteHandlerEventArgs e)
    {
    }

    private void ait_safetyplanPlugin_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.SyncPlanActivityOnPostCreate();
    }

    private void ait_safetyplanPlugin_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.SyncPlanActivityOnPostUpdate();
    }

    private void SyncPlanActivityDeletion()
    {
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression1;
        ParameterExpression parameterExpression2;
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        ait_planactivity aitPlanactivity = crmServiceContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso(pa.ait_SafetyPlan != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_SafetyPlan))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (ait_safetyplanPlugin)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityBase.get_CrmService))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (FrameworkService.get_PluginContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression1)).Select<ait_planactivity, ait_planactivity>(Expression.Lambda<Func<ait_planactivity, ait_planactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_planactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.set_ait_planactivityId)), )))); // Unable to render the statement
        if (aitPlanactivity == null)
          return;
        this.CrmService.Delete((Entity) aitPlanactivity);
      }
    }

    private void SyncPlanActivityOnPostCreate()
    {
      this.CreatePlanActivity(this.GetInputEntity<ait_safetyplan>());
    }

    private void SyncPlanActivityOnPostUpdate()
    {
      ait_safetyplan entityFromPostImage = this.GetEntityFromPostImage<ait_safetyplan>();
      ait_safetyplan inputEntity = this.GetInputEntity<ait_safetyplan>();
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression1;
        ParameterExpression parameterExpression2;
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        ait_planactivity aitPlanactivity1 = crmServiceContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso(pa.ait_SafetyPlan != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_SafetyPlan))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (ait_safetyplanPlugin)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityBase.get_CrmService))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (FrameworkService.get_PluginContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression1)).Select<ait_planactivity, ait_planactivity>(Expression.Lambda<Func<ait_planactivity, ait_planactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_planactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.set_ait_planactivityId)), )))); // Unable to render the statement
        if (aitPlanactivity1 != null)
        {
          ait_planactivity aitPlanactivity2 = new ait_planactivity();
          aitPlanactivity2.ait_planactivityId = aitPlanactivity1.ait_planactivityId;
          aitPlanactivity2.ait_CasePlan = entityFromPostImage.ait_CasePlan;
          aitPlanactivity2.ait_FamilyGroup = entityFromPostImage.ait_FamilyGroup;
          aitPlanactivity2.ait_Individual = entityFromPostImage.ait_Individual;
          aitPlanactivity2.ait_Outcome = entityFromPostImage.ait_Outcome;
          aitPlanactivity2.ait_CompletedDate = entityFromPostImage.ait_CompletedDate;
          aitPlanactivity2.ait_StartDate = entityFromPostImage.ait_StartDate;
          aitPlanactivity2.ait_EndDate = entityFromPostImage.ait_DueDate;
          aitPlanactivity2.ait_name = entityFromPostImage.ait_name;
          if (inputEntity.statuscode != null)
            aitPlanactivity2.ait_StatusLabel = MetadataLibrary.GetStatusCodeName((IOrganizationService) this.CrmService, ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityName, inputEntity.statuscode.Value);
          Ait_safetyplanState? statecode = inputEntity.statecode;
          if (statecode.HasValue)
          {
            statecode = inputEntity.statecode;
            Ait_safetyplanState aitSafetyplanState = Ait_safetyplanState.Inactive;
            if (statecode.GetValueOrDefault() == aitSafetyplanState & statecode.HasValue)
            {
              aitPlanactivity2.statecode = new Ait_planactivityState?(Ait_planactivityState.Inactive);
              aitPlanactivity2.statuscode = new OptionSetValue(Ait_planactivity_statuscode.Inactive.GetHashCode());
            }
            else
            {
              aitPlanactivity2.statecode = new Ait_planactivityState?(Ait_planactivityState.Active);
              aitPlanactivity2.statuscode = new OptionSetValue(Ait_planactivity_statuscode.Active.GetHashCode());
            }
          }
          if (inputEntity.OwnerId != null)
            aitPlanactivity2.OwnerId = inputEntity.OwnerId;
          this.CrmService.Update((Entity) aitPlanactivity2);
        }
        else
          this.CreatePlanActivity(entityFromPostImage);
      }
    }

    private void CreatePlanActivity(ait_safetyplan safetyPlan)
    {
      this.CrmService.Create((Entity) new ait_planactivity()
      {
        ait_CasePlan = safetyPlan.ait_CasePlan,
        ait_FamilyGroup = safetyPlan.ait_FamilyGroup,
        ait_Individual = safetyPlan.ait_Individual,
        ait_Outcome = safetyPlan.ait_Outcome,
        ait_CompletedDate = safetyPlan.ait_CompletedDate,
        ait_StartDate = safetyPlan.ait_StartDate,
        ait_EndDate = safetyPlan.ait_DueDate,
        ait_ActivityType = new OptionSetValue(Ait_planactivity_ait_activitytype.SafetyPlan.GetHashCode()),
        ait_name = safetyPlan.ait_name,
        ait_StatusLabel = MetadataLibrary.GetStatusCodeName((IOrganizationService) this.CrmService, ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityName, safetyPlan.statuscode.Value),
        OwnerId = safetyPlan.OwnerId,
        ait_SafetyPlan = new EntityReference(((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityName, ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityId)
      });
    }
  }
}
