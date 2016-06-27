using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace InventoryFinal.Models
{
    public class Categories
    {

        [Key]
        public int CatID { get; set; }

        [Display(Name = "Category Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(250)]
        public string Description { get; set; }

        [Column(TypeName ="Image")]
        [DataType(DataType.Upload)]
        public byte[] Picture { get; set; }

        public virtual ICollection<Products> CategProducts { get; set; }

    }
}