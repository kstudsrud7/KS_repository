// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.clientProfilePlugin
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

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
  [CRMMetadata(EntityName = "ait_clientprofile", CrmEntityType = "TPFamilyWellness.ait_clientprofile.Contact")]
  public class clientProfilePlugin : EntityBase
  {
    public clientProfilePlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.ClientProfilePlugin_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.ClientProfilePlugin_OnPluginPreUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.ClientProfilePlugin_OnPluginPostCreating);
    }

    private void ClientProfilePlugin_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.SetName();
      this.SyncClientProfileToContactLookup();
    }

    private void ClientProfilePlugin_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.SetName();
      this.PreventDuplicateActiveClientProfile();
    }

    private void ClientProfilePlugin_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.SyncClientProfileToContactLookup();
    }

    private void PreventDuplicateActiveClientProfile()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      clientProfilePlugin.\u003C\u003Ec__DisplayClass4_0 cDisplayClass40 = new clientProfilePlugin.\u003C\u003Ec__DisplayClass4_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass40.clientProfileInput = this.GetInputEntity<ait_clientprofile>();
      // ISSUE: reference to a compiler-generated field
      if (cDisplayClass40.clientProfileInput.ait_Contact == null)
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
        // ISSUE: method reference
        if (crmServiceContext.CreateQuery<ait_clientprofile>().Where<ait_clientprofile>(Expression.Lambda<Func<ait_clientprofile, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso(cp.ait_Contact != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_ait_Contact))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass40, typeof (clientProfilePlugin.\u003C\u003Ec__DisplayClass4_0)), FieldInfo.GetFieldFromHandle(__fieldref (clientProfilePlugin.\u003C\u003Ec__DisplayClass4_0.clientProfileInput))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_ait_Contact))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), (Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_statecode))), typeof (int?)), (Expression) Expression.Convert((Expression) Expression.Constant((object) Ait_clientprofileState.Active, typeof (Ait_clientprofileState)), typeof (int?)))), parameterExpression)).FirstOrDefault<ait_clientprofile>() != null)
          throw new InvalidPluginExecutionException((OperationStatus) 0, "An Active Client Profile already exists for this Contact. Please use the existing Active Client Profile, or Deactivate the existing Client Profile first.");
      }
    }

    private void SyncClientProfileToContactLookup()
    {
      ait_clientprofile inputEntity = this.GetInputEntity<ait_clientprofile>();
      if (inputEntity.ait_Contact == null)
        return;
      Contact contact = new Contact();
      contact.Id = inputEntity.ait_Contact.Id;
      contact.ContactId = new Guid?(inputEntity.ait_Contact.Id);
      contact.ait_ClientProfile = new EntityReference("ait_clientprofile", ((IExecutionContext) this.CrmService.PluginContext).PrimaryEntityId);
      this.CrmService.Update((Entity) contact);
    }

    private void SetName()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      clientProfilePlugin.\u003C\u003Ec__DisplayClass6_0 cDisplayClass60 = new clientProfilePlugin.\u003C\u003Ec__DisplayClass6_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.clientProfileInput = this.GetInputEntity<ait_clientprofile>();
      // ISSUE: reference to a compiler-generated field
      if (cDisplayClass60.clientProfileInput.ait_Contact == null)
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
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: method reference
        Contact contact = crmServiceContext.CreateQuery<Contact>().Where<Contact>(Expression.Lambda<Func<Contact, bool>>((Expression) Expression.Equal(c.ContactId.Value, (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass60, typeof (clientProfilePlugin.\u003C\u003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle(__fieldref (clientProfilePlugin.\u003C\u003Ec__DisplayClass6_0.clientProfileInput))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_ait_Contact))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality))), parameterExpression1)).Select<Contact, Contact>(Expression.Lambda<Func<Contact, Contact>>((Expression) Expression.MemberInit(Expression.New(typeof (Contact)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.set_Id)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.set_ContactId)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_ContactId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.set_FirstName)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_FirstName)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.set_MiddleName)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_MiddleName)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.set_LastName)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_LastName)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.set_Salutation)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_Salutation)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.set_Suffix)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_Suffix))))), parameterExpression2)).FirstOrDefault<Contact>();
        // ISSUE: reference to a compiler-generated field
        cDisplayClass60.clientProfileInput.ait_name = contact.FirstName + " " + contact.LastName;
        // ISSUE: reference to a compiler-generated field
        cDisplayClass60.clientProfileInput.ait_ContactFullName = contact.FirstName + " " + contact.LastName;
      }
    }
  }
}
