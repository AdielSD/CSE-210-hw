using System;
using System.Collections.Generic;



public class Resume
{
    public string _personName = "";
    public List<Job> _jobs = new List<Job>();


    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");
         foreach (var job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }


}