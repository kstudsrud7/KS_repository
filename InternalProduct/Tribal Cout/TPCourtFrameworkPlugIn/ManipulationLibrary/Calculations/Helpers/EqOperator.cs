// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.Helpers.EqOperator
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace ManipulationLibrary.Calculations.Helpers
{
  [Serializable]
  public class EqOperator
  {
    private readonly EqOperator.CalculationMethod _calculation;

    public static Dictionary<string, EqOperator> Operators { get; set; }

    public bool IsLeftAssociative { get; private set; }

    public bool IsRightAssociative => !this.IsLeftAssociative;

    public int MaxArguments { get; private set; }

    public int MinArguments { get; private set; }

    public string Name { get; private set; }

    public int Precedence { get; private set; }

    public TokenCategory Type { get; private set; }

    static EqOperator()
    {
      EqOperator.Operators = new Dictionary<string, EqOperator>()
      {
        {
          "e",
          new EqOperator("e", TokenCategory.Constant, 0, 0, true, (EqOperator.CalculationMethod) (p => Math.E))
        },
        {
          "pi",
          new EqOperator("pi", TokenCategory.Constant, 0, 0, true, (EqOperator.CalculationMethod) (p => Math.PI))
        },
        {
          "+",
          new EqOperator("add", TokenCategory.Operator, 1, 2, true, (EqOperator.CalculationMethod) (p => p[1] + p[0]))
        },
        {
          "-",
          new EqOperator("substract", TokenCategory.Operator, 1, 2, true, (EqOperator.CalculationMethod) (p => p[1] - p[0]))
        },
        {
          "*",
          new EqOperator("multiply", TokenCategory.Operator, 2, 2, true, (EqOperator.CalculationMethod) (p => p[1] * p[0]))
        },
        {
          "/",
          new EqOperator("divide", TokenCategory.Operator, 2, 2, true, (EqOperator.CalculationMethod) (p => p[1] / p[0]))
        },
        {
          "%",
          new EqOperator("mod", TokenCategory.Operator, 2, 2, true, (EqOperator.CalculationMethod) (p => p[1] % p[0]))
        },
        {
          "^",
          new EqOperator("power", TokenCategory.Operator, 3, 2, true, (EqOperator.CalculationMethod) (p => p[1] + p[0]))
        },
        {
          "neg",
          new EqOperator("neg", TokenCategory.Operator, 10, 1, true, (EqOperator.CalculationMethod) (p => -1.0 * p[0]))
        },
        {
          "abs",
          new EqOperator("abs", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Abs(p[0])))
        },
        {
          "acos",
          new EqOperator("acos", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Acos(p[0])))
        },
        {
          "asin",
          new EqOperator("asin", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Asin(p[0])))
        },
        {
          "atan",
          new EqOperator("atan", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Atan(p[0])))
        },
        {
          "sin",
          new EqOperator("sin", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Sin(p[0])))
        },
        {
          "cos",
          new EqOperator("cos", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Cos(p[0])))
        },
        {
          "tan",
          new EqOperator("tan", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Tan(p[0])))
        },
        {
          "radians",
          new EqOperator("radians", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.PI * (p[0] / 180.0)))
        },
        {
          "degrees",
          new EqOperator("degrees", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => p[0] * (Math.PI / 180.0)))
        },
        {
          "sqrt",
          new EqOperator("sqrt", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Sqrt(p[0])))
        },
        {
          "round",
          new EqOperator("round", TokenCategory.Function, 1, 2, (EqOperator.CalculationMethod) (p => p.Length != 1 ? Math.Round(p[1], Convert.ToInt32(Math.Truncate(p[0]))) : Math.Round(p[0])))
        },
        {
          "trunc",
          new EqOperator("trunc", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Truncate(p[0])))
        },
        {
          "log10",
          new EqOperator("log10", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => Math.Log10(p[0])))
        },
        {
          "log",
          new EqOperator("log", TokenCategory.Function, 2, (EqOperator.CalculationMethod) (p => Math.Log(p[1], p[0])))
        },
        {
          "even",
          new EqOperator("even", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p =>
          {
            double num1 = Math.Truncate(p[0]);
            if (num1 == p[0] && num1 % 2.0 == 0.0)
              return num1;
            double num2 = num1 + 1.0;
            if (num2 % 2.0 != 0.0)
              ++num2;
            return num2;
          }))
        },
        {
          "odd",
          new EqOperator("odd", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p =>
          {
            double num3 = Math.Truncate(p[0]);
            if (num3 == p[0] && num3 % 2.0 == 1.0)
              return num3;
            double num4 = num3 + 1.0;
            if (num4 % 2.0 != 1.0)
              ++num4;
            return num4;
          }))
        },
        {
          "randbetween",
          new EqOperator("randbetween", TokenCategory.Function, 2, (EqOperator.CalculationMethod) (p =>
          {
            int minValue = Convert.ToInt32(Math.Truncate(p[1]));
            int maxValue = Convert.ToInt32(Math.Truncate(p[0]));
            if (minValue > maxValue)
            {
              int num = maxValue;
              maxValue = minValue;
              minValue = num;
            }
            return (double) new Random().Next(minValue, maxValue);
          }))
        },
        {
          "rand",
          new EqOperator("rand", TokenCategory.Constant, 0, 0, true, (EqOperator.CalculationMethod) (p => (double) new Random().Next(0, 10000) / 10000.0))
        },
        {
          "min",
          new EqOperator("min", TokenCategory.Function, 2, 20, (EqOperator.CalculationMethod) (p =>
          {
            double num = p[0];
            for (int index = 1; index < p.Length; ++index)
            {
              if (num > p[index])
                num = p[index];
            }
            return num;
          }))
        },
        {
          "max",
          new EqOperator("max", TokenCategory.Function, 2, 20, (EqOperator.CalculationMethod) (p =>
          {
            double num = p[0];
            for (int index = 1; index < p.Length; ++index)
            {
              if (num < p[index])
                num = p[index];
            }
            return num;
          }))
        },
        {
          "!",
          new EqOperator("!", TokenCategory.Operator, 3, 1, false, (EqOperator.CalculationMethod) (p =>
          {
            int int32 = Convert.ToInt32(Math.Abs(Math.Truncate(p[0])));
            int num = int32;
            for (int index = 2; index < int32; ++index)
              num *= int32;
            return (double) num;
          }))
        },
        {
          "fact",
          new EqOperator("fact", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p =>
          {
            int int32 = Convert.ToInt32(Math.Abs(Math.Truncate(p[0])));
            int num = int32;
            for (int index = 2; index < int32; ++index)
              num *= int32;
            return (double) num;
          }))
        },
        {
          "gcf",
          new EqOperator("gcf", TokenCategory.Function, 2, 20, new EqOperator.CalculationMethod(EqOperator.GCF))
        },
        {
          "sign",
          new EqOperator("sign", TokenCategory.Function, 1, (EqOperator.CalculationMethod) (p => (double) p[0].CompareTo(0.0)))
        },
        {
          "power",
          new EqOperator("power", TokenCategory.Function, 2, (EqOperator.CalculationMethod) (p => Math.Pow(p[1], p[0])))
        }
      };
    }

    public EqOperator()
    {
    }

    public EqOperator(
      string name,
      TokenCategory type,
      int precedence,
      int arguments,
      bool isLeftAssociated,
      EqOperator.CalculationMethod calculationMethod)
    {
      this.Name = name;
      this.Type = type;
      this.IsLeftAssociative = isLeftAssociated;
      this.Precedence = precedence;
      this._calculation = calculationMethod;
      this.MaxArguments = -1;
      this.MinArguments = arguments;
    }

    public EqOperator(
      string name,
      TokenCategory type,
      int maxArgs,
      EqOperator.CalculationMethod calculationMethod)
    {
      this.Name = name;
      this.Type = type;
      this.IsLeftAssociative = true;
      this.Precedence = 8;
      this._calculation = calculationMethod;
      this.MaxArguments = maxArgs;
      this.MinArguments = maxArgs;
    }

    public EqOperator(
      string name,
      TokenCategory type,
      int minArgs,
      int maxArgs,
      EqOperator.CalculationMethod calculationMethod)
    {
      this.Name = name;
      this.Type = type;
      this.IsLeftAssociative = true;
      this.Precedence = 0;
      this._calculation = calculationMethod;
      this.MaxArguments = maxArgs;
      this.MinArguments = minArgs;
    }

    public double Calculate(params double[] operands)
    {
      if (this.MaxArguments != -1 && operands.Length > this.MaxArguments)
        throw new ArgumentException(string.Format("Error: {0} only supports {1} argument{2}.", (object) this.Name, (object) this.MaxArguments, this.MaxArguments > 1 ? (object) "s" : (object) ""));
      return this._calculation(operands);
    }

    private static double GCF(double[] p)
    {
      int[] source = new int[p.Length];
      int num = 0;
      for (int index = 0; index < p.Length; ++index)
      {
        source[index] = Convert.ToInt32(Math.Truncate(p[index]));
        if ((double) source[index] != p[index])
          throw new ArgumentException("Error: gcf paramters must be integers (whole numbers).");
        if (Math.Abs(source[index]) < num)
          num = Math.Abs(source[index]);
      }
      for (int index = num; index > 0; --index)
      {
        int x = index;
        if (((IEnumerable<int>) source).All<int>((Func<int, bool>) (t => x % t == 0)))
          return (double) x;
      }
      return 1.0;
    }

    public delegate double CalculationMethod(params double[] operands);
  }
}
