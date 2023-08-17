using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class UserModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Name is required")]
       // [Display(Name="User Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Enter a valid Email")]
       // [Display(Name = "User Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [Range(18,60,ErrorMessage ="Age must be between 18 to 60")]
        //[Display(Name = "User Age")]
        public int Age { get; set; }
    }
}