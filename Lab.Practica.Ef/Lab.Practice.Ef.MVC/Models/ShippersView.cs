using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Practice.Ef.MVC.Models
{
    public class ShippersView
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "nombre de la compañia")]
        [StringLength(40)]
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}