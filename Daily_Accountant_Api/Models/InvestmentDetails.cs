using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Daily_Accountant_Api.Models
{
    public class InvestmentDetails
    {
        public int Id { get; set; }

        [ForeignKey("Investment_Id")]
        public virtual InvestmentNameId investmentnameid { get; set; }
      
        public int Investment_Id { get; set; }

        public virtual User register { get; set; }

        public int registerId { get; set; }
    }
}