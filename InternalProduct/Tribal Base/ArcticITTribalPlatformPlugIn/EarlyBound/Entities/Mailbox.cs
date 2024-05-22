// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Mailbox
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mailbox")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Mailbox : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mailbox";
    public const string EntitySchemaName = "Mailbox";
    public const string PrimaryIdAttribute = "mailboxid";
    public const string PrimaryNameAttribute = "name";

    public Mailbox()
      : base("mailbox")
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

    [AttributeLogicalName("actdeliverymethod")]
    public OptionSetValue ACTDeliveryMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("actdeliverymethod");
      set
      {
        this.OnPropertyChanging(nameof (ACTDeliveryMethod));
        this.SetAttributeValue("actdeliverymethod", (object) value);
        this.OnPropertyChanged(nameof (ACTDeliveryMethod));
      }
    }

    [AttributeLogicalName("actstatus")]
    public OptionSetValue ACTStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("actstatus");
      set
      {
        this.OnPropertyChanging(nameof (ACTStatus));
        this.SetAttributeValue("actstatus", (object) value);
        this.OnPropertyChanged(nameof (ACTStatus));
      }
    }

    [AttributeLogicalName("allowemailconnectortousecredentials")]
    public bool? AllowEmailConnectorToUseCredentials
    {
      get => this.GetAttributeValue<bool?>("allowemailconnectortousecredentials");
      set
      {
        this.OnPropertyChanging(nameof (AllowEmailConnectorToUseCredentials));
        this.SetAttributeValue("allowemailconnectortousecredentials", (object) value);
        this.OnPropertyChanged(nameof (AllowEmailConnectorToUseCredentials));
      }
    }

    [AttributeLogicalName("averagetotalduration")]
    public int? AverageTotalDuration => this.GetAttributeValue<int?>("averagetotalduration");

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

    [AttributeLogicalName("emailaddress")]
    public string EmailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EmailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EmailAddress));
      }
    }

    [AttributeLogicalName("emailrouteraccessapproval")]
    public OptionSetValue EmailRouterAccessApproval
    {
      get => this.GetAttributeValue<OptionSetValue>("emailrouteraccessapproval");
      set
      {
        this.OnPropertyChanging(nameof (EmailRouterAccessApproval));
        this.SetAttributeValue("emailrouteraccessapproval", (object) value);
        this.OnPropertyChanged(nameof (EmailRouterAccessApproval));
      }
    }

    [AttributeLogicalName("emailserverprofile")]
    public EntityReference EmailServerProfile
    {
      get => this.GetAttributeValue<EntityReference>("emailserverprofile");
      set
      {
        this.OnPropertyChanging(nameof (EmailServerProfile));
        this.SetAttributeValue("emailserverprofile", (object) value);
        this.OnPropertyChanged(nameof (EmailServerProfile));
      }
    }

    [AttributeLogicalName("enabledforact")]
    public bool? EnabledForACT
    {
      get => this.GetAttributeValue<bool?>("enabledforact");
      set
      {
        this.OnPropertyChanging(nameof (EnabledForACT));
        this.SetAttributeValue("enabledforact", (object) value);
        this.OnPropertyChanged(nameof (EnabledForACT));
      }
    }

    [AttributeLogicalName("enabledforincomingemail")]
    public bool? EnabledForIncomingEmail
    {
      get => this.GetAttributeValue<bool?>("enabledforincomingemail");
      set
      {
        this.OnPropertyChanging(nameof (EnabledForIncomingEmail));
        this.SetAttributeValue("enabledforincomingemail", (object) value);
        this.OnPropertyChanged(nameof (EnabledForIncomingEmail));
      }
    }

    [AttributeLogicalName("enabledforoutgoingemail")]
    public bool? EnabledForOutgoingEmail
    {
      get => this.GetAttributeValue<bool?>("enabledforoutgoingemail");
      set
      {
        this.OnPropertyChanging(nameof (EnabledForOutgoingEmail));
        this.SetAttributeValue("enabledforoutgoingemail", (object) value);
        this.OnPropertyChanged(nameof (EnabledForOutgoingEmail));
      }
    }

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

    [AttributeLogicalName("ewsurl")]
    public string EWSURL
    {
      get => this.GetAttributeValue<string>("ewsurl");
      set
      {
        this.OnPropertyChanging(nameof (EWSURL));
        this.SetAttributeValue("ewsurl", (object) value);
        this.OnPropertyChanged(nameof (EWSURL));
      }
    }

    [AttributeLogicalName("exchangecontactsimportcompletedon")]
    public DateTime? ExchangeContactsImportCompletedOn
    {
      get => this.GetAttributeValue<DateTime?>("exchangecontactsimportcompletedon");
    }

    [AttributeLogicalName("exchangecontactsimportstatus")]
    public OptionSetValue ExchangeContactsImportStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("exchangecontactsimportstatus");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeContactsImportStatus));
        this.SetAttributeValue("exchangecontactsimportstatus", (object) value);
        this.OnPropertyChanged(nameof (ExchangeContactsImportStatus));
      }
    }

    [AttributeLogicalName("exchangesyncstatexml")]
    public string ExchangeSyncStateXml
    {
      get => this.GetAttributeValue<string>("exchangesyncstatexml");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeSyncStateXml));
        this.SetAttributeValue("exchangesyncstatexml", (object) value);
        this.OnPropertyChanged(nameof (ExchangeSyncStateXml));
      }
    }

    [AttributeLogicalName("folderhierarchy")]
    public string FolderHierarchy
    {
      get => this.GetAttributeValue<string>("folderhierarchy");
      set
      {
        this.OnPropertyChanging(nameof (FolderHierarchy));
        this.SetAttributeValue("folderhierarchy", (object) value);
        this.OnPropertyChanged(nameof (FolderHierarchy));
      }
    }

    [AttributeLogicalName("forcedunlockcount")]
    public int? ForcedUnlockCount => this.GetAttributeValue<int?>("forcedunlockcount");

    [AttributeLogicalName("hostid")]
    public string HostId => this.GetAttributeValue<string>("hostid");

    [AttributeLogicalName("incomingemaildeliverymethod")]
    public OptionSetValue IncomingEmailDeliveryMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod");
      set
      {
        this.OnPropertyChanging(nameof (IncomingEmailDeliveryMethod));
        this.SetAttributeValue("incomingemaildeliverymethod", (object) value);
        this.OnPropertyChanged(nameof (IncomingEmailDeliveryMethod));
      }
    }

    [AttributeLogicalName("incomingemailstatus")]
    public OptionSetValue IncomingEmailStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("incomingemailstatus");
      set
      {
        this.OnPropertyChanging(nameof (IncomingEmailStatus));
        this.SetAttributeValue("incomingemailstatus", (object) value);
        this.OnPropertyChanged(nameof (IncomingEmailStatus));
      }
    }

    [AttributeLogicalName("isactsyncorgflagset")]
    public bool? IsACTSyncOrgFlagSet
    {
      get => this.GetAttributeValue<bool?>("isactsyncorgflagset");
      set
      {
        this.OnPropertyChanging(nameof (IsACTSyncOrgFlagSet));
        this.SetAttributeValue("isactsyncorgflagset", (object) value);
        this.OnPropertyChanged(nameof (IsACTSyncOrgFlagSet));
      }
    }

    [AttributeLogicalName("isemailaddressapprovedbyo365admin")]
    public bool? IsEmailAddressApprovedByO365Admin
    {
      get => this.GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin");
      set
      {
        this.OnPropertyChanging(nameof (IsEmailAddressApprovedByO365Admin));
        this.SetAttributeValue("isemailaddressapprovedbyo365admin", (object) value);
        this.OnPropertyChanged(nameof (IsEmailAddressApprovedByO365Admin));
      }
    }

    [AttributeLogicalName("isexchangecontactsimportscheduled")]
    public bool? IsExchangeContactsImportScheduled
    {
      get => this.GetAttributeValue<bool?>("isexchangecontactsimportscheduled");
    }

    [AttributeLogicalName("isforwardmailbox")]
    public bool? IsForwardMailbox => this.GetAttributeValue<bool?>("isforwardmailbox");

    [AttributeLogicalName("isoauthaccesstokenset")]
    public bool? IsOauthAccessTokenSet => this.GetAttributeValue<bool?>("isoauthaccesstokenset");

    [AttributeLogicalName("isoauthrefreshtokenset")]
    public bool? IsOauthRefreshTokenSet => this.GetAttributeValue<bool?>("isoauthrefreshtokenset");

    [AttributeLogicalName("ispasswordset")]
    public bool? IsPasswordSet => this.GetAttributeValue<bool?>("ispasswordset");

    [AttributeLogicalName("isserviceaccount")]
    public bool? IsServiceAccount => this.GetAttributeValue<bool?>("isserviceaccount");

    [AttributeLogicalName("itemsfailedforlastsync")]
    public int? ItemsFailedForLastSync
    {
      get => this.GetAttributeValue<int?>("itemsfailedforlastsync");
      set
      {
        this.OnPropertyChanging(nameof (ItemsFailedForLastSync));
        this.SetAttributeValue("itemsfailedforlastsync", (object) value);
        this.OnPropertyChanged(nameof (ItemsFailedForLastSync));
      }
    }

    [AttributeLogicalName("itemsprocessedforlastsync")]
    public int? ItemsProcessedForLastSync
    {
      get => this.GetAttributeValue<int?>("itemsprocessedforlastsync");
      set
      {
        this.OnPropertyChanging(nameof (ItemsProcessedForLastSync));
        this.SetAttributeValue("itemsprocessedforlastsync", (object) value);
        this.OnPropertyChanged(nameof (ItemsProcessedForLastSync));
      }
    }

    [AttributeLogicalName("lastautodiscoveredon")]
    public DateTime? LastAutoDiscoveredOn
    {
      get => this.GetAttributeValue<DateTime?>("lastautodiscoveredon");
      set
      {
        this.OnPropertyChanging(nameof (LastAutoDiscoveredOn));
        this.SetAttributeValue("lastautodiscoveredon", (object) value);
        this.OnPropertyChanged(nameof (LastAutoDiscoveredOn));
      }
    }

    [AttributeLogicalName("lastduration")]
    public int? LastDuration => this.GetAttributeValue<int?>("lastduration");

    [AttributeLogicalName("lastmailboxforcedunlockoccurredon")]
    public DateTime? LastMailboxForcedUnlockOccurredOn
    {
      get => this.GetAttributeValue<DateTime?>("lastmailboxforcedunlockoccurredon");
    }

    [AttributeLogicalName("lastsuccessfulsynccompletedon")]
    public DateTime? LastSuccessfulSyncCompletedOn
    {
      get => this.GetAttributeValue<DateTime?>("lastsuccessfulsynccompletedon");
      set
      {
        this.OnPropertyChanging(nameof (LastSuccessfulSyncCompletedOn));
        this.SetAttributeValue("lastsuccessfulsynccompletedon", (object) value);
        this.OnPropertyChanged(nameof (LastSuccessfulSyncCompletedOn));
      }
    }

    [AttributeLogicalName("lastsyncerror")]
    public string LastSyncError
    {
      get => this.GetAttributeValue<string>("lastsyncerror");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncError));
        this.SetAttributeValue("lastsyncerror", (object) value);
        this.OnPropertyChanged(nameof (LastSyncError));
      }
    }

    [AttributeLogicalName("lastsyncerrorcode")]
    public int? LastSyncErrorCode
    {
      get => this.GetAttributeValue<int?>("lastsyncerrorcode");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncErrorCode));
        this.SetAttributeValue("lastsyncerrorcode", (object) value);
        this.OnPropertyChanged(nameof (LastSyncErrorCode));
      }
    }

    [AttributeLogicalName("lastsyncerrorcount")]
    public int? LastSyncErrorCount
    {
      get => this.GetAttributeValue<int?>("lastsyncerrorcount");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncErrorCount));
        this.SetAttributeValue("lastsyncerrorcount", (object) value);
        this.OnPropertyChanged(nameof (LastSyncErrorCount));
      }
    }

    [AttributeLogicalName("lastsyncerrormachinename")]
    public string LastSyncErrorMachineName
    {
      get => this.GetAttributeValue<string>("lastsyncerrormachinename");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncErrorMachineName));
        this.SetAttributeValue("lastsyncerrormachinename", (object) value);
        this.OnPropertyChanged(nameof (LastSyncErrorMachineName));
      }
    }

    [AttributeLogicalName("lastsyncerroroccurredon")]
    public DateTime? LastSyncErrorOccurredOn
    {
      get => this.GetAttributeValue<DateTime?>("lastsyncerroroccurredon");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncErrorOccurredOn));
        this.SetAttributeValue("lastsyncerroroccurredon", (object) value);
        this.OnPropertyChanged(nameof (LastSyncErrorOccurredOn));
      }
    }

    [AttributeLogicalName("lastsyncstartedon")]
    public DateTime? LastSyncStartedOn => this.GetAttributeValue<DateTime?>("lastsyncstartedon");

    [AttributeLogicalName("mailboxid")]
    public Guid? MailboxId
    {
      get => this.GetAttributeValue<Guid?>("mailboxid");
      set
      {
        this.OnPropertyChanging(nameof (MailboxId));
        this.SetAttributeValue("mailboxid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (MailboxId));
      }
    }

    [AttributeLogicalName("mailboxid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.MailboxId = new Guid?(value);
    }

    [AttributeLogicalName("mailboxprocessingcontext")]
    public int? MailboxProcessingContext
    {
      get => this.GetAttributeValue<int?>("mailboxprocessingcontext");
      set
      {
        this.OnPropertyChanging(nameof (MailboxProcessingContext));
        this.SetAttributeValue("mailboxprocessingcontext", (object) value);
        this.OnPropertyChanged(nameof (MailboxProcessingContext));
      }
    }

    [AttributeLogicalName("mailboxstatus")]
    public OptionSetValue MailboxStatus => this.GetAttributeValue<OptionSetValue>("mailboxstatus");

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

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("noactcount")]
    public int? NoACTCount => this.GetAttributeValue<int?>("noactcount");

    [AttributeLogicalName("noemailcount")]
    public int? NoEmailCount => this.GetAttributeValue<int?>("noemailcount");

    [AttributeLogicalName("oauthaccesstoken")]
    public string OauthAccessToken
    {
      get => this.GetAttributeValue<string>("oauthaccesstoken");
      set
      {
        this.OnPropertyChanging(nameof (OauthAccessToken));
        this.SetAttributeValue("oauthaccesstoken", (object) value);
        this.OnPropertyChanged(nameof (OauthAccessToken));
      }
    }

    [AttributeLogicalName("oauthrefreshtoken")]
    public string OauthRefreshToken
    {
      get => this.GetAttributeValue<string>("oauthrefreshtoken");
      set
      {
        this.OnPropertyChanging(nameof (OauthRefreshToken));
        this.SetAttributeValue("oauthrefreshtoken", (object) value);
        this.OnPropertyChanged(nameof (OauthRefreshToken));
      }
    }

    [AttributeLogicalName("oauthtokenexpireson")]
    public DateTime? OauthTokenExpiresOn
    {
      get => this.GetAttributeValue<DateTime?>("oauthtokenexpireson");
      set
      {
        this.OnPropertyChanging(nameof (OauthTokenExpiresOn));
        this.SetAttributeValue("oauthtokenexpireson", (object) value);
        this.OnPropertyChanged(nameof (OauthTokenExpiresOn));
      }
    }

    [AttributeLogicalName("officeappsdeploymentcompleteon")]
    public DateTime? OfficeAppsDeploymentCompleteOn
    {
      get => this.GetAttributeValue<DateTime?>("officeappsdeploymentcompleteon");
    }

    [AttributeLogicalName("officeappsdeploymenterror")]
    public string OfficeAppsDeploymentError
    {
      get => this.GetAttributeValue<string>("officeappsdeploymenterror");
    }

    [AttributeLogicalName("officeappsdeploymentscheduled")]
    public bool? OfficeAppsDeploymentScheduled
    {
      get => this.GetAttributeValue<bool?>("officeappsdeploymentscheduled");
      set
      {
        this.OnPropertyChanging(nameof (OfficeAppsDeploymentScheduled));
        this.SetAttributeValue("officeappsdeploymentscheduled", (object) value);
        this.OnPropertyChanged(nameof (OfficeAppsDeploymentScheduled));
      }
    }

    [AttributeLogicalName("officeappsdeploymentstatus")]
    public OptionSetValue OfficeAppsDeploymentStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("officeappsdeploymentstatus");
      set
      {
        this.OnPropertyChanging(nameof (OfficeAppsDeploymentStatus));
        this.SetAttributeValue("officeappsdeploymentstatus", (object) value);
        this.OnPropertyChanged(nameof (OfficeAppsDeploymentStatus));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("orgmarkedasprimaryforexchangesync")]
    public bool? OrgMarkedAsPrimaryForExchangeSync
    {
      get => this.GetAttributeValue<bool?>("orgmarkedasprimaryforexchangesync");
      set
      {
        this.OnPropertyChanging(nameof (OrgMarkedAsPrimaryForExchangeSync));
        this.SetAttributeValue("orgmarkedasprimaryforexchangesync", (object) value);
        this.OnPropertyChanged(nameof (OrgMarkedAsPrimaryForExchangeSync));
      }
    }

    [AttributeLogicalName("outgoingemaildeliverymethod")]
    public OptionSetValue OutgoingEmailDeliveryMethod
    {
      get => this.GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingEmailDeliveryMethod));
        this.SetAttributeValue("outgoingemaildeliverymethod", (object) value);
        this.OnPropertyChanged(nameof (OutgoingEmailDeliveryMethod));
      }
    }

    [AttributeLogicalName("outgoingemailstatus")]
    public OptionSetValue OutgoingEmailStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("outgoingemailstatus");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingEmailStatus));
        this.SetAttributeValue("outgoingemailstatus", (object) value);
        this.OnPropertyChanged(nameof (OutgoingEmailStatus));
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

    [AttributeLogicalName("password")]
    public string Password
    {
      get => this.GetAttributeValue<string>("password");
      set
      {
        this.OnPropertyChanging(nameof (Password));
        this.SetAttributeValue("password", (object) value);
        this.OnPropertyChanged(nameof (Password));
      }
    }

    [AttributeLogicalName("postponemailboxprocessinguntil")]
    public DateTime? PostponeMailboxProcessingUntil
    {
      get => this.GetAttributeValue<DateTime?>("postponemailboxprocessinguntil");
      set
      {
        this.OnPropertyChanging(nameof (PostponeMailboxProcessingUntil));
        this.SetAttributeValue("postponemailboxprocessinguntil", (object) value);
        this.OnPropertyChanged(nameof (PostponeMailboxProcessingUntil));
      }
    }

    [AttributeLogicalName("postponeofficeappsdeploymentuntil")]
    public DateTime? PostponeOfficeAppsDeploymentUntil
    {
      get => this.GetAttributeValue<DateTime?>("postponeofficeappsdeploymentuntil");
      set
      {
        this.OnPropertyChanging(nameof (PostponeOfficeAppsDeploymentUntil));
        this.SetAttributeValue("postponeofficeappsdeploymentuntil", (object) value);
        this.OnPropertyChanged(nameof (PostponeOfficeAppsDeploymentUntil));
      }
    }

    [AttributeLogicalName("postponesendinguntil")]
    public DateTime? PostponeSendingUntil
    {
      get => this.GetAttributeValue<DateTime?>("postponesendinguntil");
      set
      {
        this.OnPropertyChanging(nameof (PostponeSendingUntil));
        this.SetAttributeValue("postponesendinguntil", (object) value);
        this.OnPropertyChanged(nameof (PostponeSendingUntil));
      }
    }

    [AttributeLogicalName("postponetestemailconfigurationuntil")]
    public DateTime? PostponeTestEmailConfigurationUntil
    {
      get => this.GetAttributeValue<DateTime?>("postponetestemailconfigurationuntil");
      set
      {
        this.OnPropertyChanging(nameof (PostponeTestEmailConfigurationUntil));
        this.SetAttributeValue("postponetestemailconfigurationuntil", (object) value);
        this.OnPropertyChanged(nameof (PostponeTestEmailConfigurationUntil));
      }
    }

    [AttributeLogicalName("processanddeleteemails")]
    public bool? ProcessAndDeleteEmails
    {
      get => this.GetAttributeValue<bool?>("processanddeleteemails");
      set
      {
        this.OnPropertyChanging(nameof (ProcessAndDeleteEmails));
        this.SetAttributeValue("processanddeleteemails", (object) value);
        this.OnPropertyChanged(nameof (ProcessAndDeleteEmails));
      }
    }

    [AttributeLogicalName("processedtimes")]
    public int? ProcessedTimes => this.GetAttributeValue<int?>("processedtimes");

    [AttributeLogicalName("processemailreceivedafter")]
    public DateTime? ProcessEmailReceivedAfter
    {
      get => this.GetAttributeValue<DateTime?>("processemailreceivedafter");
      set
      {
        this.OnPropertyChanging(nameof (ProcessEmailReceivedAfter));
        this.SetAttributeValue("processemailreceivedafter", (object) value);
        this.OnPropertyChanged(nameof (ProcessEmailReceivedAfter));
      }
    }

    [AttributeLogicalName("processinglastattemptedon")]
    public DateTime? ProcessingLastAttemptedOn
    {
      get => this.GetAttributeValue<DateTime?>("processinglastattemptedon");
    }

    [AttributeLogicalName("processingstatecode")]
    public int? Processingstatecode => this.GetAttributeValue<int?>("processingstatecode");

    [AttributeLogicalName("receivingpostponeduntil")]
    public DateTime? ReceivingPostponedUntil
    {
      get => this.GetAttributeValue<DateTime?>("receivingpostponeduntil");
    }

    [AttributeLogicalName("receivingpostponeduntilforact")]
    public DateTime? ReceivingPostponedUntilForACT
    {
      get => this.GetAttributeValue<DateTime?>("receivingpostponeduntilforact");
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
    }

    [AttributeLogicalName("statecode")]
    public MailboxState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new MailboxState?((MailboxState) Enum.ToObject(typeof (MailboxState), attributeValue.Value)) : new MailboxState?();
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

    [AttributeLogicalName("testemailconfigurationretrycount")]
    public int? TestEmailConfigurationRetryCount
    {
      get => this.GetAttributeValue<int?>("testemailconfigurationretrycount");
      set
      {
        this.OnPropertyChanging(nameof (TestEmailConfigurationRetryCount));
        this.SetAttributeValue("testemailconfigurationretrycount", (object) value);
        this.OnPropertyChanged(nameof (TestEmailConfigurationRetryCount));
      }
    }

    [AttributeLogicalName("testemailconfigurationscheduled")]
    public bool? TestEmailConfigurationScheduled
    {
      get => this.GetAttributeValue<bool?>("testemailconfigurationscheduled");
      set
      {
        this.OnPropertyChanging(nameof (TestEmailConfigurationScheduled));
        this.SetAttributeValue("testemailconfigurationscheduled", (object) value);
        this.OnPropertyChanged(nameof (TestEmailConfigurationScheduled));
      }
    }

    [AttributeLogicalName("testmailboxaccesscompletedon")]
    public DateTime? TestMailboxAccessCompletedOn
    {
      get => this.GetAttributeValue<DateTime?>("testmailboxaccesscompletedon");
      set
      {
        this.OnPropertyChanging(nameof (TestMailboxAccessCompletedOn));
        this.SetAttributeValue("testmailboxaccesscompletedon", (object) value);
        this.OnPropertyChanged(nameof (TestMailboxAccessCompletedOn));
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

    [AttributeLogicalName("transientfailurecount")]
    public int? TransientFailureCount => this.GetAttributeValue<int?>("transientfailurecount");

    [AttributeLogicalName("undeliverablefolder")]
    public string UndeliverableFolder
    {
      get => this.GetAttributeValue<string>("undeliverablefolder");
      set
      {
        this.OnPropertyChanging(nameof (UndeliverableFolder));
        this.SetAttributeValue("undeliverablefolder", (object) value);
        this.OnPropertyChanged(nameof (UndeliverableFolder));
      }
    }

    [AttributeLogicalName("username")]
    public string Username
    {
      get => this.GetAttributeValue<string>("username");
      set
      {
        this.OnPropertyChanging(nameof (Username));
        this.SetAttributeValue("username", (object) value);
        this.OnPropertyChanged(nameof (Username));
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

    [AttributeLogicalName("verboseloggingenabled")]
    public int? VerboseLoggingEnabled
    {
      get => this.GetAttributeValue<int?>("verboseloggingenabled");
      set
      {
        this.OnPropertyChanging(nameof (VerboseLoggingEnabled));
        this.SetAttributeValue("verboseloggingenabled", (object) value);
        this.OnPropertyChanged(nameof (VerboseLoggingEnabled));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("activitypointer_sendermailboxid_mailbox")]
    public IEnumerable<ActivityPointer> activitypointer_sendermailboxid_mailbox
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (activitypointer_sendermailboxid_mailbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (activitypointer_sendermailboxid_mailbox));
        this.SetRelatedEntities<ActivityPointer>(nameof (activitypointer_sendermailboxid_mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (activitypointer_sendermailboxid_mailbox));
      }
    }

    [RelationshipSchemaName("email_sendermailboxid_mailbox")]
    public IEnumerable<Email> email_sendermailboxid_mailbox
    {
      get
      {
        return this.GetRelatedEntities<Email>(nameof (email_sendermailboxid_mailbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (email_sendermailboxid_mailbox));
        this.SetRelatedEntities<Email>(nameof (email_sendermailboxid_mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_sendermailboxid_mailbox));
      }
    }

    [RelationshipSchemaName("Mailbox_Annotation")]
    public IEnumerable<Annotation> Mailbox_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (Mailbox_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Mailbox_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (Mailbox_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Mailbox_Annotation));
      }
    }

    [RelationshipSchemaName("mailbox_asyncoperations")]
    public IEnumerable<AsyncOperation> mailbox_asyncoperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (mailbox_asyncoperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mailbox_asyncoperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (mailbox_asyncoperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailbox_asyncoperations));
      }
    }

    [RelationshipSchemaName("mailbox_mailboxstatistics")]
    public IEnumerable<MailboxStatistics> mailbox_mailboxstatistics
    {
      get
      {
        return this.GetRelatedEntities<MailboxStatistics>(nameof (mailbox_mailboxstatistics), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mailbox_mailboxstatistics));
        this.SetRelatedEntities<MailboxStatistics>(nameof (mailbox_mailboxstatistics), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailbox_mailboxstatistics));
      }
    }

    [RelationshipSchemaName("Mailbox_mailboxtrackingcategory")]
    public IEnumerable<MailboxTrackingCategory> Mailbox_mailboxtrackingcategory
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingCategory>(nameof (Mailbox_mailboxtrackingcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Mailbox_mailboxtrackingcategory));
        this.SetRelatedEntities<MailboxTrackingCategory>(nameof (Mailbox_mailboxtrackingcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Mailbox_mailboxtrackingcategory));
      }
    }

    [RelationshipSchemaName("Mailbox_MailboxTrackingFolder")]
    public IEnumerable<MailboxTrackingFolder> Mailbox_MailboxTrackingFolder
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (Mailbox_MailboxTrackingFolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Mailbox_MailboxTrackingFolder));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (Mailbox_MailboxTrackingFolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Mailbox_MailboxTrackingFolder));
      }
    }

    [RelationshipSchemaName("mailbox_processsessions")]
    public IEnumerable<ProcessSession> mailbox_processsessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (mailbox_processsessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mailbox_processsessions));
        this.SetRelatedEntities<ProcessSession>(nameof (mailbox_processsessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailbox_processsessions));
      }
    }

    [RelationshipSchemaName("Mailbox_SyncErrors")]
    public IEnumerable<SyncError> Mailbox_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Mailbox_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Mailbox_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Mailbox_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Mailbox_SyncErrors));
      }
    }

    [RelationshipSchemaName("mailbox_userentityinstancedatas")]
    public IEnumerable<UserEntityInstanceData> mailbox_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (mailbox_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mailbox_userentityinstancedatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (mailbox_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailbox_userentityinstancedatas));
      }
    }

    [RelationshipSchemaName("queue_defaultmailbox_mailbox")]
    public IEnumerable<Queue> queue_defaultmailbox_mailbox
    {
      get
      {
        return this.GetRelatedEntities<Queue>(nameof (queue_defaultmailbox_mailbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queue_defaultmailbox_mailbox));
        this.SetRelatedEntities<Queue>(nameof (queue_defaultmailbox_mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_defaultmailbox_mailbox));
      }
    }

    [RelationshipSchemaName("systemuser_defaultmailbox_mailbox")]
    public IEnumerable<SystemUser> systemuser_defaultmailbox_mailbox
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (systemuser_defaultmailbox_mailbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuser_defaultmailbox_mailbox));
        this.SetRelatedEntities<SystemUser>(nameof (systemuser_defaultmailbox_mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_defaultmailbox_mailbox));
      }
    }

    [RelationshipSchemaName("tracelog_Mailbox")]
    public IEnumerable<TraceLog> tracelog_Mailbox
    {
      get => this.GetRelatedEntities<TraceLog>(nameof (tracelog_Mailbox), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (tracelog_Mailbox));
        this.SetRelatedEntities<TraceLog>(nameof (tracelog_Mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (tracelog_Mailbox));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_mailbox")]
    public BusinessUnit business_unit_mailbox
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_mailbox), new EntityRole?());
    }

    [AttributeLogicalName("emailserverprofile")]
    [RelationshipSchemaName("emailserverprofile_mailbox")]
    public ArcticIT.EarlyBound.Entities.EmailServerProfile emailserverprofile_mailbox
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.EmailServerProfile>(nameof (emailserverprofile_mailbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (emailserverprofile_mailbox));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.EmailServerProfile>(nameof (emailserverprofile_mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailserverprofile_mailbox));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_mailbox_createdby")]
    public SystemUser lk_mailbox_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_mailbox_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_mailbox_createdonbehalfby")]
    public SystemUser lk_mailbox_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailbox_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mailbox_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mailbox_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mailbox_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_mailbox_modifiedby")]
    public SystemUser lk_mailbox_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_mailbox_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_mailbox_modifiedonbehalfby")]
    public SystemUser lk_mailbox_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailbox_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mailbox_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mailbox_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mailbox_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mailbox_regarding_queue")]
    public Queue mailbox_regarding_queue
    {
      get => this.GetRelatedEntity<Queue>(nameof (mailbox_regarding_queue), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mailbox_regarding_systemuser")]
    public SystemUser mailbox_regarding_systemuser
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (mailbox_regarding_systemuser), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_mailbox")]
    public Organization organization_mailbox
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_mailbox), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_mailbox")]
    public Team team_mailbox
    {
      get => this.GetRelatedEntity<Team>(nameof (team_mailbox), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_mailbox")]
    public SystemUser user_mailbox
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_mailbox), new EntityRole?());
    }

    public Mailbox(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mailboxid"] = (object) base.Id;
            break;
          case "mailboxid":
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
