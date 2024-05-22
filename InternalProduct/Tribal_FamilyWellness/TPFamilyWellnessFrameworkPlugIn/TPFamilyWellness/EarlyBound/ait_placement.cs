// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_placement
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_placement")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_placement : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_placement";
    public const int EntityTypeCode = 10662;

    public ait_placement()
      : base(nameof (ait_placement))
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

    [AttributeLogicalName("ait_case")]
    public EntityReference ait_Case
    {
      get => this.GetAttributeValue<EntityReference>("ait_case");
      set
      {
        this.OnPropertyChanging(nameof (ait_Case));
        this.SetAttributeValue("ait_case", (object) value);
        this.OnPropertyChanged(nameof (ait_Case));
      }
    }

    [AttributeLogicalName("ait_casename")]
    public string ait_CaseName => this.GetAttributeValue<string>("ait_casename");

    [AttributeLogicalName("ait_caseplan")]
    public EntityReference ait_caseplan
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_caseplan));
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan));
        this.SetAttributeValue(nameof (ait_caseplan), (object) value);
        this.OnPropertyChanged(nameof (ait_caseplan));
      }
    }

    [AttributeLogicalName("ait_caseplanname")]
    public string ait_caseplanName => this.GetAttributeValue<string>("ait_caseplanname");

    [AttributeLogicalName("ait_childsignatureifover12")]
    public string ait_ChildSignatureifover12
    {
      get => this.GetAttributeValue<string>("ait_childsignatureifover12");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChildSignatureifover12));
        this.SetAttributeValue("ait_childsignatureifover12", (object) value);
        this.OnPropertyChanged(nameof (ait_ChildSignatureifover12));
      }
    }

    [AttributeLogicalName("ait_departmentrepsignature")]
    public string ait_DepartmentRepSignature
    {
      get => this.GetAttributeValue<string>("ait_departmentrepsignature");
      set
      {
        this.OnPropertyChanging(nameof (ait_DepartmentRepSignature));
        this.SetAttributeValue("ait_departmentrepsignature", (object) value);
        this.OnPropertyChanged(nameof (ait_DepartmentRepSignature));
      }
    }

    [AttributeLogicalName("ait_description")]
    public string ait_description
    {
      get => this.GetAttributeValue<string>(nameof (ait_description));
      set
      {
        this.OnPropertyChanging(nameof (ait_description));
        this.SetAttributeValue(nameof (ait_description), (object) value);
        this.OnPropertyChanged(nameof (ait_description));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    public EntityReference ait_FamilyGroup
    {
      get => this.GetAttributeValue<EntityReference>("ait_familygroup");
      set
      {
        this.OnPropertyChanging(nameof (ait_FamilyGroup));
        this.SetAttributeValue("ait_familygroup", (object) value);
        this.OnPropertyChanged(nameof (ait_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_familygroupname")]
    public string ait_FamilyGroupName => this.GetAttributeValue<string>("ait_familygroupname");

    [AttributeLogicalName("ait_incident")]
    public EntityReference ait_Incident
    {
      get => this.GetAttributeValue<EntityReference>("ait_incident");
      set
      {
        this.OnPropertyChanging(nameof (ait_Incident));
        this.SetAttributeValue("ait_incident", (object) value);
        this.OnPropertyChanged(nameof (ait_Incident));
      }
    }

    [AttributeLogicalName("ait_incidentname")]
    public string ait_IncidentName => this.GetAttributeValue<string>("ait_incidentname");

    [AttributeLogicalName("ait_individual")]
    public EntityReference ait_individual
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_individual));
      set
      {
        this.OnPropertyChanging(nameof (ait_individual));
        this.SetAttributeValue(nameof (ait_individual), (object) value);
        this.OnPropertyChanged(nameof (ait_individual));
      }
    }

    [AttributeLogicalName("ait_individualname")]
    public string ait_individualName => this.GetAttributeValue<string>("ait_individualname");

    [AttributeLogicalName("ait_otherfunding")]
    public string ait_OtherFunding
    {
      get => this.GetAttributeValue<string>("ait_otherfunding");
      set
      {
        this.OnPropertyChanging(nameof (ait_OtherFunding));
        this.SetAttributeValue("ait_otherfunding", (object) value);
        this.OnPropertyChanged(nameof (ait_OtherFunding));
      }
    }

    [AttributeLogicalName("ait_parent1signature")]
    public string ait_Parent1Signature
    {
      get => this.GetAttributeValue<string>("ait_parent1signature");
      set
      {
        this.OnPropertyChanging(nameof (ait_Parent1Signature));
        this.SetAttributeValue("ait_parent1signature", (object) value);
        this.OnPropertyChanged(nameof (ait_Parent1Signature));
      }
    }

    [AttributeLogicalName("ait_parent2signature")]
    public string ait_Parent2Signature
    {
      get => this.GetAttributeValue<string>("ait_parent2signature");
      set
      {
        this.OnPropertyChanging(nameof (ait_Parent2Signature));
        this.SetAttributeValue("ait_parent2signature", (object) value);
        this.OnPropertyChanged(nameof (ait_Parent2Signature));
      }
    }

    [AttributeLogicalName("ait_payment")]
    public EntityReference ait_Payment
    {
      get => this.GetAttributeValue<EntityReference>("ait_payment");
      set
      {
        this.OnPropertyChanging(nameof (ait_Payment));
        this.SetAttributeValue("ait_payment", (object) value);
        this.OnPropertyChanged(nameof (ait_Payment));
      }
    }

    [AttributeLogicalName("ait_paymentname")]
    public string ait_PaymentName => this.GetAttributeValue<string>("ait_paymentname");

    [AttributeLogicalName("ait_placement_autoid")]
    public string ait_Placement_AutoID
    {
      get => this.GetAttributeValue<string>("ait_placement_autoid");
      set
      {
        this.OnPropertyChanging(nameof (ait_Placement_AutoID));
        this.SetAttributeValue("ait_placement_autoid", (object) value);
        this.OnPropertyChanged(nameof (ait_Placement_AutoID));
      }
    }

    [AttributeLogicalName("ait_placementenddate")]
    public DateTime? ait_placementenddate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_placementenddate));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementenddate));
        this.SetAttributeValue(nameof (ait_placementenddate), (object) value);
        this.OnPropertyChanged(nameof (ait_placementenddate));
      }
    }

    [AttributeLogicalName("ait_placementfundingsource")]
    public OptionSetValue ait_PlacementFundingSource
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_placementfundingsource");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementFundingSource));
        this.SetAttributeValue("ait_placementfundingsource", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementFundingSource));
      }
    }

    [AttributeLogicalName("ait_placementfundingsourcename")]
    public object ait_placementfundingsourceName
    {
      get => this.GetAttributeValue<object>("ait_placementfundingsourcename");
    }

    [AttributeLogicalName("ait_placementid")]
    public Guid? ait_placementId
    {
      get => this.GetAttributeValue<Guid?>("ait_placementid");
      set
      {
        this.OnPropertyChanging(nameof (ait_placementId));
        this.SetAttributeValue("ait_placementid", (object) value);
        this.OnPropertyChanged(nameof (ait_placementId));
      }
    }

    [AttributeLogicalName("ait_placementlocation")]
    public EntityReference ait_placementlocation
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_placementlocation));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation));
        this.SetAttributeValue(nameof (ait_placementlocation), (object) value);
        this.OnPropertyChanged(nameof (ait_placementlocation));
      }
    }

    [AttributeLogicalName("ait_placementlocationname")]
    public string ait_placementlocationName
    {
      get => this.GetAttributeValue<string>("ait_placementlocationname");
    }

    [AttributeLogicalName("ait_placementmonthlyamount")]
    public Money ait_PlacementMonthlyAmount
    {
      get => this.GetAttributeValue<Money>("ait_placementmonthlyamount");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementMonthlyAmount));
        this.SetAttributeValue("ait_placementmonthlyamount", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementMonthlyAmount));
      }
    }

    [AttributeLogicalName("ait_placementmonthlyamount_base")]
    public Money ait_placementmonthlyamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_placementmonthlyamount_base");
    }

    [AttributeLogicalName("ait_placementname")]
    public string ait_PlacementName
    {
      get => this.GetAttributeValue<string>("ait_placementname");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementName));
        this.SetAttributeValue("ait_placementname", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementName));
      }
    }

    [AttributeLogicalName("ait_placementstartdate")]
    public DateTime? ait_placementstartdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_placementstartdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_placementstartdate));
        this.SetAttributeValue(nameof (ait_placementstartdate), (object) value);
        this.OnPropertyChanged(nameof (ait_placementstartdate));
      }
    }

    [AttributeLogicalName("ait_placementstatus")]
    public OptionSetValue ait_PlacementStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_placementstatus");
      set
      {
        this.OnPropertyChanging(nameof (ait_PlacementStatus));
        this.SetAttributeValue("ait_placementstatus", (object) value);
        this.OnPropertyChanged(nameof (ait_PlacementStatus));
      }
    }

    [AttributeLogicalName("ait_placementstatusname")]
    public object ait_placementstatusName
    {
      get => this.GetAttributeValue<object>("ait_placementstatusname");
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

    [AttributeLogicalName("ait_programname")]
    public string ait_ProgramName => this.GetAttributeValue<string>("ait_programname");

    [AttributeLogicalName("ait_totalplaced")]
    public int? ait_TotalPlaced => this.GetAttributeValue<int?>("ait_totalplaced");

    [AttributeLogicalName("ait_totalplaced_date")]
    public DateTime? ait_TotalPlaced_Date
    {
      get => this.GetAttributeValue<DateTime?>("ait_totalplaced_date");
    }

    [AttributeLogicalName("ait_totalplaced_state")]
    public int? ait_TotalPlaced_State => this.GetAttributeValue<int?>("ait_totalplaced_state");

    [AttributeLogicalName("createdby")]
    public EntityReference CreatedBy => this.GetAttributeValue<EntityReference>("createdby");

    [AttributeLogicalName("createdbyname")]
    public string CreatedByName => this.GetAttributeValue<string>("createdbyname");

    [AttributeLogicalName("createdbyyominame")]
    public string CreatedByYomiName => this.GetAttributeValue<string>("createdbyyominame");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("createdonbehalfby")]
    public EntityReference CreatedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("createdonbehalfby");
    }

    [AttributeLogicalName("createdonbehalfbyname")]
    public string CreatedOnBehalfByName => this.GetAttributeValue<string>("createdonbehalfbyname");

    [AttributeLogicalName("createdonbehalfbyyominame")]
    public string CreatedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("createdonbehalfbyyominame");
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

    [AttributeLogicalName("modifiedbyname")]
    public string ModifiedByName => this.GetAttributeValue<string>("modifiedbyname");

    [AttributeLogicalName("modifiedbyyominame")]
    public string ModifiedByYomiName => this.GetAttributeValue<string>("modifiedbyyominame");

    [AttributeLogicalName("modifiedon")]
    public DateTime? ModifiedOn => this.GetAttributeValue<DateTime?>("modifiedon");

    [AttributeLogicalName("modifiedonbehalfby")]
    public EntityReference ModifiedOnBehalfBy
    {
      get => this.GetAttributeValue<EntityReference>("modifiedonbehalfby");
    }

    [AttributeLogicalName("modifiedonbehalfbyname")]
    public string ModifiedOnBehalfByName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyname");
    }

    [AttributeLogicalName("modifiedonbehalfbyyominame")]
    public string ModifiedOnBehalfByYomiName
    {
      get => this.GetAttributeValue<string>("modifiedonbehalfbyyominame");
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

    [AttributeLogicalName("owneridname")]
    public string OwnerIdName => this.GetAttributeValue<string>("owneridname");

    [AttributeLogicalName("owneridtype")]
    public string OwnerIdType
    {
      get => this.GetAttributeValue<string>("owneridtype");
      set
      {
        this.OnPropertyChanging(nameof (OwnerIdType));
        this.SetAttributeValue("owneridtype", (object) value);
        this.OnPropertyChanged(nameof (OwnerIdType));
      }
    }

    [AttributeLogicalName("owneridyominame")]
    public string OwnerIdYomiName => this.GetAttributeValue<string>("owneridyominame");

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
    public Ait_placementState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_placementState?((Ait_placementState) Enum.ToObject(typeof (Ait_placementState), attributeValue.Value)) : new Ait_placementState?();
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

    [AttributeLogicalName("statecodename")]
    public object statecodeName => this.GetAttributeValue<object>("statecodename");

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

    [AttributeLogicalName("statuscodename")]
    public object statuscodeName => this.GetAttributeValue<object>("statuscodename");

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

    [AttributeLogicalName("transactioncurrencyidname")]
    public string TransactionCurrencyIdName
    {
      get => this.GetAttributeValue<string>("transactioncurrencyidname");
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

    [RelationshipSchemaName("ait_ait_placement_ait_planactivity_Placement")]
    public IEnumerable<ait_planactivity> ait_ait_placement_ait_planactivity_Placement
    {
      get
      {
        return this.GetRelatedEntities<ait_planactivity>(nameof (ait_ait_placement_ait_planactivity_Placement), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_placement_ait_planactivity_Placement));
        this.SetRelatedEntities<ait_planactivity>(nameof (ait_ait_placement_ait_planactivity_Placement), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_placement_ait_planactivity_Placement));
      }
    }

    [RelationshipSchemaName("ait_placement_Contact_Contact")]
    public IEnumerable<Contact> ait_placement_Contact_Contact
    {
      get
      {
        return this.GetRelatedEntities<Contact>(nameof (ait_placement_Contact_Contact), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_Contact_Contact));
        this.SetRelatedEntities<Contact>(nameof (ait_placement_Contact_Contact), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_Contact_Contact));
      }
    }

    [AttributeLogicalName("ait_case")]
    [RelationshipSchemaName("ait_ait_case_ait_placement_Case")]
    public ait_case ait_ait_case_ait_placement_Case
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_placement_Case), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_case_ait_placement_Case));
        this.SetRelatedEntity<ait_case>(nameof (ait_ait_case_ait_placement_Case), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_case_ait_placement_Case));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_ait_caseplan_ait_placement_Plan")]
    public TPFamilyWellness.EarlyBound.ait_caseplan ait_ait_caseplan_ait_placement_Plan
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_caseplan>(nameof (ait_ait_caseplan_ait_placement_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_caseplan_ait_placement_Plan));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_caseplan>(nameof (ait_ait_caseplan_ait_placement_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_caseplan_ait_placement_Plan));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_ait_familygroup_ait_placement_FamilyGroup")]
    public ait_familygroup ait_ait_familygroup_ait_placement_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_placement_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_familygroup_ait_placement_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_ait_familygroup_ait_placement_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_familygroup_ait_placement_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_payment")]
    [RelationshipSchemaName("ait_ait_payment_ait_placement_Payment")]
    public ait_payment ait_ait_payment_ait_placement_Payment
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_ait_payment_ait_placement_Payment), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_payment_ait_placement_Payment));
        this.SetRelatedEntity<ait_payment>(nameof (ait_ait_payment_ait_placement_Payment), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_payment_ait_placement_Payment));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_ait_program_ait_placement_Program")]
    public ait_program ait_ait_program_ait_placement_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_placement_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_ait_program_ait_placement_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_ait_program_ait_placement_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_ait_program_ait_placement_Program));
      }
    }

    [AttributeLogicalName("ait_individual")]
    [RelationshipSchemaName("ait_clientprofile_ait_placement_PlacedPerson")]
    public ait_clientprofile ait_clientprofile_ait_placement_PlacedPerson
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_placement_PlacedPerson), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_placement_PlacedPerson));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_placement_PlacedPerson), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_placement_PlacedPerson));
      }
    }

    [AttributeLogicalName("ait_placementlocation")]
    [RelationshipSchemaName("ait_placement_placementlocation_ait_place")]
    public TPFamilyWellness.EarlyBound.ait_placementlocation ait_placement_placementlocation_ait_place
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_placementlocation>(nameof (ait_placement_placementlocation_ait_place), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_placementlocation_ait_place));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_placementlocation>(nameof (ait_placement_placementlocation_ait_place), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_placementlocation_ait_place));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_placement")]
    public BusinessUnit business_unit_ait_placement
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_placement), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_placement_createdby")]
    public SystemUser lk_ait_placement_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placement_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_placement_createdonbehalfby")]
    public SystemUser lk_ait_placement_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placement_createdonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_placement_modifiedby")]
    public SystemUser lk_ait_placement_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placement_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_placement_modifiedonbehalfby")]
    public SystemUser lk_ait_placement_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_placement_modifiedonbehalfby), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_placement")]
    public Team team_ait_placement
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_placement), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_placement")]
    public SystemUser user_ait_placement
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_placement), new EntityRole?());
    }
  }
}
