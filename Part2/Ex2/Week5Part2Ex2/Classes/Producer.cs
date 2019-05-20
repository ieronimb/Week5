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
        public Producer(string manufacutrer)
        {
            this.Manufacutrer = manufacutrer;
        }
        //Proprietati
        public string Manufacutrer { get; set; }

        public void Print()
        {
            Console.Write(Manufacutrer);
        }
        //Metoda de la interfata        
        string IProducer.Manufacutrer()
        {
            return Manufacutrer;
        }
    }
}
