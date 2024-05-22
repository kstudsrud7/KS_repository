// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.BusinessProcessFlowInstance
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("businessprocessflowinstance")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class BusinessProcessFlowInstance : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "businessprocessflowinstance";
    public const string EntitySchemaName = "BusinessProcessFlowInstance";
    public const string PrimaryIdAttribute = "businessprocessflowinstanceid";

    public BusinessProcessFlowInstance()
      : base("businessprocessflowinstance")
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

    [AttributeLogicalName("activestagestartedon")]
    public DateTime? ActiveStageStartedOn
    {
      get => this.GetAttributeValue<DateTime?>("activestagestartedon");
    }

    [AttributeLogicalName("businessprocessflowinstanceid")]
    public Guid? BusinessProcessFlowInstanceId
    {
      get => this.GetAttributeValue<Guid?>("businessprocessflowinstanceid");
      set
      {
        this.OnPropertyChanging(nameof (BusinessProcessFlowInstanceId));
        this.SetAttributeValue("businessprocessflowinstanceid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (BusinessProcessFlowInstanceId));
      }
    }

    [AttributeLogicalName("businessprocessflowinstanceid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.BusinessProcessFlowInstanceId = new Guid?(value);
    }

    [AttributeLogicalName("completedon")]
    public DateTime? CompletedOn => this.GetAttributeValue<DateTime?>("completedon");

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

    [AttributeLogicalName("entity1id")]
    public Guid? Entity1Id
    {
      get => this.GetAttributeValue<Guid?>("entity1id");
      set
      {
        this.OnPropertyChanging(nameof (Entity1Id));
        this.SetAttributeValue("entity1id", (object) value);
        this.OnPropertyChanged(nameof (Entity1Id));
      }
    }

    [AttributeLogicalName("entity1objecttypecode")]
    public string Entity1ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("entity1objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (Entity1ObjectTypeCode));
        this.SetAttributeValue("entity1objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (Entity1ObjectTypeCode));
      }
    }

    [AttributeLogicalName("entity2id")]
    public Guid? Entity2Id
    {
      get => this.GetAttributeValue<Guid?>("entity2id");
      set
      {
        this.OnPropertyChanging(nameof (Entity2Id));
        this.SetAttributeValue("entity2id", (object) value);
        this.OnPropertyChanged(nameof (Entity2Id));
      }
    }

    [AttributeLogicalName("entity2objecttypecode")]
    public string Entity2ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("entity2objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (Entity2ObjectTypeCode));
        this.SetAttributeValue("entity2objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (Entity2ObjectTypeCode));
      }
    }

    [AttributeLogicalName("entity3id")]
    public Guid? Entity3Id
    {
      get => this.GetAttributeValue<Guid?>("entity3id");
      set
      {
        this.OnPropertyChanging(nameof (Entity3Id));
        this.SetAttributeValue("entity3id", (object) value);
        this.OnPropertyChanged(nameof (Entity3Id));
      }
    }

    [AttributeLogicalName("entity3objecttypecode")]
    public string Entity3ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("entity3objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (Entity3ObjectTypeCode));
        this.SetAttributeValue("entity3objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (Entity3ObjectTypeCode));
      }
    }

    [AttributeLogicalName("entity4id")]
    public Guid? Entity4Id
    {
      get => this.GetAttributeValue<Guid?>("entity4id");
      set
      {
        this.OnPropertyChanging(nameof (Entity4Id));
        this.SetAttributeValue("entity4id", (object) value);
        this.OnPropertyChanged(nameof (Entity4Id));
      }
    }

    [AttributeLogicalName("entity4objecttypecode")]
    public string Entity4ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("entity4objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (Entity4ObjectTypeCode));
        this.SetAttributeValue("entity4objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (Entity4ObjectTypeCode));
      }
    }

    [AttributeLogicalName("entity5id")]
    public Guid? Entity5Id
    {
      get => this.GetAttributeValue<Guid?>("entity5id");
      set
      {
        this.OnPropertyChanging(nameof (Entity5Id));
        this.SetAttributeValue("entity5id", (object) value);
        this.OnPropertyChanged(nameof (Entity5Id));
      }
    }

    [AttributeLogicalName("entity5objecttypecode")]
    public string Entity5ObjectTypeCode
    {
      get => this.GetAttributeValue<string>("entity5objecttypecode");
      set
      {
        this.OnPropertyChanging(nameof (Entity5ObjectTypeCode));
        this.SetAttributeValue("entity5objecttypecode", (object) value);
        this.OnPropertyChanged(nameof (Entity5ObjectTypeCode));
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

    [AttributeLogicalName("name")]
    public string Name
    {
      get => this.GetAttributeValue<string>("name");
      set
      {
        this.OnPropertyChanging(nameof (Name));
        this.SetAttributeValue("name", (object) value);
        this.OnPropertyChanged(nameof (Name));
      }
    }

    [AttributeLogicalName("processid")]
    public EntityReference ProcessId
    {
      get => this.GetAttributeValue<EntityReference>("processid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessId));
        this.SetAttributeValue("processid", (object) value);
        this.OnPropertyChanged(nameof (ProcessId));
      }
    }

    [AttributeLogicalName("processstageid")]
    public Guid? ProcessStageId
    {
      get => this.GetAttributeValue<Guid?>("processstageid");
      set
      {
        this.OnPropertyChanging(nameof (ProcessStageId));
        this.SetAttributeValue("processstageid", (object) value);
        this.OnPropertyChanged(nameof (ProcessStageId));
      }
    }

    [AttributeLogicalName("statecode")]
    public BusinessProcessFlowInstanceState? statecode
    {
      get
      {
        OptionSetValue attributeValue = this.GetAttributeValue<OptionSetValue>(nameof (statecode));
        return attributeValue != null ? new BusinessProcessFlowInstanceState?((BusinessProcessFlowInstanceState) Enum.ToObject(typeof (BusinessProcessFlowInstanceState), attributeValue.Value)) : new BusinessProcessFlowInstanceState?();
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

    [AttributeLogicalName("traversedpath")]
    public string TraversedPath
    {
      get => this.GetAttributeValue<string>("traversedpath");
      set
      {
        this.OnPropertyChanging(nameof (TraversedPath));
        this.SetAttributeValue("traversedpath", (object) value);
        this.OnPropertyChanged(nameof (TraversedPath));
      }
    }

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_businessprocessflowinstancebase_createdby")]
    public SystemUser lk_businessprocessflowinstancebase_createdby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessprocessflowinstancebase_createdby), new EntityRole?());
      }
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_businessprocessflowinstancebase_createdonbehalfby")]
    public SystemUser lk_businessprocessflowinstancebase_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessprocessflowinstancebase_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_businessprocessflowinstancebase_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_businessprocessflowinstancebase_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessprocessflowinstancebase_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_businessprocessflowinstancebase_modifiedby")]
    public SystemUser lk_businessprocessflowinstancebase_modifiedby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessprocessflowinstancebase_modifiedby), new EntityRole?());
      }
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_businessprocessflowinstancebase_modifiedonbehalfby")]
    public SystemUser lk_businessprocessflowinstancebase_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_businessprocessflowinstancebase_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_businessprocessflowinstancebase_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_businessprocessflowinstancebase_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_businessprocessflowinstancebase_modifiedonbehalfby));
      }
    }

    public BusinessProcessFlowInstance(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["businessprocessflowinstanceid"] = (object) base.Id;
            break;
          case "businessprocessflowinstanceid":
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
