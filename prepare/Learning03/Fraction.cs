using System;



class Fraction
{
    private int _top;
    private int _bottom;


    public Fraction()
    {
        _bottom = 1;

        _top = 1;
    }


    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    private void SetTop(int top)
    {
        _top = top;
    }

    private void SetBottom(int bottom)
    {
        _bottom = bottom;
    }


    public string GetFractionString()
    {

        string toString = Convert.ToString(_top) + '/' + Convert.ToString(_bottom);
        return toString;
    }



    public double GetDecimalValue()
    {
        double result = _top / _bottom;
        return result;

    }
}