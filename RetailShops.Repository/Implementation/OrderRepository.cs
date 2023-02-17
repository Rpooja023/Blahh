using AutoMapper;
using RetailShops.Repository.Entities;
using RetailShops.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbcontext;
        public OrderRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Order GetOrders(Guid id)
        {
            var OrderInfo = _dbcontext.Orders.FirstOrDefault(x => x.Id == id);
            return OrderInfo;

        }
        public List<Order> GetOrders()
        {
            var OrderList = _dbcontext.Orders.ToList();
      
            return OrderList;

        }
        public void OrderPost(Order MyOrder)
        {
           
            _dbcontext.Orders.Add(MyOrder);
            _dbcontext.SaveChanges();
        }
        public void OrderPut(Order MyOrder)
        {
            
            _dbcontext.Orders.Update(MyOrder);
            _dbcontext.SaveChanges();

        }
        public void OrderDelete(Guid id)
        {
            var MyOrder = _dbcontext.Orders.FirstOrDefault(x => x.Id == id);
            _dbcontext.Orders.Remove(MyOrder);
            _dbcontext.SaveChanges();

        }
    }
}
    

