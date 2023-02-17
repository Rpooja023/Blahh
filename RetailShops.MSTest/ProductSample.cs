using RetailShops.Models.ViewModels;
using System.Reflection.Metadata.Ecma335;

namespace RetailShops.MSTest
{
    [TestClass]
    public class ProductSample
    {
        public ProductModel GetByName(string Name)
        {
            List<ProductModel> Samples = new List<ProductModel>
        {
        new ProductModel
        {
            
            Name= "Car",
            Quantity = 1,
            ModelName = "Seltos",
            Price = 200000,
        },
        new ProductModel
        {
            
            Name = "Car2",
            Quantity = 1,
            ModelName = "Sonet",
            Price = 15000,

        }
        };

            ProductModel model = Samples.FirstOrDefault(x => x.Name == Name);
            return model;

        }

    }
}

