// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.EntityImageConfig
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("entityimageconfig")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class EntityImageConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "entityimageconfig";
    public const string EntitySchemaName = "EntityImageConfig";
    public const string PrimaryIdAttribute = "entityimageconfigid";
    public const string PrimaryNameAttribute = "parententitylogicalname";

    public EntityImageConfig()
      : base("entityimageconfig")
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

    [AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [AttributeLogicalName("entityimageconfigid")]
    public Guid? EntityImageConfigId
    {
      get => this.GetAttributeValue<Guid?>("entityimageconfigid");
      set
      {
        this.OnPropertyChanging(nameof (EntityImageConfigId));
        this.SetAttributeValue("entityimageconfigid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (EntityImageConfigId));
      }
    }

    [AttributeLogicalName("entityimageconfigid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.EntityImageConfigId = new Guid?(value);
    }

    [AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [AttributeLogicalName("parententitylogicalname")]
    public string ParentEntityLogicalName
    {
      get => this.GetAttributeValue<string>("parententitylogicalname");
      set
      {
        this.OnPropertyChanging(nameof (ParentEntityLogicalName));
        this.SetAttributeValue("parententitylogicalname", (object) value);
        this.OnPropertyChanged(nameof (ParentEntityLogicalName));
      }
    }

    [AttributeLogicalName("primaryimageattribute")]
    public string PrimaryImageAttribute
    {
      get => this.GetAttributeValue<string>("primaryimageattribute");
      set
      {
        this.OnPropertyChanging(nameof (PrimaryImageAttribute));
        this.SetAttributeValue("primaryimageattribute", (object) value);
        this.OnPropertyChanged(nameof (PrimaryImageAttribute));
      }
    }

    [AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("entityimageconfig_AsyncOperations")]
    public IEnumerable<AsyncOperation> entityimageconfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (entityimageconfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (entityimageconfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_AsyncOperations));
      }
    }

    [RelationshipSchemaName("entityimageconfig_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> entityimageconfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (entityimageconfig_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (entityimageconfig_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("entityimageconfig_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> entityimageconfig_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (entityimageconfig_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (entityimageconfig_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("entityimageconfig_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> entityimageconfig_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (entityimageconfig_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (entityimageconfig_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("entityimageconfig_SyncErrors")]
    public IEnumerable<SyncError> entityimageconfig_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (entityimageconfig_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (entityimageconfig_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_SyncErrors));
      }
    }

    [RelationshipSchemaName("entityimageconfig_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> entityimageconfig_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (entityimageconfig_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (entityimageconfig_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (entityimageconfig_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (entityimageconfig_UserEntityInstanceDatas));
      }
    }

    public EntityImageConfig(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["entityimageconfigid"] = (object) base.Id;
            break;
          case "entityimageconfigid":
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
