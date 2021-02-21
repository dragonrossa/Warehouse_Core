using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Core.Models
{
    class Transfer:BaseComponent
    {
        public void AddNewItemToTransfer()
        {

            this._mediator.AddNewItem(this, "Transfer");

        }
    }
}
