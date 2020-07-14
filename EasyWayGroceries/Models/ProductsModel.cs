using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWayGroceries.Models
{
    public class ProductsModel
    {
        [Key]
        public int ProductId { get; set; } 
        public string ProductName { get; set; } 
        public double Price { get; set; }  
        public string Description { get; set; }
        public string Department { get; set; }
        public int Stock { get; set; }
        public string Unit { get; set; }
        [NotMapped]
        public string ImagePath { get; set; }
        [NotMapped]
        public string Quantity { get; set; }
    }
}
