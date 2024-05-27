﻿using Microsoft.AspNetCore.Mvc;
using RiaanCarelse_ST10065550_POEPart1.Models;

namespace RiaanCarelse_ST10065550_POEPart1.Controllers
{
    public class UserController : Controller
    {

        public userTable usrtbl = new userTable();



        [HttpPost]
        public ActionResult About(userTable Users)
        {
            var result = usrtbl.insert_User(Users);
            return RedirectToAction("Privacy", "Home");
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(usrtbl);
        }


    }
}
