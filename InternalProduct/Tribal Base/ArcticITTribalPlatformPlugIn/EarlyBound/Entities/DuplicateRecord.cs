// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.DuplicateRecord
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("duplicaterecord")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class DuplicateRecord : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "duplicaterecord";
    public const string EntitySchemaName = "DuplicateRecord";
    public const string PrimaryIdAttribute = "duplicateid";

    public DuplicateRecord()
      : base("duplicaterecord")
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

    [AttributeLogicalName("asyncoperationid")]
    public EntityReference AsyncOperationId
    {
      get => this.GetAttributeValue<EntityReference>("asyncoperationid");
    }

    [AttributeLogicalName("baserecordid")]
    public EntityReference BaseRecordId => this.GetAttributeValue<EntityReference>("baserecordid");

    [AttributeLogicalName("createdon")]
    public DateTime? CreatedOn => this.GetAttributeValue<DateTime?>("createdon");

    [AttributeLogicalName("duplicateid")]
    public Guid? DuplicateId
    {
      get => this.GetAttributeValue<Guid?>("duplicateid");
      set
      {
        this.OnPropertyChanging(nameof (DuplicateId));
        this.SetAttributeValue("duplicateid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (DuplicateId));
      }
    }

    [AttributeLogicalName("duplicateid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.DuplicateId = new Guid?(value);
    }

    [AttributeLogicalName("duplicaterecordid")]
    public EntityReference DuplicateRecordId
    {
      get => this.GetAttributeValue<EntityReference>("duplicaterecordid");
    }

    [AttributeLogicalName("duplicateruleid")]
    public EntityReference DuplicateRuleId
    {
      get => this.GetAttributeValue<EntityReference>("duplicateruleid");
    }

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

    [RelationshipSchemaName("userentityinstancedata_duplicaterecord")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterecord
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_duplicaterecord), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_duplicaterecord));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_duplicaterecord), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_duplicaterecord));
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Account_DuplicateBaseRecord")]
    public Account Account_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (Account_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Account_DuplicateMatchingRecord")]
    public Account Account_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (Account_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_addresstype_DuplicateBaseRecord")]
    public ait_addresstype ait_addresstype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_addresstype_DuplicateMatchingRecord")]
    public ait_addresstype ait_addresstype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_assessment_DuplicateBaseRecord")]
    public ait_assessment ait_assessment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_assessment_DuplicateMatchingRecord")]
    public ait_assessment ait_assessment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_band_DuplicateBaseRecord")]
    public ait_band ait_band_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_band>(nameof (ait_band_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_band_DuplicateMatchingRecord")]
    public ait_band ait_band_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_band>(nameof (ait_band_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_bankaccounttype_DuplicateBaseRecord")]
    public ait_bankaccounttype ait_bankaccounttype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_bankaccounttype_DuplicateMatchingRecord")]
    public ait_bankaccounttype ait_bankaccounttype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_birthrecord_DuplicateBaseRecord")]
    public ait_birthrecord ait_birthrecord_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_birthrecord_DuplicateMatchingRecord")]
    public ait_birthrecord ait_birthrecord_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_bloodquantum_DuplicateBaseRecord")]
    public ait_bloodquantum ait_bloodquantum_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_bloodquantum_DuplicateMatchingRecord")]
    public ait_bloodquantum ait_bloodquantum_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_cardhistory_DuplicateBaseRecord")]
    public ait_cardhistory ait_cardhistory_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_cardhistory_DuplicateMatchingRecord")]
    public ait_cardhistory ait_cardhistory_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_case_DuplicateBaseRecord")]
    public ait_case ait_case_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_case_DuplicateMatchingRecord")]
    public ait_case ait_case_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_casenote_DuplicateBaseRecord")]
    public ait_casenote ait_casenote_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_casenote_DuplicateMatchingRecord")]
    public ait_casenote ait_casenote_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_caseplan_DuplicateBaseRecord")]
    public ait_caseplan ait_caseplan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_caseplan_DuplicateMatchingRecord")]
    public ait_caseplan ait_caseplan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_causeofdeath_DuplicateBaseRecord")]
    public ait_causeofdeath ait_causeofdeath_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_causeofdeath_DuplicateMatchingRecord")]
    public ait_causeofdeath ait_causeofdeath_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_cemetary_DuplicateBaseRecord")]
    public ait_cemetary ait_cemetary_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_cemetary_DuplicateMatchingRecord")]
    public ait_cemetary ait_cemetary_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_certification_DuplicateBaseRecord")]
    public ait_certification ait_certification_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_certification_DuplicateMatchingRecord")]
    public ait_certification ait_certification_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_changerequest_DuplicateBaseRecord")]
    public ait_changerequest ait_changerequest_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_changerequest_DuplicateMatchingRecord")]
    public ait_changerequest ait_changerequest_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_changerequesttype_DuplicateBaseRecord")]
    public ait_changerequesttype ait_changerequesttype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_changerequesttype_DuplicateMatchingRecord")]
    public ait_changerequesttype ait_changerequesttype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_charge_DuplicateBaseRecord")]
    public ait_charge ait_charge_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_charge>(nameof (ait_charge_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_charge_DuplicateMatchingRecord")]
    public ait_charge ait_charge_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_charge>(nameof (ait_charge_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_childvisitations_DuplicateBaseRecord")]
    public ait_childvisitations ait_childvisitations_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_childvisitations_DuplicateMatchingRecord")]
    public ait_childvisitations ait_childvisitations_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_city_DuplicateBaseRecord")]
    public ait_city ait_city_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_city_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_city_DuplicateMatchingRecord")]
    public ait_city ait_city_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_city_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_clan_DuplicateBaseRecord")]
    public ait_clan ait_clan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_clan>(nameof (ait_clan_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_clan_DuplicateMatchingRecord")]
    public ait_clan ait_clan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_clan>(nameof (ait_clan_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_clientprofile_DuplicateBaseRecord")]
    public ait_clientprofile ait_clientprofile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_clientprofile_DuplicateMatchingRecord")]
    public ait_clientprofile ait_clientprofile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_committee_DuplicateBaseRecord")]
    public ait_committee ait_committee_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_committee_DuplicateMatchingRecord")]
    public ait_committee ait_committee_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_committeemeeting_DuplicateBaseRecord")]
    public ait_committeemeeting ait_committeemeeting_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_committeemeeting_DuplicateMatchingRecord")]
    public ait_committeemeeting ait_committeemeeting_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_committeemember_DuplicateBaseRecord")]
    public ait_committeemember ait_committeemember_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_committeemember_DuplicateMatchingRecord")]
    public ait_committeemember ait_committeemember_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_committeeposition_DuplicateBaseRecord")]
    public ait_committeeposition ait_committeeposition_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_committeeposition_DuplicateMatchingRecord")]
    public ait_committeeposition ait_committeeposition_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_committeepositiontype_DuplicateBaseRecord")]
    public ait_committeepositiontype ait_committeepositiontype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_committeepositiontype_DuplicateMatchingRecord")]
    public ait_committeepositiontype ait_committeepositiontype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_company_DuplicateBaseRecord")]
    public ait_company ait_company_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_company_DuplicateMatchingRecord")]
    public ait_company ait_company_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contactcertification_DuplicateBaseRecord")]
    public ait_contactcertification ait_contactcertification_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contactcertification_DuplicateMatchingRecord")]
    public ait_contactcertification ait_contactcertification_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contacteducation_DuplicateBaseRecord")]
    public ait_contacteducation ait_contacteducation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contacteducation_DuplicateMatchingRecord")]
    public ait_contacteducation ait_contacteducation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contactemployment_DuplicateBaseRecord")]
    public ait_contactemployment ait_contactemployment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contactemployment_DuplicateMatchingRecord")]
    public ait_contactemployment ait_contactemployment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contactimage_DuplicateBaseRecord")]
    public ait_contactimage ait_contactimage_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contactimage_DuplicateMatchingRecord")]
    public ait_contactimage ait_contactimage_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contactincarceration_DuplicateBaseRecord")]
    public ait_contactincarceration ait_contactincarceration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contactincarceration_DuplicateMatchingRecord")]
    public ait_contactincarceration ait_contactincarceration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_DuplicateBaseRecord")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_DuplicateMatchingRecord")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_DuplicateBaseRecord")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_DuplicateMatchingRecord")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contactname_DuplicateBaseRecord")]
    public ait_contactname ait_contactname_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contactname_DuplicateMatchingRecord")]
    public ait_contactname ait_contactname_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_contactskill_DuplicateBaseRecord")]
    public ait_contactskill ait_contactskill_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_contactskill_DuplicateMatchingRecord")]
    public ait_contactskill ait_contactskill_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_countryregion_DuplicateBaseRecord")]
    public ait_countryregion ait_countryregion_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_countryregion_DuplicateMatchingRecord")]
    public ait_countryregion ait_countryregion_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_county_DuplicateBaseRecord")]
    public ait_county ait_county_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_county>(nameof (ait_county_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_county_DuplicateMatchingRecord")]
    public ait_county ait_county_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_county>(nameof (ait_county_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_courtcase_DuplicateBaseRecord")]
    public ait_courtcase ait_courtcase_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_courtcase_DuplicateMatchingRecord")]
    public ait_courtcase ait_courtcase_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_courtfinesandfees_DuplicateBaseRecord")]
    public ait_courtfinesandfees ait_courtfinesandfees_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_courtfinesandfees_DuplicateMatchingRecord")]
    public ait_courtfinesandfees ait_courtfinesandfees_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_courtparty_DuplicateBaseRecord")]
    public ait_courtparty ait_courtparty_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_courtparty_DuplicateMatchingRecord")]
    public ait_courtparty ait_courtparty_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_courtpayments_DuplicateBaseRecord")]
    public ait_courtpayments ait_courtpayments_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_courtpayments_DuplicateMatchingRecord")]
    public ait_courtpayments ait_courtpayments_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_courtprofile_DuplicateBaseRecord")]
    public ait_courtprofile ait_courtprofile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_courtprofile_DuplicateMatchingRecord")]
    public ait_courtprofile ait_courtprofile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_courtprofileaddress_DuplicateBaseRecord")]
    public ait_courtprofileaddress ait_courtprofileaddress_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_courtprofileaddress_DuplicateMatchingRecord")]
    public ait_courtprofileaddress ait_courtprofileaddress_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_courtroom_DuplicateBaseRecord")]
    public ait_courtroom ait_courtroom_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_courtroom_DuplicateMatchingRecord")]
    public ait_courtroom ait_courtroom_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_deathrecord_DuplicateBaseRecord")]
    public ait_deathrecord ait_deathrecord_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_deathrecord_DuplicateMatchingRecord")]
    public ait_deathrecord ait_deathrecord_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_degree_DuplicateBaseRecord")]
    public ait_degree ait_degree_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_degree>(nameof (ait_degree_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_degree_DuplicateMatchingRecord")]
    public ait_degree ait_degree_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_degree>(nameof (ait_degree_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_electronicaddress_DuplicateBaseRecord")]
    public ait_electronicaddress ait_electronicaddress_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_electronicaddress_DuplicateMatchingRecord")]
    public ait_electronicaddress ait_electronicaddress_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_emergencycontact_DuplicateBaseRecord")]
    public ait_emergencycontact ait_emergencycontact_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_emergencycontact_DuplicateMatchingRecord")]
    public ait_emergencycontact ait_emergencycontact_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_familygroup_DuplicateBaseRecord")]
    public ait_familygroup ait_familygroup_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_familygroup_DuplicateMatchingRecord")]
    public ait_familygroup ait_familygroup_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_DuplicateBaseRecord")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_DuplicateMatchingRecord")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_geographicalarea_DuplicateBaseRecord")]
    public ait_geographicalarea ait_geographicalarea_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_geographicalarea_DuplicateMatchingRecord")]
    public ait_geographicalarea ait_geographicalarea_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_goal_DuplicateBaseRecord")]
    public ait_goal ait_goal_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_goal_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_goal_DuplicateMatchingRecord")]
    public ait_goal ait_goal_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_goal_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_groupactivity_DuplicateBaseRecord")]
    public ait_groupactivity ait_groupactivity_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_groupactivity_DuplicateMatchingRecord")]
    public ait_groupactivity ait_groupactivity_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_DuplicateBaseRecord")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_DuplicateMatchingRecord")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_household_DuplicateBaseRecord")]
    public ait_household ait_household_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_household_DuplicateMatchingRecord")]
    public ait_household ait_household_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_householdmember_DuplicateBaseRecord")]
    public ait_householdmember ait_householdmember_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_householdmember_DuplicateMatchingRecord")]
    public ait_householdmember ait_householdmember_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_icwaadoption_DuplicateBaseRecord")]
    public ait_icwaadoption ait_icwaadoption_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_icwaadoption_DuplicateMatchingRecord")]
    public ait_icwaadoption ait_icwaadoption_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_icwanotice_DuplicateBaseRecord")]
    public ait_icwanotice ait_icwanotice_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_icwanotice_DuplicateMatchingRecord")]
    public ait_icwanotice ait_icwanotice_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_icwaregion_DuplicateBaseRecord")]
    public ait_icwaregion ait_icwaregion_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_icwaregion_DuplicateMatchingRecord")]
    public ait_icwaregion ait_icwaregion_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_icwaregionnotification_DuplicateBaseRecord")]
    public ait_icwaregionnotification ait_icwaregionnotification_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_icwaregionnotification_DuplicateMatchingRecord")]
    public ait_icwaregionnotification ait_icwaregionnotification_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_incident_DuplicateBaseRecord")]
    public ait_incident ait_incident_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_incident_DuplicateMatchingRecord")]
    public ait_incident ait_incident_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_incidenttype_DuplicateBaseRecord")]
    public ait_incidenttype ait_incidenttype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_incidenttype_DuplicateMatchingRecord")]
    public ait_incidenttype ait_incidenttype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_DuplicateBaseRecord")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_DuplicateMatchingRecord")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_investigation_DuplicateBaseRecord")]
    public ait_investigation ait_investigation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_investigation_DuplicateMatchingRecord")]
    public ait_investigation ait_investigation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_language_DuplicateBaseRecord")]
    public ait_language ait_language_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_language_DuplicateMatchingRecord")]
    public ait_language ait_language_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_loan_DuplicateBaseRecord")]
    public ait_loan ait_loan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_loan>(nameof (ait_loan_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_loan_DuplicateMatchingRecord")]
    public ait_loan ait_loan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_loan>(nameof (ait_loan_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_loantype_DuplicateBaseRecord")]
    public ait_loantype ait_loantype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_loantype_DuplicateMatchingRecord")]
    public ait_loantype ait_loantype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_medicalproviders_DuplicateBaseRecord")]
    public ait_medicalproviders ait_medicalproviders_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_medicalproviders_DuplicateMatchingRecord")]
    public ait_medicalproviders ait_medicalproviders_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_memberprofile_DuplicateBaseRecord")]
    public ait_memberprofile ait_memberprofile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_memberprofile_DuplicateMatchingRecord")]
    public ait_memberprofile ait_memberprofile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_DuplicateBaseRecord")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_DuplicateMatchingRecord")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_memberroll_DuplicateBaseRecord")]
    public ait_memberroll ait_memberroll_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_memberroll_DuplicateMatchingRecord")]
    public ait_memberroll ait_memberroll_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_DuplicateBaseRecord")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_DuplicateMatchingRecord")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_nametype_DuplicateBaseRecord")]
    public ait_nametype ait_nametype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_nametype_DuplicateMatchingRecord")]
    public ait_nametype ait_nametype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_outcome_DuplicateBaseRecord")]
    public ait_outcome ait_outcome_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_outcome_DuplicateMatchingRecord")]
    public ait_outcome ait_outcome_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_payment_DuplicateBaseRecord")]
    public ait_payment ait_payment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_payment_DuplicateMatchingRecord")]
    public ait_payment ait_payment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_physicaladdress_DuplicateBaseRecord")]
    public ait_physicaladdress ait_physicaladdress_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_physicaladdress_DuplicateMatchingRecord")]
    public ait_physicaladdress ait_physicaladdress_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_placement_DuplicateBaseRecord")]
    public ait_placement ait_placement_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_placement_DuplicateMatchingRecord")]
    public ait_placement ait_placement_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_placementlocation_DuplicateBaseRecord")]
    public ait_placementlocation ait_placementlocation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_placementlocation_DuplicateMatchingRecord")]
    public ait_placementlocation ait_placementlocation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_planactivity_DuplicateBaseRecord")]
    public ait_planactivity ait_planactivity_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_planactivity_DuplicateMatchingRecord")]
    public ait_planactivity ait_planactivity_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_referral_DuplicateBaseRecord")]
    public ait_referral ait_referral_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_referral_DuplicateMatchingRecord")]
    public ait_referral ait_referral_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_relationship_DuplicateBaseRecord")]
    public ait_relationship ait_relationship_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_relationship_DuplicateMatchingRecord")]
    public ait_relationship ait_relationship_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_reservation_DuplicateBaseRecord")]
    public ait_reservation ait_reservation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_reservation_DuplicateMatchingRecord")]
    public ait_reservation ait_reservation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_resolution_DuplicateBaseRecord")]
    public ait_resolution ait_resolution_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_resolution_DuplicateMatchingRecord")]
    public ait_resolution ait_resolution_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_roll_DuplicateBaseRecord")]
    public ait_roll ait_roll_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_roll>(nameof (ait_roll_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_roll_DuplicateMatchingRecord")]
    public ait_roll ait_roll_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_roll>(nameof (ait_roll_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_safetyplan_DuplicateBaseRecord")]
    public ait_safetyplan ait_safetyplan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_safetyplan_DuplicateMatchingRecord")]
    public ait_safetyplan ait_safetyplan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_school_DuplicateBaseRecord")]
    public ait_school ait_school_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_school>(nameof (ait_school_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_school_DuplicateMatchingRecord")]
    public ait_school ait_school_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_school>(nameof (ait_school_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_schooltype_DuplicateBaseRecord")]
    public ait_schooltype ait_schooltype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_schooltype_DuplicateMatchingRecord")]
    public ait_schooltype ait_schooltype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_servicerequest_DuplicateBaseRecord")]
    public ait_servicerequest ait_servicerequest_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_servicerequest_DuplicateMatchingRecord")]
    public ait_servicerequest ait_servicerequest_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_skill_DuplicateBaseRecord")]
    public ait_skill ait_skill_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_skill>(nameof (ait_skill_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_skill_DuplicateMatchingRecord")]
    public ait_skill ait_skill_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_skill>(nameof (ait_skill_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_stateprovince_DuplicateBaseRecord")]
    public ait_stateprovince ait_stateprovince_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_stateprovince_DuplicateMatchingRecord")]
    public ait_stateprovince ait_stateprovince_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_statute_DuplicateBaseRecord")]
    public ait_statute ait_statute_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_statute_DuplicateMatchingRecord")]
    public ait_statute ait_statute_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_training_DuplicateBaseRecord")]
    public ait_training ait_training_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_training_DuplicateMatchingRecord")]
    public ait_training ait_training_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_trainingtype_DuplicateBaseRecord")]
    public ait_trainingtype ait_trainingtype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_trainingtype_DuplicateMatchingRecord")]
    public ait_trainingtype ait_trainingtype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_DuplicateBaseRecord")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_DuplicateMatchingRecord")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_tribe_DuplicateBaseRecord")]
    public ait_tribe ait_tribe_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_tribe_DuplicateMatchingRecord")]
    public ait_tribe ait_tribe_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("ait_withholdingtype_DuplicateBaseRecord")]
    public ait_withholdingtype ait_withholdingtype_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("ait_withholdingtype_DuplicateMatchingRecord")]
    public ait_withholdingtype ait_withholdingtype_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("apisettings_DuplicateBaseRecord")]
    public apisettings apisettings_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<apisettings>(nameof (apisettings_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("apisettings_DuplicateMatchingRecord")]
    public apisettings apisettings_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<apisettings>(nameof (apisettings_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("applicationuser_DuplicateBaseRecord")]
    public ApplicationUser applicationuser_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("applicationuser_DuplicateMatchingRecord")]
    public ApplicationUser applicationuser_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Appointment_DuplicateBaseRecord")]
    public Appointment Appointment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (Appointment_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Appointment_DuplicateMatchingRecord")]
    public Appointment Appointment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (Appointment_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("AsyncOperation_DuplicateBaseRecord")]
    public AsyncOperation AsyncOperation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>(nameof (AsyncOperation_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("canvasappextendedmetadata_DuplicateBaseRecord")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("canvasappextendedmetadata_DuplicateMatchingRecord")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("catalogassignment_DuplicateBaseRecord")]
    public CatalogAssignment catalogassignment_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("catalogassignment_DuplicateMatchingRecord")]
    public CatalogAssignment catalogassignment_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("channelaccessprofile_DuplicateBaseRecord")]
    public ChannelAccessProfile channelaccessprofile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("channelaccessprofile_DuplicateMatchingRecord")]
    public ChannelAccessProfile channelaccessprofile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("connector_DuplicateBaseRecord")]
    public connector connector_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<connector>(nameof (connector_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("connector_DuplicateMatchingRecord")]
    public connector connector_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<connector>(nameof (connector_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Contact_DuplicateBaseRecord")]
    public Contact Contact_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (Contact_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Contact_DuplicateMatchingRecord")]
    public Contact Contact_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (Contact_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("conversationtranscript_DuplicateBaseRecord")]
    public conversationtranscript conversationtranscript_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("conversationtranscript_DuplicateMatchingRecord")]
    public conversationtranscript conversationtranscript_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("datalakefolder_DuplicateBaseRecord")]
    public datalakefolder datalakefolder_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("datalakefolder_DuplicateMatchingRecord")]
    public datalakefolder datalakefolder_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("datalakefolderpermission_DuplicateBaseRecord")]
    public datalakefolderpermission datalakefolderpermission_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("datalakefolderpermission_DuplicateMatchingRecord")]
    public datalakefolderpermission datalakefolderpermission_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("datalakeworkspace_DuplicateBaseRecord")]
    public datalakeworkspace datalakeworkspace_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("datalakeworkspace_DuplicateMatchingRecord")]
    public datalakeworkspace datalakeworkspace_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("datalakeworkspacepermission_DuplicateBaseRecord")]
    public datalakeworkspacepermission datalakeworkspacepermission_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("datalakeworkspacepermission_DuplicateMatchingRecord")]
    public datalakeworkspacepermission datalakeworkspacepermission_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicateruleid")]
    [RelationshipSchemaName("DuplicateRule_DuplicateBaseRecord")]
    public DuplicateRule DuplicateRule_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<DuplicateRule>(nameof (DuplicateRule_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Email_DuplicateBaseRecord")]
    public Email Email_DuplicateBaseRecord
    {
      get => this.GetRelatedEntity<Email>(nameof (Email_DuplicateBaseRecord), new EntityRole?());
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Email_DuplicateMatchingRecord")]
    public Email Email_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<Email>(nameof (Email_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("emailserverprofile_duplicatebaserecord")]
    public EmailServerProfile emailserverprofile_duplicatebaserecord
    {
      get
      {
        return this.GetRelatedEntity<EmailServerProfile>(nameof (emailserverprofile_duplicatebaserecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("emailserverprofile_duplicatematchingrecord")]
    public EmailServerProfile emailserverprofile_duplicatematchingrecord
    {
      get
      {
        return this.GetRelatedEntity<EmailServerProfile>(nameof (emailserverprofile_duplicatematchingrecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("environmentvariabledefinition_DuplicateBaseRecord")]
    public EnvironmentVariableDefinition environmentvariabledefinition_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("environmentvariabledefinition_DuplicateMatchingRecord")]
    public EnvironmentVariableDefinition environmentvariabledefinition_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("environmentvariablevalue_DuplicateBaseRecord")]
    public EnvironmentVariableValue environmentvariablevalue_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("environmentvariablevalue_DuplicateMatchingRecord")]
    public EnvironmentVariableValue environmentvariablevalue_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("exportsolutionupload_DuplicateBaseRecord")]
    public ExportSolutionUpload exportsolutionupload_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("exportsolutionupload_DuplicateMatchingRecord")]
    public ExportSolutionUpload exportsolutionupload_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Fax_DuplicateBaseRecord")]
    public Fax Fax_DuplicateBaseRecord
    {
      get => this.GetRelatedEntity<Fax>(nameof (Fax_DuplicateBaseRecord), new EntityRole?());
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Fax_DuplicateMatchingRecord")]
    public Fax Fax_DuplicateMatchingRecord
    {
      get => this.GetRelatedEntity<Fax>(nameof (Fax_DuplicateMatchingRecord), new EntityRole?());
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("feedback_DuplicateBaseRecord")]
    public Feedback feedback_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<Feedback>(nameof (feedback_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("feedback_DuplicateMatchingRecord")]
    public Feedback feedback_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<Feedback>(nameof (feedback_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Goal_DuplicateBaseRecord")]
    public Goal Goal_DuplicateBaseRecord
    {
      get => this.GetRelatedEntity<Goal>(nameof (Goal_DuplicateBaseRecord), new EntityRole?());
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Goal_DuplicateMatchingRecord")]
    public Goal Goal_DuplicateMatchingRecord
    {
      get => this.GetRelatedEntity<Goal>(nameof (Goal_DuplicateMatchingRecord), new EntityRole?());
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("GoalRollupQuery_DuplicateBaseRecord")]
    public GoalRollupQuery GoalRollupQuery_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<GoalRollupQuery>(nameof (GoalRollupQuery_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("GoalRollupQuery_DuplicateMatchingRecord")]
    public GoalRollupQuery GoalRollupQuery_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<GoalRollupQuery>(nameof (GoalRollupQuery_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("KbArticle_DuplicateBaseRecord")]
    public KbArticle KbArticle_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (KbArticle_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("KbArticle_DuplicateMatchingRecord")]
    public KbArticle KbArticle_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (KbArticle_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("knowledgearticle_DuplicateBaseRecord")]
    public KnowledgeArticle knowledgearticle_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("knowledgearticle_DuplicateMatchingRecord")]
    public KnowledgeArticle knowledgearticle_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_DuplicateBaseRecord")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_DuplicateMatchingRecord")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Letter_DuplicateBaseRecord")]
    public Letter Letter_DuplicateBaseRecord
    {
      get => this.GetRelatedEntity<Letter>(nameof (Letter_DuplicateBaseRecord), new EntityRole?());
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Letter_DuplicateMatchingRecord")]
    public Letter Letter_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<Letter>(nameof (Letter_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aibdataset_DuplicateBaseRecord")]
    public msdyn_AIBDataset msdyn_aibdataset_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aibdataset_DuplicateMatchingRecord")]
    public msdyn_AIBDataset msdyn_aibdataset_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_DuplicateBaseRecord")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_DuplicateMatchingRecord")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_DuplicateBaseRecord")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_DuplicateMatchingRecord")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_DuplicateBaseRecord")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_DuplicateMatchingRecord")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aibfile_DuplicateBaseRecord")]
    public msdyn_AIBFile msdyn_aibfile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aibfile_DuplicateMatchingRecord")]
    public msdyn_AIBFile msdyn_aibfile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_DuplicateBaseRecord")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_DuplicateMatchingRecord")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aiodimage_DuplicateBaseRecord")]
    public msdyn_AIOdImage msdyn_aiodimage_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aiodimage_DuplicateMatchingRecord")]
    public msdyn_AIOdImage msdyn_aiodimage_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aiodlabel_DuplicateBaseRecord")]
    public msdyn_AIOdLabel msdyn_aiodlabel_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aiodlabel_DuplicateMatchingRecord")]
    public msdyn_AIOdLabel msdyn_aiodlabel_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_DuplicateBaseRecord")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_DuplicateBaseRecord")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_DuplicateMatchingRecord")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_DuplicateBaseRecord")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_DuplicateMatchingRecord")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_analysisjob_DuplicateBaseRecord")]
    public msdyn_analysisjob msdyn_analysisjob_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_analysisjob_DuplicateMatchingRecord")]
    public msdyn_analysisjob msdyn_analysisjob_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_analysisresult_DuplicateBaseRecord")]
    public msdyn_analysisresult msdyn_analysisresult_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_analysisresult_DuplicateMatchingRecord")]
    public msdyn_analysisresult msdyn_analysisresult_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_DuplicateBaseRecord")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_DuplicateMatchingRecord")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_dataflow_DuplicateBaseRecord")]
    public msdyn_dataflow msdyn_dataflow_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_dataflow_DuplicateMatchingRecord")]
    public msdyn_dataflow msdyn_dataflow_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_federatedarticle_DuplicateBaseRecord")]
    public msdyn_federatedarticle msdyn_federatedarticle_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_federatedarticle_DuplicateMatchingRecord")]
    public msdyn_federatedarticle msdyn_federatedarticle_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_DuplicateBaseRecord")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_DuplicateMatchingRecord")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_DuplicateBaseRecord")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_DuplicateBaseRecord")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_DuplicateMatchingRecord")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_DuplicateBaseRecord")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_DuplicateMatchingRecord")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_DuplicateBaseRecord")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_DuplicateBaseRecord")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_DuplicateMatchingRecord")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_DuplicateBaseRecord")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_DuplicateMatchingRecord")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_slakpi_DuplicateBaseRecord")]
    public msdyn_slakpi msdyn_slakpi_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_slakpi_DuplicateMatchingRecord")]
    public msdyn_slakpi msdyn_slakpi_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_DuplicateBaseRecord")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_DuplicateMatchingRecord")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_DuplicateBaseRecord")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_DuplicateMatchingRecord")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_DuplicateBaseRecord")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_DuplicateMatchingRecord")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("package_DuplicateBaseRecord")]
    public package package_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<package>(nameof (package_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("package_DuplicateMatchingRecord")]
    public package package_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<package>(nameof (package_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("PhoneCall_DuplicateBaseRecord")]
    public PhoneCall PhoneCall_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (PhoneCall_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("PhoneCall_DuplicateMatchingRecord")]
    public PhoneCall PhoneCall_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (PhoneCall_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Publisher_DuplicateBaseRecord")]
    public Publisher Publisher_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<Publisher>(nameof (Publisher_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Publisher_DuplicateMatchingRecord")]
    public Publisher Publisher_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<Publisher>(nameof (Publisher_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Queue_DuplicateBaseRecord")]
    public Queue Queue_DuplicateBaseRecord
    {
      get => this.GetRelatedEntity<Queue>(nameof (Queue_DuplicateBaseRecord), new EntityRole?());
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Queue_DuplicateMatchingRecord")]
    public Queue Queue_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<Queue>(nameof (Queue_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("RecurringAppointmentMaster_DuplicateBaseRecord")]
    public RecurringAppointmentMaster RecurringAppointmentMaster_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("RecurringAppointmentMaster_DuplicateMatchingRecord")]
    public RecurringAppointmentMaster RecurringAppointmentMaster_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_DuplicateBaseRecord")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_DuplicateMatchingRecord")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("serviceplan_DuplicateBaseRecord")]
    public ServicePlan serviceplan_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("serviceplan_DuplicateMatchingRecord")]
    public ServicePlan serviceplan_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("SharePointDocumentLocation_DuplicateBaseRecord")]
    public SharePointDocumentLocation SharePointDocumentLocation_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>(nameof (SharePointDocumentLocation_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("SharePointDocumentLocation_DuplicateMatchingRecord")]
    public SharePointDocumentLocation SharePointDocumentLocation_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>(nameof (SharePointDocumentLocation_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("SharePointSite_DuplicateBaseRecord")]
    public SharePointSite SharePointSite_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>(nameof (SharePointSite_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("SharePointSite_DuplicateMatchingRecord")]
    public SharePointSite SharePointSite_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>(nameof (SharePointSite_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("SocialActivity_DuplicateBaseRecord")]
    public SocialActivity SocialActivity_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (SocialActivity_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("SocialActivity_DuplicateMatchingRecord")]
    public SocialActivity SocialActivity_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (SocialActivity_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("SocialProfile_DuplicateBaseRecord")]
    public SocialProfile SocialProfile_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (SocialProfile_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("SocialProfile_DuplicateMatchingRecord")]
    public SocialProfile SocialProfile_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (SocialProfile_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_DuplicateBaseRecord")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_DuplicateMatchingRecord")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_DuplicateBaseRecord")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_DuplicateMatchingRecord")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_DuplicateBaseRecord")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("stagesolutionupload_DuplicateBaseRecord")]
    public StageSolutionUpload stagesolutionupload_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("stagesolutionupload_DuplicateMatchingRecord")]
    public StageSolutionUpload stagesolutionupload_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("SystemUser_DuplicateBaseRecord")]
    public SystemUser SystemUser_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (SystemUser_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("SystemUser_DuplicateMatchingRecord")]
    public SystemUser SystemUser_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (SystemUser_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Task_DuplicateBaseRecord")]
    public Task Task_DuplicateBaseRecord
    {
      get => this.GetRelatedEntity<Task>(nameof (Task_DuplicateBaseRecord), new EntityRole?());
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Task_DuplicateMatchingRecord")]
    public Task Task_DuplicateMatchingRecord
    {
      get => this.GetRelatedEntity<Task>(nameof (Task_DuplicateMatchingRecord), new EntityRole?());
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("Team_DuplicateBaseRecord")]
    public Team Team_DuplicateBaseRecord
    {
      get => this.GetRelatedEntity<Team>(nameof (Team_DuplicateBaseRecord), new EntityRole?());
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("Team_DuplicateMatchingRecord")]
    public Team Team_DuplicateMatchingRecord
    {
      get => this.GetRelatedEntity<Team>(nameof (Team_DuplicateMatchingRecord), new EntityRole?());
    }

    [AttributeLogicalName("baserecordid")]
    [RelationshipSchemaName("TransactionCurrency_DuplicateBaseRecord")]
    public TransactionCurrency TransactionCurrency_DuplicateBaseRecord
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_DuplicateBaseRecord), new EntityRole?());
      }
    }

    [AttributeLogicalName("duplicaterecordid")]
    [RelationshipSchemaName("TransactionCurrency_DuplicateMatchingRecord")]
    public TransactionCurrency TransactionCurrency_DuplicateMatchingRecord
    {
      get
      {
        return this.GetRelatedEntity<TransactionCurrency>(nameof (TransactionCurrency_DuplicateMatchingRecord), new EntityRole?());
      }
    }

    public DuplicateRecord(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["duplicateid"] = (object) base.Id;
            break;
          case "duplicateid":
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
