using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();        
        Resume resume = new Resume();

        job1._company = "Microsoft";
        job1._endYear = 2019;
        job1._jobTitle = "Software Engeneer";
        job1._startYear = 2022;
        job2._company = "Apple";
        job2._endYear = 2022;
        job2._jobTitle = "Manager";
        job2._startYear = 2023;

        resume._name = "Brian Madroñero";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}