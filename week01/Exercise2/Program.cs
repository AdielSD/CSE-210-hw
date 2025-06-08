using System;
using System.Runtime.CompilerServices;
class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter your grade percentage: ");
        string gradeInput = Console.ReadLine();

        
        int gradePercentage = int.Parse(gradeInput);

        // Defines the letter as rade
        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Display the letter grade
        Console.WriteLine($"Your letter grade is: {letter}");

        // Display pass/fail message
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Better luck next time!");
        }
    }
}



