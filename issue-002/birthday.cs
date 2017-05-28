using System;

class Program
{
    static void Main()
    {
    	// Day I was born
    	DateTime born = new DateTime(1992,3,7);

    	// My next bday
        DateTime nextBirthday = new DateTime(DateTime.Today.Year+1, 3, 7);

        // days to next bday
        TimeSpan duration = nextBirthday - DateTime.Today;

        // get age
        int age = nextBirthday.Year - born.Year;

        //display nicely
        Console.WriteLine($"You are {duration.TotalDays} days away from turning {age} Years old!");
    }
}
