using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Daily_Accountant_Api.Models;
using Daily_Accountant_Api.Models.Dto;

namespace Daily_Accountant_Api.Controllers.Api
{
    public class LoginController : ApiController
    {
        private ApplicationDbContext _context;

        public LoginController()
        {
            _context = new ApplicationDbContext();
        }
        public IHttpActionResult UserValidation(UserDto userDto)
        {
            //var user = _context.Users.Select<>;
            //if(userDto.Password == user.Password && ) 
 
            return Ok();
        }

        [ActionName("NewUser")]
        [HttpPost]
        public IHttpActionResult CreateNewUser(User register)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.register.Add(register);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + register.Id), register);
        }
    }
}
