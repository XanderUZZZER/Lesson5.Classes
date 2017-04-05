using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;

namespace ConsoleApplication
{
    class Program: Shape
    {
        private void YU()
        {
            H = 17;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 5");

            Shape.DrawPerfect();

            var shape1 = Shape.Initialaze();
            var shape2 = Shape.Initialaze();

            Console.ReadLine();
        }
    }
}
