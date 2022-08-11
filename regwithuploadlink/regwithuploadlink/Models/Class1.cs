using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace regwithuploadlink.Models
{
    public class Class1
    {
        [Required(ErrorMessage =  "Enter User Name")]
        [Display(Name="Enter UserName:")]
        [StringLength(maximumLength:7,MinimumLength =3,ErrorMessage ="User Name Must Be Max 7 And Min 3")]

        public string Uname { get; set; }
        [Required(ErrorMessage ="Please Enter Email Address")]
        [Display(Name ="Enter Email:")]

       public string Uemail { get; set; }
        [Required(ErrorMessage ="Enter The Password")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]

        public string Upwd { get; set; }

        [Required(ErrorMessage = "Retype password")]
        [Display(Name = "Re-Password")]
        [DataType(DataType.Password)]

        public string Rpwd { get; set; }
        [Required(ErrorMessage = "Select Gender")]
        [Display(Name = "Gender")]

        public char Gender { get; set; }
        [Required(ErrorMessage = "Upload Profile Image")]

        public string Uimg { get; set; }
    }
}