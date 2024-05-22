// Decompiled with JetBrains decompiler
// Type: TPCourt.EarlyBound.BaseProxyClass
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;

#nullable disable
namespace TPCourt.EarlyBound
{
  [DataContract(Name = "Entity", Namespace = "http://schemas.microsoft.com/xrm/2011/Contracts")]
  public abstract class BaseProxyClass : Entity, INotifyPropertyChanged, INotifyPropertyChanging
  {
    public static bool ReturnDatesInLocalTime = false;
    private static Dictionary<Type, string> _proxyTypes = new Dictionary<Type, string>();
    private Dictionary<string, object> _changedValues = new Dictionary<string, object>();
    private BaseProxyClass.AttributeEqualityComparer _equalityComparer = new BaseProxyClass.AttributeEqualityComparer();

    protected BaseProxyClass(Entity original)
    {
      this.LogicalName = !string.IsNullOrEmpty(original.LogicalName) ? BaseProxyClass.GetLogicalName(((object) this).GetType()) : throw new Exception("Please specify the 'logicalName' on the entity when using a proxy class.");
      this.LogicalName = !(this.LogicalName != original.LogicalName) ? original.LogicalName : throw new Exception("Please make sure that the entity logical name matches that of the proxy class you are creating.");
      ((DataCollection<Relationship, EntityCollection>) this.RelatedEntities).Clear();
      ((DataCollection<string, string>) this.FormattedValues).Clear();
      this.Attributes = original.Attributes;
      ((DataCollection<Relationship, EntityCollection>) this.RelatedEntities).AddRange((IEnumerable<KeyValuePair<Relationship, EntityCollection>>) original.RelatedEntities);
      ((DataCollection<string, string>) this.FormattedValues).AddRange((IEnumerable<KeyValuePair<string, string>>) original.FormattedValues);
      this.ExtensionData = original.ExtensionData;
      this.EntityState = original.EntityState;
      this.Id = original.Id;
    }

    public bool AllColumnsRetrievedFromCrm { get; set; } = false;

    public Guid Create(IOrganizationService service)
    {
      this.Id = service.Create((Entity) this);
      this._changedValues.Clear();
      return this.Id;
    }

    public void Delete(IOrganizationService service) => service.Delete(this.LogicalName, this.Id);

    public void Update(IOrganizationService service)
    {
      if (this._changedValues.Count > 0)
        service.Update(this.GetChangedEntity());
      this._changedValues.Clear();
    }

    public async Task<Guid> CreateAsync(IOrganizationService service)
    {
      Guid async = await Task.Run<Guid>((Func<Guid>) (() => this.Create(service)));
      return async;
    }

    public async Task UpdateAsync(IOrganizationService service)
    {
      await Task.Run((Action) (() => this.Update(service)));
    }

    public async Task DeleteAsync(IOrganizationService service)
    {
      await Task.Run((Action) (() => this.Delete(service)));
    }

    public Entity GetChangedEntity()
    {
      Entity changedEntity = new Entity(this.LogicalName);
      changedEntity.Id = this.Id;
      foreach (string key in this._changedValues.Keys)
        ((DataCollection<string, object>) changedEntity.Attributes)[key] = ((DataCollection<string, object>) this.Attributes)[key];
      return changedEntity;
    }

    public void Save(IOrganizationService service)
    {
      if (this.Id != Guid.Empty)
        this.Update(service);
      else
        this.Create(service);
    }

    public async Task SaveAsync(IOrganizationService service)
    {
      await Task.Run((Action) (() => this.Save(service)));
    }

    public static BaseProxyClass CreateProxyType(Entity entity)
    {
      if (!BaseProxyClass._proxyTypes.ContainsValue(entity.LogicalName))
        BaseProxyClass.RegisterProxyTypesInAssembly(typeof (BaseProxyClass).Assembly);
      if (!BaseProxyClass._proxyTypes.ContainsValue(entity.LogicalName))
        throw new Exception("The proxy class for type '" + entity.LogicalName + "' has not been registered.");
      return (BaseProxyClass) BaseProxyClass._proxyTypes.Keys.Where<Type>((Func<Type, bool>) (ProxyTypeTemp => BaseProxyClass._proxyTypes[ProxyTypeTemp] == entity.LogicalName)).FirstOrDefault<Type>().GetConstructor(new Type[1]
      {
        typeof (Entity)
      }).Invoke(new object[1]{ (object) entity });
    }

    public static void RegisterProxyType(Type ProxyType, string logicalName)
    {
      if (BaseProxyClass._proxyTypes.ContainsKey(ProxyType))
        return;
      BaseProxyClass._proxyTypes.Add(ProxyType, logicalName);
    }

    public static void RegisterProxyTypesInAssembly(Assembly assembly)
    {
      if (!(assembly != (Assembly) null))
        return;
      foreach (Type type in assembly.GetTypes())
        RuntimeHelpers.RunClassConstructor(type.TypeHandle);
    }

    public static string GetLogicalName<T>() where T : BaseProxyClass
    {
      return BaseProxyClass.GetLogicalName(typeof (T));
    }

    public static string GetLogicalName(Type type)
    {
      if (!BaseProxyClass._proxyTypes.ContainsKey(type))
        type.GetConstructor(new Type[0]).Invoke(new object[0]);
      return BaseProxyClass._proxyTypes[type];
    }

    public static implicit operator EntityReference(BaseProxyClass proxy)
    {
      return proxy?.ToEntityReference();
    }

    public T GetPropertyValue<T>(string name)
    {
      if (!this.Contains(name))
        return default (T);
      T propertyValue = (T) ((DataCollection<string, object>) this.Attributes)[name];
      if ((typeof (T) == typeof (DateTime) || typeof (T) == typeof (DateTime?)) && BaseProxyClass.ReturnDatesInLocalTime && (object) propertyValue != null)
        propertyValue = (T) (ValueType) ((DateTime) (object) propertyValue).ToLocalTime();
      return propertyValue;
    }

    public void SetPropertyValue<T>(string name, T value, string propertyName)
    {
      object propertyValue = this.Contains(name) ? (object) this.GetPropertyValue<T>(name) : (object) null;
      if ((propertyValue != null || this.AllColumnsRetrievedFromCrm) && this._equalityComparer.Equals(propertyValue, (object) value))
        return;
      this.OnPropertyChanging(propertyName);
      object x;
      if (this._changedValues.TryGetValue(name, out x))
      {
        if (this._equalityComparer.Equals(x, (object) value))
          this._changedValues.Remove(name);
      }
      else
        this._changedValues.Add(name, propertyValue);
      ((DataCollection<string, object>) this.Attributes)[name] = (object) value;
      this.OnPropertyChanged(propertyName);
    }

    private void OnPropertyChanging(string propertyName)
    {
      if (this.PropertyChanging == null)
        return;
      this.PropertyChanging((object) this, new PropertyChangingEventArgs(propertyName));
    }

    private void OnPropertyChanged(string propertyName)
    {
      if (this.PropertyChanged == null)
        return;
      this.PropertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    public void SetPropertyValue(string name, string value, int maxLength, string propertyName)
    {
      BaseProxyClass.eTextOptions textOptions = this.GetTextOptions(name);
      if (textOptions != BaseProxyClass.eTextOptions.Ignore && !string.IsNullOrEmpty(value) && value.Length > maxLength)
      {
        if (textOptions == BaseProxyClass.eTextOptions.Truncate)
          value = value.Substring(0, maxLength);
        else
          throw new Exception(string.Format(this.GetErrorString(name, BaseProxyClass.eErrorType.Text), (object) name, (object) value, (object) value.Length, (object) maxLength));
      }
      this.SetPropertyValue<string>(name, value, propertyName);
    }

    public void SetPropertyValue(
      string name,
      int? value,
      int minValue,
      int maxValue,
      string propertyName)
    {
      BaseProxyClass.eNumberOptions numberOptions = this.GetNumberOptions(name);
      int? nullable;
      int num1;
      if (numberOptions != BaseProxyClass.eNumberOptions.Ignore)
      {
        nullable = value;
        int num2 = minValue;
        if (!(nullable.GetValueOrDefault() < num2 & nullable.HasValue))
        {
          nullable = value;
          int num3 = maxValue;
          num1 = nullable.GetValueOrDefault() > num3 & nullable.HasValue ? 1 : 0;
        }
        else
          num1 = 1;
      }
      else
        num1 = 0;
      if (num1 != 0)
      {
        bool flag = false;
        int num4;
        switch (numberOptions)
        {
          case BaseProxyClass.eNumberOptions.CorrectMinIgnoreMax:
            nullable = value;
            int num5 = minValue;
            value = nullable.GetValueOrDefault() < num5 & nullable.HasValue ? new int?(minValue) : value;
            goto label_20;
          case BaseProxyClass.eNumberOptions.CorrectMinThrowMax:
            nullable = value;
            int num6 = minValue;
            num4 = nullable.GetValueOrDefault() < num6 & nullable.HasValue ? 1 : 0;
            break;
          case BaseProxyClass.eNumberOptions.CorrectMinAndMax:
            ref int? local = ref value;
            nullable = value;
            int num7 = minValue;
            int num8 = nullable.GetValueOrDefault() < num7 & nullable.HasValue ? minValue : maxValue;
            local = new int?(num8);
            goto label_20;
          default:
            num4 = 0;
            break;
        }
        if (num4 != 0)
        {
          value = new int?(minValue);
        }
        else
        {
          int num9;
          switch (numberOptions)
          {
            case BaseProxyClass.eNumberOptions.CorrectMaxIgnoreMin:
              nullable = value;
              int num10 = maxValue;
              value = nullable.GetValueOrDefault() > num10 & nullable.HasValue ? new int?(maxValue) : value;
              goto label_20;
            case BaseProxyClass.eNumberOptions.CorrectMaxThrowMin:
              nullable = value;
              int num11 = maxValue;
              num9 = nullable.GetValueOrDefault() > num11 & nullable.HasValue ? 1 : 0;
              break;
            default:
              num9 = 0;
              break;
          }
          if (num9 != 0)
            value = new int?(maxValue);
          else
            flag = true;
        }
label_20:
        if (flag)
          throw new Exception(string.Format(this.GetErrorString(name, BaseProxyClass.eErrorType.Number), (object) name, (object) value, (object) minValue, (object) maxValue));
      }
      this.SetPropertyValue<int?>(name, value, propertyName);
    }

    public void SetPropertyValue(
      string name,
      Decimal? value,
      Decimal minValue,
      Decimal maxValue,
      string propertyName)
    {
      BaseProxyClass.eNumberOptions numberOptions = this.GetNumberOptions(name);
      Decimal? nullable;
      int num1;
      if (numberOptions != BaseProxyClass.eNumberOptions.Ignore)
      {
        nullable = value;
        Decimal num2 = minValue;
        if (!(nullable.GetValueOrDefault() < num2 & nullable.HasValue))
        {
          nullable = value;
          Decimal num3 = maxValue;
          num1 = nullable.GetValueOrDefault() > num3 & nullable.HasValue ? 1 : 0;
        }
        else
          num1 = 1;
      }
      else
        num1 = 0;
      if (num1 != 0)
      {
        bool flag = false;
        int num4;
        switch (numberOptions)
        {
          case BaseProxyClass.eNumberOptions.CorrectMinIgnoreMax:
            nullable = value;
            Decimal num5 = minValue;
            value = nullable.GetValueOrDefault() < num5 & nullable.HasValue ? new Decimal?(minValue) : value;
            goto label_20;
          case BaseProxyClass.eNumberOptions.CorrectMinThrowMax:
            nullable = value;
            Decimal num6 = minValue;
            num4 = nullable.GetValueOrDefault() < num6 & nullable.HasValue ? 1 : 0;
            break;
          case BaseProxyClass.eNumberOptions.CorrectMinAndMax:
            ref Decimal? local = ref value;
            nullable = value;
            Decimal num7 = minValue;
            Decimal num8 = nullable.GetValueOrDefault() < num7 & nullable.HasValue ? minValue : maxValue;
            local = new Decimal?(num8);
            goto label_20;
          default:
            num4 = 0;
            break;
        }
        if (num4 != 0)
        {
          value = new Decimal?(minValue);
        }
        else
        {
          int num9;
          switch (numberOptions)
          {
            case BaseProxyClass.eNumberOptions.CorrectMaxIgnoreMin:
              nullable = value;
              Decimal num10 = maxValue;
              value = nullable.GetValueOrDefault() > num10 & nullable.HasValue ? new Decimal?(maxValue) : value;
              goto label_20;
            case BaseProxyClass.eNumberOptions.CorrectMaxThrowMin:
              nullable = value;
              Decimal num11 = maxValue;
              num9 = nullable.GetValueOrDefault() > num11 & nullable.HasValue ? 1 : 0;
              break;
            default:
              num9 = 0;
              break;
          }
          if (num9 != 0)
            value = new Decimal?(maxValue);
          else
            flag = true;
        }
label_20:
        if (flag)
          throw new Exception(string.Format(this.GetErrorString(name, BaseProxyClass.eErrorType.Number), (object) name, (object) value, (object) minValue, (object) maxValue));
      }
      this.SetPropertyValue<Decimal?>(name, value, propertyName);
    }

    public void SetPropertyValue(
      string name,
      double? value,
      double minValue,
      double maxValue,
      string propertyName)
    {
      BaseProxyClass.eNumberOptions numberOptions = this.GetNumberOptions(name);
      double? nullable;
      int num1;
      if (numberOptions != BaseProxyClass.eNumberOptions.Ignore)
      {
        nullable = value;
        double num2 = minValue;
        if (!(nullable.GetValueOrDefault() < num2 & nullable.HasValue))
        {
          nullable = value;
          double num3 = maxValue;
          num1 = nullable.GetValueOrDefault() > num3 & nullable.HasValue ? 1 : 0;
        }
        else
          num1 = 1;
      }
      else
        num1 = 0;
      if (num1 != 0)
      {
        bool flag = false;
        int num4;
        switch (numberOptions)
        {
          case BaseProxyClass.eNumberOptions.CorrectMinIgnoreMax:
            nullable = value;
            double num5 = minValue;
            value = nullable.GetValueOrDefault() < num5 & nullable.HasValue ? new double?(minValue) : value;
            goto label_20;
          case BaseProxyClass.eNumberOptions.CorrectMinThrowMax:
            nullable = value;
            double num6 = minValue;
            num4 = nullable.GetValueOrDefault() < num6 & nullable.HasValue ? 1 : 0;
            break;
          case BaseProxyClass.eNumberOptions.CorrectMinAndMax:
            ref double? local = ref value;
            nullable = value;
            double num7 = minValue;
            double num8 = nullable.GetValueOrDefault() < num7 & nullable.HasValue ? minValue : maxValue;
            local = new double?(num8);
            goto label_20;
          default:
            num4 = 0;
            break;
        }
        if (num4 != 0)
        {
          value = new double?(minValue);
        }
        else
        {
          int num9;
          switch (numberOptions)
          {
            case BaseProxyClass.eNumberOptions.CorrectMaxIgnoreMin:
              nullable = value;
              double num10 = maxValue;
              value = nullable.GetValueOrDefault() > num10 & nullable.HasValue ? new double?(maxValue) : value;
              goto label_20;
            case BaseProxyClass.eNumberOptions.CorrectMaxThrowMin:
              nullable = value;
              double num11 = maxValue;
              num9 = nullable.GetValueOrDefault() > num11 & nullable.HasValue ? 1 : 0;
              break;
            default:
              num9 = 0;
              break;
          }
          if (num9 != 0)
            value = new double?(maxValue);
          else
            flag = true;
        }
label_20:
        if (flag)
          throw new Exception(string.Format(this.GetErrorString(name, BaseProxyClass.eErrorType.Number), (object) name, (object) value, (object) minValue, (object) maxValue));
      }
      this.SetPropertyValue<double?>(name, value, propertyName);
    }

    public void SetPropertyValue(
      string name,
      Money value,
      Decimal minValue,
      Decimal maxValue,
      string propertyName)
    {
      BaseProxyClass.eNumberOptions numberOptions = this.GetNumberOptions(name);
      if (value != null && numberOptions != BaseProxyClass.eNumberOptions.Ignore && (value.Value < minValue || value.Value > maxValue))
      {
        bool flag = false;
        int num1;
        switch (numberOptions)
        {
          case BaseProxyClass.eNumberOptions.CorrectMinIgnoreMax:
            value.Value = value.Value < minValue ? minValue : value.Value;
            goto label_15;
          case BaseProxyClass.eNumberOptions.CorrectMinThrowMax:
            num1 = value.Value < minValue ? 1 : 0;
            break;
          case BaseProxyClass.eNumberOptions.CorrectMinAndMax:
            value.Value = value.Value < minValue ? minValue : maxValue;
            goto label_15;
          default:
            num1 = 0;
            break;
        }
        if (num1 != 0)
        {
          value.Value = minValue;
        }
        else
        {
          int num2;
          switch (numberOptions)
          {
            case BaseProxyClass.eNumberOptions.CorrectMaxIgnoreMin:
              value.Value = value.Value > maxValue ? maxValue : value.Value;
              goto label_15;
            case BaseProxyClass.eNumberOptions.CorrectMaxThrowMin:
              num2 = value.Value > maxValue ? 1 : 0;
              break;
            default:
              num2 = 0;
              break;
          }
          if (num2 != 0)
            value.Value = maxValue;
          else
            flag = true;
        }
label_15:
        if (flag)
          throw new Exception(string.Format(this.GetErrorString(name, BaseProxyClass.eErrorType.Number), (object) name, (object) value.Value, (object) minValue, (object) maxValue));
      }
      this.SetPropertyValue<Money>(name, value, propertyName);
    }

    protected abstract BaseProxyClass.eTextOptions GetTextOptions(string logicalName);

    protected abstract string GetErrorString(
      string attributeName,
      BaseProxyClass.eErrorType defaultErrorType);

    protected abstract BaseProxyClass.eNumberOptions GetNumberOptions(string logicalName);

    public bool IsDirty => this._changedValues.Count > 0;

    public static List<T> GetRelatedOneToManyEntities<T>(
      IOrganizationService service,
      Guid relatedId,
      string logicalName,
      string attributeName,
      params string[] columns)
      where T : BaseProxyClass
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, relatedId, logicalName, attributeName, columns).ToProxies<T>();
    }

    public static List<T> GetRelatedOneToManyEntities<T>(
      IOrganizationService service,
      Guid relatedId,
      string logicalName,
      string attributeName,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, relatedId, logicalName, attributeName, columns).ToProxies<T>();
    }

    public static List<Entity> GetRelatedOneToManyEntities(
      IOrganizationService service,
      Guid relatedId,
      string logicalName,
      string attributeName,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedOneToManyEntities(service, relatedId, logicalName, attributeName, ExtensionMethods.GetColumnSet(columns));
    }

    public static List<Entity> GetRelatedOneToManyEntities(
      IOrganizationService service,
      Guid relatedId,
      string logicalName,
      string attributeName,
      ColumnSet columns)
    {
      return ((IEnumerable<Entity>) service.RetrieveMultiple(logicalName, new ConditionExpression(attributeName, (ConditionOperator) 0, (object) relatedId), columns).Entities).ToList<Entity>();
    }

    public static List<T> GetRelatedManyToManyEntities<T>(
      IOrganizationService service,
      BaseProxyClass proxy,
      string linkFromEntityTypeName,
      string linkFromAttributeName,
      string linkToEntityTypeName,
      string linkToAttributeName,
      string intermediateEntityName,
      string intermediateFromAttributeName,
      string intermediateToAttributeName,
      params string[] columns)
      where T : BaseProxyClass
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, proxy, linkFromEntityTypeName, linkFromAttributeName, linkToEntityTypeName, linkToAttributeName, intermediateEntityName, intermediateFromAttributeName, intermediateToAttributeName, columns).ToProxies<T>();
    }

    public static List<T> GetRelatedManyToManyEntities<T>(
      IOrganizationService service,
      BaseProxyClass proxy,
      string linkFromEntityTypeName,
      string linkFromAttributeName,
      string linkToEntityTypeName,
      string linkToAttributeName,
      string intermediateEntityName,
      string intermediateFromAttributeName,
      string intermediateToAttributeName,
      ColumnSet columns)
      where T : BaseProxyClass
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, proxy, linkFromEntityTypeName, linkFromAttributeName, linkToEntityTypeName, linkToAttributeName, intermediateEntityName, intermediateFromAttributeName, intermediateToAttributeName, columns).ToProxies<T>();
    }

    public static List<Entity> GetRelatedManyToManyEntities(
      IOrganizationService service,
      BaseProxyClass proxy,
      string linkFromEntityTypeName,
      string linkFromAttributeName,
      string linkToEntityTypeName,
      string linkToAttributeName,
      string intermediateEntityName,
      string intermediateFromAttributeName,
      string intermediateToAttributeName,
      params string[] columns)
    {
      return BaseProxyClass.GetRelatedManyToManyEntities(service, proxy, linkFromEntityTypeName, linkFromAttributeName, linkToEntityTypeName, linkToAttributeName, intermediateEntityName, intermediateFromAttributeName, intermediateToAttributeName, ExtensionMethods.GetColumnSet(columns));
    }

    public static List<Entity> GetRelatedManyToManyEntities(
      IOrganizationService service,
      BaseProxyClass proxy,
      string linkFromEntityTypeName,
      string linkFromAttributeName,
      string linkToEntityTypeName,
      string linkToAttributeName,
      string intermediateEntityName,
      string intermediateFromAttributeName,
      string intermediateToAttributeName,
      ColumnSet columns)
    {
      QueryExpression queryExpression = new QueryExpression();
      queryExpression.EntityName = linkToEntityTypeName;
      queryExpression.ColumnSet = columns;
      DataCollection<LinkEntity> linkEntities1 = queryExpression.LinkEntities;
      LinkEntity linkEntity1 = new LinkEntity();
      linkEntity1.LinkFromAttributeName = linkToAttributeName;
      linkEntity1.LinkFromEntityName = linkToEntityTypeName;
      linkEntity1.LinkToAttributeName = intermediateToAttributeName;
      linkEntity1.LinkToEntityName = intermediateEntityName;
      DataCollection<LinkEntity> linkEntities2 = linkEntity1.LinkEntities;
      LinkEntity linkEntity2 = new LinkEntity();
      linkEntity2.LinkFromAttributeName = intermediateFromAttributeName;
      linkEntity2.LinkFromEntityName = intermediateEntityName;
      linkEntity2.LinkToAttributeName = linkFromAttributeName;
      linkEntity2.LinkToEntityName = linkFromEntityTypeName;
      LinkEntity linkEntity3 = linkEntity2;
      FilterExpression filterExpression1 = new FilterExpression();
      ((Collection<ConditionExpression>) filterExpression1.Conditions).Add(new ConditionExpression(linkFromAttributeName, (ConditionOperator) 0, new object[1]
      {
        (object) proxy.Id
      }));
      FilterExpression filterExpression2 = filterExpression1;
      linkEntity3.LinkCriteria = filterExpression2;
      LinkEntity linkEntity4 = linkEntity2;
      ((Collection<LinkEntity>) linkEntities2).Add(linkEntity4);
      LinkEntity linkEntity5 = linkEntity1;
      ((Collection<LinkEntity>) linkEntities1).Add(linkEntity5);
      QueryExpression query = queryExpression;
      return ((IEnumerable<Entity>) service.RetrieveMultipleAllPages(query).Entities).ToList<Entity>();
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public event PropertyChangingEventHandler PropertyChanging;

    private class AttributeEqualityComparer : IEqualityComparer
    {
      public bool Equals(object x, object y)
      {
        if ((x == null || x.GetType() == typeof (string) && string.IsNullOrEmpty(x as string)) && (y == null || y.GetType() == typeof (string) && string.IsNullOrEmpty(y as string)) || x == null && y == null)
          return true;
        if (x == null && y != null || x != null && y == null || !(x.GetType() == y.GetType()))
          return false;
        if (x.GetType() == typeof (OptionSetValue))
          return ((OptionSetValue) x).Value == ((OptionSetValue) y).Value;
        if (x.GetType() == typeof (BooleanManagedProperty))
          return ((ManagedProperty<bool>) x).Value == ((ManagedProperty<bool>) y).Value;
        if (x.GetType() == typeof (EntityReference))
          return ((EntityReference) x).LogicalName == ((EntityReference) y).LogicalName && ((EntityReference) x).Id == ((EntityReference) y).Id;
        if (x.GetType() == typeof (Money))
          return ((Money) x).Value == ((Money) y).Value;
        return x.GetType() == typeof (DateTime) || x.GetType() == typeof (DateTime?) ? Math.Abs(((DateTime) x - (DateTime) y).TotalSeconds) < 1.0 : x.Equals(y);
      }

      public int GetHashCode(object obj) => obj.GetHashCode();
    }

    public enum eTextOptions
    {
      Ignore,
      Truncate,
      ThrowError,
    }

    public enum eNumberOptions
    {
      Ignore,
      CorrectMinIgnoreMax,
      CorrectMinThrowMax,
      CorrectMaxIgnoreMin,
      CorrectMaxThrowMin,
      CorrectMinAndMax,
      ThrowError,
    }

    public enum eErrorType
    {
      Text,
      Number,
    }
  }
}
