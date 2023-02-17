using RetailShops.Models.ViewModels;
using RetailShops.Repository.Entities;
using RetailShops.Repository.Implementation;
using RetailShops.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RetailShops.Repository.Interface;

namespace RetailShops.Service.Implementation
{
    public class OrderService : IOrderService
    {
       
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        
        public List<OrderModel> GetOrders()
        {
            var OrderList = _orderRepository.GetOrders();
            List<OrderModel> ListOfOrders = _mapper.Map<List<OrderModel>>(OrderList);
            return ListOfOrders;


        }
        public OrderModel GetOrders(Guid id)
        {
            var OrderInfo = _orderRepository.GetOrders(id);
            OrderModel OrderWithId = _mapper.Map<OrderModel>(OrderInfo);
            return OrderWithId;
        }
        public void OrderPost(OrderModel MyOrder)
        {
           var NewOrder = _mapper.Map<Order>(MyOrder);
            NewOrder.Id = Guid.NewGuid();
            _orderRepository.OrderPost(NewOrder);

        }
        public void OrderPut(Guid id, OrderModel MyOrder)
        {
            var NewOrder = _mapper.Map<Order>(MyOrder);
            NewOrder.Id = id;
            _orderRepository.OrderPut(NewOrder);
        }
        public void OrderDelete(Guid id)
        {
            _orderRepository.OrderDelete(id);
        }

    }
    }
