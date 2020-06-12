using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace demo1.Models
{
    public class Student
    {
        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        [Required]
        public decimal Height { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public string Email { get; set; }
    }
}