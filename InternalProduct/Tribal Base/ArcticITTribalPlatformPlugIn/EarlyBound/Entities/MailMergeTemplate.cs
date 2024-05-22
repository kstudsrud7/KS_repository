// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.MailMergeTemplate
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mailmergetemplate")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class MailMergeTemplate : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mailmergetemplate";
    public const string EntitySchemaName = "MailMergeTemplate";
    public const string PrimaryIdAttribute = "mailmergetemplateid";
    public const string PrimaryNameAttribute = "name";

    public MailMergeTemplate()
      : base("mailmergetemplate")
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

    [AttributeLogicalName("body")]
    public string Body
    {
      get => this.GetAttributeValue<string>("body");
      set
      {
        this.OnPropertyChanging(nameof (Body));
        this.SetAttributeValue("body", (object) value);
        this.OnPropertyChanged(nameof (Body));
      }
    }

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

    [AttributeLogicalName("defaultfilter")]
    public string DefaultFilter
    {
      get => this.GetAttributeValue<string>("defaultfilter");
      set
      {
        this.OnPropertyChanging(nameof (DefaultFilter));
        this.SetAttributeValue("defaultfilter", (object) value);
        this.OnPropertyChanged(nameof (DefaultFilter));
      }
    }

    [AttributeLogicalName("description")]
    public string Description
    {
      get => this.GetAttributeValue<string>("description");
      set
      {
        this.OnPropertyChanging(nameof (Description));
        this.SetAttributeValue("description", (object) value);
        this.OnPropertyChanged(nameof (Description));
      }
    }

    [AttributeLogicalName("documentformat")]
    public OptionSetValue DocumentFormat
    {
      get => this.GetAttributeValue<OptionSetValue>("documentformat");
      set
      {
        this.OnPropertyChanging(nameof (DocumentFormat));
        this.SetAttributeValue("documentformat", (object) value);
        this.OnPropertyChanged(nameof (DocumentFormat));
      }
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("filename")]
    public string FileName
    {
      get => this.GetAttributeValue<string>("filename");
      set
      {
        this.OnPropertyChanging(nameof (FileName));
        this.SetAttributeValue("filename", (object) value);
        this.OnPropertyChanged(nameof (FileName));
      }
    }

    [AttributeLogicalName("filesize")]
    public int? FileSize => this.GetAttributeValue<int?>("filesize");

    [AttributeLogicalName("introducedversion")]
    public string IntroducedVersion
    {
      get => this.GetAttributeValue<string>("introducedversion");
      set
      {
        this.OnPropertyChanging(nameof (IntroducedVersion));
        this.SetAttributeValue("introducedversion", (object) value);
        this.OnPropertyChanged(nameof (IntroducedVersion));
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

    [AttributeLogicalName("ispersonal")]
    public bool? IsPersonal
    {
      get => this.GetAttributeValue<bool?>("ispersonal");
      set
      {
        this.OnPropertyChanging(nameof (IsPersonal));
        this.SetAttributeValue("ispersonal", (object) value);
        this.OnPropertyChanged(nameof (IsPersonal));
      }
    }

    [AttributeLogicalName("languagecode")]
    public int? LanguageCode
    {
      get => this.GetAttributeValue<int?>("languagecode");
      set
      {
        this.OnPropertyChanging(nameof (LanguageCode));
        this.SetAttributeValue("languagecode", (object) value);
        this.OnPropertyChanged(nameof (LanguageCode));
      }
    }

    [AttributeLogicalName("mailmergetemplateid")]
    public Guid? MailMergeTemplateId
    {
      get => this.GetAttributeValue<Guid?>("mailmergetemplateid");
      set
      {
        this.OnPropertyChanging(nameof (MailMergeTemplateId));
        this.SetAttributeValue("mailmergetemplateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (MailMergeTemplateId));
      }
    }

    [AttributeLogicalName("mailmergetemplateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.MailMergeTemplateId = new Guid?(value);
    }

    [AttributeLogicalName("mailmergetemplateidunique")]
    public Guid? MailMergeTemplateIdUnique
    {
      get => this.GetAttributeValue<Guid?>("mailmergetemplateidunique");
    }

    [AttributeLogicalName("mailmergetype")]
    public OptionSetValue MailMergeType
    {
      get => this.GetAttributeValue<OptionSetValue>("mailmergetype");
      set
      {
        this.OnPropertyChanging(nameof (MailMergeType));
        this.SetAttributeValue("mailmergetype", (object) value);
        this.OnPropertyChanged(nameof (MailMergeType));
      }
    }

    [AttributeLogicalName("mimetype")]
    public string MimeType
    {
      get => this.GetAttributeValue<string>("mimetype");
      set
      {
        this.OnPropertyChanging(nameof (MimeType));
        this.SetAttributeValue("mimetype", (object) value);
        this.OnPropertyChanged(nameof (MimeType));
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

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

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

    [AttributeLogicalName("parameterxml")]
    public string ParameterXml => this.GetAttributeValue<string>("parameterxml");

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("statecode")]
    public MailMergeTemplateState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new MailMergeTemplateState?((MailMergeTemplateState) Enum.ToObject(typeof (MailMergeTemplateState), attributeValue.Value)) : new MailMergeTemplateState?();
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

    [AttributeLogicalName("templatetypecode")]
    public string TemplateTypeCode
    {
      get => this.GetAttributeValue<string>("templatetypecode");
      set
      {
        this.OnPropertyChanging(nameof (TemplateTypeCode));
        this.SetAttributeValue("templatetypecode", (object) value);
        this.OnPropertyChanged(nameof (TemplateTypeCode));
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

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrencyId));
        this.SetAttributeValue("transactioncurrencyid", (object) value);
        this.OnPropertyChanged(nameof (TransactionCurrencyId));
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

    [RelationshipSchemaName("MailMergeTemplate_AsyncOperations")]
    public IEnumerable<AsyncOperation> MailMergeTemplate_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (MailMergeTemplate_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MailMergeTemplate_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (MailMergeTemplate_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MailMergeTemplate_AsyncOperations));
      }
    }

    [RelationshipSchemaName("mailmergetemplate_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> mailmergetemplate_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (mailmergetemplate_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mailmergetemplate_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (mailmergetemplate_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailmergetemplate_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("MailMergeTemplate_ProcessSessions")]
    public IEnumerable<ProcessSession> MailMergeTemplate_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (MailMergeTemplate_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MailMergeTemplate_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (MailMergeTemplate_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MailMergeTemplate_ProcessSessions));
      }
    }

    [RelationshipSchemaName("MailMergeTemplate_SyncErrors")]
    public IEnumerable<SyncError> MailMergeTemplate_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (MailMergeTemplate_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (MailMergeTemplate_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (MailMergeTemplate_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (MailMergeTemplate_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_mailmergetemplate")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_mailmergetemplate
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_mailmergetemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_mailmergetemplate));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_mailmergetemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_mailmergetemplate));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_mailmergetemplates")]
    public BusinessUnit business_unit_mailmergetemplates
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_mailmergetemplates), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_mailmergetemplate_createdonbehalfby")]
    public SystemUser lk_mailmergetemplate_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailmergetemplate_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mailmergetemplate_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mailmergetemplate_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mailmergetemplate_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_mailmergetemplate_modifiedonbehalfby")]
    public SystemUser lk_mailmergetemplate_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailmergetemplate_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_mailmergetemplate_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_mailmergetemplate_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_mailmergetemplate_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_mailmergetemplatebase_createdby")]
    public SystemUser lk_mailmergetemplatebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailmergetemplatebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_mailmergetemplatebase_modifiedby")]
    public SystemUser lk_mailmergetemplatebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_mailmergetemplatebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_MailMergeTemplate")]
    public TransactionCurrency TransactionCurrency_MailMergeTemplate
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_MailMergeTemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_MailMergeTemplate));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_MailMergeTemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_MailMergeTemplate));
      }
    }

    public MailMergeTemplate(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mailmergetemplateid"] = (object) base.Id;
            break;
          case "mailmergetemplateid":
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
