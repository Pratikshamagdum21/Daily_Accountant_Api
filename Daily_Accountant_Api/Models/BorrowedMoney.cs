﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Daily_Accountant_Api.Models
{
    public class BorrowedMoney
    {
        public int Id { get; set; }
        public string LenderName { get; set; }
        public long Amount { get; set; }
        public string Note { get; set; }
        public Registers register { get; set; }
        public int registerId { get; set; }
    }
}