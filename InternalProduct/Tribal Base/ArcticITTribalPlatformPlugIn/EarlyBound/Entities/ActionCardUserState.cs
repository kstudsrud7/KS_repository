// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ActionCardUserState
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("actioncarduserstate")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ActionCardUserState : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "actioncarduserstate";
    public const string EntitySchemaName = "ActionCardUserState";
    public const string PrimaryIdAttribute = "actioncarduserstateid";

    public ActionCardUserState()
      : base("actioncarduserstate")
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

    [AttributeLogicalName("actioncardid")]
    public EntityReference ActionCardId
    {
      get => this.GetAttributeValue<EntityReference>("actioncardid");
      set
      {
        this.OnPropertyChanging(nameof (ActionCardId));
        this.SetAttributeValue("actioncardid", (object) value);
        this.OnPropertyChanged(nameof (ActionCardId));
      }
    }

    [AttributeLogicalName("actioncarduserstateid")]
    public Guid? ActionCardUserStateId
    {
      get => this.GetAttributeValue<Guid?>("actioncarduserstateid");
      set
      {
        this.OnPropertyChanging(nameof (ActionCardUserStateId));
        this.SetAttributeValue("actioncarduserstateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ActionCardUserStateId));
      }
    }

    [AttributeLogicalName("actioncarduserstateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ActionCardUserStateId = new Guid?(value);
    }

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

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

    [AttributeLogicalName("startdate")]
    public DateTime? StartDate
    {
      get => this.GetAttributeValue<DateTime?>("startdate");
      set
      {
        this.OnPropertyChanging(nameof (StartDate));
        this.SetAttributeValue("startdate", (object) value);
        this.OnPropertyChanged(nameof (StartDate));
      }
    }

    [AttributeLogicalName("state")]
    public OptionSetValue State
    {
      get => this.GetAttributeValue<OptionSetValue>("state");
      set
      {
        this.OnPropertyChanging(nameof (State));
        this.SetAttributeValue("state", (object) value);
        this.OnPropertyChanged(nameof (State));
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

    [AttributeLogicalName("actioncardid")]
    [RelationshipSchemaName("ActionCardUserState_ActionCard")]
    public ActionCard ActionCardUserState_ActionCard
    {
      get
      {
        return this.GetRelatedEntity<ActionCard>(nameof (ActionCardUserState_ActionCard), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ActionCardUserState_ActionCard));
        this.SetRelatedEntity<ActionCard>(nameof (ActionCardUserState_ActionCard), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ActionCardUserState_ActionCard));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ActionCardUserState")]
    public TransactionCurrency TransactionCurrency_ActionCardUserState
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ActionCardUserState), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ActionCardUserState));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ActionCardUserState), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ActionCardUserState));
      }
    }

    public ActionCardUserState(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["actioncarduserstateid"] = (object) base.Id;
            break;
          case "actioncarduserstateid":
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
