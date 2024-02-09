using System;

public class Fraction{
    //The following are the atrributes for this program:
    private int _top;

    private int _bottom;
    
    //The following are the constructors for this program:

    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int TopNumber){
        _top = TopNumber;
        _bottom = 1;
        
    }
    public Fraction(int TopNumber, int BottomNumber){
        _top = TopNumber;
        _bottom = BottomNumber;

    }
    //The following are the methods for this program:
     public string GetFractionString(){
        string fractions = $"{_top}/{_bottom}";
        return fractions;

     }

    public double GetDecimalValue(){
        double DecVal = (double)_top/(double)_bottom;
        return DecVal;
    }
}
