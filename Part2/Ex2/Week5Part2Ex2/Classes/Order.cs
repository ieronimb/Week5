using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2Ex2.Interfaces;

namespace Week5Part2Ex2.Classes
{
    class Order : IOrder
    {    //Constructori       
        
        public Order(string weeks)
        {
            this.Weeks = weeks;
        }
        //Proprietati
        public string Weeks { get; private set; }

        public void Print()
        {
            Console.Write(Weeks);
        }
        //Metoda de la interfata        
        string IOrder.Weeks()
        {
            return Weeks;
        }
    }
}
