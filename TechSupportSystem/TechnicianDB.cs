using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupportSystem
{
    public class TechnicianDB
    {
        private static Technician[] technicians = new Technician[5];
        public static int count = 0;
        public static bool AddTechnician(Technician technician)
        {
            bool success = false;
            try
            {
                technicians[count++] = technician;
                success = true;
            }
            catch
            {
                throw new Exception("Database is Full, Cannot Add more Technicians");
            }
            return success;
        }

        public static Technician[] GetTechnicians()
        {
            return technicians;
        }
    }
}
