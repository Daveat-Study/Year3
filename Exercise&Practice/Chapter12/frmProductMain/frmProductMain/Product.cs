using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmProductMain
{
    public class Product
    {
        private string code;
        private string description;
        private decimal price;

        public Product() { }
        public Product(string code)
        {
            Product p = ProductsDB.GetProduct(code);
            this.code = p.code;
            this.description = p.description;
            this.price = p.price;
        }
        public Product(string code, string des, decimal price)
        {
            this.code = code;
            this.description = des;
            this.price = price;
        }

        public string getCode
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string getDescription
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public decimal getPrice
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string GetDisplayText(string sep)
        {
            return code + sep + price.ToString("c") + sep + description;
        }
    }
}
