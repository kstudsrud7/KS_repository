// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.FrameworkService
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Workflow;
using System;
using System.Activities;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;

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

    public ITracingService TracingService { get; private set; }

    public FrameworkService ParentFrameworkService { get; private set; }

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
      this.PluginContext = (IPluginExecutionContext) this.ServiceProvider.GetService(typeof (IPluginExecutionContext));
      this.TracingService = (ITracingService) serviceProvider.GetService(typeof (ITracingService));
      this.OrganizationService = ((IOrganizationServiceFactory) this.ServiceProvider.GetService(typeof (IOrganizationServiceFactory))).CreateOrganizationService(new Guid?(((IExecutionContext) this.PluginContext).UserId));
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
      this.OrganizationService = ((IOrganizationServiceFactory) this.ServiceProvider.GetService(typeof (IOrganizationServiceFactory))).CreateOrganizationService(new Guid?(((IExecutionContext) this.PluginContext).UserId));
    }

    public FrameworkService(CodeActivityContext executionContext)
    {
      this.CodeActivityContext = executionContext != null ? executionContext : throw new ArgumentNullException(nameof (executionContext));
      this.WorkflowContext = executionContext.GetExtension<IWorkflowContext>();
      this.ExecutionContext = (IExecutionContext) this.WorkflowContext;
      this.OrganizationService = executionContext.GetExtension<IOrganizationServiceFactory>().CreateOrganizationService(new Guid?(((IExecutionContext) this.WorkflowContext).UserId));
      this.TracingService = executionContext.GetExtension<ITracingService>();
    }

    public FrameworkService ImpersonateAdmin()
    {
      Guid? systemUserId = this.GetSystemUserID("SYSTEM", this.OrganizationService);
      IOrganizationService organizationService = ((IOrganizationServiceFactory) this.ServiceProvider.GetService(typeof (IOrganizationServiceFactory))).CreateOrganizationService(systemUserId);
      return new FrameworkService(this.ServiceProvider, this)
      {
        OrganizationService = organizationService
      };
    }

    public FrameworkService Impersonate() => this.Impersonate("CRM Admin");

    public FrameworkService Impersonate(string userName)
    {
      this.Trace("Entering Impersonate");
      try
      {
        OrganizationServiceContext organizationServiceContext = new OrganizationServiceContext(this.OrganizationService);
        OrganizationServiceProxy organizationService = (OrganizationServiceProxy) this.OrganizationService;
        this.Trace("Initialization of variables complete");
        Guid guid = organizationServiceContext.CreateQuery<SystemUser>().Where<SystemUser>((Expression<Func<SystemUser, bool>>) (user => user.FullName == userName)).Select<SystemUser, Guid>((Expression<Func<SystemUser, Guid>>) (user => user.SystemUserId.Value)).FirstOrDefault<Guid>();
        this.Trace("First attempt to set userId" + guid.ToString());
        organizationService.CallerId = guid;
        FrameworkService frameworkService = new FrameworkService(this.ServiceProvider, this);
        frameworkService.OrganizationService = (IOrganizationService) organizationService;
        this.Trace("success return from Impersonate" + frameworkService?.ToString());
        return frameworkService;
      }
      catch
      {
        this.Trace("Entering catch of Impersonate");
        return this;
      }
    }

    public IPluginExecutionContext GetTopParentContext()
    {
      return this.GetTopParentContext(this.PluginContext);
    }

    private IPluginExecutionContext GetTopParentContext(IPluginExecutionContext pluginContext)
    {
      return pluginContext == null || pluginContext.ParentContext == null ? pluginContext : this.GetTopParentContext(pluginContext.ParentContext);
    }

    private Guid? GetSystemUserID(string name, IOrganizationService service)
    {
      QueryByAttribute queryByAttribute = new QueryByAttribute()
      {
        EntityName = "systemuser",
        ColumnSet = new ColumnSet(new string[1]
        {
          "systemuserid"
        })
      };
      queryByAttribute.AddAttributeValue("fullname", (object) name);
      EntityCollection entityCollection = service.RetrieveMultiple((QueryBase) queryByAttribute);
      return entityCollection != null && ((Collection<Entity>) entityCollection.Entities).Count > 0 ? new Guid?(((Collection<Entity>) entityCollection.Entities)[0].Id) : new Guid?();
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
      this.OrganizationService.Associate(entityName, entityId, relationship, relatedEntities);
    }

    public Guid Create(Entity entity)
    {
      ++this.ExecuteCreateCount;
      this.Trace("Enter FrameworkService.Create({0}): {1}, {2}", (object) this.ExecuteCreateCount, (object) entity.LogicalName, (object) entity.ToEntityReference().Name);
      DateTime now = DateTime.Now;
      Guid guid = this.OrganizationService.Create(entity);
      this.ExecuteCreateTime = this.ExecuteCreateTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
      return guid;
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
      this.Trace("Enter FrameworkService.Delete({0}): {1}, {2}", (object) this.ExecuteDeleteCount, (object) entityName, (object) id.ToString());
      DateTime now = DateTime.Now;
      this.OrganizationService.Delete(entityName, id);
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
      this.OrganizationService.Disassociate(entityName, entityId, relationship, relatedEntities);
    }

    public OrganizationResponse Execute(OrganizationRequest request)
    {
      ++this.ExecuteExecuteCount;
      this.Trace("Enter FrameworkService.Execute({0}): {1}", (object) this.ExecuteExecuteCount, (object) request.RequestName);
      DateTime now = DateTime.Now;
      OrganizationResponse organizationResponse = this.OrganizationService.Execute(request);
      this.ExecuteExecuteTime = this.ExecuteExecuteTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
      return organizationResponse;
    }

    public Entity Retrieve(string entityName, Guid id, ColumnSet columnSet)
    {
      ++this.ExecuteRetrieveCount;
      this.Trace("Enter FrameworkService.Retrieve({0}): {1}, {2}", (object) this.ExecuteRetrieveCount, (object) entityName, (object) id.ToString());
      DateTime now = DateTime.Now;
      Entity entity = this.OrganizationService.Retrieve(entityName, id, columnSet);
      this.ExecuteRetrieveTime = this.ExecuteRetrieveTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
      return entity;
    }

    public EntityCollection RetrieveMultiple(QueryBase query)
    {
      ++this.ExecuteRetrieveMultipleCount;
      DateTime now = DateTime.Now;
      EntityCollection entityCollection = this.OrganizationService.RetrieveMultiple(query);
      if (entityCollection != null)
        this.RecordRetrieveMultipleCount += ((Collection<Entity>) entityCollection.Entities).Count;
      this.ExecuteRetrieveMultipleTime = this.ExecuteRetrieveMultipleTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
      switch (query)
      {
        case QueryExpression _:
          this.Trace("Exit FrameworkService.RetrieveMultiple({0}): {1}, {2}", (object) this.ExecuteRetrieveMultipleCount, (object) this.RecordRetrieveMultipleCount, (object) ((QueryExpression) query).EntityName);
          break;
        case QueryByAttribute _:
          this.Trace("Exit FrameworkService.RetrieveMultiple({0}): {1}, {2}", (object) this.ExecuteRetrieveMultipleCount, (object) this.RecordRetrieveMultipleCount, (object) ((QueryByAttribute) query).EntityName);
          break;
        case FetchExpression _:
          this.Trace("Exit FrameworkService.RetrieveMultiple({0}): {1}, {2}", (object) this.ExecuteRetrieveMultipleCount, (object) this.RecordRetrieveMultipleCount, (object) ((FetchExpression) query).Query);
          break;
        default:
          this.Trace("Exit FrameworkService.RetrieveMultiple({0}): {1}", (object) this.ExecuteRetrieveMultipleCount, (object) this.RecordRetrieveMultipleCount);
          break;
      }
      return entityCollection;
    }

    public void Update(Entity entity)
    {
      if (entity == null)
        return;
      string[] attributeList = new string[4]
      {
        "ownerid",
        "owningteam",
        "owninguser",
        "owningbusinessunit"
      };
      EntityLibrary.RemoveAttributes(entity, attributeList);
      this.UpdateAll(entity);
    }

    public void UpdateAll(Entity entity)
    {
      ++this.ExecuteUpdateCount;
      this.Trace("Enter FrameworkService.Update({0}): {1}, {2}", (object) this.ExecuteUpdateCount, (object) entity.LogicalName, (object) entity.ToEntityReference().Name);
      DateTime now = DateTime.Now;
      this.OrganizationService.Update(entity);
      this.ExecuteUpdateTime = this.ExecuteUpdateTime.Add(new TimeSpan((DateTime.Now - now).Ticks));
    }
  }
}
