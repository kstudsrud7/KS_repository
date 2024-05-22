// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ApplicationUser
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("applicationuser")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ApplicationUser : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "applicationuser";
    public const string EntitySchemaName = "ApplicationUser";
    public const string PrimaryIdAttribute = "applicationuserid";
    public const string PrimaryNameAttribute = "applicationname";

    public ApplicationUser()
      : base("applicationuser")
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

    [AttributeLogicalName("applicationid")]
    public Guid? ApplicationId
    {
      get => this.GetAttributeValue<Guid?>("applicationid");
      set
      {
        this.OnPropertyChanging(nameof (ApplicationId));
        this.SetAttributeValue("applicationid", (object) value);
        this.OnPropertyChanged(nameof (ApplicationId));
      }
    }

    [AttributeLogicalName("applicationname")]
    public string ApplicationName
    {
      get => this.GetAttributeValue<string>("applicationname");
      set
      {
        this.OnPropertyChanging(nameof (ApplicationName));
        this.SetAttributeValue("applicationname", (object) value);
        this.OnPropertyChanged(nameof (ApplicationName));
      }
    }

    [AttributeLogicalName("applicationtype")]
    public OptionSetValue ApplicationType
    {
      get => this.GetAttributeValue<OptionSetValue>("applicationtype");
      set
      {
        this.OnPropertyChanging(nameof (ApplicationType));
        this.SetAttributeValue("applicationtype", (object) value);
        this.OnPropertyChanged(nameof (ApplicationType));
      }
    }

    [AttributeLogicalName("applicationuserid")]
    public Guid? ApplicationUserId
    {
      get => this.GetAttributeValue<Guid?>("applicationuserid");
      set
      {
        this.OnPropertyChanging(nameof (ApplicationUserId));
        this.SetAttributeValue("applicationuserid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ApplicationUserId));
      }
    }

    [AttributeLogicalName("applicationuserid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ApplicationUserId = new Guid?(value);
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

    [AttributeLogicalName("canimpersonateassystemuser")]
    public bool? CanImpersonateAsSystemUser
    {
      get => this.GetAttributeValue<bool?>("canimpersonateassystemuser");
      set
      {
        this.OnPropertyChanging(nameof (CanImpersonateAsSystemUser));
        this.SetAttributeValue("canimpersonateassystemuser", (object) value);
        this.OnPropertyChanged(nameof (CanImpersonateAsSystemUser));
      }
    }

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
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

    [AttributeLogicalName("iscustomizable")]
    public BooleanManagedProperty IsCustomizable
    {
      get => this.GetAttributeValue<BooleanManagedProperty>("iscustomizable");
      set
      {
        this.OnPropertyChanging(nameof (IsCustomizable));
        this.SetAttributeValue("iscustomizable", (object) value);
        this.OnPropertyChanged(nameof (IsCustomizable));
      }
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

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

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public ApplicationUserState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ApplicationUserState?((ApplicationUserState) Enum.ToObject(typeof (ApplicationUserState), attributeValue.Value)) : new ApplicationUserState?();
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

    [RelationshipSchemaName("applicationuser_AsyncOperations")]
    public IEnumerable<AsyncOperation> applicationuser_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (applicationuser_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (applicationuser_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_AsyncOperations));
      }
    }

    [RelationshipSchemaName("applicationuser_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> applicationuser_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (applicationuser_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (applicationuser_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("applicationuser_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> applicationuser_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (applicationuser_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (applicationuser_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("applicationuser_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> applicationuser_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (applicationuser_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (applicationuser_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("applicationuser_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> applicationuser_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (applicationuser_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (applicationuser_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("applicationuser_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> applicationuser_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (applicationuser_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (applicationuser_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("applicationuser_ProcessSession")]
    public IEnumerable<ProcessSession> applicationuser_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (applicationuser_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (applicationuser_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_ProcessSession));
      }
    }

    [RelationshipSchemaName("applicationuser_SyncErrors")]
    public IEnumerable<SyncError> applicationuser_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (applicationuser_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (applicationuser_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_SyncErrors));
      }
    }

    [RelationshipSchemaName("applicationuser_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> applicationuser_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (applicationuser_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (applicationuser_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("applicationuserprofile")]
    public IEnumerable<FieldSecurityProfile> applicationuserprofile
    {
      get
      {
        return this.GetRelatedEntities<FieldSecurityProfile>(nameof (applicationuserprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuserprofile));
        this.SetRelatedEntities<FieldSecurityProfile>(nameof (applicationuserprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuserprofile));
      }
    }

    [RelationshipSchemaName("applicationuserrole")]
    public IEnumerable<Role> applicationuserrole
    {
      get => this.GetRelatedEntities<Role>(nameof (applicationuserrole), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (applicationuserrole));
        this.SetRelatedEntities<Role>(nameof (applicationuserrole), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuserrole));
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_applicationuser")]
    public BusinessUnit business_unit_applicationuser
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_applicationuser), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_applicationuser));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_applicationuser), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_applicationuser));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_applicationuser_createdby")]
    public SystemUser lk_applicationuser_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_applicationuser_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_applicationuser_createdonbehalfby")]
    public SystemUser lk_applicationuser_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_applicationuser_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_applicationuser_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_applicationuser_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_applicationuser_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_applicationuser_modifiedby")]
    public SystemUser lk_applicationuser_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_applicationuser_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_applicationuser_modifiedonbehalfby")]
    public SystemUser lk_applicationuser_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_applicationuser_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_applicationuser_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_applicationuser_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_applicationuser_modifiedonbehalfby));
      }
    }

    public ApplicationUser(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["applicationuserid"] = (object) base.Id;
            break;
          case "applicationuserid":
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
