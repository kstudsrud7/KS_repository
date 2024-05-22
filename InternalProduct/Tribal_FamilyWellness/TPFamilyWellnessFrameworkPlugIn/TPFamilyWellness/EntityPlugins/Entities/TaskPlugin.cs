// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.TaskPlugin
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
  [CRMMetadata(EntityName = "task", CrmEntityType = "TPFamilyWellness.EarlyBound.Task")]
  public class TaskPlugin : EntityBase
  {
    public TaskPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.TaskPlugin_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.TaskPlugin_OnPluginPostCreating);
      this.OnPluginPreDeleting += new EntityBase.PluginOnPreDeleteHandler(this.TaskPlugin_OnPluginPreDeleting);
    }

    private void TaskPlugin_OnPluginPreDeleting(
      object sender,
      EntityBase.PluginOnPreDeleteHandlerEventArgs e)
    {
    }

    private void TaskPlugin_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.SyncPlanActivityOnPostCreate();
    }

    private void TaskPlugin_OnPluginPostUpdating(
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
        ait_planactivity aitPlanactivity = crmServiceContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso(pa.ait_Task != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_Task))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (TaskPlugin)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityBase.get_CrmService))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (FrameworkService.get_PluginContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression1)).Select<ait_planactivity, ait_planactivity>(Expression.Lambda<Func<ait_planactivity, ait_planactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_planactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.set_ait_planactivityId)), )))); // Unable to render the statement
        if (aitPlanactivity == null)
          return;
        this.CrmService.Delete((Entity) aitPlanactivity);
      }
    }

    private void SyncPlanActivityOnPostCreate()
    {
      this.CreatePlanActivity(this.GetInputEntity<Task>());
    }

    private void SyncPlanActivityOnPostUpdate()
    {
      Task entityFromPostImage = this.GetEntityFromPostImage<Task>();
      Task inputEntity = this.GetInputEntity<Task>();
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
        ait_planactivity aitPlanactivity1 = crmServiceContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso(pa.ait_Task != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_Task))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (TaskPlugin)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityBase.get_CrmService))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (FrameworkService.get_PluginContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression1)).Select<ait_planactivity, ait_planactivity>(Expression.Lambda<Func<ait_planactivity, ait_planactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_planactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.set_ait_planactivityId)), )))); // Unable to render the statement
        if (aitPlanactivity1 != null)
        {
          ait_planactivity aitPlanactivity2 = new ait_planactivity();
          aitPlanactivity2.ait_planactivityId = aitPlanactivity1.ait_planactivityId;
          aitPlanactivity2.ait_CasePlan = entityFromPostImage.ait_CasePlan;
          aitPlanactivity2.ait_FamilyGroup = entityFromPostImage.ait_FamilyGroup;
          aitPlanactivity2.ait_Individual = entityFromPostImage.ait_Individual;
          aitPlanactivity2.ait_Outcome = entityFromPostImage.ait_Outcome;
          aitPlanactivity2.ait_StartDate = entityFromPostImage.ScheduledStart;
          aitPlanactivity2.ait_EndDate = entityFromPostImage.ScheduledEnd;
          aitPlanactivity2.ait_name = entityFromPostImage.Subject;
          if (inputEntity.StatusCode != null)
            aitPlanactivity2.ait_StatusLabel = MetadataLibrary.GetStatusCodeName((IOrganizationService) this.CrmService, ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityName, inputEntity.StatusCode.Value);
          TaskState? stateCode = inputEntity.StateCode;
          if (stateCode.HasValue)
          {
            stateCode = inputEntity.StateCode;
            TaskState taskState1 = TaskState.Completed;
            int num;
            if (!(stateCode.GetValueOrDefault() == taskState1 & stateCode.HasValue))
            {
              stateCode = inputEntity.StateCode;
              TaskState taskState2 = TaskState.Canceled;
              num = stateCode.GetValueOrDefault() == taskState2 & stateCode.HasValue ? 1 : 0;
            }
            else
              num = 1;
            if (num != 0)
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

    private void CreatePlanActivity(Task task)
    {
      this.CrmService.Create((Entity) new ait_planactivity()
      {
        ait_CasePlan = task.ait_CasePlan,
        ait_FamilyGroup = task.ait_FamilyGroup,
        ait_Individual = task.ait_Individual,
        ait_Outcome = task.ait_Outcome,
        ait_StartDate = task.ScheduledStart,
        ait_EndDate = task.ScheduledEnd,
        ait_ActivityType = new OptionSetValue(Ait_planactivity_ait_activitytype.Task.GetHashCode()),
        ait_name = task.Subject,
        ait_StatusLabel = MetadataLibrary.GetStatusCodeName((IOrganizationService) this.CrmService, ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityName, task.StatusCode.Value),
        OwnerId = task.OwnerId,
        ait_Task = new EntityReference(((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityName, ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityId)
      });
    }
  }
}
