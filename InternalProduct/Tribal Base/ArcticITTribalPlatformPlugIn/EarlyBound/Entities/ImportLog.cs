// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ImportLog
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("importlog")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ImportLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "importlog";
    public const string EntitySchemaName = "ImportLog";
    public const string PrimaryIdAttribute = "importlogid";

    public ImportLog()
      : base("importlog")
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

    [AttributeLogicalName("additionalinfo")]
    public string AdditionalInfo
    {
      get => this.GetAttributeValue<string>("additionalinfo");
      set
      {
        this.OnPropertyChanging(nameof (AdditionalInfo));
        this.SetAttributeValue("additionalinfo", (object) value);
        this.OnPropertyChanged(nameof (AdditionalInfo));
      }
    }

    [AttributeLogicalName("columnvalue")]
    public string ColumnValue
    {
      get => this.GetAttributeValue<string>("columnvalue");
      set
      {
        this.OnPropertyChanging(nameof (ColumnValue));
        this.SetAttributeValue("columnvalue", (object) value);
        this.OnPropertyChanged(nameof (ColumnValue));
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

    [AttributeLogicalName("errordescription")]
    public string ErrorDescription
    {
      get => this.GetAttributeValue<string>("errordescription");
      set
      {
        this.OnPropertyChanging(nameof (ErrorDescription));
        this.SetAttributeValue("errordescription", (object) value);
        this.OnPropertyChanged(nameof (ErrorDescription));
      }
    }

    [AttributeLogicalName("errornumber")]
    public int? ErrorNumber
    {
      get => this.GetAttributeValue<int?>("errornumber");
      set
      {
        this.OnPropertyChanging(nameof (ErrorNumber));
        this.SetAttributeValue("errornumber", (object) value);
        this.OnPropertyChanged(nameof (ErrorNumber));
      }
    }

    [AttributeLogicalName("headercolumn")]
    public string HeaderColumn
    {
      get => this.GetAttributeValue<string>("headercolumn");
      set
      {
        this.OnPropertyChanging(nameof (HeaderColumn));
        this.SetAttributeValue("headercolumn", (object) value);
        this.OnPropertyChanged(nameof (HeaderColumn));
      }
    }

    [AttributeLogicalName("importdataid")]
    public EntityReference ImportDataId
    {
      get => this.GetAttributeValue<EntityReference>("importdataid");
      set
      {
        this.OnPropertyChanging(nameof (ImportDataId));
        this.SetAttributeValue("importdataid", (object) value);
        this.OnPropertyChanged(nameof (ImportDataId));
      }
    }

    [AttributeLogicalName("importfileid")]
    public EntityReference ImportFileId
    {
      get => this.GetAttributeValue<EntityReference>("importfileid");
      set
      {
        this.OnPropertyChanging(nameof (ImportFileId));
        this.SetAttributeValue("importfileid", (object) value);
        this.OnPropertyChanged(nameof (ImportFileId));
      }
    }

    [AttributeLogicalName("importlogid")]
    public Guid? ImportLogId
    {
      get => this.GetAttributeValue<Guid?>("importlogid");
      set
      {
        this.OnPropertyChanging(nameof (ImportLogId));
        this.SetAttributeValue("importlogid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ImportLogId));
      }
    }

    [AttributeLogicalName("importlogid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ImportLogId = new Guid?(value);
    }

    [AttributeLogicalName("linenumber")]
    public int? LineNumber
    {
      get => this.GetAttributeValue<int?>("linenumber");
      set
      {
        this.OnPropertyChanging(nameof (LineNumber));
        this.SetAttributeValue("linenumber", (object) value);
        this.OnPropertyChanged(nameof (LineNumber));
      }
    }

    [AttributeLogicalName("logphasecode")]
    public OptionSetValue LogPhaseCode
    {
      get => this.GetAttributeValue<OptionSetValue>("logphasecode");
      set
      {
        this.OnPropertyChanging(nameof (LogPhaseCode));
        this.SetAttributeValue("logphasecode", (object) value);
        this.OnPropertyChanged(nameof (LogPhaseCode));
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

    [AttributeLogicalName("sequencenumber")]
    public int? SequenceNumber => this.GetAttributeValue<int?>("sequencenumber");

    [AttributeLogicalName("statecode")]
    public ImportLogState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ImportLogState?((ImportLogState) Enum.ToObject(typeof (ImportLogState), attributeValue.Value)) : new ImportLogState?();
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

    [RelationshipSchemaName("ImportLog_AsyncOperations")]
    public IEnumerable<AsyncOperation> ImportLog_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ImportLog_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportLog_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ImportLog_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportLog_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ImportLog_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ImportLog_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ImportLog_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ImportLog_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ImportLog_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportLog_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_importlog")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_importlog
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importlog), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importlog));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_importlog), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importlog));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("BusinessUnit_ImportLogs")]
    public BusinessUnit BusinessUnit_ImportLogs
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_ImportLogs), new EntityRole?());
      }
    }

    [AttributeLogicalName("importfileid")]
    [RelationshipSchemaName("ImportLog_ImportFile")]
    public ImportFile ImportLog_ImportFile
    {
      get => this.GetRelatedEntity<ImportFile>(nameof (ImportLog_ImportFile), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ImportLog_ImportFile));
        this.SetRelatedEntity<ImportFile>(nameof (ImportLog_ImportFile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ImportLog_ImportFile));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_importlog_createdonbehalfby")]
    public SystemUser lk_importlog_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importlog_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importlog_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importlog_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importlog_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_importlog_modifiedonbehalfby")]
    public SystemUser lk_importlog_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importlog_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_importlog_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_importlog_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_importlog_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_importlogbase_createdby")]
    public SystemUser lk_importlogbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importlogbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_importlogbase_modifiedby")]
    public SystemUser lk_importlogbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importlogbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("SystemUser_ImportLogs")]
    public SystemUser SystemUser_ImportLogs
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (SystemUser_ImportLogs), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ImportLogs")]
    public Team team_ImportLogs
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ImportLogs), new EntityRole?());
    }

    public ImportLog(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["importlogid"] = (object) base.Id;
            break;
          case "importlogid":
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
