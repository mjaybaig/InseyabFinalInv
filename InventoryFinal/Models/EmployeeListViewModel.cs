using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryFinal.Models
{
    public class EmployeeListViewModel
    {
        public int EmployeesID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public DateTime Birthdate { get; set; }

        public string ReportsToName { get; set; }
    }
}
