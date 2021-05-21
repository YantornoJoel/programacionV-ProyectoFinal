using Microsoft.AspNetCore.Mvc;
using Prototype.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prototype.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserContext _context;
        public LoginController(UserContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {

            var user = _context.Users.FirstOrDefault(e => e.Email == email && e.Password == password);

            if (user != null)
            {
                return RedirectToAction("Privacy", "Home");

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }
    }

}
