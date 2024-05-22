// Decompiled with JetBrains decompiler
// Type: ArcticIT.Core.Entities.MembershipStatusChangeRequest
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

#nullable disable
namespace ArcticIT.Core.Entities
{
  [CRMMetadata(EntityName = "ait_membershipstatuschangerequest", CrmEntityType = "ArcticIT.CrmFramework.Plugins.EarlyBound.ait_membershipstatuschangerequest")]
  public class MembershipStatusChangeRequest : EntityBase
  {
    public MembershipStatusChangeRequest(
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
    }

    private void Execute_OnPluginPreCreating(
      object sender,
      EntityBase.PluginOnPreCreateHandlerEventArgs e)
    {
      this.UpdateName();
    }

    private void Execute_OnPluginPreUpdating(
      object sender,
      EntityBase.PluginOnPreUpdateHandlerEventArgs e)
    {
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
    }

    private void Execute_OnPluginPostDeleting(
      object sender,
      EntityBase.PluginOnPostDeleteHandlerEventArgs e)
    {
      this.UpdateRelatedRecords();
    }

    protected override Entity GetBaseImageForUpdate()
    {
      return (Entity) this.GetInputEntity<ait_membershipstatuschangerequest>(this.ActionType, Global.Stage.PRE);
    }

    protected override Entity GetPreImageForUpdate()
    {
      return (Entity) this.GetEntityFromPreImage<ait_membershipstatuschangerequest>();
    }

    protected override string GenerateFormattedName(Entity entityInput, Entity preImage)
    {
      string empty = string.Empty;
      ait_membershipstatuschangerequest membershipstatuschangerequest1 = (ait_membershipstatuschangerequest) entityInput;
      ait_membershipstatuschangerequest membershipstatuschangerequest2 = (ait_membershipstatuschangerequest) preImage;
      return FormatLibrary.FormatName(FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, membershipstatuschangerequest1.ait_memberprofile, membershipstatuschangerequest2.ait_memberprofile), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, "ait_changestatustype", membershipstatuschangerequest1.ait_changerequesttype, membershipstatuschangerequest2.ait_changerequesttype), FormatLibrary.GetEntityValue((IOrganizationService) this.CrmService, "ait_changerequeststatus", membershipstatuschangerequest1.ait_changerequeststatus, membershipstatuschangerequest2.ait_changerequeststatus));
    }

    private void MemberProfile(
      IOrganizationService crmService,
      ait_membershipstatuschangerequest memberProfileChangeRequest,
      Global.ActionType actionType)
    {
      if (memberProfileChangeRequest == null || memberProfileChangeRequest.ait_memberprofile == null || actionType == Global.ActionType.DELETE)
        return;
      ait_memberprofile entity1 = (ait_memberprofile) EntityLibrary.GetEntity(crmService, memberProfileChangeRequest.ait_memberprofile, false);
      if (entity1 == null)
        return;
      Contact entity2 = (Contact) EntityLibrary.GetEntity((IOrganizationService) this.CrmService, entity1.ait_Contact);
      Contact contact = new Contact();
      bool flag = false;
      if (entity2 != null)
        ((Entity) contact).Id = ((Entity) entity2).Id;
      if (AttributeLibrary.Compare(memberProfileChangeRequest.ait_changerequeststatus, 750000001) && memberProfileChangeRequest.ait_changerequesttype != null)
      {
        switch (memberProfileChangeRequest.ait_changerequesttype.Value)
        {
          case 750000000:
            entity1.ait_enrollmentdate = memberProfileChangeRequest.ait_changerequeststatuseffectivedate;
            entity1.ait_revokeddate = new DateTime?();
            entity1.ait_relinquisheddate = new DateTime?();
            entity1.ait_mostrecentchangerequest = memberProfileChangeRequest.ToEntityReference();
            entity1.ait_tribe = TribalEnrollmentConfiguration.GetDefaultTribe(this.CrmService);
            break;
          case 750000001:
            entity1.ait_revokeddate = memberProfileChangeRequest.ait_changerequeststatuseffectivedate;
            entity1.ait_relinquisheddate = new DateTime?();
            entity1.ait_mostrecentchangerequest = memberProfileChangeRequest.ToEntityReference();
            entity1.ait_tribe = (EntityReference) null;
            break;
          case 750000002:
            entity1.ait_revokeddate = new DateTime?();
            entity1.ait_relinquisheddate = memberProfileChangeRequest.ait_changerequeststatuseffectivedate;
            entity1.ait_mostrecentchangerequest = memberProfileChangeRequest.ToEntityReference();
            entity1.ait_tribe = (EntityReference) null;
            break;
        }
      }
      ait_membershipstatus? membershipStatus = this.GetMembershipStatus(memberProfileChangeRequest);
      int num = !membershipStatus.HasValue ? 1 : (!membershipStatus.HasValue ? 1 : 0);
      entity1.ait_membershipstatus = num == 0 ? new OptionSetValue((int) membershipStatus.Value) : new OptionSetValue(750000002);
      if (contact != null && !AttributeLibrary.Compare(entity1.ait_membershipstatus, entity2.ait_membershipstatus))
      {
        flag = true;
        contact.ait_membershipstatus = entity1.ait_membershipstatus;
      }
      if (!AttributeLibrary.Compare(entity1.ait_memberstatuseffectivedate, memberProfileChangeRequest.ait_changerequeststatuseffectivedate))
        entity1.ait_memberstatuseffectivedate = memberProfileChangeRequest.ait_changerequeststatuseffectivedate;
      if (contact != null && flag)
        crmService.Update((Entity) contact);
      crmService.Update((Entity) entity1);
    }

    private ait_membershipstatus? GetMembershipStatus(
      ait_membershipstatuschangerequest membershipChangeRequest)
    {
      if (membershipChangeRequest.ait_changerequesttype == null || membershipChangeRequest.ait_changerequeststatus == null)
        return new ait_membershipstatus?();
      ait_membershipstatus? membershipStatus = new ait_membershipstatus?();
      Dictionary<string, ait_membershipstatus> statusDictionary = this.GetMembershipStatusDictionary();
      string membershipStatusKey = this.GetMembershipStatusKey((ait_changestatustype) membershipChangeRequest.ait_changerequesttype.Value, (ait_changerequeststatus) membershipChangeRequest.ait_changerequeststatus.Value);
      if (statusDictionary.ContainsKey(membershipStatusKey))
        membershipStatus = new ait_membershipstatus?(statusDictionary[membershipStatusKey]);
      return membershipStatus;
    }

    private Dictionary<string, ait_membershipstatus> GetMembershipStatusDictionary()
    {
      return new Dictionary<string, ait_membershipstatus>()
      {
        {
          this.GetMembershipStatusKey(ait_changestatustype.Membership, ait_changerequeststatus.Pending),
          ait_membershipstatus.Pending
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Membership, ait_changerequeststatus.PendingMemberAction),
          ait_membershipstatus.Pending
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Membership, ait_changerequeststatus.PendingProcessingApplication),
          ait_membershipstatus.Pending
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Membership, ait_changerequeststatus.PendingTribalAction),
          ait_membershipstatus.Pending
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Membership, ait_changerequeststatus.Approved),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Membership, ait_changerequeststatus.Denied),
          ait_membershipstatus.NonMember
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Membership, ait_changerequeststatus.Withdrawn),
          ait_membershipstatus.NonMember
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Revocation, ait_changerequeststatus.Pending),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Revocation, ait_changerequeststatus.PendingMemberAction),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Revocation, ait_changerequeststatus.PendingProcessingApplication),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Revocation, ait_changerequeststatus.PendingTribalAction),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Revocation, ait_changerequeststatus.Approved),
          ait_membershipstatus.NonMember
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Revocation, ait_changerequeststatus.Denied),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Revocation, ait_changerequeststatus.Withdrawn),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Relinquishment, ait_changerequeststatus.Pending),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Relinquishment, ait_changerequeststatus.PendingMemberAction),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Relinquishment, ait_changerequeststatus.PendingProcessingApplication),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Relinquishment, ait_changerequeststatus.PendingTribalAction),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Relinquishment, ait_changerequeststatus.Approved),
          ait_membershipstatus.NonMember
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Relinquishment, ait_changerequeststatus.Denied),
          ait_membershipstatus.Member
        },
        {
          this.GetMembershipStatusKey(ait_changestatustype.Relinquishment, ait_changerequeststatus.Withdrawn),
          ait_membershipstatus.Member
        }
      };
    }

    private string GetMembershipStatusKey(
      ait_changestatustype changeStatusType,
      ait_changerequeststatus changeRequestStatus)
    {
      return string.Format("{0}-{1}", (object) (int) changeStatusType, (object) (int) changeRequestStatus);
    }

    private void UpdateRelatedRecords()
    {
      this.MemberProfile((IOrganizationService) this.CrmService, this.GetInputEntity<ait_membershipstatuschangerequest>(this.ActionType), this.ActionType);
    }
  }
}
