using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
         
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job1.Display();
        //job2.Display();

        //Verify that i get the company
        //Console.WriteLine($"{job1._company}");
        //Console.WriteLine($"{job2._company}");
        
        Resume resume = new Resume();
        resume._name = "Allison Rose";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //Verify that i get and can display the first job title
        //Console.WriteLine($"{resume._jobs[0]._jobTitle}");

        resume.Display();
    }
}