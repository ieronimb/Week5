using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel.Interfaces
{
    public interface IStore
    {
        string Name { get; }
        void Enter(IPerson person);
        IOrder Buy(IPerson person, string carName, string CarPrice);
        void CancelOrder(IPerson person, IOrder order);
        void ReceivedOrder(IPerson person, IOrder order);

    }
}
