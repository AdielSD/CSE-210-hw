using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Reference reference = new Reference("Proverbs", 3, 5, 6);
            string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

            
            Scripture scripture = new Scripture(reference, scriptureText);

            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide some words, or type 'quit' to exit.");

            
            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWords();
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsFullyHidden())
                {
                    Console.WriteLine("\nAll words are hidden! Good job memorizing!");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            }
        }
    }
}

