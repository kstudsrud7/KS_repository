// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.ait_groupactivitymeetingPlugin
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using TPFamilyWellness.EarlyBound;

#nullable disable
namespace TPFamilyWellness.EntityPlugins.Entities
{
  [CRMMetadata(EntityName = "ait_groupactivitymeeting", CrmEntityType = "TPFamilyWellness.ait_groupactivitymeeting.Contact")]
  public class ait_groupactivitymeetingPlugin : EntityBase
  {
    public ait_groupactivitymeetingPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.ait_groupactivitymeetingOnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Ait_groupactivitymeetingPlugin_OnPluginPreUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Ait_groupactivitymeetingPlugin_OnPluginPostCreating);
    }

    private void Ait_groupactivitymeetingPlugin_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.CopyAllGroupActivityContacts();
    }

    private void Ait_groupactivitymeetingPlugin_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.SetNameOnUpdate();
    }

    private void ait_groupactivitymeetingOnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.SetNameOnCreate();
    }

    private void CopyAllGroupActivityContacts()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ait_groupactivitymeetingPlugin.\u003C\u003Ec__DisplayClass4_0 cDisplayClass40 = new ait_groupactivitymeetingPlugin.\u003C\u003Ec__DisplayClass4_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass40.groupActivityMeetingInput = this.GetInputEntity<ait_groupactivitymeeting>();
      // ISSUE: reference to a compiler-generated field
      if (cDisplayClass40.groupActivityMeetingInput.ait_GroupActivity == null)
        return;
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression;
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        List<ait_groupactivityregistration> list1 = crmServiceContext.CreateQuery<ait_groupactivityregistration>().Where<ait_groupactivityregistration>(Expression.Lambda<Func<ait_groupactivityregistration, bool>>((Expression) Expression.AndAlso(c.ait_GroupActivity != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivityregistration.get_ait_GroupActivity))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass40, typeof (ait_groupactivitymeetingPlugin.\u003C\u003Ec__DisplayClass4_0)), FieldInfo.GetFieldFromHandle(__fieldref (ait_groupactivitymeetingPlugin.\u003C\u003Ec__DisplayClass4_0.groupActivityMeetingInput))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivitymeeting.get_ait_GroupActivity))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), parameterExpression)).ToList<ait_groupactivityregistration>();
        List<ait_tribalenrollmentconfiguration> list2 = crmServiceContext.CreateQuery<ait_tribalenrollmentconfiguration>().Where<ait_tribalenrollmentconfiguration>((Expression<Func<ait_tribalenrollmentconfiguration, bool>>) (c => c.ait_name == "Tribal Enrollment Configuration")).ToList<ait_tribalenrollmentconfiguration>();
        bool? nullable1 = list2.Count > 0 ? list2[0].ait_HousingDeployed : throw new Exception("Error - did not find Tribal Enrollment Configuration record. ");
        bool flag = true;
        if (nullable1.GetValueOrDefault() == flag & nullable1.HasValue)
        {
          foreach (ait_groupactivityregistration groupactivityregistration in list1)
          {
            ait_meetingattendee aitMeetingattendee = new ait_meetingattendee();
            Guid? nullable2 = groupactivityregistration.ait_groupactivityregistrationId;
            aitMeetingattendee.ait_GroupActivityRegistration = new EntityReference("ait_groupactivityregistration", nullable2.Value);
            // ISSUE: reference to a compiler-generated field
            nullable2 = cDisplayClass40.groupActivityMeetingInput.ait_groupactivitymeetingId;
            aitMeetingattendee.ait_GroupActivityMeeting = new EntityReference("ait_groupactivitymeeting", nullable2.Value);
            aitMeetingattendee.ait_GroupActivity = groupactivityregistration.ait_GroupActivity;
            aitMeetingattendee.ait_HousingProfile = groupactivityregistration.ait_HousingProfile;
            aitMeetingattendee.ait_ClientProfile = groupactivityregistration.ait_ClientProfile;
            aitMeetingattendee.ait_Case = groupactivityregistration.ait_Case;
            aitMeetingattendee.ait_FamilyPlan = groupactivityregistration.ait_FamilyPlan;
            this.CrmService.Create((Entity) aitMeetingattendee);
          }
        }
        else
        {
          foreach (ait_groupactivityregistration groupactivityregistration in list1)
          {
            ait_meetingattendee aitMeetingattendee = new ait_meetingattendee();
            Guid? nullable3 = groupactivityregistration.ait_groupactivityregistrationId;
            aitMeetingattendee.ait_GroupActivityRegistration = new EntityReference("ait_groupactivityregistration", nullable3.Value);
            // ISSUE: reference to a compiler-generated field
            nullable3 = cDisplayClass40.groupActivityMeetingInput.ait_groupactivitymeetingId;
            aitMeetingattendee.ait_GroupActivityMeeting = new EntityReference("ait_groupactivitymeeting", nullable3.Value);
            aitMeetingattendee.ait_GroupActivity = groupactivityregistration.ait_GroupActivity;
            aitMeetingattendee.ait_ClientProfile = groupactivityregistration.ait_ClientProfile;
            aitMeetingattendee.ait_Case = groupactivityregistration.ait_Case;
            aitMeetingattendee.ait_FamilyPlan = groupactivityregistration.ait_FamilyPlan;
            this.CrmService.Create((Entity) aitMeetingattendee);
          }
        }
      }
    }

    private void SetNameOnUpdate()
    {
      ait_groupactivitymeeting inputEntity = this.GetInputEntity<ait_groupactivitymeeting>();
      DateTime? aitMeetingDateTime;
      int num;
      if (inputEntity.ait_GroupActivity == null)
      {
        aitMeetingDateTime = inputEntity.ait_MeetingDateTime;
        num = aitMeetingDateTime.HasValue ? 1 : 0;
      }
      else
        num = 1;
      if (num == 0)
        return;
      ait_groupactivitymeeting entityFromPreImage = this.GetEntityFromPreImage<ait_groupactivitymeeting>();
      Guid groupActivityGuid = inputEntity.ait_GroupActivity != null ? inputEntity.ait_GroupActivity.Id : (entityFromPreImage.ait_GroupActivity != null ? entityFromPreImage.ait_GroupActivity.Id : Guid.Empty);
      aitMeetingDateTime = inputEntity.ait_MeetingDateTime;
      string str1;
      if (!aitMeetingDateTime.HasValue)
      {
        aitMeetingDateTime = entityFromPreImage.ait_MeetingDateTime;
        if (!aitMeetingDateTime.HasValue)
        {
          str1 = "";
        }
        else
        {
          aitMeetingDateTime = entityFromPreImage.ait_MeetingDateTime;
          str1 = aitMeetingDateTime.Value.ToShortDateString();
        }
      }
      else
      {
        aitMeetingDateTime = inputEntity.ait_MeetingDateTime;
        str1 = aitMeetingDateTime.Value.ToShortDateString();
      }
      string str2 = str1;
      string str3 = "";
      if (groupActivityGuid != Guid.Empty)
      {
        using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
        {
          ParameterExpression parameterExpression;
          // ISSUE: method reference
          // ISSUE: method reference
          // ISSUE: method reference
          // ISSUE: method reference
          // ISSUE: method reference
          // ISSUE: method reference
          ait_groupactivity aitGroupactivity = crmServiceContext.CreateQuery<ait_groupactivity>().Where<ait_groupactivity>((Expression<Func<ait_groupactivity, bool>>) (ga => ga.ait_groupactivityId == (Guid?) groupActivityGuid)).Select<ait_groupactivity, ait_groupactivity>(Expression.Lambda<Func<ait_groupactivity, ait_groupactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_groupactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.set_Id)), (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivity.set_ait_groupactivityId)), (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivity.get_ait_groupactivityId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivity.set_ait_name)), (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivity.get_ait_name))))), parameterExpression)).FirstOrDefault<ait_groupactivity>();
          if (aitGroupactivity != null)
            str3 = aitGroupactivity.ait_name;
          inputEntity.ait_activitymeetingname = str3 + " - " + str2;
        }
      }
    }

    private void SetNameOnCreate()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ait_groupactivitymeetingPlugin.\u003C\u003Ec__DisplayClass6_0 cDisplayClass60 = new ait_groupactivitymeetingPlugin.\u003C\u003Ec__DisplayClass6_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.groupActivityMeetingInput = this.GetInputEntity<ait_groupactivitymeeting>();
      // ISSUE: reference to a compiler-generated field
      if (cDisplayClass60.groupActivityMeetingInput.ait_GroupActivity == null)
        return;
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression1;
        ParameterExpression parameterExpression2;
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        ait_groupactivity aitGroupactivity = crmServiceContext.CreateQuery<ait_groupactivity>().Where<ait_groupactivity>(Expression.Lambda<Func<ait_groupactivity, bool>>((Expression) Expression.Equal(ga.ait_groupactivityId, (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass60, typeof (ait_groupactivitymeetingPlugin.\u003C\u003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle(__fieldref (ait_groupactivitymeetingPlugin.\u003C\u003Ec__DisplayClass6_0.groupActivityMeetingInput))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivitymeeting.get_ait_GroupActivity))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), typeof (Guid?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality))), parameterExpression1)).Select<ait_groupactivity, ait_groupactivity>(Expression.Lambda<Func<ait_groupactivity, ait_groupactivity>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_groupactivity)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.set_Id)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivity.set_ait_groupactivityId)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivity.get_ait_groupactivityId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivity.set_ait_name)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_groupactivity.get_ait_name))))), parameterExpression2)).FirstOrDefault<ait_groupactivity>();
        string str1 = (string) null;
        string str2 = (string) null;
        if (aitGroupactivity != null)
          str1 = aitGroupactivity.ait_name;
        // ISSUE: reference to a compiler-generated field
        if (cDisplayClass60.groupActivityMeetingInput.ait_MeetingDateTime.HasValue)
        {
          // ISSUE: reference to a compiler-generated field
          str2 = cDisplayClass60.groupActivityMeetingInput.ait_MeetingDateTime.Value.ToShortDateString();
        }
        // ISSUE: reference to a compiler-generated field
        cDisplayClass60.groupActivityMeetingInput.ait_activitymeetingname = str1 + " - " + str2;
      }
    }
  }
}
