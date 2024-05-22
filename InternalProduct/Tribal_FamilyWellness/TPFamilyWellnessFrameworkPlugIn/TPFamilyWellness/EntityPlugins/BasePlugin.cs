// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EntityPlugins.BasePlugin
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

#nullable disable
namespace TPFamilyWellness.EntityPlugins
{
  public abstract class BasePlugin : IPlugin
  {
    private Collection<BasePlugin.PluginEvent> registeredEvents;

    protected Collection<BasePlugin.PluginEvent> RegisteredEvents
    {
      get
      {
        if (this.registeredEvents == null)
          this.registeredEvents = new Collection<BasePlugin.PluginEvent>();
        return this.registeredEvents;
      }
    }

    internal BasePlugin(string unsecureConfig, string secureConfig)
    {
      this.UnsecureConfig = unsecureConfig;
      this.SecureConfig = secureConfig;
    }

    public string UnsecureConfig { get; private set; }

    public string SecureConfig { get; private set; }

    public void Execute(IServiceProvider serviceProvider)
    {
      ITracingService itracingService = serviceProvider != null ? (ITracingService) serviceProvider.GetService(typeof (ITracingService)) : throw new ArgumentNullException(nameof (serviceProvider));
      IPluginExecutionContext pluginContext = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
      itracingService.Trace(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Entered {0}.Execute()", (object) this.GetType().ToString()), Array.Empty<object>());
      try
      {
        IEnumerable<Action<IServiceProvider>> source = this.RegisteredEvents.Where<BasePlugin.PluginEvent>((Func<BasePlugin.PluginEvent, bool>) (a =>
        {
          if (a.Stage != (BasePlugin.eStage) pluginContext.Stage || (string.IsNullOrWhiteSpace(a.MessageName) ? 1 : (a.MessageName.ToLowerInvariant() == ((IExecutionContext) pluginContext).MessageName.ToLowerInvariant() ? 1 : 0)) == 0)
            return false;
          return string.IsNullOrWhiteSpace(a.EntityName) || a.EntityName.ToLowerInvariant() == ((IExecutionContext) pluginContext).PrimaryEntityName.ToLowerInvariant();
        })).Select<BasePlugin.PluginEvent, Action<IServiceProvider>>((Func<BasePlugin.PluginEvent, Action<IServiceProvider>>) (a => a.PluginAction));
        if (!source.Any<Action<IServiceProvider>>())
          return;
        foreach (Action<IServiceProvider> action in source)
        {
          itracingService.Trace(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "{0} is firing for Entity: {1}, Message: {2}, Method: {3}", (object) this.GetType().ToString(), (object) ((IExecutionContext) pluginContext).PrimaryEntityName, (object) ((IExecutionContext) pluginContext).MessageName, (object) action.Method.Name), Array.Empty<object>());
          action(serviceProvider);
        }
      }
      catch (Exception ex)
      {
        itracingService.Trace(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Exception: {0}", (object) ex.ToString()), Array.Empty<object>());
        throw;
      }
      finally
      {
        itracingService.Trace(string.Format((IFormatProvider) CultureInfo.InvariantCulture, "Exiting {0}.Execute()", (object) this.GetType().ToString()), Array.Empty<object>());
      }
    }

    protected class LocalPluginContext<T> : IDisposable where T : Entity
    {
      internal OrganizationServiceContext CrmContext { get; private set; }

      internal IServiceProvider ServiceProvider { get; private set; }

      internal IOrganizationServiceFactory ServiceFactory { get; private set; }

      internal IOrganizationService OrganizationService { get; private set; }

      internal IPluginExecutionContext PluginExecutionContext { get; private set; }

      internal ITracingService TracingService { get; private set; }

      internal BasePlugin.eStage Stage => (BasePlugin.eStage) this.PluginExecutionContext.Stage;

      internal int Depth => ((IExecutionContext) this.PluginExecutionContext).Depth;

      internal string MessageName => ((IExecutionContext) this.PluginExecutionContext).MessageName;

      internal LocalPluginContext(IServiceProvider serviceProvider)
      {
        this.TracingService = serviceProvider != null ? (ITracingService) serviceProvider.GetService(typeof (ITracingService)) : throw new ArgumentNullException(nameof (serviceProvider));
        this.PluginExecutionContext = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
        this.ServiceFactory = (IOrganizationServiceFactory) serviceProvider.GetService(typeof (IOrganizationServiceFactory));
        this.OrganizationService = this.ServiceFactory.CreateOrganizationService(new Guid?(((IExecutionContext) this.PluginExecutionContext).UserId));
        this.CrmContext = new OrganizationServiceContext(this.OrganizationService);
      }

      internal void Trace(string message)
      {
        if (string.IsNullOrWhiteSpace(message) || this.TracingService == null)
          return;
        if (this.PluginExecutionContext == null)
          this.TracingService.Trace(message, Array.Empty<object>());
        else
          this.TracingService.Trace("{0}, Correlation Id: {1}, Initiating User: {2}", new object[3]
          {
            (object) message,
            (object) ((IExecutionContext) this.PluginExecutionContext).CorrelationId,
            (object) ((IExecutionContext) this.PluginExecutionContext).InitiatingUserId
          });
      }

      public void Dispose()
      {
        if (this.CrmContext == null)
          return;
        this.CrmContext.Dispose();
      }

      internal T PreImage
      {
        get
        {
          return ((IEnumerable<KeyValuePair<string, Entity>>) ((IExecutionContext) this.PluginExecutionContext).PreEntityImages).Any<KeyValuePair<string, Entity>>() ? this.GetEntityAsType(((DataCollection<string, Entity>) ((IExecutionContext) this.PluginExecutionContext).PreEntityImages)[((IEnumerable<KeyValuePair<string, Entity>>) ((IExecutionContext) this.PluginExecutionContext).PreEntityImages).FirstOrDefault<KeyValuePair<string, Entity>>().Key]) : default (T);
        }
      }

      internal T PostImage
      {
        get
        {
          return ((IEnumerable<KeyValuePair<string, Entity>>) ((IExecutionContext) this.PluginExecutionContext).PostEntityImages).Any<KeyValuePair<string, Entity>>() ? this.GetEntityAsType(((DataCollection<string, Entity>) ((IExecutionContext) this.PluginExecutionContext).PostEntityImages)[((IEnumerable<KeyValuePair<string, Entity>>) ((IExecutionContext) this.PluginExecutionContext).PostEntityImages).FirstOrDefault<KeyValuePair<string, Entity>>().Key]) : default (T);
        }
      }

      internal Entity TargetEntity
      {
        get
        {
          return ((DataCollection<string, object>) ((IExecutionContext) this.PluginExecutionContext).InputParameters).Contains("Target") ? ((DataCollection<string, object>) ((IExecutionContext) this.PluginExecutionContext).InputParameters)["Target"] as Entity : (Entity) null;
        }
      }

      internal EntityReference TargetEntityReference
      {
        get
        {
          return ((DataCollection<string, object>) ((IExecutionContext) this.PluginExecutionContext).InputParameters).Contains("Target") ? ((DataCollection<string, object>) ((IExecutionContext) this.PluginExecutionContext).InputParameters)["Target"] as EntityReference : (EntityReference) null;
        }
      }

      private T GetEntityAsType(Entity entity)
      {
        return typeof (T) == entity.GetType() ? entity as T : entity.ToEntity<T>();
      }
    }

    protected enum eStage
    {
      PreValidation = 10, // 0x0000000A
      PreOperation = 20, // 0x00000014
      PostOperation = 40, // 0x00000028
    }

    protected class PluginEvent
    {
      public BasePlugin.eStage Stage { get; set; }

      public string EntityName { get; set; }

      public string MessageName { get; set; }

      public Action<IServiceProvider> PluginAction { get; set; }
    }
  }
}
