// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ExpanderEvent
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("expanderevent")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ExpanderEvent : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "expanderevent";
    public const string EntitySchemaName = "ExpanderEvent";
    public const string PrimaryIdAttribute = "expandereventid";
    public const string PrimaryNameAttribute = "name";

    public ExpanderEvent()
      : base("expanderevent")
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

    [AttributeLogicalName("contexturi")]
    public string ContextUri
    {
      get => this.GetAttributeValue<string>("contexturi");
      set
      {
        this.OnPropertyChanging(nameof (ContextUri));
        this.SetAttributeValue("contexturi", (object) value);
        this.OnPropertyChanged(nameof (ContextUri));
      }
    }

    [AttributeLogicalName("correlationid")]
    public Guid? CorrelationId
    {
      get => this.GetAttributeValue<Guid?>("correlationid");
      set
      {
        this.OnPropertyChanging(nameof (CorrelationId));
        this.SetAttributeValue("correlationid", (object) value);
        this.OnPropertyChanged(nameof (CorrelationId));
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

    [AttributeLogicalName("expandereventid")]
    public Guid? ExpanderEventId
    {
      get => this.GetAttributeValue<Guid?>("expandereventid");
      set
      {
        this.OnPropertyChanging(nameof (ExpanderEventId));
        this.SetAttributeValue("expandereventid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ExpanderEventId));
      }
    }

    [AttributeLogicalName("expandereventid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ExpanderEventId = new Guid?(value);
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("registrations")]
    public string Registrations
    {
      get => this.GetAttributeValue<string>("registrations");
      set
      {
        this.OnPropertyChanging(nameof (Registrations));
        this.SetAttributeValue("registrations", (object) value);
        this.OnPropertyChanged(nameof (Registrations));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_expanderevent")]
    public SystemUser createdby_expanderevent
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (createdby_expanderevent), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_expanderevent_createdonbehalfby")]
    public SystemUser lk_expanderevent_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_expanderevent_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expanderevent_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_expanderevent_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expanderevent_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_expanderevent_modifiedonbehalfby")]
    public SystemUser lk_expanderevent_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_expanderevent_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_expanderevent_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_expanderevent_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_expanderevent_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_expanderevent")]
    public SystemUser modifiedby_expanderevent
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_expanderevent), new EntityRole?());
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_expanderevent")]
    public Organization organization_expanderevent
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_expanderevent), new EntityRole?());
      }
    }

    public ExpanderEvent(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["expandereventid"] = (object) base.Id;
            break;
          case "expandereventid":
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
