// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
class MyFirstConsoleApplication
{
    static void Main()
    {
        // Name and location
        string name = "Andrew";
        string location = "The United States";
        Console.WriteLine($"My name is {name}");
        Console.WriteLine($"I am from {location}");
        // Display Current Date
        DateTime today = DateTime.Today;
        Console.WriteLine(today.ToString("MM/dd/yyyy"));
        // Determine when christmas will be this year and display the days until
        DateTime christmas = DateTime.Parse($"12/25/{today.Year}");
        TimeSpan untilChristmas = christmas.Subtract(today);
        Console.WriteLine($"There are {untilChristmas.TotalDays} day(s) until Christmas ({christmas.ToString("MM/dd/yyyy")})");

        //From C# Programming by Rob Miles 2.1.1
        double width, height, woodLength, glassArea;
        string widthString, heightString;
        Console.Write("Window Width: ");
        widthString = Console.ReadLine();
        width = double.Parse(widthString);
        Console.Write("Window Height: ");
        heightString = Console.ReadLine();
        height = double.Parse(heightString);
        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);
        Console.WriteLine("The length of the wood is " +
        woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
        glassArea + " square metres");

        Console.ReadKey();
    }
}



