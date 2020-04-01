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
    public class WalletController : ApiController
    {
        private ApplicationDbContext _context;
        public WalletController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        [ActionName("WalletList")]
        public IHttpActionResult GetWallet()
        {
            var Wallet = _context.walletDetails.Include(w => w.WalletName);
            var walletList = Wallet.ToList();
            return Ok(walletList);
        }

        [HttpPost]
        [ActionName("AddWallet")]
        public IHttpActionResult createWallet(WalletDetails wallwetdetail)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            wallwetdetail.registerId = 1;
            _context.walletDetails.Add(wallwetdetail);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + wallwetdetail.Id), wallwetdetail);
        }
    }
}
