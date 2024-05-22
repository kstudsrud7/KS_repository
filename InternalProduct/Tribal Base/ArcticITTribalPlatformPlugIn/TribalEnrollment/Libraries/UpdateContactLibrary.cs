// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Libraries.UpdateContactLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

#nullable disable
namespace ArcticIT.TribalEnrollment.Libraries
{
  public static class UpdateContactLibrary
  {
    public static int GMT_EST_OFFSET = DateTime.Now.IsDaylightSavingTime() ? -4 : -5;

    public static DataCollection<Entity> FetchAllRecords(
      string fetchxml,
      IOrganizationService CrmService,
      int pageLimit,
      int count,
      ref string pagingCookie,
      ref int page,
      ref bool hasMoreRecords,
      ITracingService tracingService)
    {
      int num = 1;
      bool flag = false;
      DataCollection<Entity> dataCollection = (DataCollection<Entity>) null;
      while (!flag)
      {
        tracingService.Trace("PageLimitCount: Page: {0}", new object[1]
        {
          (object) num
        });
        EntityCollection entityCollection = UpdateContactLibrary.FetchDataSet(UpdateContactLibrary.CreateXml(fetchxml, pagingCookie, page, count), CrmService);
        pagingCookie = entityCollection.PagingCookie;
        if (dataCollection == null)
          dataCollection = entityCollection.Entities;
        else
          dataCollection.AddRange((IEnumerable<Entity>) entityCollection.Entities);
        if (!entityCollection.MoreRecords)
        {
          flag = true;
          hasMoreRecords = false;
          ++page;
        }
        else
        {
          ++page;
          ++num;
          hasMoreRecords = true;
        }
      }
      return dataCollection;
    }

    private static EntityCollection FetchDataSet(string fetchXml, IOrganizationService CrmService)
    {
      FetchExpression fetchExpression = new FetchExpression(fetchXml);
      return CrmService.RetrieveMultiple((QueryBase) fetchExpression);
    }

    private static string CreateXml(string xml, string cookie, int page, int count)
    {
      XmlTextReader reader = new XmlTextReader((TextReader) new StringReader(xml));
      XmlDocument doc = new XmlDocument();
      doc.Load((XmlReader) reader);
      return UpdateContactLibrary.CreateXml(doc, cookie, page, count);
    }

    private static string CreateXml(XmlDocument doc, string cookie, int page, int count)
    {
      XmlAttributeCollection attributes = doc.DocumentElement.Attributes;
      if (cookie != null)
      {
        XmlAttribute attribute = doc.CreateAttribute("paging-cookie");
        attribute.Value = cookie;
        attributes.Append(attribute);
      }
      XmlAttribute attribute1 = doc.CreateAttribute(nameof (page));
      attribute1.Value = Convert.ToString(page);
      attributes.Append(attribute1);
      XmlAttribute attribute2 = doc.CreateAttribute(nameof (count));
      attribute2.Value = Convert.ToString(count);
      attributes.Append(attribute2);
      StringBuilder sb = new StringBuilder(1024);
      XmlTextWriter w = new XmlTextWriter((TextWriter) new StringWriter(sb));
      doc.WriteTo((XmlWriter) w);
      w.Close();
      return sb.ToString();
    }
  }
}
