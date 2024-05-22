// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.EntityBase
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins.Enums;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace ArcticIT.CrmFramework.Plugins
{
  public abstract class EntityBase
  {
    private DateTime _createTime = DateTime.Now;

    private IPluginExecutionContext PluginContext { get; set; }

    private IServiceProvider ServiceProvider { get; set; }

    public FrameworkService CrmService { get; set; }

    public string SecuredConfiguration { get; set; }

    public string UnsecuredConfiguration { get; set; }

    public string EntityLogicalName { get; set; }

    public EntityReference TargetEntityReference { get; private set; }

    public Type CrmEntityType { get; set; }

    public ExecutionMode ExecutionMode { get; set; }

    public DateTime CreateTime => this._createTime;

    public Global.ActionType ActionType
    {
      get
      {
        Global.ActionType actionType = Global.ActionType.UNKNOWN;
        switch (((IExecutionContext) this.PluginContext).MessageName)
        {
          case "Close":
            actionType = Global.ActionType.CLOSE;
            break;
          case "Create":
            actionType = Global.ActionType.CREATE;
            break;
          case "Delete":
            actionType = Global.ActionType.DELETE;
            break;
          case "Merge":
            actionType = Global.ActionType.MERGE;
            break;
          case "Send":
            actionType = Global.ActionType.SENDEMAIL;
            break;
          case "SetState":
            actionType = Global.ActionType.SETSTATE;
            break;
          case "SetStateDynamicEntity":
            actionType = Global.ActionType.SETSTATEDYNAMICEVENT;
            break;
          case "Update":
            actionType = Global.ActionType.UPDATE;
            break;
        }
        return actionType;
      }
    }

    public bool IsCreateAction() => this.ActionType == Global.ActionType.CREATE;

    public bool IsUpdateAction() => this.ActionType == Global.ActionType.UPDATE;

    public bool IsDeleteAction() => this.ActionType == Global.ActionType.DELETE;

    public bool IsMergeAction() => this.ActionType == Global.ActionType.MERGE;

    public bool IsEmailAction() => this.ActionType == Global.ActionType.SENDEMAIL;

    public event EntityBase.PluginOnPreCloseHandler OnPluginPreClosing;

    public event EntityBase.PluginOnPostCloseHandler OnPluginPostClosing;

    public event EntityBase.PluginOnPreCreateHandler OnPluginPreCreating;

    public event EntityBase.PluginOnPostCreateHandler OnPluginPostCreating;

    public event EntityBase.PluginOnPreUpdateHandler OnPluginPreUpdating;

    public event EntityBase.PluginOnPostUpdateHandler OnPluginPostUpdating;

    public event EntityBase.PluginOnPreDeleteHandler OnPluginPreDeleting;

    public event EntityBase.PluginOnPostDeleteHandler OnPluginPostDeleting;

    public event EntityBase.PluginOnValidateStateChangeHandler OnPluginValidateStateChanging;

    public event EntityBase.PluginOnPreStateChangeHandler OnPluginPreStateChanging;

    public event EntityBase.PluginOnPostStateChangeHandler OnPluginPostStateChanging;

    public event EntityBase.PluginPreAssociateHandler OnPluginPreAssociateChanging;

    public event EntityBase.PluginPostAssociateHandler OnPluginPostAssociateChanging;

    public event EntityBase.PluginPreDisassociateHandler OnPluginPreDisassociateChanging;

    public event EntityBase.PluginPostDisassociateHandler OnPluginPostDisassociateChanging;

    public event EntityBase.PluginPreCustomActionHandler OnPluginPreCustomActionFiring;

    public event EntityBase.PluginPostCustomActionHandler OnPluginPostCustomActionFiring;

    public event EntityBase.PluginPreMergeHandler OnPluginPreMerging;

    public event EntityBase.PluginPostMergeHandler OnPluginPostMerging;

    public event EntityBase.PluginPreSendEmailHandler OnPluginPreSendEmail;

    public event EntityBase.PluginPostSendEmailHandler OnPluginPostSendEmailHandler;

    public event EntityBase.PluginOnPreCloseHandler OnPluginPreClosingAsynchronous;

    public event EntityBase.PluginOnPostCloseHandler OnPluginPostClosingAsynchronous;

    public event EntityBase.PluginOnPreCreateHandler OnPluginPreCreatingAsynchronous;

    public event EntityBase.PluginOnPostCreateHandler OnPluginPostCreatingAsynchronous;

    public event EntityBase.PluginOnPreUpdateHandler OnPluginPreUpdatingAsynchronous;

    public event EntityBase.PluginOnPostUpdateHandler OnPluginPostUpdatingAsynchronous;

    public event EntityBase.PluginOnPreDeleteHandler OnPluginPreDeletingAsynchronous;

    public event EntityBase.PluginOnPostDeleteHandler OnPluginPostDeletingAsynchronous;

    public event EntityBase.PluginOnValidateStateChangeHandler OnPluginValidateStateChangingAsynchronous;

    public event EntityBase.PluginOnPreStateChangeHandler OnPluginPreStateChangingAsynchronous;

    public event EntityBase.PluginOnPostStateChangeHandler OnPluginPostStateChangingAsynchronous;

    public event EntityBase.PluginPreAssociateHandler OnPluginPreAssociateChangingAsynchronous;

    public event EntityBase.PluginPostAssociateHandler OnPluginPostAssociateChangingAsynchronous;

    public event EntityBase.PluginPreDisassociateHandler OnPluginPreDisassociateChangingAsynchronous;

    public event EntityBase.PluginPostDisassociateHandler OnPluginPostDisassociateChangingAsynchronous;

    public event EntityBase.PluginPreCustomActionHandler OnPluginPreCustomActionFiringAsynchronous;

    public event EntityBase.PluginPostCustomActionHandler OnPluginPostCustomActionFiringAsynchronous;

    public event EntityBase.PluginPreMergeHandler OnPluginPreMergeAsynchronous;

    public event EntityBase.PluginPostMergeHandler OnPluginPostMergeAsynchronous;

    public event EntityBase.PluginPreSendEmailHandler OnPluginPreSendEmailAsynchronous;

    public event EntityBase.PluginPostSendEmailHandler OnPluginPostSendEmailHandlerAsynchronous;

    public EntityBase(
      IServiceProvider serviceProvider,
      string unsecuredConfiguration,
      string securedConfiguration)
    {
      this.ServiceProvider = serviceProvider;
      this.UnsecuredConfiguration = unsecuredConfiguration;
      this.SecuredConfiguration = securedConfiguration;
      this.PluginContext = (IPluginExecutionContext) this.ServiceProvider.GetService(typeof (IPluginExecutionContext));
      this.CrmService = new FrameworkService(serviceProvider);
      if (((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters).ContainsKey("Target"))
      {
        if (((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"] is Entity)
          this.TargetEntityReference = ((Entity) ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"]).ToEntityReference();
        else if (((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"] is EntityReference)
          this.TargetEntityReference = (EntityReference) ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"];
      }
      object[] customAttributes = this.GetType().GetCustomAttributes(typeof (CRMMetadataAttribute), false);
      if (customAttributes != null && ((IEnumerable<object>) customAttributes).Count<object>() > 0)
      {
        CRMMetadataAttribute metadataAttribute = (CRMMetadataAttribute) customAttributes[0];
        this.EntityLogicalName = metadataAttribute.EntityName;
        this.CrmEntityType = Type.GetType(metadataAttribute.CrmEntityType);
      }
      else if (this.TargetEntityReference != null)
        this.EntityLogicalName = this.TargetEntityReference.LogicalName;
    }

    public void PluginDoWork()
    {
      if (((IExecutionContext) this.PluginContext).MessageName.Length > 3 && ((IExecutionContext) this.PluginContext).MessageName.ToLower().IndexOf("bia_") == 0 || ((IExecutionContext) this.PluginContext).MessageName.ToLower().IndexOf("ait_") == 0)
      {
        int stage1 = this.PluginContext.Stage;
        Global.Stage stage2 = Global.Stage.PRE;
        int hashCode1 = stage2.GetHashCode();
        if (stage1 == hashCode1)
        {
          if (this.OnPluginPreCustomActionFiring == null)
            return;
          this.OnPluginPreCustomActionFiring((object) this.PluginContext, new EntityBase.PluginPreCustomActionHandlerEventArgs());
        }
        else
        {
          int stage3 = this.PluginContext.Stage;
          stage2 = Global.Stage.POST;
          int hashCode2 = stage2.GetHashCode();
          if (stage3 != hashCode2 || this.OnPluginPostCustomActionFiring == null)
            return;
          this.OnPluginPostCustomActionFiring((object) this.PluginContext, new EntityBase.PluginPostCustomActionHandlerEventArgs());
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Merge")
      {
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          int stage4 = this.PluginContext.Stage;
          Global.Stage stage5 = Global.Stage.PRE;
          int hashCode3 = stage5.GetHashCode();
          if (stage4 == hashCode3)
          {
            if (this.OnPluginPreMergeAsynchronous == null)
              return;
            this.OnPluginPreMergeAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPreMergeHandlerEventArgs());
          }
          else
          {
            int stage6 = this.PluginContext.Stage;
            stage5 = Global.Stage.POST;
            int hashCode4 = stage5.GetHashCode();
            if (stage6 != hashCode4 || this.OnPluginPostMergeAsynchronous == null)
              return;
            this.OnPluginPostMergeAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPostMergeHandlerEventArgs());
          }
        }
        else
        {
          int stage7 = this.PluginContext.Stage;
          Global.Stage stage8 = Global.Stage.PRE;
          int hashCode5 = stage8.GetHashCode();
          if (stage7 == hashCode5)
          {
            if (this.OnPluginPreMerging != null)
              this.OnPluginPreMerging((object) this.PluginContext, new EntityBase.PluginOnPreMergeHandlerEventArgs());
          }
          else
          {
            int stage9 = this.PluginContext.Stage;
            stage8 = Global.Stage.POST;
            int hashCode6 = stage8.GetHashCode();
            if (stage9 == hashCode6 && this.OnPluginPostMerging != null)
              this.OnPluginPostMerging((object) this.PluginContext, new EntityBase.PluginOnPostMergeHandlerEventArgs());
          }
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Create")
      {
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          int stage10 = this.PluginContext.Stage;
          Global.Stage stage11 = Global.Stage.PRE;
          int hashCode7 = stage11.GetHashCode();
          if (stage10 == hashCode7)
          {
            if (this.OnPluginPreCreatingAsynchronous == null)
              return;
            this.OnPluginPreCreatingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPreCreateHandlerEventArgs());
          }
          else
          {
            int stage12 = this.PluginContext.Stage;
            stage11 = Global.Stage.POST;
            int hashCode8 = stage11.GetHashCode();
            if (stage12 != hashCode8 || this.OnPluginPostCreatingAsynchronous == null)
              return;
            this.OnPluginPostCreatingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPostCreateHandlerEventArgs());
          }
        }
        else
        {
          int stage13 = this.PluginContext.Stage;
          Global.Stage stage14 = Global.Stage.PRE;
          int hashCode9 = stage14.GetHashCode();
          if (stage13 == hashCode9)
          {
            if (this.OnPluginPreCreating != null)
              this.OnPluginPreCreating((object) this.PluginContext, new EntityBase.PluginOnPreCreateHandlerEventArgs());
          }
          else
          {
            int stage15 = this.PluginContext.Stage;
            stage14 = Global.Stage.POST;
            int hashCode10 = stage14.GetHashCode();
            if (stage15 == hashCode10 && this.OnPluginPostCreating != null)
              this.OnPluginPostCreating((object) this.PluginContext, new EntityBase.PluginOnPostCreateHandlerEventArgs());
          }
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Close")
      {
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          int stage16 = this.PluginContext.Stage;
          Global.Stage stage17 = Global.Stage.PRE;
          int hashCode11 = stage17.GetHashCode();
          if (stage16 == hashCode11)
          {
            if (this.OnPluginPreClosingAsynchronous == null)
              return;
            this.OnPluginPreClosingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPreCloseHandlerEventArgs());
          }
          else
          {
            int stage18 = this.PluginContext.Stage;
            stage17 = Global.Stage.POST;
            int hashCode12 = stage17.GetHashCode();
            if (stage18 != hashCode12 || this.OnPluginPostClosingAsynchronous == null)
              return;
            this.OnPluginPostClosingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPostCloseHandlerEventArgs());
          }
        }
        else
        {
          int stage19 = this.PluginContext.Stage;
          Global.Stage stage20 = Global.Stage.PRE;
          int hashCode13 = stage20.GetHashCode();
          if (stage19 == hashCode13)
          {
            if (this.OnPluginPreClosing != null)
              this.OnPluginPreClosing((object) this.PluginContext, new EntityBase.PluginOnPreCloseHandlerEventArgs());
          }
          else
          {
            int stage21 = this.PluginContext.Stage;
            stage20 = Global.Stage.POST;
            int hashCode14 = stage20.GetHashCode();
            if (stage21 == hashCode14 && this.OnPluginPostClosing != null)
              this.OnPluginPostClosing((object) this.PluginContext, new EntityBase.PluginOnPostCloseHandlerEventArgs());
          }
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Update")
      {
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          int stage22 = this.PluginContext.Stage;
          Global.Stage stage23 = Global.Stage.PRE;
          int hashCode15 = stage23.GetHashCode();
          if (stage22 == hashCode15)
          {
            if (this.OnPluginPreUpdatingAsynchronous == null)
              return;
            this.OnPluginPreUpdatingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPreUpdateHandlerEventArgs());
          }
          else
          {
            int stage24 = this.PluginContext.Stage;
            stage23 = Global.Stage.POST;
            int hashCode16 = stage23.GetHashCode();
            if (stage24 != hashCode16 || this.OnPluginPostUpdatingAsynchronous == null)
              return;
            this.OnPluginPostUpdatingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPostUpdateHandlerEventArgs());
          }
        }
        else
        {
          int stage25 = this.PluginContext.Stage;
          Global.Stage stage26 = Global.Stage.PRE;
          int hashCode17 = stage26.GetHashCode();
          if (stage25 == hashCode17)
          {
            if (this.OnPluginPreUpdating != null)
              this.OnPluginPreUpdating((object) this.PluginContext, new EntityBase.PluginOnPreUpdateHandlerEventArgs());
          }
          else
          {
            int stage27 = this.PluginContext.Stage;
            stage26 = Global.Stage.POST;
            int hashCode18 = stage26.GetHashCode();
            if (stage27 == hashCode18 && this.OnPluginPostUpdating != null)
              this.OnPluginPostUpdating((object) this.PluginContext, new EntityBase.PluginOnPostUpdateHandlerEventArgs());
          }
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Delete")
      {
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          int stage28 = this.PluginContext.Stage;
          Global.Stage stage29 = Global.Stage.PRE;
          int hashCode19 = stage29.GetHashCode();
          if (stage28 == hashCode19)
          {
            if (this.OnPluginPreDeletingAsynchronous == null)
              return;
            this.OnPluginPreDeletingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPreDeleteHandlerEventArgs());
          }
          else
          {
            int stage30 = this.PluginContext.Stage;
            stage29 = Global.Stage.POST;
            int hashCode20 = stage29.GetHashCode();
            if (stage30 != hashCode20 || this.OnPluginPostDeletingAsynchronous == null)
              return;
            this.OnPluginPostDeletingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPostDeleteHandlerEventArgs());
          }
        }
        else
        {
          int stage31 = this.PluginContext.Stage;
          Global.Stage stage32 = Global.Stage.PRE;
          int hashCode21 = stage32.GetHashCode();
          if (stage31 == hashCode21)
          {
            if (this.OnPluginPreDeleting != null)
              this.OnPluginPreDeleting((object) this.PluginContext, new EntityBase.PluginOnPreDeleteHandlerEventArgs());
          }
          else
          {
            int stage33 = this.PluginContext.Stage;
            stage32 = Global.Stage.POST;
            int hashCode22 = stage32.GetHashCode();
            if (stage33 == hashCode22 && this.OnPluginPostDeleting != null)
              this.OnPluginPostDeleting((object) this.PluginContext, new EntityBase.PluginOnPostDeleteHandlerEventArgs());
          }
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "SetStateDynamicEntity")
      {
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          if (this.PluginContext.Stage == 10)
          {
            if (this.OnPluginValidateStateChangingAsynchronous == null)
              return;
            this.OnPluginValidateStateChangingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPreStateChangeHandlerEventArgs());
          }
          else if (this.PluginContext.Stage == Global.Stage.PRE.GetHashCode())
          {
            if (this.OnPluginPreStateChangingAsynchronous == null)
              return;
            this.OnPluginPreStateChangingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPreStateChangeHandlerEventArgs());
          }
          else
          {
            if (this.PluginContext.Stage != Global.Stage.POST.GetHashCode() || this.OnPluginPostStateChangingAsynchronous == null)
              return;
            this.OnPluginPostStateChangingAsynchronous((object) this.PluginContext, new EntityBase.PluginOnPostStateChangeHandlerEventArgs());
          }
        }
        else if (this.PluginContext.Stage == 10)
        {
          if (this.OnPluginValidateStateChanging != null)
            this.OnPluginValidateStateChanging((object) this.PluginContext, new EntityBase.PluginOnPreStateChangeHandlerEventArgs());
        }
        else if (this.PluginContext.Stage == Global.Stage.PRE.GetHashCode())
        {
          if (this.OnPluginPreStateChanging != null)
            this.OnPluginPreStateChanging((object) this.PluginContext, new EntityBase.PluginOnPreStateChangeHandlerEventArgs());
        }
        else if (this.PluginContext.Stage == Global.Stage.POST.GetHashCode() && this.OnPluginPostStateChanging != null)
          this.OnPluginPostStateChanging((object) this.PluginContext, new EntityBase.PluginOnPostStateChangeHandlerEventArgs());
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Associate")
      {
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          int stage34 = this.PluginContext.Stage;
          Global.Stage stage35 = Global.Stage.PRE;
          int hashCode23 = stage35.GetHashCode();
          if (stage34 == hashCode23)
          {
            if (this.OnPluginPreAssociateChangingAsynchronous == null)
              return;
            this.OnPluginPreAssociateChangingAsynchronous((object) this.PluginContext, new EntityBase.PluginPreAssociateHandlerEventArgs());
          }
          else
          {
            int stage36 = this.PluginContext.Stage;
            stage35 = Global.Stage.POST;
            int hashCode24 = stage35.GetHashCode();
            if (stage36 != hashCode24 || this.OnPluginPostAssociateChangingAsynchronous == null)
              return;
            this.OnPluginPostAssociateChangingAsynchronous((object) this.PluginContext, new EntityBase.PluginPostAssociateHandlerEventArgs());
          }
        }
        else
        {
          int stage37 = this.PluginContext.Stage;
          Global.Stage stage38 = Global.Stage.PRE;
          int hashCode25 = stage38.GetHashCode();
          if (stage37 == hashCode25)
          {
            if (this.OnPluginPreAssociateChanging != null)
              this.OnPluginPreAssociateChanging((object) this.PluginContext, new EntityBase.PluginPreAssociateHandlerEventArgs());
          }
          else
          {
            int stage39 = this.PluginContext.Stage;
            stage38 = Global.Stage.POST;
            int hashCode26 = stage38.GetHashCode();
            if (stage39 == hashCode26 && this.OnPluginPostAssociateChanging != null)
              this.OnPluginPostAssociateChanging((object) this.PluginContext, new EntityBase.PluginPostAssociateHandlerEventArgs());
          }
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Disassociate")
      {
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          int stage40 = this.PluginContext.Stage;
          Global.Stage stage41 = Global.Stage.PRE;
          int hashCode27 = stage41.GetHashCode();
          if (stage40 == hashCode27)
          {
            if (this.OnPluginPreDisassociateChangingAsynchronous == null)
              return;
            this.OnPluginPreDisassociateChangingAsynchronous((object) this.PluginContext, new EntityBase.PluginPreDisassociateHandlerEventArgs());
          }
          else
          {
            int stage42 = this.PluginContext.Stage;
            stage41 = Global.Stage.POST;
            int hashCode28 = stage41.GetHashCode();
            if (stage42 != hashCode28 || this.OnPluginPostDisassociateChangingAsynchronous == null)
              return;
            this.OnPluginPostDisassociateChangingAsynchronous((object) this.PluginContext, new EntityBase.PluginPostDisassociateHandlerEventArgs());
          }
        }
        else
        {
          int stage43 = this.PluginContext.Stage;
          Global.Stage stage44 = Global.Stage.PRE;
          int hashCode29 = stage44.GetHashCode();
          if (stage43 == hashCode29)
          {
            if (this.OnPluginPreDisassociateChanging != null)
              this.OnPluginPreDisassociateChanging((object) this.PluginContext, new EntityBase.PluginPreDisassociateHandlerEventArgs());
          }
          else
          {
            int stage45 = this.PluginContext.Stage;
            stage44 = Global.Stage.POST;
            int hashCode30 = stage44.GetHashCode();
            if (stage45 == hashCode30 && this.OnPluginPostDisassociateChanging != null)
              this.OnPluginPostDisassociateChanging((object) this.PluginContext, new EntityBase.PluginPostDisassociateHandlerEventArgs());
          }
        }
      }
      else
      {
        if (!(((IExecutionContext) this.PluginContext).MessageName == "Send"))
          return;
        if (this.ExecutionMode == ExecutionMode.Asynchronous)
        {
          int stage46 = this.PluginContext.Stage;
          Global.Stage stage47 = Global.Stage.PRE;
          int hashCode31 = stage47.GetHashCode();
          if (stage46 == hashCode31)
          {
            if (this.OnPluginPreSendEmailAsynchronous != null)
              this.OnPluginPreSendEmailAsynchronous((object) this.PluginContext, new EntityBase.PluginPreSendEmailHandlerEventArgs());
          }
          else
          {
            int stage48 = this.PluginContext.Stage;
            stage47 = Global.Stage.POST;
            int hashCode32 = stage47.GetHashCode();
            if (stage48 == hashCode32 && this.OnPluginPostSendEmailHandlerAsynchronous != null)
              this.OnPluginPostSendEmailHandlerAsynchronous((object) this.PluginContext, new EntityBase.PluginPostSendEmailHandlerEventArgs());
          }
        }
        else
        {
          int stage49 = this.PluginContext.Stage;
          Global.Stage stage50 = Global.Stage.PRE;
          int hashCode33 = stage50.GetHashCode();
          if (stage49 == hashCode33)
          {
            if (this.OnPluginPreSendEmail != null)
              this.OnPluginPreSendEmail((object) this.PluginContext, new EntityBase.PluginPreSendEmailHandlerEventArgs());
          }
          else
          {
            int stage51 = this.PluginContext.Stage;
            stage50 = Global.Stage.POST;
            int hashCode34 = stage50.GetHashCode();
            if (stage51 == hashCode34 && this.OnPluginPostSendEmailHandler != null)
              this.OnPluginPostSendEmailHandler((object) this.PluginContext, new EntityBase.PluginPostSendEmailHandlerEventArgs());
          }
        }
      }
    }

    public T GetInputEntity<T>() where T : Entity
    {
      T inputEntity = default (T);
      if (this.ActionType == Global.ActionType.DELETE)
        inputEntity = this.GetEntityFromPreImage<T>();
      else if (((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters).Keys.Contains("Target"))
        inputEntity = ((Entity) ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"]).ToEntity<T>();
      else if (((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters).Keys.Contains("EntityMoniker"))
      {
        EntityReference inputVariable = this.GetInputVariable<EntityReference>("EntityMoniker", false);
        if (inputVariable != null)
          inputEntity = (T) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputVariable);
      }
      return inputEntity;
    }

    public T GetInputEntity<T>(Global.ActionType actionType) where T : Entity
    {
      return this.GetInputEntity<T>(actionType, Global.Stage.POST);
    }

    public T GetInputEntity<T>(Global.ActionType actionType, Global.Stage stage) where T : Entity
    {
      T inputEntity = default (T);
      switch (actionType)
      {
        case Global.ActionType.CREATE:
          if (Global.Stage.POST == stage)
            inputEntity = this.GetEntityFromPostImage<T>();
          if ((object) inputEntity == null)
          {
            inputEntity = this.GetInputEntity<T>();
            break;
          }
          break;
        case Global.ActionType.UPDATE:
        case Global.ActionType.SETSTATEDYNAMICEVENT:
        case Global.ActionType.MERGE:
          if (Global.Stage.POST == stage)
            inputEntity = this.GetEntityFromPostImage<T>();
          if ((object) inputEntity == null)
          {
            inputEntity = this.GetInputEntity<T>();
            break;
          }
          break;
        case Global.ActionType.DELETE:
          inputEntity = this.GetEntityFromPreImage<T>();
          break;
      }
      return inputEntity;
    }

    public T GetInputVariable<T>(string inputVariableName, bool throwExceptionIfVariableMissing)
    {
      if (((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters).Contains(inputVariableName))
        return (T) ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)[inputVariableName];
      if (throwExceptionIfVariableMissing)
        throw new InvalidPluginExecutionException(string.Format("Input Variable {0} is missing.", (object) inputVariableName));
      return default (T);
    }

    public T GetEntityFromPreImage<T>() where T : Entity
    {
      T obj = default (T);
      T entityFromPreImage;
      if (((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PreEntityImages).ContainsKey(nameof (EntityBase)))
      {
        entityFromPreImage = ((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PreEntityImages)[nameof (EntityBase)].ToEntity<T>();
      }
      else
      {
        this.Trace("No preimage EntityBase found.");
        entityFromPreImage = this.GetInputEntity<T>();
      }
      return entityFromPreImage;
    }

    public T GetEntityFromPostImage<T>() where T : Entity
    {
      T entityFromPostImage = default (T);
      if (((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PostEntityImages).ContainsKey(nameof (EntityBase)))
        entityFromPostImage = ((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PostEntityImages)[nameof (EntityBase)].ToEntity<T>();
      return entityFromPostImage;
    }

    public T GetEntityMerged<T>() where T : Entity
    {
      this.TraceMethodStart();
      T obj = default (T);
      T entityMerged;
      if (this.ActionType == Global.ActionType.CREATE)
        entityMerged = this.GetInputEntity<T>();
      else if (this.ActionType == Global.ActionType.DELETE)
      {
        entityMerged = this.GetEntityFromPreImage<T>();
      }
      else
      {
        T entity = ((Entity) ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"]).ToEntity<T>();
        T entityFromPreImage = this.GetEntityFromPreImage<T>();
        if ((object) entityFromPreImage != null)
        {
          foreach (string key in (IEnumerable<string>) ((DataCollection<string, object>) entity.Attributes).Keys)
          {
            if (((DataCollection<string, object>) entityFromPreImage.Attributes).ContainsKey(key))
              ((DataCollection<string, object>) entityFromPreImage.Attributes)[key] = ((DataCollection<string, object>) entity.Attributes)[key];
            else
              ((DataCollection<string, object>) entityFromPreImage.Attributes).Add(key, ((DataCollection<string, object>) entity.Attributes)[key]);
          }
          entityMerged = entityFromPreImage;
        }
        else
          entityMerged = entity;
      }
      return entityMerged;
    }

    public bool HasAttributeChanged(string[] attributes)
    {
      bool flag = false;
      if (attributes == null)
        return flag;
      foreach (string attribute in attributes)
      {
        flag = this.HasAttributeChanged(attribute, (Entity) null);
        if (flag)
          break;
      }
      return flag;
    }

    public bool HasAttributeChanged(string attribute)
    {
      return this.HasAttributeChanged(attribute, (Entity) null);
    }

    public bool HasAttributeChanged(string attribute, Entity currentImage)
    {
      bool flag = false;
      if (this.ActionType == Global.ActionType.CREATE || this.ActionType == Global.ActionType.DELETE)
        flag = true;
      else if (this.ActionType == Global.ActionType.UPDATE)
      {
        Entity entityFromPreImage = this.GetEntityFromPreImage<Entity>();
        if (currentImage == null)
          currentImage = this.GetInputEntity<Entity>();
        if (entityFromPreImage == null || currentImage == null)
        {
          flag = true;
        }
        else
        {
          object original = (object) null;
          object compareTo = (object) null;
          if (((DataCollection<string, object>) currentImage.Attributes).ContainsKey(attribute))
            compareTo = currentImage[attribute];
          else if (((DataCollection<string, object>) currentImage.Attributes).ContainsKey(attribute.ToLower()))
            compareTo = currentImage[attribute.ToLower()];
          if (compareTo != null)
          {
            flag = true;
          }
          else
          {
            if (((DataCollection<string, object>) entityFromPreImage.Attributes).ContainsKey(attribute))
              original = ((DataCollection<string, object>) entityFromPreImage.Attributes)[attribute];
            else if (((DataCollection<string, object>) entityFromPreImage.Attributes).ContainsKey(attribute.ToLower()))
              original = ((DataCollection<string, object>) entityFromPreImage.Attributes)[attribute.ToLower()];
            if (compareTo == null)
              compareTo = original;
            flag = original != null && compareTo == null || original == null && compareTo != null || !AttributeLibrary.Compare(original, compareTo);
          }
        }
      }
      return flag;
    }

    public object GetAttributeValue(string attributeName)
    {
      string lower = attributeName.ToLower();
      if (((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters).Contains("Target") && ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"] is Entity)
      {
        Entity inputParameter = (Entity) ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"];
        if (((DataCollection<string, object>) inputParameter.Attributes).ContainsKey(attributeName) && inputParameter[attributeName] != null)
          return inputParameter[attributeName];
        if (((DataCollection<string, object>) inputParameter.Attributes).ContainsKey(lower) && inputParameter[lower] != null)
          return inputParameter[lower];
      }
      if (((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PostEntityImages).Contains(nameof (EntityBase)))
      {
        Entity postEntityImage = ((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PostEntityImages)[nameof (EntityBase)];
        if (((DataCollection<string, object>) postEntityImage.Attributes).ContainsKey(attributeName))
          return postEntityImage[attributeName];
        if (((DataCollection<string, object>) postEntityImage.Attributes).ContainsKey(lower))
          return postEntityImage[lower];
      }
      if (((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PreEntityImages).Contains(nameof (EntityBase)))
      {
        Entity preEntityImage = ((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PreEntityImages)[nameof (EntityBase)];
        if (((DataCollection<string, object>) preEntityImage.Attributes).ContainsKey(attributeName))
          return preEntityImage[attributeName];
        if (((DataCollection<string, object>) preEntityImage.Attributes).ContainsKey(lower))
          return preEntityImage[lower];
      }
      this.CrmService.Trace("GetAttributeValue: Attribute not found: {0}", (object) attributeName);
      return (object) null;
    }

    protected virtual Entity GetBaseImageForUpdate()
    {
      throw new NotImplementedException("GetBaseImageForNameUpdate is not implemented on the base EntityBase class.");
    }

    protected virtual Entity GetPreImageForUpdate()
    {
      throw new NotImplementedException("GetPreImageForNameUpdate is not implemented on the base EntityBase class.");
    }

    protected virtual string GetEntityNameProperty() => "bia_name";

    protected virtual List<UpdateRelatedAttributeInformation> GetSynchronizeFromAttributeRelationships()
    {
      return new List<UpdateRelatedAttributeInformation>();
    }

    protected virtual void SynchronizeFromRelatedAttributes()
    {
      RelatedEntityLibrary.SynchronizeFromRelatedEntityAttributes(this.CrmService, this, this.GetSynchronizeFromAttributeRelationships());
    }

    protected virtual List<UpdateRelatedAttributeInformation> GetSynchronizeToAttributeRelationships()
    {
      return new List<UpdateRelatedAttributeInformation>();
    }

    protected virtual void SynchronizeToRelatedAttributes()
    {
      RelatedEntityLibrary.SynchronizeToRelatedEntityAttributes(this.CrmService, this, this.GetSynchronizeToAttributeRelationships());
    }

    protected virtual List<UpdateNameInformation> GetNameRelationships()
    {
      return new List<UpdateNameInformation>();
    }

    protected virtual void UpdateRelatedNames()
    {
      Entity baseImageForUpdate = this.GetBaseImageForUpdate();
      if (baseImageForUpdate == null)
        return;
      string lower = ObjectLibrary.GetPropertyName((object) baseImageForUpdate).ToLower();
      if (!baseImageForUpdate.Contains(lower) || !this.HasAttributeChanged(lower))
        return;
      RelatedEntityLibrary.UpdateRelatedEntityNames(this.CrmService, baseImageForUpdate.ToEntityReference(), this.GetNameRelationships());
    }

    protected virtual List<UpdateStatusInformation> GetStatusRelationships()
    {
      return new List<UpdateStatusInformation>();
    }

    protected virtual void UpdateRelatedStatuses()
    {
      Entity baseImageForUpdate = this.GetBaseImageForUpdate();
      if (!this.HasAttributeChanged("statecode"))
        return;
      RelatedEntityLibrary.UpdateRelatedEntityStatuses(this.CrmService, baseImageForUpdate.ToEntityReference(), this.GetStatusRelationships());
    }

    public string GetPropertyNameValue()
    {
      string propertyNameValue = string.Empty;
      if (this.TargetEntityReference != null && !string.IsNullOrEmpty(this.TargetEntityReference.Name))
        propertyNameValue = this.TargetEntityReference.Name;
      if (string.IsNullOrEmpty(propertyNameValue))
      {
        try
        {
          Entity entity = this.ActionType != Global.ActionType.UPDATE ? this.GetBaseImageForUpdate() : this.GetPreImageForUpdate();
          if (entity != null)
            propertyNameValue = entity.ToEntityReference().Name;
          if (string.IsNullOrEmpty(propertyNameValue))
          {
            string propertyName = this.GetPropertyName();
            propertyNameValue = entity.GetAttributeValue<string>(propertyName);
          }
        }
        catch
        {
        }
      }
      return propertyNameValue;
    }

    protected virtual string GetPropertyName()
    {
      return ObjectLibrary.GetPropertyName((object) this.GetBaseImageForUpdate());
    }

    protected virtual void UpdateName()
    {
      Entity baseImageForUpdate = this.GetBaseImageForUpdate();
      Entity preImage = this.ActionType != Global.ActionType.UPDATE ? this.GetBaseImageForUpdate() : this.GetPreImageForUpdate();
      string propertyName = this.GetPropertyName();
      string formattedName = this.GenerateFormattedName(baseImageForUpdate, preImage);
      if (this.ActionType == Global.ActionType.UPDATE)
        formattedName = (preImage.GetAttributeValue<string>(propertyName.ToLower()) ?? preImage.GetAttributeValue<string>(propertyName)) == formattedName ? string.Empty : formattedName;
      if (!string.IsNullOrEmpty(formattedName) && formattedName.Length > 75)
        formattedName = EntityLibrary.TruncateToMaxLengthOfString((IOrganizationService) this.CrmService, formattedName, this.EntityLogicalName, propertyName.ToLower());
      if (string.IsNullOrEmpty(formattedName))
        return;
      if (propertyName == "FullName")
      {
        baseImageForUpdate["fullname"] = (object) formattedName;
      }
      else
      {
        this.Trace("Update name attribute {0} : {1}", (object) propertyName, (object) formattedName);
        baseImageForUpdate[propertyName] = (object) formattedName;
      }
    }

    protected virtual string GenerateFormattedName(Entity entity, Entity preImage)
    {
      string entityNameProperty = this.GetEntityNameProperty();
      string empty = string.Empty;
      string propertyValue = (string) ObjectLibrary.GetPropertyValue((object) preImage, entityNameProperty);
      if (string.IsNullOrEmpty(propertyValue))
        propertyValue = (string) ObjectLibrary.GetPropertyValue((object) entity, entityNameProperty);
      return propertyValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime? TraceMethodStart() => TracingLibrary.TraceMethodStart(this.CrmService, 2);

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TraceMethodEnd() => TracingLibrary.TraceMethodEnd(this.CrmService, 2);

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TraceMethodEnd(string returnValue)
    {
      TracingLibrary.TraceMethodEnd(this.CrmService, returnValue, new DateTime?(), 2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TraceMethodEnd(DateTime? startTime)
    {
      TracingLibrary.TraceMethodEnd(this.CrmService, (string) null, startTime, 2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TraceMethodEnd(string returnValue, DateTime? startTime)
    {
      TracingLibrary.TraceMethodEnd(this.CrmService, returnValue, startTime, 2);
    }

    public void Trace(string format, params object[] args)
    {
      this.CrmService.TracingService.Trace(format, args);
    }

    public void TraceAllEntities()
    {
      this.Trace("Input: " + TracingLibrary.GetEntityDisplay(this.GetInputEntity<Entity>()));
      this.Trace("Pre: " + TracingLibrary.GetEntityDisplay(this.GetEntityFromPreImage<Entity>()));
      this.Trace("Post: " + TracingLibrary.GetEntityDisplay(this.GetEntityFromPostImage<Entity>()));
      this.Trace("Merge: " + TracingLibrary.GetEntityDisplay(this.GetEntityMerged<Entity>()));
    }

    public delegate void PluginOnPreCloseHandler(
      object sender,
      EntityBase.PluginOnPreCloseHandlerEventArgs e);

    public delegate void PluginOnPostCloseHandler(
      object sender,
      EntityBase.PluginOnPostCloseHandlerEventArgs e);

    public delegate void PluginOnPreCreateHandler(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e);

    public delegate void PluginOnPostCreateHandler(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e);

    public delegate void PluginOnPreUpdateHandler(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e);

    public delegate void PluginOnPostUpdateHandler(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e);

    public delegate void PluginOnPreDeleteHandler(
      object sender,
      EntityBase.PluginOnPreDeleteHandlerEventArgs e);

    public delegate void PluginOnPostDeleteHandler(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e);

    public delegate void PluginOnValidateStateChangeHandler(
      object sender,
      EntityBase.PluginOnPreStateChangeHandlerEventArgs e);

    public delegate void PluginOnPreStateChangeHandler(
      object sender,
      EntityBase.PluginOnPreStateChangeHandlerEventArgs e);

    public delegate void PluginOnPostStateChangeHandler(
      object sender,
      EntityBase.PluginOnPostStateChangeHandlerEventArgs e);

    public delegate void PluginPreAssociateHandler(
      object sender,
      EntityBase.PluginPreAssociateHandlerEventArgs e);

    public delegate void PluginPostAssociateHandler(
      object sender,
      EntityBase.PluginPostAssociateHandlerEventArgs e);

    public delegate void PluginPreDisassociateHandler(
      object sender,
      EntityBase.PluginPreDisassociateHandlerEventArgs e);

    public delegate void PluginPostDisassociateHandler(
      object sender,
      EntityBase.PluginPostDisassociateHandlerEventArgs e);

    public delegate void PluginPreCustomActionHandler(
      object sender,
      EntityBase.PluginPreCustomActionHandlerEventArgs e);

    public delegate void PluginPostCustomActionHandler(
      object sender,
      EntityBase.PluginPostCustomActionHandlerEventArgs e);

    public delegate void PluginPreMergeHandler(
      object sender,
      EntityBase.PluginOnPreMergeHandlerEventArgs e);

    public delegate void PluginPostMergeHandler(
      object sender,
      EntityBase.PluginOnPostMergeHandlerEventArgs e);

    public delegate void PluginPreSendEmailHandler(
      object sender,
      EntityBase.PluginPreSendEmailHandlerEventArgs e);

    public delegate void PluginPostSendEmailHandler(
      object sender,
      EntityBase.PluginPostSendEmailHandlerEventArgs e);

    public class PluginOnPreCloseHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPostCloseHandlerEventArgs : EventArgs
    {
    }

    public class PluginPreCustomActionHandlerEventArgs : EventArgs
    {
    }

    public class PluginPostCustomActionHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPreMergeHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPostMergeHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPreCreateHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPostCreateHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPreUpdateHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPostUpdateHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPreDeleteHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPostDeleteHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPreStateChangeHandlerEventArgs : EventArgs
    {
    }

    public class PluginOnPostStateChangeHandlerEventArgs : EventArgs
    {
    }

    public class PluginPreAssociateHandlerEventArgs : EventArgs
    {
    }

    public class PluginPostAssociateHandlerEventArgs : EventArgs
    {
    }

    public class PluginPreDisassociateHandlerEventArgs : EventArgs
    {
    }

    public class PluginPostDisassociateHandlerEventArgs : EventArgs
    {
    }

    public class PluginPreSendEmailHandlerEventArgs : EventArgs
    {
    }

    public class PluginPostSendEmailHandlerEventArgs : EventArgs
    {
    }
  }
}
