using Microsoft.AspNetCore.Mvc;
using RetailShops.Models.ViewModels;
using RetailShops.Repository.Entities;
using RetailShops.Repository.Implementation;
using RetailShops.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailShops.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;

        }
        // GET: api/<OrderController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.GetOrders());
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_orderService.GetOrders(id));
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post(OrderModel MyOrder)
        {
            _orderService.OrderPost(MyOrder);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, OrderModel MyOrder)
        {
            _orderService.OrderPut(id, MyOrder);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _orderService.OrderDelete(id);
        }
    }
}
