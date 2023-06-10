using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem_3.BL
{
    class Dog:Mammal
    {
        public Dog(string name) : base(name)
        {

        }
        public void greets()
        {
            Console.WriteLine("Woof");
            Console.ReadKey();
        }
        public void greets(Dog another)
        {
            Console.WriteLine("Woooof");
            Console.ReadKey();
        }
        public override string toString()
        {
            string word;
            word = " Animal Mammal Dog Name: " + name;
            return word;
        }
    }
}
