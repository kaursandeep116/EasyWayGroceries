using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWayGroceries.Models
{
    public class CartDetails
    {
  
        public int CartNo { get; set; }
  
        public int ProductId { get; set; }
        public double Quantity { get; set; }
    }
}
