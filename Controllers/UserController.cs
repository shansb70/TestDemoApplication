using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        //[HttpPost]
        public IActionResult CreateUser(UserDetail userDetail)
        {
            Repository.Create(userDetail);

       
            return View();
        }
    }
}
