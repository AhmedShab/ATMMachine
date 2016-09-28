using AutomatedTellerMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class TransectionController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Transection/Deposit
        [Authorize]
        public ActionResult Deposit(int checkingAccountId)
        {
            return View();
        }

        // POST: Transection/Deposit
        [HttpPost]
        public ActionResult Deposit(Transection transection)
        {
            if (ModelState.IsValid)
            {
                db.Transections.Add(transection);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");

            }
            return View();
        }
    }
}
