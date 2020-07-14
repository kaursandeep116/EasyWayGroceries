using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWayGroceries.Models
{
    public class CustomerOrderModel
    {
        public int CustomerId { get; set; }
        [Key]
        public int OrderId { get; set; }
        public string status { get; set; }

    }
}
