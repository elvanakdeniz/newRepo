using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.MVC.Models
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string EMail { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}