﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle: Shape
    {
        public Triangle() : base(9,9)
        {
            Console.WriteLine(nameof(Triangle));
        }

        public void Print()
        {
            DrawA();
        }
    }
}
