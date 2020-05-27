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
    public class ExpensesDetailController : ApiController
    {
        private ApplicationDbContext _context;
        private Daily_Accountant_DbEntities DB;
        public ExpensesDetailController()
        {
            _context = new ApplicationDbContext();
            DB = new Daily_Accountant_DbEntities();
        }

        public IHttpActionResult GetExpenses(string query = null)
        {
            var ExpensesList = _context.expensesDetails.Include(d => d.Category);

            var expenses = ExpensesList.ToList();

            return Ok(expenses);
        }

        [ActionName("DeleteExpenses")]
        [HttpDelete]
        public IHttpActionResult DeleteExpenses(int id)
        {
            var CustomerInDb = _context.expensesDetails.SingleOrDefault(e => e.Expenses_Id == id);
            if (CustomerInDb == null)
                return NotFound();
            _context.expensesDetails.Remove(CustomerInDb);
            _context.SaveChanges();
            return Ok();
        }

        [ActionName("EditExpenses")]
        [HttpPut]
        public IHttpActionResult UpdateExpenses(int id, ExpensesDetail expensesdetail)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var expensesInDb = _context.expensesDetails.SingleOrDefault(c => c.Expenses_Id == id);

            if (expensesInDb == null)
                return NotFound();

            _context.SaveChanges();

            return Ok();
        }

        [ActionName("AddExpenses")]
        [HttpPost]
        public IHttpActionResult CreateNewExpenses(ExpensesDetail expensesdetail)
        {
            if (!ModelState.IsValid)
                return BadRequest();
    
            expensesdetail.registerId = 1;
            DB.ExpensesDetails.Add(expensesdetail);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + expensesdetail.Expenses_Id), expensesdetail);
        }

    }
}
