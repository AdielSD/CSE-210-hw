using System;
using System.Collections.Generic;     
using System.Transactions;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1; 

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();

            try
            {
                number = int.Parse(input); 
                if (number != 0)
                {
                    numbers.Add(number); 
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        
        if (numbers.Count > 0)
        {
            
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Count;

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Stretch challenges
            int? smallestPositive = null;
            foreach (int num in numbers)
            {
                if (num > 0 && (smallestPositive == null || num < smallestPositive))
                {
                    smallestPositive = num;
                }
            }

            if (smallestPositive.HasValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }

            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}