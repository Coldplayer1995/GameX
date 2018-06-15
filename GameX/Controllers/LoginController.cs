using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameX.DAL;
using GameX.Infrastructure;
using GameX.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace GameX.Controllers
{
    public class LoginController : Controller
    {
        private readonly StoreContext context;
        private IUser UserManager { get; set; }

        public LoginController(StoreContext context)
        {
            this.UserManager = new UserManager(context);
            this.context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel User)
        {
            this.UserManager.Login(User);
            return RedirectToAction("Login");
        }

    }
}