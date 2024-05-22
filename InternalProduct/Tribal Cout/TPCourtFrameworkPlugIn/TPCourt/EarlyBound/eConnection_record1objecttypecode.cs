// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eConnection_record1objecttypecode
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eConnection_record1objecttypecode
  {
    [Description("Account")] Account = 1,
    [Description("Contact")] Contact = 2,
    [Description("Opportunity")] Opportunity = 3,
    [Description("Lead")] Lead = 4,
    [Description("User")] User = 8,
    [Description("Team")] Team = 9,
    [Description("Position")] Position = 50, // 0x00000032
    [Description("Social Profile")] Social_Profile = 99, // 0x00000063
    [Description("Case")] Case = 112, // 0x00000070
    [Description("Competitor")] Competitor = 123, // 0x0000007B
    [Description("Contract")] Contract = 1010, // 0x000003F2
    [Description("Price List")] Price_List = 1022, // 0x000003FE
    [Description("Product")] Product = 1024, // 0x00000400
    [Description("Quote")] Quote = 1084, // 0x0000043C
    [Description("Order")] Order = 1088, // 0x00000440
    [Description("Invoice")] Invoice = 1090, // 0x00000442
    [Description("Territory")] Territory = 2013, // 0x000007DD
    [Description("Facility/Equipment")] Facility_Equipment = 4000, // 0x00000FA0
    [Description("Scheduling Group")] Scheduling_Group = 4005, // 0x00000FA5
    [Description("Resource Group")] Resource_Group = 4007, // 0x00000FA7
    [Description("Activity")] Activity = 4200, // 0x00001068
    [Description("Hearing")] Hearing = 4201, // 0x00001069
    [Description("Email")] Email = 4202, // 0x0000106A
    [Description("Fax")] Fax = 4204, // 0x0000106C
    [Description("Letter")] Letter = 4207, // 0x0000106F
    [Description("Phone Call")] Phone_Call = 4210, // 0x00001072
    [Description("Task")] Task = 4212, // 0x00001074
    [Description("Service Activity")] Service_Activity = 4214, // 0x00001076
    [Description("Social Activity")] Social_Activity = 4216, // 0x00001078
    [Description("Recurring Appointment")] Recurring_Appointment = 4251, // 0x0000109B
    [Description("Marketing List")] Marketing_List = 4300, // 0x000010CC
    [Description("Campaign")] Campaign = 4400, // 0x00001130
    [Description("Campaign Activity")] Campaign_Activity = 4402, // 0x00001132
    [Description("Process Session")] Process_Session = 4710, // 0x00001266
    [Description("Channel Access Profile Rule")] Channel_Access_Profile_Rule = 9400, // 0x000024B8
    [Description("Goal")] Goal = 9600, // 0x00002580
    [Description("Entitlement")] Entitlement = 9700, // 0x000025E4
    [Description("Entitlement Channel")] Entitlement_Channel = 9701, // 0x000025E5
    [Description("Entitlement Template Channel")] Entitlement_Template_Channel = 9703, // 0x000025E7
    [Description("Knowledge Base Record")] Knowledge_Base_Record = 9930, // 0x000026CA
    [Description("Knowledge Article")] Knowledge_Article = 9953, // 0x000026E1
    [Description("Profile Album")] Profile_Album = 10070, // 0x00002756
    [Description("Customer Voice survey invite")] Customer_Voice_survey_invite = 10079, // 0x0000275F
    [Description("Customer Voice survey response")] Customer_Voice_survey_response = 10080, // 0x00002760
    [Description("XX-Hearing")] XX_Hearing = 10159, // 0x000027AF
    [Description("Device")] Device = 10162, // 0x000027B2
    [Description("IoT Alert")] IoT_Alert = 10164, // 0x000027B4
    [Description("IoT Device")] IoT_Device = 10165, // 0x000027B5
    [Description("IoT Device Category")] IoT_Device_Category = 10166, // 0x000027B6
    [Description("IoT Device Command")] IoT_Device_Command = 10167, // 0x000027B7
    [Description("IoT Device Registration History")] IoT_Device_Registration_History = 10171, // 0x000027BB
  }
}
