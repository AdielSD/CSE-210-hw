using System;
using System.Formats.Asn1;
using System.Collections.Generic;

public class PromptGenerator
    {
    // I think I might add the questions here
    private List<string> _prompts = new List<string>
    {
     "Who was the most interesting person I interacted with today",
     "What was the best part of my day?",
     "How did I see the hand of the Lord in my day today? ",
     "What was the strongest emotion I felt today",
     "If I had one thing I could do over again, what would it be?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}