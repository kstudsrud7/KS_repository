// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_bankaccount
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_bankaccount")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_bankaccount : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_bankaccount";
    public const string EntitySchemaName = "ait_bankaccount";
    public const string PrimaryIdAttribute = "ait_bankaccountid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_bankaccount()
      : base(nameof (ait_bankaccount))
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

    [AttributeLogicalName("ait_accountnumber")]
    public string ait_AccountNumber
    {
      get => this.GetAttributeValue<string>("ait_accountnumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_AccountNumber));
        this.SetAttributeValue("ait_accountnumber", (object) value);
        this.OnPropertyChanged(nameof (ait_AccountNumber));
      }
    }

    [AttributeLogicalName("ait_bankaccountid")]
    public Guid? ait_bankaccountId
    {
      get => this.GetAttributeValue<Guid?>("ait_bankaccountid");
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccountId));
        this.SetAttributeValue("ait_bankaccountid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_bankaccountId));
      }
    }

    [AttributeLogicalName("ait_bankaccountid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_bankaccountId = new Guid?(value);
    }

    [AttributeLogicalName("ait_bankaccounttypeid")]
    public EntityReference ait_bankaccounttypeid
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_bankaccounttypeid));
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccounttypeid));
        this.SetAttributeValue(nameof (ait_bankaccounttypeid), (object) value);
        this.OnPropertyChanged(nameof (ait_bankaccounttypeid));
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

    [AttributeLogicalName("ait_routingnumber")]
    public string ait_RoutingNumber
    {
      get => this.GetAttributeValue<string>("ait_routingnumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_RoutingNumber));
        this.SetAttributeValue("ait_routingnumber", (object) value);
        this.OnPropertyChanged(nameof (ait_RoutingNumber));
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
    public ait_bankaccountState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_bankaccountState?((ait_bankaccountState) Enum.ToObject(typeof (ait_bankaccountState), attributeValue.Value)) : new ait_bankaccountState?();
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

    [RelationshipSchemaName("ait_ait_bankaccount_ait_pmtwithholding_BankAccount")]
    public IEnumerable<ait_pmtwithholding> ait_ait_bankaccount_ait_pmtwithholding_BankAccount
    {
      get
      {
        return this.GetRelatedEntities<ait_pmtwithholding>(nameof (ait_ait_bankaccount_ait_pmtwithholding_BankAccount), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_bankaccount_ait_pmtwithholding_BankAccount));
        this.SetRelatedEntities<ait_pmtwithholding>(nameof (ait_ait_bankaccount_ait_pmtwithholding_BankAccount), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_bankaccount_ait_pmtwithholding_BankAccount));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_Annotations")]
    public IEnumerable<Annotation> ait_bankaccount_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_bankaccount_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_bankaccount_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_Annotations));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_bankaccount_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_bankaccount_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_bankaccount_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_bankaccount_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_bankaccount_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_bankaccount_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_bankaccount_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_bankaccount_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_bankaccount_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_pmttransactiondeducti")]
    public IEnumerable<ait_pmttransactiondeduction> ait_bankaccount_pmttransactiondeducti
    {
      get
      {
        return this.GetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_bankaccount_pmttransactiondeducti), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_pmttransactiondeducti));
        this.SetRelatedEntities<ait_pmttransactiondeduction>(nameof (ait_bankaccount_pmttransactiondeducti), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_pmttransactiondeducti));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_bankaccount_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_bankaccount_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_bankaccount_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_ProcessSession")]
    public IEnumerable<ProcessSession> ait_bankaccount_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_bankaccount_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_bankaccount_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_SyncErrors")]
    public IEnumerable<SyncError> ait_bankaccount_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_bankaccount_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_bankaccount_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_bankaccount_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_bankaccount_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_bankaccount_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_bankaccount_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_bankaccounttypeid")]
    [RelationshipSchemaName("ait_bankaccounttype_bankaccount")]
    public ait_bankaccounttype ait_bankaccounttype_bankaccount
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_bankaccount), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccounttype_bankaccount));
        this.SetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_bankaccount), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccounttype_bankaccount));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_bankaccount")]
    public BusinessUnit business_unit_ait_bankaccount
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_bankaccount), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_bankaccount_createdby")]
    public SystemUser lk_ait_bankaccount_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_bankaccount_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_bankaccount_createdonbehalfby")]
    public SystemUser lk_ait_bankaccount_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_bankaccount_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_bankaccount_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_bankaccount_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_bankaccount_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_bankaccount_modifiedby")]
    public SystemUser lk_ait_bankaccount_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_bankaccount_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_bankaccount_modifiedonbehalfby")]
    public SystemUser lk_ait_bankaccount_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_bankaccount_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_bankaccount_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_bankaccount_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_bankaccount_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_bankaccount")]
    public Team team_ait_bankaccount
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_bankaccount), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_bankaccount")]
    public SystemUser user_ait_bankaccount
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_bankaccount), new EntityRole?());
    }

    public ait_bankaccount(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_bankaccountid"] = (object) base.Id;
            break;
          case "ait_bankaccountid":
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
