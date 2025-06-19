public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity helps you relax by breathing in and out slowly.", 30) { }

    public void Run()
    {
        DisplayStartMessage();
        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);
            Console.WriteLine("Breathe out...");
            ShowSpinner(2);
        }
        DisplayEndMessage();
    }
}
