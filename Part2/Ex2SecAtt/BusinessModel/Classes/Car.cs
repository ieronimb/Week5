using BusinessModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Classes
{
    public class Car: IVehicle
    {
        

        public Car(string name, string model)
        {
            Name = name;
            Model = model;
        }

        public string Name { get; }
        public string Model { get; }


    }
}
