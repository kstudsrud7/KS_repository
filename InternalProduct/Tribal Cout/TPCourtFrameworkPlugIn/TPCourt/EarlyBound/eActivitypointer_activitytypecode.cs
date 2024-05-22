// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eActivitypointer_activitytypecode
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eActivitypointer_activitytypecode
  {
    [Description("Appointment")] Appointment = 4201, // 0x00001069
    [Description("Email")] Email = 4202, // 0x0000106A
    [Description("Fax")] Fax = 4204, // 0x0000106C
    [Description("Case Resolution")] Case_Resolution = 4206, // 0x0000106E
    [Description("Letter")] Letter = 4207, // 0x0000106F
    [Description("Opportunity Close")] Opportunity_Close = 4208, // 0x00001070
    [Description("Order Close")] Order_Close = 4209, // 0x00001071
    [Description("Phone Call")] Phone_Call = 4210, // 0x00001072
    [Description("Quote Close")] Quote_Close = 4211, // 0x00001073
    [Description("Task")] Task = 4212, // 0x00001074
    [Description("Service Activity")] Service_Activity = 4214, // 0x00001076
    [Description("Recurring Appointment")] Recurring_Appointment = 4251, // 0x0000109B
    [Description("Campaign Response")] Campaign_Response = 4401, // 0x00001131
    [Description("Campaign Activity")] Campaign_Activity = 4402, // 0x00001132
    [Description("Quick Campaign")] Quick_Campaign = 4406, // 0x00001136
    [Description("Forms Pro survey invite")] Forms_Pro_survey_invite = 10079, // 0x0000275F
    [Description("Forms Pro survey response")] Forms_Pro_survey_response = 10080, // 0x00002760
    [Description("Hearing")] Hearing = 10159, // 0x000027AF
  }
}
