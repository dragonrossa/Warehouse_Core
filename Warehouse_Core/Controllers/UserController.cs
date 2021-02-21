using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Core.Context;
using Warehouse_Core.Mediator;
using Warehouse_Core.Models;

namespace Warehouse_Core.Controllers
{
    public class UserController : Controller
    {
        CallMediator objects = new CallMediator();


        //DB Context - via constructor

        private readonly WarehouseContext _context;

        public UserController(WarehouseContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("user/create")]
        public IActionResult CreateUser([FromBody] User user)
        {
            new ConcreteMediator(objects.component1,
                               objects.component2,
                               objects.component3,
                               objects.component4,
                               objects.component5,
                               objects.component6,
                               objects.component7,
                               objects.component8,
                               objects.component9,
                               objects.component10);

            //objects.component1.AddNewItemToAdmin();
            //objects.component2.AddNewItemToLog();
            //objects.component3.AddNewItemToProcurement();
            //objects.component4.AddNewItemToSearch();
            //objects.component5.AddNewItemToStorage();
            //objects.component6.AddNewItemToStore();
            //objects.component7.AddNewItemToSupplier();
            //objects.component8.AddNewItemToTask();
            //objects.component9.AddNewItemToTransfer();
            objects.component10.Add(user,_context);

            //user.DateModified = DateTime.Now;
            //_context.Users.Add(user);
            //_context.SaveChanges();


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
        public IActionResult UpdateUser([FromBody] User user)
        {
            return View();
        }

        [HttpDelete]
        [Route("user/delete")]
        public IActionResult DeleteUser([FromBody] User user)
        {
            return View();
        }


    }
}
