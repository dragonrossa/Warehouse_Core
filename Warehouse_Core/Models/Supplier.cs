using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
    class Supplier:BaseComponent
    {
        public void AddNewItemToSupplier()
        {

            this._mediator.AddNewItem(this,"Supplier");

        }
    }
}
