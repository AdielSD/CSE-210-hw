using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int magicNumberGuess = 0;
        int guessCount = 0;

        while (magicNumberGuess != number)
        {

            Console.Write("What is your guess?: ");

            string numberGuess = Console.ReadLine();

            magicNumberGuess = int.Parse(numberGuess);
            guessCount++;

            string letter;
            if (magicNumberGuess == number)
            {
                letter = "Correct! You've guessed the magic number.";
            }
            else if (magicNumberGuess > number)
            {
                letter = "Lower";
            }
            else
            {
                letter = "Higher";
            }

            Console.WriteLine(letter);
        }

        Console.WriteLine($"You guessed the magic number in {guessCount} attempts");
    }
}














    

       

        
