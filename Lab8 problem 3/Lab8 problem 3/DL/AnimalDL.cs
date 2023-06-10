using Lab8_problem_3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem_3.DL
{
    class AnimalDL
    {
        public static List<Animal> Animals = new List<Animal>();

        public static void addToList(Animal a)
        {
            Animals.Add(a);
        }
    }
}
