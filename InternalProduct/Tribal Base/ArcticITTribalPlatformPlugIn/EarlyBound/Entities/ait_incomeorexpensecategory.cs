// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_incomeorexpensecategory
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_incomeorexpensecategory")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_incomeorexpensecategory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_incomeorexpensecategory";
    public const string EntitySchemaName = "ait_incomeorexpensecategory";
    public const string PrimaryIdAttribute = "ait_incomeorexpensecategoryid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_incomeorexpensecategory()
      : base(nameof (ait_incomeorexpensecategory))
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

    [AttributeLogicalName("ait_incomeorexpensecategoryid")]
    public Guid? ait_incomeorexpensecategoryId
    {
      get => this.GetAttributeValue<Guid?>("ait_incomeorexpensecategoryid");
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategoryId));
        this.SetAttributeValue("ait_incomeorexpensecategoryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategoryId));
      }
    }

    [AttributeLogicalName("ait_incomeorexpensecategoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_incomeorexpensecategoryId = new Guid?(value);
    }

    [AttributeLogicalName("ait_incomeorexpensetype")]
    public OptionSetValue ait_incomeorexpensetype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_incomeorexpensetype));
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensetype));
        this.SetAttributeValue(nameof (ait_incomeorexpensetype), (object) value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensetype));
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
    public ait_incomeorexpensecategoryState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_incomeorexpensecategoryState?((ait_incomeorexpensecategoryState) Enum.ToObject(typeof (ait_incomeorexpensecategoryState), attributeValue.Value)) : new ait_incomeorexpensecategoryState?();
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

    [RelationshipSchemaName("ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category")]
    public IEnumerable<ait_contactincomeandexpense> ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category
    {
      get
      {
        return this.GetRelatedEntities<ait_contactincomeandexpense>(nameof (ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category));
        this.SetRelatedEntities<ait_contactincomeandexpense>(nameof (ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_incomeorexpensecategory_ait_contactincomeandexpense_category));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_incomeorexpensecategory_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_incomeorexpensecategory_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_incomeorexpensecategory_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_incomeorexpensecategory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_incomeorexpensecategory_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_incomeorexpensecategory_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_incomeorexpensecategory_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_incomeorexpensecategory_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_incomeorexpensecategory_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_incomeorexpensecategory_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_incomeorexpensecategory_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_incomeorexpensecategory_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_incomeorexpensecategory_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_incomeorexpensecategory_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_incomeorexpensecategory_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_ProcessSession")]
    public IEnumerable<ProcessSession> ait_incomeorexpensecategory_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_incomeorexpensecategory_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_incomeorexpensecategory_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_SyncErrors")]
    public IEnumerable<SyncError> ait_incomeorexpensecategory_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_incomeorexpensecategory_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_incomeorexpensecategory_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_incomeorexpensecategory_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_incomeorexpensecategory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_incomeorexpensecategory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_incomeorexpensecategory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_incomeorexpensecategory_createdby")]
    public SystemUser lk_ait_incomeorexpensecategory_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incomeorexpensecategory_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_incomeorexpensecategory_createdonbehalfby")]
    public SystemUser lk_ait_incomeorexpensecategory_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incomeorexpensecategory_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incomeorexpensecategory_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_incomeorexpensecategory_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incomeorexpensecategory_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_incomeorexpensecategory_modifiedby")]
    public SystemUser lk_ait_incomeorexpensecategory_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incomeorexpensecategory_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_incomeorexpensecategory_modifiedonbehalfby")]
    public SystemUser lk_ait_incomeorexpensecategory_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_incomeorexpensecategory_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_incomeorexpensecategory_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_incomeorexpensecategory_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_incomeorexpensecategory_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_incomeorexpensecategory")]
    public Organization organization_ait_incomeorexpensecategory
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_incomeorexpensecategory), new EntityRole?());
      }
    }

    public ait_incomeorexpensecategory(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_incomeorexpensecategoryid"] = (object) base.Id;
            break;
          case "ait_incomeorexpensecategoryid":
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
