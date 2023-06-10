using Lab8_problem_3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem_3.UI
{
    class AnimalUI
    {
        public static Cat takeInpuCat()
        {
            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();
            Cat c = new Cat(name);
            return c;
        }
        public static Dog takeInputDog()
        {
            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();
            Dog c = new Dog(name);
            return c;
        }
    }
}
