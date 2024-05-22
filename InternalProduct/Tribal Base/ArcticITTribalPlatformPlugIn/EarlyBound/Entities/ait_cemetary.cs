// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_cemetary
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_cemetary")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_cemetary : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_cemetary";
    public const string EntitySchemaName = "ait_cemetary";
    public const string PrimaryIdAttribute = "ait_cemetaryid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_cemetary()
      : base(nameof (ait_cemetary))
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

    [AttributeLogicalName("ait_address")]
    public EntityReference ait_address
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_address));
      set
      {
        this.OnPropertyChanging(nameof (ait_address));
        this.SetAttributeValue(nameof (ait_address), (object) value);
        this.OnPropertyChanged(nameof (ait_address));
      }
    }

    [AttributeLogicalName("ait_cemetaryid")]
    public Guid? ait_cemetaryId
    {
      get => this.GetAttributeValue<Guid?>("ait_cemetaryid");
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetaryId));
        this.SetAttributeValue("ait_cemetaryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_cemetaryId));
      }
    }

    [AttributeLogicalName("ait_cemetaryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_cemetaryId = new Guid?(value);
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
    public ait_cemetaryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_cemetaryState?((ait_cemetaryState) Enum.ToObject(typeof (ait_cemetaryState), attributeValue.Value)) : new ait_cemetaryState?();
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

    [RelationshipSchemaName("ait_ait_deathrecord_ait_cemetary")]
    public IEnumerable<ait_deathrecord> ait_ait_deathrecord_ait_cemetary
    {
      get
      {
        return this.GetRelatedEntities<ait_deathrecord>(nameof (ait_ait_deathrecord_ait_cemetary), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_deathrecord_ait_cemetary));
        this.SetRelatedEntities<ait_deathrecord>(nameof (ait_ait_deathrecord_ait_cemetary), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_deathrecord_ait_cemetary));
      }
    }

    [RelationshipSchemaName("ait_cemetary_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_cemetary_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_cemetary_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_cemetary_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_cemetary_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_cemetary_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_cemetary_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_cemetary_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_cemetary_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_cemetary_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_cemetary_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_cemetary_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_cemetary_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_cemetary_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_cemetary_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_cemetary_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_cemetary_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_cemetary_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_cemetary_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_cemetary_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_cemetary_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_cemetary_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_cemetary_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_cemetary_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_cemetary_ProcessSession")]
    public IEnumerable<ProcessSession> ait_cemetary_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_cemetary_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_cemetary_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_cemetary_SyncErrors")]
    public IEnumerable<SyncError> ait_cemetary_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_cemetary_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_cemetary_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_cemetary_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_cemetary_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_cemetary_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_cemetary_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_address")]
    [RelationshipSchemaName("ait_ait_cemetary_ait_physicaladdress")]
    public ait_physicaladdress ait_ait_cemetary_ait_physicaladdress
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_cemetary_ait_physicaladdress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_cemetary_ait_physicaladdress));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_ait_cemetary_ait_physicaladdress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_cemetary_ait_physicaladdress));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_cemetary_createdby")]
    public SystemUser lk_ait_cemetary_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cemetary_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_cemetary_createdonbehalfby")]
    public SystemUser lk_ait_cemetary_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cemetary_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_cemetary_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_cemetary_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_cemetary_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_cemetary_modifiedby")]
    public SystemUser lk_ait_cemetary_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cemetary_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_cemetary_modifiedonbehalfby")]
    public SystemUser lk_ait_cemetary_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cemetary_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_cemetary_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_cemetary_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_cemetary_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_cemetary")]
    public Organization organization_ait_cemetary
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_cemetary), new EntityRole?());
      }
    }

    public ait_cemetary(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_cemetaryid"] = (object) base.Id;
            break;
          case "ait_cemetaryid":
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
