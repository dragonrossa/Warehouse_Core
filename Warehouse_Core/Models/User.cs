﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Core.Context;

namespace Warehouse_Core.Models
{
    public class User : BaseComponent
    {
        public User()
        {

        }

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [RegularExpression(@"^[a-zA-Z.1-9 ]{2,80}$", ErrorMessage = "Address must have min 2 and max 80 letters")]
        public string Address { get; set; }

        [RegularExpression(@"^[a-zA-Z. ]{2,60}$", ErrorMessage = "Hometown must have min 2 and max 60 letters")]
        public string Hometown { get; set; }

        [RegularExpression(@"\d{5}$", ErrorMessage = "Zipcode has 5 digits")]
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }

        [RegularExpression(@"^[a-zA-Z.]{2,30}$", ErrorMessage = "Country must have min 2 and max 30 letters")]
        public string Country { get; set; }

        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@" + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "This is not valid email address!")]
        public string Mail { get; set; }

        [RegularExpression(@"\d{9,10}$", ErrorMessage = "Telephone number can have 9 or 10 digits")]
        public string Telephone { get; set; }

        [Display(Name = "Date modified")]
        public DateTime? DateModified { get; set; }

        //public IEnumerable<UserModels> users { get; set; }

        //PagedList
        //public IPagedList<UserModels> userAccess { get; set; }


        //public void AddNewItemToUser()
        //{
        //    this._mediator.AddNewItem(this,"User");

        //}

        public User Add(User user, WarehouseContext _context)
        {
            this._mediator.NewUser(user, _context);
            return user;
        }
    }
}
