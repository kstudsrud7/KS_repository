// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.SyncError
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("syncerror")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class SyncError : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "syncerror";
    public const string EntitySchemaName = "SyncError";
    public const string PrimaryIdAttribute = "syncerrorid";
    public const string PrimaryNameAttribute = "name";

    public SyncError()
      : base("syncerror")
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

    [AttributeLogicalName("action")]
    public string Action
    {
      get => this.GetAttributeValue<string>("action");
      set
      {
        this.OnPropertyChanging(nameof (Action));
        this.SetAttributeValue("action", (object) value);
        this.OnPropertyChanged(nameof (Action));
      }
    }

    [AttributeLogicalName("actiondata")]
    public string ActionData
    {
      get => this.GetAttributeValue<string>("actiondata");
      set
      {
        this.OnPropertyChanging(nameof (ActionData));
        this.SetAttributeValue("actiondata", (object) value);
        this.OnPropertyChanged(nameof (ActionData));
      }
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

    [AttributeLogicalName("errorcode")]
    public string ErrorCode
    {
      get => this.GetAttributeValue<string>("errorcode");
      set
      {
        this.OnPropertyChanging(nameof (ErrorCode));
        this.SetAttributeValue("errorcode", (object) value);
        this.OnPropertyChanged(nameof (ErrorCode));
      }
    }

    [AttributeLogicalName("errordetail")]
    public string ErrorDetail
    {
      get => this.GetAttributeValue<string>("errordetail");
      set
      {
        this.OnPropertyChanging(nameof (ErrorDetail));
        this.SetAttributeValue("errordetail", (object) value);
        this.OnPropertyChanged(nameof (ErrorDetail));
      }
    }

    [AttributeLogicalName("errormessage")]
    public string ErrorMessage
    {
      get => this.GetAttributeValue<string>("errormessage");
      set
      {
        this.OnPropertyChanging(nameof (ErrorMessage));
        this.SetAttributeValue("errormessage", (object) value);
        this.OnPropertyChanged(nameof (ErrorMessage));
      }
    }

    [AttributeLogicalName("errortime")]
    public DateTime? ErrorTime
    {
      get => this.GetAttributeValue<DateTime?>("errortime");
      set
      {
        this.OnPropertyChanging(nameof (ErrorTime));
        this.SetAttributeValue("errortime", (object) value);
        this.OnPropertyChanged(nameof (ErrorTime));
      }
    }

    [AttributeLogicalName("errortype")]
    public OptionSetValue ErrorType
    {
      get => this.GetAttributeValue<OptionSetValue>("errortype");
      set
      {
        this.OnPropertyChanging(nameof (ErrorType));
        this.SetAttributeValue("errortype", (object) value);
        this.OnPropertyChanged(nameof (ErrorType));
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

    [AttributeLogicalName("requestdata")]
    public string RequestData
    {
      get => this.GetAttributeValue<string>("requestdata");
      set
      {
        this.OnPropertyChanging(nameof (RequestData));
        this.SetAttributeValue("requestdata", (object) value);
        this.OnPropertyChanged(nameof (RequestData));
      }
    }

    [AttributeLogicalName("statecode")]
    public SyncErrorState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new SyncErrorState?((SyncErrorState) Enum.ToObject(typeof (SyncErrorState), attributeValue.Value)) : new SyncErrorState?();
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

    [AttributeLogicalName("syncerrorid")]
    public Guid? SyncErrorId
    {
      get => this.GetAttributeValue<Guid?>("syncerrorid");
      set
      {
        this.OnPropertyChanging(nameof (SyncErrorId));
        this.SetAttributeValue("syncerrorid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (SyncErrorId));
      }
    }

    [AttributeLogicalName("syncerrorid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.SyncErrorId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName]
    public IEnumerable<SyncError> ReferencedSyncError_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>("SyncError_SyncErrors", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (ReferencedSyncError_SyncErrors));
        this.SetRelatedEntities<SyncError>("SyncError_SyncErrors", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (ReferencedSyncError_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_SyncErrors")]
    public Account Account_SyncErrors
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Account_SyncErrors));
        this.SetRelatedEntity<Account>(nameof (Account_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ActivityMimeAttachment_SyncErrors")]
    public ActivityMimeAttachment ActivityMimeAttachment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ActivityMimeAttachment>(nameof (ActivityMimeAttachment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityMimeAttachment_SyncErrors));
        this.SetRelatedEntity<ActivityMimeAttachment>(nameof (ActivityMimeAttachment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityMimeAttachment_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ActivityParty_SyncErrors")]
    public ActivityParty ActivityParty_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ActivityParty>(nameof (ActivityParty_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActivityParty_SyncErrors));
        this.SetRelatedEntity<ActivityParty>(nameof (ActivityParty_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActivityParty_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_accountingcode_SyncErrors")]
    public ait_accountingcode ait_accountingcode_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_SyncErrors));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_addresstype_SyncErrors")]
    public ait_addresstype ait_addresstype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_addresstype_SyncErrors));
        this.SetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_addresstype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_SyncErrors")]
    public ait_assessment ait_assessment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_SyncErrors));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_autonumber_SyncErrors")]
    public ait_autonumber ait_autonumber_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_SyncErrors));
        this.SetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_band_SyncErrors")]
    public ait_band ait_band_SyncErrors
    {
      get => this.GetRelatedEntity<ait_band>(nameof (ait_band_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_band_SyncErrors));
        this.SetRelatedEntity<ait_band>(nameof (ait_band_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_band_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccount_SyncErrors")]
    public ait_bankaccount ait_bankaccount_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_SyncErrors));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccounttype_SyncErrors")]
    public ait_bankaccounttype ait_bankaccounttype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccounttype_SyncErrors));
        this.SetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccounttype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_birthrecord_SyncErrors")]
    public ait_birthrecord ait_birthrecord_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_SyncErrors));
        this.SetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bloodquantum_SyncErrors")]
    public ait_bloodquantum ait_bloodquantum_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_SyncErrors));
        this.SetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformat_SyncErrors")]
    public ait_cardformat ait_cardformat_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_SyncErrors));
        this.SetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformatdetail_SyncErrors")]
    public ait_cardformatdetail ait_cardformatdetail_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_SyncErrors));
        this.SetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardhistory_SyncErrors")]
    public ait_cardhistory ait_cardhistory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_SyncErrors));
        this.SetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_SyncErrors")]
    public ait_case ait_case_SyncErrors
    {
      get => this.GetRelatedEntity<ait_case>(nameof (ait_case_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_case_SyncErrors));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_SyncErrors")]
    public ait_casenote ait_casenote_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_SyncErrors));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_SyncErrors")]
    public ait_caseplan ait_caseplan_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_SyncErrors));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_causeofdeath_SyncErrors")]
    public ait_causeofdeath ait_causeofdeath_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_causeofdeath_SyncErrors));
        this.SetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_causeofdeath_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cemetary_SyncErrors")]
    public ait_cemetary ait_cemetary_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_SyncErrors));
        this.SetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_certification_SyncErrors")]
    public ait_certification ait_certification_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_certification_SyncErrors));
        this.SetRelatedEntity<ait_certification>(nameof (ait_certification_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_certification_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_SyncErrors")]
    public ait_changerequest ait_changerequest_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_SyncErrors));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequesttype_SyncErrors")]
    public ait_changerequesttype ait_changerequesttype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_SyncErrors));
        this.SetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_charge_SyncErrors")]
    public ait_charge ait_charge_SyncErrors
    {
      get => this.GetRelatedEntity<ait_charge>(nameof (ait_charge_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_SyncErrors));
        this.SetRelatedEntity<ait_charge>(nameof (ait_charge_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_childvisitations_SyncErrors")]
    public ait_childvisitations ait_childvisitations_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_SyncErrors));
        this.SetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_city_SyncErrors")]
    public ait_city ait_city_SyncErrors
    {
      get => this.GetRelatedEntity<ait_city>(nameof (ait_city_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_city_SyncErrors));
        this.SetRelatedEntity<ait_city>(nameof (ait_city_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clan_SyncErrors")]
    public ait_clan ait_clan_SyncErrors
    {
      get => this.GetRelatedEntity<ait_clan>(nameof (ait_clan_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_clan_SyncErrors));
        this.SetRelatedEntity<ait_clan>(nameof (ait_clan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clan_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_SyncErrors")]
    public ait_clientprofile ait_clientprofile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_SyncErrors));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committee_SyncErrors")]
    public ait_committee ait_committee_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_SyncErrors));
        this.SetRelatedEntity<ait_committee>(nameof (ait_committee_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemeeting_SyncErrors")]
    public ait_committeemeeting ait_committeemeeting_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemeeting_SyncErrors));
        this.SetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemeeting_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemember_SyncErrors")]
    public ait_committeemember ait_committeemember_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_SyncErrors));
        this.SetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeeposition_SyncErrors")]
    public ait_committeeposition ait_committeeposition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeeposition_SyncErrors));
        this.SetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeeposition_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeepositiontype_SyncErrors")]
    public ait_committeepositiontype ait_committeepositiontype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeepositiontype_SyncErrors));
        this.SetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeepositiontype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_company_SyncErrors")]
    public ait_company ait_company_SyncErrors
    {
      get => this.GetRelatedEntity<ait_company>(nameof (ait_company_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_company_SyncErrors));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactcertification_SyncErrors")]
    public ait_contactcertification ait_contactcertification_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_SyncErrors));
        this.SetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contacteducation_SyncErrors")]
    public ait_contacteducation ait_contacteducation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_SyncErrors));
        this.SetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactemployment_SyncErrors")]
    public ait_contactemployment ait_contactemployment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_SyncErrors));
        this.SetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactimage_SyncErrors")]
    public ait_contactimage ait_contactimage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactimage_SyncErrors));
        this.SetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactimage_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincarceration_SyncErrors")]
    public ait_contactincarceration ait_contactincarceration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_SyncErrors));
        this.SetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_SyncErrors")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_SyncErrors));
        this.SetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactlanguage_SyncErrors")]
    public ait_contactlanguage ait_contactlanguage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_SyncErrors));
        this.SetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_SyncErrors")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_SyncErrors));
        this.SetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactname_SyncErrors")]
    public ait_contactname ait_contactname_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_SyncErrors));
        this.SetRelatedEntity<ait_contactname>(nameof (ait_contactname_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactskill_SyncErrors")]
    public ait_contactskill ait_contactskill_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactskill_SyncErrors));
        this.SetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactskill_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_countryregion_SyncErrors")]
    public ait_countryregion ait_countryregion_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_SyncErrors));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_county_SyncErrors")]
    public ait_county ait_county_SyncErrors
    {
      get => this.GetRelatedEntity<ait_county>(nameof (ait_county_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_county_SyncErrors));
        this.SetRelatedEntity<ait_county>(nameof (ait_county_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_county_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_SyncErrors")]
    public ait_courtcase ait_courtcase_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_SyncErrors));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtfinesandfees_SyncErrors")]
    public ait_courtfinesandfees ait_courtfinesandfees_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_SyncErrors));
        this.SetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtparty_SyncErrors")]
    public ait_courtparty ait_courtparty_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_SyncErrors));
        this.SetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtpayments_SyncErrors")]
    public ait_courtpayments ait_courtpayments_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_SyncErrors));
        this.SetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofile_SyncErrors")]
    public ait_courtprofile ait_courtprofile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_SyncErrors));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofileaddress_SyncErrors")]
    public ait_courtprofileaddress ait_courtprofileaddress_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_SyncErrors));
        this.SetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtroom_SyncErrors")]
    public ait_courtroom ait_courtroom_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtroom_SyncErrors));
        this.SetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtroom_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_datamigrationhistory_SyncErrors")]
    public ait_datamigrationhistory ait_datamigrationhistory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_SyncErrors));
        this.SetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_deathrecord_SyncErrors")]
    public ait_deathrecord ait_deathrecord_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_SyncErrors));
        this.SetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_degree_SyncErrors")]
    public ait_degree ait_degree_SyncErrors
    {
      get => this.GetRelatedEntity<ait_degree>(nameof (ait_degree_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_degree_SyncErrors));
        this.SetRelatedEntity<ait_degree>(nameof (ait_degree_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_degree_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_electronicaddress_SyncErrors")]
    public ait_electronicaddress ait_electronicaddress_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_SyncErrors));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_emergencycontact_SyncErrors")]
    public ait_emergencycontact ait_emergencycontact_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_SyncErrors));
        this.SetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_SyncErrors")]
    public ait_familygroup ait_familygroup_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_SyncErrors));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_SyncErrors")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_SyncErrors));
        this.SetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_geographicalarea_SyncErrors")]
    public ait_geographicalarea ait_geographicalarea_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_SyncErrors));
        this.SetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_SyncErrors")]
    public ait_goal ait_goal_SyncErrors
    {
      get => this.GetRelatedEntity<ait_goal>(nameof (ait_goal_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_SyncErrors));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivity_SyncErrors")]
    public ait_groupactivity ait_groupactivity_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_SyncErrors));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_SyncErrors")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_SyncErrors));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_household_SyncErrors")]
    public ait_household ait_household_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_SyncErrors));
        this.SetRelatedEntity<ait_household>(nameof (ait_household_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_householdmember_SyncErrors")]
    public ait_householdmember ait_householdmember_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_SyncErrors));
        this.SetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_SyncErrors")]
    public ait_icwaadoption ait_icwaadoption_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_SyncErrors));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_SyncErrors")]
    public ait_icwanotice ait_icwanotice_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_SyncErrors));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregion_SyncErrors")]
    public ait_icwaregion ait_icwaregion_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_SyncErrors));
        this.SetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregionnotification_SyncErrors")]
    public ait_icwaregionnotification ait_icwaregionnotification_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_SyncErrors));
        this.SetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_SyncErrors")]
    public ait_incident ait_incident_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_SyncErrors));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incidenttype_SyncErrors")]
    public ait_incidenttype ait_incidenttype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype_SyncErrors));
        this.SetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidenttype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_SyncErrors")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_SyncErrors));
        this.SetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_SyncErrors")]
    public ait_investigation ait_investigation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_SyncErrors));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_language_SyncErrors")]
    public ait_language ait_language_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_language_SyncErrors));
        this.SetRelatedEntity<ait_language>(nameof (ait_language_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_language_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_languageproficiencylevel_SyncErrors")]
    public ait_languageproficiencylevel ait_languageproficiencylevel_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_SyncErrors));
        this.SetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loan_SyncErrors")]
    public ait_loan ait_loan_SyncErrors
    {
      get => this.GetRelatedEntity<ait_loan>(nameof (ait_loan_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_SyncErrors));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loandetail_SyncErrors")]
    public ait_loandetail ait_loandetail_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_SyncErrors));
        this.SetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loantype_SyncErrors")]
    public ait_loantype ait_loantype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loantype_SyncErrors));
        this.SetRelatedEntity<ait_loantype>(nameof (ait_loantype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loantype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_medicalproviders_SyncErrors")]
    public ait_medicalproviders ait_medicalproviders_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_SyncErrors));
        this.SetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofile_SyncErrors")]
    public ait_memberprofile ait_memberprofile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_SyncErrors));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_SyncErrors")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofilemembershipcategory_SyncErrors));
        this.SetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofilemembershipcategory_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberroll_SyncErrors")]
    public ait_memberroll ait_memberroll_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_SyncErrors));
        this.SetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipcategory_SyncErrors")]
    public ait_membershipcategory ait_membershipcategory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_SyncErrors));
        this.SetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_SyncErrors")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatuschangerequest_SyncErrors));
        this.SetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipstatuschangerequest_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_nametype_SyncErrors")]
    public ait_nametype ait_nametype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_nametype_SyncErrors));
        this.SetRelatedEntity<ait_nametype>(nameof (ait_nametype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_nametype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_SyncErrors")]
    public ait_outcome ait_outcome_SyncErrors
    {
      get => this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_SyncErrors));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_payment_SyncErrors")]
    public ait_payment ait_payment_SyncErrors
    {
      get => this.GetRelatedEntity<ait_payment>(nameof (ait_payment_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_SyncErrors));
        this.SetRelatedEntity<ait_payment>(nameof (ait_payment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_physicaladdress_SyncErrors")]
    public ait_physicaladdress ait_physicaladdress_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_SyncErrors));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placement_SyncErrors")]
    public ait_placement ait_placement_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_SyncErrors));
        this.SetRelatedEntity<ait_placement>(nameof (ait_placement_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placementlocation_SyncErrors")]
    public ait_placementlocation ait_placementlocation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_SyncErrors));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_SyncErrors")]
    public ait_planactivity ait_planactivity_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_SyncErrors));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmteligibility_SyncErrors")]
    public ait_pmteligibility ait_pmteligibility_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_SyncErrors));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtevent_SyncErrors")]
    public ait_pmtevent ait_pmtevent_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_SyncErrors));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtpaymenttype_SyncErrors")]
    public ait_pmtpaymenttype ait_pmtpaymenttype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_SyncErrors));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransaction_SyncErrors")]
    public ait_pmttransaction ait_pmttransaction_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_SyncErrors));
        this.SetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransactiondeduction_SyncErrors")]
    public ait_pmttransactiondeduction ait_pmttransactiondeduction_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_SyncErrors));
        this.SetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholding_SyncErrors")]
    public ait_pmtwithholding ait_pmtwithholding_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_SyncErrors));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholdingoverride_SyncErrors")]
    public ait_pmtwithholdingoverride ait_pmtwithholdingoverride_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_SyncErrors));
        this.SetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_SyncErrors")]
    public ait_program ait_program_SyncErrors
    {
      get => this.GetRelatedEntity<ait_program>(nameof (ait_program_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_SyncErrors));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_SyncErrors")]
    public ait_referral ait_referral_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_SyncErrors));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_relationship_SyncErrors")]
    public ait_relationship ait_relationship_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_SyncErrors));
        this.SetRelatedEntity<ait_relationship>(nameof (ait_relationship_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_reservation_SyncErrors")]
    public ait_reservation ait_reservation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_reservation_SyncErrors));
        this.SetRelatedEntity<ait_reservation>(nameof (ait_reservation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_reservation_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_resolution_SyncErrors")]
    public ait_resolution ait_resolution_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_resolution_SyncErrors));
        this.SetRelatedEntity<ait_resolution>(nameof (ait_resolution_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_resolution_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_roll_SyncErrors")]
    public ait_roll ait_roll_SyncErrors
    {
      get => this.GetRelatedEntity<ait_roll>(nameof (ait_roll_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_SyncErrors));
        this.SetRelatedEntity<ait_roll>(nameof (ait_roll_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_safetyplan_SyncErrors")]
    public ait_safetyplan ait_safetyplan_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_SyncErrors));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_school_SyncErrors")]
    public ait_school ait_school_SyncErrors
    {
      get => this.GetRelatedEntity<ait_school>(nameof (ait_school_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_school_SyncErrors));
        this.SetRelatedEntity<ait_school>(nameof (ait_school_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_schooltype_SyncErrors")]
    public ait_schooltype ait_schooltype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_schooltype_SyncErrors));
        this.SetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_schooltype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_SyncErrors")]
    public ait_servicerequest ait_servicerequest_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_SyncErrors));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_skill_SyncErrors")]
    public ait_skill ait_skill_SyncErrors
    {
      get => this.GetRelatedEntity<ait_skill>(nameof (ait_skill_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_skill_SyncErrors));
        this.SetRelatedEntity<ait_skill>(nameof (ait_skill_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_skill_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_stateprovince_SyncErrors")]
    public ait_stateprovince ait_stateprovince_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_SyncErrors));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_statute_SyncErrors")]
    public ait_statute ait_statute_SyncErrors
    {
      get => this.GetRelatedEntity<ait_statute>(nameof (ait_statute_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_SyncErrors));
        this.SetRelatedEntity<ait_statute>(nameof (ait_statute_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_training_SyncErrors")]
    public ait_training ait_training_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_training_SyncErrors));
        this.SetRelatedEntity<ait_training>(nameof (ait_training_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_training_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_trainingtype_SyncErrors")]
    public ait_trainingtype ait_trainingtype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_trainingtype_SyncErrors));
        this.SetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_trainingtype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_SyncErrors")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_SyncErrors));
        this.SetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribe_SyncErrors")]
    public ait_tribe ait_tribe_SyncErrors
    {
      get => this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_SyncErrors));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_tribe_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_withholdingtype_SyncErrors")]
    public ait_withholdingtype ait_withholdingtype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_SyncErrors));
        this.SetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_zipcodecity_SyncErrors")]
    public ait_zipcodecity ait_zipcodecity_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_SyncErrors));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Annotation_SyncErrors")]
    public Annotation Annotation_SyncErrors
    {
      get => this.GetRelatedEntity<Annotation>(nameof (Annotation_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Annotation_SyncErrors));
        this.SetRelatedEntity<Annotation>(nameof (Annotation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Annotation_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("apisettings_SyncErrors")]
    public apisettings apisettings_SyncErrors
    {
      get => this.GetRelatedEntity<apisettings>(nameof (apisettings_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (apisettings_SyncErrors));
        this.SetRelatedEntity<apisettings>(nameof (apisettings_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appelement_SyncErrors")]
    public AppElement appelement_SyncErrors
    {
      get => this.GetRelatedEntity<AppElement>(nameof (appelement_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (appelement_SyncErrors));
        this.SetRelatedEntity<AppElement>(nameof (appelement_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("applicationuser_SyncErrors")]
    public ApplicationUser applicationuser_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_SyncErrors));
        this.SetRelatedEntity<ApplicationUser>(nameof (applicationuser_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentedge_SyncErrors")]
    public AppModuleComponentEdge appmodulecomponentedge_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_SyncErrors));
        this.SetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentnode_SyncErrors")]
    public AppModuleComponentNode appmodulecomponentnode_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_SyncErrors));
        this.SetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Appointment_SyncErrors")]
    public Appointment Appointment_SyncErrors
    {
      get => this.GetRelatedEntity<Appointment>(nameof (Appointment_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Appointment_SyncErrors));
        this.SetRelatedEntity<Appointment>(nameof (Appointment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Appointment_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appsetting_SyncErrors")]
    public AppSetting appsetting_SyncErrors
    {
      get => this.GetRelatedEntity<AppSetting>(nameof (appsetting_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (appsetting_SyncErrors));
        this.SetRelatedEntity<AppSetting>(nameof (appsetting_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("attributeimageconfig_SyncErrors")]
    public AttributeImageConfig attributeimageconfig_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_SyncErrors));
        this.SetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("bot_SyncErrors")]
    public bot bot_SyncErrors
    {
      get => this.GetRelatedEntity<bot>(nameof (bot_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_SyncErrors));
        this.SetRelatedEntity<bot>(nameof (bot_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("botcomponent_SyncErrors")]
    public botcomponent botcomponent_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<botcomponent>(nameof (botcomponent_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_SyncErrors));
        this.SetRelatedEntity<botcomponent>(nameof (botcomponent_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_SyncErrors));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("BusinessUnit_SyncError")]
    public BusinessUnit BusinessUnit_SyncError
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_SyncError), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("BusinessUnit_SyncErrors")]
    public BusinessUnit BusinessUnit_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_SyncErrors));
        this.SetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("canvasappextendedmetadata_SyncErrors")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_SyncErrors));
        this.SetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalog_SyncErrors")]
    public Catalog catalog_SyncErrors
    {
      get => this.GetRelatedEntity<Catalog>(nameof (catalog_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (catalog_SyncErrors));
        this.SetRelatedEntity<Catalog>(nameof (catalog_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalogassignment_SyncErrors")]
    public CatalogAssignment catalogassignment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_SyncErrors));
        this.SetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Category_SyncErrors")]
    public Category Category_SyncErrors
    {
      get => this.GetRelatedEntity<Category>(nameof (Category_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Category_SyncErrors));
        this.SetRelatedEntity<Category>(nameof (Category_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Category_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ChannelAccessProfile_SyncErrors")]
    public ChannelAccessProfile ChannelAccessProfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (ChannelAccessProfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfile_SyncErrors));
        this.SetRelatedEntity<ChannelAccessProfile>(nameof (ChannelAccessProfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ChannelAccessProfileRule_SyncErrors")]
    public ChannelAccessProfileRule ChannelAccessProfileRule_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (ChannelAccessProfileRule_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileRule_SyncErrors));
        this.SetRelatedEntity<ChannelAccessProfileRule>(nameof (ChannelAccessProfileRule_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfileRule_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ChannelAccessProfileRuleItem_SyncErrors")]
    public ChannelAccessProfileRuleItem ChannelAccessProfileRuleItem_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRuleItem>(nameof (ChannelAccessProfileRuleItem_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ChannelAccessProfileRuleItem_SyncErrors));
        this.SetRelatedEntity<ChannelAccessProfileRuleItem>(nameof (ChannelAccessProfileRuleItem_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ChannelAccessProfileRuleItem_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Connection_SyncErrors")]
    public Connection Connection_SyncErrors
    {
      get => this.GetRelatedEntity<Connection>(nameof (Connection_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Connection_SyncErrors));
        this.SetRelatedEntity<Connection>(nameof (Connection_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Connection_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connectionreference_SyncErrors")]
    public connectionreference connectionreference_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<connectionreference>(nameof (connectionreference_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_SyncErrors));
        this.SetRelatedEntity<connectionreference>(nameof (connectionreference_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ConnectionRole_SyncErrors")]
    public ConnectionRole ConnectionRole_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>(nameof (ConnectionRole_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConnectionRole_SyncErrors));
        this.SetRelatedEntity<ConnectionRole>(nameof (ConnectionRole_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConnectionRole_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connector_SyncErrors")]
    public connector connector_SyncErrors
    {
      get => this.GetRelatedEntity<connector>(nameof (connector_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (connector_SyncErrors));
        this.SetRelatedEntity<connector>(nameof (connector_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_SyncErrors")]
    public Contact Contact_SyncErrors
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Contact_SyncErrors));
        this.SetRelatedEntity<Contact>(nameof (Contact_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("conversationtranscript_SyncErrors")]
    public conversationtranscript conversationtranscript_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_SyncErrors));
        this.SetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("customapi_SyncErrors")]
    public CustomAPI customapi_SyncErrors
    {
      get => this.GetRelatedEntity<CustomAPI>(nameof (customapi_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (customapi_SyncErrors));
        this.SetRelatedEntity<CustomAPI>(nameof (customapi_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("CustomerAddress_SyncErrors")]
    public CustomerAddress CustomerAddress_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<CustomerAddress>(nameof (CustomerAddress_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (CustomerAddress_SyncErrors));
        this.SetRelatedEntity<CustomerAddress>(nameof (CustomerAddress_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (CustomerAddress_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolder_SyncErrors")]
    public datalakefolder datalakefolder_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_SyncErrors));
        this.SetRelatedEntity<datalakefolder>(nameof (datalakefolder_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolderpermission_SyncErrors")]
    public datalakefolderpermission datalakefolderpermission_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_SyncErrors));
        this.SetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspace_SyncErrors")]
    public datalakeworkspace datalakeworkspace_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_SyncErrors));
        this.SetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspacepermission_SyncErrors")]
    public datalakeworkspacepermission datalakeworkspacepermission_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_SyncErrors));
        this.SetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("DuplicateRule_SyncErrors")]
    public DuplicateRule DuplicateRule_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<DuplicateRule>(nameof (DuplicateRule_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRule_SyncErrors));
        this.SetRelatedEntity<DuplicateRule>(nameof (DuplicateRule_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRule_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("DuplicateRuleCondition_SyncErrors")]
    public DuplicateRuleCondition DuplicateRuleCondition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<DuplicateRuleCondition>(nameof (DuplicateRuleCondition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (DuplicateRuleCondition_SyncErrors));
        this.SetRelatedEntity<DuplicateRuleCondition>(nameof (DuplicateRuleCondition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (DuplicateRuleCondition_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Email_SyncErrors")]
    public Email Email_SyncErrors
    {
      get => this.GetRelatedEntity<Email>(nameof (Email_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Email_SyncErrors));
        this.SetRelatedEntity<Email>(nameof (Email_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Email_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("EmailServerProfile_SyncErrors")]
    public EmailServerProfile EmailServerProfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<EmailServerProfile>(nameof (EmailServerProfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (EmailServerProfile_SyncErrors));
        this.SetRelatedEntity<EmailServerProfile>(nameof (EmailServerProfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (EmailServerProfile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("entityanalyticsconfig_SyncErrors")]
    public EntityAnalyticsConfig entityanalyticsconfig_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_SyncErrors));
        this.SetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("entityimageconfig_SyncErrors")]
    public EntityImageConfig entityimageconfig_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_SyncErrors));
        this.SetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariabledefinition_SyncErrors")]
    public EnvironmentVariableDefinition environmentvariabledefinition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_SyncErrors));
        this.SetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariablevalue_SyncErrors")]
    public EnvironmentVariableValue environmentvariablevalue_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_SyncErrors));
        this.SetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ExpiredProcess_SyncErrors")]
    public ExpiredProcess ExpiredProcess_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ExpiredProcess>(nameof (ExpiredProcess_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ExpiredProcess_SyncErrors));
        this.SetRelatedEntity<ExpiredProcess>(nameof (ExpiredProcess_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ExpiredProcess_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("exportsolutionupload_SyncErrors")]
    public ExportSolutionUpload exportsolutionupload_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_SyncErrors));
        this.SetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ExternalParty_SyncErrors")]
    public ExternalParty ExternalParty_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ExternalParty>(nameof (ExternalParty_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ExternalParty_SyncErrors));
        this.SetRelatedEntity<ExternalParty>(nameof (ExternalParty_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ExternalParty_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ExternalPartyItem_SyncErrors")]
    public ExternalPartyItem ExternalPartyItem_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ExternalPartyItem>(nameof (ExternalPartyItem_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ExternalPartyItem_SyncErrors));
        this.SetRelatedEntity<ExternalPartyItem>(nameof (ExternalPartyItem_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ExternalPartyItem_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Fax_SyncErrors")]
    public Fax Fax_SyncErrors
    {
      get => this.GetRelatedEntity<Fax>(nameof (Fax_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Fax_SyncErrors));
        this.SetRelatedEntity<Fax>(nameof (Fax_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Fax_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Feedback_SyncErrors")]
    public Feedback Feedback_SyncErrors
    {
      get => this.GetRelatedEntity<Feedback>(nameof (Feedback_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Feedback_SyncErrors));
        this.SetRelatedEntity<Feedback>(nameof (Feedback_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Feedback_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("FieldPermission_SyncErrors")]
    public FieldPermission FieldPermission_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<FieldPermission>(nameof (FieldPermission_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (FieldPermission_SyncErrors));
        this.SetRelatedEntity<FieldPermission>(nameof (FieldPermission_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (FieldPermission_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("FieldSecurityProfile_SyncErrors")]
    public FieldSecurityProfile FieldSecurityProfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<FieldSecurityProfile>(nameof (FieldSecurityProfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (FieldSecurityProfile_SyncErrors));
        this.SetRelatedEntity<FieldSecurityProfile>(nameof (FieldSecurityProfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (FieldSecurityProfile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("flowsession_SyncErrors")]
    public flowsession flowsession_SyncErrors
    {
      get => this.GetRelatedEntity<flowsession>(nameof (flowsession_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (flowsession_SyncErrors));
        this.SetRelatedEntity<flowsession>(nameof (flowsession_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Goal_SyncErrors")]
    public Goal Goal_SyncErrors
    {
      get => this.GetRelatedEntity<Goal>(nameof (Goal_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Goal_SyncErrors));
        this.SetRelatedEntity<Goal>(nameof (Goal_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Goal_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("GoalRollupQuery_SyncErrors")]
    public GoalRollupQuery GoalRollupQuery_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<GoalRollupQuery>(nameof (GoalRollupQuery_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (GoalRollupQuery_SyncErrors));
        this.SetRelatedEntity<GoalRollupQuery>(nameof (GoalRollupQuery_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (GoalRollupQuery_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("holidaywrapper_SyncErrors")]
    public holidaywrapper holidaywrapper_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_SyncErrors));
        this.SetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ImportMap_SyncErrors")]
    public ImportMap ImportMap_SyncErrors
    {
      get => this.GetRelatedEntity<ImportMap>(nameof (ImportMap_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportMap_SyncErrors));
        this.SetRelatedEntity<ImportMap>(nameof (ImportMap_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportMap_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("internalcatalogassignment_SyncErrors")]
    public InternalCatalogAssignment internalcatalogassignment_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_SyncErrors));
        this.SetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticle_SyncErrors")]
    public KbArticle KbArticle_SyncErrors
    {
      get => this.GetRelatedEntity<KbArticle>(nameof (KbArticle_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (KbArticle_SyncErrors));
        this.SetRelatedEntity<KbArticle>(nameof (KbArticle_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticle_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticleTemplate_SyncErrors")]
    public KbArticleTemplate KbArticleTemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<KbArticleTemplate>(nameof (KbArticleTemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KbArticleTemplate_SyncErrors));
        this.SetRelatedEntity<KbArticleTemplate>(nameof (KbArticleTemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KbArticleTemplate_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticle_SyncErrors")]
    public KnowledgeArticle KnowledgeArticle_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticle_SyncErrors));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (KnowledgeArticle_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticle_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeArticleViews_SyncErrors")]
    public KnowledgeArticleViews KnowledgeArticleViews_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticleViews>(nameof (KnowledgeArticleViews_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeArticleViews_SyncErrors));
        this.SetRelatedEntity<KnowledgeArticleViews>(nameof (KnowledgeArticleViews_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeArticleViews_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_SyncErrors")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_SyncErrors));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Letter_SyncErrors")]
    public Letter Letter_SyncErrors
    {
      get => this.GetRelatedEntity<Letter>(nameof (Letter_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Letter_SyncErrors));
        this.SetRelatedEntity<Letter>(nameof (Letter_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Letter_SyncErrors));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_syncerrorbase_createdby")]
    public SystemUser lk_syncerrorbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_syncerrorbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_syncerrorbase_createdonbehalfby")]
    public SystemUser lk_syncerrorbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_syncerrorbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_syncerrorbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_syncerrorbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_syncerrorbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_syncerrorbase_modifiedby")]
    public SystemUser lk_syncerrorbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_syncerrorbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_syncerrorbase_modifiedonbehalfby")]
    public SystemUser lk_syncerrorbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_syncerrorbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_syncerrorbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_syncerrorbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_syncerrorbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Mailbox_SyncErrors")]
    public Mailbox Mailbox_SyncErrors
    {
      get => this.GetRelatedEntity<Mailbox>(nameof (Mailbox_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Mailbox_SyncErrors));
        this.SetRelatedEntity<Mailbox>(nameof (Mailbox_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Mailbox_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("MailMergeTemplate_SyncErrors")]
    public MailMergeTemplate MailMergeTemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<MailMergeTemplate>(nameof (MailMergeTemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MailMergeTemplate_SyncErrors));
        this.SetRelatedEntity<MailMergeTemplate>(nameof (MailMergeTemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MailMergeTemplate_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mbs_pluginprofile_SyncErrors")]
    public mbs_pluginprofile mbs_pluginprofile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_SyncErrors));
        this.SetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Metric_SyncErrors")]
    public Metric Metric_SyncErrors
    {
      get => this.GetRelatedEntity<Metric>(nameof (Metric_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Metric_SyncErrors));
        this.SetRelatedEntity<Metric>(nameof (Metric_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Metric_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdataset_SyncErrors")]
    public msdyn_AIBDataset msdyn_aibdataset_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdataset_SyncErrors));
        this.SetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdataset_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_SyncErrors")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_SyncErrors));
        this.SetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_SyncErrors")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_SyncErrors));
        this.SetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_SyncErrors")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_SyncErrors));
        this.SetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfile_SyncErrors")]
    public msdyn_AIBFile msdyn_aibfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_SyncErrors));
        this.SetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_SyncErrors")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfileattacheddata_SyncErrors));
        this.SetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfileattacheddata_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiconfiguration_SyncErrors")]
    public msdyn_AIConfiguration msdyn_aiconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_SyncErrors));
        this.SetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aifptrainingdocument_SyncErrors")]
    public msdyn_AIFpTrainingDocument msdyn_aifptrainingdocument_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_SyncErrors));
        this.SetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aimodel_SyncErrors")]
    public msdyn_AIModel msdyn_aimodel_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_SyncErrors));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodimage_SyncErrors")]
    public msdyn_AIOdImage msdyn_aiodimage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_SyncErrors));
        this.SetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodlabel_SyncErrors")]
    public msdyn_AIOdLabel msdyn_aiodlabel_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_SyncErrors));
        this.SetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_SyncErrors")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_SyncErrors));
        this.SetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_SyncErrors")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_SyncErrors));
        this.SetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aitemplate_SyncErrors")]
    public msdyn_AITemplate msdyn_aitemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_SyncErrors));
        this.SetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_SyncErrors")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_SyncErrors));
        this.SetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisjob_SyncErrors")]
    public msdyn_analysisjob msdyn_analysisjob_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_SyncErrors));
        this.SetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresult_SyncErrors")]
    public msdyn_analysisresult msdyn_analysisresult_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_SyncErrors));
        this.SetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_SyncErrors")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_SyncErrors));
        this.SetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_dataflow_SyncErrors")]
    public msdyn_dataflow msdyn_dataflow_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_SyncErrors));
        this.SetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticle_SyncErrors")]
    public msdyn_federatedarticle msdyn_federatedarticle_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_SyncErrors));
        this.SetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_SyncErrors")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_SyncErrors));
        this.SetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_helppage_SyncErrors")]
    public msdyn_helppage msdyn_helppage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_helppage_SyncErrors));
        this.SetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_helppage_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_SyncErrors")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_SyncErrors));
        this.SetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_SyncErrors")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_SyncErrors));
        this.SetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_SyncErrors")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_SyncErrors));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_SyncErrors")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_SyncErrors));
        this.SetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_SyncErrors")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_SyncErrors));
        this.SetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_richtextfile_SyncErrors")]
    public msdyn_richtextfile msdyn_richtextfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_SyncErrors));
        this.SetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_SyncErrors")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_SyncErrors));
        this.SetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_slakpi_SyncErrors")]
    public msdyn_slakpi msdyn_slakpi_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_SyncErrors));
        this.SetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_SyncErrors")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_SyncErrors));
        this.SetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_SyncErrors")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_SyncErrors));
        this.SetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_SyncErrors")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_SyncErrors));
        this.SetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdynce_botcontent_SyncErrors")]
    public msdynce_botcontent msdynce_botcontent_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_SyncErrors));
        this.SetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("NewProcess_SyncErrors")]
    public NewProcess NewProcess_SyncErrors
    {
      get => this.GetRelatedEntity<NewProcess>(nameof (NewProcess_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (NewProcess_SyncErrors));
        this.SetRelatedEntity<NewProcess>(nameof (NewProcess_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (NewProcess_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("OfflineCommandDefinition_SyncErrors")]
    public OfflineCommandDefinition OfflineCommandDefinition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<OfflineCommandDefinition>(nameof (OfflineCommandDefinition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (OfflineCommandDefinition_SyncErrors));
        this.SetRelatedEntity<OfflineCommandDefinition>(nameof (OfflineCommandDefinition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (OfflineCommandDefinition_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Organization_SyncErrors")]
    public Organization Organization_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (Organization_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Organization_SyncErrors));
        this.SetRelatedEntity<Organization>(nameof (Organization_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Organization_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("package_SyncErrors")]
    public package package_SyncErrors
    {
      get => this.GetRelatedEntity<package>(nameof (package_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (package_SyncErrors));
        this.SetRelatedEntity<package>(nameof (package_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("pdfsetting_SyncErrors")]
    public PDFSetting pdfsetting_SyncErrors
    {
      get => this.GetRelatedEntity<PDFSetting>(nameof (pdfsetting_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_SyncErrors));
        this.SetRelatedEntity<PDFSetting>(nameof (pdfsetting_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("PhoneCall_SyncErrors")]
    public PhoneCall PhoneCall_SyncErrors
    {
      get => this.GetRelatedEntity<PhoneCall>(nameof (PhoneCall_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (PhoneCall_SyncErrors));
        this.SetRelatedEntity<PhoneCall>(nameof (PhoneCall_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PhoneCall_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Position_SyncErrors")]
    public Position Position_SyncErrors
    {
      get => this.GetRelatedEntity<Position>(nameof (Position_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Position_SyncErrors));
        this.SetRelatedEntity<Position>(nameof (Position_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Position_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("PostFollow_SyncErrors")]
    public PostFollow PostFollow_SyncErrors
    {
      get => this.GetRelatedEntity<PostFollow>(nameof (PostFollow_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (PostFollow_SyncErrors));
        this.SetRelatedEntity<PostFollow>(nameof (PostFollow_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (PostFollow_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ProcessSession_SyncErrors")]
    public ProcessSession ProcessSession_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>(nameof (ProcessSession_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ProcessSession_SyncErrors));
        this.SetRelatedEntity<ProcessSession>(nameof (ProcessSession_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ProcessSession_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ProcessStage_SyncErrors")]
    public ProcessStage ProcessStage_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ProcessStage>(nameof (ProcessStage_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ProcessStage_SyncErrors));
        this.SetRelatedEntity<ProcessStage>(nameof (ProcessStage_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ProcessStage_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("processstageparameter_SyncErrors")]
    public processstageparameter processstageparameter_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<processstageparameter>(nameof (processstageparameter_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_SyncErrors));
        this.SetRelatedEntity<processstageparameter>(nameof (processstageparameter_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ProcessTrigger_SyncErrors")]
    public ProcessTrigger ProcessTrigger_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ProcessTrigger>(nameof (ProcessTrigger_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ProcessTrigger_SyncErrors));
        this.SetRelatedEntity<ProcessTrigger>(nameof (ProcessTrigger_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ProcessTrigger_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("provisionlanguageforuser_SyncErrors")]
    public ProvisionLanguageForUser provisionlanguageforuser_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_SyncErrors));
        this.SetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Publisher_SyncErrors")]
    public Publisher Publisher_SyncErrors
    {
      get => this.GetRelatedEntity<Publisher>(nameof (Publisher_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Publisher_SyncErrors));
        this.SetRelatedEntity<Publisher>(nameof (Publisher_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Publisher_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Queue_SyncErrors")]
    public Queue Queue_SyncErrors
    {
      get => this.GetRelatedEntity<Queue>(nameof (Queue_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Queue_SyncErrors));
        this.SetRelatedEntity<Queue>(nameof (Queue_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Queue_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("QueueItem_SyncErrors")]
    public QueueItem QueueItem_SyncErrors
    {
      get => this.GetRelatedEntity<QueueItem>(nameof (QueueItem_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (QueueItem_SyncErrors));
        this.SetRelatedEntity<QueueItem>(nameof (QueueItem_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (QueueItem_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RecurringAppointmentMaster_SyncErrors")]
    public RecurringAppointmentMaster RecurringAppointmentMaster_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (RecurringAppointmentMaster_SyncErrors));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RecurringAppointmentMaster_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Report_SyncErrors")]
    public Report Report_SyncErrors
    {
      get => this.GetRelatedEntity<Report>(nameof (Report_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Report_SyncErrors));
        this.SetRelatedEntity<Report>(nameof (Report_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Report_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ReportCategory_SyncErrors")]
    public ReportCategory ReportCategory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<ReportCategory>(nameof (ReportCategory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ReportCategory_SyncErrors));
        this.SetRelatedEntity<ReportCategory>(nameof (ReportCategory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ReportCategory_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_SyncErrors")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_SyncErrors));
        this.SetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Role_SyncErrors")]
    public Role Role_SyncErrors
    {
      get => this.GetRelatedEntity<Role>(nameof (Role_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Role_SyncErrors));
        this.SetRelatedEntity<Role>(nameof (Role_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Role_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RollupField_SyncErrors")]
    public RollupField RollupField_SyncErrors
    {
      get => this.GetRelatedEntity<RollupField>(nameof (RollupField_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (RollupField_SyncErrors));
        this.SetRelatedEntity<RollupField>(nameof (RollupField_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (RollupField_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SavedQuery_SyncErrors")]
    public SavedQuery SavedQuery_SyncErrors
    {
      get => this.GetRelatedEntity<SavedQuery>(nameof (SavedQuery_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (SavedQuery_SyncErrors));
        this.SetRelatedEntity<SavedQuery>(nameof (SavedQuery_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SavedQuery_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SavedQueryVisualization_SyncErrors")]
    public SavedQueryVisualization SavedQueryVisualization_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<SavedQueryVisualization>(nameof (SavedQueryVisualization_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SavedQueryVisualization_SyncErrors));
        this.SetRelatedEntity<SavedQueryVisualization>(nameof (SavedQueryVisualization_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SavedQueryVisualization_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("serviceplan_SyncErrors")]
    public ServicePlan serviceplan_SyncErrors
    {
      get => this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_SyncErrors));
        this.SetRelatedEntity<ServicePlan>(nameof (serviceplan_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("settingdefinition_SyncErrors")]
    public SettingDefinition settingdefinition_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<SettingDefinition>(nameof (settingdefinition_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_SyncErrors));
        this.SetRelatedEntity<SettingDefinition>(nameof (settingdefinition_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SharePointDocumentLocation_SyncErrors")]
    public SharePointDocumentLocation SharePointDocumentLocation_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>(nameof (SharePointDocumentLocation_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointDocumentLocation_SyncErrors));
        this.SetRelatedEntity<SharePointDocumentLocation>(nameof (SharePointDocumentLocation_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointDocumentLocation_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SharePointSite_SyncErrors")]
    public SharePointSite SharePointSite_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>(nameof (SharePointSite_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SharePointSite_SyncErrors));
        this.SetRelatedEntity<SharePointSite>(nameof (SharePointSite_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SharePointSite_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SLA_SyncErrors")]
    public SLA SLA_SyncErrors
    {
      get => this.GetRelatedEntity<SLA>(nameof (SLA_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (SLA_SyncErrors));
        this.SetRelatedEntity<SLA>(nameof (SLA_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SLA_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SLAItem_SyncErrors")]
    public SLAItem SLAItem_SyncErrors
    {
      get => this.GetRelatedEntity<SLAItem>(nameof (SLAItem_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (SLAItem_SyncErrors));
        this.SetRelatedEntity<SLAItem>(nameof (SLAItem_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SLAItem_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SLAKPIInstance_SyncErrors")]
    public SLAKPIInstance SLAKPIInstance_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<SLAKPIInstance>(nameof (SLAKPIInstance_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SLAKPIInstance_SyncErrors));
        this.SetRelatedEntity<SLAKPIInstance>(nameof (SLAKPIInstance_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SLAKPIInstance_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SocialActivity_SyncErrors")]
    public SocialActivity SocialActivity_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (SocialActivity_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialActivity_SyncErrors));
        this.SetRelatedEntity<SocialActivity>(nameof (SocialActivity_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialActivity_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SocialProfile_SyncErrors")]
    public SocialProfile SocialProfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (SocialProfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (SocialProfile_SyncErrors));
        this.SetRelatedEntity<SocialProfile>(nameof (SocialProfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SocialProfile_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Solution_SyncErrors")]
    public Solution Solution_SyncErrors
    {
      get => this.GetRelatedEntity<Solution>(nameof (Solution_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Solution_SyncErrors));
        this.SetRelatedEntity<Solution>(nameof (Solution_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Solution_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_SyncErrors")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_SyncErrors));
        this.SetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_SyncErrors")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_SyncErrors));
        this.SetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_SyncErrors")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_SyncErrors));
        this.SetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("stagesolutionupload_SyncErrors")]
    public StageSolutionUpload stagesolutionupload_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_SyncErrors));
        this.SetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Subject_SyncErrors")]
    public Subject Subject_SyncErrors
    {
      get => this.GetRelatedEntity<Subject>(nameof (Subject_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Subject_SyncErrors));
        this.SetRelatedEntity<Subject>(nameof (Subject_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Subject_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName]
    public SyncError ReferencingSyncError_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<SyncError>("SyncError_SyncErrors", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (ReferencingSyncError_SyncErrors));
        this.SetRelatedEntity<SyncError>("SyncError_SyncErrors", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (ReferencingSyncError_SyncErrors));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("SystemUser_SyncError")]
    public SystemUser SystemUser_SyncError
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (SystemUser_SyncError), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SystemUser_SyncErrors")]
    public SystemUser SystemUser_SyncErrors
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (SystemUser_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (SystemUser_SyncErrors));
        this.SetRelatedEntity<SystemUser>(nameof (SystemUser_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (SystemUser_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Task_SyncErrors")]
    public Task Task_SyncErrors
    {
      get => this.GetRelatedEntity<Task>(nameof (Task_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Task_SyncErrors));
        this.SetRelatedEntity<Task>(nameof (Task_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Task_SyncErrors));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_SyncError")]
    public Team team_SyncError
    {
      get => this.GetRelatedEntity<Team>(nameof (team_SyncError), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Team_SyncErrors")]
    public Team Team_SyncErrors
    {
      get => this.GetRelatedEntity<Team>(nameof (Team_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Team_SyncErrors));
        this.SetRelatedEntity<Team>(nameof (Team_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("TeamTemplate_SyncErrors")]
    public TeamTemplate TeamTemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<TeamTemplate>(nameof (TeamTemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TeamTemplate_SyncErrors));
        this.SetRelatedEntity<TeamTemplate>(nameof (TeamTemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TeamTemplate_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Template_SyncErrors")]
    public Template Template_SyncErrors
    {
      get => this.GetRelatedEntity<Template>(nameof (Template_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Template_SyncErrors));
        this.SetRelatedEntity<Template>(nameof (Template_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Template_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Territory_SyncErrors")]
    public Territory Territory_SyncErrors
    {
      get => this.GetRelatedEntity<Territory>(nameof (Territory_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Territory_SyncErrors));
        this.SetRelatedEntity<Territory>(nameof (Territory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Territory_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("TransactionCurrency_SyncErrors")]
    public TransactionCurrency TransactionCurrency_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_SyncErrors));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("TranslationProcess_SyncErrors")]
    public TranslationProcess TranslationProcess_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<TranslationProcess>(nameof (TranslationProcess_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TranslationProcess_SyncErrors));
        this.SetRelatedEntity<TranslationProcess>(nameof (TranslationProcess_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TranslationProcess_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("UserQuery_SyncErrors")]
    public UserQuery UserQuery_SyncErrors
    {
      get => this.GetRelatedEntity<UserQuery>(nameof (UserQuery_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (UserQuery_SyncErrors));
        this.SetRelatedEntity<UserQuery>(nameof (UserQuery_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserQuery_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("UserQueryVisualization_SyncErrors")]
    public UserQueryVisualization UserQueryVisualization_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<UserQueryVisualization>(nameof (UserQueryVisualization_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (UserQueryVisualization_SyncErrors));
        this.SetRelatedEntity<UserQueryVisualization>(nameof (UserQueryVisualization_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserQueryVisualization_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Workflow_SyncErrors")]
    public Workflow Workflow_SyncErrors
    {
      get => this.GetRelatedEntity<Workflow>(nameof (Workflow_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Workflow_SyncErrors));
        this.SetRelatedEntity<Workflow>(nameof (Workflow_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Workflow_SyncErrors));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("workflowbinary_SyncErrors")]
    public workflowbinary workflowbinary_SyncErrors
    {
      get
      {
        return this.GetRelatedEntity<workflowbinary>(nameof (workflowbinary_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_SyncErrors));
        this.SetRelatedEntity<workflowbinary>(nameof (workflowbinary_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_SyncErrors));
      }
    }

    public SyncError(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["syncerrorid"] = (object) base.Id;
            break;
          case "syncerrorid":
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
