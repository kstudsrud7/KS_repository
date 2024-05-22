// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.EmailServerProfile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("emailserverprofile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class EmailServerProfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "emailserverprofile";
    public const string EntitySchemaName = "EmailServerProfile";
    public const string PrimaryIdAttribute = "emailserverprofileid";
    public const string PrimaryNameAttribute = "name";

    public EmailServerProfile()
      : base("emailserverprofile")
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

    [AttributeLogicalName("defaultserverlocation")]
    public string DefaultServerLocation
    {
      get => this.GetAttributeValue<string>("defaultserverlocation");
      set
      {
        this.OnPropertyChanging(nameof (DefaultServerLocation));
        this.SetAttributeValue("defaultserverlocation", (object) value);
        this.OnPropertyChanged(nameof (DefaultServerLocation));
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

    [AttributeLogicalName("emailserverprofileid")]
    public Guid? EmailServerProfileId
    {
      get => this.GetAttributeValue<Guid?>("emailserverprofileid");
      set
      {
        this.OnPropertyChanging(nameof (EmailServerProfileId));
        this.SetAttributeValue("emailserverprofileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (EmailServerProfileId));
      }
    }

    [AttributeLogicalName("emailserverprofileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.EmailServerProfileId = new Guid?(value);
    }

    [AttributeLogicalName("emailservertypename")]
    public string EmailServerTypeName => this.GetAttributeValue<string>("emailservertypename");

    [AttributeLogicalName("encodingcodepage")]
    public string EncodingCodePage
    {
      get => this.GetAttributeValue<string>("encodingcodepage");
      set
      {
        this.OnPropertyChanging(nameof (EncodingCodePage));
        this.SetAttributeValue("encodingcodepage", (object) value);
        this.OnPropertyChanged(nameof (EncodingCodePage));
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

    [AttributeLogicalName("exchangeonlinetenantid")]
    public string ExchangeOnlineTenantId
    {
      get => this.GetAttributeValue<string>("exchangeonlinetenantid");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeOnlineTenantId));
        this.SetAttributeValue("exchangeonlinetenantid", (object) value);
        this.OnPropertyChanged(nameof (ExchangeOnlineTenantId));
      }
    }

    [AttributeLogicalName("exchangeversion")]
    public OptionSetValue ExchangeVersion
    {
      get => this.GetAttributeValue<OptionSetValue>("exchangeversion");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeVersion));
        this.SetAttributeValue("exchangeversion", (object) value);
        this.OnPropertyChanged(nameof (ExchangeVersion));
      }
    }

    [AttributeLogicalName("incomingauthenticationprotocol")]
    public OptionSetValue IncomingAuthenticationProtocol
    {
      get => this.GetAttributeValue<OptionSetValue>("incomingauthenticationprotocol");
      set
      {
        this.OnPropertyChanging(nameof (IncomingAuthenticationProtocol));
        this.SetAttributeValue("incomingauthenticationprotocol", (object) value);
        this.OnPropertyChanged(nameof (IncomingAuthenticationProtocol));
      }
    }

    [AttributeLogicalName("incomingcredentialretrieval")]
    public OptionSetValue IncomingCredentialRetrieval
    {
      get => this.GetAttributeValue<OptionSetValue>("incomingcredentialretrieval");
      set
      {
        this.OnPropertyChanging(nameof (IncomingCredentialRetrieval));
        this.SetAttributeValue("incomingcredentialretrieval", (object) value);
        this.OnPropertyChanged(nameof (IncomingCredentialRetrieval));
      }
    }

    [AttributeLogicalName("incomingpartnerapplication")]
    public EntityReference IncomingPartnerApplication
    {
      get => this.GetAttributeValue<EntityReference>("incomingpartnerapplication");
    }

    [AttributeLogicalName("incomingpassword")]
    public string IncomingPassword
    {
      get => this.GetAttributeValue<string>("incomingpassword");
      set
      {
        this.OnPropertyChanging(nameof (IncomingPassword));
        this.SetAttributeValue("incomingpassword", (object) value);
        this.OnPropertyChanged(nameof (IncomingPassword));
      }
    }

    [AttributeLogicalName("incomingportnumber")]
    public int? IncomingPortNumber
    {
      get => this.GetAttributeValue<int?>("incomingportnumber");
      set
      {
        this.OnPropertyChanging(nameof (IncomingPortNumber));
        this.SetAttributeValue("incomingportnumber", (object) value);
        this.OnPropertyChanged(nameof (IncomingPortNumber));
      }
    }

    [AttributeLogicalName("incomingserverlocation")]
    public string IncomingServerLocation
    {
      get => this.GetAttributeValue<string>("incomingserverlocation");
      set
      {
        this.OnPropertyChanging(nameof (IncomingServerLocation));
        this.SetAttributeValue("incomingserverlocation", (object) value);
        this.OnPropertyChanged(nameof (IncomingServerLocation));
      }
    }

    [AttributeLogicalName("incominguseimpersonation")]
    public bool? IncomingUseImpersonation
    {
      get => this.GetAttributeValue<bool?>("incominguseimpersonation");
      set
      {
        this.OnPropertyChanging(nameof (IncomingUseImpersonation));
        this.SetAttributeValue("incominguseimpersonation", (object) value);
        this.OnPropertyChanged(nameof (IncomingUseImpersonation));
      }
    }

    [AttributeLogicalName("incomingusername")]
    public string IncomingUserName
    {
      get => this.GetAttributeValue<string>("incomingusername");
      set
      {
        this.OnPropertyChanging(nameof (IncomingUserName));
        this.SetAttributeValue("incomingusername", (object) value);
        this.OnPropertyChanged(nameof (IncomingUserName));
      }
    }

    [AttributeLogicalName("incomingusessl")]
    public bool? IncomingUseSSL
    {
      get => this.GetAttributeValue<bool?>("incomingusessl");
      set
      {
        this.OnPropertyChanging(nameof (IncomingUseSSL));
        this.SetAttributeValue("incomingusessl", (object) value);
        this.OnPropertyChanged(nameof (IncomingUseSSL));
      }
    }

    [AttributeLogicalName("isincomingpasswordset")]
    public bool? IsIncomingPasswordSet => this.GetAttributeValue<bool?>("isincomingpasswordset");

    [AttributeLogicalName("isoauthclientsecretset")]
    public bool? IsOauthClientSecretSet => this.GetAttributeValue<bool?>("isoauthclientsecretset");

    [AttributeLogicalName("isoutgoingpasswordset")]
    public bool? IsOutgoingPasswordSet => this.GetAttributeValue<bool?>("isoutgoingpasswordset");

    [AttributeLogicalName("lastauthorizationstatus")]
    public OptionSetValue LastAuthorizationStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("lastauthorizationstatus");
      set
      {
        this.OnPropertyChanging(nameof (LastAuthorizationStatus));
        this.SetAttributeValue("lastauthorizationstatus", (object) value);
        this.OnPropertyChanged(nameof (LastAuthorizationStatus));
      }
    }

    [AttributeLogicalName("lastcrmmessage")]
    public string LastCrmMessage
    {
      get => this.GetAttributeValue<string>("lastcrmmessage");
      set
      {
        this.OnPropertyChanging(nameof (LastCrmMessage));
        this.SetAttributeValue("lastcrmmessage", (object) value);
        this.OnPropertyChanged(nameof (LastCrmMessage));
      }
    }

    [AttributeLogicalName("lasttestexecutionstatus")]
    public OptionSetValue LastTestExecutionStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("lasttestexecutionstatus");
      set
      {
        this.OnPropertyChanging(nameof (LastTestExecutionStatus));
        this.SetAttributeValue("lasttestexecutionstatus", (object) value);
        this.OnPropertyChanged(nameof (LastTestExecutionStatus));
      }
    }

    [AttributeLogicalName("lasttestrequest")]
    public string LastTestRequest
    {
      get => this.GetAttributeValue<string>("lasttestrequest");
      set
      {
        this.OnPropertyChanging(nameof (LastTestRequest));
        this.SetAttributeValue("lasttestrequest", (object) value);
        this.OnPropertyChanged(nameof (LastTestRequest));
      }
    }

    [AttributeLogicalName("lasttestresponse")]
    public string LastTestResponse
    {
      get => this.GetAttributeValue<string>("lasttestresponse");
      set
      {
        this.OnPropertyChanging(nameof (LastTestResponse));
        this.SetAttributeValue("lasttestresponse", (object) value);
        this.OnPropertyChanged(nameof (LastTestResponse));
      }
    }

    [AttributeLogicalName("lastteststarttime")]
    public DateTime? LastTestStartTime
    {
      get => this.GetAttributeValue<DateTime?>("lastteststarttime");
      set
      {
        this.OnPropertyChanging(nameof (LastTestStartTime));
        this.SetAttributeValue("lastteststarttime", (object) value);
        this.OnPropertyChanged(nameof (LastTestStartTime));
      }
    }

    [AttributeLogicalName("lasttesttotalexecutiontime")]
    public long? LastTestTotalExecutionTime
    {
      get => this.GetAttributeValue<long?>("lasttesttotalexecutiontime");
      set
      {
        this.OnPropertyChanging(nameof (LastTestTotalExecutionTime));
        this.SetAttributeValue("lasttesttotalexecutiontime", (object) value);
        this.OnPropertyChanged(nameof (LastTestTotalExecutionTime));
      }
    }

    [AttributeLogicalName("lasttestvalidationstatus")]
    public OptionSetValue LastTestValidationStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("lasttestvalidationstatus");
      set
      {
        this.OnPropertyChanging(nameof (LastTestValidationStatus));
        this.SetAttributeValue("lasttestvalidationstatus", (object) value);
        this.OnPropertyChanged(nameof (LastTestValidationStatus));
      }
    }

    [AttributeLogicalName("maxconcurrentconnections")]
    public int? MaxConcurrentConnections
    {
      get => this.GetAttributeValue<int?>("maxconcurrentconnections");
      set
      {
        this.OnPropertyChanging(nameof (MaxConcurrentConnections));
        this.SetAttributeValue("maxconcurrentconnections", (object) value);
        this.OnPropertyChanged(nameof (MaxConcurrentConnections));
      }
    }

    [AttributeLogicalName("minpollingintervalinminutes")]
    public int? MinPollingIntervalInMinutes
    {
      get => this.GetAttributeValue<int?>("minpollingintervalinminutes");
      set
      {
        this.OnPropertyChanging(nameof (MinPollingIntervalInMinutes));
        this.SetAttributeValue("minpollingintervalinminutes", (object) value);
        this.OnPropertyChanged(nameof (MinPollingIntervalInMinutes));
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

    [AttributeLogicalName("moveundeliveredemails")]
    public bool? MoveUndeliveredEmails
    {
      get => this.GetAttributeValue<bool?>("moveundeliveredemails");
      set
      {
        this.OnPropertyChanging(nameof (MoveUndeliveredEmails));
        this.SetAttributeValue("moveundeliveredemails", (object) value);
        this.OnPropertyChanged(nameof (MoveUndeliveredEmails));
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

    [AttributeLogicalName("oauthclientid")]
    public string OauthClientId
    {
      get => this.GetAttributeValue<string>("oauthclientid");
      set
      {
        this.OnPropertyChanging(nameof (OauthClientId));
        this.SetAttributeValue("oauthclientid", (object) value);
        this.OnPropertyChanged(nameof (OauthClientId));
      }
    }

    [AttributeLogicalName("oauthclientsecret")]
    public string OauthClientSecret
    {
      get => this.GetAttributeValue<string>("oauthclientsecret");
      set
      {
        this.OnPropertyChanging(nameof (OauthClientSecret));
        this.SetAttributeValue("oauthclientsecret", (object) value);
        this.OnPropertyChanged(nameof (OauthClientSecret));
      }
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("outgoingauthenticationprotocol")]
    public OptionSetValue OutgoingAuthenticationProtocol
    {
      get => this.GetAttributeValue<OptionSetValue>("outgoingauthenticationprotocol");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingAuthenticationProtocol));
        this.SetAttributeValue("outgoingauthenticationprotocol", (object) value);
        this.OnPropertyChanged(nameof (OutgoingAuthenticationProtocol));
      }
    }

    [AttributeLogicalName("outgoingautograntdelegateaccess")]
    public bool? OutgoingAutoGrantDelegateAccess
    {
      get => this.GetAttributeValue<bool?>("outgoingautograntdelegateaccess");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingAutoGrantDelegateAccess));
        this.SetAttributeValue("outgoingautograntdelegateaccess", (object) value);
        this.OnPropertyChanged(nameof (OutgoingAutoGrantDelegateAccess));
      }
    }

    [AttributeLogicalName("outgoingcredentialretrieval")]
    public OptionSetValue OutgoingCredentialRetrieval
    {
      get => this.GetAttributeValue<OptionSetValue>("outgoingcredentialretrieval");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingCredentialRetrieval));
        this.SetAttributeValue("outgoingcredentialretrieval", (object) value);
        this.OnPropertyChanged(nameof (OutgoingCredentialRetrieval));
      }
    }

    [AttributeLogicalName("outgoingpartnerapplication")]
    public EntityReference OutgoingPartnerApplication
    {
      get => this.GetAttributeValue<EntityReference>("outgoingpartnerapplication");
    }

    [AttributeLogicalName("outgoingpassword")]
    public string OutgoingPassword
    {
      get => this.GetAttributeValue<string>("outgoingpassword");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingPassword));
        this.SetAttributeValue("outgoingpassword", (object) value);
        this.OnPropertyChanged(nameof (OutgoingPassword));
      }
    }

    [AttributeLogicalName("outgoingportnumber")]
    public int? OutgoingPortNumber
    {
      get => this.GetAttributeValue<int?>("outgoingportnumber");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingPortNumber));
        this.SetAttributeValue("outgoingportnumber", (object) value);
        this.OnPropertyChanged(nameof (OutgoingPortNumber));
      }
    }

    [AttributeLogicalName("outgoingserverlocation")]
    public string OutgoingServerLocation
    {
      get => this.GetAttributeValue<string>("outgoingserverlocation");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingServerLocation));
        this.SetAttributeValue("outgoingserverlocation", (object) value);
        this.OnPropertyChanged(nameof (OutgoingServerLocation));
      }
    }

    [AttributeLogicalName("outgoinguseimpersonation")]
    public bool? OutgoingUseImpersonation
    {
      get => this.GetAttributeValue<bool?>("outgoinguseimpersonation");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingUseImpersonation));
        this.SetAttributeValue("outgoinguseimpersonation", (object) value);
        this.OnPropertyChanged(nameof (OutgoingUseImpersonation));
      }
    }

    [AttributeLogicalName("outgoingusername")]
    public string OutgoingUsername
    {
      get => this.GetAttributeValue<string>("outgoingusername");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingUsername));
        this.SetAttributeValue("outgoingusername", (object) value);
        this.OnPropertyChanged(nameof (OutgoingUsername));
      }
    }

    [AttributeLogicalName("outgoingusessl")]
    public bool? OutgoingUseSSL
    {
      get => this.GetAttributeValue<bool?>("outgoingusessl");
      set
      {
        this.OnPropertyChanging(nameof (OutgoingUseSSL));
        this.SetAttributeValue("outgoingusessl", (object) value);
        this.OnPropertyChanged(nameof (OutgoingUseSSL));
      }
    }

    [AttributeLogicalName("owneremailaddress")]
    public string OwnerEmailAddress
    {
      get => this.GetAttributeValue<string>("owneremailaddress");
      set
      {
        this.OnPropertyChanging(nameof (OwnerEmailAddress));
        this.SetAttributeValue("owneremailaddress", (object) value);
        this.OnPropertyChanged(nameof (OwnerEmailAddress));
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

    [AttributeLogicalName("processemailsreceivedafter")]
    public DateTime? ProcessEmailsReceivedAfter
    {
      get => this.GetAttributeValue<DateTime?>("processemailsreceivedafter");
      set
      {
        this.OnPropertyChanging(nameof (ProcessEmailsReceivedAfter));
        this.SetAttributeValue("processemailsreceivedafter", (object) value);
        this.OnPropertyChanged(nameof (ProcessEmailsReceivedAfter));
      }
    }

    [AttributeLogicalName("sendemailalert")]
    public bool? SendEmailAlert
    {
      get => this.GetAttributeValue<bool?>("sendemailalert");
      set
      {
        this.OnPropertyChanging(nameof (SendEmailAlert));
        this.SetAttributeValue("sendemailalert", (object) value);
        this.OnPropertyChanged(nameof (SendEmailAlert));
      }
    }

    [AttributeLogicalName("servertype")]
    public OptionSetValue ServerType
    {
      get => this.GetAttributeValue<OptionSetValue>("servertype");
      set
      {
        this.OnPropertyChanging(nameof (ServerType));
        this.SetAttributeValue("servertype", (object) value);
        this.OnPropertyChanged(nameof (ServerType));
      }
    }

    [AttributeLogicalName("statecode")]
    public EmailServerProfileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new EmailServerProfileState?((EmailServerProfileState) Enum.ToObject(typeof (EmailServerProfileState), attributeValue.Value)) : new EmailServerProfileState?();
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

    [AttributeLogicalName("timeoutmailboxconnection")]
    public bool? TimeoutMailboxConnection
    {
      get => this.GetAttributeValue<bool?>("timeoutmailboxconnection");
      set
      {
        this.OnPropertyChanging(nameof (TimeoutMailboxConnection));
        this.SetAttributeValue("timeoutmailboxconnection", (object) value);
        this.OnPropertyChanged(nameof (TimeoutMailboxConnection));
      }
    }

    [AttributeLogicalName("timeoutmailboxconnectionafteramount")]
    public int? TimeoutMailboxConnectionAfterAmount
    {
      get => this.GetAttributeValue<int?>("timeoutmailboxconnectionafteramount");
      set
      {
        this.OnPropertyChanging(nameof (TimeoutMailboxConnectionAfterAmount));
        this.SetAttributeValue("timeoutmailboxconnectionafteramount", (object) value);
        this.OnPropertyChanged(nameof (TimeoutMailboxConnectionAfterAmount));
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

    [AttributeLogicalName("useautodiscover")]
    public bool? UseAutoDiscover
    {
      get => this.GetAttributeValue<bool?>("useautodiscover");
      set
      {
        this.OnPropertyChanging(nameof (UseAutoDiscover));
        this.SetAttributeValue("useautodiscover", (object) value);
        this.OnPropertyChanged(nameof (UseAutoDiscover));
      }
    }

    [AttributeLogicalName("usedefaulttenantid")]
    public bool? UseDefaultTenantId
    {
      get => this.GetAttributeValue<bool?>("usedefaulttenantid");
      set
      {
        this.OnPropertyChanging(nameof (UseDefaultTenantId));
        this.SetAttributeValue("usedefaulttenantid", (object) value);
        this.OnPropertyChanged(nameof (UseDefaultTenantId));
      }
    }

    [AttributeLogicalName("usesamesettingsforoutgoingconnections")]
    public bool? UseSameSettingsForOutgoingConnections
    {
      get => this.GetAttributeValue<bool?>("usesamesettingsforoutgoingconnections");
      set
      {
        this.OnPropertyChanging(nameof (UseSameSettingsForOutgoingConnections));
        this.SetAttributeValue("usesamesettingsforoutgoingconnections", (object) value);
        this.OnPropertyChanged(nameof (UseSameSettingsForOutgoingConnections));
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

    [RelationshipSchemaName("EmailServerProfile_Annotation")]
    public IEnumerable<Annotation> EmailServerProfile_Annotation
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (EmailServerProfile_Annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (EmailServerProfile_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (EmailServerProfile_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (EmailServerProfile_Annotation));
      }
    }

    [RelationshipSchemaName("emailserverprofile_asyncoperations")]
    public IEnumerable<AsyncOperation> emailserverprofile_asyncoperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (emailserverprofile_asyncoperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (emailserverprofile_asyncoperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (emailserverprofile_asyncoperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailserverprofile_asyncoperations));
      }
    }

    [RelationshipSchemaName("emailserverprofile_bulkdeletefailures")]
    public IEnumerable<BulkDeleteFailure> emailserverprofile_bulkdeletefailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (emailserverprofile_bulkdeletefailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (emailserverprofile_bulkdeletefailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (emailserverprofile_bulkdeletefailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailserverprofile_bulkdeletefailures));
      }
    }

    [RelationshipSchemaName("emailserverprofile_duplicatebaserecord")]
    public IEnumerable<DuplicateRecord> emailserverprofile_duplicatebaserecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (emailserverprofile_duplicatebaserecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (emailserverprofile_duplicatebaserecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (emailserverprofile_duplicatebaserecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailserverprofile_duplicatebaserecord));
      }
    }

    [RelationshipSchemaName("emailserverprofile_duplicatematchingrecord")]
    public IEnumerable<DuplicateRecord> emailserverprofile_duplicatematchingrecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (emailserverprofile_duplicatematchingrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (emailserverprofile_duplicatematchingrecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (emailserverprofile_duplicatematchingrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailserverprofile_duplicatematchingrecord));
      }
    }

    [RelationshipSchemaName("emailserverprofile_mailbox")]
    public IEnumerable<Mailbox> emailserverprofile_mailbox
    {
      get
      {
        return this.GetRelatedEntities<Mailbox>(nameof (emailserverprofile_mailbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (emailserverprofile_mailbox));
        this.SetRelatedEntities<Mailbox>(nameof (emailserverprofile_mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (emailserverprofile_mailbox));
      }
    }

    [RelationshipSchemaName("EmailServerProfile_Organization")]
    public IEnumerable<Organization> EmailServerProfile_Organization
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (EmailServerProfile_Organization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (EmailServerProfile_Organization));
        this.SetRelatedEntities<Organization>(nameof (EmailServerProfile_Organization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (EmailServerProfile_Organization));
      }
    }

    [RelationshipSchemaName("EmailServerProfile_SyncErrors")]
    public IEnumerable<SyncError> EmailServerProfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (EmailServerProfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (EmailServerProfile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (EmailServerProfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (EmailServerProfile_SyncErrors));
      }
    }

    [RelationshipSchemaName("tracelog_EmailServerProfile")]
    public IEnumerable<TraceLog> tracelog_EmailServerProfile
    {
      get
      {
        return this.GetRelatedEntities<TraceLog>(nameof (tracelog_EmailServerProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (tracelog_EmailServerProfile));
        this.SetRelatedEntities<TraceLog>(nameof (tracelog_EmailServerProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (tracelog_EmailServerProfile));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_emailserverprofile")]
    public BusinessUnit business_unit_emailserverprofile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_emailserverprofile), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_emailserverprofile_createdby")]
    public SystemUser lk_emailserverprofile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_emailserverprofile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_emailserverprofile_createdonbehalfby")]
    public SystemUser lk_emailserverprofile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_emailserverprofile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_emailserverprofile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_emailserverprofile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_emailserverprofile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_emailserverprofile_modifiedby")]
    public SystemUser lk_emailserverprofile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_emailserverprofile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_emailserverprofile_modifiedonbehalfby")]
    public SystemUser lk_emailserverprofile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_emailserverprofile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_emailserverprofile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_emailserverprofile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_emailserverprofile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_emailserverprofile")]
    public Organization organization_emailserverprofile
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_emailserverprofile), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_emailserverprofile")]
    public Team team_emailserverprofile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_emailserverprofile), new EntityRole?());
    }

    public EmailServerProfile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["emailserverprofileid"] = (object) base.Id;
            break;
          case "emailserverprofileid":
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
