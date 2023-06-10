using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8_problem1.BL;

namespace Lab8_problem1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Cylinder c = new Cylinder();
            Cylinder c2 = new Cylinder(1, 2);
            Cylinder c3 = new Cylinder(1, 2, "yellow");
            c.setHeight(2.3);
            c2.setHeight(2);
            c3.setHeight(4);
            Console.WriteLine(c.getVolume());
            Console.WriteLine(c2.getVolume());
            Console.WriteLine(c3.getVolume());
            Console.ReadKey();




        }
    }
}
