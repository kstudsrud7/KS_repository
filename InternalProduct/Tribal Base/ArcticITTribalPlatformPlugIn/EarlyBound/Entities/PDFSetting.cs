// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PDFSetting
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("pdfsetting")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PDFSetting : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "pdfsetting";
    public const string EntitySchemaName = "PDFSetting";
    public const string PrimaryIdAttribute = "pdfsettingid";
    public const string PrimaryNameAttribute = "entityname";

    public PDFSetting()
      : base("pdfsetting")
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

    [AttributeLogicalName("entityname")]
    public string entityname
    {
      get => this.GetAttributeValue<string>(nameof (entityname));
      set
      {
        this.OnPropertyChanging(nameof (entityname));
        this.SetAttributeValue(nameof (entityname), (object) value);
        this.OnPropertyChanged(nameof (entityname));
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

    [AttributeLogicalName("ispdfsettingenabled")]
    public bool? ispdfsettingenabled
    {
      get => this.GetAttributeValue<bool?>(nameof (ispdfsettingenabled));
      set
      {
        this.OnPropertyChanging(nameof (ispdfsettingenabled));
        this.SetAttributeValue(nameof (ispdfsettingenabled), (object) value);
        this.OnPropertyChanged(nameof (ispdfsettingenabled));
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

    [AttributeLogicalName("pdfsettingid")]
    public Guid? PDFSettingId
    {
      get => this.GetAttributeValue<Guid?>("pdfsettingid");
      set
      {
        this.OnPropertyChanging(nameof (PDFSettingId));
        this.SetAttributeValue("pdfsettingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PDFSettingId));
      }
    }

    [AttributeLogicalName("pdfsettingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PDFSettingId = new Guid?(value);
    }

    [AttributeLogicalName("pdfsettingsjson")]
    public string pdfsettingsjson
    {
      get => this.GetAttributeValue<string>(nameof (pdfsettingsjson));
      set
      {
        this.OnPropertyChanging(nameof (pdfsettingsjson));
        this.SetAttributeValue(nameof (pdfsettingsjson), (object) value);
        this.OnPropertyChanged(nameof (pdfsettingsjson));
      }
    }

    [AttributeLogicalName("statecode")]
    public PDFSettingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new PDFSettingState?((PDFSettingState) Enum.ToObject(typeof (PDFSettingState), attributeValue.Value)) : new PDFSettingState?();
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

    [RelationshipSchemaName("pdfsetting_AsyncOperations")]
    public IEnumerable<AsyncOperation> pdfsetting_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (pdfsetting_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (pdfsetting_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_AsyncOperations));
      }
    }

    [RelationshipSchemaName("pdfsetting_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> pdfsetting_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (pdfsetting_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (pdfsetting_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("pdfsetting_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> pdfsetting_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (pdfsetting_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (pdfsetting_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("pdfsetting_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> pdfsetting_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (pdfsetting_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (pdfsetting_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("pdfsetting_ProcessSession")]
    public IEnumerable<ProcessSession> pdfsetting_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (pdfsetting_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (pdfsetting_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_ProcessSession));
      }
    }

    [RelationshipSchemaName("pdfsetting_SyncErrors")]
    public IEnumerable<SyncError> pdfsetting_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (pdfsetting_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (pdfsetting_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_SyncErrors));
      }
    }

    [RelationshipSchemaName("pdfsetting_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> pdfsetting_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (pdfsetting_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (pdfsetting_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_pdfsetting")]
    public BusinessUnit business_unit_pdfsetting
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_pdfsetting), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_pdfsetting_createdby")]
    public SystemUser lk_pdfsetting_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_pdfsetting_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_pdfsetting_createdonbehalfby")]
    public SystemUser lk_pdfsetting_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_pdfsetting_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_pdfsetting_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_pdfsetting_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_pdfsetting_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_pdfsetting_modifiedby")]
    public SystemUser lk_pdfsetting_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_pdfsetting_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_pdfsetting_modifiedonbehalfby")]
    public SystemUser lk_pdfsetting_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_pdfsetting_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_pdfsetting_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_pdfsetting_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_pdfsetting_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_pdfsetting")]
    public Team team_pdfsetting
    {
      get => this.GetRelatedEntity<Team>(nameof (team_pdfsetting), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_pdfsetting")]
    public SystemUser user_pdfsetting
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_pdfsetting), new EntityRole?());
    }

    public PDFSetting(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["pdfsettingid"] = (object) base.Id;
            break;
          case "pdfsettingid":
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
