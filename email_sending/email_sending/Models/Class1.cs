using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace email_sending.Models
{
    public class Class1
    {
        [Required(ErrorMessage ="Name Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mobile Is Required")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Message Is Required")]
        public string Message { get; set; }
    }
}