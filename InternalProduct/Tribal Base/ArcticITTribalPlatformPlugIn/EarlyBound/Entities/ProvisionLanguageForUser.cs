// Decompiled with JetBrains decompiler
// Type: ArcticIT.EarlyBound.Entities.ProvisionLanguageForUser
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
  [Microsoft.Xrm.Sdk.Client.EntityLogicalName("provisionlanguageforuser")]
  [GeneratedCode("CrmSvcUtil", "9.1.0.45")]
  public class ProvisionLanguageForUser : Entity, INotifyPropertyChanging, INotifyPropertyChanged
  {
    public const string EntityLogicalName = "provisionlanguageforuser";
    public const string EntitySchemaName = "ProvisionLanguageForUser";
    public const string PrimaryIdAttribute = "provisionlanguageforuserid";
    public const string PrimaryNameAttribute = "name";

    public ProvisionLanguageForUser()
      : base("provisionlanguageforuser")
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
    public Guid? AsyncOperationId
    {
      get => this.GetAttributeValue<Guid?>("asyncoperationid");
      set
      {
        this.OnPropertyChanging(nameof (AsyncOperationId));
        this.SetAttributeValue("asyncoperationid", (object) value);
        this.OnPropertyChanged(nameof (AsyncOperationId));
      }
    }

    [AttributeLogicalName("lcid")]
    public int? Lcid
    {
      get => this.GetAttributeValue<int?>("lcid");
      set
      {
        this.OnPropertyChanging(nameof (Lcid));
        this.SetAttributeValue("lcid", (object) value);
        this.OnPropertyChanged(nameof (Lcid));
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

    [AttributeLogicalName("operationstatus")]
    public OptionSetValue OperationStatus
    {
      get => this.GetAttributeValue<OptionSetValue>("operationstatus");
      set
      {
        this.OnPropertyChanging(nameof (OperationStatus));
        this.SetAttributeValue("operationstatus", (object) value);
        this.OnPropertyChanged(nameof (OperationStatus));
      }
    }

    [AttributeLogicalName("organizationid")]
    public Guid? OrganizationId => this.GetAttributeValue<Guid?>("organizationid");

    [AttributeLogicalName("provisionlanguageforuserid")]
    public Guid? ProvisionLanguageForUserId
    {
      get => this.GetAttributeValue<Guid?>("provisionlanguageforuserid");
      set
      {
        this.OnPropertyChanging(nameof (ProvisionLanguageForUserId));
        this.SetAttributeValue("provisionlanguageforuserid", (object) value);
        if (value.HasValue)
          base.Id = value.Value;
        else
          base.Id = Guid.Empty;
        this.OnPropertyChanged(nameof (ProvisionLanguageForUserId));
      }
    }

    [AttributeLogicalName("provisionlanguageforuserid")]
    public virtual Guid Id
    {
      get => base.Id;
      set => this.ProvisionLanguageForUserId = new Guid?(value);
    }

    [AttributeLogicalName("userid")]
    public Guid? UserId
    {
      get => this.GetAttributeValue<Guid?>("userid");
      set
      {
        this.OnPropertyChanging(nameof (UserId));
        this.SetAttributeValue("userid", (object) value);
        this.OnPropertyChanged(nameof (UserId));
      }
    }

    [RelationshipSchemaName("provisionlanguageforuser_AsyncOperations")]
    public IEnumerable<AsyncOperation> provisionlanguageforuser_AsyncOperations
    {
      get
      {
        return this.GetRelatedEntities<AsyncOperation>(nameof (provisionlanguageforuser_AsyncOperations), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_AsyncOperations));
        this.SetRelatedEntities<AsyncOperation>(nameof (provisionlanguageforuser_AsyncOperations), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_AsyncOperations));
      }
    }

    [RelationshipSchemaName("provisionlanguageforuser_BulkDeleteFailures")]
    public IEnumerable<BulkDeleteFailure> provisionlanguageforuser_BulkDeleteFailures
    {
      get
      {
        return this.GetRelatedEntities<BulkDeleteFailure>(nameof (provisionlanguageforuser_BulkDeleteFailures), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_BulkDeleteFailures));
        this.SetRelatedEntities<BulkDeleteFailure>(nameof (provisionlanguageforuser_BulkDeleteFailures), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_BulkDeleteFailures));
      }
    }

    [RelationshipSchemaName("provisionlanguageforuser_MailboxTrackingFolders")]
    public IEnumerable<MailboxTrackingFolder> provisionlanguageforuser_MailboxTrackingFolders
    {
      get
      {
        return this.GetRelatedEntities<MailboxTrackingFolder>(nameof (provisionlanguageforuser_MailboxTrackingFolders), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_MailboxTrackingFolders));
        this.SetRelatedEntities<MailboxTrackingFolder>(nameof (provisionlanguageforuser_MailboxTrackingFolders), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_MailboxTrackingFolders));
      }
    }

    [RelationshipSchemaName("provisionlanguageforuser_PrincipalObjectAttributeAccesses")]
    public IEnumerable<PrincipalObjectAttributeAccess> provisionlanguageforuser_PrincipalObjectAttributeAccesses
    {
      get
      {
        return this.GetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (provisionlanguageforuser_PrincipalObjectAttributeAccesses), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_PrincipalObjectAttributeAccesses));
        this.SetRelatedEntities<PrincipalObjectAttributeAccess>(nameof (provisionlanguageforuser_PrincipalObjectAttributeAccesses), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_PrincipalObjectAttributeAccesses));
      }
    }

    [RelationshipSchemaName("provisionlanguageforuser_ProcessSession")]
    public IEnumerable<ProcessSession> provisionlanguageforuser_ProcessSession
    {
      get
      {
        return this.GetRelatedEntities<ProcessSession>(nameof (provisionlanguageforuser_ProcessSession), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_ProcessSession));
        this.SetRelatedEntities<ProcessSession>(nameof (provisionlanguageforuser_ProcessSession), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_ProcessSession));
      }
    }

    [RelationshipSchemaName("provisionlanguageforuser_SyncErrors")]
    public IEnumerable<SyncError> provisionlanguageforuser_SyncErrors
    {
      get
      {
        return this.GetRelatedEntities<SyncError>(nameof (provisionlanguageforuser_SyncErrors), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_SyncErrors));
        this.SetRelatedEntities<SyncError>(nameof (provisionlanguageforuser_SyncErrors), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_SyncErrors));
      }
    }

    [RelationshipSchemaName("provisionlanguageforuser_UserEntityInstanceDatas")]
    public IEnumerable<UserEntityInstanceData> provisionlanguageforuser_UserEntityInstanceDatas
    {
      get
      {
        return this.GetRelatedEntities<UserEntityInstanceData>(nameof (provisionlanguageforuser_UserEntityInstanceDatas), new EntityRole?());
      }
      set
      {
        this.OnPropertyChanging(nameof (provisionlanguageforuser_UserEntityInstanceDatas));
        this.SetRelatedEntities<UserEntityInstanceData>(nameof (provisionlanguageforuser_UserEntityInstanceDatas), new EntityRole?(), value);
        this.OnPropertyChanged(nameof (provisionlanguageforuser_UserEntityInstanceDatas));
      }
    }

    public ProvisionLanguageForUser(object anonymousType)
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
            ((DataCollection<string, object>) this.Attributes)["provisionlanguageforuserid"] = (object) base.Id;
            break;
          case "provisionlanguageforuserid":
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
