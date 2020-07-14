using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EasyWayGroceries.Models
{
    public class RegistrationModel
    {
        public string UserName { get; set; }
        [Key]
        public string EmailId { get; set; }
        public string Password { get; set; }
        [NotMapped]
        public string confirmPassword { get; set; }  
      
        public int CustomerId { get; set; }  
        public string IsVerified { get; set; } 
        public String ActivationCode { get; set; }

    }
}
