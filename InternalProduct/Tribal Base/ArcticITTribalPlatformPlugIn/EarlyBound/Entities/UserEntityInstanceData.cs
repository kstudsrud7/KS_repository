// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.UserEntityInstanceData
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("userentityinstancedata")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class UserEntityInstanceData : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "userentityinstancedata";
    public const string EntitySchemaName = "UserEntityInstanceData";
    public const string PrimaryIdAttribute = "userentityinstancedataid";

    public UserEntityInstanceData()
      : base("userentityinstancedata")
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

    [AttributeLogicalName("commonend")]
    public DateTime? CommonEnd
    {
      get => this.GetAttributeValue<DateTime?>("commonend");
      set
      {
        this.OnPropertyChanging(nameof (CommonEnd));
        this.SetAttributeValue("commonend", (object) value);
        this.OnPropertyChanged(nameof (CommonEnd));
      }
    }

    [AttributeLogicalName("commonstart")]
    public DateTime? CommonStart
    {
      get => this.GetAttributeValue<DateTime?>("commonstart");
      set
      {
        this.OnPropertyChanging(nameof (CommonStart));
        this.SetAttributeValue("commonstart", (object) value);
        this.OnPropertyChanged(nameof (CommonStart));
      }
    }

    [AttributeLogicalName("duedate")]
    public DateTime? DueDate
    {
      get => this.GetAttributeValue<DateTime?>("duedate");
      set
      {
        this.OnPropertyChanging(nameof (DueDate));
        this.SetAttributeValue("duedate", (object) value);
        this.OnPropertyChanged(nameof (DueDate));
      }
    }

    [AttributeLogicalName("flagdueby")]
    public DateTime? FlagDueBy
    {
      get => this.GetAttributeValue<DateTime?>("flagdueby");
      set
      {
        this.OnPropertyChanging(nameof (FlagDueBy));
        this.SetAttributeValue("flagdueby", (object) value);
        this.OnPropertyChanged(nameof (FlagDueBy));
      }
    }

    [AttributeLogicalName("flagrequest")]
    public string FlagRequest
    {
      get => this.GetAttributeValue<string>("flagrequest");
      set
      {
        this.OnPropertyChanging(nameof (FlagRequest));
        this.SetAttributeValue("flagrequest", (object) value);
        this.OnPropertyChanged(nameof (FlagRequest));
      }
    }

    [AttributeLogicalName("flagstatus")]
    public int? FlagStatus
    {
      get => this.GetAttributeValue<int?>("flagstatus");
      set
      {
        this.OnPropertyChanging(nameof (FlagStatus));
        this.SetAttributeValue("flagstatus", (object) value);
        this.OnPropertyChanged(nameof (FlagStatus));
      }
    }

    [AttributeLogicalName("objectid")]
    public EntityReference ObjectId
    {
      get => this.GetAttributeValue<EntityReference>("objectid");
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

    [AttributeLogicalName("personalcategories")]
    public string PersonalCategories
    {
      get => this.GetAttributeValue<string>("personalcategories");
      set
      {
        this.OnPropertyChanging(nameof (PersonalCategories));
        this.SetAttributeValue("personalcategories", (object) value);
        this.OnPropertyChanged(nameof (PersonalCategories));
      }
    }

    [AttributeLogicalName("reminderset")]
    public bool? ReminderSet
    {
      get => this.GetAttributeValue<bool?>("reminderset");
      set
      {
        this.OnPropertyChanging(nameof (ReminderSet));
        this.SetAttributeValue("reminderset", (object) value);
        this.OnPropertyChanged(nameof (ReminderSet));
      }
    }

    [AttributeLogicalName("remindertime")]
    public DateTime? ReminderTime
    {
      get => this.GetAttributeValue<DateTime?>("remindertime");
      set
      {
        this.OnPropertyChanging(nameof (ReminderTime));
        this.SetAttributeValue("remindertime", (object) value);
        this.OnPropertyChanged(nameof (ReminderTime));
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

    [AttributeLogicalName("todoitemflags")]
    public int? ToDoItemFlags
    {
      get => this.GetAttributeValue<int?>("todoitemflags");
      set
      {
        this.OnPropertyChanging(nameof (ToDoItemFlags));
        this.SetAttributeValue("todoitemflags", (object) value);
        this.OnPropertyChanged(nameof (ToDoItemFlags));
      }
    }

    [AttributeLogicalName("todoordinaldate")]
    public DateTime? ToDoOrdinalDate
    {
      get => this.GetAttributeValue<DateTime?>("todoordinaldate");
      set
      {
        this.OnPropertyChanging(nameof (ToDoOrdinalDate));
        this.SetAttributeValue("todoordinaldate", (object) value);
        this.OnPropertyChanged(nameof (ToDoOrdinalDate));
      }
    }

    [AttributeLogicalName("todosubordinal")]
    public string ToDoSubOrdinal
    {
      get => this.GetAttributeValue<string>("todosubordinal");
      set
      {
        this.OnPropertyChanging(nameof (ToDoSubOrdinal));
        this.SetAttributeValue("todosubordinal", (object) value);
        this.OnPropertyChanged(nameof (ToDoSubOrdinal));
      }
    }

    [AttributeLogicalName("todotitle")]
    public string ToDoTitle
    {
      get => this.GetAttributeValue<string>("todotitle");
      set
      {
        this.OnPropertyChanging(nameof (ToDoTitle));
        this.SetAttributeValue("todotitle", (object) value);
        this.OnPropertyChanged(nameof (ToDoTitle));
      }
    }

    [AttributeLogicalName("userentityinstancedataid")]
    public Guid? UserEntityInstanceDataId
    {
      get => this.GetAttributeValue<Guid?>("userentityinstancedataid");
      set
      {
        this.OnPropertyChanging(nameof (UserEntityInstanceDataId));
        this.SetAttributeValue("userentityinstancedataid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (UserEntityInstanceDataId));
      }
    }

    [AttributeLogicalName("userentityinstancedataid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.UserEntityInstanceDataId = new Guid?(value);
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_accountingcode_UserEntityInstanceDatas")]
    public ait_accountingcode ait_accountingcode_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_addresstype_UserEntityInstanceDatas")]
    public ait_addresstype ait_addresstype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_addresstype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_addresstype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_assessment_UserEntityInstanceDatas")]
    public ait_assessment ait_assessment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_autonumber_UserEntityInstanceDatas")]
    public ait_autonumber ait_autonumber_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_band_UserEntityInstanceDatas")]
    public ait_band ait_band_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_band>(nameof (ait_band_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_band_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_band>(nameof (ait_band_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_band_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_bankaccount_UserEntityInstanceDatas")]
    public ait_bankaccount ait_bankaccount_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_bankaccounttype_UserEntityInstanceDatas")]
    public ait_bankaccounttype ait_bankaccounttype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccounttype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccounttype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_birthrecord_UserEntityInstanceDatas")]
    public ait_birthrecord ait_birthrecord_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_bloodquantum_UserEntityInstanceDatas")]
    public ait_bloodquantum ait_bloodquantum_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_cardformat_UserEntityInstanceDatas")]
    public ait_cardformat ait_cardformat_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_cardformatdetail_UserEntityInstanceDatas")]
    public ait_cardformatdetail ait_cardformatdetail_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_cardhistory_UserEntityInstanceDatas")]
    public ait_cardhistory ait_cardhistory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_case_UserEntityInstanceDatas")]
    public ait_case ait_case_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_casenote_UserEntityInstanceDatas")]
    public ait_casenote ait_casenote_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_caseplan_UserEntityInstanceDatas")]
    public ait_caseplan ait_caseplan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_causeofdeath_UserEntityInstanceDatas")]
    public ait_causeofdeath ait_causeofdeath_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_causeofdeath_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_causeofdeath_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_cemetary_UserEntityInstanceDatas")]
    public ait_cemetary ait_cemetary_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_certification_UserEntityInstanceDatas")]
    public ait_certification ait_certification_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_certification_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_certification>(nameof (ait_certification_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_certification_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_changerequest_UserEntityInstanceDatas")]
    public ait_changerequest ait_changerequest_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_changerequesttype_UserEntityInstanceDatas")]
    public ait_changerequesttype ait_changerequesttype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_charge_UserEntityInstanceDatas")]
    public ait_charge ait_charge_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_charge>(nameof (ait_charge_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_charge>(nameof (ait_charge_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_childvisitations_UserEntityInstanceDatas")]
    public ait_childvisitations ait_childvisitations_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_city_UserEntityInstanceDatas")]
    public ait_city ait_city_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_city_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_city>(nameof (ait_city_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_clan_UserEntityInstanceDatas")]
    public ait_clan ait_clan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_clan>(nameof (ait_clan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clan_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_clan>(nameof (ait_clan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clan_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_clientprofile_UserEntityInstanceDatas")]
    public ait_clientprofile ait_clientprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committee_UserEntityInstanceDatas")]
    public ait_committee ait_committee_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_committee>(nameof (ait_committee_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeemeeting_UserEntityInstanceDatas")]
    public ait_committeemeeting ait_committeemeeting_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemeeting_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemeeting_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeemember_UserEntityInstanceDatas")]
    public ait_committeemember ait_committeemember_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeeposition_UserEntityInstanceDatas")]
    public ait_committeeposition ait_committeeposition_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeeposition_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeeposition_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeepositiontype_UserEntityInstanceDatas")]
    public ait_committeepositiontype ait_committeepositiontype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeepositiontype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeepositiontype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_company_UserEntityInstanceDatas")]
    public ait_company ait_company_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactcertification_UserEntityInstanceDatas")]
    public ait_contactcertification ait_contactcertification_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contacteducation_UserEntityInstanceDatas")]
    public ait_contacteducation ait_contacteducation_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactemployment_UserEntityInstanceDatas")]
    public ait_contactemployment ait_contactemployment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactimage_UserEntityInstanceDatas")]
    public ait_contactimage ait_contactimage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactimage_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactimage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactincarceration_UserEntityInstanceDatas")]
    public ait_contactincarceration ait_contactincarceration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_UserEntityInstanceDatas")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactlanguage_UserEntityInstanceDatas")]
    public ait_contactlanguage ait_contactlanguage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_UserEntityInstanceDatas")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactname_UserEntityInstanceDatas")]
    public ait_contactname ait_contactname_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactname>(nameof (ait_contactname_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactskill_UserEntityInstanceDatas")]
    public ait_contactskill ait_contactskill_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactskill_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactskill_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_countryregion_UserEntityInstanceDatas")]
    public ait_countryregion ait_countryregion_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_county_UserEntityInstanceDatas")]
    public ait_county ait_county_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_county>(nameof (ait_county_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_county_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_county>(nameof (ait_county_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_county_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtcase_UserEntityInstanceDatas")]
    public ait_courtcase ait_courtcase_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtfinesandfees_UserEntityInstanceDatas")]
    public ait_courtfinesandfees ait_courtfinesandfees_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtparty_UserEntityInstanceDatas")]
    public ait_courtparty ait_courtparty_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtpayments_UserEntityInstanceDatas")]
    public ait_courtpayments ait_courtpayments_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtprofile_UserEntityInstanceDatas")]
    public ait_courtprofile ait_courtprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtprofileaddress_UserEntityInstanceDatas")]
    public ait_courtprofileaddress ait_courtprofileaddress_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtroom_UserEntityInstanceDatas")]
    public ait_courtroom ait_courtroom_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtroom_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtroom_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_datamigrationhistory_UserEntityInstanceDatas")]
    public ait_datamigrationhistory ait_datamigrationhistory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_deathrecord_UserEntityInstanceDatas")]
    public ait_deathrecord ait_deathrecord_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_degree_UserEntityInstanceDatas")]
    public ait_degree ait_degree_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_degree>(nameof (ait_degree_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_degree_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_degree>(nameof (ait_degree_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_degree_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_electronicaddress_UserEntityInstanceDatas")]
    public ait_electronicaddress ait_electronicaddress_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_emergencycontact_UserEntityInstanceDatas")]
    public ait_emergencycontact ait_emergencycontact_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_familygroup_UserEntityInstanceDatas")]
    public ait_familygroup ait_familygroup_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_UserEntityInstanceDatas")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_geographicalarea_UserEntityInstanceDatas")]
    public ait_geographicalarea ait_geographicalarea_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_goal_UserEntityInstanceDatas")]
    public ait_goal ait_goal_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_goal_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_groupactivity_UserEntityInstanceDatas")]
    public ait_groupactivity ait_groupactivity_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_UserEntityInstanceDatas")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_household_UserEntityInstanceDatas")]
    public ait_household ait_household_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_household>(nameof (ait_household_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_householdmember_UserEntityInstanceDatas")]
    public ait_householdmember ait_householdmember_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwaadoption_UserEntityInstanceDatas")]
    public ait_icwaadoption ait_icwaadoption_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwanotice_UserEntityInstanceDatas")]
    public ait_icwanotice ait_icwanotice_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwaregion_UserEntityInstanceDatas")]
    public ait_icwaregion ait_icwaregion_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwaregionnotification_UserEntityInstanceDatas")]
    public ait_icwaregionnotification ait_icwaregionnotification_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_incident_UserEntityInstanceDatas")]
    public ait_incident ait_incident_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_incidenttype_UserEntityInstanceDatas")]
    public ait_incidenttype ait_incidenttype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidenttype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_UserEntityInstanceDatas")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_investigation_UserEntityInstanceDatas")]
    public ait_investigation ait_investigation_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_language_UserEntityInstanceDatas")]
    public ait_language ait_language_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_language_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_language>(nameof (ait_language_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_language_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_languageproficiencylevel_UserEntityInstanceDatas")]
    public ait_languageproficiencylevel ait_languageproficiencylevel_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_loan_UserEntityInstanceDatas")]
    public ait_loan ait_loan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_loan>(nameof (ait_loan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_loandetail_UserEntityInstanceDatas")]
    public ait_loandetail ait_loandetail_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_loantype_UserEntityInstanceDatas")]
    public ait_loantype ait_loantype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loantype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_loantype>(nameof (ait_loantype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loantype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_medicalproviders_UserEntityInstanceDatas")]
    public ait_medicalproviders ait_medicalproviders_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_memberprofile_UserEntityInstanceDatas")]
    public ait_memberprofile ait_memberprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_UserEntityInstanceDatas")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofilemembershipcategory_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofilemembershipcategory_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_memberroll_UserEntityInstanceDatas")]
    public ait_memberroll ait_memberroll_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_membershipcategory_UserEntityInstanceDatas")]
    public ait_membershipcategory ait_membershipcategory_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_UserEntityInstanceDatas")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatuschangerequest_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipstatuschangerequest_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_nametype_UserEntityInstanceDatas")]
    public ait_nametype ait_nametype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_nametype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_nametype>(nameof (ait_nametype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_nametype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_outcome_UserEntityInstanceDatas")]
    public ait_outcome ait_outcome_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_payment_UserEntityInstanceDatas")]
    public ait_payment ait_payment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_payment>(nameof (ait_payment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_physicaladdress_UserEntityInstanceDatas")]
    public ait_physicaladdress ait_physicaladdress_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_placement_UserEntityInstanceDatas")]
    public ait_placement ait_placement_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_placement>(nameof (ait_placement_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_placementlocation_UserEntityInstanceDatas")]
    public ait_placementlocation ait_placementlocation_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_planactivity_UserEntityInstanceDatas")]
    public ait_planactivity ait_planactivity_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmteligibility_UserEntityInstanceDatas")]
    public ait_pmteligibility ait_pmteligibility_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtevent_UserEntityInstanceDatas")]
    public ait_pmtevent ait_pmtevent_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtpaymenttype_UserEntityInstanceDatas")]
    public ait_pmtpaymenttype ait_pmtpaymenttype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmttransaction_UserEntityInstanceDatas")]
    public ait_pmttransaction ait_pmttransaction_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmttransactiondeduction_UserEntityInstanceDatas")]
    public ait_pmttransactiondeduction ait_pmttransactiondeduction_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtwithholding_UserEntityInstanceDatas")]
    public ait_pmtwithholding ait_pmtwithholding_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtwithholdingoverride_UserEntityInstanceDatas")]
    public ait_pmtwithholdingoverride ait_pmtwithholdingoverride_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_program_UserEntityInstanceDatas")]
    public ait_program ait_program_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_referral_UserEntityInstanceDatas")]
    public ait_referral ait_referral_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_relationship_UserEntityInstanceDatas")]
    public ait_relationship ait_relationship_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_relationship>(nameof (ait_relationship_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_reservation_UserEntityInstanceDatas")]
    public ait_reservation ait_reservation_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_reservation_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_reservation>(nameof (ait_reservation_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_reservation_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_resolution_UserEntityInstanceDatas")]
    public ait_resolution ait_resolution_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_resolution_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_resolution>(nameof (ait_resolution_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_resolution_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_roll_UserEntityInstanceDatas")]
    public ait_roll ait_roll_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_roll>(nameof (ait_roll_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_roll>(nameof (ait_roll_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_safetyplan_UserEntityInstanceDatas")]
    public ait_safetyplan ait_safetyplan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_school_UserEntityInstanceDatas")]
    public ait_school ait_school_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_school>(nameof (ait_school_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_school>(nameof (ait_school_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_schooltype_UserEntityInstanceDatas")]
    public ait_schooltype ait_schooltype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_schooltype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_schooltype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_servicerequest_UserEntityInstanceDatas")]
    public ait_servicerequest ait_servicerequest_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_skill_UserEntityInstanceDatas")]
    public ait_skill ait_skill_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_skill>(nameof (ait_skill_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_skill_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_skill>(nameof (ait_skill_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_skill_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_stateprovince_UserEntityInstanceDatas")]
    public ait_stateprovince ait_stateprovince_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_statute_UserEntityInstanceDatas")]
    public ait_statute ait_statute_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_statute>(nameof (ait_statute_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_training_UserEntityInstanceDatas")]
    public ait_training ait_training_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_training_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_training>(nameof (ait_training_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_training_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_trainingtype_UserEntityInstanceDatas")]
    public ait_trainingtype ait_trainingtype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_trainingtype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_trainingtype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_UserEntityInstanceDatas")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_tribe_UserEntityInstanceDatas")]
    public ait_tribe ait_tribe_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_tribe_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_withholdingtype_UserEntityInstanceDatas")]
    public ait_withholdingtype ait_withholdingtype_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_zipcodecity_UserEntityInstanceDatas")]
    public ait_zipcodecity ait_zipcodecity_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_UserEntityInstanceDatas));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("apisettings_UserEntityInstanceDatas")]
    public apisettings apisettings_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<apisettings>(nameof (apisettings_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_UserEntityInstanceDatas));
        this.SetRelatedEntity<apisettings>(nameof (apisettings_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appelement_UserEntityInstanceDatas")]
    public AppElement appelement_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<AppElement>(nameof (appelement_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_UserEntityInstanceDatas));
        this.SetRelatedEntity<AppElement>(nameof (appelement_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("applicationuser_UserEntityInstanceDatas")]
    public ApplicationUser applicationuser_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_UserEntityInstanceDatas));
        this.SetRelatedEntity<ApplicationUser>(nameof (applicationuser_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appmodulecomponentedge_UserEntityInstanceDatas")]
    public AppModuleComponentEdge appmodulecomponentedge_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_UserEntityInstanceDatas));
        this.SetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appmodulecomponentnode_UserEntityInstanceDatas")]
    public AppModuleComponentNode appmodulecomponentnode_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_UserEntityInstanceDatas));
        this.SetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appsetting_UserEntityInstanceDatas")]
    public AppSetting appsetting_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<AppSetting>(nameof (appsetting_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_UserEntityInstanceDatas));
        this.SetRelatedEntity<AppSetting>(nameof (appsetting_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("attributeimageconfig_UserEntityInstanceDatas")]
    public AttributeImageConfig attributeimageconfig_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_UserEntityInstanceDatas));
        this.SetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("bot_UserEntityInstanceDatas")]
    public bot bot_UserEntityInstanceDatas
    {
      get => this.GetRelatedEntity<bot>(nameof (bot_UserEntityInstanceDatas), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (bot_UserEntityInstanceDatas));
        this.SetRelatedEntity<bot>(nameof (bot_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("botcomponent_UserEntityInstanceDatas")]
    public botcomponent botcomponent_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<botcomponent>(nameof (botcomponent_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_UserEntityInstanceDatas));
        this.SetRelatedEntity<botcomponent>(nameof (botcomponent_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("canvasappextendedmetadata_UserEntityInstanceDatas")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_UserEntityInstanceDatas));
        this.SetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("catalog_UserEntityInstanceDatas")]
    public Catalog catalog_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<Catalog>(nameof (catalog_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_UserEntityInstanceDatas));
        this.SetRelatedEntity<Catalog>(nameof (catalog_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("catalogassignment_UserEntityInstanceDatas")]
    public CatalogAssignment catalogassignment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_UserEntityInstanceDatas));
        this.SetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("channelaccessprofile_UserEntityInstanceDatas")]
    public ChannelAccessProfile channelaccessprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_UserEntityInstanceDatas));
        this.SetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("connectionreference_UserEntityInstanceDatas")]
    public connectionreference connectionreference_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<connectionreference>(nameof (connectionreference_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_UserEntityInstanceDatas));
        this.SetRelatedEntity<connectionreference>(nameof (connectionreference_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("connector_UserEntityInstanceDatas")]
    public connector connector_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<connector>(nameof (connector_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_UserEntityInstanceDatas));
        this.SetRelatedEntity<connector>(nameof (connector_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("conversationtranscript_UserEntityInstanceDatas")]
    public conversationtranscript conversationtranscript_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_UserEntityInstanceDatas));
        this.SetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ConvertRule_userentityinstancedatas")]
    public ConvertRule ConvertRule_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntity<ConvertRule>(nameof (ConvertRule_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ConvertRule_userentityinstancedatas));
        this.SetRelatedEntity<ConvertRule>(nameof (ConvertRule_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ConvertRule_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("customapi_UserEntityInstanceDatas")]
    public CustomAPI customapi_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<CustomAPI>(nameof (customapi_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_UserEntityInstanceDatas));
        this.SetRelatedEntity<CustomAPI>(nameof (customapi_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("datalakefolder_UserEntityInstanceDatas")]
    public datalakefolder datalakefolder_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_UserEntityInstanceDatas));
        this.SetRelatedEntity<datalakefolder>(nameof (datalakefolder_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("datalakefolderpermission_UserEntityInstanceDatas")]
    public datalakefolderpermission datalakefolderpermission_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_UserEntityInstanceDatas));
        this.SetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("datalakeworkspace_UserEntityInstanceDatas")]
    public datalakeworkspace datalakeworkspace_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_UserEntityInstanceDatas));
        this.SetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("datalakeworkspacepermission_UserEntityInstanceDatas")]
    public datalakeworkspacepermission datalakeworkspacepermission_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_UserEntityInstanceDatas));
        this.SetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("entityanalyticsconfig_UserEntityInstanceDatas")]
    public EntityAnalyticsConfig entityanalyticsconfig_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_UserEntityInstanceDatas));
        this.SetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("entityimageconfig_UserEntityInstanceDatas")]
    public EntityImageConfig entityimageconfig_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_UserEntityInstanceDatas));
        this.SetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("environmentvariabledefinition_UserEntityInstanceDatas")]
    public EnvironmentVariableDefinition environmentvariabledefinition_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_UserEntityInstanceDatas));
        this.SetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("environmentvariablevalue_UserEntityInstanceDatas")]
    public EnvironmentVariableValue environmentvariablevalue_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_UserEntityInstanceDatas));
        this.SetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("exportsolutionupload_UserEntityInstanceDatas")]
    public ExportSolutionUpload exportsolutionupload_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_UserEntityInstanceDatas));
        this.SetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("externalparty_UserEntityInstanceDatas")]
    public ExternalParty externalparty_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ExternalParty>(nameof (externalparty_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (externalparty_UserEntityInstanceDatas));
        this.SetRelatedEntity<ExternalParty>(nameof (externalparty_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (externalparty_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("flowsession_UserEntityInstanceDatas")]
    public flowsession flowsession_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<flowsession>(nameof (flowsession_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_UserEntityInstanceDatas));
        this.SetRelatedEntity<flowsession>(nameof (flowsession_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("holidaywrapper_UserEntityInstanceDatas")]
    public holidaywrapper holidaywrapper_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_UserEntityInstanceDatas));
        this.SetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("internalcatalogassignment_UserEntityInstanceDatas")]
    public InternalCatalogAssignment internalcatalogassignment_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_UserEntityInstanceDatas));
        this.SetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("knowledgearticle_UserEntityInstanceDatas")]
    public KnowledgeArticle knowledgearticle_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_UserEntityInstanceDatas));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_UserEntityInstanceDatas")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_UserEntityInstanceDatas));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("mailbox_userentityinstancedatas")]
    public Mailbox mailbox_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntity<Mailbox>(nameof (mailbox_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mailbox_userentityinstancedatas));
        this.SetRelatedEntity<Mailbox>(nameof (mailbox_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailbox_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("mbs_pluginprofile_UserEntityInstanceDatas")]
    public mbs_pluginprofile mbs_pluginprofile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_UserEntityInstanceDatas));
        this.SetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibdataset_UserEntityInstanceDatas")]
    public msdyn_AIBDataset msdyn_aibdataset_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdataset_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdataset_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_UserEntityInstanceDatas")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_UserEntityInstanceDatas")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_UserEntityInstanceDatas")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibfile_UserEntityInstanceDatas")]
    public msdyn_AIBFile msdyn_aibfile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_UserEntityInstanceDatas")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfileattacheddata_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfileattacheddata_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiconfiguration_UserEntityInstanceDatas")]
    public msdyn_AIConfiguration msdyn_aiconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aifptrainingdocument_UserEntityInstanceDatas")]
    public msdyn_AIFpTrainingDocument msdyn_aifptrainingdocument_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aimodel_UserEntityInstanceDatas")]
    public msdyn_AIModel msdyn_aimodel_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodimage_UserEntityInstanceDatas")]
    public msdyn_AIOdImage msdyn_aiodimage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodlabel_UserEntityInstanceDatas")]
    public msdyn_AIOdLabel msdyn_aiodlabel_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_UserEntityInstanceDatas")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aitemplate_UserEntityInstanceDatas")]
    public msdyn_AITemplate msdyn_aitemplate_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_UserEntityInstanceDatas")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_analysisjob_UserEntityInstanceDatas")]
    public msdyn_analysisjob msdyn_analysisjob_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_analysisresult_UserEntityInstanceDatas")]
    public msdyn_analysisresult msdyn_analysisresult_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_UserEntityInstanceDatas")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_dataflow_UserEntityInstanceDatas")]
    public msdyn_dataflow msdyn_dataflow_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_federatedarticle_UserEntityInstanceDatas")]
    public msdyn_federatedarticle msdyn_federatedarticle_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_UserEntityInstanceDatas")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_helppage_UserEntityInstanceDatas")]
    public msdyn_helppage msdyn_helppage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_helppage_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_helppage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_UserEntityInstanceDatas")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_UserEntityInstanceDatas")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_UserEntityInstanceDatas")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_richtextfile_UserEntityInstanceDatas")]
    public msdyn_richtextfile msdyn_richtextfile_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_UserEntityInstanceDatas")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_slakpi_UserEntityInstanceDatas")]
    public msdyn_slakpi msdyn_slakpi_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_UserEntityInstanceDatas")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_UserEntityInstanceDatas")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_UserEntityInstanceDatas")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdynce_botcontent_UserEntityInstanceDatas")]
    public msdynce_botcontent msdynce_botcontent_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_UserEntityInstanceDatas));
        this.SetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("package_UserEntityInstanceDatas")]
    public package package_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<package>(nameof (package_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_UserEntityInstanceDatas));
        this.SetRelatedEntity<package>(nameof (package_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("pdfsetting_UserEntityInstanceDatas")]
    public PDFSetting pdfsetting_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<PDFSetting>(nameof (pdfsetting_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_UserEntityInstanceDatas));
        this.SetRelatedEntity<PDFSetting>(nameof (pdfsetting_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("processstageparameter_UserEntityInstanceDatas")]
    public processstageparameter processstageparameter_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<processstageparameter>(nameof (processstageparameter_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_UserEntityInstanceDatas));
        this.SetRelatedEntity<processstageparameter>(nameof (processstageparameter_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("profilerule_UserEntityInstanceDatas")]
    public ChannelAccessProfileRule profilerule_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (profilerule_UserEntityInstanceDatas));
        this.SetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (profilerule_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("provisionlanguageforuser_UserEntityInstanceDatas")]
    public ProvisionLanguageForUser provisionlanguageforuser_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_UserEntityInstanceDatas));
        this.SetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_UserEntityInstanceDatas")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_UserEntityInstanceDatas));
        this.SetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("routingrule_userentityinstancedatas")]
    public RoutingRule routingrule_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntity<RoutingRule>(nameof (routingrule_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingrule_userentityinstancedatas));
        this.SetRelatedEntity<RoutingRule>(nameof (routingrule_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingrule_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("routingruleitem_userentityinstancedatas")]
    public RoutingRuleItem routingruleitem_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (routingruleitem_userentityinstancedatas));
        this.SetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (routingruleitem_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("serviceplan_UserEntityInstanceDatas")]
    public ServicePlan serviceplan_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_UserEntityInstanceDatas));
        this.SetRelatedEntity<ServicePlan>(nameof (serviceplan_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("settingdefinition_UserEntityInstanceDatas")]
    public SettingDefinition settingdefinition_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<SettingDefinition>(nameof (settingdefinition_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_UserEntityInstanceDatas));
        this.SetRelatedEntity<SettingDefinition>(nameof (settingdefinition_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("slabase_userentityinstancedatas")]
    public SLA slabase_userentityinstancedatas
    {
      get
      {
        return this.GetRelatedEntity<SLA>(nameof (slabase_userentityinstancedatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (slabase_userentityinstancedatas));
        this.SetRelatedEntity<SLA>(nameof (slabase_userentityinstancedatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (slabase_userentityinstancedatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_UserEntityInstanceDatas")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_UserEntityInstanceDatas")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas));
        this.SetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("stagesolutionupload_UserEntityInstanceDatas")]
    public StageSolutionUpload stagesolutionupload_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_UserEntityInstanceDatas));
        this.SetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_userentityinstancedata")]
    public Team team_userentityinstancedata
    {
      get => this.GetRelatedEntity<Team>(nameof (team_userentityinstancedata), new EntityRole?());
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("theme_UserEntityInstanceDatas")]
    public Theme theme_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<Theme>(nameof (theme_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (theme_UserEntityInstanceDatas));
        this.SetRelatedEntity<Theme>(nameof (theme_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (theme_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_account")]
    public Account userentityinstancedata_account
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (userentityinstancedata_account), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_account));
        this.SetRelatedEntity<Account>(nameof (userentityinstancedata_account), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_account));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_activitymimeattachment")]
    public ActivityMimeAttachment userentityinstancedata_activitymimeattachment
    {
      get
      {
        return this.GetRelatedEntity<ActivityMimeAttachment>(nameof (userentityinstancedata_activitymimeattachment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_activitymimeattachment));
        this.SetRelatedEntity<ActivityMimeAttachment>(nameof (userentityinstancedata_activitymimeattachment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_activitymimeattachment));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_activityparty")]
    public ActivityParty userentityinstancedata_activityparty
    {
      get
      {
        return this.GetRelatedEntity<ActivityParty>(nameof (userentityinstancedata_activityparty), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_activityparty));
        this.SetRelatedEntity<ActivityParty>(nameof (userentityinstancedata_activityparty), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_activityparty));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_annotation")]
    public Annotation userentityinstancedata_annotation
    {
      get
      {
        return this.GetRelatedEntity<Annotation>(nameof (userentityinstancedata_annotation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_annotation));
        this.SetRelatedEntity<Annotation>(nameof (userentityinstancedata_annotation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_annotation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_appointment")]
    public Appointment userentityinstancedata_appointment
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (userentityinstancedata_appointment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_appointment));
        this.SetRelatedEntity<Appointment>(nameof (userentityinstancedata_appointment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_appointment));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_asyncoperation")]
    public AsyncOperation userentityinstancedata_asyncoperation
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>(nameof (userentityinstancedata_asyncoperation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_asyncoperation));
        this.SetRelatedEntity<AsyncOperation>(nameof (userentityinstancedata_asyncoperation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_asyncoperation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_attributemap")]
    public AttributeMap userentityinstancedata_attributemap
    {
      get
      {
        return this.GetRelatedEntity<AttributeMap>(nameof (userentityinstancedata_attributemap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_attributemap));
        this.SetRelatedEntity<AttributeMap>(nameof (userentityinstancedata_attributemap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_attributemap));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_audit")]
    public Audit userentityinstancedata_audit
    {
      get => this.GetRelatedEntity<Audit>(nameof (userentityinstancedata_audit), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_audit));
        this.SetRelatedEntity<Audit>(nameof (userentityinstancedata_audit), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_audit));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_bulkdeletefailure")]
    public BulkDeleteFailure userentityinstancedata_bulkdeletefailure
    {
      get
      {
        return this.GetRelatedEntity<BulkDeleteFailure>(nameof (userentityinstancedata_bulkdeletefailure), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_bulkdeletefailure));
        this.SetRelatedEntity<BulkDeleteFailure>(nameof (userentityinstancedata_bulkdeletefailure), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_bulkdeletefailure));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_bulkdeleteoperation")]
    public BulkDeleteOperation userentityinstancedata_bulkdeleteoperation
    {
      get
      {
        return this.GetRelatedEntity<BulkDeleteOperation>(nameof (userentityinstancedata_bulkdeleteoperation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_bulkdeleteoperation));
        this.SetRelatedEntity<BulkDeleteOperation>(nameof (userentityinstancedata_bulkdeleteoperation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_bulkdeleteoperation));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("userentityinstancedata_businessunit")]
    public BusinessUnit userentityinstancedata_businessunit
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (userentityinstancedata_businessunit), new EntityRole?());
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_businessunitnewsarticle")]
    public BusinessUnitNewsArticle userentityinstancedata_businessunitnewsarticle
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnitNewsArticle>(nameof (userentityinstancedata_businessunitnewsarticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_businessunitnewsarticle));
        this.SetRelatedEntity<BusinessUnitNewsArticle>(nameof (userentityinstancedata_businessunitnewsarticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_businessunitnewsarticle));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_calendar")]
    public Calendar userentityinstancedata_calendar
    {
      get
      {
        return this.GetRelatedEntity<Calendar>(nameof (userentityinstancedata_calendar), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_calendar));
        this.SetRelatedEntity<Calendar>(nameof (userentityinstancedata_calendar), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_calendar));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_columnmapping")]
    public ColumnMapping userentityinstancedata_columnmapping
    {
      get
      {
        return this.GetRelatedEntity<ColumnMapping>(nameof (userentityinstancedata_columnmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_columnmapping));
        this.SetRelatedEntity<ColumnMapping>(nameof (userentityinstancedata_columnmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_columnmapping));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_connection")]
    public Connection userentityinstancedata_connection
    {
      get
      {
        return this.GetRelatedEntity<Connection>(nameof (userentityinstancedata_connection), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_connection));
        this.SetRelatedEntity<Connection>(nameof (userentityinstancedata_connection), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_connection));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_connectionrole")]
    public ConnectionRole userentityinstancedata_connectionrole
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRole>(nameof (userentityinstancedata_connectionrole), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_connectionrole));
        this.SetRelatedEntity<ConnectionRole>(nameof (userentityinstancedata_connectionrole), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_connectionrole));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_connectionroleassociation")]
    public ConnectionRoleAssociation userentityinstancedata_connectionroleassociation
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRoleAssociation>(nameof (userentityinstancedata_connectionroleassociation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_connectionroleassociation));
        this.SetRelatedEntity<ConnectionRoleAssociation>(nameof (userentityinstancedata_connectionroleassociation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_connectionroleassociation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_connectionroleobjecttypecode")]
    public ConnectionRoleObjectTypeCode userentityinstancedata_connectionroleobjecttypecode
    {
      get
      {
        return this.GetRelatedEntity<ConnectionRoleObjectTypeCode>(nameof (userentityinstancedata_connectionroleobjecttypecode), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_connectionroleobjecttypecode));
        this.SetRelatedEntity<ConnectionRoleObjectTypeCode>(nameof (userentityinstancedata_connectionroleobjecttypecode), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_connectionroleobjecttypecode));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_contact")]
    public Contact userentityinstancedata_contact
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (userentityinstancedata_contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_contact));
        this.SetRelatedEntity<Contact>(nameof (userentityinstancedata_contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_contact));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_customeraddress")]
    public CustomerAddress userentityinstancedata_customeraddress
    {
      get
      {
        return this.GetRelatedEntity<CustomerAddress>(nameof (userentityinstancedata_customeraddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_customeraddress));
        this.SetRelatedEntity<CustomerAddress>(nameof (userentityinstancedata_customeraddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_customeraddress));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_customerrelationship")]
    public CustomerRelationship userentityinstancedata_customerrelationship
    {
      get
      {
        return this.GetRelatedEntity<CustomerRelationship>(nameof (userentityinstancedata_customerrelationship), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_customerrelationship));
        this.SetRelatedEntity<CustomerRelationship>(nameof (userentityinstancedata_customerrelationship), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_customerrelationship));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_dependency")]
    public Dependency userentityinstancedata_dependency
    {
      get
      {
        return this.GetRelatedEntity<Dependency>(nameof (userentityinstancedata_dependency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_dependency));
        this.SetRelatedEntity<Dependency>(nameof (userentityinstancedata_dependency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_dependency));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_displaystring")]
    public DisplayString userentityinstancedata_displaystring
    {
      get
      {
        return this.GetRelatedEntity<DisplayString>(nameof (userentityinstancedata_displaystring), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_displaystring));
        this.SetRelatedEntity<DisplayString>(nameof (userentityinstancedata_displaystring), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_displaystring));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_documentindex")]
    public DocumentIndex userentityinstancedata_documentindex
    {
      get
      {
        return this.GetRelatedEntity<DocumentIndex>(nameof (userentityinstancedata_documentindex), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_documentindex));
        this.SetRelatedEntity<DocumentIndex>(nameof (userentityinstancedata_documentindex), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_documentindex));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_duplicaterecord")]
    public DuplicateRecord userentityinstancedata_duplicaterecord
    {
      get
      {
        return this.GetRelatedEntity<DuplicateRecord>(nameof (userentityinstancedata_duplicaterecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_duplicaterecord));
        this.SetRelatedEntity<DuplicateRecord>(nameof (userentityinstancedata_duplicaterecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_duplicaterecord));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_duplicaterule")]
    public DuplicateRule userentityinstancedata_duplicaterule
    {
      get
      {
        return this.GetRelatedEntity<DuplicateRule>(nameof (userentityinstancedata_duplicaterule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_duplicaterule));
        this.SetRelatedEntity<DuplicateRule>(nameof (userentityinstancedata_duplicaterule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_duplicaterule));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_duplicaterulecondition")]
    public DuplicateRuleCondition userentityinstancedata_duplicaterulecondition
    {
      get
      {
        return this.GetRelatedEntity<DuplicateRuleCondition>(nameof (userentityinstancedata_duplicaterulecondition), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_duplicaterulecondition));
        this.SetRelatedEntity<DuplicateRuleCondition>(nameof (userentityinstancedata_duplicaterulecondition), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_duplicaterulecondition));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_email")]
    public Email userentityinstancedata_email
    {
      get => this.GetRelatedEntity<Email>(nameof (userentityinstancedata_email), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_email));
        this.SetRelatedEntity<Email>(nameof (userentityinstancedata_email), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_email));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_entitymap")]
    public EntityMap userentityinstancedata_entitymap
    {
      get
      {
        return this.GetRelatedEntity<EntityMap>(nameof (userentityinstancedata_entitymap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_entitymap));
        this.SetRelatedEntity<EntityMap>(nameof (userentityinstancedata_entitymap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_entitymap));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_fax")]
    public Fax userentityinstancedata_fax
    {
      get => this.GetRelatedEntity<Fax>(nameof (userentityinstancedata_fax), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_fax));
        this.SetRelatedEntity<Fax>(nameof (userentityinstancedata_fax), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_fax));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_fieldpermission")]
    public FieldPermission userentityinstancedata_fieldpermission
    {
      get
      {
        return this.GetRelatedEntity<FieldPermission>(nameof (userentityinstancedata_fieldpermission), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_fieldpermission));
        this.SetRelatedEntity<FieldPermission>(nameof (userentityinstancedata_fieldpermission), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_fieldpermission));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_fieldsecurityprofile")]
    public FieldSecurityProfile userentityinstancedata_fieldsecurityprofile
    {
      get
      {
        return this.GetRelatedEntity<FieldSecurityProfile>(nameof (userentityinstancedata_fieldsecurityprofile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_fieldsecurityprofile));
        this.SetRelatedEntity<FieldSecurityProfile>(nameof (userentityinstancedata_fieldsecurityprofile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_fieldsecurityprofile));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_goal")]
    public Goal userentityinstancedata_goal
    {
      get => this.GetRelatedEntity<Goal>(nameof (userentityinstancedata_goal), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_goal));
        this.SetRelatedEntity<Goal>(nameof (userentityinstancedata_goal), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_goal));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_goalrollupquery")]
    public GoalRollupQuery userentityinstancedata_goalrollupquery
    {
      get
      {
        return this.GetRelatedEntity<GoalRollupQuery>(nameof (userentityinstancedata_goalrollupquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_goalrollupquery));
        this.SetRelatedEntity<GoalRollupQuery>(nameof (userentityinstancedata_goalrollupquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_goalrollupquery));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_import")]
    public Import userentityinstancedata_import
    {
      get
      {
        return this.GetRelatedEntity<Import>(nameof (userentityinstancedata_import), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_import));
        this.SetRelatedEntity<Import>(nameof (userentityinstancedata_import), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_import));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_importentitymapping")]
    public ImportEntityMapping userentityinstancedata_importentitymapping
    {
      get
      {
        return this.GetRelatedEntity<ImportEntityMapping>(nameof (userentityinstancedata_importentitymapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importentitymapping));
        this.SetRelatedEntity<ImportEntityMapping>(nameof (userentityinstancedata_importentitymapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importentitymapping));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_importfile")]
    public ImportFile userentityinstancedata_importfile
    {
      get
      {
        return this.GetRelatedEntity<ImportFile>(nameof (userentityinstancedata_importfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importfile));
        this.SetRelatedEntity<ImportFile>(nameof (userentityinstancedata_importfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importfile));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_importjob")]
    public ImportJob userentityinstancedata_importjob
    {
      get
      {
        return this.GetRelatedEntity<ImportJob>(nameof (userentityinstancedata_importjob), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importjob));
        this.SetRelatedEntity<ImportJob>(nameof (userentityinstancedata_importjob), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importjob));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_importlog")]
    public ImportLog userentityinstancedata_importlog
    {
      get
      {
        return this.GetRelatedEntity<ImportLog>(nameof (userentityinstancedata_importlog), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importlog));
        this.SetRelatedEntity<ImportLog>(nameof (userentityinstancedata_importlog), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importlog));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_importmap")]
    public ImportMap userentityinstancedata_importmap
    {
      get
      {
        return this.GetRelatedEntity<ImportMap>(nameof (userentityinstancedata_importmap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_importmap));
        this.SetRelatedEntity<ImportMap>(nameof (userentityinstancedata_importmap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_importmap));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_invaliddependency")]
    public InvalidDependency userentityinstancedata_invaliddependency
    {
      get
      {
        return this.GetRelatedEntity<InvalidDependency>(nameof (userentityinstancedata_invaliddependency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_invaliddependency));
        this.SetRelatedEntity<InvalidDependency>(nameof (userentityinstancedata_invaliddependency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_invaliddependency));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_isvconfig")]
    public IsvConfig userentityinstancedata_isvconfig
    {
      get
      {
        return this.GetRelatedEntity<IsvConfig>(nameof (userentityinstancedata_isvconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_isvconfig));
        this.SetRelatedEntity<IsvConfig>(nameof (userentityinstancedata_isvconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_isvconfig));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_kbarticle")]
    public KbArticle userentityinstancedata_kbarticle
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (userentityinstancedata_kbarticle), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_kbarticle));
        this.SetRelatedEntity<KbArticle>(nameof (userentityinstancedata_kbarticle), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_kbarticle));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_kbarticlecomment")]
    public KbArticleComment userentityinstancedata_kbarticlecomment
    {
      get
      {
        return this.GetRelatedEntity<KbArticleComment>(nameof (userentityinstancedata_kbarticlecomment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_kbarticlecomment));
        this.SetRelatedEntity<KbArticleComment>(nameof (userentityinstancedata_kbarticlecomment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_kbarticlecomment));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_kbarticletemplate")]
    public KbArticleTemplate userentityinstancedata_kbarticletemplate
    {
      get
      {
        return this.GetRelatedEntity<KbArticleTemplate>(nameof (userentityinstancedata_kbarticletemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_kbarticletemplate));
        this.SetRelatedEntity<KbArticleTemplate>(nameof (userentityinstancedata_kbarticletemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_kbarticletemplate));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_letter")]
    public Letter userentityinstancedata_letter
    {
      get
      {
        return this.GetRelatedEntity<Letter>(nameof (userentityinstancedata_letter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_letter));
        this.SetRelatedEntity<Letter>(nameof (userentityinstancedata_letter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_letter));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_license")]
    public License userentityinstancedata_license
    {
      get
      {
        return this.GetRelatedEntity<License>(nameof (userentityinstancedata_license), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_license));
        this.SetRelatedEntity<License>(nameof (userentityinstancedata_license), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_license));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_lookupmapping")]
    public LookUpMapping userentityinstancedata_lookupmapping
    {
      get
      {
        return this.GetRelatedEntity<LookUpMapping>(nameof (userentityinstancedata_lookupmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_lookupmapping));
        this.SetRelatedEntity<LookUpMapping>(nameof (userentityinstancedata_lookupmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_lookupmapping));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_mailmergetemplate")]
    public MailMergeTemplate userentityinstancedata_mailmergetemplate
    {
      get
      {
        return this.GetRelatedEntity<MailMergeTemplate>(nameof (userentityinstancedata_mailmergetemplate), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_mailmergetemplate));
        this.SetRelatedEntity<MailMergeTemplate>(nameof (userentityinstancedata_mailmergetemplate), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_mailmergetemplate));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_metric")]
    public Metric userentityinstancedata_metric
    {
      get
      {
        return this.GetRelatedEntity<Metric>(nameof (userentityinstancedata_metric), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_metric));
        this.SetRelatedEntity<Metric>(nameof (userentityinstancedata_metric), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_metric));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_organization")]
    public Organization userentityinstancedata_organization
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (userentityinstancedata_organization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_organization));
        this.SetRelatedEntity<Organization>(nameof (userentityinstancedata_organization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_organization));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_ownermapping")]
    public OwnerMapping userentityinstancedata_ownermapping
    {
      get
      {
        return this.GetRelatedEntity<OwnerMapping>(nameof (userentityinstancedata_ownermapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_ownermapping));
        this.SetRelatedEntity<OwnerMapping>(nameof (userentityinstancedata_ownermapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_ownermapping));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("userentityinstancedata_owning_user")]
    public SystemUser userentityinstancedata_owning_user
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (userentityinstancedata_owning_user), new EntityRole?());
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_phonecall")]
    public PhoneCall userentityinstancedata_phonecall
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (userentityinstancedata_phonecall), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_phonecall));
        this.SetRelatedEntity<PhoneCall>(nameof (userentityinstancedata_phonecall), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_phonecall));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_picklistmapping")]
    public PickListMapping userentityinstancedata_picklistmapping
    {
      get
      {
        return this.GetRelatedEntity<PickListMapping>(nameof (userentityinstancedata_picklistmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_picklistmapping));
        this.SetRelatedEntity<PickListMapping>(nameof (userentityinstancedata_picklistmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_picklistmapping));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_pluginassembly")]
    public PluginAssembly userentityinstancedata_pluginassembly
    {
      get
      {
        return this.GetRelatedEntity<PluginAssembly>(nameof (userentityinstancedata_pluginassembly), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_pluginassembly));
        this.SetRelatedEntity<PluginAssembly>(nameof (userentityinstancedata_pluginassembly), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_pluginassembly));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_plugintype")]
    public PluginType userentityinstancedata_plugintype
    {
      get
      {
        return this.GetRelatedEntity<PluginType>(nameof (userentityinstancedata_plugintype), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_plugintype));
        this.SetRelatedEntity<PluginType>(nameof (userentityinstancedata_plugintype), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_plugintype));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_plugintypestatistic")]
    public PluginTypeStatistic userentityinstancedata_plugintypestatistic
    {
      get
      {
        return this.GetRelatedEntity<PluginTypeStatistic>(nameof (userentityinstancedata_plugintypestatistic), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_plugintypestatistic));
        this.SetRelatedEntity<PluginTypeStatistic>(nameof (userentityinstancedata_plugintypestatistic), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_plugintypestatistic));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_principalentitymap")]
    public PrincipalEntityMap userentityinstancedata_principalentitymap
    {
      get
      {
        return this.GetRelatedEntity<PrincipalEntityMap>(nameof (userentityinstancedata_principalentitymap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_principalentitymap));
        this.SetRelatedEntity<PrincipalEntityMap>(nameof (userentityinstancedata_principalentitymap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_principalentitymap));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_principalobjectattributeaccess")]
    public PrincipalObjectAttributeAccess userentityinstancedata_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<PrincipalObjectAttributeAccess>(nameof (userentityinstancedata_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_principalobjectattributeaccess));
        this.SetRelatedEntity<PrincipalObjectAttributeAccess>(nameof (userentityinstancedata_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_privilege")]
    public Privilege userentityinstancedata_privilege
    {
      get
      {
        return this.GetRelatedEntity<Privilege>(nameof (userentityinstancedata_privilege), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_privilege));
        this.SetRelatedEntity<Privilege>(nameof (userentityinstancedata_privilege), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_privilege));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_processsession")]
    public ProcessSession userentityinstancedata_processsession
    {
      get
      {
        return this.GetRelatedEntity<ProcessSession>(nameof (userentityinstancedata_processsession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_processsession));
        this.SetRelatedEntity<ProcessSession>(nameof (userentityinstancedata_processsession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_processsession));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_publisher")]
    public Publisher userentityinstancedata_publisher
    {
      get
      {
        return this.GetRelatedEntity<Publisher>(nameof (userentityinstancedata_publisher), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_publisher));
        this.SetRelatedEntity<Publisher>(nameof (userentityinstancedata_publisher), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_publisher));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_publisheraddress")]
    public PublisherAddress userentityinstancedata_publisheraddress
    {
      get
      {
        return this.GetRelatedEntity<PublisherAddress>(nameof (userentityinstancedata_publisheraddress), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_publisheraddress));
        this.SetRelatedEntity<PublisherAddress>(nameof (userentityinstancedata_publisheraddress), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_publisheraddress));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_queue")]
    public Queue userentityinstancedata_queue
    {
      get => this.GetRelatedEntity<Queue>(nameof (userentityinstancedata_queue), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_queue));
        this.SetRelatedEntity<Queue>(nameof (userentityinstancedata_queue), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_queue));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_queueitem")]
    public QueueItem userentityinstancedata_queueitem
    {
      get
      {
        return this.GetRelatedEntity<QueueItem>(nameof (userentityinstancedata_queueitem), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_queueitem));
        this.SetRelatedEntity<QueueItem>(nameof (userentityinstancedata_queueitem), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_queueitem));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_recurringappointmentmaster")]
    public RecurringAppointmentMaster userentityinstancedata_recurringappointmentmaster
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (userentityinstancedata_recurringappointmentmaster), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_recurringappointmentmaster));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (userentityinstancedata_recurringappointmentmaster), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_recurringappointmentmaster));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_relationshiprole")]
    public RelationshipRole userentityinstancedata_relationshiprole
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>(nameof (userentityinstancedata_relationshiprole), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_relationshiprole));
        this.SetRelatedEntity<RelationshipRole>(nameof (userentityinstancedata_relationshiprole), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_relationshiprole));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_relationshiprolemap")]
    public RelationshipRoleMap userentityinstancedata_relationshiprolemap
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRoleMap>(nameof (userentityinstancedata_relationshiprolemap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_relationshiprolemap));
        this.SetRelatedEntity<RelationshipRoleMap>(nameof (userentityinstancedata_relationshiprolemap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_relationshiprolemap));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_report")]
    public Report userentityinstancedata_report
    {
      get
      {
        return this.GetRelatedEntity<Report>(nameof (userentityinstancedata_report), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_report));
        this.SetRelatedEntity<Report>(nameof (userentityinstancedata_report), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_report));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_reportcategory")]
    public ReportCategory userentityinstancedata_reportcategory
    {
      get
      {
        return this.GetRelatedEntity<ReportCategory>(nameof (userentityinstancedata_reportcategory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_reportcategory));
        this.SetRelatedEntity<ReportCategory>(nameof (userentityinstancedata_reportcategory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_reportcategory));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_reportentity")]
    public ReportEntity userentityinstancedata_reportentity
    {
      get
      {
        return this.GetRelatedEntity<ReportEntity>(nameof (userentityinstancedata_reportentity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_reportentity));
        this.SetRelatedEntity<ReportEntity>(nameof (userentityinstancedata_reportentity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_reportentity));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_reportlink")]
    public ReportLink userentityinstancedata_reportlink
    {
      get
      {
        return this.GetRelatedEntity<ReportLink>(nameof (userentityinstancedata_reportlink), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_reportlink));
        this.SetRelatedEntity<ReportLink>(nameof (userentityinstancedata_reportlink), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_reportlink));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_reportvisibility")]
    public ReportVisibility userentityinstancedata_reportvisibility
    {
      get
      {
        return this.GetRelatedEntity<ReportVisibility>(nameof (userentityinstancedata_reportvisibility), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_reportvisibility));
        this.SetRelatedEntity<ReportVisibility>(nameof (userentityinstancedata_reportvisibility), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_reportvisibility));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_ribboncustomization")]
    public RibbonCustomization userentityinstancedata_ribboncustomization
    {
      get
      {
        return this.GetRelatedEntity<RibbonCustomization>(nameof (userentityinstancedata_ribboncustomization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_ribboncustomization));
        this.SetRelatedEntity<RibbonCustomization>(nameof (userentityinstancedata_ribboncustomization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_ribboncustomization));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_role")]
    public Role userentityinstancedata_role
    {
      get => this.GetRelatedEntity<Role>(nameof (userentityinstancedata_role), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_role));
        this.SetRelatedEntity<Role>(nameof (userentityinstancedata_role), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_role));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_rollupfield")]
    public RollupField userentityinstancedata_rollupfield
    {
      get
      {
        return this.GetRelatedEntity<RollupField>(nameof (userentityinstancedata_rollupfield), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_rollupfield));
        this.SetRelatedEntity<RollupField>(nameof (userentityinstancedata_rollupfield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_rollupfield));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_savedquery")]
    public SavedQuery userentityinstancedata_savedquery
    {
      get
      {
        return this.GetRelatedEntity<SavedQuery>(nameof (userentityinstancedata_savedquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_savedquery));
        this.SetRelatedEntity<SavedQuery>(nameof (userentityinstancedata_savedquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_savedquery));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_savedqueryvisualization")]
    public SavedQueryVisualization userentityinstancedata_savedqueryvisualization
    {
      get
      {
        return this.GetRelatedEntity<SavedQueryVisualization>(nameof (userentityinstancedata_savedqueryvisualization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_savedqueryvisualization));
        this.SetRelatedEntity<SavedQueryVisualization>(nameof (userentityinstancedata_savedqueryvisualization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_savedqueryvisualization));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessage")]
    public SdkMessage userentityinstancedata_sdkmessage
    {
      get
      {
        return this.GetRelatedEntity<SdkMessage>(nameof (userentityinstancedata_sdkmessage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessage));
        this.SetRelatedEntity<SdkMessage>(nameof (userentityinstancedata_sdkmessage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessage));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessagefilter")]
    public SdkMessageFilter userentityinstancedata_sdkmessagefilter
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageFilter>(nameof (userentityinstancedata_sdkmessagefilter), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessagefilter));
        this.SetRelatedEntity<SdkMessageFilter>(nameof (userentityinstancedata_sdkmessagefilter), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessagefilter));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessagepair")]
    public SdkMessagePair userentityinstancedata_sdkmessagepair
    {
      get
      {
        return this.GetRelatedEntity<SdkMessagePair>(nameof (userentityinstancedata_sdkmessagepair), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessagepair));
        this.SetRelatedEntity<SdkMessagePair>(nameof (userentityinstancedata_sdkmessagepair), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessagepair));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstep")]
    public SdkMessageProcessingStep userentityinstancedata_sdkmessageprocessingstep
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageProcessingStep>(nameof (userentityinstancedata_sdkmessageprocessingstep), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageprocessingstep));
        this.SetRelatedEntity<SdkMessageProcessingStep>(nameof (userentityinstancedata_sdkmessageprocessingstep), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageprocessingstep));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstepimage")]
    public SdkMessageProcessingStepImage userentityinstancedata_sdkmessageprocessingstepimage
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageProcessingStepImage>(nameof (userentityinstancedata_sdkmessageprocessingstepimage), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageprocessingstepimage));
        this.SetRelatedEntity<SdkMessageProcessingStepImage>(nameof (userentityinstancedata_sdkmessageprocessingstepimage), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageprocessingstepimage));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessageprocessingstepsecureconfig")]
    public SdkMessageProcessingStepSecureConfig userentityinstancedata_sdkmessageprocessingstepsecureconfig
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageProcessingStepSecureConfig>(nameof (userentityinstancedata_sdkmessageprocessingstepsecureconfig), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageprocessingstepsecureconfig));
        this.SetRelatedEntity<SdkMessageProcessingStepSecureConfig>(nameof (userentityinstancedata_sdkmessageprocessingstepsecureconfig), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageprocessingstepsecureconfig));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessagerequest")]
    public SdkMessageRequest userentityinstancedata_sdkmessagerequest
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageRequest>(nameof (userentityinstancedata_sdkmessagerequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessagerequest));
        this.SetRelatedEntity<SdkMessageRequest>(nameof (userentityinstancedata_sdkmessagerequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessagerequest));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessagerequestfield")]
    public SdkMessageRequestField userentityinstancedata_sdkmessagerequestfield
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageRequestField>(nameof (userentityinstancedata_sdkmessagerequestfield), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessagerequestfield));
        this.SetRelatedEntity<SdkMessageRequestField>(nameof (userentityinstancedata_sdkmessagerequestfield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessagerequestfield));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessageresponse")]
    public SdkMessageResponse userentityinstancedata_sdkmessageresponse
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageResponse>(nameof (userentityinstancedata_sdkmessageresponse), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageresponse));
        this.SetRelatedEntity<SdkMessageResponse>(nameof (userentityinstancedata_sdkmessageresponse), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageresponse));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sdkmessageresponsefield")]
    public SdkMessageResponseField userentityinstancedata_sdkmessageresponsefield
    {
      get
      {
        return this.GetRelatedEntity<SdkMessageResponseField>(nameof (userentityinstancedata_sdkmessageresponsefield), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sdkmessageresponsefield));
        this.SetRelatedEntity<SdkMessageResponseField>(nameof (userentityinstancedata_sdkmessageresponsefield), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sdkmessageresponsefield));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_serviceendpoint")]
    public ServiceEndpoint userentityinstancedata_serviceendpoint
    {
      get
      {
        return this.GetRelatedEntity<ServiceEndpoint>(nameof (userentityinstancedata_serviceendpoint), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_serviceendpoint));
        this.SetRelatedEntity<ServiceEndpoint>(nameof (userentityinstancedata_serviceendpoint), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_serviceendpoint));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sharepointdocumentlocation")]
    public SharePointDocumentLocation userentityinstancedata_sharepointdocumentlocation
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>(nameof (userentityinstancedata_sharepointdocumentlocation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sharepointdocumentlocation));
        this.SetRelatedEntity<SharePointDocumentLocation>(nameof (userentityinstancedata_sharepointdocumentlocation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sharepointdocumentlocation));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sharepointsite")]
    public SharePointSite userentityinstancedata_sharepointsite
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>(nameof (userentityinstancedata_sharepointsite), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sharepointsite));
        this.SetRelatedEntity<SharePointSite>(nameof (userentityinstancedata_sharepointsite), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sharepointsite));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_sitemap")]
    public SiteMap userentityinstancedata_sitemap
    {
      get
      {
        return this.GetRelatedEntity<SiteMap>(nameof (userentityinstancedata_sitemap), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_sitemap));
        this.SetRelatedEntity<SiteMap>(nameof (userentityinstancedata_sitemap), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_sitemap));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_socialactivity")]
    public SocialActivity userentityinstancedata_socialactivity
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (userentityinstancedata_socialactivity), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_socialactivity));
        this.SetRelatedEntity<SocialActivity>(nameof (userentityinstancedata_socialactivity), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_socialactivity));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_solution")]
    public Solution userentityinstancedata_solution
    {
      get
      {
        return this.GetRelatedEntity<Solution>(nameof (userentityinstancedata_solution), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_solution));
        this.SetRelatedEntity<Solution>(nameof (userentityinstancedata_solution), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_solution));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_solutioncomponent")]
    public SolutionComponent userentityinstancedata_solutioncomponent
    {
      get
      {
        return this.GetRelatedEntity<SolutionComponent>(nameof (userentityinstancedata_solutioncomponent), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_solutioncomponent));
        this.SetRelatedEntity<SolutionComponent>(nameof (userentityinstancedata_solutioncomponent), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_solutioncomponent));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_subject")]
    public Subject userentityinstancedata_subject
    {
      get
      {
        return this.GetRelatedEntity<Subject>(nameof (userentityinstancedata_subject), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_subject));
        this.SetRelatedEntity<Subject>(nameof (userentityinstancedata_subject), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_subject));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_subscriptionmanuallytrackedobject")]
    public SubscriptionManuallyTrackedObject userentityinstancedata_subscriptionmanuallytrackedobject
    {
      get
      {
        return this.GetRelatedEntity<SubscriptionManuallyTrackedObject>(nameof (userentityinstancedata_subscriptionmanuallytrackedobject), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_subscriptionmanuallytrackedobject));
        this.SetRelatedEntity<SubscriptionManuallyTrackedObject>(nameof (userentityinstancedata_subscriptionmanuallytrackedobject), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_subscriptionmanuallytrackedobject));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_systemuser")]
    public SystemUser userentityinstancedata_systemuser
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (userentityinstancedata_systemuser), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_systemuser));
        this.SetRelatedEntity<SystemUser>(nameof (userentityinstancedata_systemuser), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_systemuser));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_task")]
    public Task userentityinstancedata_task
    {
      get => this.GetRelatedEntity<Task>(nameof (userentityinstancedata_task), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_task));
        this.SetRelatedEntity<Task>(nameof (userentityinstancedata_task), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_task));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_team")]
    public Team userentityinstancedata_team
    {
      get => this.GetRelatedEntity<Team>(nameof (userentityinstancedata_team), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_team));
        this.SetRelatedEntity<Team>(nameof (userentityinstancedata_team), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_team));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_teammembership")]
    public TeamMembership userentityinstancedata_teammembership
    {
      get
      {
        return this.GetRelatedEntity<TeamMembership>(nameof (userentityinstancedata_teammembership), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_teammembership));
        this.SetRelatedEntity<TeamMembership>(nameof (userentityinstancedata_teammembership), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_teammembership));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_template")]
    public Template userentityinstancedata_template
    {
      get
      {
        return this.GetRelatedEntity<Template>(nameof (userentityinstancedata_template), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_template));
        this.SetRelatedEntity<Template>(nameof (userentityinstancedata_template), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_template));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_territory")]
    public Territory userentityinstancedata_territory
    {
      get
      {
        return this.GetRelatedEntity<Territory>(nameof (userentityinstancedata_territory), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_territory));
        this.SetRelatedEntity<Territory>(nameof (userentityinstancedata_territory), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_territory));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_timezonedefinition")]
    public TimeZoneDefinition userentityinstancedata_timezonedefinition
    {
      get
      {
        return this.GetRelatedEntity<TimeZoneDefinition>(nameof (userentityinstancedata_timezonedefinition), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_timezonedefinition));
        this.SetRelatedEntity<TimeZoneDefinition>(nameof (userentityinstancedata_timezonedefinition), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_timezonedefinition));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_timezonelocalizedname")]
    public TimeZoneLocalizedName userentityinstancedata_timezonelocalizedname
    {
      get
      {
        return this.GetRelatedEntity<TimeZoneLocalizedName>(nameof (userentityinstancedata_timezonelocalizedname), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_timezonelocalizedname));
        this.SetRelatedEntity<TimeZoneLocalizedName>(nameof (userentityinstancedata_timezonelocalizedname), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_timezonelocalizedname));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_timezonerule")]
    public TimeZoneRule userentityinstancedata_timezonerule
    {
      get
      {
        return this.GetRelatedEntity<TimeZoneRule>(nameof (userentityinstancedata_timezonerule), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_timezonerule));
        this.SetRelatedEntity<TimeZoneRule>(nameof (userentityinstancedata_timezonerule), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_timezonerule));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_transactioncurrency")]
    public TransactionCurrency userentityinstancedata_transactioncurrency
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (userentityinstancedata_transactioncurrency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_transactioncurrency));
        this.SetRelatedEntity<TransactionCurrency>(nameof (userentityinstancedata_transactioncurrency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_transactioncurrency));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_transformationmapping")]
    public TransformationMapping userentityinstancedata_transformationmapping
    {
      get
      {
        return this.GetRelatedEntity<TransformationMapping>(nameof (userentityinstancedata_transformationmapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_transformationmapping));
        this.SetRelatedEntity<TransformationMapping>(nameof (userentityinstancedata_transformationmapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_transformationmapping));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_transformationparametermapping")]
    public TransformationParameterMapping userentityinstancedata_transformationparametermapping
    {
      get
      {
        return this.GetRelatedEntity<TransformationParameterMapping>(nameof (userentityinstancedata_transformationparametermapping), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_transformationparametermapping));
        this.SetRelatedEntity<TransformationParameterMapping>(nameof (userentityinstancedata_transformationparametermapping), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_transformationparametermapping));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_userentityuisettings")]
    public UserEntityUISettings userentityinstancedata_userentityuisettings
    {
      get
      {
        return this.GetRelatedEntity<UserEntityUISettings>(nameof (userentityinstancedata_userentityuisettings), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_userentityuisettings));
        this.SetRelatedEntity<UserEntityUISettings>(nameof (userentityinstancedata_userentityuisettings), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_userentityuisettings));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_userform")]
    public UserForm userentityinstancedata_userform
    {
      get
      {
        return this.GetRelatedEntity<UserForm>(nameof (userentityinstancedata_userform), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_userform));
        this.SetRelatedEntity<UserForm>(nameof (userentityinstancedata_userform), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_userform));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_userquery")]
    public UserQuery userentityinstancedata_userquery
    {
      get
      {
        return this.GetRelatedEntity<UserQuery>(nameof (userentityinstancedata_userquery), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_userquery));
        this.SetRelatedEntity<UserQuery>(nameof (userentityinstancedata_userquery), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_userquery));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_userqueryvisualization")]
    public UserQueryVisualization userentityinstancedata_userqueryvisualization
    {
      get
      {
        return this.GetRelatedEntity<UserQueryVisualization>(nameof (userentityinstancedata_userqueryvisualization), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_userqueryvisualization));
        this.SetRelatedEntity<UserQueryVisualization>(nameof (userentityinstancedata_userqueryvisualization), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_userqueryvisualization));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_webresource")]
    public WebResource userentityinstancedata_webresource
    {
      get
      {
        return this.GetRelatedEntity<WebResource>(nameof (userentityinstancedata_webresource), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_webresource));
        this.SetRelatedEntity<WebResource>(nameof (userentityinstancedata_webresource), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_webresource));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_workflow")]
    public Workflow userentityinstancedata_workflow
    {
      get
      {
        return this.GetRelatedEntity<Workflow>(nameof (userentityinstancedata_workflow), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_workflow));
        this.SetRelatedEntity<Workflow>(nameof (userentityinstancedata_workflow), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_workflow));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_workflowdependency")]
    public WorkflowDependency userentityinstancedata_workflowdependency
    {
      get
      {
        return this.GetRelatedEntity<WorkflowDependency>(nameof (userentityinstancedata_workflowdependency), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_workflowdependency));
        this.SetRelatedEntity<WorkflowDependency>(nameof (userentityinstancedata_workflowdependency), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_workflowdependency));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("userentityinstancedata_workflowlog")]
    public WorkflowLog userentityinstancedata_workflowlog
    {
      get
      {
        return this.GetRelatedEntity<WorkflowLog>(nameof (userentityinstancedata_workflowlog), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_workflowlog));
        this.SetRelatedEntity<WorkflowLog>(nameof (userentityinstancedata_workflowlog), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_workflowlog));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("usermapping_UserEntityInstanceDatas")]
    public UserMapping usermapping_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<UserMapping>(nameof (usermapping_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (usermapping_UserEntityInstanceDatas));
        this.SetRelatedEntity<UserMapping>(nameof (usermapping_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (usermapping_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("workflowbinary_UserEntityInstanceDatas")]
    public workflowbinary workflowbinary_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntity<workflowbinary>(nameof (workflowbinary_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_UserEntityInstanceDatas));
        this.SetRelatedEntity<workflowbinary>(nameof (workflowbinary_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_UserEntityInstanceDatas));
      }
    }

    public UserEntityInstanceData(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["userentityinstancedataid"] = (object) base.Id;
            break;
          case "userentityinstancedataid":
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
