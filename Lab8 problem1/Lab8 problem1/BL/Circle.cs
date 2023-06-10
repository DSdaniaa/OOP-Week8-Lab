using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem1.BL
{
    public class Circle
    {
        protected double radius;
        protected string color;

        public Circle()
        {
            radius = 1;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius,string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            double area;
            area = (radius * radius);
            return area;
        }
        public string toString()
        {
            string word;
            word = "Radius: " + radius + " Color: " + color;
            return word;
        }
    }
}
