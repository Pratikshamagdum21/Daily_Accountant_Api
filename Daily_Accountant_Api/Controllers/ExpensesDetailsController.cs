using Daily_Accountant_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Daily_Accountant_Api.Controllers
{
    public class ExpensesDetailsController : Controller
    {
        private ApplicationDbContext _context;
        public ExpensesDetailsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public JsonResult AjaxMethod_ExpensesList()
        {
            List<SelectListItem> CategoryList = new List<SelectListItem>();
            for (int i = 0; i < _context.category.Count(); i++)
            {
                CategoryList.Add(new SelectListItem
                {
                    Value = _context.category.ToList()[i].Id.ToString(),
                    Text = _context.category.ToList()[i].CategoryName
                });
            }

            return Json(CategoryList);
        }

    }
}