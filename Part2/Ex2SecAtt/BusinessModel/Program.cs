using BusinessModel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    internal class Program
    {
        private static void Main(string[] args)
        {                  
                                   
            var store = new Store("FordStore");
            var client = new Client("Alex");
            store.Enter(client);
            var car = new Car(name: "Focus", model: "2015");
            var order = store.Buy(client, car.Name, CarPrice: "15,000 euro");           
            store.CancelOrder(client, order);

            var newStore = new Store("SkodaStore");
            store.Enter(client);
            var newCar = new Car(name: "Assume Skoda", model: "Unknown");
            var newOrder = store.Buy(client, car.Name, CarPrice: "14,000 euro");
            store.ReceivedOrder(client, order);

            Console.ReadLine();

        }                  
        
    }

}