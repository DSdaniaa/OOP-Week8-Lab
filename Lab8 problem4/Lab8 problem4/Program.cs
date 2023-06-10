using Lab8_problem4.BL;
using Lab8_problem4.DL;
using Lab8_problem4.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = RectangleUI.createShape();
            shapeDL.addIntoList(r);
            Circle c = CircleUI.createShape();
            shapeDL.addIntoList(c);
            Square s = SquareUI.createShape();
            shapeDL.addIntoList(s);
            Rectangle r1 = RectangleUI.createShape();
            shapeDL.addIntoList(r1);
            Circle c1 = CircleUI.createShape();
            shapeDL.addIntoList(c1);
            shapeUI.showAreas(shapeDL.getList());
            Console.ReadKey();
        }
    }
}
