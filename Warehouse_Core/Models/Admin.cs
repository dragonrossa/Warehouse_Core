using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
    class Admin:BaseComponent
    {
        public void AddNewItemToAdmin()
        {
        
            this._mediator.AddNewItem(this,"Admin");

        }
    }
}
