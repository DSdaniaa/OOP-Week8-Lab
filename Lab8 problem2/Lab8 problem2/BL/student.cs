using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem2.BL
{
    public class student:person
    {
        public string program;
        public int year;
        public double fees;
        
        public student(string name, string address, string program, int year , double fees) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fees = fees;
        }
        public string getProgram()
        {
            return this.program;

        }
        public int getYear()
        {
            return this.year;
        }
        public double getFees()
        {
            return this.fees;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public void setYear(int year)
        {
            this.year = year;
        }
        public void setFees(double fees)
        {
            this.fees = fees;
        }
        public override string toString()
        {
            string word;
            word = "Name: " + name + " Address: " + address +" Program "+program+" Year: "+ year+" Fees: "+fees;
            return word;
        }



    }
}
