using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryFinal.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime OrderDate { get; set; }

        public int CustID { get; set; }
        public virtual Customers Customer { get; set; }

        public int EmployeeID { get; set; }
        public virtual Employees Employee { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RequiredDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ShippedDate { get; set; }

        public int ShipVia { get; set; }

        [ForeignKey("ShipVia")]
        public virtual Shippers Shippers { get; set; }

        public string shipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }

        public string ShipPostalCode { get; set; }

        public string ShipCountry { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}