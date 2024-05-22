// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdynce_botcontent
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdynce_botcontent")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdynce_botcontent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdynce_botcontent";
    public const string EntitySchemaName = "msdynce_botcontent";
    public const string PrimaryIdAttribute = "msdynce_botcontentid";
    public const string PrimaryNameAttribute = "msdynce_autonumber";

    public msdynce_botcontent()
      : base(nameof (msdynce_botcontent))
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

    [AttributeLogicalName("msdynce_autonumber")]
    public string msdynce_autonumber
    {
      get => this.GetAttributeValue<string>(nameof (msdynce_autonumber));
      set
      {
        this.OnPropertyChanging(nameof (msdynce_autonumber));
        this.SetAttributeValue(nameof (msdynce_autonumber), (object) value);
        this.OnPropertyChanged(nameof (msdynce_autonumber));
      }
    }

    [AttributeLogicalName("msdynce_botcontentid")]
    public Guid? msdynce_botcontentId
    {
      get => this.GetAttributeValue<Guid?>("msdynce_botcontentid");
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontentId));
        this.SetAttributeValue("msdynce_botcontentid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdynce_botcontentId));
      }
    }

    [AttributeLogicalName("msdynce_botcontentid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdynce_botcontentId = new Guid?(value);
    }

    [AttributeLogicalName("msdynce_botid")]
    public string msdynce_botid
    {
      get => this.GetAttributeValue<string>(nameof (msdynce_botid));
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botid));
        this.SetAttributeValue(nameof (msdynce_botid), (object) value);
        this.OnPropertyChanged(nameof (msdynce_botid));
      }
    }

    [AttributeLogicalName("msdynce_state")]
    public OptionSetValue msdynce_state
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (msdynce_state));
      set
      {
        this.OnPropertyChanging(nameof (msdynce_state));
        this.SetAttributeValue(nameof (msdynce_state), (object) value);
        this.OnPropertyChanged(nameof (msdynce_state));
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
    public msdynce_botcontentState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdynce_botcontentState?((msdynce_botcontentState) Enum.ToObject(typeof (msdynce_botcontentState), attributeValue.Value)) : new msdynce_botcontentState?();
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

    [RelationshipSchemaName("msdynce_botcontent_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdynce_botcontent_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdynce_botcontent_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdynce_botcontent_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdynce_botcontent_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdynce_botcontent_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdynce_botcontent_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdynce_botcontent_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdynce_botcontent_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdynce_botcontent_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdynce_botcontent_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdynce_botcontent_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdynce_botcontent_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdynce_botcontent_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdynce_botcontent_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdynce_botcontent_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdynce_botcontent_ProcessSession")]
    public IEnumerable<ProcessSession> msdynce_botcontent_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdynce_botcontent_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdynce_botcontent_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdynce_botcontent_SyncErrors")]
    public IEnumerable<SyncError> msdynce_botcontent_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdynce_botcontent_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdynce_botcontent_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdynce_botcontent_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdynce_botcontent_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdynce_botcontent_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdynce_botcontent_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdynce_botcontent")]
    public BusinessUnit business_unit_msdynce_botcontent
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdynce_botcontent), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdynce_botcontent_createdby")]
    public SystemUser lk_msdynce_botcontent_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdynce_botcontent_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdynce_botcontent_createdonbehalfby")]
    public SystemUser lk_msdynce_botcontent_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdynce_botcontent_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdynce_botcontent_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdynce_botcontent_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdynce_botcontent_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdynce_botcontent_modifiedby")]
    public SystemUser lk_msdynce_botcontent_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdynce_botcontent_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdynce_botcontent_modifiedonbehalfby")]
    public SystemUser lk_msdynce_botcontent_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdynce_botcontent_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdynce_botcontent_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdynce_botcontent_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdynce_botcontent_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdynce_botcontent")]
    public Team team_msdynce_botcontent
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdynce_botcontent), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdynce_botcontent")]
    public SystemUser user_msdynce_botcontent
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdynce_botcontent), new EntityRole?());
    }

    public msdynce_botcontent(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdynce_botcontentid"] = (object) base.Id;
            break;
          case "msdynce_botcontentid":
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
