using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryFinal.Models
{
    public class Suppliers
    {
        [Key]
        public int SupplierID { get; set; }

        [Display(Name = "Supplier Name")]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactTitle { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string fax { get; set; }

        [DataType(DataType.Url)]
        public string homePage { get; set; }

        public ICollection<Products> supProducts { get; set; }

    }
}