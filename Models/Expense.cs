using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerProject.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Expenses")]
        public string  ExpenseName { get; set; }
        [Required]
        [Range(1.0,double.MaxValue, ErrorMessage ="Quantity must be greater than 0" )]
        public int Quantity { get; set; }
        [Required]
        [Range(1.0, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public int Amount { get; set; }
    }
}
