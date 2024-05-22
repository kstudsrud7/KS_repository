// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.MetadataLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  internal class MetadataLibrary
  {
    public static int GetStatusCode(
      IOrganizationService crmService,
      string entityLogicalName,
      string statusName)
    {
      int statusCode = -1;
      OptionMetadata optionMetadata = ((IEnumerable<OptionMetadata>) ((EnumAttributeMetadata) ((RetrieveAttributeResponse) crmService.Execute((OrganizationRequest) new RetrieveAttributeRequest()
      {
        EntityLogicalName = entityLogicalName,
        LogicalName = "statuscode"
      })).AttributeMetadata).OptionSet.Options).First<OptionMetadata>((Func<OptionMetadata, bool>) (value => value.Label.UserLocalizedLabel.Label == statusName));
      if (optionMetadata != null)
        statusCode = optionMetadata.Value.Value;
      return statusCode;
    }

    public static string GetOptionSetText(
      IOrganizationService service,
      string optionSetName,
      OptionSetValue optionSetValue)
    {
      string optionSetText = string.Empty;
      if (optionSetValue != null)
        optionSetText = MetadataLibrary.GetOptionSetText(service, optionSetName, optionSetValue.Value);
      return optionSetText;
    }

    public static string GetOptionSetText(
      IOrganizationService service,
      string optionSetName,
      int optionSetValue)
    {
      string empty = string.Empty;
      try
      {
        RetrieveOptionSetRequest optionSetRequest = new RetrieveOptionSetRequest()
        {
          Name = optionSetName
        };
        foreach (OptionMetadata optionMetadata in ((DataCollection<OptionMetadata>) ((OptionSetMetadata) ((RetrieveOptionSetResponse) service.Execute((OrganizationRequest) optionSetRequest)).OptionSetMetadata).Options).ToArray())
        {
          int? nullable = optionMetadata.Value;
          int num = optionSetValue;
          if (nullable.GetValueOrDefault() == num & nullable.HasValue)
          {
            empty = optionMetadata.Label.UserLocalizedLabel.Label.ToString();
            break;
          }
        }
      }
      catch (Exception ex)
      {
        throw;
      }
      return empty;
    }

    public static string GetAttributeDisplayName(
      IOrganizationService crmService,
      string entityLogicalName,
      string attributeName)
    {
      string attributeDisplayName = string.Empty;
      foreach (AttributeMetadata attribute in ((RetrieveEntityResponse) crmService.Execute((OrganizationRequest) new RetrieveEntityRequest()
      {
        RetrieveAsIfPublished = false,
        LogicalName = entityLogicalName,
        EntityFilters = (EntityFilters) 2
      })).EntityMetadata.Attributes)
      {
        if (attribute.LogicalName == attributeName)
          attributeDisplayName = ((Collection<LocalizedLabel>) attribute.DisplayName.LocalizedLabels)[0].Label;
      }
      return attributeDisplayName;
    }

    public static string GetEntityDisplayName(
      IOrganizationService crmService,
      string entityLogicalName)
    {
      string entityDisplayName = string.Empty;
      EntityMetadata entityMetadata = ((RetrieveEntityResponse) crmService.Execute((OrganizationRequest) new RetrieveEntityRequest()
      {
        RetrieveAsIfPublished = false,
        LogicalName = entityLogicalName,
        EntityFilters = (EntityFilters) 1
      })).EntityMetadata;
      if (entityMetadata != null)
        entityDisplayName = ((Collection<LocalizedLabel>) entityMetadata.DisplayName.LocalizedLabels)[0].Label;
      return entityDisplayName;
    }
  }
}
