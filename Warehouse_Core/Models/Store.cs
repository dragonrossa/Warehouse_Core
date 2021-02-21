using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
    class Store:BaseComponent
    {
        public void AddNewItemToStore()
        {

            this._mediator.AddNewItem(this, "Store");

        }
    }
}
