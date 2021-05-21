using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prototype.Models;
using Prototype.Data;

namespace Prototype.Controllers
{
    public class Register : Controller
    {
        private readonly UserContext _context;
        public Register(UserContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            UsersModels model = new UsersModels();
            //ViewData["Message"] = "Hello " + name;
            //ViewData["Email"] = email;
            return View(model);
        }
        [HttpPost]
        public IActionResult AddPost(UsersModels model)
        {
            if (ModelState.IsValid)
            {
                _context.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
                return View(model);
        }
        

        
    }
}
