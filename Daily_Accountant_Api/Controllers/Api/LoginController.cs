using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Daily_Accountant_Api.Models;
using Daily_Accountant_Api.Models.Dto;
using System.Web;

namespace Daily_Accountant_Api.Controllers.Api
{
    public class LoginController : ApiController
    {
        private ApplicationDbContext _context;
        private Daily_Accountant_DbEntities DB;

        public LoginController()
        {
            _context = new ApplicationDbContext();
            DB = new Daily_Accountant_DbEntities();
        }

        [ActionName("UserDetails")]
        [HttpGet]
        public IHttpActionResult GetLoginData(int id)
        {
            var LoginDetails = _context.register.SingleOrDefault(u => u.Id == id);

            if (LoginDetails == null)
                return NotFound();
            HttpContext.Current.Session["User Id"] = LoginDetails.Id;
            return Ok(LoginDetails);
        }

        [ActionName("NewUser")]
        [HttpPost]
        public IHttpActionResult CreateNewUser(Register reg)
        {
            try
            {
                Register register = new Register();
                register.Mail = reg.Mail;
                register.UserName = reg.UserName;
                register.Password = reg.Password;
                DB.Registers.Add(register);
                DB.SaveChanges();
            }
            catch(Exception)
            {
                throw;
            }
            return Created(new Uri(Request.RequestUri + "/" + reg.Id), reg); 
          
        }

        [HttpPost]
        [ActionName("UserLogin")]
        public IHttpActionResult UserLogin(User user)
        {
            bool areValidCredentials = false;
            var log = DB.Registers.Where(x => x.Mail.Equals(user.Mail) &&
            x.Password.Equals(user.Password)).FirstOrDefault();

            if (log != null)
            {
                areValidCredentials = true;             
            }
            if (areValidCredentials)
            {
                return Ok(log.Id);
            }
                return Ok();                  
        }
    }
}
