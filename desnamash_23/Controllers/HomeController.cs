using desnamash_23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace desnamash_23.Controllers
{
    public class HomeController : Controller
    {
        UserContactsContext db;
        public HomeController(UserContactsContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitContact(UserContact userContact)
        {
            db.UserContacts.Add(userContact);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
