using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Egamek_Core
{
    public interface IUnitOfWork
    {
        //public IOrderRepository orderRepository { get; }
        Task SaveAsync();
    }
}
