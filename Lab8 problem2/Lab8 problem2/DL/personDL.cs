using Lab8_problem2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem2.DL
{
    public class personDL
    {
        public static List<person> persons = new List<person>();
        public static void addToPersonList(person p)
        {
            persons.Add(p);
        }
    }
}
