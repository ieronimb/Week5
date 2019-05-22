using System;
using BusinessModel.Interfaces;

namespace BusinessModel.Classes
{
    public class Order: IOrder
    {
        public IVehicle Vehicle { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string StoreName { get; set; }
        public string refNumber { get; set; }
        
        public void Cancel()
        {
          
        }

        public void Received()
        {

        }
    }
}