// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.msdyn_solutioncomponentsummary
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("msdyn_solutioncomponentsummary")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class msdyn_solutioncomponentsummary : 
    Entity,
    INotifyPropertyChanging,
    INotifyPropertyChanged
  {
    public const string EntityLogicalName = "msdyn_solutioncomponentsummary";
    public const string EntitySchemaName = "msdyn_solutioncomponentsummary";
    public const string PrimaryIdAttribute = "msdyn_solutioncomponentsummaryid";
    public const string PrimaryNameAttribute = "msdyn_name";

    public msdyn_solutioncomponentsummary()
      : base(nameof (msdyn_solutioncomponentsummary))
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

    [AttributeLogicalName("msdyn_canvasappuniqueid")]
    public string msdyn_canvasappuniqueid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_canvasappuniqueid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_canvasappuniqueid));
        this.SetAttributeValue(nameof (msdyn_canvasappuniqueid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_canvasappuniqueid));
      }
    }

    [AttributeLogicalName("msdyn_componentlogicalname")]
    public string msdyn_componentlogicalname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_componentlogicalname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_componentlogicalname));
        this.SetAttributeValue(nameof (msdyn_componentlogicalname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_componentlogicalname));
      }
    }

    [AttributeLogicalName("msdyn_componenttype")]
    public Decimal? msdyn_componenttype
    {
      get => this.GetAttributeValue<Decimal?>(nameof (msdyn_componenttype));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_componenttype));
        this.SetAttributeValue(nameof (msdyn_componenttype), (object) value);
        this.OnPropertyChanged(nameof (msdyn_componenttype));
      }
    }

    [AttributeLogicalName("msdyn_componenttypename")]
    public string msdyn_componenttypename
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_componenttypename));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_componenttypename));
        this.SetAttributeValue(nameof (msdyn_componenttypename), (object) value);
        this.OnPropertyChanged(nameof (msdyn_componenttypename));
      }
    }

    [AttributeLogicalName("msdyn_connectorinternalid")]
    public string msdyn_connectorinternalid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_connectorinternalid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_connectorinternalid));
        this.SetAttributeValue(nameof (msdyn_connectorinternalid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_connectorinternalid));
      }
    }

    [AttributeLogicalName("msdyn_createdon")]
    public string msdyn_createdon
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_createdon));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_createdon));
        this.SetAttributeValue(nameof (msdyn_createdon), (object) value);
        this.OnPropertyChanged(nameof (msdyn_createdon));
      }
    }

    [AttributeLogicalName("msdyn_culture")]
    public string msdyn_culture
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_culture));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_culture));
        this.SetAttributeValue(nameof (msdyn_culture), (object) value);
        this.OnPropertyChanged(nameof (msdyn_culture));
      }
    }

    [AttributeLogicalName("msdyn_deployment")]
    public string msdyn_deployment
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_deployment));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_deployment));
        this.SetAttributeValue(nameof (msdyn_deployment), (object) value);
        this.OnPropertyChanged(nameof (msdyn_deployment));
      }
    }

    [AttributeLogicalName("msdyn_description")]
    public string msdyn_description
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_description));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_description));
        this.SetAttributeValue(nameof (msdyn_description), (object) value);
        this.OnPropertyChanged(nameof (msdyn_description));
      }
    }

    [AttributeLogicalName("msdyn_displayname")]
    public string msdyn_displayname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_displayname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_displayname));
        this.SetAttributeValue(nameof (msdyn_displayname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_displayname));
      }
    }

    [AttributeLogicalName("msdyn_eventhandler")]
    public string msdyn_eventhandler
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_eventhandler));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_eventhandler));
        this.SetAttributeValue(nameof (msdyn_eventhandler), (object) value);
        this.OnPropertyChanged(nameof (msdyn_eventhandler));
      }
    }

    [AttributeLogicalName("msdyn_executionorder")]
    public string msdyn_executionorder
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_executionorder));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_executionorder));
        this.SetAttributeValue(nameof (msdyn_executionorder), (object) value);
        this.OnPropertyChanged(nameof (msdyn_executionorder));
      }
    }

    [AttributeLogicalName("msdyn_executionstage")]
    public string msdyn_executionstage
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_executionstage));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_executionstage));
        this.SetAttributeValue(nameof (msdyn_executionstage), (object) value);
        this.OnPropertyChanged(nameof (msdyn_executionstage));
      }
    }

    [AttributeLogicalName("msdyn_fieldsecurity")]
    public string msdyn_fieldsecurity
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_fieldsecurity));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_fieldsecurity));
        this.SetAttributeValue(nameof (msdyn_fieldsecurity), (object) value);
        this.OnPropertyChanged(nameof (msdyn_fieldsecurity));
      }
    }

    [AttributeLogicalName("msdyn_fieldtype")]
    public string msdyn_fieldtype
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_fieldtype));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_fieldtype));
        this.SetAttributeValue(nameof (msdyn_fieldtype), (object) value);
        this.OnPropertyChanged(nameof (msdyn_fieldtype));
      }
    }

    [AttributeLogicalName("msdyn_isappaware")]
    public string msdyn_isappaware
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_isappaware));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isappaware));
        this.SetAttributeValue(nameof (msdyn_isappaware), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isappaware));
      }
    }

    [AttributeLogicalName("msdyn_isappawarename")]
    public string msdyn_isappawarename
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_isappawarename));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isappawarename));
        this.SetAttributeValue(nameof (msdyn_isappawarename), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isappawarename));
      }
    }

    [AttributeLogicalName("msdyn_isauditenabled")]
    public string msdyn_isauditenabled
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_isauditenabled));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isauditenabled));
        this.SetAttributeValue(nameof (msdyn_isauditenabled), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isauditenabled));
      }
    }

    [AttributeLogicalName("msdyn_isauditenabledname")]
    public string msdyn_isauditenabledname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_isauditenabledname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isauditenabledname));
        this.SetAttributeValue(nameof (msdyn_isauditenabledname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isauditenabledname));
      }
    }

    [AttributeLogicalName("msdyn_iscustom")]
    public string msdyn_iscustom
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_iscustom));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_iscustom));
        this.SetAttributeValue(nameof (msdyn_iscustom), (object) value);
        this.OnPropertyChanged(nameof (msdyn_iscustom));
      }
    }

    [AttributeLogicalName("msdyn_iscustomizable")]
    public string msdyn_iscustomizable
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_iscustomizable));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_iscustomizable));
        this.SetAttributeValue(nameof (msdyn_iscustomizable), (object) value);
        this.OnPropertyChanged(nameof (msdyn_iscustomizable));
      }
    }

    [AttributeLogicalName("msdyn_iscustomizablename")]
    public string msdyn_iscustomizablename
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_iscustomizablename));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_iscustomizablename));
        this.SetAttributeValue(nameof (msdyn_iscustomizablename), (object) value);
        this.OnPropertyChanged(nameof (msdyn_iscustomizablename));
      }
    }

    [AttributeLogicalName("msdyn_iscustomname")]
    public string msdyn_iscustomname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_iscustomname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_iscustomname));
        this.SetAttributeValue(nameof (msdyn_iscustomname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_iscustomname));
      }
    }

    [AttributeLogicalName("msdyn_isdefault")]
    public string msdyn_isdefault
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_isdefault));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isdefault));
        this.SetAttributeValue(nameof (msdyn_isdefault), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isdefault));
      }
    }

    [AttributeLogicalName("msdyn_isdefaultname")]
    public string msdyn_isdefaultname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_isdefaultname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isdefaultname));
        this.SetAttributeValue(nameof (msdyn_isdefaultname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isdefaultname));
      }
    }

    [AttributeLogicalName("msdyn_ismanaged")]
    public string msdyn_ismanaged
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_ismanaged));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ismanaged));
        this.SetAttributeValue(nameof (msdyn_ismanaged), (object) value);
        this.OnPropertyChanged(nameof (msdyn_ismanaged));
      }
    }

    [AttributeLogicalName("msdyn_ismanagedname")]
    public string msdyn_ismanagedname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_ismanagedname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_ismanagedname));
        this.SetAttributeValue(nameof (msdyn_ismanagedname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_ismanagedname));
      }
    }

    [AttributeLogicalName("msdyn_isolationmode")]
    public string msdyn_isolationmode
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_isolationmode));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_isolationmode));
        this.SetAttributeValue(nameof (msdyn_isolationmode), (object) value);
        this.OnPropertyChanged(nameof (msdyn_isolationmode));
      }
    }

    [AttributeLogicalName("msdyn_istableenabled")]
    public string msdyn_istableenabled
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_istableenabled));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_istableenabled));
        this.SetAttributeValue(nameof (msdyn_istableenabled), (object) value);
        this.OnPropertyChanged(nameof (msdyn_istableenabled));
      }
    }

    [AttributeLogicalName("msdyn_logicalcollectionname")]
    public string msdyn_logicalcollectionname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_logicalcollectionname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_logicalcollectionname));
        this.SetAttributeValue(nameof (msdyn_logicalcollectionname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_logicalcollectionname));
      }
    }

    [AttributeLogicalName("msdyn_modifiedon")]
    public string msdyn_modifiedon
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_modifiedon));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_modifiedon));
        this.SetAttributeValue(nameof (msdyn_modifiedon), (object) value);
        this.OnPropertyChanged(nameof (msdyn_modifiedon));
      }
    }

    [AttributeLogicalName("msdyn_name")]
    public string msdyn_name
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_name));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_name));
        this.SetAttributeValue(nameof (msdyn_name), (object) value);
        this.OnPropertyChanged(nameof (msdyn_name));
      }
    }

    [AttributeLogicalName("msdyn_objectid")]
    public string msdyn_objectid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_objectid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_objectid));
        this.SetAttributeValue(nameof (msdyn_objectid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_objectid));
      }
    }

    [AttributeLogicalName("msdyn_objecttypecode")]
    public string msdyn_objecttypecode
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_objecttypecode));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_objecttypecode));
        this.SetAttributeValue(nameof (msdyn_objecttypecode), (object) value);
        this.OnPropertyChanged(nameof (msdyn_objecttypecode));
      }
    }

    [AttributeLogicalName("msdyn_owner")]
    public string msdyn_owner
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_owner));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_owner));
        this.SetAttributeValue(nameof (msdyn_owner), (object) value);
        this.OnPropertyChanged(nameof (msdyn_owner));
      }
    }

    [AttributeLogicalName("msdyn_owningbusinessunit")]
    public string msdyn_owningbusinessunit
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_owningbusinessunit));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_owningbusinessunit));
        this.SetAttributeValue(nameof (msdyn_owningbusinessunit), (object) value);
        this.OnPropertyChanged(nameof (msdyn_owningbusinessunit));
      }
    }

    [AttributeLogicalName("msdyn_primaryentityname")]
    public string msdyn_primaryentityname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_primaryentityname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_primaryentityname));
        this.SetAttributeValue(nameof (msdyn_primaryentityname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_primaryentityname));
      }
    }

    [AttributeLogicalName("msdyn_publickeytoken")]
    public string msdyn_publickeytoken
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_publickeytoken));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_publickeytoken));
        this.SetAttributeValue(nameof (msdyn_publickeytoken), (object) value);
        this.OnPropertyChanged(nameof (msdyn_publickeytoken));
      }
    }

    [AttributeLogicalName("msdyn_relatedentity")]
    public string msdyn_relatedentity
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_relatedentity));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_relatedentity));
        this.SetAttributeValue(nameof (msdyn_relatedentity), (object) value);
        this.OnPropertyChanged(nameof (msdyn_relatedentity));
      }
    }

    [AttributeLogicalName("msdyn_relatedentityattribute")]
    public string msdyn_relatedentityattribute
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_relatedentityattribute));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_relatedentityattribute));
        this.SetAttributeValue(nameof (msdyn_relatedentityattribute), (object) value);
        this.OnPropertyChanged(nameof (msdyn_relatedentityattribute));
      }
    }

    [AttributeLogicalName("msdyn_schemaname")]
    public string msdyn_schemaname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_schemaname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_schemaname));
        this.SetAttributeValue(nameof (msdyn_schemaname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_schemaname));
      }
    }

    [AttributeLogicalName("msdyn_sdkmessagename")]
    public string msdyn_sdkmessagename
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_sdkmessagename));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_sdkmessagename));
        this.SetAttributeValue(nameof (msdyn_sdkmessagename), (object) value);
        this.OnPropertyChanged(nameof (msdyn_sdkmessagename));
      }
    }

    [AttributeLogicalName("msdyn_solutioncomponentsummaryid")]
    public Guid? msdyn_solutioncomponentsummaryId
    {
      get => this.GetAttributeValue<Guid?>("msdyn_solutioncomponentsummaryid");
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutioncomponentsummaryId));
        this.SetAttributeValue("msdyn_solutioncomponentsummaryid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (msdyn_solutioncomponentsummaryId));
      }
    }

    [AttributeLogicalName("msdyn_solutioncomponentsummaryid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.msdyn_solutioncomponentsummaryId = new Guid?(value);
    }

    [AttributeLogicalName("msdyn_solutionid")]
    public string msdyn_solutionid
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_solutionid));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_solutionid));
        this.SetAttributeValue(nameof (msdyn_solutionid), (object) value);
        this.OnPropertyChanged(nameof (msdyn_solutionid));
      }
    }

    [AttributeLogicalName("msdyn_status")]
    public string msdyn_status
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_status));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_status));
        this.SetAttributeValue(nameof (msdyn_status), (object) value);
        this.OnPropertyChanged(nameof (msdyn_status));
      }
    }

    [AttributeLogicalName("msdyn_statusname")]
    public string msdyn_statusname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_statusname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_statusname));
        this.SetAttributeValue(nameof (msdyn_statusname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_statusname));
      }
    }

    [AttributeLogicalName("msdyn_subtype")]
    public string msdyn_subtype
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_subtype));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_subtype));
        this.SetAttributeValue(nameof (msdyn_subtype), (object) value);
        this.OnPropertyChanged(nameof (msdyn_subtype));
      }
    }

    [AttributeLogicalName("msdyn_synctoexternalsearchindex")]
    public string msdyn_synctoexternalsearchindex
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_synctoexternalsearchindex));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_synctoexternalsearchindex));
        this.SetAttributeValue(nameof (msdyn_synctoexternalsearchindex), (object) value);
        this.OnPropertyChanged(nameof (msdyn_synctoexternalsearchindex));
      }
    }

    [AttributeLogicalName("msdyn_total")]
    public Decimal? msdyn_total
    {
      get => this.GetAttributeValue<Decimal?>(nameof (msdyn_total));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_total));
        this.SetAttributeValue(nameof (msdyn_total), (object) value);
        this.OnPropertyChanged(nameof (msdyn_total));
      }
    }

    [AttributeLogicalName("msdyn_typename")]
    public string msdyn_typename
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_typename));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_typename));
        this.SetAttributeValue(nameof (msdyn_typename), (object) value);
        this.OnPropertyChanged(nameof (msdyn_typename));
      }
    }

    [AttributeLogicalName("msdyn_uniquename")]
    public string msdyn_uniquename
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_uniquename));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_uniquename));
        this.SetAttributeValue(nameof (msdyn_uniquename), (object) value);
        this.OnPropertyChanged(nameof (msdyn_uniquename));
      }
    }

    [AttributeLogicalName("msdyn_version")]
    public string msdyn_version
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_version));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_version));
        this.SetAttributeValue(nameof (msdyn_version), (object) value);
        this.OnPropertyChanged(nameof (msdyn_version));
      }
    }

    [AttributeLogicalName("msdyn_workflowcategory")]
    public string msdyn_workflowcategory
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_workflowcategory));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_workflowcategory));
        this.SetAttributeValue(nameof (msdyn_workflowcategory), (object) value);
        this.OnPropertyChanged(nameof (msdyn_workflowcategory));
      }
    }

    [AttributeLogicalName("msdyn_workflowcategoryname")]
    public string msdyn_workflowcategoryname
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_workflowcategoryname));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_workflowcategoryname));
        this.SetAttributeValue(nameof (msdyn_workflowcategoryname), (object) value);
        this.OnPropertyChanged(nameof (msdyn_workflowcategoryname));
      }
    }

    [AttributeLogicalName("msdyn_workflowidunique")]
    public string msdyn_workflowidunique
    {
      get => this.GetAttributeValue<string>(nameof (msdyn_workflowidunique));
      set
      {
        this.OnPropertyChanging(nameof (msdyn_workflowidunique));
        this.SetAttributeValue(nameof (msdyn_workflowidunique), (object) value);
        this.OnPropertyChanged(nameof (msdyn_workflowidunique));
      }
    }

    public msdyn_solutioncomponentsummary(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["msdyn_solutioncomponentsummaryid"] = (object) base.Id;
            break;
          case "msdyn_solutioncomponentsummaryid":
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
