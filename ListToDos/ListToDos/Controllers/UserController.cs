using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListToDos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ListToDos.Controllers
{
    [Route("")]
    [Route("user")]
    public class UserController : Controller
    {
        private TodoContext db;

        public UserController(TodoContext db)
        {
            this.db = db;
        }

        [Route("")]
        [Route("sign-in")]
        public IActionResult SignIn()
        {
            return View();
        }

        [Route("add-user")]
        public void AddUser(string email, string password)
        {
            db.Users.Add(new User
            {
                Email = email,
                Password = password
            });
        }
    }
}