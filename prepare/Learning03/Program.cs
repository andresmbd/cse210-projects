using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    { // verifing for calling the three contructor functions
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(17);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(12, 7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());


        // Fraction f4 = new Fraction();
        // f4.SetTop(5);
        // Console.WriteLine(f4.GetTop());

        // Fraction f5 = new Fraction();
        // f5.SetButtom(3);
        // Console.WriteLine(f5.GetButtom());
    }
}