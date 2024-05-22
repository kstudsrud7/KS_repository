// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_solutionhealthruleset
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_solutionhealthruleset")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_solutionhealthruleset : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_solutionhealthruleset";
    public const string EntitySchemaName = "msdyn_solutionhealthruleset";
    public const string PrimaryIdAttribute = "msdyn_solutionhealthrulesetid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_solutionhealthruleset()
      : base(nameof (msdyn_solutionhealthruleset))
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
    public string msdyn_description
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_description));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_description));
        this.SetAttributeValue(nameof (msdyn_description), (object) value);
        this.OnPropertyChanged(nameof (msdyn_description));
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

    [AttributeLogicalName("msdyn_solutionhealthrulesetid")]
    public Guid? msdyn_solutionhealthrulesetId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_solutionhealthrulesetid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrulesetId));
        this.SetAttributeValue("msdyn_solutionhealthrulesetid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrulesetId));
      }
    }

    [AttributeLogicalName("msdyn_solutionhealthrulesetid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_solutionhealthrulesetId = new Guid?(value);
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
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

    [AttributeLogicalName("statecode")]
    public msdyn_solutionhealthrulesetState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_solutionhealthrulesetState?((msdyn_solutionhealthrulesetState) Enum.ToObject(typeof (msdyn_solutionhealthrulesetState), attributeValue.Value)) : new msdyn_solutionhealthrulesetState?();
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

    [RelationshipSchemaName("msdyn_msdyn_solutionhealthruleset_msdyn_analysi")]
    public IEnumerable<msdyn_analysiscomponent> msdyn_msdyn_solutionhealthruleset_msdyn_analysi
    {
      get
      {
        return this.GetRelatedEntities<msdyn_analysiscomponent>(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_analysi), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_analysi));
        this.SetRelatedEntities<msdyn_analysiscomponent>(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_analysi), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_analysi));
      }
    }

    [RelationshipSchemaName("msdyn_msdyn_solutionhealthruleset_msdyn_solutio")]
    public IEnumerable<msdyn_solutionhealthrule> msdyn_msdyn_solutionhealthruleset_msdyn_solutio
    {
      get
      {
        return this.GetRelatedEntities<msdyn_solutionhealthrule>(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_solutio), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_solutio));
        this.SetRelatedEntities<msdyn_solutionhealthrule>(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_solutio), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_msdyn_solutionhealthruleset_msdyn_solutio));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_solutionhealthruleset_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_solutionhealthruleset_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_solutionhealthruleset_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_solutionhealthruleset_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_solutionhealthruleset_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_solutionhealthruleset_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> msdyn_solutionhealthruleset_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthruleset_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthruleset_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> msdyn_solutionhealthruleset_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthruleset_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (msdyn_solutionhealthruleset_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_solutionhealthruleset_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_solutionhealthruleset_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_solutionhealthruleset_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_solutionhealthruleset_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_solutionhealthruleset_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_solutionhealthruleset_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_SyncErrors")]
    public IEnumerable<SyncError> msdyn_solutionhealthruleset_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_solutionhealthruleset_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_solutionhealthruleset_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_solutionhealthruleset_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_solutionhealthruleset_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_solutionhealthruleset_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_solutionhealthruleset_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthruleset_createdby")]
    public SystemUser lk_msdyn_solutionhealthruleset_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleset_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthruleset_createdonbehalfby")]
    public SystemUser lk_msdyn_solutionhealthruleset_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleset_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_solutionhealthruleset_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleset_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_solutionhealthruleset_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthruleset_modifiedby")]
    public SystemUser lk_msdyn_solutionhealthruleset_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleset_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_solutionhealthruleset_modifiedonbehalfby")]
    public SystemUser lk_msdyn_solutionhealthruleset_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleset_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_solutionhealthruleset_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_solutionhealthruleset_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_solutionhealthruleset_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_msdyn_solutionhealthruleset")]
    public Organization organization_msdyn_solutionhealthruleset
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_msdyn_solutionhealthruleset), new EntityRole?());
      }
    }

    public msdyn_solutionhealthruleset(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_solutionhealthrulesetid"] = (object) base.Id;
            break;
          case "msdyn_solutionhealthrulesetid":
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
