using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InventoryFinal.Models
{
    public class Region
    {
        public int RegionID { get; set; }

        [DataType(DataType.MultilineText)]
        public string RegionDesc { get; set; }
    }
}