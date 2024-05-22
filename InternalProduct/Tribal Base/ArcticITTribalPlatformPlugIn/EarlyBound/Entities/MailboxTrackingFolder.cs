// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.MailboxTrackingFolder
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mailboxtrackingfolder")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class MailboxTrackingFolder : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mailboxtrackingfolder";
    public const string EntitySchemaName = "MailboxTrackingFolder";
    public const string PrimaryIdAttribute = "mailboxtrackingfolderid";

    public MailboxTrackingFolder()
      : base("mailboxtrackingfolder")
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

    [AttributeLogicalName("exchangefolderid")]
    public string ExchangeFolderId
    {
      get => this.GetAttributeValue<string>("exchangefolderid");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeFolderId));
        this.SetAttributeValue("exchangefolderid", (object) value);
        this.OnPropertyChanged(nameof (ExchangeFolderId));
      }
    }

    [AttributeLogicalName("exchangefoldername")]
    public string ExchangeFolderName
    {
      get => this.GetAttributeValue<string>("exchangefoldername");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeFolderName));
        this.SetAttributeValue("exchangefoldername", (object) value);
        this.OnPropertyChanged(nameof (ExchangeFolderName));
      }
    }

    [AttributeLogicalName("folderonboardingstatus")]
    public int? FolderOnboardingStatus
    {
      get => this.GetAttributeValue<int?>("folderonboardingstatus");
      set
      {
        this.OnPropertyChanging(nameof (FolderOnboardingStatus));
        this.SetAttributeValue("folderonboardingstatus", (object) value);
        this.OnPropertyChanged(nameof (FolderOnboardingStatus));
      }
    }

    [AttributeLogicalName("mailboxid")]
    public EntityReference MailboxId
    {
      get => this.GetAttributeValue<EntityReference>("mailboxid");
      set
      {
        this.OnPropertyChanging(nameof (MailboxId));
        this.SetAttributeValue("mailboxid", (object) value);
        this.OnPropertyChanged(nameof (MailboxId));
      }
    }

    [AttributeLogicalName("mailboxtrackingfolderid")]
    public Guid? MailboxTrackingFolderId
    {
      get => this.GetAttributeValue<Guid?>("mailboxtrackingfolderid");
    }

    [AttributeLogicalName("mailboxtrackingfolderid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_MailboxTrackingFolder")]
    public Account Account_MailboxTrackingFolder
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (Account_MailboxTrackingFolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Account_MailboxTrackingFolder));
        this.SetRelatedEntity<Account>(nameof (Account_MailboxTrackingFolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Account_MailboxTrackingFolder));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_accountingcode_MailboxTrackingFolders")]
    public ait_accountingcode ait_accountingcode_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_addresstype_MailboxTrackingFolders")]
    public ait_addresstype ait_addresstype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_addresstype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_addresstype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_MailboxTrackingFolders")]
    public ait_assessment ait_assessment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_autonumber_MailboxTrackingFolders")]
    public ait_autonumber ait_autonumber_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_band_MailboxTrackingFolders")]
    public ait_band ait_band_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_band>(nameof (ait_band_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_band_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_band>(nameof (ait_band_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_band_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccount_MailboxTrackingFolders")]
    public ait_bankaccount ait_bankaccount_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccounttype_MailboxTrackingFolders")]
    public ait_bankaccounttype ait_bankaccounttype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccounttype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccounttype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_birthrecord_MailboxTrackingFolders")]
    public ait_birthrecord ait_birthrecord_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bloodquantum_MailboxTrackingFolders")]
    public ait_bloodquantum ait_bloodquantum_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformat_MailboxTrackingFolders")]
    public ait_cardformat ait_cardformat_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformatdetail_MailboxTrackingFolders")]
    public ait_cardformatdetail ait_cardformatdetail_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardhistory_MailboxTrackingFolders")]
    public ait_cardhistory ait_cardhistory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_MailboxTrackingFolders")]
    public ait_case ait_case_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_MailboxTrackingFolders")]
    public ait_casenote ait_casenote_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_MailboxTrackingFolders")]
    public ait_caseplan ait_caseplan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_causeofdeath_MailboxTrackingFolders")]
    public ait_causeofdeath ait_causeofdeath_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_causeofdeath_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_causeofdeath_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cemetary_MailboxTrackingFolders")]
    public ait_cemetary ait_cemetary_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_certification_MailboxTrackingFolders")]
    public ait_certification ait_certification_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_certification_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_certification>(nameof (ait_certification_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_certification_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_MailboxTrackingFolders")]
    public ait_changerequest ait_changerequest_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequesttype_MailboxTrackingFolders")]
    public ait_changerequesttype ait_changerequesttype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_charge_MailboxTrackingFolders")]
    public ait_charge ait_charge_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_charge>(nameof (ait_charge_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_charge>(nameof (ait_charge_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_childvisitations_MailboxTrackingFolders")]
    public ait_childvisitations ait_childvisitations_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_city_MailboxTrackingFolders")]
    public ait_city ait_city_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_city_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_city>(nameof (ait_city_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clan_MailboxTrackingFolders")]
    public ait_clan ait_clan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_clan>(nameof (ait_clan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clan_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_clan>(nameof (ait_clan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clan_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_MailboxTrackingFolders")]
    public ait_clientprofile ait_clientprofile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committee_MailboxTrackingFolders")]
    public ait_committee ait_committee_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_committee>(nameof (ait_committee_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemeeting_MailboxTrackingFolders")]
    public ait_committeemeeting ait_committeemeeting_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemeeting_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemeeting_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemember_MailboxTrackingFolders")]
    public ait_committeemember ait_committeemember_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeeposition_MailboxTrackingFolders")]
    public ait_committeeposition ait_committeeposition_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeeposition_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeeposition_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeepositiontype_MailboxTrackingFolders")]
    public ait_committeepositiontype ait_committeepositiontype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeepositiontype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeepositiontype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_company_MailboxTrackingFolders")]
    public ait_company ait_company_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactcertification_MailboxTrackingFolders")]
    public ait_contactcertification ait_contactcertification_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contacteducation_MailboxTrackingFolders")]
    public ait_contacteducation ait_contacteducation_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactemployment_MailboxTrackingFolders")]
    public ait_contactemployment ait_contactemployment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactimage_MailboxTrackingFolders")]
    public ait_contactimage ait_contactimage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactimage_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactimage_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincarceration_MailboxTrackingFolders")]
    public ait_contactincarceration ait_contactincarceration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_MailboxTrackingFolders")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactlanguage_MailboxTrackingFolders")]
    public ait_contactlanguage ait_contactlanguage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_MailboxTrackingFolders")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactname_MailboxTrackingFolders")]
    public ait_contactname ait_contactname_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactname>(nameof (ait_contactname_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactskill_MailboxTrackingFolders")]
    public ait_contactskill ait_contactskill_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactskill_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactskill_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_countryregion_MailboxTrackingFolders")]
    public ait_countryregion ait_countryregion_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_county_MailboxTrackingFolders")]
    public ait_county ait_county_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_county>(nameof (ait_county_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_county_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_county>(nameof (ait_county_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_county_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_MailboxTrackingFolders")]
    public ait_courtcase ait_courtcase_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtfinesandfees_MailboxTrackingFolders")]
    public ait_courtfinesandfees ait_courtfinesandfees_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtparty_MailboxTrackingFolders")]
    public ait_courtparty ait_courtparty_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtpayments_MailboxTrackingFolders")]
    public ait_courtpayments ait_courtpayments_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofile_MailboxTrackingFolders")]
    public ait_courtprofile ait_courtprofile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofileaddress_MailboxTrackingFolders")]
    public ait_courtprofileaddress ait_courtprofileaddress_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtroom_MailboxTrackingFolders")]
    public ait_courtroom ait_courtroom_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtroom_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtroom_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_datamigrationhistory_MailboxTrackingFolders")]
    public ait_datamigrationhistory ait_datamigrationhistory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_deathrecord_MailboxTrackingFolders")]
    public ait_deathrecord ait_deathrecord_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_degree_MailboxTrackingFolders")]
    public ait_degree ait_degree_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_degree>(nameof (ait_degree_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_degree_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_degree>(nameof (ait_degree_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_degree_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_electronicaddress_MailboxTrackingFolders")]
    public ait_electronicaddress ait_electronicaddress_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_emergencycontact_MailboxTrackingFolders")]
    public ait_emergencycontact ait_emergencycontact_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_MailboxTrackingFolders")]
    public ait_familygroup ait_familygroup_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_MailboxTrackingFolders")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_geographicalarea_MailboxTrackingFolders")]
    public ait_geographicalarea ait_geographicalarea_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_MailboxTrackingFolders")]
    public ait_goal ait_goal_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_goal_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivity_MailboxTrackingFolders")]
    public ait_groupactivity ait_groupactivity_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_MailboxTrackingFolders")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_household_MailboxTrackingFolders")]
    public ait_household ait_household_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_household>(nameof (ait_household_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_householdmember_MailboxTrackingFolders")]
    public ait_householdmember ait_householdmember_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_MailboxTrackingFolders")]
    public ait_icwaadoption ait_icwaadoption_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_MailboxTrackingFolders")]
    public ait_icwanotice ait_icwanotice_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregion_MailboxTrackingFolders")]
    public ait_icwaregion ait_icwaregion_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregionnotification_MailboxTrackingFolders")]
    public ait_icwaregionnotification ait_icwaregionnotification_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_MailboxTrackingFolders")]
    public ait_incident ait_incident_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incidenttype_MailboxTrackingFolders")]
    public ait_incidenttype ait_incidenttype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidenttype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_MailboxTrackingFolders")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_MailboxTrackingFolders")]
    public ait_investigation ait_investigation_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_language_MailboxTrackingFolders")]
    public ait_language ait_language_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_language_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_language>(nameof (ait_language_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_language_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_languageproficiencylevel_MailboxTrackingFolders")]
    public ait_languageproficiencylevel ait_languageproficiencylevel_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loan_MailboxTrackingFolders")]
    public ait_loan ait_loan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_loan>(nameof (ait_loan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loandetail_MailboxTrackingFolders")]
    public ait_loandetail ait_loandetail_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loantype_MailboxTrackingFolders")]
    public ait_loantype ait_loantype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loantype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_loantype>(nameof (ait_loantype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loantype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_medicalproviders_MailboxTrackingFolders")]
    public ait_medicalproviders ait_medicalproviders_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofile_MailboxTrackingFolders")]
    public ait_memberprofile ait_memberprofile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_MailboxTrackingFolders")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofilemembershipcategory_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofilemembershipcategory_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberroll_MailboxTrackingFolders")]
    public ait_memberroll ait_memberroll_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipcategory_MailboxTrackingFolders")]
    public ait_membershipcategory ait_membershipcategory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_MailboxTrackingFolders")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatuschangerequest_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipstatuschangerequest_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_nametype_MailboxTrackingFolders")]
    public ait_nametype ait_nametype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_nametype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_nametype>(nameof (ait_nametype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_nametype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_MailboxTrackingFolders")]
    public ait_outcome ait_outcome_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_payment_MailboxTrackingFolders")]
    public ait_payment ait_payment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_payment>(nameof (ait_payment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_physicaladdress_MailboxTrackingFolders")]
    public ait_physicaladdress ait_physicaladdress_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placement_MailboxTrackingFolders")]
    public ait_placement ait_placement_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_placement>(nameof (ait_placement_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placementlocation_MailboxTrackingFolders")]
    public ait_placementlocation ait_placementlocation_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_MailboxTrackingFolders")]
    public ait_planactivity ait_planactivity_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmteligibility_MailboxTrackingFolders")]
    public ait_pmteligibility ait_pmteligibility_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtevent_MailboxTrackingFolders")]
    public ait_pmtevent ait_pmtevent_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtpaymenttype_MailboxTrackingFolders")]
    public ait_pmtpaymenttype ait_pmtpaymenttype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransaction_MailboxTrackingFolders")]
    public ait_pmttransaction ait_pmttransaction_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransactiondeduction_MailboxTrackingFolders")]
    public ait_pmttransactiondeduction ait_pmttransactiondeduction_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholding_MailboxTrackingFolders")]
    public ait_pmtwithholding ait_pmtwithholding_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholdingoverride_MailboxTrackingFolders")]
    public ait_pmtwithholdingoverride ait_pmtwithholdingoverride_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_MailboxTrackingFolders")]
    public ait_program ait_program_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_MailboxTrackingFolders")]
    public ait_referral ait_referral_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_relationship_MailboxTrackingFolders")]
    public ait_relationship ait_relationship_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_relationship>(nameof (ait_relationship_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_reservation_MailboxTrackingFolders")]
    public ait_reservation ait_reservation_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_reservation_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_reservation>(nameof (ait_reservation_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_reservation_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_resolution_MailboxTrackingFolders")]
    public ait_resolution ait_resolution_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_resolution_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_resolution>(nameof (ait_resolution_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_resolution_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_roll_MailboxTrackingFolders")]
    public ait_roll ait_roll_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_roll>(nameof (ait_roll_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_roll>(nameof (ait_roll_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_safetyplan_MailboxTrackingFolders")]
    public ait_safetyplan ait_safetyplan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_school_MailboxTrackingFolders")]
    public ait_school ait_school_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_school>(nameof (ait_school_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_school>(nameof (ait_school_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_schooltype_MailboxTrackingFolders")]
    public ait_schooltype ait_schooltype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_schooltype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_schooltype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_MailboxTrackingFolders")]
    public ait_servicerequest ait_servicerequest_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_skill_MailboxTrackingFolders")]
    public ait_skill ait_skill_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_skill>(nameof (ait_skill_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_skill_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_skill>(nameof (ait_skill_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_skill_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_stateprovince_MailboxTrackingFolders")]
    public ait_stateprovince ait_stateprovince_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_statute_MailboxTrackingFolders")]
    public ait_statute ait_statute_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_statute>(nameof (ait_statute_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_training_MailboxTrackingFolders")]
    public ait_training ait_training_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_training_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_training>(nameof (ait_training_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_training_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_trainingtype_MailboxTrackingFolders")]
    public ait_trainingtype ait_trainingtype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_trainingtype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_trainingtype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_MailboxTrackingFolders")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribe_MailboxTrackingFolders")]
    public ait_tribe ait_tribe_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_tribe_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_withholdingtype_MailboxTrackingFolders")]
    public ait_withholdingtype ait_withholdingtype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_zipcodecity_MailboxTrackingFolders")]
    public ait_zipcodecity ait_zipcodecity_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_MailboxTrackingFolders));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("apisettings_MailboxTrackingFolders")]
    public apisettings apisettings_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<apisettings>(nameof (apisettings_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_MailboxTrackingFolders));
        this.SetRelatedEntity<apisettings>(nameof (apisettings_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appelement_MailboxTrackingFolders")]
    public AppElement appelement_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<AppElement>(nameof (appelement_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_MailboxTrackingFolders));
        this.SetRelatedEntity<AppElement>(nameof (appelement_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("applicationuser_MailboxTrackingFolders")]
    public ApplicationUser applicationuser_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_MailboxTrackingFolders));
        this.SetRelatedEntity<ApplicationUser>(nameof (applicationuser_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentedge_MailboxTrackingFolders")]
    public AppModuleComponentEdge appmodulecomponentedge_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_MailboxTrackingFolders));
        this.SetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentnode_MailboxTrackingFolders")]
    public AppModuleComponentNode appmodulecomponentnode_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_MailboxTrackingFolders));
        this.SetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appsetting_MailboxTrackingFolders")]
    public AppSetting appsetting_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<AppSetting>(nameof (appsetting_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_MailboxTrackingFolders));
        this.SetRelatedEntity<AppSetting>(nameof (appsetting_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("AsyncOperation_MailboxTrackingFolder")]
    public AsyncOperation AsyncOperation_MailboxTrackingFolder
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>(nameof (AsyncOperation_MailboxTrackingFolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperation_MailboxTrackingFolder));
        this.SetRelatedEntity<AsyncOperation>(nameof (AsyncOperation_MailboxTrackingFolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (AsyncOperation_MailboxTrackingFolder));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("attributeimageconfig_MailboxTrackingFolders")]
    public AttributeImageConfig attributeimageconfig_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_MailboxTrackingFolders));
        this.SetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("bot_MailboxTrackingFolders")]
    public bot bot_MailboxTrackingFolders
    {
      get => this.GetRelatedEntity<bot>(nameof (bot_MailboxTrackingFolders), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_MailboxTrackingFolders));
        this.SetRelatedEntity<bot>(nameof (bot_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("botcomponent_MailboxTrackingFolders")]
    public botcomponent botcomponent_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<botcomponent>(nameof (botcomponent_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_MailboxTrackingFolders));
        this.SetRelatedEntity<botcomponent>(nameof (botcomponent_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("businessunit_mailboxtrackingfolder")]
    public BusinessUnit businessunit_mailboxtrackingfolder
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (businessunit_mailboxtrackingfolder), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("canvasappextendedmetadata_MailboxTrackingFolders")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_MailboxTrackingFolders));
        this.SetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalog_MailboxTrackingFolders")]
    public Catalog catalog_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<Catalog>(nameof (catalog_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_MailboxTrackingFolders));
        this.SetRelatedEntity<Catalog>(nameof (catalog_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalogassignment_MailboxTrackingFolders")]
    public CatalogAssignment catalogassignment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_MailboxTrackingFolders));
        this.SetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connectionreference_MailboxTrackingFolders")]
    public connectionreference connectionreference_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<connectionreference>(nameof (connectionreference_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_MailboxTrackingFolders));
        this.SetRelatedEntity<connectionreference>(nameof (connectionreference_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connector_MailboxTrackingFolders")]
    public connector connector_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<connector>(nameof (connector_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_MailboxTrackingFolders));
        this.SetRelatedEntity<connector>(nameof (connector_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_MailboxTrackingFolder")]
    public Contact Contact_MailboxTrackingFolder
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (Contact_MailboxTrackingFolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Contact_MailboxTrackingFolder));
        this.SetRelatedEntity<Contact>(nameof (Contact_MailboxTrackingFolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Contact_MailboxTrackingFolder));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("conversationtranscript_MailboxTrackingFolders")]
    public conversationtranscript conversationtranscript_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_MailboxTrackingFolders));
        this.SetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("customapi_MailboxTrackingFolders")]
    public CustomAPI customapi_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<CustomAPI>(nameof (customapi_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_MailboxTrackingFolders));
        this.SetRelatedEntity<CustomAPI>(nameof (customapi_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolder_MailboxTrackingFolders")]
    public datalakefolder datalakefolder_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_MailboxTrackingFolders));
        this.SetRelatedEntity<datalakefolder>(nameof (datalakefolder_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolderpermission_MailboxTrackingFolders")]
    public datalakefolderpermission datalakefolderpermission_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_MailboxTrackingFolders));
        this.SetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspace_MailboxTrackingFolders")]
    public datalakeworkspace datalakeworkspace_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_MailboxTrackingFolders));
        this.SetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspacepermission_MailboxTrackingFolders")]
    public datalakeworkspacepermission datalakeworkspacepermission_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_MailboxTrackingFolders));
        this.SetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("entityanalyticsconfig_MailboxTrackingFolders")]
    public EntityAnalyticsConfig entityanalyticsconfig_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_MailboxTrackingFolders));
        this.SetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("entityimageconfig_MailboxTrackingFolders")]
    public EntityImageConfig entityimageconfig_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_MailboxTrackingFolders));
        this.SetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariabledefinition_MailboxTrackingFolders")]
    public EnvironmentVariableDefinition environmentvariabledefinition_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_MailboxTrackingFolders));
        this.SetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariablevalue_MailboxTrackingFolders")]
    public EnvironmentVariableValue environmentvariablevalue_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_MailboxTrackingFolders));
        this.SetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("exportsolutionupload_MailboxTrackingFolders")]
    public ExportSolutionUpload exportsolutionupload_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_MailboxTrackingFolders));
        this.SetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("flowsession_MailboxTrackingFolders")]
    public flowsession flowsession_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<flowsession>(nameof (flowsession_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_MailboxTrackingFolders));
        this.SetRelatedEntity<flowsession>(nameof (flowsession_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("holidaywrapper_MailboxTrackingFolders")]
    public holidaywrapper holidaywrapper_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_MailboxTrackingFolders));
        this.SetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("internalcatalogassignment_MailboxTrackingFolders")]
    public InternalCatalogAssignment internalcatalogassignment_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_MailboxTrackingFolders));
        this.SetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_mailboxtrackingfolder_createdby")]
    public SystemUser lk_mailboxtrackingfolder_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailboxtrackingfolder_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_mailboxtrackingfolder_createdonbehalfby")]
    public SystemUser lk_mailboxtrackingfolder_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailboxtrackingfolder_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mailboxtrackingfolder_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mailboxtrackingfolder_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mailboxtrackingfolder_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_mailboxtrackingfolder_modifiedby")]
    public SystemUser lk_mailboxtrackingfolder_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailboxtrackingfolder_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_mailboxtrackingfolder_modifiedonbehalfby")]
    public SystemUser lk_mailboxtrackingfolder_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailboxtrackingfolder_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mailboxtrackingfolder_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mailboxtrackingfolder_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mailboxtrackingfolder_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("mailboxid")]
    [RelationshipSchemaName("Mailbox_MailboxTrackingFolder")]
    public Mailbox Mailbox_MailboxTrackingFolder
    {
      get
      {
        return this.GetRelatedEntity<Mailbox>(nameof (Mailbox_MailboxTrackingFolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Mailbox_MailboxTrackingFolder));
        this.SetRelatedEntity<Mailbox>(nameof (Mailbox_MailboxTrackingFolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Mailbox_MailboxTrackingFolder));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mbs_pluginprofile_MailboxTrackingFolders")]
    public mbs_pluginprofile mbs_pluginprofile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_MailboxTrackingFolders));
        this.SetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdataset_MailboxTrackingFolders")]
    public msdyn_AIBDataset msdyn_aibdataset_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdataset_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdataset_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_MailboxTrackingFolders")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_MailboxTrackingFolders")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_MailboxTrackingFolders")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfile_MailboxTrackingFolders")]
    public msdyn_AIBFile msdyn_aibfile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_MailboxTrackingFolders")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfileattacheddata_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfileattacheddata_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiconfiguration_MailboxTrackingFolders")]
    public msdyn_AIConfiguration msdyn_aiconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aifptrainingdocument_MailboxTrackingFolders")]
    public msdyn_AIFpTrainingDocument msdyn_aifptrainingdocument_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aimodel_MailboxTrackingFolders")]
    public msdyn_AIModel msdyn_aimodel_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodimage_MailboxTrackingFolders")]
    public msdyn_AIOdImage msdyn_aiodimage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodlabel_MailboxTrackingFolders")]
    public msdyn_AIOdLabel msdyn_aiodlabel_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_MailboxTrackingFolders")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_MailboxTrackingFolders")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aitemplate_MailboxTrackingFolders")]
    public msdyn_AITemplate msdyn_aitemplate_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_MailboxTrackingFolders")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisjob_MailboxTrackingFolders")]
    public msdyn_analysisjob msdyn_analysisjob_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresult_MailboxTrackingFolders")]
    public msdyn_analysisresult msdyn_analysisresult_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_MailboxTrackingFolders")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_dataflow_MailboxTrackingFolders")]
    public msdyn_dataflow msdyn_dataflow_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticle_MailboxTrackingFolders")]
    public msdyn_federatedarticle msdyn_federatedarticle_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_MailboxTrackingFolders")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_helppage_MailboxTrackingFolders")]
    public msdyn_helppage msdyn_helppage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_helppage_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_helppage_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_MailboxTrackingFolders")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_MailboxTrackingFolders")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_MailboxTrackingFolders")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_MailboxTrackingFolders")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_MailboxTrackingFolders")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_richtextfile_MailboxTrackingFolders")]
    public msdyn_richtextfile msdyn_richtextfile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_MailboxTrackingFolders")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_slakpi_MailboxTrackingFolders")]
    public msdyn_slakpi msdyn_slakpi_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_MailboxTrackingFolders")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_MailboxTrackingFolders")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_MailboxTrackingFolders")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_MailboxTrackingFolders));
        this.SetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdynce_botcontent_MailboxTrackingFolders")]
    public msdynce_botcontent msdynce_botcontent_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_MailboxTrackingFolders));
        this.SetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("Organization_MailboxTrackingFolder")]
    public Organization Organization_MailboxTrackingFolder
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (Organization_MailboxTrackingFolder), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("package_MailboxTrackingFolders")]
    public package package_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<package>(nameof (package_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_MailboxTrackingFolders));
        this.SetRelatedEntity<package>(nameof (package_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("pdfsetting_MailboxTrackingFolders")]
    public PDFSetting pdfsetting_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<PDFSetting>(nameof (pdfsetting_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_MailboxTrackingFolders));
        this.SetRelatedEntity<PDFSetting>(nameof (pdfsetting_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("processstageparameter_MailboxTrackingFolders")]
    public processstageparameter processstageparameter_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<processstageparameter>(nameof (processstageparameter_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_MailboxTrackingFolders));
        this.SetRelatedEntity<processstageparameter>(nameof (processstageparameter_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("provisionlanguageforuser_MailboxTrackingFolders")]
    public ProvisionLanguageForUser provisionlanguageforuser_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_MailboxTrackingFolders));
        this.SetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_MailboxTrackingFolders")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_MailboxTrackingFolders));
        this.SetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("serviceplan_MailboxTrackingFolders")]
    public ServicePlan serviceplan_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_MailboxTrackingFolders));
        this.SetRelatedEntity<ServicePlan>(nameof (serviceplan_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("settingdefinition_MailboxTrackingFolders")]
    public SettingDefinition settingdefinition_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<SettingDefinition>(nameof (settingdefinition_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_MailboxTrackingFolders));
        this.SetRelatedEntity<SettingDefinition>(nameof (settingdefinition_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_MailboxTrackingFolders")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_MailboxTrackingFolders")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_MailboxTrackingFolders")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_MailboxTrackingFolders));
        this.SetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("stagesolutionupload_MailboxTrackingFolders")]
    public StageSolutionUpload stagesolutionupload_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_MailboxTrackingFolders));
        this.SetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_mailboxtrackingfolder")]
    public Team team_mailboxtrackingfolder
    {
      get => this.GetRelatedEntity<Team>(nameof (team_mailboxtrackingfolder), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("territory_MailboxTrackingFolders")]
    public Territory territory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<Territory>(nameof (territory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (territory_MailboxTrackingFolders));
        this.SetRelatedEntity<Territory>(nameof (territory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_MailboxTrackingFolders));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("workflowbinary_MailboxTrackingFolders")]
    public workflowbinary workflowbinary_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntity<workflowbinary>(nameof (workflowbinary_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_MailboxTrackingFolders));
        this.SetRelatedEntity<workflowbinary>(nameof (workflowbinary_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_MailboxTrackingFolders));
      }
    }

    public MailboxTrackingFolder(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mailboxtrackingfolderid"] = (object) base.Id;
            break;
          case "mailboxtrackingfolderid":
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
