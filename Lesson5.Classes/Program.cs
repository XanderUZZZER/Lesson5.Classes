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
            
            Shape shape = new Shape();
            shape.Draw();

            Shape shape1 = new Shape(5, 8);
            shape1.Draw();

            var triangle = new Triangle();

            Console.ReadLine();
        }
    }
}
