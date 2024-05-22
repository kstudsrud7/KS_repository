// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.XrmPlugins.Referral
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using TPFamilyWellness.EarlyBound;
using TPFamilyWellness.EntityPlugins;

#nullable disable
namespace TPFamilyWellness.XrmPlugins
{
  public class Referral : BasePlugin
  {
    public Referral(string unsecureConfig, string secureConfig)
      : base(unsecureConfig, secureConfig)
    {
      this.RegisteredEvents.Add(new BasePlugin.PluginEvent()
      {
        Stage = BasePlugin.eStage.PostOperation,
        MessageName = MessageNames.Update,
        EntityName = EntityNames.ait_referral,
        PluginAction = new Action<IServiceProvider>(this.ExecutePluginLogic)
      });
    }

    public void ExecutePluginLogic(IServiceProvider serviceProvider)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Referral.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10 = new Referral.\u003C\u003Ec__DisplayClass1_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.localContext = new BasePlugin.LocalPluginContext<Entity>(serviceProvider);
      try
      {
        // ISSUE: reference to a compiler-generated field
        ait_referral entity1 = cDisplayClass10.localContext.TargetEntity.ToEntity<ait_referral>();
        if (entity1.OwnerId == null)
          return;
        ParameterExpression parameterExpression1;
        ParameterExpression parameterExpression2;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: type reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        ait_planactivity aitPlanactivity = cDisplayClass10.localContext.CrmContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso(pa.ait_Referral != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_Referral))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (Referral.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (Referral.\u003C\u003Ec__DisplayClass1_0.localContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (BasePlugin.LocalPluginContext<Entity>.get_PluginExecutionContext), __typeref (BasePlugin.LocalPluginContext<Entity>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression1)).Select<ait_planactivity, ait_planactivity>(Expression.Lambda<Func<ait_planactivity, ait_planactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_planactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.set_ait_planactivityId)), )))); // Unable to render the statement
        if (aitPlanactivity != null)
        {
          Entity entity2 = new Entity("ait_planactivity", aitPlanactivity.ait_planactivityId.Value);
          ((DataCollection<string, object>) entity2.Attributes)["ownerid"] = (object) new EntityReference("systemuser", entity1.OwnerId.Id);
          // ISSUE: reference to a compiler-generated field
          cDisplayClass10.localContext.OrganizationService.Update(entity2);
        }
      }
      finally
      {
        // ISSUE: reference to a compiler-generated field
        if (cDisplayClass10.localContext != null)
        {
          // ISSUE: reference to a compiler-generated field
          cDisplayClass10.localContext.Dispose();
        }
      }
    }
  }
}
