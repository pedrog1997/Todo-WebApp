using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListToDos.Controllers
{
    [Route("")]
    [Route("user")]
    public class UserController : Controller
    {
        [Route("")]
        [Route("sign-in")]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}