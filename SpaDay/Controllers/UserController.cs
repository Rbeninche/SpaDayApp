using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;
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
            AddUserViewModel addUserViewModel = new AddUserViewModel();
            return View(addUserViewModel);
        }


        [HttpPost("/User")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {

            if (ModelState.IsValid)
            {
                
                    User newUser = new User
                    {
                        Username = addUserViewModel.Username,
                        Email = addUserViewModel.Email,
                        Password = addUserViewModel.Password
                    };
                    return View("Index", newUser);
                }
            return View("Add", addUserViewModel);

        }

            

        }




        }
    