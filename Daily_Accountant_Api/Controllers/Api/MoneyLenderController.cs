using Daily_Accountant_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Daily_Accountant_Api.Controllers.Api
{
    public class MoneyLenderController : ApiController
    {
        private ApplicationDbContext _context;
        private Daily_Accountant_DbEntities DB;

        public MoneyLenderController()
        {
            _context = new ApplicationDbContext();
            DB = new Daily_Accountant_DbEntities();
        }

        [ActionName("GetMoneyLender")]
        [HttpGet]
        public IHttpActionResult GetMoneyLender(string query = null)
        {
            var moneyLenderList = _context.moneyLender;

            var moneyLender = moneyLenderList.ToList();

            return Ok(moneyLender);
        }

        [ActionName("DeleteMoneyLender")]
        [HttpDelete]
        public IHttpActionResult DeleteMoneyLender(int id)
        {
            var CustomerInDb = _context.moneyLender.SingleOrDefault(e => e.Id == id);
            if (CustomerInDb == null)
                return NotFound();
            _context.moneyLender.Remove(CustomerInDb);
            _context.SaveChanges();
            return Ok();
        }

        [ActionName("AddMoneyLender")]
        [HttpPost]
        public IHttpActionResult CreateNewMoneyLender(MoneyLender moneyLender)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            moneyLender.registerId = 1;
            _context.moneyLender.Add(moneyLender);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + moneyLender.Id), moneyLender);
        }
    }
}
