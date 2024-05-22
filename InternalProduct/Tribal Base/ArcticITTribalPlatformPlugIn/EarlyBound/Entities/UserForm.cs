// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.UserForm
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("userform")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class UserForm : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "userform";
    public const string EntitySchemaName = "UserForm";
    public const string PrimaryIdAttribute = "userformid";
    public const string PrimaryNameAttribute = "name";

    public UserForm()
      : base("userform")
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

    [AttributeLogicalName("formjson")]
    public string FormJson
    {
      get => this.GetAttributeValue<string>("formjson");
      set
      {
        this.OnPropertyChanging(nameof (FormJson));
        this.SetAttributeValue("formjson", (object) value);
        this.OnPropertyChanged(nameof (FormJson));
      }
    }

    [AttributeLogicalName("formxml")]
    public string FormXml
    {
      get => this.GetAttributeValue<string>("formxml");
      set
      {
        this.OnPropertyChanging(nameof (FormXml));
        this.SetAttributeValue("formxml", (object) value);
        this.OnPropertyChanged(nameof (FormXml));
      }
    }

    [AttributeLogicalName("istabletenabled")]
    public bool? IsTabletEnabled
    {
      get => this.GetAttributeValue<bool?>("istabletenabled");
      set
      {
        this.OnPropertyChanging(nameof (IsTabletEnabled));
        this.SetAttributeValue("istabletenabled", (object) value);
        this.OnPropertyChanged(nameof (IsTabletEnabled));
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

    [AttributeLogicalName("objecttypecode")]
    public string ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (ObjectTypeCode));
        this.SetAttributeValue("objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (ObjectTypeCode));
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

    [AttributeLogicalName("type")]
    public OptionSetValue Type
    {
      get => this.GetAttributeValue<OptionSetValue>("type");
      set
      {
        this.OnPropertyChanging(nameof (Type));
        this.SetAttributeValue("type", (object) value);
        this.OnPropertyChanged(nameof (Type));
      }
    }

    [AttributeLogicalName("userformid")]
    public Guid? UserFormId
    {
      get => this.GetAttributeValue<Guid?>("userformid");
      set
      {
        this.OnPropertyChanging(nameof (UserFormId));
        this.SetAttributeValue("userformid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (UserFormId));
      }
    }

    [AttributeLogicalName("userformid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.UserFormId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("socialinsightsconfiguration_userform")]
    public IEnumerable<SocialInsightsConfiguration> socialinsightsconfiguration_userform
    {
      get
      {
        return this.GetRelatedEntities<SocialInsightsConfiguration>(nameof (socialinsightsconfiguration_userform), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialinsightsconfiguration_userform));
        this.SetRelatedEntities<SocialInsightsConfiguration>(nameof (socialinsightsconfiguration_userform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialinsightsconfiguration_userform));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_userform")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_userform
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_userform), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_userform));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_userform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_userform));
      }
    }

    [RelationshipSchemaName("UserForm_AsyncOperations")]
    public IEnumerable<AsyncOperation> UserForm_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (UserForm_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (UserForm_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (UserForm_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserForm_AsyncOperations));
      }
    }

    [RelationshipSchemaName("UserForm_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> UserForm_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (UserForm_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (UserForm_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (UserForm_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (UserForm_BulkDeleteFailures));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_userform")]
    public BusinessUnit business_unit_userform
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_userform), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_userform_createdby")]
    public SystemUser lk_userform_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_userform_createdby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_userform_modifiedby")]
    public SystemUser lk_userform_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_userform_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_userformbase_createdonbehalfby")]
    public SystemUser lk_userformbase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_userformbase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_userformbase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_userformbase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_userformbase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_userformbase_modifiedonbehalfby")]
    public SystemUser lk_userformbase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_userformbase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_userformbase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_userformbase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_userformbase_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_userform")]
    public Team team_userform
    {
      get => this.GetRelatedEntity<Team>(nameof (team_userform), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_userform")]
    public SystemUser user_userform
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_userform), new EntityRole?());
    }

    public UserForm(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["userformid"] = (object) base.Id;
            break;
          case "userformid":
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
