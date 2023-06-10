using Lab8_problem_3.BL;
using Lab8_problem_3.DL;
using Lab8_problem_3.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = AnimalUI.takeInpuCat();
            Cat c2= AnimalUI.takeInpuCat();
            Dog d1 = AnimalUI.takeInputDog();
            Dog d2 = AnimalUI.takeInputDog();
            AnimalDL.addToList(c1);
            AnimalDL.addToList(c2);
            AnimalDL.addToList(d2);
            AnimalDL.addToList(d2);
            c1.greets();
            Console.WriteLine(c1.toString());
            c2.greets();
            Console.WriteLine(c2.toString());
            d1.greets();
            d1.greets(d2);
            Console.WriteLine(d1.toString());
            d2.greets();
            d2.greets(d1);

            Console.WriteLine(d2.toString());
            Console.ReadLine();



        }
    }
}
