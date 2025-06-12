using System;
using System.Security.Cryptography.X509Certificates;
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
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose to Write.");
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Enter your response: ");
                    string response = Console.ReadLine();
                    string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                    journal.AddEntry(new Entry(currentDate, randomPrompt, response));
                    Console.WriteLine("Your response has been saved.");
                    break;
                case "2":
                    Console.WriteLine("\nYour journal entries:");
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved.");
                    break;
                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.");
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}



