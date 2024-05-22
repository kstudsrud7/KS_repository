// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_accountingcode
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_accountingcode")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_accountingcode : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_accountingcode";
    public const string EntitySchemaName = "ait_accountingcode";
    public const string PrimaryIdAttribute = "ait_accountingcodeid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_accountingcode()
      : base(nameof (ait_accountingcode))
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

    [AttributeLogicalName("ait_accountingcodeid")]
    public Guid? ait_accountingcodeId
    {
      get => this.GetAttributeValue<Guid?>("ait_accountingcodeid");
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcodeId));
        this.SetAttributeValue("ait_accountingcodeid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_accountingcodeId));
      }
    }

    [AttributeLogicalName("ait_accountingcodeid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_accountingcodeId = new Guid?(value);
    }

    [AttributeLogicalName("ait_description")]
    public string ait_Description
    {
      get => this.GetAttributeValue<string>("ait_description");
      set
      {
        this.OnPropertyChanging(nameof (ait_Description));
        this.SetAttributeValue("ait_description", (object) value);
        this.OnPropertyChanged(nameof (ait_Description));
      }
    }

    [AttributeLogicalName("ait_loantypeid")]
    public EntityReference ait_loantypeid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_loantypeid));
      set
      {
        this.OnPropertyChanging(nameof (ait_loantypeid));
        this.SetAttributeValue(nameof (ait_loantypeid), (object) value);
        this.OnPropertyChanged(nameof (ait_loantypeid));
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
    public ait_accountingcodeState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_accountingcodeState?((ait_accountingcodeState) Enum.ToObject(typeof (ait_accountingcodeState), attributeValue.Value)) : new ait_accountingcodeState?();
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

    [RelationshipSchemaName("ait_accountingcode_Annotations")]
    public IEnumerable<Annotation> ait_accountingcode_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_accountingcode_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_accountingcode_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_Annotations));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_accountingcode_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_accountingcode_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_accountingcode_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_accountingcode_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_accountingcode_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_accountingcode_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_loan")]
    public IEnumerable<ait_loan> ait_accountingcode_loan
    {
      get => this.GetRelatedEntities<ait_loan>(nameof (ait_accountingcode_loan), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_loan));
        this.SetRelatedEntities<ait_loan>(nameof (ait_accountingcode_loan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_loan));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_accountingcode_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_accountingcode_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_accountingcode_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_accountingcode_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_accountingcode_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_accountingcode_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_ProcessSession")]
    public IEnumerable<ProcessSession> ait_accountingcode_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_accountingcode_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_accountingcode_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_SyncErrors")]
    public IEnumerable<SyncError> ait_accountingcode_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_accountingcode_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_accountingcode_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_accountingcode_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_accountingcode_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_accountingcode_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_UserEntityInstanceDatas));
      }
    }

    [RelationshipSchemaName("ait_accountingcode_withholdingtype")]
    public IEnumerable<ait_withholdingtype> ait_accountingcode_withholdingtype
    {
      get
      {
        return this.GetRelatedEntities<ait_withholdingtype>(nameof (ait_accountingcode_withholdingtype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_withholdingtype));
        this.SetRelatedEntities<ait_withholdingtype>(nameof (ait_accountingcode_withholdingtype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_withholdingtype));
      }
    }

    [RelationshipSchemaName("ait_ait_accountingcode_ait_pmtwithholding_AccountingCode")]
    public IEnumerable<ait_pmtwithholding> ait_ait_accountingcode_ait_pmtwithholding_AccountingCode
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholding>(nameof (ait_ait_accountingcode_ait_pmtwithholding_AccountingCode), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_accountingcode_ait_pmtwithholding_AccountingCode));
        this.SetRelatedEntities<ait_pmtwithholding>(nameof (ait_ait_accountingcode_ait_pmtwithholding_AccountingCode), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_accountingcode_ait_pmtwithholding_AccountingCode));
      }
    }

    [AttributeLogicalName("ait_loantypeid")]
    [RelationshipSchemaName("ait_loantype_accountingcode")]
    public ait_loantype ait_loantype_accountingcode
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_accountingcode), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loantype_accountingcode));
        this.SetRelatedEntity<ait_loantype>(nameof (ait_loantype_accountingcode), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loantype_accountingcode));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_accountingcode")]
    public BusinessUnit business_unit_ait_accountingcode
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_accountingcode), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_accountingcode_createdby")]
    public SystemUser lk_ait_accountingcode_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_accountingcode_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_accountingcode_createdonbehalfby")]
    public SystemUser lk_ait_accountingcode_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_accountingcode_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_accountingcode_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_accountingcode_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_accountingcode_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_accountingcode_modifiedby")]
    public SystemUser lk_ait_accountingcode_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_accountingcode_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_accountingcode_modifiedonbehalfby")]
    public SystemUser lk_ait_accountingcode_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_accountingcode_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_accountingcode_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_accountingcode_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_accountingcode_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_accountingcode")]
    public Team team_ait_accountingcode
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_accountingcode), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_accountingcode")]
    public SystemUser user_ait_accountingcode
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_accountingcode), new EntityRole?());
    }

    public ait_accountingcode(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_accountingcodeid"] = (object) base.Id;
            break;
          case "ait_accountingcodeid":
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
