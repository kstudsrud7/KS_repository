// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.IncidentsClientProfilePlugin
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using TPFamilyWellness.EarlyBound;

#nullable disable
namespace TPFamilyWellness.EntityPlugins.Entities
{
  [CRMMetadata(EntityName = "ait_ait_incidents_ait_clientprofile", CrmEntityType = "TPFamilyWellness.EarlyBound.ait_ait_incidents_ait_clientprofile")]
  public class IncidentsClientProfilePlugin : EntityBase
  {
    public IncidentsClientProfilePlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostAssociateChanging += new EntityBase.PluginPostAssociateHandler(this.Execute_OnPluginPostAssociateChanging);
      this.OnPluginPostDisassociateChanging += new EntityBase.PluginPostDisassociateHandler(this.Execute_OnPluginPostDisassociateChanging);
    }

    private void Execute_OnPluginPostAssociateChanging(
      object sender,
      EntityBase.PluginPostAssociateHandlerEventArgs e)
    {
      if (!(((Relationship) ((DataCollection<string, object>) ((IExecutionContext) this.CrmService.PluginContext).InputParameters)["Relationship"]).SchemaName == "ait_ait_incidents_ait_clientprofile"))
        return;
      this.SyncPlanActivityOnAssociate();
    }

    private void Execute_OnPluginPostDisassociateChanging(
      object sender,
      EntityBase.PluginPostDisassociateHandlerEventArgs e)
    {
      if (!(((Relationship) ((DataCollection<string, object>) ((IExecutionContext) this.CrmService.PluginContext).InputParameters)["Relationship"]).SchemaName == "ait_ait_incidents_ait_clientprofile"))
        return;
      this.SyncPlanActivityOnDisassociate();
    }

    private void SyncPlanActivityOnAssociate()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass3_0 cDisplayClass30 = new IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass3_0();
      EntityReferenceCollection inputParameter = ((DataCollection<string, object>) ((IExecutionContext) this.CrmService.PluginContext).InputParameters)["RelatedEntities"] as EntityReferenceCollection;
      EntityReference targetEntityReference;
      if (this.TargetEntityReference.LogicalName == "ait_incidents")
      {
        // ISSUE: reference to a compiler-generated field
        cDisplayClass30.incidentReference = this.TargetEntityReference;
        targetEntityReference = ((Collection<EntityReference>) inputParameter)[0];
      }
      else
      {
        targetEntityReference = this.TargetEntityReference;
        // ISSUE: reference to a compiler-generated field
        cDisplayClass30.incidentReference = ((Collection<EntityReference>) inputParameter)[0];
      }
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression;
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: method reference
        ait_incidents aitIncidents = crmServiceContext.CreateQuery<ait_incidents>().Where<ait_incidents>(Expression.Lambda<Func<ait_incidents, bool>>((Expression) Expression.Equal(w.ait_incidentsId, (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass3_0.incidentReference))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), typeof (Guid?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality))), parameterExpression)).FirstOrDefault<ait_incidents>();
        // ISSUE: reference to a compiler-generated field
        this.CrmService.Create((Entity) new ait_planactivity()
        {
          ait_CasePlan = aitIncidents.ait_caseplan,
          ait_Individual = targetEntityReference,
          ait_CompletedDate = aitIncidents.ait_IncidentClosedDate,
          ait_StartDate = aitIncidents.ait_incidentreportdate,
          ait_EndDate = aitIncidents.ait_IncidentClosedDate,
          ait_ActivityType = new OptionSetValue(Ait_planactivity_ait_activitytype.Incident.GetHashCode()),
          ait_name = aitIncidents.ait_name,
          ait_StatusLabel = MetadataLibrary.GetStatusCodeName((IOrganizationService) this.CrmService, aitIncidents.LogicalName, aitIncidents.statuscode.Value),
          OwnerId = aitIncidents.OwnerId,
          ait_IncidentsId = cDisplayClass30.incidentReference
        });
      }
    }

    private void SyncPlanActivityOnDisassociate()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass4_0 cDisplayClass40 = new IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass4_0();
      EntityReferenceCollection inputParameter = ((DataCollection<string, object>) ((IExecutionContext) this.CrmService.PluginContext).InputParameters)["RelatedEntities"] as EntityReferenceCollection;
      if (this.TargetEntityReference.LogicalName == "ait_incidents")
      {
        // ISSUE: reference to a compiler-generated field
        cDisplayClass40.incidentReference = this.TargetEntityReference;
        // ISSUE: reference to a compiler-generated field
        cDisplayClass40.clientProfileReference = ((Collection<EntityReference>) inputParameter)[0];
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        cDisplayClass40.clientProfileReference = this.TargetEntityReference;
        // ISSUE: reference to a compiler-generated field
        cDisplayClass40.incidentReference = ((Collection<EntityReference>) inputParameter)[0];
      }
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression;
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: method reference
        ait_planactivity aitPlanactivity = crmServiceContext.CreateQuery<ait_planactivity>().Where<ait_planactivity>(Expression.Lambda<Func<ait_planactivity, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso(pa.ait_IncidentsId != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_IncidentsId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass40, typeof (IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass4_0)), FieldInfo.GetFieldFromHandle(__fieldref (IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass4_0.incidentReference))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), (Expression) Expression.NotEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_Individual))), (Expression) Expression.Constant((object) null, typeof (object)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_planactivity.get_ait_Individual))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass40, typeof (IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass4_0)), FieldInfo.GetFieldFromHandle(__fieldref (IncidentsClientProfilePlugin.\u003C\u003Ec__DisplayClass4_0.clientProfileReference))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression)).FirstOrDefault<ait_planactivity>();
        if (aitPlanactivity == null)
          return;
        this.CrmService.Delete((Entity) aitPlanactivity);
      }
    }
  }
}
