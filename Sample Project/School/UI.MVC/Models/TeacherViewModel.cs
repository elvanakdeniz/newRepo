using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI.MVC.Models
{
    public class TeacherViewModel
    {
        public Teacher Teacher { get; set; }
        public User User { get; set; }
    }
}