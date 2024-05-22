// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Team
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("team")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Team : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "team";
    public const string EntitySchemaName = "Team";
    public const string PrimaryIdAttribute = "teamid";
    public const string PrimaryNameAttribute = "name";

    public Team()
      : base("team")
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

    [AttributeLogicalName("administratorid")]
    public EntityReference AdministratorId
    {
      get => this.GetAttributeValue<EntityReference>("administratorid");
      set
      {
        this.OnPropertyChanging(nameof (AdministratorId));
        this.SetAttributeValue("administratorid", (object) value);
        this.OnPropertyChanged(nameof (AdministratorId));
      }
    }

    [AttributeLogicalName("azureactivedirectoryobjectid")]
    public Guid? AzureActiveDirectoryObjectId
    {
      get => this.GetAttributeValue<Guid?>("azureactivedirectoryobjectid");
      set
      {
        this.OnPropertyChanging(nameof (AzureActiveDirectoryObjectId));
        this.SetAttributeValue("azureactivedirectoryobjectid", (object) value);
        this.OnPropertyChanged(nameof (AzureActiveDirectoryObjectId));
      }
    }

    [AttributeLogicalName("businessunitid")]
    public EntityReference BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitId));
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged(nameof (BusinessUnitId));
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

    [AttributeLogicalName("emailaddress")]
    public string EMailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EMailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EMailAddress));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("isdefault")]
    public bool? IsDefault => this.GetAttributeValue<bool?>("isdefault");

    [AttributeLogicalName("membershiptype")]
    public OptionSetValue MembershipType
    {
      get => this.GetAttributeValue<OptionSetValue>("membershiptype");
      set
      {
        this.OnPropertyChanging(nameof (MembershipType));
        this.SetAttributeValue("membershiptype", (object) value);
        this.OnPropertyChanged(nameof (MembershipType));
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

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

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

    [AttributeLogicalName("queueid")]
    public EntityReference QueueId
    {
      get => this.GetAttributeValue<EntityReference>("queueid");
      set
      {
        this.OnPropertyChanging(nameof (QueueId));
        this.SetAttributeValue("queueid", (object) value);
        this.OnPropertyChanged(nameof (QueueId));
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

    [AttributeLogicalName("systemmanaged")]
    public bool? SystemManaged => this.GetAttributeValue<bool?>("systemmanaged");

    [AttributeLogicalName("teamid")]
    public Guid? TeamId
    {
      get => this.GetAttributeValue<Guid?>("teamid");
      set
      {
        this.OnPropertyChanging(nameof (TeamId));
        this.SetAttributeValue("teamid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TeamId));
      }
    }

    [AttributeLogicalName("teamid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TeamId = new Guid?(value);
    }

    [AttributeLogicalName("teamtemplateid")]
    public EntityReference TeamTemplateId
    {
      get => this.GetAttributeValue<EntityReference>("teamtemplateid");
      set
      {
        this.OnPropertyChanging(nameof (TeamTemplateId));
        this.SetAttributeValue("teamtemplateid", (object) value);
        this.OnPropertyChanged(nameof (TeamTemplateId));
      }
    }

    [AttributeLogicalName("teamtype")]
    public OptionSetValue TeamType
    {
      get => this.GetAttributeValue<OptionSetValue>("teamtype");
      set
      {
        this.OnPropertyChanging(nameof (TeamType));
        this.SetAttributeValue("teamtype", (object) value);
        this.OnPropertyChanged(nameof (TeamType));
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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("yominame")]
    public string YomiName
    {
      get => this.GetAttributeValue<string>("yominame");
      set
      {
        this.OnPropertyChanging(nameof (YomiName));
        this.SetAttributeValue("yominame", (object) value);
        this.OnPropertyChanged(nameof (YomiName));
      }
    }

    [RelationshipSchemaName("ait_team_ait_changerequesttype_ApprovingTeam")]
    public IEnumerable<ait_changerequesttype> ait_team_ait_changerequesttype_ApprovingTeam
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequesttype>(nameof (ait_team_ait_changerequesttype_ApprovingTeam), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_team_ait_changerequesttype_ApprovingTeam));
        this.SetRelatedEntities<ait_changerequesttype>(nameof (ait_team_ait_changerequesttype_ApprovingTeam), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_team_ait_changerequesttype_ApprovingTeam));
      }
    }

    [RelationshipSchemaName("ImportFile_Team")]
    public IEnumerable<ImportFile> ImportFile_Team
    {
      get => this.GetRelatedEntities<ImportFile>(nameof (ImportFile_Team), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportFile_Team));
        this.SetRelatedEntities<ImportFile>(nameof (ImportFile_Team), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportFile_Team));
      }
    }

    [RelationshipSchemaName("OwningTeam_postfollows")]
    public IEnumerable<PostFollow> OwningTeam_postfollows
    {
      get
      {
        return this.GetRelatedEntities<PostFollow>(nameof (OwningTeam_postfollows), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (OwningTeam_postfollows));
        this.SetRelatedEntities<PostFollow>(nameof (OwningTeam_postfollows), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (OwningTeam_postfollows));
      }
    }

    [RelationshipSchemaName("team_accounts")]
    public IEnumerable<Account> team_accounts
    {
      get => this.GetRelatedEntities<Account>(nameof (team_accounts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_accounts));
        this.SetRelatedEntities<Account>(nameof (team_accounts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_accounts));
      }
    }

    [RelationshipSchemaName("team_actioncardusersettings")]
    public IEnumerable<ActionCardUserSettings> team_actioncardusersettings
    {
      get
      {
        return this.GetRelatedEntities<ActionCardUserSettings>(nameof (team_actioncardusersettings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_actioncardusersettings));
        this.SetRelatedEntities<ActionCardUserSettings>(nameof (team_actioncardusersettings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_actioncardusersettings));
      }
    }

    [RelationshipSchemaName("team_activity")]
    public IEnumerable<ActivityPointer> team_activity
    {
      get => this.GetRelatedEntities<ActivityPointer>(nameof (team_activity), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_activity));
        this.SetRelatedEntities<ActivityPointer>(nameof (team_activity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_activity));
      }
    }

    [RelationshipSchemaName("team_ait_accountingcode")]
    public IEnumerable<ait_accountingcode> team_ait_accountingcode
    {
      get
      {
        return this.GetRelatedEntities<ait_accountingcode>(nameof (team_ait_accountingcode), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_accountingcode));
        this.SetRelatedEntities<ait_accountingcode>(nameof (team_ait_accountingcode), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_accountingcode));
      }
    }

    [RelationshipSchemaName("team_ait_assessment")]
    public IEnumerable<ait_assessment> team_ait_assessment
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (team_ait_assessment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_assessment));
        this.SetRelatedEntities<ait_assessment>(nameof (team_ait_assessment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_assessment));
      }
    }

    [RelationshipSchemaName("team_ait_bankaccount")]
    public IEnumerable<ait_bankaccount> team_ait_bankaccount
    {
      get
      {
        return this.GetRelatedEntities<ait_bankaccount>(nameof (team_ait_bankaccount), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_bankaccount));
        this.SetRelatedEntities<ait_bankaccount>(nameof (team_ait_bankaccount), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_bankaccount));
      }
    }

    [RelationshipSchemaName("team_ait_birthrecord")]
    public IEnumerable<ait_birthrecord> team_ait_birthrecord
    {
      get
      {
        return this.GetRelatedEntities<ait_birthrecord>(nameof (team_ait_birthrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_birthrecord));
        this.SetRelatedEntities<ait_birthrecord>(nameof (team_ait_birthrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_birthrecord));
      }
    }

    [RelationshipSchemaName("team_ait_bloodquantum")]
    public IEnumerable<ait_bloodquantum> team_ait_bloodquantum
    {
      get
      {
        return this.GetRelatedEntities<ait_bloodquantum>(nameof (team_ait_bloodquantum), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_bloodquantum));
        this.SetRelatedEntities<ait_bloodquantum>(nameof (team_ait_bloodquantum), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_bloodquantum));
      }
    }

    [RelationshipSchemaName("team_ait_cardhistory")]
    public IEnumerable<ait_cardhistory> team_ait_cardhistory
    {
      get
      {
        return this.GetRelatedEntities<ait_cardhistory>(nameof (team_ait_cardhistory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_cardhistory));
        this.SetRelatedEntities<ait_cardhistory>(nameof (team_ait_cardhistory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_cardhistory));
      }
    }

    [RelationshipSchemaName("team_ait_case")]
    public IEnumerable<ait_case> team_ait_case
    {
      get => this.GetRelatedEntities<ait_case>(nameof (team_ait_case), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_case));
        this.SetRelatedEntities<ait_case>(nameof (team_ait_case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_case));
      }
    }

    [RelationshipSchemaName("team_ait_casenote")]
    public IEnumerable<ait_casenote> team_ait_casenote
    {
      get => this.GetRelatedEntities<ait_casenote>(nameof (team_ait_casenote), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_casenote));
        this.SetRelatedEntities<ait_casenote>(nameof (team_ait_casenote), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_casenote));
      }
    }

    [RelationshipSchemaName("team_ait_caseplan")]
    public IEnumerable<ait_caseplan> team_ait_caseplan
    {
      get => this.GetRelatedEntities<ait_caseplan>(nameof (team_ait_caseplan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_caseplan));
        this.SetRelatedEntities<ait_caseplan>(nameof (team_ait_caseplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_caseplan));
      }
    }

    [RelationshipSchemaName("team_ait_changerequest")]
    public IEnumerable<ait_changerequest> team_ait_changerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (team_ait_changerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_changerequest));
        this.SetRelatedEntities<ait_changerequest>(nameof (team_ait_changerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_changerequest));
      }
    }

    [RelationshipSchemaName("team_ait_changerequesttype")]
    public IEnumerable<ait_changerequesttype> team_ait_changerequesttype
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequesttype>(nameof (team_ait_changerequesttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_changerequesttype));
        this.SetRelatedEntities<ait_changerequesttype>(nameof (team_ait_changerequesttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_changerequesttype));
      }
    }

    [RelationshipSchemaName("team_ait_charge")]
    public IEnumerable<ait_charge> team_ait_charge
    {
      get => this.GetRelatedEntities<ait_charge>(nameof (team_ait_charge), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_charge));
        this.SetRelatedEntities<ait_charge>(nameof (team_ait_charge), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_charge));
      }
    }

    [RelationshipSchemaName("team_ait_childvisitations")]
    public IEnumerable<ait_childvisitations> team_ait_childvisitations
    {
      get
      {
        return this.GetRelatedEntities<ait_childvisitations>(nameof (team_ait_childvisitations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_childvisitations));
        this.SetRelatedEntities<ait_childvisitations>(nameof (team_ait_childvisitations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_childvisitations));
      }
    }

    [RelationshipSchemaName("team_ait_clientprofile")]
    public IEnumerable<ait_clientprofile> team_ait_clientprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_clientprofile>(nameof (team_ait_clientprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_clientprofile));
        this.SetRelatedEntities<ait_clientprofile>(nameof (team_ait_clientprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_clientprofile));
      }
    }

    [RelationshipSchemaName("team_ait_company")]
    public IEnumerable<ait_company> team_ait_company
    {
      get => this.GetRelatedEntities<ait_company>(nameof (team_ait_company), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_company));
        this.SetRelatedEntities<ait_company>(nameof (team_ait_company), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_company));
      }
    }

    [RelationshipSchemaName("team_ait_contactcertification")]
    public IEnumerable<ait_contactcertification> team_ait_contactcertification
    {
      get
      {
        return this.GetRelatedEntities<ait_contactcertification>(nameof (team_ait_contactcertification), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactcertification));
        this.SetRelatedEntities<ait_contactcertification>(nameof (team_ait_contactcertification), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactcertification));
      }
    }

    [RelationshipSchemaName("team_ait_contacteducation")]
    public IEnumerable<ait_contacteducation> team_ait_contacteducation
    {
      get
      {
        return this.GetRelatedEntities<ait_contacteducation>(nameof (team_ait_contacteducation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contacteducation));
        this.SetRelatedEntities<ait_contacteducation>(nameof (team_ait_contacteducation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contacteducation));
      }
    }

    [RelationshipSchemaName("team_ait_contactemployment")]
    public IEnumerable<ait_contactemployment> team_ait_contactemployment
    {
      get
      {
        return this.GetRelatedEntities<ait_contactemployment>(nameof (team_ait_contactemployment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactemployment));
        this.SetRelatedEntities<ait_contactemployment>(nameof (team_ait_contactemployment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactemployment));
      }
    }

    [RelationshipSchemaName("team_ait_contactimage")]
    public IEnumerable<ait_contactimage> team_ait_contactimage
    {
      get
      {
        return this.GetRelatedEntities<ait_contactimage>(nameof (team_ait_contactimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactimage));
        this.SetRelatedEntities<ait_contactimage>(nameof (team_ait_contactimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactimage));
      }
    }

    [RelationshipSchemaName("team_ait_contactincarceration")]
    public IEnumerable<ait_contactincarceration> team_ait_contactincarceration
    {
      get
      {
        return this.GetRelatedEntities<ait_contactincarceration>(nameof (team_ait_contactincarceration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactincarceration));
        this.SetRelatedEntities<ait_contactincarceration>(nameof (team_ait_contactincarceration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactincarceration));
      }
    }

    [RelationshipSchemaName("team_ait_contactincomeandexpense")]
    public IEnumerable<ait_contactincomeandexpense> team_ait_contactincomeandexpense
    {
      get
      {
        return this.GetRelatedEntities<ait_contactincomeandexpense>(nameof (team_ait_contactincomeandexpense), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactincomeandexpense));
        this.SetRelatedEntities<ait_contactincomeandexpense>(nameof (team_ait_contactincomeandexpense), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactincomeandexpense));
      }
    }

    [RelationshipSchemaName("team_ait_contactlanguage")]
    public IEnumerable<ait_contactlanguage> team_ait_contactlanguage
    {
      get
      {
        return this.GetRelatedEntities<ait_contactlanguage>(nameof (team_ait_contactlanguage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactlanguage));
        this.SetRelatedEntities<ait_contactlanguage>(nameof (team_ait_contactlanguage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactlanguage));
      }
    }

    [RelationshipSchemaName("team_ait_contactmilitaryservice")]
    public IEnumerable<ait_contactmilitaryservice> team_ait_contactmilitaryservice
    {
      get
      {
        return this.GetRelatedEntities<ait_contactmilitaryservice>(nameof (team_ait_contactmilitaryservice), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactmilitaryservice));
        this.SetRelatedEntities<ait_contactmilitaryservice>(nameof (team_ait_contactmilitaryservice), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactmilitaryservice));
      }
    }

    [RelationshipSchemaName("team_ait_contactname")]
    public IEnumerable<ait_contactname> team_ait_contactname
    {
      get
      {
        return this.GetRelatedEntities<ait_contactname>(nameof (team_ait_contactname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactname));
        this.SetRelatedEntities<ait_contactname>(nameof (team_ait_contactname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactname));
      }
    }

    [RelationshipSchemaName("team_ait_contactskill")]
    public IEnumerable<ait_contactskill> team_ait_contactskill
    {
      get
      {
        return this.GetRelatedEntities<ait_contactskill>(nameof (team_ait_contactskill), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_contactskill));
        this.SetRelatedEntities<ait_contactskill>(nameof (team_ait_contactskill), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_contactskill));
      }
    }

    [RelationshipSchemaName("team_ait_courtcase")]
    public IEnumerable<ait_courtcase> team_ait_courtcase
    {
      get => this.GetRelatedEntities<ait_courtcase>(nameof (team_ait_courtcase), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_courtcase));
        this.SetRelatedEntities<ait_courtcase>(nameof (team_ait_courtcase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_courtcase));
      }
    }

    [RelationshipSchemaName("team_ait_courtfinesandfees")]
    public IEnumerable<ait_courtfinesandfees> team_ait_courtfinesandfees
    {
      get
      {
        return this.GetRelatedEntities<ait_courtfinesandfees>(nameof (team_ait_courtfinesandfees), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_courtfinesandfees));
        this.SetRelatedEntities<ait_courtfinesandfees>(nameof (team_ait_courtfinesandfees), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_courtfinesandfees));
      }
    }

    [RelationshipSchemaName("team_ait_courtparty")]
    public IEnumerable<ait_courtparty> team_ait_courtparty
    {
      get
      {
        return this.GetRelatedEntities<ait_courtparty>(nameof (team_ait_courtparty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_courtparty));
        this.SetRelatedEntities<ait_courtparty>(nameof (team_ait_courtparty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_courtparty));
      }
    }

    [RelationshipSchemaName("team_ait_courtpayments")]
    public IEnumerable<ait_courtpayments> team_ait_courtpayments
    {
      get
      {
        return this.GetRelatedEntities<ait_courtpayments>(nameof (team_ait_courtpayments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_courtpayments));
        this.SetRelatedEntities<ait_courtpayments>(nameof (team_ait_courtpayments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_courtpayments));
      }
    }

    [RelationshipSchemaName("team_ait_courtprofile")]
    public IEnumerable<ait_courtprofile> team_ait_courtprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofile>(nameof (team_ait_courtprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_courtprofile));
        this.SetRelatedEntities<ait_courtprofile>(nameof (team_ait_courtprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_courtprofile));
      }
    }

    [RelationshipSchemaName("team_ait_courtprofileaddress")]
    public IEnumerable<ait_courtprofileaddress> team_ait_courtprofileaddress
    {
      get
      {
        return this.GetRelatedEntities<ait_courtprofileaddress>(nameof (team_ait_courtprofileaddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_courtprofileaddress));
        this.SetRelatedEntities<ait_courtprofileaddress>(nameof (team_ait_courtprofileaddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_courtprofileaddress));
      }
    }

    [RelationshipSchemaName("team_ait_courtroom")]
    public IEnumerable<ait_courtroom> team_ait_courtroom
    {
      get => this.GetRelatedEntities<ait_courtroom>(nameof (team_ait_courtroom), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_courtroom));
        this.SetRelatedEntities<ait_courtroom>(nameof (team_ait_courtroom), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_courtroom));
      }
    }

    [RelationshipSchemaName("team_ait_datamigrationhistory")]
    public IEnumerable<ait_datamigrationhistory> team_ait_datamigrationhistory
    {
      get
      {
        return this.GetRelatedEntities<ait_datamigrationhistory>(nameof (team_ait_datamigrationhistory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_datamigrationhistory));
        this.SetRelatedEntities<ait_datamigrationhistory>(nameof (team_ait_datamigrationhistory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_datamigrationhistory));
      }
    }

    [RelationshipSchemaName("team_ait_deathrecord")]
    public IEnumerable<ait_deathrecord> team_ait_deathrecord
    {
      get
      {
        return this.GetRelatedEntities<ait_deathrecord>(nameof (team_ait_deathrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_deathrecord));
        this.SetRelatedEntities<ait_deathrecord>(nameof (team_ait_deathrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_deathrecord));
      }
    }

    [RelationshipSchemaName("team_ait_electronicaddress")]
    public IEnumerable<ait_electronicaddress> team_ait_electronicaddress
    {
      get
      {
        return this.GetRelatedEntities<ait_electronicaddress>(nameof (team_ait_electronicaddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_electronicaddress));
        this.SetRelatedEntities<ait_electronicaddress>(nameof (team_ait_electronicaddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_electronicaddress));
      }
    }

    [RelationshipSchemaName("team_ait_emergencycontact")]
    public IEnumerable<ait_emergencycontact> team_ait_emergencycontact
    {
      get
      {
        return this.GetRelatedEntities<ait_emergencycontact>(nameof (team_ait_emergencycontact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_emergencycontact));
        this.SetRelatedEntities<ait_emergencycontact>(nameof (team_ait_emergencycontact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_emergencycontact));
      }
    }

    [RelationshipSchemaName("team_ait_familygroup")]
    public IEnumerable<ait_familygroup> team_ait_familygroup
    {
      get
      {
        return this.GetRelatedEntities<ait_familygroup>(nameof (team_ait_familygroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_familygroup));
        this.SetRelatedEntities<ait_familygroup>(nameof (team_ait_familygroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_familygroup));
      }
    }

    [RelationshipSchemaName("team_ait_goal")]
    public IEnumerable<ait_goal> team_ait_goal
    {
      get => this.GetRelatedEntities<ait_goal>(nameof (team_ait_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_goal));
        this.SetRelatedEntities<ait_goal>(nameof (team_ait_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_goal));
      }
    }

    [RelationshipSchemaName("team_ait_groupactivity")]
    public IEnumerable<ait_groupactivity> team_ait_groupactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (team_ait_groupactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_groupactivity));
        this.SetRelatedEntities<ait_groupactivity>(nameof (team_ait_groupactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_groupactivity));
      }
    }

    [RelationshipSchemaName("team_ait_groupactivitymeeting")]
    public IEnumerable<ait_groupactivitymeeting> team_ait_groupactivitymeeting
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (team_ait_groupactivitymeeting), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_groupactivitymeeting));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (team_ait_groupactivitymeeting), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_groupactivitymeeting));
      }
    }

    [RelationshipSchemaName("team_ait_household")]
    public IEnumerable<ait_household> team_ait_household
    {
      get => this.GetRelatedEntities<ait_household>(nameof (team_ait_household), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_household));
        this.SetRelatedEntities<ait_household>(nameof (team_ait_household), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_household));
      }
    }

    [RelationshipSchemaName("team_ait_householdmember")]
    public IEnumerable<ait_householdmember> team_ait_householdmember
    {
      get
      {
        return this.GetRelatedEntities<ait_householdmember>(nameof (team_ait_householdmember), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_householdmember));
        this.SetRelatedEntities<ait_householdmember>(nameof (team_ait_householdmember), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_householdmember));
      }
    }

    [RelationshipSchemaName("team_ait_icwaadoption")]
    public IEnumerable<ait_icwaadoption> team_ait_icwaadoption
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaadoption>(nameof (team_ait_icwaadoption), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_icwaadoption));
        this.SetRelatedEntities<ait_icwaadoption>(nameof (team_ait_icwaadoption), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_icwaadoption));
      }
    }

    [RelationshipSchemaName("team_ait_icwanotice")]
    public IEnumerable<ait_icwanotice> team_ait_icwanotice
    {
      get
      {
        return this.GetRelatedEntities<ait_icwanotice>(nameof (team_ait_icwanotice), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_icwanotice));
        this.SetRelatedEntities<ait_icwanotice>(nameof (team_ait_icwanotice), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_icwanotice));
      }
    }

    [RelationshipSchemaName("team_ait_icwaregion")]
    public IEnumerable<ait_icwaregion> team_ait_icwaregion
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregion>(nameof (team_ait_icwaregion), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_icwaregion));
        this.SetRelatedEntities<ait_icwaregion>(nameof (team_ait_icwaregion), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_icwaregion));
      }
    }

    [RelationshipSchemaName("team_ait_icwaregionnotification")]
    public IEnumerable<ait_icwaregionnotification> team_ait_icwaregionnotification
    {
      get
      {
        return this.GetRelatedEntities<ait_icwaregionnotification>(nameof (team_ait_icwaregionnotification), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_icwaregionnotification));
        this.SetRelatedEntities<ait_icwaregionnotification>(nameof (team_ait_icwaregionnotification), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_icwaregionnotification));
      }
    }

    [RelationshipSchemaName("team_ait_loan")]
    public IEnumerable<ait_loan> team_ait_loan
    {
      get => this.GetRelatedEntities<ait_loan>(nameof (team_ait_loan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_loan));
        this.SetRelatedEntities<ait_loan>(nameof (team_ait_loan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_loan));
      }
    }

    [RelationshipSchemaName("team_ait_loandetail")]
    public IEnumerable<ait_loandetail> team_ait_loandetail
    {
      get
      {
        return this.GetRelatedEntities<ait_loandetail>(nameof (team_ait_loandetail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_loandetail));
        this.SetRelatedEntities<ait_loandetail>(nameof (team_ait_loandetail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_loandetail));
      }
    }

    [RelationshipSchemaName("team_ait_loantype")]
    public IEnumerable<ait_loantype> team_ait_loantype
    {
      get => this.GetRelatedEntities<ait_loantype>(nameof (team_ait_loantype), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_loantype));
        this.SetRelatedEntities<ait_loantype>(nameof (team_ait_loantype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_loantype));
      }
    }

    [RelationshipSchemaName("team_ait_memberprofile")]
    public IEnumerable<ait_memberprofile> team_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofile>(nameof (team_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_memberprofile));
        this.SetRelatedEntities<ait_memberprofile>(nameof (team_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_memberprofile));
      }
    }

    [RelationshipSchemaName("team_ait_memberprofilemembershipcategory")]
    public IEnumerable<ait_memberprofilemembershipcategory> team_ait_memberprofilemembershipcategory
    {
      get
      {
        return this.GetRelatedEntities<ait_memberprofilemembershipcategory>(nameof (team_ait_memberprofilemembershipcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_memberprofilemembershipcategory));
        this.SetRelatedEntities<ait_memberprofilemembershipcategory>(nameof (team_ait_memberprofilemembershipcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_memberprofilemembershipcategory));
      }
    }

    [RelationshipSchemaName("team_ait_memberroll")]
    public IEnumerable<ait_memberroll> team_ait_memberroll
    {
      get
      {
        return this.GetRelatedEntities<ait_memberroll>(nameof (team_ait_memberroll), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_memberroll));
        this.SetRelatedEntities<ait_memberroll>(nameof (team_ait_memberroll), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_memberroll));
      }
    }

    [RelationshipSchemaName("team_ait_membershipstatuschangerequest")]
    public IEnumerable<ait_membershipstatuschangerequest> team_ait_membershipstatuschangerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_membershipstatuschangerequest>(nameof (team_ait_membershipstatuschangerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_membershipstatuschangerequest));
        this.SetRelatedEntities<ait_membershipstatuschangerequest>(nameof (team_ait_membershipstatuschangerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_membershipstatuschangerequest));
      }
    }

    [RelationshipSchemaName("team_ait_outcome")]
    public IEnumerable<ait_outcome> team_ait_outcome
    {
      get => this.GetRelatedEntities<ait_outcome>(nameof (team_ait_outcome), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_outcome));
        this.SetRelatedEntities<ait_outcome>(nameof (team_ait_outcome), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_outcome));
      }
    }

    [RelationshipSchemaName("team_ait_payment")]
    public IEnumerable<ait_payment> team_ait_payment
    {
      get => this.GetRelatedEntities<ait_payment>(nameof (team_ait_payment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_payment));
        this.SetRelatedEntities<ait_payment>(nameof (team_ait_payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_payment));
      }
    }

    [RelationshipSchemaName("team_ait_physicaladdress")]
    public IEnumerable<ait_physicaladdress> team_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntities<ait_physicaladdress>(nameof (team_ait_physicaladdress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_physicaladdress));
        this.SetRelatedEntities<ait_physicaladdress>(nameof (team_ait_physicaladdress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_physicaladdress));
      }
    }

    [RelationshipSchemaName("team_ait_placement")]
    public IEnumerable<ait_placement> team_ait_placement
    {
      get => this.GetRelatedEntities<ait_placement>(nameof (team_ait_placement), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_placement));
        this.SetRelatedEntities<ait_placement>(nameof (team_ait_placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_placement));
      }
    }

    [RelationshipSchemaName("team_ait_placementlocation")]
    public IEnumerable<ait_placementlocation> team_ait_placementlocation
    {
      get
      {
        return this.GetRelatedEntities<ait_placementlocation>(nameof (team_ait_placementlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_placementlocation));
        this.SetRelatedEntities<ait_placementlocation>(nameof (team_ait_placementlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_placementlocation));
      }
    }

    [RelationshipSchemaName("team_ait_planactivity")]
    public IEnumerable<ait_planactivity> team_ait_planactivity
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (team_ait_planactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_planactivity));
        this.SetRelatedEntities<ait_planactivity>(nameof (team_ait_planactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_planactivity));
      }
    }

    [RelationshipSchemaName("team_ait_pmteligibility")]
    public IEnumerable<ait_pmteligibility> team_ait_pmteligibility
    {
      get
      {
        return this.GetRelatedEntities<ait_pmteligibility>(nameof (team_ait_pmteligibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_pmteligibility));
        this.SetRelatedEntities<ait_pmteligibility>(nameof (team_ait_pmteligibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_pmteligibility));
      }
    }

    [RelationshipSchemaName("team_ait_pmtevent")]
    public IEnumerable<ait_pmtevent> team_ait_pmtevent
    {
      get => this.GetRelatedEntities<ait_pmtevent>(nameof (team_ait_pmtevent), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_pmtevent));
        this.SetRelatedEntities<ait_pmtevent>(nameof (team_ait_pmtevent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_pmtevent));
      }
    }

    [RelationshipSchemaName("team_ait_pmtpaymenttype")]
    public IEnumerable<ait_pmtpaymenttype> team_ait_pmtpaymenttype
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtpaymenttype>(nameof (team_ait_pmtpaymenttype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_pmtpaymenttype));
        this.SetRelatedEntities<ait_pmtpaymenttype>(nameof (team_ait_pmtpaymenttype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_pmtpaymenttype));
      }
    }

    [RelationshipSchemaName("team_ait_pmttransaction")]
    public IEnumerable<ait_pmttransaction> team_ait_pmttransaction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransaction>(nameof (team_ait_pmttransaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_pmttransaction));
        this.SetRelatedEntities<ait_pmttransaction>(nameof (team_ait_pmttransaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_pmttransaction));
      }
    }

    [RelationshipSchemaName("team_ait_pmttransactiondeduction")]
    public IEnumerable<ait_pmttransactiondeduction> team_ait_pmttransactiondeduction
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (team_ait_pmttransactiondeduction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_pmttransactiondeduction));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (team_ait_pmttransactiondeduction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_pmttransactiondeduction));
      }
    }

    [RelationshipSchemaName("team_ait_pmtwithholding")]
    public IEnumerable<ait_pmtwithholding> team_ait_pmtwithholding
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholding>(nameof (team_ait_pmtwithholding), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_pmtwithholding));
        this.SetRelatedEntities<ait_pmtwithholding>(nameof (team_ait_pmtwithholding), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_pmtwithholding));
      }
    }

    [RelationshipSchemaName("team_ait_pmtwithholdingoverride")]
    public IEnumerable<ait_pmtwithholdingoverride> team_ait_pmtwithholdingoverride
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholdingoverride>(nameof (team_ait_pmtwithholdingoverride), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_pmtwithholdingoverride));
        this.SetRelatedEntities<ait_pmtwithholdingoverride>(nameof (team_ait_pmtwithholdingoverride), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_pmtwithholdingoverride));
      }
    }

    [RelationshipSchemaName("team_ait_program")]
    public IEnumerable<ait_program> team_ait_program
    {
      get => this.GetRelatedEntities<ait_program>(nameof (team_ait_program), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_program));
        this.SetRelatedEntities<ait_program>(nameof (team_ait_program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_program));
      }
    }

    [RelationshipSchemaName("team_ait_referral")]
    public IEnumerable<ait_referral> team_ait_referral
    {
      get => this.GetRelatedEntities<ait_referral>(nameof (team_ait_referral), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_referral));
        this.SetRelatedEntities<ait_referral>(nameof (team_ait_referral), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_referral));
      }
    }

    [RelationshipSchemaName("team_ait_relationship")]
    public IEnumerable<ait_relationship> team_ait_relationship
    {
      get
      {
        return this.GetRelatedEntities<ait_relationship>(nameof (team_ait_relationship), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_relationship));
        this.SetRelatedEntities<ait_relationship>(nameof (team_ait_relationship), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_relationship));
      }
    }

    [RelationshipSchemaName("team_ait_resolution")]
    public IEnumerable<ait_resolution> team_ait_resolution
    {
      get
      {
        return this.GetRelatedEntities<ait_resolution>(nameof (team_ait_resolution), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_resolution));
        this.SetRelatedEntities<ait_resolution>(nameof (team_ait_resolution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_resolution));
      }
    }

    [RelationshipSchemaName("team_ait_safetyplan")]
    public IEnumerable<ait_safetyplan> team_ait_safetyplan
    {
      get
      {
        return this.GetRelatedEntities<ait_safetyplan>(nameof (team_ait_safetyplan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_safetyplan));
        this.SetRelatedEntities<ait_safetyplan>(nameof (team_ait_safetyplan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_safetyplan));
      }
    }

    [RelationshipSchemaName("team_ait_school")]
    public IEnumerable<ait_school> team_ait_school
    {
      get => this.GetRelatedEntities<ait_school>(nameof (team_ait_school), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_school));
        this.SetRelatedEntities<ait_school>(nameof (team_ait_school), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_school));
      }
    }

    [RelationshipSchemaName("team_ait_servicerequest")]
    public IEnumerable<ait_servicerequest> team_ait_servicerequest
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (team_ait_servicerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_servicerequest));
        this.SetRelatedEntities<ait_servicerequest>(nameof (team_ait_servicerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_servicerequest));
      }
    }

    [RelationshipSchemaName("team_ait_statute")]
    public IEnumerable<ait_statute> team_ait_statute
    {
      get => this.GetRelatedEntities<ait_statute>(nameof (team_ait_statute), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_statute));
        this.SetRelatedEntities<ait_statute>(nameof (team_ait_statute), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_statute));
      }
    }

    [RelationshipSchemaName("team_ait_training")]
    public IEnumerable<ait_training> team_ait_training
    {
      get => this.GetRelatedEntities<ait_training>(nameof (team_ait_training), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ait_training));
        this.SetRelatedEntities<ait_training>(nameof (team_ait_training), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_training));
      }
    }

    [RelationshipSchemaName("team_ait_trainingtype")]
    public IEnumerable<ait_trainingtype> team_ait_trainingtype
    {
      get
      {
        return this.GetRelatedEntities<ait_trainingtype>(nameof (team_ait_trainingtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_trainingtype));
        this.SetRelatedEntities<ait_trainingtype>(nameof (team_ait_trainingtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_trainingtype));
      }
    }

    [RelationshipSchemaName("team_ait_tribalenrollmentconfiguration")]
    public IEnumerable<ait_tribalenrollmentconfiguration> team_ait_tribalenrollmentconfiguration
    {
      get
      {
        return this.GetRelatedEntities<ait_tribalenrollmentconfiguration>(nameof (team_ait_tribalenrollmentconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_tribalenrollmentconfiguration));
        this.SetRelatedEntities<ait_tribalenrollmentconfiguration>(nameof (team_ait_tribalenrollmentconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_tribalenrollmentconfiguration));
      }
    }

    [RelationshipSchemaName("team_ait_withholdingtype")]
    public IEnumerable<ait_withholdingtype> team_ait_withholdingtype
    {
      get
      {
        return this.GetRelatedEntities<ait_withholdingtype>(nameof (team_ait_withholdingtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_ait_withholdingtype));
        this.SetRelatedEntities<ait_withholdingtype>(nameof (team_ait_withholdingtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ait_withholdingtype));
      }
    }

    [RelationshipSchemaName("team_annotations")]
    public IEnumerable<Annotation> team_annotations
    {
      get => this.GetRelatedEntities<Annotation>(nameof (team_annotations), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_annotations));
        this.SetRelatedEntities<Annotation>(nameof (team_annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_annotations));
      }
    }

    [RelationshipSchemaName("team_appointment")]
    public IEnumerable<Appointment> team_appointment
    {
      get => this.GetRelatedEntities<Appointment>(nameof (team_appointment), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_appointment));
        this.SetRelatedEntities<Appointment>(nameof (team_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_appointment));
      }
    }

    [RelationshipSchemaName("team_asyncoperation")]
    public IEnumerable<AsyncOperation> team_asyncoperation
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (team_asyncoperation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_asyncoperation));
        this.SetRelatedEntities<AsyncOperation>(nameof (team_asyncoperation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_asyncoperation));
      }
    }

    [RelationshipSchemaName("Team_AsyncOperations")]
    public IEnumerable<AsyncOperation> Team_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Team_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Team_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Team_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_AsyncOperations));
      }
    }

    [RelationshipSchemaName("team_bot")]
    public IEnumerable<bot> team_bot
    {
      get => this.GetRelatedEntities<bot>(nameof (team_bot), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_bot));
        this.SetRelatedEntities<bot>(nameof (team_bot), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_bot));
      }
    }

    [RelationshipSchemaName("team_botcomponent")]
    public IEnumerable<botcomponent> team_botcomponent
    {
      get => this.GetRelatedEntities<botcomponent>(nameof (team_botcomponent), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_botcomponent));
        this.SetRelatedEntities<botcomponent>(nameof (team_botcomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_botcomponent));
      }
    }

    [RelationshipSchemaName("Team_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Team_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Team_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Team_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Team_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("team_canvasappextendedmetadata")]
    public IEnumerable<CanvasAppExtendedMetadata> team_canvasappextendedmetadata
    {
      get
      {
        return this.GetRelatedEntities<CanvasAppExtendedMetadata>(nameof (team_canvasappextendedmetadata), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_canvasappextendedmetadata));
        this.SetRelatedEntities<CanvasAppExtendedMetadata>(nameof (team_canvasappextendedmetadata), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_canvasappextendedmetadata));
      }
    }

    [RelationshipSchemaName("team_channelaccessprofile")]
    public IEnumerable<ChannelAccessProfile> team_channelaccessprofile
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfile>(nameof (team_channelaccessprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_channelaccessprofile));
        this.SetRelatedEntities<ChannelAccessProfile>(nameof (team_channelaccessprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_channelaccessprofile));
      }
    }

    [RelationshipSchemaName("team_connectionreference")]
    public IEnumerable<connectionreference> team_connectionreference
    {
      get
      {
        return this.GetRelatedEntities<connectionreference>(nameof (team_connectionreference), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_connectionreference));
        this.SetRelatedEntities<connectionreference>(nameof (team_connectionreference), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_connectionreference));
      }
    }

    [RelationshipSchemaName("team_connections1")]
    public IEnumerable<Connection> team_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (team_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_connections1));
        this.SetRelatedEntities<Connection>(nameof (team_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_connections1));
      }
    }

    [RelationshipSchemaName("team_connections2")]
    public IEnumerable<Connection> team_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (team_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_connections2));
        this.SetRelatedEntities<Connection>(nameof (team_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_connections2));
      }
    }

    [RelationshipSchemaName("team_connector")]
    public IEnumerable<connector> team_connector
    {
      get => this.GetRelatedEntities<connector>(nameof (team_connector), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_connector));
        this.SetRelatedEntities<connector>(nameof (team_connector), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_connector));
      }
    }

    [RelationshipSchemaName("team_contacts")]
    public IEnumerable<Contact> team_contacts
    {
      get => this.GetRelatedEntities<Contact>(nameof (team_contacts), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_contacts));
        this.SetRelatedEntities<Contact>(nameof (team_contacts), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_contacts));
      }
    }

    [RelationshipSchemaName("team_conversationtranscript")]
    public IEnumerable<conversationtranscript> team_conversationtranscript
    {
      get
      {
        return this.GetRelatedEntities<conversationtranscript>(nameof (team_conversationtranscript), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_conversationtranscript));
        this.SetRelatedEntities<conversationtranscript>(nameof (team_conversationtranscript), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_conversationtranscript));
      }
    }

    [RelationshipSchemaName("team_convertrule")]
    public IEnumerable<ConvertRule> team_convertrule
    {
      get => this.GetRelatedEntities<ConvertRule>(nameof (team_convertrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_convertrule));
        this.SetRelatedEntities<ConvertRule>(nameof (team_convertrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_convertrule));
      }
    }

    [RelationshipSchemaName("team_customapi")]
    public IEnumerable<CustomAPI> team_customapi
    {
      get => this.GetRelatedEntities<CustomAPI>(nameof (team_customapi), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_customapi));
        this.SetRelatedEntities<CustomAPI>(nameof (team_customapi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_customapi));
      }
    }

    [RelationshipSchemaName("team_customer_relationship")]
    public IEnumerable<CustomerRelationship> team_customer_relationship
    {
      get
      {
        return this.GetRelatedEntities<CustomerRelationship>(nameof (team_customer_relationship), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_customer_relationship));
        this.SetRelatedEntities<CustomerRelationship>(nameof (team_customer_relationship), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_customer_relationship));
      }
    }

    [RelationshipSchemaName("team_datalakefolder")]
    public IEnumerable<datalakefolder> team_datalakefolder
    {
      get
      {
        return this.GetRelatedEntities<datalakefolder>(nameof (team_datalakefolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_datalakefolder));
        this.SetRelatedEntities<datalakefolder>(nameof (team_datalakefolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_datalakefolder));
      }
    }

    [RelationshipSchemaName("team_datalakefolderpermission")]
    public IEnumerable<datalakefolderpermission> team_datalakefolderpermission
    {
      get
      {
        return this.GetRelatedEntities<datalakefolderpermission>(nameof (team_datalakefolderpermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_datalakefolderpermission));
        this.SetRelatedEntities<datalakefolderpermission>(nameof (team_datalakefolderpermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_datalakefolderpermission));
      }
    }

    [RelationshipSchemaName("Team_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> Team_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Team_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Team_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Team_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("Team_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> Team_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (Team_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Team_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (Team_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("team_DuplicateRules")]
    public IEnumerable<DuplicateRule> team_DuplicateRules
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRule>(nameof (team_DuplicateRules), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_DuplicateRules));
        this.SetRelatedEntities<DuplicateRule>(nameof (team_DuplicateRules), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_DuplicateRules));
      }
    }

    [RelationshipSchemaName("team_email")]
    public IEnumerable<Email> team_email
    {
      get => this.GetRelatedEntities<Email>(nameof (team_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_email));
        this.SetRelatedEntities<Email>(nameof (team_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_email));
      }
    }

    [RelationshipSchemaName("team_email_templates")]
    public IEnumerable<Template> team_email_templates
    {
      get => this.GetRelatedEntities<Template>(nameof (team_email_templates), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_email_templates));
        this.SetRelatedEntities<Template>(nameof (team_email_templates), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_email_templates));
      }
    }

    [RelationshipSchemaName("team_emailserverprofile")]
    public IEnumerable<EmailServerProfile> team_emailserverprofile
    {
      get
      {
        return this.GetRelatedEntities<EmailServerProfile>(nameof (team_emailserverprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_emailserverprofile));
        this.SetRelatedEntities<EmailServerProfile>(nameof (team_emailserverprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_emailserverprofile));
      }
    }

    [RelationshipSchemaName("team_environmentvariabledefinition")]
    public IEnumerable<EnvironmentVariableDefinition> team_environmentvariabledefinition
    {
      get
      {
        return this.GetRelatedEntities<EnvironmentVariableDefinition>(nameof (team_environmentvariabledefinition), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_environmentvariabledefinition));
        this.SetRelatedEntities<EnvironmentVariableDefinition>(nameof (team_environmentvariabledefinition), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_environmentvariabledefinition));
      }
    }

    [RelationshipSchemaName("team_environmentvariablevalue")]
    public IEnumerable<EnvironmentVariableValue> team_environmentvariablevalue
    {
      get
      {
        return this.GetRelatedEntities<EnvironmentVariableValue>(nameof (team_environmentvariablevalue), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_environmentvariablevalue));
        this.SetRelatedEntities<EnvironmentVariableValue>(nameof (team_environmentvariablevalue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_environmentvariablevalue));
      }
    }

    [RelationshipSchemaName("team_exchangesyncidmapping")]
    public IEnumerable<ExchangeSyncIdMapping> team_exchangesyncidmapping
    {
      get
      {
        return this.GetRelatedEntities<ExchangeSyncIdMapping>(nameof (team_exchangesyncidmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_exchangesyncidmapping));
        this.SetRelatedEntities<ExchangeSyncIdMapping>(nameof (team_exchangesyncidmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_exchangesyncidmapping));
      }
    }

    [RelationshipSchemaName("team_exportsolutionupload")]
    public IEnumerable<ExportSolutionUpload> team_exportsolutionupload
    {
      get
      {
        return this.GetRelatedEntities<ExportSolutionUpload>(nameof (team_exportsolutionupload), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_exportsolutionupload));
        this.SetRelatedEntities<ExportSolutionUpload>(nameof (team_exportsolutionupload), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_exportsolutionupload));
      }
    }

    [RelationshipSchemaName("team_externalparty")]
    public IEnumerable<ExternalParty> team_externalparty
    {
      get => this.GetRelatedEntities<ExternalParty>(nameof (team_externalparty), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_externalparty));
        this.SetRelatedEntities<ExternalParty>(nameof (team_externalparty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_externalparty));
      }
    }

    [RelationshipSchemaName("team_fax")]
    public IEnumerable<Fax> team_fax
    {
      get => this.GetRelatedEntities<Fax>(nameof (team_fax), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_fax));
        this.SetRelatedEntities<Fax>(nameof (team_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_fax));
      }
    }

    [RelationshipSchemaName("team_flowsession")]
    public IEnumerable<flowsession> team_flowsession
    {
      get => this.GetRelatedEntities<flowsession>(nameof (team_flowsession), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_flowsession));
        this.SetRelatedEntities<flowsession>(nameof (team_flowsession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_flowsession));
      }
    }

    [RelationshipSchemaName("team_goal")]
    public IEnumerable<Goal> team_goal
    {
      get => this.GetRelatedEntities<Goal>(nameof (team_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_goal));
        this.SetRelatedEntities<Goal>(nameof (team_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_goal));
      }
    }

    [RelationshipSchemaName("team_goal_goalowner")]
    public IEnumerable<Goal> team_goal_goalowner
    {
      get => this.GetRelatedEntities<Goal>(nameof (team_goal_goalowner), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_goal_goalowner));
        this.SetRelatedEntities<Goal>(nameof (team_goal_goalowner), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_goal_goalowner));
      }
    }

    [RelationshipSchemaName("team_goalrollupquery")]
    public IEnumerable<GoalRollupQuery> team_goalrollupquery
    {
      get
      {
        return this.GetRelatedEntities<GoalRollupQuery>(nameof (team_goalrollupquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_goalrollupquery));
        this.SetRelatedEntities<GoalRollupQuery>(nameof (team_goalrollupquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_goalrollupquery));
      }
    }

    [RelationshipSchemaName("team_ImportFiles")]
    public IEnumerable<ImportFile> team_ImportFiles
    {
      get => this.GetRelatedEntities<ImportFile>(nameof (team_ImportFiles), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ImportFiles));
        this.SetRelatedEntities<ImportFile>(nameof (team_ImportFiles), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ImportFiles));
      }
    }

    [RelationshipSchemaName("team_ImportLogs")]
    public IEnumerable<ImportLog> team_ImportLogs
    {
      get => this.GetRelatedEntities<ImportLog>(nameof (team_ImportLogs), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ImportLogs));
        this.SetRelatedEntities<ImportLog>(nameof (team_ImportLogs), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ImportLogs));
      }
    }

    [RelationshipSchemaName("team_ImportMaps")]
    public IEnumerable<ImportMap> team_ImportMaps
    {
      get => this.GetRelatedEntities<ImportMap>(nameof (team_ImportMaps), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_ImportMaps));
        this.SetRelatedEntities<ImportMap>(nameof (team_ImportMaps), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_ImportMaps));
      }
    }

    [RelationshipSchemaName("team_Imports")]
    public IEnumerable<Import> team_Imports
    {
      get => this.GetRelatedEntities<Import>(nameof (team_Imports), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_Imports));
        this.SetRelatedEntities<Import>(nameof (team_Imports), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_Imports));
      }
    }

    [RelationshipSchemaName("team_interactionforemail")]
    public IEnumerable<InteractionForEmail> team_interactionforemail
    {
      get
      {
        return this.GetRelatedEntities<InteractionForEmail>(nameof (team_interactionforemail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_interactionforemail));
        this.SetRelatedEntities<InteractionForEmail>(nameof (team_interactionforemail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_interactionforemail));
      }
    }

    [RelationshipSchemaName("team_knowledgearticle")]
    public IEnumerable<KnowledgeArticle> team_knowledgearticle
    {
      get
      {
        return this.GetRelatedEntities<KnowledgeArticle>(nameof (team_knowledgearticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_knowledgearticle));
        this.SetRelatedEntities<KnowledgeArticle>(nameof (team_knowledgearticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_knowledgearticle));
      }
    }

    [RelationshipSchemaName("team_letter")]
    public IEnumerable<Letter> team_letter
    {
      get => this.GetRelatedEntities<Letter>(nameof (team_letter), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_letter));
        this.SetRelatedEntities<Letter>(nameof (team_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_letter));
      }
    }

    [RelationshipSchemaName("team_mailbox")]
    public IEnumerable<Mailbox> team_mailbox
    {
      get => this.GetRelatedEntities<Mailbox>(nameof (team_mailbox), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_mailbox));
        this.SetRelatedEntities<Mailbox>(nameof (team_mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_mailbox));
      }
    }

    [RelationshipSchemaName("team_mailboxtrackingcategory")]
    public IEnumerable<MailboxTrackingCategory> team_mailboxtrackingcategory
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingCategory>(nameof (team_mailboxtrackingcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_mailboxtrackingcategory));
        this.SetRelatedEntities<MailboxTrackingCategory>(nameof (team_mailboxtrackingcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_mailboxtrackingcategory));
      }
    }

    [RelationshipSchemaName("team_mailboxtrackingfolder")]
    public IEnumerable<MailboxTrackingFolder> team_mailboxtrackingfolder
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (team_mailboxtrackingfolder), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_mailboxtrackingfolder));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (team_mailboxtrackingfolder), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_mailboxtrackingfolder));
      }
    }

    [RelationshipSchemaName("team_msdyn_aibdataset")]
    public IEnumerable<msdyn_AIBDataset> team_msdyn_aibdataset
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDataset>(nameof (team_msdyn_aibdataset), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aibdataset));
        this.SetRelatedEntities<msdyn_AIBDataset>(nameof (team_msdyn_aibdataset), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aibdataset));
      }
    }

    [RelationshipSchemaName("team_msdyn_aibdatasetfile")]
    public IEnumerable<msdyn_AIBDatasetFile> team_msdyn_aibdatasetfile
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDatasetFile>(nameof (team_msdyn_aibdatasetfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aibdatasetfile));
        this.SetRelatedEntities<msdyn_AIBDatasetFile>(nameof (team_msdyn_aibdatasetfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aibdatasetfile));
      }
    }

    [RelationshipSchemaName("team_msdyn_aibdatasetrecord")]
    public IEnumerable<msdyn_AIBDatasetRecord> team_msdyn_aibdatasetrecord
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDatasetRecord>(nameof (team_msdyn_aibdatasetrecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aibdatasetrecord));
        this.SetRelatedEntities<msdyn_AIBDatasetRecord>(nameof (team_msdyn_aibdatasetrecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aibdatasetrecord));
      }
    }

    [RelationshipSchemaName("team_msdyn_aibdatasetscontainer")]
    public IEnumerable<msdyn_AIBDatasetsContainer> team_msdyn_aibdatasetscontainer
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBDatasetsContainer>(nameof (team_msdyn_aibdatasetscontainer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aibdatasetscontainer));
        this.SetRelatedEntities<msdyn_AIBDatasetsContainer>(nameof (team_msdyn_aibdatasetscontainer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aibdatasetscontainer));
      }
    }

    [RelationshipSchemaName("team_msdyn_aibfile")]
    public IEnumerable<msdyn_AIBFile> team_msdyn_aibfile
    {
      get => this.GetRelatedEntities<msdyn_AIBFile>(nameof (team_msdyn_aibfile), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aibfile));
        this.SetRelatedEntities<msdyn_AIBFile>(nameof (team_msdyn_aibfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aibfile));
      }
    }

    [RelationshipSchemaName("team_msdyn_aibfileattacheddata")]
    public IEnumerable<msdyn_AIBFileAttachedData> team_msdyn_aibfileattacheddata
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIBFileAttachedData>(nameof (team_msdyn_aibfileattacheddata), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aibfileattacheddata));
        this.SetRelatedEntities<msdyn_AIBFileAttachedData>(nameof (team_msdyn_aibfileattacheddata), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aibfileattacheddata));
      }
    }

    [RelationshipSchemaName("team_msdyn_aiconfiguration")]
    public IEnumerable<msdyn_AIConfiguration> team_msdyn_aiconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIConfiguration>(nameof (team_msdyn_aiconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aiconfiguration));
        this.SetRelatedEntities<msdyn_AIConfiguration>(nameof (team_msdyn_aiconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aiconfiguration));
      }
    }

    [RelationshipSchemaName("team_msdyn_aifptrainingdocument")]
    public IEnumerable<msdyn_AIFpTrainingDocument> team_msdyn_aifptrainingdocument
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIFpTrainingDocument>(nameof (team_msdyn_aifptrainingdocument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aifptrainingdocument));
        this.SetRelatedEntities<msdyn_AIFpTrainingDocument>(nameof (team_msdyn_aifptrainingdocument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aifptrainingdocument));
      }
    }

    [RelationshipSchemaName("team_msdyn_aimodel")]
    public IEnumerable<msdyn_AIModel> team_msdyn_aimodel
    {
      get => this.GetRelatedEntities<msdyn_AIModel>(nameof (team_msdyn_aimodel), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aimodel));
        this.SetRelatedEntities<msdyn_AIModel>(nameof (team_msdyn_aimodel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aimodel));
      }
    }

    [RelationshipSchemaName("team_msdyn_aiodimage")]
    public IEnumerable<msdyn_AIOdImage> team_msdyn_aiodimage
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdImage>(nameof (team_msdyn_aiodimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aiodimage));
        this.SetRelatedEntities<msdyn_AIOdImage>(nameof (team_msdyn_aiodimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aiodimage));
      }
    }

    [RelationshipSchemaName("team_msdyn_aiodlabel")]
    public IEnumerable<msdyn_AIOdLabel> team_msdyn_aiodlabel
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdLabel>(nameof (team_msdyn_aiodlabel), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aiodlabel));
        this.SetRelatedEntities<msdyn_AIOdLabel>(nameof (team_msdyn_aiodlabel), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aiodlabel));
      }
    }

    [RelationshipSchemaName("team_msdyn_aiodtrainingboundingbox")]
    public IEnumerable<msdyn_AIOdTrainingBoundingBox> team_msdyn_aiodtrainingboundingbox
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdTrainingBoundingBox>(nameof (team_msdyn_aiodtrainingboundingbox), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aiodtrainingboundingbox));
        this.SetRelatedEntities<msdyn_AIOdTrainingBoundingBox>(nameof (team_msdyn_aiodtrainingboundingbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aiodtrainingboundingbox));
      }
    }

    [RelationshipSchemaName("team_msdyn_aiodtrainingimage")]
    public IEnumerable<msdyn_AIOdTrainingImage> team_msdyn_aiodtrainingimage
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AIOdTrainingImage>(nameof (team_msdyn_aiodtrainingimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aiodtrainingimage));
        this.SetRelatedEntities<msdyn_AIOdTrainingImage>(nameof (team_msdyn_aiodtrainingimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aiodtrainingimage));
      }
    }

    [RelationshipSchemaName("team_msdyn_aitemplate")]
    public IEnumerable<msdyn_AITemplate> team_msdyn_aitemplate
    {
      get
      {
        return this.GetRelatedEntities<msdyn_AITemplate>(nameof (team_msdyn_aitemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_aitemplate));
        this.SetRelatedEntities<msdyn_AITemplate>(nameof (team_msdyn_aitemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_aitemplate));
      }
    }

    [RelationshipSchemaName("team_msdyn_analysiscomponent")]
    public IEnumerable<msdyn_analysiscomponent> team_msdyn_analysiscomponent
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysiscomponent>(nameof (team_msdyn_analysiscomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_analysiscomponent));
        this.SetRelatedEntities<msdyn_analysiscomponent>(nameof (team_msdyn_analysiscomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_analysiscomponent));
      }
    }

    [RelationshipSchemaName("team_msdyn_analysisjob")]
    public IEnumerable<msdyn_analysisjob> team_msdyn_analysisjob
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisjob>(nameof (team_msdyn_analysisjob), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_analysisjob));
        this.SetRelatedEntities<msdyn_analysisjob>(nameof (team_msdyn_analysisjob), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_analysisjob));
      }
    }

    [RelationshipSchemaName("team_msdyn_analysisresult")]
    public IEnumerable<msdyn_analysisresult> team_msdyn_analysisresult
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisresult>(nameof (team_msdyn_analysisresult), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_analysisresult));
        this.SetRelatedEntities<msdyn_analysisresult>(nameof (team_msdyn_analysisresult), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_analysisresult));
      }
    }

    [RelationshipSchemaName("team_msdyn_analysisresultdetail")]
    public IEnumerable<msdyn_analysisresultdetail> team_msdyn_analysisresultdetail
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisresultdetail>(nameof (team_msdyn_analysisresultdetail), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_analysisresultdetail));
        this.SetRelatedEntities<msdyn_analysisresultdetail>(nameof (team_msdyn_analysisresultdetail), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_analysisresultdetail));
      }
    }

    [RelationshipSchemaName("team_msdyn_dataflow")]
    public IEnumerable<msdyn_dataflow> team_msdyn_dataflow
    {
      get
      {
        return this.GetRelatedEntities<msdyn_dataflow>(nameof (team_msdyn_dataflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_dataflow));
        this.SetRelatedEntities<msdyn_dataflow>(nameof (team_msdyn_dataflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_dataflow));
      }
    }

    [RelationshipSchemaName("team_msdyn_federatedarticle")]
    public IEnumerable<msdyn_federatedarticle> team_msdyn_federatedarticle
    {
      get
      {
        return this.GetRelatedEntities<msdyn_federatedarticle>(nameof (team_msdyn_federatedarticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_federatedarticle));
        this.SetRelatedEntities<msdyn_federatedarticle>(nameof (team_msdyn_federatedarticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_federatedarticle));
      }
    }

    [RelationshipSchemaName("team_msdyn_kmfederatedsearchconfig")]
    public IEnumerable<msdyn_kmfederatedsearchconfig> team_msdyn_kmfederatedsearchconfig
    {
      get
      {
        return this.GetRelatedEntities<msdyn_kmfederatedsearchconfig>(nameof (team_msdyn_kmfederatedsearchconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_kmfederatedsearchconfig));
        this.SetRelatedEntities<msdyn_kmfederatedsearchconfig>(nameof (team_msdyn_kmfederatedsearchconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_kmfederatedsearchconfig));
      }
    }

    [RelationshipSchemaName("team_msdyn_knowledgearticleimage")]
    public IEnumerable<msdyn_knowledgearticleimage> team_msdyn_knowledgearticleimage
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgearticleimage>(nameof (team_msdyn_knowledgearticleimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_knowledgearticleimage));
        this.SetRelatedEntities<msdyn_knowledgearticleimage>(nameof (team_msdyn_knowledgearticleimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_knowledgearticleimage));
      }
    }

    [RelationshipSchemaName("team_msdyn_knowledgearticletemplate")]
    public IEnumerable<msdyn_knowledgearticletemplate> team_msdyn_knowledgearticletemplate
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgearticletemplate>(nameof (team_msdyn_knowledgearticletemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_knowledgearticletemplate));
        this.SetRelatedEntities<msdyn_knowledgearticletemplate>(nameof (team_msdyn_knowledgearticletemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_knowledgearticletemplate));
      }
    }

    [RelationshipSchemaName("team_msdyn_knowledgeinteractioninsight")]
    public IEnumerable<msdyn_knowledgeinteractioninsight> team_msdyn_knowledgeinteractioninsight
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgeinteractioninsight>(nameof (team_msdyn_knowledgeinteractioninsight), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_knowledgeinteractioninsight));
        this.SetRelatedEntities<msdyn_knowledgeinteractioninsight>(nameof (team_msdyn_knowledgeinteractioninsight), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_knowledgeinteractioninsight));
      }
    }

    [RelationshipSchemaName("team_msdyn_knowledgesearchinsight")]
    public IEnumerable<msdyn_knowledgesearchinsight> team_msdyn_knowledgesearchinsight
    {
      get
      {
        return this.GetRelatedEntities<msdyn_knowledgesearchinsight>(nameof (team_msdyn_knowledgesearchinsight), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_knowledgesearchinsight));
        this.SetRelatedEntities<msdyn_knowledgesearchinsight>(nameof (team_msdyn_knowledgesearchinsight), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_knowledgesearchinsight));
      }
    }

    [RelationshipSchemaName("team_msdyn_richtextfile")]
    public IEnumerable<msdyn_richtextfile> team_msdyn_richtextfile
    {
      get
      {
        return this.GetRelatedEntities<msdyn_richtextfile>(nameof (team_msdyn_richtextfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_richtextfile));
        this.SetRelatedEntities<msdyn_richtextfile>(nameof (team_msdyn_richtextfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_richtextfile));
      }
    }

    [RelationshipSchemaName("team_msdyn_serviceconfiguration")]
    public IEnumerable<msdyn_serviceconfiguration> team_msdyn_serviceconfiguration
    {
      get
      {
        return this.GetRelatedEntities<msdyn_serviceconfiguration>(nameof (team_msdyn_serviceconfiguration), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_serviceconfiguration));
        this.SetRelatedEntities<msdyn_serviceconfiguration>(nameof (team_msdyn_serviceconfiguration), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_serviceconfiguration));
      }
    }

    [RelationshipSchemaName("team_msdyn_slakpi")]
    public IEnumerable<msdyn_slakpi> team_msdyn_slakpi
    {
      get => this.GetRelatedEntities<msdyn_slakpi>(nameof (team_msdyn_slakpi), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_slakpi));
        this.SetRelatedEntities<msdyn_slakpi>(nameof (team_msdyn_slakpi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_slakpi));
      }
    }

    [RelationshipSchemaName("team_msdyn_solutionhealthrule")]
    public IEnumerable<msdyn_solutionhealthrule> team_msdyn_solutionhealthrule
    {
      get
      {
        return this.GetRelatedEntities<msdyn_solutionhealthrule>(nameof (team_msdyn_solutionhealthrule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_solutionhealthrule));
        this.SetRelatedEntities<msdyn_solutionhealthrule>(nameof (team_msdyn_solutionhealthrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_solutionhealthrule));
      }
    }

    [RelationshipSchemaName("team_msdyn_solutionhealthruleargument")]
    public IEnumerable<msdyn_solutionhealthruleargument> team_msdyn_solutionhealthruleargument
    {
      get
      {
        return this.GetRelatedEntities<msdyn_solutionhealthruleargument>(nameof (team_msdyn_solutionhealthruleargument), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdyn_solutionhealthruleargument));
        this.SetRelatedEntities<msdyn_solutionhealthruleargument>(nameof (team_msdyn_solutionhealthruleargument), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdyn_solutionhealthruleargument));
      }
    }

    [RelationshipSchemaName("team_msdynce_botcontent")]
    public IEnumerable<msdynce_botcontent> team_msdynce_botcontent
    {
      get
      {
        return this.GetRelatedEntities<msdynce_botcontent>(nameof (team_msdynce_botcontent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_msdynce_botcontent));
        this.SetRelatedEntities<msdynce_botcontent>(nameof (team_msdynce_botcontent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_msdynce_botcontent));
      }
    }

    [RelationshipSchemaName("team_pdfsetting")]
    public IEnumerable<PDFSetting> team_pdfsetting
    {
      get => this.GetRelatedEntities<PDFSetting>(nameof (team_pdfsetting), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_pdfsetting));
        this.SetRelatedEntities<PDFSetting>(nameof (team_pdfsetting), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_pdfsetting));
      }
    }

    [RelationshipSchemaName("team_phonecall")]
    public IEnumerable<PhoneCall> team_phonecall
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (team_phonecall), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_phonecall));
        this.SetRelatedEntities<PhoneCall>(nameof (team_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_phonecall));
      }
    }

    [RelationshipSchemaName("team_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> team_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (team_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (team_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("team_principalobjectattributeaccess_principalid")]
    public IEnumerable<PrincipalObjectAttributeAccess> team_principalobjectattributeaccess_principalid
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (team_principalobjectattributeaccess_principalid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_principalobjectattributeaccess_principalid));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (team_principalobjectattributeaccess_principalid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_principalobjectattributeaccess_principalid));
      }
    }

    [RelationshipSchemaName("team_processsession")]
    public IEnumerable<ProcessSession> team_processsession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (team_processsession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_processsession));
        this.SetRelatedEntities<ProcessSession>(nameof (team_processsession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_processsession));
      }
    }

    [RelationshipSchemaName("Team_ProcessSessions")]
    public IEnumerable<ProcessSession> Team_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Team_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Team_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Team_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_ProcessSessions));
      }
    }

    [RelationshipSchemaName("team_processstageparameter")]
    public IEnumerable<processstageparameter> team_processstageparameter
    {
      get
      {
        return this.GetRelatedEntities<processstageparameter>(nameof (team_processstageparameter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_processstageparameter));
        this.SetRelatedEntities<processstageparameter>(nameof (team_processstageparameter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_processstageparameter));
      }
    }

    [RelationshipSchemaName("team_profilerule")]
    public IEnumerable<ChannelAccessProfileRule> team_profilerule
    {
      get
      {
        return this.GetRelatedEntities<ChannelAccessProfileRule>(nameof (team_profilerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_profilerule));
        this.SetRelatedEntities<ChannelAccessProfileRule>(nameof (team_profilerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_profilerule));
      }
    }

    [RelationshipSchemaName("team_queueitembase_workerid")]
    public IEnumerable<QueueItem> team_queueitembase_workerid
    {
      get
      {
        return this.GetRelatedEntities<QueueItem>(nameof (team_queueitembase_workerid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_queueitembase_workerid));
        this.SetRelatedEntities<QueueItem>(nameof (team_queueitembase_workerid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_queueitembase_workerid));
      }
    }

    [RelationshipSchemaName("team_recurringappointmentmaster")]
    public IEnumerable<RecurringAppointmentMaster> team_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (team_recurringappointmentmaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_recurringappointmentmaster));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (team_recurringappointmentmaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_recurringappointmentmaster));
      }
    }

    [RelationshipSchemaName("team_revokeinheritedaccessrecordstracker")]
    public IEnumerable<revokeinheritedaccessrecordstracker> team_revokeinheritedaccessrecordstracker
    {
      get
      {
        return this.GetRelatedEntities<revokeinheritedaccessrecordstracker>(nameof (team_revokeinheritedaccessrecordstracker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_revokeinheritedaccessrecordstracker));
        this.SetRelatedEntities<revokeinheritedaccessrecordstracker>(nameof (team_revokeinheritedaccessrecordstracker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_revokeinheritedaccessrecordstracker));
      }
    }

    [RelationshipSchemaName("team_routingrule")]
    public IEnumerable<RoutingRule> team_routingrule
    {
      get => this.GetRelatedEntities<RoutingRule>(nameof (team_routingrule), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_routingrule));
        this.SetRelatedEntities<RoutingRule>(nameof (team_routingrule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_routingrule));
      }
    }

    [RelationshipSchemaName("team_routingruleitem")]
    public IEnumerable<RoutingRuleItem> team_routingruleitem
    {
      get
      {
        return this.GetRelatedEntities<RoutingRuleItem>(nameof (team_routingruleitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_routingruleitem));
        this.SetRelatedEntities<RoutingRuleItem>(nameof (team_routingruleitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_routingruleitem));
      }
    }

    [RelationshipSchemaName("team_sharepointdocumentlocation")]
    public IEnumerable<SharePointDocumentLocation> team_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (team_sharepointdocumentlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_sharepointdocumentlocation));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (team_sharepointdocumentlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_sharepointdocumentlocation));
      }
    }

    [RelationshipSchemaName("team_sharepointsite")]
    public IEnumerable<SharePointSite> team_sharepointsite
    {
      get
      {
        return this.GetRelatedEntities<SharePointSite>(nameof (team_sharepointsite), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_sharepointsite));
        this.SetRelatedEntities<SharePointSite>(nameof (team_sharepointsite), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_sharepointsite));
      }
    }

    [RelationshipSchemaName("team_slaBase")]
    public IEnumerable<SLA> team_slaBase
    {
      get => this.GetRelatedEntities<SLA>(nameof (team_slaBase), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_slaBase));
        this.SetRelatedEntities<SLA>(nameof (team_slaBase), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_slaBase));
      }
    }

    [RelationshipSchemaName("team_socialactivity")]
    public IEnumerable<SocialActivity> team_socialactivity
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (team_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_socialactivity));
        this.SetRelatedEntities<SocialActivity>(nameof (team_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_socialactivity));
      }
    }

    [RelationshipSchemaName("team_stagesolutionupload")]
    public IEnumerable<StageSolutionUpload> team_stagesolutionupload
    {
      get
      {
        return this.GetRelatedEntities<StageSolutionUpload>(nameof (team_stagesolutionupload), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_stagesolutionupload));
        this.SetRelatedEntities<StageSolutionUpload>(nameof (team_stagesolutionupload), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_stagesolutionupload));
      }
    }

    [RelationshipSchemaName("team_SyncError")]
    public IEnumerable<SyncError> team_SyncError
    {
      get => this.GetRelatedEntities<SyncError>(nameof (team_SyncError), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_SyncError));
        this.SetRelatedEntities<SyncError>(nameof (team_SyncError), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_SyncError));
      }
    }

    [RelationshipSchemaName("Team_SyncErrors")]
    public IEnumerable<SyncError> Team_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Team_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Team_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Team_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Team_SyncErrors));
      }
    }

    [RelationshipSchemaName("team_task")]
    public IEnumerable<Task> team_task
    {
      get => this.GetRelatedEntities<Task>(nameof (team_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_task));
        this.SetRelatedEntities<Task>(nameof (team_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_task));
      }
    }

    [RelationshipSchemaName("team_userentityinstancedata")]
    public IEnumerable<UserEntityInstanceData> team_userentityinstancedata
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (team_userentityinstancedata), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_userentityinstancedata));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (team_userentityinstancedata), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_userentityinstancedata));
      }
    }

    [RelationshipSchemaName("team_userentityuisettings")]
    public IEnumerable<UserEntityUISettings> team_userentityuisettings
    {
      get
      {
        return this.GetRelatedEntities<UserEntityUISettings>(nameof (team_userentityuisettings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_userentityuisettings));
        this.SetRelatedEntities<UserEntityUISettings>(nameof (team_userentityuisettings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_userentityuisettings));
      }
    }

    [RelationshipSchemaName("team_userform")]
    public IEnumerable<UserForm> team_userform
    {
      get => this.GetRelatedEntities<UserForm>(nameof (team_userform), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_userform));
        this.SetRelatedEntities<UserForm>(nameof (team_userform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_userform));
      }
    }

    [RelationshipSchemaName("team_userquery")]
    public IEnumerable<UserQuery> team_userquery
    {
      get => this.GetRelatedEntities<UserQuery>(nameof (team_userquery), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_userquery));
        this.SetRelatedEntities<UserQuery>(nameof (team_userquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_userquery));
      }
    }

    [RelationshipSchemaName("team_userqueryvisualizations")]
    public IEnumerable<UserQueryVisualization> team_userqueryvisualizations
    {
      get
      {
        return this.GetRelatedEntities<UserQueryVisualization>(nameof (team_userqueryvisualizations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_userqueryvisualizations));
        this.SetRelatedEntities<UserQueryVisualization>(nameof (team_userqueryvisualizations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_userqueryvisualizations));
      }
    }

    [RelationshipSchemaName("team_workflow")]
    public IEnumerable<Workflow> team_workflow
    {
      get => this.GetRelatedEntities<Workflow>(nameof (team_workflow), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_workflow));
        this.SetRelatedEntities<Workflow>(nameof (team_workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_workflow));
      }
    }

    [RelationshipSchemaName("team_workflowbinary")]
    public IEnumerable<workflowbinary> team_workflowbinary
    {
      get
      {
        return this.GetRelatedEntities<workflowbinary>(nameof (team_workflowbinary), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_workflowbinary));
        this.SetRelatedEntities<workflowbinary>(nameof (team_workflowbinary), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_workflowbinary));
      }
    }

    [RelationshipSchemaName("team_workflowlog")]
    public IEnumerable<WorkflowLog> team_workflowlog
    {
      get => this.GetRelatedEntities<WorkflowLog>(nameof (team_workflowlog), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (team_workflowlog));
        this.SetRelatedEntities<WorkflowLog>(nameof (team_workflowlog), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_workflowlog));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_team")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_team
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_team), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_team));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_team), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_team));
      }
    }

    [RelationshipSchemaName("teammembership_association")]
    public IEnumerable<SystemUser> teammembership_association
    {
      get
      {
        return this.GetRelatedEntities<SystemUser>(nameof (teammembership_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (teammembership_association));
        this.SetRelatedEntities<SystemUser>(nameof (teammembership_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teammembership_association));
      }
    }

    [RelationshipSchemaName("teamprofiles_association")]
    public IEnumerable<FieldSecurityProfile> teamprofiles_association
    {
      get
      {
        return this.GetRelatedEntities<FieldSecurityProfile>(nameof (teamprofiles_association), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (teamprofiles_association));
        this.SetRelatedEntities<FieldSecurityProfile>(nameof (teamprofiles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teamprofiles_association));
      }
    }

    [RelationshipSchemaName("teamroles_association")]
    public IEnumerable<Role> teamroles_association
    {
      get => this.GetRelatedEntities<Role>(nameof (teamroles_association), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (teamroles_association));
        this.SetRelatedEntities<Role>(nameof (teamroles_association), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teamroles_association));
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_teams")]
    public BusinessUnit business_unit_teams
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (business_unit_teams));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_teams));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("knowledgearticle_Teams")]
    public KnowledgeArticle knowledgearticle_Teams
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_Teams), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_Teams));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_Teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_Teams));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_team_createdonbehalfby")]
    public SystemUser lk_team_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_team_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_team_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_team_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_team_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_team_modifiedonbehalfby")]
    public SystemUser lk_team_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_team_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_team_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_team_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_team_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("administratorid")]
    [RelationshipSchemaName("lk_teambase_administratorid")]
    public SystemUser lk_teambase_administratorid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_teambase_administratorid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_teambase_administratorid));
        this.SetRelatedEntity<SystemUser>(nameof (lk_teambase_administratorid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_teambase_administratorid));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_teambase_createdby")]
    public SystemUser lk_teambase_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_teambase_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_teambase_modifiedby")]
    public SystemUser lk_teambase_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_teambase_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_teams")]
    public Organization organization_teams
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_teams), new EntityRole?());
    }

    [AttributeLogicalName("stageid")]
    [RelationshipSchemaName("processstage_teams")]
    public ProcessStage processstage_teams
    {
      get => this.GetRelatedEntity<ProcessStage>(nameof (processstage_teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (processstage_teams));
        this.SetRelatedEntity<ProcessStage>(nameof (processstage_teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstage_teams));
      }
    }

    [AttributeLogicalName("queueid")]
    [RelationshipSchemaName("queue_team")]
    public Queue queue_team
    {
      get => this.GetRelatedEntity<Queue>(nameof (queue_team), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (queue_team));
        this.SetRelatedEntity<Queue>(nameof (queue_team), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_team));
      }
    }

    [AttributeLogicalName("teamtemplateid")]
    [RelationshipSchemaName("teamtemplate_Teams")]
    public TeamTemplate teamtemplate_Teams
    {
      get => this.GetRelatedEntity<TeamTemplate>(nameof (teamtemplate_Teams), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (teamtemplate_Teams));
        this.SetRelatedEntity<TeamTemplate>(nameof (teamtemplate_Teams), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (teamtemplate_Teams));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_Team")]
    public TransactionCurrency TransactionCurrency_Team
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Team), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_Team));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_Team), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_Team));
      }
    }

    public Team(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["teamid"] = (object) base.Id;
            break;
          case "teamid":
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
