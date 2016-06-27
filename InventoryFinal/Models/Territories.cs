using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventoryFinal.Models
{
    public class Territories
    {
        [Key]
        public int TerritoryID { get; set; }
        public string TerritoryDesc { get; set; }

        public int RegionID { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }

        public virtual Region TerrRegion { get; set; }
    }
}