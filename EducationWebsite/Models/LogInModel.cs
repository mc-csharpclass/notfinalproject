using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EducationWebsite.Models
{
    public class LogInModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    
}