// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Email
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("email")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Email : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "email";
    public const string EntitySchemaName = "Email";
    public const string PrimaryIdAttribute = "activityid";
    public const string PrimaryNameAttribute = "subject";

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
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ActivityId));
      }
    }

    [AttributeLogicalName("activityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ActivityId = new Guid?(value);
    }

    [AttributeLogicalName("activitytypecode")]
    public string ActivityTypeCode => this.GetAttributeValue<string>("activitytypecode");

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
    public IEnumerable<ActivityParty> Bcc
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("bcc");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Bcc));
        if (value == null)
          this.SetAttributeValue("bcc", (object) value);
        else
          this.SetAttributeValue("bcc", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (Bcc));
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
    public IEnumerable<ActivityParty> Cc
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("cc");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (Cc));
        if (value == null)
          this.SetAttributeValue("cc", (object) value);
        else
          this.SetAttributeValue("cc", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (Cc));
      }
    }

    [AttributeLogicalName("compressed")]
    public bool? Compressed => this.GetAttributeValue<bool?>("compressed");

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

    [AttributeLogicalName("correlationmethod")]
    public OptionSetValue CorrelationMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("correlationmethod");
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (CreatedOnBehalfBy));
        this.SetAttributeValue("createdonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (CreatedOnBehalfBy));
      }
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

    [AttributeLogicalName("emailsender")]
    public EntityReference EmailSender => this.GetAttributeValue<EntityReference>("emailsender");

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

    [AttributeLogicalName("from")]
    public IEnumerable<ActivityParty> From
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("from");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (From));
        if (value == null)
          this.SetAttributeValue("from", (object) value);
        else
          this.SetAttributeValue("from", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (From));
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

    [AttributeLogicalName("isemailfollowed")]
    public bool? IsEmailFollowed => this.GetAttributeValue<bool?>("isemailfollowed");

    [AttributeLogicalName("isemailreminderset")]
    public bool? IsEmailReminderSet => this.GetAttributeValue<bool?>("isemailreminderset");

    [AttributeLogicalName("isregularactivity")]
    public bool? IsRegularActivity => this.GetAttributeValue<bool?>("isregularactivity");

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
    [Obsolete]
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

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
      set
      {
        this.OnPropertyChanging(nameof (ModifiedOnBehalfBy));
        this.SetAttributeValue("modifiedonbehalfby", (object) value);
        this.OnPropertyChanged(nameof (ModifiedOnBehalfBy));
      }
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

    [AttributeLogicalName("sendersaccount")]
    public EntityReference SendersAccount
    {
      get => this.GetAttributeValue<EntityReference>("sendersaccount");
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
    public EmailState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new EmailState?((EmailState) Enum.ToObject(typeof (EmailState), attributeValue.Value)) : new EmailState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (statecode));
        if (!value.HasValue)
          this.SetAttributeValue(nameof (statecode), (object) null);
        else
          this.SetAttributeValue(nameof (statecode), (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (statecode));
      }
    }

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
    public IEnumerable<ActivityParty> To
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("to");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, ActivityParty>((Func<Entity, ActivityParty>) (e => e.ToEntity<ActivityParty>())) : (IEnumerable<ActivityParty>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (To));
        if (value == null)
          this.SetAttributeValue("to", (object) value);
        else
          this.SetAttributeValue("to", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (To));
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

    [RelationshipSchemaName("email_actioncard")]
    public IEnumerable<ActionCard> email_actioncard
    {
      get => this.GetRelatedEntities<ActionCard>(nameof (email_actioncard), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (email_actioncard));
        this.SetRelatedEntities<ActionCard>(nameof (email_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_actioncard));
      }
    }

    [RelationshipSchemaName("email_activity_mime_attachment")]
    public IEnumerable<ActivityMimeAttachment> email_activity_mime_attachment
    {
      get
      {
        return this.GetRelatedEntities<ActivityMimeAttachment>(nameof (email_activity_mime_attachment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (email_activity_mime_attachment));
        this.SetRelatedEntities<ActivityMimeAttachment>(nameof (email_activity_mime_attachment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_activity_mime_attachment));
      }
    }

    [RelationshipSchemaName("email_activity_parties")]
    public IEnumerable<ActivityParty> email_activity_parties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (email_activity_parties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (email_activity_parties));
        this.SetRelatedEntities<ActivityParty>(nameof (email_activity_parties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_activity_parties));
      }
    }

    [RelationshipSchemaName("Email_Annotation")]
    public IEnumerable<Annotation> Email_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (Email_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (Email_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_Annotation));
      }
    }

    [RelationshipSchemaName("Email_AsyncOperations")]
    public IEnumerable<AsyncOperation> Email_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Email_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Email_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Email_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Email_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Email_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Email_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Email_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Email_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_BulkDeleteFailures));
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

    [RelationshipSchemaName("Email_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> Email_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Email_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Email_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Email_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("Email_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> Email_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Email_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Email_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Email_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_DuplicateMatchingRecord));
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

    [RelationshipSchemaName("email_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> email_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (email_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (email_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (email_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("Email_ProcessSessions")]
    public IEnumerable<ProcessSession> Email_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Email_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Email_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Email_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_ProcessSessions));
      }
    }

    [RelationshipSchemaName("Email_QueueItem")]
    public IEnumerable<QueueItem> Email_QueueItem
    {
      get => this.GetRelatedEntities<QueueItem>(nameof (Email_QueueItem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_QueueItem));
        this.SetRelatedEntities<QueueItem>(nameof (Email_QueueItem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_QueueItem));
      }
    }

    [RelationshipSchemaName("Email_SyncErrors")]
    public IEnumerable<SyncError> Email_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Email_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Email_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_SyncErrors));
      }
    }

    [RelationshipSchemaName("slakpiinstance_email")]
    public IEnumerable<SLAKPIInstance> slakpiinstance_email
    {
      get
      {
        return this.GetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_email), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slakpiinstance_email));
        this.SetRelatedEntities<SLAKPIInstance>(nameof (slakpiinstance_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slakpiinstance_email));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_email")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_email
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_email), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_email));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_email));
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

    [AttributeLogicalName("activityid")]
    [RelationshipSchemaName("activity_pointer_email")]
    public ActivityPointer activity_pointer_email
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (activity_pointer_email), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activity_pointer_email));
        this.SetRelatedEntity<ActivityPointer>(nameof (activity_pointer_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activity_pointer_email));
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

    [AttributeLogicalName("ait_outcome")]
    [RelationshipSchemaName("ait_ait_outcome_email_Outcome")]
    public ait_outcome ait_ait_outcome_email_Outcome
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_email_Outcome), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_outcome_email_Outcome));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_ait_outcome_email_Outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_outcome_email_Outcome));
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
    [RelationshipSchemaName("ait_casenote_Emails")]
    public ait_casenote ait_casenote_Emails
    {
      get => this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_Emails));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_Emails));
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
    [RelationshipSchemaName("ait_changerequest_Emails")]
    public ait_changerequest ait_changerequest_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_Emails));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_Emails));
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
    [RelationshipSchemaName("ait_courtcase_Emails")]
    public ait_courtcase ait_courtcase_Emails
    {
      get => this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_Emails));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_Emails));
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
    [RelationshipSchemaName("ait_icwaadoption_Emails")]
    public ait_icwaadoption ait_icwaadoption_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Emails));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_Emails")]
    public ait_icwanotice ait_icwanotice_Emails
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_Emails));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_Emails")]
    public ait_incident ait_incident_Emails
    {
      get => this.GetRelatedEntity<ait_incident>(nameof (ait_incident_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_Emails));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_Emails));
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
    [RelationshipSchemaName("ait_outcome_Emails")]
    public ait_outcome ait_outcome_Emails
    {
      get => this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_Emails));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_Emails));
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

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("AsyncOperation_Emails")]
    public AsyncOperation AsyncOperation_Emails
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>(nameof (AsyncOperation_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperation_Emails));
        this.SetRelatedEntity<AsyncOperation>(nameof (AsyncOperation_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AsyncOperation_Emails));
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

    [AttributeLogicalName("templateid")]
    [RelationshipSchemaName("Email_EmailTemplate")]
    public Template Email_EmailTemplate
    {
      get => this.GetRelatedEntity<Template>(nameof (Email_EmailTemplate), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_EmailTemplate));
        this.SetRelatedEntity<Template>(nameof (Email_EmailTemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_EmailTemplate));
      }
    }

    [AttributeLogicalName("sendermailboxid")]
    [RelationshipSchemaName("email_sendermailboxid_mailbox")]
    public Mailbox email_sendermailboxid_mailbox
    {
      get
      {
        return this.GetRelatedEntity<Mailbox>(nameof (email_sendermailboxid_mailbox), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_Emails")]
    public KnowledgeArticle KnowledgeArticle_Emails
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_Emails));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_Emails));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_Emails")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_Emails
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Emails), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_Emails));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_Emails));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_email_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_email_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_email_createdonbehalfby));
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
      set
      {
        this.OnPropertyChanging(nameof (lk_email_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_email_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_email_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("slaid")]
    [RelationshipSchemaName("manualsla_email")]
    public SLA manualsla_email
    {
      get => this.GetRelatedEntity<SLA>(nameof (manualsla_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (manualsla_email));
        this.SetRelatedEntity<SLA>(nameof (manualsla_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (manualsla_email));
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
    [RelationshipSchemaName("Queue_Email_EmailSender")]
    public Queue Queue_Email_EmailSender
    {
      get => this.GetRelatedEntity<Queue>(nameof (Queue_Email_EmailSender), new EntityRole?());
    }

    [AttributeLogicalName("slainvokedid")]
    [RelationshipSchemaName("sla_email")]
    public SLA sla_email => this.GetRelatedEntity<SLA>(nameof (sla_email), new EntityRole?());

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

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Email")]
    public TransactionCurrency TransactionCurrency_Email
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Email), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Email));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Email));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_email")]
    public SystemUser user_email
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_email), new EntityRole?());
    }

    public Email(object anonymousType)
      : this()
    {
      foreach (PropertyInfo property in anonymousType.GetType().GetProperties())
      {
        object obj = property.GetValue(anonymousType, (object[]) null);
        string str = property.Name.ToLower();
        if (str.EndsWith("enum") && obj.GetType().BaseType == typeof (Enum))
        {
          obj = (object) new OptionSetValue((int) obj);
          str = str.Remove(str.Length - "enum".Length);
        }
        switch (str)
        {
          case "id":
            base.Id = (Guid) obj;
            ((DataCollection<string, object>) this.Attributes)["activityid"] = (object) base.Id;
            break;
          case "activityid":
            Guid? nullable = (Guid?) obj;
            if (nullable.HasValue)
            {
              base.Id = nullable.Value;
              ((DataCollection<string, object>) this.Attributes)[str] = (object) base.Id;
              break;
            }
            continue;
          case "formattedvalues":
            ((DataCollection<string, string>) this.FormattedValues).AddRange((IEnumerable<KeyValuePair<string, string>>) obj);
            break;
          default:
            ((DataCollection<string, object>) this.Attributes)[str] = obj;
            break;
        }
      }
    }
  }
}
