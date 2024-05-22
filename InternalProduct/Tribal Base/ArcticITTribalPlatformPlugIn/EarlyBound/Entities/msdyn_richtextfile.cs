// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_richtextfile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_richtextfile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_richtextfile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_richtextfile";
    public const string EntitySchemaName = "msdyn_richtextfile";
    public const string PrimaryIdAttribute = "msdyn_richtextfileid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_richtextfile()
      : base(nameof (msdyn_richtextfile))
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

    [AttributeLogicalName("msdyn_imageblob")]
    public byte[] msdyn_imageblob => this.GetAttributeValue<byte[]>(nameof (msdyn_imageblob));

    [AttributeLogicalName("msdyn_imageblob_timestamp")]
    public long? msdyn_imageblob_Timestamp
    {
      get => this.GetAttributeValue<long?>("msdyn_imageblob_timestamp");
    }

    [AttributeLogicalName("msdyn_imageblob_url")]
    public string msdyn_imageblob_URL => this.GetAttributeValue<string>("msdyn_imageblob_url");

    [AttributeLogicalName("msdyn_imageblobid")]
    public Guid? msdyn_imageblobId => this.GetAttributeValue<Guid?>("msdyn_imageblobid");

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

    [AttributeLogicalName("msdyn_parententity_fieldname")]
    public string msdyn_parententity_fieldname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parententity_fieldname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parententity_fieldname));
        this.SetAttributeValue(nameof (msdyn_parententity_fieldname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parententity_fieldname));
      }
    }

    [AttributeLogicalName("msdyn_parententityname")]
    public string msdyn_parententityname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parententityname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parententityname));
        this.SetAttributeValue(nameof (msdyn_parententityname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parententityname));
      }
    }

    [AttributeLogicalName("msdyn_parentid")]
    public string msdyn_parentid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_parentid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_parentid));
        this.SetAttributeValue(nameof (msdyn_parentid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_parentid));
      }
    }

    [AttributeLogicalName("msdyn_richtextfileid")]
    public Guid? msdyn_richtextfileId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_richtextfileid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfileId));
        this.SetAttributeValue("msdyn_richtextfileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_richtextfileId));
      }
    }

    [AttributeLogicalName("msdyn_richtextfileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_richtextfileId = new Guid?(value);
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
    public msdyn_richtextfileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new msdyn_richtextfileState?((msdyn_richtextfileState) Enum.ToObject(typeof (msdyn_richtextfileState), attributeValue.Value)) : new msdyn_richtextfileState?();
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

    [RelationshipSchemaName("msdyn_richtextfile_AsyncOperations")]
    public IEnumerable<AsyncOperation> msdyn_richtextfile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (msdyn_richtextfile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (msdyn_richtextfile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("msdyn_richtextfile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> msdyn_richtextfile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_richtextfile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (msdyn_richtextfile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("msdyn_richtextfile_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> msdyn_richtextfile_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_richtextfile_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (msdyn_richtextfile_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("msdyn_richtextfile_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> msdyn_richtextfile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_richtextfile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (msdyn_richtextfile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("msdyn_richtextfile_ProcessSession")]
    public IEnumerable<ProcessSession> msdyn_richtextfile_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (msdyn_richtextfile_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (msdyn_richtextfile_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_ProcessSession));
      }
    }

    [RelationshipSchemaName("msdyn_richtextfile_SyncErrors")]
    public IEnumerable<SyncError> msdyn_richtextfile_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (msdyn_richtextfile_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (msdyn_richtextfile_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_SyncErrors));
      }
    }

    [RelationshipSchemaName("msdyn_richtextfile_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> msdyn_richtextfile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_richtextfile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (msdyn_richtextfile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_msdyn_richtextfile")]
    public BusinessUnit business_unit_msdyn_richtextfile
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_msdyn_richtextfile), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_msdyn_richtextfile_createdby")]
    public SystemUser lk_msdyn_richtextfile_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_richtextfile_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_richtextfile_createdonbehalfby")]
    public SystemUser lk_msdyn_richtextfile_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_richtextfile_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_richtextfile_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_richtextfile_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_richtextfile_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_msdyn_richtextfile_modifiedby")]
    public SystemUser lk_msdyn_richtextfile_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_richtextfile_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_msdyn_richtextfile_modifiedonbehalfby")]
    public SystemUser lk_msdyn_richtextfile_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_msdyn_richtextfile_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_msdyn_richtextfile_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_msdyn_richtextfile_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_msdyn_richtextfile_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_msdyn_richtextfile")]
    public Team team_msdyn_richtextfile
    {
      get => this.GetRelatedEntity<Team>(nameof (team_msdyn_richtextfile), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_msdyn_richtextfile")]
    public SystemUser user_msdyn_richtextfile
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_msdyn_richtextfile), new EntityRole?());
    }

    public msdyn_richtextfile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_richtextfileid"] = (object) base.Id;
            break;
          case "msdyn_richtextfileid":
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
