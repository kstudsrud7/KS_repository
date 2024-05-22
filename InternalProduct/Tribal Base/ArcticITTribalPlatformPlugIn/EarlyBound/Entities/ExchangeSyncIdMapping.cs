// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ExchangeSyncIdMapping
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("exchangesyncidmapping")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ExchangeSyncIdMapping : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "exchangesyncidmapping";
    public const string EntitySchemaName = "ExchangeSyncIdMapping";
    public const string PrimaryIdAttribute = "exchangesyncidmappingid";

    public ExchangeSyncIdMapping()
      : base("exchangesyncidmapping")
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

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("exchangeentryid")]
    public string ExchangeEntryId
    {
      get => this.GetAttributeValue<string>("exchangeentryid");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeEntryId));
        this.SetAttributeValue("exchangeentryid", (object) value);
        this.OnPropertyChanged(nameof (ExchangeEntryId));
      }
    }

    [AttributeLogicalName("exchangesyncidmappingid")]
    public Guid? ExchangeSyncIdmappingId
    {
      get => this.GetAttributeValue<Guid?>("exchangesyncidmappingid");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeSyncIdmappingId));
        this.SetAttributeValue("exchangesyncidmappingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ExchangeSyncIdmappingId));
      }
    }

    [AttributeLogicalName("exchangesyncidmappingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ExchangeSyncIdmappingId = new Guid?(value);
    }

    [AttributeLogicalName("fromcrmchangetype")]
    public int? FromCrmChangeType
    {
      get => this.GetAttributeValue<int?>("fromcrmchangetype");
      set
      {
        this.OnPropertyChanging(nameof (FromCrmChangeType));
        this.SetAttributeValue("fromcrmchangetype", (object) value);
        this.OnPropertyChanged(nameof (FromCrmChangeType));
      }
    }

    [AttributeLogicalName("isdeletedinexchange")]
    public bool? IsDeletedInExchange
    {
      get => this.GetAttributeValue<bool?>("isdeletedinexchange");
      set
      {
        this.OnPropertyChanging(nameof (IsDeletedInExchange));
        this.SetAttributeValue("isdeletedinexchange", (object) value);
        this.OnPropertyChanged(nameof (IsDeletedInExchange));
      }
    }

    [AttributeLogicalName("isunlinkedincrm")]
    public bool? IsUnlinkedInCRM
    {
      get => this.GetAttributeValue<bool?>("isunlinkedincrm");
      set
      {
        this.OnPropertyChanging(nameof (IsUnlinkedInCRM));
        this.SetAttributeValue("isunlinkedincrm", (object) value);
        this.OnPropertyChanged(nameof (IsUnlinkedInCRM));
      }
    }

    [AttributeLogicalName("itemsubject")]
    public string ItemSubject
    {
      get => this.GetAttributeValue<string>("itemsubject");
      set
      {
        this.OnPropertyChanging(nameof (ItemSubject));
        this.SetAttributeValue("itemsubject", (object) value);
        this.OnPropertyChanged(nameof (ItemSubject));
      }
    }

    [AttributeLogicalName("lastsyncerror")]
    public string LastSyncError
    {
      get => this.GetAttributeValue<string>("lastsyncerror");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncError));
        this.SetAttributeValue("lastsyncerror", (object) value);
        this.OnPropertyChanged(nameof (LastSyncError));
      }
    }

    [AttributeLogicalName("lastsyncerrorcode")]
    public int? LastSyncErrorCode
    {
      get => this.GetAttributeValue<int?>("lastsyncerrorcode");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncErrorCode));
        this.SetAttributeValue("lastsyncerrorcode", (object) value);
        this.OnPropertyChanged(nameof (LastSyncErrorCode));
      }
    }

    [AttributeLogicalName("lastsyncerroroccurredon")]
    public DateTime? LastSyncErrorOccurredOn
    {
      get => this.GetAttributeValue<DateTime?>("lastsyncerroroccurredon");
      set
      {
        this.OnPropertyChanging(nameof (LastSyncErrorOccurredOn));
        this.SetAttributeValue("lastsyncerroroccurredon", (object) value);
        this.OnPropertyChanged(nameof (LastSyncErrorOccurredOn));
      }
    }

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("objectid")]
    public Guid? ObjectId
    {
      get => this.GetAttributeValue<Guid?>("objectid");
      set
      {
        this.OnPropertyChanging(nameof (ObjectId));
        this.SetAttributeValue("objectid", (object) value);
        this.OnPropertyChanged(nameof (ObjectId));
      }
    }

    [AttributeLogicalName("objecttypecode")]
    public int? ObjectTypeCode
    {
      get => this.GetAttributeValue<int?>("objecttypecode");
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

    [AttributeLogicalName("retries")]
    public int? Retries
    {
      get => this.GetAttributeValue<int?>("retries");
      set
      {
        this.OnPropertyChanging(nameof (Retries));
        this.SetAttributeValue("retries", (object) value);
        this.OnPropertyChanged(nameof (Retries));
      }
    }

    [AttributeLogicalName("tocrmchangetype")]
    public int? ToCrmChangeType
    {
      get => this.GetAttributeValue<int?>("tocrmchangetype");
      set
      {
        this.OnPropertyChanging(nameof (ToCrmChangeType));
        this.SetAttributeValue("tocrmchangetype", (object) value);
        this.OnPropertyChanged(nameof (ToCrmChangeType));
      }
    }

    [AttributeLogicalName("userdecision")]
    public int? UserDecision
    {
      get => this.GetAttributeValue<int?>("userdecision");
      set
      {
        this.OnPropertyChanging(nameof (UserDecision));
        this.SetAttributeValue("userdecision", (object) value);
        this.OnPropertyChanged(nameof (UserDecision));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_exchangesyncidmapping")]
    public BusinessUnit business_unit_exchangesyncidmapping
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_exchangesyncidmapping), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_exchangesyncidmapping")]
    public Team team_exchangesyncidmapping
    {
      get => this.GetRelatedEntity<Team>(nameof (team_exchangesyncidmapping), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_exchangesyncidmapping")]
    public SystemUser user_exchangesyncidmapping
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_exchangesyncidmapping), new EntityRole?());
      }
    }

    public ExchangeSyncIdMapping(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["exchangesyncidmappingid"] = (object) base.Id;
            break;
          case "exchangesyncidmappingid":
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
