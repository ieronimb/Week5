using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2Ex2.Interfaces;

namespace Week5Part2Ex2.Classes
{

    class Producer : IProducer
    {
        //Constructori
        public Producer(string manufacturer)
        {
            this.Manufacturer = manufacturer;
        }
        //Proprietati
        public string Manufacturer { get; set; }

        public void Print()
        {
            Console.Write(Manufacturer);
        }
        //Metoda de la interfata        
        string IProducer.Manufacturer()
        {
            return Manufacturer;
        }
    }
}
