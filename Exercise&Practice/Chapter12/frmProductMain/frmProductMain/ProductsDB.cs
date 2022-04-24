using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmProductMain
{
    internal class ProductsDB
    {
        public static List<Product> GetListProducts()
        {
            List<Product> ls = new List<Product>();
            return ls;
        }
        public static Product GetProduct(string code)
        {
            return new Product();
        }

        public static void SaveProducts(List<Product> list)
        {
        }
    }
}
