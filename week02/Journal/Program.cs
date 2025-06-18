using System;
using System.Security.Cryptography.X509Certificates;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("You chose to Write.");
                string randomPrompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("Enter your response: ");
                string response = Console.ReadLine();

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(new Entry(currentDate, randomPrompt, response));

                Console.WriteLine("Your response has been saved.");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nYour journal entries:");
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                Console.WriteLine("Journal saved.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
                Console.WriteLine("Journal loaded.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}



