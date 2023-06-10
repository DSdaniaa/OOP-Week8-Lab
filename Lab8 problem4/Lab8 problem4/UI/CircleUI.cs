using Lab8_problem4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem4.UI
{
    class CircleUI
    {
        public static Circle createShape()
        {
            Circle c;
            Console.Write("Enter radius: ");
            int radius = int.Parse(Console.ReadLine());
            c = new Circle(radius);
            return c;
        }
    }
}
