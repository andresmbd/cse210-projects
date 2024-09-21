using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        

        Console.Write("Enter your grade percentage: ");
        string letter = "A";
        string userinput = Console.ReadLine(); 
      
        int gradePercentage = int.Parse(userinput);
        int remain = gradePercentage % 10;
        string sign = remain.ToString();

        if (gradePercentage >= 90)
        {
            letter = "A";
            if (remain > 3)
            {  
                sign = "";
            }
            else 
            {
                sign = "-";
            }


        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
            if (remain > 7)
            {
                sign = "+";
            }
            else if (remain <= 6 && remain >= 3)
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
            if (remain > 7)
            {
                sign = "+";
            }
            else if (remain <= 6 && remain >= 3)
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
            if (remain > 7)
            {
                sign = "+";
            }
            else if (remain <= 6 && remain >= 3)
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else
        {
            letter = "F";
            sign = "";
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine($"{letter}{sign} Congratulation!! You passed the course.");
        }

        else 
        {
            Console.WriteLine($"{letter}{sign} Sorry you did not pass the course, try next time.");
        }

    }
}