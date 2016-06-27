using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventoryFinal.Models
{
    public class Shippers
    {
        [Key]
        public int ShipperID { get; set; }

        public string CompanyName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}