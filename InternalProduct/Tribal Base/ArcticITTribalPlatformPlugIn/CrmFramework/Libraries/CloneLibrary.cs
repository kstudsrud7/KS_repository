// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.CloneLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class CloneLibrary
  {
    public static Entity CloneEntityUnsaved(
      IOrganizationService crmService,
      Entity originalEntity,
      Dictionary<string, object> attributeUpdateList)
    {
      string[] attributesToSkipIn = new string[0];
      return CloneLibrary.CloneEntityUnsaved(crmService, originalEntity, attributeUpdateList, attributesToSkipIn);
    }

    public static Entity CloneEntityUnsaved(
      IOrganizationService crmService,
      Entity originalEntity,
      Dictionary<string, object> attributeUpdateList,
      string[] attributesToSkipIn)
    {
      Entity clonedEntity = originalEntity != null ? new Entity()
      {
        LogicalName = originalEntity.LogicalName
      } : throw new ArgumentNullException(nameof (originalEntity));
      clonedEntity.Id = crmService.Create(clonedEntity);
      CloneLibrary.CopyEntityAttributes(originalEntity, clonedEntity, attributeUpdateList, attributesToSkipIn);
      return clonedEntity;
    }

    public static Entity CloneEntity(
      IOrganizationService crmService,
      Entity originalEntity,
      Dictionary<string, object> attributeUpdateList)
    {
      Entity clonedEntity = originalEntity != null ? new Entity()
      {
        LogicalName = originalEntity.LogicalName
      } : throw new ArgumentNullException(nameof (originalEntity));
      clonedEntity.Id = crmService.Create(clonedEntity);
      CloneLibrary.CopyEntityAttributes(originalEntity, clonedEntity, attributeUpdateList);
      crmService.Update(clonedEntity);
      new SetStateRequest().EntityMoniker = clonedEntity.ToEntityReference();
      return clonedEntity;
    }

    public static bool CopyEntityAttributes(
      Entity originalEntity,
      Entity clonedEntity,
      Dictionary<string, object> attributeUpdateList)
    {
      string[] attributesToSkipIn = new string[0];
      return CloneLibrary.CopyEntityAttributes(originalEntity, clonedEntity, attributeUpdateList, attributesToSkipIn);
    }

    public static bool CopyEntityAttributes(
      Entity originalEntity,
      Entity clonedEntity,
      Dictionary<string, object> attributeUpdateList,
      string[] attributesToSkipIn)
    {
      bool flag1 = false;
      string[] source = new string[8]
      {
        "state",
        "statecode",
        "status",
        "createdby",
        "createdon",
        "modifiedby",
        "modifiedon",
        "activityid"
      };
      string str1 = originalEntity.LogicalName + "id";
      foreach (string key in (IEnumerable<string>) ((DataCollection<string, object>) originalEntity.Attributes).Keys)
      {
        string lower = key.ToLower();
        bool flag2 = false;
        if (!(lower == "id") && !(lower == str1) && !((IEnumerable<string>) source).Contains<string>(lower) && (attributesToSkipIn == null || !((IEnumerable<string>) attributesToSkipIn).Contains<string>(lower)))
        {
          object compareTo = ((DataCollection<string, object>) originalEntity.Attributes)[key];
          if (attributeUpdateList != null && attributeUpdateList.ContainsKey(key))
            compareTo = attributeUpdateList[key];
          if (((DataCollection<string, object>) clonedEntity.Attributes).ContainsKey(key))
            flag2 = AttributeLibrary.Compare(clonedEntity[key], compareTo);
          if (!flag2)
          {
            flag1 = true;
            clonedEntity[key] = compareTo;
          }
        }
      }
      foreach (string str2 in ((DataCollection<string, object>) clonedEntity.Attributes).Keys.ToArray<string>())
      {
        if (!((DataCollection<string, object>) originalEntity.Attributes).ContainsKey(str2))
          clonedEntity[str2] = (object) null;
      }
      return flag1;
    }
  }
}
