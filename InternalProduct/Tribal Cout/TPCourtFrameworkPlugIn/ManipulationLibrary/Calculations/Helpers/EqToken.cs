// Decompiled with JetBrains decompiler
// Type: ManipulationLibrary.Calculations.Helpers.EqToken
// Assembly: TPCourt.Framework.PlugIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f14fc1be7d1161af
// MVID: 615270E2-97DB-4878-8B8F-88925A0FA667
// Assembly location: C:\Users\kstudsrud\Downloads\TPBasePlugins_2024_01_18_1\PluginAssemblies\TPCourtFrameworkPlugIn-41F62F3A-2F19-44F2-86DD-4C4AA2D959EF\TPCourtFrameworkPlugIn.dll

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
