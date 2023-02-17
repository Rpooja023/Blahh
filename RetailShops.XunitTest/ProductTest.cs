using Moq;
using RetailShops.API.Controllers;
using RetailShops.Models.ViewModels;
using RetailShops.Service.Interface;

namespace RetailShops.XunitTest
{
    public class ProductTest
    {
       
        private readonly Mock<IProductService> _productService;
        public ProductTest()
        {
            _productService = new Mock<IProductService>();
        }
        [Fact]
        public async Task GetAllProducts()
        {
            
            var testData = GetProductModel();
            var lookups = _productService.Setup(x => x.GetProducts()).Returns(testData);          
            var productController = new ProductController(_productService.Object);
            var response = productController.Get();           
            Assert.NotNull(response);
        }
        private List<ProductModel> GetProductModel()
        {
            return new List<ProductModel> 
            {
              new ProductModel()
              {
                
                Name= "Car",
                Quantity = 1,
                ModelName = "I20"
              }
            };
        }
    }
}
