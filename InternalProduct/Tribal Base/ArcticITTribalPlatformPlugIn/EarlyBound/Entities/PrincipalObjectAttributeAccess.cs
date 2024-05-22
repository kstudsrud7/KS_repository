// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.PrincipalObjectAttributeAccess
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("principalobjectattributeaccess")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class PrincipalObjectAttributeAccess : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "principalobjectattributeaccess";
    public const string EntitySchemaName = "PrincipalObjectAttributeAccess";
    public const string PrimaryIdAttribute = "principalobjectattributeaccessid";

    public PrincipalObjectAttributeAccess()
      : base("principalobjectattributeaccess")
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

    [AttributeLogicalName("attributeid")]
    public Guid? AttributeId
    {
      get => this.GetAttributeValue<Guid?>("attributeid");
      set
      {
        this.OnPropertyChanging(nameof (AttributeId));
        this.SetAttributeValue("attributeid", (object) value);
        this.OnPropertyChanged(nameof (AttributeId));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("principalid")]
    public EntityReference PrincipalId
    {
      get => this.GetAttributeValue<EntityReference>("principalid");
      set
      {
        this.OnPropertyChanging(nameof (PrincipalId));
        this.SetAttributeValue("principalid", (object) value);
        this.OnPropertyChanged(nameof (PrincipalId));
      }
    }

    [AttributeLogicalName("principalobjectattributeaccessid")]
    public Guid? PrincipalObjectAttributeAccessId
    {
      get => this.GetAttributeValue<Guid?>("principalobjectattributeaccessid");
      set
      {
        this.OnPropertyChanging(nameof (PrincipalObjectAttributeAccessId));
        this.SetAttributeValue("principalobjectattributeaccessid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (PrincipalObjectAttributeAccessId));
      }
    }

    [AttributeLogicalName("principalobjectattributeaccessid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.PrincipalObjectAttributeAccessId = new Guid?(value);
    }

    [AttributeLogicalName("readaccess")]
    public bool? ReadAccess
    {
      get => this.GetAttributeValue<bool?>("readaccess");
      set
      {
        this.OnPropertyChanging(nameof (ReadAccess));
        this.SetAttributeValue("readaccess", (object) value);
        this.OnPropertyChanged(nameof (ReadAccess));
      }
    }

    [AttributeLogicalName("updateaccess")]
    public bool? UpdateAccess
    {
      get => this.GetAttributeValue<bool?>("updateaccess");
      set
      {
        this.OnPropertyChanging(nameof (UpdateAccess));
        this.SetAttributeValue("updateaccess", (object) value);
        this.OnPropertyChanged(nameof (UpdateAccess));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("userentityinstancedata_principalobjectattributeaccess")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_principalobjectattributeaccess));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("account_principalobjectattributeaccess")]
    public Account account_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Account>(nameof (account_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (account_principalobjectattributeaccess));
        this.SetRelatedEntity<Account>(nameof (account_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (account_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_accountingcode_PrincipalObjectAttributeAccesses")]
    public ait_accountingcode ait_accountingcode_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_accountingcode_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_accountingcode>(nameof (ait_accountingcode_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_accountingcode_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_addresstype_PrincipalObjectAttributeAccesses")]
    public ait_addresstype ait_addresstype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_addresstype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_addresstype>(nameof (ait_addresstype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_addresstype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_assessment_PrincipalObjectAttributeAccesses")]
    public ait_assessment ait_assessment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_assessment>(nameof (ait_assessment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_assessment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_assessment>(nameof (ait_assessment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_assessment_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_autonumber_PrincipalObjectAttributeAccesses")]
    public ait_autonumber ait_autonumber_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_autonumber_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_autonumber>(nameof (ait_autonumber_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_autonumber_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_band_PrincipalObjectAttributeAccesses")]
    public ait_band ait_band_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_band>(nameof (ait_band_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_band_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_band>(nameof (ait_band_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_band_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_bankaccount_PrincipalObjectAttributeAccesses")]
    public ait_bankaccount ait_bankaccount_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccount_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_bankaccount>(nameof (ait_bankaccount_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccount_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_bankaccounttype_PrincipalObjectAttributeAccesses")]
    public ait_bankaccounttype ait_bankaccounttype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bankaccounttype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_bankaccounttype>(nameof (ait_bankaccounttype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bankaccounttype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_birthrecord_PrincipalObjectAttributeAccesses")]
    public ait_birthrecord ait_birthrecord_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_birthrecord_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_birthrecord>(nameof (ait_birthrecord_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_birthrecord_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_bloodquantum_PrincipalObjectAttributeAccesses")]
    public ait_bloodquantum ait_bloodquantum_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_bloodquantum_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_bloodquantum>(nameof (ait_bloodquantum_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_bloodquantum_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_cardformat_PrincipalObjectAttributeAccesses")]
    public ait_cardformat ait_cardformat_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformat_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_cardformat>(nameof (ait_cardformat_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformat_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_cardformatdetail_PrincipalObjectAttributeAccesses")]
    public ait_cardformatdetail ait_cardformatdetail_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardformatdetail_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_cardformatdetail>(nameof (ait_cardformatdetail_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardformatdetail_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_cardhistory_PrincipalObjectAttributeAccesses")]
    public ait_cardhistory ait_cardhistory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cardhistory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_cardhistory>(nameof (ait_cardhistory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cardhistory_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_case_PrincipalObjectAttributeAccesses")]
    public ait_case ait_case_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_case>(nameof (ait_case_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_case_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_case>(nameof (ait_case_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_case_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_casenote_PrincipalObjectAttributeAccesses")]
    public ait_casenote ait_casenote_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_casenote>(nameof (ait_casenote_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_casenote_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_casenote>(nameof (ait_casenote_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_casenote_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_caseplan_PrincipalObjectAttributeAccesses")]
    public ait_caseplan ait_caseplan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_caseplan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_caseplan>(nameof (ait_caseplan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_caseplan_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_causeofdeath_PrincipalObjectAttributeAccesses")]
    public ait_causeofdeath ait_causeofdeath_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_causeofdeath_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_causeofdeath>(nameof (ait_causeofdeath_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_causeofdeath_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_cemetary_PrincipalObjectAttributeAccesses")]
    public ait_cemetary ait_cemetary_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_cemetary_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_cemetary>(nameof (ait_cemetary_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_cemetary_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_certification_PrincipalObjectAttributeAccesses")]
    public ait_certification ait_certification_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_certification>(nameof (ait_certification_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_certification_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_certification>(nameof (ait_certification_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_certification_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_changerequest_PrincipalObjectAttributeAccesses")]
    public ait_changerequest ait_changerequest_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequest_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_changerequest>(nameof (ait_changerequest_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequest_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_changerequesttype_PrincipalObjectAttributeAccesses")]
    public ait_changerequesttype ait_changerequesttype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_changerequesttype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_changerequesttype>(nameof (ait_changerequesttype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_changerequesttype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_charge_PrincipalObjectAttributeAccesses")]
    public ait_charge ait_charge_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_charge>(nameof (ait_charge_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_charge_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_charge>(nameof (ait_charge_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_charge_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_childvisitations_PrincipalObjectAttributeAccesses")]
    public ait_childvisitations ait_childvisitations_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_childvisitations_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_childvisitations>(nameof (ait_childvisitations_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_childvisitations_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_city_PrincipalObjectAttributeAccesses")]
    public ait_city ait_city_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_city>(nameof (ait_city_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_city_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_city>(nameof (ait_city_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_city_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_clan_PrincipalObjectAttributeAccesses")]
    public ait_clan ait_clan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_clan>(nameof (ait_clan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_clan>(nameof (ait_clan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clan_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_clientprofile_PrincipalObjectAttributeAccesses")]
    public ait_clientprofile ait_clientprofile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_clientprofile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_clientprofile>(nameof (ait_clientprofile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_clientprofile_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committee_PrincipalObjectAttributeAccesses")]
    public ait_committee ait_committee_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_committee>(nameof (ait_committee_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committee_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_committee>(nameof (ait_committee_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committee_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeemeeting_PrincipalObjectAttributeAccesses")]
    public ait_committeemeeting ait_committeemeeting_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemeeting_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_committeemeeting>(nameof (ait_committeemeeting_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemeeting_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeemember_PrincipalObjectAttributeAccesses")]
    public ait_committeemember ait_committeemember_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeemember_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_committeemember>(nameof (ait_committeemember_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeemember_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeeposition_PrincipalObjectAttributeAccesses")]
    public ait_committeeposition ait_committeeposition_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeeposition_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_committeeposition>(nameof (ait_committeeposition_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeeposition_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_committeepositiontype_PrincipalObjectAttributeAccesses")]
    public ait_committeepositiontype ait_committeepositiontype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_committeepositiontype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_committeepositiontype>(nameof (ait_committeepositiontype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_committeepositiontype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_company_PrincipalObjectAttributeAccesses")]
    public ait_company ait_company_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_company>(nameof (ait_company_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_company_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_company>(nameof (ait_company_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_company_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactcertification_PrincipalObjectAttributeAccesses")]
    public ait_contactcertification ait_contactcertification_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactcertification_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactcertification>(nameof (ait_contactcertification_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactcertification_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contacteducation_PrincipalObjectAttributeAccesses")]
    public ait_contacteducation ait_contacteducation_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contacteducation_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contacteducation>(nameof (ait_contacteducation_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contacteducation_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactemployment_PrincipalObjectAttributeAccesses")]
    public ait_contactemployment ait_contactemployment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactemployment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactemployment>(nameof (ait_contactemployment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactemployment_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactimage_PrincipalObjectAttributeAccesses")]
    public ait_contactimage ait_contactimage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactimage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactimage>(nameof (ait_contactimage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactimage_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactincarceration_PrincipalObjectAttributeAccesses")]
    public ait_contactincarceration ait_contactincarceration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincarceration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactincarceration>(nameof (ait_contactincarceration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincarceration_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactincomeandexpense_PrincipalObjectAttributeAccesses")]
    public ait_contactincomeandexpense ait_contactincomeandexpense_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactincomeandexpense_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactincomeandexpense>(nameof (ait_contactincomeandexpense_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactincomeandexpense_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactlanguage_PrincipalObjectAttributeAccesses")]
    public ait_contactlanguage ait_contactlanguage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactlanguage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactlanguage>(nameof (ait_contactlanguage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactlanguage_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactmilitaryservice_PrincipalObjectAttributeAccesses")]
    public ait_contactmilitaryservice ait_contactmilitaryservice_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactmilitaryservice_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactmilitaryservice>(nameof (ait_contactmilitaryservice_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactmilitaryservice_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactname_PrincipalObjectAttributeAccesses")]
    public ait_contactname ait_contactname_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactname>(nameof (ait_contactname_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactname_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactname>(nameof (ait_contactname_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactname_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_contactskill_PrincipalObjectAttributeAccesses")]
    public ait_contactskill ait_contactskill_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_contactskill_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_contactskill>(nameof (ait_contactskill_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_contactskill_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_countryregion_PrincipalObjectAttributeAccesses")]
    public ait_countryregion ait_countryregion_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_countryregion_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_countryregion>(nameof (ait_countryregion_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_countryregion_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_county_PrincipalObjectAttributeAccesses")]
    public ait_county ait_county_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_county>(nameof (ait_county_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_county_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_county>(nameof (ait_county_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_county_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtcase_PrincipalObjectAttributeAccesses")]
    public ait_courtcase ait_courtcase_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtcase_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_courtcase>(nameof (ait_courtcase_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtcase_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtfinesandfees_PrincipalObjectAttributeAccesses")]
    public ait_courtfinesandfees ait_courtfinesandfees_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtfinesandfees_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_courtfinesandfees>(nameof (ait_courtfinesandfees_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtfinesandfees_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtparty_PrincipalObjectAttributeAccesses")]
    public ait_courtparty ait_courtparty_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtparty_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_courtparty>(nameof (ait_courtparty_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtparty_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtpayments_PrincipalObjectAttributeAccesses")]
    public ait_courtpayments ait_courtpayments_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtpayments_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_courtpayments>(nameof (ait_courtpayments_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtpayments_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtprofile_PrincipalObjectAttributeAccesses")]
    public ait_courtprofile ait_courtprofile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_courtprofile>(nameof (ait_courtprofile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofile_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtprofileaddress_PrincipalObjectAttributeAccesses")]
    public ait_courtprofileaddress ait_courtprofileaddress_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtprofileaddress_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_courtprofileaddress>(nameof (ait_courtprofileaddress_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtprofileaddress_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_courtroom_PrincipalObjectAttributeAccesses")]
    public ait_courtroom ait_courtroom_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_courtroom_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_courtroom>(nameof (ait_courtroom_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_courtroom_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_datamigrationhistory_PrincipalObjectAttributeAccesses")]
    public ait_datamigrationhistory ait_datamigrationhistory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_datamigrationhistory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_datamigrationhistory>(nameof (ait_datamigrationhistory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_datamigrationhistory_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_deathrecord_PrincipalObjectAttributeAccesses")]
    public ait_deathrecord ait_deathrecord_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_deathrecord_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_deathrecord>(nameof (ait_deathrecord_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_deathrecord_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_degree_PrincipalObjectAttributeAccesses")]
    public ait_degree ait_degree_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_degree>(nameof (ait_degree_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_degree_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_degree>(nameof (ait_degree_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_degree_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_electronicaddress_PrincipalObjectAttributeAccesses")]
    public ait_electronicaddress ait_electronicaddress_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_electronicaddress_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_electronicaddress>(nameof (ait_electronicaddress_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_electronicaddress_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_emergencycontact_PrincipalObjectAttributeAccesses")]
    public ait_emergencycontact ait_emergencycontact_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_emergencycontact_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_emergencycontact>(nameof (ait_emergencycontact_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_emergencycontact_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_familygroup_PrincipalObjectAttributeAccesses")]
    public ait_familygroup ait_familygroup_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familygroup_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_familygroup>(nameof (ait_familygroup_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familygroup_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses")]
    public ait_familywellnessconfiguration ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_familywellnessconfiguration>(nameof (ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_familywellnessconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_geographicalarea_PrincipalObjectAttributeAccesses")]
    public ait_geographicalarea ait_geographicalarea_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_geographicalarea_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_geographicalarea>(nameof (ait_geographicalarea_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_geographicalarea_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_goal_PrincipalObjectAttributeAccesses")]
    public ait_goal ait_goal_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_goal>(nameof (ait_goal_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_goal_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_goal>(nameof (ait_goal_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_goal_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_groupactivity_PrincipalObjectAttributeAccesses")]
    public ait_groupactivity ait_groupactivity_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivity_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_groupactivity>(nameof (ait_groupactivity_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivity_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_groupactivitymeeting_PrincipalObjectAttributeAccesses")]
    public ait_groupactivitymeeting ait_groupactivitymeeting_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_groupactivitymeeting_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_groupactivitymeeting>(nameof (ait_groupactivitymeeting_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_groupactivitymeeting_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_household_PrincipalObjectAttributeAccesses")]
    public ait_household ait_household_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_household>(nameof (ait_household_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_household_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_household>(nameof (ait_household_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_household_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_householdmember_PrincipalObjectAttributeAccesses")]
    public ait_householdmember ait_householdmember_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_householdmember_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_householdmember>(nameof (ait_householdmember_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_householdmember_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwaadoption_PrincipalObjectAttributeAccesses")]
    public ait_icwaadoption ait_icwaadoption_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaadoption_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_icwaadoption>(nameof (ait_icwaadoption_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaadoption_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwanotice_PrincipalObjectAttributeAccesses")]
    public ait_icwanotice ait_icwanotice_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwanotice_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_icwanotice>(nameof (ait_icwanotice_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwanotice_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwaregion_PrincipalObjectAttributeAccesses")]
    public ait_icwaregion ait_icwaregion_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregion_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_icwaregion>(nameof (ait_icwaregion_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregion_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_icwaregionnotification_PrincipalObjectAttributeAccesses")]
    public ait_icwaregionnotification ait_icwaregionnotification_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_icwaregionnotification_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_icwaregionnotification>(nameof (ait_icwaregionnotification_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_icwaregionnotification_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_incident_PrincipalObjectAttributeAccesses")]
    public ait_incident ait_incident_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_incident>(nameof (ait_incident_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incident_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_incident>(nameof (ait_incident_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incident_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_incidenttype_PrincipalObjectAttributeAccesses")]
    public ait_incidenttype ait_incidenttype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incidenttype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_incidenttype>(nameof (ait_incidenttype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incidenttype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses")]
    public ait_incomeorexpensecategory ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_incomeorexpensecategory>(nameof (ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_incomeorexpensecategory_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_investigation_PrincipalObjectAttributeAccesses")]
    public ait_investigation ait_investigation_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_investigation>(nameof (ait_investigation_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_investigation_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_investigation>(nameof (ait_investigation_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_investigation_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_language_PrincipalObjectAttributeAccesses")]
    public ait_language ait_language_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_language>(nameof (ait_language_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_language_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_language>(nameof (ait_language_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_language_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_languageproficiencylevel_PrincipalObjectAttributeAccesses")]
    public ait_languageproficiencylevel ait_languageproficiencylevel_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_languageproficiencylevel_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_languageproficiencylevel>(nameof (ait_languageproficiencylevel_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_languageproficiencylevel_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_loan_PrincipalObjectAttributeAccesses")]
    public ait_loan ait_loan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_loan>(nameof (ait_loan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_loan>(nameof (ait_loan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loan_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_loandetail_PrincipalObjectAttributeAccesses")]
    public ait_loandetail ait_loandetail_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loandetail_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_loandetail>(nameof (ait_loandetail_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loandetail_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_loantype_PrincipalObjectAttributeAccesses")]
    public ait_loantype ait_loantype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_loantype>(nameof (ait_loantype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_loantype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_loantype>(nameof (ait_loantype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_loantype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_medicalproviders_PrincipalObjectAttributeAccesses")]
    public ait_medicalproviders ait_medicalproviders_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_medicalproviders_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_medicalproviders>(nameof (ait_medicalproviders_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_medicalproviders_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_memberprofile_PrincipalObjectAttributeAccesses")]
    public ait_memberprofile ait_memberprofile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_memberprofile>(nameof (ait_memberprofile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofile_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_memberprofilemembershipcategory_PrincipalObjectAttributeAccesses")]
    public ait_memberprofilemembershipcategory ait_memberprofilemembershipcategory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberprofilemembershipcategory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_memberprofilemembershipcategory>(nameof (ait_memberprofilemembershipcategory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberprofilemembershipcategory_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_memberroll_PrincipalObjectAttributeAccesses")]
    public ait_memberroll ait_memberroll_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_memberroll_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_memberroll>(nameof (ait_memberroll_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_memberroll_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_membershipcategory_PrincipalObjectAttributeAccesses")]
    public ait_membershipcategory ait_membershipcategory_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipcategory_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_membershipcategory>(nameof (ait_membershipcategory_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipcategory_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_membershipstatuschangerequest_PrincipalObjectAttributeAccesses")]
    public ait_membershipstatuschangerequest ait_membershipstatuschangerequest_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_membershipstatuschangerequest_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_membershipstatuschangerequest>(nameof (ait_membershipstatuschangerequest_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_membershipstatuschangerequest_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_nametype_PrincipalObjectAttributeAccesses")]
    public ait_nametype ait_nametype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_nametype>(nameof (ait_nametype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_nametype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_nametype>(nameof (ait_nametype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_nametype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_outcome_PrincipalObjectAttributeAccesses")]
    public ait_outcome ait_outcome_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_outcome>(nameof (ait_outcome_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_outcome_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_outcome>(nameof (ait_outcome_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_outcome_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_payment_PrincipalObjectAttributeAccesses")]
    public ait_payment ait_payment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_payment>(nameof (ait_payment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_payment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_payment>(nameof (ait_payment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_payment_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_physicaladdress_PrincipalObjectAttributeAccesses")]
    public ait_physicaladdress ait_physicaladdress_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_physicaladdress_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_physicaladdress>(nameof (ait_physicaladdress_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_physicaladdress_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_placement_PrincipalObjectAttributeAccesses")]
    public ait_placement ait_placement_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_placement>(nameof (ait_placement_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placement_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_placement>(nameof (ait_placement_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placement_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_placementlocation_PrincipalObjectAttributeAccesses")]
    public ait_placementlocation ait_placementlocation_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_placementlocation_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_placementlocation>(nameof (ait_placementlocation_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_placementlocation_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_planactivity_PrincipalObjectAttributeAccesses")]
    public ait_planactivity ait_planactivity_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_planactivity_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_planactivity>(nameof (ait_planactivity_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_planactivity_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmteligibility_PrincipalObjectAttributeAccesses")]
    public ait_pmteligibility ait_pmteligibility_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmteligibility_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_pmteligibility>(nameof (ait_pmteligibility_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmteligibility_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtevent_PrincipalObjectAttributeAccesses")]
    public ait_pmtevent ait_pmtevent_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtevent_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_pmtevent>(nameof (ait_pmtevent_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtevent_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtpaymenttype_PrincipalObjectAttributeAccesses")]
    public ait_pmtpaymenttype ait_pmtpaymenttype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtpaymenttype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_pmtpaymenttype>(nameof (ait_pmtpaymenttype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtpaymenttype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmttransaction_PrincipalObjectAttributeAccesses")]
    public ait_pmttransaction ait_pmttransaction_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransaction_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_pmttransaction>(nameof (ait_pmttransaction_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransaction_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses")]
    public ait_pmttransactiondeduction ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_pmttransactiondeduction>(nameof (ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmttransactiondeduction_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtwithholding_PrincipalObjectAttributeAccesses")]
    public ait_pmtwithholding ait_pmtwithholding_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholding_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_pmtwithholding>(nameof (ait_pmtwithholding_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholding_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses")]
    public ait_pmtwithholdingoverride ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_pmtwithholdingoverride>(nameof (ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_pmtwithholdingoverride_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_program_PrincipalObjectAttributeAccesses")]
    public ait_program ait_program_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_program>(nameof (ait_program_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_program_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_program>(nameof (ait_program_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_program_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_referral_PrincipalObjectAttributeAccesses")]
    public ait_referral ait_referral_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_referral>(nameof (ait_referral_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_referral_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_referral>(nameof (ait_referral_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_referral_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_relationship_PrincipalObjectAttributeAccesses")]
    public ait_relationship ait_relationship_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_relationship>(nameof (ait_relationship_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_relationship_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_relationship>(nameof (ait_relationship_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_relationship_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_reservation_PrincipalObjectAttributeAccesses")]
    public ait_reservation ait_reservation_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_reservation>(nameof (ait_reservation_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_reservation_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_reservation>(nameof (ait_reservation_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_reservation_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_resolution_PrincipalObjectAttributeAccesses")]
    public ait_resolution ait_resolution_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_resolution>(nameof (ait_resolution_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_resolution_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_resolution>(nameof (ait_resolution_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_resolution_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_roll_PrincipalObjectAttributeAccesses")]
    public ait_roll ait_roll_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_roll>(nameof (ait_roll_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_roll_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_roll>(nameof (ait_roll_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_roll_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_safetyplan_PrincipalObjectAttributeAccesses")]
    public ait_safetyplan ait_safetyplan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_safetyplan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_safetyplan>(nameof (ait_safetyplan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_safetyplan_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_school_PrincipalObjectAttributeAccesses")]
    public ait_school ait_school_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_school>(nameof (ait_school_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_school_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_school>(nameof (ait_school_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_school_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_schooltype_PrincipalObjectAttributeAccesses")]
    public ait_schooltype ait_schooltype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_schooltype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_schooltype>(nameof (ait_schooltype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_schooltype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_servicerequest_PrincipalObjectAttributeAccesses")]
    public ait_servicerequest ait_servicerequest_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_servicerequest_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_servicerequest>(nameof (ait_servicerequest_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_servicerequest_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_skill_PrincipalObjectAttributeAccesses")]
    public ait_skill ait_skill_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_skill>(nameof (ait_skill_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_skill_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_skill>(nameof (ait_skill_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_skill_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_stateprovince_PrincipalObjectAttributeAccesses")]
    public ait_stateprovince ait_stateprovince_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_stateprovince_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_stateprovince>(nameof (ait_stateprovince_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_stateprovince_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_statute_PrincipalObjectAttributeAccesses")]
    public ait_statute ait_statute_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_statute>(nameof (ait_statute_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_statute_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_statute>(nameof (ait_statute_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_statute_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_training_PrincipalObjectAttributeAccesses")]
    public ait_training ait_training_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_training>(nameof (ait_training_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_training_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_training>(nameof (ait_training_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_training_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_trainingtype_PrincipalObjectAttributeAccesses")]
    public ait_trainingtype ait_trainingtype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_trainingtype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_trainingtype>(nameof (ait_trainingtype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_trainingtype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses")]
    public ait_tribalenrollmentconfiguration ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_tribalenrollmentconfiguration>(nameof (ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribalenrollmentconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_tribe_PrincipalObjectAttributeAccesses")]
    public ait_tribe ait_tribe_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_tribe>(nameof (ait_tribe_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_tribe_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_tribe>(nameof (ait_tribe_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_tribe_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_withholdingtype_PrincipalObjectAttributeAccesses")]
    public ait_withholdingtype ait_withholdingtype_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_withholdingtype_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_withholdingtype>(nameof (ait_withholdingtype_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_withholdingtype_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("ait_zipcodecity_PrincipalObjectAttributeAccesses")]
    public ait_zipcodecity ait_zipcodecity_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (ait_zipcodecity_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ait_zipcodecity>(nameof (ait_zipcodecity_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (ait_zipcodecity_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("apisettings_PrincipalObjectAttributeAccesses")]
    public apisettings apisettings_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<apisettings>(nameof (apisettings_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (apisettings_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<apisettings>(nameof (apisettings_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (apisettings_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appelement_PrincipalObjectAttributeAccesses")]
    public AppElement appelement_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<AppElement>(nameof (appelement_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appelement_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<AppElement>(nameof (appelement_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appelement_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("applicationuser_PrincipalObjectAttributeAccesses")]
    public ApplicationUser applicationuser_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ApplicationUser>(nameof (applicationuser_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (applicationuser_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ApplicationUser>(nameof (applicationuser_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (applicationuser_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appmodulecomponentedge_PrincipalObjectAttributeAccesses")]
    public AppModuleComponentEdge appmodulecomponentedge_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentedge_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<AppModuleComponentEdge>(nameof (appmodulecomponentedge_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentedge_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appmodulecomponentnode_PrincipalObjectAttributeAccesses")]
    public AppModuleComponentNode appmodulecomponentnode_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appmodulecomponentnode_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<AppModuleComponentNode>(nameof (appmodulecomponentnode_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appmodulecomponentnode_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appointment_principalobjectattributeaccess")]
    public Appointment appointment_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Appointment>(nameof (appointment_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appointment_principalobjectattributeaccess));
        this.SetRelatedEntity<Appointment>(nameof (appointment_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appointment_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("appsetting_PrincipalObjectAttributeAccesses")]
    public AppSetting appsetting_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<AppSetting>(nameof (appsetting_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (appsetting_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<AppSetting>(nameof (appsetting_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (appsetting_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("attributeimageconfig_PrincipalObjectAttributeAccesses")]
    public AttributeImageConfig attributeimageconfig_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<AttributeImageConfig>(nameof (attributeimageconfig_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("bot_PrincipalObjectAttributeAccesses")]
    public bot bot_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<bot>(nameof (bot_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (bot_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<bot>(nameof (bot_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (bot_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("botcomponent_PrincipalObjectAttributeAccesses")]
    public botcomponent botcomponent_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<botcomponent>(nameof (botcomponent_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (botcomponent_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<botcomponent>(nameof (botcomponent_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (botcomponent_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("businessunit_principalobjectattributeaccess")]
    public BusinessUnit businessunit_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (businessunit_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (businessunit_principalobjectattributeaccess));
        this.SetRelatedEntity<BusinessUnit>(nameof (businessunit_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (businessunit_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("canvasappextendedmetadata_PrincipalObjectAttributeAccesses")]
    public CanvasAppExtendedMetadata canvasappextendedmetadata_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (canvasappextendedmetadata_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<CanvasAppExtendedMetadata>(nameof (canvasappextendedmetadata_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (canvasappextendedmetadata_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("catalog_PrincipalObjectAttributeAccesses")]
    public Catalog catalog_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<Catalog>(nameof (catalog_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalog_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<Catalog>(nameof (catalog_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalog_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("catalogassignment_PrincipalObjectAttributeAccesses")]
    public CatalogAssignment catalogassignment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (catalogassignment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<CatalogAssignment>(nameof (catalogassignment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (catalogassignment_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("channelaccessprofile_PrincipalObjectAttributeAccess")]
    public ChannelAccessProfile channelaccessprofile_PrincipalObjectAttributeAccess
    {
      get
      {
        return this.GetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_PrincipalObjectAttributeAccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (channelaccessprofile_PrincipalObjectAttributeAccess));
        this.SetRelatedEntity<ChannelAccessProfile>(nameof (channelaccessprofile_PrincipalObjectAttributeAccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (channelaccessprofile_PrincipalObjectAttributeAccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("connection_principalobjectattributeaccess")]
    public Connection connection_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Connection>(nameof (connection_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connection_principalobjectattributeaccess));
        this.SetRelatedEntity<Connection>(nameof (connection_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connection_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("connectionreference_PrincipalObjectAttributeAccesses")]
    public connectionreference connectionreference_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<connectionreference>(nameof (connectionreference_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connectionreference_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<connectionreference>(nameof (connectionreference_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connectionreference_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("connector_PrincipalObjectAttributeAccesses")]
    public connector connector_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<connector>(nameof (connector_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (connector_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<connector>(nameof (connector_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (connector_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("contact_principalobjectattributeaccess")]
    public Contact contact_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Contact>(nameof (contact_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (contact_principalobjectattributeaccess));
        this.SetRelatedEntity<Contact>(nameof (contact_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (contact_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("conversationtranscript_PrincipalObjectAttributeAccesses")]
    public conversationtranscript conversationtranscript_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (conversationtranscript_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<conversationtranscript>(nameof (conversationtranscript_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (conversationtranscript_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("customapi_PrincipalObjectAttributeAccesses")]
    public CustomAPI customapi_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<CustomAPI>(nameof (customapi_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customapi_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<CustomAPI>(nameof (customapi_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customapi_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("customeraddress_principalobjectattributeaccess")]
    public CustomerAddress customeraddress_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<CustomerAddress>(nameof (customeraddress_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (customeraddress_principalobjectattributeaccess));
        this.SetRelatedEntity<CustomerAddress>(nameof (customeraddress_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (customeraddress_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("datalakefolder_PrincipalObjectAttributeAccesses")]
    public datalakefolder datalakefolder_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<datalakefolder>(nameof (datalakefolder_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolder_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<datalakefolder>(nameof (datalakefolder_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolder_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("datalakefolderpermission_PrincipalObjectAttributeAccesses")]
    public datalakefolderpermission datalakefolderpermission_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakefolderpermission_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<datalakefolderpermission>(nameof (datalakefolderpermission_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakefolderpermission_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("datalakeworkspace_PrincipalObjectAttributeAccesses")]
    public datalakeworkspace datalakeworkspace_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspace_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<datalakeworkspace>(nameof (datalakeworkspace_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspace_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("datalakeworkspacepermission_PrincipalObjectAttributeAccesses")]
    public datalakeworkspacepermission datalakeworkspacepermission_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (datalakeworkspacepermission_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<datalakeworkspacepermission>(nameof (datalakeworkspacepermission_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (datalakeworkspacepermission_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("email_principalobjectattributeaccess")]
    public Email email_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Email>(nameof (email_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (email_principalobjectattributeaccess));
        this.SetRelatedEntity<Email>(nameof (email_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (email_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("entityanalyticsconfig_PrincipalObjectAttributeAccesses")]
    public EntityAnalyticsConfig entityanalyticsconfig_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityanalyticsconfig_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<EntityAnalyticsConfig>(nameof (entityanalyticsconfig_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityanalyticsconfig_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("entityimageconfig_PrincipalObjectAttributeAccesses")]
    public EntityImageConfig entityimageconfig_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<EntityImageConfig>(nameof (entityimageconfig_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("environmentvariabledefinition_PrincipalObjectAttributeAccesses")]
    public EnvironmentVariableDefinition environmentvariabledefinition_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariabledefinition_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<EnvironmentVariableDefinition>(nameof (environmentvariabledefinition_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariabledefinition_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("environmentvariablevalue_PrincipalObjectAttributeAccesses")]
    public EnvironmentVariableValue environmentvariablevalue_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (environmentvariablevalue_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<EnvironmentVariableValue>(nameof (environmentvariablevalue_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (environmentvariablevalue_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("exportsolutionupload_PrincipalObjectAttributeAccesses")]
    public ExportSolutionUpload exportsolutionupload_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (exportsolutionupload_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ExportSolutionUpload>(nameof (exportsolutionupload_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (exportsolutionupload_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("fax_principalobjectattributeaccess")]
    public Fax fax_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Fax>(nameof (fax_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (fax_principalobjectattributeaccess));
        this.SetRelatedEntity<Fax>(nameof (fax_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (fax_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("feedback_principalobjectattributeaccess")]
    public Feedback feedback_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Feedback>(nameof (feedback_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (feedback_principalobjectattributeaccess));
        this.SetRelatedEntity<Feedback>(nameof (feedback_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (feedback_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("flowsession_PrincipalObjectAttributeAccesses")]
    public flowsession flowsession_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<flowsession>(nameof (flowsession_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (flowsession_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<flowsession>(nameof (flowsession_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (flowsession_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("goal_principalobjectattributeaccess")]
    public Goal goal_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Goal>(nameof (goal_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (goal_principalobjectattributeaccess));
        this.SetRelatedEntity<Goal>(nameof (goal_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (goal_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("holidaywrapper_PrincipalObjectAttributeAccesses")]
    public holidaywrapper holidaywrapper_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (holidaywrapper_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<holidaywrapper>(nameof (holidaywrapper_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (holidaywrapper_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("internalcatalogassignment_PrincipalObjectAttributeAccesses")]
    public InternalCatalogAssignment internalcatalogassignment_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (internalcatalogassignment_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<InternalCatalogAssignment>(nameof (internalcatalogassignment_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (internalcatalogassignment_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("kbarticle_principalobjectattributeaccess")]
    public KbArticle kbarticle_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<KbArticle>(nameof (kbarticle_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (kbarticle_principalobjectattributeaccess));
        this.SetRelatedEntity<KbArticle>(nameof (kbarticle_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (kbarticle_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("knowledgearticle_PrincipalObjectAttributeAccess")]
    public KnowledgeArticle knowledgearticle_PrincipalObjectAttributeAccess
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_PrincipalObjectAttributeAccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticle_PrincipalObjectAttributeAccess));
        this.SetRelatedEntity<KnowledgeArticle>(nameof (knowledgearticle_PrincipalObjectAttributeAccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticle_PrincipalObjectAttributeAccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("knowledgearticleview_principalobjectattributeaccess")]
    public KnowledgeArticleViews knowledgearticleview_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeArticleViews>(nameof (knowledgearticleview_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (knowledgearticleview_principalobjectattributeaccess));
        this.SetRelatedEntity<KnowledgeArticleViews>(nameof (knowledgearticleview_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (knowledgearticleview_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("KnowledgeBaseRecord_PrincipalObjectAttributeAccess")]
    public KnowledgeBaseRecord KnowledgeBaseRecord_PrincipalObjectAttributeAccess
    {
      get
      {
        return this.GetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_PrincipalObjectAttributeAccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (KnowledgeBaseRecord_PrincipalObjectAttributeAccess));
        this.SetRelatedEntity<KnowledgeBaseRecord>(nameof (KnowledgeBaseRecord_PrincipalObjectAttributeAccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (KnowledgeBaseRecord_PrincipalObjectAttributeAccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("letter_principalobjectattributeaccess")]
    public Letter letter_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Letter>(nameof (letter_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (letter_principalobjectattributeaccess));
        this.SetRelatedEntity<Letter>(nameof (letter_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (letter_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("lk_principalobjectattributeaccess_organizationid")]
    public Organization lk_principalobjectattributeaccess_organizationid
    {
      get
      {
        return this.GetRelatedEntity<Organization>(nameof (lk_principalobjectattributeaccess_organizationid), new EntityRole?());
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("mailmergetemplate_principalobjectattributeaccess")]
    public MailMergeTemplate mailmergetemplate_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<MailMergeTemplate>(nameof (mailmergetemplate_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mailmergetemplate_principalobjectattributeaccess));
        this.SetRelatedEntity<MailMergeTemplate>(nameof (mailmergetemplate_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mailmergetemplate_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("mbs_pluginprofile_PrincipalObjectAttributeAccesses")]
    public mbs_pluginprofile mbs_pluginprofile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (mbs_pluginprofile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<mbs_pluginprofile>(nameof (mbs_pluginprofile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (mbs_pluginprofile_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibdataset_PrincipalObjectAttributeAccesses")]
    public msdyn_AIBDataset msdyn_aibdataset_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdataset_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIBDataset>(nameof (msdyn_aibdataset_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdataset_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses")]
    public msdyn_AIBDatasetFile msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIBDatasetFile>(nameof (msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetfile_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses")]
    public msdyn_AIBDatasetRecord msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIBDatasetRecord>(nameof (msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetrecord_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses")]
    public msdyn_AIBDatasetsContainer msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIBDatasetsContainer>(nameof (msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibdatasetscontainer_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibfile_PrincipalObjectAttributeAccesses")]
    public msdyn_AIBFile msdyn_aibfile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIBFile>(nameof (msdyn_aibfile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfile_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aibfileattacheddata_PrincipalObjectAttributeAccesses")]
    public msdyn_AIBFileAttachedData msdyn_aibfileattacheddata_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aibfileattacheddata_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIBFileAttachedData>(nameof (msdyn_aibfileattacheddata_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aibfileattacheddata_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiconfiguration_PrincipalObjectAttributeAccesses")]
    public msdyn_AIConfiguration msdyn_aiconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIConfiguration>(nameof (msdyn_aiconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses")]
    public msdyn_AIFpTrainingDocument msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIFpTrainingDocument>(nameof (msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aifptrainingdocument_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aimodel_PrincipalObjectAttributeAccesses")]
    public msdyn_AIModel msdyn_aimodel_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aimodel_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIModel>(nameof (msdyn_aimodel_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aimodel_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodimage_PrincipalObjectAttributeAccesses")]
    public msdyn_AIOdImage msdyn_aiodimage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodimage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIOdImage>(nameof (msdyn_aiodimage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodimage_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodlabel_PrincipalObjectAttributeAccesses")]
    public msdyn_AIOdLabel msdyn_aiodlabel_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodlabel_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIOdLabel>(nameof (msdyn_aiodlabel_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodlabel_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses")]
    public msdyn_AIOdTrainingBoundingBox msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIOdTrainingBoundingBox>(nameof (msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses")]
    public msdyn_AIOdTrainingImage msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AIOdTrainingImage>(nameof (msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aiodtrainingimage_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_aitemplate_PrincipalObjectAttributeAccesses")]
    public msdyn_AITemplate msdyn_aitemplate_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_aitemplate_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_AITemplate>(nameof (msdyn_aitemplate_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_aitemplate_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_analysiscomponent_PrincipalObjectAttributeAccesses")]
    public msdyn_analysiscomponent msdyn_analysiscomponent_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysiscomponent_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_analysiscomponent>(nameof (msdyn_analysiscomponent_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysiscomponent_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_analysisjob_PrincipalObjectAttributeAccesses")]
    public msdyn_analysisjob msdyn_analysisjob_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisjob_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_analysisjob>(nameof (msdyn_analysisjob_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisjob_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_analysisresult_PrincipalObjectAttributeAccesses")]
    public msdyn_analysisresult msdyn_analysisresult_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresult_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_analysisresult>(nameof (msdyn_analysisresult_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresult_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses")]
    public msdyn_analysisresultdetail msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_analysisresultdetail>(nameof (msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_analysisresultdetail_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_dataflow_PrincipalObjectAttributeAccesses")]
    public msdyn_dataflow msdyn_dataflow_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_dataflow_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_dataflow>(nameof (msdyn_dataflow_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_dataflow_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_federatedarticle_PrincipalObjectAttributeAccesses")]
    public msdyn_federatedarticle msdyn_federatedarticle_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticle_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_federatedarticle>(nameof (msdyn_federatedarticle_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticle_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses")]
    public msdyn_federatedarticleincident msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_federatedarticleincident>(nameof (msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_federatedarticleincident_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_helppage_PrincipalObjectAttributeAccesses")]
    public msdyn_helppage msdyn_helppage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_helppage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_helppage>(nameof (msdyn_helppage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_helppage_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses")]
    public msdyn_kmfederatedsearchconfig msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_kmfederatedsearchconfig>(nameof (msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_kmfederatedsearchconfig_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses")]
    public msdyn_knowledgearticleimage msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_knowledgearticleimage>(nameof (msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticleimage_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses")]
    public msdyn_knowledgearticletemplate msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_knowledgearticletemplate>(nameof (msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgearticletemplate_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses")]
    public msdyn_knowledgeinteractioninsight msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_knowledgeinteractioninsight>(nameof (msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgeinteractioninsight_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses")]
    public msdyn_knowledgesearchinsight msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_knowledgesearchinsight>(nameof (msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_knowledgesearchinsight_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_richtextfile_PrincipalObjectAttributeAccesses")]
    public msdyn_richtextfile msdyn_richtextfile_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_richtextfile_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_richtextfile>(nameof (msdyn_richtextfile_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_richtextfile_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses")]
    public msdyn_serviceconfiguration msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_serviceconfiguration>(nameof (msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_serviceconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_slakpi_PrincipalObjectAttributeAccesses")]
    public msdyn_slakpi msdyn_slakpi_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_slakpi_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_slakpi>(nameof (msdyn_slakpi_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_slakpi_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses")]
    public msdyn_solutionhealthrule msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_solutionhealthrule>(nameof (msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthrule_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses")]
    public msdyn_solutionhealthruleargument msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_solutionhealthruleargument>(nameof (msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleargument_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses")]
    public msdyn_solutionhealthruleset msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdyn_solutionhealthruleset>(nameof (msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdyn_solutionhealthruleset_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("msdynce_botcontent_PrincipalObjectAttributeAccesses")]
    public msdynce_botcontent msdynce_botcontent_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (msdynce_botcontent_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<msdynce_botcontent>(nameof (msdynce_botcontent_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (msdynce_botcontent_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("package_PrincipalObjectAttributeAccesses")]
    public package package_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<package>(nameof (package_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (package_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<package>(nameof (package_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (package_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("pdfsetting_PrincipalObjectAttributeAccesses")]
    public PDFSetting pdfsetting_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<PDFSetting>(nameof (pdfsetting_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (pdfsetting_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<PDFSetting>(nameof (pdfsetting_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (pdfsetting_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("phonecall_principalobjectattributeaccess")]
    public PhoneCall phonecall_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<PhoneCall>(nameof (phonecall_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (phonecall_principalobjectattributeaccess));
        this.SetRelatedEntity<PhoneCall>(nameof (phonecall_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (phonecall_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("position_principalobjectattributeaccess")]
    public Position position_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Position>(nameof (position_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (position_principalobjectattributeaccess));
        this.SetRelatedEntity<Position>(nameof (position_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (position_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("processstageparameter_PrincipalObjectAttributeAccesses")]
    public processstageparameter processstageparameter_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<processstageparameter>(nameof (processstageparameter_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (processstageparameter_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<processstageparameter>(nameof (processstageparameter_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (processstageparameter_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("provisionlanguageforuser_PrincipalObjectAttributeAccesses")]
    public ProvisionLanguageForUser provisionlanguageforuser_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ProvisionLanguageForUser>(nameof (provisionlanguageforuser_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("queue_principalobjectattributeaccess")]
    public Queue queue_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Queue>(nameof (queue_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queue_principalobjectattributeaccess));
        this.SetRelatedEntity<Queue>(nameof (queue_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queue_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("queueitem_principalobjectattributeaccess")]
    public QueueItem queueitem_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<QueueItem>(nameof (queueitem_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (queueitem_principalobjectattributeaccess));
        this.SetRelatedEntity<QueueItem>(nameof (queueitem_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (queueitem_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("recurringappointmentmaster_principalobjectattributeaccess")]
    public RecurringAppointmentMaster recurringappointmentmaster_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (recurringappointmentmaster_principalobjectattributeaccess));
        this.SetRelatedEntity<RecurringAppointmentMaster>(nameof (recurringappointmentmaster_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (recurringappointmentmaster_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("reportcategory_principalobjectattributeaccess")]
    public ReportCategory reportcategory_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<ReportCategory>(nameof (reportcategory_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (reportcategory_principalobjectattributeaccess));
        this.SetRelatedEntity<ReportCategory>(nameof (reportcategory_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (reportcategory_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses")]
    public revokeinheritedaccessrecordstracker revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<revokeinheritedaccessrecordstracker>(nameof (revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (revokeinheritedaccessrecordstracker_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("serviceplan_PrincipalObjectAttributeAccesses")]
    public ServicePlan serviceplan_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<ServicePlan>(nameof (serviceplan_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (serviceplan_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<ServicePlan>(nameof (serviceplan_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (serviceplan_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("settingdefinition_PrincipalObjectAttributeAccesses")]
    public SettingDefinition settingdefinition_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<SettingDefinition>(nameof (settingdefinition_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (settingdefinition_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<SettingDefinition>(nameof (settingdefinition_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (settingdefinition_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("sharepointdocumentlocation_principalobjectattributeaccess")]
    public SharePointDocumentLocation sharepointdocumentlocation_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<SharePointDocumentLocation>(nameof (sharepointdocumentlocation_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sharepointdocumentlocation_principalobjectattributeaccess));
        this.SetRelatedEntity<SharePointDocumentLocation>(nameof (sharepointdocumentlocation_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sharepointdocumentlocation_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("sharepointsite_principalobjectattributeaccess")]
    public SharePointSite sharepointsite_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<SharePointSite>(nameof (sharepointsite_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (sharepointsite_principalobjectattributeaccess));
        this.SetRelatedEntity<SharePointSite>(nameof (sharepointsite_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (sharepointsite_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("socialactivity_principalobjectattributeaccess")]
    public SocialActivity socialactivity_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<SocialActivity>(nameof (socialactivity_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialactivity_principalobjectattributeaccess));
        this.SetRelatedEntity<SocialActivity>(nameof (socialactivity_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialactivity_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("socialprofile_principalobjectattributeaccess")]
    public SocialProfile socialprofile_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<SocialProfile>(nameof (socialprofile_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (socialprofile_principalobjectattributeaccess));
        this.SetRelatedEntity<SocialProfile>(nameof (socialprofile_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (socialprofile_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses")]
    public solutioncomponentattributeconfiguration solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<solutioncomponentattributeconfiguration>(nameof (solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentattributeconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("solutioncomponentconfiguration_PrincipalObjectAttributeAccesses")]
    public solutioncomponentconfiguration solutioncomponentconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<solutioncomponentconfiguration>(nameof (solutioncomponentconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses")]
    public solutioncomponentrelationshipconfiguration solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<solutioncomponentrelationshipconfiguration>(nameof (solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (solutioncomponentrelationshipconfiguration_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("stagesolutionupload_PrincipalObjectAttributeAccesses")]
    public StageSolutionUpload stagesolutionupload_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (stagesolutionupload_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<StageSolutionUpload>(nameof (stagesolutionupload_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (stagesolutionupload_PrincipalObjectAttributeAccesses));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("systemuser_principalobjectattributeaccess")]
    public SystemUser systemuser_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (systemuser_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuser_principalobjectattributeaccess));
        this.SetRelatedEntity<SystemUser>(nameof (systemuser_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("principalid")]
    [RelationshipSchemaName("systemuser_principalobjectattributeaccess_principalid")]
    public SystemUser systemuser_principalobjectattributeaccess_principalid
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (systemuser_principalobjectattributeaccess_principalid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (systemuser_principalobjectattributeaccess_principalid));
        this.SetRelatedEntity<SystemUser>(nameof (systemuser_principalobjectattributeaccess_principalid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (systemuser_principalobjectattributeaccess_principalid));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("task_principalobjectattributeaccess")]
    public Task task_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Task>(nameof (task_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (task_principalobjectattributeaccess));
        this.SetRelatedEntity<Task>(nameof (task_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (task_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("team_principalobjectattributeaccess")]
    public Team team_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_principalobjectattributeaccess));
        this.SetRelatedEntity<Team>(nameof (team_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("principalid")]
    [RelationshipSchemaName("team_principalobjectattributeaccess_principalid")]
    public Team team_principalobjectattributeaccess_principalid
    {
      get
      {
        return this.GetRelatedEntity<Team>(nameof (team_principalobjectattributeaccess_principalid), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (team_principalobjectattributeaccess_principalid));
        this.SetRelatedEntity<Team>(nameof (team_principalobjectattributeaccess_principalid), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (team_principalobjectattributeaccess_principalid));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("territory_principalobjectattributeaccess")]
    public Territory territory_principalobjectattributeaccess
    {
      get
      {
        return this.GetRelatedEntity<Territory>(nameof (territory_principalobjectattributeaccess), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (territory_principalobjectattributeaccess));
        this.SetRelatedEntity<Territory>(nameof (territory_principalobjectattributeaccess), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (territory_principalobjectattributeaccess));
      }
    }

    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("workflowbinary_PrincipalObjectAttributeAccesses")]
    public workflowbinary workflowbinary_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntity<workflowbinary>(nameof (workflowbinary_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (workflowbinary_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntity<workflowbinary>(nameof (workflowbinary_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (workflowbinary_PrincipalObjectAttributeAccesses));
      }
    }

    public PrincipalObjectAttributeAccess(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["principalobjectattributeaccessid"] = (object) base.Id;
            break;
          case "principalobjectattributeaccessid":
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
