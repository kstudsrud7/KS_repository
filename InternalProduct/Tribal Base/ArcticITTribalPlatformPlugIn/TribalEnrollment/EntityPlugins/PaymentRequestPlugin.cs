// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.PaymentRequestPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_payment", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_payment")]
  public class PaymentRequestPlugin : EntityBase
  {
    public PaymentRequestPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
    }

    public static EntityCollection GetAllReadyForProcessing(
      IOrganizationService crmService,
      Guid paymentTypeId,
      Guid paymentEventId)
    {
      if (paymentTypeId == Guid.Empty)
        return (EntityCollection) null;
      FilterExpression filterExpression1 = new FilterExpression();
      ((Collection<ConditionExpression>) filterExpression1.Conditions).Add(new ConditionExpression("ait_paymentrequesttype", (ConditionOperator) 0, (object) paymentTypeId));
      FilterExpression filterExpression2 = filterExpression1;
      FilterExpression filterExpression3 = new FilterExpression();
      filterExpression3.FilterOperator = (LogicalOperator) 1;
      ((Collection<ConditionExpression>) filterExpression3.Conditions).Add(new ConditionExpression("ait_paymentstatus", (ConditionOperator) 0, (object) 914600001));
      DataCollection<FilterExpression> filters = filterExpression3.Filters;
      FilterExpression filterExpression4 = new FilterExpression();
      filterExpression4.FilterOperator = (LogicalOperator) 0;
      ((Collection<ConditionExpression>) filterExpression4.Conditions).Add(new ConditionExpression("ait_paymentstatus", (ConditionOperator) 0, (object) 914600004));
      ((Collection<ConditionExpression>) filterExpression4.Conditions).Add(new ConditionExpression("ait_paymentevent", (ConditionOperator) 0, (object) paymentEventId));
      ((Collection<FilterExpression>) filters).Add(filterExpression4);
      FilterExpression filterExpression5 = filterExpression3;
      FilterExpression filterExpression6 = new FilterExpression();
      filterExpression6.FilterOperator = (LogicalOperator) 1;
      ((Collection<ConditionExpression>) filterExpression6.Conditions).Add(new ConditionExpression("ait_howpaid", (ConditionOperator) 0, (object) 914600000));
      ((Collection<ConditionExpression>) filterExpression6.Conditions).Add(new ConditionExpression("ait_howpaid", (ConditionOperator) 0, (object) 914600004));
      FilterExpression filterExpression7 = filterExpression6;
      return EntityLibrary.GetAllEntities(crmService, "ait_payment", true, filterExpression2, filterExpression5, filterExpression7);
    }

    public static EntityCollection GetAllForPaymentEvent(
      IOrganizationService crmService,
      Guid paymentEventId)
    {
      return paymentEventId == Guid.Empty ? (EntityCollection) null : EntityLibrary.GetAllEntities(crmService, "ait_payment", "ait_paymentevent", (object) paymentEventId, true);
    }
  }
}
