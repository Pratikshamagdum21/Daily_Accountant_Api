using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daily_Accountant_Api.Models
{
    public class RegisterCategory
    {
        public virtual User register { get; set; }
        public Category category { get; set; }
    }
}