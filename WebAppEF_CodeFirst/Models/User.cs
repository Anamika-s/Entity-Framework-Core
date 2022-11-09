using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebAppEF_CodeFirst.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required]
        [ScaffoldColumn(false)]
        [Compare("Password", ErrorMessage = "Password do not match")]
        public string RetypePassword { get; set; }


    }
}
