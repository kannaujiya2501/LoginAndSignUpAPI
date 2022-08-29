using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace API.model
{
    public class Register
    {
        [Key]
        public int Id  {get; set; }
        [MaxLength(20)]
        public string Username  {get; set; }
        [MaxLength(100)]

        public string Email {get; set; }
        [MaxLength(30)]

         public string Password {get; set; }
        [MaxLength(12)]

        public string Mobile {get; set; }




    }
}