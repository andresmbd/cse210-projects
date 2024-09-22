using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenarator = new Random();

        int number = randomGenarator.Next(1, 101);
        // string userNumber;
        string userGuessed;

        // Console.Write("What is the magic number? ");
        // userNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userNumber); 

        Console.Write("What is your guess? ");
        userGuessed = Console.ReadLine();
        int guessedNumber = int.Parse(userGuessed);

        while (number != guessedNumber)
        {
            if (guessedNumber > number)
            {
                Console.WriteLine("Lower");
            }

            else if (guessedNumber < number)
            {
                Console.WriteLine("Higher");
            }
            
            Console.Write("What is your guess? ");
            userGuessed = Console.ReadLine();
            guessedNumber = int.Parse(userGuessed); 
        }
         Console.WriteLine("You guessed it!");
        
    }
}