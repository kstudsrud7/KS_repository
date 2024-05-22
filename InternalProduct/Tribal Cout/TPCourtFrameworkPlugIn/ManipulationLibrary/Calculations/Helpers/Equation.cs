// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.Helpers.Equation
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

#nullable disable
namespace ManipulationLibrary.Calculations.Helpers
{
  [Serializable]
  public class Equation
  {
    private static string _ptnSpacer;
    private static string _ptnNegative;

    public static double Solve(string equation)
    {
      return Equation.Solve(Equation.Postfix(Equation.Clean(equation)));
    }

    private static string Clean(string dirty)
    {
      string lower = dirty.ToLower();
      if (string.IsNullOrEmpty(Equation._ptnSpacer))
        Equation.BuildCleaningPatterns();
      return Regex.Replace(Regex.Replace(Regex.Replace(lower, Equation._ptnSpacer, " ${match} "), "\\s+", " ").Trim().Replace("-", "neg"), Equation._ptnNegative, "${match} -");
    }

    private static void BuildCleaningPatterns()
    {
      List<string> list = EqOperator.Operators.Keys.ToList<string>();
      list.Sort((Comparison<string>) ((a, b) => b.Length.CompareTo(a.Length)));
      StringBuilder stringBuilder1 = new StringBuilder();
      StringBuilder stringBuilder2 = new StringBuilder("[");
      StringBuilder stringBuilder3 = new StringBuilder();
      foreach (string key in list)
      {
        if (key.Length == 1)
        {
          stringBuilder2.Append(key);
        }
        else
        {
          stringBuilder3.Append(key);
          stringBuilder3.Append('|');
        }
        if (EqOperator.Operators[key].Type == TokenCategory.Function || EqOperator.Operators[key].Type == TokenCategory.Constant)
        {
          stringBuilder1.Append('|');
          stringBuilder1.Append(key);
        }
      }
      stringBuilder1.Remove(0, 1);
      stringBuilder2.Replace("-", "\\-");
      stringBuilder2.Append(']');
      stringBuilder3.Append(stringBuilder2.ToString());
      Equation._ptnSpacer = string.Format("(?<match>({0}|[()]|{1}))", (object) "\\d+(\\.\\d+)?", (object) stringBuilder3);
      Equation._ptnNegative = string.Format("(?<match>({0}|{1}))\\sneg", (object) "\\d+(\\.\\d+)?", (object) stringBuilder1);
    }

    private static double Solve(IEnumerable<EqToken> postfix)
    {
      Stack<double> doubleStack = new Stack<double>();
      List<double> doubleList = new List<double>();
      foreach (EqToken eqToken in postfix)
      {
        if (eqToken.Type == TokenCategory.Number)
          doubleStack.Push(eqToken.DValue);
        else if (doubleStack.Count >= 1)
        {
          int num = eqToken.NumberOfOperands;
          if (eqToken.Type == TokenCategory.Operator)
            num = eqToken.Op.MinArguments;
          doubleList.Clear();
          for (int index = 0; index < num; ++index)
            doubleList.Add(doubleStack.Pop());
          doubleStack.Push(eqToken.Op.Calculate(doubleList.ToArray()));
        }
      }
      return doubleStack.Count <= 1 ? doubleStack.Pop() : throw new ArgumentException("Error: Invalid formula.");
    }

    private static IEnumerable<EqToken> Postfix(string infix)
    {
      List<EqToken> eqTokenList = new List<EqToken>();
      Stack<EqToken> eqTokenStack1 = new Stack<EqToken>();
      Stack<EqToken> eqTokenStack2 = new Stack<EqToken>();
      foreach (EqToken eqToken1 in ((IEnumerable<string>) infix.Split(' ')).Select<string, EqToken>((Func<string, EqToken>) (t => new EqToken(t))))
      {
        switch (eqToken1.Type)
        {
          case TokenCategory.Invalid:
            continue;
          case TokenCategory.Number:
            eqTokenList.Add(eqToken1);
            continue;
          case TokenCategory.Function:
            eqTokenStack1.Push(eqToken1);
            eqTokenStack2.Push(eqToken1);
            continue;
          case TokenCategory.ArgumentSeparator:
            if (eqTokenStack2.Count == 0)
              throw new ArgumentException("Error: Arguments specified not in a function.");
            ++eqTokenStack2.Peek().NumberOfOperands;
            if (eqTokenStack1.Peek().Value == "neg")
            {
              eqTokenList.Add(eqTokenStack1.Pop());
              continue;
            }
            continue;
          case TokenCategory.Operator:
            while (eqTokenStack1.Count > 0 && (eqTokenStack1.Peek().Type == TokenCategory.Operator || eqTokenStack1.Peek().Type == TokenCategory.Function))
            {
              EqToken eqToken2 = eqTokenStack1.Peek();
              if (eqToken1.Op.IsLeftAssociative && eqToken1.Op.Precedence <= eqToken2.Op.Precedence || eqToken1.Op.IsRightAssociative && eqToken1.Op.Precedence < eqToken2.Op.Precedence)
                eqTokenList.Add(eqTokenStack1.Pop());
              else
                break;
            }
            eqTokenStack1.Push(eqToken1);
            continue;
          case TokenCategory.LeftParenthesis:
            eqTokenStack1.Push(eqToken1);
            continue;
          case TokenCategory.RightParenthesis:
            if (eqTokenStack1.Count != 0)
            {
              while (eqTokenStack1.Count != 0 && eqTokenStack1.Peek().Type != TokenCategory.LeftParenthesis)
                eqTokenList.Add(eqTokenStack1.Pop());
              if (eqTokenStack1.Count == 0)
                throw new ArgumentException("Error: Unbalanced parenthesis in formula.");
              eqTokenStack1.Pop();
              if (eqTokenStack1.Count > 0 && eqTokenStack1.Peek().Type == TokenCategory.Function)
              {
                eqTokenStack2.Pop();
                eqTokenList.Add(eqTokenStack1.Pop());
                continue;
              }
              continue;
            }
            continue;
          default:
            throw new ArgumentOutOfRangeException();
        }
      }
      while (eqTokenStack1.Count != 0)
      {
        if (eqTokenStack1.Peek().Type == TokenCategory.LeftParenthesis)
          throw new ArgumentException("Error: Unbalanced parenthesis in formula.");
        eqTokenList.Add(eqTokenStack1.Pop());
      }
      return (IEnumerable<EqToken>) eqTokenList;
    }
  }
}
