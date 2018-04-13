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

        [Route("adduser1")]
        public void AddUser()
        {
            db.Users.Add(new User
            {
                Email = "pedro_0797@hotmail.com",
                Password = "pass123"
            });
            db.SaveChanges();
        }

        [Route("adduser2")]
        public void AddUser2()
        {
            db.Users.Add(new User
            {
                Email = "pedrogmez5@gmail.com",
                Password = "pass123"
            });
            db.SaveChanges();
        }
    }
}