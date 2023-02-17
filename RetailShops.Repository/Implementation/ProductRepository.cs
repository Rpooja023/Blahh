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
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbcontext;
        
        public ProductRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
           
        }
        
        public Product GetProducts(Guid id)
        {
            var ProductInfo = _dbcontext.Products.FirstOrDefault(x => x.Id == id);
            return ProductInfo;

        }
        public List<Product> GetProducts()
        {
            var ProductList =  _dbcontext.Products.ToList();
            
          
            return ProductList;

        }
        public void ProductPost(Product MyProduct)
        {
           
            _dbcontext.Products.Add(MyProduct);
            _dbcontext.SaveChanges();
        }
        public void ProductPut(Product MyProduct)
        {
            
            _dbcontext.Products.Update(MyProduct);
            _dbcontext.SaveChanges();
       
        }
        public void ProductDelete(Guid id)
        {
           var MyProduct =  _dbcontext.Products.FirstOrDefault(x => x.Id == id);
           _dbcontext.Products.Remove(MyProduct);
           _dbcontext.SaveChanges();

        }
    }
}
