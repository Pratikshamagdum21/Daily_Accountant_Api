﻿using Daily_Accountant_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Web.Http.Results;
using System.Data.Entity.Infrastructure;
namespace Daily_Accountant_Api.Controllers.Api
{
    public class BorrowedMoneyController : ApiController
    {
        private ApplicationDbContext _context;
        public BorrowedMoneyController()
        {
            _context = new ApplicationDbContext();
        }
    }
}
