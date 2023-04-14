using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCSharp
{
    internal class DateAndTime
    {
        static void Main(string[] args)
        {
            ValidDateTime();
        }
        static void ValidDateTime()
        {
            Console.WriteLine("Enter the date in the format yyyy-mm-dd:");
            string input = Console.ReadLine();
            string[] parts = input.Split('-');
            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);
            if (year < 2000 || year > 2050)
            {
                Console.WriteLine("Enter a Valid year!");
                return;
            }
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Enter a valid month!");
                return;
            }

            int maxDays = DateTime.DaysInMonth(year, month);
            if (day < 1 || day > maxDays)
            {
                Console.WriteLine("Enter a valid day!");
                return;
            }

            Console.WriteLine("Valid date. Thank you!");
        }
    }
}
