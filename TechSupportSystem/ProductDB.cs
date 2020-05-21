using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    public class ProductDB
    {
        private static Product[] products = new Product[5];
        public static int count = 0;
        public static bool AddProduct(Product product)
        {
            bool success = false;
            try
            {
                products[count++] = product;
                success = true;
            }
            catch
            {
                throw new Exception("Database is Full, Cannot Add more Products");
            }
            return success;
        }

        public static Product[] GetProducts()
        {
            return products;
        }
    }
}
