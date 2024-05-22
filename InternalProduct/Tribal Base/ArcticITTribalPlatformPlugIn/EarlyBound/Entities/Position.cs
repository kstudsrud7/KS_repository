// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Position
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("position")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Position : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "position";
    public const string EntitySchemaName = "Position";
    public const string PrimaryIdAttribute = "positionid";
    public const string PrimaryNameAttribute = "name";

    public Position()
      : base("position")
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

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("importsequencenumber")]
    public int? ImportSequenceNumber
    {
      get => this.GetAttributeValue<int?>("importsequencenumber");
      set
      {
        this.OnPropertyChanging(nameof (ImportSequenceNumber));
        this.SetAttributeValue("importsequencenumber", (object) value);
        this.OnPropertyChanged(nameof (ImportSequenceNumber));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("overriddencreatedon")]
    public DateTime? OverriddenCreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("overriddencreatedon");
      set
      {
        this.OnPropertyChanging(nameof (OverriddenCreatedOn));
        this.SetAttributeValue("overriddencreatedon", (object) value);
        this.OnPropertyChanged(nameof (OverriddenCreatedOn));
      }
    }

    [AttributeLogicalName("parentpositionid")]
    public EntityReference ParentPositionId
    {
      get => this.GetAttributeValue<EntityReference>("parentpositionid");
      set
      {
        this.OnPropertyChanging(nameof (ParentPositionId));
        this.SetAttributeValue("parentpositionid", (object) value);
        this.OnPropertyChanged(nameof (ParentPositionId));
      }
    }

    [AttributeLogicalName("positionid")]
    public Guid? PositionId
    {
      get => this.GetAttributeValue<Guid?>("positionid");
      set
      {
        this.OnPropertyChanging(nameof (PositionId));
        this.SetAttributeValue("positionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PositionId));
      }
    }

    [AttributeLogicalName("positionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PositionId = new Guid?(value);
    }

    [AttributeLogicalName("statecode")]
    public PositionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new PositionState?((PositionState) Enum.ToObject(typeof (PositionState), attributeValue.Value)) : new PositionState?();
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

    [RelationshipSchemaName("position_AsyncOperations")]
    public IEnumerable<AsyncOperation> position_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (position_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (position_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (position_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_AsyncOperations));
      }
    }

    [RelationshipSchemaName("position_connection1")]
    public IEnumerable<Connection> position_connection1
    {
      get => this.GetRelatedEntities<Connection>(nameof (position_connection1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (position_connection1));
        this.SetRelatedEntities<Connection>(nameof (position_connection1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_connection1));
      }
    }

    [RelationshipSchemaName("position_connection2")]
    public IEnumerable<Connection> position_connection2
    {
      get => this.GetRelatedEntities<Connection>(nameof (position_connection2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (position_connection2));
        this.SetRelatedEntities<Connection>(nameof (position_connection2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_connection2));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Position> Referencedposition_parent_position
    {
      get
      {
        return this.GetRelatedEntities<Position>("position_parent_position", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedposition_parent_position));
        this.SetRelatedEntities<Position>("position_parent_position", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedposition_parent_position));
      }
    }

    [RelationshipSchemaName("position_principalobjectattributeaccess")]
    public IEnumerable<PrincipalObjectAttributeAccess> position_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (position_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (position_principalobjectattributeaccess));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (position_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_principalobjectattributeaccess));
      }
    }

    [RelationshipSchemaName("position_ProcessSession")]
    public IEnumerable<ProcessSession> position_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (position_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (position_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (position_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_ProcessSession));
      }
    }

    [RelationshipSchemaName("Position_SyncErrors")]
    public IEnumerable<SyncError> Position_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (Position_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Position_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (Position_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Position_SyncErrors));
      }
    }

    [RelationshipSchemaName("position_users")]
    public IEnumerable<SystemUser> position_users
    {
      get => this.GetRelatedEntities<SystemUser>(nameof (position_users), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (position_users));
        this.SetRelatedEntities<SystemUser>(nameof (position_users), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_users));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_position_createdby")]
    public SystemUser lk_position_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_position_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_position_createdonbehalfby")]
    public SystemUser lk_position_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_position_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_position_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_position_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_position_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_position_modifiedby")]
    public SystemUser lk_position_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_position_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_position_modifiedonbehalfby")]
    public SystemUser lk_position_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_position_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_position_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_position_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_position_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_position")]
    public Organization organization_position
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_position), new EntityRole?());
    }

    [AttributeLogicalName("parentpositionid")]
    [RelationshipSchemaName]
    public Position Referencingposition_parent_position
    {
      get
      {
        return this.GetRelatedEntity<Position>("position_parent_position", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingposition_parent_position));
        this.SetRelatedEntity<Position>("position_parent_position", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingposition_parent_position));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("transactioncurrency_position")]
    public TransactionCurrency transactioncurrency_position
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_position), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (transactioncurrency_position));
        this.SetRelatedEntity<TransactionCurrency>(nameof (transactioncurrency_position), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (transactioncurrency_position));
      }
    }

    public Position(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["positionid"] = (object) base.Id;
            break;
          case "positionid":
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
