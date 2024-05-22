// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ImportFile
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("importfile")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ImportFile : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "importfile";
    public const string EntitySchemaName = "ImportFile";
    public const string PrimaryIdAttribute = "importfileid";
    public const string PrimaryNameAttribute = "name";

    public ImportFile()
      : base("importfile")
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

    [AttributeLogicalName("additionalheaderrow")]
    public string AdditionalHeaderRow => this.GetAttributeValue<string>("additionalheaderrow");

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn => this.GetAttributeValue<DateTime?>("completedon");

    [AttributeLogicalName("content")]
    public string Content
    {
      get => this.GetAttributeValue<string>("content");
      set
      {
        this.OnPropertyChanging(nameof (Content));
        this.SetAttributeValue("content", (object) value);
        this.OnPropertyChanged(nameof (Content));
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

    [AttributeLogicalName("datadelimitercode")]
    public OptionSetValue DataDelimiterCode
    {
      get => this.GetAttributeValue<OptionSetValue>("datadelimitercode");
      set
      {
        this.OnPropertyChanging(nameof (DataDelimiterCode));
        this.SetAttributeValue("datadelimitercode", (object) value);
        this.OnPropertyChanged(nameof (DataDelimiterCode));
      }
    }

    [AttributeLogicalName("enableduplicatedetection")]
    public bool? EnableDuplicateDetection
    {
      get => this.GetAttributeValue<bool?>("enableduplicatedetection");
      set
      {
        this.OnPropertyChanging(nameof (EnableDuplicateDetection));
        this.SetAttributeValue("enableduplicatedetection", (object) value);
        this.OnPropertyChanged(nameof (EnableDuplicateDetection));
      }
    }

    [AttributeLogicalName("entitykeyid")]
    public Guid? EntityKeyId
    {
      get => this.GetAttributeValue<Guid?>("entitykeyid");
      set
      {
        this.OnPropertyChanging(nameof (EntityKeyId));
        this.SetAttributeValue("entitykeyid", (object) value);
        this.OnPropertyChanged(nameof (EntityKeyId));
      }
    }

    [AttributeLogicalName("failurecount")]
    public int? FailureCount => this.GetAttributeValue<int?>("failurecount");

    [AttributeLogicalName("fielddelimitercode")]
    public OptionSetValue FieldDelimiterCode
    {
      get => this.GetAttributeValue<OptionSetValue>("fielddelimitercode");
      set
      {
        this.OnPropertyChanging(nameof (FieldDelimiterCode));
        this.SetAttributeValue("fielddelimitercode", (object) value);
        this.OnPropertyChanged(nameof (FieldDelimiterCode));
      }
    }

    [AttributeLogicalName("filetypecode")]
    public OptionSetValue FileTypeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("filetypecode");
      set
      {
        this.OnPropertyChanging(nameof (FileTypeCode));
        this.SetAttributeValue("filetypecode", (object) value);
        this.OnPropertyChanged(nameof (FileTypeCode));
      }
    }

    [AttributeLogicalName("headerrow")]
    public string HeaderRow => this.GetAttributeValue<string>("headerrow");

    [AttributeLogicalName("importfileid")]
    public Guid? ImportFileId
    {
      get => this.GetAttributeValue<Guid?>("importfileid");
      set
      {
        this.OnPropertyChanging(nameof (ImportFileId));
        this.SetAttributeValue("importfileid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ImportFileId));
      }
    }

    [AttributeLogicalName("importfileid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ImportFileId = new Guid?(value);
    }

    [AttributeLogicalName("importid")]
    public EntityReference ImportId
    {
      get => this.GetAttributeValue<EntityReference>("importid");
      set
      {
        this.OnPropertyChanging(nameof (ImportId));
        this.SetAttributeValue("importid", (object) value);
        this.OnPropertyChanged(nameof (ImportId));
      }
    }

    [AttributeLogicalName("importmapid")]
    public EntityReference ImportMapId
    {
      get => this.GetAttributeValue<EntityReference>("importmapid");
      set
      {
        this.OnPropertyChanging(nameof (ImportMapId));
        this.SetAttributeValue("importmapid", (object) value);
        this.OnPropertyChanged(nameof (ImportMapId));
      }
    }

    [AttributeLogicalName("isfirstrowheader")]
    public bool? IsFirstRowHeader
    {
      get => this.GetAttributeValue<bool?>("isfirstrowheader");
      set
      {
        this.OnPropertyChanging(nameof (IsFirstRowHeader));
        this.SetAttributeValue("isfirstrowheader", (object) value);
        this.OnPropertyChanged(nameof (IsFirstRowHeader));
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

    [AttributeLogicalName("parsedtablecolumnprefix")]
    public string ParsedTableColumnPrefix
    {
      get => this.GetAttributeValue<string>("parsedtablecolumnprefix");
    }

    [AttributeLogicalName("parsedtablecolumnsnumber")]
    public int? ParsedTableColumnsNumber
    {
      get => this.GetAttributeValue<int?>("parsedtablecolumnsnumber");
    }

    [AttributeLogicalName("parsedtablename")]
    public string ParsedTableName => this.GetAttributeValue<string>("parsedtablename");

    [AttributeLogicalName("partialfailurecount")]
    public int? PartialFailureCount => this.GetAttributeValue<int?>("partialfailurecount");

    [AttributeLogicalName("processcode")]
    public OptionSetValue ProcessCode
    {
      get => this.GetAttributeValue<OptionSetValue>("processcode");
      set
      {
        this.OnPropertyChanging(nameof (ProcessCode));
        this.SetAttributeValue("processcode", (object) value);
        this.OnPropertyChanged(nameof (ProcessCode));
      }
    }

    [AttributeLogicalName("processingstatus")]
    public OptionSetValue ProcessingStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("processingstatus");
    }

    [AttributeLogicalName("progresscounter")]
    public int? ProgressCounter => this.GetAttributeValue<int?>("progresscounter");

    [AttributeLogicalName("recordsownerid")]
    public EntityReference RecordsOwnerId
    {
      get => this.GetAttributeValue<EntityReference>("recordsownerid");
      set
      {
        this.OnPropertyChanging(nameof (RecordsOwnerId));
        this.SetAttributeValue("recordsownerid", (object) value);
        this.OnPropertyChanged(nameof (RecordsOwnerId));
      }
    }

    [AttributeLogicalName("relatedentitycolumns")]
    public string RelatedEntityColumns
    {
      get => this.GetAttributeValue<string>("relatedentitycolumns");
      set
      {
        this.OnPropertyChanging(nameof (RelatedEntityColumns));
        this.SetAttributeValue("relatedentitycolumns", (object) value);
        this.OnPropertyChanged(nameof (RelatedEntityColumns));
      }
    }

    [AttributeLogicalName("size")]
    public string Size
    {
      get => this.GetAttributeValue<string>("size");
      set
      {
        this.OnPropertyChanging(nameof (Size));
        this.SetAttributeValue("size", (object) value);
        this.OnPropertyChanged(nameof (Size));
      }
    }

    [AttributeLogicalName("source")]
    public string Source
    {
      get => this.GetAttributeValue<string>("source");
      set
      {
        this.OnPropertyChanging(nameof (Source));
        this.SetAttributeValue("source", (object) value);
        this.OnPropertyChanged(nameof (Source));
      }
    }

    [AttributeLogicalName("sourceentityname")]
    public string SourceEntityName
    {
      get => this.GetAttributeValue<string>("sourceentityname");
      set
      {
        this.OnPropertyChanging(nameof (SourceEntityName));
        this.SetAttributeValue("sourceentityname", (object) value);
        this.OnPropertyChanged(nameof (SourceEntityName));
      }
    }

    [AttributeLogicalName("statecode")]
    public ImportFileState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ImportFileState?((ImportFileState) Enum.ToObject(typeof (ImportFileState), attributeValue.Value)) : new ImportFileState?();
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

    [AttributeLogicalName("successcount")]
    public int? SuccessCount => this.GetAttributeValue<int?>("successcount");

    [AttributeLogicalName("targetentityname")]
    public string TargetEntityName
    {
      get => this.GetAttributeValue<string>("targetentityname");
      set
      {
        this.OnPropertyChanging(nameof (TargetEntityName));
        this.SetAttributeValue("targetentityname", (object) value);
        this.OnPropertyChanged(nameof (TargetEntityName));
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

    [AttributeLogicalName("totalcount")]
    public int? TotalCount => this.GetAttributeValue<int?>("totalcount");

    [AttributeLogicalName("upsertmodecode")]
    public OptionSetValue UpsertModeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("upsertmodecode");
      set
      {
        this.OnPropertyChanging(nameof (UpsertModeCode));
        this.SetAttributeValue("upsertmodecode", (object) value);
        this.OnPropertyChanged(nameof (UpsertModeCode));
      }
    }

    [AttributeLogicalName("usesystemmap")]
    public bool? UseSystemMap
    {
      get => this.GetAttributeValue<bool?>("usesystemmap");
      set
      {
        this.OnPropertyChanging(nameof (UseSystemMap));
        this.SetAttributeValue("usesystemmap", (object) value);
        this.OnPropertyChanged(nameof (UseSystemMap));
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

    [RelationshipSchemaName("ImportFile_AsyncOperations")]
    public IEnumerable<AsyncOperation> ImportFile_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ImportFile_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportFile_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ImportFile_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportFile_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ImportFile_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ImportFile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ImportFile_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportFile_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ImportFile_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportFile_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ImportLog_ImportFile")]
    public IEnumerable<ImportLog> ImportLog_ImportFile
    {
      get => this.GetRelatedEntities<ImportLog>(nameof (ImportLog_ImportFile), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportLog_ImportFile));
        this.SetRelatedEntities<ImportLog>(nameof (ImportLog_ImportFile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportLog_ImportFile));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_importfile")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_importfile
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importfile));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importfile));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("BusinessUnit_ImportFiles")]
    public BusinessUnit BusinessUnit_ImportFiles
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_ImportFiles), new EntityRole?());
      }
    }

    [AttributeLogicalName("importid")]
    [RelationshipSchemaName("Import_ImportFile")]
    public Import Import_ImportFile
    {
      get => this.GetRelatedEntity<Import>(nameof (Import_ImportFile), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Import_ImportFile));
        this.SetRelatedEntity<Import>(nameof (Import_ImportFile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Import_ImportFile));
      }
    }

    [AttributeLogicalName("recordsownerid")]
    [RelationshipSchemaName("ImportFile_SystemUser")]
    public SystemUser ImportFile_SystemUser
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (ImportFile_SystemUser), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportFile_SystemUser));
        this.SetRelatedEntity<SystemUser>(nameof (ImportFile_SystemUser), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportFile_SystemUser));
      }
    }

    [AttributeLogicalName("recordsownerid")]
    [RelationshipSchemaName("ImportFile_Team")]
    public Team ImportFile_Team
    {
      get => this.GetRelatedEntity<Team>(nameof (ImportFile_Team), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportFile_Team));
        this.SetRelatedEntity<Team>(nameof (ImportFile_Team), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportFile_Team));
      }
    }

    [AttributeLogicalName("importmapid")]
    [RelationshipSchemaName("ImportMap_ImportFile")]
    public ImportMap ImportMap_ImportFile
    {
      get => this.GetRelatedEntity<ImportMap>(nameof (ImportMap_ImportFile), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportMap_ImportFile));
        this.SetRelatedEntity<ImportMap>(nameof (ImportMap_ImportFile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportMap_ImportFile));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_importfilebase_createdby")]
    public SystemUser lk_importfilebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importfilebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_importfilebase_createdonbehalfby")]
    public SystemUser lk_importfilebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importfilebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importfilebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importfilebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importfilebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_importfilebase_modifiedby")]
    public SystemUser lk_importfilebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importfilebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_importfilebase_modifiedonbehalfby")]
    public SystemUser lk_importfilebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importfilebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importfilebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importfilebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importfilebase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("SystemUser_ImportFiles")]
    public SystemUser SystemUser_ImportFiles
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (SystemUser_ImportFiles), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ImportFiles")]
    public Team team_ImportFiles
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ImportFiles), new EntityRole?());
    }

    public ImportFile(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["importfileid"] = (object) base.Id;
            break;
          case "importfileid":
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
