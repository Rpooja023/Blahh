using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShops.MSTest
{
    [TestClass]
    public class Testing
    {

        [TestMethod]
        public void GetByName()
        {
            var Expected = "Car";
            ProductSample sample = new ProductSample();
            var content = sample.GetByName("Car");
            Assert.IsNotNull(content);
            Assert.AreEqual(Expected, content? .Name);

        }
    }
}
