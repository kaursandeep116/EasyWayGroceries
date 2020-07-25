using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWayGroceries.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderId { get; set; }
        [Key]
        public int ProductId { get; set; }
    }
}
