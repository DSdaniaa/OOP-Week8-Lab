using Lab8_problem2.BL;
using Lab8_problem2.DL;
using Lab8_problem2.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            staff s1 = personUI.takeInputStaff();
            personDL.addToPersonList(s1);
            staff s2 = personUI.takeInputStaff();
            personDL.addToPersonList(s2);
            student s3 = personUI.takeInputStudent();
            personDL.addToPersonList(s3);
            student s4 = personUI.takeInputStudent();
            personDL.addToPersonList(s4);
            Console.WriteLine(s1.toString());
            Console.WriteLine(s2.toString());
            Console.WriteLine(s3.toString());
            Console.WriteLine(s4.toString());
            Console.ReadKey();

        }
    }
}
