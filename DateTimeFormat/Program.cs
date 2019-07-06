using System;

namespace DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program extracts the Date property and displays the DateTime value in the formatted output");

            DateTime dt = new DateTime(2019, 6, 15, 11, 25, 55);
            Console.WriteLine("Complete date: " + dt.ToString());

            DateTime dateOnly = dt.Date;

            Console.WriteLine("Short Date: " + dateOnly.ToString());

            Console.WriteLine("Display date using 24-hour clock format:");
            Console.WriteLine(dateOnly.ToString("g"));
            Console.WriteLine(dateOnly.ToString("MM/dd/yy HH:mm"));

            Console.ReadLine();
        }
    }
}
