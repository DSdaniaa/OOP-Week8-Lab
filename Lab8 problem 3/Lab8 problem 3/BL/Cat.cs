using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem_3.BL
{
    class Cat:Mammal
    {
        public Cat(string name) : base(name)
        {

        }
        public void greets()
        {
            Console.WriteLine("Meow");
            Console.ReadKey();
        }
        public override string toString()
        {
            string word;
            word = " Animal Mammal Cat Name: " + name;
            return word;
        }
    }
}
