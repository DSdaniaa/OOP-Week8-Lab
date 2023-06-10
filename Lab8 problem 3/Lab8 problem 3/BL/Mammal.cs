using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem_3.BL
{
    class Mammal:Animal
    {

        public Mammal(string name):base(name)
        {
           
        }
        public override string toString()
        {
            string word;
            word = " Animal Mammal Name: " + name;
            return word;
        }
    }
}
