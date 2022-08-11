using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace html_helper.Models
{
    public class Class1
    {
        public int Emp_ID { get; set; }
        [Display(Name = "Name")]
        [Required (ErrorMessage ="Please Enter Name!")]
        public string Emp_name { get; set; }
        [Display(Name = "Department ID")]
        [Required(ErrorMessage = "Please Department ID!")]
        public Nullable<int> Dep_ID { get; set; }
        [Required(ErrorMessage = "Please Enter Address!")]
        public string Address { get; set; }
        [Display(Name = "Department Name")]
        public string Dep_Name { get; set; }

    }
}