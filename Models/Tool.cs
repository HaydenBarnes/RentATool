using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace RentATool1.Models
{
    public class Tool
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required, StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        public string Category { get; set; }

        [Display(Name = "Price/Day"), Required, Range(1, 1000), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required, StringLength(15)]
        public string Brand { get; set; }
    }    
}
