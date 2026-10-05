using System;

class Program
{
    static void Main()
    {
        DateTime birthdate = new DateTime(2007, 10, 10);
        DateTime currentDate = DateTime.Now;
        
        TimeSpan ageSpan = currentDate - birthdate;

        int age = (int)(ageSpan.TotalDays / 365.25);

        Console.WriteLine("Task 5: DateTime and TimeSpan");
        Console.WriteLine($"Birthdate: {birthdate:yyyy-MM-dd}");
        Console.WriteLine($"Current Date: {currentDate}");
        Console.WriteLine($"Age: {age} years");

        DateTime newDate = birthdate.AddDays(4);

        Console.WriteLine($"Birthdate + 10 days: {newDate:yyyy-MM-dd}");
    }
}