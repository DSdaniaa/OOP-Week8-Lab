using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem_3.BL
{
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }
        public virtual string toString()
        {
            string word;
            word = " Animal Name: " + name;
            return word;
        }
    }
}
