// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.ContactPlugin
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
  [CRMMetadata(EntityName = "contact", CrmEntityType = "TPFamilyWellness.EarlyBound.Contact")]
  public class ContactPlugin : EntityBase
  {
    private FrameworkService adminService;

    public ContactPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.ContactPlugin_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.ContactPlugin_OnPluginPostCreating);
      this.OnPluginPostCustomActionFiring += new EntityBase.PluginPostCustomActionHandler(this.Execute_OnPluginPostCustomActionFiring);
      this.adminService = this.CrmService.ImpersonateAdmin();
    }

    private void ContactPlugin_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
    }

    private void ContactPlugin_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.SyncClientProfileName();
    }

    private void Execute_OnPluginPostCustomActionFiring(
      object sender,
      EntityBase.PluginPostCustomActionHandlerEventArgs e)
    {
      string lower = ((IExecutionContext) this.CrmService.PluginContext).MessageName.ToLower();
      if (!(lower == "ait_createclientprofilefromcontact"))
        throw new InvalidPluginExecutionException("Invalid action on Contact: " + lower);
      this.CreateClientProfile();
    }

    private void SyncPrimaryContactFamilyGroup()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ContactPlugin.\u003C\u003Ec__DisplayClass5_0 cDisplayClass50 = new ContactPlugin.\u003C\u003Ec__DisplayClass5_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass50.contactInput = this.GetInputEntity<Contact>();
      // ISSUE: reference to a compiler-generated field
      if (cDisplayClass50.contactInput.ait_familygroup == null)
        return;
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression1;
        ParameterExpression parameterExpression2;
        // ISSUE: method reference
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
        ait_familygroup aitFamilygroup1 = crmServiceContext.CreateQuery<ait_familygroup>().Where<ait_familygroup>(Expression.Lambda<Func<ait_familygroup, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass50, typeof (ContactPlugin.\u003C\u003Ec__DisplayClass5_0)), FieldInfo.GetFieldFromHandle(__fieldref (ContactPlugin.\u003C\u003Ec__DisplayClass5_0.contactInput))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_ait_familygroup))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality))), parameterExpression1)).Select<ait_familygroup, ait_familygroup>(Expression.Lambda<Func<ait_familygroup, ait_familygroup>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_familygroup)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.set_Id)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_familygroup.set_ait_familygroupId)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_familygroup.get_ait_familygroupId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_familygroup.set_ait_PrimaryContact)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_familygroup.get_ait_PrimaryContact))))), parameterExpression2)).FirstOrDefault<ait_familygroup>();
        if (aitFamilygroup1 != null && aitFamilygroup1.ait_PrimaryContact == null)
        {
          ait_familygroup aitFamilygroup2 = new ait_familygroup();
          aitFamilygroup2.Id = aitFamilygroup1.Id;
          aitFamilygroup2.ait_PrimaryContact = new EntityReference("contact", ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityId);
          this.CrmService.Update((Entity) aitFamilygroup2);
        }
      }
    }

    private void SyncClientProfileName()
    {
      Contact inputEntity = this.GetInputEntity<Contact>();
      Contact entityFromPostImage = this.GetEntityFromPostImage<Contact>();
      if (inputEntity.FirstName == null && inputEntity.LastName == null)
        return;
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression1;
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        IQueryable<ait_clientprofile> source = crmServiceContext.CreateQuery<ait_clientprofile>().Where<ait_clientprofile>(Expression.Lambda<Func<ait_clientprofile, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso(cp.ait_Contact != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_ait_Contact))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (ContactPlugin)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityBase.get_CrmService))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (FrameworkService.get_PluginContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), (Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_statecode))), typeof (int?)), (Expression) Expression.Convert((Expression) Expression.Constant((object) Ait_clientprofileState.Active, typeof (Ait_clientprofileState)), typeof (int?)))), parameterExpression1));
        ParameterExpression parameterExpression2;
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        Expression<Func<ait_clientprofile, ait_clientprofile>> selector = Expression.Lambda<Func<ait_clientprofile, ait_clientprofile>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_clientprofile)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.set_Id)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.set_ait_clientprofileId)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_ait_clientprofileId))))), parameterExpression2);
        foreach (ait_clientprofile aitClientprofile1 in source.Select<ait_clientprofile, ait_clientprofile>(selector).ToList<ait_clientprofile>())
        {
          ait_clientprofile aitClientprofile2 = new ait_clientprofile();
          aitClientprofile2.Id = aitClientprofile1.Id;
          aitClientprofile2.ait_name = entityFromPostImage.FirstName + " " + entityFromPostImage.LastName;
          aitClientprofile2.ait_ContactFullName = entityFromPostImage.FirstName + " " + entityFromPostImage.LastName;
          this.CrmService.Update((Entity) aitClientprofile2);
        }
      }
    }

    private void CreateClientProfile()
    {
      EntityReference inputVariable = this.GetInputVariable<EntityReference>("Target", true);
      if (inputVariable == null || inputVariable.Id == Guid.Empty)
        return;
      Guid guid = this.adminService.Create((Entity) new ait_clientprofile()
      {
        ait_Contact = inputVariable
      });
      Contact contact1 = new Contact();
      contact1.Id = inputVariable.Id;
      Contact contact2 = contact1;
      contact2.ait_ClientProfile = new EntityReference("ait_clientprofile", guid);
      this.adminService.Update((Entity) contact2);
    }
  }
}
