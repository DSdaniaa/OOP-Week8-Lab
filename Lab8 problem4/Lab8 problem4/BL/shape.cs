using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem4.BL
{
    public class shape
    {
        public virtual double getArea()
        {
            return 0;
        }
        public virtual string getShapeType()
        {
            return "undefined.";
        }
    }
}
