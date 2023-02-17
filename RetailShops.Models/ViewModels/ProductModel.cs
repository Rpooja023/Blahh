using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.Models.ViewModels
{
    public class ProductModel
    {
        string MyName;
        
        int MyQuantity;
        string MyModelName;
        double MyPrice;
        
        
        public string Name { get { return MyName; } set { MyName = value; } }
        
        public int Quantity { get { return MyQuantity; } set { MyQuantity = value; } }
        public string ModelName { get { return MyModelName; } set { MyModelName = value; } }
        public double Price { get { return MyPrice; } set { MyPrice = value; } }
        

    }
}
