using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RetailShops.Repository.Entities;
using RetailShops.Models.ViewModels;
using RetailShops.Repository.Implementation;
using RetailShops.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailShops.Repository.Interface;

namespace RetailShops.Service.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public List<ProductModel> GetProducts()
        {
            var ProductList = _productRepository.GetProducts();
            List<ProductModel> ListOfProducts = _mapper.Map<List<ProductModel>>(ProductList);
            return ListOfProducts;


        }
        public ProductModel GetProducts(Guid id)
        {
            var ProductById = _productRepository.GetProducts(id);
            ProductModel ProductWithId = _mapper.Map<ProductModel>(ProductById);
            return ProductWithId;
        }
        public void ProductPost(ProductModel MyProduct)
        {
            var NewProduct = _mapper.Map<Product>(MyProduct);
            NewProduct.Id = Guid.NewGuid();
            _productRepository.ProductPost(NewProduct);

        }
        public void ProductPut(Guid id, ProductModel MyProduct)
        {
            var NewProduct = _mapper.Map<Product>(MyProduct);
            NewProduct.Id = id;
            _productRepository.ProductPut(NewProduct);
        }
        public void ProductDelete(Guid id)
        {
            _productRepository.ProductDelete(id);
        }

    }
}
