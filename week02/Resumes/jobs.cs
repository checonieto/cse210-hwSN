// Week 2 - Sergio Nieto
// This program defines a class to represent a job and includes a method to display job details.

using System;

public class Job
{
    // Fields to store job details
    public string _jobTitle;  // Stores the job title
    public string _company;   // Stores the name of the company
    public int _startYear;    // Stores the year the job started
    public int _endYear;      // Stores the year the job ended

    // Method to display job details
    public void Display()
    {
        // Outputs the job title, company, and start/end years in a formatted string
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}