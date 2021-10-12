using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Task1.Models
{
    public partial class Sales
    {
        [key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter ProductId")]
        [Display(Name = "ProductId")]

        public int? ProductId { get; set; }

        [Required(ErrorMessage = "Enter the CustomerId")]
        [Display(Name = "CustomerId")]

        public int? CustomerId { get; set; }

        [Required(ErrorMessage = "Enter the StoreId ")]
        [Display(Name = "StoreId")]
        public int? StoreId { get; set; }

        [Required(ErrorMessage = "Enter the DateSold")]
        [Display(Name = "DateSold")]
        public DateTime? DateSold { get; set; }
       
    }
}


