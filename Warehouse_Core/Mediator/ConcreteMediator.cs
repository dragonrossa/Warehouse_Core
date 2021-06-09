using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Core.Context;
using Warehouse_Core.Models;

namespace Warehouse_Core.Mediator
{
    class ConcreteMediator : IMediator
    {
        private Admin _component1;

        private Log _component2;

        private Procurement _component3;

        private Search _component4;

        private Storage _component5;

        private Store _component6;

        private Supplier _component7;

        private Warehouse_Core.Models.Task _component8;

        private Transfer _component9;

        private User _component10;



        public ConcreteMediator(Admin component1, Log component2, Procurement component3,
            Search component4, Storage component5, Store component6, Supplier component7, Warehouse_Core.Models.Task component8,
            Transfer component9, User component10)
        {
            this._component1 = component1;
            this._component1.SetMediator(this);
            this._component2 = component2;
            this._component2.SetMediator(this);
            this._component3 = component3;
            this._component3.SetMediator(this);
            this._component4 = component4;
            this._component4.SetMediator(this);
            this._component5 = component5;
            this._component5.SetMediator(this);
            this._component6 = component6;
            this._component6.SetMediator(this);
            this._component7 = component7;
            this._component7.SetMediator(this);
            this._component8 = component8;
            this._component8.SetMediator(this);
            this._component9 = component9;
            this._component9.SetMediator(this);
            this._component10 = component10;
            this._component10.SetMediator(this);
        }



        public object AddNewItem(object item, string type)
        {


            if (type == "Admin")
            {
                this._component1.AddNewItemToAdmin();
            }
            if (type == "Log")
            {
                this._component2.AddNewItemToLog();
            }
            if (type == "Procurement")
            {
                this._component3.AddNewItemToProcurement();
            }
            if (type == "Search")
            {
                this._component4.AddNewItemToSearch();
            }
            if (type == "Storage")
            {
                this._component5.AddNewItemToStorage();
            }
            if (type == "Store")
            {
                this._component6.AddNewItemToStore();
            }
            if (type == "Supplier")
            {
                this._component7.AddNewItemToSupplier();
            }
            if (type == "Task")
            {
                this._component8.AddNewItemToTask();
            }
            if (type == "Transfer")
            {
                this._component9.AddNewItemToTransfer();
            }
            if (type == "User")
            {
                // this._component10.AddNewItemToUser();
                var a = "Ovo je user";
                return item;

            }
            return item;

        }

        public User NewUser(User user, WarehouseContext _context)
        {
            //check if user data is valid - if yes then save

            if (user.Name == null || user.LastName == null || user.UserName == null || user.Address == null ||
                user.Hometown == null || user.ZipCode == null || user.Country == null || user.Mail == null || user.Telephone == null )
            {
                throw new UserNotFoundException();
            }

            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

    }
}
