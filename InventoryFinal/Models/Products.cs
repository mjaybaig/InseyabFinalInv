using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryFinal.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(250)]
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        [Display(Name ="Supplier")]
        public int SupplierID { get; set; }

        public virtual Suppliers prodSupplier { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Categories prodCategory { get; set; }
        
        public int QuantityPerUnit { get; set; }

        public int UnitsInStock { get; set; }
        public int UnitsInOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public virtual ICollection<OrderDetails> Orders { get; set; }

    }
}