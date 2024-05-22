// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_cardformat
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_cardformat")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_cardformat : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_cardformat";
    public const string EntitySchemaName = "ait_cardformat";
    public const string PrimaryIdAttribute = "ait_cardformatid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_cardformat()
      : base(nameof (ait_cardformat))
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

    [AttributeLogicalName("ait_backbackground")]
    public string ait_backbackground
    {
      get => this.GetAttributeValue<string>(nameof (ait_backbackground));
      set
      {
        this.OnPropertyChanging(nameof (ait_backbackground));
        this.SetAttributeValue(nameof (ait_backbackground), (object) value);
        this.OnPropertyChanged(nameof (ait_backbackground));
      }
    }

    [AttributeLogicalName("ait_backorientation")]
    public OptionSetValue ait_backorientation
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_backorientation));
      set
      {
        this.OnPropertyChanging(nameof (ait_backorientation));
        this.SetAttributeValue(nameof (ait_backorientation), (object) value);
        this.OnPropertyChanged(nameof (ait_backorientation));
      }
    }

    [AttributeLogicalName("ait_cardformatid")]
    public Guid? ait_cardformatId
    {
      get => this.GetAttributeValue<Guid?>("ait_cardformatid");
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatId));
        this.SetAttributeValue("ait_cardformatid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_cardformatId));
      }
    }

    [AttributeLogicalName("ait_cardformatid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_cardformatId = new Guid?(value);
    }

    [AttributeLogicalName("ait_cardtype")]
    public OptionSetValue ait_cardtype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_cardtype));
      set
      {
        this.OnPropertyChanging(nameof (ait_cardtype));
        this.SetAttributeValue(nameof (ait_cardtype), (object) value);
        this.OnPropertyChanged(nameof (ait_cardtype));
      }
    }

    [AttributeLogicalName("ait_defaulthopper")]
    public int? ait_defaulthopper
    {
      get => this.GetAttributeValue<int?>(nameof (ait_defaulthopper));
      set
      {
        this.OnPropertyChanging(nameof (ait_defaulthopper));
        this.SetAttributeValue(nameof (ait_defaulthopper), (object) value);
        this.OnPropertyChanged(nameof (ait_defaulthopper));
      }
    }

    [AttributeLogicalName("ait_defaultprinter")]
    public string ait_defaultprinter
    {
      get => this.GetAttributeValue<string>(nameof (ait_defaultprinter));
      set
      {
        this.OnPropertyChanging(nameof (ait_defaultprinter));
        this.SetAttributeValue(nameof (ait_defaultprinter), (object) value);
        this.OnPropertyChanged(nameof (ait_defaultprinter));
      }
    }

    [AttributeLogicalName("ait_frontbackground")]
    public string ait_frontbackground
    {
      get => this.GetAttributeValue<string>(nameof (ait_frontbackground));
      set
      {
        this.OnPropertyChanging(nameof (ait_frontbackground));
        this.SetAttributeValue(nameof (ait_frontbackground), (object) value);
        this.OnPropertyChanged(nameof (ait_frontbackground));
      }
    }

    [AttributeLogicalName("ait_frontorientation")]
    public OptionSetValue ait_frontorientation
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_frontorientation));
      set
      {
        this.OnPropertyChanging(nameof (ait_frontorientation));
        this.SetAttributeValue(nameof (ait_frontorientation), (object) value);
        this.OnPropertyChanged(nameof (ait_frontorientation));
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
    public ait_cardformatState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_cardformatState?((ait_cardformatState) Enum.ToObject(typeof (ait_cardformatState), attributeValue.Value)) : new ait_cardformatState?();
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

    [RelationshipSchemaName("ait_ait_cardformat_ait_cardformatdetail_cardformat")]
    public IEnumerable<ait_cardformatdetail> ait_ait_cardformat_ait_cardformatdetail_cardformat
    {
      get
      {
        return this.GetRelatedEntities<ait_cardformatdetail>(nameof (ait_ait_cardformat_ait_cardformatdetail_cardformat), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_cardformat_ait_cardformatdetail_cardformat));
        this.SetRelatedEntities<ait_cardformatdetail>(nameof (ait_ait_cardformat_ait_cardformatdetail_cardformat), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_cardformat_ait_cardformatdetail_cardformat));
      }
    }

    [RelationshipSchemaName("ait_ait_cardformat_ait_cardhistory_actioncard")]
    public IEnumerable<ait_cardhistory> ait_ait_cardformat_ait_cardhistory_actioncard
    {
      get
      {
        return this.GetRelatedEntities<ait_cardhistory>(nameof (ait_ait_cardformat_ait_cardhistory_actioncard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_cardformat_ait_cardhistory_actioncard));
        this.SetRelatedEntities<ait_cardhistory>(nameof (ait_ait_cardformat_ait_cardhistory_actioncard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_cardformat_ait_cardhistory_actioncard));
      }
    }

    [RelationshipSchemaName("ait_cardformat_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_cardformat_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_cardformat_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_cardformat_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_cardformat_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_cardformat_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_cardformat_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_cardformat_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_cardformat_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_cardformat_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_cardformat_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_cardformat_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_cardformat_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_cardformat_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_cardformat_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_cardformat_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_cardformat_ProcessSession")]
    public IEnumerable<ProcessSession> ait_cardformat_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_cardformat_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_cardformat_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_cardformat_SyncErrors")]
    public IEnumerable<SyncError> ait_cardformat_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_cardformat_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_cardformat_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_cardformat_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_cardformat_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_cardformat_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_cardformat_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_cardformat_createdby")]
    public SystemUser lk_ait_cardformat_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardformat_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_cardformat_createdonbehalfby")]
    public SystemUser lk_ait_cardformat_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardformat_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_cardformat_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_cardformat_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_cardformat_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_cardformat_modifiedby")]
    public SystemUser lk_ait_cardformat_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardformat_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_cardformat_modifiedonbehalfby")]
    public SystemUser lk_ait_cardformat_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_cardformat_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_cardformat_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_cardformat_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_cardformat_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_ait_cardformat")]
    public Organization organization_ait_cardformat
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_ait_cardformat), new EntityRole?());
      }
    }

    public ait_cardformat(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_cardformatid"] = (object) base.Id;
            break;
          case "ait_cardformatid":
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
