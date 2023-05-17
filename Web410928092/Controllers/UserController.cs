using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410928092.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult SignUp()
        {
            return View();
        }
        public ActionResult SignUp(string name, string account, string password)
        {
            if (name.IsNullOrWhiteSpace())
            { 
                ViewBag.NameMessage = "請輸入姓名";
            }
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            {
                ViewBag.NameMessage = "請輸入姓名";
            }
            
            return View();
        }
    }
}