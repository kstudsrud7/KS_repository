// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.MetadataLibrary
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  internal class MetadataLibrary
  {
    private static ConcurrentDictionary<string, OptionSetMetadata> _optionSetMetadataDictionary = new ConcurrentDictionary<string, OptionSetMetadata>();
    private static ConcurrentDictionary<string, string> _nameAttributeDictionary = new ConcurrentDictionary<string, string>();
    private static ConcurrentDictionary<string, RetrieveAttributeResponse> _attributeMetadataDictionary = new ConcurrentDictionary<string, RetrieveAttributeResponse>();
    private static ConcurrentDictionary<string, EntityMetadata> _entityMetadataSimpleDictionary = new ConcurrentDictionary<string, EntityMetadata>();

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

    public static string GetStatusCodeName(
      IOrganizationService crmService,
      string entityLogicalName,
      int valueToRetrieve)
    {
      string statusCodeName = string.Empty;
      OptionMetadata optionMetadata = ((IEnumerable<OptionMetadata>) ((EnumAttributeMetadata) ((RetrieveAttributeResponse) crmService.Execute((OrganizationRequest) new RetrieveAttributeRequest()
      {
        EntityLogicalName = entityLogicalName,
        LogicalName = "statuscode"
      })).AttributeMetadata).OptionSet.Options).First<OptionMetadata>((Func<OptionMetadata, bool>) (value =>
      {
        int? nullable = value.Value;
        int num = valueToRetrieve;
        return nullable.GetValueOrDefault() == num & nullable.HasValue;
      }));
      if (optionMetadata != null)
        statusCodeName = optionMetadata.Label.UserLocalizedLabel.Label;
      return statusCodeName;
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
        OptionSetMetadata optionSetMetadata;
        if (MetadataLibrary._optionSetMetadataDictionary.ContainsKey(optionSetName))
        {
          optionSetMetadata = MetadataLibrary._optionSetMetadataDictionary[optionSetName];
        }
        else
        {
          RetrieveOptionSetRequest optionSetRequest = new RetrieveOptionSetRequest()
          {
            Name = optionSetName
          };
          optionSetMetadata = (OptionSetMetadata) ((RetrieveOptionSetResponse) service.Execute((OrganizationRequest) optionSetRequest)).OptionSetMetadata;
          if (!MetadataLibrary._optionSetMetadataDictionary.ContainsKey(optionSetName))
            MetadataLibrary._optionSetMetadataDictionary.TryAdd(optionSetName, optionSetMetadata);
        }
        foreach (OptionMetadata optionMetadata in ((DataCollection<OptionMetadata>) optionSetMetadata.Options).ToArray())
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
      RetrieveAttributeResponse attributeMetadata = MetadataLibrary.GetAttributeMetadata(crmService, entityLogicalName, attributeName);
      if (attributeMetadata != null)
        attributeDisplayName = ((Collection<LocalizedLabel>) attributeMetadata.AttributeMetadata.DisplayName.LocalizedLabels)[0].Label;
      return attributeDisplayName;
    }

    public static int GetAttributeStringLength(
      IOrganizationService crmService,
      string entityLogicalName,
      string attributeName)
    {
      return ((StringAttributeMetadata) MetadataLibrary.GetAttributeMetadata(crmService, entityLogicalName, attributeName).AttributeMetadata).MaxLength.Value;
    }

    public static string GetEntityDisplayName(
      IOrganizationService crmService,
      string entityLogicalName)
    {
      string entityDisplayName = string.Empty;
      EntityMetadata entityMetadata = MetadataLibrary.GetEntityMetadata(crmService, entityLogicalName);
      if (entityMetadata != null)
        entityDisplayName = ((Collection<LocalizedLabel>) entityMetadata.DisplayName.LocalizedLabels)[0].Label;
      return entityDisplayName;
    }

    public static string GetPrimaryNameAttribute(
      IOrganizationService crmService,
      string entityLogicalName)
    {
      string primaryNameAttribute = string.Empty;
      if (MetadataLibrary._nameAttributeDictionary.ContainsKey(entityLogicalName))
        return MetadataLibrary._nameAttributeDictionary[entityLogicalName];
      if (string.IsNullOrEmpty(primaryNameAttribute))
      {
        string name = string.Format("{0}.{1}", (object) "TPCourt.EarlyBound", (object) entityLogicalName);
        Type type = typeof (MetadataLibrary).Assembly.GetType(name);
        if (crmService is FrameworkService)
          TracingLibrary.Trace((FrameworkService) crmService, string.Format("GetPrimaryNameAttribute: Type not found: {0}", (object) name));
        primaryNameAttribute = ObjectLibrary.GetPropertyName(type);
      }
      if (string.IsNullOrEmpty(primaryNameAttribute))
      {
        EntityMetadata entityMetadata = MetadataLibrary.GetEntityMetadata(crmService, entityLogicalName);
        if (entityMetadata != null)
          primaryNameAttribute = entityMetadata.PrimaryNameAttribute;
      }
      if (!string.IsNullOrEmpty(primaryNameAttribute))
        MetadataLibrary._nameAttributeDictionary.TryAdd(entityLogicalName, primaryNameAttribute);
      return primaryNameAttribute;
    }

    private static RetrieveAttributeResponse GetAttributeMetadata(
      IOrganizationService crmService,
      string entityLogicalName,
      string attributeName)
    {
      string key = string.Format("{0}-{1}", (object) entityLogicalName, (object) attributeName);
      RetrieveAttributeResponse attributeMetadata;
      if (MetadataLibrary._attributeMetadataDictionary.ContainsKey(key))
      {
        attributeMetadata = MetadataLibrary._attributeMetadataDictionary[key];
      }
      else
      {
        RetrieveAttributeRequest attributeRequest = new RetrieveAttributeRequest()
        {
          EntityLogicalName = entityLogicalName,
          LogicalName = attributeName
        };
        attributeMetadata = (RetrieveAttributeResponse) crmService.Execute((OrganizationRequest) attributeRequest);
        if (attributeMetadata != null)
          MetadataLibrary._attributeMetadataDictionary.TryAdd(key, attributeMetadata);
      }
      return attributeMetadata;
    }

    private static EntityMetadata GetEntityMetadata(
      IOrganizationService crmService,
      string entityLogicalName)
    {
      if (MetadataLibrary._entityMetadataSimpleDictionary.ContainsKey(entityLogicalName))
        return MetadataLibrary._entityMetadataSimpleDictionary[entityLogicalName];
      EntityMetadata entityMetadata = ((RetrieveEntityResponse) crmService.Execute((OrganizationRequest) new RetrieveEntityRequest()
      {
        RetrieveAsIfPublished = false,
        LogicalName = entityLogicalName,
        EntityFilters = (EntityFilters) 1
      })).EntityMetadata;
      if (entityMetadata != null && !MetadataLibrary._entityMetadataSimpleDictionary.TryAdd(entityLogicalName, entityMetadata) && crmService is FrameworkService)
        TracingLibrary.Trace((FrameworkService) crmService, "GetEntityMetadata: Metadata not added to dictionary.");
      return entityMetadata;
    }
  }
}
