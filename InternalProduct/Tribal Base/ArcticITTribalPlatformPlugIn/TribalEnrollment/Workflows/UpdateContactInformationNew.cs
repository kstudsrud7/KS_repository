// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Workflows.UpdateContactInformationNew
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.TribalEnrollment.EntityPlugins;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.Workflows
{
  public class UpdateContactInformationNew : CodeActivity
  {
    private int CRM_EXECUTE_MULTIPLE_BATCH_SIZE;

    [Input("Max Contacts To Process")]
    [Default("500")]
    [RequiredArgument]
    public InArgument<int> MaxRecordsToProcess { get; set; }

    [Input("Bulkupdate Batch Size")]
    [Default("500")]
    [RequiredArgument]
    public InArgument<int> BulkUpdateBatchSize { get; set; }

    [Input("Paging Cookie IN")]
    [Output("Paging Cookie OUT")]
    public InOutArgument<string> PagingCookieIn { get; set; }

    [Input("PageStart IN")]
    [Output("PageStart OUT")]
    [RequiredArgument]
    [Default("1")]
    public InOutArgument<int> PageStart { get; set; }

    [Input("HasMorePages IN")]
    [Output("HasMorePages OUT")]
    [Default("True")]
    public InOutArgument<bool> HasMoreRecords { get; set; }

    protected override void Execute(CodeActivityContext executionContext)
    {
      IWorkflowContext extension1 = executionContext.GetExtension<IWorkflowContext>();
      FrameworkService crmService1 = WorkflowLibrary.GetCrmService(executionContext);
      if (((IExecutionContext) extension1).Depth > 3)
        return;
      this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = this.BulkUpdateBatchSize.Get((ActivityContext) executionContext);
      FrameworkService crmService2 = new FrameworkService(executionContext);
      ITracingService extension2 = executionContext.GetExtension<ITracingService>();
      extension2.Trace("BEGIN of WorkFlowActivity UpdateContactInformationNew", Array.Empty<object>());
      extension2.Trace("Begin Retrieving active Contacts", Array.Empty<object>());
      DateTime now1 = DateTime.Now;
      List<ConditionExpression> conditions = new List<ConditionExpression>();
      conditions.Add(new ConditionExpression("statecode", (ConditionOperator) 0, (object) 0));
      ColumnSet columnSet = new ColumnSet(new string[10]
      {
        "contactid",
        "createdon",
        "modifiedon",
        "ait_tribalid",
        "birthdate",
        "ait_deathdate",
        "ait_birthrecord",
        "ait_deathrecord",
        "ait_age",
        "ait_agegroup"
      });
      int num1;
      if (this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 9999)
      {
        this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = 100;
        conditions.Add(new ConditionExpression("ait_deathrecord", (ConditionOperator) 12));
        ConditionExpression conditionExpression1 = new ConditionExpression();
        conditionExpression1.AttributeName = "ait_membershipstatus";
        conditionExpression1.Operator = (ConditionOperator) 0;
        ((Collection<object>) conditionExpression1.Values).Add((object) 750000000);
        ConditionExpression conditionExpression2 = conditionExpression1;
        conditions.Add(conditionExpression2);
      }
      else if (this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 9998)
      {
        this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = 100;
        conditions.Add(new ConditionExpression("ait_deathrecord", (ConditionOperator) 12));
        ConditionExpression conditionExpression3 = new ConditionExpression();
        conditionExpression3.AttributeName = "ait_membershipstatus";
        conditionExpression3.Operator = (ConditionOperator) 1;
        ((Collection<object>) conditionExpression3.Values).Add((object) 750000000);
        ConditionExpression conditionExpression4 = conditionExpression3;
        conditions.Add(conditionExpression4);
      }
      else if (this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 9997)
      {
        this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = 100;
        conditions.Add(new ConditionExpression("ait_deathrecord", (ConditionOperator) 13));
      }
      else if (this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 9996)
      {
        this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = 100;
        conditions.Add(new ConditionExpression("ait_deathrecord", (ConditionOperator) 12));
        DateTime now2 = DateTime.Now;
        List<ConditionExpression> conditionExpressionList = conditions;
        string str1 = now2.Month.ToString();
        num1 = now2.Day;
        string str2 = num1.ToString();
        ConditionExpression conditionExpression = new ConditionExpression("ait_birthrecordname", (ConditionOperator) 6, (object) (str1 + "/" + str2 + "%"));
        conditionExpressionList.Add(conditionExpression);
      }
      else if (this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 9995)
      {
        this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = 1000;
        conditions.Add(new ConditionExpression("ait_deathrecord", (ConditionOperator) 12));
        ConditionExpression conditionExpression5 = new ConditionExpression();
        conditionExpression5.AttributeName = "ait_membershipstatus";
        conditionExpression5.Operator = (ConditionOperator) 0;
        ((Collection<object>) conditionExpression5.Values).Add((object) 750000000);
        ConditionExpression conditionExpression6 = conditionExpression5;
        conditions.Add(conditionExpression6);
        ConditionExpression conditionExpression7 = new ConditionExpression();
        conditionExpression7.AttributeName = "ait_gender";
        conditionExpression7.Operator = (ConditionOperator) 0;
        ((Collection<object>) conditionExpression7.Values).Add((object) 750000001);
        ConditionExpression conditionExpression8 = conditionExpression7;
        conditions.Add(conditionExpression8);
      }
      else if (this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 9994)
      {
        this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = 1000;
        conditions.Add(new ConditionExpression("ait_deathrecord", (ConditionOperator) 12));
        ConditionExpression conditionExpression9 = new ConditionExpression();
        conditionExpression9.AttributeName = "ait_membershipstatus";
        conditionExpression9.Operator = (ConditionOperator) 0;
        ((Collection<object>) conditionExpression9.Values).Add((object) 750000000);
        ConditionExpression conditionExpression10 = conditionExpression9;
        conditions.Add(conditionExpression10);
        ConditionExpression conditionExpression11 = new ConditionExpression();
        conditionExpression11.AttributeName = "ait_gender";
        conditionExpression11.Operator = (ConditionOperator) 1;
        ((Collection<object>) conditionExpression11.Values).Add((object) 750000001);
        ConditionExpression conditionExpression12 = conditionExpression11;
        conditions.Add(conditionExpression12);
      }
      else if (this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 9993)
      {
        this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = 1000;
        conditions.Add(new ConditionExpression("ait_deathrecord", (ConditionOperator) 12));
        ConditionExpression conditionExpression13 = new ConditionExpression();
        conditionExpression13.AttributeName = "ait_membershipstatus";
        conditionExpression13.Operator = (ConditionOperator) 1;
        ((Collection<object>) conditionExpression13.Values).Add((object) 750000000);
        ConditionExpression conditionExpression14 = conditionExpression13;
        conditions.Add(conditionExpression14);
        ConditionExpression conditionExpression15 = new ConditionExpression();
        conditionExpression15.AttributeName = "ait_gender";
        conditionExpression15.Operator = (ConditionOperator) 0;
        ((Collection<object>) conditionExpression15.Values).Add((object) 750000001);
        ConditionExpression conditionExpression16 = conditionExpression15;
        conditions.Add(conditionExpression16);
      }
      else if (this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 9992)
      {
        this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE = 1000;
        conditions.Add(new ConditionExpression("ait_deathrecord", (ConditionOperator) 12));
        ConditionExpression conditionExpression17 = new ConditionExpression();
        conditionExpression17.AttributeName = "ait_membershipstatus";
        conditionExpression17.Operator = (ConditionOperator) 1;
        ((Collection<object>) conditionExpression17.Values).Add((object) 750000000);
        ConditionExpression conditionExpression18 = conditionExpression17;
        conditions.Add(conditionExpression18);
        ConditionExpression conditionExpression19 = new ConditionExpression();
        conditionExpression19.AttributeName = "ait_gender";
        conditionExpression19.Operator = (ConditionOperator) 1;
        ((Collection<object>) conditionExpression19.Values).Add((object) 750000001);
        ConditionExpression conditionExpression20 = conditionExpression19;
        conditions.Add(conditionExpression20);
      }
      string str3 = this.PagingCookieIn.Get((ActivityContext) executionContext);
      int num2 = this.PageStart.Get((ActivityContext) executionContext);
      this.MaxRecordsToProcess.Get((ActivityContext) executionContext);
      bool flag = true;
      extension2.Trace("UpdateContactInformationNew: Calling GetAllEntitiesUnlimited", Array.Empty<object>());
      EntityCollection entitiesUnlimited = EntityLibrary.GetAllEntitiesUnlimited((IOrganizationService) crmService2, "contact", conditions, true, columnSet, "modifiedon", (OrderType) 0);
      ITracingService itracingService = extension2;
      num1 = ((Collection<Entity>) entitiesUnlimited.Entities).Count;
      string str4 = "UpdateContactInformationNew: GetAllEntitiesUnlimited Returned Contacts: " + num1.ToString();
      object[] objArray = Array.Empty<object>();
      itracingService.Trace(str4, objArray);
      this.HasMoreRecords.Set((ActivityContext) executionContext, flag);
      this.PagingCookieIn.Set((ActivityContext) executionContext, str3);
      this.PageStart.Set((ActivityContext) executionContext, num2);
      List<Entity> entityList = new List<Entity>();
      DateTime.Now.ToUniversalTime();
      extension2.Trace("Begin Process for all Contacts retrieved {0}, then add to a list for bulk update.", new object[1]
      {
        (object) ((Collection<Entity>) entitiesUnlimited.Entities).Count
      });
      foreach (Contact entity in (Collection<Entity>) entitiesUnlimited.Entities)
      {
        Contact contact = ContactPlugin.UpdateAgeInfo(crmService1, entity, false);
        if (contact != null)
          entityList.Add((Entity) contact);
      }
      extension2.Trace(string.Format("Process Active Contacts Completed, Start Bulk Update in batches of {0} for {1} Contacts", (object) this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE, (object) entityList.Count), Array.Empty<object>());
      ExecuteMultipleRequest request = new ExecuteMultipleRequest()
      {
        Settings = new ExecuteMultipleSettings()
        {
          ContinueOnError = false,
          ReturnResponses = false
        },
        Requests = new OrganizationRequestCollection()
      };
      for (int index = 0; index < entityList.Count; ++index)
      {
        UpdateRequest updateRequest = new UpdateRequest()
        {
          Target = entityList[index]
        };
        ((Collection<OrganizationRequest>) request.Requests).Add((OrganizationRequest) updateRequest);
        if ((index + 1) % this.CRM_EXECUTE_MULTIPLE_BATCH_SIZE == 0 && index != 0 || index + 1 >= entityList.Count)
        {
          extension2.Trace(string.Format("updateRequest count = {0}", (object) ((Collection<OrganizationRequest>) request.Requests).Count), Array.Empty<object>());
          ExecuteMultipleResponse multipleResponse = (ExecuteMultipleResponse) crmService2.Execute((OrganizationRequest) request);
          if (multipleResponse.IsFaulted && ((Collection<ExecuteMultipleResponseItem>) multipleResponse.Responses).Count > 0)
          {
            extension2.Trace(string.Format("Response Fault {0}", (object) ((Collection<ExecuteMultipleResponseItem>) multipleResponse.Responses)[0].Fault), Array.Empty<object>());
            extension2.Trace(string.Format("Response Fault Message{0}", (object) ((BaseServiceFault) ((Collection<ExecuteMultipleResponseItem>) multipleResponse.Responses)[0].Fault).Message), Array.Empty<object>());
            extension2.Trace(string.Format("Response Fault Error Code{0}", (object) ((BaseServiceFault) ((Collection<ExecuteMultipleResponseItem>) multipleResponse.Responses)[0].Fault).ErrorCode), Array.Empty<object>());
            if (((Collection<ExecuteMultipleResponseItem>) multipleResponse.Responses)[0].Fault.InnerFault != null)
            {
              extension2.Trace(string.Format("Inner Fault {0}", (object) ((Collection<ExecuteMultipleResponseItem>) multipleResponse.Responses)[0].Fault.InnerFault), Array.Empty<object>());
              extension2.Trace(string.Format("Inner Fault Message {0}", (object) ((BaseServiceFault) ((Collection<ExecuteMultipleResponseItem>) multipleResponse.Responses)[0].Fault.InnerFault).Message), Array.Empty<object>());
              extension2.Trace(string.Format("Inner Fault Error Code {0}", (object) ((BaseServiceFault) ((Collection<ExecuteMultipleResponseItem>) multipleResponse.Responses)[0].Fault.InnerFault).ErrorCode), Array.Empty<object>());
            }
            throw new Exception("Fault Occurred");
          }
          ((Collection<OrganizationRequest>) request.Requests).Clear();
        }
      }
      extension2.Trace("END of WorkFlowActivity UpdateContactInformationNew " + ((IExecutionContext) extension1).PrimaryEntityId.ToString(), Array.Empty<object>());
    }
  }
}
