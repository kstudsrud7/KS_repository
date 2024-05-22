// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.CustomerRelationship
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("customerrelationship")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class CustomerRelationship : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "customerrelationship";
    public const string EntitySchemaName = "CustomerRelationship";
    public const string PrimaryIdAttribute = "customerrelationshipid";
    public const string PrimaryNameAttribute = "customerroleidname";

    public CustomerRelationship()
      : base("customerrelationship")
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

    [AttributeLogicalName("converserelationshipid")]
    public EntityReference ConverseRelationshipId
    {
      get => this.GetAttributeValue<EntityReference>("converserelationshipid");
      set
      {
        this.OnPropertyChanging(nameof (ConverseRelationshipId));
        this.SetAttributeValue("converserelationshipid", (object) value);
        this.OnPropertyChanged(nameof (ConverseRelationshipId));
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

    [AttributeLogicalName("customerid")]
    public EntityReference CustomerId
    {
      get => this.GetAttributeValue<EntityReference>("customerid");
      set
      {
        this.OnPropertyChanging(nameof (CustomerId));
        this.SetAttributeValue("customerid", (object) value);
        this.OnPropertyChanged(nameof (CustomerId));
      }
    }

    [AttributeLogicalName("customerrelationshipid")]
    public Guid? CustomerRelationshipId
    {
      get => this.GetAttributeValue<Guid?>("customerrelationshipid");
      set
      {
        this.OnPropertyChanging(nameof (CustomerRelationshipId));
        this.SetAttributeValue("customerrelationshipid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CustomerRelationshipId));
      }
    }

    [AttributeLogicalName("customerrelationshipid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CustomerRelationshipId = new Guid?(value);
    }

    [AttributeLogicalName("customerroledescription")]
    public string CustomerRoleDescription
    {
      get => this.GetAttributeValue<string>("customerroledescription");
      set
      {
        this.OnPropertyChanging(nameof (CustomerRoleDescription));
        this.SetAttributeValue("customerroledescription", (object) value);
        this.OnPropertyChanged(nameof (CustomerRoleDescription));
      }
    }

    [AttributeLogicalName("customerroleid")]
    public EntityReference CustomerRoleId
    {
      get => this.GetAttributeValue<EntityReference>("customerroleid");
      set
      {
        this.OnPropertyChanging(nameof (CustomerRoleId));
        this.SetAttributeValue("customerroleid", (object) value);
        this.OnPropertyChanged(nameof (CustomerRoleId));
      }
    }

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

    [AttributeLogicalName("partnerid")]
    public EntityReference PartnerId
    {
      get => this.GetAttributeValue<EntityReference>("partnerid");
      set
      {
        this.OnPropertyChanging(nameof (PartnerId));
        this.SetAttributeValue("partnerid", (object) value);
        this.OnPropertyChanged(nameof (PartnerId));
      }
    }

    [AttributeLogicalName("partnerroledescription")]
    public string PartnerRoleDescription
    {
      get => this.GetAttributeValue<string>("partnerroledescription");
      set
      {
        this.OnPropertyChanging(nameof (PartnerRoleDescription));
        this.SetAttributeValue("partnerroledescription", (object) value);
        this.OnPropertyChanged(nameof (PartnerRoleDescription));
      }
    }

    [AttributeLogicalName("partnerroleid")]
    public EntityReference PartnerRoleId
    {
      get => this.GetAttributeValue<EntityReference>("partnerroleid");
      set
      {
        this.OnPropertyChanging(nameof (PartnerRoleId));
        this.SetAttributeValue("partnerroleid", (object) value);
        this.OnPropertyChanged(nameof (PartnerRoleId));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName]
    public IEnumerable<CustomerRelationship> Referencedcustomer_relationship_converse_relationship
    {
      get
      {
        return this.GetRelatedEntities<CustomerRelationship>("customer_relationship_converse_relationship", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedcustomer_relationship_converse_relationship));
        this.SetRelatedEntities<CustomerRelationship>("customer_relationship_converse_relationship", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedcustomer_relationship_converse_relationship));
      }
    }

    [RelationshipSchemaName("CustomerRelationship_AsyncOperations")]
    public IEnumerable<AsyncOperation> CustomerRelationship_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (CustomerRelationship_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (CustomerRelationship_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (CustomerRelationship_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (CustomerRelationship_AsyncOperations));
      }
    }

    [RelationshipSchemaName("CustomerRelationship_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> CustomerRelationship_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (CustomerRelationship_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (CustomerRelationship_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (CustomerRelationship_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (CustomerRelationship_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("CustomerRelationship_ProcessSessions")]
    public IEnumerable<ProcessSession> CustomerRelationship_ProcessSessions
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (CustomerRelationship_ProcessSessions), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (CustomerRelationship_ProcessSessions));
        this.SetRelatedEntities<ProcessSession>(nameof (CustomerRelationship_ProcessSessions), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (CustomerRelationship_ProcessSessions));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_customerrelationship")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_customerrelationship
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_customerrelationship), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_customerrelationship));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_customerrelationship), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_customerrelationship));
      }
    }

    [AttributeLogicalName("customerid")]
    [RelationshipSchemaName("account_customer_relationship_customer")]
    public Account account_customer_relationship_customer
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (account_customer_relationship_customer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (account_customer_relationship_customer));
        this.SetRelatedEntity<Account>(nameof (account_customer_relationship_customer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_customer_relationship_customer));
      }
    }

    [AttributeLogicalName("partnerid")]
    [RelationshipSchemaName("account_customer_relationship_partner")]
    public Account account_customer_relationship_partner
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (account_customer_relationship_partner), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (account_customer_relationship_partner));
        this.SetRelatedEntity<Account>(nameof (account_customer_relationship_partner), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_customer_relationship_partner));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_customer_relationship")]
    public BusinessUnit business_unit_customer_relationship
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_customer_relationship), new EntityRole?());
      }
    }

    [AttributeLogicalName("customerid")]
    [RelationshipSchemaName("contact_customer_relationship_customer")]
    public Contact contact_customer_relationship_customer
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (contact_customer_relationship_customer), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (contact_customer_relationship_customer));
        this.SetRelatedEntity<Contact>(nameof (contact_customer_relationship_customer), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_customer_relationship_customer));
      }
    }

    [AttributeLogicalName("partnerid")]
    [RelationshipSchemaName("contact_customer_relationship_partner")]
    public Contact contact_customer_relationship_partner
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (contact_customer_relationship_partner), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (contact_customer_relationship_partner));
        this.SetRelatedEntity<Contact>(nameof (contact_customer_relationship_partner), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_customer_relationship_partner));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("createdby_customer_relationship")]
    public SystemUser createdby_customer_relationship
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdby_customer_relationship), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("createdonbehalfby_customer_relationship")]
    public SystemUser createdonbehalfby_customer_relationship
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (createdonbehalfby_customer_relationship), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (createdonbehalfby_customer_relationship));
        this.SetRelatedEntity<SystemUser>(nameof (createdonbehalfby_customer_relationship), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (createdonbehalfby_customer_relationship));
      }
    }

    [AttributeLogicalName("converserelationshipid")]
    [RelationshipSchemaName]
    public CustomerRelationship Referencingcustomer_relationship_converse_relationship
    {
      get
      {
        return this.GetRelatedEntity<CustomerRelationship>("customer_relationship_converse_relationship", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingcustomer_relationship_converse_relationship));
        this.SetRelatedEntity<CustomerRelationship>("customer_relationship_converse_relationship", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingcustomer_relationship_converse_relationship));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("modifiedby_customer_relationship")]
    public SystemUser modifiedby_customer_relationship
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedby_customer_relationship), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("modifiedonbehalfby_customer_relationship")]
    public SystemUser modifiedonbehalfby_customer_relationship
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (modifiedonbehalfby_customer_relationship), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (modifiedonbehalfby_customer_relationship));
        this.SetRelatedEntity<SystemUser>(nameof (modifiedonbehalfby_customer_relationship), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (modifiedonbehalfby_customer_relationship));
      }
    }

    [AttributeLogicalName("customerroleid")]
    [RelationshipSchemaName("relationship_role_customer_role")]
    public RelationshipRole relationship_role_customer_role
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>(nameof (relationship_role_customer_role), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (relationship_role_customer_role));
        this.SetRelatedEntity<RelationshipRole>(nameof (relationship_role_customer_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (relationship_role_customer_role));
      }
    }

    [AttributeLogicalName("partnerroleid")]
    [RelationshipSchemaName("relationship_role_partner_role")]
    public RelationshipRole relationship_role_partner_role
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>(nameof (relationship_role_partner_role), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (relationship_role_partner_role));
        this.SetRelatedEntity<RelationshipRole>(nameof (relationship_role_partner_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (relationship_role_partner_role));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_customer_relationship")]
    public Team team_customer_relationship
    {
      get => this.GetRelatedEntity<Team>(nameof (team_customer_relationship), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_customer_relationship")]
    public SystemUser user_customer_relationship
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (user_customer_relationship), new EntityRole?());
      }
    }

    public CustomerRelationship(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["customerrelationshipid"] = (object) base.Id;
            break;
          case "customerrelationshipid":
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
