﻿// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_bloodquantum
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_bloodquantum")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_bloodquantum : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_bloodquantum";
    public const string EntitySchemaName = "ait_bloodquantum";
    public const string PrimaryIdAttribute = "ait_bloodquantumid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_bloodquantum()
      : base(nameof (ait_bloodquantum))
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

    [AttributeLogicalName("ait_bloodquantumdecimal")]
    public Decimal? ait_bloodquantumdecimal
    {
      get => this.GetAttributeValue<Decimal?>(nameof (ait_bloodquantumdecimal));
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantumdecimal));
        this.SetAttributeValue(nameof (ait_bloodquantumdecimal), (object) value);
        this.OnPropertyChanged(nameof (ait_bloodquantumdecimal));
      }
    }

    [AttributeLogicalName("ait_bloodquantumfraction")]
    public string ait_bloodquantumfraction
    {
      get => this.GetAttributeValue<string>(nameof (ait_bloodquantumfraction));
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantumfraction));
        this.SetAttributeValue(nameof (ait_bloodquantumfraction), (object) value);
        this.OnPropertyChanged(nameof (ait_bloodquantumfraction));
      }
    }

    [AttributeLogicalName("ait_bloodquantumid")]
    public Guid? ait_bloodquantumId
    {
      get => this.GetAttributeValue<Guid?>("ait_bloodquantumid");
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantumId));
        this.SetAttributeValue("ait_bloodquantumid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_bloodquantumId));
      }
    }

    [AttributeLogicalName("ait_bloodquantumid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_bloodquantumId = new Guid?(value);
    }

    [AttributeLogicalName("ait_bloodquantumincludedintribe")]
    public bool? ait_bloodquantumincludedintribe
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_bloodquantumincludedintribe));
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantumincludedintribe));
        this.SetAttributeValue(nameof (ait_bloodquantumincludedintribe), (object) value);
        this.OnPropertyChanged(nameof (ait_bloodquantumincludedintribe));
      }
    }

    [AttributeLogicalName("ait_confederatedtribefilter")]
    public EntityReference ait_confederatedtribefilter
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_confederatedtribefilter));
      set
      {
        this.OnPropertyChanging(nameof (ait_confederatedtribefilter));
        this.SetAttributeValue(nameof (ait_confederatedtribefilter), (object) value);
        this.OnPropertyChanged(nameof (ait_confederatedtribefilter));
      }
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

    [AttributeLogicalName("ait_memberprofile")]
    public EntityReference ait_memberprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_memberprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile));
        this.SetAttributeValue(nameof (ait_memberprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_memberprofile));
      }
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

    [AttributeLogicalName("ait_systemgenerated")]
    public bool? ait_systemgenerated
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_systemgenerated));
      set
      {
        this.OnPropertyChanging(nameof (ait_systemgenerated));
        this.SetAttributeValue(nameof (ait_systemgenerated), (object) value);
        this.OnPropertyChanged(nameof (ait_systemgenerated));
      }
    }

    [AttributeLogicalName("ait_tribe")]
    public EntityReference ait_Tribe
    {
      get => this.GetAttributeValue<EntityReference>("ait_tribe");
      set
      {
        this.OnPropertyChanging(nameof (ait_Tribe));
        this.SetAttributeValue("ait_tribe", (object) value);
        this.OnPropertyChanged(nameof (ait_Tribe));
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
    public ait_bloodquantumState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_bloodquantumState?((ait_bloodquantumState) Enum.ToObject(typeof (ait_bloodquantumState), attributeValue.Value)) : new ait_bloodquantumState?();
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

    [RelationshipSchemaName("ait_bloodquantum_Annotations")]
    public IEnumerable<Annotation> ait_bloodquantum_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_bloodquantum_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_bloodquantum_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_Annotations));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_bloodquantum_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_bloodquantum_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_bloodquantum_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_bloodquantum_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_bloodquantum_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_bloodquantum_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_bloodquantum_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_bloodquantum_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_bloodquantum_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_bloodquantum_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_bloodquantum_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_bloodquantum_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_bloodquantum_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_bloodquantum_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_bloodquantum_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_bloodquantum_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_bloodquantum_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_bloodquantum_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_ProcessSession")]
    public IEnumerable<ProcessSession> ait_bloodquantum_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_bloodquantum_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_bloodquantum_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_SyncErrors")]
    public IEnumerable<SyncError> ait_bloodquantum_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_bloodquantum_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_bloodquantum_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_bloodquantum_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_bloodquantum_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_bloodquantum_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_bloodquantum_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_memberprofile")]
    [RelationshipSchemaName("ait_ait_bloodquantum_ait_memberprofile")]
    public ArcticIT.EarlyBound.Entities.ait_memberprofile ait_ait_bloodquantum_ait_memberprofile
    {
      get
      {
        return this.GetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_memberprofile>(nameof (ait_ait_bloodquantum_ait_memberprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_bloodquantum_ait_memberprofile));
        this.SetRelatedEntity<ArcticIT.EarlyBound.Entities.ait_memberprofile>(nameof (ait_ait_bloodquantum_ait_memberprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_bloodquantum_ait_memberprofile));
      }
    }

    [AttributeLogicalName("ait_confederatedtribefilter")]
    [RelationshipSchemaName("ait_ait_tribe_ait_bloodquantum_confederatedtribefilter")]
    public ait_tribe ait_ait_tribe_ait_bloodquantum_confederatedtribefilter
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_ait_tribe_ait_bloodquantum_confederatedtribefilter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_bloodquantum_confederatedtribefilter));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_ait_tribe_ait_bloodquantum_confederatedtribefilter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_bloodquantum_confederatedtribefilter));
      }
    }

    [AttributeLogicalName("ait_tribe")]
    [RelationshipSchemaName("ait_ait_tribe_ait_bloodquantum_Tribe")]
    public ait_tribe ait_ait_tribe_ait_bloodquantum_Tribe
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_ait_tribe_ait_bloodquantum_Tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_bloodquantum_Tribe));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_ait_tribe_ait_bloodquantum_Tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_bloodquantum_Tribe));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_bloodquantum")]
    public BusinessUnit business_unit_ait_bloodquantum
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_bloodquantum), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_bloodquantum_createdby")]
    public SystemUser lk_ait_bloodquantum_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_bloodquantum_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_bloodquantum_createdonbehalfby")]
    public SystemUser lk_ait_bloodquantum_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_bloodquantum_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_bloodquantum_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_bloodquantum_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_bloodquantum_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_bloodquantum_modifiedby")]
    public SystemUser lk_ait_bloodquantum_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_bloodquantum_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_bloodquantum_modifiedonbehalfby")]
    public SystemUser lk_ait_bloodquantum_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_bloodquantum_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_bloodquantum_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_bloodquantum_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_bloodquantum_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_bloodquantum")]
    public Team team_ait_bloodquantum
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_bloodquantum), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_bloodquantum")]
    public SystemUser user_ait_bloodquantum
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_bloodquantum), new EntityRole?());
    }

    public ait_bloodquantum(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_bloodquantumid"] = (object) base.Id;
            break;
          case "ait_bloodquantumid":
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