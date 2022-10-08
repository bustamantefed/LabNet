using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Practice.Ef.MVC.Models
{
    public class EmployeesView
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "apellido")]
        [StringLength(20)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "nombre")]
        [StringLength(10)]
        public string FirstName { get; set; }
        [StringLength(30)]
        public string Tittle { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string BirthDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string HireDate { get; set; }
        [StringLength(60)]
        public string Address { get; set; }
        [StringLength(15)]
        public string Country { get; set; }
        [StringLength(15)]
        public string City { get; set; }
        [StringLength(15)]
        public string Region { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(24)]
        public string Phone { get; set; }

    }
}