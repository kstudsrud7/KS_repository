// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CallbackRegistration
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("callbackregistration")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CallbackRegistration : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "callbackregistration";
    public const string EntitySchemaName = "CallbackRegistration";
    public const string PrimaryIdAttribute = "callbackregistrationid";
    public const string PrimaryNameAttribute = "name";

    public CallbackRegistration()
      : base("callbackregistration")
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

    [AttributeLogicalName("callbackregistrationid")]
    public Guid? CallbackRegistrationId
    {
      get => this.GetAttributeValue<Guid?>("callbackregistrationid");
      set
      {
        this.OnPropertyChanging(nameof (CallbackRegistrationId));
        this.SetAttributeValue("callbackregistrationid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CallbackRegistrationId));
      }
    }

    [AttributeLogicalName("callbackregistrationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CallbackRegistrationId = new Guid?(value);
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
    public string EntityName
    {
      get => this.GetAttributeValue<string>("entityname");
      set
      {
        this.OnPropertyChanging(nameof (EntityName));
        this.SetAttributeValue("entityname", (object) value);
        this.OnPropertyChanged(nameof (EntityName));
      }
    }

    [AttributeLogicalName("filterexpression")]
    public string FilterExpression
    {
      get => this.GetAttributeValue<string>("filterexpression");
      set
      {
        this.OnPropertyChanging(nameof (FilterExpression));
        this.SetAttributeValue("filterexpression", (object) value);
        this.OnPropertyChanged(nameof (FilterExpression));
      }
    }

    [AttributeLogicalName("filteringattributes")]
    public string FilteringAttributes
    {
      get => this.GetAttributeValue<string>("filteringattributes");
      set
      {
        this.OnPropertyChanging(nameof (FilteringAttributes));
        this.SetAttributeValue("filteringattributes", (object) value);
        this.OnPropertyChanged(nameof (FilteringAttributes));
      }
    }

    [AttributeLogicalName("message")]
    public OptionSetValue Message
    {
      get => this.GetAttributeValue<OptionSetValue>("message");
      set
      {
        this.OnPropertyChanging(nameof (Message));
        this.SetAttributeValue("message", (object) value);
        this.OnPropertyChanged(nameof (Message));
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

    [AttributeLogicalName("postponeuntil")]
    public string PostponeUntil
    {
      get => this.GetAttributeValue<string>("postponeuntil");
      set
      {
        this.OnPropertyChanging(nameof (PostponeUntil));
        this.SetAttributeValue("postponeuntil", (object) value);
        this.OnPropertyChanged(nameof (PostponeUntil));
      }
    }

    [AttributeLogicalName("runas")]
    public OptionSetValue RunAs
    {
      get => this.GetAttributeValue<OptionSetValue>("runas");
      set
      {
        this.OnPropertyChanging(nameof (RunAs));
        this.SetAttributeValue("runas", (object) value);
        this.OnPropertyChanged(nameof (RunAs));
      }
    }

    [AttributeLogicalName("scope")]
    public OptionSetValue Scope
    {
      get => this.GetAttributeValue<OptionSetValue>("scope");
      set
      {
        this.OnPropertyChanging(nameof (Scope));
        this.SetAttributeValue("scope", (object) value);
        this.OnPropertyChanged(nameof (Scope));
      }
    }

    [AttributeLogicalName("url")]
    public string Url
    {
      get => this.GetAttributeValue<string>("url");
      set
      {
        this.OnPropertyChanging(nameof (Url));
        this.SetAttributeValue("url", (object) value);
        this.OnPropertyChanged(nameof (Url));
      }
    }

    [AttributeLogicalName("version")]
    public OptionSetValue Version
    {
      get => this.GetAttributeValue<OptionSetValue>("version");
      set
      {
        this.OnPropertyChanging(nameof (Version));
        this.SetAttributeValue("version", (object) value);
        this.OnPropertyChanged(nameof (Version));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("businessunit_callbackregistration")]
    public BusinessUnit businessunit_callbackregistration
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (businessunit_callbackregistration), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_callbackregistration_createdby")]
    public SystemUser lk_callbackregistration_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_callbackregistration_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_callbackregistration_createdonbehalfby")]
    public SystemUser lk_callbackregistration_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_callbackregistration_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_callbackregistration_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_callbackregistration_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_callbackregistration_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_callbackregistration_modifiedby")]
    public SystemUser lk_callbackregistration_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_callbackregistration_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_callbackregistration_modifiedonbehalfby")]
    public SystemUser lk_callbackregistration_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_callbackregistration_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_callbackregistration_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_callbackregistration_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_callbackregistration_modifiedonbehalfby));
      }
    }

    public CallbackRegistration(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["callbackregistrationid"] = (object) base.Id;
            break;
          case "callbackregistrationid":
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
