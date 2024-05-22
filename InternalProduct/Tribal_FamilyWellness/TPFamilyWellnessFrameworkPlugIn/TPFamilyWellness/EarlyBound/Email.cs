// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Email
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("email")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class Email : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "email";
    public const int EntityTypeCode = 4202;

    public Email()
      : base("email")
    {
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    private void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnPropertyChanging(string propertyName)
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, new PropertyChangingEventArgs(propertyName));
    }

    [AttributeLogicalName("activityadditionalparams")]
    public string ActivityAdditionalParams
    {
      get => this.GetAttributeValue<string>("activityadditionalparams");
      set
      {
        this.OnPropertyChanging(nameof (ActivityAdditionalParams));
        this.SetAttributeValue("activityadditionalparams", (object) value);
        this.OnPropertyChanged(nameof (ActivityAdditionalParams));
      }
    }

    [AttributeLogicalName("activityid")]
    public Guid? ActivityId
    {
      get => this.GetAttributeValue<Guid?>("activityid");
      set
      {
        this.OnPropertyChanging(nameof (ActivityId));
        this.SetAttributeValue("activityid", (object) value);
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("activitytypecode")]
    public string ActivityTypeCode => this.GetAttributeValue<string>("activitytypecode");

    [AttributeLogicalName("activitytypecodename")]
    public object ActivityTypeCodeName => this.GetAttributeValue<object>("activitytypecodename");

    [AttributeLogicalName("actualdurationminutes")]
    public int? ActualDurationMinutes
    {
      get => this.GetAttributeValue<int?>("actualdurationminutes");
      set
      {
        this.OnPropertyChanging(nameof (ActualDurationMinutes));
        this.SetAttributeValue("actualdurationminutes", (object) value);
        this.OnPropertyChanged(nameof (ActualDurationMinutes));
      }
    }

    [AttributeLogicalName("actualend")]
    public DateTime? ActualEnd
    {
      get => this.GetAttributeValue<DateTime?>("actualend");
      set
      {
        this.OnPropertyChanging(nameof (ActualEnd));
        this.SetAttributeValue("actualend", (object) value);
        this.OnPropertyChanged(nameof (ActualEnd));
      }
    }

    [AttributeLogicalName("actualstart")]
    public DateTime? ActualStart
    {
      get => this.GetAttributeValue<DateTime?>("actualstart");
      set
      {
        this.OnPropertyChanging(nameof (ActualStart));
        this.SetAttributeValue("actualstart", (object) value);
        this.OnPropertyChanged(nameof (ActualStart));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    public EntityReference ait_CasePlan
    {
      get => this.GetAttributeValue<EntityReference>("ait_caseplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_CasePlan));
        this.SetAttributeValue("ait_caseplan", (object) value);
        this.OnPropertyChanged(nameof (ait_CasePlan));
      }
    }

    [AttributeLogicalName("ait_caseplanname")]
    public string ait_CasePlanName => this.GetAttributeValue<string>("ait_caseplanname");

    [AttributeLogicalName("ait_familygroup")]
    public EntityReference ait_FamilyGroup
    {
      get => this.GetAttributeValue<EntityReference>("ait_familygroup");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyGroup));
        this.SetAttributeValue("ait_familygroup", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_familygroupname")]
    public string ait_FamilyGroupName => this.GetAttributeValue<string>("ait_familygroupname");

    [AttributeLogicalName("ait_individual")]
    public EntityReference ait_Individual
    {
      get => this.GetAttributeValue<EntityReference>("ait_individual");
      set
      {
        this.OnPropertyChanging(nameof (ait_Individual));
        this.SetAttributeValue("ait_individual", (object) value);
        this.OnPropertyChanged(nameof (ait_Individual));
      }
    }

    [AttributeLogicalName("ait_individualname")]
    public string ait_IndividualName => this.GetAttributeValue<string>("ait_individualname");

    [AttributeLogicalName("ait_outcome")]
    public EntityReference ait_Outcome
    {
      get => this.GetAttributeValue<EntityReference>("ait_outcome");
      set
      {
        this.OnPropertyChanging(nameof (ait_Outcome));
        this.SetAttributeValue("ait_outcome", (object) value);
        this.OnPropertyChanged(nameof (ait_Outcome));
      }
    }

    [AttributeLogicalName("ait_outcomename")]
    public string ait_OutcomeName => this.GetAttributeValue<string>("ait_outcomename");

    [AttributeLogicalName("attachmentcount")]
    public int? AttachmentCount => this.GetAttributeValue<int?>("attachmentcount");

    [AttributeLogicalName("attachmentopencount")]
    public int? AttachmentOpenCount
    {
      get => this.GetAttributeValue<int?>("attachmentopencount");
      set
      {
        this.OnPropertyChanging(nameof (AttachmentOpenCount));
        this.SetAttributeValue("attachmentopencount", (object) value);
        this.OnPropertyChanged(nameof (AttachmentOpenCount));
      }
    }

    [AttributeLogicalName("baseconversationindexhash")]
    public int? BaseConversationIndexHash
    {
      get => this.GetAttributeValue<int?>("baseconversationindexhash");
      set
      {
        this.OnPropertyChanging(nameof (BaseConversationIndexHash));
        this.SetAttributeValue("baseconversationindexhash", (object) value);
        this.OnPropertyChanged(nameof (BaseConversationIndexHash));
      }
    }

    [AttributeLogicalName("bcc")]
    public IEnumerable<Entity> bcc
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>(nameof (bcc));
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (bcc));
        if (value == null)
          this.SetAttributeValue(nameof (bcc), (object) value);
        else
          this.SetAttributeValue(nameof (bcc), (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (bcc));
      }
    }

    [AttributeLogicalName("category")]
    public string Category
    {
      get => this.GetAttributeValue<string>("category");
      set
      {
        this.OnPropertyChanging(nameof (Category));
        this.SetAttributeValue("category", (object) value);
        this.OnPropertyChanged(nameof (Category));
      }
    }

    [AttributeLogicalName("cc")]
    public IEnumerable<Entity> cc
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>(nameof (cc));
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (cc));
        if (value == null)
          this.SetAttributeValue(nameof (cc), (object) value);
        else
          this.SetAttributeValue(nameof (cc), (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (cc));
      }
    }

    [AttributeLogicalName("compressed")]
    public bool? Compressed => this.GetAttributeValue<bool?>("compressed");

    [AttributeLogicalName("compressedname")]
    public object CompressedName => this.GetAttributeValue<object>("compressedname");

    [AttributeLogicalName("conversationindex")]
    public string ConversationIndex => this.GetAttributeValue<string>("conversationindex");

    [AttributeLogicalName("conversationtrackingid")]
    public Guid? ConversationTrackingId
    {
      get => this.GetAttributeValue<Guid?>("conversationtrackingid");
      set
      {
        this.OnPropertyChanging(nameof (ConversationTrackingId));
        this.SetAttributeValue("conversationtrackingid", (object) value);
        this.OnPropertyChanged(nameof (ConversationTrackingId));
      }
    }

    [AttributeLogicalName("correlatedactivityid")]
    public EntityReference CorrelatedActivityId
    {
      get => this.GetAttributeValue<EntityReference>("correlatedactivityid");
      set
      {
        this.OnPropertyChanging(nameof (CorrelatedActivityId));
        this.SetAttributeValue("correlatedactivityid", (object) value);
        this.OnPropertyChanged(nameof (CorrelatedActivityId));
      }
    }

    [AttributeLogicalName("correlatedactivityidname")]
    public string CorrelatedActivityIdName
    {
      get => this.GetAttributeValue<string>("correlatedactivityidname");
    }

    [AttributeLogicalName("correlationmethod")]
    public OptionSetValue CorrelationMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("correlationmethod");
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdbyname")]
    public string CreatedByName => this.GetAttributeValue<string>("createdbyname");

    [AttributeLogicalName("createdbyyominame")]
    public string CreatedByYomiName => this.GetAttributeValue<string>("createdbyyominame");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("createdonbehalfbyname")]
    public string CreatedOnBehalfByName => this.GetAttributeValue<string>("createdonbehalfbyname");

    [AttributeLogicalName("createdonbehalfbyyominame")]
    public string CreatedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("createdonbehalfbyyominame");
    }

    [AttributeLogicalName("delayedemailsendtime")]
    public DateTime? DelayedEmailSendTime
    {
      get => this.GetAttributeValue<DateTime?>("delayedemailsendtime");
      set
      {
        this.OnPropertyChanging(nameof (DelayedEmailSendTime));
        this.SetAttributeValue("delayedemailsendtime", (object) value);
        this.OnPropertyChanged(nameof (DelayedEmailSendTime));
      }
    }

    [AttributeLogicalName("deliveryattempts")]
    public int? DeliveryAttempts
    {
      get => this.GetAttributeValue<int?>("deliveryattempts");
      set
      {
        this.OnPropertyChanging(nameof (DeliveryAttempts));
        this.SetAttributeValue("deliveryattempts", (object) value);
        this.OnPropertyChanged(nameof (DeliveryAttempts));
      }
    }

    [AttributeLogicalName("deliveryprioritycode")]
    public OptionSetValue DeliveryPriorityCode
    {
      get => this.GetAttributeValue<OptionSetValue>("deliveryprioritycode");
      set
      {
        this.OnPropertyChanging(nameof (DeliveryPriorityCode));
        this.SetAttributeValue("deliveryprioritycode", (object) value);
        this.OnPropertyChanged(nameof (DeliveryPriorityCode));
      }
    }

    [AttributeLogicalName("deliveryprioritycodename")]
    public object DeliveryPriorityCodeName
    {
      get => this.GetAttributeValue<object>("deliveryprioritycodename");
    }

    [AttributeLogicalName("deliveryreceiptrequested")]
    public bool? DeliveryReceiptRequested
    {
      get => this.GetAttributeValue<bool?>("deliveryreceiptrequested");
      set
      {
        this.OnPropertyChanging(nameof (DeliveryReceiptRequested));
        this.SetAttributeValue("deliveryreceiptrequested", (object) value);
        this.OnPropertyChanged(nameof (DeliveryReceiptRequested));
      }
    }

    [AttributeLogicalName("deliveryreceiptrequestedname")]
    public object DeliveryReceiptRequestedName
    {
      get => this.GetAttributeValue<object>("deliveryreceiptrequestedname");
    }

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("directioncode")]
    public bool? DirectionCode
    {
      get => this.GetAttributeValue<bool?>("directioncode");
      set
      {
        this.OnPropertyChanging(nameof (DirectionCode));
        this.SetAttributeValue("directioncode", (object) value);
        this.OnPropertyChanged(nameof (DirectionCode));
      }
    }

    [AttributeLogicalName("directioncodename")]
    public object DirectionCodeName => this.GetAttributeValue<object>("directioncodename");

    [AttributeLogicalName("emailreminderexpirytime")]
    public DateTime? EmailReminderExpiryTime
    {
      get => this.GetAttributeValue<DateTime?>("emailreminderexpirytime");
      set
      {
        this.OnPropertyChanging(nameof (EmailReminderExpiryTime));
        this.SetAttributeValue("emailreminderexpirytime", (object) value);
        this.OnPropertyChanged(nameof (EmailReminderExpiryTime));
      }
    }

    [AttributeLogicalName("emailreminderstatus")]
    public OptionSetValue EmailReminderStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("emailreminderstatus");
    }

    [AttributeLogicalName("emailreminderstatusname")]
    public object EmailReminderStatusName
    {
      get => this.GetAttributeValue<object>("emailreminderstatusname");
    }

    [AttributeLogicalName("emailremindertext")]
    public string EmailReminderText
    {
      get => this.GetAttributeValue<string>("emailremindertext");
      set
      {
        this.OnPropertyChanging(nameof (EmailReminderText));
        this.SetAttributeValue("emailremindertext", (object) value);
        this.OnPropertyChanged(nameof (EmailReminderText));
      }
    }

    [AttributeLogicalName("emailremindertype")]
    public OptionSetValue EmailReminderType
    {
      get => this.GetAttributeValue<OptionSetValue>("emailremindertype");
      set
      {
        this.OnPropertyChanging(nameof (EmailReminderType));
        this.SetAttributeValue("emailremindertype", (object) value);
        this.OnPropertyChanged(nameof (EmailReminderType));
      }
    }

    [AttributeLogicalName("emailremindertypename")]
    public object EmailReminderTypeName => this.GetAttributeValue<object>("emailremindertypename");

    [AttributeLogicalName("emailsender")]
    public EntityReference EmailSender => this.GetAttributeValue<EntityReference>("emailsender");

    [AttributeLogicalName("emailsendername")]
    public string EmailSenderName
    {
      get => this.GetAttributeValue<string>("emailsendername");
      set
      {
        this.OnPropertyChanging(nameof (EmailSenderName));
        this.SetAttributeValue("emailsendername", (object) value);
        this.OnPropertyChanged(nameof (EmailSenderName));
      }
    }

    [AttributeLogicalName("emailsenderobjecttypecode")]
    public string EmailSenderObjectTypeCode
    {
      get => this.GetAttributeValue<string>("emailsenderobjecttypecode");
    }

    [AttributeLogicalName("emailsenderyominame")]
    public string EmailSenderYomiName => this.GetAttributeValue<string>("emailsenderyominame");

    [AttributeLogicalName("emailtrackingid")]
    public Guid? EmailTrackingId
    {
      get => this.GetAttributeValue<Guid?>("emailtrackingid");
      set
      {
        this.OnPropertyChanging(nameof (EmailTrackingId));
        this.SetAttributeValue("emailtrackingid", (object) value);
        this.OnPropertyChanged(nameof (EmailTrackingId));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("followemailuserpreference")]
    public bool? FollowEmailUserPreference
    {
      get => this.GetAttributeValue<bool?>("followemailuserpreference");
      set
      {
        this.OnPropertyChanging(nameof (FollowEmailUserPreference));
        this.SetAttributeValue("followemailuserpreference", (object) value);
        this.OnPropertyChanged(nameof (FollowEmailUserPreference));
      }
    }

    [AttributeLogicalName("followemailuserpreferencename")]
    public object FollowEmailUserPreferenceName
    {
      get => this.GetAttributeValue<object>("followemailuserpreferencename");
    }

    [AttributeLogicalName("from")]
    public IEnumerable<Entity> from
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>(nameof (from));
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging("@from");
        if (value == null)
          this.SetAttributeValue(nameof (from), (object) value);
        else
          this.SetAttributeValue(nameof (from), (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged("@from");
      }
    }

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("importsequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (ImportSequenceNumber));
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged(nameof (ImportSequenceNumber));
      }
    }

    [AttributeLogicalName("inreplyto")]
    public string InReplyTo => this.GetAttributeValue<string>("inreplyto");

    [AttributeLogicalName("isbilled")]
    public bool? IsBilled
    {
      get => this.GetAttributeValue<bool?>("isbilled");
      set
      {
        this.OnPropertyChanging(nameof (IsBilled));
        this.SetAttributeValue("isbilled", (object) value);
        this.OnPropertyChanged(nameof (IsBilled));
      }
    }

    [AttributeLogicalName("isbilledname")]
    public object IsBilledName => this.GetAttributeValue<object>("isbilledname");

    [AttributeLogicalName("isemailfollowed")]
    public bool? IsEmailFollowed => this.GetAttributeValue<bool?>("isemailfollowed");

    [AttributeLogicalName("isemailfollowedname")]
    public object IsEmailFollowedName => this.GetAttributeValue<object>("isemailfollowedname");

    [AttributeLogicalName("isemailreminderset")]
    public bool? IsEmailReminderSet => this.GetAttributeValue<bool?>("isemailreminderset");

    [AttributeLogicalName("isemailremindersetname")]
    public object IsEmailReminderSetName
    {
      get => this.GetAttributeValue<object>("isemailremindersetname");
    }

    [AttributeLogicalName("isregularactivity")]
    public bool? IsRegularActivity => this.GetAttributeValue<bool?>("isregularactivity");

    [AttributeLogicalName("isregularactivityname")]
    public object IsRegularActivityName => this.GetAttributeValue<object>("isregularactivityname");

    [AttributeLogicalName("isunsafe")]
    public int? IsUnsafe => this.GetAttributeValue<int?>("isunsafe");

    [AttributeLogicalName("isworkflowcreated")]
    public bool? IsWorkflowCreated
    {
      get => this.GetAttributeValue<bool?>("isworkflowcreated");
      set
      {
        this.OnPropertyChanging(nameof (IsWorkflowCreated));
        this.SetAttributeValue("isworkflowcreated", (object) value);
        this.OnPropertyChanged(nameof (IsWorkflowCreated));
      }
    }

    [AttributeLogicalName("isworkflowcreatedname")]
    public object IsWorkflowCreatedName => this.GetAttributeValue<object>("isworkflowcreatedname");

    [AttributeLogicalName("lastonholdtime")]
    public DateTime? LastOnHoldTime
    {
      get => this.GetAttributeValue<DateTime?>("lastonholdtime");
      set
      {
        this.OnPropertyChanging(nameof (LastOnHoldTime));
        this.SetAttributeValue("lastonholdtime", (object) value);
        this.OnPropertyChanged(nameof (LastOnHoldTime));
      }
    }

    [AttributeLogicalName("lastopenedtime")]
    public DateTime? LastOpenedTime
    {
      get => this.GetAttributeValue<DateTime?>("lastopenedtime");
      set
      {
        this.OnPropertyChanging(nameof (LastOpenedTime));
        this.SetAttributeValue("lastopenedtime", (object) value);
        this.OnPropertyChanged(nameof (LastOpenedTime));
      }
    }

    [AttributeLogicalName("linksclickedcount")]
    public int? LinksClickedCount
    {
      get => this.GetAttributeValue<int?>("linksclickedcount");
      set
      {
        this.OnPropertyChanging(nameof (LinksClickedCount));
        this.SetAttributeValue("linksclickedcount", (object) value);
        this.OnPropertyChanged(nameof (LinksClickedCount));
      }
    }

    [AttributeLogicalName("messageid")]
    public string MessageId
    {
      get => this.GetAttributeValue<string>("messageid");
      set
      {
        this.OnPropertyChanging(nameof (MessageId));
        this.SetAttributeValue("messageid", (object) value);
        this.OnPropertyChanged(nameof (MessageId));
      }
    }

    [AttributeLogicalName("messageiddupcheck")]
    public Guid? MessageIdDupCheck
    {
      get => this.GetAttributeValue<Guid?>("messageiddupcheck");
      set
      {
        this.OnPropertyChanging(nameof (MessageIdDupCheck));
        this.SetAttributeValue("messageiddupcheck", (object) value);
        this.OnPropertyChanged(nameof (MessageIdDupCheck));
      }
    }

    [AttributeLogicalName("mimetype")]
    public string MimeType
    {
      get => this.GetAttributeValue<string>("mimetype");
      set
      {
        this.OnPropertyChanging(nameof (MimeType));
        this.SetAttributeValue("mimetype", (object) value);
        this.OnPropertyChanged(nameof (MimeType));
      }
    }

    [AttributeLogicalName("modifiedby")]
    public EntityReference ModifiedBy => this.GetAttributeValue<EntityReference>("modifiedby");

    [AttributeLogicalName("modifiedbyname")]
    public string ModifiedByName => this.GetAttributeValue<string>("modifiedbyname");

    [AttributeLogicalName("modifiedbyyominame")]
    public string ModifiedByYomiName => this.GetAttributeValue<string>("modifiedbyyominame");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
    }

    [AttributeLogicalName("modifiedonbehalfbyname")]
    public string ModifiedOnBehalfByName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyname");
    }

    [AttributeLogicalName("modifiedonbehalfbyyominame")]
    public string ModifiedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyyominame");
    }

    [AttributeLogicalName("notifications")]
    public OptionSetValue Notifications
    {
      get => this.GetAttributeValue<OptionSetValue>("notifications");
      set
      {
        this.OnPropertyChanging(nameof (Notifications));
        this.SetAttributeValue("notifications", (object) value);
        this.OnPropertyChanged(nameof (Notifications));
      }
    }

    [AttributeLogicalName("notificationsname")]
    public object NotificationsName => this.GetAttributeValue<object>("notificationsname");

    [AttributeLogicalName("onholdtime")]
    public int? OnHoldTime => this.GetAttributeValue<int?>("onholdtime");

    [AttributeLogicalName("opencount")]
    public int? OpenCount
    {
      get => this.GetAttributeValue<int?>("opencount");
      set
      {
        this.OnPropertyChanging(nameof (OpenCount));
        this.SetAttributeValue("opencount", (object) value);
        this.OnPropertyChanged(nameof (OpenCount));
      }
    }

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("overriddencreatedon");
      set
      {
        this.OnPropertyChanging(nameof (OverriddenCreatedOn));
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged(nameof (OverriddenCreatedOn));
      }
    }

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId
    {
      get => this.GetAttributeValue<EntityReference>("ownerid");
      set
      {
        this.OnPropertyChanging(nameof (OwnerId));
        this.SetAttributeValue("ownerid", (object) value);
        this.OnPropertyChanged(nameof (OwnerId));
      }
    }

    [AttributeLogicalName("owneridname")]
    public string OwnerIdName => this.GetAttributeValue<string>("owneridname");

    [AttributeLogicalName("owneridtype")]
    public string OwnerIdType
    {
      get => this.GetAttributeValue<string>("owneridtype");
      set
      {
        this.OnPropertyChanging(nameof (OwnerIdType));
        this.SetAttributeValue("owneridtype", (object) value);
        this.OnPropertyChanged(nameof (OwnerIdType));
      }
    }

    [AttributeLogicalName("owneridyominame")]
    public string OwnerIdYomiName => this.GetAttributeValue<string>("owneridyominame");

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owningteam")]
    public EntityReference OwningTeam => this.GetAttributeValue<EntityReference>("owningteam");

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("parentactivityid")]
    public EntityReference ParentActivityId
    {
      get => this.GetAttributeValue<EntityReference>("parentactivityid");
      set
      {
        this.OnPropertyChanging(nameof (ParentActivityId));
        this.SetAttributeValue("parentactivityid", (object) value);
        this.OnPropertyChanged(nameof (ParentActivityId));
      }
    }

    [AttributeLogicalName("parentactivityidname")]
    public string ParentActivityIdName => this.GetAttributeValue<string>("parentactivityidname");

    [AttributeLogicalName("postponeemailprocessinguntil")]
    public DateTime? PostponeEmailProcessingUntil
    {
      get => this.GetAttributeValue<DateTime?>("postponeemailprocessinguntil");
    }

    [AttributeLogicalName("prioritycode")]
    public OptionSetValue PriorityCode
    {
      get => this.GetAttributeValue<OptionSetValue>("prioritycode");
      set
      {
        this.OnPropertyChanging(nameof (PriorityCode));
        this.SetAttributeValue("prioritycode", (object) value);
        this.OnPropertyChanged(nameof (PriorityCode));
      }
    }

    [AttributeLogicalName("prioritycodename")]
    public object PriorityCodeName => this.GetAttributeValue<object>("prioritycodename");

    [AttributeLogicalName("processid")]
    public Guid? ProcessId
    {
      get => this.GetAttributeValue<Guid?>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("readreceiptrequested")]
    public bool? ReadReceiptRequested
    {
      get => this.GetAttributeValue<bool?>("readreceiptrequested");
      set
      {
        this.OnPropertyChanging(nameof (ReadReceiptRequested));
        this.SetAttributeValue("readreceiptrequested", (object) value);
        this.OnPropertyChanged(nameof (ReadReceiptRequested));
      }
    }

    [AttributeLogicalName("readreceiptrequestedname")]
    public object ReadReceiptRequestedName
    {
      get => this.GetAttributeValue<object>("readreceiptrequestedname");
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("regardingobjectidname")]
    public string RegardingObjectIdName => this.GetAttributeValue<string>("regardingobjectidname");

    [AttributeLogicalName("regardingobjectidyominame")]
    public string RegardingObjectIdYomiName
    {
      get => this.GetAttributeValue<string>("regardingobjectidyominame");
    }

    [AttributeLogicalName("regardingobjecttypecode")]
    public string RegardingObjectTypeCode
    {
      get => this.GetAttributeValue<string>("regardingobjecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectTypeCode));
        this.SetAttributeValue("regardingobjecttypecode", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectTypeCode));
      }
    }

    [AttributeLogicalName("reminderactioncardid")]
    public Guid? ReminderActionCardId
    {
      get => this.GetAttributeValue<Guid?>("reminderactioncardid");
      set
      {
        this.OnPropertyChanging(nameof (ReminderActionCardId));
        this.SetAttributeValue("reminderactioncardid", (object) value);
        this.OnPropertyChanged(nameof (ReminderActionCardId));
      }
    }

    [AttributeLogicalName("replycount")]
    public int? ReplyCount => this.GetAttributeValue<int?>("replycount");

    [AttributeLogicalName("reservedforinternaluse")]
    public string ReservedForInternalUse
    {
      get => this.GetAttributeValue<string>("reservedforinternaluse");
      set
      {
        this.OnPropertyChanging(nameof (ReservedForInternalUse));
        this.SetAttributeValue("reservedforinternaluse", (object) value);
        this.OnPropertyChanged(nameof (ReservedForInternalUse));
      }
    }

    [AttributeLogicalName("safedescription")]
    public string SafeDescription => this.GetAttributeValue<string>("safedescription");

    [AttributeLogicalName("scheduleddurationminutes")]
    public int? ScheduledDurationMinutes
    {
      get => this.GetAttributeValue<int?>("scheduleddurationminutes");
    }

    [AttributeLogicalName("scheduledend")]
    public DateTime? ScheduledEnd
    {
      get => this.GetAttributeValue<DateTime?>("scheduledend");
      set
      {
        this.OnPropertyChanging(nameof (ScheduledEnd));
        this.SetAttributeValue("scheduledend", (object) value);
        this.OnPropertyChanged(nameof (ScheduledEnd));
      }
    }

    [AttributeLogicalName("scheduledstart")]
    public DateTime? ScheduledStart
    {
      get => this.GetAttributeValue<DateTime?>("scheduledstart");
      set
      {
        this.OnPropertyChanging(nameof (ScheduledStart));
        this.SetAttributeValue("scheduledstart", (object) value);
        this.OnPropertyChanged(nameof (ScheduledStart));
      }
    }

    [AttributeLogicalName("sender")]
    public string Sender
    {
      get => this.GetAttributeValue<string>("sender");
      set
      {
        this.OnPropertyChanging(nameof (Sender));
        this.SetAttributeValue("sender", (object) value);
        this.OnPropertyChanged(nameof (Sender));
      }
    }

    [AttributeLogicalName("sendermailboxid")]
    public EntityReference SenderMailboxId
    {
      get => this.GetAttributeValue<EntityReference>("sendermailboxid");
    }

    [AttributeLogicalName("sendermailboxidname")]
    public string SenderMailboxIdName => this.GetAttributeValue<string>("sendermailboxidname");

    [AttributeLogicalName("sendersaccount")]
    public EntityReference SendersAccount
    {
      get => this.GetAttributeValue<EntityReference>("sendersaccount");
    }

    [AttributeLogicalName("sendersaccountname")]
    public string SendersAccountName
    {
      get => this.GetAttributeValue<string>("sendersaccountname");
      set
      {
        this.OnPropertyChanging(nameof (SendersAccountName));
        this.SetAttributeValue("sendersaccountname", (object) value);
        this.OnPropertyChanged(nameof (SendersAccountName));
      }
    }

    [AttributeLogicalName("sendersaccountobjecttypecode")]
    public string SendersAccountObjectTypeCode
    {
      get => this.GetAttributeValue<string>("sendersaccountobjecttypecode");
    }

    [AttributeLogicalName("sendersaccountyominame")]
    public string SendersAccountYomiName
    {
      get => this.GetAttributeValue<string>("sendersaccountyominame");
    }

    [AttributeLogicalName("senton")]
    public DateTime? SentOn => this.GetAttributeValue<DateTime?>("senton");

    [AttributeLogicalName("slaid")]
    public EntityReference SLAId
    {
      get => this.GetAttributeValue<EntityReference>("slaid");
      set
      {
        this.OnPropertyChanging(nameof (SLAId));
        this.SetAttributeValue("slaid", (object) value);
        this.OnPropertyChanged(nameof (SLAId));
      }
    }

    [AttributeLogicalName("slainvokedid")]
    public EntityReference SLAInvokedId => this.GetAttributeValue<EntityReference>("slainvokedid");

    [AttributeLogicalName("slainvokedidname")]
    public string SLAInvokedIdName => this.GetAttributeValue<string>("slainvokedidname");

    [AttributeLogicalName("slaname")]
    public string SLAName => this.GetAttributeValue<string>("slaname");

    [AttributeLogicalName("sortdate")]
    public DateTime? SortDate
    {
      get => this.GetAttributeValue<DateTime?>("sortdate");
      set
      {
        this.OnPropertyChanging(nameof (SortDate));
        this.SetAttributeValue("sortdate", (object) value);
        this.OnPropertyChanged(nameof (SortDate));
      }
    }

    [AttributeLogicalName("stageid")]
    public Guid? StageId
    {
      get => this.GetAttributeValue<Guid?>("stageid");
      set
      {
        this.OnPropertyChanging(nameof (StageId));
        this.SetAttributeValue("stageid", (object) value);
        this.OnPropertyChanged(nameof (StageId));
      }
    }

    [AttributeLogicalName("statecode")]
    public EmailState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new EmailState?((EmailState) Enum.ToObject(typeof (EmailState), attributeValue.Value)) : new EmailState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (StateCode));
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (StateCode));
      }
    }

    [AttributeLogicalName("statecodename")]
    public object StateCodeName => this.GetAttributeValue<object>("statecodename");

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode
    {
      get => this.GetAttributeValue<OptionSetValue>("statuscode");
      set
      {
        this.OnPropertyChanging(nameof (StatusCode));
        this.SetAttributeValue("statuscode", (object) value);
        this.OnPropertyChanged(nameof (StatusCode));
      }
    }

    [AttributeLogicalName("statuscodename")]
    public object StatusCodeName => this.GetAttributeValue<object>("statuscodename");

    [AttributeLogicalName("subcategory")]
    public string Subcategory
    {
      get => this.GetAttributeValue<string>("subcategory");
      set
      {
        this.OnPropertyChanging(nameof (Subcategory));
        this.SetAttributeValue("subcategory", (object) value);
        this.OnPropertyChanged(nameof (Subcategory));
      }
    }

    [AttributeLogicalName("subject")]
    public string Subject
    {
      get => this.GetAttributeValue<string>("subject");
      set
      {
        this.OnPropertyChanging(nameof (Subject));
        this.SetAttributeValue("subject", (object) value);
        this.OnPropertyChanged(nameof (Subject));
      }
    }

    [AttributeLogicalName("submittedby")]
    public string SubmittedBy
    {
      get => this.GetAttributeValue<string>("submittedby");
      set
      {
        this.OnPropertyChanging(nameof (SubmittedBy));
        this.SetAttributeValue("submittedby", (object) value);
        this.OnPropertyChanged(nameof (SubmittedBy));
      }
    }

    [AttributeLogicalName("templateid")]
    public EntityReference TemplateId
    {
      get => this.GetAttributeValue<EntityReference>("templateid");
      set
      {
        this.OnPropertyChanging(nameof (TemplateId));
        this.SetAttributeValue("templateid", (object) value);
        this.OnPropertyChanged(nameof (TemplateId));
      }
    }

    [AttributeLogicalName("templateidname")]
    public string TemplateIdName => this.GetAttributeValue<string>("templateidname");

    [AttributeLogicalName("timezoneruleversionnumber")]
    public int? TimeZoneRuleVersionNumber
    {
      get => this.GetAttributeValue<int?>("timezoneruleversionnumber");
      set
      {
        this.OnPropertyChanging(nameof (TimeZoneRuleVersionNumber));
        this.SetAttributeValue("timezoneruleversionnumber", (object) value);
        this.OnPropertyChanged(nameof (TimeZoneRuleVersionNumber));
      }
    }

    [AttributeLogicalName("to")]
    public IEnumerable<Entity> to
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>(nameof (to));
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable) attributeValue.Entities).Cast<Entity>() : (IEnumerable<Entity>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (to));
        if (value == null)
          this.SetAttributeValue(nameof (to), (object) value);
        else
          this.SetAttributeValue(nameof (to), (object) new EntityCollection((IList<Entity>) new List<Entity>(value)));
        this.OnPropertyChanged(nameof (to));
      }
    }

    [AttributeLogicalName("torecipients")]
    public string ToRecipients
    {
      get => this.GetAttributeValue<string>("torecipients");
      set
      {
        this.OnPropertyChanging(nameof (ToRecipients));
        this.SetAttributeValue("torecipients", (object) value);
        this.OnPropertyChanged(nameof (ToRecipients));
      }
    }

    [AttributeLogicalName("trackingtoken")]
    public string TrackingToken
    {
      get => this.GetAttributeValue<string>("trackingtoken");
      set
      {
        this.OnPropertyChanging(nameof (TrackingToken));
        this.SetAttributeValue("trackingtoken", (object) value);
        this.OnPropertyChanged(nameof (TrackingToken));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
      }
    }

    [AttributeLogicalName("transactioncurrencyidname")]
    public string TransactionCurrencyIdName
    {
      get => this.GetAttributeValue<string>("transactioncurrencyidname");
    }

    [AttributeLogicalName("traversedpath")]
    public string TraversedPath
    {
      get => this.GetAttributeValue<string>("traversedpath");
      set
      {
        this.OnPropertyChanging(nameof (TraversedPath));
        this.SetAttributeValue("traversedpath", (object) value);
        this.OnPropertyChanged(nameof (TraversedPath));
      }
    }

    [AttributeLogicalName("utcconversiontimezonecode")]
    public int? UTCConversionTimeZoneCode
    {
      get => this.GetAttributeValue<int?>("utcconversiontimezonecode");
      set
      {
        this.OnPropertyChanging(nameof (UTCConversionTimeZoneCode));
        this.SetAttributeValue("utcconversiontimezonecode", (object) value);
        this.OnPropertyChanged(nameof (UTCConversionTimeZoneCode));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("ait_email_ait_planactivity_Email")]
    public IEnumerable<ait_planactivity> ait_email_ait_planactivity_Email
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_email_ait_planactivity_Email), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_email_ait_planactivity_Email));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_email_ait_planactivity_Email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_email_ait_planactivity_Email));
      }
    }

    [RelationshipSchemaName("email_connections1")]
    public IEnumerable<Connection> email_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (email_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (email_connections1));
        this.SetRelatedEntities<Connection>(nameof (email_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_connections1));
      }
    }

    [RelationshipSchemaName("email_connections2")]
    public IEnumerable<Connection> email_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (email_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (email_connections2));
        this.SetRelatedEntities<Connection>(nameof (email_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_connections2));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Email> Referencedemail_email_CorrelatedActivityId
    {
      get
      {
        return this.GetRelatedEntities<Email>("email_email_CorrelatedActivityId", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedemail_email_CorrelatedActivityId));
        this.SetRelatedEntities<Email>("email_email_CorrelatedActivityId", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedemail_email_CorrelatedActivityId));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Email> Referencedemail_email_parentactivityid
    {
      get
      {
        return this.GetRelatedEntities<Email>("email_email_parentactivityid", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedemail_email_parentactivityid));
        this.SetRelatedEntities<Email>("email_email_parentactivityid", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedemail_email_parentactivityid));
      }
    }

    [AttributeLogicalName("emailsender")]
    [RelationshipSchemaName("Account_Email_EmailSender")]
    public Account Account_Email_EmailSender
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_Email_EmailSender), new EntityRole?());
    }

    [AttributeLogicalName("sendersaccount")]
    [RelationshipSchemaName("Account_Email_SendersAccount")]
    public Account Account_Email_SendersAccount
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (Account_Email_SendersAccount), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_Emails")]
    public Account Account_Emails
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_Emails));
        this.SetRelatedEntity<Account>(nameof (Account_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_Emails));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_email_Plan")]
    public ait_caseplan ait_ait_caseplan_email_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_email_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_email_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_ait_caseplan_email_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_email_Plan));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_ait_clientprofile_email_Individual")]
    public ait_clientprofile ait_ait_clientprofile_email_Individual
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_email_Individual), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_clientprofile_email_Individual));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_ait_clientprofile_email_Individual), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_clientprofile_email_Individual));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_email_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_email_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_email_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_email_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_email_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_email_FamilyGroup));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_Emails")]
    public ait_assessment ait_assessment_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_Emails));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_Emails")]
    public ait_case ait_case_Emails
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_Emails));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenotefamilywellness_Emails")]
    public ait_casenotefamilywellness ait_casenotefamilywellness_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_casenotefamilywellness>(nameof (ait_casenotefamilywellness_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenotefamilywellness_Emails));
        this.SetRelatedEntity<ait_casenotefamilywellness>(nameof (ait_casenotefamilywellness_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenotefamilywellness_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_Emails")]
    public ait_caseplan ait_caseplan_Emails
    {
      get => this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_Emails));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_Emails")]
    public ait_clientprofile ait_clientprofile_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_Emails));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_Emails")]
    public ait_familygroup ait_familygroup_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_Emails));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_Emails")]
    public ait_goal ait_goal_Emails
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_Emails));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivityregistration_Emails")]
    public ait_groupactivityregistration ait_groupactivityregistration_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivityregistration>(nameof (ait_groupactivityregistration_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityregistration_Emails));
        this.SetRelatedEntity<ait_groupactivityregistration>(nameof (ait_groupactivityregistration_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivityregistration_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incidents_Emails")]
    public ait_incidents ait_incidents_Emails
    {
      get => this.GetRelatedEntity<ait_incidents>(nameof (ait_incidents_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incidents_Emails));
        this.SetRelatedEntity<ait_incidents>(nameof (ait_incidents_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidents_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_Emails")]
    public ait_investigation ait_investigation_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_Emails));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_meetingattendee_Emails")]
    public ait_meetingattendee ait_meetingattendee_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_meetingattendee_Emails));
        this.SetRelatedEntity<ait_meetingattendee>(nameof (ait_meetingattendee_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_meetingattendee_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_Emails")]
    public ait_planactivity ait_planactivity_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_Emails));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_Emails")]
    public ait_program ait_program_Emails
    {
      get => this.GetRelatedEntity<ait_program>(nameof (ait_program_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Emails));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_Emails")]
    public ait_referral ait_referral_Emails
    {
      get => this.GetRelatedEntity<ait_referral>(nameof (ait_referral_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_Emails));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_Emails")]
    public ait_servicerequest ait_servicerequest_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_Emails));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_Emails));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_email_activities")]
    public BusinessUnit business_unit_email_activities
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_email_activities), new EntityRole?());
      }
    }

    [AttributeLogicalName("emailsender")]
    [RelationshipSchemaName("Contact_Email_EmailSender")]
    public Contact Contact_Email_EmailSender
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Email_EmailSender), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_Emails")]
    public Contact Contact_Emails
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_Emails));
        this.SetRelatedEntity<Contact>(nameof (Contact_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_Emails));
      }
    }

    [AttributeLogicalName("correlatedactivityid")]
    [RelationshipSchemaName]
    public Email Referencingemail_email_CorrelatedActivityId
    {
      get
      {
        return this.GetRelatedEntity<Email>("email_email_CorrelatedActivityId", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingemail_email_CorrelatedActivityId));
        this.SetRelatedEntity<Email>("email_email_CorrelatedActivityId", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingemail_email_CorrelatedActivityId));
      }
    }

    [AttributeLogicalName("parentactivityid")]
    [RelationshipSchemaName]
    public Email Referencingemail_email_parentactivityid
    {
      get
      {
        return this.GetRelatedEntity<Email>("email_email_parentactivityid", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingemail_email_parentactivityid));
        this.SetRelatedEntity<Email>("email_email_parentactivityid", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingemail_email_parentactivityid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_email_createdby")]
    public SystemUser lk_email_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_email_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_email_createdonbehalfby")]
    public SystemUser lk_email_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_email_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_email_modifiedby")]
    public SystemUser lk_email_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_email_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_email_modifiedonbehalfby")]
    public SystemUser lk_email_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_email_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_emails")]
    public ProcessStage processstage_emails
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_emails));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_emails));
      }
    }

    [AttributeLogicalName("emailsender")]
    [RelationshipSchemaName("SystemUser_Email_EmailSender")]
    public SystemUser SystemUser_Email_EmailSender
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (SystemUser_Email_EmailSender), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_email")]
    public Team team_email => this.GetRelatedEntity<Team>(nameof (team_email), new EntityRole?());

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_email")]
    public SystemUser user_email
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_email), new EntityRole?());
    }
  }
}
