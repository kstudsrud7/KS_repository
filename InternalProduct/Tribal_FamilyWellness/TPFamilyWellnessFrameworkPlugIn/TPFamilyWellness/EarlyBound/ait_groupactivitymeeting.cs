// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_groupactivitymeeting
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace TPFamilyWellness.EarlyBound
{
  [DataContract]
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_groupactivitymeeting")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_groupactivitymeeting : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_groupactivitymeeting";
    public const int EntityTypeCode = 10383;

    public ait_groupactivitymeeting()
      : base(nameof (ait_groupactivitymeeting))
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

    [AttributeLogicalName("ait_activitymeetingname")]
    public string ait_activitymeetingname
    {
      get => this.GetAttributeValue<string>(nameof (ait_activitymeetingname));
      set
      {
        this.OnPropertyChanging(nameof (ait_activitymeetingname));
        this.SetAttributeValue(nameof (ait_activitymeetingname), (object) value);
        this.OnPropertyChanged(nameof (ait_activitymeetingname));
      }
    }

    [AttributeLogicalName("ait_attendeecount")]
    public int? ait_AttendeeCount
    {
      get => this.GetAttributeValue<int?>("ait_attendeecount");
      set
      {
        this.OnPropertyChanging(nameof (ait_AttendeeCount));
        this.SetAttributeValue("ait_attendeecount", (object) value);
        this.OnPropertyChanged(nameof (ait_AttendeeCount));
      }
    }

    [AttributeLogicalName("ait_groupactivity")]
    public EntityReference ait_GroupActivity
    {
      get => this.GetAttributeValue<EntityReference>("ait_groupactivity");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivity));
        this.SetAttributeValue("ait_groupactivity", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivity));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeetingid")]
    public Guid? ait_groupactivitymeetingId
    {
      get => this.GetAttributeValue<Guid?>("ait_groupactivitymeetingid");
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeetingId));
        this.SetAttributeValue("ait_groupactivitymeetingid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_groupactivitymeetingId));
      }
    }

    [AttributeLogicalName("ait_groupactivitymeetingid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_groupactivitymeetingId = new Guid?(value);
    }

    [AttributeLogicalName("ait_groupactivitymeetingidauto")]
    public string ait_GroupActivityMeetingIDauto
    {
      get => this.GetAttributeValue<string>("ait_groupactivitymeetingidauto");
      set
      {
        this.OnPropertyChanging(nameof (ait_GroupActivityMeetingIDauto));
        this.SetAttributeValue("ait_groupactivitymeetingidauto", (object) value);
        this.OnPropertyChanged(nameof (ait_GroupActivityMeetingIDauto));
      }
    }

    [AttributeLogicalName("ait_meetingdatetime")]
    public DateTime? ait_MeetingDateTime
    {
      get => this.GetAttributeValue<DateTime?>("ait_meetingdatetime");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingDateTime));
        this.SetAttributeValue("ait_meetingdatetime", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingDateTime));
      }
    }

    [AttributeLogicalName("ait_meetingleader")]
    public EntityReference ait_MeetingLeader
    {
      get => this.GetAttributeValue<EntityReference>("ait_meetingleader");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingLeader));
        this.SetAttributeValue("ait_meetingleader", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingLeader));
      }
    }

    [AttributeLogicalName("ait_meetingsummary")]
    public string ait_MeetingSummary
    {
      get => this.GetAttributeValue<string>("ait_meetingsummary");
      set
      {
        this.OnPropertyChanging(nameof (ait_MeetingSummary));
        this.SetAttributeValue("ait_meetingsummary", (object) value);
        this.OnPropertyChanged(nameof (ait_MeetingSummary));
      }
    }

    [AttributeLogicalName("ait_registeredcount")]
    public int? ait_RegisteredCount
    {
      get => this.GetAttributeValue<int?>("ait_registeredcount");
      set
      {
        this.OnPropertyChanging(nameof (ait_RegisteredCount));
        this.SetAttributeValue("ait_registeredcount", (object) value);
        this.OnPropertyChanged(nameof (ait_RegisteredCount));
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
    public Ait_groupactivitymeetingState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_groupactivitymeetingState?((Ait_groupactivitymeetingState) Enum.ToObject(typeof (Ait_groupactivitymeetingState), attributeValue.Value)) : new Ait_groupactivitymeetingState?();
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

    [AttributeLogicalName("ait_groupactivity")]
    [RelationshipSchemaName("ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity")]
    public ait_groupactivity ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_groupactivity_ait_groupactivitymeeting_GroupActivity));
      }
    }
  }
}
