using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventoryFinal.Models
{
    public class CustomerDemographics
    {
        [Key]
        public int CustomerDemographicID { get; set; }

        [DataType(DataType.MultilineText)]
        public string CustomerDesc { get; set; }

        public virtual ICollection<Customers> DemoCustomers { get; set; }
    }
}