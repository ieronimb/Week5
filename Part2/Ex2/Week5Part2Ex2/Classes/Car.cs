using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2Ex2.Interfaces;

namespace Week5Part2Ex2.Classes
{
    class Car : IVehicle
    {
        //Constructori
        public Car(string machine)
        {
            this.Machine = machine;
        }
        //Proprietati
        public string Machine { get; private set; }

        //Metoda printare
        public void Print()
        {
            Console.Write(Machine);
        }

        string IVehicle.Machine()
        {
            return Machine;
        }    
        
    }
}
