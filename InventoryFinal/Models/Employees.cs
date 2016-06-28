using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryFinal.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }

        [StringLength(50, ErrorMessage = "Kindly Enter between 1 and 50 characters")]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "Kindly Enter between 1 and 50 characters")]
        public string FirstName { get; set; }

        [StringLength(10, ErrorMessage = "Kindly Enter between 1 and 10 characters")]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Birthdate { get; set; }

        [Display(Name ="Hire Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Hiredate { get; set; }

        [StringLength(250, ErrorMessage = "Kindly Enter between 1 and 250 characters")]
        public string Address { get; set; }

        [StringLength(50, ErrorMessage = "Kindly Enter between 1 and 50 characters")]
        public string City { get; set; }

        [StringLength(50, ErrorMessage = "Kindly Enter between 1 and 50 characters")]
        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string HomePhone { get; set; }

        [StringLength(7, ErrorMessage = "Please enter upto 7 charactars")]
        [DataType(DataType.PhoneNumber)]
        public string Extension { get; set; }

        [DataType(DataType.Upload)]
        public byte[] Photo { get; set; }

        [Display(Name = "Reports To")]
        public int? ReportsToID { get; set; }

        [ForeignKey("ReportsToID")]
        [Display(Name = "Reports To")]
        public virtual Employees ReportsTo { get; set; }

        public virtual ICollection<Territories> Territories { get; set; }

    }
}