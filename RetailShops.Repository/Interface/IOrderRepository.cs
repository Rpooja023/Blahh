using RetailShops.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repository.Interface
{
    public interface IOrderRepository
    {
        Order GetOrders(Guid id);
        List<Order> GetOrders();
        void OrderPost(Order MyOrder);
        void OrderPut(Order MyOrder);
        void OrderDelete(Guid id);
    }
}
