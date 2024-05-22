// Decompiled with JetBrains decompiler
// Type: TPFamilyWellness.EarlyBound.ait_servicerequest
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_servicerequest")]
  [GeneratedCode("CrmSvcUtil", "9.0.0.9154")]
  public class ait_servicerequest : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_servicerequest";
    public const int EntityTypeCode = 10398;

    public ait_servicerequest()
      : base(nameof (ait_servicerequest))
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

    [AttributeLogicalName("ait_approvaldate")]
    public DateTime? ait_approvaldate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_approvaldate));
      set
      {
        this.OnPropertyChanging(nameof (ait_approvaldate));
        this.SetAttributeValue(nameof (ait_approvaldate), (object) value);
        this.OnPropertyChanged(nameof (ait_approvaldate));
      }
    }

    [AttributeLogicalName("ait_approvalneeded")]
    public bool? ait_ApprovalNeeded
    {
      get => this.GetAttributeValue<bool?>("ait_approvalneeded");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApprovalNeeded));
        this.SetAttributeValue("ait_approvalneeded", (object) value);
        this.OnPropertyChanged(nameof (ait_ApprovalNeeded));
      }
    }

    [AttributeLogicalName("ait_approvalstatus")]
    public OptionSetValue ait_approvalstatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_approvalstatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_approvalstatus));
        this.SetAttributeValue(nameof (ait_approvalstatus), (object) value);
        this.OnPropertyChanged(nameof (ait_approvalstatus));
      }
    }

    [AttributeLogicalName("ait_approver")]
    public EntityReference ait_approver
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_approver));
      set
      {
        this.OnPropertyChanging(nameof (ait_approver));
        this.SetAttributeValue(nameof (ait_approver), (object) value);
        this.OnPropertyChanged(nameof (ait_approver));
      }
    }

    [AttributeLogicalName("ait_approvernotes")]
    public string ait_ApproverNotes
    {
      get => this.GetAttributeValue<string>("ait_approvernotes");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApproverNotes));
        this.SetAttributeValue("ait_approvernotes", (object) value);
        this.OnPropertyChanged(nameof (ait_ApproverNotes));
      }
    }

    [AttributeLogicalName("ait_autonumbertest")]
    public string ait_AutoNumberTest
    {
      get => this.GetAttributeValue<string>("ait_autonumbertest");
      set
      {
        this.OnPropertyChanging(nameof (ait_AutoNumberTest));
        this.SetAttributeValue("ait_autonumbertest", (object) value);
        this.OnPropertyChanged(nameof (ait_AutoNumberTest));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    public EntityReference ait_CasePlan
    {
      get => this.GetAttributeValue<EntityReference>("ait_caseplan");
      set
      {
        this.OnPropertyChanging(nameof (ait_CasePlan));
        this.SetAttributeValue("ait_caseplan", (object) value);
        this.OnPropertyChanged(nameof (ait_CasePlan));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    public EntityReference ait_caseworker
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_caseworker));
      set
      {
        this.OnPropertyChanging(nameof (ait_caseworker));
        this.SetAttributeValue(nameof (ait_caseworker), (object) value);
        this.OnPropertyChanged(nameof (ait_caseworker));
      }
    }

    [AttributeLogicalName("ait_christmasgivingtree")]
    public bool? ait_christmasgivingtree
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_christmasgivingtree));
      set
      {
        this.OnPropertyChanging(nameof (ait_christmasgivingtree));
        this.SetAttributeValue(nameof (ait_christmasgivingtree), (object) value);
        this.OnPropertyChanged(nameof (ait_christmasgivingtree));
      }
    }

    [AttributeLogicalName("ait_christmasvouchers")]
    public bool? ait_christmasvouchers
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_christmasvouchers));
      set
      {
        this.OnPropertyChanging(nameof (ait_christmasvouchers));
        this.SetAttributeValue(nameof (ait_christmasvouchers), (object) value);
        this.OnPropertyChanged(nameof (ait_christmasvouchers));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    public EntityReference ait_clientprofile
    {
      get => this.GetAttributeValue<EntityReference>(nameof (ait_clientprofile));
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile));
        this.SetAttributeValue(nameof (ait_clientprofile), (object) value);
        this.OnPropertyChanged(nameof (ait_clientprofile));
      }
    }

    [AttributeLogicalName("ait_completiondate")]
    public DateTime? ait_CompletionDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_completiondate");
      set
      {
        this.OnPropertyChanging(nameof (ait_CompletionDate));
        this.SetAttributeValue("ait_completiondate", (object) value);
        this.OnPropertyChanged(nameof (ait_CompletionDate));
      }
    }

    [AttributeLogicalName("ait_eligibilitycriteria")]
    public string ait_eligibilitycriteria
    {
      get => this.GetAttributeValue<string>(nameof (ait_eligibilitycriteria));
      set
      {
        this.OnPropertyChanging(nameof (ait_eligibilitycriteria));
        this.SetAttributeValue(nameof (ait_eligibilitycriteria), (object) value);
        this.OnPropertyChanged(nameof (ait_eligibilitycriteria));
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

    [AttributeLogicalName("ait_financialassistancerequested")]
    public bool? ait_financialassistancerequested
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_financialassistancerequested));
      set
      {
        this.OnPropertyChanging(nameof (ait_financialassistancerequested));
        this.SetAttributeValue(nameof (ait_financialassistancerequested), (object) value);
        this.OnPropertyChanged(nameof (ait_financialassistancerequested));
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

    [AttributeLogicalName("ait_requestedamount")]
    public Money ait_requestedamount
    {
      get => this.GetAttributeValue<Money>(nameof (ait_requestedamount));
      set
      {
        this.OnPropertyChanging(nameof (ait_requestedamount));
        this.SetAttributeValue(nameof (ait_requestedamount), (object) value);
        this.OnPropertyChanged(nameof (ait_requestedamount));
      }
    }

    [AttributeLogicalName("ait_requestedamount_base")]
    public Money ait_requestedamount_Base
    {
      get => this.GetAttributeValue<Money>("ait_requestedamount_base");
    }

    [AttributeLogicalName("ait_requestereligible")]
    public OptionSetValue ait_RequesterEligible
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_requestereligible");
      set
      {
        this.OnPropertyChanging(nameof (ait_RequesterEligible));
        this.SetAttributeValue("ait_requestereligible", (object) value);
        this.OnPropertyChanged(nameof (ait_RequesterEligible));
      }
    }

    [AttributeLogicalName("ait_servicerequestdate")]
    public DateTime? ait_servicerequestdate
    {
      get => this.GetAttributeValue<DateTime?>(nameof (ait_servicerequestdate));
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequestdate));
        this.SetAttributeValue(nameof (ait_servicerequestdate), (object) value);
        this.OnPropertyChanged(nameof (ait_servicerequestdate));
      }
    }

    [AttributeLogicalName("ait_servicerequestid")]
    public Guid? ait_servicerequestId
    {
      get => this.GetAttributeValue<Guid?>("ait_servicerequestid");
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequestId));
        this.SetAttributeValue("ait_servicerequestid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_servicerequestId));
      }
    }

    [AttributeLogicalName("ait_servicerequestid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_servicerequestId = new Guid?(value);
    }

    [AttributeLogicalName("ait_servicerequestname")]
    public string ait_ServiceRequestName
    {
      get => this.GetAttributeValue<string>("ait_servicerequestname");
      set
      {
        this.OnPropertyChanging(nameof (ait_ServiceRequestName));
        this.SetAttributeValue("ait_servicerequestname", (object) value);
        this.OnPropertyChanged(nameof (ait_ServiceRequestName));
      }
    }

    [AttributeLogicalName("ait_servicerequestreason")]
    public string ait_servicerequestreason
    {
      get => this.GetAttributeValue<string>(nameof (ait_servicerequestreason));
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequestreason));
        this.SetAttributeValue(nameof (ait_servicerequestreason), (object) value);
        this.OnPropertyChanged(nameof (ait_servicerequestreason));
      }
    }

    [AttributeLogicalName("ait_servicerequeststatus")]
    public OptionSetValue ait_servicerequeststatus
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_servicerequeststatus));
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequeststatus));
        this.SetAttributeValue(nameof (ait_servicerequeststatus), (object) value);
        this.OnPropertyChanged(nameof (ait_servicerequeststatus));
      }
    }

    [AttributeLogicalName("ait_servicerequesttype")]
    public OptionSetValue ait_servicerequesttype
    {
      get => this.GetAttributeValue<OptionSetValue>(nameof (ait_servicerequesttype));
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequesttype));
        this.SetAttributeValue(nameof (ait_servicerequesttype), (object) value);
        this.OnPropertyChanged(nameof (ait_servicerequesttype));
      }
    }

    [AttributeLogicalName("ait_thanksgivingvouchers")]
    public bool? ait_thanksgivingvouchers
    {
      get => this.GetAttributeValue<bool?>(nameof (ait_thanksgivingvouchers));
      set
      {
        this.OnPropertyChanging(nameof (ait_thanksgivingvouchers));
        this.SetAttributeValue(nameof (ait_thanksgivingvouchers), (object) value);
        this.OnPropertyChanged(nameof (ait_thanksgivingvouchers));
      }
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
    public Ait_servicerequestState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new Ait_servicerequestState?((Ait_servicerequestState) Enum.ToObject(typeof (Ait_servicerequestState), attributeValue.Value)) : new Ait_servicerequestState?();
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

    [RelationshipSchemaName("ait_servicerequest_ait_caseplan_ServiceRequest")]
    public IEnumerable<ait_caseplan> ait_servicerequest_ait_caseplan_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_caseplan>(nameof (ait_servicerequest_ait_caseplan_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_caseplan_ServiceRequest));
        this.SetRelatedEntities<ait_caseplan>(nameof (ait_servicerequest_ait_caseplan_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_caseplan_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ait_goal_ServiceRequest")]
    public IEnumerable<ait_goal> ait_servicerequest_ait_goal_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_goal>(nameof (ait_servicerequest_ait_goal_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_goal_ServiceRequest));
        this.SetRelatedEntities<ait_goal>(nameof (ait_servicerequest_ait_goal_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_goal_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ait_payment_ServiceRequest")]
    public IEnumerable<ait_payment> ait_servicerequest_ait_payment_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_payment>(nameof (ait_servicerequest_ait_payment_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_payment_ServiceRequest));
        this.SetRelatedEntities<ait_payment>(nameof (ait_servicerequest_ait_payment_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_payment_ServiceRequest));
      }
    }

    [RelationshipSchemaName("ait_servicerequest_ait_referral_ServiceRequest")]
    public IEnumerable<ait_referral> ait_servicerequest_ait_referral_ServiceRequest
    {
      get
      {
        return this.GetRelatedEntities<ait_referral>(nameof (ait_servicerequest_ait_referral_ServiceRequest), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_ait_referral_ServiceRequest));
        this.SetRelatedEntities<ait_referral>(nameof (ait_servicerequest_ait_referral_ServiceRequest), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_ait_referral_ServiceRequest));
      }
    }

    [AttributeLogicalName("ait_caseplan")]
    [RelationshipSchemaName("ait_caseplan_ait_servicerequest_Plan")]
    public ait_caseplan ait_caseplan_ait_servicerequest_Plan
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ait_servicerequest_Plan), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_ait_servicerequest_Plan));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_ait_servicerequest_Plan), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_ait_servicerequest_Plan));
      }
    }

    [AttributeLogicalName("ait_familygroup")]
    [RelationshipSchemaName("ait_familygroup_ait_servicerequest_FamilyGroup")]
    public ait_familygroup ait_familygroup_ait_servicerequest_FamilyGroup
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_servicerequest_FamilyGroup), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_ait_servicerequest_FamilyGroup));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_ait_servicerequest_FamilyGroup), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_ait_servicerequest_FamilyGroup));
      }
    }

    [AttributeLogicalName("ait_program")]
    [RelationshipSchemaName("ait_program_ait_servicerequest_Program")]
    public ait_program ait_program_ait_servicerequest_Program
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_ait_servicerequest_Program), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_ait_servicerequest_Program));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_ait_servicerequest_Program), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_ait_servicerequest_Program));
      }
    }

    [AttributeLogicalName("ait_clientprofile")]
    [RelationshipSchemaName("ait_servicerequest_clientprofile_ait_clie")]
    public TPFamilyWellness.EarlyBound.ait_clientprofile ait_servicerequest_clientprofile_ait_clie
    {
      get
      {
        return this.GetRelatedEntity<TPFamilyWellness.EarlyBound.ait_clientprofile>(nameof (ait_servicerequest_clientprofile_ait_clie), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_clientprofile_ait_clie));
        this.SetRelatedEntity<TPFamilyWellness.EarlyBound.ait_clientprofile>(nameof (ait_servicerequest_clientprofile_ait_clie), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_clientprofile_ait_clie));
      }
    }
  }
}
