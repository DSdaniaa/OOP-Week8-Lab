using Lab8_problem2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem2.UI
{
    public class personUI
    {
        public static student takeInputStudent()
        {
            Console.Clear();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Program: ");
            string program = Console.ReadLine();
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Fees: ");
            double fee = double.Parse(Console.ReadLine());
            student s = new student(name, address, program, year,fee);
            return s;

        }
        public static staff takeInputStaff()
        {
            Console.Clear();
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter School Name: ");
            string sname = Console.ReadLine();
            Console.Write("Enter Pay: ");
            double pay = double.Parse(Console.ReadLine());
            staff s = new staff(name, address, sname, pay);
            return s;
        }
    }
}
