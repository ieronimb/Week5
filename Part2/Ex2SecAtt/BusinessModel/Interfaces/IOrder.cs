using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Interfaces
{
    public interface IOrder
    {
        string refNumber { get; set; }
        string StoreName { get; set; }
        IVehicle Vehicle {get; set;}
        DateTime DeliveryDate { get; set; }       
        void Cancel();
        void Received();
    }
}
