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

            string output = null;
            output = "Time of Travel: " + duration.ToString("%d") + " days";
            Console.WriteLine(output);
            output = "Time of Travel: " + duration.ToString(@"dd\.hh\:mm\:ss");
            Console.WriteLine(output);

            Console.WriteLine("Time of Travel: {0:%d} day(s)", duration);
            Console.WriteLine("Time of Travel: {0:dd\\.hh\\:mm\\:ss} days", duration);
        }
    }
}
