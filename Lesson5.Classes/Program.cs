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

            var shape1 = Shape.Initialize();
            var shape2 = Shape.Initialize();

            Console.ReadLine();
        }
    }
}
