using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2.Enum;

namespace Week5Part2.Classes
{
    public class Customer
    {
        //Campuri
        private string name;
        private CustomerType type;
        

        //Constructori
        public Customer(string name, CustomerType type)
        {
            this.name = name;
            this.type = type;
        }

        //Proprietati
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }//nu e e nevoie sa scriem numele decat in clasa Customer
        }
        public CustomerType Type
        {
            get { return this.type; }
            private set { this.type = value; }//trebuie sa scriem tipul de client doar in clasa Customer
        }
    }
}
