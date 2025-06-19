using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        manager.AddGoal(new simpleGoal("Run a Marathon", "Complete a marathon", 1000));
        manager.AddGoal(new EternalGoal("Read Scriptures", "Daily scripture reading", 100));
        manager.AddGoal(new ChecklistGoal("Attend Temple", "Go 10 times", 50, 10, 500));

        manager.DisplayGoals();
        manager.RecordEvent(1); 
        manager.DisplayScore();
        manager.DisplayGoals();
    }
}
