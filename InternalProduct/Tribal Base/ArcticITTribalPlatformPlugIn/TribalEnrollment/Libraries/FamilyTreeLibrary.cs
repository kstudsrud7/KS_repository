// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Libraries.FamilyTreeLibrary
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.TribalEnrollment.EntityPlugins;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

#nullable disable
namespace ArcticIT.TribalEnrollment.Libraries
{
  public class FamilyTreeLibrary
  {
    private Dictionary<string, FamilyTreeMember> familyTreeMemberDictionary = new Dictionary<string, FamilyTreeMember>();
    private Dictionary<int, int> generationLevelCount = new Dictionary<int, int>();
    private string generationMessage = string.Empty;
    private FamilyTreeType familyTreeType;
    private string _reportHeading = string.Empty;
    private string _reportName = string.Empty;

    private FrameworkService CrmService { get; set; }

    public FamilyTreeLibrary(FrameworkService crmService)
    {
      this.CrmService = crmService != null ? crmService : throw new ArgumentNullException(nameof (crmService));
    }

    public ait_memberprofile MemberProfile { get; set; }

    public string ReportHeading
    {
      get
      {
        if (string.IsNullOrEmpty(this._reportHeading))
        {
          ait_tribe entity = (ait_tribe) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, TribalEnrollmentConfiguration.GetDefaultTribe(this.CrmService), false);
          this._reportHeading = entity == null ? "Tribe Report" : entity.ait_officialname;
        }
        return this._reportHeading;
      }
      set => this._reportHeading = value;
    }

    public string ReportName
    {
      get
      {
        if (string.IsNullOrEmpty(this._reportName))
        {
          string str1 = "Ancestor";
          if (this.familyTreeType == FamilyTreeType.Descendant)
            str1 = "Descendant";
          Contact entity = (Contact) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, this.MemberProfile.ait_Contact, false);
          if (entity != null)
          {
            string str2 = ",";
            if (!string.IsNullOrEmpty(entity.Suffix))
              str2 = string.Format(" {0},", (object) entity.Suffix);
            this._reportName = string.Format("{0} Family Tree Chart for {1}{2} {3} {4}{5}", (object) str1, (object) entity.LastName, (object) str2, (object) entity.FirstName, (object) entity.MiddleName, (object) this.generationMessage);
          }
        }
        return this._reportName;
      }
      set => this._reportName = value;
    }

    public string GetHeaderString()
    {
      ait_tribalenrollmentconfiguration configuration = TribalEnrollmentConfiguration.GetConfiguration(this.CrmService, true);
      string reportHeading = this.ReportHeading;
      string reportName = this.ReportName;
      string str1 = "";
      string str2 = "";
      if (configuration != null)
      {
        str1 = (string.IsNullOrEmpty(configuration.ait_ReportFooterInformation) ? string.Empty : configuration.ait_ReportFooterInformation).Replace("\n", "<br />");
        ait_tribalenrollmentconfiguration entityImage = (ait_tribalenrollmentconfiguration) EntityLibrary.GetEntityImage((IOrganizationService) this.CrmService, configuration.ToEntityReference(), false);
        if (entityImage != null && entityImage.EntityImage != null)
          str2 = string.Format("<img class=\"logo\" style=\"float:right\" alt=\"\" src=\"data:image/jpg;base64,{0}\" />", (object) Convert.ToBase64String(entityImage.EntityImage));
      }
      return string.Format("<tr><td class=\"header\"><h1>{0}</h1><h5>{1}</h5></td><td class=\"address\">{2}</td><td class=\"logo\">{3}</td></tr>", (object) reportHeading, (object) reportName, (object) str1, (object) str2);
    }

    public string GetTreeString(FamilyTreeDetailLevel detailLevel)
    {
      StringBuilder stringBuilder = new StringBuilder();
      int num = 0;
      foreach (FamilyTreeMember familyTreeMember in this.familyTreeMemberDictionary.Values)
      {
        if (num > 0)
          stringBuilder.Append(",");
        string nodeString = familyTreeMember.GetNodeString(detailLevel);
        stringBuilder.AppendLine(nodeString);
        ++num;
      }
      return stringBuilder.ToString();
    }

    public void BuildFamilyTree(FamilyTreeType familyTreeType, int maxLevel)
    {
      this.familyTreeType = familyTreeType;
      this.AddDescendantMembers(this.MemberProfile, new Guid?(), 0, maxLevel);
      this.LimitDescendantMembers();
    }

    public string GetLineageJson()
    {
      List<LineageMember> lineageMemberList = new List<LineageMember>();
      foreach (FamilyTreeMember familyTreeMember in this.familyTreeMemberDictionary.Values)
      {
        LineageMember lineageMember = new LineageMember(familyTreeMember);
        lineageMemberList.Add(lineageMember);
      }
      return JsonLibrary.ConvertObjectToJSon<List<LineageMember>>(lineageMemberList);
    }

    private void LimitDescendantMembers()
    {
      if (this.familyTreeMemberDictionary.Values.Count < 200)
        return;
      int num1 = this.generationLevelCount.Keys.Count;
      int num2 = 0;
      for (int key = 0; key < this.generationLevelCount.Keys.Count; ++key)
      {
        num2 += this.generationLevelCount[key];
        if (num2 >= 200)
        {
          num1 = key - 1;
          break;
        }
      }
      this.generationMessage = string.Format(" ({0} of {1} generations displayed)", (object) (num1 + 1), (object) this.generationLevelCount.Keys.Count);
      foreach (string key in this.familyTreeMemberDictionary.Keys.ToArray<string>())
      {
        if (this.familyTreeMemberDictionary[key].Level > num1)
          this.familyTreeMemberDictionary.Remove(key);
      }
    }

    private void AddDescendantMembers(
      ait_memberprofile memberProfile,
      Guid? attachedToMemberId,
      int level,
      int maxLevel)
    {
      if (level >= maxLevel)
        return;
      FamilyTreeMember familyTreeMember1 = new FamilyTreeMember(this.CrmService, memberProfile)
      {
        Level = level,
        AttachedToId = attachedToMemberId,
        TreeType = this.familyTreeType,
        Duplicate = false
      };
      if (this.familyTreeMemberDictionary.ContainsKey(memberProfile.ait_memberprofileId.Value.ToString().ToLower()))
      {
        MemberProfilePlugin.ValidateNoCircularReference((IOrganizationService) this.CrmService, this.MemberProfile);
        string key = memberProfile.ait_memberprofileId.Value.ToString().ToLower() + ";Duplicate;" + Guid.NewGuid().ToString();
        familyTreeMember1.Duplicate = true;
        this.familyTreeMemberDictionary.Add(key, familyTreeMember1);
        this.IncrementLevelCount(level);
      }
      else
      {
        this.IncrementLevelCount(level);
        Dictionary<string, FamilyTreeMember> memberDictionary1 = this.familyTreeMemberDictionary;
        Guid id = memberProfile.ait_memberprofileId.Value;
        string lower1 = id.ToString().ToLower();
        FamilyTreeMember familyTreeMember2 = familyTreeMember1;
        memberDictionary1.Add(lower1, familyTreeMember2);
        if (this.familyTreeType == FamilyTreeType.Ancestor)
        {
          ait_memberprofile entity1 = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, memberProfile.ait_biologicalmotherprofile, false);
          if (entity1 != null)
            this.AddDescendantMembers(entity1, memberProfile.ait_memberprofileId, level + 1, maxLevel);
          ait_memberprofile entity2 = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, memberProfile.ait_biologicalfatherprofile, false);
          if (entity2 != null)
            this.AddDescendantMembers(entity2, memberProfile.ait_memberprofileId, level + 1, maxLevel);
        }
        else
        {
          EntityCollection allEntities1 = EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_memberprofile", "ait_biologicalfatherprofile", (object) memberProfile.ait_memberprofileId, true);
          if (allEntities1 != null)
          {
            foreach (ait_memberprofile entity in (Collection<Entity>) allEntities1.Entities)
              this.AddDescendantMembers(entity, memberProfile.ait_memberprofileId, level + 1, maxLevel);
          }
          EntityCollection allEntities2 = EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_memberprofile", "ait_biologicalmotherprofile", (object) memberProfile.ait_memberprofileId, true);
          if (allEntities2 != null)
          {
            foreach (ait_memberprofile entity in (Collection<Entity>) allEntities2.Entities)
              this.AddDescendantMembers(entity, memberProfile.ait_memberprofileId, level + 1, maxLevel);
          }
        }
        int num1;
        if (memberProfile.ait_biologicalmotherprofile != null)
        {
          Dictionary<string, FamilyTreeMember> memberDictionary2 = this.familyTreeMemberDictionary;
          id = memberProfile.ait_biologicalmotherprofile.Id;
          string lower2 = id.ToString().ToLower();
          num1 = memberDictionary2.ContainsKey(lower2) ? 1 : 0;
        }
        else
          num1 = 0;
        if (num1 != 0)
        {
          Dictionary<string, FamilyTreeMember> memberDictionary3 = this.familyTreeMemberDictionary;
          id = memberProfile.ait_biologicalmotherprofile.Id;
          string lower3 = id.ToString().ToLower();
          memberDictionary3[lower3].AddChild(familyTreeMember1);
        }
        int num2;
        if (memberProfile.ait_biologicalfatherprofile != null)
        {
          Dictionary<string, FamilyTreeMember> memberDictionary4 = this.familyTreeMemberDictionary;
          id = memberProfile.ait_biologicalfatherprofile.Id;
          string lower4 = id.ToString().ToLower();
          num2 = memberDictionary4.ContainsKey(lower4) ? 1 : 0;
        }
        else
          num2 = 0;
        if (num2 == 0)
          return;
        Dictionary<string, FamilyTreeMember> memberDictionary5 = this.familyTreeMemberDictionary;
        id = memberProfile.ait_biologicalfatherprofile.Id;
        string lower5 = id.ToString().ToLower();
        memberDictionary5[lower5].AddChild(familyTreeMember1);
      }
    }

    private void IncrementLevelCount(int level)
    {
      if (!this.generationLevelCount.ContainsKey(level))
        this.generationLevelCount.Add(level, 0);
      this.generationLevelCount[level]++;
    }
  }
}
