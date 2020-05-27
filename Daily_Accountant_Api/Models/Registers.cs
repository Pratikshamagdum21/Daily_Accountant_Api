using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Daily_Accountant_Api.Models
{
    public class Registers
    {
        public int Id { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}