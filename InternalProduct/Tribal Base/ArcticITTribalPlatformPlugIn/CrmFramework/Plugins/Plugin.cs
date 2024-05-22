// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.Plugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

#nullable disable
namespace ArcticIT.CrmFramework.Plugins
{
  public class Plugin : IPlugin
  {
    private string _unsecuredConfiguration;
    private string _securedConfiguration;

    public Plugin(string unsecureConfig, string secureConfig)
    {
      this._unsecuredConfiguration = unsecureConfig;
      this._securedConfiguration = secureConfig;
    }

    public void Execute(IServiceProvider serviceProvider) => this.RunPlugin(serviceProvider);

    public void RunPlugin(IServiceProvider serviceProvider)
    {
      EntityBase entityBase = this.GetEntityBase(serviceProvider);
      if (entityBase != null)
      {
        TracingLibrary.Trace(entityBase.CrmService, entityBase);
        try
        {
          entityBase.PluginDoWork();
          FrameworkLog.WriteEntry(entityBase);
        }
        catch (Exception ex)
        {
          TracingLibrary.Trace(entityBase.CrmService, ex, "Uncaught exception");
          throw;
        }
      }
      else
      {
        FrameworkService frameworkService = new FrameworkService(serviceProvider);
        TracingLibrary.Trace(frameworkService, entityBase);
        TracingLibrary.Trace(frameworkService, "Error: Entity Base could not be found.");
      }
    }

    public EntityBase GetEntityBase(IServiceProvider serviceProvider)
    {
      IPluginExecutionContext service = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
      Type type1 = (Type) null;
      string entityName = ((IExecutionContext) service).PrimaryEntityName;
      if (this._unsecuredConfiguration != null && this._unsecuredConfiguration.Contains("ValidateDeleteAggregation"))
        type1 = typeof (ValidateDeleteAggregationPlugin);
      else if (entityName == "none" && (((IExecutionContext) service).MessageName.ToLower().StartsWith("ait_") || ((IExecutionContext) service).MessageName.ToLower().StartsWith("ait_")))
      {
        if (((DataCollection<string, object>) ((IExecutionContext) service).InputParameters).Contains("Target"))
        {
          EntityReference inputParameter = (EntityReference) ((DataCollection<string, object>) ((IExecutionContext) service).InputParameters)["Target"];
          if (inputParameter != null)
            entityName = inputParameter.LogicalName;
        }
        else
          entityName = "ait_organizationconfiguration";
      }
      else if ((entityName == null || entityName.ToLower().Equals("none")) && (((IExecutionContext) service).MessageName.ToLower().Equals("associate") || ((IExecutionContext) service).MessageName.ToLower().Equals("disassociate")))
      {
        try
        {
          entityName = ((Relationship) ((DataCollection<string, object>) ((IExecutionContext) service).InputParameters)["Relationship"]).SchemaName;
          if (!string.IsNullOrEmpty(entityName) && entityName.Length > 43)
            entityName = entityName.Substring(0, 43);
        }
        catch (Exception ex)
        {
        }
      }
      if ((Type) null == type1)
      {
        Assembly executingAssembly = Assembly.GetExecutingAssembly();
        try
        {
          type1 = ((IEnumerable<Type>) executingAssembly.GetTypes()).Where<Type>((Func<Type, bool>) (type => type.IsClass && type.IsSubclassOf(typeof (EntityBase)) && (CRMMetadataAttribute) type.GetCustomAttributes(typeof (CRMMetadataAttribute), false)[0] != null && ((CRMMetadataAttribute) type.GetCustomAttributes(typeof (CRMMetadataAttribute), false)[0]).EntityName != null && ((CRMMetadataAttribute) type.GetCustomAttributes(typeof (CRMMetadataAttribute), false)[0]).EntityName.Equals(entityName, StringComparison.CurrentCultureIgnoreCase))).FirstOrDefault<Type>();
        }
        catch (NullReferenceException ex)
        {
          TracingLibrary.Trace(serviceProvider, string.Format("Error: NullReference getting plugin type for: {0}.", (object) entityName));
          TracingLibrary.Trace(serviceProvider, string.Format("Error: Searching assembly: {0}.", (object) executingAssembly.FullName));
          return (EntityBase) null;
        }
        catch (IndexOutOfRangeException ex)
        {
          TracingLibrary.Trace(serviceProvider, string.Format("Error: IndexOutOfRange getting plugin type for: {0}.", (object) entityName));
          TracingLibrary.Trace(serviceProvider, string.Format("Error: Searching assembly: {0}.", (object) executingAssembly.FullName));
          return (EntityBase) null;
        }
      }
      if (type1 == (Type) null)
      {
        string message = string.Format("Entity type not found for entity: {0}", (object) entityName);
        FrameworkLog.WriteEntry(FrameworkLog.GetEventMessage(service, message), EventLogEntryType.Error, FrameworkLog.GetEventLogId(service));
        return (EntityBase) null;
      }
      return (EntityBase) type1.GetConstructor(new Type[3]
      {
        typeof (IServiceProvider),
        typeof (string),
        typeof (string)
      }).Invoke(new object[3]
      {
        (object) serviceProvider,
        (object) this._unsecuredConfiguration,
        (object) this._securedConfiguration
      });
    }

    private void XPath() => throw new NotImplementedException();
  }
}
