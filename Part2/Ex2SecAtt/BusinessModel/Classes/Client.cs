using BusinessModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Classes
{
    class Client: IPerson
    {
        public Client(string name)
        {
            Name = name;
        }
        public string Name { get; }                    
    }
}
