using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Instance 1

        Job job1 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;


        //Instance 2

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;


        Resume resume = new Resume
        {
            _personName = "Alisson Rose "

        };

        

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
        
}

    }
    