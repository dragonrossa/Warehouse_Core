using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Core.Models;

namespace Warehouse_Core.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        [Route("user/create")]
        public IActionResult CreateUser([FromBody] User user)
        {
            return View();
        }

        [HttpGet]
        [Route("user/list")]
        public IActionResult ListUsers()
        {
            return View();
        }

        [HttpPut]
        [Route("user/update")]
        public IActionResult UpdateUser()
        {
            return View();
        }

        [HttpDelete]
        [Route("user/delete")]
        public IActionResult DeleteUser()
        {
            return View();
        }


    }
}
