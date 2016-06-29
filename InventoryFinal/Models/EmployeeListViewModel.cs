using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DisplayFormat(NullDisplayText = "N/A")]
        public string ReportsToName { get; set; }
    }
}
