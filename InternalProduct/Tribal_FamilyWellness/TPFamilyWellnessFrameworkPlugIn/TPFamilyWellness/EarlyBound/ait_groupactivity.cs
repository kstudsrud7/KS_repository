// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_groupactivity
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_groupactivity")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_groupactivity : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_groupactivity";
    public const int EntityTypeCode = 10382;

    public ait_groupactivity()
      : base(nameof (ait_groupactivity))
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

    [AttributeLogicalName("ait_activityobjective")]
    public string ait_ActivityObjective
    {
      get => this.GetAttributeValue<string>("ait_activityobjective");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityObjective));
        this.SetAttributeValue("ait_activityobjective", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityObjective));
      }
    }

    [AttributeLogicalName("ait_activitystartdate")]
    public DateTime? ait_ActivityStartDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_activitystartdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ActivityStartDate));
        this.SetAttributeValue("ait_activitystartdate", (object) value);
        this.OnPropertyChanged(nameof (ait_ActivityStartDate));
      }
    }

    [AttributeLogicalName("ait_duration")]
    public int? ait_Duration
    {
      get => this.GetAttributeValue<int?>("ait_duration");
      set
      {
        this.OnPropertyChanging(nameof (ait_Duration));
        this.SetAttributeValue("ait_duration", (object) value);
        this.OnPropertyChanged(nameof (ait_Duration));
      }
    }

    [AttributeLogicalName("ait_eventtype")]
    public OptionSetValue ait_EventType
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_eventtype");
      set
      {
        this.OnPropertyChanging(nameof (ait_EventType));
        this.SetAttributeValue("ait_eventtype", (object) value);
        this.OnPropertyChanged(nameof (ait_EventType));
      }
    }

    [AttributeLogicalName("ait_groupactivityid")]
    public Guid? ait_groupactivityId
    {
      get => this.GetAttributeValue<Guid?>("ait_groupactivityid");
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivityId));
        this.SetAttributeValue("ait_groupactivityid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_groupactivityId));
      }
    }

    [AttributeLogicalName("ait_groupactivityid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_groupactivityId = new Guid?(value);
    }

    [AttributeLogicalName("ait_groupactivityidauto")]
    public string ait_GroupActivityIDauto
    {
      get => this.GetAttributeValue<string>("ait_groupactivityidauto");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivityIDauto));
        this.SetAttributeValue("ait_groupactivityidauto", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivityIDauto));
      }
    }

    [AttributeLogicalName("ait_name")]
    public string ait_name
    {
      get => this.GetAttributeValue<string>(nameof (ait_name));
      set
      {
        this.OnPropertyChanging(nameof (ait_name));
        this.SetAttributeValue(nameof (ait_name), (object) value);
        this.OnPropertyChanged(nameof (ait_name));
      }
    }

    [AttributeLogicalName("ait_numberofactivities")]
    public int? ait_NumberofActivities
    {
      get => this.GetAttributeValue<int?>("ait_numberofactivities");
      set
      {
        this.OnPropertyChanging(nameof (ait_NumberofActivities));
        this.SetAttributeValue("ait_numberofactivities", (object) value);
        this.OnPropertyChanged(nameof (ait_NumberofActivities));
      }
    }

    [AttributeLogicalName("ait_program")]
    public EntityReference ait_Program
    {
      get => this.GetAttributeValue<EntityReference>("ait_program");
      set
      {
        this.OnPropertyChanging(nameof (ait_Program));
        this.SetAttributeValue("ait_program", (object) value);
        this.OnPropertyChanged(nameof (ait_Program));
      }
    }

    [AttributeLogicalName("ait_totalattendees")]
    public int? ait_TotalAttendees
    {
      get => this.GetAttributeValue<int?>("ait_totalattendees");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalAttendees));
        this.SetAttributeValue("ait_totalattendees", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalAttendees));
      }
    }

    [AttributeLogicalName("ait_totalmeetings")]
    public int? ait_TotalMeetings => this.GetAttributeValue<int?>("ait_totalmeetings");

    [AttributeLogicalName("ait_totalmeetings_date")]
    public DateTime? ait_TotalMeetings_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalmeetings_date");
    }

    [AttributeLogicalName("ait_totalmeetings_state")]
    public int? ait_TotalMeetings_State => this.GetAttributeValue<int?>("ait_totalmeetings_state");

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("emailaddress")]
    public string EmailAddress
    {
      get => this.GetAttributeValue<string>("emailaddress");
      set
      {
        this.OnPropertyChanging(nameof (EmailAddress));
        this.SetAttributeValue("emailaddress", (object) value);
        this.OnPropertyChanged(nameof (EmailAddress));
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

    [AttributeLogicalName("statecode")]
    public Ait_groupactivityState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_groupactivityState?((Ait_groupactivityState) Enum.ToObject(typeof (Ait_groupactivityState), attributeValue.Value)) : new Ait_groupactivityState?();
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
    public OptionSetValue statuscode
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (statuscode));
      set
      {
        this.OnPropertyChanging(nameof (statuscode));
        this.SetAttributeValue(nameof (statuscode), (object) value);
        this.OnPropertyChanged(nameof (statuscode));
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

    [RelationshipSchemaName("ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity")]
    public IEnumerable<ait_groupactivitymeeting> ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivitymeeting>(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity));
        this.SetRelatedEntities<ait_groupactivitymeeting>(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity));
      }
    }
  }
}
