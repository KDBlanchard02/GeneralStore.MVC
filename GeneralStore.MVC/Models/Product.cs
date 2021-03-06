using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStore.MVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "# In Stock")]
        public int InventoryCount { get; set; }
        public decimal Price { get; set; }
        [Required]
        [Display(Name ="Is It Food")]
        public bool IsFood { get; set; }

    }
}