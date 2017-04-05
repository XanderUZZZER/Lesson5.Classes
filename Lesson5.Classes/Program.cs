using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 5");

            TimeSpan duration = new TimeSpan(1, 12, 23, 62);

            string output12 = null;
            output12 = "Time of Travel: " + duration.ToString("%d") + " days";
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(output12);
            output12 = "Time of Travel: " + duration.ToString(@"dd\.hh\:mm\:ss");
            Console.WriteLine(output12);

            Console.WriteLine("Time of Travel: {0:%d} day(s)", duration);
            Console.WriteLine("Time of Travel: {0:dd\\.hh\\:mm\\:ss} days", duration);
        }
    }
}
