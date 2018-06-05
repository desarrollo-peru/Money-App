using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoneyApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(6)]
        [Display(Name = "Username")]
        public string username { get; set; }
        [Required]
        [MaxLength(15),MinLength(6)]
        [Display(Name = "Password")]
        public string password { get; set; }
        [NotMapped]
        [Compare("password")]
        [Display(Name = "Confirm password")]
        public string confirmPassword { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string lastname { get; set; }
        [Required]
        [Display(Name = "Balance")]
        [DataType(DataType.Currency)]
        public double balance { get; set; }
        public Budget budget { get; set; }
    }
}