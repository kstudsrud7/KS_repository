// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.Goal
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("goal")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.20")]
  public class Goal : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "goal";
    public const int EntityTypeCode = 9600;

    public Goal()
      : base("goal")
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

    [AttributeLogicalName("actualdecimal")]
    public Decimal? ActualDecimal
    {
      get => this.GetAttributeValue<Decimal?>("actualdecimal");
      set
      {
        this.OnPropertyChanging(nameof (ActualDecimal));
        this.SetAttributeValue("actualdecimal", (object) value);
        this.OnPropertyChanged(nameof (ActualDecimal));
      }
    }

    [AttributeLogicalName("actualinteger")]
    public int? ActualInteger
    {
      get => this.GetAttributeValue<int?>("actualinteger");
      set
      {
        this.OnPropertyChanging(nameof (ActualInteger));
        this.SetAttributeValue("actualinteger", (object) value);
        this.OnPropertyChanged(nameof (ActualInteger));
      }
    }

    [AttributeLogicalName("actualmoney")]
    public Money ActualMoney
    {
      get => this.GetAttributeValue<Money>("actualmoney");
      set
      {
        this.OnPropertyChanging(nameof (ActualMoney));
        this.SetAttributeValue("actualmoney", (object) value);
        this.OnPropertyChanged(nameof (ActualMoney));
      }
    }

    [AttributeLogicalName("actualmoney_base")]
    public Money ActualMoney_Base => this.GetAttributeValue<Money>("actualmoney_base");

    [AttributeLogicalName("actualstring")]
    public string ActualString => this.GetAttributeValue<string>("actualstring");

    [AttributeLogicalName("amountdatatype")]
    public OptionSetValue AmountDataType
    {
      get => this.GetAttributeValue<OptionSetValue>("amountdatatype");
      set
      {
        this.OnPropertyChanging(nameof (AmountDataType));
        this.SetAttributeValue("amountdatatype", (object) value);
        this.OnPropertyChanged(nameof (AmountDataType));
      }
    }

    [AttributeLogicalName("computedtargetasoftodaydecimal")]
    public Decimal? ComputedTargetAsOfTodayDecimal
    {
      get => this.GetAttributeValue<Decimal?>("computedtargetasoftodaydecimal");
    }

    [AttributeLogicalName("computedtargetasoftodayinteger")]
    public int? ComputedTargetAsOfTodayInteger
    {
      get => this.GetAttributeValue<int?>("computedtargetasoftodayinteger");
    }

    [AttributeLogicalName("computedtargetasoftodaymoney")]
    public Money ComputedTargetAsOfTodayMoney
    {
      get => this.GetAttributeValue<Money>("computedtargetasoftodaymoney");
    }

    [AttributeLogicalName("computedtargetasoftodaymoney_base")]
    public Money ComputedTargetAsOfTodayMoney_Base
    {
      get => this.GetAttributeValue<Money>("computedtargetasoftodaymoney_base");
    }

    [AttributeLogicalName("computedtargetasoftodaypercentageachieved")]
    public Decimal? ComputedTargetAsOfTodayPercentageAchieved
    {
      get => this.GetAttributeValue<Decimal?>("computedtargetasoftodaypercentageachieved");
    }

    [AttributeLogicalName("consideronlygoalownersrecords")]
    public bool? ConsiderOnlyGoalOwnersRecords
    {
      get => this.GetAttributeValue<bool?>("consideronlygoalownersrecords");
      set
      {
        this.OnPropertyChanging(nameof (ConsiderOnlyGoalOwnersRecords));
        this.SetAttributeValue("consideronlygoalownersrecords", (object) value);
        this.OnPropertyChanged(nameof (ConsiderOnlyGoalOwnersRecords));
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

    [AttributeLogicalName("customrollupfielddecimal")]
    public Decimal? CustomRollupFieldDecimal
    {
      get => this.GetAttributeValue<Decimal?>("customrollupfielddecimal");
      set
      {
        this.OnPropertyChanging(nameof (CustomRollupFieldDecimal));
        this.SetAttributeValue("customrollupfielddecimal", (object) value);
        this.OnPropertyChanged(nameof (CustomRollupFieldDecimal));
      }
    }

    [AttributeLogicalName("customrollupfieldinteger")]
    public int? CustomRollupFieldInteger
    {
      get => this.GetAttributeValue<int?>("customrollupfieldinteger");
      set
      {
        this.OnPropertyChanging(nameof (CustomRollupFieldInteger));
        this.SetAttributeValue("customrollupfieldinteger", (object) value);
        this.OnPropertyChanged(nameof (CustomRollupFieldInteger));
      }
    }

    [AttributeLogicalName("customrollupfieldmoney")]
    public Money CustomRollupFieldMoney
    {
      get => this.GetAttributeValue<Money>("customrollupfieldmoney");
      set
      {
        this.OnPropertyChanging(nameof (CustomRollupFieldMoney));
        this.SetAttributeValue("customrollupfieldmoney", (object) value);
        this.OnPropertyChanged(nameof (CustomRollupFieldMoney));
      }
    }

    [AttributeLogicalName("customrollupfieldmoney_base")]
    public Money CustomRollupFieldMoney_Base
    {
      get => this.GetAttributeValue<Money>("customrollupfieldmoney_base");
    }

    [AttributeLogicalName("customrollupfieldstring")]
    public string CustomRollupFieldString
    {
      get => this.GetAttributeValue<string>("customrollupfieldstring");
    }

    [AttributeLogicalName("depth")]
    public int? Depth => this.GetAttributeValue<int?>("depth");

    [AttributeLogicalName("entityimage")]
    public byte[] EntityImage
    {
      get => this.GetAttributeValue<byte[]>("entityimage");
      set
      {
        this.OnPropertyChanging(nameof (EntityImage));
        this.SetAttributeValue("entityimage", (object) value);
        this.OnPropertyChanged(nameof (EntityImage));
      }
    }

    [AttributeLogicalName("entityimage_timestamp")]
    public long? EntityImage_Timestamp => this.GetAttributeValue<long?>("entityimage_timestamp");

    [AttributeLogicalName("entityimage_url")]
    public string EntityImage_URL => this.GetAttributeValue<string>("entityimage_url");

    [AttributeLogicalName("entityimageid")]
    public Guid? EntityImageId => this.GetAttributeValue<Guid?>("entityimageid");

    [AttributeLogicalName("exchangerate")]
    public Decimal? ExchangeRate => this.GetAttributeValue<Decimal?>("exchangerate");

    [AttributeLogicalName("fiscalperiod")]
    public OptionSetValue FiscalPeriod
    {
      get => this.GetAttributeValue<OptionSetValue>("fiscalperiod");
      set
      {
        this.OnPropertyChanging(nameof (FiscalPeriod));
        this.SetAttributeValue("fiscalperiod", (object) value);
        this.OnPropertyChanged(nameof (FiscalPeriod));
      }
    }

    [AttributeLogicalName("fiscalyear")]
    public OptionSetValue FiscalYear
    {
      get => this.GetAttributeValue<OptionSetValue>("fiscalyear");
      set
      {
        this.OnPropertyChanging(nameof (FiscalYear));
        this.SetAttributeValue("fiscalyear", (object) value);
        this.OnPropertyChanged(nameof (FiscalYear));
      }
    }

    [AttributeLogicalName("goalenddate")]
    public DateTime? GoalEndDate
    {
      get => this.GetAttributeValue<DateTime?>("goalenddate");
      set
      {
        this.OnPropertyChanging(nameof (GoalEndDate));
        this.SetAttributeValue("goalenddate", (object) value);
        this.OnPropertyChanged(nameof (GoalEndDate));
      }
    }

    [AttributeLogicalName("goalid")]
    public Guid? GoalId
    {
      get => this.GetAttributeValue<Guid?>("goalid");
      set
      {
        this.OnPropertyChanging(nameof (GoalId));
        this.SetAttributeValue("goalid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (GoalId));
      }
    }

    [AttributeLogicalName("goalid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.GoalId = new Guid?(value);
    }

    [AttributeLogicalName("goalownerid")]
    public EntityReference GoalOwnerId
    {
      get => this.GetAttributeValue<EntityReference>("goalownerid");
      set
      {
        this.OnPropertyChanging(nameof (GoalOwnerId));
        this.SetAttributeValue("goalownerid", (object) value);
        this.OnPropertyChanged(nameof (GoalOwnerId));
      }
    }

    [AttributeLogicalName("goalstartdate")]
    public DateTime? GoalStartDate
    {
      get => this.GetAttributeValue<DateTime?>("goalstartdate");
      set
      {
        this.OnPropertyChanging(nameof (GoalStartDate));
        this.SetAttributeValue("goalstartdate", (object) value);
        this.OnPropertyChanged(nameof (GoalStartDate));
      }
    }

    [AttributeLogicalName("goalwitherrorid")]
    public EntityReference GoalWithErrorId
    {
      get => this.GetAttributeValue<EntityReference>("goalwitherrorid");
      set
      {
        this.OnPropertyChanging(nameof (GoalWithErrorId));
        this.SetAttributeValue("goalwitherrorid", (object) value);
        this.OnPropertyChanged(nameof (GoalWithErrorId));
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

    [AttributeLogicalName("inprogressdecimal")]
    public Decimal? InProgressDecimal
    {
      get => this.GetAttributeValue<Decimal?>("inprogressdecimal");
      set
      {
        this.OnPropertyChanging(nameof (InProgressDecimal));
        this.SetAttributeValue("inprogressdecimal", (object) value);
        this.OnPropertyChanged(nameof (InProgressDecimal));
      }
    }

    [AttributeLogicalName("inprogressinteger")]
    public int? InProgressInteger
    {
      get => this.GetAttributeValue<int?>("inprogressinteger");
      set
      {
        this.OnPropertyChanging(nameof (InProgressInteger));
        this.SetAttributeValue("inprogressinteger", (object) value);
        this.OnPropertyChanged(nameof (InProgressInteger));
      }
    }

    [AttributeLogicalName("inprogressmoney")]
    public Money InProgressMoney
    {
      get => this.GetAttributeValue<Money>("inprogressmoney");
      set
      {
        this.OnPropertyChanging(nameof (InProgressMoney));
        this.SetAttributeValue("inprogressmoney", (object) value);
        this.OnPropertyChanged(nameof (InProgressMoney));
      }
    }

    [AttributeLogicalName("inprogressmoney_base")]
    public Money InProgressMoney_Base => this.GetAttributeValue<Money>("inprogressmoney_base");

    [AttributeLogicalName("inprogressstring")]
    public string InProgressString => this.GetAttributeValue<string>("inprogressstring");

    [AttributeLogicalName("isamount")]
    public bool? IsAmount
    {
      get => this.GetAttributeValue<bool?>("isamount");
      set
      {
        this.OnPropertyChanging(nameof (IsAmount));
        this.SetAttributeValue("isamount", (object) value);
        this.OnPropertyChanged(nameof (IsAmount));
      }
    }

    [AttributeLogicalName("isfiscalperiodgoal")]
    public bool? IsFiscalPeriodGoal
    {
      get => this.GetAttributeValue<bool?>("isfiscalperiodgoal");
      set
      {
        this.OnPropertyChanging(nameof (IsFiscalPeriodGoal));
        this.SetAttributeValue("isfiscalperiodgoal", (object) value);
        this.OnPropertyChanged(nameof (IsFiscalPeriodGoal));
      }
    }

    [AttributeLogicalName("isoverridden")]
    public bool? IsOverridden
    {
      get => this.GetAttributeValue<bool?>("isoverridden");
      set
      {
        this.OnPropertyChanging(nameof (IsOverridden));
        this.SetAttributeValue("isoverridden", (object) value);
        this.OnPropertyChanged(nameof (IsOverridden));
      }
    }

    [AttributeLogicalName("isoverride")]
    public bool? IsOverride
    {
      get => this.GetAttributeValue<bool?>("isoverride");
      set
      {
        this.OnPropertyChanging(nameof (IsOverride));
        this.SetAttributeValue("isoverride", (object) value);
        this.OnPropertyChanged(nameof (IsOverride));
      }
    }

    [AttributeLogicalName("lastrolledupdate")]
    public DateTime? LastRolledupDate
    {
      get => this.GetAttributeValue<DateTime?>("lastrolledupdate");
      set
      {
        this.OnPropertyChanging(nameof (LastRolledupDate));
        this.SetAttributeValue("lastrolledupdate", (object) value);
        this.OnPropertyChanged(nameof (LastRolledupDate));
      }
    }

    [AttributeLogicalName("metricid")]
    public EntityReference MetricId
    {
      get => this.GetAttributeValue<EntityReference>("metricid");
      set
      {
        this.OnPropertyChanging(nameof (MetricId));
        this.SetAttributeValue("metricid", (object) value);
        this.OnPropertyChanged(nameof (MetricId));
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

    [AttributeLogicalName("parentgoalid")]
    public EntityReference ParentGoalId
    {
      get => this.GetAttributeValue<EntityReference>("parentgoalid");
      set
      {
        this.OnPropertyChanging(nameof (ParentGoalId));
        this.SetAttributeValue("parentgoalid", (object) value);
        this.OnPropertyChanged(nameof (ParentGoalId));
      }
    }

    [AttributeLogicalName("percentage")]
    public Decimal? Percentage
    {
      get => this.GetAttributeValue<Decimal?>("percentage");
      set
      {
        this.OnPropertyChanging(nameof (Percentage));
        this.SetAttributeValue("percentage", (object) value);
        this.OnPropertyChanged(nameof (Percentage));
      }
    }

    [AttributeLogicalName("rolluperrorcode")]
    public int? RollupErrorCode
    {
      get => this.GetAttributeValue<int?>("rolluperrorcode");
      set
      {
        this.OnPropertyChanging(nameof (RollupErrorCode));
        this.SetAttributeValue("rolluperrorcode", (object) value);
        this.OnPropertyChanged(nameof (RollupErrorCode));
      }
    }

    [AttributeLogicalName("rolluponlyfromchildgoals")]
    public bool? RollupOnlyFromChildGoals
    {
      get => this.GetAttributeValue<bool?>("rolluponlyfromchildgoals");
      set
      {
        this.OnPropertyChanging(nameof (RollupOnlyFromChildGoals));
        this.SetAttributeValue("rolluponlyfromchildgoals", (object) value);
        this.OnPropertyChanged(nameof (RollupOnlyFromChildGoals));
      }
    }

    [AttributeLogicalName("rollupqueryactualdecimalid")]
    public EntityReference RollUpQueryActualDecimalId
    {
      get => this.GetAttributeValue<EntityReference>("rollupqueryactualdecimalid");
      set
      {
        this.OnPropertyChanging(nameof (RollUpQueryActualDecimalId));
        this.SetAttributeValue("rollupqueryactualdecimalid", (object) value);
        this.OnPropertyChanged(nameof (RollUpQueryActualDecimalId));
      }
    }

    [AttributeLogicalName("rollupqueryactualintegerid")]
    public EntityReference RollupQueryActualIntegerId
    {
      get => this.GetAttributeValue<EntityReference>("rollupqueryactualintegerid");
      set
      {
        this.OnPropertyChanging(nameof (RollupQueryActualIntegerId));
        this.SetAttributeValue("rollupqueryactualintegerid", (object) value);
        this.OnPropertyChanged(nameof (RollupQueryActualIntegerId));
      }
    }

    [AttributeLogicalName("rollupqueryactualmoneyid")]
    public EntityReference RollUpQueryActualMoneyId
    {
      get => this.GetAttributeValue<EntityReference>("rollupqueryactualmoneyid");
      set
      {
        this.OnPropertyChanging(nameof (RollUpQueryActualMoneyId));
        this.SetAttributeValue("rollupqueryactualmoneyid", (object) value);
        this.OnPropertyChanged(nameof (RollUpQueryActualMoneyId));
      }
    }

    [AttributeLogicalName("rollupquerycustomdecimalid")]
    public EntityReference RollUpQueryCustomDecimalId
    {
      get => this.GetAttributeValue<EntityReference>("rollupquerycustomdecimalid");
      set
      {
        this.OnPropertyChanging(nameof (RollUpQueryCustomDecimalId));
        this.SetAttributeValue("rollupquerycustomdecimalid", (object) value);
        this.OnPropertyChanged(nameof (RollUpQueryCustomDecimalId));
      }
    }

    [AttributeLogicalName("rollupquerycustomintegerid")]
    public EntityReference RollUpQueryCustomIntegerId
    {
      get => this.GetAttributeValue<EntityReference>("rollupquerycustomintegerid");
      set
      {
        this.OnPropertyChanging(nameof (RollUpQueryCustomIntegerId));
        this.SetAttributeValue("rollupquerycustomintegerid", (object) value);
        this.OnPropertyChanged(nameof (RollUpQueryCustomIntegerId));
      }
    }

    [AttributeLogicalName("rollupquerycustommoneyid")]
    public EntityReference RollUpQueryCustomMoneyId
    {
      get => this.GetAttributeValue<EntityReference>("rollupquerycustommoneyid");
      set
      {
        this.OnPropertyChanging(nameof (RollUpQueryCustomMoneyId));
        this.SetAttributeValue("rollupquerycustommoneyid", (object) value);
        this.OnPropertyChanged(nameof (RollUpQueryCustomMoneyId));
      }
    }

    [AttributeLogicalName("rollupqueryinprogressdecimalid")]
    public EntityReference RollUpQueryInprogressDecimalId
    {
      get => this.GetAttributeValue<EntityReference>("rollupqueryinprogressdecimalid");
      set
      {
        this.OnPropertyChanging(nameof (RollUpQueryInprogressDecimalId));
        this.SetAttributeValue("rollupqueryinprogressdecimalid", (object) value);
        this.OnPropertyChanged(nameof (RollUpQueryInprogressDecimalId));
      }
    }

    [AttributeLogicalName("rollupqueryinprogressintegerid")]
    public EntityReference RollUpQueryInprogressIntegerId
    {
      get => this.GetAttributeValue<EntityReference>("rollupqueryinprogressintegerid");
      set
      {
        this.OnPropertyChanging(nameof (RollUpQueryInprogressIntegerId));
        this.SetAttributeValue("rollupqueryinprogressintegerid", (object) value);
        this.OnPropertyChanged(nameof (RollUpQueryInprogressIntegerId));
      }
    }

    [AttributeLogicalName("rollupqueryinprogressmoneyid")]
    public EntityReference RollUpQueryInprogressMoneyId
    {
      get => this.GetAttributeValue<EntityReference>("rollupqueryinprogressmoneyid");
      set
      {
        this.OnPropertyChanging(nameof (RollUpQueryInprogressMoneyId));
        this.SetAttributeValue("rollupqueryinprogressmoneyid", (object) value);
        this.OnPropertyChanged(nameof (RollUpQueryInprogressMoneyId));
      }
    }

    [AttributeLogicalName("statecode")]
    public GoalState? StateCode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>("statecode");
        return attributeValue != null ? new GoalState?((GoalState) Enum.ToObject(typeof (GoalState), attributeValue.Value)) : new GoalState?();
      }
      set
      {
        this.OnPropertyChanging(nameof (StateCode));
        if (!value.HasValue)
          this.SetAttributeValue("statecode", (object) null);
        else
          this.SetAttributeValue("statecode", (object) new OptionSetValue((int) value.Value));
        this.OnPropertyChanged(nameof (StateCode));
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

    [AttributeLogicalName("stretchtargetdecimal")]
    public Decimal? StretchTargetDecimal
    {
      get => this.GetAttributeValue<Decimal?>("stretchtargetdecimal");
      set
      {
        this.OnPropertyChanging(nameof (StretchTargetDecimal));
        this.SetAttributeValue("stretchtargetdecimal", (object) value);
        this.OnPropertyChanged(nameof (StretchTargetDecimal));
      }
    }

    [AttributeLogicalName("stretchtargetinteger")]
    public int? StretchTargetInteger
    {
      get => this.GetAttributeValue<int?>("stretchtargetinteger");
      set
      {
        this.OnPropertyChanging(nameof (StretchTargetInteger));
        this.SetAttributeValue("stretchtargetinteger", (object) value);
        this.OnPropertyChanged(nameof (StretchTargetInteger));
      }
    }

    [AttributeLogicalName("stretchtargetmoney")]
    public Money StretchTargetMoney
    {
      get => this.GetAttributeValue<Money>("stretchtargetmoney");
      set
      {
        this.OnPropertyChanging(nameof (StretchTargetMoney));
        this.SetAttributeValue("stretchtargetmoney", (object) value);
        this.OnPropertyChanged(nameof (StretchTargetMoney));
      }
    }

    [AttributeLogicalName("stretchtargetmoney_base")]
    public Money StretchTargetMoney_Base
    {
      get => this.GetAttributeValue<Money>("stretchtargetmoney_base");
    }

    [AttributeLogicalName("stretchtargetstring")]
    public string StretchTargetString => this.GetAttributeValue<string>("stretchtargetstring");

    [AttributeLogicalName("targetdecimal")]
    public Decimal? TargetDecimal
    {
      get => this.GetAttributeValue<Decimal?>("targetdecimal");
      set
      {
        this.OnPropertyChanging(nameof (TargetDecimal));
        this.SetAttributeValue("targetdecimal", (object) value);
        this.OnPropertyChanged(nameof (TargetDecimal));
      }
    }

    [AttributeLogicalName("targetinteger")]
    public int? TargetInteger
    {
      get => this.GetAttributeValue<int?>("targetinteger");
      set
      {
        this.OnPropertyChanging(nameof (TargetInteger));
        this.SetAttributeValue("targetinteger", (object) value);
        this.OnPropertyChanged(nameof (TargetInteger));
      }
    }

    [AttributeLogicalName("targetmoney")]
    public Money TargetMoney
    {
      get => this.GetAttributeValue<Money>("targetmoney");
      set
      {
        this.OnPropertyChanging(nameof (TargetMoney));
        this.SetAttributeValue("targetmoney", (object) value);
        this.OnPropertyChanged(nameof (TargetMoney));
      }
    }

    [AttributeLogicalName("targetmoney_base")]
    public Money TargetMoney_Base => this.GetAttributeValue<Money>("targetmoney_base");

    [AttributeLogicalName("targetstring")]
    public string TargetString => this.GetAttributeValue<string>("targetstring");

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

    [AttributeLogicalName("title")]
    public string Title
    {
      get => this.GetAttributeValue<string>("title");
      set
      {
        this.OnPropertyChanging(nameof (Title));
        this.SetAttributeValue("title", (object) value);
        this.OnPropertyChanged(nameof (Title));
      }
    }

    [AttributeLogicalName("transactioncurrencyid")]
    public EntityReference TransactionCurrencyId
    {
      get => this.GetAttributeValue<EntityReference>("transactioncurrencyid");
    }

    [AttributeLogicalName("treeid")]
    public Guid? TreeId => this.GetAttributeValue<Guid?>("treeid");

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

    [RelationshipSchemaName("goal_connections1")]
    public IEnumerable<Connection> goal_connections1
    {
      get => this.GetRelatedEntities<Connection>(nameof (goal_connections1), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (goal_connections1));
        this.SetRelatedEntities<Connection>(nameof (goal_connections1), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_connections1));
      }
    }

    [RelationshipSchemaName("goal_connections2")]
    public IEnumerable<Connection> goal_connections2
    {
      get => this.GetRelatedEntities<Connection>(nameof (goal_connections2), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (goal_connections2));
        this.SetRelatedEntities<Connection>(nameof (goal_connections2), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_connections2));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Goal> Referencedgoal_parent_goal
    {
      get => this.GetRelatedEntities<Goal>("goal_parent_goal", new EntityRole?((EntityRole) 1));
      set
      {
        this.OnPropertyChanging(nameof (Referencedgoal_parent_goal));
        this.SetRelatedEntities<Goal>("goal_parent_goal", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedgoal_parent_goal));
      }
    }

    [RelationshipSchemaName]
    public IEnumerable<Goal> ReferencedGoal_RollupError_Goal
    {
      get
      {
        return this.GetRelatedEntities<Goal>("Goal_RollupError_Goal", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (ReferencedGoal_RollupError_Goal));
        this.SetRelatedEntities<Goal>("Goal_RollupError_Goal", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (ReferencedGoal_RollupError_Goal));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_goal")]
    public BusinessUnit business_unit_goal
    {
      get => this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_goal), new EntityRole?());
    }

    [AttributeLogicalName("parentgoalid")]
    [RelationshipSchemaName]
    public Goal Referencinggoal_parent_goal
    {
      get => this.GetRelatedEntity<Goal>("goal_parent_goal", new EntityRole?((EntityRole) 0));
      set
      {
        this.OnPropertyChanging(nameof (Referencinggoal_parent_goal));
        this.SetRelatedEntity<Goal>("goal_parent_goal", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencinggoal_parent_goal));
      }
    }

    [AttributeLogicalName("goalwitherrorid")]
    [RelationshipSchemaName]
    public Goal ReferencingGoal_RollupError_Goal
    {
      get => this.GetRelatedEntity<Goal>("Goal_RollupError_Goal", new EntityRole?((EntityRole) 0));
      set
      {
        this.OnPropertyChanging(nameof (ReferencingGoal_RollupError_Goal));
        this.SetRelatedEntity<Goal>("Goal_RollupError_Goal", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (ReferencingGoal_RollupError_Goal));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_goal_createdby")]
    public SystemUser lk_goal_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_goal_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_goal_createdonbehalfby")]
    public SystemUser lk_goal_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_goal_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_goal_modifiedby")]
    public SystemUser lk_goal_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_goal_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_goal_modifiedonbehalfby")]
    public SystemUser lk_goal_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_goal_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_goal")]
    public SystemUser user_goal
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_goal), new EntityRole?());
    }

    [AttributeLogicalName("goalownerid")]
    [RelationshipSchemaName("user_goal_goalowner")]
    public SystemUser user_goal_goalowner
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_goal_goalowner), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (user_goal_goalowner));
        this.SetRelatedEntity<SystemUser>(nameof (user_goal_goalowner), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (user_goal_goalowner));
      }
    }
  }
}
