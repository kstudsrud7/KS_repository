// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.TraceLog
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("tracelog")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class TraceLog : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "tracelog";
    public const string EntitySchemaName = "TraceLog";
    public const string PrimaryIdAttribute = "tracelogid";
    public const string PrimaryNameAttribute = "text";

    public TraceLog()
      : base("tracelog")
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

    [AttributeLogicalName("canbedeleted")]
    public bool? CanBeDeleted
    {
      get => this.GetAttributeValue<bool?>("canbedeleted");
      set
      {
        this.OnPropertyChanging(nameof (CanBeDeleted));
        this.SetAttributeValue("canbedeleted", (object) value);
        this.OnPropertyChanged(nameof (CanBeDeleted));
      }
    }

    [AttributeLogicalName("collationlevel")]
    public int? CollationLevel
    {
      get => this.GetAttributeValue<int?>("collationlevel");
      set
      {
        this.OnPropertyChanging(nameof (CollationLevel));
        this.SetAttributeValue("collationlevel", (object) value);
        this.OnPropertyChanged(nameof (CollationLevel));
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

    [AttributeLogicalName("errordetails")]
    public string ErrorDetails
    {
      get => this.GetAttributeValue<string>("errordetails");
      set
      {
        this.OnPropertyChanging(nameof (ErrorDetails));
        this.SetAttributeValue("errordetails", (object) value);
        this.OnPropertyChanged(nameof (ErrorDetails));
      }
    }

    [AttributeLogicalName("errortypedisplay")]
    public string ErrorTypeDisplay
    {
      get => this.GetAttributeValue<string>("errortypedisplay");
      set
      {
        this.OnPropertyChanging(nameof (ErrorTypeDisplay));
        this.SetAttributeValue("errortypedisplay", (object) value);
        this.OnPropertyChanged(nameof (ErrorTypeDisplay));
      }
    }

    [AttributeLogicalName("isunique")]
    public bool? IsUnique
    {
      get => this.GetAttributeValue<bool?>("isunique");
      set
      {
        this.OnPropertyChanging(nameof (IsUnique));
        this.SetAttributeValue("isunique", (object) value);
        this.OnPropertyChanged(nameof (IsUnique));
      }
    }

    [AttributeLogicalName("level")]
    public OptionSetValue Level
    {
      get => this.GetAttributeValue<OptionSetValue>("level");
      set
      {
        this.OnPropertyChanging(nameof (Level));
        this.SetAttributeValue("level", (object) value);
        this.OnPropertyChanged(nameof (Level));
      }
    }

    [AttributeLogicalName("machinename")]
    public string MachineName
    {
      get => this.GetAttributeValue<string>("machinename");
      set
      {
        this.OnPropertyChanging(nameof (MachineName));
        this.SetAttributeValue("machinename", (object) value);
        this.OnPropertyChanged(nameof (MachineName));
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

    [AttributeLogicalName("organizationid")]
    public EntityReference OrganizationId
    {
      get => this.GetAttributeValue<EntityReference>("organizationid");
    }

    [AttributeLogicalName("parenttracelogid")]
    public EntityReference ParentTraceLogId
    {
      get => this.GetAttributeValue<EntityReference>("parenttracelogid");
      set
      {
        this.OnPropertyChanging(nameof (ParentTraceLogId));
        this.SetAttributeValue("parenttracelogid", (object) value);
        this.OnPropertyChanged(nameof (ParentTraceLogId));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    public EntityReference RegardingObjectId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectid");
      set
      {
        this.OnPropertyChanging(nameof (RegardingObjectId));
        this.SetAttributeValue("regardingobjectid", (object) value);
        this.OnPropertyChanged(nameof (RegardingObjectId));
      }
    }

    [AttributeLogicalName("regardingobjectownerid")]
    public EntityReference RegardingObjectOwnerId
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectownerid");
    }

    [AttributeLogicalName("regardingobjectowningbusinessunit")]
    public EntityReference RegardingObjectOwningBusinessUnit
    {
      get => this.GetAttributeValue<EntityReference>("regardingobjectowningbusinessunit");
    }

    [AttributeLogicalName("text")]
    public string Text
    {
      get => this.GetAttributeValue<string>("text");
      set
      {
        this.OnPropertyChanging(nameof (Text));
        this.SetAttributeValue("text", (object) value);
        this.OnPropertyChanged(nameof (Text));
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

    [AttributeLogicalName("traceactionxml")]
    public string TraceActionXml
    {
      get => this.GetAttributeValue<string>("traceactionxml");
      set
      {
        this.OnPropertyChanging(nameof (TraceActionXml));
        this.SetAttributeValue("traceactionxml", (object) value);
        this.OnPropertyChanged(nameof (TraceActionXml));
      }
    }

    [AttributeLogicalName("tracecode")]
    public int? TraceCode
    {
      get => this.GetAttributeValue<int?>("tracecode");
      set
      {
        this.OnPropertyChanging(nameof (TraceCode));
        this.SetAttributeValue("tracecode", (object) value);
        this.OnPropertyChanged(nameof (TraceCode));
      }
    }

    [AttributeLogicalName("tracedetailxml")]
    public string TraceDetailXml
    {
      get => this.GetAttributeValue<string>("tracedetailxml");
      set
      {
        this.OnPropertyChanging(nameof (TraceDetailXml));
        this.SetAttributeValue("tracedetailxml", (object) value);
        this.OnPropertyChanged(nameof (TraceDetailXml));
      }
    }

    [AttributeLogicalName("tracelogid")]
    public Guid? TraceLogId
    {
      get => this.GetAttributeValue<Guid?>("tracelogid");
      set
      {
        this.OnPropertyChanging(nameof (TraceLogId));
        this.SetAttributeValue("tracelogid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (TraceLogId));
      }
    }

    [AttributeLogicalName("tracelogid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.TraceLogId = new Guid?(value);
    }

    [AttributeLogicalName("traceparameterhash")]
    public int? TraceParameterHash => this.GetAttributeValue<int?>("traceparameterhash");

    [AttributeLogicalName("traceparameterxml")]
    public string TraceParameterXml
    {
      get => this.GetAttributeValue<string>("traceparameterxml");
      set
      {
        this.OnPropertyChanging(nameof (TraceParameterXml));
        this.SetAttributeValue("traceparameterxml", (object) value);
        this.OnPropertyChanged(nameof (TraceParameterXml));
      }
    }

    [AttributeLogicalName("tracestatus")]
    public bool? TraceStatus
    {
      get => this.GetAttributeValue<bool?>("tracestatus");
      set
      {
        this.OnPropertyChanging(nameof (TraceStatus));
        this.SetAttributeValue("tracestatus", (object) value);
        this.OnPropertyChanged(nameof (TraceStatus));
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

    [RelationshipSchemaName]
    public IEnumerable<TraceLog> Referencedtracelog_parent_tracelog
    {
      get
      {
        return this.GetRelatedEntities<TraceLog>("tracelog_parent_tracelog", new EntityRole?((EntityRole) 1));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencedtracelog_parent_tracelog));
        this.SetRelatedEntities<TraceLog>("tracelog_parent_tracelog", new EntityRole?((EntityRole) 1), value);
        this.OnPropertyChanged(nameof (Referencedtracelog_parent_tracelog));
      }
    }

    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_tracelog_createdby")]
    public SystemUser lk_tracelog_createdby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_tracelog_createdby), new EntityRole?());
    }

    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_tracelog_createdonbehalfby")]
    public SystemUser lk_tracelog_createdonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_tracelog_createdonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_tracelog_createdonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_tracelog_createdonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_tracelog_createdonbehalfby));
      }
    }

    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_tracelog_modifiedby")]
    public SystemUser lk_tracelog_modifiedby
    {
      get => this.GetRelatedEntity<SystemUser>(nameof (lk_tracelog_modifiedby), new EntityRole?());
    }

    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_tracelog_modifiedonbehalfby")]
    public SystemUser lk_tracelog_modifiedonbehalfby
    {
      get
      {
        return this.GetRelatedEntity<SystemUser>(nameof (lk_tracelog_modifiedonbehalfby), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (lk_tracelog_modifiedonbehalfby));
        this.SetRelatedEntity<SystemUser>(nameof (lk_tracelog_modifiedonbehalfby), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (lk_tracelog_modifiedonbehalfby));
      }
    }

    [AttributeLogicalName("organizationid")]
    [RelationshipSchemaName("organization_tracelog")]
    public Organization organization_tracelog
    {
      get => this.GetRelatedEntity<Organization>(nameof (organization_tracelog), new EntityRole?());
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("tracelog_EmailServerProfile")]
    public EmailServerProfile tracelog_EmailServerProfile
    {
      get
      {
        return this.GetRelatedEntity<EmailServerProfile>(nameof (tracelog_EmailServerProfile), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (tracelog_EmailServerProfile));
        this.SetRelatedEntity<EmailServerProfile>(nameof (tracelog_EmailServerProfile), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (tracelog_EmailServerProfile));
      }
    }

    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("tracelog_Mailbox")]
    public Mailbox tracelog_Mailbox
    {
      get => this.GetRelatedEntity<Mailbox>(nameof (tracelog_Mailbox), new EntityRole?());
      set
      {
        this.OnPropertyChanging(nameof (tracelog_Mailbox));
        this.SetRelatedEntity<Mailbox>(nameof (tracelog_Mailbox), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (tracelog_Mailbox));
      }
    }

    [AttributeLogicalName("parenttracelogid")]
    [RelationshipSchemaName]
    public TraceLog Referencingtracelog_parent_tracelog
    {
      get
      {
        return this.GetRelatedEntity<TraceLog>("tracelog_parent_tracelog", new EntityRole?((EntityRole) 0));
      }
      set
      {
        this.OnPropertyChanging(nameof (Referencingtracelog_parent_tracelog));
        this.SetRelatedEntity<TraceLog>("tracelog_parent_tracelog", new EntityRole?((EntityRole) 0), value);
        this.OnPropertyChanged(nameof (Referencingtracelog_parent_tracelog));
      }
    }

    public TraceLog(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["tracelogid"] = (object) base.Id;
            break;
          case "tracelogid":
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
