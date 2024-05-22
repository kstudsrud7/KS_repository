// Decompiled with JetBrains decompiler
// Type: TribalPlatformPlugIn.EntityPlugins.UpdateClientProfileTribalID
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace TribalPlatformPlugIn.EntityPlugins
{
  public class UpdateClientProfileTribalID : IPlugin
  {
    private IOrganizationService Service { get; set; }

    private static Entity Target { get; set; }

    public void Execute(IServiceProvider serviceProvider)
    {
      IPluginExecutionContext service1 = (IPluginExecutionContext) serviceProvider.GetService(typeof (IPluginExecutionContext));
      IOrganizationServiceFactory service2 = (IOrganizationServiceFactory) serviceProvider.GetService(typeof (IOrganizationServiceFactory));
      ITracingService service3 = (ITracingService) serviceProvider.GetService(typeof (ITracingService));
      this.Service = service2.CreateOrganizationService(new Guid?(((IExecutionContext) service1).UserId));
      Entity inputParameter = ((DataCollection<string, object>) ((IExecutionContext) service1).InputParameters)["Target"] == null || !(((DataCollection<string, object>) ((IExecutionContext) service1).InputParameters)["Target"] is Entity) ? (Entity) null : (Entity) ((DataCollection<string, object>) ((IExecutionContext) service1).InputParameters)["Target"];
      if (inputParameter == null)
        return;
      try
      {
        string attributeValue = inputParameter.GetAttributeValue<string>("ait_tribalid");
        foreach (Entity associatedClientProfile in this.GetAssociatedClientProfiles(inputParameter.Id))
          this.Service.Update(new Entity(associatedClientProfile.LogicalName)
          {
            Id = associatedClientProfile.Id,
            ["ait_tribalid"] = (object) attributeValue
          });
      }
      catch (Exception ex)
      {
        throw new InvalidPluginExecutionException(ex.Message);
      }
    }

    private List<Entity> GetAssociatedClientProfiles(Guid conId)
    {
      return ((IEnumerable<Entity>) this.Service.RetrieveMultiple((QueryBase) new FetchExpression("<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>  <entity name='ait_clientprofile'>    <attribute name='ait_tribalid' />    <attribute name='ait_clientprofileid' />    <order attribute='ait_name' descending='false' />    <filter type='and'>      <condition attribute='ait_contact' operator='eq' value='" + conId.ToString() + "' />    </filter>  </entity></fetch>")).Entities).ToList<Entity>();
    }
  }
}
