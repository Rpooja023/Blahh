using RetailShops.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Repository.Interface
{
    public  interface IProductRepository
    {
        Product GetProducts(Guid id);
        List<Product> GetProducts();
        void ProductPost(Product MyProduct);
        void ProductPut(Product MyProduct);
        void ProductDelete(Guid id);
    }
}
