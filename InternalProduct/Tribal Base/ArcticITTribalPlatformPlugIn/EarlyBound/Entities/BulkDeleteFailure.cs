// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.BulkDeleteFailure
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("bulkdeletefailure")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class BulkDeleteFailure : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "bulkdeletefailure";
    public const string EntitySchemaName = "BulkDeleteFailure";
    public const string PrimaryIdAttribute = "bulkdeletefailureid";

    public BulkDeleteFailure()
      : base("bulkdeletefailure")
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

    [AttributeLogicalName("bulkdeletefailureid")]
    public Guid? BulkDeleteFailureId => this.GetAttributeValue<Guid?>("bulkdeletefailureid");

    [AttributeLogicalName("bulkdeletefailureid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
    }

    [AttributeLogicalName("bulkdeleteoperationid")]
    public EntityReference BulkDeleteOperationId
    {
      get => this.GetAttributeValue<EntityReference>("bulkdeleteoperationid");
    }

    [AttributeLogicalName("errordescription")]
    public string ErrorDescription => this.GetAttributeValue<string>("errordescription");

    [AttributeLogicalName("errornumber")]
    public int? ErrorNumber => this.GetAttributeValue<int?>("errornumber");

    [AttributeLogicalName("orderedqueryindex")]
    public int? OrderedQueryIndex => this.GetAttributeValue<int?>("orderedqueryindex");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public Guid? OwningBusinessUnit => this.GetAttributeValue<Guid?>("owningbusinessunit");

    [AttributeLogicalName("owninguser")]
    public Guid? OwningUser => this.GetAttributeValue<Guid?>("owninguser");

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
    }

    [RelationshipSchemaName("userentityinstancedata_bulkdeletefailure")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkdeletefailure
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_bulkdeletefailure), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_bulkdeletefailure));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_bulkdeletefailure), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_bulkdeletefailure));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_BulkDeleteFailures")]
    public Account Account_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Account>(nameof (Account_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ActivityMimeAttachment_BulkDeleteFailures")]
    public ActivityMimeAttachment ActivityMimeAttachment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ActivityMimeAttachment>(nameof (ActivityMimeAttachment_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ActivityPointer_BulkDeleteFailures")]
    public ActivityPointer ActivityPointer_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ActivityPointer>(nameof (ActivityPointer_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_accountingcode_BulkDeleteFailures")]
    public ait_accountingcode ait_accountingcode_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_addresstype_BulkDeleteFailures")]
    public ait_addresstype ait_addresstype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_assessment_BulkDeleteFailures")]
    public ait_assessment ait_assessment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_autonumber_BulkDeleteFailures")]
    public ait_autonumber ait_autonumber_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_band_BulkDeleteFailures")]
    public ait_band ait_band_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_band>(nameof (ait_band_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccount_BulkDeleteFailures")]
    public ait_bankaccount ait_bankaccount_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bankaccounttype_BulkDeleteFailures")]
    public ait_bankaccounttype ait_bankaccounttype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_birthrecord_BulkDeleteFailures")]
    public ait_birthrecord ait_birthrecord_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_bloodquantum_BulkDeleteFailures")]
    public ait_bloodquantum ait_bloodquantum_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformat_BulkDeleteFailures")]
    public ait_cardformat ait_cardformat_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardformatdetail_BulkDeleteFailures")]
    public ait_cardformatdetail ait_cardformatdetail_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cardhistory_BulkDeleteFailures")]
    public ait_cardhistory ait_cardhistory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_case_BulkDeleteFailures")]
    public ait_case ait_case_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_casenote_BulkDeleteFailures")]
    public ait_casenote ait_casenote_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_caseplan_BulkDeleteFailures")]
    public ait_caseplan ait_caseplan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_causeofdeath_BulkDeleteFailures")]
    public ait_causeofdeath ait_causeofdeath_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_cemetary_BulkDeleteFailures")]
    public ait_cemetary ait_cemetary_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_certification_BulkDeleteFailures")]
    public ait_certification ait_certification_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequest_BulkDeleteFailures")]
    public ait_changerequest ait_changerequest_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_changerequesttype_BulkDeleteFailures")]
    public ait_changerequesttype ait_changerequesttype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_charge_BulkDeleteFailures")]
    public ait_charge ait_charge_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_charge>(nameof (ait_charge_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_childvisitations_BulkDeleteFailures")]
    public ait_childvisitations ait_childvisitations_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_city_BulkDeleteFailures")]
    public ait_city ait_city_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_city_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clan_BulkDeleteFailures")]
    public ait_clan ait_clan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_clan>(nameof (ait_clan_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_clientprofile_BulkDeleteFailures")]
    public ait_clientprofile ait_clientprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committee_BulkDeleteFailures")]
    public ait_committee ait_committee_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemeeting_BulkDeleteFailures")]
    public ait_committeemeeting ait_committeemeeting_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeemember_BulkDeleteFailures")]
    public ait_committeemember ait_committeemember_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeeposition_BulkDeleteFailures")]
    public ait_committeeposition ait_committeeposition_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_committeepositiontype_BulkDeleteFailures")]
    public ait_committeepositiontype ait_committeepositiontype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_company_BulkDeleteFailures")]
    public ait_company ait_company_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactcertification_BulkDeleteFailures")]
    public ait_contactcertification ait_contactcertification_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contacteducation_BulkDeleteFailures")]
    public ait_contacteducation ait_contacteducation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactemployment_BulkDeleteFailures")]
    public ait_contactemployment ait_contactemployment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactimage_BulkDeleteFailures")]
    public ait_contactimage ait_contactimage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincarceration_BulkDeleteFailures")]
    public ait_contactincarceration ait_contactincarceration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_BulkDeleteFailures")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactlanguage_BulkDeleteFailures")]
    public ait_contactlanguage ait_contactlanguage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_BulkDeleteFailures")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactname_BulkDeleteFailures")]
    public ait_contactname ait_contactname_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_contactskill_BulkDeleteFailures")]
    public ait_contactskill ait_contactskill_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_countryregion_BulkDeleteFailures")]
    public ait_countryregion ait_countryregion_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_county_BulkDeleteFailures")]
    public ait_county ait_county_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_county>(nameof (ait_county_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtcase_BulkDeleteFailures")]
    public ait_courtcase ait_courtcase_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtfinesandfees_BulkDeleteFailures")]
    public ait_courtfinesandfees ait_courtfinesandfees_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtparty_BulkDeleteFailures")]
    public ait_courtparty ait_courtparty_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtpayments_BulkDeleteFailures")]
    public ait_courtpayments ait_courtpayments_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofile_BulkDeleteFailures")]
    public ait_courtprofile ait_courtprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtprofileaddress_BulkDeleteFailures")]
    public ait_courtprofileaddress ait_courtprofileaddress_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_courtroom_BulkDeleteFailures")]
    public ait_courtroom ait_courtroom_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_datamigrationhistory_BulkDeleteFailures")]
    public ait_datamigrationhistory ait_datamigrationhistory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_deathrecord_BulkDeleteFailures")]
    public ait_deathrecord ait_deathrecord_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_degree_BulkDeleteFailures")]
    public ait_degree ait_degree_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_degree>(nameof (ait_degree_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_electronicaddress_BulkDeleteFailures")]
    public ait_electronicaddress ait_electronicaddress_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_emergencycontact_BulkDeleteFailures")]
    public ait_emergencycontact ait_emergencycontact_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familygroup_BulkDeleteFailures")]
    public ait_familygroup ait_familygroup_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_BulkDeleteFailures")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_geographicalarea_BulkDeleteFailures")]
    public ait_geographicalarea ait_geographicalarea_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_goal_BulkDeleteFailures")]
    public ait_goal ait_goal_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_goal_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivity_BulkDeleteFailures")]
    public ait_groupactivity ait_groupactivity_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_BulkDeleteFailures")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_household_BulkDeleteFailures")]
    public ait_household ait_household_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_householdmember_BulkDeleteFailures")]
    public ait_householdmember ait_householdmember_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaadoption_BulkDeleteFailures")]
    public ait_icwaadoption ait_icwaadoption_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwanotice_BulkDeleteFailures")]
    public ait_icwanotice ait_icwanotice_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregion_BulkDeleteFailures")]
    public ait_icwaregion ait_icwaregion_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_icwaregionnotification_BulkDeleteFailures")]
    public ait_icwaregionnotification ait_icwaregionnotification_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incident_BulkDeleteFailures")]
    public ait_incident ait_incident_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incidenttype_BulkDeleteFailures")]
    public ait_incidenttype ait_incidenttype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_BulkDeleteFailures")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_investigation_BulkDeleteFailures")]
    public ait_investigation ait_investigation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_language_BulkDeleteFailures")]
    public ait_language ait_language_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_languageproficiencylevel_BulkDeleteFailures")]
    public ait_languageproficiencylevel ait_languageproficiencylevel_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loan_BulkDeleteFailures")]
    public ait_loan ait_loan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_loan>(nameof (ait_loan_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loandetail_BulkDeleteFailures")]
    public ait_loandetail ait_loandetail_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_loantype_BulkDeleteFailures")]
    public ait_loantype ait_loantype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_medicalproviders_BulkDeleteFailures")]
    public ait_medicalproviders ait_medicalproviders_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofile_BulkDeleteFailures")]
    public ait_memberprofile ait_memberprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_BulkDeleteFailures")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_memberroll_BulkDeleteFailures")]
    public ait_memberroll ait_memberroll_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipcategory_BulkDeleteFailures")]
    public ait_membershipcategory ait_membershipcategory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_BulkDeleteFailures")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_nametype_BulkDeleteFailures")]
    public ait_nametype ait_nametype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_outcome_BulkDeleteFailures")]
    public ait_outcome ait_outcome_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_payment_BulkDeleteFailures")]
    public ait_payment ait_payment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_physicaladdress_BulkDeleteFailures")]
    public ait_physicaladdress ait_physicaladdress_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placement_BulkDeleteFailures")]
    public ait_placement ait_placement_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_placementlocation_BulkDeleteFailures")]
    public ait_placementlocation ait_placementlocation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_planactivity_BulkDeleteFailures")]
    public ait_planactivity ait_planactivity_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmteligibility_BulkDeleteFailures")]
    public ait_pmteligibility ait_pmteligibility_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtevent_BulkDeleteFailures")]
    public ait_pmtevent ait_pmtevent_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtpaymenttype_BulkDeleteFailures")]
    public ait_pmtpaymenttype ait_pmtpaymenttype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransaction_BulkDeleteFailures")]
    public ait_pmttransaction ait_pmttransaction_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmttransactiondeduction_BulkDeleteFailures")]
    public ait_pmttransactiondeduction ait_pmttransactiondeduction_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholding_BulkDeleteFailures")]
    public ait_pmtwithholding ait_pmtwithholding_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_pmtwithholdingoverride_BulkDeleteFailures")]
    public ait_pmtwithholdingoverride ait_pmtwithholdingoverride_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_program_BulkDeleteFailures")]
    public ait_program ait_program_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_referral_BulkDeleteFailures")]
    public ait_referral ait_referral_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_relationship_BulkDeleteFailures")]
    public ait_relationship ait_relationship_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_reservation_BulkDeleteFailures")]
    public ait_reservation ait_reservation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_resolution_BulkDeleteFailures")]
    public ait_resolution ait_resolution_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_roll_BulkDeleteFailures")]
    public ait_roll ait_roll_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_roll>(nameof (ait_roll_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_safetyplan_BulkDeleteFailures")]
    public ait_safetyplan ait_safetyplan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_school_BulkDeleteFailures")]
    public ait_school ait_school_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_school>(nameof (ait_school_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_schooltype_BulkDeleteFailures")]
    public ait_schooltype ait_schooltype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_servicerequest_BulkDeleteFailures")]
    public ait_servicerequest ait_servicerequest_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_skill_BulkDeleteFailures")]
    public ait_skill ait_skill_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_skill>(nameof (ait_skill_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_stateprovince_BulkDeleteFailures")]
    public ait_stateprovince ait_stateprovince_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_statute_BulkDeleteFailures")]
    public ait_statute ait_statute_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_training_BulkDeleteFailures")]
    public ait_training ait_training_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_trainingtype_BulkDeleteFailures")]
    public ait_trainingtype ait_trainingtype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_BulkDeleteFailures")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_tribe_BulkDeleteFailures")]
    public ait_tribe ait_tribe_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_withholdingtype_BulkDeleteFailures")]
    public ait_withholdingtype ait_withholdingtype_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ait_zipcodecity_BulkDeleteFailures")]
    public ait_zipcodecity ait_zipcodecity_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Annotation_BulkDeleteFailures")]
    public Annotation Annotation_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<Annotation>(nameof (Annotation_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("AnnualFiscalCalendar_BulkDeleteFailures")]
    public AnnualFiscalCalendar AnnualFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<AnnualFiscalCalendar>(nameof (AnnualFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("apisettings_BulkDeleteFailures")]
    public apisettings apisettings_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<apisettings>(nameof (apisettings_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appelement_BulkDeleteFailures")]
    public AppElement appelement_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<AppElement>(nameof (appelement_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("applicationuser_BulkDeleteFailures")]
    public ApplicationUser applicationuser_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentedge_BulkDeleteFailures")]
    public AppModuleComponentEdge appmodulecomponentedge_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appmodulecomponentnode_BulkDeleteFailures")]
    public AppModuleComponentNode appmodulecomponentnode_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Appointment_BulkDeleteFailures")]
    public Appointment Appointment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (Appointment_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("appsetting_BulkDeleteFailures")]
    public AppSetting appsetting_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<AppSetting>(nameof (appsetting_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("attributeimageconfig_BulkDeleteFailures")]
    public AttributeImageConfig attributeimageconfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("AttributeMap_BulkDeleteFailures")]
    public AttributeMap AttributeMap_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<AttributeMap>(nameof (AttributeMap_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("bot_BulkDeleteFailures")]
    public bot bot_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<bot>(nameof (bot_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("botcomponent_BulkDeleteFailures")]
    public botcomponent botcomponent_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<botcomponent>(nameof (botcomponent_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("bulkdeleteoperationid")]
    [RelationshipSchemaName("BulkDeleteOperation_BulkDeleteFailure")]
    public BulkDeleteOperation BulkDeleteOperation_BulkDeleteFailure
    {
      get
      {
        return this.GetRelatedEntity<BulkDeleteOperation>(nameof (BulkDeleteOperation_BulkDeleteFailure), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("BusinessUnit_BulkDeleteFailures")]
    public BusinessUnit BusinessUnit_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BusinessUnit_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("BusinessUnitNewsArticle_BulkDeleteFailures")]
    public BusinessUnitNewsArticle BusinessUnitNewsArticle_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnitNewsArticle>(nameof (BusinessUnitNewsArticle_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Calendar_BulkDeleteFailures")]
    public Calendar Calendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<Calendar>(nameof (Calendar_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("canvasappextendedmetadata_BulkDeleteFailures")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalog_BulkDeleteFailures")]
    public Catalog catalog_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Catalog>(nameof (catalog_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("catalogassignment_BulkDeleteFailures")]
    public CatalogAssignment catalogassignment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("channelaccessprofile_BulkDeleteFailures")]
    public ChannelAccessProfile channelaccessprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connectionreference_BulkDeleteFailures")]
    public connectionreference connectionreference_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<connectionreference>(nameof (connectionreference_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("connector_BulkDeleteFailures")]
    public connector connector_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<connector>(nameof (connector_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_BulkDeleteFailures")]
    public Contact Contact_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Contact>(nameof (Contact_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("conversationtranscript_BulkDeleteFailures")]
    public conversationtranscript conversationtranscript_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("customapi_BulkDeleteFailures")]
    public CustomAPI customapi_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<CustomAPI>(nameof (customapi_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("CustomerAddress_BulkDeleteFailures")]
    public CustomerAddress CustomerAddress_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<CustomerAddress>(nameof (CustomerAddress_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("CustomerRelationship_BulkDeleteFailures")]
    public CustomerRelationship CustomerRelationship_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<CustomerRelationship>(nameof (CustomerRelationship_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolder_BulkDeleteFailures")]
    public datalakefolder datalakefolder_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakefolderpermission_BulkDeleteFailures")]
    public datalakefolderpermission datalakefolderpermission_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspace_BulkDeleteFailures")]
    public datalakeworkspace datalakeworkspace_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("datalakeworkspacepermission_BulkDeleteFailures")]
    public datalakeworkspacepermission datalakeworkspacepermission_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("DisplayString_BulkDeleteFailures")]
    public DisplayString DisplayString_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<DisplayString>(nameof (DisplayString_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Email_BulkDeleteFailures")]
    public Email Email_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Email>(nameof (Email_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("emailserverprofile_bulkdeletefailures")]
    public EmailServerProfile emailserverprofile_bulkdeletefailures
    {
      get
      {
        return this.GetRelatedEntity<EmailServerProfile>(nameof (emailserverprofile_bulkdeletefailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("entityanalyticsconfig_BulkDeleteFailures")]
    public EntityAnalyticsConfig entityanalyticsconfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("entityimageconfig_BulkDeleteFailures")]
    public EntityImageConfig entityimageconfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("EntityMap_BulkDeleteFailures")]
    public EntityMap EntityMap_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<EntityMap>(nameof (EntityMap_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariabledefinition_BulkDeleteFailures")]
    public EnvironmentVariableDefinition environmentvariabledefinition_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("environmentvariablevalue_BulkDeleteFailures")]
    public EnvironmentVariableValue environmentvariablevalue_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("exportsolutionupload_BulkDeleteFailures")]
    public ExportSolutionUpload exportsolutionupload_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("externalparty_BulkDeleteFailures")]
    public ExternalParty externalparty_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ExternalParty>(nameof (externalparty_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("externalpartyitem_BulkDeleteFailures")]
    public ExternalPartyItem externalpartyitem_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ExternalPartyItem>(nameof (externalpartyitem_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Fax_BulkDeleteFailures")]
    public Fax Fax_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Fax>(nameof (Fax_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
    public FixedMonthlyFiscalCalendar FixedMonthlyFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<FixedMonthlyFiscalCalendar>(nameof (FixedMonthlyFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("flowsession_BulkDeleteFailures")]
    public flowsession flowsession_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<flowsession>(nameof (flowsession_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("holidaywrapper_BulkDeleteFailures")]
    public holidaywrapper holidaywrapper_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Import_BulkDeleteFailures")]
    public Import Import_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Import>(nameof (Import_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ImportFile_BulkDeleteFailures")]
    public ImportFile ImportFile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ImportFile>(nameof (ImportFile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ImportLog_BulkDeleteFailures")]
    public ImportLog ImportLog_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ImportLog>(nameof (ImportLog_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("ImportMap_BulkDeleteFailures")]
    public ImportMap ImportMap_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ImportMap>(nameof (ImportMap_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("internalcatalogassignment_BulkDeleteFailures")]
    public InternalCatalogAssignment internalcatalogassignment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("IsvConfig_BulkDeleteFailures")]
    public IsvConfig IsvConfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<IsvConfig>(nameof (IsvConfig_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticle_BulkDeleteFailures")]
    public KbArticle KbArticle_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (KbArticle_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticleComment_BulkDeleteFailures")]
    public KbArticleComment KbArticleComment_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<KbArticleComment>(nameof (KbArticleComment_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KbArticleTemplate_BulkDeleteFailures")]
    public KbArticleTemplate KbArticleTemplate_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<KbArticleTemplate>(nameof (KbArticleTemplate_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("knowledgearticle_BulkDeleteFailures")]
    public KnowledgeArticle knowledgearticle_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_BulkDeleteFailures")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Letter_BulkDeleteFailures")]
    public Letter Letter_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Letter>(nameof (Letter_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("mbs_pluginprofile_BulkDeleteFailures")]
    public mbs_pluginprofile mbs_pluginprofile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("MonthlyFiscalCalendar_BulkDeleteFailures")]
    public MonthlyFiscalCalendar MonthlyFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<MonthlyFiscalCalendar>(nameof (MonthlyFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdataset_BulkDeleteFailures")]
    public msdyn_AIBDataset msdyn_aibdataset_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_BulkDeleteFailures")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_BulkDeleteFailures")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_BulkDeleteFailures")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfile_BulkDeleteFailures")]
    public msdyn_AIBFile msdyn_aibfile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_BulkDeleteFailures")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiconfiguration_BulkDeleteFailures")]
    public msdyn_AIConfiguration msdyn_aiconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aifptrainingdocument_BulkDeleteFailures")]
    public msdyn_AIFpTrainingDocument msdyn_aifptrainingdocument_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aimodel_BulkDeleteFailures")]
    public msdyn_AIModel msdyn_aimodel_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodimage_BulkDeleteFailures")]
    public msdyn_AIOdImage msdyn_aiodimage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodlabel_BulkDeleteFailures")]
    public msdyn_AIOdLabel msdyn_aiodlabel_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_BulkDeleteFailures")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_BulkDeleteFailures")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_aitemplate_BulkDeleteFailures")]
    public msdyn_AITemplate msdyn_aitemplate_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_BulkDeleteFailures")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisjob_BulkDeleteFailures")]
    public msdyn_analysisjob msdyn_analysisjob_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresult_BulkDeleteFailures")]
    public msdyn_analysisresult msdyn_analysisresult_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_BulkDeleteFailures")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_dataflow_BulkDeleteFailures")]
    public msdyn_dataflow msdyn_dataflow_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticle_BulkDeleteFailures")]
    public msdyn_federatedarticle msdyn_federatedarticle_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_BulkDeleteFailures")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_helppage_BulkDeleteFailures")]
    public msdyn_helppage msdyn_helppage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_BulkDeleteFailures")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_BulkDeleteFailures")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_BulkDeleteFailures")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_BulkDeleteFailures")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_BulkDeleteFailures")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_richtextfile_BulkDeleteFailures")]
    public msdyn_richtextfile msdyn_richtextfile_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_BulkDeleteFailures")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_slakpi_BulkDeleteFailures")]
    public msdyn_slakpi msdyn_slakpi_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_BulkDeleteFailures")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_BulkDeleteFailures")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_BulkDeleteFailures")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("msdynce_botcontent_BulkDeleteFailures")]
    public msdynce_botcontent msdynce_botcontent_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Organization_BulkDeleteFailures")]
    public Organization Organization_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (Organization_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("package_BulkDeleteFailures")]
    public package package_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<package>(nameof (package_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("pdfsetting_BulkDeleteFailures")]
    public PDFSetting pdfsetting_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<PDFSetting>(nameof (pdfsetting_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("PhoneCall_BulkDeleteFailures")]
    public PhoneCall PhoneCall_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (PhoneCall_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("post_BulkDeleteFailures")]
    public Post post_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Post>(nameof (post_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Privilege_BulkDeleteFailures")]
    public Privilege Privilege_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<Privilege>(nameof (Privilege_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("processstageparameter_BulkDeleteFailures")]
    public processstageparameter processstageparameter_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<processstageparameter>(nameof (processstageparameter_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("profilerule_BulkDeleteFailures")]
    public ChannelAccessProfileRule profilerule_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfileRule>(nameof (profilerule_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("provisionlanguageforuser_BulkDeleteFailures")]
    public ProvisionLanguageForUser provisionlanguageforuser_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("QuarterlyFiscalCalendar_BulkDeleteFailures")]
    public QuarterlyFiscalCalendar QuarterlyFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<QuarterlyFiscalCalendar>(nameof (QuarterlyFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Queue_BulkDeleteFailures")]
    public Queue Queue_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Queue>(nameof (Queue_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("QueueItem_BulkDeleteFailures")]
    public QueueItem QueueItem_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<QueueItem>(nameof (QueueItem_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RecurringAppointmentMaster_BulkDeleteFailures")]
    public RecurringAppointmentMaster RecurringAppointmentMaster_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (RecurringAppointmentMaster_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RelationshipRole_BulkDeleteFailures")]
    public RelationshipRole RelationshipRole_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRole>(nameof (RelationshipRole_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("RelationshipRoleMap_BulkDeleteFailures")]
    public RelationshipRoleMap RelationshipRoleMap_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<RelationshipRoleMap>(nameof (RelationshipRoleMap_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_BulkDeleteFailures")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Role_BulkDeleteFailures")]
    public Role Role_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Role>(nameof (Role_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("routingrule_BulkDeleteFailures")]
    public RoutingRule routingrule_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<RoutingRule>(nameof (routingrule_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("routingruleitem_BulkDeleteFailures")]
    public RoutingRuleItem routingruleitem_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<RoutingRuleItem>(nameof (routingruleitem_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SavedQuery_BulkDeleteFailures")]
    public SavedQuery SavedQuery_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<SavedQuery>(nameof (SavedQuery_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SemiAnnualFiscalCalendar_BulkDeleteFailures")]
    public SemiAnnualFiscalCalendar SemiAnnualFiscalCalendar_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<SemiAnnualFiscalCalendar>(nameof (SemiAnnualFiscalCalendar_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("serviceplan_BulkDeleteFailures")]
    public ServicePlan serviceplan_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("settingdefinition_BulkDeleteFailures")]
    public SettingDefinition settingdefinition_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<SettingDefinition>(nameof (settingdefinition_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("slabase_BulkDeleteFailures")]
    public SLA slabase_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<SLA>(nameof (slabase_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SocialActivity_BulkDeleteFailures")]
    public SocialActivity SocialActivity_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (SocialActivity_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_BulkDeleteFailures")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_BulkDeleteFailures")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_BulkDeleteFailures")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("stagesolutionupload_BulkDeleteFailures")]
    public StageSolutionUpload stagesolutionupload_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Subject_BulkDeleteFailures")]
    public Subject Subject_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Subject>(nameof (Subject_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SystemForm_BulkDeleteFailures")]
    public SystemForm SystemForm_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<SystemForm>(nameof (SystemForm_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("SystemUser_BulkDeleteFailures")]
    public SystemUser SystemUser_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (SystemUser_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Task_BulkDeleteFailures")]
    public Task Task_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Task>(nameof (Task_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Team_BulkDeleteFailures")]
    public Team Team_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Team>(nameof (Team_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Template_BulkDeleteFailures")]
    public Template Template_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<Template>(nameof (Template_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Territory_BulkDeleteFailures")]
    public Territory Territory_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<Territory>(nameof (Territory_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("theme_BulkDeleteFailures")]
    public Theme theme_BulkDeleteFailures
    {
      get => this.GetRelatedEntity<Theme>(nameof (theme_BulkDeleteFailures), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("UserForm_BulkDeleteFailures")]
    public UserForm UserForm_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<UserForm>(nameof (UserForm_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("usermapping_BulkDeleteFailures")]
    public UserMapping usermapping_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<UserMapping>(nameof (usermapping_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("UserQuery_BulkDeleteFailures")]
    public UserQuery UserQuery_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<UserQuery>(nameof (UserQuery_BulkDeleteFailures), new EntityRole?());
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("workflowbinary_BulkDeleteFailures")]
    public workflowbinary workflowbinary_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntity<workflowbinary>(nameof (workflowbinary_BulkDeleteFailures), new EntityRole?());
      }
    }

    public BulkDeleteFailure(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["bulkdeletefailureid"] = (object) base.Id;
            break;
          case "bulkdeletefailureid":
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
