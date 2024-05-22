// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.SequentialGuid
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  [Serializable]
  public struct SequentialGuid : IComparable<SequentialGuid>, IComparable<Guid>, IComparable
  {
    private const int NumberOfSequenceBytes = 6;
    private const int PermutationsOfAByte = 256;
    private static readonly long MaximumPermutations = (long) Math.Pow(256.0, 6.0);
    private static long _lastSequence;
    private static readonly DateTime SequencePeriodStart = new DateTime(2011, 11, 15, 0, 0, 0, DateTimeKind.Utc);
    private static readonly DateTime SequencePeriodeEnd = new DateTime(2100, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    private readonly Guid _guidValue;
    private static readonly object SynchronizationObject = new object();
    private static readonly int[] IndexOrderingHighLow = new int[16]
    {
      10,
      11,
      12,
      13,
      14,
      15,
      8,
      9,
      7,
      6,
      5,
      4,
      3,
      2,
      1,
      0
    };

    public SequentialGuid(Guid guidValue) => this._guidValue = guidValue;

    public SequentialGuid(string guidValue)
      : this(new Guid(guidValue))
    {
    }

    [SecuritySafeCritical]
    public static SequentialGuid NewSequentialGuid()
    {
      return new SequentialGuid(SequentialGuid.GetGuidValue(DateTime.Now));
    }

    public static TimeSpan TimePerSequence
    {
      get => new TimeSpan(SequentialGuid.TotalPeriod.Ticks / SequentialGuid.MaximumPermutations);
    }

    public static TimeSpan TotalPeriod
    {
      get => SequentialGuid.SequencePeriodeEnd - SequentialGuid.SequencePeriodStart;
    }

    internal static Guid GetGuidValue(DateTime now)
    {
      return now < SequentialGuid.SequencePeriodStart || now >= SequentialGuid.SequencePeriodeEnd ? Guid.NewGuid() : SequentialGuid.GetGuid(SequentialGuid.GetCurrentSequence(now));
    }

    private static long GetCurrentSequence(DateTime now)
    {
      return (long) ((Decimal) (now.Ticks - SequentialGuid.SequencePeriodStart.Ticks) / (Decimal) SequentialGuid.TotalPeriod.Ticks * (Decimal) SequentialGuid.MaximumPermutations);
    }

    private static Guid GetGuid(long sequence)
    {
      lock (SequentialGuid.SynchronizationObject)
      {
        if (sequence <= SequentialGuid._lastSequence)
          sequence = SequentialGuid._lastSequence + 1L;
        SequentialGuid._lastSequence = sequence;
      }
      IEnumerable<byte> sequenceBytes = SequentialGuid.GetSequenceBytes(sequence);
      return new Guid(SequentialGuid.GetGuidBytes().Concat<byte>(sequenceBytes).ToArray<byte>());
    }

    private static IEnumerable<byte> GetSequenceBytes(long sequence)
    {
      return ((IEnumerable<byte>) BitConverter.GetBytes(sequence)).Concat<byte>((IEnumerable<byte>) new byte[6]).Take<byte>(6).Reverse<byte>();
    }

    private static IEnumerable<byte> GetGuidBytes()
    {
      return ((IEnumerable<byte>) Guid.NewGuid().ToByteArray()).Take<byte>(10);
    }

    public DateTime CreatedDateTime => SequentialGuid.GetCreatedDateTime(this._guidValue);

    internal static DateTime GetCreatedDateTime(Guid value)
    {
      return new DateTime((long) ((Decimal) BitConverter.ToInt64(SequentialGuid.GetSequenceLongBytes(value).ToArray<byte>(), 0) / (Decimal) SequentialGuid.MaximumPermutations * (Decimal) SequentialGuid.TotalPeriod.Ticks + (Decimal) SequentialGuid.SequencePeriodStart.Ticks));
    }

    private static IEnumerable<byte> GetSequenceLongBytes(Guid value)
    {
      byte[] array = ((IEnumerable<byte>) value.ToByteArray()).Skip<byte>(10).Reverse<byte>().ToArray<byte>();
      int length = 8 - array.Length;
      return ((IEnumerable<byte>) array).Concat<byte>((IEnumerable<byte>) new byte[length]);
    }

    public static bool operator <(SequentialGuid value1, SequentialGuid value2)
    {
      return value1.CompareTo(value2) < 0;
    }

    public static bool operator >(SequentialGuid value1, SequentialGuid value2)
    {
      return value1.CompareTo(value2) > 0;
    }

    public static bool operator <(Guid value1, SequentialGuid value2)
    {
      return value1.CompareTo((Guid) value2) < 0;
    }

    public static bool operator >(Guid value1, SequentialGuid value2)
    {
      return value1.CompareTo((Guid) value2) > 0;
    }

    public static bool operator <(SequentialGuid value1, Guid value2)
    {
      return value1.CompareTo(value2) < 0;
    }

    public static bool operator >(SequentialGuid value1, Guid value2)
    {
      return value1.CompareTo(value2) > 0;
    }

    public static bool operator <=(SequentialGuid value1, SequentialGuid value2)
    {
      return value1.CompareTo(value2) <= 0;
    }

    public static bool operator >=(SequentialGuid value1, SequentialGuid value2)
    {
      return value1.CompareTo(value2) >= 0;
    }

    public static bool operator <=(Guid value1, SequentialGuid value2)
    {
      return value1.CompareTo((Guid) value2) <= 0;
    }

    public static bool operator >=(Guid value1, SequentialGuid value2)
    {
      return value1.CompareTo((Guid) value2) >= 0;
    }

    public static bool operator <=(SequentialGuid value1, Guid value2)
    {
      return value1.CompareTo(value2) <= 0;
    }

    public static bool operator >=(SequentialGuid value1, Guid value2)
    {
      return value1.CompareTo(value2) >= 0;
    }

    public static bool operator ==(SequentialGuid value1, SequentialGuid value2)
    {
      return value1.CompareTo(value2) == 0;
    }

    public static bool operator !=(SequentialGuid value1, SequentialGuid value2)
    {
      return !(value1 == value2);
    }

    public static bool operator ==(Guid value1, SequentialGuid value2)
    {
      return value1.CompareTo((Guid) value2) == 0;
    }

    public static bool operator !=(Guid value1, SequentialGuid value2) => !(value1 == value2);

    public static bool operator ==(SequentialGuid value1, Guid value2)
    {
      return value1.CompareTo(value2) == 0;
    }

    public static bool operator !=(SequentialGuid value1, Guid value2) => !(value1 == value2);

    public int CompareTo(object obj)
    {
      switch (obj)
      {
        case SequentialGuid other1:
          return this.CompareTo(other1);
        case Guid other2:
          return this.CompareTo(other2);
        default:
          throw new ArgumentException("Parameter is not of the rigt type");
      }
    }

    public int CompareTo(SequentialGuid other) => this.CompareTo(other._guidValue);

    public int CompareTo(Guid other)
    {
      return SequentialGuid.CompareImplementation(this._guidValue, other);
    }

    private static int CompareImplementation(Guid left, Guid right)
    {
      byte[] leftBytes = left.ToByteArray();
      byte[] rightBytes = right.ToByteArray();
      return ((IEnumerable<int>) SequentialGuid.IndexOrderingHighLow).Select<int, int>((Func<int, int>) (i => leftBytes[i].CompareTo(rightBytes[i]))).FirstOrDefault<int>((Func<int, bool>) (r => r != 0));
    }

    public override bool Equals(object obj)
    {
      return (obj is SequentialGuid || obj is Guid) && this.CompareTo(obj) == 0;
    }

    public bool Equals(SequentialGuid other) => this.CompareTo(other) == 0;

    public bool Equals(Guid other) => this.CompareTo(other) == 0;

    public override int GetHashCode() => this._guidValue.GetHashCode();

    public static implicit operator Guid(SequentialGuid value) => value._guidValue;

    public static explicit operator SequentialGuid(Guid value) => new SequentialGuid(value);

    public override string ToString()
    {
      return string.Format("{0} ({1:yyyy-MM-dd HH:mm:ss.fff})", (object) this._guidValue, (object) SequentialGuid.Round(this.CreatedDateTime, TimeSpan.FromMilliseconds(1.0)));
    }

    private static DateTime Round(DateTime dateTime, TimeSpan interval)
    {
      long num = interval.Ticks + 1L >> 1;
      return dateTime.AddTicks(num - (dateTime.Ticks + num) % interval.Ticks);
    }
  }
}
