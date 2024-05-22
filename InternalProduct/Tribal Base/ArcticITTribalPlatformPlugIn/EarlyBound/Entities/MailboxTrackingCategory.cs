// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.MailboxTrackingCategory
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mailboxtrackingcategory")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class MailboxTrackingCategory : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mailboxtrackingcategory";
    public const string EntitySchemaName = "MailboxTrackingCategory";
    public const string PrimaryIdAttribute = "mailboxtrackingcategoryid";

    public MailboxTrackingCategory()
      : base("mailboxtrackingcategory")
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

    [AttributeLogicalName("categoryonboardingstatus")]
    public int? CategoryOnboardingStatus
    {
      get => this.GetAttributeValue<int?>("categoryonboardingstatus");
      set
      {
        this.OnPropertyChanging(nameof (CategoryOnboardingStatus));
        this.SetAttributeValue("categoryonboardingstatus", (object) value);
        this.OnPropertyChanged(nameof (CategoryOnboardingStatus));
      }
    }

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("exchangecategorycolor")]
    public int? ExchangeCategoryColor
    {
      get => this.GetAttributeValue<int?>("exchangecategorycolor");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeCategoryColor));
        this.SetAttributeValue("exchangecategorycolor", (object) value);
        this.OnPropertyChanged(nameof (ExchangeCategoryColor));
      }
    }

    [AttributeLogicalName("exchangecategoryid")]
    public Guid? ExchangeCategoryId
    {
      get => this.GetAttributeValue<Guid?>("exchangecategoryid");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeCategoryId));
        this.SetAttributeValue("exchangecategoryid", (object) value);
        this.OnPropertyChanged(nameof (ExchangeCategoryId));
      }
    }

    [AttributeLogicalName("exchangecategoryname")]
    public string ExchangeCategoryName
    {
      get => this.GetAttributeValue<string>("exchangecategoryname");
      set
      {
        this.OnPropertyChanging(nameof (ExchangeCategoryName));
        this.SetAttributeValue("exchangecategoryname", (object) value);
        this.OnPropertyChanged(nameof (ExchangeCategoryName));
      }
    }

    [AttributeLogicalName("mailboxid")]
    public EntityReference MailboxId
    {
      get => this.GetAttributeValue<EntityReference>("mailboxid");
      set
      {
        this.OnPropertyChanging(nameof (MailboxId));
        this.SetAttributeValue("mailboxid", (object) value);
        this.OnPropertyChanged(nameof (MailboxId));
      }
    }

    [AttributeLogicalName("mailboxtrackingcategoryid")]
    public Guid? MailboxTrackingCategoryId
    {
      get => this.GetAttributeValue<Guid?>("mailboxtrackingcategoryid");
    }

    [AttributeLogicalName("mailboxtrackingcategoryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

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

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("businessunit_mailboxtrackingcategory")]
    public BusinessUnit businessunit_mailboxtrackingcategory
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (businessunit_mailboxtrackingcategory), new EntityRole?());
      }
    }

    [AttributeLogicalName("mailboxid")]
    [RelationshipSchemaName("Mailbox_mailboxtrackingcategory")]
    public Mailbox Mailbox_mailboxtrackingcategory
    {
      get
      {
        return this.GetRelatedEntity<Mailbox>(nameof (Mailbox_mailboxtrackingcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Mailbox_mailboxtrackingcategory));
        this.SetRelatedEntity<Mailbox>(nameof (Mailbox_mailboxtrackingcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Mailbox_mailboxtrackingcategory));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_mailboxtrackingcategory")]
    public Team team_mailboxtrackingcategory
    {
      get => this.GetRelatedEntity<Team>(nameof (team_mailboxtrackingcategory), new EntityRole?());
    }

    public MailboxTrackingCategory(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mailboxtrackingcategoryid"] = (object) base.Id;
            break;
          case "mailboxtrackingcategoryid":
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
