// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.EntityBase
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.OptionSets;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

    public DateTime CreateTime => this._createTime;

    public Global.ActionType ActionType
    {
      get
      {
        Global.ActionType actionType = Global.ActionType.UNKNOWN;
        switch (((IExecutionContext) this.PluginContext).MessageName)
        {
          case "Create":
            actionType = Global.ActionType.CREATE;
            break;
          case "Close":
            actionType = Global.ActionType.CLOSE;
            break;
          case "Update":
            actionType = Global.ActionType.UPDATE;
            break;
          case "Delete":
            actionType = Global.ActionType.DELETE;
            break;
          case "SetState":
            actionType = Global.ActionType.SETSTATE;
            break;
          case "SetStateDynamicEntity":
            actionType = Global.ActionType.SETSTATEDYNAMICEVENT;
            break;
        }
        return actionType;
      }
    }

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
      if (((IExecutionContext) this.PluginContext).MessageName.Length > 3 && ((IExecutionContext) this.PluginContext).MessageName.ToLower().IndexOf("ait_") == 0 || ((IExecutionContext) this.PluginContext).MessageName.ToLower().IndexOf("ait_") == 0)
      {
        int stage1 = this.PluginContext.Stage;
        workflow_stage workflowStage = workflow_stage.Preoperation;
        int hashCode1 = workflowStage.GetHashCode();
        if (stage1 == hashCode1)
        {
          if (this.OnPluginPreCustomActionFiring == null)
            return;
          this.OnPluginPreCustomActionFiring((object) this.PluginContext, new EntityBase.PluginPreCustomActionHandlerEventArgs());
        }
        else
        {
          int stage2 = this.PluginContext.Stage;
          workflowStage = workflow_stage.Postoperation;
          int hashCode2 = workflowStage.GetHashCode();
          if (stage2 != hashCode2 || this.OnPluginPostCustomActionFiring == null)
            return;
          this.OnPluginPostCustomActionFiring((object) this.PluginContext, new EntityBase.PluginPostCustomActionHandlerEventArgs());
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Create")
      {
        int stage3 = this.PluginContext.Stage;
        workflow_stage workflowStage = workflow_stage.Preoperation;
        int hashCode3 = workflowStage.GetHashCode();
        if (stage3 == hashCode3)
        {
          if (this.OnPluginPreCreating == null)
            return;
          this.OnPluginPreCreating((object) this.PluginContext, new EntityBase.PluginOnPreCreateHandlerEventArgs());
        }
        else
        {
          int stage4 = this.PluginContext.Stage;
          workflowStage = workflow_stage.Postoperation;
          int hashCode4 = workflowStage.GetHashCode();
          if (stage4 != hashCode4 || this.OnPluginPostCreating == null)
            return;
          this.OnPluginPostCreating((object) this.PluginContext, new EntityBase.PluginOnPostCreateHandlerEventArgs());
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Close")
      {
        int stage5 = this.PluginContext.Stage;
        workflow_stage workflowStage = workflow_stage.Preoperation;
        int hashCode5 = workflowStage.GetHashCode();
        if (stage5 == hashCode5)
        {
          if (this.OnPluginPreClosing == null)
            return;
          this.OnPluginPreClosing((object) this.PluginContext, new EntityBase.PluginOnPreCloseHandlerEventArgs());
        }
        else
        {
          int stage6 = this.PluginContext.Stage;
          workflowStage = workflow_stage.Postoperation;
          int hashCode6 = workflowStage.GetHashCode();
          if (stage6 != hashCode6 || this.OnPluginPostClosing == null)
            return;
          this.OnPluginPostClosing((object) this.PluginContext, new EntityBase.PluginOnPostCloseHandlerEventArgs());
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Update")
      {
        int stage7 = this.PluginContext.Stage;
        workflow_stage workflowStage = workflow_stage.Preoperation;
        int hashCode7 = workflowStage.GetHashCode();
        if (stage7 == hashCode7)
        {
          if (this.OnPluginPreUpdating == null)
            return;
          this.OnPluginPreUpdating((object) this.PluginContext, new EntityBase.PluginOnPreUpdateHandlerEventArgs());
        }
        else
        {
          int stage8 = this.PluginContext.Stage;
          workflowStage = workflow_stage.Postoperation;
          int hashCode8 = workflowStage.GetHashCode();
          if (stage8 != hashCode8 || this.OnPluginPostUpdating == null)
            return;
          this.OnPluginPostUpdating((object) this.PluginContext, new EntityBase.PluginOnPostUpdateHandlerEventArgs());
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Delete")
      {
        int stage9 = this.PluginContext.Stage;
        workflow_stage workflowStage = workflow_stage.Preoperation;
        int hashCode9 = workflowStage.GetHashCode();
        if (stage9 == hashCode9)
        {
          if (this.OnPluginPreDeleting == null)
            return;
          this.OnPluginPreDeleting((object) this.PluginContext, new EntityBase.PluginOnPreDeleteHandlerEventArgs());
        }
        else
        {
          int stage10 = this.PluginContext.Stage;
          workflowStage = workflow_stage.Postoperation;
          int hashCode10 = workflowStage.GetHashCode();
          if (stage10 != hashCode10 || this.OnPluginPostDeleting == null)
            return;
          this.OnPluginPostDeleting((object) this.PluginContext, new EntityBase.PluginOnPostDeleteHandlerEventArgs());
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "SetStateDynamicEntity")
      {
        if (this.PluginContext.Stage == 10)
        {
          if (this.OnPluginValidateStateChanging == null)
            return;
          this.OnPluginValidateStateChanging((object) this.PluginContext, new EntityBase.PluginOnPreStateChangeHandlerEventArgs());
        }
        else if (this.PluginContext.Stage == workflow_stage.Preoperation.GetHashCode())
        {
          if (this.OnPluginPreStateChanging == null)
            return;
          this.OnPluginPreStateChanging((object) this.PluginContext, new EntityBase.PluginOnPreStateChangeHandlerEventArgs());
        }
        else
        {
          if (this.PluginContext.Stage != workflow_stage.Postoperation.GetHashCode() || this.OnPluginPostStateChanging == null)
            return;
          this.OnPluginPostStateChanging((object) this.PluginContext, new EntityBase.PluginOnPostStateChangeHandlerEventArgs());
        }
      }
      else if (((IExecutionContext) this.PluginContext).MessageName == "Associate")
      {
        int stage11 = this.PluginContext.Stage;
        workflow_stage workflowStage = workflow_stage.Preoperation;
        int hashCode11 = workflowStage.GetHashCode();
        if (stage11 == hashCode11)
        {
          if (this.OnPluginPreAssociateChanging == null)
            return;
          this.OnPluginPreAssociateChanging((object) this.PluginContext, new EntityBase.PluginPreAssociateHandlerEventArgs());
        }
        else
        {
          int stage12 = this.PluginContext.Stage;
          workflowStage = workflow_stage.Postoperation;
          int hashCode12 = workflowStage.GetHashCode();
          if (stage12 != hashCode12 || this.OnPluginPostAssociateChanging == null)
            return;
          this.OnPluginPostAssociateChanging((object) this.PluginContext, new EntityBase.PluginPostAssociateHandlerEventArgs());
        }
      }
      else
      {
        if (!(((IExecutionContext) this.PluginContext).MessageName == "Disassociate"))
          return;
        int stage13 = this.PluginContext.Stage;
        workflow_stage workflowStage = workflow_stage.Preoperation;
        int hashCode13 = workflowStage.GetHashCode();
        if (stage13 == hashCode13)
        {
          if (this.OnPluginPreDisassociateChanging != null)
            this.OnPluginPreDisassociateChanging((object) this.PluginContext, new EntityBase.PluginPreDisassociateHandlerEventArgs());
        }
        else
        {
          int stage14 = this.PluginContext.Stage;
          workflowStage = workflow_stage.Postoperation;
          int hashCode14 = workflowStage.GetHashCode();
          if (stage14 == hashCode14 && this.OnPluginPostDisassociateChanging != null)
            this.OnPluginPostDisassociateChanging((object) this.PluginContext, new EntityBase.PluginPostDisassociateHandlerEventArgs());
        }
      }
    }

    public T GetInputEntity<T>() where T : Entity
    {
      return ((Entity) ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"]).ToEntity<T>();
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
      return !((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PreEntityImages).ContainsKey(nameof (EntityBase)) ? this.GetInputEntity<T>() : ((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PreEntityImages)[nameof (EntityBase)].ToEntity<T>();
    }

    public T GetEntityFromPostImage<T>() where T : Entity
    {
      T entityFromPostImage = default (T);
      if (((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PostEntityImages).ContainsKey(nameof (EntityBase)))
        entityFromPostImage = ((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PostEntityImages)[nameof (EntityBase)].ToEntity<T>();
      return entityFromPostImage;
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
          if (((DataCollection<string, object>) entityFromPreImage.Attributes).ContainsKey(attribute.ToLower()))
            original = ((DataCollection<string, object>) entityFromPreImage.Attributes)[attribute.ToLower()];
          object compareTo = !((DataCollection<string, object>) currentImage.Attributes).ContainsKey(attribute.ToLower()) ? original : currentImage[attribute.ToLower()];
          flag = original != null && compareTo == null || original == null && compareTo != null || !AttributeLibrary.Compare(original, compareTo);
        }
      }
      return flag;
    }

    public object GetAttributeValue(string attributeName)
    {
      if (((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters).Contains("Target"))
      {
        Entity inputParameter = (Entity) ((DataCollection<string, object>) ((IExecutionContext) this.PluginContext).InputParameters)["Target"];
        if (((DataCollection<string, object>) inputParameter.Attributes).ContainsKey(attributeName) && inputParameter[attributeName] != null)
          return inputParameter[attributeName];
      }
      if (((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PreEntityImages).Contains(nameof (EntityBase)))
      {
        Entity preEntityImage = ((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PreEntityImages)[nameof (EntityBase)];
        if (((DataCollection<string, object>) preEntityImage.Attributes).ContainsKey(attributeName))
          return preEntityImage[attributeName];
      }
      if (((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PostEntityImages).Contains(nameof (EntityBase)))
      {
        Entity postEntityImage = ((DataCollection<string, Entity>) ((IExecutionContext) this.PluginContext).PostEntityImages)[nameof (EntityBase)];
        if (((DataCollection<string, object>) postEntityImage.Attributes).ContainsKey(attributeName))
          return postEntityImage[attributeName];
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

    protected virtual string GetEntityNameProperty() => "ait_name";

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

    protected virtual string GetPropertyName()
    {
      string propertyName = ObjectLibrary.GetPropertyName((object) this.GetBaseImageForUpdate());
      if (string.IsNullOrEmpty(propertyName))
        propertyName = "ait_name";
      return propertyName;
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
        if (string.IsNullOrEmpty(propertyName))
          throw new InvalidPluginExecutionException(string.Format("The nameProperty cannot be empty in UpdateName call for {0}.", (object) this.EntityLogicalName));
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
    public void TraceMethodStart()
    {
      this.CrmService.TracingService.Trace("Method start: {0}", new object[1]
      {
        (object) new StackTrace().GetFrame(1).GetMethod().Name
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TraceMethodEnd()
    {
      this.CrmService.TracingService.Trace("Method end: {0}", new object[1]
      {
        (object) new StackTrace().GetFrame(1).GetMethod().Name
      });
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TraceMethodEnd(string returnValue)
    {
      StackFrame frame = new StackTrace().GetFrame(1);
      string str = string.Empty;
      if (!string.IsNullOrEmpty(returnValue))
        str = string.Format("; Value: {0}", (object) returnValue);
      this.CrmService.TracingService.Trace("Method end: {0}{1}", new object[2]
      {
        (object) frame.GetMethod().Name,
        (object) str
      });
    }

    public void Trace(string format, params object[] args)
    {
      this.CrmService.TracingService.Trace(format, args);
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
  }
}
