using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2Ex2.Interfaces;

namespace Week5Part2Ex2.Classes
{

    public class Customer : IPerson
    {
        //Constructori
        public Customer(string name)
        {
            this.Name = name;
        }
        //Proprietati
        public string Name { get; private set; }

        public void Print()
        {
            Console.Write($"{Name} intended to buy a " +
                $"");
        }
        //Metoda de la interfata
        string IPerson.Name()
        {
            return Name;
        }
    }
}
    