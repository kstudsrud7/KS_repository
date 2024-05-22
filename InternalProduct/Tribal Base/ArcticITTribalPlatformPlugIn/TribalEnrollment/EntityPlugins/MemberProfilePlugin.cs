// Decompiled with JetBrains decompiler
// Type: ArcticIT.TribalEnrollment.EntityPlugins.MemberProfilePlugin
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using ArcticIT.CrmFramework.Libraries;
using ArcticIT.CrmFramework.Plugins;
using ArcticIT.CrmFramework.Plugins.Enums;
using ArcticIT.EarlyBound.Entities;
using ArcticIT.EarlyBound.OptionSets;
using ArcticIT.TribalEnrollment.Libraries;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

#nullable disable
namespace ArcticIT.TribalEnrollment.EntityPlugins
{
  [CRMMetadata(EntityName = "ait_memberprofile", CrmEntityType = "ArcticIT.EarlyBound.Entities.ait_memberprofile")]
  public class MemberProfilePlugin : EntityBase
  {
    public MemberProfilePlugin(
      IServiceProvider serviceProvider,
      string securedConfiguration,
      string unsecuredConfiguration)
      : base(serviceProvider, securedConfiguration, securedConfiguration)
    {
      this.OnPluginPreCreating += new EntityBase.PluginOnPreCreateHandler(this.Execute_OnPluginPreCreating);
      this.OnPluginPreUpdating += new EntityBase.PluginOnPreUpdateHandler(this.Execute_OnPluginPreUpdating);
      this.OnPluginPostUpdating += new EntityBase.PluginOnPostUpdateHandler(this.Execute_OnPluginPostUpdating);
      this.OnPluginPostCreating += new EntityBase.PluginOnPostCreateHandler(this.Execute_OnPluginPostCreating);
      this.OnPluginPostDeleting += new EntityBase.PluginOnPostDeleteHandler(this.Execute_OnPluginPostDeleting);
      this.OnPluginPostCustomActionFiring += new EntityBase.PluginPostCustomActionHandler(this.Execute_OnPluginPostCustomActionFiring);
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.UpdateDefaults();
      this.ValidateRelationship();
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
      this.ValidateRelationship();
      this.UpdateName();
    }

    private void Execute_OnPluginPostCreating(
      object sender,
      EntityBase.PluginOnPostCreateHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostUpdating(
      object sender,
      EntityBase.PluginOnPostUpdateHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
      this.UpdateRelatedNames();
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    private void Execute_OnPluginPostCustomActionFiring(
      object sender,
      EntityBase.PluginPostCustomActionHandlerEventArgs e)
    {
      string lower = ((IExecutionContext) this.CrmService.PluginContext).MessageName.ToLower();
      switch (lower)
      {
        case "ait_calculatebloodquantumaction":
          this.CalculateBloodQuantumAction();
          break;
        case "ait_getfamilytreedata":
          this.GetFamilyTreeData();
          break;
        case "ait_getlineagedata":
          this.GetLineageData();
          break;
        default:
          throw new InvalidPluginExecutionException("Invalid action on MemberProfile: " + lower);
      }
    }

    public bool UpdateRelationship(
      FrameworkService crmService,
      ait_memberprofile memberProfile,
      Global.ActionType actionType)
    {
      if (memberProfile == null || Global.ActionType.DELETE == actionType || memberProfile.ait_Contact == null)
        return false;
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = this.HasAttributeChanged("ait_biologicalmotherconfidential", (Entity) memberProfile);
      bool flag4 = this.HasAttributeChanged("ait_biologicalfatherconfidential", (Entity) memberProfile);
      bool flag5 = this.HasAttributeChanged("ait_biologicalmotherprofile", (Entity) memberProfile);
      bool flag6 = this.HasAttributeChanged("ait_biologicalfatherprofile", (Entity) memberProfile);
      if (flag3 && AttributeLibrary.Compare(memberProfile.ait_biologicalmotherconfidential, true))
        flag1 = MemberProfilePlugin.DeleteRelationship(crmService, memberProfile.ait_Contact, memberProfile.ait_biologicalmotherprofile, ait_relationshiptype.BiologicalMother);
      if (flag4 && AttributeLibrary.Compare(memberProfile.ait_biologicalfatherconfidential, true))
        flag2 = MemberProfilePlugin.DeleteRelationship(crmService, memberProfile.ait_Contact, memberProfile.ait_biologicalfatherprofile, ait_relationshiptype.BiologicalFather);
      if (flag3 | flag5 && AttributeLibrary.Compare(memberProfile.ait_biologicalmotherconfidential, false))
        flag1 = MemberProfilePlugin.AddRelationship((IOrganizationService) crmService, memberProfile.ait_Contact, memberProfile.ait_biologicalmotherprofile, ait_relationshiptype.BiologicalMother);
      if (flag4 | flag6 && AttributeLibrary.Compare(memberProfile.ait_biologicalfatherconfidential, false))
        flag2 = MemberProfilePlugin.AddRelationship((IOrganizationService) crmService, memberProfile.ait_Contact, memberProfile.ait_biologicalfatherprofile, ait_relationshiptype.BiologicalFather);
      return flag1 | flag2;
    }

    private static bool DeleteRelationship(
      FrameworkService crmService,
      EntityReference contact,
      EntityReference relationshipToProfile,
      ait_relationshiptype relationshipType)
    {
      bool flag = false;
      if (crmService == null || contact == null || relationshipToProfile == null)
        return false;
      ait_memberprofile entity = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) crmService, relationshipToProfile);
      if (entity != null && entity.ait_Contact != null)
      {
        ait_relationship relationship = RelationshipPlugin.GetRelationship((IOrganizationService) crmService, contact, entity.ait_Contact);
        if (relationship != null)
          crmService.ImpersonateAdmin().Delete("ait_relationship", ((Entity) relationship).Id);
      }
      return flag;
    }

    private static bool AddRelationship(
      IOrganizationService crmService,
      EntityReference contact,
      EntityReference relationshipToProfile,
      ait_relationshiptype relationshipType)
    {
      bool flag = false;
      if (crmService == null || contact == null || relationshipToProfile == null)
        return false;
      ait_memberprofile entity = (ait_memberprofile) EntityLibrary.GetEntity(crmService, relationshipToProfile);
      if (entity != null && entity.ait_Contact != null)
      {
        ait_relationship relationship = RelationshipPlugin.GetRelationship(crmService, contact, entity.ait_Contact);
        if (relationship == null)
        {
          ait_relationship aitRelationship = new ait_relationship()
          {
            ait_contact = contact,
            ait_RelationshipTo = entity.ait_Contact,
            ait_relationshiptype = new OptionSetValue((int) relationshipType)
          };
          crmService.Create((Entity) aitRelationship);
          flag = true;
        }
        else if (!AttributeLibrary.Compare(relationship.ait_RelationshipTo, entity.ait_Contact) || !AttributeLibrary.Compare(relationship.ait_relationshiptype, (int) relationshipType))
        {
          relationship.ait_RelationshipTo = entity.ait_Contact;
          relationship.ait_relationshiptype = new OptionSetValue((int) relationshipType);
          crmService.Update((Entity) relationship);
          flag = true;
        }
      }
      return flag;
    }

    public static bool UpdateContact(
      IOrganizationService crmService,
      ait_memberprofile memberProfile,
      Global.ActionType actionType)
    {
      bool flag = false;
      if (memberProfile == null || memberProfile.ait_Contact == null)
        return false;
      Contact entity = (Contact) EntityLibrary.GetEntity(crmService, memberProfile.ait_Contact, false);
      if (entity == null)
        return false;
      Contact contact = new Contact();
      ((Entity) contact).Id = ((Entity) entity).Id;
      if (actionType == Global.ActionType.DELETE)
      {
        flag = true;
        contact.ait_membershipstatus = (OptionSetValue) null;
      }
      else
      {
        if (!AttributeLibrary.Compare(entity.ait_MemberProfile, memberProfile.ToEntityReference()))
        {
          flag = true;
          contact.ait_MemberProfile = memberProfile.ToEntityReference();
        }
        if (!AttributeLibrary.Compare(entity.ait_membershipstatus, memberProfile.ait_membershipstatus))
        {
          flag = true;
          contact.ait_membershipstatus = memberProfile.ait_membershipstatus;
        }
        if (!AttributeLibrary.Compare((object) entity.ait_tribalid, (object) memberProfile.ait_tribalid))
        {
          flag = true;
          contact.ait_tribalid = memberProfile.ait_tribalid;
        }
        if (!AttributeLibrary.Compare(entity.ait_tribe, memberProfile.ait_tribe))
        {
          flag = true;
          contact.ait_tribe = memberProfile.ait_tribe;
        }
        if (!AttributeLibrary.Compare(entity.ait_bandid, memberProfile.ait_bandid))
        {
          flag = true;
          contact.ait_bandid = memberProfile.ait_bandid;
        }
      }
      if (flag)
        crmService.Update((Entity) contact);
      return flag;
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_memberprofile>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_memberprofile>();
    }

    protected override List<UpdateNameInformation> GetNameRelationships()
    {
      return new List<UpdateNameInformation>()
      {
        new UpdateNameInformation("ait_bloodquantum", "ait_memberprofile")
      };
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty1 = string.Empty;
      ait_memberprofile aitMemberprofile1 = (ait_memberprofile) entityInput;
      ait_memberprofile aitMemberprofile2 = (ait_memberprofile) preImage;
      string empty2 = string.Empty;
      string empty3 = string.Empty;
      string entityValue1 = FormatLibrary.GetEntityValue(aitMemberprofile1.ait_tribalid, aitMemberprofile2.ait_tribalid);
      string entityValue2 = FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitMemberprofile1.ait_tribe, aitMemberprofile2.ait_tribe);
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, aitMemberprofile1.ait_Contact, aitMemberprofile2.ait_Contact), entityValue2, entityValue1);
    }

    private void AutoNumberMembershipId()
    {
      ait_memberprofile inputEntity = this.GetInputEntity<ait_memberprofile>(this.ActionType);
      if (!this.HasAttributeChanged("ait_membershipstatus") || !AttributeLibrary.Compare(inputEntity.ait_membershipstatus, 750000000))
        return;
      inputEntity.ait_memberid = AutoNumberLibrary.GetNextFormattedValue(this.CrmService, "ait_memberprofile", "ait_memberid");
    }

    public void UpdateRelatedRecords()
    {
      ait_memberprofile inputEntity = this.GetInputEntity<ait_memberprofile>(this.ActionType);
      MemberProfilePlugin.UpdateContact((IOrganizationService) this.CrmService, inputEntity, this.ActionType);
      this.UpdateRelationship(this.CrmService, inputEntity, this.ActionType);
    }

    private void GetLineageData()
    {
      IPluginExecutionContext pluginContext = this.CrmService.PluginContext;
      EntityReference inputVariable1 = this.GetInputVariable<EntityReference>("Target", true);
      string inputVariable2 = this.GetInputVariable<string>("familytreetype", false);
      ait_memberprofile entity = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputVariable1, true);
      FamilyTreeLibrary familyTreeLibrary = new FamilyTreeLibrary(this.CrmService)
      {
        MemberProfile = entity
      };
      FamilyTreeType familyTreeType = FamilyTreeType.Ancestor;
      if (!string.IsNullOrEmpty(inputVariable2) && inputVariable2.ToLower() == "descendant")
        familyTreeType = FamilyTreeType.Descendant;
      int maxLevel = 10000;
      familyTreeLibrary.BuildFamilyTree(familyTreeType, maxLevel);
      string lineageJson = familyTreeLibrary.GetLineageJson();
      ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["lineageData"] = (object) lineageJson;
    }

    private void GetFamilyTreeData()
    {
      IPluginExecutionContext pluginContext = this.CrmService.PluginContext;
      EntityReference inputVariable1 = this.GetInputVariable<EntityReference>("Target", true);
      string inputVariable2 = this.GetInputVariable<string>("familytreetype", false);
      string str = this.GetInputVariable<string>("familytreedetaillevel", false) ?? string.Empty;
      int maxLevel = 10000;
      FamilyTreeDetailLevel detailLevel = FamilyTreeDetailLevel.Detail;
      if (str.ToLower() == "quantum")
        detailLevel = FamilyTreeDetailLevel.Quantum;
      if (str.ToLower() == "detail")
        detailLevel = FamilyTreeDetailLevel.Detail;
      if (str.ToLower() == "summary")
        detailLevel = FamilyTreeDetailLevel.Summary;
      switch (detailLevel)
      {
        case FamilyTreeDetailLevel.Detail:
          maxLevel = 5;
          break;
        case FamilyTreeDetailLevel.Quantum:
          maxLevel = 3;
          break;
        case FamilyTreeDetailLevel.Summary:
          maxLevel = 1000;
          break;
      }
      ait_memberprofile entity = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputVariable1, true);
      FamilyTreeLibrary familyTreeLibrary = new FamilyTreeLibrary(this.CrmService)
      {
        MemberProfile = entity
      };
      FamilyTreeType familyTreeType = FamilyTreeType.Descendant;
      if (!string.IsNullOrEmpty(inputVariable2) && inputVariable2.ToLower() == "ancestor")
        familyTreeType = FamilyTreeType.Ancestor;
      familyTreeLibrary.BuildFamilyTree(familyTreeType, maxLevel);
      string treeString = familyTreeLibrary.GetTreeString(detailLevel);
      ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["descendantstring"] = (object) treeString;
      ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["reportheading"] = (object) familyTreeLibrary.GetHeaderString();
    }

    private void CalculateBloodQuantumAction()
    {
      IPluginExecutionContext pluginContext = this.CrmService.PluginContext;
      EntityReference inputVariable = this.GetInputVariable<EntityReference>("Target", true);
      BloodQuantumLibrary bloodQuantumLibrary = new BloodQuantumLibrary(this.CrmService, inputVariable);
      if (!bloodQuantumLibrary.UseParentProfileForCalculation)
      {
        ait_memberprofile aitMemberprofile = bloodQuantumLibrary.UpdateBloodQuantumForIndividual();
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["tribalbloodquantum"] = (object) aitMemberprofile.ait_tribalbqfraction;
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["tribalbloodquantumdecimal"] = (object) aitMemberprofile.ait_tribalbqdecimal.ToString();
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["totalbloodquantum"] = (object) aitMemberprofile.ait_totalbqfraction;
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["totalbloodquantumdecimal"] = (object) aitMemberprofile.ait_totalbqdecimal.ToString();
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["bloodquantumthresholdmet"] = (object) aitMemberprofile.ait_bqthresholdmet.Value.ToString();
      }
      else
      {
        bloodQuantumLibrary.DeleteAllMemberBloodQuantums();
        MemberBloodQuantumInfoStruct quantumInfoFromParents = bloodQuantumLibrary.GetCalculatedBloodQuantumInfoFromParents();
        bool flag = BloodQuantumLibrary.IsBloodQuantumThreshholdMet(this.CrmService, quantumInfoFromParents.TribalBloodQuantum, quantumInfoFromParents.TotalBloodQuantum);
        ait_memberprofile entity1 = (ait_memberprofile) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, inputVariable);
        ait_memberprofile aitMemberprofile1 = entity1;
        Fraction fraction = quantumInfoFromParents.TribalBloodQuantum;
        string str1 = fraction.ToString();
        aitMemberprofile1.ait_tribalbqfraction = str1;
        entity1.ait_tribalbqdecimal = new Decimal?(quantumInfoFromParents.TribalBloodQuantumDecimal);
        ait_memberprofile aitMemberprofile2 = entity1;
        fraction = quantumInfoFromParents.TotalBloodQuantum;
        string str2 = fraction.ToString();
        aitMemberprofile2.ait_totalbqfraction = str2;
        entity1.ait_totalbqdecimal = new Decimal?(quantumInfoFromParents.TotalBloodQuantumDecimal);
        entity1.ait_bqthresholdmet = new bool?(flag);
        this.CrmService.Update((Entity) entity1);
        foreach (ait_bloodquantum entity2 in (Collection<Entity>) quantumInfoFromParents.MemberBloodQuantums.Entities)
        {
          Decimal? bloodquantumdecimal = entity2.ait_bloodquantumdecimal;
          Decimal num = 0M;
          if (!(bloodquantumdecimal.GetValueOrDefault() == num & bloodquantumdecimal.HasValue))
            this.CrmService.Create((Entity) entity2);
        }
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["tribalbloodquantum"] = (object) quantumInfoFromParents.TribalBloodQuantum.ToString();
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["tribalbloodquantumdecimal"] = (object) quantumInfoFromParents.TribalBloodQuantumDecimal.ToString();
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["totalbloodquantum"] = (object) quantumInfoFromParents.TotalBloodQuantum.ToString();
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["totalbloodquantumdecimal"] = (object) quantumInfoFromParents.TotalBloodQuantumDecimal.ToString();
        ((DataCollection<string, object>) ((IExecutionContext) pluginContext).OutputParameters)["bloodquantumthresholdmet"] = (object) flag;
      }
    }

    private static string GetContactName(
      IOrganizationService crmService,
      EntityReference memberProfileReference)
    {
      string contactName = string.Empty;
      ait_memberprofile entity = (ait_memberprofile) EntityLibrary.GetEntity(crmService, memberProfileReference, false);
      if (entity != null)
        contactName = EntityLibrary.GetEntityName(crmService, entity.ait_Contact);
      return contactName;
    }

    public static void ValidateNoCircularReference(
      IOrganizationService crmService,
      ait_memberprofile profileToVerify)
    {
      if (profileToVerify == null)
        return;
      MemberProfilePlugin.ValidateNoCircularReference(crmService, profileToVerify, (ait_memberprofile) null, (List<Guid>) null, "ait_biologicalfatherprofile", string.Empty);
      MemberProfilePlugin.ValidateNoCircularReference(crmService, profileToVerify, (ait_memberprofile) null, (List<Guid>) null, "ait_biologicalmotherprofile", string.Empty);
    }

    private static void ValidateNoCircularReference(
      IOrganizationService crmService,
      ait_memberprofile profileToVerify,
      ait_memberprofile parentProfile,
      List<Guid> processedList,
      string attributeToVerify,
      string relationshipList)
    {
      if (profileToVerify == null || !((DataCollection<string, object>) profileToVerify.Attributes).ContainsKey(attributeToVerify))
        return;
      if (processedList == null)
        processedList = new List<Guid>();
      ait_memberprofile parentProfile1 = (ait_memberprofile) null;
      string str = string.Empty;
      if (parentProfile == null)
      {
        str = MemberProfilePlugin.GetContactName(crmService, (EntityReference) profileToVerify[attributeToVerify]);
        parentProfile1 = (ait_memberprofile) EntityLibrary.GetEntity(crmService, (EntityReference) profileToVerify[attributeToVerify], false);
      }
      else if (((DataCollection<string, object>) parentProfile.Attributes).ContainsKey(attributeToVerify))
      {
        str = MemberProfilePlugin.GetContactName(crmService, (EntityReference) parentProfile[attributeToVerify]);
        parentProfile1 = (ait_memberprofile) EntityLibrary.GetEntity(crmService, (EntityReference) parentProfile[attributeToVerify]);
      }
      if (parentProfile1 == null)
        return;
      Guid? aitMemberprofileId;
      int num;
      if (parentProfile != null)
      {
        List<Guid> guidList = processedList;
        aitMemberprofileId = parentProfile1.ait_memberprofileId;
        Guid guid = aitMemberprofileId.Value;
        num = guidList.Contains(guid) ? 1 : (AttributeLibrary.Compare(profileToVerify.ToEntityReference(), (EntityReference) parentProfile[attributeToVerify]) ? 1 : 0);
      }
      else
        num = 0;
      if (num != 0)
      {
        string contactName = MemberProfilePlugin.GetContactName(crmService, parentProfile1.ToEntityReference());
        relationshipList = string.Format("{0}, {1}, {2}", (object) str, (object) relationshipList, (object) contactName);
        throw new InvalidPluginExecutionException(string.Format("Member Profile: Adding relationship would cause a circular {0} relationship: {1}.", (object) MetadataLibrary.GetAttributeDisplayName(crmService, "ait_memberprofile", attributeToVerify), (object) relationshipList));
      }
      if (!string.IsNullOrEmpty(relationshipList))
        relationshipList += ", ";
      relationshipList += str;
      List<Guid> guidList1 = processedList;
      aitMemberprofileId = parentProfile1.ait_memberprofileId;
      Guid guid1 = aitMemberprofileId.Value;
      guidList1.Add(guid1);
      MemberProfilePlugin.ValidateNoCircularReference(crmService, profileToVerify, parentProfile1, processedList, attributeToVerify, relationshipList);
    }

    private void UpdateDefaults()
    {
      ait_memberprofile inputEntity = this.GetInputEntity<ait_memberprofile>();
      if (AttributeLibrary.Compare((object) inputEntity.ait_membershipstatus, (object) ait_membershipstatus.Member) && inputEntity.ait_tribe == null)
        inputEntity.ait_tribe = TribalEnrollmentConfiguration.GetDefaultTribe(this.CrmService);
      if (AttributeLibrary.Compare((object) inputEntity.ait_membershipstatus, (object) ait_membershipstatus.Member) && string.IsNullOrEmpty(inputEntity.ait_tribalid) && !string.IsNullOrEmpty(inputEntity.ait_memberid))
        inputEntity.ait_tribalid = inputEntity.ait_memberid;
      int num;
      if (AttributeLibrary.Compare((object) inputEntity.ait_membershipstatus, (object) ait_membershipstatus.Member))
      {
        DateTime? nullable = inputEntity.ait_memberstatuseffectivedate;
        if (!nullable.HasValue)
        {
          nullable = inputEntity.ait_enrollmentdate;
          num = nullable.HasValue ? 1 : 0;
          goto label_8;
        }
      }
      num = 0;
label_8:
      if (num == 0)
        return;
      inputEntity.ait_memberstatuseffectivedate = inputEntity.ait_enrollmentdate;
    }

    private void ValidateRelationship()
    {
      if (this.ActionType == Global.ActionType.DELETE)
        return;
      ait_memberprofile inputEntity = this.GetInputEntity<ait_memberprofile>();
      if (inputEntity.ait_biologicalfatherprofile != null && AttributeLibrary.Compare(inputEntity.ait_biologicalfatherprofile, inputEntity.ait_biologicalmotherprofile))
        throw new InvalidPluginExecutionException("Biological mother and father cannot be the same.");
      if (inputEntity.ait_biologicalfatherprofile == null && inputEntity.ait_biologicalmotherprofile == null)
        return;
      MemberProfilePlugin.ValidateNoCircularReference((IOrganizationService) this.CrmService, inputEntity);
    }
  }
}
