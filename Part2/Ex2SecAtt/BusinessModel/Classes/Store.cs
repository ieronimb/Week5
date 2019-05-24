using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel.Interfaces;

namespace BusinessModel.Classes
{
    public class Store : IStore
    {
        private List<IOrder> orders = new List<IOrder>();
        public string Name { get; }       
        
        public Store(string name)
        {
            Name = name;
        }

        public void Enter(IPerson person)
        {        
            
        }

        private List<IVehicle> cars = new List<IVehicle>
        {
            new Car("Focus", "Model 2105"),
            new Car("Mondeo", "Model 2105"),
            new Car("Fiesta", "Model 2105"),
            new Car("Kuga", "Model 2105"),

        };
       

        public IOrder Buy(IPerson person, string carName, string CarPrice)
        {
            var currentCar = FindCar(carName);

            if (currentCar == null)
            {
                return null;
            }

            var order = new Order
            {
                Vehicle = currentCar,
                DeliveryDate = DateTime.Now.AddDays(28),
                StoreName = this.Name
            };

            orders.Add(order);

            return order;
        }

        public void CancelOrder(IPerson person, IOrder order)
        {
            order.Cancel();
        }      

        private IVehicle FindCar(string carToFind)
        {
            foreach (var car  in cars)
            {
                if (car.Name == carToFind)
                {
                    return car;
                }
            }
            return null;
        }

        public void ReceivedOrder(IPerson person, IOrder order)
        {
            order.Received();
        }
        
    }
}
