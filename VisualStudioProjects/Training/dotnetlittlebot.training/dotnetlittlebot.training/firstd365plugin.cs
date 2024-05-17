using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace dotnetlittlebot.training
{
    public class first365plugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            // Obtain the tracing service
            ITracingService tracingService =
                (ITracingService)serviceProvider.GetService(typeof(ITracingService));

            // Obtain the execution context from the service provider.
            IPluginExecutionContext context = (IPluginExecutionContext)
                serviceProvider.GetService(typeof(IPluginExecutionContext));

            // The InputParameters collection contains all the data passed in the message request.
            if (context.InputParameters.Contains("Target") &&
                context.InputParameters["Target"] is Entity)
            {
                // Obtain the target entity from the input parameters.
                Entity targetEntity = (Entity)context.InputParameters["Target"];

                // Obtain the IOrganizationService instance which you will need for
                // web service calls.
                IOrganizationServiceFactory serviceFactory =
                    (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
                IOrganizationService service = serviceFactory.CreateOrganizationService(context.UserId);

                try
                {
                    Entity updateAutoNumberConfig = new Entity("sss_autonumberapplication");
                    StringBuilder autoNumber = new StringBuilder();
                    string prefix, suffix, separator, current, year, month, day;
                    DateTime today = DateTime.Now;
                    day = today.Day.ToString("00");
                    month = today.Month.ToString("00");
                    year = today.Year.ToString("00");

                    QueryExpression qeAutoNumberApplication = new QueryExpression()
                    {
                        EntityName = "sss_autonumberapplication",
                        ColumnSet = new ColumnSet("sss_prefix", "sss_separator", "sss_suffix", "sss_currentnumber", "sss_name")
                    };

                    EntityCollection ecAutoNumberApplication = service.RetrieveMultiple(qeAutoNumberApplication);

                    if (ecAutoNumberApplication.Entities.Count == 0)
                    {
                        return;
                    }

                    foreach (Entity autoNumberEntity in ecAutoNumberApplication.Entities)
                    {
                        if (autoNumberEntity.Attributes["sss_name"].ToString().ToLower() == "applicationautonumber")
                        {
                            prefix = autoNumberEntity.GetAttributeValue<string>("sss_prefix");
                            separator = autoNumberEntity.GetAttributeValue<string>("sss_separator");
                            suffix = autoNumberEntity.GetAttributeValue<string>("sss_suffix");
                            current = autoNumberEntity.GetAttributeValue<string>("sss_currentnumber");
                            int tempCurrent = int.Parse(current);
                            tempCurrent++;
                            current = tempCurrent.ToString("000000");
                            updateAutoNumberConfig.Id = autoNumberEntity.Id;
                            updateAutoNumberConfig["sss_currentnumber"] = current;
                            service.Update(updateAutoNumberConfig);
                            autoNumber.Append(prefix + separator + year + separator + month + separator + day + separator + suffix + separator + current);
                            break;
                        }
                    }

                    targetEntity["sss_application"] = autoNumber.ToString();
                }

                catch (FaultException<OrganizationServiceFault> ex)
                {
                    throw new InvalidPluginExecutionException("An error occurred in FollowUpPlugin.", ex);
                }

                catch (Exception ex)
                {
                    tracingService.Trace("FollowUpPlugin: {0}", ex.ToString());
                    throw;
                }
            }
        }
    }
}