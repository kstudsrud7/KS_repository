// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.FrameworkService
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using TPCourt.EarlyBound;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public class FrameworkService : IOrganizationService
  {
    private DateTime _createTime = DateTime.Now;

    public IOrganizationService OrganizationService { get; private set; }

    public IServiceProvider ServiceProvider { get; private set; }

    public IPluginExecutionContext PluginContext { get; private set; }

    public IWorkflowContext WorkflowContext { get; private set; }

    public CodeActivityContext CodeActivityContext { get; private set; }

    public IExecutionContext ExecutionContext { get; private set; }

    public OrganizationServiceContext CrmContext { get; private set; }

    public IOrganizationServiceFactory ServiceFactory { get; private set; }

    public ITracingService TracingService { get; private set; }

    public FrameworkService ParentFrameworkService { get; private set; }

    public int ExecuteCount { get; private set; }

    public int ExecuteRetrieveCount { get; private set; }

    public TimeSpan ExecuteRetrieveTime { get; private set; }

    public int RecordRetrieveMultipleCount { get; private set; }

    public int ExecuteRetrieveMultipleCount { get; private set; }

    public TimeSpan ExecuteRetrieveMultipleTime { get; private set; }

    public int ExecuteUpdateCount { get; private set; }

    public TimeSpan ExecuteUpdateTime { get; private set; }

    public int ExecuteDeleteCount { get; private set; }

    public TimeSpan ExecuteDeleteTime { get; private set; }

    public int ExecuteExecuteCount { get; private set; }

    public TimeSpan ExecuteExecuteTime { get; private set; }

    public int ExecuteCreateCount { get; private set; }

    public TimeSpan ExecuteCreateTime { get; private set; }

    public DateTime CreateTime => this._createTime;

    public TimeSpan TotalServiceCallTime
    {
      get
      {
        return this.ExecuteCreateTime + this.ExecuteExecuteTime + this.ExecuteDeleteTime + this.ExecuteUpdateTime + this.ExecuteRetrieveMultipleTime + this.ExecuteRetrieveTime;
      }
    }

    public FrameworkService(
      IServiceProvider serviceProvider,
      FrameworkService parentFrameworkService)
    {
      if (serviceProvider == null)
        throw new ArgumentNullException(nameof (serviceProvider));
      this.ParentFrameworkService = parentFrameworkService;
      this.ServiceProvider = serviceProvider;
      this.ServiceFactory = (IOrganizationServiceFactory) serviceProvider.GetService(typeof (IOrganizationServiceFactory));
      this.OrganizationService = this.ServiceFactory.CreateOrganizationService(new Guid?(((IExecutionContext) this.PluginContext).UserId));
      this.CrmContext = new OrganizationServiceContext(this.OrganizationService);
      this.PluginContext = (IPluginExecutionContext) this.ServiceProvider.GetService(typeof (IPluginExecutionContext));
      this.TracingService = (ITracingService) serviceProvider.GetService(typeof (ITracingService));
      this.ExecuteRetrieveTime = new TimeSpan();
      this.ExecuteRetrieveMultipleTime = new TimeSpan();
      this.ExecuteUpdateTime = new TimeSpan();
      this.ExecuteDeleteTime = new TimeSpan();
      this.ExecuteExecuteTime = new TimeSpan();
      this.ExecuteCreateTime = new TimeSpan();
    }

    public FrameworkService(IServiceProvider serviceProvider)
    {
      if (serviceProvider == null)
        throw new ArgumentNullException(nameof (serviceProvider));
      this.ParentFrameworkService = (FrameworkService) null;
      this.ServiceProvider = serviceProvider;
      this.PluginContext = (IPluginExecutionContext) this.ServiceProvider.GetService(typeof (IPluginExecutionContext));
      this.ExecutionContext = (IExecutionContext) this.PluginContext;
      this.TracingService = (ITracingService) this.ServiceProvider.GetService(typeof (ITracingService));
      this.ServiceFactory = (IOrganizationServiceFactory) serviceProvider.GetService(typeof (IOrganizationServiceFactory));
      this.OrganizationService = this.ServiceFactory.CreateOrganizationService(new Guid?(((IExecutionContext) this.PluginContext).UserId));
      this.CrmContext = new OrganizationServiceContext(this.OrganizationService);
    }

    public FrameworkService(CodeActivityContext executionContext)
    {
      this.CodeActivityContext = executionContext != null ? executionContext : throw new ArgumentNullException(nameof (executionContext));
      this.WorkflowContext = executionContext.GetExtension<IWorkflowContext>();
      this.ServiceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
      this.OrganizationService = this.ServiceFactory.CreateOrganizationService(new Guid?(((IExecutionContext) this.WorkflowContext).UserId));
      this.CrmContext = new OrganizationServiceContext(this.OrganizationService);
      this.TracingService = executionContext.GetExtension<ITracingService>();
    }

    public FrameworkService Impersonate() => this.Impersonate("CRM Admin");

    public FrameworkService Impersonate(string userName)
    {
      OrganizationServiceContext organizationServiceContext = new OrganizationServiceContext(this.OrganizationService);
      OrganizationServiceProxy organizationService = (OrganizationServiceProxy) this.OrganizationService;
      Guid guid = organizationServiceContext.CreateQuery<systemuser>().Where<systemuser>((Expression<Func<systemuser, bool>>) (user => user.firstname + " " + user.lastname == userName)).Select<systemuser, Guid>((Expression<Func<systemuser, Guid>>) (user => user.systemuserid)).FirstOrDefault<Guid>();
      organizationService.CallerId = guid;
      return new FrameworkService(this.ServiceProvider, this)
      {
        OrganizationService = (IOrganizationService) organizationService
      };
    }

    public IPluginExecutionContext GetTopParentContext()
    {
      return this.GetTopParentContext(this.PluginContext);
    }

    private IPluginExecutionContext GetTopParentContext(IPluginExecutionContext pluginContext)
    {
      return pluginContext == null || pluginContext.ParentContext == null ? pluginContext : this.GetTopParentContext(pluginContext.ParentContext);
    }

    public void Trace(string format, params object[] args)
    {
      if (this.TracingService == null)
        return;
      this.TracingService.Trace(format, args);
    }

    public void Trace(string argumentName, InArgument argument)
    {
      if (argument == null || this.CodeActivityContext == null)
        return;
      this.Trace(string.Format("InArgument: {0}-{1}-{2}", (object) argumentName, (object) argument.ArgumentType, argument.Get((ActivityContext) this.CodeActivityContext)));
    }

    public void Trace(string argumentName, OutArgument argument)
    {
      if (argument == null || this.CodeActivityContext == null)
        return;
      this.Trace(string.Format("OutArgument: {0}-{1}-{2}", (object) argumentName, (object) argument.ArgumentType, argument.Get((ActivityContext) this.CodeActivityContext)));
    }

    public void Associate(
      string entityName,
      Guid entityId,
      Relationship relationship,
      EntityReferenceCollection relatedEntities)
    {
      ++this.ExecuteCount;
      this.Trace("*FrameworkService.Associate({0}): {1}-{2}", (object) this.ExecuteCount, (object) entityName, (object) entityId);
      this.OrganizationService.Associate(entityName, entityId, relationship, relatedEntities);
    }

    public Guid Create(Entity entity)
    {
      if (entity == null)
      {
        this.Trace("FrameworkService.Create: entity cannot be null.");
        throw new InvalidPluginExecutionException("FrameworkServiice.Create entity cannot be null.");
      }
      ++this.ExecuteCreateCount;
      DateTime now = DateTime.Now;
      ++this.ExecuteCount;
      Guid empty = Guid.Empty;
      try
      {
        empty = this.OrganizationService.Create(entity);
      }
      catch (Exception ex)
      {
        this.Trace("Exception FrameworkService.Create({0},{1}): {2}", (object) this.ExecuteCount, (object) this.ExecuteCreateCount, (object) (entity != null ? entity.LogicalName : "Unkown"));
        throw;
      }
      finally
      {
      }
      TimeSpan timeSpan = this.ExecuteCreateTime;
      this.ExecuteCreateTime = timeSpan.Add(new TimeSpan((DateTime.Now - now).Ticks));
      timeSpan = DateTime.Now.Subtract(now);
      this.Trace("*FrameworkService.Create({0},{1}-{2}): {3}, {4}", (object) this.ExecuteCount, (object) this.ExecuteCreateCount, (object) timeSpan.TotalSeconds, (object) entity.LogicalName, (object) entity.ToEntityReference().Name);
      return empty;
    }

    public void Delete(Entity entity)
    {
      if (entity == null)
        throw new ArgumentNullException(nameof (entity));
      this.Delete(entity.ToEntityReference());
    }

    public void Delete(EntityReference entityReference)
    {
      if (entityReference == null)
        throw new ArgumentNullException(nameof (entityReference));
      this.Delete(entityReference.LogicalName, entityReference.Id);
    }

    public void Delete(string entityName, Guid id)
    {
      ++this.ExecuteDeleteCount;
      ++this.ExecuteCount;
      DateTime now = DateTime.Now;
      try
      {
        this.OrganizationService.Delete(entityName, id);
      }
      catch
      {
        this.Trace("Exception FrameworkService.Delete({0},{1}): {2}, {3}", (object) this.ExecuteCount, (object) this.ExecuteDeleteCount, (object) entityName, (object) id.ToString());
        throw;
      }
      finally
      {
        this.Trace("*FrameworkService.Delete({0},{1}-{2}): {3}, {4}", (object) this.ExecuteCount, (object) this.ExecuteDeleteCount, (object) DateTime.Now.Subtract(now).TotalSeconds, (object) entityName, (object) id.ToString());
      }
      this.ExecuteDeleteTime = this.ExecuteDeleteTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
    }

    public void Delete(string entityName, Guid id, string impersonateUser)
    {
      this.Impersonate(impersonateUser).Delete(entityName, id);
    }

    public void Disassociate(
      string entityName,
      Guid entityId,
      Relationship relationship,
      EntityReferenceCollection relatedEntities)
    {
      ++this.ExecuteCount;
      this.OrganizationService.Disassociate(entityName, entityId, relationship, relatedEntities);
    }

    public OrganizationResponse Execute(OrganizationRequest request)
    {
      OrganizationResponse organizationResponse = (OrganizationResponse) null;
      ++this.ExecuteExecuteCount;
      ++this.ExecuteCount;
      string str = string.Empty;
      switch (request)
      {
        case RetrieveEntityRequest _:
          str = string.Format(" - {0}:{1}", (object) ((RetrieveEntityRequest) request).LogicalName, (object) ((RetrieveEntityRequest) request).EntityFilters);
          break;
        case RetrieveOptionSetRequest _:
          str = string.Format(" - {0}", (object) ((RetrieveOptionSetRequest) request).Name);
          break;
        case AssociateRequest _:
          AssociateRequest associateRequest = (AssociateRequest) request;
          str = string.Format(" - {0}, Target: {1}-{2}; Related: ", (object) associateRequest.Relationship.SchemaName, (object) associateRequest.Target.LogicalName, (object) associateRequest.Target.Id);
          using (IEnumerator<EntityReference> enumerator = ((Collection<EntityReference>) associateRequest.RelatedEntities).GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              EntityReference current = enumerator.Current;
              str += string.Format(" {0}-{1}|", (object) current.LogicalName, (object) current.Id);
            }
            break;
          }
      }
      DateTime now = DateTime.Now;
      try
      {
        organizationResponse = this.OrganizationService.Execute(request);
      }
      catch
      {
        this.Trace("Exception FrameworkService.Execute({0},{1}): {2}{3}", (object) this.ExecuteCount, (object) this.ExecuteExecuteCount, (object) request.RequestName, (object) str);
        throw;
      }
      finally
      {
        TimeSpan timeSpan = this.ExecuteExecuteTime;
        this.ExecuteExecuteTime = timeSpan.Add(new TimeSpan((DateTime.Now - now).Ticks));
        timeSpan = DateTime.Now.Subtract(now);
        this.Trace("*FrameworkService.Execute({0},{1}-{2}): {3}{4}", (object) this.ExecuteCount, (object) this.ExecuteExecuteCount, (object) timeSpan.TotalSeconds, (object) request.RequestName, (object) str);
      }
      return organizationResponse;
    }

    public Entity Retrieve(string entityName, Guid id, ColumnSet columnSet)
    {
      ++this.ExecuteRetrieveCount;
      ++this.ExecuteCount;
      Entity entity = (Entity) null;
      DateTime now = DateTime.Now;
      try
      {
        entity = this.OrganizationService.Retrieve(entityName, id, columnSet);
      }
      catch
      {
        this.Trace("Exception FrameworkService.Retrieve({0},{1}): {2}, {3}", (object) this.ExecuteCount, (object) this.ExecuteRetrieveCount, (object) entityName, (object) id.ToString());
        throw;
      }
      finally
      {
        this.ExecuteRetrieveTime = this.ExecuteRetrieveTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
        this.Trace("*FrameworkService.Retrieve({0},{1}-{2}): {3}, {4}", (object) this.ExecuteCount, (object) this.ExecuteRetrieveCount, (object) DateTime.Now.Subtract(now).TotalSeconds, (object) entityName, (object) id.ToString());
      }
      return entity;
    }

    public EntityCollection RetrieveMultiple(QueryBase query)
    {
      ++this.ExecuteRetrieveMultipleCount;
      ++this.ExecuteCount;
      DateTime now = DateTime.Now;
      EntityCollection entityCollection;
      try
      {
        entityCollection = this.OrganizationService.RetrieveMultiple(query);
      }
      catch
      {
        this.Trace("Exception FrameworkService.RetrieveMultiple({0},{1}): {2}", (object) this.ExecuteCount, (object) this.ExecuteRetrieveMultipleCount, (object) this.RecordRetrieveMultipleCount);
        throw;
      }
      double totalSeconds = DateTime.Now.Subtract(now).TotalSeconds;
      if (entityCollection != null)
        this.RecordRetrieveMultipleCount += ((Collection<Entity>) entityCollection.Entities).Count;
      this.ExecuteRetrieveMultipleTime = this.ExecuteRetrieveMultipleTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
      switch (query)
      {
        case QueryExpression _:
          QueryExpression queryExpression = (QueryExpression) query;
          this.Trace("*FrameworkService.RetrieveMultiple({0},{1}-{2}): {3}, {4}", (object) this.ExecuteCount, (object) this.ExecuteRetrieveMultipleCount, (object) totalSeconds, (object) this.RecordRetrieveMultipleCount, (object) queryExpression.EntityName);
          break;
        case QueryByAttribute _:
          QueryByAttribute queryByAttribute = (QueryByAttribute) query;
          this.Trace("*FrameworkService.RetrieveMultiple({0},{1}-{2}): {3}, {4}", (object) this.ExecuteCount, (object) this.ExecuteRetrieveMultipleCount, (object) totalSeconds, (object) this.RecordRetrieveMultipleCount, (object) queryByAttribute.EntityName);
          break;
        case FetchExpression _:
          FetchExpression fetchExpression = (FetchExpression) query;
          this.Trace("*FrameworkService.RetrieveMultiple({0},{1}-{2}): {3}, {4}", (object) this.ExecuteCount, (object) this.ExecuteRetrieveMultipleCount, (object) totalSeconds, (object) this.RecordRetrieveMultipleCount, (object) fetchExpression.Query);
          break;
        default:
          this.Trace("*FrameworkService.RetrieveMultiple({0},{1}-{2}): {3}", (object) this.ExecuteCount, (object) this.ExecuteRetrieveMultipleCount, (object) totalSeconds, (object) this.RecordRetrieveMultipleCount);
          break;
      }
      return entityCollection;
    }

    public void Update(Entity entity)
    {
      if (entity == null)
        return;
      string[] attributeList = new string[3]
      {
        "owningteam",
        "owninguser",
        "owningbusinessunit"
      };
      EntityLibrary.RemoveAttributes(entity, attributeList);
      this.UpdateAll(entity);
    }

    public void UpdateChanged(Entity updateEntity, Entity originalEntity)
    {
      if (TracingLibrary.TraceObjectNull((object) updateEntity, nameof (updateEntity), this) || TracingLibrary.TraceObjectNull((object) originalEntity, nameof (originalEntity), this))
        return;
      if (updateEntity.LogicalName != originalEntity.LogicalName)
        throw new InvalidPluginExecutionException(string.Format("UpdateChanged: Entity types not the same {0} - {1}", (object) updateEntity.LogicalName, (object) originalEntity.LogicalName));
      string[] attributeList = new string[3]
      {
        "owningteam",
        "owninguser",
        "owningbusinessunit"
      };
      EntityLibrary.RemoveAttributes(updateEntity, attributeList);
      string str = EntityLibrary.RemoveAttributesUnchanged(updateEntity, originalEntity);
      if (!string.IsNullOrEmpty(str))
        this.Trace("FrameworkService.UpdateChanged({0},{1}): Removed unchanged attributes: {2}", (object) updateEntity.LogicalName, (object) updateEntity.Id, (object) str);
      if (((DataCollection<string, object>) updateEntity.Attributes).Count < 1)
        this.Trace("FrameworkService.UpdateChanged({0},{1}):  No attributes remain for update, exit.", (object) updateEntity.LogicalName, (object) updateEntity.Id);
      else
        this.UpdateAll(updateEntity);
    }

    public void UpdateAll(Entity entity)
    {
      ++this.ExecuteUpdateCount;
      ++this.ExecuteCount;
      string attributeList = TracingLibrary.GetAttributeList(entity);
      DateTime now = DateTime.Now;
      try
      {
        this.OrganizationService.Update(entity);
      }
      catch
      {
        this.Trace("Exception FrameworkService.Update({0},{1}): {2}, {3}: {4}", (object) this.ExecuteCount, (object) this.ExecuteUpdateCount, (object) entity.LogicalName, (object) entity.ToEntityReference().Name, (object) attributeList);
        throw;
      }
      finally
      {
        this.Trace("*FrameworkService.Update({0},{1}-{2}): {3}, {4}: {5}", (object) this.ExecuteCount, (object) this.ExecuteUpdateCount, (object) DateTime.Now.Subtract(now).TotalSeconds, (object) entity.LogicalName, (object) entity.ToEntityReference().Name, (object) attributeList);
        this.ExecuteUpdateTime = this.ExecuteUpdateTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
      }
    }
  }
}
