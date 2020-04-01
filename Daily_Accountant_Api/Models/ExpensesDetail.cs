using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Daily_Accountant_Api.Models
{
    public class ExpensesDetail
    {
        [Key]
        public int Expenses_Id { get; set; }

        [ForeignKey("registerId")]
        public virtual User register { get; set; }

        public int registerId { get; set; }

        public Category Category     { get; set; }

        public int CategoryId { get; set; }

        public DateTime date { get; set; }

        public string Note { get; set; }

        public long Amount { get; set; }
    }
}