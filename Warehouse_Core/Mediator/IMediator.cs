using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse_Core.Context;
using Warehouse_Core.Models;

namespace Warehouse_Core.Mediator
{
   
      public interface IMediator
        {
        object AddNewItem(object item, string type);
        //Add new user
        User NewUser(User user, WarehouseContext _context);
    }
    
}
