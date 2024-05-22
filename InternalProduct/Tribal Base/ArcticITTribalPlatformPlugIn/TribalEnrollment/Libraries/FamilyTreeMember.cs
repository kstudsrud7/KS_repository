// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.Libraries.FamilyTreeMember
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.EarlyBound.Entities;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;

#nullable disable
namespace ArcticIT.TribalEnrollment.Libraries
{
  public class FamilyTreeMember
  {
    private FrameworkService CrmService = (FrameworkService) null;
    private ait_memberprofile _ait_memberProfile = (ait_memberprofile) null;
    private Contact _contact = (Contact) null;
    private Dictionary<string, FamilyTreeMember> _childrenDictionary = new Dictionary<string, FamilyTreeMember>();

    public FamilyTreeMember(FrameworkService crmService, ait_memberprofile memberProfile)
    {
      if (memberProfile == null)
        throw new ArgumentNullException(nameof (memberProfile));
      this.CrmService = crmService != null ? crmService : throw new ArgumentNullException(nameof (crmService));
      this.MemberProfile = memberProfile;
    }

    public int Level { get; set; }

    public FamilyTreeType TreeType { get; set; }

    public Guid Id => this.MemberProfile.ait_memberprofileId.Value;

    public Guid? AttachedToId { get; set; }

    public ait_memberprofile MemberProfile
    {
      get => this._ait_memberProfile;
      private set => this._ait_memberProfile = value;
    }

    public Contact ContactEntity
    {
      get
      {
        if (this._contact == null && this.MemberProfile != null)
          this._contact = (Contact) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, this.MemberProfile.ait_Contact, false);
        return this._contact;
      }
    }

    public void AddChild(FamilyTreeMember familyTreeMember)
    {
      if (this._childrenDictionary.ContainsKey(familyTreeMember.Id.ToString().ToLower()))
        return;
      this._childrenDictionary.Add(familyTreeMember.Id.ToString().ToLower(), familyTreeMember);
    }

    public int ChildCount => this._childrenDictionary.Count;

    public bool Duplicate { get; set; }

    public string GetNodeString(FamilyTreeDetailLevel detailLevel)
    {
      string memberId = this.Id.ToString();
      if (this.Duplicate)
        memberId = memberId + ";Duplicate;" + Guid.NewGuid().ToString();
      string empty1 = string.Empty;
      Guid? attachedToId;
      int num;
      if (this.AttachedToId.HasValue)
      {
        attachedToId = this.AttachedToId;
        num = attachedToId.HasValue ? 1 : 0;
      }
      else
        num = 0;
      if (num != 0)
      {
        attachedToId = this.AttachedToId;
        empty1 = attachedToId.Value.ToString();
      }
      string displayValue = this.BuildDisplayString(detailLevel);
      string empty2 = string.Empty;
      return this.BuildNodeString(memberId, empty1, displayValue, empty2);
    }

    private bool ContactIsMember
    {
      get => AttributeLibrary.Compare(this.MemberProfile.ait_membershipstatus, 750000000);
    }

    private bool ContactGenderKnown
    {
      get
      {
        return AttributeLibrary.Compare(this.ContactEntity.ait_gender, 750000000) || AttributeLibrary.Compare(this.ContactEntity.ait_gender, 750000001);
      }
    }

    private bool ContactIsMale
    {
      get => AttributeLibrary.Compare(this.ContactEntity.ait_gender, 750000000);
    }

    private string NameClass
    {
      get
      {
        string nameClass = "divname";
        if (this.ContactEntity.ait_gender != null)
          nameClass = !this.ContactIsMale ? "divnamefemale" : "divnamemale";
        return nameClass;
      }
    }

    private string NodeBloodQuantum
    {
      get
      {
        string nodeBloodQuantum = string.Empty;
        if (!string.IsNullOrEmpty(this.MemberProfile.ait_totalbqfraction) || !string.IsNullOrEmpty(this.MemberProfile.ait_tribalbqfraction))
          nodeBloodQuantum = string.Format("BQ: Tribal:{0} - Total:{1}", (object) this.MemberProfile.ait_tribalbqfraction, (object) this.MemberProfile.ait_totalbqfraction);
        return nodeBloodQuantum;
      }
    }

    private string NodeName1
    {
      get
      {
        string str1 = string.Empty;
        if (this.Duplicate)
          str1 = " (Duplicate - Detail listed earlier in this chart)";
        string str2 = ",";
        if (!string.IsNullOrEmpty(this.ContactEntity.Suffix))
          str2 = string.Format(" {0},", (object) this.ContactEntity.Suffix);
        return WebUtility.HtmlEncode(string.Format("{0}{1} {2} {3}{4}", (object) this.ContactEntity.LastName, (object) str2, (object) this.ContactEntity.FirstName, (object) this.ContactEntity.MiddleName, (object) str1));
      }
    }

    private string NodeType
    {
      get
      {
        string nodeType = string.Empty;
        if (this.Level == 0)
          nodeType = "Current";
        if (this.Level > 0)
        {
          if (this.TreeType == FamilyTreeType.Descendant)
          {
            nodeType = "Child";
            if (this.ContactEntity.ait_gender != null && this.ContactGenderKnown)
              nodeType = this.ContactIsMale ? "Son" : "Daughter";
          }
          else
          {
            nodeType = "Parent";
            if (this.ContactEntity.ait_gender != null && this.ContactGenderKnown)
              nodeType = this.ContactIsMale ? "Father" : "Mother";
          }
        }
        return nodeType;
      }
    }

    private string NodeRole
    {
      get
      {
        string empty1 = string.Empty;
        string nodeType = this.NodeType;
        string str = string.Empty;
        if (this.Level == 2)
          str = "Grand";
        else if (this.Level == 3)
          str = "Great-Grand";
        else if (this.Level >= 4)
        {
          string empty2 = string.Empty;
          for (int index = 4; index <= this.Level; ++index)
            empty2 += "G";
          str = empty2 + "G-Grand";
        }
        string name = str + nodeType;
        return this.GetEntityLink(this.MemberProfile.ToEntityReference(), name);
      }
    }

    private string NodeBirthDates
    {
      get
      {
        string str1 = string.Empty;
        string str2 = string.Empty;
        string nodeBirthDates = string.Empty;
        if (this.ContactEntity.ait_birthrecord != null)
          str1 = this.ContactEntity.ait_birthrecord.Name;
        if (this.ContactEntity.ait_deathrecord != null)
          str2 = this.ContactEntity.ait_deathrecord.Name;
        if (!string.IsNullOrEmpty(str1) || !string.IsNullOrEmpty(str2))
        {
          string name = string.Format("{0} - {1}", (object) str1, (object) str2);
          nodeBirthDates = this.GetEntityLink(this.ContactEntity.ToEntityReference(), name);
        }
        return nodeBirthDates;
      }
    }

    private string NodeTribeInfo
    {
      get
      {
        string nodeTribeInfo = string.Empty;
        if (this.ContactEntity.ait_tribe != null || !string.IsNullOrEmpty(this.ContactEntity.ait_tribalid) || this.ContactEntity.ait_membershipstatus != null)
        {
          string str1 = string.Empty;
          if (this.ContactEntity.ait_tribe != null)
            str1 = this.ContactEntity.ait_tribe.Name;
          string str2 = str1;
          string str3 = string.Empty;
          string optionSetText = MetadataLibrary.GetOptionSetText((IOrganizationService) this.CrmService, "ait_membershipstatus", this.ContactEntity.ait_membershipstatus);
          if (!string.IsNullOrEmpty(this.ContactEntity.ait_tribalid))
            str3 = " - ";
          string str4 = string.Format("{0}{1}{2}", (object) str2, (object) str3, (object) this.ContactEntity.ait_tribalid);
          string str5 = string.Empty;
          if (!string.IsNullOrEmpty(optionSetText))
            str5 = " - ";
          nodeTribeInfo = WebUtility.HtmlEncode(string.Format("{0}{1}{2}", (object) str4, (object) str5, (object) optionSetText));
        }
        return nodeTribeInfo;
      }
    }

    private string BackgroundColor
    {
      get
      {
        string backgroundColor = string.Empty;
        if (this.ContactIsMember)
          backgroundColor = "background-color:LightBlue";
        return backgroundColor;
      }
    }

    private string BloodQuantumTable
    {
      get
      {
        string bloodQuantumTable = string.Empty;
        EntityCollection allEntities = EntityLibrary.GetAllEntities((IOrganizationService) this.CrmService, "ait_bloodquantum", "ait_memberprofile", (object) this.MemberProfile.ait_memberprofileId, true);
        if (((Collection<Entity>) allEntities.Entities).Count > 0)
          bloodQuantumTable = "<hr class=\"underline\"><Table CLASS=\"boldtable\">";
        foreach (ait_bloodquantum aitBloodquantum in (IEnumerable<Entity>) ((IEnumerable<Entity>) allEntities.Entities).OrderByDescending<Entity, object>((Func<Entity, object>) (f => ((DataCollection<string, object>) f.Attributes)["ait_bloodquantumincludedintribe"])))
        {
          string empty1 = string.Empty;
          ait_tribe entity = (ait_tribe) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, aitBloodquantum.ait_Tribe, false);
          ait_tribe aitTribe = (ait_tribe) null;
          if (entity.ait_parenttribe != null)
            aitTribe = (ait_tribe) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, entity.ait_parenttribe, false);
          string empty2 = string.Empty;
          string str1 = string.Empty;
          string aitOfficialname;
          if (aitTribe != null)
          {
            str1 = entity.ait_officialname;
            aitOfficialname = aitTribe.ait_officialname;
          }
          else
            aitOfficialname = entity.ait_officialname;
          string str2 = WebUtility.HtmlEncode(aitOfficialname);
          string str3 = WebUtility.HtmlEncode(str1);
          string str4 = string.Format("<TR{0}><TD>{1}</TD><TD>{2}</TD><TD>{3}</TD></TR>", (object) empty1, (object) str2, (object) str3, (object) aitBloodquantum.ait_bloodquantumfraction);
          bloodQuantumTable += str4;
        }
        if (((Collection<Entity>) allEntities.Entities).Count > 0)
          bloodQuantumTable += "</Table>";
        return bloodQuantumTable;
      }
    }

    private string GetMemberImageBase64String()
    {
      string imageBase64String = string.Empty;
      Contact entityImage = (Contact) EntityLibrary.GetEntityImage((IOrganizationService) this.CrmService, this.ContactEntity.ToEntityReference(), false);
      if (entityImage != null && entityImage.EntityImage != null)
        imageBase64String = Convert.ToBase64String(entityImage.EntityImage);
      return imageBase64String;
    }

    private string BuildDisplayString(FamilyTreeDetailLevel detailLevel)
    {
      string str1 = string.Empty;
      if (this.ContactIsMember)
        str1 = "divmember";
      string str2 = string.Format("<div class=\"divelement {0}\">", (object) str1);
      string nameClass = this.NameClass;
      string nodeName1 = this.NodeName1;
      string str3 = string.Format("{0}<div class=\"{1}\">{2}</div>", (object) str2, (object) nameClass, (object) nodeName1);
      string str4 = string.Empty;
      string str5 = string.IsNullOrEmpty(this.NodeRole) ? this.NodeRole : this.NodeRole + "<br>";
      string str6 = string.IsNullOrEmpty(this.NodeBirthDates) ? this.NodeBirthDates : this.NodeBirthDates + "<br>";
      string str7 = string.IsNullOrEmpty(this.NodeTribeInfo) ? this.NodeTribeInfo : this.NodeTribeInfo + "<br>";
      string str8 = string.IsNullOrEmpty(this.NodeBloodQuantum) ? this.NodeBloodQuantum : this.NodeBloodQuantum + "<br>";
      string str9 = string.Empty;
      if (this.Level == 0)
      {
        string imageBase64String = this.GetMemberImageBase64String();
        if (!string.IsNullOrEmpty(imageBase64String))
          str9 = string.Format("<img class=\"member\" alt=\"\" src=\"data:image/png;base64,{0}\" />", (object) imageBase64String);
      }
      switch (detailLevel)
      {
        case FamilyTreeDetailLevel.Detail:
          string nodeBloodQuantum = this.NodeBloodQuantum;
          str4 = string.Format("{0}<div>{1}{2}{3}{4}</div></div>", (object) str3, (object) str5, (object) str6, (object) str7, (object) nodeBloodQuantum);
          break;
        case FamilyTreeDetailLevel.Quantum:
          string str10 = string.IsNullOrEmpty(this.NodeRole) ? this.NodeRole : "(" + this.NodeRole + ")";
          str4 = string.Format("{0}<div>{1}{2}</div></div>", (object) string.Format("{0}{1}<div class=\"{2}\">{3}{4}</div>", (object) str2, (object) str9, (object) this.NameClass, (object) this.NodeName1, (object) str10), (object) str8, (object) this.BloodQuantumTable);
          break;
        case FamilyTreeDetailLevel.Summary:
          str4 = string.Format("{0}<div>{1}</div></div>", (object) str3, (object) this.NodeRole);
          break;
      }
      return str4;
    }

    private string BuildNodeString(
      string memberId,
      string attachedToId,
      string displayValue,
      string toolTip)
    {
      return string.Format("[{{v:'{0}',f:'{1}'}}, '{2}', '{3}']", (object) memberId, (object) displayValue, (object) attachedToId, (object) toolTip);
    }

    private string GetEntityLink(EntityReference entityReference, string name)
    {
      string entityLink = name;
      if (!string.IsNullOrEmpty(TribalEnrollmentConfiguration.GetFamilyTreeUrl(this.CrmService)))
        entityLink = string.Format("<a href=\"{0}\" target=\"_blank\">{1}</a>", (object) this.GetEntityURL(entityReference), (object) name);
      return entityLink;
    }

    private string GetEntityURL(EntityReference entityReference)
    {
      string upper = entityReference.Id.ToString().ToUpper();
      return string.Format("{0}/main.aspx?etn={1}&pagetype=entityrecord&id={2}", (object) TribalEnrollmentConfiguration.GetFamilyTreeUrl(this.CrmService), (object) entityReference.LogicalName, (object) upper);
    }
  }
}
