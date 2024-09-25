using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); // constructor method, here is calling the constructor of the Job class.
        
        job1._jobTitle = "Sothware Engineer";
        job1._company = "Samsung";
        job1._startYear = 2012;
        job1._endYear = 2015;

        Job job2 = new Job();

        job2._jobTitle = "Sales Manager";
        job2._company = "AGR";
        job2._startYear = 2017;
        job2._endYear = 2020;

        Resume resume = new Resume();
        resume._name = "John Stevenson";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayMyResume();
        

    }

}