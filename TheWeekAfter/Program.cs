using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWeekAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter date in mm/dd/yyyy format: ");
            string input = Console.ReadLine();

            DateTime dt;
            var isValidDate = DateTime.TryParse(input, out dt);

            if (isValidDate)
            {
                TimeSpan ts = new TimeSpan(7, 0, 0, 0);
                DateTime result = dt.Add(ts);
                Console.WriteLine($"Next week from {dt} is {result}");
            }
            else
            {
                Console.WriteLine($"{input} is not a valid date string");
            }

            Console.ReadLine();
        }
    }
}
