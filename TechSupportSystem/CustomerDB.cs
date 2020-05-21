using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    public class CustomerDB
    {
        private static Customer[] customers = new Customer[5];
        public static int count = 0;
        public static bool AddCustomer(Customer customer)
        {
            bool success = false;
            try
            {
                customers[count++] = customer;
                success = true;
            }
            catch
            {
                throw new Exception("Database is Full, Cannot Add more Customers");

            }
            return success;
        }

        public static Customer[] GetCustomers()
        {
            return customers;
        }
    }
}
