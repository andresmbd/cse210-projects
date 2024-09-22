using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); // Call to display the welcome message

        string userName = PromptUserName(); // Get the user's name
        int userNumber = PromptUserNumber(); // Get the user's favorite number
        int squaredNumber = SquareNumber(userNumber); // Square the user's favorite number

        DisplayResult(userName, squaredNumber); // Display the result
    }

    // Static function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Static function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine(); // Read and return the user's name
    }

    // Static function to prompt the user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine()); // Read, parse, and return the user's favorite number
    }

    // Static function to square a number and return the result
    static int SquareNumber(int number)
    {
        return number * number; // Return the square of the number
    }

    // Static function to display the user's name and the squared number
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
