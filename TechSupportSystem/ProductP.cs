using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    class ProductP
    {
        private String code;
        private String name;
        private int version;
        private String date;

        public ProductP()
        {

        }

        public ProductP(String code, String name, int version, String date)
        {
            this.Code = code;
            this.Name = name;
            this.Version = version;
            this.Date = date;
            
        }

        public String Code
        {
            get { return code; }
            set { code = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Version
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
