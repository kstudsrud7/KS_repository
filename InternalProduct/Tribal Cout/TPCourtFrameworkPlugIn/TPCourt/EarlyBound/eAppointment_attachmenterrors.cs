// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.eAppointment_attachmenterrors
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System.ComponentModel;

#nullable disable
namespace TPCourt.EarlyBound
{
  public enum eAppointment_attachmenterrors
  {
    [Description("None")] None,
    [Description("The appointment was saved as a Microsoft Dynamics 365 appointment record, but not all the attachments could be saved with it. An attachment cannot be saved if it is blocked or if its file type is invalid.")] The_appointment_was_saved_as_a_Microsoft_Dynamics_365_appointment_record__but_not_all_the_attachments_could_be_saved_with_it__An_attachment_cannot_be_saved_if_it_is_blocked_or_if_its_file_type_is_invalid,
  }
}
