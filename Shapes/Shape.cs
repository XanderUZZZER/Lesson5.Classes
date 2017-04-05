using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        internal protected int H;


        private int _a;
        private int _b;
        private Color _color;

        //public Shape()
        //{
          //  Console.WriteLine(nameof(Shape));
        //}
        public Shape(int a, int b) : this()
        {
            _a = a;
            _b = b;
            Draw();
        }

        private Shape()
        { Console.WriteLine("Private constr"); }

        static Shape()
        { Console.WriteLine("Static constr"); }

        public int A { get; private set; }

        public void Draw()
        {
            Console.WriteLine($"A:{_a} B:{_b}");
        }
        public void Draw(int t)
        {
            Console.WriteLine($"A:{_a} B:{_b}");
        }
        public void Draw(string t)
        {
            Console.WriteLine($"A:{_a} B:{_b}");
        }

        public static void DrawPerfect()
        {
            Console.WriteLine("Static method");
        }
        protected virtual void DrawA()
        {
            Console.WriteLine(_a);
        }
        private void DrawB()
        {
            Console.WriteLine(_b);
        }
        public int CalculateSquare(int a, int b)
        {
            return a * b;
        }
    }
}
