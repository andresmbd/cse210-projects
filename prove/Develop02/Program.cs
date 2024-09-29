using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choiceNumber = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (choiceNumber != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write \n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            choiceNumber = int.Parse(input);

            if (choiceNumber == 1)
            {
                journal.AddEntry();
            }
            else if (choiceNumber == 2)
            {
                journal.DisplayAll();
            }
            else if (choiceNumber == 3)
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choiceNumber == 4)
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}