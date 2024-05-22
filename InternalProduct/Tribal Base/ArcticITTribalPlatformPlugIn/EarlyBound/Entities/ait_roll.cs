// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_roll
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_roll")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_roll : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_roll";
    public const string EntitySchemaName = "ait_roll";
    public const string PrimaryIdAttribute = "ait_rollid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_roll()
      : base(nameof (ait_roll))
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

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
      }
    }

    [AttributeLogicalName("ait_memberrollcount")]
    public int? ait_MemberRollCount => this.GetAttributeValue<int?>("ait_memberrollcount");

    [AttributeLogicalName("ait_memberrollcount_date")]
    public DateTime? ait_MemberRollCount_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_memberrollcount_date");
    }

    [AttributeLogicalName("ait_memberrollcount_state")]
    public int? ait_MemberRollCount_State
    {
      get => this.GetAttributeValue<int?>("ait_memberrollcount_state");
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
      }
    }

    [AttributeLogicalName("ait_rolldate")]
    public DateTime? ait_rolldate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_rolldate));
      set
      {
        this.OnPropertyChanging(nameof (ait_rolldate));
        this.SetAttributeValue(nameof (ait_rolldate), (object) value);
        this.OnPropertyChanged(nameof (ait_rolldate));
      }
    }

    [AttributeLogicalName("ait_rollid")]
    public Guid? ait_rollId
    {
      get => this.GetAttributeValue<Guid?>("ait_rollid");
      set
      {
        this.OnPropertyChanging(nameof (ait_rollId));
        this.SetAttributeValue("ait_rollid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_rollId));
      }
    }

    [AttributeLogicalName("ait_rollid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_rollId = new Guid?(value);
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
    public ait_rollState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_rollState?((ait_rollState) Enum.ToObject(typeof (ait_rollState), attributeValue.Value)) : new ait_rollState?();
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

    [RelationshipSchemaName("ait_ait_memberroll_ait_roll")]
    public IEnumerable<ait_memberroll> ait_ait_memberroll_ait_roll
    {
      get
      {
        return this.GetRelatedEntities<ait_memberroll>(nameof (ait_ait_memberroll_ait_roll), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_memberroll_ait_roll));
        this.SetRelatedEntities<ait_memberroll>(nameof (ait_ait_memberroll_ait_roll), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_memberroll_ait_roll));
      }
    }

    [RelationshipSchemaName("ait_roll_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_roll_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_roll_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_roll_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_roll_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_roll_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_roll_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_roll_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_roll_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_roll_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_roll_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_roll_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_roll_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_roll_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_roll_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_roll_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_roll_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_roll_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_roll_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_roll_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_roll_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_roll_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_roll_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_roll_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_roll_ProcessSession")]
    public IEnumerable<ProcessSession> ait_roll_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_roll_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_roll_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_roll_SyncErrors")]
    public IEnumerable<SyncError> ait_roll_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_roll_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_roll_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_roll_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_roll_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_roll_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_roll_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_roll_createdby")]
    public SystemUser lk_ait_roll_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_roll_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_roll_createdonbehalfby")]
    public SystemUser lk_ait_roll_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_roll_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_roll_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_roll_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_roll_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_roll_modifiedby")]
    public SystemUser lk_ait_roll_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_ait_roll_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_roll_modifiedonbehalfby")]
    public SystemUser lk_ait_roll_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_roll_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_roll_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_roll_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_roll_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_roll")]
    public Organization organization_ait_roll
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_ait_roll), new EntityRole?());
    }

    public ait_roll(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_rollid"] = (object) base.Id;
            break;
          case "ait_rollid":
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
