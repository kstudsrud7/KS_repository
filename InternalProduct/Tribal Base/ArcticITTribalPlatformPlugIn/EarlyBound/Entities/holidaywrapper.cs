// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.holidaywrapper
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("holidaywrapper")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class holidaywrapper : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "holidaywrapper";
    public const string EntitySchemaName = "holidaywrapper";
    public const string PrimaryIdAttribute = "holidaywrapperid";
    public const string PrimaryNameAttribute = "name";

    public holidaywrapper()
      : base(nameof (holidaywrapper))
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

    [AttributeLogicalName("calendarid")]
    public string CalendarId
    {
      get => this.GetAttributeValue<string>("calendarid");
      set
      {
        this.OnPropertyChanging(nameof (CalendarId));
        this.SetAttributeValue("calendarid", (object) value);
        this.OnPropertyChanged(nameof (CalendarId));
      }
    }

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn
    {
      get => this.GetAttributeValue<DateTime?>("createdon");
      set
      {
        this.OnPropertyChanging(nameof (CreatedOn));
        this.SetAttributeValue("createdon", (object) value);
        this.OnPropertyChanged(nameof (CreatedOn));
      }
    }

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

    [AttributeLogicalName("duration")]
    public string Duration
    {
      get => this.GetAttributeValue<string>("duration");
      set
      {
        this.OnPropertyChanging(nameof (Duration));
        this.SetAttributeValue("duration", (object) value);
        this.OnPropertyChanged(nameof (Duration));
      }
    }

    [AttributeLogicalName("endtime")]
    public DateTime? EndTime
    {
      get => this.GetAttributeValue<DateTime?>("endtime");
      set
      {
        this.OnPropertyChanging(nameof (EndTime));
        this.SetAttributeValue("endtime", (object) value);
        this.OnPropertyChanged(nameof (EndTime));
      }
    }

    [AttributeLogicalName("holidaywrapperid")]
    public Guid? holidaywrapperId
    {
      get => this.GetAttributeValue<Guid?>("holidaywrapperid");
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapperId));
        this.SetAttributeValue("holidaywrapperid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (holidaywrapperId));
      }
    }

    [AttributeLogicalName("holidaywrapperid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.holidaywrapperId = new Guid?(value);
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
    public DateTime? ModifiedOn
    {
      get => this.GetAttributeValue<DateTime?>("modifiedon");
      set
      {
        this.OnPropertyChanging(nameof (ModifiedOn));
        this.SetAttributeValue("modifiedon", (object) value);
        this.OnPropertyChanged(nameof (ModifiedOn));
      }
    }

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
    public string name
    {
      get => this.GetAttributeValue<string>(nameof (name));
      set
      {
        this.OnPropertyChanging(nameof (name));
        this.SetAttributeValue(nameof (name), (object) value);
        this.OnPropertyChanged(nameof (name));
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

    [AttributeLogicalName("selectedyear")]
    public int? SelectedYear
    {
      get => this.GetAttributeValue<int?>("selectedyear");
      set
      {
        this.OnPropertyChanging(nameof (SelectedYear));
        this.SetAttributeValue("selectedyear", (object) value);
        this.OnPropertyChanged(nameof (SelectedYear));
      }
    }

    [AttributeLogicalName("starttime")]
    public DateTime? StartTime
    {
      get => this.GetAttributeValue<DateTime?>("starttime");
      set
      {
        this.OnPropertyChanging(nameof (StartTime));
        this.SetAttributeValue("starttime", (object) value);
        this.OnPropertyChanged(nameof (StartTime));
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

    [RelationshipSchemaName("holidaywrapper_AsyncOperations")]
    public IEnumerable<AsyncOperation> holidaywrapper_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (holidaywrapper_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (holidaywrapper_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_AsyncOperations));
      }
    }

    [RelationshipSchemaName("holidaywrapper_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> holidaywrapper_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (holidaywrapper_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (holidaywrapper_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("holidaywrapper_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> holidaywrapper_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (holidaywrapper_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (holidaywrapper_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("holidaywrapper_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> holidaywrapper_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (holidaywrapper_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (holidaywrapper_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("holidaywrapper_ProcessSession")]
    public IEnumerable<ProcessSession> holidaywrapper_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (holidaywrapper_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (holidaywrapper_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_ProcessSession));
      }
    }

    [RelationshipSchemaName("holidaywrapper_SyncErrors")]
    public IEnumerable<SyncError> holidaywrapper_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (holidaywrapper_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (holidaywrapper_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_SyncErrors));
      }
    }

    [RelationshipSchemaName("holidaywrapper_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> holidaywrapper_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (holidaywrapper_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (holidaywrapper_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_UserEntityInstanceDatas));
      }
    }

    public holidaywrapper(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["holidaywrapperid"] = (object) base.Id;
            break;
          case "holidaywrapperid":
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
