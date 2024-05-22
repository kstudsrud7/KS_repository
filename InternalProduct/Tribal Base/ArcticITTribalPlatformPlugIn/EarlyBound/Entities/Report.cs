// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Report
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("report")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Report : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "report";
    public const string EntitySchemaName = "Report";
    public const string PrimaryIdAttribute = "reportid";
    public const string PrimaryNameAttribute = "name";

    public Report()
      : base("report")
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

    [AttributeLogicalName("bodybinary")]
    public string BodyBinary
    {
      get => this.GetAttributeValue<string>("bodybinary");
      set
      {
        this.OnPropertyChanging(nameof (BodyBinary));
        this.SetAttributeValue("bodybinary", (object) value);
        this.OnPropertyChanged(nameof (BodyBinary));
      }
    }

    [AttributeLogicalName("bodytext")]
    public string BodyText
    {
      get => this.GetAttributeValue<string>("bodytext");
      set
      {
        this.OnPropertyChanging(nameof (BodyText));
        this.SetAttributeValue("bodytext", (object) value);
        this.OnPropertyChanged(nameof (BodyText));
      }
    }

    [AttributeLogicalName("bodyurl")]
    public string BodyUrl
    {
      get => this.GetAttributeValue<string>("bodyurl");
      set
      {
        this.OnPropertyChanging(nameof (BodyUrl));
        this.SetAttributeValue("bodyurl", (object) value);
        this.OnPropertyChanged(nameof (BodyUrl));
      }
    }

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdinmajorversion")]
    public int? CreatedInMajorVersion
    {
      get => this.GetAttributeValue<int?>("createdinmajorversion");
      set
      {
        this.OnPropertyChanging(nameof (CreatedInMajorVersion));
        this.SetAttributeValue("createdinmajorversion", (object) value);
        this.OnPropertyChanged(nameof (CreatedInMajorVersion));
      }
    }

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

    [AttributeLogicalName("customreportxml")]
    public string CustomReportXml => this.GetAttributeValue<string>("customreportxml");

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

    [AttributeLogicalName("iscustomreport")]
    public bool? IsCustomReport => this.GetAttributeValue<bool?>("iscustomreport");

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

    [AttributeLogicalName("isscheduledreport")]
    public bool? IsScheduledReport => this.GetAttributeValue<bool?>("isscheduledreport");

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

    [AttributeLogicalName("originalbodytext")]
    public string OriginalBodyText => this.GetAttributeValue<string>("originalbodytext");

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

    [AttributeLogicalName("parentreportid")]
    public EntityReference ParentReportId
    {
      get => this.GetAttributeValue<EntityReference>("parentreportid");
      set
      {
        this.OnPropertyChanging(nameof (ParentReportId));
        this.SetAttributeValue("parentreportid", (object) value);
        this.OnPropertyChanged(nameof (ParentReportId));
      }
    }

    [AttributeLogicalName("queryinfo")]
    public string QueryInfo => this.GetAttributeValue<string>("queryinfo");

    [AttributeLogicalName("rdlhash")]
    public int? RdlHash => this.GetAttributeValue<int?>("rdlhash");

    [AttributeLogicalName("reportid")]
    public Guid? ReportId
    {
      get => this.GetAttributeValue<Guid?>("reportid");
      set
      {
        this.OnPropertyChanging(nameof (ReportId));
        this.SetAttributeValue("reportid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ReportId));
      }
    }

    [AttributeLogicalName("reportid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ReportId = new Guid?(value);
    }

    [AttributeLogicalName("reportidunique")]
    public Guid? ReportIdUnique => this.GetAttributeValue<Guid?>("reportidunique");

    [AttributeLogicalName("reportnameonsrs")]
    public string ReportNameOnSRS => this.GetAttributeValue<string>("reportnameonsrs");

    [AttributeLogicalName("reporttypecode")]
    public OptionSetValue ReportTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("reporttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ReportTypeCode));
        this.SetAttributeValue("reporttypecode", (object) value);
        this.OnPropertyChanged(nameof (ReportTypeCode));
      }
    }

    [AttributeLogicalName("schedulexml")]
    public string ScheduleXml => this.GetAttributeValue<string>("schedulexml");

    [AttributeLogicalName("signaturedate")]
    public DateTime? SignatureDate
    {
      get => this.GetAttributeValue<DateTime?>("signaturedate");
      set
      {
        this.OnPropertyChanging(nameof (SignatureDate));
        this.SetAttributeValue("signaturedate", (object) value);
        this.OnPropertyChanged(nameof (SignatureDate));
      }
    }

    [AttributeLogicalName("signatureid")]
    public Guid? SignatureId
    {
      get => this.GetAttributeValue<Guid?>("signatureid");
      set
      {
        this.OnPropertyChanging(nameof (SignatureId));
        this.SetAttributeValue("signatureid", (object) value);
        this.OnPropertyChanged(nameof (SignatureId));
      }
    }

    [AttributeLogicalName("signaturelcid")]
    public int? SignatureLcid
    {
      get => this.GetAttributeValue<int?>("signaturelcid");
      set
      {
        this.OnPropertyChanging(nameof (SignatureLcid));
        this.SetAttributeValue("signaturelcid", (object) value);
        this.OnPropertyChanged(nameof (SignatureLcid));
      }
    }

    [AttributeLogicalName("signaturemajorversion")]
    public int? SignatureMajorVersion
    {
      get => this.GetAttributeValue<int?>("signaturemajorversion");
      set
      {
        this.OnPropertyChanging(nameof (SignatureMajorVersion));
        this.SetAttributeValue("signaturemajorversion", (object) value);
        this.OnPropertyChanged(nameof (SignatureMajorVersion));
      }
    }

    [AttributeLogicalName("signatureminorversion")]
    public int? SignatureMinorVersion
    {
      get => this.GetAttributeValue<int?>("signatureminorversion");
      set
      {
        this.OnPropertyChanging(nameof (SignatureMinorVersion));
        this.SetAttributeValue("signatureminorversion", (object) value);
        this.OnPropertyChanged(nameof (SignatureMinorVersion));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

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

    [RelationshipSchemaName("Report_AsyncOperations")]
    public IEnumerable<AsyncOperation> Report_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Report_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Report_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Report_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Report_AsyncOperations));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Report> Referencedreport_parent_report
    {
      get
      {
        return this.GetRelatedEntities<Report>("report_parent_report", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedreport_parent_report));
        this.SetRelatedEntities<Report>("report_parent_report", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedreport_parent_report));
      }
    }

    [RelationshipSchemaName("Report_ProcessSessions")]
    public IEnumerable<ProcessSession> Report_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (Report_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Report_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (Report_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Report_ProcessSessions));
      }
    }

    [RelationshipSchemaName("report_reportcategories")]
    public IEnumerable<ReportCategory> report_reportcategories
    {
      get
      {
        return this.GetRelatedEntities<ReportCategory>(nameof (report_reportcategories), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (report_reportcategories));
        this.SetRelatedEntities<ReportCategory>(nameof (report_reportcategories), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportcategories));
      }
    }

    [RelationshipSchemaName("report_reportentities")]
    public IEnumerable<ReportEntity> report_reportentities
    {
      get
      {
        return this.GetRelatedEntities<ReportEntity>(nameof (report_reportentities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (report_reportentities));
        this.SetRelatedEntities<ReportEntity>(nameof (report_reportentities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportentities));
      }
    }

    [RelationshipSchemaName("report_reportlink")]
    public IEnumerable<ReportLink> report_reportlink
    {
      get => this.GetRelatedEntities<ReportLink>(nameof (report_reportlink), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (report_reportlink));
        this.SetRelatedEntities<ReportLink>(nameof (report_reportlink), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportlink));
      }
    }

    [RelationshipSchemaName("report_reportlink_sub")]
    public IEnumerable<ReportLink> report_reportlink_sub
    {
      get => this.GetRelatedEntities<ReportLink>(nameof (report_reportlink_sub), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (report_reportlink_sub));
        this.SetRelatedEntities<ReportLink>(nameof (report_reportlink_sub), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportlink_sub));
      }
    }

    [RelationshipSchemaName("report_reportvisibility")]
    public IEnumerable<ReportVisibility> report_reportvisibility
    {
      get
      {
        return this.GetRelatedEntities<ReportVisibility>(nameof (report_reportvisibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (report_reportvisibility));
        this.SetRelatedEntities<ReportVisibility>(nameof (report_reportvisibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (report_reportvisibility));
      }
    }

    [RelationshipSchemaName("Report_SyncErrors")]
    public IEnumerable<SyncError> Report_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Report_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Report_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Report_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Report_SyncErrors));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_report")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_report
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_report), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_report));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_report), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_report));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_reports")]
    public BusinessUnit business_unit_reports
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_reports), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_report_createdonbehalfby")]
    public SystemUser lk_report_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_report_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_report_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_report_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_report_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_report_modifiedonbehalfby")]
    public SystemUser lk_report_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_report_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_report_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_report_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_report_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_reportbase_createdby")]
    public SystemUser lk_reportbase_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_reportbase_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_reportbase_modifiedby")]
    public SystemUser lk_reportbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_reportbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("parentreportid")]
    [RelationshipSchemaName]
    public Report Referencingreport_parent_report
    {
      get => this.GetRelatedEntity<Report>("report_parent_report", new EntityRole?((EntityRole) 0));
      set
      {
        this.OnPropertyChanging(nameof (Referencingreport_parent_report));
        this.SetRelatedEntity<Report>("report_parent_report", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingreport_parent_report));
      }
    }

    public Report(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["reportid"] = (object) base.Id;
            break;
          case "reportid":
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
