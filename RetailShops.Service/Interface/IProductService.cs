using RetailShops.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Service.Interface
{
    public interface IProductService
    {
        List<ProductModel> GetProducts();
        ProductModel GetProducts(Guid id);

        void ProductPost(ProductModel MyProduct);
        void ProductDelete(Guid id);
        void ProductPut(Guid id, ProductModel MyProduct);
    }
       
}
