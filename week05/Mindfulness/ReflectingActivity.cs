using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel when it was complete?",
        "What could you learn from this experience?"
    };

    public ReflectingActivity() 
        : base("Reflecting", "This activity helps you reflect on meaningful experiences.", 60) { }

    public void Run()
    {
        DisplayStartMessage();
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        ShowSpinner(3);

        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(3);
        }
        DisplayEndMessage();
    }
}
