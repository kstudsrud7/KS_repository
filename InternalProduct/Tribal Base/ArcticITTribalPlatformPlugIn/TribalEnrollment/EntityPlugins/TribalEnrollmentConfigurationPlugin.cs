// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.TribalEnrollmentConfigurationPlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.TribalEnrollment.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_tribalenrollmentconfiguration", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_tribalenrollmentconfiguration")]
  public class TribalEnrollmentConfigurationPlugin : EntityBase
  {
    public TribalEnrollmentConfigurationPlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.ValidateSingleton();
      this.UpdateBloodQuantumDecimal();
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.UpdateBloodQuantumDecimal();
      this.UpdateName();
      TribalEnrollmentConfiguration.ClearConfiguration(this.CrmService);
      this.UpdateEntityImageString();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_tribalenrollmentconfiguration>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_tribalenrollmentconfiguration>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      return "Tribal Enrollment Configuration";
    }

    private void ValidateSingleton()
    {
      if (((Collection<Entity>) EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_tribalenrollmentconfiguration", true).Entities).Count > 0)
        throw new InvalidPluginExecutionException("Cannot create more than one Tribal Enrollment Configuration.");
    }

    private void UpdateBloodQuantumDecimal()
    {
      ait_tribalenrollmentconfiguration inputEntity = this.GetInputEntity<ait_tribalenrollmentconfiguration>();
      inputEntity.ait_bqmembershipthresholddecimal = string.IsNullOrEmpty(inputEntity.ait_bqmembershipthresholdfraction) ? new Decimal?() : new Decimal?((Decimal) Fraction.Parse(inputEntity.ait_bqmembershipthresholdfraction));
      if (!string.IsNullOrEmpty(inputEntity.ait_bqparentminimumfraction))
        inputEntity.ait_bqparentminimumdecimal = new Decimal?((Decimal) Fraction.Parse(inputEntity.ait_bqparentminimumfraction));
      else
        inputEntity.ait_bqparentminimumdecimal = new Decimal?();
    }

    private void UpdateEntityImageString()
    {
      string str = (string) null;
      float width1 = 768f;
      float height1 = 1024f;
      this.CrmService.Trace("Entered Plugin to update Entity Image");
      ait_tribalenrollmentconfiguration inputEntity = this.GetInputEntity<ait_tribalenrollmentconfiguration>();
      if (((DataCollection<string, object>) inputEntity.Attributes).ContainsKey("entityimage"))
      {
        this.CrmService.Trace("EntityImage updated, converting...");
        if (inputEntity.EntityImage.Length > 102400)
        {
          using (MemoryStream memoryStream1 = new MemoryStream(inputEntity.EntityImage))
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
          str = Convert.ToBase64String(inputEntity.EntityImage);
        }
        inputEntity.ait_entityimagestring = str != null && str.Length <= 1024094 ? str : throw new InvalidPluginExecutionException("Image issue: uploaded is too large, please keep below 1,024,094 bytes.");
      }
      this.CrmService.Trace("Conversion complete, leaving plugin.");
    }
  }
}
