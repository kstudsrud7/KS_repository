// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.OptionSets.WorkflowDependency_Type
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.OptionSets
{
  [DataContract]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public enum WorkflowDependency_Type
  {
    [EnumMember] Sdkassociation = 1,
    [EnumMember] Localparameter = 2,
    [EnumMember] Primaryentity = 3,
    [EnumMember] PrimaryentitybeforeSDKoperation = 4,
    [EnumMember] PrimaryentityafterSDKoperation = 5,
    [EnumMember] Relatedentity = 6,
    [EnumMember] Customentitydefinitionthatworkflowdependson = 7,
    [EnumMember] Attributedefinitionthatworkflowdependson = 8,
    [EnumMember] ArgumentEntitythatworkflowdependson = 9,
  }
}
