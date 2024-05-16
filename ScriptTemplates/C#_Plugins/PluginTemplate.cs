using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace PluginTest.Plugins
{
    public class Plugin1 : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the tracing service**
            ITracingService tracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

            // Obtain the execution context from the service provider**
            IPluginExecutionContext context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            // The InputParameter collection contains all the data that is passed in the message request **
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                // Obtain the target entity from the input parameters **
                Entity entity = (Entity)context.InputParameters["Target"];

                // Obtain the organization service reference so we can make web service/API calls **
                IOrganizationServiceFactory serviceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                try  // Beginning of Plugin Logic
                {
                    // Input Logic

                }
                catch (System.ServiceModel.FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An Error Has Occurred in Task Plugin", ex); // Update to Plugin Name
                }
                catch (Exception ex) //Leverageing Tracing Service
                {
                    tracingService.Trace("PLUGIN: {0}", ex.ToString()); //has to be the name of the plugin**
                    throw;
                }
            }
        }
    }
}
