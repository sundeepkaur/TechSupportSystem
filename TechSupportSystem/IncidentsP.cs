using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    class IncidentsP
    {
        private int id;
        private int customerId;
        private int productId;
        private int technicianId;
        private String date;
        private String title;

        public IncidentsP()
        {

        }

        public IncidentsP(int id, int custId, int prodId, int techId, String date, String title)
        {
            this.ID = id;
            this.CustomerID = custId;
            this.ProductID = prodId;
            this.TechnicianID = techId;
            this.Date = date;
            this.Title = title;
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int CustomerID
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }

        public int TechnicianID
        {
            get { return technicianId; }
            set { technicianId = value; }
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public String GetDisplayIncidents(String sep)
        {
            return ID + sep + CustomerID + sep + ProductID + sep + TechnicianID + sep + Date + sep + Title;
        }
    }
}
