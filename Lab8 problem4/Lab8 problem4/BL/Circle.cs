using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem4.BL
{
    public class Circle:shape
    {
        private int radius;
        public Circle(int radius)

        {

            this.radius = radius;
        }
        public override double getArea()

        {

            double area;
            area = 2 * Math.Pow(radius, 2) * Math.PI;
            return area;
        }
        public override string getShapeType()

        {

            return "Circle";
        }
    }
}
