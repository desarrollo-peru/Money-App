using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MoneyApp.Models
{
    public class Budget
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Quantity")]
        [DataType(DataType.Currency)]
        public double quantity { get; set; }
        [Required]
        [Display(Name = "Frequency")]
        public string frequency { get; set; }
    }
}