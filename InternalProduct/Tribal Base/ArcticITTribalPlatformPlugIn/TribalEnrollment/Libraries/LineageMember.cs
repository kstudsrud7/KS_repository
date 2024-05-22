// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Libraries.LineageMember
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.TribalEnrollment.Libraries
{
  [DataContract]
  public class LineageMember
  {
    private FamilyTreeMember _familyTreeMember = (FamilyTreeMember) null;

    private FamilyTreeMember _FamilyTreeMember
    {
      get => this._familyTreeMember;
      set
      {
        this._familyTreeMember = value;
        if (this._familyTreeMember == null)
          return;
        this.Level = this._familyTreeMember.Level;
        this.Id = ((Entity) this._familyTreeMember.MemberProfile).Id;
        this.ChildCount = this._familyTreeMember.ChildCount;
        if (this._familyTreeMember.MemberProfile.ait_biologicalfatherprofile != null)
          this.FatherId = this._familyTreeMember.MemberProfile.ait_biologicalfatherprofile.Id;
        if (this._familyTreeMember.MemberProfile.ait_biologicalmotherprofile != null)
          this.MotherId = this._familyTreeMember.MemberProfile.ait_biologicalmotherprofile.Id;
      }
    }

    public LineageMember(FamilyTreeMember familyTreeMember)
    {
      this._FamilyTreeMember = familyTreeMember;
    }

    [DataMember]
    public Guid Id { get; private set; }

    [DataMember]
    public int Level { get; private set; }

    [DataMember]
    public Guid FatherId { get; private set; }

    [DataMember]
    public Guid MotherId { get; private set; }

    [DataMember]
    public int ChildCount { get; private set; }
  }
}
