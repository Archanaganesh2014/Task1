using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Task1.Models
{
    public partial class Store
    {
        [key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter the Name")]
        [Display(Name = "Name")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Enter the Address")]
        [Display(Name = "Address")]

        public string Address { get; set; }
    }
}
