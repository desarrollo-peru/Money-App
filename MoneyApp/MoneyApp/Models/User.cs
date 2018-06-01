using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Nombre de usuario")]
        public string username { get; set; }
        [Required]
        [MaxLength(15),MinLength(6)]
        [Display(Name = "Contraseña")]
        public string password { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string lastname { get; set; }
    }
}