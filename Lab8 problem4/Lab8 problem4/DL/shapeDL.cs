using Lab8_problem4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem4.DL
{
    public class shapeDL
    {
        private static List<shape> shapesList = new List<shape>();
        public static void addIntoList(shape r)
        {
            shapesList.Add(r);
        }
        public static List<shape> getList()
        {
            return shapesList;
        }
    }
}
