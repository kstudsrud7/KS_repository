// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_solutionhealthruleargument
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_solutionhealthruleargument")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_solutionhealthruleargument : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_solutionhealthruleargument";
    public const string EntitySchemaName = "msdyn_solutionhealthruleargument";
    public const string PrimaryIdAttribute = "msdyn_solutionhealthruleargumentid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_solutionhealthruleargument()
      : base(nameof (msdyn_solutionhealthruleargument))
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

    [AttributeLogicalName("msdyn_key")]
    public string msdyn_Key
    {
      get => this.GetAttributeValue<string>("msdyn_key");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Key));
        this.SetAttributeValue("msdyn_key", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Key));
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

    [AttributeLogicalName("msdyn_solutionhealthrule")]
    public EntityReference msdyn_SolutionHealthRule
    {
      get => this.GetAttributeValue<EntityReference>("msdyn_solutionhealthrule");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_SolutionHealthRule));
        this.SetAttributeValue("msdyn_solutionhealthrule", (object) value);
        this.OnPropertyChanged(nameof (msdyn_SolutionHealthRule));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthruleargumentid")]
    public Guid? msdyn_solutionhealthruleargumentId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_solutionhealthruleargumentid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargumentId));
        this.SetAttributeValue("msdyn_solutionhealthruleargumentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargumentId));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthruleargumentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_solutionhealthruleargumentId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_value")]
    public string msdyn_Value
    {
      get => this.GetAttributeValue<string>("msdyn_value");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_Value));
        this.SetAttributeValue("msdyn_value", (object) value);
        this.OnPropertyChanged(nameof (msdyn_Value));
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
    public msdyn_solutionhealthruleargumentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_solutionhealthruleargumentState?((msdyn_solutionhealthruleargumentState) Enum.ToObject(typeof (msdyn_solutionhealthruleargumentState), attributeValue.Value)) : new msdyn_solutionhealthruleargumentState?();
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

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_solutionhealthruleargument_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_solutionhealthruleargument_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_solutionhealthruleargument_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_solutionhealthruleargument_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_solutionhealthruleargument_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_solutionhealthruleargument_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_solutionhealthruleargument_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthruleargument_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthruleargument_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_solutionhealthruleargument_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthruleargument_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthruleargument_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_solutionhealthruleargument_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_solutionhealthruleargument_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_solutionhealthruleargument_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_solutionhealthruleargument_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_solutionhealthruleargument_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_solutionhealthruleargument_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_SyncErrors")]
    public IEnumerable<SyncError> msdyn_solutionhealthruleargument_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_solutionhealthruleargument_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_solutionhealthruleargument_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleargument_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_solutionhealthruleargument_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_solutionhealthruleargument_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_solutionhealthruleargument_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_solutionhealthruleargument")]
    public BusinessUnit business_unit_msdyn_solutionhealthruleargument
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_solutionhealthruleargument), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthruleargument_createdby")]
    public SystemUser lk_msdyn_solutionhealthruleargument_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleargument_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthruleargument_createdonbehalfby")]
    public SystemUser lk_msdyn_solutionhealthruleargument_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleargument_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_solutionhealthruleargument_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleargument_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_solutionhealthruleargument_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthruleargument_modifiedby")]
    public SystemUser lk_msdyn_solutionhealthruleargument_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleargument_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthruleargument_modifiedonbehalfby")]
    public SystemUser lk_msdyn_solutionhealthruleargument_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleargument_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_solutionhealthruleargument_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleargument_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_solutionhealthruleargument_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthrule")]
    [RelationshipSchemaName("msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule")]
    public msdyn_solutionhealthrule msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule));
        this.SetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_solutionhealthrule_msdyn_solutionhealthruleargument_SolutionHealthRule));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_solutionhealthruleargument")]
    public Team team_msdyn_solutionhealthruleargument
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_msdyn_solutionhealthruleargument), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_solutionhealthruleargument")]
    public SystemUser user_msdyn_solutionhealthruleargument
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_solutionhealthruleargument), new EntityRole?());
      }
    }

    public msdyn_solutionhealthruleargument(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_solutionhealthruleargumentid"] = (object) base.Id;
            break;
          case "msdyn_solutionhealthruleargumentid":
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
