using RetailShops.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RetailShops.Models.ViewModels
{
    public class OrderModel
    {
        Guid MyId;
        Guid MyProductId;
        Product Myproduct;
        public Guid Id { get { return MyId; } set { MyId = value; } }
        public Guid ProductId { get { return MyProductId; } set { MyProductId = value; } }
        public Product Product { get { return Myproduct; } set { Myproduct = value; } }
    }
}
