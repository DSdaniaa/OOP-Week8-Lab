using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem1.BL
{
    class Cylinder:Circle
    {
        public double height;

        public Cylinder()
        {
            height = 1;
        }
        public Cylinder(double radius) : base (radius)
        {

        }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }
        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.height = height;
        }
        public double getHeight()
        {
            return this.height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            double vol;
            vol = 3.1415 * radius * radius * height;
            return vol;

        }
    }
}
