using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpryStorePresentationLayer.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
    }
}
