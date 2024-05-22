// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ait_icwaadoption
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("ait_icwaadoption")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ait_icwaadoption : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "ait_icwaadoption";
    public const string EntitySchemaName = "ait_icwaadoption";
    public const string PrimaryIdAttribute = "ait_icwaadoptionid";
    public const string PrimaryNameAttribute = "ait_name";

    public ait_icwaadoption()
      : base(nameof (ait_icwaadoption))
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

    [AttributeLogicalName("ait_action")]
    public OptionSetValue ait_Action
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_action");
      set
      {
        this.OnPropertyChanging(nameof (ait_Action));
        this.SetAttributeValue("ait_action", (object) value);
        this.OnPropertyChanged(nameof (ait_Action));
      }
    }

    [AttributeLogicalName("ait_adoptiondecreeno")]
    public string ait_AdoptionDecreeNo
    {
      get => this.GetAttributeValue<string>("ait_adoptiondecreeno");
      set
      {
        this.OnPropertyChanging(nameof (ait_AdoptionDecreeNo));
        this.SetAttributeValue("ait_adoptiondecreeno", (object) value);
        this.OnPropertyChanged(nameof (ait_AdoptionDecreeNo));
      }
    }

    [AttributeLogicalName("ait_adoptiveparent1")]
    public string ait_AdoptiveParent1
    {
      get => this.GetAttributeValue<string>("ait_adoptiveparent1");
      set
      {
        this.OnPropertyChanging(nameof (ait_AdoptiveParent1));
        this.SetAttributeValue("ait_adoptiveparent1", (object) value);
        this.OnPropertyChanged(nameof (ait_AdoptiveParent1));
      }
    }

    [AttributeLogicalName("ait_adoptiveparent2")]
    public string ait_AdoptiveParent2
    {
      get => this.GetAttributeValue<string>("ait_adoptiveparent2");
      set
      {
        this.OnPropertyChanging(nameof (ait_AdoptiveParent2));
        this.SetAttributeValue("ait_adoptiveparent2", (object) value);
        this.OnPropertyChanged(nameof (ait_AdoptiveParent2));
      }
    }

    [AttributeLogicalName("ait_adoptiveparentaddress")]
    public string ait_AdoptiveParentAddress
    {
      get => this.GetAttributeValue<string>("ait_adoptiveparentaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_AdoptiveParentAddress));
        this.SetAttributeValue("ait_adoptiveparentaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_AdoptiveParentAddress));
      }
    }

    [AttributeLogicalName("ait_approvaldate")]
    public DateTime? ait_ApprovalDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_approvaldate");
      set
      {
        this.OnPropertyChanging(nameof (ait_ApprovalDate));
        this.SetAttributeValue("ait_approvaldate", (object) value);
        this.OnPropertyChanged(nameof (ait_ApprovalDate));
      }
    }

    [AttributeLogicalName("ait_birthfather")]
    public string ait_BirthFather
    {
      get => this.GetAttributeValue<string>("ait_birthfather");
      set
      {
        this.OnPropertyChanging(nameof (ait_BirthFather));
        this.SetAttributeValue("ait_birthfather", (object) value);
        this.OnPropertyChanged(nameof (ait_BirthFather));
      }
    }

    [AttributeLogicalName("ait_birthfatheranonymous")]
    public OptionSetValue ait_BirthFatherAnonymous
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_birthfatheranonymous");
      set
      {
        this.OnPropertyChanging(nameof (ait_BirthFatherAnonymous));
        this.SetAttributeValue("ait_birthfatheranonymous", (object) value);
        this.OnPropertyChanged(nameof (ait_BirthFatherAnonymous));
      }
    }

    [AttributeLogicalName("ait_birthmother")]
    public string ait_BirthMother
    {
      get => this.GetAttributeValue<string>("ait_birthmother");
      set
      {
        this.OnPropertyChanging(nameof (ait_BirthMother));
        this.SetAttributeValue("ait_birthmother", (object) value);
        this.OnPropertyChanged(nameof (ait_BirthMother));
      }
    }

    [AttributeLogicalName("ait_birthmotheranonymous")]
    public OptionSetValue ait_BirthMotherAnonymous
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_birthmotheranonymous");
      set
      {
        this.OnPropertyChanging(nameof (ait_BirthMotherAnonymous));
        this.SetAttributeValue("ait_birthmotheranonymous", (object) value);
        this.OnPropertyChanged(nameof (ait_BirthMotherAnonymous));
      }
    }

    [AttributeLogicalName("ait_birthname")]
    public string ait_BirthName
    {
      get => this.GetAttributeValue<string>("ait_birthname");
      set
      {
        this.OnPropertyChanging(nameof (ait_BirthName));
        this.SetAttributeValue("ait_birthname", (object) value);
        this.OnPropertyChanged(nameof (ait_BirthName));
      }
    }

    [AttributeLogicalName("ait_birthparentaddress")]
    public string ait_BirthParentAddress
    {
      get => this.GetAttributeValue<string>("ait_birthparentaddress");
      set
      {
        this.OnPropertyChanging(nameof (ait_BirthParentAddress));
        this.SetAttributeValue("ait_birthparentaddress", (object) value);
        this.OnPropertyChanged(nameof (ait_BirthParentAddress));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    public EntityReference ait_Caseworker
    {
      get => this.GetAttributeValue<EntityReference>("ait_caseworker");
      set
      {
        this.OnPropertyChanging(nameof (ait_Caseworker));
        this.SetAttributeValue("ait_caseworker", (object) value);
        this.OnPropertyChanged(nameof (ait_Caseworker));
      }
    }

    [AttributeLogicalName("ait_childclientprofile")]
    public EntityReference ait_ChildClientProfile
    {
      get => this.GetAttributeValue<EntityReference>("ait_childclientprofile");
      set
      {
        this.OnPropertyChanging(nameof (ait_ChildClientProfile));
        this.SetAttributeValue("ait_childclientprofile", (object) value);
        this.OnPropertyChanged(nameof (ait_ChildClientProfile));
      }
    }

    [AttributeLogicalName("ait_countyofadoption")]
    public string ait_CountyofAdoption
    {
      get => this.GetAttributeValue<string>("ait_countyofadoption");
      set
      {
        this.OnPropertyChanging(nameof (ait_CountyofAdoption));
        this.SetAttributeValue("ait_countyofadoption", (object) value);
        this.OnPropertyChanged(nameof (ait_CountyofAdoption));
      }
    }

    [AttributeLogicalName("ait_dateofadoption")]
    public DateTime? ait_DateofAdoption
    {
      get => this.GetAttributeValue<DateTime?>("ait_dateofadoption");
      set
      {
        this.OnPropertyChanging(nameof (ait_DateofAdoption));
        this.SetAttributeValue("ait_dateofadoption", (object) value);
        this.OnPropertyChanged(nameof (ait_DateofAdoption));
      }
    }

    [AttributeLogicalName("ait_deniedreason")]
    public string ait_DeniedReason
    {
      get => this.GetAttributeValue<string>("ait_deniedreason");
      set
      {
        this.OnPropertyChanging(nameof (ait_DeniedReason));
        this.SetAttributeValue("ait_deniedreason", (object) value);
        this.OnPropertyChanged(nameof (ait_DeniedReason));
      }
    }

    [AttributeLogicalName("ait_deptrepsignature")]
    public string ait_DeptRepSignature
    {
      get => this.GetAttributeValue<string>("ait_deptrepsignature");
      set
      {
        this.OnPropertyChanging(nameof (ait_DeptRepSignature));
        this.SetAttributeValue("ait_deptrepsignature", (object) value);
        this.OnPropertyChanged(nameof (ait_DeptRepSignature));
      }
    }

    [AttributeLogicalName("ait_icwaadoptionid")]
    public Guid? ait_icwaadoptionId
    {
      get => this.GetAttributeValue<Guid?>("ait_icwaadoptionid");
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoptionId));
        this.SetAttributeValue("ait_icwaadoptionid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ait_icwaadoptionId));
      }
    }

    [AttributeLogicalName("ait_icwaadoptionid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ait_icwaadoptionId = new Guid?(value);
    }

    [AttributeLogicalName("ait_icwaadoptionidauto")]
    public string ait_ICWAAdoptionIDauto
    {
      get => this.GetAttributeValue<string>("ait_icwaadoptionidauto");
      set
      {
        this.OnPropertyChanging(nameof (ait_ICWAAdoptionIDauto));
        this.SetAttributeValue("ait_icwaadoptionidauto", (object) value);
        this.OnPropertyChanged(nameof (ait_ICWAAdoptionIDauto));
      }
    }

    [AttributeLogicalName("ait_istribalmember")]
    public OptionSetValue ait_IsTribalMember
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_istribalmember");
      set
      {
        this.OnPropertyChanging(nameof (ait_IsTribalMember));
        this.SetAttributeValue("ait_istribalmember", (object) value);
        this.OnPropertyChanged(nameof (ait_IsTribalMember));
      }
    }

    [AttributeLogicalName("ait_memberoftribe")]
    public EntityReference ait_MemberofTribe
    {
      get => this.GetAttributeValue<EntityReference>("ait_memberoftribe");
      set
      {
        this.OnPropertyChanging(nameof (ait_MemberofTribe));
        this.SetAttributeValue("ait_memberoftribe", (object) value);
        this.OnPropertyChanged(nameof (ait_MemberofTribe));
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

    [AttributeLogicalName("ait_nameafteradoption")]
    public string ait_Nameafteradoption
    {
      get => this.GetAttributeValue<string>("ait_nameafteradoption");
      set
      {
        this.OnPropertyChanging(nameof (ait_Nameafteradoption));
        this.SetAttributeValue("ait_nameafteradoption", (object) value);
        this.OnPropertyChanged(nameof (ait_Nameafteradoption));
      }
    }

    [AttributeLogicalName("ait_nameofstateortribalcourt")]
    public string ait_NameofStateorTribalCourt
    {
      get => this.GetAttributeValue<string>("ait_nameofstateortribalcourt");
      set
      {
        this.OnPropertyChanging(nameof (ait_NameofStateorTribalCourt));
        this.SetAttributeValue("ait_nameofstateortribalcourt", (object) value);
        this.OnPropertyChanged(nameof (ait_NameofStateorTribalCourt));
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

    [AttributeLogicalName("ait_signaturedate")]
    public DateTime? ait_SignatureDate
    {
      get => this.GetAttributeValue<DateTime?>("ait_signaturedate");
      set
      {
        this.OnPropertyChanging(nameof (ait_SignatureDate));
        this.SetAttributeValue("ait_signaturedate", (object) value);
        this.OnPropertyChanged(nameof (ait_SignatureDate));
      }
    }

    [AttributeLogicalName("ait_stateofadoption")]
    public string ait_StateofAdoption
    {
      get => this.GetAttributeValue<string>("ait_stateofadoption");
      set
      {
        this.OnPropertyChanging(nameof (ait_StateofAdoption));
        this.SetAttributeValue("ait_stateofadoption", (object) value);
        this.OnPropertyChanged(nameof (ait_StateofAdoption));
      }
    }

    [AttributeLogicalName("ait_status")]
    public OptionSetValue ait_Status
    {
      get => this.GetAttributeValue<OptionSetValue>("ait_status");
      set
      {
        this.OnPropertyChanging(nameof (ait_Status));
        this.SetAttributeValue("ait_status", (object) value);
        this.OnPropertyChanged(nameof (ait_Status));
      }
    }

    [AttributeLogicalName("ait_tribalcourtrepresentative")]
    public string ait_TribalCourtRepresentative
    {
      get => this.GetAttributeValue<string>("ait_tribalcourtrepresentative");
      set
      {
        this.OnPropertyChanging(nameof (ait_TribalCourtRepresentative));
        this.SetAttributeValue("ait_tribalcourtrepresentative", (object) value);
        this.OnPropertyChanged(nameof (ait_TribalCourtRepresentative));
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
    public ait_icwaadoptionState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new ait_icwaadoptionState?((ait_icwaadoptionState) Enum.ToObject(typeof (ait_icwaadoptionState), attributeValue.Value)) : new ait_icwaadoptionState?();
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

    [RelationshipSchemaName("ait_icwaadoption_ActivityPointers")]
    public IEnumerable<ActivityPointer> ait_icwaadoption_ActivityPointers
    {
      get
      {
        return this.GetRelatedEntities<ActivityPointer>(nameof (ait_icwaadoption_ActivityPointers), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_ActivityPointers));
        this.SetRelatedEntities<ActivityPointer>(nameof (ait_icwaadoption_ActivityPointers), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_ActivityPointers));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_Annotations")]
    public IEnumerable<Annotation> ait_icwaadoption_Annotations
    {
      get
      {
        return this.GetRelatedEntities<Annotation>(nameof (ait_icwaadoption_Annotations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Annotations));
        this.SetRelatedEntities<Annotation>(nameof (ait_icwaadoption_Annotations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Annotations));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_Appointments")]
    public IEnumerable<Appointment> ait_icwaadoption_Appointments
    {
      get
      {
        return this.GetRelatedEntities<Appointment>(nameof (ait_icwaadoption_Appointments), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Appointments));
        this.SetRelatedEntities<Appointment>(nameof (ait_icwaadoption_Appointments), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Appointments));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_AsyncOperations")]
    public IEnumerable<AsyncOperation> ait_icwaadoption_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (ait_icwaadoption_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (ait_icwaadoption_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_AsyncOperations));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> ait_icwaadoption_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (ait_icwaadoption_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (ait_icwaadoption_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_DuplicateBaseRecord")]
    public IEnumerable<DuplicateRecord> ait_icwaadoption_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_icwaadoption_DuplicateBaseRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_DuplicateBaseRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_icwaadoption_DuplicateBaseRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_DuplicateBaseRecord));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_DuplicateMatchingRecord")]
    public IEnumerable<DuplicateRecord> ait_icwaadoption_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntities<DuplicateRecord>(nameof (ait_icwaadoption_DuplicateMatchingRecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_DuplicateMatchingRecord));
        this.SetRelatedEntities<DuplicateRecord>(nameof (ait_icwaadoption_DuplicateMatchingRecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_DuplicateMatchingRecord));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_Emails")]
    public IEnumerable<Email> ait_icwaadoption_Emails
    {
      get => this.GetRelatedEntities<Email>(nameof (ait_icwaadoption_Emails), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Emails));
        this.SetRelatedEntities<Email>(nameof (ait_icwaadoption_Emails), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Emails));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_Faxes")]
    public IEnumerable<Fax> ait_icwaadoption_Faxes
    {
      get => this.GetRelatedEntities<Fax>(nameof (ait_icwaadoption_Faxes), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Faxes));
        this.SetRelatedEntities<Fax>(nameof (ait_icwaadoption_Faxes), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Faxes));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_Letters")]
    public IEnumerable<Letter> ait_icwaadoption_Letters
    {
      get => this.GetRelatedEntities<Letter>(nameof (ait_icwaadoption_Letters), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Letters));
        this.SetRelatedEntities<Letter>(nameof (ait_icwaadoption_Letters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Letters));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> ait_icwaadoption_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (ait_icwaadoption_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (ait_icwaadoption_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_PhoneCalls")]
    public IEnumerable<PhoneCall> ait_icwaadoption_PhoneCalls
    {
      get
      {
        return this.GetRelatedEntities<PhoneCall>(nameof (ait_icwaadoption_PhoneCalls), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_PhoneCalls));
        this.SetRelatedEntities<PhoneCall>(nameof (ait_icwaadoption_PhoneCalls), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_PhoneCalls));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> ait_icwaadoption_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_icwaadoption_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (ait_icwaadoption_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_ProcessSession")]
    public IEnumerable<ProcessSession> ait_icwaadoption_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (ait_icwaadoption_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (ait_icwaadoption_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_ProcessSession));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_RecurringAppointmentMasters")]
    public IEnumerable<RecurringAppointmentMaster> ait_icwaadoption_RecurringAppointmentMasters
    {
      get
      {
        return this.GetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_icwaadoption_RecurringAppointmentMasters), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_RecurringAppointmentMasters));
        this.SetRelatedEntities<RecurringAppointmentMaster>(nameof (ait_icwaadoption_RecurringAppointmentMasters), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_RecurringAppointmentMasters));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_SocialActivities")]
    public IEnumerable<SocialActivity> ait_icwaadoption_SocialActivities
    {
      get
      {
        return this.GetRelatedEntities<SocialActivity>(nameof (ait_icwaadoption_SocialActivities), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_SocialActivities));
        this.SetRelatedEntities<SocialActivity>(nameof (ait_icwaadoption_SocialActivities), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_SocialActivities));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_SyncErrors")]
    public IEnumerable<SyncError> ait_icwaadoption_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (ait_icwaadoption_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (ait_icwaadoption_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_SyncErrors));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_Tasks")]
    public IEnumerable<Task> ait_icwaadoption_Tasks
    {
      get => this.GetRelatedEntities<Task>(nameof (ait_icwaadoption_Tasks), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_Tasks));
        this.SetRelatedEntities<Task>(nameof (ait_icwaadoption_Tasks), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_Tasks));
      }
    }

    [RelationshipSchemaName("ait_icwaadoption_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> ait_icwaadoption_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (ait_icwaadoption_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (ait_icwaadoption_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_UserEntityInstanceDatas));
      }
    }

    [AttributeLogicalName("ait_childclientprofile")]
    [RelationshipSchemaName("ait_clientprofile_ait_icwaadoption_ChildClientProfile")]
    public ait_clientprofile ait_clientprofile_ait_icwaadoption_ChildClientProfile
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_icwaadoption_ChildClientProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_ait_icwaadoption_ChildClientProfile));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_ait_icwaadoption_ChildClientProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_ait_icwaadoption_ChildClientProfile));
      }
    }

    [AttributeLogicalName("ait_caseworker")]
    [RelationshipSchemaName("ait_systemuser_ait_icwaadoption_Caseworker")]
    public SystemUser ait_systemuser_ait_icwaadoption_Caseworker
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_icwaadoption_Caseworker), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_systemuser_ait_icwaadoption_Caseworker));
        this.SetRelatedEntity<SystemUser>(nameof (ait_systemuser_ait_icwaadoption_Caseworker), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_systemuser_ait_icwaadoption_Caseworker));
      }
    }

    [AttributeLogicalName("ait_memberoftribe")]
    [RelationshipSchemaName("ait_tribe_ait_icwaadoption_MemberofTribe")]
    public ait_tribe ait_tribe_ait_icwaadoption_MemberofTribe
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_ait_icwaadoption_MemberofTribe), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_ait_icwaadoption_MemberofTribe));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_tribe_ait_icwaadoption_MemberofTribe), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_ait_icwaadoption_MemberofTribe));
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_ait_icwaadoption")]
    public BusinessUnit business_unit_ait_icwaadoption
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (business_unit_ait_icwaadoption), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_ait_icwaadoption_createdby")]
    public SystemUser lk_ait_icwaadoption_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaadoption_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_ait_icwaadoption_createdonbehalfby")]
    public SystemUser lk_ait_icwaadoption_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaadoption_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_icwaadoption_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_icwaadoption_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_icwaadoption_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_ait_icwaadoption_modifiedby")]
    public SystemUser lk_ait_icwaadoption_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaadoption_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_ait_icwaadoption_modifiedonbehalfby")]
    public SystemUser lk_ait_icwaadoption_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_ait_icwaadoption_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_ait_icwaadoption_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_ait_icwaadoption_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_ait_icwaadoption_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_ait_icwaadoption")]
    public Team team_ait_icwaadoption
    {
      get => this.GetRelatedEntity<Team>(nameof (team_ait_icwaadoption), new EntityRole?());
    }

    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_ait_icwaadoption")]
    public SystemUser user_ait_icwaadoption
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (user_ait_icwaadoption), new EntityRole?());
    }

    public ait_icwaadoption(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["ait_icwaadoptionid"] = (object) base.Id;
            break;
          case "ait_icwaadoptionid":
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
