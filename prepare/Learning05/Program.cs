using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the Assignment class
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        // Output: Samuel Bennett - Multiplication

        // Test the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        // Output: Roberto Rodriguez - Fractions
        //         Section 7.3 Problems 8-19

        // Test the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        // Output: Mary Waters - European History
        // The Causes of World War II by Mary Waters
    }
}