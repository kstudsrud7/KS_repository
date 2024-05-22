// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.ait_casenotePlugin
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
  [CRMMetadata(EntityName = "ait_casenotefamilywellness", CrmEntityType = "TPFamilyWellness.EarlyBound.ait_casenotefamilywellness")]
  public class ait_casenotePlugin : EntityBase
  {
    public ait_casenotePlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.ait_casenotePlugin_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.ait_casenotePlugin_OnPluginPostCreating);
      this.OnPluginPreDeleting += new EntityBase.PluginOnPreDeleteHandler(this.Ait_casenotePlugin_OnPluginPreDeleting);
    }

    private void Ait_casenotePlugin_OnPluginPreDeleting(
      object sender,
      EntityBase.PluginOnPreDeleteHandlerEventArgs e)
    {
    }

    private void ait_casenotePlugin_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.SyncPlanActivityOnPostCreate();
    }

    private void ait_casenotePlugin_OnPluginPostUpdating(
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
        ait_planactivity aitPlanactivity = crmServiceContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso(pa.ait_CaseNotes != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_CaseNotes))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (ait_casenotePlugin)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityBase.get_CrmService))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (FrameworkService.get_PluginContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression1)).Select<ait_planactivity, ait_planactivity>(Expression.Lambda<Func<ait_planactivity, ait_planactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_planactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.set_ait_planactivityId)), )))); // Unable to render the statement
        if (aitPlanactivity == null)
          return;
        this.CrmService.Delete((Entity) aitPlanactivity);
      }
    }

    private void SyncPlanActivityOnPostCreate()
    {
      this.CreatePlanActivity(this.GetInputEntity<ait_casenotefamilywellness>());
    }

    private void SyncPlanActivityOnPostUpdate()
    {
      ait_casenotefamilywellness entityFromPostImage = this.GetEntityFromPostImage<ait_casenotefamilywellness>();
      ait_casenotefamilywellness inputEntity = this.GetInputEntity<ait_casenotefamilywellness>();
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
        ait_planactivity aitPlanactivity1 = crmServiceContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso(pa.ait_CaseNotes != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_CaseNotes))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (ait_casenotePlugin)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityBase.get_CrmService))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (FrameworkService.get_PluginContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression1)).Select<ait_planactivity, ait_planactivity>(Expression.Lambda<Func<ait_planactivity, ait_planactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_planactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.set_ait_planactivityId)), )))); // Unable to render the statement
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
          Ait_casenotefamilywellnessState? statecode = inputEntity.statecode;
          if (statecode.HasValue)
          {
            statecode = inputEntity.statecode;
            Ait_casenotefamilywellnessState casenotefamilywellnessState = Ait_casenotefamilywellnessState.Inactive;
            if (statecode.GetValueOrDefault() == casenotefamilywellnessState & statecode.HasValue)
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

    private void CreatePlanActivity(ait_casenotefamilywellness caseNote)
    {
      this.CrmService.Create((Entity) new ait_planactivity()
      {
        ait_CasePlan = caseNote.ait_CasePlan,
        ait_FamilyGroup = caseNote.ait_FamilyGroup,
        ait_Individual = caseNote.ait_Individual,
        ait_Outcome = caseNote.ait_Outcome,
        ait_CompletedDate = caseNote.ait_CompletedDate,
        ait_StartDate = caseNote.ait_StartDate,
        ait_EndDate = caseNote.ait_DueDate,
        ait_ActivityType = new OptionSetValue(Ait_planactivity_ait_activitytype.CaseNote.GetHashCode()),
        ait_name = caseNote.ait_name,
        ait_StatusLabel = MetadataLibrary.GetStatusCodeName((IOrganizationService) this.CrmService, ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityName, caseNote.statuscode.Value),
        OwnerId = caseNote.OwnerId,
        ait_CaseNotes = new EntityReference(((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityName, ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityId)
      });
    }
  }
}
