using System;
using System.Threading.Tasks;
using Func2Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace Func2Test.Controllers
{

    public class DefaultController : Controller
    {
        
        // GET: OutboundClaims/Create
        public async Task<IActionResult> Create(string contractCode, string messageId)
        {
            return View();
        }

        // POST: OutboundClaims/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Func2ViewModel newMessage)
        {
            //var outboundClaim = outboundClaimViewModel.OutboundClaim;


            return View();
        }
    }
}
