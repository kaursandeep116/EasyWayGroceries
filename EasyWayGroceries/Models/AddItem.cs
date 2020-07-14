using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWayGroceries.Models
{
    public class AddItem
    {
        [Key]
        public int ProductId { get; set; }
        public double TotalPrice { get; set; }
        public double UnitPrice { get; set; }
        public float Quantity { get; set; }
    }
}
