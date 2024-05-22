// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.MailboxStatistics
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("mailboxstatistics")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class MailboxStatistics : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "mailboxstatistics";
    public const string EntitySchemaName = "MailboxStatistics";
    public const string PrimaryIdAttribute = "mailboxstatisticsid";

    public MailboxStatistics()
      : base("mailboxstatistics")
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

    [AttributeLogicalName("asynceventid")]
    public Guid? AsyncEventId => this.GetAttributeValue<Guid?>("asynceventid");

    [AttributeLogicalName("crmitemsbacklog")]
    public int? CrmItemsBacklog => this.GetAttributeValue<int?>("crmitemsbacklog");

    [AttributeLogicalName("individualstepdurations")]
    public string IndividualStepDurations
    {
      get => this.GetAttributeValue<string>("individualstepdurations");
    }

    [AttributeLogicalName("itemsfailed")]
    public int? ItemsFailed => this.GetAttributeValue<int?>("itemsfailed");

    [AttributeLogicalName("itemsprocessed")]
    public int? ItemsProcessed => this.GetAttributeValue<int?>("itemsprocessed");

    [AttributeLogicalName("machinename")]
    public string MachineName => this.GetAttributeValue<string>("machinename");

    [AttributeLogicalName("mailboxid")]
    public EntityReference MailboxId => this.GetAttributeValue<EntityReference>("mailboxid");

    [AttributeLogicalName("mailboxprocesscompletedon")]
    public DateTime? MailboxProcessCompletedOn
    {
      get => this.GetAttributeValue<DateTime?>("mailboxprocesscompletedon");
    }

    [AttributeLogicalName("mailboxprocessscheduledon")]
    public DateTime? MailboxProcessScheduledOn
    {
      get => this.GetAttributeValue<DateTime?>("mailboxprocessscheduledon");
    }

    [AttributeLogicalName("mailboxprocessstartedon")]
    public DateTime? MailboxProcessStartedOn
    {
      get => this.GetAttributeValue<DateTime?>("mailboxprocessstartedon");
    }

    [AttributeLogicalName("mailboxstatisticsid")]
    public Guid? MailboxStatisticsId => this.GetAttributeValue<Guid?>("mailboxstatisticsid");

    [AttributeLogicalName("mailboxstatisticsid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("operationtypeid")]
    public OptionSetValue OperationTypeId
    {
      get => this.GetAttributeValue<OptionSetValue>("operationtypeid");
    }

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("processresult")]
    public bool? ProcessResult => this.GetAttributeValue<bool?>("processresult");

    [AttributeLogicalName("processtimeintervalinminutes")]
    public int? ProcessTimeIntervalInMinutes
    {
      get => this.GetAttributeValue<int?>("processtimeintervalinminutes");
    }

    [AttributeLogicalName("scheduledtimeintervalinminutes")]
    public int? ScheduledTimeIntervalInMinutes
    {
      get => this.GetAttributeValue<int?>("scheduledtimeintervalinminutes");
    }

    [AttributeLogicalName("mailboxid")]
    [RelationshipSchemaName("mailbox_mailboxstatistics")]
    public Mailbox mailbox_mailboxstatistics
    {
      get => this.GetRelatedEntity<Mailbox>(nameof (mailbox_mailboxstatistics), new EntityRole?());
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_mailboxstatistics")]
    public Organization organization_mailboxstatistics
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_mailboxstatistics), new EntityRole?());
      }
    }

    public MailboxStatistics(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["mailboxstatisticsid"] = (object) base.Id;
            break;
          case "mailboxstatisticsid":
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
