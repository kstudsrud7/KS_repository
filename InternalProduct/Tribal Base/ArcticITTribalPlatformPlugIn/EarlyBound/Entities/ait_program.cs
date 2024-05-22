// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_program
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_program")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_program : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_program";
    public const string EntitySchemaName = "ait_program";
    public const string PrimaryIdAttribute = "ait_programid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_program()
      : base(nameof (ait_program))
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

    [AttributeLogicalName("ait_abbreviation")]
    public string ait_Abbreviation
    {
      get => this.GetAttributeValue<string>("ait_abbreviation");
      set
      {
        this.OnPropertyChanging(nameof (ait_Abbreviation));
        this.SetAttributeValue("ait_abbreviation", (object) value);
        this.OnPropertyChanged(nameof (ait_Abbreviation));
      }
    }

    [AttributeLogicalName("ait_agegrouprequirement")]
    public OptionSetValue ait_AgeGroupRequirement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_agegrouprequirement");
      set
      {
        this.OnPropertyChanging(nameof (ait_AgeGroupRequirement));
        this.SetAttributeValue("ait_agegrouprequirement", (object) value);
        this.OnPropertyChanged(nameof (ait_AgeGroupRequirement));
      }
    }

    [AttributeLogicalName("ait_agemaximum")]
    public int? ait_AgeMaximum
    {
      get => this.GetAttributeValue<int?>("ait_agemaximum");
      set
      {
        this.OnPropertyChanging(nameof (ait_AgeMaximum));
        this.SetAttributeValue("ait_agemaximum", (object) value);
        this.OnPropertyChanged(nameof (ait_AgeMaximum));
      }
    }

    [AttributeLogicalName("ait_ageminimum")]
    public int? ait_AgeMinimum
    {
      get => this.GetAttributeValue<int?>("ait_ageminimum");
      set
      {
        this.OnPropertyChanging(nameof (ait_AgeMinimum));
        this.SetAttributeValue("ait_ageminimum", (object) value);
        this.OnPropertyChanged(nameof (ait_AgeMinimum));
      }
    }

    [AttributeLogicalName("ait_autocreatewithholding")]
    public bool? ait_AutoCreateWithholding
    {
      get => this.GetAttributeValue<bool?>("ait_autocreatewithholding");
      set
      {
        this.OnPropertyChanging(nameof (ait_AutoCreateWithholding));
        this.SetAttributeValue("ait_autocreatewithholding", (object) value);
        this.OnPropertyChanged(nameof (ait_AutoCreateWithholding));
      }
    }

    [AttributeLogicalName("ait_category")]
    public OptionSetValue ait_Category
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_category");
      set
      {
        this.OnPropertyChanging(nameof (ait_Category));
        this.SetAttributeValue("ait_category", (object) value);
        this.OnPropertyChanged(nameof (ait_Category));
      }
    }

    [AttributeLogicalName("ait_costcode")]
    public string ait_CostCode
    {
      get => this.GetAttributeValue<string>("ait_costcode");
      set
      {
        this.OnPropertyChanging(nameof (ait_CostCode));
        this.SetAttributeValue("ait_costcode", (object) value);
        this.OnPropertyChanged(nameof (ait_CostCode));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_Description
    {
      get => this.GetAttributeValue<string>("ait_description");
      set
      {
        this.OnPropertyChanging(nameof (ait_Description));
        this.SetAttributeValue("ait_description", (object) value);
        this.OnPropertyChanged(nameof (ait_Description));
      }
    }

    [AttributeLogicalName("ait_ethnicity")]
    public OptionSetValue ait_Ethnicity
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_ethnicity");
      set
      {
        this.OnPropertyChanging(nameof (ait_Ethnicity));
        this.SetAttributeValue("ait_ethnicity", (object) value);
        this.OnPropertyChanged(nameof (ait_Ethnicity));
      }
    }

    [AttributeLogicalName("ait_exclusions")]
    public string ait_Exclusions
    {
      get => this.GetAttributeValue<string>("ait_exclusions");
      set
      {
        this.OnPropertyChanging(nameof (ait_Exclusions));
        this.SetAttributeValue("ait_exclusions", (object) value);
        this.OnPropertyChanged(nameof (ait_Exclusions));
      }
    }

    [AttributeLogicalName("ait_familygroupminimumnumber")]
    public int? ait_FamilyGroupMinimumNumber
    {
      get => this.GetAttributeValue<int?>("ait_familygroupminimumnumber");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyGroupMinimumNumber));
        this.SetAttributeValue("ait_familygroupminimumnumber", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyGroupMinimumNumber));
      }
    }

    [AttributeLogicalName("ait_fundingmaximum")]
    public Money ait_FundingMaximum
    {
      get => this.GetAttributeValue<Money>("ait_fundingmaximum");
      set
      {
        this.OnPropertyChanging(nameof (ait_FundingMaximum));
        this.SetAttributeValue("ait_fundingmaximum", (object) value);
        this.OnPropertyChanged(nameof (ait_FundingMaximum));
      }
    }

    [AttributeLogicalName("ait_fundingmaximum_base")]
    public Money ait_fundingmaximum_Base
    {
      get => this.GetAttributeValue<Money>("ait_fundingmaximum_base");
    }

    [AttributeLogicalName("ait_fundingrecommendation")]
    public Money ait_FundingRecommendation
    {
      get => this.GetAttributeValue<Money>("ait_fundingrecommendation");
      set
      {
        this.OnPropertyChanging(nameof (ait_FundingRecommendation));
        this.SetAttributeValue("ait_fundingrecommendation", (object) value);
        this.OnPropertyChanged(nameof (ait_FundingRecommendation));
      }
    }

    [AttributeLogicalName("ait_fundingrecommendation_base")]
    public Money ait_fundingrecommendation_Base
    {
      get => this.GetAttributeValue<Money>("ait_fundingrecommendation_base");
    }

    [AttributeLogicalName("ait_gender")]
    public OptionSetValue ait_Gender
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_gender");
      set
      {
        this.OnPropertyChanging(nameof (ait_Gender));
        this.SetAttributeValue("ait_gender", (object) value);
        this.OnPropertyChanged(nameof (ait_Gender));
      }
    }

    [AttributeLogicalName("ait_grantfunded")]
    public OptionSetValue ait_GrantFunded
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_grantfunded");
      set
      {
        this.OnPropertyChanging(nameof (ait_GrantFunded));
        this.SetAttributeValue("ait_grantfunded", (object) value);
        this.OnPropertyChanged(nameof (ait_GrantFunded));
      }
    }

    [AttributeLogicalName("ait_grantname")]
    public string ait_GrantName
    {
      get => this.GetAttributeValue<string>("ait_grantname");
      set
      {
        this.OnPropertyChanging(nameof (ait_GrantName));
        this.SetAttributeValue("ait_grantname", (object) value);
        this.OnPropertyChanged(nameof (ait_GrantName));
      }
    }

    [AttributeLogicalName("ait_incomemaximum")]
    public Money ait_IncomeMaximum
    {
      get => this.GetAttributeValue<Money>("ait_incomemaximum");
      set
      {
        this.OnPropertyChanging(nameof (ait_IncomeMaximum));
        this.SetAttributeValue("ait_incomemaximum", (object) value);
        this.OnPropertyChanged(nameof (ait_IncomeMaximum));
      }
    }

    [AttributeLogicalName("ait_incomemaximum_base")]
    public Money ait_incomemaximum_Base => this.GetAttributeValue<Money>("ait_incomemaximum_base");

    [AttributeLogicalName("ait_incomeminimum")]
    public Money ait_IncomeMinimum
    {
      get => this.GetAttributeValue<Money>("ait_incomeminimum");
      set
      {
        this.OnPropertyChanging(nameof (ait_IncomeMinimum));
        this.SetAttributeValue("ait_incomeminimum", (object) value);
        this.OnPropertyChanged(nameof (ait_IncomeMinimum));
      }
    }

    [AttributeLogicalName("ait_incomeminimum_base")]
    public Money ait_incomeminimum_Base => this.GetAttributeValue<Money>("ait_incomeminimum_base");

    [AttributeLogicalName("ait_maximumparticipants")]
    public int? ait_MaximumParticipants
    {
      get => this.GetAttributeValue<int?>("ait_maximumparticipants");
      set
      {
        this.OnPropertyChanging(nameof (ait_MaximumParticipants));
        this.SetAttributeValue("ait_maximumparticipants", (object) value);
        this.OnPropertyChanged(nameof (ait_MaximumParticipants));
      }
    }

    [AttributeLogicalName("ait_maximumreferrals")]
    public int? ait_MaximumReferrals
    {
      get => this.GetAttributeValue<int?>("ait_maximumreferrals");
      set
      {
        this.OnPropertyChanging(nameof (ait_MaximumReferrals));
        this.SetAttributeValue("ait_maximumreferrals", (object) value);
        this.OnPropertyChanged(nameof (ait_MaximumReferrals));
      }
    }

    [AttributeLogicalName("ait_membershiprequirement")]
    public OptionSetValue ait_MembershipRequirement
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_membershiprequirement");
      set
      {
        this.OnPropertyChanging(nameof (ait_MembershipRequirement));
        this.SetAttributeValue("ait_membershiprequirement", (object) value);
        this.OnPropertyChanged(nameof (ait_MembershipRequirement));
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

    [AttributeLogicalName("ait_programautoid")]
    public string ait_ProgramAutoID
    {
      get => this.GetAttributeValue<string>("ait_programautoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProgramAutoID));
        this.SetAttributeValue("ait_programautoid", (object) value);
        this.OnPropertyChanged(nameof (ait_ProgramAutoID));
      }
    }

    [AttributeLogicalName("ait_programbudget")]
    public Money ait_ProgramBudget
    {
      get => this.GetAttributeValue<Money>("ait_programbudget");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProgramBudget));
        this.SetAttributeValue("ait_programbudget", (object) value);
        this.OnPropertyChanged(nameof (ait_ProgramBudget));
      }
    }

    [AttributeLogicalName("ait_programbudget_base")]
    public Money ait_programbudget_Base => this.GetAttributeValue<Money>("ait_programbudget_base");

    [AttributeLogicalName("ait_programenddate")]
    public DateTime? ait_ProgramEndDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_programenddate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProgramEndDate));
        this.SetAttributeValue("ait_programenddate", (object) value);
        this.OnPropertyChanged(nameof (ait_ProgramEndDate));
      }
    }

    [AttributeLogicalName("ait_programid")]
    public Guid? ait_programId
    {
      get => this.GetAttributeValue<Guid?>("ait_programid");
      set
      {
        this.OnPropertyChanging(nameof (ait_programId));
        this.SetAttributeValue("ait_programid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_programId));
      }
    }

    [AttributeLogicalName("ait_programid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_programId = new Guid?(value);
    }

    [AttributeLogicalName("ait_programmanager")]
    public EntityReference ait_ProgramManager
    {
      get => this.GetAttributeValue<EntityReference>("ait_programmanager");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProgramManager));
        this.SetAttributeValue("ait_programmanager", (object) value);
        this.OnPropertyChanged(nameof (ait_ProgramManager));
      }
    }

    [AttributeLogicalName("ait_programstartdate")]
    public DateTime? ait_ProgramStartDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_programstartdate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProgramStartDate));
        this.SetAttributeValue("ait_programstartdate", (object) value);
        this.OnPropertyChanged(nameof (ait_ProgramStartDate));
      }
    }

    [AttributeLogicalName("ait_programstatus")]
    public OptionSetValue ait_ProgramStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_programstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_ProgramStatus));
        this.SetAttributeValue("ait_programstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_ProgramStatus));
      }
    }

    [AttributeLogicalName("ait_remainingfunds")]
    public Money ait_RemainingFunds => this.GetAttributeValue<Money>("ait_remainingfunds");

    [AttributeLogicalName("ait_remainingfunds_base")]
    public Money ait_remainingfunds_Base
    {
      get => this.GetAttributeValue<Money>("ait_remainingfunds_base");
    }

    [AttributeLogicalName("ait_staffingrequirements")]
    public string ait_StaffingRequirements
    {
      get => this.GetAttributeValue<string>("ait_staffingrequirements");
      set
      {
        this.OnPropertyChanging(nameof (ait_StaffingRequirements));
        this.SetAttributeValue("ait_staffingrequirements", (object) value);
        this.OnPropertyChanged(nameof (ait_StaffingRequirements));
      }
    }

    [AttributeLogicalName("ait_totalassistancerequests")]
    public int? ait_TotalAssistanceRequests
    {
      get => this.GetAttributeValue<int?>("ait_totalassistancerequests");
    }

    [AttributeLogicalName("ait_totalassistancerequests_date")]
    public DateTime? ait_TotalAssistanceRequests_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalassistancerequests_date");
    }

    [AttributeLogicalName("ait_totalassistancerequests_state")]
    public int? ait_TotalAssistanceRequests_State
    {
      get => this.GetAttributeValue<int?>("ait_totalassistancerequests_state");
    }

    [AttributeLogicalName("ait_totalcounselingrequests")]
    public int? ait_TotalCounselingRequests
    {
      get => this.GetAttributeValue<int?>("ait_totalcounselingrequests");
    }

    [AttributeLogicalName("ait_totalcounselingrequests_date")]
    public DateTime? ait_TotalCounselingRequests_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalcounselingrequests_date");
    }

    [AttributeLogicalName("ait_totalcounselingrequests_state")]
    public int? ait_TotalCounselingRequests_State
    {
      get => this.GetAttributeValue<int?>("ait_totalcounselingrequests_state");
    }

    [AttributeLogicalName("ait_totalgroupactivities")]
    public int? ait_TotalGroupActivities
    {
      get => this.GetAttributeValue<int?>("ait_totalgroupactivities");
    }

    [AttributeLogicalName("ait_totalgroupactivities_date")]
    public DateTime? ait_TotalGroupActivities_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalgroupactivities_date");
    }

    [AttributeLogicalName("ait_totalgroupactivities_state")]
    public int? ait_TotalGroupActivities_State
    {
      get => this.GetAttributeValue<int?>("ait_totalgroupactivities_state");
    }

    [AttributeLogicalName("ait_totalpayments")]
    public Money ait_TotalPayments => this.GetAttributeValue<Money>("ait_totalpayments");

    [AttributeLogicalName("ait_totalpayments_base")]
    public Money ait_totalpayments_Base => this.GetAttributeValue<Money>("ait_totalpayments_base");

    [AttributeLogicalName("ait_totalpayments_date")]
    public DateTime? ait_TotalPayments_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalpayments_date");
    }

    [AttributeLogicalName("ait_totalpayments_state")]
    public int? ait_TotalPayments_State => this.GetAttributeValue<int?>("ait_totalpayments_state");

    [AttributeLogicalName("ait_totalpendingreferrals")]
    public int? ait_TotalPendingReferrals
    {
      get => this.GetAttributeValue<int?>("ait_totalpendingreferrals");
    }

    [AttributeLogicalName("ait_totalpendingreferrals_date")]
    public DateTime? ait_TotalPendingReferrals_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalpendingreferrals_date");
    }

    [AttributeLogicalName("ait_totalpendingreferrals_state")]
    public int? ait_TotalPendingReferrals_State
    {
      get => this.GetAttributeValue<int?>("ait_totalpendingreferrals_state");
    }

    [AttributeLogicalName("ait_totalplacementpayments")]
    public int? ait_TotalPlacementPayments
    {
      get => this.GetAttributeValue<int?>("ait_totalplacementpayments");
      set
      {
        this.OnPropertyChanging(nameof (ait_TotalPlacementPayments));
        this.SetAttributeValue("ait_totalplacementpayments", (object) value);
        this.OnPropertyChanged(nameof (ait_TotalPlacementPayments));
      }
    }

    [AttributeLogicalName("ait_totalplacementpayments_date")]
    public DateTime? ait_TotalPlacementPayments_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalplacementpayments_date");
    }

    [AttributeLogicalName("ait_totalplacementpayments_state")]
    public int? ait_TotalPlacementPayments_State
    {
      get => this.GetAttributeValue<int?>("ait_totalplacementpayments_state");
    }

    [AttributeLogicalName("ait_totalplanparticipants")]
    public int? ait_TotalPlanParticipants
    {
      get => this.GetAttributeValue<int?>("ait_totalplanparticipants");
    }

    [AttributeLogicalName("ait_totalplanparticipants_date")]
    public DateTime? ait_TotalPlanParticipants_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalplanparticipants_date");
    }

    [AttributeLogicalName("ait_totalplanparticipants_state")]
    public int? ait_TotalPlanParticipants_State
    {
      get => this.GetAttributeValue<int?>("ait_totalplanparticipants_state");
    }

    [AttributeLogicalName("ait_totalreferrals")]
    public int? ait_TotalReferrals => this.GetAttributeValue<int?>("ait_totalreferrals");

    [AttributeLogicalName("ait_totalreferrals_date")]
    public DateTime? ait_TotalReferrals_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalreferrals_date");
    }

    [AttributeLogicalName("ait_totalreferrals_state")]
    public int? ait_TotalReferrals_State
    {
      get => this.GetAttributeValue<int?>("ait_totalreferrals_state");
    }

    [AttributeLogicalName("ait_totalservicerequests")]
    public int? ait_TotalServiceRequests
    {
      get => this.GetAttributeValue<int?>("ait_totalservicerequests");
    }

    [AttributeLogicalName("ait_totalservicerequests_date")]
    public DateTime? ait_TotalServiceRequests_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalservicerequests_date");
    }

    [AttributeLogicalName("ait_totalservicerequests_state")]
    public int? ait_TotalServiceRequests_State
    {
      get => this.GetAttributeValue<int?>("ait_totalservicerequests_state");
    }

    [AttributeLogicalName("ait_tribe")]
    public EntityReference ait_Tribe
    {
      get => this.GetAttributeValue<EntityReference>("ait_tribe");
      set
      {
        this.OnPropertyChanging(nameof (ait_Tribe));
        this.SetAttributeValue("ait_tribe", (object) value);
        this.OnPropertyChanged(nameof (ait_Tribe));
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
    public ait_programState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_programState?((ait_programState) Enum.ToObject(typeof (ait_programState), attributeValue.Value)) : new ait_programState?();
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

    [RelationshipSchemaName("ait_ait_program_ait_assessment_Program")]
    public IEnumerable<ait_assessment> ait_ait_program_ait_assessment_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_assessment>(nameof (ait_ait_program_ait_assessment_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_assessment_Program));
        this.SetRelatedEntities<ait_assessment>(nameof (ait_ait_program_ait_assessment_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_assessment_Program));
      }
    }

    [RelationshipSchemaName("ait_ait_program_ait_case_Program")]
    public IEnumerable<ait_case> ait_ait_program_ait_case_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_case>(nameof (ait_ait_program_ait_case_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_case_Program));
        this.SetRelatedEntities<ait_case>(nameof (ait_ait_program_ait_case_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_case_Program));
      }
    }

    [RelationshipSchemaName("ait_ait_program_ait_caseplan_Program")]
    public IEnumerable<ait_caseplan> ait_ait_program_ait_caseplan_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (ait_ait_program_ait_caseplan_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_caseplan_Program));
        this.SetRelatedEntities<ait_caseplan>(nameof (ait_ait_program_ait_caseplan_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_caseplan_Program));
      }
    }

    [RelationshipSchemaName("ait_ait_program_ait_outcome_Program")]
    public IEnumerable<ait_outcome> ait_ait_program_ait_outcome_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_outcome>(nameof (ait_ait_program_ait_outcome_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_outcome_Program));
        this.SetRelatedEntities<ait_outcome>(nameof (ait_ait_program_ait_outcome_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_outcome_Program));
      }
    }

    [RelationshipSchemaName("ait_ait_program_ait_payment_Program")]
    public IEnumerable<ait_payment> ait_ait_program_ait_payment_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_ait_program_ait_payment_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_payment_Program));
        this.SetRelatedEntities<ait_payment>(nameof (ait_ait_program_ait_payment_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_payment_Program));
      }
    }

    [RelationshipSchemaName("ait_ait_program_ait_placement_Program")]
    public IEnumerable<ait_placement> ait_ait_program_ait_placement_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_placement>(nameof (ait_ait_program_ait_placement_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_placement_Program));
        this.SetRelatedEntities<ait_placement>(nameof (ait_ait_program_ait_placement_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_placement_Program));
      }
    }

    [RelationshipSchemaName("ait_ait_program_ait_referral_Program")]
    public IEnumerable<ait_referral> ait_ait_program_ait_referral_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_ait_program_ait_referral_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_referral_Program));
        this.SetRelatedEntities<ait_referral>(nameof (ait_ait_program_ait_referral_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_referral_Program));
      }
    }

    [RelationshipSchemaName("ait_program_ActivityParties")]
    public IEnumerable<ActivityParty> ait_program_ActivityParties
    {
      get
      {
        return this.GetRelatedEntities<ActivityParty>(nameof (ait_program_ActivityParties), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ActivityParties));
        this.SetRelatedEntities<ActivityParty>(nameof (ait_program_ActivityParties), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ActivityParties));
      }
    }

    [RelationshipSchemaName("ait_program_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_program_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_program_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_program_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_program_ait_goal_Program")]
    public IEnumerable<ait_goal> ait_program_ait_goal_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (ait_program_ait_goal_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ait_goal_Program));
        this.SetRelatedEntities<ait_goal>(nameof (ait_program_ait_goal_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ait_goal_Program));
      }
    }

    [RelationshipSchemaName("ait_program_ait_groupactivity_Program")]
    public IEnumerable<ait_groupactivity> ait_program_ait_groupactivity_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_groupactivity>(nameof (ait_program_ait_groupactivity_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ait_groupactivity_Program));
        this.SetRelatedEntities<ait_groupactivity>(nameof (ait_program_ait_groupactivity_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ait_groupactivity_Program));
      }
    }

    [RelationshipSchemaName("ait_program_ait_servicerequest_Program")]
    public IEnumerable<ait_servicerequest> ait_program_ait_servicerequest_Program
    {
      get
      {
        return this.GetRelatedEntities<ait_servicerequest>(nameof (ait_program_ait_servicerequest_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ait_servicerequest_Program));
        this.SetRelatedEntities<ait_servicerequest>(nameof (ait_program_ait_servicerequest_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ait_servicerequest_Program));
      }
    }

    [RelationshipSchemaName("ait_program_Annotations")]
    public IEnumerable<Annotation> ait_program_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_program_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_program_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Annotations));
      }
    }

    [RelationshipSchemaName("ait_program_Appointments")]
    public IEnumerable<Appointment> ait_program_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_program_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_program_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Appointments));
      }
    }

    [RelationshipSchemaName("ait_program_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_program_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_program_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_program_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_program_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_program_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_program_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_program_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_program_Emails")]
    public IEnumerable<Email> ait_program_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_program_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_program_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Emails));
      }
    }

    [RelationshipSchemaName("ait_program_Faxes")]
    public IEnumerable<Fax> ait_program_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_program_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_program_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Faxes));
      }
    }

    [RelationshipSchemaName("ait_program_Letters")]
    public IEnumerable<Letter> ait_program_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_program_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_program_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Letters));
      }
    }

    [RelationshipSchemaName("ait_program_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_program_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_program_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_program_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_program_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_program_PhoneCalls
    {
      get => this.GetRelatedEntities<PhoneCall>(nameof (ait_program_PhoneCalls), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_program_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_program_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_program_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_program_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_program_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_program_ProcessSession")]
    public IEnumerable<ProcessSession> ait_program_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_program_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_program_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_program_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_program_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_program_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_program_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_program_SharePointDocumentLocations")]
    public IEnumerable<SharePointDocumentLocation> ait_program_SharePointDocumentLocations
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocumentLocation>(nameof (ait_program_SharePointDocumentLocations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_SharePointDocumentLocations));
        this.SetRelatedEntities<SharePointDocumentLocation>(nameof (ait_program_SharePointDocumentLocations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_SharePointDocumentLocations));
      }
    }

    [RelationshipSchemaName("ait_program_SharePointDocuments")]
    public IEnumerable<SharePointDocument> ait_program_SharePointDocuments
    {
      get
      {
        return this.GetRelatedEntities<SharePointDocument>(nameof (ait_program_SharePointDocuments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_SharePointDocuments));
        this.SetRelatedEntities<SharePointDocument>(nameof (ait_program_SharePointDocuments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_SharePointDocuments));
      }
    }

    [RelationshipSchemaName("ait_program_SocialActivities")]
    public IEnumerable<SocialActivity> ait_program_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_program_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_program_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_program_SyncErrors")]
    public IEnumerable<SyncError> ait_program_SyncErrors
    {
      get => this.GetRelatedEntities<SyncError>(nameof (ait_program_SyncErrors), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_program_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_program_Tasks")]
    public IEnumerable<Task> ait_program_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_program_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_program_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_program_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_Tasks));
      }
    }

    [RelationshipSchemaName("ait_program_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_program_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_program_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_program_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_tribe")]
    [RelationshipSchemaName("ait_ait_tribe_ait_program_Tribe")]
    public ait_tribe ait_ait_tribe_ait_program_Tribe
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_ait_tribe_ait_program_Tribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_tribe_ait_program_Tribe));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_ait_tribe_ait_program_Tribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_tribe_ait_program_Tribe));
      }
    }

    [AttributeLogicalName("ait_programmanager")]
    [RelationshipSchemaName("ait_systemuser_ait_program_ProgramManager")]
    public SystemUser ait_systemuser_ait_program_ProgramManager
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_program_ProgramManager), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_program_ProgramManager));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_program_ProgramManager), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_program_ProgramManager));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_program")]
    public BusinessUnit business_unit_ait_program
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_program), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_program_createdby")]
    public SystemUser lk_ait_program_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_program_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_program_createdonbehalfby")]
    public SystemUser lk_ait_program_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_program_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_program_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_program_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_program_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_program_modifiedby")]
    public SystemUser lk_ait_program_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_program_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_program_modifiedonbehalfby")]
    public SystemUser lk_ait_program_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_program_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_program_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_program_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_program_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_program")]
    public Team team_ait_program
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_program), new EntityRole?());
    }

    [AttributeLogicalName("transactioncurrencyid")]
    [RelationshipSchemaName("TransactionCurrency_ait_program")]
    public TransactionCurrency TransactionCurrency_ait_program
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (TransactionCurrency_ait_program));
        this.SetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_ait_program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (TransactionCurrency_ait_program));
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_program")]
    public SystemUser user_ait_program
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_program), new EntityRole?());
    }

    public ait_program(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_programid"] = (object) base.Id;
            break;
          case "ait_programid":
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
