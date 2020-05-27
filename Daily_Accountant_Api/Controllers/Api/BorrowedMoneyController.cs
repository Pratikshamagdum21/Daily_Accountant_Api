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
    public class BorrowedMoneyController : ApiController
    {
        private ApplicationDbContext _context;
        private Daily_Accountant_DbEntities DB;

        public BorrowedMoneyController()
        {
            _context = new ApplicationDbContext();
            DB = new Daily_Accountant_DbEntities();
        }

        [ActionName("GetBorrowedMoney")]
        [HttpGet]
        public IHttpActionResult GetBorrowedMoney(string query = null)
        {
            var BorrowedMoneyList = _context.borrowedMoney;

            var BorrowedMoney = BorrowedMoneyList.ToList();

            return Ok(BorrowedMoney);
        }

        [ActionName("DeleteBorrowedMoney")]
        [HttpDelete]
        public IHttpActionResult DeleteBorrowedMoney(int id)
        {
            var CustomerInDb = _context.borrowedMoney.SingleOrDefault(e => e.Id == id);
            if (CustomerInDb == null)
                return NotFound();
            _context.borrowedMoney.Remove(CustomerInDb);
            _context.SaveChanges();
            return Ok();
        }

        [ActionName("AddBorrowedMoney")]
        [HttpPost]
        public IHttpActionResult CreateNewBorrowedMoney(BorrowedMoney borrowedMoney)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            borrowedMoney.registerId = 1;
            _context.borrowedMoney.Add(borrowedMoney);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + borrowedMoney.Id), borrowedMoney);
        }

    }
}
