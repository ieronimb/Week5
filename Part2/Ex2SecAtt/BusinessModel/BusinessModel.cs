using BusinessModel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    internal class BusinessModel
    {
        private static void Main(string[] args)
        {
            //3.Model in c# the following business model
            //   Store(IStore)
            //   Customer(IPerson)
            //   Order(IOrder)
            //   Producer(IProducer)
            //   Car(IVehicle)
            //   Inside the main method implement the following behavior:
            //   Alex intended to buy a Ford Focus 2015 model.
            //   He walked to the FordStore in Bucuresti and agreed to buy one for 15000Euro.
            //   They informed him it will take 4 weeks for delivery.
            //   He then decided to visit another store SkodaStore and agreed to buy one for 14000Euro and 3 weeks delivery.
            //   He then canceled his original order from the FordStore.
            //   After 3 weeks, he received the model.
            
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