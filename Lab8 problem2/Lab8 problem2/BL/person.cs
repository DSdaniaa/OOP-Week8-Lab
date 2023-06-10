using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_problem2.BL
{
    public class person
    {
        protected string name;
        protected string address;

        public person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return this.name;
        }
        public string getAddress()
        {
            return this.address;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAddress(string address)
        {
            this.address = address;

        }
        public virtual string toString()
        {
            string word;
            word = "Name: " + name + " Address: " + address;
            return word;
        }
    }
}
