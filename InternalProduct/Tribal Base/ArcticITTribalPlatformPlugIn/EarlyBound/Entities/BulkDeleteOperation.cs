// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.BulkDeleteOperation
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("bulkdeleteoperation")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class BulkDeleteOperation : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "bulkdeleteoperation";
    public const string EntitySchemaName = "BulkDeleteOperation";
    public const string PrimaryIdAttribute = "bulkdeleteoperationid";
    public const string PrimaryNameAttribute = "name";

    public BulkDeleteOperation()
      : base("bulkdeleteoperation")
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

    [AttributeLogicalName("bulkdeleteoperationid")]
    public Guid? BulkDeleteOperationId => this.GetAttributeValue<Guid?>("bulkdeleteoperationid");

    [AttributeLogicalName("bulkdeleteoperationid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => base.Id = value;
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

    [AttributeLogicalName("failurecount")]
    public int? FailureCount => this.GetAttributeValue<int?>("failurecount");

    [AttributeLogicalName("isrecurring")]
    public bool? IsRecurring => this.GetAttributeValue<bool?>("isrecurring");

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

    [AttributeLogicalName("name")]
    public string Name => this.GetAttributeValue<string>("name");

    [AttributeLogicalName("nextrun")]
    public DateTime? NextRun => this.GetAttributeValue<DateTime?>("nextrun");

    [AttributeLogicalName("orderedquerysetxml")]
    public string OrderedQuerySetXml => this.GetAttributeValue<string>("orderedquerysetxml");

    [AttributeLogicalName("ownerid")]
    public EntityReference OwnerId => this.GetAttributeValue<EntityReference>("ownerid");

    [AttributeLogicalName("owningbusinessunit")]
    public EntityReference OwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("owningbusinessunit");
    }

    [AttributeLogicalName("owninguser")]
    public EntityReference OwningUser => this.GetAttributeValue<EntityReference>("owninguser");

    [AttributeLogicalName("processingqeindex")]
    public int? ProcessingQEIndex => this.GetAttributeValue<int?>("processingqeindex");

    [AttributeLogicalName("statecode")]
    public BulkDeleteOperationState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new BulkDeleteOperationState?((BulkDeleteOperationState) Enum.ToObject(typeof (BulkDeleteOperationState), attributeValue.Value)) : new BulkDeleteOperationState?();
      }
    }

    [AttributeLogicalName("statuscode")]
    public OptionSetValue StatusCode => this.GetAttributeValue<OptionSetValue>("statuscode");

    [AttributeLogicalName("successcount")]
    public int? SuccessCount => this.GetAttributeValue<int?>("successcount");

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

    [RelationshipSchemaName("BulkDeleteOperation_BulkDeleteFailure")]
    public IEnumerable<BulkDeleteFailure> BulkDeleteOperation_BulkDeleteFailure
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (BulkDeleteOperation_BulkDeleteFailure), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (BulkDeleteOperation_BulkDeleteFailure));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (BulkDeleteOperation_BulkDeleteFailure), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (BulkDeleteOperation_BulkDeleteFailure));
      }
    }

    [RelationshipSchemaName("userentityinstancedata_bulkdeleteoperation")]
    public IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkdeleteoperation
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_bulkdeleteoperation), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (userentityinstancedata_bulkdeleteoperation));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (userentityinstancedata_bulkdeleteoperation), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (userentityinstancedata_bulkdeleteoperation));
      }
    }

    [AttributeLogicalName("asyncoperationid")]
    [RelationshipSchemaName("AsyncOperation_BulkDeleteOperation")]
    public AsyncOperation AsyncOperation_BulkDeleteOperation
    {
      get
      {
        return this.GetRelatedEntity<AsyncOperation>(nameof (AsyncOperation_BulkDeleteOperation), new EntityRole?());
      }
    }

    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("BulkDeleteOperation_BusinessUnit")]
    public BusinessUnit BulkDeleteOperation_BusinessUnit
    {
      get
      {
        return this.GetRelatedEntity<BusinessUnit>(nameof (BulkDeleteOperation_BusinessUnit), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_bulkdeleteoperation_createdonbehalfby")]
    public SystemUser lk_bulkdeleteoperation_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_bulkdeleteoperation_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_bulkdeleteoperation_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_bulkdeleteoperation_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_bulkdeleteoperation_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_bulkdeleteoperation_modifiedonbehalfby")]
    public SystemUser lk_bulkdeleteoperation_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_bulkdeleteoperation_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_bulkdeleteoperation_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_bulkdeleteoperation_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_bulkdeleteoperation_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_bulkdeleteoperationbase_createdby")]
    public SystemUser lk_bulkdeleteoperationbase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_bulkdeleteoperationbase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_bulkdeleteoperationbase_modifiedby")]
    public SystemUser lk_bulkdeleteoperationbase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_bulkdeleteoperationbase_modifiedby), new EntityRole?());
      }
    }

    public BulkDeleteOperation(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["bulkdeleteoperationid"] = (object) base.Id;
            break;
          case "bulkdeleteoperationid":
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
