// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.Entities.familywellnessConfigurationPlugin
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using TPFamilyWellness.EarlyBound;

#nullable disable
namespace TPFamilyWellness.EntityPlugins.Entities
{
  [CRMMetadata(EntityName = "ait_familywellnessconfiguration", CrmEntityType = "TPFamilyWellness.EarlyBound.Contact")]
  public class familywellnessConfigurationPlugin : EntityBase
  {
    public familywellnessConfigurationPlugin(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
      : base(serviceProvider, unsecuredConfiguration, securedConfiguration)
    {
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.FamilywellnessConfigurationPlugin_OnPluginPreUpdating);
    }

    private void FamilywellnessConfigurationPlugin_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.UpdateEntityImageString();
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

    private void UpdateEntityImageString()
    {
      string str = (string) null;
      float width1 = 768f;
      float height1 = 1024f;
      this.CrmService.Trace("Entered Plugin to update Entity Image");
      ait_familywellnessconfiguration inputEntity = this.GetInputEntity<ait_familywellnessconfiguration>();
      if (((DataCollection<string, object>) inputEntity.Attributes).ContainsKey("ait_entityimage"))
      {
        this.CrmService.Trace("ait_EntityImage updated, converting...");
        if (inputEntity.ait_EntityImage.Length > 102400)
        {
          using (MemoryStream memoryStream1 = new MemoryStream(inputEntity.ait_EntityImage))
          {
            this.CrmService.Trace("Original Image size = " + memoryStream1.Length.ToString());
            Bitmap bitmap1 = new Bitmap((Stream) memoryStream1);
            float num = Math.Min(width1 / (float) bitmap1.Width, height1 / (float) bitmap1.Height);
            SolidBrush solidBrush = new SolidBrush(Color.White);
            using (MemoryStream memoryStream2 = new MemoryStream())
            {
              Bitmap bitmap2 = new Bitmap((int) width1, (int) height1);
              using (Graphics graphics = Graphics.FromImage((Image) bitmap2))
              {
                this.CrmService.Trace("Compressing Image");
                graphics.InterpolationMode = InterpolationMode.High;
                graphics.CompositingQuality = CompositingQuality.Default;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                int width2 = (int) ((double) bitmap1.Width * (double) num);
                int height2 = (int) ((double) bitmap1.Height * (double) num);
                graphics.FillRectangle((Brush) solidBrush, new RectangleF(0.0f, 0.0f, width1, height1));
                graphics.DrawImage((Image) bitmap1, ((int) width1 - width2) / 2, ((int) height1 - height2) / 2, width2, height2);
              }
              bitmap2.Save((Stream) memoryStream2, ImageFormat.Jpeg);
              this.CrmService.Trace("Save image to memory buffer, size =" + memoryStream2.Length.ToString());
              str = Convert.ToBase64String(memoryStream2.ToArray());
            }
          }
        }
        else
        {
          this.CrmService.Trace("Image size less than 100kB, saving directly.");
          str = Convert.ToBase64String(inputEntity.ait_EntityImage);
        }
        inputEntity.ait_EntityImageString = str != null && str.Length <= 1024094 ? str : throw new InvalidPluginExecutionException("Image issue: uploaded is too large, please keep below 1,024,094 bytes.");
      }
      this.CrmService.Trace("Conversion complete, leaving plugin.");
    }

    private void SyncPrimaryContactFamilyGroup()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      familywellnessConfigurationPlugin.\u003C\u003Ec__DisplayClass5_0 cDisplayClass50 = new familywellnessConfigurationPlugin.\u003C\u003Ec__DisplayClass5_0();
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
        ait_familygroup aitFamilygroup1 = crmServiceContext.CreateQuery<ait_familygroup>().Where<ait_familygroup>(Expression.Lambda<Func<ait_familygroup, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass50, typeof (familywellnessConfigurationPlugin.\u003C\u003Ec__DisplayClass5_0)), FieldInfo.GetFieldFromHandle(__fieldref (familywellnessConfigurationPlugin.\u003C\u003Ec__DisplayClass5_0.contactInput))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Contact.get_ait_familygroup))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality))), parameterExpression1)).Select<ait_familygroup, ait_familygroup>(Expression.Lambda<Func<ait_familygroup, ait_familygroup>>((Expression) Expression.MemberInit(Expression.New(typeof (ait_familygroup)), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.set_Id)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Entity.get_Id)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_familygroup.set_ait_familygroupId)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_familygroup.get_ait_familygroupId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_familygroup.set_ait_PrimaryContact)), (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_familygroup.get_ait_PrimaryContact))))), parameterExpression2)).FirstOrDefault<ait_familygroup>();
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
        IQueryable<ait_clientprofile> source = crmServiceContext.CreateQuery<ait_clientprofile>().Where<ait_clientprofile>(Expression.Lambda<Func<ait_clientprofile, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso(cp.ait_Contact != default (object), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_ait_Contact))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityReference.get_Id))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Constant((object) this, typeof (familywellnessConfigurationPlugin)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityBase.get_CrmService))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (FrameworkService.get_PluginContext))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IExecutionContext.get_PrimaryEntityId))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Guid.op_Equality)))), (Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ait_clientprofile.get_statecode))), typeof (int?)), (Expression) Expression.Convert((Expression) Expression.Constant((object) Ait_clientprofileState.Active, typeof (Ait_clientprofileState)), typeof (int?)))), parameterExpression1));
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
  }
}
