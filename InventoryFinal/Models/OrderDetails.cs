using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryFinal.Models
{
    public class OrderDetails
    {
        [Key]
        [Column(Order = 1)]
        public int ProductID { get; set; }
        public Products Product { get; set; }

        [Key]
        [Column(Order = 2)]
        public int OrderID { get; set; }
        public virtual Orders Order { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quanity { get; set; }
        
        [Display(Name = "Discount (%)")]
        [Range(1, 100)]
        public decimal Discount { get; set; }
    }
}