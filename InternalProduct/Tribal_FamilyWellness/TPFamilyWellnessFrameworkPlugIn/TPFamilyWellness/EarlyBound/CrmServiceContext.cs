// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.CrmServiceContext
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System.CodeDom.Compiler;
using System.Linq;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class CrmServiceContext : OrganizationServiceContext
  {
    public CrmServiceContext(IOrganizationService service)
      : base(service)
    {
    }

    public IQueryable<Account> AccountSet => this.CreateQuery<Account>();

    public IQueryable<ait_addresstype> ait_addresstypeSet => this.CreateQuery<ait_addresstype>();

    public IQueryable<ait_ait_committeemeeting_ait_committeemembe> ait_ait_committeemeeting_ait_committeemembeSet
    {
      get => this.CreateQuery<ait_ait_committeemeeting_ait_committeemembe>();
    }

    public IQueryable<ait_ait_groupactivity_contact> ait_ait_groupactivity_contactSet
    {
      get => this.CreateQuery<ait_ait_groupactivity_contact>();
    }

    public IQueryable<ait_ait_incidents_ait_clientprofile> ait_ait_incidents_ait_clientprofileSet
    {
      get => this.CreateQuery<ait_ait_incidents_ait_clientprofile>();
    }

    public IQueryable<ait_ait_memberprofile_ait_membershipcategor> ait_ait_memberprofile_ait_membershipcategorSet
    {
      get => this.CreateQuery<ait_ait_memberprofile_ait_membershipcategor>();
    }

    public IQueryable<ait_ait_resolution_ait_memberprofile> ait_ait_resolution_ait_memberprofileSet
    {
      get => this.CreateQuery<ait_ait_resolution_ait_memberprofile>();
    }

    public IQueryable<ait_assessment> ait_assessmentSet => this.CreateQuery<ait_assessment>();

    public IQueryable<ait_case> ait_caseSet => this.CreateQuery<ait_case>();

    public IQueryable<ait_casenotefamilywellness> ait_casenotefamilywellnessSet
    {
      get => this.CreateQuery<ait_casenotefamilywellness>();
    }

    public IQueryable<ait_caseplan> ait_caseplanSet => this.CreateQuery<ait_caseplan>();

    public IQueryable<ait_clan> ait_clanSet => this.CreateQuery<ait_clan>();

    public IQueryable<ait_clientprofile> ait_clientprofileSet
    {
      get => this.CreateQuery<ait_clientprofile>();
    }

    public IQueryable<ait_familygroup> ait_familygroupSet => this.CreateQuery<ait_familygroup>();

    public IQueryable<ait_familywellnessconfiguration> ait_familywellnessconfigurationSet
    {
      get => this.CreateQuery<ait_familywellnessconfiguration>();
    }

    public IQueryable<ait_goal> ait_goalSet => this.CreateQuery<ait_goal>();

    public IQueryable<ait_groupactivity> ait_groupactivitySet
    {
      get => this.CreateQuery<ait_groupactivity>();
    }

    public IQueryable<ait_groupactivitymeeting> ait_groupactivitymeetingSet
    {
      get => this.CreateQuery<ait_groupactivitymeeting>();
    }

    public IQueryable<ait_groupactivityregistration> ait_groupactivityregistrationSet
    {
      get => this.CreateQuery<ait_groupactivityregistration>();
    }

    public IQueryable<ait_incidents> ait_incidentsSet => this.CreateQuery<ait_incidents>();

    public IQueryable<ait_incidenttype> ait_incidenttypeSet => this.CreateQuery<ait_incidenttype>();

    public IQueryable<ait_investigation> ait_investigationSet
    {
      get => this.CreateQuery<ait_investigation>();
    }

    public IQueryable<ait_meetingattendee> ait_meetingattendeeSet
    {
      get => this.CreateQuery<ait_meetingattendee>();
    }

    public IQueryable<ait_outcome> ait_outcomeSet => this.CreateQuery<ait_outcome>();

    public IQueryable<ait_payment> ait_paymentSet => this.CreateQuery<ait_payment>();

    public IQueryable<ait_placement> ait_placementSet => this.CreateQuery<ait_placement>();

    public IQueryable<ait_placementlocation> ait_placementlocationSet
    {
      get => this.CreateQuery<ait_placementlocation>();
    }

    public IQueryable<ait_planactivity> ait_planactivitySet => this.CreateQuery<ait_planactivity>();

    public IQueryable<ait_program> ait_programSet => this.CreateQuery<ait_program>();

    public IQueryable<ait_referral> ait_referralSet => this.CreateQuery<ait_referral>();

    public IQueryable<ait_servicerequest> ait_servicerequestSet
    {
      get => this.CreateQuery<ait_servicerequest>();
    }

    public IQueryable<ait_tribe> ait_tribeSet => this.CreateQuery<ait_tribe>();

    public IQueryable<Appointment> AppointmentSet => this.CreateQuery<Appointment>();

    public IQueryable<BusinessUnit> BusinessUnitSet => this.CreateQuery<BusinessUnit>();

    public IQueryable<Connection> ConnectionSet => this.CreateQuery<Connection>();

    public IQueryable<ConnectionRole> ConnectionRoleSet => this.CreateQuery<ConnectionRole>();

    public IQueryable<Contact> ContactSet => this.CreateQuery<Contact>();

    public IQueryable<Email> EmailSet => this.CreateQuery<Email>();

    public IQueryable<Organization> OrganizationSet => this.CreateQuery<Organization>();

    public IQueryable<PhoneCall> PhoneCallSet => this.CreateQuery<PhoneCall>();

    public IQueryable<ProcessStage> ProcessStageSet => this.CreateQuery<ProcessStage>();

    public IQueryable<SystemUser> SystemUserSet => this.CreateQuery<SystemUser>();

    public IQueryable<SystemUserRoles> SystemUserRolesSet => this.CreateQuery<SystemUserRoles>();

    public IQueryable<Task> TaskSet => this.CreateQuery<Task>();

    public IQueryable<Team> TeamSet => this.CreateQuery<Team>();

    public IQueryable<TeamMembership> TeamMembershipSet => this.CreateQuery<TeamMembership>();

    public IQueryable<TeamRoles> TeamRolesSet => this.CreateQuery<TeamRoles>();

    public IQueryable<UserSettings> UserSettingsSet => this.CreateQuery<UserSettings>();
  }
}
