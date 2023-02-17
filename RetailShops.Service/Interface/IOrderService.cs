using RetailShops.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Service.Interface
{
    public interface IOrderService 
    {
        List<OrderModel> GetOrders();
        OrderModel GetOrders(Guid id);
        void OrderPost(OrderModel MyOrder);
        void OrderDelete(Guid id);
        void OrderPut(Guid id, OrderModel MyOrder);
    }
}

