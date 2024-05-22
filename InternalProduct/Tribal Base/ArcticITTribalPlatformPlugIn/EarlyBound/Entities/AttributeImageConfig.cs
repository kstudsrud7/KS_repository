// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.AttributeImageConfig
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("attributeimageconfig")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class AttributeImageConfig : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "attributeimageconfig";
    public const string EntitySchemaName = "AttributeImageConfig";
    public const string PrimaryIdAttribute = "attributeimageconfigid";
    public const string PrimaryNameAttribute = "attributelogicalname";

    public AttributeImageConfig()
      : base("attributeimageconfig")
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

    [Microsoft.Xrm.Sdk.AttributeLogicalName("attributeimageconfigid")]
    public Guid? AttributeImageConfigId
    {
      get => this.GetAttributeValue<Guid?>("attributeimageconfigid");
      set
      {
        this.OnPropertyChanging(nameof (AttributeImageConfigId));
        this.SetAttributeValue("attributeimageconfigid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (AttributeImageConfigId));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("attributeimageconfigid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.AttributeImageConfigId = new Guid?(value);
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("attributelogicalname")]
    public string AttributeLogicalName
    {
      get => this.GetAttributeValue<string>("attributelogicalname");
      set
      {
        this.OnPropertyChanging(nameof (AttributeLogicalName));
        this.SetAttributeValue("attributelogicalname", (object) value);
        this.OnPropertyChanged(nameof (AttributeLogicalName));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("canstorefullimage")]
    public bool? CanStoreFullImage
    {
      get => this.GetAttributeValue<bool?>("canstorefullimage");
      set
      {
        this.OnPropertyChanging(nameof (CanStoreFullImage));
        this.SetAttributeValue("canstorefullimage", (object) value);
        this.OnPropertyChanged(nameof (CanStoreFullImage));
      }
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("componentidunique")]
    public Guid? ComponentIdUnique => this.GetAttributeValue<Guid?>("componentidunique");

    [Microsoft.Xrm.Sdk.AttributeLogicalName("componentstate")]
    public OptionSetValue ComponentState
    {
      get => this.GetAttributeValue<OptionSetValue>("componentstate");
    }

    [Microsoft.Xrm.Sdk.AttributeLogicalName("ismanaged")]
    public bool? IsManaged => this.GetAttributeValue<bool?>("ismanaged");

    [Microsoft.Xrm.Sdk.AttributeLogicalName("overwritetime")]
    public DateTime? OverwriteTime => this.GetAttributeValue<DateTime?>("overwritetime");

    [Microsoft.Xrm.Sdk.AttributeLogicalName("parententitylogicalname")]
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

    [Microsoft.Xrm.Sdk.AttributeLogicalName("solutionid")]
    public Guid? SolutionId => this.GetAttributeValue<Guid?>("solutionid");

    [Microsoft.Xrm.Sdk.AttributeLogicalName("versionnumber")]
    public long? VersionNumber => this.GetAttributeValue<long?>("versionnumber");

    [RelationshipSchemaName("attributeimageconfig_AsyncOperations")]
    public IEnumerable<AsyncOperation> attributeimageconfig_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (attributeimageconfig_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (attributeimageconfig_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_AsyncOperations));
      }
    }

    [RelationshipSchemaName("attributeimageconfig_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> attributeimageconfig_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (attributeimageconfig_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (attributeimageconfig_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("attributeimageconfig_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> attributeimageconfig_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (attributeimageconfig_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (attributeimageconfig_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("attributeimageconfig_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> attributeimageconfig_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (attributeimageconfig_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (attributeimageconfig_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("attributeimageconfig_SyncErrors")]
    public IEnumerable<SyncError> attributeimageconfig_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (attributeimageconfig_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (attributeimageconfig_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_SyncErrors));
      }
    }

    [RelationshipSchemaName("attributeimageconfig_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> attributeimageconfig_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (attributeimageconfig_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (attributeimageconfig_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (attributeimageconfig_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (attributeimageconfig_UserEntityInstanceDatas));
      }
    }

    public AttributeImageConfig(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["attributeimageconfigid"] = (object) base.Id;
            break;
          case "attributeimageconfigid":
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
