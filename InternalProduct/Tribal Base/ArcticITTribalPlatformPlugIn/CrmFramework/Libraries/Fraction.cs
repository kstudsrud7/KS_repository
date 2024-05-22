// Decompiled with JetBrains decompiler
// Type: ArcticIT.CrmFramework.Libraries.Fraction
// Assembly: ArcticIT.TribalPlatform.PlugIn, Version=1.0.16.12201, Culture=neutral, PublicKeyToken=b2b6f2647677fd07
// MVID: 8AFF6454-F76B-4647-8402-3B791DBBC103
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\ArcticITTribalPlatformPlugIn-019A1BCF-5834-4D97-909C-235CE08C6BBB\ArcticITTribalPlatformPlugIn.dll

using System;
using System.Globalization;
using System.Text;

#nullable disable
namespace ArcticIT.CrmFramework.Libraries
{
  public struct Fraction : IEquatable<Fraction>
  {
    private long _numerator;
    private long _denominator;

    public long Numerator
    {
      get => this._numerator;
      private set => this._numerator = value;
    }

    public long Denominator
    {
      get => this._denominator == 0L ? 1L : this._denominator;
      private set
      {
        this._denominator = value != 0L ? value : throw new InvalidOperationException("Denominator cannot be assigned a 0 Value.");
      }
    }

    public Fraction(long value)
    {
      this._numerator = value;
      this._denominator = 1L;
      this.Reduce();
    }

    public Fraction(long numerator, long denominator)
    {
      if (denominator == 0L)
        throw new InvalidOperationException("Denominator cannot be assigned a 0 Value.");
      this._numerator = numerator;
      this._denominator = denominator;
      this.Reduce();
    }

    private void Reduce()
    {
      try
      {
        if (this.Numerator == 0L)
        {
          this.Denominator = 1L;
        }
        else
        {
          long num = Fraction.GCD(this.Numerator, this.Denominator);
          this.Numerator /= num;
          this.Denominator /= num;
          if (this.Denominator >= 0L)
            return;
          this.Numerator *= -1L;
          this.Denominator *= -1L;
        }
      }
      catch (Exception ex)
      {
        throw new InvalidOperationException("Cannot reduce Fraction: " + ex.Message);
      }
    }

    public bool Equals(Fraction other)
    {
      return this.Numerator == other.Numerator && this.Denominator == other.Denominator;
    }

    public override bool Equals(object obj)
    {
      return obj != null && obj is Fraction && this.Equals((Fraction) obj);
    }

    public override int GetHashCode()
    {
      return Convert.ToInt32((this.Numerator ^ this.Denominator) & (long) uint.MaxValue);
    }

    public override string ToString()
    {
      if (this.Numerator == 0L)
        return "0";
      if (this.Denominator != 0L && (this.Denominator == 1L || this.Denominator == this.Numerator))
        return "4/4";
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.Numerator);
      stringBuilder.Append('/');
      stringBuilder.Append(this.Denominator);
      return stringBuilder.ToString();
    }

    public static Fraction Parse(string strValue)
    {
      if (strValue == null)
        strValue = "0/1";
      int length = strValue.IndexOf('/');
      return length == -1 ? Fraction.DecimalToFraction(Convert.ToDecimal(strValue)) : new Fraction(Convert.ToInt64(strValue.Substring(0, length)), Convert.ToInt64(strValue.Substring(length + 1)));
    }

    public static bool TryParse(string strValue, out Fraction fraction)
    {
      if (!string.IsNullOrWhiteSpace(strValue))
      {
        try
        {
          int length = strValue.IndexOf('/');
          if (length == -1)
          {
            Decimal result;
            if (Decimal.TryParse(strValue, out result))
            {
              fraction = Fraction.DecimalToFraction(result);
              return true;
            }
          }
          else
          {
            long result1;
            long result2;
            if (long.TryParse(strValue.Substring(0, length), out result1) && long.TryParse(strValue.Substring(length + 1), out result2))
            {
              fraction = new Fraction(result1, result2);
              return true;
            }
          }
        }
        catch
        {
        }
      }
      fraction = new Fraction();
      return false;
    }

    private static Fraction DoubleToFraction(double dValue)
    {
      char ch = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
      try
      {
        Fraction fraction;
        if (dValue % 1.0 == 0.0)
        {
          fraction = new Fraction(checked ((long) dValue));
        }
        else
        {
          double a = dValue;
          long denominator = 1;
          string str;
          for (str = dValue.ToString(); str.IndexOf("E") > 0; str = a.ToString())
          {
            a *= 10.0;
            checked { denominator *= 10L; }
          }
          int index = 0;
          while ((int) str[index] != (int) ch)
            checked { ++index; }
          int num = checked (str.Length - index - 1);
          while (num > 0)
          {
            a *= 10.0;
            checked { denominator *= 10L; }
            checked { --num; }
          }
          fraction = new Fraction((long) checked ((int) Math.Round(a)), denominator);
        }
        return fraction;
      }
      catch (OverflowException ex)
      {
        throw new InvalidCastException("Conversion to Fraction in no possible due to overflow.", (Exception) ex);
      }
      catch (Exception ex)
      {
        throw new InvalidCastException("Conversion to Fraction in not possible.", ex);
      }
    }

    private static Fraction DecimalToFraction(Decimal dValue)
    {
      char ch = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
      try
      {
        Fraction fraction;
        if (dValue % 1M == 0M)
        {
          fraction = new Fraction((long) dValue);
        }
        else
        {
          Decimal d = dValue;
          long denominator = 1;
          string str;
          for (str = dValue.ToString(); str.IndexOf("E") > 0; str = d.ToString())
          {
            d *= 10M;
            checked { denominator *= 10L; }
          }
          int index = 0;
          while ((int) str[index] != (int) ch)
            checked { ++index; }
          int num = checked (str.Length - index - 1);
          while (num > 0)
          {
            d *= 10M;
            checked { denominator *= 10L; }
            checked { --num; }
          }
          fraction = new Fraction((long) (int) Math.Round(d), denominator);
        }
        return fraction;
      }
      catch (OverflowException ex)
      {
        throw new InvalidCastException("Conversion to Fraction in no possible due to overflow.", (Exception) ex);
      }
      catch (Exception ex)
      {
        throw new InvalidCastException("Conversion to Fraction in not possible.", ex);
      }
    }

    private static Fraction Inverse(Fraction frac1)
    {
      if (frac1.Numerator == 0L)
        throw new InvalidOperationException("Operation not possible (Denominator cannot be assigned a ZERO Value)");
      return new Fraction(frac1.Denominator, frac1.Numerator);
    }

    private static Fraction Negate(Fraction frac1)
    {
      return new Fraction(-frac1.Numerator, frac1.Denominator);
    }

    private static Fraction Add(Fraction frac1, Fraction frac2)
    {
      try
      {
        return new Fraction(checked (frac1.Numerator * frac2.Denominator + frac2.Numerator * frac1.Denominator), checked (frac1.Denominator * frac2.Denominator));
      }
      catch (OverflowException ex)
      {
        throw new OverflowException("Overflow occurred while performing arithemetic operation on Fraction.", (Exception) ex);
      }
      catch (Exception ex)
      {
        throw new Exception("An error occurred while performing arithemetic operation on Fraction.", ex);
      }
    }

    private static Fraction Multiply(Fraction frac1, Fraction frac2)
    {
      try
      {
        return new Fraction(checked (frac1.Numerator * frac2.Numerator), checked (frac1.Denominator * frac2.Denominator));
      }
      catch (OverflowException ex)
      {
        throw new OverflowException("Overflow occurred while performing arithemetic operation on Fraction.", (Exception) ex);
      }
      catch (Exception ex)
      {
        throw new Exception("An error occurred while performing arithemetic operation on Fraction.", ex);
      }
    }

    private static long GCD(long iNo1, long iNo2)
    {
      if (iNo1 < 0L)
        iNo1 = -iNo1;
      if (iNo2 < 0L)
        iNo2 = -iNo2;
      do
      {
        if (iNo1 < iNo2)
        {
          long num = iNo1;
          iNo1 = iNo2;
          iNo2 = num;
        }
        iNo1 %= iNo2;
      }
      while (iNo1 != 0L);
      return iNo2;
    }

    public static Fraction operator -(Fraction frac1) => Fraction.Negate(frac1);

    public static Fraction operator +(Fraction frac1, Fraction frac2) => Fraction.Add(frac1, frac2);

    public static Fraction operator -(Fraction frac1, Fraction frac2)
    {
      return Fraction.Add(frac1, -frac2);
    }

    public static Fraction operator *(Fraction frac1, Fraction frac2)
    {
      return Fraction.Multiply(frac1, frac2);
    }

    public static Fraction operator /(Fraction frac1, Fraction frac2)
    {
      return Fraction.Multiply(frac1, Fraction.Inverse(frac2));
    }

    public static bool operator ==(Fraction frac1, Fraction frac2) => frac1.Equals(frac2);

    public static bool operator !=(Fraction frac1, Fraction frac2) => !frac1.Equals(frac2);

    public static bool operator <(Fraction frac1, Fraction frac2)
    {
      return frac1.Numerator * frac2.Denominator < frac2.Numerator * frac1.Denominator;
    }

    public static bool operator >(Fraction frac1, Fraction frac2)
    {
      return frac1.Numerator * frac2.Denominator > frac2.Numerator * frac1.Denominator;
    }

    public static bool operator <=(Fraction frac1, Fraction frac2)
    {
      return frac1.Numerator * frac2.Denominator <= frac2.Numerator * frac1.Denominator;
    }

    public static bool operator >=(Fraction frac1, Fraction frac2)
    {
      return frac1.Numerator * frac2.Denominator >= frac2.Numerator * frac1.Denominator;
    }

    public static implicit operator Fraction(long value) => new Fraction(value);

    public static implicit operator Fraction(double value) => Fraction.DoubleToFraction(value);

    public static implicit operator Fraction(Decimal value) => Fraction.DecimalToFraction(value);

    public static explicit operator double(Fraction frac)
    {
      return (double) frac.Numerator / (double) frac.Denominator;
    }

    public static explicit operator Decimal(Fraction frac)
    {
      return (Decimal) frac.Numerator / (Decimal) frac.Denominator;
    }
  }
}
