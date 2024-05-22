// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_solutionhealthrule
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_solutionhealthrule")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_solutionhealthrule : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_solutionhealthrule";
    public const string EntitySchemaName = "msdyn_solutionhealthrule";
    public const string PrimaryIdAttribute = "msdyn_solutionhealthruleid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_solutionhealthrule()
      : base(nameof (msdyn_solutionhealthrule))
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

    [AttributeLogicalName("msdyn_description")]
    public string msdyn_Description
    {
      get => this.GetAttributeValue<string>("msdyn_description");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Description));
        this.SetAttributeValue("msdyn_description", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Description));
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

    [AttributeLogicalName("msdyn_owningsolutionid")]
    public string msdyn_OwningSolutionId
    {
      get => this.GetAttributeValue<string>("msdyn_owningsolutionid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_OwningSolutionId));
        this.SetAttributeValue("msdyn_owningsolutionid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_OwningSolutionId));
      }
    }

    [AttributeLogicalName("msdyn_resolutionaction")]
    public EntityReference msdyn_ResolutionAction
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_resolutionaction");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ResolutionAction));
        this.SetAttributeValue("msdyn_resolutionaction", (object) value);
        this.OnPropertyChanged(nameof (msdyn_ResolutionAction));
      }
    }

    [AttributeLogicalName("msdyn_resolutionmessage")]
    public string msdyn_resolutionmessage
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_resolutionmessage));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_resolutionmessage));
        this.SetAttributeValue(nameof (msdyn_resolutionmessage), (object) value);
        this.OnPropertyChanged(nameof (msdyn_resolutionmessage));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthruleid")]
    public Guid? msdyn_solutionhealthruleId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_solutionhealthruleid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleId));
        this.SetAttributeValue("msdyn_solutionhealthruleid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleId));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthruleid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_solutionhealthruleId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_solutionhealthrulesetid")]
    public EntityReference msdyn_solutionhealthrulesetId
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_solutionhealthrulesetid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrulesetId));
        this.SetAttributeValue("msdyn_solutionhealthrulesetid", (object) value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrulesetId));
      }
    }

    [AttributeLogicalName("msdyn_uniquename")]
    public string msdyn_uniquename
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_uniquename));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_uniquename));
        this.SetAttributeValue(nameof (msdyn_uniquename), (object) value);
        this.OnPropertyChanged(nameof (msdyn_uniquename));
      }
    }

    [AttributeLogicalName("msdyn_workflow")]
    public EntityReference msdyn_Workflow
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_workflow");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Workflow));
        this.SetAttributeValue("msdyn_workflow", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Workflow));
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
    public msdyn_solutionhealthruleState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_solutionhealthruleState?((msdyn_solutionhealthruleState) Enum.ToObject(typeof (msdyn_solutionhealthruleState), attributeValue.Value)) : new msdyn_solutionhealthruleState?();
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

    [RelationshipSchemaName("msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule")]
    public IEnumerable<msdyn_solutionhealthruleargument> msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule
    {
      get
      {
        return this.GetRelatedEntities<msdyn_solutionhealthruleargument>(nameof (msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule));
        this.SetRelatedEntities<msdyn_solutionhealthruleargument>(nameof (msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_solutionhealthrule_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_solutionhealthrule_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_solutionhealthrule_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_solutionhealthrule_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_solutionhealthrule_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_solutionhealthrule_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_solutionhealthrule_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthrule_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthrule_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_solutionhealthrule_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthrule_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthrule_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_solutionhealthrule_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_solutionhealthrule_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_solutionhealthrule_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_solutionhealthrule_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_solutionhealthrule_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_solutionhealthrule_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_SyncErrors")]
    public IEnumerable<SyncError> msdyn_solutionhealthrule_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_solutionhealthrule_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_solutionhealthrule_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthrule_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_solutionhealthrule_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_solutionhealthrule_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_solutionhealthrule_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_solutionhealthrule")]
    public BusinessUnit business_unit_msdyn_solutionhealthrule
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_solutionhealthrule), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthrule_createdby")]
    public SystemUser lk_msdyn_solutionhealthrule_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthrule_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthrule_createdonbehalfby")]
    public SystemUser lk_msdyn_solutionhealthrule_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthrule_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_solutionhealthrule_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthrule_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_solutionhealthrule_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthrule_modifiedby")]
    public SystemUser lk_msdyn_solutionhealthrule_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthrule_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthrule_modifiedonbehalfby")]
    public SystemUser lk_msdyn_solutionhealthrule_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthrule_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_solutionhealthrule_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthrule_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_solutionhealthrule_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthrulesetid")]
    [RelationshipSchemaName("msdyn_msdyn_solutionhealthruleset_msdyn_solutio")]
    public msdyn_solutionhealthruleset msdyn_msdyn_solutionhealthruleset_msdyn_solutio
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_solutio), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_solutio));
        this.SetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_solutio), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_solutio));
      }
    }

    [AttributeLogicalName("msdyn_resolutionaction")]
    [RelationshipSchemaName("msdyn_workflow_msdyn_solutionhealthrule_resolutionaction")]
    public Workflow msdyn_workflow_msdyn_solutionhealthrule_resolutionaction
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (msdyn_workflow_msdyn_solutionhealthrule_resolutionaction), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_workflow_msdyn_solutionhealthrule_resolutionaction));
        this.SetRelatedEntity<Workflow>(nameof (msdyn_workflow_msdyn_solutionhealthrule_resolutionaction), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_workflow_msdyn_solutionhealthrule_resolutionaction));
      }
    }

    [AttributeLogicalName("msdyn_workflow")]
    [RelationshipSchemaName("msdyn_workflow_msdyn_solutionhealthrule_Workflow")]
    public Workflow msdyn_workflow_msdyn_solutionhealthrule_Workflow
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (msdyn_workflow_msdyn_solutionhealthrule_Workflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_workflow_msdyn_solutionhealthrule_Workflow));
        this.SetRelatedEntity<Workflow>(nameof (msdyn_workflow_msdyn_solutionhealthrule_Workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_workflow_msdyn_solutionhealthrule_Workflow));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_solutionhealthrule")]
    public Team team_msdyn_solutionhealthrule
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_solutionhealthrule), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_solutionhealthrule")]
    public SystemUser user_msdyn_solutionhealthrule
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_solutionhealthrule), new EntityRole?());
      }
    }

    public msdyn_solutionhealthrule(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_solutionhealthruleid"] = (object) base.Id;
            break;
          case "msdyn_solutionhealthruleid":
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
