// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Plugins.PluginAbstract
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

#nullable disable
namespace ArcticIT.CrmFramework.Plugins
{
  public abstract class PluginAbstract : IPlugin
  {
    private string _unsecuredConfiguration;
    private string _securedConfiguration;
    private static ConcurrentBag<string> _notFoundList = new ConcurrentBag<string>();
    private static ConcurrentDictionary<string, Type> _entityTypeDictionary = new ConcurrentDictionary<string, Type>();

    public ExecutionMode ExecutionMode { get; protected set; }

    public PluginAbstract(string unsecureConfig, string secureConfig)
    {
      this._unsecuredConfiguration = unsecureConfig;
      this._securedConfiguration = secureConfig;
    }

    public void Execute(IServiceProvider serviceProvider) => this.RunPlugin(serviceProvider);

    public void RunPlugin(IServiceProvider serviceProvider)
    {
      DateTime startTime = new DateTime();
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
        TracingLibrary.Trace(frameworkService, "Error: Entity Base could not be found.", startTime);
      }
    }

    public EntityBase GetEntityBase(IServiceProvider serviceProvider)
    {
      IPluginExecutionContext service = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
      Type type1 = (Type) null;
      string entityName = ((IExecutionContext) service).PrimaryEntityName;
      if (this._unsecuredConfiguration == null || !this._unsecuredConfiguration.Contains("ValidateDeleteAggregation"))
      {
        if (entityName == "none" && (((IExecutionContext) service).MessageName.ToLower().StartsWith("bia_") || ((IExecutionContext) service).MessageName.ToLower().StartsWith("ait_")))
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
      }
      if ((Type) null == type1)
      {
        if (entityName == "teammembership_association")
        {
          entityName = "teammembership";
          TracingLibrary.Trace(serviceProvider, string.Format("Primary {0}: Rename teammembership_association to {1}", (object) ((IExecutionContext) service).PrimaryEntityName, (object) entityName));
        }
        else if (entityName == "systemuserroles_association")
        {
          entityName = "systemuserroles";
          TracingLibrary.Trace(serviceProvider, string.Format("Primary {0}: Rename systemuserroles_association to {1}", (object) ((IExecutionContext) service).PrimaryEntityName, (object) entityName));
        }
        else if (entityName == "teamroles_association")
        {
          entityName = "teamroles";
          TracingLibrary.Trace(serviceProvider, string.Format("Primary {0}: Rename teamroles_association to {1}", (object) ((IExecutionContext) service).PrimaryEntityName, (object) entityName));
        }
        if (!PluginAbstract._notFoundList.Contains<string>(entityName))
        {
          if (PluginAbstract._entityTypeDictionary.ContainsKey(entityName))
          {
            type1 = PluginAbstract._entityTypeDictionary[entityName];
          }
          else
          {
            try
            {
              type1 = ((IEnumerable<Type>) Assembly.GetExecutingAssembly().GetTypes()).Where<Type>((Func<Type, bool>) (type => type.IsClass && type.IsSubclassOf(typeof (EntityBase)) && (CRMMetadataAttribute) type.GetCustomAttributes(typeof (CRMMetadataAttribute), false)[0] != null && ((CRMMetadataAttribute) type.GetCustomAttributes(typeof (CRMMetadataAttribute), false)[0]).EntityName != null && ((CRMMetadataAttribute) type.GetCustomAttributes(typeof (CRMMetadataAttribute), false)[0]).EntityName.Equals(entityName, StringComparison.CurrentCultureIgnoreCase))).FirstOrDefault<Type>();
              if ((Type) null != type1)
                PluginAbstract._entityTypeDictionary.GetOrAdd(entityName, type1);
            }
            catch (NullReferenceException ex)
            {
              TracingLibrary.Trace(serviceProvider, string.Format("Error: NullReference getting plugin type for: {0}.", (object) entityName));
              return (EntityBase) null;
            }
            catch (IndexOutOfRangeException ex)
            {
              TracingLibrary.Trace(serviceProvider, string.Format("Error: IndexOutOfRange getting plugin type for: {0}.", (object) entityName));
              return (EntityBase) null;
            }
          }
        }
        else
          TracingLibrary.Trace(serviceProvider, "Skip check since entity type in not found list.");
      }
      if (type1 == (Type) null)
      {
        if (!PluginAbstract._notFoundList.Contains<string>(entityName))
          PluginAbstract._notFoundList.Add(entityName);
        string message = string.Format("Entity type not found for entity: {0}", (object) entityName);
        FrameworkLog.WriteEntry(FrameworkLog.GetEventMessage(service, message), EventLogEntryType.Error, FrameworkLog.GetEventLogId(service));
        TracingLibrary.Trace(serviceProvider, message);
        return (EntityBase) null;
      }
      EntityBase entityBase = (EntityBase) type1.GetConstructor(new Type[3]
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
      if (entityBase == null)
        TracingLibrary.Trace(serviceProvider, string.Format("Error: Trying to retrieve plugin for: {0}.", (object) entityName));
      else
        entityBase.ExecutionMode = this.ExecutionMode;
      return entityBase;
    }

    private void XPath() => throw new NotImplementedException();
  }
}
