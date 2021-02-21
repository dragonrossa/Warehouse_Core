using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
    class Procurement:BaseComponent
    {
        public void AddNewItemToProcurement()
        {
            this._mediator.AddNewItem(this,"Procurement");
           
        }
    }
}
