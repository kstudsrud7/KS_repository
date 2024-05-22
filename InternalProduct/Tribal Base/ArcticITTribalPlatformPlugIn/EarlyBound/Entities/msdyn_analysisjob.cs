// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_analysisjob
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_analysisjob")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_analysisjob : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_analysisjob";
    public const string EntitySchemaName = "msdyn_analysisjob";
    public const string PrimaryIdAttribute = "msdyn_analysisjobid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_analysisjob()
      : base(nameof (msdyn_analysisjob))
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

    [AttributeLogicalName("msdyn_analysisjobid")]
    public Guid? msdyn_analysisjobId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_analysisjobid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjobId));
        this.SetAttributeValue("msdyn_analysisjobid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_analysisjobId));
      }
    }

    [AttributeLogicalName("msdyn_analysisjobid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_analysisjobId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_customdetails")]
    public string msdyn_CustomDetails
    {
      get => this.GetAttributeValue<string>("msdyn_customdetails");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_CustomDetails));
        this.SetAttributeValue("msdyn_customdetails", (object) value);
        this.OnPropertyChanged(nameof (msdyn_CustomDetails));
      }
    }

    [AttributeLogicalName("msdyn_displaystatus")]
    public string msdyn_DisplayStatus
    {
      get => this.GetAttributeValue<string>("msdyn_displaystatus");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_DisplayStatus));
        this.SetAttributeValue("msdyn_displaystatus", (object) value);
        this.OnPropertyChanged(nameof (msdyn_DisplayStatus));
      }
    }

    [AttributeLogicalName("msdyn_endtime")]
    public DateTime? msdyn_EndTime
    {
      get => this.GetAttributeValue<DateTime?>("msdyn_endtime");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_EndTime));
        this.SetAttributeValue("msdyn_endtime", (object) value);
        this.OnPropertyChanged(nameof (msdyn_EndTime));
      }
    }

    [AttributeLogicalName("msdyn_errorcount")]
    public int? msdyn_ErrorCount
    {
      get => this.GetAttributeValue<int?>("msdyn_errorcount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ErrorCount));
        this.SetAttributeValue("msdyn_errorcount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ErrorCount));
      }
    }

    [AttributeLogicalName("msdyn_exception")]
    public string msdyn_Exception
    {
      get => this.GetAttributeValue<string>("msdyn_exception");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Exception));
        this.SetAttributeValue("msdyn_exception", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Exception));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_name));
        this.SetAttributeValue(nameof (msdyn_name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_name));
      }
    }

    [AttributeLogicalName("msdyn_rulefailcount")]
    public int? msdyn_RuleFailCount
    {
      get => this.GetAttributeValue<int?>("msdyn_rulefailcount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RuleFailCount));
        this.SetAttributeValue("msdyn_rulefailcount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RuleFailCount));
      }
    }

    [AttributeLogicalName("msdyn_rulepasscount")]
    public int? msdyn_RulePassCount
    {
      get => this.GetAttributeValue<int?>("msdyn_rulepasscount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RulePassCount));
        this.SetAttributeValue("msdyn_rulepasscount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RulePassCount));
      }
    }

    [AttributeLogicalName("msdyn_ruleruncount")]
    public int? msdyn_RuleRunCount
    {
      get => this.GetAttributeValue<int?>("msdyn_ruleruncount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RuleRunCount));
        this.SetAttributeValue("msdyn_ruleruncount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RuleRunCount));
      }
    }

    [AttributeLogicalName("msdyn_runcorrelationid")]
    public string msdyn_RunCorrelationId
    {
      get => this.GetAttributeValue<string>("msdyn_runcorrelationid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_RunCorrelationId));
        this.SetAttributeValue("msdyn_runcorrelationid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_RunCorrelationId));
      }
    }

    [AttributeLogicalName("msdyn_sevcriticalcount")]
    public int? msdyn_sevcriticalcount
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_sevcriticalcount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sevcriticalcount));
        this.SetAttributeValue(nameof (msdyn_sevcriticalcount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sevcriticalcount));
      }
    }

    [AttributeLogicalName("msdyn_sevhighcount")]
    public int? msdyn_sevhighcount
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_sevhighcount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sevhighcount));
        this.SetAttributeValue(nameof (msdyn_sevhighcount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sevhighcount));
      }
    }

    [AttributeLogicalName("msdyn_sevlowcount")]
    public int? msdyn_sevlowcount
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_sevlowcount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sevlowcount));
        this.SetAttributeValue(nameof (msdyn_sevlowcount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sevlowcount));
      }
    }

    [AttributeLogicalName("msdyn_sevmediumcount")]
    public int? msdyn_sevmediumcount
    {
      get => this.GetAttributeValue<int?>(nameof (msdyn_sevmediumcount));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sevmediumcount));
        this.SetAttributeValue(nameof (msdyn_sevmediumcount), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sevmediumcount));
      }
    }

    [AttributeLogicalName("msdyn_starttime")]
    public DateTime? msdyn_StartTime
    {
      get => this.GetAttributeValue<DateTime?>("msdyn_starttime");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_StartTime));
        this.SetAttributeValue("msdyn_starttime", (object) value);
        this.OnPropertyChanged(nameof (msdyn_StartTime));
      }
    }

    [AttributeLogicalName("msdyn_tenantid")]
    public string msdyn_TenantId
    {
      get => this.GetAttributeValue<string>("msdyn_tenantid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_TenantId));
        this.SetAttributeValue("msdyn_tenantid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_TenantId));
      }
    }

    [AttributeLogicalName("msdyn_warningcount")]
    public int? msdyn_WarningCount
    {
      get => this.GetAttributeValue<int?>("msdyn_warningcount");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_WarningCount));
        this.SetAttributeValue("msdyn_warningcount", (object) value);
        this.OnPropertyChanged(nameof (msdyn_WarningCount));
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

    [AttributeLogicalName("statecode")]
    public msdyn_analysisjobState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_analysisjobState?((msdyn_analysisjobState) Enum.ToObject(typeof (msdyn_analysisjobState), attributeValue.Value)) : new msdyn_analysisjobState?();
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

    [RelationshipSchemaName("msdyn_analysisjob_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_analysisjob_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_analysisjob_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_analysisjob_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_analysisjob_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_analysisjob_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_analysisjob_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_analysisjob_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisjob_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisjob_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_analysisjob_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisjob_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_analysisjob_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_analysisjob_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_analysisjob_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_analysisjob_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_msdyn_analysiscomponent")]
    public IEnumerable<msdyn_analysiscomponent> msdyn_analysisjob_msdyn_analysiscomponent
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysiscomponent>(nameof (msdyn_analysisjob_msdyn_analysiscomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_msdyn_analysiscomponent));
        this.SetRelatedEntities<msdyn_analysiscomponent>(nameof (msdyn_analysisjob_msdyn_analysiscomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_msdyn_analysiscomponent));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_msdyn_analysisresult")]
    public IEnumerable<msdyn_analysisresult> msdyn_analysisjob_msdyn_analysisresult
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysisresult>(nameof (msdyn_analysisjob_msdyn_analysisresult), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_msdyn_analysisresult));
        this.SetRelatedEntities<msdyn_analysisresult>(nameof (msdyn_analysisjob_msdyn_analysisresult), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_msdyn_analysisresult));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_analysisjob_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_analysisjob_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_analysisjob_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_analysisjob_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_analysisjob_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_analysisjob_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_SyncErrors")]
    public IEnumerable<SyncError> msdyn_analysisjob_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_analysisjob_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_analysisjob_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_analysisjob_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_analysisjob_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_analysisjob_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_analysisjob_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_analysisjob")]
    public BusinessUnit business_unit_msdyn_analysisjob
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_analysisjob), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_analysisjob_createdby")]
    public SystemUser lk_msdyn_analysisjob_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisjob_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_analysisjob_createdonbehalfby")]
    public SystemUser lk_msdyn_analysisjob_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisjob_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_analysisjob_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisjob_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_analysisjob_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_analysisjob_modifiedby")]
    public SystemUser lk_msdyn_analysisjob_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisjob_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_analysisjob_modifiedonbehalfby")]
    public SystemUser lk_msdyn_analysisjob_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisjob_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_analysisjob_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_analysisjob_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_analysisjob_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_analysisjob")]
    public Team team_msdyn_analysisjob
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_analysisjob), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_analysisjob")]
    public SystemUser user_msdyn_analysisjob
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_analysisjob), new EntityRole?());
    }

    public msdyn_analysisjob(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_analysisjobid"] = (object) base.Id;
            break;
          case "msdyn_analysisjobid":
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
