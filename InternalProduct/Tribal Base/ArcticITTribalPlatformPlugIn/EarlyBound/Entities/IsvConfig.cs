// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.IsvConfig
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("isvconfig")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class IsvConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "isvconfig";
    public const string EntitySchemaName = "IsvConfig";
    public const string PrimaryIdAttribute = "isvconfigid";

    public IsvConfig()
      : base("isvconfig")
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

    [AttributeLogicalName("configxml")]
    public string ConfigXML
    {
      get => this.GetAttributeValue<string>("configxml");
      set
      {
        this.OnPropertyChanging(nameof (ConfigXML));
        this.SetAttributeValue("configxml", (object) value);
        this.OnPropertyChanged(nameof (ConfigXML));
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

    [AttributeLogicalName("isvconfigid")]
    public Guid? IsvConfigId
    {
      get => this.GetAttributeValue<Guid?>("isvconfigid");
      set
      {
        this.OnPropertyChanging(nameof (IsvConfigId));
        this.SetAttributeValue("isvconfigid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (IsvConfigId));
      }
    }

    [AttributeLogicalName("isvconfigid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.IsvConfigId = new Guid?(value);
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
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("IsvConfig_AsyncOperations")]
    public IEnumerable<AsyncOperation> IsvConfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (IsvConfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (IsvConfig_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (IsvConfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (IsvConfig_AsyncOperations));
      }
    }

    [RelationshipSchemaName("IsvConfig_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> IsvConfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (IsvConfig_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (IsvConfig_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (IsvConfig_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (IsvConfig_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_isvconfig")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_isvconfig
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_isvconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_isvconfig));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_isvconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_isvconfig));
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_isvconfig_createdonbehalfby")]
    public SystemUser lk_isvconfig_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_isvconfig_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_isvconfig_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_isvconfig_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_isvconfig_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_isvconfig_modifiedonbehalfby")]
    public SystemUser lk_isvconfig_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_isvconfig_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_isvconfig_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_isvconfig_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_isvconfig_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_isvconfigbase_createdby")]
    public SystemUser lk_isvconfigbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_isvconfigbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_isvconfigbase_modifiedby")]
    public SystemUser lk_isvconfigbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_isvconfigbase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_isvconfigs")]
    public Organization organization_isvconfigs
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_isvconfigs), new EntityRole?());
      }
    }

    public IsvConfig(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["isvconfigid"] = (object) base.Id;
            break;
          case "isvconfigid":
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
