// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_changerequesttype
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_changerequesttype")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_changerequesttype : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_changerequesttype";
    public const string EntitySchemaName = "ait_changerequesttype";
    public const string PrimaryIdAttribute = "ait_changerequesttypeid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_changerequesttype()
      : base(nameof (ait_changerequesttype))
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

    [AttributeLogicalName("ait_approvingteam")]
    public EntityReference ait_ApprovingTeam
    {
      get => this.GetAttributeValue<EntityReference>("ait_approvingteam");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApprovingTeam));
        this.SetAttributeValue("ait_approvingteam", (object) value);
        this.OnPropertyChanged(nameof (ait_ApprovingTeam));
      }
    }

    [AttributeLogicalName("ait_attachmentrequired")]
    public OptionSetValue ait_AttachmentRequired
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_attachmentrequired");
      set
      {
        this.OnPropertyChanging(nameof (ait_AttachmentRequired));
        this.SetAttributeValue("ait_attachmentrequired", (object) value);
        this.OnPropertyChanged(nameof (ait_AttachmentRequired));
      }
    }

    [AttributeLogicalName("ait_ceformname")]
    public string ait_CEFormName
    {
      get => this.GetAttributeValue<string>("ait_ceformname");
      set
      {
        this.OnPropertyChanging(nameof (ait_CEFormName));
        this.SetAttributeValue("ait_ceformname", (object) value);
        this.OnPropertyChanged(nameof (ait_CEFormName));
      }
    }

    [AttributeLogicalName("ait_ceformtabname")]
    public string ait_CEFormTabName
    {
      get => this.GetAttributeValue<string>("ait_ceformtabname");
      set
      {
        this.OnPropertyChanging(nameof (ait_CEFormTabName));
        this.SetAttributeValue("ait_ceformtabname", (object) value);
        this.OnPropertyChanged(nameof (ait_CEFormTabName));
      }
    }

    [AttributeLogicalName("ait_changerequesttypeid")]
    public Guid? ait_changerequesttypeId
    {
      get => this.GetAttributeValue<Guid?>("ait_changerequesttypeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttypeId));
        this.SetAttributeValue("ait_changerequesttypeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_changerequesttypeId));
      }
    }

    [AttributeLogicalName("ait_changerequesttypeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_changerequesttypeId = new Guid?(value);
    }

    [AttributeLogicalName("ait_displayorder")]
    public int? ait_DisplayOrder
    {
      get => this.GetAttributeValue<int?>("ait_displayorder");
      set
      {
        this.OnPropertyChanging(nameof (ait_DisplayOrder));
        this.SetAttributeValue("ait_displayorder", (object) value);
        this.OnPropertyChanged(nameof (ait_DisplayOrder));
      }
    }

    [AttributeLogicalName("ait_isgeneralsubtype")]
    public OptionSetValue ait_IsGeneralSubtype
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_isgeneralsubtype");
      set
      {
        this.OnPropertyChanging(nameof (ait_IsGeneralSubtype));
        this.SetAttributeValue("ait_isgeneralsubtype", (object) value);
        this.OnPropertyChanged(nameof (ait_IsGeneralSubtype));
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

    [AttributeLogicalName("ait_portalformname")]
    public string ait_PortalFormName
    {
      get => this.GetAttributeValue<string>("ait_portalformname");
      set
      {
        this.OnPropertyChanging(nameof (ait_PortalFormName));
        this.SetAttributeValue("ait_portalformname", (object) value);
        this.OnPropertyChanged(nameof (ait_PortalFormName));
      }
    }

    [AttributeLogicalName("ait_userfacingname")]
    public string ait_UserfacingName
    {
      get => this.GetAttributeValue<string>("ait_userfacingname");
      set
      {
        this.OnPropertyChanging(nameof (ait_UserfacingName));
        this.SetAttributeValue("ait_userfacingname", (object) value);
        this.OnPropertyChanged(nameof (ait_UserfacingName));
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
    public ait_changerequesttypeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_changerequesttypeState?((ait_changerequesttypeState) Enum.ToObject(typeof (ait_changerequesttypeState), attributeValue.Value)) : new ait_changerequesttypeState?();
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

    [RelationshipSchemaName("ait_ait_changerequesttype_ait_changerequest_CRType")]
    public IEnumerable<ait_changerequest> ait_ait_changerequesttype_ait_changerequest_CRType
    {
      get
      {
        return this.GetRelatedEntities<ait_changerequest>(nameof (ait_ait_changerequesttype_ait_changerequest_CRType), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_changerequesttype_ait_changerequest_CRType));
        this.SetRelatedEntities<ait_changerequest>(nameof (ait_ait_changerequesttype_ait_changerequest_CRType), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_changerequesttype_ait_changerequest_CRType));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_changerequesttype_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_changerequesttype_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_changerequesttype_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_changerequesttype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_changerequesttype_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_changerequesttype_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_changerequesttype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_changerequesttype_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_changerequesttype_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_changerequesttype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_changerequesttype_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_changerequesttype_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_changerequesttype_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_changerequesttype_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_changerequesttype_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_changerequesttype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_changerequesttype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_changerequesttype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_ProcessSession")]
    public IEnumerable<ProcessSession> ait_changerequesttype_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_changerequesttype_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_changerequesttype_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_SyncErrors")]
    public IEnumerable<SyncError> ait_changerequesttype_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_changerequesttype_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_changerequesttype_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_changerequesttype_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_changerequesttype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_changerequesttype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_changerequesttype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_approvingteam")]
    [RelationshipSchemaName("ait_team_ait_changerequesttype_ApprovingTeam")]
    public Team ait_team_ait_changerequesttype_ApprovingTeam
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (ait_team_ait_changerequesttype_ApprovingTeam), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_team_ait_changerequesttype_ApprovingTeam));
        this.SetRelatedEntity<Team>(nameof (ait_team_ait_changerequesttype_ApprovingTeam), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_team_ait_changerequesttype_ApprovingTeam));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_changerequesttype")]
    public BusinessUnit business_unit_ait_changerequesttype
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_changerequesttype), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_changerequesttype_createdby")]
    public SystemUser lk_ait_changerequesttype_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_changerequesttype_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_changerequesttype_createdonbehalfby")]
    public SystemUser lk_ait_changerequesttype_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_changerequesttype_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_changerequesttype_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_changerequesttype_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_changerequesttype_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_changerequesttype_modifiedby")]
    public SystemUser lk_ait_changerequesttype_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_changerequesttype_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_changerequesttype_modifiedonbehalfby")]
    public SystemUser lk_ait_changerequesttype_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_changerequesttype_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_changerequesttype_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_changerequesttype_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_changerequesttype_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_changerequesttype")]
    public Team team_ait_changerequesttype
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_changerequesttype), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_changerequesttype")]
    public SystemUser user_ait_changerequesttype
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_ait_changerequesttype), new EntityRole?());
      }
    }

    public ait_changerequesttype(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_changerequesttypeid"] = (object) base.Id;
            break;
          case "ait_changerequesttypeid":
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
