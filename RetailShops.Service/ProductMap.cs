using AutoMapper;
using RetailShops.Models.ViewModels;
using RetailShops.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Service
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<Order, OrderModel>().ReverseMap();
        }

    }
}
