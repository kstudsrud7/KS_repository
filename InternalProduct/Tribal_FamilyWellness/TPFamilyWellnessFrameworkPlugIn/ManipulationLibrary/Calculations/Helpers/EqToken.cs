// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.Helpers.EqToken
// Assembly: TPFamilyWellness.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: C0DF2365-4BFC-418D-B654-2FF4D2B8EB1A
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPFamilyWellnessFrameworkPlugIn-A0924F88-EA00-EA11-A82D-000D3A1F0599\TPFamilyWellnessFrameworkPlugIn.dll

using System;

#nullable disable
namespace ManipulationLibrary.Calculations.Helpers
{
  [Serializable]
  public class EqToken
  {
    private double _dvalue;

    public double DValue
    {
      get => this._dvalue;
      set
      {
        this._dvalue = value;
        this.Value = string.Format("{0:0.0#####}", (object) this._dvalue);
      }
    }

    public int NumberOfOperands { get; set; }

    public EqOperator Op { get; set; }

    public TokenCategory Type { get; set; }

    public string Value { get; set; }

    public EqToken()
    {
    }

    public EqToken(string value)
    {
      this.Value = value;
      this.Type = TokenCategory.Invalid;
      double result;
      if (double.TryParse(value, out result))
      {
        this.Type = TokenCategory.Number;
        this.DValue = result;
        this.NumberOfOperands = 0;
      }
      else
      {
        switch (value)
        {
          case ",":
            this.Type = TokenCategory.ArgumentSeparator;
            break;
          case "(":
            this.Type = TokenCategory.LeftParenthesis;
            break;
          case ")":
            this.Type = TokenCategory.RightParenthesis;
            break;
          default:
            if (!EqOperator.Operators.ContainsKey(value))
              break;
            EqOperator eqOperator = EqOperator.Operators[value];
            if (eqOperator.Type == TokenCategory.Constant)
            {
              this.DValue = this.Op.Calculate();
              this.Type = TokenCategory.Number;
              this.NumberOfOperands = 0;
              break;
            }
            this.Op = eqOperator;
            this.Type = this.Op.Type;
            this.NumberOfOperands = 1;
            break;
        }
      }
    }
  }
}
