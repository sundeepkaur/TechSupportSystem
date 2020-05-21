using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    public class Product
    {
        private int code;
        private String name;
        private decimal version;
        private String date;

        public Product()
        {

        }

        public Product(int code, String name, decimal version, String date)
        {
            this.Code = code;
            this.Name = name;
            this.Version = version;
            this.Date = date;

        }

        public int Code
        {
            get { return code; }
            set { code = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Version
        {
            get { return version; }
            set { version = value; }
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public String GetDisplayProduct(String sep)
        {
            return Code + sep + Name + sep + Version + sep + Date;
        }
    }
}
