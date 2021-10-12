using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Task1.Models
{
    public partial class Product
    {
        [key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the Name")]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the Price")]
        [Display(Name = "Price")]
        public int Price { get; set; }
    }
}
