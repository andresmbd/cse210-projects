public class Fraction
{
   private int _top;
   private int _buttom;

   public Fraction()
   {
    _top = 1;
    _buttom = 1;
   }

   public Fraction(int numerator)
   {
    _top = numerator;
    _buttom = 2;
   }

   public Fraction(int numerator, int denominator)
   {
    _top = numerator;
    _buttom = denominator;
   }

   public int GetTop()
   {
    return _top;
   }

    public void SetTop(int numerator)
    {
        _top = numerator;
    }

    public int GetButtom()
    {
        return _buttom;
    }

    public void SetButtom(int denominator)
    {
        _buttom = denominator;
    }

    public string GetFractionString()
    {
        string fractionForm = $"{_top}/{_buttom}";
        return fractionForm;
    }

    public double GetDecimalValue()
    {
        return (double) _top / (double) _buttom;
    }

}