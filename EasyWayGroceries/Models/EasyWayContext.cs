using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWayGroceries.Models
{
    public class EasyWayContext:DbContext
    {
        public EasyWayContext()
        {
        }

        public EasyWayContext(DbContextOptions<EasyWayContext> options):base(options)
        {

         }
     public DbSet<RegistrationModel> Registration { get; set; } 
    public DbSet<ProductsModel> Products { get; set; } 
    public DbSet<CustomerOrderModel> CustomerOrders { get; set; } 
         }
}
