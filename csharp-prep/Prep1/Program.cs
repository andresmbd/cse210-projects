using System;

class Program
{
    static void Main(string[] args)
    {
        // ask information from the user
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine("");
        
        Console.Write($"Your name is {last_name}, {first_name} {last_name}.");
    }
}