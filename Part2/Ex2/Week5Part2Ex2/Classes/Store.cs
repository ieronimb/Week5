using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2Ex2.Interfaces;

namespace Week5Part2Ex2.Classes
{
    class Store: IStore
    {
        //Constructori
        public Store(string magazin)
        {
            this.Magazin = magazin;
        }
        //Proprietati
        public string Magazin { get; private set; }

        public void Print()
        {
            Console.Write($"{Magazin} intended to buy a ");
        }
        //Metoda de la interfata        
        string IStore.Magazine()
        {
            return Magazin;
        }
    }
}
