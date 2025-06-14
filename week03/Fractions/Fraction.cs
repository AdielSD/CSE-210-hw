using System;
public class Fraction
{
    private int _numerator;
    private int _denominator;



    //getters and setters

    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set
        {
            //  denominator is never zero
            if (value == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }

            _denominator = value;


        }



    }


    //DEfault 


    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }


    
     //  return the fraction 3/4 and dat
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // to return decimals
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}

