using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction fraction1 = new Fraction();
        Console.WriteLine($" {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");

        
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($" {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($" {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        // Test getters and setters
        fraction3.Numerator = 1;
        fraction3.Denominator = 3;
        Console.WriteLine($": {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");
        
       

    }
}
