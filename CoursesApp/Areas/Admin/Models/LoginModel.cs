using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace   CoursesApp.Areas.Admin.Models
{
    public class LoginModel
    {
        [EmailAddress]
        [Required]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }

        public string Message { get; set; }


    }
}