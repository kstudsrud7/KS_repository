// Decompiled with JetBrains decompiler
// Type: ArcticIT.Framework.Libraries.AuditHistoryLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;

#nullable disable
namespace ArcticIT.Framework.Libraries
{
  internal class AuditHistoryLibrary
  {
    public static void UpdateEntityAttributeLastChangeDate(
      DataCollection<Entity> entityCollection,
      string auditFieldName,
      string auditFieldValue,
      string dateFieldNameToUpdate,
      IOrganizationService CrmService)
    {
      for (int index = 0; index < ((Collection<Entity>) entityCollection).Count; ++index)
      {
        Entity entity = ((Collection<Entity>) entityCollection)[index];
        foreach (AttributeAuditDetail attributeAuditDetail in ((IEnumerable) ((RetrieveRecordChangeHistoryResponse) CrmService.Execute((OrganizationRequest) new RetrieveRecordChangeHistoryRequest()
        {
          Target = new EntityReference(entity.LogicalName, entity.Id)
        })).AuditDetailCollection.AuditDetails).OfType<AttributeAuditDetail>())
        {
          if (((AuditDetail) attributeAuditDetail).AuditRecord != null)
          {
            AttributeCollection attributes1 = ((AuditDetail) attributeAuditDetail).AuditRecord.Attributes;
            if (((AuditDetail) attributeAuditDetail).AuditRecord != null && ((AuditDetail) attributeAuditDetail).AuditRecord.Attributes != null)
            {
              AttributeCollection attributes2 = attributeAuditDetail.NewValue.Attributes;
              if (((DataCollection<string, object>) attributes2).Contains(auditFieldName) && ((DataCollection<string, object>) attributes2)[auditFieldName] != null && (auditFieldValue == null || ((OptionSetValue) ((DataCollection<string, object>) attributes2)[auditFieldName]).Value.ToString() == auditFieldValue))
              {
                CrmService.Update(new Entity(entity.LogicalName, entity.Id)
                {
                  [dateFieldNameToUpdate] = (object) (DateTime) ((DataCollection<string, object>) attributes1)["createdon"]
                });
                break;
              }
            }
          }
        }
      }
    }
  }
}
