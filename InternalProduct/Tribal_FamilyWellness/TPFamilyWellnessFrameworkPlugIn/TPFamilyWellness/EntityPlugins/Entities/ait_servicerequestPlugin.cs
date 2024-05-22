// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.ait_servicerequestPlugin
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
  [CRMMetadata(EntityName = "ait_servicerequest", CrmEntityType = "TPFamilyWellness.ait_servicerequest.ait_familygroup")]
  public class ait_servicerequestPlugin : EntityBase
  {
    public ait_servicerequestPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Ait_servicerequestPlugin_OnPluginPreCreating);
    }

    private void Ait_servicerequestPlugin_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.DefaultFamilyGroup();
    }

    private void DefaultFamilyGroup()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ait_servicerequestPlugin.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20 = new ait_servicerequestPlugin.\u003C\u003Ec__DisplayClass2_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.serviceRequestInput = this.GetInputEntity<ait_servicerequest>();
      // ISSUE: reference to a compiler-generated field
      if (cDisplayClass20.serviceRequestInput.ait_clientprofile == null)
        return;
      using (CrmServiceContext crmServiceContext = new CrmServiceContext(this.CrmService.OrganizationService))
      {
        ParameterExpression parameterExpression1;
        ParameterExpression parameterExpression2;
        // ISSUE: method reference
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
        Contact contact = crmServiceContext.CreateQuery<Contact>().Where<Contact>(Expression.Lambda<Func<Contact, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso(c.ait_ClientProfile != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_ait_ClientProfile))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ait_servicerequestPlugin.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ait_servicerequestPlugin.\u003C\u003Ec__DisplayClass2_0.serviceRequestInput))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_servicerequest.get_ait_clientprofile))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), (Expression) Expression.NotEqual((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_ait_familygroup))), (Expression) Expression.Constant((object) null, typeof (object)))), parameterExpression1)).Select<Contact, Contact>(Expression.Lambda<Func<Contact, Contact>>((Expression) Expression.MemberInit(Expression.New(typeof (Contact)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.set_Id)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.set_ait_familygroup)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_ait_familygroup))))), parameterExpression2)).FirstOrDefault<Contact>();
        if (contact != null)
        {
          // ISSUE: reference to a compiler-generated field
          cDisplayClass20.serviceRequestInput.ait_FamilyGroup = contact.ait_familygroup;
        }
      }
    }
  }
}
