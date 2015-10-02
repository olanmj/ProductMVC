using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(20, ErrorMessage ="Name must be 3 to 20 characters", MinimumLength =3)]
        public string Name { get; set; }
        [Required]
        [Display(Name="Product Details")]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Category { set; get; }
    }
}