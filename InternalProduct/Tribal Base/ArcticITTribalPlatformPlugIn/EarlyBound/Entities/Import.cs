// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Import
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("import")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Import : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "import";
    public const string EntitySchemaName = "Import";
    public const string PrimaryIdAttribute = "importid";
    public const string PrimaryNameAttribute = "name";

    public Import()
      : base("import")
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

    [AttributeLogicalName("emailaddress")]
    public string EMailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EMailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EMailAddress));
      }
    }

    [AttributeLogicalName("importid")]
    public Guid? ImportId
    {
      get => this.GetAttributeValue<Guid?>("importid");
      set
      {
        this.OnPropertyChanging(nameof (ImportId));
        this.SetAttributeValue("importid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ImportId));
      }
    }

    [AttributeLogicalName("importid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ImportId = new Guid?(value);
    }

    [AttributeLogicalName("isimport")]
    [Obsolete]
    public bool? IsImport
    {
      get => this.GetAttributeValue<bool?>("isimport");
      set
      {
        this.OnPropertyChanging(nameof (IsImport));
        this.SetAttributeValue("isimport", (object) value);
        this.OnPropertyChanged(nameof (IsImport));
      }
    }

    [AttributeLogicalName("modecode")]
    public OptionSetValue ModeCode
    {
      get => this.GetAttributeValue<OptionSetValue>("modecode");
      set
      {
        this.OnPropertyChanging(nameof (ModeCode));
        this.SetAttributeValue("modecode", (object) value);
        this.OnPropertyChanged(nameof (ModeCode));
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

    [AttributeLogicalName("sendnotification")]
    public bool? SendNotification
    {
      get => this.GetAttributeValue<bool?>("sendnotification");
      set
      {
        this.OnPropertyChanging(nameof (SendNotification));
        this.SetAttributeValue("sendnotification", (object) value);
        this.OnPropertyChanged(nameof (SendNotification));
      }
    }

    [AttributeLogicalName("sequence")]
    public int? Sequence => this.GetAttributeValue<int?>("sequence");

    [AttributeLogicalName("statecode")]
    public ImportState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ImportState?((ImportState) Enum.ToObject(typeof (ImportState), attributeValue.Value)) : new ImportState?();
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

    [RelationshipSchemaName("Import_AsyncOperations")]
    public IEnumerable<AsyncOperation> Import_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Import_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Import_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Import_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Import_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Import_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Import_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Import_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Import_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Import_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Import_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("Import_ImportFile")]
    public IEnumerable<ImportFile> Import_ImportFile
    {
      get => this.GetRelatedEntities<ImportFile>(nameof (Import_ImportFile), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Import_ImportFile));
        this.SetRelatedEntities<ImportFile>(nameof (Import_ImportFile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Import_ImportFile));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_import")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_import
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_import), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_import));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_import), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_import));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("BusinessUnit_Imports")]
    public BusinessUnit BusinessUnit_Imports
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_Imports), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_import_createdonbehalfby")]
    public SystemUser lk_import_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_import_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_import_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_import_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_import_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_import_modifiedonbehalfby")]
    public SystemUser lk_import_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_import_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_import_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_import_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_import_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_importbase_createdby")]
    public SystemUser lk_importbase_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_importbase_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_importbase_modifiedby")]
    public SystemUser lk_importbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_importbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("SystemUser_Imports")]
    public SystemUser SystemUser_Imports
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (SystemUser_Imports), new EntityRole?());
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_Imports")]
    public Team team_Imports
    {
      get => this.GetRelatedEntity<Team>(nameof (team_Imports), new EntityRole?());
    }

    public Import(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["importid"] = (object) base.Id;
            break;
          case "importid":
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
