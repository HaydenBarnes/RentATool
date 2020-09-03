using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentATool1.Models
{
    public class User
    {
        public int UserId { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), Required, StringLength(60, MinimumLength = 3)]
        public string Name { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        public string City { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        public string State { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$"), Required]
        public string Zip { get; set; }

        [DataType(DataType.EmailAddress), Required]
        public string Email { get; set; }


    }
}
