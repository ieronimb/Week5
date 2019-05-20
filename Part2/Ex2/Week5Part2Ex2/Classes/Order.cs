using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2Ex2.Interfaces;

namespace Week5Part2Ex2.Classes
{
    class Order : IOrder
    {   
        //Campuri
        private string weeks;        
        //Constructor
        public Order(string weeks)
        {
            this.weeks = weeks;            
        }
        //Proprietati
        public string Weeks { get; private set; }       

        //Metode din interfete           

        string IOrder.Weeks()
        {
            return Weeks;
        }

        public void Print()
        {
            Console.Write(Weeks);
        }        
    }
}
