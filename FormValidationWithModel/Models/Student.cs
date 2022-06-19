using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace FormValidationWithModel.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter Your Roll")]
        public int Roll { get; set; }


        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please ReEnter Your Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Repassword doesn't match")]
        public string RePassword { get; set; }


        [Required(ErrorMessage = "Please Enter Your Age")]
        public int Age { get; set; }


        [Required(ErrorMessage = "Please Enter Your Phone")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }
    }
}