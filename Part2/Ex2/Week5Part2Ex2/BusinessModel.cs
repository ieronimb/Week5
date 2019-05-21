using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5Part2Ex2.Classes;

namespace Week5Part2Ex2
{
    class BusinessModel
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
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer("Alex");
            Producer Model = new Producer("2015 model");
            Car Skoda = new Car("Skoda");
            Car ForFocus = new Car("ForFocus");
            Store FordStore = new Store("FordStore");
            Store SkodaStore = new Store("SkodaStore");
            Order FourWeeks = new Order("4 weeks");
            Order ThreeWeeks = new Order("3 weeks");


            newCustomer.Print();
            Console.Write(" intended to buy a ");
            ForFocus.Print();
            Model.Print();
            Console.Write($". He walked to the ");
            FordStore.Print();
            Console.Write(" in Bucuresti and agreed to buy one for 15000Euro. They informed him it will take ");
            FourWeeks.Print();
            Console.Write(" for delivery. He then decided to visit another store ");
            SkodaStore.Print();
            Console.Write(" and agreed to buy one for 14000Euro and ");
            ThreeWeeks.Print();
            Console.Write(" delivery. He then canceled his original order from the ");
            FordStore.Print();
            Console.Write(". After ");
            ThreeWeeks.Print();
            Console.WriteLine(" he received the model.");

            Console.ReadLine();
        }        
    }
}
