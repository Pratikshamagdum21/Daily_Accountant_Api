using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daily_Accountant_Api.Models
{
    public class WalletDetails
    {
        public int Id { get; set; }

        public virtual User register { get; set; }

        public int registerId { get; set; }

        public string WalletName { get; set; }

        public long Amount { get; set; }
    }
}