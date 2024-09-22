using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string digit;
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter Number: ");
            digit = Console.ReadLine();
            number = int.Parse(digit);

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0); // will continue until 0 is entered

        int sum = 0;
        int max = int.MinValue;

        foreach (int num in numbers)
        {
            sum += num;
            if (num > max)
            {
                max = num;
            }
        }

        double average = (numbers.Count > 0) ? (double)sum / numbers.Count : 0; 
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        
    }
}