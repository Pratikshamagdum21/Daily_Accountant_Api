using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daily_Accountant_Api.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public virtual Registers register { get; set; }

        public int registerId { get; set; }
    }
}