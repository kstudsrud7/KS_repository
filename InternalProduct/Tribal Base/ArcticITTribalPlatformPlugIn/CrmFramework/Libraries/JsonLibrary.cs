// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.JsonLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public static class JsonLibrary
  {
    public static string ConvertObjectToJSon<T>(T obj)
    {
      DataContractJsonSerializer contractJsonSerializer = new DataContractJsonSerializer(typeof (T));
      MemoryStream memoryStream = new MemoryStream();
      contractJsonSerializer.WriteObject((Stream) memoryStream, (object) obj);
      string json = Encoding.UTF8.GetString(memoryStream.ToArray());
      memoryStream.Close();
      return json;
    }

    public static T ConvertJSonToObject<T>(string jsonString)
    {
      return (T) new DataContractJsonSerializer(typeof (T)).ReadObject((Stream) new MemoryStream(Encoding.UTF8.GetBytes(jsonString)));
    }
  }
}
