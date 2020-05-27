using Daily_Accountant_Api.Models;
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
    public class InvestmentController : ApiController
    {
        private ApplicationDbContext _context;
        public InvestmentController()
        {
            _context = new ApplicationDbContext();
        }
        //[ActionName("AddInvestment")]
        //[HttpPost]
        //public IHttpActionResult CreateInvestment(InvestmentNameId investmentnameid)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest();

        //    _context.investmentnameid.Add(investmentnameid);
        //    _context.SaveChanges();

        //    return Created(new Uri(Request.RequestUri + "/" + investmentnameid.Id), investmentnameid);
        //}
   
    }
}