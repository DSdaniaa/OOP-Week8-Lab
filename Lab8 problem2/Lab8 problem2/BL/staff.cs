using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem2.BL
{
    public class staff:person
    {
        public string school;
        public double pay;

        public staff(string name, string address, string school,double pay) :base(name,address)
        {
            this.school = school;
            this.pay = pay;
        }
        public string getSchool()
        {
            return this.school;
        }
        public double getPay()
        {
            return this.pay;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public void setSchool(double pay)
        {
            this.pay = pay;
        }
        public override string toString()
        {
            string word;
            word = "Name: " + name + " Address: " + address+" School: "+school+" pay: "+ pay;
            return word;
        }
    }
}
