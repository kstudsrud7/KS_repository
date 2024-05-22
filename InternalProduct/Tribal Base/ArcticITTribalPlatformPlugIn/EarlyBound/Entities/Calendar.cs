// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.Calendar
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

#nullable disable
namespace ArcticIT.EarlyBound.Entities
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("calendar")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class Calendar : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "calendar";
    public const string EntitySchemaName = "Calendar";
    public const string PrimaryIdAttribute = "calendarid";
    public const string PrimaryNameAttribute = "name";

    public Calendar()
      : base("calendar")
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

    [AttributeLogicalName("businessunitid")]
    public EntityReference BusinessUnitId
    {
      get => this.GetAttributeValue<EntityReference>("businessunitid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnitId));
        this.SetAttributeValue("businessunitid", (object) value);
        this.OnPropertyChanged(nameof (BusinessUnitId));
      }
    }

    [AttributeLogicalName("calendarid")]
    public Guid? CalendarId
    {
      get => this.GetAttributeValue<Guid?>("calendarid");
      set
      {
        this.OnPropertyChanging(nameof (CalendarId));
        this.SetAttributeValue("calendarid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (CalendarId));
      }
    }

    [AttributeLogicalName("calendarid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.CalendarId = new Guid?(value);
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

    [AttributeLogicalName("holidayschedulecalendarid")]
    public EntityReference HolidayScheduleCalendarId
    {
      get => this.GetAttributeValue<EntityReference>("holidayschedulecalendarid");
      set
      {
        this.OnPropertyChanging(nameof (HolidayScheduleCalendarId));
        this.SetAttributeValue("holidayschedulecalendarid", (object) value);
        this.OnPropertyChanged(nameof (HolidayScheduleCalendarId));
      }
    }

    [AttributeLogicalName("isshared")]
    public bool? IsShared
    {
      get => this.GetAttributeValue<bool?>("isshared");
      set
      {
        this.OnPropertyChanging(nameof (IsShared));
        this.SetAttributeValue("isshared", (object) value);
        this.OnPropertyChanged(nameof (IsShared));
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

    [AttributeLogicalName("primaryuserid")]
    public Guid? PrimaryUserId
    {
      get => this.GetAttributeValue<Guid?>("primaryuserid");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryUserId));
        this.SetAttributeValue("primaryuserid", (object) value);
        this.OnPropertyChanged(nameof (PrimaryUserId));
      }
    }

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

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("BusinessUnit_Calendar")]
    public IEnumerable<BusinessUnit> BusinessUnit_Calendar
    {
      get
      {
        return this.GetRelatedEntities<BusinessUnit>(nameof (BusinessUnit_Calendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BusinessUnit_Calendar));
        this.SetRelatedEntities<BusinessUnit>(nameof (BusinessUnit_Calendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BusinessUnit_Calendar));
      }
    }

    [RelationshipSchemaName("Calendar_Annotation")]
    public IEnumerable<Annotation> Calendar_Annotation
    {
      get => this.GetRelatedEntities<Annotation>(nameof (Calendar_Annotation), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (Calendar_Annotation));
        this.SetRelatedEntities<Annotation>(nameof (Calendar_Annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Calendar_Annotation));
      }
    }

    [RelationshipSchemaName("Calendar_AsyncOperations")]
    public IEnumerable<AsyncOperation> Calendar_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (Calendar_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Calendar_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (Calendar_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Calendar_AsyncOperations));
      }
    }

    [RelationshipSchemaName("Calendar_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> Calendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (Calendar_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (Calendar_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (Calendar_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (Calendar_BulkDeleteFailures));
      }
    }

    [AttributeLogicalName("calendarrules")]
    public IEnumerable<CalendarRule> CalendarRules
    {
      get
      {
        EntityCollection attributeValue = this.GetAttributeValue<EntityCollection>("calendarrules");
        return attributeValue != null && attributeValue.Entities != null ? ((IEnumerable<Entity>) attributeValue.Entities).Select<Entity, CalendarRule>((Func<Entity, CalendarRule>) (e => e.ToEntity<CalendarRule>())) : (IEnumerable<CalendarRule>) null;
      }
      set
      {
        this.OnPropertyChanging(nameof (CalendarRules));
        if (value == null)
          this.SetAttributeValue("calendarrules", (object) value);
        else
          this.SetAttributeValue("calendarrules", (object) new EntityCollection((IList<Entity>) new List<Entity>((IEnumerable<Entity>) value)));
        this.OnPropertyChanged(nameof (CalendarRules));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Calendar> Referencedcalendar_customercalendar_holidaycalendar
    {
      get
      {
        return this.GetRelatedEntities<Calendar>("calendar_customercalendar_holidaycalendar", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedcalendar_customercalendar_holidaycalendar));
        this.SetRelatedEntities<Calendar>("calendar_customercalendar_holidaycalendar", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedcalendar_customercalendar_holidaycalendar));
      }
    }

    [RelationshipSchemaName("calendar_organization")]
    public IEnumerable<Organization> calendar_organization
    {
      get
      {
        return this.GetRelatedEntities<Organization>(nameof (calendar_organization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (calendar_organization));
        this.SetRelatedEntities<Organization>(nameof (calendar_organization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (calendar_organization));
      }
    }

    [RelationshipSchemaName("calendar_slaitem")]
    public IEnumerable<SLAItem> calendar_slaitem
    {
      get => this.GetRelatedEntities<SLAItem>(nameof (calendar_slaitem), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (calendar_slaitem));
        this.SetRelatedEntities<SLAItem>(nameof (calendar_slaitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (calendar_slaitem));
      }
    }

    [RelationshipSchemaName("calendar_system_users")]
    public IEnumerable<SystemUser> calendar_system_users
    {
      get => this.GetRelatedEntities<SystemUser>(nameof (calendar_system_users), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (calendar_system_users));
        this.SetRelatedEntities<SystemUser>(nameof (calendar_system_users), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (calendar_system_users));
      }
    }

    [RelationshipSchemaName("slabase_businesshoursid")]
    public IEnumerable<SLA> slabase_businesshoursid
    {
      get => this.GetRelatedEntities<SLA>(nameof (slabase_businesshoursid), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (slabase_businesshoursid));
        this.SetRelatedEntities<SLA>(nameof (slabase_businesshoursid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_businesshoursid));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_calendar")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_calendar
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_calendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_calendar));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_calendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_calendar));
      }
    }

    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_calendars")]
    public BusinessUnit business_unit_calendars
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_calendars), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (business_unit_calendars));
        this.SetRelatedEntity<BusinessUnit>(nameof (business_unit_calendars), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (business_unit_calendars));
      }
    }

    [AttributeLogicalName("holidayschedulecalendarid")]
    [RelationshipSchemaName]
    public Calendar Referencingcalendar_customercalendar_holidaycalendar
    {
      get
      {
        return this.GetRelatedEntity<Calendar>("calendar_customercalendar_holidaycalendar", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingcalendar_customercalendar_holidaycalendar));
        this.SetRelatedEntity<Calendar>("calendar_customercalendar_holidaycalendar", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingcalendar_customercalendar_holidaycalendar));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_calendar_createdby")]
    public SystemUser lk_calendar_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_calendar_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_calendar_createdonbehalfby")]
    public SystemUser lk_calendar_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_calendar_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_calendar_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_calendar_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_calendar_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_calendar_modifiedby")]
    public SystemUser lk_calendar_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_calendar_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_calendar_modifiedonbehalfby")]
    public SystemUser lk_calendar_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_calendar_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_calendar_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_calendar_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_calendar_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_calendars")]
    public Organization organization_calendars
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (organization_calendars), new EntityRole?());
      }
    }

    public Calendar(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["calendarid"] = (object) base.Id;
            break;
          case "calendarid":
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
