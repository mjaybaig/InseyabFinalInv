using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventoryFinal.Models
{
    public class Customers
    {
        [Key]
        public int CustID { get; set; }

        public string CompanyName { get; set; }
        public string ContactName { get; set; }

        public string ContactTitle { get; set;}
        public string Address { get; set; }

        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string fax { get; set; }

        public int OrderID { get; set; }

        public virtual ICollection<Orders> CustOrders { get; set; }
        public virtual ICollection<CustomerDemographics> CustDemographics { get; set; }
    }
}