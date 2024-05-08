using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction unit = new Fraction();
        Fraction whole = new Fraction(5);
        Fraction fraction1 = new Fraction(3, 4);
        Fraction fraction2 = new Fraction(1, 3);

        Console.WriteLine(unit.GetFractionString());
        Console.WriteLine(unit.GetDecimalValue());

        Console.WriteLine(whole.GetFractionString());
        Console.WriteLine(whole.GetDecimalValue());

        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
    }
}