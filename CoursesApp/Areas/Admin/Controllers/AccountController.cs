
using CoursesApp.Areas.Admin.Models;
using CoursesApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoursesApp.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel LoginInfo)
        {
            var adminService = new AdminService();
            var IsLoggedIn = adminService.Login(LoginInfo.Email, LoginInfo.password);
            if (IsLoggedIn)
            {
                return RedirectToAction("Index","Default");
            }
            else
            {
                LoginInfo.Message = "Email or Password Is not Correct !";
                return View(LoginInfo); 
            }
            return View();
        }
    }
}