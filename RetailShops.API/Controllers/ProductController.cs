using Microsoft.AspNetCore.Mvc;
using RetailShops.Models.ViewModels;
using RetailShops.Repository;
using RetailShops.Repository.Entities;
using RetailShops.Service.Implementation;
using RetailShops.Service.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailShops.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
       
        public ProductController(IProductService productService)
        {
            _productService = productService;
            
        }

        // GET: api/<APIController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProducts());
        }

        // GET api/<APIController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            
            return Ok(_productService.GetProducts(id)) ;
        }

        // POST api/<APIController>
        [HttpPost]
        public void Post(ProductModel MyProduct )
        {
            _productService.ProductPost(MyProduct);
        }

        // PUT api/<APIController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, ProductModel MyProduct )

        {
            _productService.ProductPut(id, MyProduct);

        }

        // DELETE api/<APIController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {

           _productService.ProductDelete(id);
        }
    }
}
