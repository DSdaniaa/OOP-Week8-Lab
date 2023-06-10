using Lab8_problem4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem4.UI
{
    public class shapeUI
    {
        public static void showAreas(List<shape> shapesList)
        {
            string message;
            for (int idx = 0; idx < shapesList.Count; idx++)
            {
                message = "The shape is {0} and its area is {1}";
                message = (idx + 1) + "." + message;
                shape s = shapesList[idx];
                Console.WriteLine(message, s.getShapeType(), s.getArea());
            }
        }
    }
}
