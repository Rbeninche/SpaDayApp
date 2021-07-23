using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Add()
        {
            return View();
        }


        [HttpPost("/User")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {

            if (newUser.Password == verify)
            {

                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                ViewBag.dateCreated = newUser.DateCreated;
                return View("Index");
            }
            else
            {

                ViewBag.error = "Password does not match";
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                ViewBag.password = newUser.Password;





                return View("Add");

            }




        }
    }
}
